using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KsiazkaPrzepisyKokot.Models
{
    [Table("Salatki")]
    public class Salatki : Przepisy
    {

        public bool z_kurczakiem { get; set; }
        public bool na_cieplo { get; set; }
        public bool na_zimno { get; set; }
        public bool z_makaronem { get; set; }

    }
}
