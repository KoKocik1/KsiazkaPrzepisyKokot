using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KsiazkaPrzepisyKokot.Models
{
    public class CiastaDto : Przepisy
    {
        public int idCiasta { get; set; }
        public bool drozdzowe { get; set; }
        public bool na_zimno { get; set; }
        public bool na_cieplo { get; set; }
        public bool ciasto_francuskie { get; set; }
        public bool z_owsianka { get; set; }
        public bool z_owocami { get; set; }

    }
}
