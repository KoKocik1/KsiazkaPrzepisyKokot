using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KsiazkaPrzepisyKokot.Models
{
    public class Skladnik
    {
        public int idSkladnika { get; set; }
        public WszystkieSkladniki skladnik { get; set; }
        public Jaka_miara jaka_miara { get; set; }
        public int ilosc { get; set; }
    }
}
