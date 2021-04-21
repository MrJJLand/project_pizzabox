using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models.Pizzas
{
    public class Meatlovers : APizza
    {
        public Meatlovers()
        {
            //Crust = new Crust() { name = "Meatlovers" };
            name = "Meatlovers";
        }
    }
}