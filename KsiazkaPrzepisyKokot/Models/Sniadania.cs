using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KsiazkaPrzepisyKokot.Models
{
    [Table("Sniadania")]
    public class Sniadania : Przepisy
    {

        public bool z_jajkiem { get; set; }
        public bool na_slono { get; set; }
        public bool na_slodko { get; set; }
        public bool fit { get; set; }
        public bool bez_miesa { get; set; }

    }
}
