using System.Linq;
using Microsoft.EntityFrameworkCore;
using PizzaBox.Domain.Models;

namespace PizzaBox.Storing.Repositories
{
    public class OrderRepository
    {
        // Based around CRUD
        private readonly PizzaBoxContext _db;

        public OrderRepository(PizzaBoxContext context)
        {
            _db = context;
        }

        public void Create(Order order)
        {
            //order.Store = _db.Stores.FirstOrDefault(s => s.name == order.Store.name);
            _db.Orders.Add(order);
            _db.SaveChanges();
        }
    }
}