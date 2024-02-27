using IntroduccionAEFCore.Entidades;
using Microsoft.EntityFrameworkCore;

namespace IntroduccionAEFCore
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions opcion) :base(opcion){
        
        }

        public DbSet<Genero> Generos => Set<Genero>();
    }
}
