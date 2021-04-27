using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models.Pizzas;
using PizzaBox.Storing;
using PizzaBox.Storing.Repositories;

namespace PizzaBox.Client.Singletons
{
    public class PizzaSingleton
    {
        private const string _path = @"data/pizza.xml";
        private readonly FileRepository _fr = new FileRepository();
        private readonly PizzaBoxContext _db;
        private static PizzaSingleton _instance;
        public List<APizza> Pizzas { get; set; }

        public static PizzaSingleton Instance(PizzaBoxContext context)
        {
            if (_instance == null)
            {
                _instance = new PizzaSingleton(context);
            }
            return _instance;
        }

        private PizzaSingleton(PizzaBoxContext context)
        {
            _db = context;
            Pizzas = _db.Pizzas.ToList();
        }
    }
}