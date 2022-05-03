using KsiazkaPrzepisyKokot.BuisnessLayer.Implementacje;
using KsiazkaPrzepisyKokot.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace KsiazkaPrzepisyKokot.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WszystkieSkladnikiController : ControllerBase
    {
        private readonly WszystkieSkladnikiBL skladniki;

        public WszystkieSkladnikiController(WszystkieSkladnikiBL skladniki)
        {
            this.skladniki = skladniki;
        }
        
        [HttpGet]
        public IEnumerable<WszystkieSkladniki> Get()
            => this.skladniki.Pobierz();
        [HttpGet("idWszystkieSkladniki/")]
        public WszystkieSkladniki Get([FromQuery] int idSkladnika)
            => this.skladniki.Pobierz(idSkladnika);
        [HttpPut]
        public WszystkieSkladniki Put([FromBody] WszystkieSkladniki przepis)
           => this.skladniki.Edytuj(przepis);

        [HttpPost]
        public WszystkieSkladniki Post([FromBody] WszystkieSkladniki przepis)
    => this.skladniki.Dodaj(przepis);

        [HttpDelete("{WszystkieSkladnikiId}")]
        public bool Delete(int WszystkieSkladnikiId)
           => this.skladniki.Usun(WszystkieSkladnikiId);


    }
}
