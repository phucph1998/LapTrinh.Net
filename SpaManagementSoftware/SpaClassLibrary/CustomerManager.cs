using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Devart.Data;
using Devart.Data.MySql;
using DbSpaContext;
using System.IO;
using System.Drawing;

namespace SpaClassLibrary
{
    public class CustomerManager
    {
        C_Account acc = new C_Account();
        UserManager mh = new UserManager();
        //Bảng loại khách hàng
        public DataTable GetTableTypeCustomer()
        {
            DataTable listType = new DataTable();
            SqlDataAdapter dt = new SqlDataAdapter("select NAME_TYPE from TYPE_CUSTOMER", Properties.Settings.Default.DB_SPAConnect);
            dt.Fill(listType);
            return listType;
        }
        //Bảng loại khách hàng MYSQL
        public DataTable GetTableTypeCustomerMySQL()
        {
            DataTable listType = new DataTable();
            MySqlDataAdapter dt = new MySqlDataAdapter("select NAME from type_cus", Properties.Settings.Default.DbSpaDataContextConnectionString);
            dt.Fill(listType);
            return listType;
        }

        //Danh sách tất cả khách hàng
        public DataTable GetListCustomer()
        {
            DataTable listCus = new DataTable();
            SqlDataAdapter dt = new SqlDataAdapter("select p.ID_PROFILE,p.ID_USER,p.IDENFITICATION,p.LAST_NAME,p.FIRST_NAME,p.SEX,p.PHONE,p.ADDRESS,pc.SCORE,tpc.NAME_TYPE,p.STATUS from dbo.PROFILE p,dbo.PROFILE_CUSTOMER pc ,dbo.TYPE_CUSTOMER tpc where p.ID_PROFILE = pc.ID_PROFILE and pc.ID_TYPE_CUS = tpc.ID_TYPE_CUS and p.STATUS=1", Properties.Settings.Default.DB_SPAConnect);
            dt.Fill(listCus);
            return listCus;
        }

        //Danh sách tất cả khách hàng MYSQL
        public DataTable GetListCustomerMySQL()
        {
            DataTable listCus = new DataTable();
            MySqlDataAdapter dt = new MySqlDataAdapter("SELECT p.IMAGE,p.ID_PROFILE,p.NAME,p.SEX,p.ADDRESS,p.PHONE,p.BIRTHDAY,t.NAME,p.SCORE,p.`STATUS` FROM type_cus t,profile_cus p WHERE t.ID = p.ID_TYPE", Properties.Settings.Default.DbSpaDataContextConnectionString);
            dt.Fill(listCus);
            return listCus;
        }

        //Loc danh sach khach hang theo ten
        public DataTable GetListCusTomerMySQL_Name(string pName)
        {
            DataTable listCus = new DataTable();
            MySqlDataAdapter dt = new MySqlDataAdapter("SELECT p.IMAGE,p.ID_PROFILE,p.NAME,p.SEX,p.ADDRESS,p.PHONE,p.BIRTHDAY,t.NAME,p.SCORE,p.`STATUS` FROM type_cus t,profile_cus p WHERE t.ID = p.ID_TYPE AND p.NAME LIKE '%" + pName + "%'", Properties.Settings.Default.DbSpaDataContextConnectionString);
            dt.Fill(listCus);
            return listCus;
        }

        //Danh sách khách hàng dựa trên Loại KH
        public DataTable GetListTypeCustomer(string pTypeCus)
        {
            DataTable listCus = new DataTable();
            SqlDataAdapter dt = new SqlDataAdapter("select p.ID_PROFILE,p.ID_USER,p.IDENFITICATION,p.LAST_NAME,p.FIRST_NAME,p.SEX,p.PHONE,p.ADDRESS,pc.SCORE,tpc.NAME_TYPE,p.STATUS from dbo.PROFILE p,dbo.PROFILE_CUSTOMER pc ,dbo.TYPE_CUSTOMER tpc where p.ID_PROFILE = pc.ID_PROFILE and pc.ID_TYPE_CUS = tpc.ID_TYPE_CUS and tpc.NAME_TYPE=N'" + pTypeCus + "' and p.STATUS=1", Properties.Settings.Default.DB_SPAConnect);
            dt.Fill(listCus);
            return listCus;
        }

