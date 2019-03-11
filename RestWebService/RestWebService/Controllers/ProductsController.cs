using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RestWebService.DAL;
using ProductShared;

namespace RestWebService.Controllers
{
    [RoutePrefix("api/productservice")]
    public class ProductsController : ApiController
    {
        [HttpGet]
        [Route("getall")]
        public List<Product> GetAll()
        {
            List<Product> products = ProductDAO.selectAll().ToList<Product>();
            return products;
        }
        [HttpGet]
        [Route("search/{name}")]
        public List<Product> Search(String name)
        {
            List<Product> products = ProductDAO.searchByName(name).ToList<Product>();
            return products;
        }
        [HttpPost]
        [Route("insert")]
        public Boolean addNew(Product product)
        {
            Boolean flat = ProductDAO.Insert(product);
            return flat;
        }
        [HttpPost]
        [Route("update")]
        public Boolean Update(Product product)
        {
            Boolean flat = ProductDAO.updateById(product);
            return flat;
        }
        [HttpPost]
        [Route("delete/{id:int}")]
        public Boolean Delete(String id)
        {
            Boolean flat = ProductDAO.deleteById(id);
            return flat;
        }
    }
}