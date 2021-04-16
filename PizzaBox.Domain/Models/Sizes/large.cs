using System;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models.Sizes
{
    public class crust_large : Size
    {
        public void large_pizza(){
            name.Equals("Large 16in");
            price = 14;
        }
        
    }
}