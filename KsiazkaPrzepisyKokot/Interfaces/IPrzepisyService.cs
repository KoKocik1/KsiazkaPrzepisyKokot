using KsiazkaPrzepisyKokot.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KsiazkaPrzepisyKokot.Interfaces
{
    public interface IPrzepisyService
    {
        public bool DodajPrzepis(Przepisy przepis);
        public bool UsunPrzepis(Przepisy przepis);
        public bool EdytujPrzepis(Przepisy przepis);
        public Przepisy[] PobierzPrzepisy(Przepisy przepis);
        public Przepisy[] PobierzSniadania();
        public Przepisy[] PobierzSniadanie(SniadaniaDto sniadanie);
        public Przepisy[] PobierzDrinki();
        public Przepisy[] PobierzDrika(DrinkiDto drink);
        public Przepisy[] PobierzKolacje(KolacjeDto kolacja);
        public Przepisy[] PobierzKolacjes();
        public Przepisy[] PobierzFit(FitDto fit);
        public Przepisy[] PobierzFits();
        public Przepisy[] PobierzObiad(ObiadyDto obiad);
        public Przepisy[] PobierzObiady();
        public Przepisy[] PobierzSalatke(SalatkiDto salatka);
        public Przepisy[] PobierzSalatki();
        public Przepisy[] PobierzSlonaPrzekaska(Slone_przekaskiDto slone);
        public Przepisy[] PobierzSlonePrzekaski();
        public Przepisy[] PobierzSos(SosyDto sos);
        public Przepisy[] PobierzSosy();
        public Przepisy[] PobierzUlubione();
        public Przepisy[] PobierzUlubione(Przepisy p);
    }
}
