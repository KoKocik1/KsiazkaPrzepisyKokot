using KsiazkaPrzepisyKokot.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KsiazkaPrzepisyKokot.ObiektyPosrednie
{
    public class PelnyPrzepis
    {
        public Przepisy przepis;
        public IEnumerable<WszystkieSkladniki> skladnikiPrzepisu;
    }
}
