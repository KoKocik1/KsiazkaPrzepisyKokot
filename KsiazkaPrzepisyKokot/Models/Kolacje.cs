using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KsiazkaPrzepisyKokot.Models
{
    [Table("Kolacje")]
    public class Kolacje : Przepisy
    {
        public bool na_slono { get; set; }
        public bool na_slodko { get; set; }
        public bool fit { get; set; }

    }
}
