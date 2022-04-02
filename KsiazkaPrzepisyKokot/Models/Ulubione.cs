using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KsiazkaPrzepisyKokot.Models
{
    public class Ulubione
    {
        public int idUlubione { get; set; }
        public Przepisy przepis { get; set; }
    }
}
