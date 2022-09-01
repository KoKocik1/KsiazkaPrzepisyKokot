using KsiazkaPrzepisyKokot.ObiektyPosrednie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KsiazkaPrzepisyKokot.Repository.Interfaces
{
    public interface IRepository<T>
    {
        public IEnumerable<T> Pobierz();
        public IEnumerable<T> Pobierz(PaginationDto dto);
        public T PobierzPoId(object id);
        public void Dodaj(T obiekt);
        public void Aktualizuj(T obiekt);
        public bool Usun(object id);
    }
}
