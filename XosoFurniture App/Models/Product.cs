using System;
using System.Collections.Generic;
using System.Text;

namespace XosoFurniture_App.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public string ProductPhone { get; set; }
        public float ProductPrice { get; set; }
        public bool IsTheProductCreditable { get; set; }
        public bool IsMonthsWithoutInterest { get; set; }
        public float ProductRate { get; set; }
        public List<Product> ProductComments { get; set; }
        public Features ProductFeatures { get; set; }
        public string PaymentMethod { get; set; }
        public int ProductStock { get; set; }

    }
}
