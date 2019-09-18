using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.Sql;

namespace SpaClassLibrary
{
    class UserManager
    {
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
        
        //Kiểm tra tài khoản
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
                if (dt.Rows[0][2] == null || dt.Rows[0][4].ToString() == "1")
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
       
        //Đọc danh sách database
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
    }
}
