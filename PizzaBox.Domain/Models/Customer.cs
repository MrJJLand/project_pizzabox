using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
    public class Customer : AModel
    {
        public string name { get; set; }

        public long CustomerID { get; set; }

        public override string ToString()
        {
            return $"{name}";
        }
    }
}