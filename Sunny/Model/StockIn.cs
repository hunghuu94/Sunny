using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sunny.Model
{
    class StockIn
    {
        public string id { get; set; }
        public string title { get; set; }
        public string contents { get; set; }
        public double totalPrice { get; set; }
        public System.DateTime createdDate { get; set; }
        public string createdBy { get; set; }
        public System.DateTime modifiedDate { get; set; }
        public string modifiedBy { get; set; }
    }
}
