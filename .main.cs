// using System;
// using System.Collections.Generic;

// // class for pizza, order, customer, store
// // pizza: crust, size, topping(s), preset, top_max, top_min, price
// // Crust: name, price
// // Size: name, size, price
// // Topping: name, price
// // top min = 2, top max = 5
// // price = crust_price + size_price + toppingX_price
// // order: new_pizza, pizza_collection, price_total, price_max, pizza_max
// // price_max = 250, pizza_max = 50
// // price_total = pizza_collection.total && !<= price_max
// // pizza_collection = amount, total
// // customer: 
// // store: location, monthly_revenue, weekly_revenue, quarterly_revenue

// namespace project_pizzabox
// {
//     public class program
//     {
//         private static readonly StoreSingletons _storeSingleton = StoreSingletons.Instance;
//         private static void Main(string[] args)
//         {
//             Run();
//         }
//         //     _storeSingleton.WriteToFile();
//         //     Run();

//         // }
//         // private void Run()
//         // {
//         //     StoreSingletons ss = StoreSingleton.Instance;


//         //     Console.WriteLine("Welcome to PizzaBox!\n");

//         //     Console.WriteLine("Please Choose a Store from the Following List");
//         //     for (var x = 0; x < stores.Count; x += 1)
//         //     {
//         //         int y = x + 1;
//         //         Console.Write("Store " + y + ": ");
//         //         Console.WriteLine(stores[x]);
//         //     }

//         //     string input = Console.ReadLine();
//         //     int entry = int.Parse(input);

//         public Run()
//         {
//             //List<string> stores = new List<string>{"Store 001", "Store 002", "Store 003"}; // explicit
//             var stores = new List<AStore> { new NewYorkStore(), new ChicagoStore() }; // datatype inference

//             for (var x = 0; x < stores.Count; x += 1)
//             {
//                 Console.WriteLine(stores[x]);
//             }

//             Console.Write("Pick the Number of a Store: ");
//             string input = System.Console.ReadLine();
//             int entry = int.Parse(input);
//             entry = entry - 1;

//             Console.WriteLine("Your store is " + stores[entry]);
//         }
//     }



// }