using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KsiazkaPrzepisyKokot.Models
{
    public class Sniadania
    {
        [Key]
        public int idSniadania { get; set; }
        public bool z_jajkiem { get; set; }
        public bool na_slono { get; set; }
        public bool na_slodko { get; set; }
        public bool fit { get; set; }
        public bool bez_miesa { get; set; }
        [ForeignKey("Przepis")]
        public int idPrzepis { get; set; }
    }
}
