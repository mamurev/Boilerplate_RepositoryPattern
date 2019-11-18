using Company.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace Company.DataAccess.Concrete.EntityFramework.Contexts
{
    public class NorthwindContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"Server=.\sqlexpress;Database=Northwind;Trusted_Connection=yes");
        }

        public DbSet<Product> Products { get; set; }
    }
}
