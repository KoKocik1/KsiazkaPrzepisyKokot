using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KsiazkaPrzepisyKokot.Models
{
    public class Przepisy
    {
        [Key]
        public int idPrzepisu { get; set; }
        [Required]
        public string Przepis { get; set; }
        [Required]
        public DateTime data { get; set; }
        [MaxLength(100), Required]
        public string nazwaDania { get; set; }
        [Required]
        public TimeSpan czas { get; set; }

        public Skladnik[] skladniki { get; set; }
    }
}
