using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KsiazkaPrzepisyKokot.ObiektyPosrednie
{
    public class Filtry
    {
        public class SniadaniaF
        {
            public bool z_jajkiem { get; set; }
            public bool na_slono { get; set; }
            public bool na_slodko { get; set; }
            public bool fit { get; set; }
            public bool bez_miesa { get; set; }
        }
        public class ObiadyF
        {

            public bool z_kurczakiem { get; set; }
            public bool z_wolowina { get; set; }
            public bool z_wieprzowina { get; set; }
            public bool z_mielonym { get; set; }
            public bool z_makaronem { get; set; }
            public bool z_ryzem { get; set; }
            public bool z_kartoflami { get; set; }
        }
        public class KolacjeF
        {
            public bool na_slono { get; set; }
            public bool na_slodko { get; set; }
            public bool fit { get; set; }
        }

        public class DrinkiF
        {
            public bool wodka { get; set; }
            public bool whisky { get; set; }
            public bool rum { get; set; }
            public bool yager { get; set; }
            public bool bezalkoholowy { get; set; }
        }
        public class CiastaF
        {
            public bool drozdzowe { get; set; }
            public bool na_zimno { get; set; }
            public bool na_cieplo { get; set; }
            public bool ciasto_francuskie { get; set; }
            public bool z_owsianka { get; set; }
            public bool z_owocami { get; set; }
        }
        public class FitF
        {
            public bool z_owsianka { get; set; }
            public bool z_jogurtem { get; set; }
            public bool z_owocami { get; set; }
            public bool z_kasza { get; set; }
            public bool z_ryzem { get; set; }
        }
        public class SalatkiF
        {
            public bool z_kurczakiem { get; set; }
            public bool na_cieplo { get; set; }
            public bool na_zimno { get; set; }
            public bool z_makaronem { get; set; }
        }
        public class SloneF
        {
            public bool na_zimno { get; set; }
            public bool na_cieplo { get; set; }
        }
        public class SosyF
        {
            public bool slone { get; set; }
            public bool slodkie { get; set; }
        }

    }
}
