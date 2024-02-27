namespace ProductoProyect.Models.PRODUCT
{
    public class Producto
    {
        public int IdProducto { get; set; }
        public string NombreProducto { get; set; }
        public string DescripcionProducto { get; set; }
        public List<Talla> ListaTallaProducto { get; set; }

        public DateTime FechaCreacionProducto = DateTime.Now;

        public DateTime FechaActualizacion = DateTime.Now;

    }
}
