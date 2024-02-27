using System.ComponentModel.DataAnnotations;

namespace EFRepositoryMVC.Models.EntitiesPrenda
{
    public class Talla
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
		public virtual List<PrendaTallaColorStock> PrendaTallaColorStocks { get; set; } = new List<PrendaTallaColorStock>();
	}
}
