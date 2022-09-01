using KsiazkaPrzepisyKokot.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KsiazkaPrzepisyKokot.BuisnessLayer.Interface
{
    public interface ILogBL
    {
        //podstawowe
        public LogPost Dodaj(Log log);
        public LogPost EdytujName(string login, string passwd,string newName);
        public LogPost EdytujPasswd(string login, string passwd, string newPasswd);
        public LogPost EdytujLogin(string login, string passwd, string newLogin);
        public LogPost EdytujSurrname(string login, string passwd, string newSurrname);
        public bool Usun(string login, string passwd);
        public LogPost Pobierz(string login, string passwd);
    }
}
