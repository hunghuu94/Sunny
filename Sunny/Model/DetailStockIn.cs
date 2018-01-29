using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sunny.Model
{
    class DetailStockIn
    {
        public string stockin_id { get; set; }
        public string product_id { get; set; }
        public string product_name { get; set; }
        public double import_price { get; set; }
        public int quantity { get; set; }
        public double amount { get; set; }
    }
}
