using System.ComponentModel.DataAnnotations;

namespace EFRepositoryMVC.Models.EntitiesPrenda
{
    public class Imagen
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
		public string Description { get; set; } = null!;
		public string Url { get; set; } = null!;
		public int PrendaId { get; set; }
        public virtual Prenda Prenda { get; set; } = null!;

    }
}
