namespace EntityFrameworkProducto.Models
{
    public class Producto
    {
        public int IdProducto { get; set; }
        public string NombreProducto { get; set; } = null!;
        public string DescripcionProducto { get; set; } = null!;
        public List<Talla> ListaTallaProducto { get; set; } = null!;

        public List<ImagenUrl> ListaUrl { get; set; } = null!;

        public DateTime FechaCreacionProducto = DateTime.Now;

        public DateTime FechaActualizacion = DateTime.Now;

    }
}
