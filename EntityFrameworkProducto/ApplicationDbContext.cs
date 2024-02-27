using EntityFrameworkProducto.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkProducto
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Producto> productos => Set<Producto>();
        public DbSet<Color> Colores => Set<Color>();

        public DbSet<ImagenUrl> ImagenUrls => Set<ImagenUrl>();
        public DbSet<Marca> Marcas => Set<Marca>();
        public DbSet<Talla> Tallas => Set<Talla>();
    }
}
