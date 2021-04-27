using System.Collections.Generic;
using System.Linq;
using PizzaBox.Domain.Models;
using PizzaBox.Storing;

namespace PizzaBox.Client.Singletons
{
    public class CustomerSingleton
    {
        private readonly PizzaBoxContext _db;
        private static CustomerSingleton _instance;


        public List<Customer> Customers { get; set; }

        public static CustomerSingleton Instance(PizzaBoxContext context)
        {
            if (_instance == null)
            {
                _instance = new CustomerSingleton(context);
            }
            return _instance;
        }

        private CustomerSingleton(PizzaBoxContext context)
        {
            _db = context;
            Customers = _db.Customers.ToList();
        }
    }
}