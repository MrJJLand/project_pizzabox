using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models.Pizzas;

namespace PizzaBox.Client.Singletons
{
    public class PizzaSingleton
    {

        private static readonly PizzaSingleton _instance;
        public static List<APizza> stores = new List<APizza>
        {
            new Custom(),
            new Meatlovers(),
            new Veggie(),
            new Hawaiian(),
        };

        public List<APizza> Pizzas { get; set; }

        public static PizzaSingleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    return new PizzaSingleton();
                }

                return _instance;
            }
        }

        private PizzaSingleton()
        {
            //Pizzas = _fileRepository.ReadFromFile<List<APizza>>(_path);

        }

    }
}