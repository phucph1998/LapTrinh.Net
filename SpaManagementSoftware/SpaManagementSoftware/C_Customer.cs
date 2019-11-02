using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaManagementSoftware
{
    public class C_Customer
    {
        public string pImag, iD_PROFILE, nAME, sEX, pHONE, aDDRESS, bIRTHDAY, tYPE_CUS, sTATUS;

        public string PImag
        {
            get { return pImag; }
            set { pImag = value; }
        }

        public string NAME
        {
            get { return nAME; }
            set { nAME = value; }
        }

        public string BIRTHDAY
        {
            get { return bIRTHDAY; }
            set { bIRTHDAY = value; }
        }


        public C_Customer()
        {

        }
        public C_Customer(string image,string iD_PROFILE, string nAME, string sEX, string pHONE, string aDDRESS,string bIRTHDAY,string tYPE_CUS,string sTATUS)
        {
            this.pImag = image;
            this.iD_PROFILE = iD_PROFILE;
            this.nAME = nAME;
            this.sEX = sEX;
            this.bIRTHDAY = bIRTHDAY;
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

        public string ID_PROFILE
        {
            get { return iD_PROFILE; }
            set { iD_PROFILE = value; }
        }

    }
}
