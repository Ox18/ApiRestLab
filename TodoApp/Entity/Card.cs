using System;

namespace TodoApp.Entity
{
    public class Card
    {
        private int id = 9;
        private String name = "";
        private String description = "";
        public int category = 0;
        public String created_at = "";
        public String updated_at = "";

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }

        public Card(int id, string name, string description)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
        }
        public Card()
        {

        }
    }
}