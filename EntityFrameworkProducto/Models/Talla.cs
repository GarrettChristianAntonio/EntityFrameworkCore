namespace EntityFrameworkProducto.Models
{
    public class Talla
    {
        public int IdTalla { get; set; }
        public string TallaName { get; set; } = null!;
        public decimal Precio { get; set; }

        public List<Color> ListaColorTalla { get; set; } = null!;

    }
}
