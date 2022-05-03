using KsiazkaPrzepisyKokot.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KsiazkaPrzepisyKokot.ObiektyPosrednie
{
    [Table("PelnyPrzepis")]
    public class PelnyPrzepis
    {
        public Przepisy przepis { get; set; }
        public IEnumerable<WszystkieSkladniki> skladnikiPrzepisu { get; set; }

        public PelnyPrzepis()
        {

        }
        public PelnyPrzepis(Przepisy przepis, IEnumerable<WszystkieSkladniki> skladnikiPrzepisu)
        {
            this.przepis = przepis;
            this.skladnikiPrzepisu = skladnikiPrzepisu;
        }
        
        public override string ToString()
        {
            return "id przepisu: " + przepis.idPrzepisu + ", ilosc skladnikow: " + skladnikiPrzepisu.Count();
        }
    }
}
