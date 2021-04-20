using System;
using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models.Pizzas
{
    public class Custom : APizza
    {
        protected override void AddCrust()
        {
            //AddCrust = new Crust() { name = "Original" };
        }
        protected override void AddSize()
        {
            //Size = new Size() { name = "Medium" };
        }
        // protected override void AddToppings()
        // {
        //     Toppings = new List<Topping>()
        //     {
        //         new Topping() {name = "Mozzerella"};
        //         new Topping() { name = "Marinara" };
        //     }
        // }
        public Custom()
        {
            name = "Custom";
            Factory();
        }
    }
}
