using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.EntityFrameworkCore;
namespace ZombieParty.Models.Data
{
    public class ZombiePartyDbContext : DbContext
    {
        public ZombiePartyDbContext(DbContextOptions<ZombiePartyDbContext> options) : base(options)
        {

        }
        
        public DbSet<Zombie> Zombies { get; set; }
        public DbSet<ZombieType> ZombieTypes { get; set; }

        public DbSet<HuntingLog> HuntingLogs { get; set; }

        public DbSet<Weapon> Weapons { get; set; } 
    }
}
