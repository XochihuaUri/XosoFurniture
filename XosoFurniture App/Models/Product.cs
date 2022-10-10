using System;
using System.Collections.Generic;
using System.Text;

namespace XosoFurniture_App.Models
{
    public class Product
    {
        private int productStock;
        private float productPrice;
        private string productDescription;
        private string productName;
        private string productId;

        public Product(string productId, string productName, float productPrice)
        {
            this.productId = productId;
            this.productName = productName;
            this.productPrice = productPrice;
        }

        public string ProductId { get { return productId;} }
        public string ProductName { get{return productName; } set { productName = value; } }
        public string ProductDescription { get { return productDescription; } set { productDescription = value; } }
        public float ProductPrice { get{ return productPrice; } set{ productPrice = value; } }
        public int ProductStock { get{ return productStock; } set{ productStock = value; } }

    }
}
