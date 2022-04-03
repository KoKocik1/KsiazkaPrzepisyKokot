﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KsiazkaPrzepisyKokot.Models
{
    public class Log
    {
        [Key]
        public int idLog { get; set; }
        public string login { get; set; }
        public string haslo { get; set; }
        public string imie { get; set; }
        public string nazwisko { get; set; }
    }
}
