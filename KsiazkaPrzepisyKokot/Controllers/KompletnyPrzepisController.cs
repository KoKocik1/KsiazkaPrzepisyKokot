using KsiazkaPrzepisyKokot.BuisnessLayer.Implementacje;
using KsiazkaPrzepisyKokot.Models;
using KsiazkaPrzepisyKokot.ObiektyPosrednie;
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
    public class KompletnyPrzepisController : Controller
    {
        private readonly KompletnyPrzepisBL kompletnyPrzepisBL;

        public KompletnyPrzepisController(KompletnyPrzepisBL kompletnyPrzepisBL)
        {
            this.kompletnyPrzepisBL = kompletnyPrzepisBL;
        }

        [HttpGet]
        public PelnyPrzepis GetById(int IdPrzepisu)
            => this.kompletnyPrzepisBL.Pobierz(IdPrzepisu);



    }
}
