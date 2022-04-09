using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KsiazkaPrzepisyKokot.Models
{
    [Table("Log")]
    public class Log
    {
        [Key]
        public int idLog { get; set; }
        [Required, MaxLength(30)]
        public string login { get; set; }
        [Required, MaxLength(30)]
        public string haslo { get; set; }
        [Required, MaxLength(30)]
        public string imie { get; set; }
        [Required, MaxLength(30)]
        public string nazwisko { get; set; }
    }
}
