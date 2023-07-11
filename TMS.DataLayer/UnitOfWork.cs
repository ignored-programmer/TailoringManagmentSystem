using System;
using TMS.DataLayer.Models;
using TMS.DataLayer.Repositories;
using TMS.DataLayer.Services;

namespace TMS.DataLayer
{
    public class UnitOfWork : IDisposable
    {
        AppDbContext db = new AppDbContext();

        private ICustomerRepository _customerRepository;
        public ICustomerRepository CustomerRepository
        {
            get
            {
                if (_customerRepository == null)
                {
                    _customerRepository = new CustomerRepository(db);
                }

                return _customerRepository;
            }
        }

        private IOrderRpository _orderRepository;
        public IOrderRpository OrderRepository
        {
            get
            {
                if (_orderRepository == null)
                {
                    _orderRepository = new OrderRepository(db);
                }

                return _orderRepository;
            }
        }

        private IClothRepository _clothRepository;
        public IClothRepository ClothRepository
        {
            get
            {
                if (_clothRepository == null)
                {
                    _clothRepository = new ClothRepository(db);
                }

                return _clothRepository;
            }
        }


        private GenericRepository<User> _loginRepository;

        public GenericRepository<User> LoginRepository
        {
            get
            {
                if (_loginRepository == null)
                {
                    _loginRepository = new GenericRepository<User>(db);
                }
                return _loginRepository;
            }
        }
        public void Save()
        {
            db.SaveChanges();
        }
        public void Dispose()
        {
            db.Dispose();
        }
    }
}
