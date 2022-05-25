using AOProject.Entities;
using Microsoft.EntityFrameworkCore;

namespace AOProject.API.DbContexts
{
    public class AODbContext : DbContext
    {

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Branch> Branches { get; set; }
      

        public AODbContext(DbContextOptions<AODbContext> options)
          : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog=AOData");
        }
    }
}
