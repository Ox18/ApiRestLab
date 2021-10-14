using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using System.Web.Http;
using TodoApp.Models;
using TodoApp.Entity;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net;
using System.Net.Http.Formatting;
using System.Web.Http.Cors;

namespace TodoApp.Controllers
{

    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class CardsController : ApiController
    {
        // GET api/cards
        public ResponseCard Get()
        {
            return CardModel.ReadAll();
        }

        [System.Web.Mvc.HttpPost]
        // POST api/cards
        public ResponseCard Post(Cards Cards)
        {
            Card card = new Card(0, Cards.Name, Cards.Description);
            card.category = Cards.Category;

            return CardModel.Create(card);

        }

        [System.Web.Http.HttpPut]
        public ResponseCard Put(Cards Cards)
        {
            Card card = new Card();
            card.Id = Cards.Id;
            card.Name = Cards.Name;
            card.Description = Cards.Description;
            card.category = Cards.Category;

            return CardModel.Update(card);
        }

        [System.Web.Http.HttpDelete]
        public ResponseCard Delete(int id)
        {
            Card card = new Card();
            card.Id = id;
            return CardModel.delete(card);
        }
    }
}
