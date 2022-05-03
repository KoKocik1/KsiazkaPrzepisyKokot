using KsiazkaPrzepisyKokot.BuisnessLayer.Interface;
using KsiazkaPrzepisyKokot.Models;
using KsiazkaPrzepisyKokot.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KsiazkaPrzepisyKokot.BuisnessLayer.Implementacje
{
    public class UlubioneBL : IUlubioneBL
    {
        private readonly UnitOfWork_ unitOfWork;
        public UlubioneBL(UnitOfWork_ unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public Ulubione Dodaj(Ulubione przepis)
        {
            unitOfWork.UlubioneRepo.Dodaj(przepis);
            update();
            return przepis;
        }

        public Ulubione Pobierz(int idUlubione)
        {
            return unitOfWork.UlubioneRepo.PobierzPoId(idUlubione);
        }

        public IEnumerable<Ulubione> Pobierz()
        {
            return unitOfWork.UlubioneRepo.Pobierz();
        }

        public bool Usun(int idUlubione)
        {
            Ulubione u = Pobierz(idUlubione);
            if (u == null)
                return false;
            bool usuniete= unitOfWork.UlubioneRepo.Usun(u);
            update();
            return usuniete; 
        }
        private void update()
        {
            unitOfWork.Save();
        }
    }
}
