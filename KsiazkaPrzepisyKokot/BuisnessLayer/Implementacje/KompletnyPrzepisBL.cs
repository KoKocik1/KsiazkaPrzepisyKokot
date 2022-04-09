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
            IEnumerable<Sniadania> listaSniadan=przepisy.PobierzSniadania(filtr);
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
            List<PelnyPrzepis> listaPrzepisow = new List<PelnyPrzepis>();
            IEnumerable<Obiady> listaSniadan = przepisy.PobierzObiady(filtr);
            foreach (Obiady s in listaSniadan)
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
            IEnumerable<Kolacje> listaSniadan = przepisy.PobierzKolacje(filtr);
            foreach (Kolacje s in listaSniadan)
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
            IEnumerable<Ciasta> listaSniadan = przepisy.PobierzCiasta(filtr);
            foreach (Ciasta s in listaSniadan)
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
            IEnumerable<Fit> listaSniadan = przepisy.PobierzFit(filtr);
            foreach (Fit s in listaSniadan)
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
            IEnumerable<Salatki> listaSniadan = przepisy.PobierzSalatki(filtr);
            foreach (Salatki s in listaSniadan)
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
            IEnumerable<Slone_przekaski> listaSniadan = przepisy.PobierzSlone_przekaski(filtr);
            foreach (Slone_przekaski s in listaSniadan)
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
            IEnumerable<Sosy> listaSniadan = przepisy.PobierzSosy(filtr);
            foreach (Sosy s in listaSniadan)
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
