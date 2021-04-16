using System;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models.Sizes
{
    public class crust_small : Size
    {
        public void small_pizza(){
            name.Equals("Small 12in");
            price = 10;
        }
        
    }
}