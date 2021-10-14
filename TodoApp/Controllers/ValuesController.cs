using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TodoApp.Models;
using TodoApp.Entity;
using System.Threading.Tasks;

namespace TodoApp.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public ResponseCard  Get()
        {
            return CardModel.ReadAll();
        }

        // POST api/values
        [HttpPost]
        public ResponseCard Post([FromBody]string name, [FromBody]string description, [FromBody]int category)
        {
            Card card = new Card(0, name, description);
            card.category = category;
            return CardModel.Create(card);
        }

        // PUT api/values
        public ResponseCard Put([FromBody]int id, [FromBody]string name, [FromBody]string description, [FromBody]int category)
        {
            Card card = new Card(id, name, description);
            card.category = category;

            return CardModel.Update(card);
        }

        // DELETE api/values
        public ResponseCard Delete([FromBody]int id)
        {
            Card card = new Card();
            card.Id = id;
            return CardModel.delete(card);
        }

        [HttpPost]
        public async Task<IHttpActionResult> Insert()
        {
            return Ok("OK");
        }
    }
}
