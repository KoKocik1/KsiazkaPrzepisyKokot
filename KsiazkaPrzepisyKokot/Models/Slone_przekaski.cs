﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KsiazkaPrzepisyKokot.Models
{
    public class Slone_przekaski 
    {
        [Key]
        public int idSlonePrzekaski { get; set; }
        public bool na_zimno { get; set; }
        public bool na_cieplo { get; set; }
        [ForeignKey("Przepis")]
        public int idPrzepis { get; set; }
    }
}
