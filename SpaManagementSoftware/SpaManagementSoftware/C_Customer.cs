using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaManagementSoftware
{
    public class C_Customer
    {
        public string iD_PROFILE, iD_USER, iDENFITICATION, lAST_NAME, fIRST_NAME, sEX, pHONE, aDDRESS, tYPE_CUS, sTATUS;


        public C_Customer()
        {

        }
        public C_Customer(string iD_PROFILE, string iD_USER, string iDENFITICATION, string lAST_NAME, string fIRST_NAME, string sEX, string pHONE, string aDDRESS,string tYPE_CUS,string sTATUS)
        {
            this.iD_PROFILE = iD_PROFILE;
            this.iD_USER = iD_USER;
            this.iDENFITICATION = iDENFITICATION;
            this.lAST_NAME = lAST_NAME;
            this.fIRST_NAME = fIRST_NAME;
            this.sEX = sEX;
            this.pHONE = pHONE;
            this.aDDRESS = aDDRESS;
            this.tYPE_CUS = tYPE_CUS;
            this.sTATUS = sTATUS;
        }

        public string TYPE_CUS
        {
            get { return tYPE_CUS; }
            set { tYPE_CUS = value; }
        }

        public string STATUS
        {
            get { return sTATUS; }
            set { sTATUS = value; }
        }

        public string ADDRESS
        {
            get { return aDDRESS; }
            set { aDDRESS = value; }
        }

        public string PHONE
        {
            get { return pHONE; }
            set { pHONE = value; }
        }

        public string SEX
        {
            get { return sEX; }
            set { sEX = value; }
        }

        public string FIRST_NAME
        {
            get { return fIRST_NAME; }
            set { fIRST_NAME = value; }
        }

        public string LAST_NAME
        {
            get { return lAST_NAME; }
            set { lAST_NAME = value; }
        }

        public string IDENFITICATION
        {
            get { return iDENFITICATION; }
            set { iDENFITICATION = value; }
        }

        public string ID_USER
        {
            get { return iD_USER; }
            set { iD_USER = value; }
        }

        public string ID_PROFILE
        {
            get { return iD_PROFILE; }
            set { iD_PROFILE = value; }
        }

    }
}
