using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KsiazkaPrzepisyKokot.Models
{
    public class ObiadyDto : Przepisy
    {
        public int idObiadu { get; set; }
        public bool z_kurczakiem { get; set; }
        public bool z_wolowina { get; set; }
        public bool z_wieprzowina { get; set; }
        public bool z_mielonym { get; set; }
        public bool z_makaronem { get; set; }
        public bool z_ryzem { get; set; }
        public bool z_kartoflami { get; set; }
    }
}
