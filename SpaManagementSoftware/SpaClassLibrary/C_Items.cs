using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DbSpaContext;
using Devart.Data.MySql;
using Devart.Data;

namespace SpaClassLibrary
{
    public class C_Items
    {
        //Load nhom san pham
        public DataTable GetTableTypeItemMySQL()
        {
            DataTable listType = new DataTable();
            MySqlDataAdapter dt = new MySqlDataAdapter("select NAME_GROUP from group_item", Properties.Settings.Default.DbSpaDataContextConnectionString);
            dt.Fill(listType);
            return listType;
        }
    }
}
