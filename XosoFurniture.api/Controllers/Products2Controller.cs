using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Text.Json;
using XosoFurniture.api.Models;

namespace XosoFurniture.api.Controllers
{
    [Route("api/product/")]
    [ApiController]
    public class Products2Controller : ControllerBase
    {
        private ProductRepository _repository;

        //public Products2Controller(ProductRepository repository)
        //{
        //    _repository = repository;
        //}
        public Products2Controller()
        {
            _repository = new ProductRepository();
        }

        [HttpGet]
        public IEnumerable<Product> GetAll()
        {
            return _repository.GetAll();
        }

        [HttpGet]
        [Route("{id}")]
        public Product GetById(int id)
        {
            return _repository.Get(id);
        }

        [HttpPost]
        public Product Create([FromBody] Product product)
        {
            Product newProd = new Product(product.ProductId, product.ProductName, product.ProductPrice);
            _repository.Add(newProd);
            return _repository.Get(newProd.ProductId);
        }

        [HttpPut]
        [Route("{id}")]
        public Product Update(int id, [FromBody] Product product)
        {
            Product newProduct = new Product(id, product.ProductName, product.ProductPrice);
            _repository.Update(newProduct);
            return _repository.Get(product.ProductId);
        }

        [HttpDelete]
        [Route("{id}")]
        public string Delete(int id)
        {
            string res = _repository.Remove(id);
            return res;
        }
    }
}
