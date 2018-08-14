using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carrier.Model
{
    public class Carrier
    {
        public int ID { get; set; }
        public string CarrierName { get; set; }
        public int CustomerID { get; set; }
        public string SCACCode { get; set; }
        public int Enabled { get; set; }
        public string By { get; set; }
        public DateTime Datetime { get; set; }
    }
}
