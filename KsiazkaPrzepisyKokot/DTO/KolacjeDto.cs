﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KsiazkaPrzepisyKokot.Models
{
    public class KolacjeDto : Przepisy
    {
        public int idKolacji { get; set; }
        public bool na_slono { get; set; }
        public bool na_slodko { get; set; }
        public bool fit { get; set; }
    }
}
