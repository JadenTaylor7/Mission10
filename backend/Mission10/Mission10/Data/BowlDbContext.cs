using Microsoft.EntityFrameworkCore;

namespace Mission10.Data
{
    public class BowlDbContext : DbContext
    {
        public BowlDbContext(DbContextOptions<BowlDbContext> options) : base(options) 
        {
        }
        public DbSet<BowlingLeague> Bowlers { get; set; }
        public DbSet<Team> Teams { get; set; }

    }
}
