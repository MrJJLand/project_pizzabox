using System.Collections.Generic;
using System;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;
using PizzaBox.Domain.Models.Pizzas;
using PizzaBox.Client.Singletons;
//using sc = System.Console; // alias

namespace project_pizzabox.Client
{
    public class Program
    {
        private static readonly StoreSingletons _storeSingleton = StoreSingletons.Instance;
        private static void Main()
        {
            //List<string> stores = new List<string>{"Store 001", "Store 002", "Store 003"}; // explicit
            var stores = new List<AStore> { new NewYorkStore(), new ChicagoStore() }; // datatype inference

            for (var x = 0; x < stores.Count; x += 1)
            {
                Console.WriteLine(stores[x]);
            }

            Console.Write("Pick the Number of a Store: ");
            string input = System.Console.ReadLine();
            int entry = int.Parse(input);
            entry = entry - 1;

            Console.WriteLine("Your store is " + stores[entry]);

        }
    }
}