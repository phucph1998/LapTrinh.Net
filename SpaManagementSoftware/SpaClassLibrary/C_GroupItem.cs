using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbSpaContext;
namespace SpaClassLibrary
{
    public class C_GroupItem
    {
        DbSpaDataContext db = new DbSpaDataContext();

        public List<GroupItem> GetDataGroupItem()
        {
            return db.GroupItems.Select(t => t).ToList();
        }
    }
}
