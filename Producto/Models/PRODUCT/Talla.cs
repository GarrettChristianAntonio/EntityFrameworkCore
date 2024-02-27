namespace ProductoProyect.Models.PRODUCT
{
    public class Talla
    {
        public int IdTalla { get; set; }
        public string TallaName { get; set; }
        public decimal Precio { get; set; }

        public List<Color> ListaColorTalla { get; set; }

    }
}
