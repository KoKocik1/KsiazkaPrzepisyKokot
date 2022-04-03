using KsiazkaPrzepisyKokot.Interfaces;
using Microsoft.AspNetCore.Mvc;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PrzepisyController : ControllerBase
    {
        private readonly IPrzepisyService przepisyService;

        public PrzepisyController(IPrzepisyService przepisyService)
        {
            this.przepisyService = przepisyService;
        }

    }
}
