using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pronect.DirectoryServer.DbContext.Models;

namespace Pronect.DeviceServer.API.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class Devices : Controller
    {
        // GET: api/UserAccounts
        [HttpGet]
        public IEnumerable<PronectDevice> Get()
        {
            using (var db = new DbContext.DbContext())
            {
                var devices = new List<PronectDevice>();
                devices = (from s in db.PronectDevice
                            orderby s.Id
                            select s).ToList();

                return devices;
            }
        }

        // GET: api/UserAccounts/5
        [HttpGet("{id}")]
        public IEnumerable<PronectDevice> Get(string license)
        {
            using (var db = new DbContext.DbContext())
            {
                var device = new List<PronectDevice>();
                device = (from s in db.PronectDevice
                          orderby s.Account == license
                          select s).ToList();

                return device;
            }
        }

        // POST: api/UserAccounts
        [HttpPost]
        public void Post([FromBody]PronectDevice device)
        {
            using (var db = new DbContext.DbContext())
            {
                db.PronectDevice.Add(device);
                db.SaveChanges();
            }
        }

        // PUT: api/UserAccounts/5
        [HttpPut("{id}")]
        public void Put(string id, [FromBody]PronectDevice device)
        {
            using (var db = new DbContext.DbContext())
            {
                db.Entry(device).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            using (var db = new DbContext.DbContext())
            {
                var userAccount = db.PronectDevice.Find(id);

                db.PronectDevice.Remove(userAccount);
                db.SaveChanges();
            }
        }
    }
}
