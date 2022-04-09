using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KsiazkaPrzepisyKokot.Models
{
    [Table("WszystkieSkladniki")]
    public class WszystkieSkladniki
    {
        [Key]
        public int idWszystkieSkladniki { get; set; }
        [Required, MaxLength(100)]
        public string skladnik { get; set; }
        public double? lyzka_kcal { get; set; }
        public double? lyzeczka_kcal { get; set; }
        public double? gram_kcal { get; set; }
        public double? szklanka_kcal { get; set; }
    }
}
