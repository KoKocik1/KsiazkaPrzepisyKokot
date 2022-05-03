using KsiazkaPrzepisyKokot.Interfaces;
using KsiazkaPrzepisyKokot.Models;
using KsiazkaPrzepisyKokot.ObiektyPosrednie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KsiazkaPrzepisyKokot.BuisnessLayer.Interface
{
    public interface IKompletnyPrzepisBL
    {
        public PelnyPrzepis Pobierz(int Przepisu);
        
    }
}
