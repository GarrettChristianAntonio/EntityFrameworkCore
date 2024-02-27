using System.ComponentModel.DataAnnotations;

namespace EFRepositoryMVC.DTOs.Prenda
{
	public class CategoriaCreacionDTO
	{
		[Required(ErrorMessage ="No puede estar vacio")]
		public string Name { get; set; } = null!;
	}
}
