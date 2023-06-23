using Game.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Game.Infra.Data.DataContext
{
    public class GameDatabaseContext : DbContext
    {
        public GameDatabaseContext() : base()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=GameDatabase;Integrated Security=True;";
            optionsBuilder.UseSqlServer(connectionString);
        }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Friend> Friends { get; set; }
        public DbSet<Rental> Rentals { get; set; }
        public DbSet<VideogameCartridge> VideogameCartridges { get; set; }
        public DbSet<VideogameConsole> VideogameConsoles { get; set; }
    }
}