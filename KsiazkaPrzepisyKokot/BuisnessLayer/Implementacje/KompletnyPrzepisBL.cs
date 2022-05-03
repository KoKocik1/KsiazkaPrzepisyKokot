using KsiazkaPrzepisyKokot.BuisnessLayer.Interface;
using KsiazkaPrzepisyKokot.Interfaces;
using KsiazkaPrzepisyKokot.Models;
using KsiazkaPrzepisyKokot.ObiektyPosrednie;
using KsiazkaPrzepisyKokot.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KsiazkaPrzepisyKokot.BuisnessLayer.Implementacje
{
    public class KompletnyPrzepisBL : IKompletnyPrzepisBL
    {

        private readonly PrzepisyBL przepisy;
        private readonly SkladnikiPrzepisuBL skladniki;
        public KompletnyPrzepisBL(PrzepisyBL przepisy, SkladnikiPrzepisuBL skladniki)
        {
            this.przepisy = przepisy;
            this.skladniki = skladniki;
        }
        public PelnyPrzepis Pobierz(int idPrzepisu)
        {
            PelnyPrzepis p = new PelnyPrzepis(przepisy.Pobierz(idPrzepisu), skladniki.PobierzSkladnikiPoPrzepisie(idPrzepisu));
            //throw new Exception("obiekt ten jest tworzony prawidlowo ale?: " + p);
            return p;

        }

       


    }
}
