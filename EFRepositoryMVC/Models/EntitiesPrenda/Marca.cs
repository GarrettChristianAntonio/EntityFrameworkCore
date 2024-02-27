using System.ComponentModel.DataAnnotations;

namespace EFRepositoryMVC.Models.EntitiesPrenda
{
    public class Marca
    {
       public int Id { get; set; }
       public string Name { get; set; } = null!;
       public virtual HashSet<Prenda> Prendas { get; set; }= new HashSet<Prenda>();

    }
}
