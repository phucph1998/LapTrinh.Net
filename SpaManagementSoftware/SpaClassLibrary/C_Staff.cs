using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Devart.Data;
using Devart.Data.MySql;
using System.Data;

namespace SpaClassLibrary
{
    public class C_Staff
    {
        public DataTable LoadListStaff()
        {
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT ID,NAME FROM staff", Properties.Settings.Default.DbSpaDataContextConnectionString);
            da.Fill(dt);
            return dt;
        }

        //Load du lieu nhan vien vao combobox de chon voi dieu kien cung chi nhánh với user
        public DataTable LoadListStaff_SameBranch(string pUserName)
        {
            DataTable dt = new DataTable();
            string sql = "SELECT s.ID,s.NAME FROM user_staff us,staff s WHERE us.ID_STAFF=s.ID and us.ID_BRANCH=(SELECT ID_BRANCH FROM user_staff WHERE USER_NAME='"+ pUserName + "') AND us.`STATUS`=1";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, Properties.Settings.Default.DbSpaDataContextConnectionString);
            da.Fill(dt);
            return dt;
        }
    }
}
