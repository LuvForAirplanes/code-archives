using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pronect.UserAccountServer.DbContext.Models;

namespace Pronect.UserAccountServer.Server.Controllers
{
    [Produces("application/json")]
    [Route("api/UserAccounts")]
    public class UserAccounts : Controller
    {
        // GET: api/UserAccounts
        [HttpGet]
        public IEnumerable<UserAccount> Get()
        {
            using (var db = new DbContext.DbContext())
            {
                var accounts = new List<UserAccount>();
                accounts = (from s in db.UserAccounts
                            orderby s.Id
                            select s).ToList();
                
                return accounts;
            }
        }

        // GET: api/UserAccounts/5
        [HttpGet("{id}", Name = "Get")]
        public IEnumerable<UserAccount> Get(string license)
        {
            using (var db = new DbContext.DbContext())
            {
                var accounts = new List<UserAccount>();
                accounts = (from s in db.UserAccounts
                            orderby s.LicenseKey == license
                            select s).ToList();

                return accounts;
            }
        }
        
        // POST: api/UserAccounts
        [HttpPost]
        public void Post([FromBody] UserAccount userAccount)
        {
            using(var db = new DbContext.DbContext())
            {
                db.UserAccounts.Add(userAccount);
                db.SaveChanges();
            }
        }
        
        // PUT: api/UserAccounts/5
        [HttpPut("{id}")]
        public void Put(string licenseKey, [FromBody]UserAccount userAccount)
        {
            using (var db = new DbContext.DbContext())
            {
                db.Entry(userAccount).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            using(var db = new DbContext.DbContext())
            {
                var userAccount = db.UserAccounts.Find(id);

                db.UserAccounts.Remove(userAccount);
                db.SaveChanges();
            }
        }
    }
}
