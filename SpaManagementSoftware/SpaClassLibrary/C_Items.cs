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
        DbSpaDataContext db = new DbSpaDataContext();
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
        //Load items theo so phieu
        public DataTable GetListItem_IdEnter(string pIdEnter)
        {
            DataTable dt = new DataTable();
            string sql = "SELECT i.NAME AS NAME_ITEM,dt.NUMBER,i.PRICE_IN,dt.INTO_MONEY FROM detail_enter_coupon dt,item i WHERE dt.ID_ENTER_COUPON = '" + pIdEnter + "' AND dt.ID_ITEM=i.ID";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, Properties.Settings.Default.DbSpaDataContextConnectionString);
            da.Fill(dt);
            return dt;
        }
        //Load items theo so phieu co don vi tinh
        public DataTable GetListDetail_IdEnter(string pIdEnter)
        {
            DataTable dt = new DataTable();
            string sql = "SELECT dt.ID_ITEM,i.NAME AS NAME_ITEM,u.NAME AS UNIT,dt.NUMBER,i.PRICE_IN,dt.INTO_MONEY FROM detail_enter_coupon dt,item i,unit_item u WHERE dt.ID_ENTER_COUPON = '" + pIdEnter + "' AND dt.ID_ITEM=i.ID AND u.ID=i.ID_UNIT";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, Properties.Settings.Default.DbSpaDataContextConnectionString);
            da.Fill(dt);
            return dt;
        }

        public int InsertOneDtailItem(string pIdEnter, string pIdItem, string pNumber, string pPriceIn, string pMoney)
        {
            try
            {
                //Đã kiểm tra trùng các mặt hàng trên GUI nên khi thêm ta không cần kiểm tra nửa.
                DetailEnterCoupon add = new DetailEnterCoupon();
                add.IDENTERCOUPON = int.Parse(pIdEnter);
                add.IDITEM = int.Parse(pIdItem);
                add.NUMBER = int.Parse(pNumber);
                add.PRICEIN = float.Parse(pPriceIn);
                add.INTOMONEY = float.Parse(pMoney);
                add.STATUS = 1;

                db.DetailEnterCoupons.InsertOnSubmit(add);
                db.SubmitChanges();
                return 1;//Them thanh cong
            }
            catch
            {
                return 0;
            }
        }

        public int UpdateNumberItemTerminal(string pIdItem, string pNumberIn)
        {
            try
            {
                //Vì nếu có sản phẩm thì lúc load dữ liệu để tạo 1 phiếu nhập, mặt đó đã tồn tại trong kho
                //Nên đến lúc này cập nhật lại số lượng trong kho không cần kiểm tra mặt hàng đó tồn tại chưa
                Item update = db.Items.Where(t => t.ID == int.Parse(pIdItem)).FirstOrDefault();
                update.NUMBER = update.NUMBER + int.Parse(pNumberIn);

                db.SubmitChanges();
                return 1;//Them thanh cong
            }
            catch
            {
                return 0;
            }
        }

        public int UpdateDtEnterCoupon(string pIdEnter, string pIdItem, string pNumber, string pPriceIn, string pMoney)
        {
            try
            {
                DetailEnterCoupon check = db.DetailEnterCoupons.Where(t => t.IDENTERCOUPON == int.Parse(pIdEnter) && t.IDITEM == int.Parse(pIdItem)).FirstOrDefault();
                if (check != null)
                {
                    check.IDENTERCOUPON = int.Parse(pIdEnter);
                    check.IDITEM = int.Parse(pIdItem);
                    check.NUMBER = int.Parse(pNumber);
                    check.PRICEIN = float.Parse(pPriceIn);
                    check.INTOMONEY = float.Parse(pMoney);
                    check.STATUS = 1;
                    db.SubmitChanges();
                    return 1;//Tồn tại thì cập nhật => Cap nhat so luong kho
                }
                else
                {
                    InsertOneDtailItem(pIdEnter, pIdItem, pNumber, pPriceIn, pMoney);
                    return 2;//Chưa tồn tại thì thêm => Them so luong kho
                }
            }
            catch
            {
                return 0;
            }
        }
    }
}
