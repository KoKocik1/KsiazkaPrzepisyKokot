using KsiazkaPrzepisyKokot.Interfaces;
using KsiazkaPrzepisyKokot.Models;
using KsiazkaPrzepisyKokot.ObiektyPosrednie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KsiazkaPrzepisyKokot.BuisnessLayer.Interface
{
    public interface IPrzepisyBL
    {
        //podstawowe
        public Przepisy Dodaj(Przepisy przepis);
        public Przepisy Edytuj(Przepisy przepis);
        public bool Usun(int idPrzepisu);

        public Przepisy Pobierz(int idPrzepisu);
        public IEnumerable<Przepisy> PobierzPrzepisyPoSkladniku(int idSkladnia);
        public IEnumerable<Przepisy> PobierzPrzepisyPoSkladnikach(int[] idSkladnikow);
        public IEnumerable<Przepisy> PobierzPrzepisyPoSkladnikachOrazTypieDania(int[] idSkladnikow, RodzajePosilkow rodzaj);
        public IEnumerable<Przepisy> PobierzPrzepisyPoRodzajuPosilku(RodzajePosilkow rodzajPosilku);
        public IEnumerable<Przepisy> Pobierz();
        public IEnumerable<Przepisy> PobierzUlubione();
        public Przepisy PobierzUlubiony(int idUlubiony);

        //sniadania 
        public Sniadania PobierzSniadania(int idPrzepisu);
        public IEnumerable<Sniadania> PobierzSniadania(SniadaniaF filtr);
        public IEnumerable<Sniadania> PobierzSniadania();
        //obiady
     
        public Obiady PobierzObiady(int idPrzepisu);
        public IEnumerable<Obiady> PobierzObiady(ObiadyF filtr);
        public IEnumerable<Obiady> PobierzObiady();
        //kolacje

        public Kolacje PobierzKolacje(int idPrzepisu);
        public IEnumerable<Kolacje> PobierzKolacje(KolacjeF filtr);
        public IEnumerable<Kolacje> PobierzKolacje();
        //Fit

        public Fit PobierzFit(int idPrzepisu);
        public IEnumerable<Fit> PobierzFit(FitF filtr);
        public IEnumerable<Fit> PobierzFit();
        //Ciasta

        public Ciasta PobierzCiasta(int idPrzepisu);
        public IEnumerable<Ciasta> PobierzCiasta(CiastaF filtr);
        public IEnumerable<Ciasta> PobierzCiasta();
        //Drinki

        public Drinki PobierzDrinki(int idPrzepisu);
        public IEnumerable<Drinki> PobierzDrinki(DrinkiF filtr);
        public IEnumerable<Drinki> PobierzDrinki();
        //Salatki

        public Salatki PobierzSalatki(int idPrzepisu);
        public IEnumerable<Salatki> PobierzSalatki(SalatkiF filtr);
        public IEnumerable<Salatki> PobierzSalatki();
        //Slone przekaski

        public Slone_przekaski PobierzSlone_przekaski(int idPrzepisu);
        public IEnumerable<Slone_przekaski> PobierzSlone_przekaski(SloneF filtr);
        public IEnumerable<Slone_przekaski> PobierzSlone_przekaski();
        //sosy

        public Sosy PobierzSosy(int idPrzepisu);
        public IEnumerable<Sosy> PobierzSosy(SosyF filtr);
        public IEnumerable<Sosy> PobierzSosy();

       
    }
}
