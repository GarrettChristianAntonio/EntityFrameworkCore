using EFRepositoryMVC.Models.EntitiesPrenda;
using System.ComponentModel.DataAnnotations;

namespace EFRepositoryMVC.DTOs.Prenda
{
    public class ColorCreacionDTO
    {
		public string Name { get; set; } = null!;
		public string ColorInRGB { get; set; } = null!;
	}
}
