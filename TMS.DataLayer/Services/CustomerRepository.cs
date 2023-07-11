using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using TMS.DataLayer.Models;
using TMS.DataLayer.Repositories;
using TMS.ViewModels;

namespace TMS.DataLayer.Services
{
    public class CustomerRepository : ICustomerRepository
    {
        private AppDbContext _db;

        public CustomerRepository(AppDbContext db)
        {
            _db = db;
        }

        public List<Customer> GetAllCustomers()
        {
            return _db.Customers.ToList();

        }
        public Customer GetCustomerById(int customerId)
        {
            return _db.Customers.Find(customerId);
        }

        public IEnumerable<Customer> GetCusstomersByFilter(string parameter)
        {
            return _db.Customers.Where(c =>
                c.FullName.Contains(parameter) || c.PhoneNumber.ToString().Contains(parameter)).ToList();
        }
        public List<ListCustomerViewModel> GetNameCustomers(string filter = "")
        {
            if (filter == "")
            {
                return _db.Customers.Select(c => new ListCustomerViewModel()
                {
                    CustomerID = c.Id,
                    FullName = c.FullName
                }).ToList();
            }

            return _db.Customers.Where(c => c.FullName.Contains(filter)).Select(c => new ListCustomerViewModel()
            {
                CustomerID = c.Id,
                FullName = c.FullName
            }).ToList();
        }

        public string GetCustomerMobileByName(string name)
        {
            return _db.Customers.First(c => c.FullName == name).PhoneNumber;
        }
        public long GetCustomerIdByName(string name)
        {
            return _db.Customers.First(c => c.FullName == name).Id;
        }
        public string GetCustomerNameById(int customerId)
        {
            return _db.Customers.Find(customerId).FullName;
        }

        public bool InsertCustomer(Customer customer)
        {
            try
            {
                _db.Customers.Add(customer);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool UpdateCustomer(Customer customer)
        {
            var local = _db.Set<Customer>()
                .Local
                .FirstOrDefault(f => f.Id == customer.Id);
            if (local != null)
            {
                _db.Entry(local).State = EntityState.Detached;
            }
            _db.Entry(customer).State = EntityState.Modified;
            return true;
        }

        public bool DeleteCustomer(Customer customer)
        {
            try
            {
                _db.Entry(customer).State = EntityState.Deleted;
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool DeleteCustomer(int customerId)
        {
            try
            {
                var customer = GetCustomerById(customerId);
                DeleteCustomer(customer);
                return true;
            }
            catch
            {
                return false;
            }
        }


    }
}
