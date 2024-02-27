namespace EntityFrameworkProducto.Models
{
    public class Color
    {
        public int IdColor { get; set; }
        public string NombreColor { get; set; } = null!;
        public int Stock { get; set; }
    }
}
