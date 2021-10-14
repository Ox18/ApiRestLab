using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TodoApp.Models
{
    public class Cards
    {
        private String name;
        private String description;
        private int category;
        private int id;

        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public int Category { get => category; set => category = value; }
        public int Id { get => id; set => id = value; }
    }
}