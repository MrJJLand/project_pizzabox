using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models.Pizzas
{
    public class Custom : APizza
    {
        public override void AddCrust(Crust crust = null)
        {
            Crust = crust ?? new Crust() { name = "Original" };
        }
        public override void AddSize(Size size = null)
        {
            Size = size;
        }
        public override void AddToppings(params Topping[] toppings)
        {
            Toppings = new List<Topping>()
            {
                new Topping() {name = "Mozzerella"},
                new Topping() { name = "Marinara" }
            };
        }
    }
}

