using KsiazkaPrzepisyKokot.BuisnessLayer.Interface;
using KsiazkaPrzepisyKokot.Models;
using KsiazkaPrzepisyKokot.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KsiazkaPrzepisyKokot.BuisnessLayer.Implementacje
{
    public class LogBL : ILogBL
    {
        private readonly UnitOfWork_ unitOfWork;
        public LogBL(UnitOfWork_ unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public Log Dodaj(Log log)
        {
            unitOfWork.LogRepo.Dodaj(log);
            return log;
        }

        public Log EdytujLogin(string login, string passwd, string newLogin)
        {
            Log log = Pobierz(login, passwd);
            if (log == null)
                throw new ArgumentException("zle haslo lub login");
            
            log.login = newLogin;
            unitOfWork.LogRepo.Aktualizuj(log);
            return log;
        }

        public Log EdytujName(string login, string passwd, string newName)
        {
            Log log = Pobierz(login, passwd);
            if (log == null)
                throw new ArgumentException("zle haslo lub login");

            log.imie = newName;
            unitOfWork.LogRepo.Aktualizuj(log);
            return log;
        }

        public Log EdytujPasswd(string login, string passwd, string newPasswd)
        {
            Log log = Pobierz(login, passwd);
            if (log == null)
                throw new ArgumentException("zle haslo lub login");

            log.haslo = newPasswd;
            unitOfWork.LogRepo.Aktualizuj(log);
            return log;
        }

        public Log EdytujSurrname(string login, string passwd, string newSurrname)
        {
            Log log = Pobierz(login, passwd);
            if (log == null)
                throw new ArgumentException("zle haslo lub login");

            log.nazwisko = newSurrname;
            unitOfWork.LogRepo.Aktualizuj(log);
            return log;
        }

        public Log Pobierz(string login, string passwd)
        {
            Log log = unitOfWork.LogRepo.Pobierz().Where(p => p.login.Contains(login) && p.haslo.Contains(passwd)).FirstOrDefault();
            if (log == null)
                throw new ArgumentException("zle haslo lub login");
            return log;
        }

        public bool Usun(string login, string passwd)
        {
            Log log = Pobierz(login, passwd);
            if (log == null)
                return false;
            return unitOfWork.LogRepo.Usun(log);

        }
    }
}
