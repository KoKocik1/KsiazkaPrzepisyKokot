using KsiazkaPrzepisyKokot.BuisnessLayer.Implementacje;
using KsiazkaPrzepisyKokot.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KsiazkaPrzepisyKokot.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LogController : Controller
    {
        private readonly LogBL logBL;

        public LogController(LogBL logBL)
        {
            this.logBL = logBL;
        }

        [HttpGet]
        public Log Login([FromQuery] string login, [FromQuery] string passwd)
                => this.logBL.Pobierz(login, passwd);

       
    }
}
