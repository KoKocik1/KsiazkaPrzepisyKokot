using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KsiazkaPrzepisyKokot.Models
{
    public class LogPost
    {
        public int idLog { get; set; }
        public string imie { get; set; }
        public string nazwisko { get; set; }
       public LogPost()
        {

        }
        public LogPost(Log log)
        {
            idLog = log.idLog;
            imie= log.imie;
            nazwisko = log.nazwisko;
        }
    }
}
