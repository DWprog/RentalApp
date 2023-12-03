using Microsoft.EntityFrameworkCore;
using RentalApp.Equipments;

namespace RentalApp.Data
{
    public class RentalAppDbContext : DbContext
    {
        public DbSet<Tool> Tools => Set<Tool>();
        public DbSet<Devoice> Devoices => Set<Devoice>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseInMemoryDatabase("StoreAppDb");
        }
    }
}
