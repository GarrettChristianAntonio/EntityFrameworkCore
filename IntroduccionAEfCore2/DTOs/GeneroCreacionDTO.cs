using System.ComponentModel.DataAnnotations;

namespace IntroduccionAEfCore2.DTOs
{
    public class GeneroCreacionDTO
    {
        [StringLength(maximumLength: 150)]
        public string Nombre { get; set; } = null!;
    }
}
