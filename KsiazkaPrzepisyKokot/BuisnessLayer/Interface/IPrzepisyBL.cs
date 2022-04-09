using KsiazkaPrzepisyKokot.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static KsiazkaPrzepisyKokot.ObiektyPosrednie.Filtry;

namespace KsiazkaPrzepisyKokot.BuisnessLayer.Interface
{
    public interface IPrzepisyBL
    {
        //podstawowe
        public Przepisy Dodaj(Przepisy przepis);
        public Przepisy Edytuj(Przepisy przepis);
        public bool Usun(int idPrzepisu);
        public Przepisy Pobierz(int idPrzepisu);
        public IEnumerable<Przepisy> Pobierz();

        //sniadania
        public Sniadania PobierzSniadanie(int idPrzepisu);
        public IEnumerable<Sniadania> pobierzSniadania(SniadaniaF filtr);
        public IEnumerable<Sniadania> PobierzSniadania();
        //obiady
     
        public Obiady PobierzObiad(int idPrzepisu);
        public IEnumerable<Obiady> pobierzObiad(ObiadyF filtr);
        public IEnumerable<Obiady> PobierzObiady();
        //kolacje

        public Kolacje PobierzKolacje(int idPrzepisu);
        public IEnumerable<Kolacje> pobierzKolacje(KolacjeF filtr);
        public IEnumerable<Kolacje> PobierzKolacje();
        //Fit

        public Fit PobierzFit(int idPrzepisu);
        public IEnumerable<Fit> pobierzFit(FitF filtr);
        public IEnumerable<Fit> PobierzFit();
        //Ciasta

        public Ciasta PobierzCiasta(int idPrzepisu);
        public IEnumerable<Ciasta> pobierzCiasta(CiastaF filtr);
        public IEnumerable<Ciasta> PobierzCiasta();
        //Drinki

        public Drinki PobierzDrinki(int idPrzepisu);
        public IEnumerable<Drinki> pobierzDriki(DrinkiF filtr);
        public IEnumerable<Drinki> PobierzDrinki();
        //Salatki

        public Salatki PobierzSalatki(int idPrzepisu);
        public IEnumerable<Salatki> pobierzSalatki(SalatkiF filtr);
        public IEnumerable<Salatki> PobierzSalatki();
        //Slone przekaski

        public Slone_przekaski PobierzSlone_przekaski(int idPrzepisu);
        public IEnumerable<Slone_przekaski> pobierzSlone_przekaski(SloneF filtr);
        public IEnumerable<Slone_przekaski> PobierzSlone_przekaski();
        //sosy

        public Sosy PobierzSosy(int idPrzepisu);
        public IEnumerable<Sosy> pobierzSosy(SosyF filtr);
        public IEnumerable<Sosy> PobierzSosy();
    }
}
