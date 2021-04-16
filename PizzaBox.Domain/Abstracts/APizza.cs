using System;
using PizzaBox.Domain.Models;

namespace PizzaBox.Domain.Abstracts
{
    public class APizza
    {

        const int top_max = 5, top_min = 2;
        double crust_price = 0.0, size_price = 0.0, toppings_price = 0.0;
        //double price = crust_price + size_price + toppings_price;
        public string name { get; protected set; }

        public double price { get; protected set; }

        public Size size { get; protected set; }

        protected virtual void Factory()
        {
            AddCrust();
            AddSize();
            AddToppings();
        }

        protected virtual void AddCrust()
        {

        }

        protected virtual void AddSize()
        {

        }

        protected virtual void AddToppings()
        {

        }
    }
}