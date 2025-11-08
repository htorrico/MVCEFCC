using Microsoft.EntityFrameworkCore;

namespace MVCEFCC.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }
        public DbSet<Person> People { get; set; }

        //public DbSet<Customer> Customers { get; set; }

        //public DbSet<Product> Products { get; set; }


    }
}
