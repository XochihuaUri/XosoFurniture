using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text.Json;
using XosoFurniture.api.Models;

namespace XosoFurniture.api.Controllers
{
    [Route("api/product/")]
    [ApiController]
    public class Products2Controller : ControllerBase
    {
        private ProductRepository _repository = new ProductRepository();

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
        public IActionResult Create(Product product)
        {
            Product newProd = new Product()
            {
                productDescription = product.productDescription,
                productId = product.productId,
                productName= product.productName,
                productPrice = product.productPrice,
                productStock = product.productStock
            };
            _repository.Add(newProd);
            //return Ok(_repository.Get(newProd.productId));
            return Ok(_repository.GetAll());
        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult Update(Product product)
        {
            Product newProd = new Product()
            {
                productDescription = product.productDescription,
                productId = product.productId,
                productName = product.productName,
                productPrice = product.productPrice,
                productStock = product.productStock
            };
            _repository.Update(newProd);
            //return Ok(_repository.Get(newProd.productId));
            return Ok(_repository.GetAll());
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete(int id)
        {
            _repository.Remove(id);
            //return Ok(_repository.Get(id));
            return Ok(_repository.GetAll());
        }
    }
}
