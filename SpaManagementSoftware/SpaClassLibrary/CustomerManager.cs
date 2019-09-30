﻿using System;
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
        C_Account acc = new C_Account();
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
            SqlDataAdapter dt = new SqlDataAdapter("select p.ID_PROFILE,p.ID_USER,p.IDENFITICATION,p.LAST_NAME,p.FIRST_NAME,p.SEX,p.PHONE,p.ADDRESS,pc.SCORE,tpc.NAME_TYPE,p.STATUS from dbo.PROFILE p,dbo.PROFILE_CUSTOMER pc ,dbo.TYPE_CUSTOMER tpc where p.ID_PROFILE = pc.ID_PROFILE and pc.ID_TYPE_CUS = tpc.ID_TYPE_CUS", Properties.Settings.Default.DB_SPAConnect);
            dt.Fill(listCus);
            return listCus;
        }

        //Danh sách khách hàng dựa trên Loại KH
        public DataTable GetListTypeCustomer(string pTypeCus)
        {
            DataTable listCus = new DataTable();
            SqlDataAdapter dt = new SqlDataAdapter("select p.ID_PROFILE,p.ID_USER,p.IDENFITICATION,p.LAST_NAME,p.FIRST_NAME,p.SEX,p.PHONE,p.ADDRESS,pc.SCORE,tpc.NAME_TYPE,p.STATUS from dbo.PROFILE p,dbo.PROFILE_CUSTOMER pc ,dbo.TYPE_CUSTOMER tpc where p.ID_PROFILE = pc.ID_PROFILE and pc.ID_TYPE_CUS = tpc.ID_TYPE_CUS and tpc.NAME_TYPE=N'"+pTypeCus+"'", Properties.Settings.Default.DB_SPAConnect);
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

        //Load loại khách hàng
        public DataTable LoadTypeCus()
        {
            DataTable tb = new DataTable();
            SqlDataAdapter dt = new SqlDataAdapter("select * from TYPE_CUSTOMER", Properties.Settings.Default.DB_SPAConnect);
            dt.Fill(tb);
            return tb;
        }

        //Max ID_PROFILE
        public int GetIDMaxProFile()
        {
            DataTable tb = new DataTable();
            SqlDataAdapter dt = new SqlDataAdapter("select MAX(ID_PROFILE) from PROFILE", Properties.Settings.Default.DB_SPAConnectionString);
            dt.Fill(tb);
            return Int32.Parse(tb.Rows[0][0].ToString());
        }

        //Max ID_PROFILE_CUSTOMER
        public int GetIDMaxProFileTypeCus()
        {
            DataTable tb = new DataTable();
            SqlDataAdapter dt = new SqlDataAdapter("select MAX(ID_PROFILE_CUSTOMER) from PROFILE_CUSTOMER", Properties.Settings.Default.DB_SPAConnectionString);
            dt.Fill(tb);
            return Int32.Parse(tb.Rows[0][0].ToString());
        }

        //Thêm khách hàng đồng thời tạo tài khoản khách hàng ID: Số đt KH, Pass : CMND (Mặc định)
        public int InsertCustomer(string pID,string pLastName,string pFirstName,string pSex,string pPhone,string pAddress,int pTypeCus)
        {
            //B1 thêm tài khoản cho khách hàng
            //Username: Số đt khách hàng, Password: CMND khách hàng
            if (acc.IsAccountPhone(pPhone)!=0)
            {
                return 1;//Tồn tại tài khoản
            }
            else
            {
                int idUser = acc.InsertAccount(pPhone,pID);//thêm thành công sẽ trả về ID_USER vừa thêm
                if(idUser != 0)
                {
                    DC_CustomerDataContext cus = new DC_CustomerDataContext();

                    PROFILE profile = new PROFILE();
                    PROFILE_CUSTOMER pro_cus = new PROFILE_CUSTOMER();

                    int number = GetIDMaxProFile() + 1;

                    profile.ID_PROFILE = number;
                    profile.ID_USER = idUser;
                    profile.IDENFITICATION = pID;
                    profile.LAST_NAME = pLastName;
                    profile.FIRST_NAME = pFirstName;
                    profile.SEX = pSex;
                    profile.PHONE = pPhone;
                    profile.ADDRESS = pAddress;
                    profile.STATUS = 0;

                    pro_cus.ID_PROFILE_CUSTOMER = GetIDMaxProFileTypeCus() + 1;
                    pro_cus.ID_PROFILE = number;
                    pro_cus.ID_TYPE_CUS = pTypeCus;
                    pro_cus.SCORE = 0;

                    cus.PROFILEs.InsertOnSubmit(profile);
                    cus.PROFILE_CUSTOMERs.InsertOnSubmit(pro_cus);                    
                    cus.SubmitChanges();
                    return 2;//Thêm thành công
                }
                else
                {
                    return 3;//thêm thất bại
                }
            }      
        }
    }
}