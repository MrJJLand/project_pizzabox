using System.Text;
using PizzaBox.Domain.Models;
using System;

namespace PizzaBox.Domain.Abstracts
{
    public abstract class APizza : AModel
    {

        protected const int top_max = 5, top_min = 2;
        protected double crust_price = 0.0, size_price = 0.0, toppings_price = 0.0;
        //double price = crust_price + size_price + toppings_price;
        protected string name { get; set; }
        protected double price { get; set; }

        protected APizza()
        {
            //Factory();
        }

        protected virtual void Factory()
        {
            AddCrust();
            AddSize();
            AddToppings();
        }

        protected virtual void AddCrust()
        {
            Console.WriteLine("Choose a Crust type you would like:\n1)");
        }

        protected virtual void AddSize()
        {

        }

        protected virtual void AddToppings()
        {

        }

        // public override string ToString()
        // {
        //     var stringBuilder = new StringBuilder();
        //     var separator = ", ";

        //     foreach (var item in Topping)
        //     {
        //         stringBuilder.Append($"{item}{separator}");
        //     }
        //     return $"{Crust} - {Size} - {stringBuilder.ToString().TrimEnd(separator.ToCharArray())}";
        // }

    }
}