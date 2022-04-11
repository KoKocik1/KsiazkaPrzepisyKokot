using KsiazkaPrzepisyKokot.Models;
using KsiazkaPrzepisyKokot.Repository.Interfaces;
using KsiazkaPrzepisyKokot.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using static Testy.TestMockRepo;

namespace Testy
{
    public class UnitOfWorkTest : IUnitOfWork
    {
        public IRepository<Log> log_;
        public IRepository<Przepisy> przepisy_;
        public IRepository<Sniadania> sniadania_;
        public IRepository<Obiady> obiady_;
        public IRepository<Kolacje> kolacje_;
        public IRepository<Ciasta> ciasta_;
        public IRepository<Drinki> drinki_;
        public IRepository<Fit> fit_;
        public IRepository<Slone_przekaski> slone_;
        public IRepository<Salatki> salatki_;
        public IRepository<Sosy> sosy_;
        public IRepository<SkladnikiPrzepisu> skladnikiPrzepisu_;
        public IRepository<WszystkieSkladniki> wszystkieSkladniki_;
        public IRepository<Ulubione> ulubione_;
        public IRepository<Log> LogRepo
        {
            get
            {
                if (log_ == null)
                {
                    log_ = new MockRepository<Log>().Object;
                }
                return log_;
            }
        }

        public IRepository<Przepisy> PrzepisyRepo
        {
            get
            {
                if (przepisy_ == null)
                {
                    przepisy_ = new MockRepository<Przepisy>().Object;
                }
                return przepisy_;
            }
        }

        public IRepository<SkladnikiPrzepisu> SkladnikiPrzepisuRepo
        {
            get
            {
                if (skladnikiPrzepisu_ == null)
                {
                    skladnikiPrzepisu_ =new MockRepository<SkladnikiPrzepisu>().Object;
                }
                return skladnikiPrzepisu_;
            }
        }

        public IRepository<WszystkieSkladniki> WszystkieSkladnikiRepo
        {
            get
            {
                if (wszystkieSkladniki_ == null)
                {
                    wszystkieSkladniki_ = new MockRepository<WszystkieSkladniki>().Object;
                }
                return wszystkieSkladniki_;
            }
        }

        public IRepository<Ulubione> UlubioneRepo
        {
            get
            {
                if (ulubione_ == null)
                {
                    ulubione_ = new MockRepository<Ulubione>().Object;
                }
                return ulubione_;
            }
        }

        public IRepository<Sniadania> PrzepisySniadaniaRepo
        {
            get
            {
                if (sniadania_ == null)
                {
                    sniadania_ = new MockRepository<Sniadania>().Object;
                }
                return sniadania_;
            }
        }

        public IRepository<Ciasta> PrzepisyCiastaRepo
        {
            get
            {
                if (ciasta_ == null)
                {
                    ciasta_ = new MockRepository<Ciasta>().Object;
                }
                return ciasta_;
            }
        }

        public IRepository<Drinki> PrzepisyDrinkiRepo
        {
            get
            {
                if (drinki_ == null)
                {
                    drinki_ = new MockRepository<Drinki>().Object;
                }
                return drinki_;
            }
        }

        public IRepository<Fit> PrzepisyFitRepo
        {
            get
            {
                if (fit_ == null)
                {
                    fit_ = new MockRepository<Fit>().Object;
                }
                return fit_;
            }
        }

        public IRepository<Kolacje> PrzepisyKolacjeRepo
        {
            get
            {
                if (kolacje_ == null)
                {
                    kolacje_ = new MockRepository<Kolacje>().Object;
                }
                return kolacje_;
            }
        }

        public IRepository<Obiady> PrzepisyObiadyRepo
        {
            get
            {
                if (obiady_ == null)
                {
                    obiady_ = new MockRepository<Obiady>().Object;
                }
                return obiady_;
            }
        }

        public IRepository<Salatki> PrzepisySalatkiRepo
        {
            get
            {
                if (salatki_ == null)
                {
                    salatki_ = new MockRepository<Salatki>().Object;
                }
                return salatki_;
            }
        }

        public IRepository<Slone_przekaski> PrzepisySloneRepo
        {
            get
            {
                if (slone_ == null)
                {
                    slone_ = new MockRepository<Slone_przekaski>().Object;
                }
                return slone_;
            }
        }

        public IRepository<Sosy> PrzepisySosyaRepo
        {
            get
            {
                if (sosy_ == null)
                {
                    sosy_ = new MockRepository<Sosy>().Object;
                }
                return sosy_;
            }
        }


        public int Save()
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveAsync()
        {
            throw new NotImplementedException();
        }
    }
}
