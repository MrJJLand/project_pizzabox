using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
    public class Size : APizza
    {
        public string crust_name {get; protected set;}
        public int crust_price {get; protected set;}
    }
}