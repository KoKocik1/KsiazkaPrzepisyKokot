using KsiazkaPrzepisyKokot.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KsiazkaPrzepisyKokot.Interfaces
{
    public interface ISkladnikiService
    {
        public bool DodajSkladnik(WszystkieSkladnikiDto przepis);
        public bool UsunSkladnik(WszystkieSkladnikiDto przepis);
        public bool EdytujSkladnik(WszystkieSkladnikiDto przepis);
        public WszystkieSkladnikiDto PobierzSkladnik(WszystkieSkladnikiDto przepis);

        public WszystkieSkladnikiDto[] PobierzSkladniki();
    }
}
