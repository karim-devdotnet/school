using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApi.Base;
using MongoDB.Driver;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            MongoClient client = SchoolContext.Instance().GetConnection();

            IMongoDatabase db = client.GetDatabase("school");

            IMongoCollection<Schueler> schueler = db.GetCollection<Schueler>("schueler");

            schueler.InsertOne(new Schueler() { SchuelerID = "1", Vorname = "André", Nachname = "Kirst", CreatedAt = DateTime.Now });

            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
