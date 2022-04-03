using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KsiazkaPrzepisyKokot.Models
{
    public class Ulubione
    {
        [Key]
        public int idUlubione { get; set; }

        [ForeignKey("Przepis")]
        public int idPrzepis { get; set; }
    }
}
