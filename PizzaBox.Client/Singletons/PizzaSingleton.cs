using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;
using PizzaBox.Domain.Models.Pizzas;
using PizzaBox.Storing;
using PizzaBox.Storing.Repositories;

namespace PizzaBox.Client.Singletons
{
    public class PizzaSingleton
    {
        private const string _path = @"data/pizza.xml";
        private readonly FileRepository _fr = new FileRepository();
        private readonly PizzaBoxContext _db = new PizzaBoxContext();
        private static PizzaSingleton _instance;


        public List<APizza> Pizzas { get; }
        public static List<APizza> pizzas = new List<APizza>
        {
            new Custom(),
            new Meatlovers(),
            new Veggie(),
            new Hawaiian()
        };

        public static PizzaSingleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new PizzaSingleton();
                }
                return _instance;
            }
        }

        private PizzaSingleton()
        {
            var cp = new Custom();
            cp.Size = _db.Sizes.FirstOrDefault(s => s.name == "Medium");

            _db.Add(cp);
            // _db.Pizzas.AddRange(_fr.ReadFromFile<List<APizza>>(_path));
            _db.SaveChanges();
            //Pizzas = _fileRepository.ReadFromFile<List<APizza>>(_path);
            Pizzas = _db.Pizzas.ToList();
        }
    }
}