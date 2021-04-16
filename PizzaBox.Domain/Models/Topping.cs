using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
    public class Topping : APizza
    {
        public string top_name { get; protected set; }
        public double topping_price { get; protected set; }
        public int top_id { get; protected set; }

        public Topping(string newName, double newTop, int newID)
        {
            top_name = newName;
            topping_price = newTop;
            top_id = newID;
        }
    }
}