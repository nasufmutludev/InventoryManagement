using Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete
{
    public class IvDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-HBR8UE0;Database=InventoryDb;Integrated Security=true");
        }
        public DbSet<Inventory> Inventories { get; set; }
    }
}
