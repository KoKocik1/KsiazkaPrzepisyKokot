using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KsiazkaPrzepisyKokot.Models
{
    public class Ciasta : Przepisy
    {
        public int idCiasta { get; set; }
        public bool drozdzowe { get; set; }
        public bool na_zimno { get; set; }
        public bool na_cieplo { get; set; }
        public bool ciasto_francuskie { get; set; }
        public bool z_owsianka { get; set; }
        public bool z_owocami { get; set; }
    }
}
