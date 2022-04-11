using KsiazkaPrzepisyKokot.BuisnessLayer.Interface;
using KsiazkaPrzepisyKokot.Models;
using KsiazkaPrzepisyKokot.ObiektyPosrednie;
using KsiazkaPrzepisyKokot.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Testy;

namespace KsiazkaPrzepisyKokot.BuisnessLayer.Implementacje
{
    public class PrzepisyBL : IPrzepisyBL
    {
        private readonly UnitOfWorkTest unitOfWork;
        public PrzepisyBL(UnitOfWorkTest unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public Przepisy Dodaj(Przepisy przepis)
        {
            unitOfWork.PrzepisyRepo.Dodaj(przepis);
            update();
            return przepis;
        }

        public Przepisy Edytuj(Przepisy przepis)
        {
            unitOfWork.PrzepisyRepo.Aktualizuj(przepis);
            update();
            return przepis;
        }


        public Przepisy Pobierz(int idPrzepisu)
        {
            return unitOfWork.PrzepisyRepo.PobierzPoId(idPrzepisu);
        }

        public IEnumerable<Przepisy> Pobierz()
        {
            return unitOfWork.PrzepisyRepo.Pobierz();
        }

        public Ciasta PobierzCiasta(int idPrzepisu)
        {
            return unitOfWork.PrzepisyCiastaRepo.PobierzPoId(idPrzepisu);
        }

        public IEnumerable<Ciasta> PobierzCiasta(Filtry.CiastaF filtr)
        {
            return unitOfWork.PrzepisyCiastaRepo.Pobierz().Where(p=>
            p.na_cieplo==filtr.na_cieplo&&
            p.na_zimno==filtr.na_zimno&&
            p.z_owocami==filtr.z_owocami&&
            p.z_owsianka==filtr.z_owsianka&&
            p.drozdzowe==filtr.drozdzowe&&
            p.ciasto_francuskie==filtr.drozdzowe);
        }

        public IEnumerable<Ciasta> PobierzCiasta()
        {
            return unitOfWork.PrzepisyCiastaRepo.Pobierz();
        }

        public IEnumerable<Drinki> PobierzDrinki(Filtry.DrinkiF filtr)
        {
            return unitOfWork.PrzepisyDrinkiRepo.Pobierz().Where(p =>
            p.bezalkoholowy = filtr.bezalkoholowy &&
            p.rum == filtr.rum &&
            p.whisky == filtr.whisky &&
            p.wodka == filtr.wodka &&
            p.yager == filtr.yager);
        }

        public Drinki PobierzDrinki(int idPrzepisu)
        {
            return unitOfWork.PrzepisyDrinkiRepo.PobierzPoId(idPrzepisu);
        }

        public IEnumerable<Drinki> PobierzDrinki()
        {
            return unitOfWork.PrzepisyDrinkiRepo.Pobierz();
        }

        public Fit PobierzFit(int idPrzepisu)
        {
            return unitOfWork.PrzepisyFitRepo.PobierzPoId(idPrzepisu);
        }

        public IEnumerable<Fit> PobierzFit(Filtry.FitF filtr)
        {
            return unitOfWork.PrzepisyFitRepo.Pobierz().Where(p =>
            p.z_jogurtem == filtr.z_jogurtem &&
            p.z_kasza == filtr.z_kasza &&
            p.z_owocami == filtr.z_owocami &&
            p.z_owsianka == filtr.z_owsianka &&
            p.z_ryzem == filtr.z_ryzem);
        }

        public IEnumerable<Fit> PobierzFit()
        {
            return unitOfWork.PrzepisyFitRepo.Pobierz();
        }

        public Kolacje PobierzKolacje(int idPrzepisu)
        {
            return unitOfWork.PrzepisyKolacjeRepo.PobierzPoId(idPrzepisu);
        }

        public IEnumerable<Kolacje> PobierzKolacje(Filtry.KolacjeF filtr)
        {
            return unitOfWork.PrzepisyKolacjeRepo.Pobierz().Where(p =>
            p.fit == filtr.fit &&
            p.na_slodko == filtr.na_slodko &&
            p.na_slono == filtr.na_slono);
        }

        public IEnumerable<Kolacje> PobierzKolacje()
        {
            return unitOfWork.PrzepisyKolacjeRepo.Pobierz();
        }

        public Obiady PobierzObiady(int idPrzepisu)
        {
            return unitOfWork.PrzepisyObiadyRepo.PobierzPoId(idPrzepisu);
        }

        public IEnumerable<Obiady> PobierzObiady(Filtry.ObiadyF filtr)
        {
            return unitOfWork.PrzepisyObiadyRepo.Pobierz().Where(p =>
            p.z_kartoflami == filtr.z_kartoflami &&
            p.z_kurczakiem == filtr.z_kurczakiem &&
            p.z_makaronem == filtr.z_makaronem &&
            p.z_mielonym == filtr.z_mielonym &&
            p.z_ryzem == filtr.z_ryzem &&
            p.z_wieprzowina == filtr.z_wieprzowina &&
            p.z_wolowina == filtr.z_wolowina);
        }

        public IEnumerable<Obiady> PobierzObiady()
        {
            return unitOfWork.PrzepisyObiadyRepo.Pobierz();
        }

        public Salatki PobierzSalatki(int idPrzepisu)
        {
            return unitOfWork.PrzepisySalatkiRepo.PobierzPoId(idPrzepisu);
        }

        public IEnumerable<Salatki> PobierzSalatki(Filtry.SalatkiF filtr)
        {
            return unitOfWork.PrzepisySalatkiRepo.Pobierz().Where(p =>
            p.z_makaronem == filtr.z_makaronem &&
            p.z_kurczakiem == filtr.z_kurczakiem &&
            p.na_zimno == filtr.na_zimno &&
            p.na_cieplo == filtr.na_cieplo);
        }

        public IEnumerable<Salatki> PobierzSalatki()
        {
            return unitOfWork.PrzepisySalatkiRepo.Pobierz();
        }

        public Slone_przekaski PobierzSlone_przekaski(int idPrzepisu)
        {
            return unitOfWork.PrzepisySloneRepo.PobierzPoId(idPrzepisu);
        }

        public IEnumerable<Slone_przekaski> PobierzSlone_przekaski(Filtry.SloneF filtr)
        {
            return unitOfWork.PrzepisySloneRepo.Pobierz().Where(p =>
            p.na_cieplo == filtr.na_cieplo &&
            p.na_zimno == filtr.na_zimno);
        }

        public IEnumerable<Slone_przekaski> PobierzSlone_przekaski()
        {
            return unitOfWork.PrzepisySloneRepo.Pobierz();
        }

        public IEnumerable<Sniadania> PobierzSniadania(Filtry.SniadaniaF filtr)
        {
            return unitOfWork.PrzepisySniadaniaRepo.Pobierz().Where(p =>
            p.bez_miesa == filtr.bez_miesa &&
            p.na_slodko == filtr.na_slodko &&
            p.na_slono == filtr.na_slono &&
            p.z_jajkiem == filtr.z_jajkiem);
        }

        public IEnumerable<Sniadania> PobierzSniadania()
        {
            return unitOfWork.PrzepisySniadaniaRepo.Pobierz();
        }

        public Sniadania PobierzSniadania(int idPrzepisu)
        {
            return unitOfWork.PrzepisySniadaniaRepo.PobierzPoId(idPrzepisu);
        }

        public Sosy PobierzSosy(int idPrzepisu)
        {
            return unitOfWork.PrzepisySosyaRepo.PobierzPoId(idPrzepisu);
        }

        public IEnumerable<Sosy> PobierzSosy(Filtry.SosyF filtr)
        {
            return unitOfWork.PrzepisySosyaRepo.Pobierz().Where(p =>
            p.slone == filtr.slone &&
            p.slodkie == filtr.slodkie);
        }

        public IEnumerable<Sosy> PobierzSosy()
        {
            return unitOfWork.PrzepisySosyaRepo.Pobierz();
        }

        public bool Usun(int idPrzepisu)
        {
           bool usuniete= unitOfWork.PrzepisyRepo.Usun(idPrzepisu);
            update();
            return usuniete;
        }
        private void update()
        {
            unitOfWork.Save();
        }
    }
}
