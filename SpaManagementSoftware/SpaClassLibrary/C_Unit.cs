using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Devart.Data.MySql;
using Devart.Data;
using System.Data;
using DbSpaContext;

namespace SpaClassLibrary
{
    public class C_Unit
    {
        DbSpaDataContext db = new DbSpaDataContext();
        //Load bang don vi tinh
        public List<UnitItem> GetDataUnit()
        {
            return db.UnitItems.Select(t => t).ToList();
        }
    }
}
