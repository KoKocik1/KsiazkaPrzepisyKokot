using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KsiazkaPrzepisyKokot.Models
{
    public class DrinkiDto : Przepisy
    {
        public int idDrinka { get; set; }
        public bool wodka { get; set; }
        public bool whisky { get; set; }
        public bool rum { get; set; }
        public bool yager { get; set; }
        public bool bezalkoholowy { get; set; }
    }
}
