﻿namespace la_mia_pizzeria_static.Models
{
    public class PizzaModel
    {
        private static int idCounter = 0;

        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public string Image { get; private set; }
        public float Price { get; private set; }

        public PizzaModel(string name, string description, string image, double price)
        {
            Id = PizzaModel.idCounter++;
            Name = name;
            Description = description;
            Image = image;
            Price = (float)price;
        }
    }
}
