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
            Console.WriteLine("For When You Don't Want to Be Trendy Like Your Friends For All Your Pizza Needs\n                 Welcome to PizzaBox");
            Run();
        }

        private static void Run()
        {
            bool runner = true;
            while (runner == true)
            {
                Console.WriteLine("Please Choose an Option to Get Started");
                Console.Write("1 - Store\n2 - Customer\n3 - Exit\nOption: ");
                string option = Console.ReadLine().ToLower();
                if (option == "1" || option == "store" || option == "1 - option")
                {
                    StoreMenu();
                }
                else if (option == "2" || option == "Customer" || option == "2 - customer")
                {
                    CustomerMenu();
                }
                else if (option == "3" || option == "exit" || option == "3 - exit")
                {
                    runner = false;
                    Console.WriteLine("Thank You, Have a Great Day");
                    return;
                }
                else
                {
                    Console.WriteLine("That is not a valid option. Try Again");
                }
            }
            return;
        }

        private static void StoreMenu()
        {
            bool runner = true;
            while (runner == true)
            {
                Console.WriteLine("\nPlease Choose an Option from the Store Menu");
                Console.Write("1 - Store List\n2 - Store Orders\n3 - Sales\n4 - Return to Main Menu\nOption: ");
                string option = Console.ReadLine().ToLower();
                if (option == "1" || option == "store list" || option == "1 - store list")
                {
                    PrintListToScreen(_storeSingleton.Stores);
                }
                else if (option == "2" || option == "store orders" || option == "2 - store orders")
                {
                    Console.WriteLine("Under Construction\n");
                }
                else if (option == "3" || option == "sales" || option == "3 - sales")
                {
                    Console.WriteLine("Sale have not been Configured properly yet.\n");
                }
                else if (option == "4" || option == "return to main menu" || option == "4 - return to main menu")
                {
                    runner = false;
                    Run();
                }
                else
                {
                    Console.WriteLine("That is not a valid option. Try Again");
                }
            }
        }

        private static void CustomerMenu()
        {
            bool runner = true;
            while (runner == true)
            {
                Console.WriteLine("\nPlease Choose an Option from the Customer Menu");
                Console.Write("1 - Order\n2 - Customer List\n3 - Order History\n4 - Return to Main Menu\nOption: ");
                string option = Console.ReadLine().ToLower();
                if (option == "1" || option == "order" || option == "1 - order")
                {
                    PizzaOrder();
                }
                else if (option == "2" || option == "customer list" || option == "2 - customer list")
                {
                    PrintListToScreen(_customerSingleton.Customers);
                }
                else if (option == "3" || option == "order history" || option == "3 - order history")
                {
                    Console.WriteLine("Due to an error unable to fixed in time, Order History is Currently Down.\n");
                }
                else if (option == "4" || option == "return to main menu" || option == "4 - return to main menu")
                {
                    runner = false;
                    Run();
                }
                else
                {
                    Console.WriteLine("That is not a valid option. Try Again");
                }
            }
        }

        private static void PizzaOrder()
        {
            Console.WriteLine("\n\nPick a Customer that Represents You Below");
            var order = new Order();
            PrintListToScreen(_customerSingleton.Customers);

            order.Customer = SelectCustomer();
            order.Store = SelectStore();
            order.Pizza = SelectPizza();

            _orderRepository.Create(order);

            var orders = _db.Orders.Where(o => o.Customer.name == order.Customer.name);
            //var pizzaOrders = _db.Orders;
            PrintOrderList(order.Customer.name, orders);
            Console.WriteLine("\nThank you for your Order Today with PizzaBox\n\n\n");
        }

        private static void PrintOrder(APizza pizza)
        {
            Console.WriteLine($"Your order is: {pizza}\nYour order will cost $" + pizza.pizzaPrice);
        }
        private static void PrintListToScreen(IEnumerable<object> items)
        {
            var index = 1;
            Console.WriteLine("");
            foreach (var item in items)
            {
                Console.WriteLine($"{index++} - {item}");
            }
        }

        private static void PrintOrderList(string customerName, IEnumerable<object> items)
        {
            var index = 1;

            foreach (var item in items)
            {
                Console.WriteLine($"{index++} - {customerName}");
            }
        }
        private static AStore SelectStore()
        {
            var check = int.TryParse(Console.ReadLine(), out int input);

            if (!check)
            {
                return null;
            }

            Console.WriteLine("\nSelect a Pizza to Start Your Order With");
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
            customer.name = _customerSingleton.Customers[input - 1].name;
            Console.WriteLine("\nPick a Store from the Following To Have Your Order From");
            PrintListToScreen(_storeSingleton.Stores);

            return customer;
        }

    }
}