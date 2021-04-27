using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models.Pizzas
{
    public class Custom : APizza
    {
        public override void AddCrust(Crust crust)
        {
            Crust = new Crust() { name = "Original" };
        }
        public override void AddSize(Size size)
        {
            Size = new Size() { name = "Large" };
        }
        public override void AddToppings(params Topping[] toppings)
        {
            Toppings = new List<Topping>()
            {
                new Topping() {name = "Mozzerella"},
                new Topping() {name = "Marinara" }
            };
        }
    }
}

