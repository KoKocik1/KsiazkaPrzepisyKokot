using KsiazkaPrzepisyKokot.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KsiazkaPrzepisyKokot.BuisnessLayer.Interface
{
    public interface IWszystkieSkladnikiBL
    {
        public WszystkieSkladniki Dodaj(WszystkieSkladniki skladnik);
        public WszystkieSkladniki Edytuj(WszystkieSkladniki skladnik);
        public WszystkieSkladniki EdytujLyzka(int idSkladnik, double lyzka);
        public WszystkieSkladniki EdytujLyzeczka(int idSkladnik, double lyzeczka);
        public WszystkieSkladniki EdytujGram(int idSkladnik, double gram);
        public WszystkieSkladniki EdytujSzklanka(int idSkladnik, double szklanka);
        public WszystkieSkladniki EdytujSkladnik(int idSkladnik, string skladnik);
        public bool Usun(int idSkladnik);
        public WszystkieSkladniki Pobierz(int idSkladnik);
        public IEnumerable<WszystkieSkladniki> Pobierz();
    }
}
