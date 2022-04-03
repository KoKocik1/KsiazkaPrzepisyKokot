using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KsiazkaPrzepisyKokot.Models
{
    public class SosyDto : Przepisy
    {
        public int idSosu { get; set; }
        public bool slone { get; set; }
        public bool slodkie { get; set; }
    }
}
