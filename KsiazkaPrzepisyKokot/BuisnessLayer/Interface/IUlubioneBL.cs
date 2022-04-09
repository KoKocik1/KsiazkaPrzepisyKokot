using KsiazkaPrzepisyKokot.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KsiazkaPrzepisyKokot.BuisnessLayer.Interface
{
    public interface IUlubioneBL
    {
        public Ulubione Dodaj(Ulubione przepis);
        public bool Usun(int idUlubione);
        public Ulubione Pobierz(int idUlubione);
        public IEnumerable<Ulubione> Pobierz();
    }
}
