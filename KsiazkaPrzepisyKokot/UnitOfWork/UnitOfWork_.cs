using KsiazkaPrzepisyKokot.Database;
using KsiazkaPrzepisyKokot.Interfaces;
using KsiazkaPrzepisyKokot.Models;
using KsiazkaPrzepisyKokot.Repository.Implementacje;
using KsiazkaPrzepisyKokot.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KsiazkaPrzepisyKokot.UnitOfWork
{
    public class UnitOfWork_ : IUnitOfWork
    {
        private readonly BazaDanych dbContext;
        public UnitOfWork_(BazaDanych db)
        {
            this.dbContext = db;
        }
        private IRepository<Log> log_;
        private IRepository<Przepisy> przepisy_;
        private IRepository<Sniadania> sniadania_;
        private IRepository<Obiady> obiady_;
        private IRepository<Kolacje> kolacje_;
        private IRepository<Ciasta> ciasta_;
        private IRepository<Drinki> drinki_;
        private IRepository<Fit> fit_;
        private IRepository<Slone_przekaski> slone_;
        private IRepository<Salatki> salatki_;
        private IRepository<Sosy> sosy_;
        private IRepository<SkladnikiPrzepisu> skladnikiPrzepisu_;
        private IRepository<WszystkieSkladniki> wszystkieSkladniki_;
        private IRepository<Ulubione> ulubione_;

        public IRepository<Log> LogRepo
        {
            get
            {
                if (log_ == null)
                {
                    log_ = new Repository<Log>(dbContext);
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
                    przepisy_ = new Repository<Przepisy>(dbContext);
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
                    skladnikiPrzepisu_ = new Repository<SkladnikiPrzepisu>(dbContext);
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
                    wszystkieSkladniki_ = new Repository<WszystkieSkladniki>(dbContext);
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
                    ulubione_ = new Repository<Ulubione>(dbContext);
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
                    sniadania_ = new Repository<Sniadania>(dbContext);
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
                    ciasta_ = new Repository<Ciasta>(dbContext);
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
                    drinki_ = new Repository<Drinki>(dbContext);
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
                    fit_ = new Repository<Fit>(dbContext);
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
                    kolacje_ = new Repository<Kolacje>(dbContext);
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
                    obiady_ = new Repository<Obiady>(dbContext);
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
                    salatki_ = new Repository<Salatki>(dbContext);
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
                    slone_ = new Repository<Slone_przekaski>(dbContext);
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
                    sosy_ = new Repository<Sosy>(dbContext);
                }
                return sosy_;
            }
        }

        public int Save()
        {
            return this.dbContext.SaveChanges();
        }

        public async Task<int> SaveAsync()
        {
            return await this.dbContext.SaveChangesAsync();
        }
    }
}
