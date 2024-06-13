using Microsoft.EntityFrameworkCore;
namespace EnergyConsumption.Models
{
    public class EnergyDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<EnergyData> EnergyDatas { get; set; }
      
        public EnergyDbContext(DbContextOptions<EnergyDbContext> options) : base(options)
        {
        }
    }
}
