using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KsiazkaPrzepisyKokot.Models
{
    [Table("Ulubione")]
    public class Ulubione
    {
        [Key]
        public int idUlubione { get; set; }

        [Required]
        public int idPrzepis { get; set; }
        [ForeignKey(nameof(idPrzepis)), Required]
        public Przepisy przepis { get; set; }
    }
}
