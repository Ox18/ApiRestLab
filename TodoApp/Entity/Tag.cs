using System;


namespace TodoApp.Entity
{
    public class Tag
    {
        private int id;
        private String name;
        private int cardID;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int CardID { get => cardID; set => cardID = value; }

        public Tag(int id, string name, int cardID)
        {
            this.id = id;
            this.name = name;
            this.cardID = cardID;
        }
    }
}