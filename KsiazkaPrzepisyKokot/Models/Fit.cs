﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KsiazkaPrzepisyKokot.Models
{
    public class Fit 
    {
        [Key]
        public int idFit { get; set; }
        public bool z_owsianka { get; set; }
        public bool z_jogurtem { get; set; }
        public bool z_owocami { get; set; }
        public bool z_kasza { get; set; }
        public bool z_ryzem { get; set; }
        [ForeignKey("Przepis")]
        public int idPrzepis { get; set; }
    }
}
