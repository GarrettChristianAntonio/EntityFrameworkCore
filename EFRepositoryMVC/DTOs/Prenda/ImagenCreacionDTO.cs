using System.ComponentModel.DataAnnotations;

namespace EFRepositoryMVC.DTOs.Prenda
{
    public class ImagenCreacionDTO
    {
		public string Name { get; set; } = null!;
		public string Description { get; set; } = null!;
		public string Url { get; set; } = null!;
		public int PrendaId { get; set; }
	}
}
