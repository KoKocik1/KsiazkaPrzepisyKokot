﻿using KsiazkaPrzepisyKokot.BuisnessLayer.Interface;
using KsiazkaPrzepisyKokot.Interfaces;
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
    public class PrzepisyBL_ : IPrzepisyBL
    {
        private readonly UnitOfWorkTest unitOfWork;

        public PrzepisyBL_(UnitOfWorkTest unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public PrzepisyBL_()
        {
            this.unitOfWork = new UnitOfWorkTest();
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
        public IEnumerable<Przepisy> PobierzPrzepisyPoSkladniku(int idSkladnika)
        {

            return null;

        }
        public Ciasta PobierzCiasta(int idPrzepisu)
        {
            return unitOfWork.PrzepisyCiastaRepo.PobierzPoId(idPrzepisu);
        }

        public IEnumerable<Ciasta> PobierzCiasta(CiastaF filtr)
        {
            return unitOfWork.PrzepisyCiastaRepo.Pobierz().Where(p =>
            p.na_cieplo == filtr.na_cieplo &&
            p.na_zimno == filtr.na_zimno &&
            p.z_owocami == filtr.z_owocami &&
            p.z_owsianka == filtr.z_owsianka &&
            p.drozdzowe == filtr.drozdzowe &&
            p.ciasto_francuskie == filtr.drozdzowe);
        }

        public IEnumerable<Ciasta> PobierzCiasta()
        {
            return unitOfWork.PrzepisyCiastaRepo.Pobierz();
        }

        public IEnumerable<Drinki> PobierzDrinki(DrinkiF filtr)
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

        public IEnumerable<Fit> PobierzFit(FitF filtr)
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

        public IEnumerable<Kolacje> PobierzKolacje(KolacjeF filtr)
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

        public IEnumerable<Obiady> PobierzObiady(ObiadyF filtr)
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

        public IEnumerable<Salatki> PobierzSalatki(SalatkiF filtr)
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

        public IEnumerable<Slone_przekaski> PobierzSlone_przekaski(SloneF filtr)
        {
            return unitOfWork.PrzepisySloneRepo.Pobierz().Where(p =>
            p.na_cieplo == filtr.na_cieplo &&
            p.na_zimno == filtr.na_zimno);
        }

        public IEnumerable<Slone_przekaski> PobierzSlone_przekaski()
        {
            return unitOfWork.PrzepisySloneRepo.Pobierz();
        }

        public IEnumerable<Sniadania> PobierzSniadania(SniadaniaF filtr)
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

        public IEnumerable<Sosy> PobierzSosy(SosyF filtr)
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
            bool usuniete = unitOfWork.PrzepisyRepo.Usun(idPrzepisu);
            update();
            return usuniete;
        }

        public IEnumerable<Przepisy> PobierzPrzepisyPoRodzajuPosilku(RodzajePosilkow rodzajPosilku)
        {
            IEnumerable<Przepisy> listaPrzepisow_ = new List<Przepisy>();
            switch (rodzajPosilku)
            {
                case RodzajePosilkow.Ciasto:
                    {
                        listaPrzepisow_ = PobierzCiasta();
                        break;
                    }
                case RodzajePosilkow.Drink:
                    {
                        listaPrzepisow_ = PobierzDrinki();
                        break;
                    }
                case RodzajePosilkow.Fit:
                    {
                        listaPrzepisow_ = PobierzFit();
                        break;
                    }
                case RodzajePosilkow.Kolacja:
                    {
                        listaPrzepisow_ = PobierzKolacje();
                        break;
                    }
                case RodzajePosilkow.Obiad:
                    {
                        listaPrzepisow_ = PobierzObiady();
                        break;
                    }
                case RodzajePosilkow.Salatka:
                    {
                        listaPrzepisow_ = PobierzSalatki();
                        break;
                    }
                case RodzajePosilkow.Slona_przekaska:
                    {
                        listaPrzepisow_ = PobierzSlone_przekaski();
                        break;
                    }
                case RodzajePosilkow.Sniadanie:
                    {
                        listaPrzepisow_ = PobierzSniadania();
                        break;
                    }
                case RodzajePosilkow.Sos:
                    {
                        listaPrzepisow_ = PobierzSosy();
                        break;
                    }
            }
            return listaPrzepisow_;

        }

        public IEnumerable<Przepisy> PobierzPrzepisyPoSkladnikach(int[] idSkladnikow)
        {
            List<Przepisy> listaPelnychPrzepisow = new List<Przepisy>();
            for (int i = 0; i < idSkladnikow.Length; i++)
            {
                IEnumerable<Przepisy> listaPrzepisow = PobierzPrzepisyPoSkladniku(idSkladnikow[i]);
                foreach (Przepisy s in listaPrzepisow)
                {
                    if (!listaPelnychPrzepisow.Contains(s))
                        listaPelnychPrzepisow.Add(s);
                }
            }
            return listaPelnychPrzepisow;
        }
        public IEnumerable<Przepisy> PobierzUlubione()
        {

            return null;
        }

        public Przepisy PobierzUlubiony(int idUlubiony)
        {
            return null;
        }
        private void update()
        {
            unitOfWork.Save();
        }

        public IEnumerable<Przepisy> PobierzPrzepisyPoSkladnikachOrazTypieDania(int[] idSkladnikow, RodzajePosilkow rodzaj)
        {
            throw new NotImplementedException();
        }
    }
}
