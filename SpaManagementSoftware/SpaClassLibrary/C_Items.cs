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
        //dem so luong mat hang
        public string CountIdItem()
        {
            return db.Items.Select(t => t).Count().ToString();
        }
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
            string sql = "SELECT i.ID,i.ID_GROUP,i.ID_UNIT,i.NAME,u.NAME AS NAME_UNIT,i.PRICE_OUT,i.PRICE_IN,i.ROSE,i.ROSE_RATE FROM group_item g,item i,unit_item u WHERE g.ID=i.ID_GROUP AND u.ID=i.ID_UNIT AND i.STATUS='1'";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, Properties.Settings.Default.DbSpaDataContextConnectionString);
            da.Fill(dt);
            return dt;
        }

        //Load item tung nhom san pham custom
        public DataTable GetListItemFull_ForGroup(String pNameGroup)
        {
            DataTable dt = new DataTable();
            string mysql = "SELECT i.ID,i.ID_GROUP,i.ID_UNIT,i.NAME,u.NAME AS NAME_UNIT,i.PRICE_OUT,i.PRICE_IN,i.ROSE,i.ROSE_RATE FROM group_item g,item i,unit_item u WHERE g.ID=i.ID_GROUP AND u.ID=i.ID_UNIT AND i.ID_GROUP='" + GetIdGroupItemMySQL(pNameGroup) + "' AND i.STATUS='1'";
            MySqlDataAdapter da = new MySqlDataAdapter(mysql, Properties.Settings.Default.DbSpaDataContextConnectionString);
            da.Fill(dt);
            return dt;
        }
        //Load nhom san pham
        public DataTable GetTableTypeItemMySQL()
        {
            DataTable listType = new DataTable();
            MySqlDataAdapter dt = new MySqlDataAdapter("select NAME_GROUP from group_item WHERE `STATUS`=1", Properties.Settings.Default.DbSpaDataContextConnectionString);
            dt.Fill(listType);
            return listType;
        }
        //Load san pham
        public DataTable GetTableItemsMySQL()
        {
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT i.ID,i.NAME AS NAME_ITEM,i.PRICE_IN,u.NAME AS NAME_UNIT FROM item i, unit_item u WHERE i.ID_UNIT=u.ID", Properties.Settings.Default.DbSpaDataContextConnectionString);
            da.Fill(dt);
            return dt;
        }
        //Load san pham de ban
        public DataTable GetTableItemsMySQL_Sale()
        {
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT i.ID,i.NAME AS NAME_ITEM,u.NAME AS NAME_UNIT,i.PRICE_OUT FROM item i, unit_item u WHERE i.ID_UNIT=u.ID", Properties.Settings.Default.DbSpaDataContextConnectionString);
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

        //Load item tung nhom san pham de ban
        public DataTable GetListItem_ForGroup_Sale(String pNameGroup)
        {
            DataTable dt = new DataTable();
            string mysql = "SELECT i.ID,i.NAME AS NAME_ITEM,u.NAME AS NAME_UNIT ,i.PRICE_OUT FROM group_item g,item i,unit_item u WHERE g.ID=i.ID_GROUP AND u.ID=i.ID_UNIT AND i.ID_GROUP='" + GetIdGroupItemMySQL(pNameGroup) + "'";
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

        //Them mot mat hang
        public bool AddItems(string pIdItem, string pIdGroup, string pIdUnit, string pName, string pPriceOut, string pRose, string pRateRose)
        {
            try
            {
                Item check = db.Items.Where(t => t.ID == int.Parse(pIdItem)).FirstOrDefault();
                if (check != null)
                {
                    return false;//trung khoa chinh
                }
                else
                {
                    //them moi
                    Item add = new Item();
                    add.ID = int.Parse(pIdItem);
                    add.IDGROUP = int.Parse(pIdGroup);
                    add.IDUNIT = int.Parse(pIdUnit);
                    add.NAME = pName;
                    add.PRICEOUT = float.Parse(pPriceOut);
                    add.ROSE = float.Parse(pRose);
                    add.ROSERATE = float.Parse(pRateRose);
                    add.STATUS = 1;

                    db.Items.InsertOnSubmit(add);
                    db.SubmitChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        //Cap nhat mat hang
        public bool UpdateItems(string pIdItem, string pIdGroup, string pIdUnit, string pName, string pPriceOut, string pRose, string pRateRose)
        {
            try
            {
                Item check = db.Items.Where(t => t.ID == int.Parse(pIdItem)).FirstOrDefault();
                if (check != null)
                {
                    check.IDGROUP = int.Parse(pIdGroup);
                    check.IDUNIT = int.Parse(pIdUnit);
                    check.NAME = pName;
                    check.PRICEOUT = float.Parse(pPriceOut);
                    check.ROSE = float.Parse(pRose);
                    check.ROSERATE = float.Parse(pRateRose);

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

        //Xoa Mat Hang (Cap nhat lai status)
        public bool DeleteItems(string pIdItem)
        {
            try
            {
                Item check = db.Items.Where(t => t.ID == int.Parse(pIdItem)).FirstOrDefault();
                if (check != null)
                {
                    check.STATUS = 0;
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
        //them noi dung vat tu cua mat hang
        public bool AddContentItems(string pIdItem, string pIDitemCt, string pNum)
        {
            try
            {
                ContentItem check = db.ContentItems.Where(t => t.IDITEM == int.Parse(pIdItem) && t.IDITEMCONTENT == int.Parse(pIDitemCt)).FirstOrDefault();
                if (check != null)
                {
                    return false;
                }
                else
                {
                    ContentItem add = new ContentItem();
                    add.IDITEM = int.Parse(pIdItem);
                    add.IDITEMCONTENT = int.Parse(pIDitemCt);
                    add.NUMBER = int.Parse(pNum);

                    db.ContentItems.InsertOnSubmit(add);
                    db.SubmitChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        //Xoa noi dung vat tu cua mat hang
        public bool DeleteContentItems(string pIdItem, string pIDitemCt)
        {
            try
            {
                ContentItem check = db.ContentItems.Where(t => t.IDITEM == int.Parse(pIdItem) && t.IDITEMCONTENT == int.Parse(pIDitemCt)).FirstOrDefault();
                if (check != null)
                {
                    //Xoa
                    db.ContentItems.DeleteOnSubmit(check);
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

        //Cap nhat ContentItem
        public bool UpdateContentItems(string pIdItem, string pIDitemCt, string pNum)
        {
            try
            {
                ContentItem check = db.ContentItems.Where(t => t.IDITEM == int.Parse(pIdItem) && t.IDITEMCONTENT == int.Parse(pIDitemCt)).FirstOrDefault();
                if (check != null)
                {
                    check.NUMBER = int.Parse(pNum);
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
