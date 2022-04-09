using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KsiazkaPrzepisyKokot.Models
{
    [Table("Slone_przekaski")]
    public class Slone_przekaski : Przepisy
    {

        public bool na_zimno { get; set; }
        public bool na_cieplo { get; set; }

    }
}
