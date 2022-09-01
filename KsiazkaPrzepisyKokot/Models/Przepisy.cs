using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KsiazkaPrzepisyKokot.Models
{
    [Table("Przepisy")]
    public class Przepisy
    {
        [Key]
        public int idPrzepisu { get; set; }
        [Required, MaxLength(5000)]
        public string Przepis { get; set; }
        [Required]
        public DateTime data { get; set; }
        [MaxLength(100), Required]
        public string nazwaDania { get; set; }
        [Required]
        public int czas { get; set; }
        [Required]
        public int liczbaPorcji { get; set; }

        public String Obraz { get; set; }

    }
}
