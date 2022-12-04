using Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete
{
    public class IvDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-54KU7PI;Database=InventoryDb;Integrated Security=true");
        }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}
