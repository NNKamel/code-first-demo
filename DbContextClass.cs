using Microsoft.EntityFrameworkCore;

namespace RpsGame_NoDb
{
    class DbContextClass : DbContext
    {

        public DbSet<Match> Matchs { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Round> Rounds { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\PRODDB;Database=CodeFirstRpsDemo;Trusted_Connection=True;");
        }
    }
}