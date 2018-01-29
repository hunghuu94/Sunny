using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sunny.Model
{
    class Products
    {
        public string id { get; set; }
        public string productName { get; set; }
        public byte[] image { get; set; }
        public double importPrice { get; set; }
        public double salePrice { get; set; }
        public int quantity { get; set; }
        public int categoryId { get; set; }
        public string categoryName { get; set; }
        public string description { get; set; }
        public System.DateTime createdDate { get; set; }
        public string createdBy { get; set; }
        public System.DateTime modifiedDate { get; set; }
        public string modifiedBy { get; set; }
        public bool choose { get; set; }
    }
}
