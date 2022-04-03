using KsiazkaPrzepisyKokot.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SkladnikiController : ControllerBase
    {
        private readonly ISkladnikiService skladnikiService;

        public SkladnikiController(ISkladnikiService skladnikiService)
        {
            this.skladnikiService = skladnikiService;
        }

    }
}
