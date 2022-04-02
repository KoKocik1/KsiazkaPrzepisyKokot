using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KsiazkaPrzepisyKokot.Models
{
    public class WszystkieSkladniki
    {
        public int idWszystkieSkladniki { get; set; }
        public string skladnik { get; set; }
        public double lyzka_kcal { get; set; }
        public double lyzeczka_kcal { get; set; }
        public double gram_kcal { get; set; }
        public double szklanka_kcal { get; set; }
    }
}
