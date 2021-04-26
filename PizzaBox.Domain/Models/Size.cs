using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
    public class Size : AComponent
    {
        public ICollection<APizza> Pizzas { get; set; } //Used for Database to show Size is related to Pizza 
    }
}