using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KsiazkaPrzepisyKokot.Models
{
    [Table("SkladnikiPrzepisu")]
    public class SkladnikiPrzepisu
    {
        [Key]
        public int idSkladnika { get; set; }
        [Required]
        public int idWszystkieSkladniki { get; set; }

        [ForeignKey(nameof(idWszystkieSkladniki)), Required]
        public WszystkieSkladniki wszystkieSkladniki { get; set; }
        [Required]
        public int idPrzepisu { get; set; }

        [ForeignKey(nameof(idPrzepisu)), Required]
        public Przepisy przepis { get; set; }
        [Required]
        public string jaka_miara { get; set; }
        [Required]
        public int ilosc { get; set; }
    }
}
