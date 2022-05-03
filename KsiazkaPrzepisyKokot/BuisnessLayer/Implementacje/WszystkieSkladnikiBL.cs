using KsiazkaPrzepisyKokot.BuisnessLayer.Interface;
using KsiazkaPrzepisyKokot.Models;
using KsiazkaPrzepisyKokot.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KsiazkaPrzepisyKokot.BuisnessLayer.Implementacje
{
    public class WszystkieSkladnikiBL : IWszystkieSkladnikiBL
    {
        private readonly UnitOfWork_ unitOfWork;
        public WszystkieSkladnikiBL(UnitOfWork_ unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public WszystkieSkladniki Dodaj(WszystkieSkladniki skladnik)
        {
            unitOfWork.WszystkieSkladnikiRepo.Dodaj(skladnik);
            update();
            return skladnik;
        }

        public WszystkieSkladniki Edytuj(WszystkieSkladniki skladnik)
        {
            unitOfWork.WszystkieSkladnikiRepo.Aktualizuj(skladnik);
            update();
            return skladnik;
        }

        public WszystkieSkladniki EdytujGram(int idSkladnik, double gram)
        {
            WszystkieSkladniki s = Pobierz(idSkladnik);
            if (s == null)
                throw new ArgumentException("brak takiego skladnika w bazie wszystkieSkladniki");
            s.gram_kcal = gram;
            unitOfWork.WszystkieSkladnikiRepo.Aktualizuj(s);
            update();
            return s;
        }

        public WszystkieSkladniki EdytujLyzeczka(int idSkladnik, double lyzeczka)
        {
            WszystkieSkladniki s = Pobierz(idSkladnik);
            if (s == null)
                throw new ArgumentException("brak takiego skladnika w bazie wszystkieSkladniki");
            s.lyzeczka_kcal = lyzeczka;
            unitOfWork.WszystkieSkladnikiRepo.Aktualizuj(s);
            update();
            return s;
        }

        public WszystkieSkladniki EdytujLyzka(int idSkladnik, double lyzka)
        {
            WszystkieSkladniki s = Pobierz(idSkladnik);
            if (s == null)
                throw new ArgumentException("brak takiego skladnika w bazie wszystkieSkladniki");
            s.lyzka_kcal = lyzka;
            unitOfWork.WszystkieSkladnikiRepo.Aktualizuj(s);
            update();
            return s;
        }

        public WszystkieSkladniki EdytujSkladnik(int idSkladnik, string skladnik)
        {
            WszystkieSkladniki s = Pobierz(idSkladnik);
            if (s == null)
                throw new ArgumentException("brak takiego skladnika w bazie wszystkieSkladniki");
            s.skladnik = skladnik;
            unitOfWork.WszystkieSkladnikiRepo.Aktualizuj(s);
            update();
            return s;
        }

        public WszystkieSkladniki EdytujSzklanka(int idSkladnik, double szklanka)
        {
            WszystkieSkladniki s = Pobierz(idSkladnik);
            if (s == null)
                throw new ArgumentException("brak takiego skladnika w bazie wszystkieSkladniki");
            s.szklanka_kcal = szklanka;
            unitOfWork.WszystkieSkladnikiRepo.Aktualizuj(s);
            update();
            return s;
        }

        public WszystkieSkladniki Pobierz(int idSkladnik)
        {
            return unitOfWork.WszystkieSkladnikiRepo.PobierzPoId(idSkladnik);
        }

        public IEnumerable<WszystkieSkladniki> Pobierz()
        {
            return unitOfWork.WszystkieSkladnikiRepo.Pobierz();
        }

        public bool Usun(int idSkladnik)
        {

            bool usuniete = unitOfWork.WszystkieSkladnikiRepo.Usun(idSkladnik);
            update();
            return usuniete;
        }
        private void update()
        {
            unitOfWork.Save();
        }
    }
}
