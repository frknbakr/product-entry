using Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Conctrete
{
    public class MsSqlDbContext:DbContext
    {
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<OperationGroup> OperationGroups { get; set; }
        public DbSet<Order>Orders { get; set; }
        public DbSet<OrderProduct>OrderProducts { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<TechnicalService> TechnicalServices { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Data Source=SEBURSERVER;Initial Catalog=furkan;Persist Security Info=True;User ID=sa;Password=4934744Seyit-");
        }
    }
}