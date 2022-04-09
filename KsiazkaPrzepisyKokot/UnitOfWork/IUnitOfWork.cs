using KsiazkaPrzepisyKokot.Interfaces;
using KsiazkaPrzepisyKokot.Models;
using KsiazkaPrzepisyKokot.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KsiazkaPrzepisyKokot.UnitOfWork
{
    public interface IUnitOfWork
    {
        public IRepository<Log> LogRepo { get; }
        public IRepository<Przepisy> PrzepisyRepo { get; }
        public IRepository<Sniadania> PrzepisySniadaniaRepo { get; }
        public IRepository<Ciasta> PrzepisyCiastaRepo { get; }
        public IRepository<Drinki> PrzepisyDrinkiRepo { get; }
        public IRepository<Fit> PrzepisyFitRepo { get; }
        public IRepository<Kolacje> PrzepisyKolacjeRepo { get; }
        public IRepository<Obiady> PrzepisyObiadyRepo { get; }
        public IRepository<Salatki> PrzepisySalatkiRepo { get; }
        public IRepository<Slone_przekaski> PrzepisySloneRepo { get; }
        public IRepository<Sosy> PrzepisySosyaRepo { get; }
        public IRepository<SkladnikiPrzepisu> SkladnikiPrzepisuRepo { get; }
        public IRepository<WszystkieSkladniki> WszystkieSkladnikiRepo { get; }
        public IRepository<Ulubione> UlubioneRepo { get; }


        public Task<int> SaveAsync();
        public int Save();
    }
}
