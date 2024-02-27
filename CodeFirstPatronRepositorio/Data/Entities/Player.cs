using System.ComponentModel.DataAnnotations;

namespace CodeFirstPatronRepositorio.Data.Entities
{
    public class Player
    {
        public int PlayerId { get; set; }
        public int Ranking { get; set; }
        [Required]
        public int UserId { get; set; }
        public virtual User user { get; set; }
    }
}
