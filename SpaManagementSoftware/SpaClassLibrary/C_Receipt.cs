using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbSpaContext;
using Devart.Data.MySql;
using System.Data;

namespace SpaClassLibrary
{
    public class C_Receipt
    {
        DbSpaDataContext db = new DbSpaDataContext();
        //Load id hoa don tuong ung cua ghe
        public Receipt GetReceipt(string pidReceipt)
        {
            return db.Receipts.Where(t => t.ID == int.Parse(pidReceipt)).FirstOrDefault();
        }
        //Thanh toan cap nhat loai hoa don
        public bool PayMent(string idReceipt)
        {
            try
            {
                Receipt check = db.Receipts.Where(t => t.ID == int.Parse(idReceipt)).FirstOrDefault();
                if(check != null)
                {
                    check.TYPERECEIPT = 2;
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
        //Lay tong tien cua hoa don bat ky
        public string GetMoneyReceipt(string idReceipt)
        {
            return db.Receipts.Where(t => t.ID == int.Parse(idReceipt)).FirstOrDefault().TOTALMONEY.ToString();
        }
        //Dem Id hoa don
        public string CountIdReceipt()
        {
            return db.Receipts.Count().ToString();
        }
        //Tạo hóa đơn rỗng chi tiết
        public bool CreateReceipt(string pId, string pIdChair, string pIdUser, string pidAccount, string pCreateDate, string pDateUse, string pType)
        {
            try
            {
                Receipt add = new Receipt();
                add.ID = int.Parse(pId);
                add.IDACCOUNT = int.Parse(pidAccount);
                add.IDCHAIR = int.Parse(pIdChair);
                add.IDUSER = pIdUser;
                add.CREATEDATE = Convert.ToDateTime(pCreateDate);
                add.USEDATE = Convert.ToDateTime(pDateUse);
                add.TYPERECEIPT = int.Parse(pType);
                add.TOTALMONEY = 0;
                add.STATUS = 1;

                db.Receipts.InsertOnSubmit(add);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        //Cap nhat so tien voi hoa don tuong ung
        public bool UpdateToTalReceipt(string pIdReceipt, string pToTal)
        {
            try
            {
                Receipt check = db.Receipts.Where(t => t.ID == int.Parse(pIdReceipt)).FirstOrDefault();
                if (check != null)
                {
                    check.TOTALMONEY = float.Parse(pToTal);
                    db.SubmitChanges();
                    return true;
                }
                else { return false; }
            }
            catch
            {
                return false;
            }
        }
    }
}
