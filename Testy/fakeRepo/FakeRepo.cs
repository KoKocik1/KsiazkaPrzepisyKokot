using KsiazkaPrzepisyKokot.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Testy
{

    internal class FakeRepo<T> : IRepository<T>
    {
        private readonly List<T> pamiecFakeRepo = new List<T>();

        public void Aktualizuj(T obiekt)
        {
            pamiecFakeRepo.RemoveAt(0);
            pamiecFakeRepo.Add(obiekt);
        }

        public void Dodaj(T obiekt)
        {
            pamiecFakeRepo.Add(obiekt);
        }

        public IEnumerable<T> Pobierz()
        {
            return pamiecFakeRepo;
        }

        public T PobierzPoId(object id)
        {
            return pamiecFakeRepo[0];
        }

        public bool Usun(object id)
        {
            if(pamiecFakeRepo.Count==0)
            return false;
            pamiecFakeRepo.RemoveAt(0);
            return true;
        }
    }
    
}
