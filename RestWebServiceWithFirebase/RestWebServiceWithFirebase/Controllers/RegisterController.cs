using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RestWebServiceWithFirebase.DAL;
using RestWebServiceWithFirebase.Models;

namespace RestWebServiceWithFirebase.Controllers
{
    [RoutePrefix("api/accountservice")]
    public class RegisterController : ApiController
    {
        [HttpGet]
        [Route("getall")]
        public List<Account> GetAll()
        {
            List<Account> accounts = AccountDAO.selectAll().ToList<Account>();
            return accounts;
        }
        [HttpGet]
        [Route("search/{name}")]
        public List<Account> Search(String name)
        {
            List<Account> accounts = AccountDAO.searchByName(name).ToList<Account>();
            
            return accounts;
        }
        [HttpPost]
        [Route("insert")]
        public Boolean addNew(Account account)
        {
            Boolean flat = AccountDAO.Insert(account);
            return flat;
        }
    }
}