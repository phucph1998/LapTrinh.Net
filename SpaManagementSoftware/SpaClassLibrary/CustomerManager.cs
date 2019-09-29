using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SpaClassLibrary
{
    public class CustomerManager
    {
        //Bảng loại khách hàng
        public DataTable GetTableTypeCustomer()
        {
            DataTable listType = new DataTable();
            SqlDataAdapter dt = new SqlDataAdapter("select NAME_TYPE from TYPE_CUSTOMER", Properties.Settings.Default.DB_SPAConnect);
            dt.Fill(listType);
            return listType;
        }

        //Danh sách tất cả khách hàng
        public DataTable GetListCustomer()
        {
            DataTable listCus = new DataTable();
            SqlDataAdapter dt = new SqlDataAdapter("select * from dbo.PROFILE p where p.ID_PROFILE in (select ID_PROFILE from dbo.PROFILE_CUSTOMER)", Properties.Settings.Default.DB_SPAConnect);
            dt.Fill(listCus);
            return listCus;
        }

        //Danh sách khách hàng dựa trên Loại KH
        public DataTable GetListTypeCustomer(string pTypeCus)
        {
            DataTable listCus = new DataTable();
            SqlDataAdapter dt = new SqlDataAdapter("select * from dbo.PROFILE p where p.ID_PROFILE in (select pc.ID_PROFILE from dbo.PROFILE_CUSTOMER pc, dbo.TYPE_CUSTOMER tc where tc.ID_TYPE_CUS = pc.ID_TYPE_CUS and tc.NAME_TYPE=N'" + pTypeCus + "')", Properties.Settings.Default.DB_SPAConnect);
            dt.Fill(listCus);
            return listCus;
        }

        //Kiểm tra nhóm khách hàng trước khi thêm
        public bool IsGroupCustomer(string pNameGroup)
        {
            DataTable check = new DataTable();
            SqlDataAdapter dt = new SqlDataAdapter("select * from dbo.TYPE_CUSTOMER where TYPE_CUSTOMER.NAME_TYPE=N'"+pNameGroup+"'", Properties.Settings.Default.DB_SPAConnect);
            dt.Fill(check);
            if(check.Rows.Count > 0)
            {
                return false;//đã tồn tại nhóm khách hàng cần thêm
            }
            return true;//Cho phép thêm
        }

        //Lấy ID lớn nhất
        public int MaxIDType()
        {
            DataTable check = new DataTable();
            SqlDataAdapter dt = new SqlDataAdapter("select * from dbo.TYPE_CUSTOMER", Properties.Settings.Default.DB_SPAConnect);
            dt.Fill(check);
            return check.Rows.Count;
        }

        //Thêm nhóm khách hàng
        public bool InsertGroupCustomer(string pNameGroup)
        {
            if(IsGroupCustomer(pNameGroup))
            {
                //Cho thêm
                int numberID = MaxIDType() + 1;
                DC_TypeCustomerDataContext typeCus = new DC_TypeCustomerDataContext();

                TYPE_CUSTOMER temp = new TYPE_CUSTOMER();
                temp.ID_TYPE_CUS = numberID;
                temp.NAME_TYPE = pNameGroup;
                temp.STATUS = 0;

                typeCus.TYPE_CUSTOMERs.InsertOnSubmit(temp);
                typeCus.SubmitChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
