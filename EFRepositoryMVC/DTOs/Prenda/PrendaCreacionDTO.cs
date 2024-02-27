using System.ComponentModel.DataAnnotations;

namespace EFRepositoryMVC.DTOs.Prenda
{
    public class PrendaCreacionDTO
    {

		public string Name { get; set; } = null!;
		public string Description { get; set; } = null!;
		public decimal Price { get; set; }
		public bool Available { get; set; } = false;

	}
}
