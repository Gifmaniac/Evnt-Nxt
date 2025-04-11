using System.ComponentModel.DataAnnotations;

namespace Evnt_Nxt
{
    public class Genre
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