        //Danh sách khách hàng dựa trên Loại KH MYSQL
        public DataTable GetListTypeCustomerMySQL(string pTypeCus)
        {
            DataTable listCus = new DataTable();
            MySqlDataAdapter dt = new MySqlDataAdapter("SELECT p.IMAGE,p.ID_PROFILE,p.NAME,p.SEX,p.ADDRESS,p.PHONE,p.BIRTHDAY,t.NAME,p.SCORE,p.`STATUS` FROM type_cus t,profile_cus p WHERE t.ID = p.ID_TYPE AND t.ID = '" + pTypeCus + "'", Properties.Settings.Default.DbSpaDataContextConnectionString);
            dt.Fill(listCus);
            return listCus;
        }

        //Kiểm tra nhóm khách hàng trước khi thêm
        public bool IsGroupCustomer(string pNameGroup)
        {
            DataTable check = new DataTable();
            SqlDataAdapter dt = new SqlDataAdapter("select * from dbo.TYPE_CUSTOMER where TYPE_CUSTOMER.NAME_TYPE=N'" + pNameGroup + "'", Properties.Settings.Default.DB_SPAConnect);
            dt.Fill(check);
            if (check.Rows.Count > 0)
            {
                return false;//đã tồn tại nhóm khách hàng cần thêm
            }
            return true;//Cho phép thêm
        }
        //Kiểm tra nhóm khách hàng trước khi thêm MYSQL
        public bool IsGroupCustomerMySQL(string pNameGroup)
        {
            DataTable check = new DataTable();
            MySqlDataAdapter dt = new MySqlDataAdapter("SELECT * FROM type_cus WHERE type_cus.NAME= '" + pNameGroup + "'", Properties.Settings.Default.DbSpaDataContextConnectionString);
            dt.Fill(check);
            if (check.Rows.Count > 0)
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
        //Lấy ID lớn nhấtMYSQL
        public int MaxIDTypeMySQL()
        {
            DataTable check = new DataTable();
            MySqlDataAdapter dt = new MySqlDataAdapter("SELECT COUNT(*) FROM type_cus", Properties.Settings.Default.DbSpaDataContextConnectionString);
            dt.Fill(check);
            return Int32.Parse(check.Rows[0][0].ToString());
        }

        //Thêm nhóm khách hàng
        public bool InsertGroupCustomer(string pNameGroup)
        {
            if (IsGroupCustomer(pNameGroup))
            {
                //Cho thêm
                int numberID = MaxIDType() + 1;
                DC_CustomerDataContext typeCus = new DC_CustomerDataContext();

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
        //Thêm nhóm khách hàng MYSQL
        public bool InsertGroupCustomerMySQL(string pNameGroup)
        {
            if (IsGroupCustomerMySQL(pNameGroup))
            {
                DbSpaDataContext typeCus = new DbSpaDataContext();

                TypeCu t = new TypeCu();
                t.ID = MaxIDTypeMySQL() + 1;
                t.NAME = pNameGroup;
                t.STATUS = 1;

                typeCus.TypeCus.InsertOnSubmit(t);
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

        //Load loại khách hàng MySQL
        public DataTable LoadTypeCusMySQL()
        {
            DataTable tb = new DataTable();
            MySqlDataAdapter dt = new MySqlDataAdapter("select * from type_cus", Properties.Settings.Default.DbSpaDataContextConnectionString);
            dt.Fill(tb);
            return tb;
        }

        //Max ID_PROFILE
        public int GetIDMaxProFile()
        {
            DataTable tb = new DataTable();
            SqlDataAdapter dt = new SqlDataAdapter("select count(*) from PROFILE ", Properties.Settings.Default.DB_SPAConnectionString);
            dt.Fill(tb);
            return Int32.Parse(tb.Rows[0][0].ToString());
        }

        //Max ID_PROFILE MySQL
        public int GetIDMaxProFileMySQL()
        {
            DataTable tb = new DataTable();
            MySqlDataAdapter dt = new MySqlDataAdapter("select count(*) from profile_cus ", Properties.Settings.Default.DbSpaDataContextConnectionString);
            dt.Fill(tb);
            return Int32.Parse(tb.Rows[0][0].ToString());
        }

        //Max ID table Account
        public int GetIDMaxAccountMySQL()
        {
            DataTable tb = new DataTable();
            MySqlDataAdapter dt = new MySqlDataAdapter("select count(*) from account ", Properties.Settings.Default.DbSpaDataContextConnectionString);
            dt.Fill(tb);
            return Int32.Parse(tb.Rows[0][0].ToString());
        }

        //Max ID_PROFILE_CUSTOMER
        public int GetIDMaxProFileTypeCus()
        {
            DataTable tb = new DataTable();
            SqlDataAdapter dt = new SqlDataAdapter("select count(*) from PROFILE_CUSTOMER", Properties.Settings.Default.DB_SPAConnectionString);
            dt.Fill(tb);
            return Int32.Parse(tb.Rows[0][0].ToString());
        }

        //Thêm khách hàng đồng thời tạo tài khoản khách hàng ID: Số đt KH, Pass : CMND (Mặc định)
        public int InsertCustomer(string pID, string pLastName, string pFirstName, string pSex, string pPhone, string pAddress, int pTypeCus)
        {
            //B1 thêm tài khoản cho khách hàng
            //Username: Số đt khách hàng, Password: CMND khách hàng
            if (acc.IsAccount(pPhone) != 0)
            {
                return 1;//Tồn tại tài khoản
            }
            else
            {
                int idUser = acc.InsertAccount(pPhone, pID);//thêm thành công sẽ trả về ID_USER vừa thêm
                if (idUser != 0)
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
                    profile.STATUS = 1;

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

        //Kiểm tra Account khach hang ton tai chua MySQL
        public int IsAccountMySQL(string pUserName)
        {
            DataTable tb = new DataTable();
            MySqlDataAdapter dt = new MySqlDataAdapter("select USER_NAME from account a where USER_NAME = N'" + pUserName + "'", Properties.Settings.Default.DbSpaDataContextConnectionString);
            dt.Fill(tb);
            return tb.Rows.Count;
        }

        //Thêm tài khoản kh MYSQL
        public int InsertAccountMySQL(int pIDPROFILE, string pUserName, string pPass)
        {
            try
            {
                if (IsAccountMySQL(pUserName) == 0)
                {
                    DbSpaDataContext acc = new DbSpaDataContext();
                    Account t = new Account();
                    t.ID = GetIDMaxAccountMySQL() + 1;
                    t.IDPROFILE = pIDPROFILE;
                    t.USERNAME = pUserName;
                    t.PASSWORD = mh.EncodePass(pPass);
                    t.STATUS = 1;
                    acc.Accounts.InsertOnSubmit(t);
                    acc.SubmitChanges();
                    return acc.Accounts.Count();//Cho thêm tài khoản, trả về ID_USER mới vừa thêm
                }
                else
                {
                    return 0;//Khách hàng đã tạo tài khoản
                }
            }
            catch
            {
                return 0;
            }
        }

        //MYSQL - Thêm khách hàng đồng thời tạo tài khoản khách hàng User: Số đt KH, Pass : 1 (Mặc định)
        public int InsertCustomerMySQL(string pName, string pSex, string pPhone, string pAddress, int pTypeCus, string pBirtday)
        {
            //Username: Số đt khách hàng, Password: CMND khách hàng
            if (IsAccountMySQL(pPhone) != 0)
            {
                return 1;//Tồn tại tài khoản
            }
            else
            {
                try
                {
                    DbSpaDataContext db = new DbSpaDataContext();
                    ProfileCu cus = new ProfileCu();
                    cus.IDPROFILE = GetIDMaxProFileMySQL() + 1;
                    cus.IDTYPE = pTypeCus;
                    cus.NAME = pName;
                    cus.BIRTHDAY = Convert.ToDateTime(pBirtday);
                    cus.PHONE = pPhone;
                    cus.SEX = Convert.ToString(pSex);
                    cus.ADDRESS = Convert.ToString(pAddress);
                    cus.STATUS = 1;

                    db.ProfileCus.InsertOnSubmit(cus);
                    db.SubmitChanges();
                    //("INSERT INTO profile_cus(ID_PROFILE,ID_TYPE,NAME,SEX,ADDRESS,PHONE,BIRTHDAY,`STATUS`)VALUES('" + (GetIDMaxProFileMySQL() + 1 )+ "','"+pTypeCus+"',N'"+pName+"',N'"+pSex+"',N'"+pAddress+"','"+pPhone+"','"+pBirtday+"',1)", Properties.Settings.Default.DbSpaDataContextConnectionString);
                    //MySqlConnection conn = new MySqlConnection();
                    //string sql = "INSERT INTO profile_cus(ID_PROFILE,ID_TYPE,NAME,SEX,ADDRESS,PHONE,BIRTHDAY,`STATUS`)VALUES('" + (GetIDMaxProFileMySQL() + 1) + "','" + pTypeCus + "',N'" + pName + "',N'" + pSex + "',N'" + pAddress + "','" + pPhone + "','" + pBirtday + "',1)";
                    //conn.ConnectionString = Properties.Settings.Default.DbSpaDataContextConnectionString;
                    //if(conn.State == ConnectionState.Closed)
                    //{
                    //    conn.Open();
                    //    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    //    cmd.ExecuteNonQuery();
                    //    conn.Close();
                    //}
                    int idprofile = db.ProfileCus.Count();
                    int idUser = InsertAccountMySQL(idprofile, pPhone, "1");//thêm thành công sẽ trả về ID_USER vừa thêm
                    return 2;//Thêm thành công
                }
                catch
                {

                    return 3;//Thêm thất bại
                }
            }
        }

        //Lấy ID loại KH
        public int GetID_TypeCus(string pNameType)
        {
            int typecus = 0;
            DC_CustomerDataContext cus = new DC_CustomerDataContext();
            var query = from c in cus.TYPE_CUSTOMERs
                        where c.NAME_TYPE.ToString().Equals(pNameType) == true
                        select c;

            foreach (TYPE_CUSTOMER item in query)
            {
                typecus = item.ID_TYPE_CUS;
            }
            return typecus;
        }
        //Lấy ID loại KH MYSQL
        public int GetID_TypeCusMySQL(string pNameType)
        {
            DataTable dt = new DataTable();
            MySqlDataAdapter r = new MySqlDataAdapter("SELECT ID FROM type_cus WHERE type_cus.NAME='" + pNameType + "'", Properties.Settings.Default.DbSpaDataContextConnectionString);
            r.Fill(dt);
            return Int32.Parse(dt.Rows[0][0].ToString());
        }
        //Cập nhật thông tin khách hàng
        public bool UpdateCustomer(string pIDProfile, string pID, string pLastName, string pFirstName, string pSex, string pPhone, string pAddress, int pTypeCus, DateTime pBirtday)
        {
            try
            {
                DC_CustomerDataContext customer = new DC_CustomerDataContext();

                var q1 = from cus in customer.PROFILEs
                         where cus.ID_PROFILE == Int32.Parse(pIDProfile)
                         select cus;

                var q2 = from c in customer.PROFILE_CUSTOMERs
                         where c.ID_PROFILE == Int32.Parse(pIDProfile)
                         select c;

                foreach (PROFILE cus in q1)
                {
                    cus.LAST_NAME = pLastName;
                    cus.FIRST_NAME = pFirstName;
                    cus.SEX = pSex;
                    cus.ADDRESS = pAddress;
                    cus.IDENFITICATION = pID;
                    cus.PHONE = pPhone;//có 2 hướng 1 là cập nhật lại UserName, 2 là không cập nhật vẫn được
                }

                foreach (PROFILE_CUSTOMER cus in q2)
                {
                    cus.ID_TYPE_CUS = pTypeCus;
                }

                customer.SubmitChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        //Cập nhật thông tin khách hàng MySQL
        public bool UpdateCustomerMySQL(int pIDProfile, string pName, string pSex, string pPhone, string pAddress, string pBirthDay, int pTypeCus)
        {
            try
            {
                DbSpaDataContext db = new DbSpaDataContext();
                var q = from cus in db.ProfileCus
                        where cus.IDPROFILE == pIDProfile
                        select cus;

                foreach (ProfileCu item in q)
                {
                    item.NAME = pName;
                    item.SEX = pSex;
                    item.BIRTHDAY = Convert.ToDateTime(pBirthDay);
                    item.PHONE = pPhone;
                    item.ADDRESS = pAddress;
                    item.IDTYPE = pTypeCus;
                }
                db.SubmitChanges();
                return true;
            }
            catch
            {

                return false;
            }

        }



        //Xóa khách hàng
        public bool DeleteCustomer(string pPhone)
        {
            if (acc.IsAccount(pPhone) == 0)
            {
                return false;//Chưa tồn tại khách hàng cần xóa
            }
            else
            {
                int del = acc.DeleteAccount(pPhone);
                if (del == 1)
                {
                    DC_CustomerDataContext cus = new DC_CustomerDataContext();
                    var query = from c in cus.PROFILEs
                                where c.PHONE.ToString().Equals(pPhone) == true
                                select c;


                    foreach (PROFILE item in query)
                    {
                        item.STATUS = 0;
                    }
                    cus.SubmitChanges();
                    return true;
                }
            }

            return false;
        }
        //Xóa khách hàng MYSQL (Account)
        public int DeleteAccountMySQL(string pPhone)
        {
            if (IsAccountMySQL(pPhone) == 1)
            {
                DbSpaDataContext account = new DbSpaDataContext();
                var query = from acc in account.Accounts
                            where acc.USERNAME.ToString().Equals(pPhone) == true
                            select acc;
                foreach (Account item in query)
                {
                    item.STATUS = 0;
                }
                account.SubmitChanges();
                return 1;//Tài khoản bị khóa đồng nghĩa việc xóa tài khoản
            }
            else
            {
                return 0;//Không tồn tại tài khoản
            }
        }

        //Xóa khách hàng MYSQL (Profile)
        public bool DeleteCustomerMySQL(string pPhone)
        {
            if (IsAccountMySQL(pPhone) == 0)
            {
                return false;//Chưa tồn tại khách hàng cần xóa
            }
            else
            {
                int del = DeleteAccountMySQL(pPhone);
                if (del == 1)
                {
                    DbSpaDataContext cus = new DbSpaDataContext();
                    var query = from c in cus.ProfileCus
                                where c.PHONE.ToString().Equals(pPhone) == true
                                select c;


                    foreach (ProfileCu item in query)
                    {
                        item.STATUS = 0;
                    }
                    cus.SubmitChanges();
                    return true;
                }
            }

            return false;
        }
        //Luu anh khach hang
        public bool SaveImgCus(string pID, System.Windows.Forms.PictureBox pImg)
        {
            try
            {
                MemoryStream stream = new MemoryStream();
                pImg.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                DbSpaDataContext db = new DbSpaDataContext();
                var q = from c in db.ProfileCus
                        where c.IDPROFILE == Convert.ToInt32(pID)
                        select c;
                foreach (ProfileCu item in q)
                {
                    item.IMAGE = stream.ToArray();
                }
                db.SubmitChanges();
                return true;
            }
            catch
            {

                return false;
            }

        }

        //Load ảnh
        public bool LoadImgCus(string pID, System.Windows.Forms.PictureBox pImg)
        {
            try
            {
                MemoryStream stream = new MemoryStream();
                DbSpaDataContext db = new DbSpaDataContext();
                var q = from c in db.ProfileCus
                        where c.IDPROFILE == Convert.ToInt32(pID)
                        select c;
                foreach (ProfileCu item in q)
                {
                    stream = new MemoryStream(item.IMAGE.ToArray());
                }
                Image img = Image.FromStream(stream);
                if (img == null)
                    return false;
                pImg.Image = img;
                return true;

            }
            catch
            {
                return false;
            }

        }
    }
}
