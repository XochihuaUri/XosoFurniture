using System;
using System.Collections.Generic;
using System.Text;

namespace XosoFurniture_App.Models
{
    public class ShoppingCart
    {
        private Client client;
        private IList<Product> products = new List<Product>();
        public IList<Product> Products{get{ return products; }}

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public Product RemoveProduct(Product product)
        {
            products.Remove(product);
            return product;
        }

        public float GetTotal()
        {
            float total = 0;
            for (int i = 0; i < products.Count; i++)
            {
                total += products[i].ProductPrice;
            }
            return total;
        }

    }
}
