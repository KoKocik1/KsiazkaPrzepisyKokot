using KsiazkaPrzepisyKokot.BuisnessLayer.Implementacje;
using KsiazkaPrzepisyKokot.Interfaces;
using KsiazkaPrzepisyKokot.Models;
using KsiazkaPrzepisyKokot.ObiektyPosrednie;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace KsiazkaPrzepisyKokot.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PrzepisyController : ControllerBase
    {
        private readonly PrzepisyBL przepisyBL;

        public PrzepisyController(PrzepisyBL przepisyBL)
        {
            this.przepisyBL = przepisyBL;
        }


        //pobieranie przepisow
       /* [HttpGet]
        public IEnumerable<Przepisy> Get()
           => this.przepisyBL.Pobierz();*/

        [HttpGet("IdPrzepisu/")]
        public Przepisy Get(int IdPrzepisu)
           => this.przepisyBL.Pobierz(IdPrzepisu);

        [HttpGet]
        public IEnumerable<Przepisy> Get([FromQuery] PaginationDto dto)
    => this.przepisyBL.Pobierz(dto);

        //pobieranie po filtrach
        [HttpGet("filtrySniadania/")]
        public IEnumerable<Przepisy> GetByFilter([FromQuery] SniadaniaF filtrySniadania)
           => this.przepisyBL.PobierzSniadania(filtrySniadania);
        [HttpGet("filtryObiady/")]
        public IEnumerable<Przepisy> GetByFilter([FromQuery] ObiadyF filtryObiady)
           => this.przepisyBL.PobierzObiady(filtryObiady);
        [HttpGet("filtryKolacje/")]
        public IEnumerable<Przepisy> GetByFilter([FromQuery] KolacjeF filtryKolacje)
           => this.przepisyBL.PobierzKolacje(filtryKolacje);
        [HttpGet("filtryFit/")]
        public IEnumerable<Przepisy> GetByFilter([FromQuery] FitF filtryFit)
           => this.przepisyBL.PobierzFit(filtryFit);
        [HttpGet("filtrySalatki/")]
        public IEnumerable<Przepisy> GetByFilter([FromQuery] SalatkiF filtrySalatki)
           => this.przepisyBL.PobierzSalatki(filtrySalatki);
        [HttpGet("filtrySosy/")]
        public IEnumerable<Przepisy> GetByFilter([FromQuery] SosyF filtrySosy)
           => this.przepisyBL.PobierzSosy(filtrySosy);
        [HttpGet("filtrySlone/")]
        public IEnumerable<Przepisy> GetByFilter([FromQuery] SloneF filtrySlone)
           => this.przepisyBL.PobierzSlone_przekaski(filtrySlone);
        [HttpGet("filtryDrinki/")]
        public IEnumerable<Przepisy> GetByFilter([FromQuery] DrinkiF filtryDrinki)
           => this.przepisyBL.PobierzDrinki(filtryDrinki);
        [HttpGet("filtryCiasta/")]
        public IEnumerable<Przepisy> GetByFilter([FromQuery] CiastaF filtryCiasta)
           => this.przepisyBL.PobierzCiasta(filtryCiasta);


        //pobieranie po rodzaju posilku
        [HttpGet("rodzajPosilku/")]
        public IEnumerable<Przepisy> GetByRodzaj(RodzajePosilkow rodzajPosilku)
            => this.przepisyBL.PobierzPrzepisyPoRodzajuPosilku(rodzajPosilku);


        //pobieranie po skladnikach
        [HttpGet("IdSkladnikow/")]
        public IEnumerable<Przepisy> GetBySkladniki([FromQuery] int[] IdSkladnikow)
            => this.przepisyBL.PobierzPrzepisyPoSkladnikach(IdSkladnikow);

        [HttpGet("IdSkladnikowOrazTyp/")]
        public IEnumerable<Przepisy> GetBySkladnikiOrazTyp([FromQuery] int[] IdSkladnikow,RodzajePosilkow rodzaj)
            => this.przepisyBL.PobierzPrzepisyPoSkladnikachOrazTypieDania(IdSkladnikow, rodzaj);

        [HttpGet("IdSkladnika/")]
        public IEnumerable<Przepisy> GetBySkladnik(int IdSkladnika)
            => this.przepisyBL.PobierzPrzepisyPoSkladniku(IdSkladnika);


        //edycja przepisów
        [HttpPut]
        public Przepisy Edytuj([FromBody] Przepisy przepis)
            => this.przepisyBL.Edytuj(przepis);
        [HttpPut("edytujSniadanie/")]
        public Przepisy EdytujSniadanie([FromBody] Sniadania przepis)
            => this.przepisyBL.Edytuj(przepis);
        [HttpPut("edytujObiad/")]
        public Przepisy EdytujObiad([FromBody] Obiady przepis)
            => this.przepisyBL.Edytuj(przepis);
        [HttpPut("edytujCiasta/")]
        public Przepisy EdytujCiasta([FromBody] Ciasta przepis)
            => this.przepisyBL.Edytuj(przepis);
        [HttpPut("edytujFit/")]
        public Przepisy EdytujFit([FromBody] Fit przepis)
            => this.przepisyBL.Edytuj(przepis);
        [HttpPut("edytujKolacje/")]
        public Przepisy EdytujKolacje([FromBody] Kolacje przepis)
            => this.przepisyBL.Edytuj(przepis);
        [HttpPut("edytujSalatki/")]
        public Przepisy EdytujSalatki([FromBody] Salatki przepis)
            => this.przepisyBL.Edytuj(przepis);
        [HttpPut("edytujSlone/")]
        public Przepisy EdytujSlone([FromBody] Slone_przekaski przepis)
            => this.przepisyBL.Edytuj(przepis);
        [HttpPut("edytujSosy/")]
        public Przepisy EdytujSosy([FromBody] Sosy przepis)
            => this.przepisyBL.Edytuj(przepis);


        //dodawanie przepisów
        [HttpPost]
        public Przepisy Dodaj([FromBody] Przepisy przepis)
            => this.przepisyBL.Dodaj(przepis);
        [HttpPost("dodajSniadanie/")]
        public Przepisy DodajSniadanie([FromBody] Sniadania przepis)
            => this.przepisyBL.Dodaj(przepis);
        [HttpPost("dodajObiad/")]
        public Przepisy DodajObiad([FromBody] Obiady przepis)
            => this.przepisyBL.Dodaj(przepis);
        [HttpPost("dodajCiasta/")]
        public Przepisy DodajCiasta([FromBody] Ciasta przepis)
            => this.przepisyBL.Dodaj(przepis);
        [HttpPost("dodajFit/")]
        public Przepisy DodajFit([FromBody] Fit przepis)
            => this.przepisyBL.Dodaj(przepis);
        [HttpPost("dodajKolacje/")]
        public Przepisy DodajKolacje([FromBody] Kolacje przepis)
            => this.przepisyBL.Dodaj(przepis);
        [HttpPost("dodajSalatki/")]
        public Przepisy DodajSalatki([FromBody] Salatki przepis)
            => this.przepisyBL.Dodaj(przepis);
        [HttpPost("dodajSlone/")]
        public Przepisy DodajSlone([FromBody] Slone_przekaski przepis)
            => this.przepisyBL.Dodaj(przepis);
        [HttpPost("dodajSosy/")]
        public Przepisy DodajSosy([FromBody] Sosy przepis)
            => this.przepisyBL.Dodaj(przepis);



        //usuwanie przepisu po id
        [HttpDelete("{productId}")]
        public bool Usun(int productId)
            => this.przepisyBL.Usun(productId);
    }
}
