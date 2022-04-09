using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KsiazkaPrzepisyKokot.Models
{
    [Table("Sosy")]
    public class Sosy : Przepisy
    {

        public bool slone { get; set; }
        public bool slodkie { get; set; }

    }
}
