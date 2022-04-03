using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KsiazkaPrzepisyKokot.Models
{
    public class Skladnik
    {
        [Key]
        public int idSkladnika { get; set; }

        [ForeignKey("idWszystkieSkladniki")]
        public int idWszystkieSkladniki { get; set; }
        public string jaka_miara { get; set; }
        public int ilosc { get; set; }
    }
}
