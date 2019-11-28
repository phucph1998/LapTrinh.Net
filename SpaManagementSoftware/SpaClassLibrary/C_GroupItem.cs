using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbSpaContext;
namespace SpaClassLibrary
{
    public class C_GroupItem
    {
        DbSpaDataContext db = new DbSpaDataContext();

        //Lay ten 

        public List<GroupItem> GetDataGroupItem()
        {
            return db.GroupItems.Select(t => t).ToList();
        }

        //Thêm nhóm mặt hàng
        public bool AddGroupItem(string pNameGroup)
        {
            try
            {
                GroupItem check = db.GroupItems.Where(t => t.NAMEGROUP.Equals(pNameGroup)).FirstOrDefault();
                if (check != null)
                {
                    return false;
                }
                else
                {
                    GroupItem add = new GroupItem();
                    add.ID = db.GroupItems.Count() + 1;
                    add.NAMEGROUP = pNameGroup;
                    add.STATUS = 1;
                    db.GroupItems.InsertOnSubmit(add);
                    db.SubmitChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        //Cap nhat nhom mat hang
        public bool UpdateGroupItem(string pNameGroup, string pChangeName)
        {
            try
            {
                GroupItem check = db.GroupItems.Where(t => t.NAMEGROUP.Equals(pNameGroup)).FirstOrDefault();
                if (check != null)
                {
                    check.NAMEGROUP = pChangeName;
                    db.SubmitChanges();
                    return true;
                    ;
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

        //Xóa nhóm mặt hàng
        public int DeleteGroupItem(string pNameGroup)
        {
            try
            {
                GroupItem check = db.GroupItems.Where(t => t.NAMEGROUP.Equals(pNameGroup)).FirstOrDefault();
                if (check != null)
                {
                    Item checkFK = db.Items.Where(t => t.IDGROUP == check.ID).FirstOrDefault();
                    if (checkFK != null)
                    {
                        return 2;
                    }
                    else
                    {
                        //Xoa duoc
                        check.STATUS = 0;
                        db.SubmitChanges();
                        return 1;
                    }
                }
                else
                {
                    return 3;
                }
            }
            catch
            {
                return 3;
            }
        }
    }
}
