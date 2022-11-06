using System.Collections.Generic;
using System;
using XosoFurniture.api.Interfaces;

namespace XosoFurniture.api.Models
{
    public class ProductRepository : IProductRepository
    {
        public List<Product> products = new List<Product>() { new Product()
        {
            productDescription = "des",
            productId = 1,
            productName = "First",
            productPrice= 10,
            productStock=1
        } ,
            new Product()
        {
            productDescription = "des2",
            productId = 2,
            productName = "Second",
            productPrice= 20,
            productStock=2
        } , };


        public IEnumerable<Product> GetAll()
        {
            return products;
        }

        public Product Get(int id)
        {
            return products.Find(p => p.productId == id);
        }

        public Product Add(Product item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            products.Add(item);
            return item;
        }

        public void Remove(int id)
        {
            products.RemoveAll(p => p.productId == id);
        }

        public bool Update(Product item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            int index = products.FindIndex(p => p.productId == item.productId);
            if (index == -1)
            {
                return false;
            }
            products.RemoveAt(index);
            products.Add(item);
            return true;
        }
    }
}
