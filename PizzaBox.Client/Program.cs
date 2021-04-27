using System;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;
using PizzaBox.Client.Singletons;
using PizzaBox.Storing.Repositories;
using PizzaBox.Storing;
using System.Linq;
using System.Collections.Generic;

namespace project_pizzabox.Client
{
    public class Program
    {
        private static readonly PizzaBoxContext _db = new PizzaBoxContext();
        private static readonly StoreSingleton _storeSingleton = StoreSingleton.Instance(_db);
        private static readonly PizzaSingleton _pizzaSingleton = PizzaSingleton.Instance(_db);
        private static readonly CustomerSingleton _customerSingleton = CustomerSingleton.Instance(_db);
        private static readonly OrderRepository _orderRepository = new OrderRepository(_db);

        private static void Main()
        {
            Run();
        }

        private static void Run()
        {
            var order = new Order();

            Console.WriteLine("For When You Don't Want to Be Trendy Like Your Friends For All Your Pizza Needs\n                 Welcome to PizzaBox");
            Console.WriteLine("Pick a Customer that Represents You Below");
            PrintListToScreen(_customerSingleton.Customers);

            order.Customer = SelectCustomer();
            order.Store = SelectStore();
            order.Pizza = SelectPizza();

            _orderRepository.Create(order);

            var orders = _db.Orders.Where(o => o.Customer.name == order.Customer.name);
            PrintListToScreen(orders);
        }

        private static void PrintOrder(APizza pizza)
        {
            Console.WriteLine($"Your order is: {pizza}\nYour order will cost $" + pizza.price);
        }
        private static void PrintListToScreen(IEnumerable<object> items)
        {
            var index = 1;
            foreach (var item in items)
            {
                Console.WriteLine($"{index++} - {item}");
            }
        }

        // private static void PrintOrderList(List<Order> orders)
        // {
        //     var index = 0;

        //     foreach (var order in orders)
        //     {
        //         Console.WriteLine($"{index++} - {order}");
        //     }
        // }
        private static AStore SelectStore()
        {
            var check = int.TryParse(Console.ReadLine(), out int input);

            if (!check)
            {
                return null;
            }

            Console.WriteLine("Select a Pizza to Start Your Order With");
            PrintListToScreen(_pizzaSingleton.Pizzas);

            return _storeSingleton.Stores[input - 1];
        }

        private static APizza SelectPizza()
        {
            var check = int.TryParse(Console.ReadLine(), out int input);

            if (!check)
            {
                return null;
            }

            var pizza = _pizzaSingleton.Pizzas[input - 1];
            PrintOrder(pizza);

            return pizza;
        }

        private static Customer SelectCustomer()
        {
            var check = int.TryParse(Console.ReadLine(), out int input);

            if (!check)
            {
                return null;
            }

            var customer = _customerSingleton.Customers[input - 1];
            Console.WriteLine("Pick a Store from the Following To Have Your Order From");
            PrintListToScreen(_storeSingleton.Stores);

            return customer;
        }

    }
}