using KsiazkaPrzepisyKokot.BuisnessLayer.Implementacje;
using KsiazkaPrzepisyKokot.Interfaces;
using KsiazkaPrzepisyKokot.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KsiazkaPrzepisyKokot.Controllers
{

        [ApiController]
        [Route("[controller]")]
        public class SkladnikPrzepisuController : ControllerBase
        {
            private readonly SkladnikiPrzepisuBL skladniki;

            public SkladnikPrzepisuController(SkladnikiPrzepisuBL skladniki)
            {
                this.skladniki = skladniki;
            }

        [HttpGet]
        public IEnumerable<SkladnikiPrzepisu> Get([FromQuery] int idPrzepisu)
           => this.skladniki.PobierzPoPrzepisie(idPrzepisu);

        [HttpPut]
        public SkladnikiPrzepisu Put([FromBody] SkladnikiPrzepisu przepis)
           => this.skladniki.Edytuj(przepis);

        [HttpPost("DodajSkladnikiDoPrzepisu/")]
        public SkladnikiPrzepisu Post( int idPrzepis,  int idWszystkieSkladniki, Miara miara,  int ilosc)
            => this.skladniki.Dodaj(idPrzepis,idWszystkieSkladniki,miara,ilosc);

        [HttpPost]
        public SkladnikiPrzepisu Post([FromBody] SkladnikiPrzepisu przepis)
            => this.skladniki.Dodaj(przepis);

        [HttpDelete("{idWszystkieSkladniki}")]
        public bool Delete(int idWszystkieSkladniki)
            => this.skladniki.UsunSkladnikZprzepisu(idWszystkieSkladniki);
        [HttpDelete]
        public bool Delete(int productId, int skladnikID)
            => this.skladniki.UsunSkladnikZprzepisu(skladnikID,productId);

    }
    

}
