using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbSpaContext;

namespace SpaClassLibrary
{
    public class C_Staff_User
    {
        DbSpaDataContext db = new DbSpaDataContext();
        //Lay id chi nhanh cua user dang su dung phan mem
        public string GetIdBranch_User(string userName)
        {
            UserStaff check = db.UserStaffs.Where(t => t.USERNAME.Equals(userName)).FirstOrDefault();
            if (check != null)
            {
                return check.IDBRANCH.ToString();
            }
            else
            {
                return null;
            }
        }
    }
}
