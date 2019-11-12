using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Devart.Data;
using System.Data;
using Devart.Data.MySql;
using DbSpaContext;

namespace SpaClassLibrary
{
    public class C_Enter
    {
        DbSpaDataContext db = new DbSpaDataContext();
        //Lay ID max cua phieu nhap
        public int GetIdMaxEnterCoupon()
        {
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT COUNT(*) FROM enter_coupon", Properties.Settings.Default.DbSpaDataContextConnectionString);
            da.Fill(dt);
            return Convert.ToInt32(dt.Rows[0][0].ToString());
        }
        //Load du lieu phieu nhap
        public DataTable LoadListEnter()
        {
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT e.CREATE_DATE,e.ID,s.NAME,e.RESON_ENTER FROM enter_coupon e,staff s WHERE e.ID_STAFF = s.ID", Properties.Settings.Default.DbSpaDataContextConnectionString);
            da.Fill(dt);
            return dt;
        }
        //Load 1 phieu nhap
        public DataTable LoadEnterCoupon_Id(string pId)
        {
            DataTable dt = new DataTable();
            string sql = "SELECT e.CREATE_DATE,s.NAME AS NAME_SUP,e.RESON_ENTER,st.NAME AS NAME_STAFF FROM enter_coupon e, supplier s,staff st WHERE e.ID_SUPPLIER=s.ID AND st.ID=e.ID_STAFF AND e.ID='" + pId + "'";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, Properties.Settings.Default.DbSpaDataContextConnectionString);
            da.Fill(dt);
            return dt;
        }

        //Them mot phieu nhap
        public int InsertEnterCoupon(string pID, string pIdSup, string pIdStaff, string pUser, string pCreateDay, string pReson, string pTotal)
        {
            try
            {
                EnterCoupon check = db.EnterCoupons.Where(t => t.ID == Convert.ToInt32(pID)).FirstOrDefault();
                if (check != null)
                {
                    return 1;//Trung khoa chinh
                }
                else
                {
                    EnterCoupon add = new EnterCoupon();
                    add.ID = int.Parse(pID);
                    add.IDSUPPLIER = int.Parse(pIdSup);
                    add.IDSTAFF = int.Parse(pIdStaff);
                    add.IDUSER = pUser;
                    add.CREATEDATE = Convert.ToDateTime(pCreateDay);
                    add.RESONENTER = pReson;
                    add.TOTAL = float.Parse(pTotal);
                    add.STATUS = 1;

                    db.EnterCoupons.InsertOnSubmit(add);
                    db.SubmitChanges();
                    return 2;//them thanh cong
                }
            }
            catch
            {
                return 0;
            }
        }
    }
}
