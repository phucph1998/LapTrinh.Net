using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Devart.Data;
using Devart.Data.MySql;
using Devart.Data.Linq;
using System.Data;
using DbSpaContext;

namespace SpaClassLibrary
{
    public class C_Supplier
    {
        //Lay ma nhom nha cung cap
        public String GetIdGroupSupMySQL(string pNameGroup)
        {
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT ID FROM group_supplier WHERE NAME_GROUP=N'" + pNameGroup + "'", Properties.Settings.Default.DbSpaDataContextConnectionString);
            da.Fill(dt);
            return dt.Rows[0][0].ToString();
        }
        //Load bang nha cung cap theo nhom
        public DataTable GetListSupplier_ForGroup(String pNameGroup)
        {
            DataTable dt = new DataTable();
            string mysql = "SELECT s.ID,s.NAME,s.PHONE,s.EMAIL,s.ADDRESS,s.TAX_CODE,s.ID_GROUP FROM group_supplier g,supplier s WHERE g.ID=s.ID_GROUP AND s.ID_GROUP='" + GetIdGroupSupMySQL(pNameGroup) + "'";
            MySqlDataAdapter da = new MySqlDataAdapter(mysql, Properties.Settings.Default.DbSpaDataContextConnectionString);
            da.Fill(dt);
            return dt;
        }
        //Lay ten nhom nha cung cap
        public String GetNameGroupSupMySQL(string pIdgroup)
        {
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT NAME_GROUP FROM group_supplier WHERE ID='" + pIdgroup + "'", Properties.Settings.Default.DbSpaDataContextConnectionString);
            da.Fill(dt);
            return dt.Rows[0][0].ToString();
        }
        //Load nhom nha cung cap
        public DataTable GetTableTypeSupplierMySQL()
        {
            DataTable listType = new DataTable();
            MySqlDataAdapter dt = new MySqlDataAdapter("select NAME_GROUP from group_supplier", Properties.Settings.Default.DbSpaDataContextConnectionString);
            dt.Fill(listType);
            return listType;
        }
        //Danh sách tất cả khách hàng MYSQL
        public DataTable GetListSupplierMySQL()
        {
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT s.ID,s.NAME,s.PHONE,s.EMAIL,s.ADDRESS,s.TAX_CODE,s.ID_GROUP FROM group_supplier g,supplier s WHERE g.ID=s.ID_GROUP", Properties.Settings.Default.DbSpaDataContextConnectionString);
            da.Fill(dt);
            return dt;
        }
        //Kiểm tra nhóm nhà cung cấp trước khi thêm MYSQL
        public bool IsGroupSupplierMySQL(string pNameGroup)
        {
            DataTable check = new DataTable();
            MySqlDataAdapter dt = new MySqlDataAdapter("SELECT * FROM group_supplier WHERE group_supplier.NAME_GROUP='" + pNameGroup + "'", Properties.Settings.Default.DbSpaDataContextConnectionString);
            dt.Fill(check);
            if (check.Rows.Count > 0)
            {
                return false;//đã tồn tại nhóm khách hàng cần thêm
            }
            return true;//Cho phép thêm
        }
        //Lấy ID lớn nhấtMYSQL
        public int MaxIDTypeMySQL()
        {
            DataTable check = new DataTable();
            MySqlDataAdapter dt = new MySqlDataAdapter("SELECT COUNT(*) FROM group_supplier", Properties.Settings.Default.DbSpaDataContextConnectionString);
            dt.Fill(check);
            return Int32.Parse(check.Rows[0][0].ToString());
        }
        //Thêm nhóm khách hàng MYSQL
        public bool InsertGroupSupplierMySQL(string pNameGroup)
        {
            if (IsGroupSupplierMySQL(pNameGroup))
            {
                DbSpaDataContext db = new DbSpaDataContext();

                GroupSupplier t = new GroupSupplier();
                t.ID = MaxIDTypeMySQL() + 1;
                t.NAMEGROUP = pNameGroup;
                t.STATUS = 1;

                db.GroupSuppliers.InsertOnSubmit(t);
                db.SubmitChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
        //Kiểm tra nha cung cap ton tai chua MySQL
        public int IsSupplierMySQL(string pUserName)
        {
            DataTable tb = new DataTable();
            MySqlDataAdapter dt = new MySqlDataAdapter("SELECT s.NAME from supplier s WHERE s.NAME = N'" + pUserName + "'", Properties.Settings.Default.DbSpaDataContextConnectionString);
            dt.Fill(tb);
            return tb.Rows.Count;
        }

        //Max ID supplier MySQL
        public int GetIDMaxSupplierMySQL()
        {
            DataTable tb = new DataTable();
            MySqlDataAdapter dt = new MySqlDataAdapter("select count(*) from supplier", Properties.Settings.Default.DbSpaDataContextConnectionString);
            dt.Fill(tb);
            return Int32.Parse(tb.Rows[0][0].ToString());
        }
        //Them nha cung cap
        public int InsertSupplierMySQL(string pName, string pPhone, string pEmail, string pAddress, string pTaxcode, string pIdgroup)
        {
            if (IsSupplierMySQL(pName) != 0)
            {
                return 1;
            }
            else
            {
                try
                {
                    DbSpaDataContext db = new DbSpaDataContext();

                    Supplier sup = new Supplier();
                    sup.ID = GetIDMaxSupplierMySQL() + 1;
                    sup.NAME = pName;
                    sup.PHONE = pPhone;
                    sup.EMAIL = pEmail;
                    sup.ADDRESS = pAddress;
                    sup.TAXCODE = Convert.ToInt32(pTaxcode);
                    sup.IDGROUP = Convert.ToInt32(pIdgroup);

                    db.Suppliers.InsertOnSubmit(sup);
                    db.SubmitChanges();
                    return 2;
                }
                catch
                {
                    return 3;
                }
            }
        }
        //Cap nhat nha cung cap
        public bool UpdateSupplierMySQL(string pID, string pName, string pPhone, string pEmail, string pAddress, string pTaxcode, string pIdgroup)
        {
            try
            {
                DbSpaDataContext db = new DbSpaDataContext();

                Supplier sup = db.Suppliers.Where(t => t.ID == Convert.ToInt32(pID)).FirstOrDefault();
                sup.NAME = pName;
                sup.PHONE = pPhone;
                sup.EMAIL = pEmail;
                sup.ADDRESS = pAddress;
                sup.TAXCODE = Convert.ToInt32(pTaxcode);
                sup.IDGROUP = Convert.ToInt32(pIdgroup);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        //Xoa nha cung cap
        public bool DeleteSupplierMySQL(string pID)
        {
            try
            {
                DbSpaDataContext db = new DbSpaDataContext();
                Supplier sup = db.Suppliers.Where(t => t.ID == Convert.ToInt32(pID)).FirstOrDefault();
                db.Suppliers.DeleteOnSubmit(sup);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
