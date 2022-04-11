using KsiazkaPrzepisyKokot.BuisnessLayer.Interface;
using KsiazkaPrzepisyKokot.Interfaces;
using KsiazkaPrzepisyKokot.Models;
using KsiazkaPrzepisyKokot.ObiektyPosrednie;
using KsiazkaPrzepisyKokot.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Testy;
using static KsiazkaPrzepisyKokot.ObiektyPosrednie.Filtry;

namespace KsiazkaPrzepisyKokot.BuisnessLayer.Implementacje
{
    public class KompletnyPrzepisBL : IKompletnyPrzepisBL
    {
        private readonly UnitOfWorkTest unitOfWork;
        private readonly PrzepisyBL przepisy;
        private readonly SkladnikiPrzepisuBL skladniki;
        public KompletnyPrzepisBL(UnitOfWorkTest unitOfWork, PrzepisyBL przepisy, SkladnikiPrzepisuBL skladniki)
        {
            this.unitOfWork = unitOfWork;
            this.przepisy = przepisy;
            this.skladniki = skladniki;
        }
        public PelnyPrzepis Pobierz(int idPrzepisu)
        {
            PelnyPrzepis nowyPrzepis = new PelnyPrzepis
            {
                przepis = unitOfWork.PrzepisyRepo.PobierzPoId(idPrzepisu),
                skladnikiPrzepisu = skladniki.PobierzSkladnikiPoPrzepisie(idPrzepisu)
             };
            
            return nowyPrzepis;
        }

        public IEnumerable<PelnyPrzepis> PobierzPrzepisyPoFiltrze(Filtry.SniadaniaF filtr)
        {
            List<PelnyPrzepis> listaPrzepisow = new List<PelnyPrzepis>();
            IEnumerable<Sniadania> lista=przepisy.PobierzSniadania(filtr);
            foreach(Sniadania s in lista)
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
            List<PelnyPrzepis> listaPrzepisow = new List<PelnyPrzepis>();
            IEnumerable<Obiady> lista = przepisy.PobierzObiady(filtr);
            foreach (Obiady s in lista)
            {
                listaPrzepisow.Add(new PelnyPrzepis
                {
                    przepis = s,
                    skladnikiPrzepisu = skladniki.PobierzSkladnikiPoPrzepisie(s.idPrzepisu)
                });
            }
            return listaPrzepisow;
        }

        public IEnumerable<PelnyPrzepis> PobierzPrzepisyPoFiltrze(Filtry.KolacjeF filtr)
        {
            List<PelnyPrzepis> listaPrzepisow = new List<PelnyPrzepis>();
            IEnumerable<Kolacje> lista = przepisy.PobierzKolacje(filtr);
            foreach (Kolacje s in lista)
            {
                listaPrzepisow.Add(new PelnyPrzepis
                {
                    przepis = s,
                    skladnikiPrzepisu = skladniki.PobierzSkladnikiPoPrzepisie(s.idPrzepisu)
                });
            }
            return listaPrzepisow;
        }

        public IEnumerable<PelnyPrzepis> PobierzPrzepisyPoFiltrze(Filtry.CiastaF filtr)
        {
            List<PelnyPrzepis> listaPrzepisow = new List<PelnyPrzepis>();
            IEnumerable<Ciasta> lista = przepisy.PobierzCiasta(filtr);
            foreach (Ciasta s in lista)
            {
                listaPrzepisow.Add(new PelnyPrzepis
                {
                    przepis = s,
                    skladnikiPrzepisu = skladniki.PobierzSkladnikiPoPrzepisie(s.idPrzepisu)
                });
            }
            return listaPrzepisow;
        }

        public IEnumerable<PelnyPrzepis> PobierzPrzepisyPoFiltrze(Filtry.FitF filtr)
        {
            List<PelnyPrzepis> listaPrzepisow = new List<PelnyPrzepis>();
            IEnumerable<Fit> lista = przepisy.PobierzFit(filtr);
            foreach (Fit s in lista)
            {
                listaPrzepisow.Add(new PelnyPrzepis
                {
                    przepis = s,
                    skladnikiPrzepisu = skladniki.PobierzSkladnikiPoPrzepisie(s.idPrzepisu)
                });
            }
            return listaPrzepisow;
        }

        public IEnumerable<PelnyPrzepis> PobierzPrzepisyPoFiltrze(Filtry.SalatkiF filtr)
        {
            List<PelnyPrzepis> listaPrzepisow = new List<PelnyPrzepis>();
            IEnumerable<Salatki> lista = przepisy.PobierzSalatki(filtr);
            foreach (Salatki s in lista)
            {
                listaPrzepisow.Add(new PelnyPrzepis
                {
                    przepis = s,
                    skladnikiPrzepisu = skladniki.PobierzSkladnikiPoPrzepisie(s.idPrzepisu)
                });
            }
            return listaPrzepisow;
        }

        public IEnumerable<PelnyPrzepis> PobierzPrzepisyPoFiltrze(Filtry.SloneF filtr)
        {
            List<PelnyPrzepis> listaPrzepisow = new List<PelnyPrzepis>();
            IEnumerable<Slone_przekaski> lista = przepisy.PobierzSlone_przekaski(filtr);
            foreach (Slone_przekaski s in lista)
            {
                listaPrzepisow.Add(new PelnyPrzepis
                {
                    przepis = s,
                    skladnikiPrzepisu = skladniki.PobierzSkladnikiPoPrzepisie(s.idPrzepisu)
                });
            }
            return listaPrzepisow;
        }

