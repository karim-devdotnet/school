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
    public class SchuelerController : Controller
    {
        // GET api/values
        [HttpGet]
        public async Task<IEnumerable<Schueler>> Get()
        {
            IMongoCollection<Schueler> schueler = SchoolContext.Instance().GetCollection<Schueler>("schueler");

            //await SchoolContext.Instance().SaveItem<Schueler>(new Schueler() { SchuelerID = "1", Vorname = "André", Nachname = "Kirst", CreatedAt = DateTime.Now }, schueler);

            //schueler.InsertOne(new Schueler() { SchuelerID = "1", Vorname = "André", Nachname = "Kirst", CreatedAt = DateTime.Now });

            //return new string[] { "value1", "value2" };
            return schueler.AsQueryable();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Schueler Get(string id)
        {
            return SchoolContext.Instance().GetCollection<Schueler>("schueler").AsQueryable().FirstOrDefault(s => s.SchuelerID == id);
        }

        //// POST api/values
        //[HttpPost]
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT api/values/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/values/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
