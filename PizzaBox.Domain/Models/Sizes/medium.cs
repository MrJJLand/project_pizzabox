using System;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models.Sizes
{
    public class crust_medium : Size
    {
        public void medium_pizza(){
            name.Equals("Medium 14in");
            price = 12;
        }
        
    }
}