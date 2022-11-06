using System.Collections.Generic;
using System;
using XosoFurniture.api.Interfaces;

namespace XosoFurniture.api.Models
{
    public class ProductRepository : IProductRepository
    {
        private List<Product> products = new List<Product>();
        private int _nextId = 1;

        public ProductRepository()
        {
            Add(new Product(1, "First Product", 10));
            Add(new Product(2, "Second Product", 20));
            Add(new Product(3, "Third Product", 30));
            Add(new Product(4, "Fourth Product", 40));
        }

        public IEnumerable<Product> GetAll()
        {
            return products;
        }

        public Product Get(int id)
        {
            return products.Find(p => p.ProductId == id);
        }

        public Product Add(Product item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            item.ProductId = _nextId++;
            products.Add(item);
            return item;
        }

        public string Remove(int id)
        {
            products.RemoveAll(p => p.ProductId == id);
            if(products.Find(p => p.ProductId == id) != null)
            {
                return ("Product with id: " + id + " was not removed");
            }
            ;
            return ("Product with id: " + id + " was removed");
        }

        public bool Update(Product item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            int index = products.FindIndex(p => p.ProductId == item.ProductId);
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
