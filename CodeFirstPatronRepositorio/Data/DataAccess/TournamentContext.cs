using CodeFirstPatronRepositorio.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstPatronRepositorio.Data.DataAccess
{
    public class TournamentContext : DbContext
    {
        public DbSet<Player> Players { get; set; }
        public DbSet<User> Users { get; set; }
        public TournamentContext(DbContextOptions<TournamentContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            this.SeedUser(modelBuilder);
            this.SeedPlayer(modelBuilder);
        }
        private void SeedUser(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User()
                {
                    Id = 1,
                    Name = "Emmanuel",
                    LastName = "Ranone",
                    Email = "emmanuelranone@gmail.com",
                    Password = "12345"
                },
                new User()
                {
                    Id = 2,
                    Name = "Melina",
                    LastName = "Perez",
                    Email = "mperez@gmail.com",
                    Password = "12345"
                }
            );
        }
        private void SeedPlayer(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Player>().HasData(
               new Player()
               {
                   PlayerId = 1,
                   Ranking = 25,
                   UserId = 1
               }
            );
        }
    }
}
