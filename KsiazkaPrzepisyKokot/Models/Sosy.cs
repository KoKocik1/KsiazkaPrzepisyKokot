﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KsiazkaPrzepisyKokot.Models
{
    public class Sosy 
    {
        [Key]
        public int idSosu { get; set; }
        public bool slone { get; set; }
        public bool slodkie { get; set; }
        [ForeignKey("Przepis")]
        public int idPrzepis { get; set; }
    }
}
