namespace EFRepositoryMVC.Models.EntitiesPrenda
{
	public class Categoria
	{
		public int Id { get; set; }
		public string Name { get; set; } = null!;
		public virtual HashSet<Prenda> Prendas { get; set; } = new HashSet<Prenda>();
	}
}
