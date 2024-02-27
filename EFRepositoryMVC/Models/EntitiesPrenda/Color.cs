using System.ComponentModel.DataAnnotations;

namespace EFRepositoryMVC.Models.EntitiesPrenda
{
    public class Color
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string ColorInRGB { get; set; } = null!;

        public virtual List<PrendaTallaColorStock> PrendaTallaColorStocks { get; set; } = new List<PrendaTallaColorStock>();
    }
}
