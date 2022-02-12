using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pronect.DirectoryServer.DbContext.Models;
using Pronect.RecordServer.DbContext.Models;

namespace Pronect.RecordServer.API.Controllers
{
    [Route("api/[controller]")]
    public class ConnectionRecords : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<ConnectionRecord> Get()
        {
            using(var db = new DbContext.DbContext())
            {
                var records = new List<ConnectionRecord>();
                records = (from r in db.ConnectionRecord
                           orderby r.Id
                           select r).ToList();

                return records;
            }
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IEnumerable<ConnectionRecord> Get(string id)
        {
            using(var db = new DbContext.DbContext())
            {
                var records = new List<ConnectionRecord>();
                records = (from r in db.ConnectionRecord
                           orderby r.Id == id
                           select r).ToList();

                return records;
            }
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]ConnectionRecord record)
        {
            using (var db = new DbContext.DbContext())
            {
                db.ConnectionRecord.Add(record);
                db.SaveChanges();
            }
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(string id, [FromBody]ConnectionRecord record)
        {
            using (var db = new DbContext.DbContext())
            {
                db.Entry(record).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            using (var db = new DbContext.DbContext())
            {
                var record = db.ConnectionRecord.Find(id);

                db.ConnectionRecord.Remove(record);
                db.SaveChanges();
            }
        }
    }
}
