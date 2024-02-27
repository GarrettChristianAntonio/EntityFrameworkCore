using Microsoft.EntityFrameworkCore;
using System.Reflection;
using EFRepositoryMVC.Models.EntitiesPrenda;
using EFRepositoryMVC.Models.EntitiesPrenda.Seeding;


namespace EFRepositoryMVC.Data.DataAccess
{
    public class DbContextCodeFirst : DbContext
    {
        public DbSet<Prenda> Prendas => Set<Prenda>();
        public DbSet<Color> Colores => Set<Color>();
        public DbSet<Imagen> Images => Set<Imagen>();
        public DbSet<Marca> Marcas => Set<Marca>(); 
        public DbSet<Talla> Tamanios => Set<Talla>();       
        public DbSet<Categoria> Categorias => Set<Categoria>();
        public DbSet<PrendaTallaColorStock> PrendaTamanioColorStocks => Set<PrendaTallaColorStock>();



        public DbContextCodeFirst(DbContextOptions<DbContextCodeFirst> options) : base(options)
        {            

        }

        
        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            modelbuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            SeedingPrenda.Seed(modelbuilder);
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            base.ConfigureConventions(configurationBuilder);
        }

    }
}
