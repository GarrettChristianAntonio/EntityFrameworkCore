using System.ComponentModel.DataAnnotations;

namespace WebApplication1.DataAccess.Entities
{
    public class Role
    {
        [Required]
        public int Id { get; set; }


        [Required]
        public string Name { get; set; }
       
    }
}
