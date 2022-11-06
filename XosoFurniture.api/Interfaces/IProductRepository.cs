using System.Collections.Generic;
using XosoFurniture.api.Models;

namespace XosoFurniture.api.Interfaces
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAll();
        Product Get(int id);
        Product Add(Product item);
        void Remove(int id);
        bool Update(Product item);
    }
}
