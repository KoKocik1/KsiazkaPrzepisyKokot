using KsiazkaPrzepisyKokot.Interfaces;
using KsiazkaPrzepisyKokot.Models;
using KsiazkaPrzepisyKokot.ObiektyPosrednie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static KsiazkaPrzepisyKokot.ObiektyPosrednie.Filtry;

namespace KsiazkaPrzepisyKokot.BuisnessLayer.Interface
{
    public interface IKompletnyPrzepisBL
    {
        //potrzebne?
        public PelnyPrzepis Pobierz(int Przepisu);
        public IEnumerable<PelnyPrzepis> PobierzPrzepisyPoSkladniku(int idSkladnika);

        public IEnumerable<PelnyPrzepis> PobierzPrzepisyPoSkladnikach(int[] idSkladnikow);
        public IEnumerable<PelnyPrzepis> PobierzPrzepisyPoRodzajuPosilku(RodzajePosilkow rodzajPosilku);

        public IEnumerable<PelnyPrzepis> PobierzPrzepisyPoFiltrze(SniadaniaF filtr);
        public IEnumerable<PelnyPrzepis> PobierzPrzepisyPoFiltrze(ObiadyF filtr);
        public IEnumerable<PelnyPrzepis> PobierzPrzepisyPoFiltrze(KolacjeF filtr);
        public IEnumerable<PelnyPrzepis> PobierzPrzepisyPoFiltrze(CiastaF filtr);
        public IEnumerable<PelnyPrzepis> PobierzPrzepisyPoFiltrze(FitF filtr);
        public IEnumerable<PelnyPrzepis> PobierzPrzepisyPoFiltrze(SalatkiF filtr);
        public IEnumerable<PelnyPrzepis> PobierzPrzepisyPoFiltrze(SloneF filtr);
        public IEnumerable<PelnyPrzepis> PobierzPrzepisyPoFiltrze(SosyF filtr);

    }
}
