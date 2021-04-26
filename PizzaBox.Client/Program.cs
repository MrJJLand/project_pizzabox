using System;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;
using PizzaBox.Client.Singletons;


namespace project_pizzabox.Client
{
    public class Program
    {
        private static readonly StoreSingleton _storeSingleton = StoreSingleton.Instance;
        private static readonly PizzaSingleton _pizzaSingleton = PizzaSingleton.Instance;
        private static void Main()
        {
            Run();
        }

        private static void Run()
        {
            var order = new Order();

            Console.WriteLine("For When You Don't Want to Be Trendy Like Your Friends For All Your Pizza Needs\n                 Welcome to PizzaBox");
            PrintStoreList();

            order.Customer = new Customer();
            order.Store = SelectStore();
            order.Pizza = SelectPizza();
        }

        private static void PrintOrder(APizza pizza)
        {
            Console.WriteLine($"Your order is: {pizza}");
        }

        private static void PrintStoreList()
        {
            var index = 1;

            foreach (var item in _storeSingleton.Stores)
            {
                Console.WriteLine($"{index++} - {item}");
            }
        }

        private static void PrintPizzaList()
        {
            var index = 1;

            foreach (var item in _pizzaSingleton.Pizzas)
            {
                Console.WriteLine($"{index++} - {item}");
            }
        }

        private static AStore SelectStore()
        {
            var check = int.TryParse(Console.ReadLine(), out int input);

            if (!check)
            {
                return null;
            }

            PrintPizzaList();

            return _storeSingleton.Stores[input - 1];
        }

        private static APizza SelectPizza()
        {
            var check = int.TryParse(Console.ReadLine(), out int input);
            var pizza = _pizzaSingleton.Pizzas[input - 1];

            if (!check)
            {
                return null;
            }

            PrintOrder(pizza);

            return pizza;
        }

    }
}