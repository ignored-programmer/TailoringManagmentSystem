using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS.DataLayer.Models;

namespace TMS.DataLayer.Repositories
{
    public interface IOrderRpository
    {
        List<Order> GetAllOrders();
        string GetTotal();
        IEnumerable<Order> GetOrderssByFilter(string parameter);
        Order GetOrderById(int orderId);
        string GetOrderNameById(int orderId);
        bool InsertOrder(Order order);
        bool UpdateOrder(Order order);
        bool DeleteOrder(Order order);
        bool DeleteOrder(int orderId);
        
    }
}
