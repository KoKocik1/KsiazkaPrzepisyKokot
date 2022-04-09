using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KsiazkaPrzepisyKokot.Models
{
    [Table("Obiady")]
    public class Obiady : Przepisy
    {

        public bool z_kurczakiem { get; set; }
        public bool z_wolowina { get; set; }
        public bool z_wieprzowina { get; set; }
        public bool z_mielonym { get; set; }
        public bool z_makaronem { get; set; }
        public bool z_ryzem { get; set; }
        public bool z_kartoflami { get; set; }

    }
}
