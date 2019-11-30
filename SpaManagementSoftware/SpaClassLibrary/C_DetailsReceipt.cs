using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbSpaContext;
using System.Data;
using Devart.Data.MySql;

namespace SpaClassLibrary
{
    public class C_DetailsReceipt
    {
        DbSpaDataContext db = new DbSpaDataContext();
        //Load Chi tiet hoa don
        public DataTable GetDTReceipt(string pId)
        {
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM detail_receipt WHERE detail_receipt.ID_RECEIPT = '" + pId + "'", Properties.Settings.Default.DbSpaDataContextConnectionString);
            da.Fill(dt);
            return dt;
        }
        //Them mot chi tiet hoa don
        public bool AddDetailReceipt(string idReceipt, string idStaff, string idItem, string pSaleOff, string pNum, string pPriceOut, string pIntoMoney, string pStatus)
        {
            try
            {
                DetailReceipt add = new DetailReceipt();
                add.IDRECEIPT = int.Parse(idReceipt);
                add.IDSTAFF = int.Parse(idStaff);
                add.IDITEM = int.Parse(idItem);
                add.NUMBER = int.Parse(pNum);
                add.PRICEOUT = float.Parse(pPriceOut);
                add.INTOMONEY = float.Parse(pIntoMoney);
                add.SALEOFF = float.Parse(pSaleOff);
                add.STATUS = int.Parse(pStatus);

                db.DetailReceipts.InsertOnSubmit(add);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        //Xoa mot chi tiet hoa don
        public bool DeleteDetailReceipt(string idReceipt, string idStaff, string idItem)
        {
            try
            {
                DetailReceipt check = db.DetailReceipts.Where(t => t.IDRECEIPT == int.Parse(idReceipt) && t.IDSTAFF == int.Parse(idStaff) && t.IDITEM == int.Parse(idItem)).FirstOrDefault();
                if (check != null)
                {
                    db.DetailReceipts.DeleteOnSubmit(check);
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

        //Cap nhat chi tiet hoa don
        public bool UpdateDetailReceipt(string idReceipt, string idStaff, string idItem, string pSaleOff, string pNum, string pPriceOut, string pIntoMoney, string pStatus)
        {
            try
            {
                DetailReceipt check = db.DetailReceipts.Where(t => t.IDRECEIPT == int.Parse(idReceipt) && t.IDSTAFF == int.Parse(idStaff) && t.IDITEM == int.Parse(idItem)).FirstOrDefault();
                if (check != null)
                {
                    //Cap nhat
                    check.SALEOFF = float.Parse(pSaleOff);
                    check.NUMBER = int.Parse(pNum);
                    check.PRICEOUT = float.Parse(pPriceOut);
                    check.INTOMONEY = float.Parse(pIntoMoney);
                    check.STATUS = int.Parse(pStatus);

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
