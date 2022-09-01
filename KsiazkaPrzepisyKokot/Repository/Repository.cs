using KsiazkaPrzepisyKokot.Database;
using KsiazkaPrzepisyKokot.ObiektyPosrednie;
using KsiazkaPrzepisyKokot.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KsiazkaPrzepisyKokot.Repository.Implementacje
{
    public class Repository<T> : IRepository<T> where T:class
    {
        private readonly BazaDanych dbContext;
        public DbSet<T> table = null;

        public Repository(BazaDanych db)
        {
            this.dbContext = db;
            this.table = db.Set<T>();
        }

        public void Aktualizuj(T obiekt)
        {
            table.Attach(obiekt);
            dbContext.Entry(obiekt).State = EntityState.Modified;
        }

        public void Dodaj(T obiekt)
        {
            table.Add(obiekt);
        }

        public IEnumerable<T> Pobierz()
        {
            return table.ToList();
            
        }
        public IEnumerable<T> Pobierz(PaginationDto dto)
        {
            return Pobierz().Skip((dto.Page - 1) * dto.RowsPerPage).Take(dto.RowsPerPage);
        }

        public T PobierzPoId(object id)
        {
            return table.Find(id);
        }

        public bool Usun(object id)
        {
            bool usuniete=false;

            T obiektDoUsuniecia = table.Find(id);

            if (obiektDoUsuniecia != null) {
                usuniete = true;
                table.Remove(obiektDoUsuniecia);
            }
            return usuniete;
           
        }
    }
}
