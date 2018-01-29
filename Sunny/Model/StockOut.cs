using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sunny.Model
{
    class StockOut
    {
        public string id { get; set; }
        public string customer { get; set; }
        public string phomeNumber { get; set; }
        public string address { get; set; }
        public double totalPrice { get; set; }
        public double interest { get; set; }
        public System.DateTime createdDate { get; set; }
        public string createdBy { get; set; }
        public System.DateTime modifiedDate { get; set; }
        public string modifiedBy { get; set; }
    }
}
