using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.Sql;
using System.Security.Cryptography;
using Devart.Data;
using Devart.Data.MySql;
using DbSpaContext;

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
            if (Properties.Settings.Default.DB_SPAConnect == string.Empty)
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

        //Kiểm tra cấu hình MYSQL
        public int Check_ConfigMySQL()
        {
            if (Properties.Settings.Default.DbSpaDataContextConnectionString == string.Empty)
            {
                return 1;//Chuỗi cấu hình không tồn tại
            }
            MySqlConnection mysqlCon = new MySqlConnection(Properties.Settings.Default.DbSpaDataContextConnectionString);
            try
            {
                if (mysqlCon.State == ConnectionState.Closed)
                    mysqlCon.Open();
                return 0;//Kết nối thành công
            }
            catch
            {
                return 2;//Chuỗi cấu hình không phù hợp
            }
        }
        //Kiểm tra tài khoản, trả về số
        public int Check_User(string pUser, string pPass)
        {
            SqlDataAdapter daUser = new SqlDataAdapter("select * from ACCOUNT where USERNAME='" + pUser + "' and PASSWORD ='" + pPass + "'", Properties.Settings.Default.DB_SPAConnect);
            DataTable dt = new DataTable();
            daUser.Fill(dt);
            if (dt.Rows.Count == 0)
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
        //Kiểm tra tài khoản, trả về số MySQL
        public int Check_UserMySQL(string pUser, string pPass)
        {
            MySqlDataAdapter daUser = new MySqlDataAdapter("SELECT * FROM user WHERE user.USER_NAME ='" + pUser + "' AND user.PASSWORD='" + pPass + "'", Properties.Settings.Default.DbSpaDataContextConnectionString);
            DataTable dt = new DataTable();
            daUser.Fill(dt);
            if (dt.Rows.Count == 0)
            {
                return 1;//Không tồn tại
            }
            else
            {
                if (dt.Rows[0][1] == null || dt.Rows[0][2].ToString() == "0")
                    return 2;//Không hoạt động
            }
            return 3;//Đăng nhập thành công
        }

        //Server Name
        public List<string> LoadServerName()
        {
            List<string> srvname = new List<string> { };
            string servername = "";
            DataTable sqlSource = SqlDataSourceEnumerator.Instance.GetDataSources();
            foreach (DataRow source in sqlSource.Rows)
            {
                string instanceName = source["InstanceName"].ToString();

                if (!string.IsNullOrEmpty(instanceName))
                {
                    servername = source["InstanceName"].ToString() + '\\' + source["ServerName"];
                }
                else
                {
                    servername = source["ServerName"].ToString();
                }
                srvname.Add(servername);
            }
            return srvname;
        }
        //Đọc tên Server
        public DataTable GetServerName()
        {
            SqlDataSourceEnumerator instance = SqlDataSourceEnumerator.Instance;
            System.Data.DataTable table = instance.GetDataSources();
            return table;
        }
        //Đọc tên Host
        public DataTable GetHost()
        {
            MySqlDataSourceEnumerator instance = MySqlDataSourceEnumerator.Instance;
            DataTable table = instance.GetDataSources();
            return table;
        }
        //Đọc danh sách database,đầu vào là tên sever, tên user, mật khẩu trả về danh sách database
        public List<string> GetDatabaseName(string pServerName, string pUser, string pPass)
        {
            List<string> list = new List<string>();
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select name from sys.databases",
                    "Data Source=" + pServerName + ";Initial Catalog=" + "master" + ";User ID=" + pUser + ";pwd=" + pPass + "");
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
        //MySQL Đọc danh sách database,đầu vào là tên sever, tên user, mật khẩu trả về danh sách database
        public List<string> GetDatabaseNameMySQL(string pHost, string pUser, string pPass, string pPort)
        {
            List<string> list = new List<string>();
            DataTable dt = new DataTable();
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT SCHEMA_NAME FROM information_schema.SCHEMATA", "User Id =" + pUser + ";Password=" + pPass + ";Port =" + pPort + "; Host =" + pHost + ";Database =information_schema; Persist Security Info = True; Character Set = utf8");
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
        public void ChangConnectionString(string pServerName, string pDataBase, string pUser, string pPass)
        {
            SpaClassLibrary.Properties.Settings.Default["DB_SPAConnect"] = "Data Source=" + pServerName + ";Initial Catalog=" + pDataBase + ";User ID=" + pUser + ";pwd=" + pPass + "";
            SpaClassLibrary.Properties.Settings.Default["DB_SPAConnectionString"] = "Data Source=" + pServerName + ";Initial Catalog=" + pDataBase + ";User ID=" + pUser + ";pwd=" + pPass + "";
            Properties.Settings.Default.Save();
        }

        //Lưu cấu hình MySQL
        public void ChangConnectionStringMySQL(string pHost, string pDataBase, string pUser, string pPort,string pPass)
        {
            SpaClassLibrary.Properties.Settings.Default["DbSpaDataContextConnectionString"] = "User Id=" + pUser + ";Password=" + pPass + ";Port=" + pPort + ";Host=" + pHost + ";Database=" + pDataBase + ";Persist Security Info=True;Character Set=UTF8";
            Properties.Settings.Default.Save();
        }

        //Lấy chuỗi cấu hình
        public string GetStringConfig()
        {
            return SpaClassLibrary.Properties.Settings.Default.DB_SPAConnect;
        }

        //Lấy chuỗi cấu hình MySQL
        public string GetStringConfigMySQL()
        {
            return SpaClassLibrary.Properties.Settings.Default.DbSpaDataContextConnectionString;
        }

        //Lấy danh sách nhóm người dùng của 1 tài khoản
        public List<string> GetListIdGroupUser(string pUserName)
        {
            try
            {
                C_Account acc = new C_Account();
                List<string> list = new List<string>();
                DataTable tb = new DataTable();
                SqlDataAdapter dt = new SqlDataAdapter("select ID_GROUP from USER_GROUP_USER where ID_USER='" + acc.GetIDAccount(pUserName) + "'", Properties.Settings.Default.DB_SPAConnectionString);
                dt.Fill(tb);
                foreach (System.Data.DataRow r in tb.Rows)
                {
                    foreach (System.Data.DataColumn c in tb.Columns)
                    {
                        list.Add(r[c].ToString());
                    }
                }
                return list;
            }
            catch
            {
                return null;
            }
        }
        //Lấy danh sách nhóm người dùng của 1 tài khoản MySQL
        public List<string> GetListIdGroupUserMySQL(string pUserName)
        {
            try
            {
                C_Account acc = new C_Account();
                List<string> list = new List<string>();
                DataTable tb = new DataTable();
                MySqlDataAdapter dt = new MySqlDataAdapter("SELECT ID_GROUP_USER FROM user_group_user WHERE USER_NAME='" + pUserName + "'", Properties.Settings.Default.DbSpaDataContextConnectionString);
                dt.Fill(tb);
                foreach (System.Data.DataRow r in tb.Rows)
                {
                    foreach (System.Data.DataColumn c in tb.Columns)
                    {
                        list.Add(r[c].ToString());
                    }
                }
                return list;
            }
            catch
            {
                return null;
            }
        }

        //Lấy danh sách màn hình
        public DataTable GetListScreen(string pID_GROUP)
        {
            try
            {
                DataTable tb = new DataTable();
                SqlDataAdapter dt = new SqlDataAdapter("select * from GRANT_RIGHT where ID_GROUP = '" + pID_GROUP + "'", Properties.Settings.Default.DB_SPAConnectionString);
                dt.Fill(tb);
                return tb;
            }
            catch
            {
                return null;
            }
        }

        //Lấy danh sách màn hình mySQL
        public DataTable GetListScreenMySQL(string pID_GROUP)
        {
            try
            {
                DataTable tb = new DataTable();
                MySqlDataAdapter dt = new MySqlDataAdapter("select * from grand_right WHERE ID_GROUP_USER='" + pID_GROUP + "'", Properties.Settings.Default.DbSpaDataContextConnectionString);
                dt.Fill(tb);
                return tb;
            }
            catch
            {
                return null;
            }
        }
        //Lấy số Lầu của CHi nhánh user đang làm
        public int GetNumberFloorMySQL(string pUserName)
        {
            try
            {
                MySqlDataAdapter q = new MySqlDataAdapter("SELECT COUNT(*) FROM branch b , area a WHERE b.ID=a.ID_BRACNH AND b.ID=(SELECT ID_BRANCH FROM user_staff WHERE USER_NAME='" + pUserName + "')", Properties.Settings.Default.DbSpaDataContextConnectionString);
                DataTable dt = new DataTable();
                q.Fill(dt);
                return Convert.ToInt32(dt.Rows[0][0].ToString());
            }
            catch
            {
                return 0;
            }
        }
        //Lấy số ghế ứng với từng khu vực
        public int GetNumberChairMySQL(string pIDArea)
        {
            try
            {
                DataTable dt = new DataTable();
                MySqlDataAdapter q = new MySqlDataAdapter("SELECT COUNT(*) FROM db_spa.area, db_spa.chair WHERE db_spa.area.ID = db_spa.chair.ID_AREA AND db_spa.chair.ID_AREA='" + pIDArea + "'", Properties.Settings.Default.DbSpaDataContextConnectionString);
                q.Fill(dt);
                return Convert.ToInt32(dt.Rows[0][0].ToString());
            }
            catch
            {
                return 0;
            }
        }
    }
}
