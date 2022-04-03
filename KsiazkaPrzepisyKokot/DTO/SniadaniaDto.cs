using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KsiazkaPrzepisyKokot.Models
{
    public class SniadaniaDto : Przepisy
    {
        public int idSniadania { get; set; }
        public bool z_jajkiem { get; set; }
        public bool na_slono { get; set; }
        public bool na_slodko { get; set; }
        public bool fit { get; set; }
        public bool bez_miesa { get; set; }
    }
}
