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
        public Log Dodaj(Log log);
        public Log EdytujName(string login, string passwd,string newName);
        public Log EdytujPasswd(string login, string passwd, string newPasswd);
        public Log EdytujLogin(string login, string passwd, string newLogin);
        public Log EdytujSurrname(string login, string passwd, string newSurrname);
        public bool Usun(string login, string passwd);
        public Log Pobierz(string login, string passwd);
    }
}
