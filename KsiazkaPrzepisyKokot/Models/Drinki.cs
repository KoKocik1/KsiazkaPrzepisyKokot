﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KsiazkaPrzepisyKokot.Models
{
    public class Drinki
    {
        [Key]
        public int idDrinka { get; set; }
        public bool wodka { get; set; }
        public bool whisky { get; set; }
        public bool rum { get; set; }
        public bool yager { get; set; }
        public bool bezalkoholowy { get; set; }
        [ForeignKey("Przepis")]
        public int idPrzepis { get; set; }
    }
}
