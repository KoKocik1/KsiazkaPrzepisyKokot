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
    public class KompletnyPrzepisController_ : Controller
    {
        private readonly KompletnyPrzepisBL_ kompletnyPrzepisBL;

        public KompletnyPrzepisController_(KompletnyPrzepisBL_ kompletnyPrzepisBL)
        {
            this.kompletnyPrzepisBL = kompletnyPrzepisBL;
        }

        [HttpGet]
        public PelnyPrzepis GetById(int IdPrzepisu)
            => this.kompletnyPrzepisBL.Pobierz(IdPrzepisu);



    }
}
