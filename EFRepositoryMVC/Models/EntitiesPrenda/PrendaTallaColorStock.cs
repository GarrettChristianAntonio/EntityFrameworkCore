namespace EFRepositoryMVC.Models.EntitiesPrenda
{
    public class PrendaTallaColorStock
    {
        public int Stock {  get; set; } = 0;



        public int PrendaId { get; set; }
        public virtual Prenda Prenda { get; set; } = null!;


        public int TallaId { get; set; }
        public virtual Talla Talla { get; set; } = null!;


        public int ColorId { get; set; }
        public virtual Color Color { get; set; }= null!;


    }
}
