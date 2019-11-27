using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbSpaContext;

namespace SpaClassLibrary
{
    public class C_DetailsReceipt
    {
        DbSpaDataContext db = new DbSpaDataContext();
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
                return true;
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
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
