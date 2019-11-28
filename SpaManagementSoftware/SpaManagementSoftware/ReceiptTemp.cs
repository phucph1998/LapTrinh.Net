using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaManagementSoftware
{
    public class ReceiptTemp
    {
        string id, chair;

        public string Chair
        {
            get
            {
                return chair;
            }

            set
            {
                chair = value;
            }
        }

        public string Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }
    }
}
