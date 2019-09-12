using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaClassLibrary
{
    public class Account
    {
        public Boolean isAccount(string userName, string pass)
        {
            LoginDataClassesDataContext db = new LoginDataClassesDataContext();
            var check = from p in db.USERs
                        where p.USERNAME.ToString().CompareTo(userName) == 0 && p.PASSWORD.ToString().CompareTo(pass) == 0
                        select p;
            if (check.Any())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
