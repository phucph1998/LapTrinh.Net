using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SpaClassLibrary
{
    public class C_Account
    {
        UserManager mh = new UserManager();
        //Max ID_USER
        public int GetIDMax()
        {
            DataTable tb = new DataTable();
            SqlDataAdapter dt = new SqlDataAdapter("select MAX(ID_USER) from ACCOUNT", Properties.Settings.Default.DB_SPAConnectionString);
            dt.Fill(tb);
            return Int32.Parse(tb.Rows[0][0].ToString());
        }

        //Kiểm tra tài khoản có tồn tại chưa
        public int IsAccountPhone(string pUserName)
        {
            DataTable tb = new DataTable();
            SqlDataAdapter dt = new SqlDataAdapter("select USERNAME from ACCOUNT a where USERNAME = N'" + pUserName + "'", Properties.Settings.Default.DB_SPAConnectionString);
            dt.Fill(tb);
            return tb.Rows.Count;
        }

        //Thêm tài khoản
        public int InsertAccount(string pUserName, string pPass)
        {
            if(IsAccountPhone(pUserName)==0)
            {
                DC_CustomerDataContext account = new DC_CustomerDataContext();

                ACCOUNT temp = new ACCOUNT();
                temp.ID_ROLE = 2;
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
    }
}
