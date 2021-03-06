using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;
using PizzaBox.Storing;
using PizzaBox.Storing.Repositories;

namespace PizzaBox.Client.Singletons
{
    public class StoreSingleton
    {
        private readonly PizzaBoxContext _db;
        private static StoreSingleton _instance;
        public List<AStore> Stores { get; }

        public static StoreSingleton Instance(PizzaBoxContext context)
        {
            if (_instance == null)
            {
                _instance = new StoreSingleton(context);
            }
            return _instance;
        }
        private StoreSingleton(PizzaBoxContext context)
        {
            _db = context;
            if (Stores == null)
            {
                Stores = _db.Stores.ToList();
            }
        }

        public IEnumerable<AStore> ViewOrders(AStore store)
        {
            // lambda - LINQ (linq to objects)
            // EF Loading = Eager Loading, Explicity Loading, Lazy Loading
            // EF Eager Loading - will get Orders of all stores
            var orders = _db.Stores.Include(s => s.Orders).ThenInclude(o => o.Pizza).Where(s => s.name == store.name); //LINQ = language integrated query

            //var orders2 = _db.Stores.Include(s => s.Orders).ThenInclude(o => o.Pizza).Where(s => s.name == store.name); //Same as Eager Loading, but all orders and all pizzas on all orders

            // Explicity Loading - will get Orders, then pizzas, then components, then toppings, crusts and szies
            //var stores = _db.Stores.FirstOrDefault(s => s.name == store.name);
            //_db.Entry<AStore>(store).Collection<Order>(s => s.Orders).Load(); // load all orders and properties for 1 store

            // sql - LINQ (linq to sql)
            // EF Lazy Loading
            // var orders2 = from r in _db.Stores
            //               join ro in _db.Orders on r.EntityID == ro.StoreEntityID
            //               where r.name == store.name
            //               select ro;
            return orders.ToList();
        }

    }
}
