using KsiazkaPrzepisyKokot.BuisnessLayer.Interface;
using KsiazkaPrzepisyKokot.Interfaces;
using KsiazkaPrzepisyKokot.Models;
using KsiazkaPrzepisyKokot.ObiektyPosrednie;
using KsiazkaPrzepisyKokot.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KsiazkaPrzepisyKokot.BuisnessLayer.Implementacje
{
    public class KompletnyPrzepisBL : IKompletnyPrzepisBL
    {
        private readonly UnitOfWork_ unitOfWork;
        private readonly PrzepisyBL przepisy;
        private readonly SkladnikiPrzepisuBL skladniki;
        public KompletnyPrzepisBL(UnitOfWork_ unitOfWork, PrzepisyBL przepisy, SkladnikiPrzepisuBL skladniki)
        {
            this.unitOfWork = unitOfWork;
            this.przepisy = przepisy;
            this.skladniki = skladniki;
        }
        public PelnyPrzepis Pobierz(int Przepisu)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PelnyPrzepis> PobierzPrzepisyPoFiltrze(Filtry.SniadaniaF filtr)
        {
            List<PelnyPrzepis> listaPrzepisow = new List<PelnyPrzepis>();
            IEnumerable<Sniadania> listaSniadan=przepisy.pobierzSniadania(filtr);
            foreach(Sniadania s in listaSniadan)
            {
                listaPrzepisow.Add(new PelnyPrzepis
                {
                    przepis = s,
                    skladnikiPrzepisu = skladniki.PobierzSkladnikiPoPrzepisie(s.idPrzepisu)
                });
            }
            return listaPrzepisow;
        }

        public IEnumerable<PelnyPrzepis> PobierzPrzepisyPoFiltrze(Filtry.ObiadyF filtr)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PelnyPrzepis> PobierzPrzepisyPoFiltrze(Filtry.KolacjeF filtr)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PelnyPrzepis> PobierzPrzepisyPoFiltrze(Filtry.CiastaF filtr)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PelnyPrzepis> PobierzPrzepisyPoFiltrze(Filtry.FitF filtr)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PelnyPrzepis> PobierzPrzepisyPoFiltrze(Filtry.SalatkiF filtr)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PelnyPrzepis> PobierzPrzepisyPoFiltrze(Filtry.SloneF filtr)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PelnyPrzepis> PobierzPrzepisyPoFiltrze(Filtry.SosyF filtr)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PelnyPrzepis> PobierzPrzepisyPoRodzajuPosilku(RodzajePosilkow rodzajPosilku)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PelnyPrzepis> PobierzPrzepisyPoSkladnikach(int[] idSkladnikow)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PelnyPrzepis> PobierzPrzepisyPoSkladniku(int idSkladnika)
        {
            throw new NotImplementedException();
        }
    }
}
