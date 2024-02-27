using Microsoft.EntityFrameworkCore;
using WebApplication1.DataAccess.Entities;

namespace WebApplication1.DataAccess
{
    public class DbContextCodeFirst : DbContext
    {
        public DbSet<User> Users{get;set;}
        public DbSet<Role> Roles{get;set;}


        public DbContextCodeFirst(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
