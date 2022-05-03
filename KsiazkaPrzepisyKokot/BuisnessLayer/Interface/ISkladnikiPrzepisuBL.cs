using KsiazkaPrzepisyKokot.Interfaces;
using KsiazkaPrzepisyKokot.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KsiazkaPrzepisyKokot.BuisnessLayer.Interface
{
    public interface ISkladnikiPrzepisuBL
    {
        public SkladnikiPrzepisu Dodaj(SkladnikiPrzepisu skladnik);
        public SkladnikiPrzepisu Dodaj(int idPrzepisu, int idSkladnik, Miara miara, double ilosc);
        public SkladnikiPrzepisu Dodaj(Przepisy przepis, WszystkieSkladniki skladnik, Miara miara, int ilosc);

        public SkladnikiPrzepisu Edytuj(SkladnikiPrzepisu skladniki);

        public SkladnikiPrzepisu EdytujMiara(int idPrzepisu, int idSkladnik, Miara miara);
        public SkladnikiPrzepisu EdytujIlosc(int idPrzepisu, int idSkladnik, int ilosc);

        public bool UsunSkladnikZprzepisu(int idSkladnika, int idPrzepisu);
        public bool UsunSkladnikZprzepisu(int idSkladnikaPrzepisu);

        public SkladnikiPrzepisu PobierzPoId(int idSkladnika);
        public SkladnikiPrzepisu Pobierz(int idSkladnika, int idPrzepisu);
        public IEnumerable<SkladnikiPrzepisu> PobierzPoSkladniku(int idSkladnika);
        public IEnumerable<SkladnikiPrzepisu> PobierzPoPrzepisie(int idPrzepisu);
        public IEnumerable<WszystkieSkladniki> PobierzSkladnikiPoPrzepisie(int idPrzepisu);


    }
}
