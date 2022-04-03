using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KsiazkaPrzepisyKokot.Models
{
    public class PrzepisyDto
    {
        public int idPrzepisu { get; set; }
        public string Przepis { get; set; }
        public DateTime data { get; set; }
        public string nazwaDania { get; set; }
        public TimeSpan czas { get; set; }
        public int liczbaPorcji { get; set; }
        public int idSkladnika { get; set; }
        public Skladnik[] skladniki { get; set; }
    }
}
