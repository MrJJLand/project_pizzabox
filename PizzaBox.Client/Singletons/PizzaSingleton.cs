using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;
using PizzaBox.Domain.Models.Pizzas;
using PizzaBox.Storing.Repositories;

namespace PizzaBox.Client.Singletons
{
    public class PizzaSingleton
    {
        private const string _path = @"data/pizza.xml";
        private readonly FileRepository _fr = new FileRepository();
        private static PizzaSingleton _instance;





        // public static List<APizza> stores = new List<APizza>
        // {
        //     new Custom(),
        //     new Meatlovers(),
        //     new Veggie(),
        //     new Hawaiian(),
        // };

        // // public static List<Topping> toppings = new List<Topping>
        // // {
        // //     new
        // // }

        // public static List<APizza> Pizzas { get; set; }
        // public List<Topping> Toppings { get; set; }

        // public List<Crust> Crusts { get; set; }

        // public List<Size> Sizes { get; set; }

        // public static PizzaSingleton Instance
        // {
        //     get
        //     {
        //         if (_instance == null)
        //         {
        //             return new PizzaSingleton();
        //         }

        //         return _instance;
        //     }
        // }

        // private PizzaSingleton()
        // {
        //     //Pizzas = _fileRepository.ReadFromFile<List<APizza>>(_path);

        // }

    }
}