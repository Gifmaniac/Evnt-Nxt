using Evnt_Nxt.Pages;
using System.ComponentModel.DataAnnotations;

namespace Evnt_Nxt
{
    public class Artist
    {
        [Key] 
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
