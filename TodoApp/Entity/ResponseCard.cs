using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TodoApp.Entity;

namespace TodoApp.Entity
{
    public class ResponseCard:Response
    {
        private List<Card> data;
        
        // constructor
        public ResponseCard() : base()
        {
            this.data = new List<Card>();
        }

        public List<Card> Data { get => data; set => data = value; }
    }
}