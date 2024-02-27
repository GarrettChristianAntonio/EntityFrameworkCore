using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFRepositoryMVC.Models.EntitiesPrenda
{
    public class Prenda
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public decimal Price { get; set; }
		public bool Available { get; set; } = false;

		public DateTime FechaCreacion { get; private set; } = DateTime.Now;
        public DateTime FechaActualizacion { get; set; } = DateTime.Now;

      




        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; } = null!;
        public int MarcaId { get; set; }
        public virtual Marca Marca { get; set; } = null!;




        
        public virtual HashSet<Imagen> Imagenes { get; set; } = new HashSet<Imagen>();
        public virtual List<PrendaTallaColorStock> PrendaTamanioColorStocks { get; set; } = new List<PrendaTallaColorStock>();
    }
}
