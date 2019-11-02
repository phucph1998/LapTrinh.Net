using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Devart.Data.Linq;
using Devart.Data.MySql;
using Devart.Data;
using System.Data;
using DbSpaContext;

namespace SpaClassLibrary
{
    public class C_Role
    {
        DbSpaDataContext dc = new DbSpaDataContext();
        //Load danh sách người dùng
        public DataTable LoadTableUser()
        {
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM user WHERE STATUS='1'", Properties.Settings.Default.DbSpaDataContextConnectionString);
            da.Fill(dt);
            return dt;
        }
        //Load Nhóm người dùng
        public DataTable LoadNameGroupUser()
        {
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(" SELECT * FROM db_spa.group_user WHERE STATUS='1'", Properties.Settings.Default.DbSpaDataContextConnectionString);
            da.Fill(dt);
            return dt;
        }
        //Load danh sách phân nhóm người dùng
        public DataTable LoadTableUsGroupUs()
        {
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(" SELECT * FROM user_group_user WHERE STATUS='1'", Properties.Settings.Default.DbSpaDataContextConnectionString);
            da.Fill(dt);
            return dt;
        }
        //Load danh sách phân nhóm người dùng
        public DataTable LoadTableUsGroupUs_ID(int pIdGroup)
        {
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(" SELECT * FROM user_group_user WHERE STATUS='1' AND ID_GROUP_USER='" + pIdGroup + "'", Properties.Settings.Default.DbSpaDataContextConnectionString);
            da.Fill(dt);
            return dt;
        }
        //Load danh sách chức năng của nhóm tương ứng
        public DataTable LoadTableScreenOfGroupUs(string pIdGroupUser)
        {
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT screen.ID,screen.NAME,t.ROLE FROM (SELECT * from grand_right WHERE ID_GROUP_USER='" + pIdGroupUser + "') AS t RIGHT JOIN screen ON t.ID_SCREEN= screen.ID", Properties.Settings.Default.DbSpaDataContextConnectionString);
            da.Fill(dt);
            return dt;
        }
        //Check Mã màn hình và nhóm người dùng 
        public int CheckGrandRight(string pIdGroupUs, string pIdScreen)
        {
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT COUNT(*) FROM db_spa.grand_right WHERE ID_GROUP_USER='" + pIdGroupUs + "' AND ID_SCREEN='" + pIdScreen + "'", Properties.Settings.Default.DbSpaDataContextConnectionString);
            da.Fill(dt);
            return Convert.ToInt32(dt.Rows[0][0].ToString());
        }
        //Cập nhật lại quyền
        public bool UpdateRole(string pIdGroupUs, string pIdScreen, string pRole)
        {
            try
            {
                dc = new DbSpaDataContext();
                GrandRight gr = dc.GrandRights.Where(t => t.IDGROUPUSER == Convert.ToInt32(pIdGroupUs) && t.IDSCREEN == pIdScreen).FirstOrDefault();
                gr.ROLE = Convert.ToInt32(pRole);
                dc.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        //Thêm quyen
        public bool InsertRole(string pIdGroupUs, string pIdScreen, string pRole)
        {
            try
            {
                dc = new DbSpaDataContext();
                GrandRight gr = new GrandRight();
                gr.IDGROUPUSER = Convert.ToInt32(pIdGroupUs);
                gr.IDSCREEN = pIdScreen;
                gr.ROLE = Convert.ToInt32(pRole);
                dc.GrandRights.InsertOnSubmit(gr);
                dc.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        //Thêm người dùng vào nhóm
        public bool InsertUserToGroup(string pUserName, string pIdGroup)
        {
            try
            {
                dc = new DbSpaDataContext();
                var query = from us in dc.UserGroupUsers
                            where us.USERNAME == pUserName && us.IDGROUPUSER.Equals(pIdGroup)
                            select us;
                if (query != null)
                {
                    UserGroupUser us = new UserGroupUser();
                    us.USERNAME = pUserName;
                    us.IDGROUPUSER = Convert.ToInt32(pIdGroup);
                    us.STATUS = 1;
                    dc.UserGroupUsers.InsertOnSubmit(us);
                    dc.SubmitChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
        //Xóa người dùng khỏi nhóm
        public bool DeleteUserOutGroup(string pUserName, string pIdGroup)
        {
            try
            {
                dc = new DbSpaDataContext();
                UserGroupUser user = dc.UserGroupUsers.Where(t => t.USERNAME == pUserName && t.IDGROUPUSER == Convert.ToInt32(pIdGroup)).FirstOrDefault();
                dc.UserGroupUsers.DeleteOnSubmit(user);
                dc.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
