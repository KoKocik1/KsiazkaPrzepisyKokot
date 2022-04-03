using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KsiazkaPrzepisyKokot.Models
{
    public class Slone_przekaskiDto : Przepisy
    {
        public int idSlonePrzekaski { get; set; }
        public bool na_zimno { get; set; }
        public bool na_cieplo { get; set; }
    }
}
