using KsiazkaPrzepisyKokot.Interfaces;
using Microsoft.AspNetCore.Mvc;


namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LogController : ControllerBase
    {
        private readonly ILogService logService;

        public LogController(ILogService logService)
        {
            this.logService = logService;
        }
        
    }
}
