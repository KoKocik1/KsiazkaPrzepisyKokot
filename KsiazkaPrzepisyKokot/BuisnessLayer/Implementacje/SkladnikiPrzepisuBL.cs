using KsiazkaPrzepisyKokot.BuisnessLayer.Interface;
using KsiazkaPrzepisyKokot.Models;
using KsiazkaPrzepisyKokot.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KsiazkaPrzepisyKokot.BuisnessLayer.Implementacje
{
    public class SkladnikiPrzepisuBL : ISkladnikiPrzepisuBL
    {

        private readonly UnitOfWork_ unitOfWork;
        public SkladnikiPrzepisuBL(UnitOfWork_ unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public SkladnikiPrzepisu Dodaj(SkladnikiPrzepisu skladnik)
        {
            unitOfWork.SkladnikiPrzepisuRepo.Dodaj(skladnik);
            update();
            return skladnik;
        }


        public SkladnikiPrzepisu Dodaj(int idPrzepisu, int idSkladnik, string miara, int ilosc)
        {
            Przepisy p = unitOfWork.PrzepisyRepo.PobierzPoId(idPrzepisu);
            WszystkieSkladniki w = unitOfWork.WszystkieSkladnikiRepo.PobierzPoId(idSkladnik);
            if (p != null && w != null) {
                SkladnikiPrzepisu skladnikNowy = new SkladnikiPrzepisu{
                    idPrzepisu = idPrzepisu,
                    idSkladnika = idSkladnik,
                    przepis=p,
                    wszystkieSkladniki=w,
                    jaka_miara = miara,
                    ilosc = ilosc
                };
            Dodaj(skladnikNowy);
            return skladnikNowy;
        }
        else throw new ArgumentException("błędne id przepisu lub skladnika");
        }

        public SkladnikiPrzepisu Dodaj(Przepisy przepis, WszystkieSkladniki skladnik, string miara, int ilosc)
        {

            SkladnikiPrzepisu nowySkladnikPrzepisu= new SkladnikiPrzepisu{
                przepis=przepis,
                wszystkieSkladniki=skladnik,
                idPrzepisu=przepis.idPrzepisu,
                idWszystkieSkladniki=skladnik.idWszystkieSkladniki,
                jaka_miara=miara,
                ilosc=ilosc
            };
            Dodaj(nowySkladnikPrzepisu);
            return nowySkladnikPrzepisu;
        }

        public SkladnikiPrzepisu EdytujIlosc(int idPrzepisu, int idSkladnik, int ilosc)
        {
            SkladnikiPrzepisu s = Pobierz(idSkladnik, idPrzepisu);
            if (s == null)
                throw new ArgumentException("brak takiego skladnika w bazie skladnikiPrzepisu");
            s.ilosc = ilosc;
            unitOfWork.SkladnikiPrzepisuRepo.Aktualizuj(s);
            update();
            return s;
        }

        public SkladnikiPrzepisu EdytujMiara(int idPrzepisu, int idSkladnik, string miara)
        {
            SkladnikiPrzepisu s = Pobierz(idSkladnik,idPrzepisu);
            if (s == null)
                throw new ArgumentException("brak takiego skladnika w bazie skladnikiPrzepisu");
            s.jaka_miara = miara;
            unitOfWork.SkladnikiPrzepisuRepo.Aktualizuj(s);
            update();
            return s;
        }

        public SkladnikiPrzepisu Pobierz(int idSkladnika, int idPrzepisu)
        {
            return unitOfWork.SkladnikiPrzepisuRepo.Pobierz().Where(p => p.idPrzepisu == idPrzepisu&&p.idSkladnika==idSkladnika).FirstOrDefault();
        }

        public IEnumerable<SkladnikiPrzepisu> PobierzPoPrzepisie(int idPrzepisu)
        {
            return unitOfWork.SkladnikiPrzepisuRepo.Pobierz().Where(p => p.idPrzepisu == idPrzepisu);
        }

        public IEnumerable<SkladnikiPrzepisu> PobierzPoSkladniku(int idSkladnika)
        {
            return unitOfWork.SkladnikiPrzepisuRepo.Pobierz().Where(p => p.idSkladnika == idSkladnika);
        }

        public IEnumerable<Przepisy> PobierzPrzepisyPoSkladniku(int idSkladnika)
        {
            IEnumerable<SkladnikiPrzepisu> skladniki = PobierzPoSkladniku(idSkladnika);
            List<Przepisy> znalezionePrzepisy= new List<Przepisy>();
            foreach (SkladnikiPrzepisu s in skladniki)
            {
                Przepisy p = unitOfWork.PrzepisyRepo.PobierzPoId(s.idPrzepisu);
                if(p!=null)
                znalezionePrzepisy.Add(p);
            }
            return znalezionePrzepisy;

        }

        public IEnumerable<WszystkieSkladniki> PobierzSkladnikiPoPrzepisie(int idPrzepisu)
        {
            IEnumerable<SkladnikiPrzepisu> skladniki = PobierzPoPrzepisie(idPrzepisu);
            List<WszystkieSkladniki> znalezioneSkladniki = new List<WszystkieSkladniki>();
            foreach (SkladnikiPrzepisu s in skladniki)
            {
                WszystkieSkladniki w = unitOfWork.WszystkieSkladnikiRepo.PobierzPoId(s.idSkladnika);
                if (w != null)
                    znalezioneSkladniki.Add(w);
            }
            return znalezioneSkladniki;
        }

        public bool UsunSkladnikZprzepisu(int idSkladnika, int idPrzepisu)
        {
            SkladnikiPrzepisu s = Pobierz(idSkladnika, idPrzepisu);
            if (s == null)
                return false;

            bool usuniete= unitOfWork.SkladnikiPrzepisuRepo.Usun(s);
            update();
            return usuniete;
        }
        private void update()
        {
            unitOfWork.Save();
        }
    }
}
