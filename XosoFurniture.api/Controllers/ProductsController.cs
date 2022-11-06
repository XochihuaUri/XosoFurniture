//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using System;
//using System.Collections.Generic;
//using System.Net;
//using System.Net.Http;
//using System.Web.Http;
//using XosoFurniture.api.Interfaces;
//using XosoFurniture.api.Models;

//namespace XosoFurniture.api.Controllers
//{
//    [ApiController]
//    public class ProductsController : ApiController
//    {
//        static readonly IProductRepository repository = new ProductRepository();

//        //public IEnumerable<Product> GetAllProducts()
//        //{
//        //    return repository.GetAll();
//        //}

//        //public Product GetProduct(int id)
//        //{
//        //    Product item = repository.Get(id);
//        //    if (item == null)
//        //    {
//        //        throw new HttpResponseException(HttpStatusCode.NotFound);
//        //    }
//        //    return item;
//        //}


//        //public HttpResponseMessage PostProduct(Product item)
//        //{
//        //    item = repository.Add(item);
//        //    var response = Request.CreateResponse<Product>(HttpStatusCode.Created, item);

//        //    string uri = Url.Link("DefaultApi", new { id = item.ProductId });
//        //    response.Headers.Location = new Uri(uri);
//        //    return response;
//        //}

//        //public void PutProduct(int id, Product product)
//        //{
//        //    product.ProductId = id;
//        //    if (!repository.Update(product))
//        //    {
//        //        throw new HttpResponseException(HttpStatusCode.NotFound);
//        //    }
//        //}

//        //public void DeleteProduct(int id)
//        //{
//        //    Product item = repository.Get(id);
//        //    if (item == null)
//        //    {
//        //        throw new HttpResponseException(HttpStatusCode.NotFound);
//        //    }

//        //    repository.Remove(id);
//        //}

//    }
//}
