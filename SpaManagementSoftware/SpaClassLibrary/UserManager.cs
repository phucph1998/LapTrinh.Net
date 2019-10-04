using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.Sql;
using System.Security.Cryptography;

namespace SpaClassLibrary
{
    public class UserManager
    {

        //Mã hóa MD5
        public string EncodePass(string pPass)
        {
            MD5 encode = MD5.Create();

            //Chuyển chuỗi thành kiểu byte
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(pPass);

            //Mã hóa chuỗi đã chuyển
            byte[] hash = encode.ComputeHash(inputBytes);

            //tạo đối tượng StringBuilder
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                result.Append(hash[i].ToString("x"));
            }
            return result.ToString();
        }
        //Kiểm tra cấu hình
        public int Check_Config()
        {
            if(Properties.Settings.Default.DB_SPAConnect == string.Empty)
            {
                return 1;//Chuỗi cấu hình không tồn tại
            }
            SqlConnection sqlConn = new SqlConnection(Properties.Settings.Default.DB_SPAConnect); 
            try
            {
                if (sqlConn.State == System.Data.ConnectionState.Closed)
                    sqlConn.Open();
                return 0;//Kết nối thành công
            }
            catch
            {
                return 2;//Chuỗi cấu hình không phù hợp
            }  
        }
        
        //Kiểm tra tài khoản, trả về số
        public int Check_User(string pUser,string pPass)
        {
            SqlDataAdapter daUser = new SqlDataAdapter("select * from ACCOUNT where USERNAME='" + pUser + "' and PASSWORD ='" + pPass + "'", Properties.Settings.Default.DB_SPAConnect);
            DataTable dt = new DataTable();
            daUser.Fill(dt);
            if(dt.Rows.Count == 0)
            {
                return 1;//Không tồn tại
            }
            else
            {
                if (dt.Rows[0][2] == null || dt.Rows[0][3].ToString() == "0")
                    return 2;//Không hoạt động
            }
            return 3;//Đăng nhập thành công
        }

        //Đọc tên Server
        public DataTable GetServerName()
        {
            SqlDataSourceEnumerator instance = SqlDataSourceEnumerator.Instance;
            System.Data.DataTable table = instance.GetDataSources();
            return table;
        }
       
        //Đọc danh sách database,đầu vào là tên sever, tên user, mật khẩu trả về danh sách database
        public List<string> GetDatabaseName(string pServerName,string pUser,string pPass)
        {
            List<string> list = new List<string>();
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select name from sys.databases",
                    "Data Source="+pServerName+";Initial Catalog="+"master"+";User ID="+pUser+";pwd="+pPass+"");
                da.Fill(dt);
                foreach (System.Data.DataRow r in dt.Rows)
                {
                    foreach (System.Data.DataColumn c in dt.Columns)
                    {
                        list.Add(r[c].ToString());
                    }
                }
            }
            catch
            {
                return null;
            }
            return list;
        }

        //Lưu cấu hình
        public void ChangConnectionString(string pServerName,string pDataBase,string pUser,string pPass)
        {
            SpaClassLibrary.Properties.Settings.Default["DB_SPAConnect"] = "Data Source=" + pServerName + ";Initial Catalog=" +pDataBase+ ";User ID=" + pUser + ";pwd=" + pPass + "";
            SpaClassLibrary.Properties.Settings.Default["DB_SPAConnectionString"] = "Data Source=" + pServerName + ";Initial Catalog=" + pDataBase + ";User ID=" + pUser + ";pwd=" + pPass + "";
            Properties.Settings.Default.Save();
        }

        //Lấy chuỗi cấu hình
        public string GetStringConfig()
        {
            return SpaClassLibrary.Properties.Settings.Default.DB_SPAConnect;
        }
    }
}
