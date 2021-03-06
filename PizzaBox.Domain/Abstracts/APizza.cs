using PizzaBox.Domain.Models;
using PizzaBox.Domain.Models.Pizzas;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace PizzaBox.Domain.Abstracts
{

    // [XmlInclude(typeof(Custom))]
    // [XmlInclude(typeof(Meatlovers))]
    // [XmlInclude(typeof(Veggie))]
    // [XmlInclude(typeof(Hawaiian))]
    public abstract class APizza : AModel
    {
        public string name = "";
        public Crust Crust;
        public Size Size;
        public List<Topping> Toppings;
        public double pizzaPrice { get { return Crust.price + Size.price + Toppings.Sum(t => t.price); } }

        protected APizza()
        {
            Factory();
        }
        public virtual void Factory()
        {
            AddCrust();
            AddSize();
            AddToppings();
        }
        public abstract void AddCrust(Crust crust = null);
        public abstract void AddSize(Size size = null);
        public abstract void AddToppings(params Topping[] toppings);

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();
            var separator = ", ";

            foreach (var item in Toppings)
            {
                stringBuilder.Append($"{item}{separator}");
            }
            return $"{Crust} - {Size} - {stringBuilder.ToString().TrimEnd(separator.ToCharArray())}";
        }

    }
}