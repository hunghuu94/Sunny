using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sunny.Model
{
    class DetailStockOut
    {
        public string stockOutId { get; set; }
        public string productId { get; set; }
        public string productName { get; set; }
        public double importPrice { get; set; }
        public double salePrice { get; set; }
        public int quantity { get; set; }
        public double amount { get; set; }
    }
}
