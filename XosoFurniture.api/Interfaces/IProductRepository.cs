using System.Collections.Generic;
using XosoFurniture.api.Models;

namespace XosoFurniture.api.Interfaces
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAll();
        Product Get(int id);
        Product Add(Product item);
        string Remove(int id);
        bool Update(Product item);
    }
}
