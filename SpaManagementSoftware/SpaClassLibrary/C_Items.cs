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
        //Load san pham custom theo id
        public DataTable GetListItemFull_ToIdItem(String pIdItem)
        {
            DataTable dt = new DataTable();
            string mysql = "SELECT g.NAME_GROUP,i.ID,i.ID_GROUP,i.ID_UNIT,i.NAME,u.NAME AS NAME_UNIT,i.PRICE_OUT,i.PRICE_IN,i.ROSE,i.ROSE_RATE FROM group_item g,item i,unit_item u WHERE g.ID=i.ID_GROUP AND u.ID=i.ID_UNIT AND i.ID='" + pIdItem + "'";
            MySqlDataAdapter da = new MySqlDataAdapter(mysql, Properties.Settings.Default.DbSpaDataContextConnectionString);
            da.Fill(dt);
            return dt;
        }

        //Load noi dung mat hang co nhung vat tu gi
        public DataTable GetListContentItem_toId(string pIdItem)
        {
            DataTable dt = new DataTable();
            string sql = "SELECT t.ID_ITEM_CONTENT AS ID,it.NAME AS NAME_ITEM,t.NAME_UNIT,t.NUMBER FROM (SELECT i.ID,ct.ID_ITEM_CONTENT,ui.NAME AS NAME_UNIT,ct.NUMBER FROM item i,content_item ct,unit_item ui WHERE i.ID=ct.ID_ITEM AND i.ID_UNIT=ui.ID AND i.ID = '" + pIdItem + "') AS t, item it WHERE t.ID_ITEM_CONTENT = it.ID";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, Properties.Settings.Default.DbSpaDataContextConnectionString);
            da.Fill(dt);
            return dt;
        }

        //Load san pham custom
        public DataTable GetTableItemsFullMySQL()
        {
            DataTable dt = new DataTable();
            string sql = "SELECT i.ID,i.ID_GROUP,i.ID_UNIT,i.NAME,u.NAME AS NAME_UNIT,i.PRICE_OUT,i.PRICE_IN,i.ROSE,i.ROSE_RATE FROM group_item g,item i,unit_item u WHERE g.ID=i.ID_GROUP AND u.ID=i.ID_UNIT";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, Properties.Settings.Default.DbSpaDataContextConnectionString);
            da.Fill(dt);
            return dt;
        }

        //Load item tung nhom san pham custom
        public DataTable GetListItemFull_ForGroup(String pNameGroup)
        {
            DataTable dt = new DataTable();
            string mysql = "SELECT i.ID,i.ID_GROUP,i.ID_UNIT,i.NAME,u.NAME AS NAME_UNIT,i.PRICE_OUT,i.PRICE_IN,i.ROSE,i.ROSE_RATE FROM group_item g,item i,unit_item u WHERE g.ID=i.ID_GROUP AND u.ID=i.ID_UNIT AND i.ID_GROUP='" + GetIdGroupItemMySQL(pNameGroup) + "'";
            MySqlDataAdapter da = new MySqlDataAdapter(mysql, Properties.Settings.Default.DbSpaDataContextConnectionString);
            da.Fill(dt);
            return dt;
        }
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

        //Load san pham theo ten
        public DataTable GetTableItemsMySQL_ToName(string pNameItem)
        {
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT i.ID,i.NAME AS NAME_ITEM,i.PRICE_IN,u.NAME AS NAME_UNIT FROM item i, unit_item u WHERE i.NAME LIKE '%" + pNameItem + "%'", Properties.Settings.Default.DbSpaDataContextConnectionString);
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
            string sql = "SELECT dt.ID_ENTER_COUPON,dt.ID_ITEM,i.NAME AS NAME_ITEM,dt.NUMBER,i.PRICE_IN,dt.INTO_MONEY FROM detail_enter_coupon dt,item i WHERE dt.ID_ENTER_COUPON = '" + pIdEnter + "' AND dt.ID_ITEM=i.ID and dt.`STATUS`=1";
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

        //public int GetNumberDT(string pIdItem,string pIdenter)
        //{
        //    DataTable dt = new DataTable();
        //    MySqlDataAdapter da = new MySqlDataAdapter("SELECT NUMBER FROM detail_enter_coupon WHERE ID_ITEM='"+pIdItem+"' AND ID_ENTER_COUPON ='"+pIdenter+"'", Properties.Settings.Default.DbSpaDataContextConnectionString);
        //    da.Fill(dt);
        //    return int.Parse(dt.Rows[0][0].ToString());
        //}

        //Cap nhat Chi tiet phieu nhap,kho
        public int UpdateDtEnterCoupon(string pIdEnter, string pIdItem, string pNumber, string pPriceIn, string pMoney)
        {
            try
            {
                DetailEnterCoupon check = db.DetailEnterCoupons.Where(t => t.IDENTERCOUPON == int.Parse(pIdEnter) && t.IDITEM == int.Parse(pIdItem)).FirstOrDefault();
                if (check != null)
                {
                    int? numchange = int.Parse(pNumber) - check.NUMBER;
                    check.IDENTERCOUPON = int.Parse(pIdEnter);
                    check.IDITEM = int.Parse(pIdItem);
                    check.NUMBER = int.Parse(pNumber);
                    check.PRICEIN = float.Parse(pPriceIn);
                    check.INTOMONEY = float.Parse(pMoney);
                    check.STATUS = 1;
                    //Tồn tại thì cập nhật => Cap nhat so luong kho
                    UpdateNumberItemTerminal(pIdItem, numchange.ToString());
                    db.SubmitChanges();
                    return 1;
                }
                else
                {
                    InsertOneDtailItem(pIdEnter, pIdItem, pNumber, pPriceIn, pMoney);
                    UpdateNumberItemTerminal(pIdItem, pNumber);
                    return 2;//Chưa tồn tại thì thêm => Them so luong kho
                }
            }
            catch
            {
                return 0;
            }
        }

        //Xoa chi tiet phieu nhap theo phieu nhap(chi cap nhat status)
        public bool DeleteDtEnterCoupon(string pIdEnter, string pIdItem)
        {
            try
            {
                DetailEnterCoupon dt = db.DetailEnterCoupons.Where(t => t.IDENTERCOUPON == int.Parse(pIdEnter) && t.IDITEM == int.Parse(pIdItem)).FirstOrDefault();
                dt.STATUS = 0;
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        //Xoa hoan toan chi tiet phieu nhap
        public bool DeleteDetailEC(string pIdEnter, string pIdItem, string pNumber)
        {
            try
            {
                DetailEnterCoupon check = db.DetailEnterCoupons.Where(t => t.IDENTERCOUPON == int.Parse(pIdEnter) && t.IDITEM == int.Parse(pIdItem)).FirstOrDefault();
                if (check != null)
                {
                    //Tồn tại thì cập nhật => Cap nhat so luong kho
                    Item update = db.Items.Where(t => t.ID == int.Parse(pIdItem)).FirstOrDefault();
                    update.NUMBER = update.NUMBER - int.Parse(pNumber);
                    db.DetailEnterCoupons.DeleteOnSubmit(check);
                    db.SubmitChanges();
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
    }
}