        public IEnumerable<PelnyPrzepis> PobierzPrzepisyPoFiltrze(Filtry.SosyF filtr)
        {
            List<PelnyPrzepis> listaPrzepisow = new List<PelnyPrzepis>();
            IEnumerable<Sosy> lista = przepisy.PobierzSosy(filtr);
            foreach (Sosy s in lista)
            {
                listaPrzepisow.Add(new PelnyPrzepis
                {
                    przepis = s,
                    skladnikiPrzepisu = skladniki.PobierzSkladnikiPoPrzepisie(s.idPrzepisu)
                });
            }
            return listaPrzepisow;
        }

        public IEnumerable<PelnyPrzepis> PobierzPrzepisyPoFiltrze(DrinkiF filtr)
        {
            List<PelnyPrzepis> listaPrzepisow = new List<PelnyPrzepis>();
            IEnumerable<Drinki> lista = przepisy.PobierzDrinki(filtr);
            foreach (Drinki s in lista)
            {
                listaPrzepisow.Add(new PelnyPrzepis
                {
                    przepis = s,
                    skladnikiPrzepisu = skladniki.PobierzSkladnikiPoPrzepisie(s.idPrzepisu)
                });
            }
            return listaPrzepisow;
        }

        public IEnumerable<PelnyPrzepis> PobierzPrzepisyPoRodzajuPosilku(RodzajePosilkow rodzajPosilku)
        {
            IEnumerable<Przepisy> listaPrzepisow_= new List<Przepisy>();
            switch (rodzajPosilku)
            {
                case RodzajePosilkow.Ciasto:
                    {
                        listaPrzepisow_ = przepisy.PobierzCiasta();
                        break;
                    }
                case RodzajePosilkow.Drink:
                    {
                        listaPrzepisow_ = przepisy.PobierzDrinki();
                        break;
                    }
                case RodzajePosilkow.Fit:
                    {
                        listaPrzepisow_ = przepisy.PobierzFit();
                        break;
                    }
                case RodzajePosilkow.Kolacja:
                    {
                        listaPrzepisow_ = przepisy.PobierzKolacje();
                        break;
                    }
                case RodzajePosilkow.Obiad:
                    {
                        listaPrzepisow_ = przepisy.PobierzObiady();
                        break;
                    }
                case RodzajePosilkow.Salatka:
                    {
                        listaPrzepisow_ = przepisy.PobierzSalatki();
                        break;
                    }
                case RodzajePosilkow.Slona_przekaska:
                    {
                        listaPrzepisow_ = przepisy.PobierzSlone_przekaski();
                        break;
                    }
                case RodzajePosilkow.Sniadanie:
                    {
                        listaPrzepisow_ = przepisy.PobierzSniadania();
                        break;
                    }
                case RodzajePosilkow.Sos:
                    {
                        listaPrzepisow_ = przepisy.PobierzSosy();
                        break;
                    }
            }
                    List<PelnyPrzepis> listaPrzepisow = new List<PelnyPrzepis>();
                    foreach (Przepisy s in listaPrzepisow_)
                    {
                        listaPrzepisow.Add(new PelnyPrzepis
                        {
                            przepis = s,
                            skladnikiPrzepisu = skladniki.PobierzSkladnikiPoPrzepisie(s.idPrzepisu)
                        });
                    }
                    return listaPrzepisow;

        }

        public IEnumerable<PelnyPrzepis> PobierzPrzepisyPoSkladnikach(int[] idSkladnikow)
        {
            List<PelnyPrzepis> listaPelnychPrzepisow = new List<PelnyPrzepis>();
            for (int i = 0; i < idSkladnikow.Length; i++)
            {
                IEnumerable<Przepisy> listaPrzepisow = skladniki.PobierzPrzepisyPoSkladniku(idSkladnikow[i]);
                foreach (Przepisy s in listaPrzepisow)
                {
                    PelnyPrzepis pp = new PelnyPrzepis
                    {
                        przepis = s,
                        skladnikiPrzepisu = skladniki.PobierzSkladnikiPoPrzepisie(s.idPrzepisu)
                    };

                    if(!listaPelnychPrzepisow.Contains(pp))
                    listaPelnychPrzepisow.Add(pp);
                }
            }
            return listaPelnychPrzepisow;
        }

        public IEnumerable<PelnyPrzepis> PobierzPrzepisyPoSkladniku(int idSkladnika)
        {
            List<PelnyPrzepis> listaPelnychPrzepisow = new List<PelnyPrzepis>();
            IEnumerable<Przepisy> listaPrzepisow = skladniki.PobierzPrzepisyPoSkladniku(idSkladnika);
            foreach (Przepisy s in listaPrzepisow)
            {
                listaPelnychPrzepisow.Add(new PelnyPrzepis
                {
                    przepis = s,
                    skladnikiPrzepisu = skladniki.PobierzSkladnikiPoPrzepisie(s.idPrzepisu)
                });
            }
            return listaPelnychPrzepisow;
        }
    }
}
