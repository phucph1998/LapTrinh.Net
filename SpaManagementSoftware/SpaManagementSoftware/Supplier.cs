using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaManagementSoftware
{
    public class Supplier
    {
        string pID, pName, pPhone, pEmail, pAddress, pTaxcode, pIdgroup;

        public Supplier()
        {

        }

        public Supplier(string pID, string pName, string pPhone, string pEmail, string pAddress, string pTaxcode, string pIdgroup)
        {
            this.pID = pID;
            this.pName = pName;
            this.pPhone = pPhone;
            this.pEmail = pEmail;
            this.pAddress = pAddress;
            this.pTaxcode = pTaxcode;
            this.pIdgroup = pIdgroup;
        }

        public string PIdgroup
        {
            get { return pIdgroup; }
            set { pIdgroup = value; }
        }

        public string PTaxcode
        {
            get { return pTaxcode; }
            set { pTaxcode = value; }
        }

        public string PAddress
        {
            get { return pAddress; }
            set { pAddress = value; }
        }

        public string PEmail
        {
            get { return pEmail; }
            set { pEmail = value; }
        }

        public string PPhone
        {
            get { return pPhone; }
            set { pPhone = value; }
        }

        public string PName
        {
            get { return pName; }
            set { pName = value; }
        }

        public string PID
        {
            get { return pID; }
            set { pID = value; }
        }
    }
}
