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
        //Load san pham
        public DataTable GetTableItemsMySQL()
        {
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT i.ID,i.NAME AS NAME_ITEM,i.PRICE_IN,u.NAME AS NAME_UNIT FROM item i, unit_item u", Properties.Settings.Default.DbSpaDataContextConnectionString);
            da.Fill(dt);
            return dt;
        }
        //Lay ma nhom 
        public String GetIdGroupItemMySQL(string pNameGroup)
        {
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT ID FROM group_item WHERE NAME_GROUP=N'" + pNameGroup + "'", Properties.Settings.Default.DbSpaDataContextConnectionString);
            da.Fill(dt);
            return dt.Rows[0][0].ToString();
        }

        //Load item tung nhom san pham
        public DataTable GetListItem_ForGroup(String pNameGroup)
        {
            DataTable dt = new DataTable();
            string mysql = "SELECT i.ID,i.NAME AS NAME_ITEM ,i.PRICE_IN,u.NAME AS NAME_UNIT FROM group_item g,item i,unit_item u WHERE g.ID=i.ID_GROUP AND u.ID=i.ID_UNIT AND i.ID_GROUP='" + GetIdGroupItemMySQL(pNameGroup) + "'";
            MySqlDataAdapter da = new MySqlDataAdapter(mysql, Properties.Settings.Default.DbSpaDataContextConnectionString);
            da.Fill(dt);
            return dt;
        }
    }
}
