using System.Data.Entity;
using TMS.DataLayer.Models;

namespace TMS.DataLayer
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("appconnection")
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Cloth> Cloths { get; set; }
    }
}
