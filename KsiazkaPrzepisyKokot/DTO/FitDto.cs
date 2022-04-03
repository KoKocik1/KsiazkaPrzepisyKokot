using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KsiazkaPrzepisyKokot.Models
{
    public class FitDto : Przepisy
    {
        public int idFit { get; set; }
        public bool z_owsianka { get; set; }
        public bool z_jogurtem { get; set; }
        public bool z_owocami { get; set; }
        public bool z_kasza { get; set; }
        public bool z_ryzem { get; set; }
    }
}
