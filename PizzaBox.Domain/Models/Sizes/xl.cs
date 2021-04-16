using System;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models.Sizes
{
    public class crust_xl : Size
    {
        public void xl_pizza(){
            name.Equals("XL 20in");
            price = 16;
        }
        
    }
}