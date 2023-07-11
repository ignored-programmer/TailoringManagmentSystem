using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using TMS.DataLayer.Models;
using TMS.DataLayer.Repositories;

namespace TMS.DataLayer.Services
{
    public class OrderRepository : IOrderRpository
    {
        private AppDbContext _db;

        public OrderRepository(AppDbContext db)
        {
            _db = db;
        }

        public List<Order> GetAllOrders()
        {
            return _db.Orders.ToList();
        }
        public Order GetOrderById(int orserId)
        {
            return _db.Orders.Find(orserId);
        }
        public IEnumerable<Order> GetOrderssByFilter(string parameter)
        {
            return _db.Orders.Where(c => c.OrderCode.ToString().Contains(parameter) || c.CustomerFullName.Contains(parameter) || c.MobileCustomer.ToString().Contains(parameter)).ToList();
        }
        public string GetOrderNameById(int orderId)
        {
            return _db.Orders.Find(orderId).CustomerFullName;
        }
        public bool InsertOrder(Order order)
        {
            try
            {
                _db.Orders.Add(order);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool UpdateOrder(Order order)
        {
            try
            {
                var local = _db.Set<Order>()
                    .Local
                    .FirstOrDefault(f => f.Id == order.Id);
                if (local != null)
                {
                    _db.Entry(local).State = EntityState.Detached;
                }
                _db.Entry(order).State = EntityState.Modified;
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool DeleteOrder(Order order)
        {
            try
            {
                _db.Entry(order).State = EntityState.Deleted;
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool DeleteOrder(int orderId)
        {
            try
            {
                var order = GetOrderById(orderId);
                DeleteOrder(order);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public string GetTotal()
        {
            return GetAllOrders().Sum(c => c.TotalPrice).ToString();
        }
    }
}
