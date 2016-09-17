/*
 * Copyright André Kirst
 * 2016 - 2016
 * School
*/
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
        private string _collectionName = "schueler";

        // GET api/schueler
        [HttpGet]
        public IEnumerable<Schueler> Get()
        {
            IMongoCollection<Schueler> schueler = SchoolContext.Instance().GetCollection<Schueler>(_collectionName);
            return schueler.AsQueryable();
        }

        // GET api/schueler/5
        [HttpGet("{id}")]
        public IEnumerable<Schueler> Get(string id)
        {
            return SchoolContext.Instance().GetCollection<Schueler>(_collectionName).AsQueryable().Where(s => s.SchuelerID == id);
        }

        // POST api/schueler
        [HttpPost]
        public async Task<bool> Post([FromBody]Schueler value)
        {
            try
            {
                await SchoolContext.Instance().SaveItem(value, SchoolContext.Instance().GetCollection<Schueler>(_collectionName));
            }
            catch(Exception)
            {
                return false;
            }
            return true;
        }

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
