using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Devart.Data;
using Devart.Data.MySql;
using DbSpaContext;

namespace SpaClassLibrary
{
    public class C_Account
    {
        UserManager mh = new UserManager();
        //Lấy ID Tài khoản

        public int GetIDAccount(string pUserName)
        {
            DataTable tb = new DataTable();
            SqlDataAdapter dt = new SqlDataAdapter("select * from ACCOUNT a where a.USERNAME ='" + pUserName + "'", Properties.Settings.Default.DB_SPAConnectionString);
            dt.Fill(tb);
            return Int32.Parse(tb.Rows[0][0].ToString());
        }
        //Max ID_USER
        public int GetIDMax()
        {
            DataTable tb = new DataTable();
            SqlDataAdapter dt = new SqlDataAdapter("select MAX(ID_USER) from ACCOUNT", Properties.Settings.Default.DB_SPAConnectionString);
            dt.Fill(tb);
            return Int32.Parse(tb.Rows[0][0].ToString());
        }

        //Kiểm tra tài khoản có tồn tại chưa
        public int IsAccount(string pUserName)
        {
            DataTable tb = new DataTable();
            SqlDataAdapter dt = new SqlDataAdapter("select USERNAME from ACCOUNT a where USERNAME = N'" + pUserName + "'", Properties.Settings.Default.DB_SPAConnectionString);
            dt.Fill(tb);
            return tb.Rows.Count;
        }

        //Kiểm tra tài khoản có tồn tại chưa MySQL
        public int IsUserMySQL(string pUserName)
        {
            DataTable tb = new DataTable();
            MySqlDataAdapter dt = new MySqlDataAdapter("select * from user where USER_NAME = '" + pUserName + "'", Properties.Settings.Default.DbSpaDataContextConnectionString);
            dt.Fill(tb);
            return tb.Rows.Count;
        }

        //Thêm tài khoản
        public int InsertAccount(string pUserName, string pPass)
        {
            if (IsAccount(pUserName) == 0)
            {
                DC_CustomerDataContext account = new DC_CustomerDataContext();

                ACCOUNT temp = new ACCOUNT();
                temp.ID_USER = GetIDMax() + 1;
                temp.USERNAME = pUserName;
                temp.PASSWORD = mh.EncodePass(pPass);
                temp.STATUS = 0;

                account.ACCOUNTs.InsertOnSubmit(temp);
                account.SubmitChanges();
                return GetIDMax();//Cho thêm tài khoản, trả về ID_USER mới vừa thêm
            }
            else
            {
                return 0;//Khách hàng đã tạo tài khoản
            }
        }

        //Thêm tài khoản MYSQL
        public int InsertUserMySQL(string pUserName, string pPass)
        {
            if (IsUserMySQL(pUserName) == 0)
            {
                DbSpaDataContext acc = new DbSpaDataContext();

                DbSpaContext.User t = new User();
                t.USERNAME = pUserName;
                t.PASSWORD = mh.EncodePass(pPass);
                t.STATUS = 1;
                acc.Users.InsertOnSubmit(t);
                acc.SubmitChanges();
                return 1;//Cho thêm tài khoản, trả về ID_USER mới vừa thêm
            }
            else
            {
                return 0;//Khách hàng đã tạo tài khoản
            }
        }

        //Xóa tài khoản,Tại đây thực chất cho khóa tài khoản đồng nghĩa với việc dữ liệu tk vẫn còn
        public int DeleteAccount(string pUserName)
        {
            if (IsAccount(pUserName) == 1)
            {
                DC_CustomerDataContext account = new DC_CustomerDataContext();
                var query = from acc in account.ACCOUNTs
                            where acc.USERNAME.ToString().Equals(pUserName) == true
                            select acc;
                foreach (ACCOUNT item in query)
                {
                    item.STATUS = 0;
                }
                account.SubmitChanges();
                return 1;//Tài khoản bị khóa đồng nghĩa việc xóa tài khoản
            }
            else
            {
                return 0;//Không tồn tại tài khoản
            }
        }

        //MySQL Xóa tài khoản,Tại đây thực chất cho khóa tài khoản đồng nghĩa với việc dữ liệu tk vẫn còn
        public int DeleteUserMySQL(string pUserName)
        {
            if (IsUserMySQL(pUserName) == 1)
            {
                // DC_CustomerDataContext account = new DC_CustomerDataContext();
                DbSpaDataContext account = new DbSpaDataContext();
                var query = from acc in account.Users
                            where acc.USERNAME.ToString().Equals(pUserName) == true
                            select acc;
                foreach (User item in query)
                {
                    item.STATUS = 0;
                }
                account.SubmitChanges();
                return 1;//Tài khoản bị khóa đồng nghĩa việc xóa tài khoản
            }
            else
            {
                return 0;//Không tồn tại tài khoản
            }
        }

        //Đổi mật khẩu
        public bool ChangePass(string pUserName, string pPassNew, string pPassOld)
        {
            try
            {
                DC_CustomerDataContext dc = new DC_CustomerDataContext();
                var query = from acc in dc.ACCOUNTs
                            where string.Equals(acc.USERNAME, pUserName) == true
                            select acc;

                foreach (ACCOUNT item in query)
                {
                    if (string.Equals(item.PASSWORD, mh.EncodePass(pPassOld)))
                    {
                        item.PASSWORD = mh.EncodePass(pPassNew);
                    }
                    else
                    {
                        return false;
                    }
                }
                dc.SubmitChanges();
                return true;//Cap nhat thanh cong
            }
            catch
            {
                return false;
            }
        }
        //Đổi mật khẩu MySQL
        public bool ChangePassMySQL(string pUserName, string pPassNew, string pPassOld)
        {
            try
            {
                DbSpaDataContext dc = new DbSpaDataContext();
                User us = dc.Users.Where(t => t.USERNAME == pUserName).FirstOrDefault();

                if (us.PASSWORD == mh.EncodePass(pPassOld))
                {
                    us.PASSWORD = mh.EncodePass(pPassNew);
                }
                else
                {
                    return false;
                }
                dc.SubmitChanges();
                return true;//Cap nhat thanh cong
            }
            catch
            {
                return false;
            }
        }
    }
}
