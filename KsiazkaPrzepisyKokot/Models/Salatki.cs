using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KsiazkaPrzepisyKokot.Models
{
    public class Salatki : Przepisy
    {
        public int idSalatki { get; set; }
        public bool z_kasz_kurczakiem { get; set; }
        public bool na_cieplo { get; set; }
        public bool na_zimno { get; set; }
        public bool z_makaronem { get; set; }
    }
}
