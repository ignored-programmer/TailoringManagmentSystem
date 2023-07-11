using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS.DataLayer.Models;
using TMS.ViewModels;

namespace TMS.DataLayer.Repositories
{
    public interface ICustomerRepository
    {
        List<Customer> GetAllCustomers();
        IEnumerable<Customer> GetCusstomersByFilter(string parameter);
        List<ListCustomerViewModel> GetNameCustomers(string filter = "");
        Customer GetCustomerById(int customerId);
        bool InsertCustomer(Customer customer);
        bool UpdateCustomer(Customer customer);
        bool DeleteCustomer(Customer customer);
        bool DeleteCustomer(int customerId);
        string GetCustomerNameById(int customerId);
        long GetCustomerIdByName(string name);
        string GetCustomerMobileByName(string name);
    }
}
