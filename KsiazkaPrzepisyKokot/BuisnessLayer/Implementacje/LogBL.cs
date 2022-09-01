using KsiazkaPrzepisyKokot.BuisnessLayer.Interface;
using KsiazkaPrzepisyKokot.Models;
using KsiazkaPrzepisyKokot.ObiektyPosrednie;
using KsiazkaPrzepisyKokot.UnitOfWork;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
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
        public LogPost Dodaj(Log log)
        {
            Log pobranyLog = unitOfWork.LogRepo.PobierzPoId(log.idLog);
            if (pobranyLog == null)
                unitOfWork.LogRepo.Dodaj(log);
            return new LogPost(log);
        }

        public LogPost EdytujLogin(string login, string passwd, string newLogin)
        {
            Log log = PobierzLog(login, passwd);
            if (log == null)
                throw new ArgumentException("zle haslo lub login");

            log.login = newLogin;
            unitOfWork.LogRepo.Aktualizuj(log);
            return new LogPost(log);
        }

        public LogPost EdytujName(string login, string passwd, string newName)
        {
            Log log = PobierzLog(login, passwd);
            if (log == null)
                throw new ArgumentException("zle haslo lub login");

            log.imie = newName;
            unitOfWork.LogRepo.Aktualizuj(log);
            return new LogPost(log);
        }

        public LogPost EdytujPasswd(string login, string passwd, string newPasswd)
        {
            Log log = PobierzLog(login, passwd);
            if (log == null)
                throw new ArgumentException("zle haslo lub login");

            log.haslo = newPasswd;
            unitOfWork.LogRepo.Aktualizuj(log);
            return new LogPost(log);
        }

        public LogPost EdytujSurrname(string login, string passwd, string newSurrname)
        {
            Log log = PobierzLog(login, passwd);
            if (log == null)
                throw new ArgumentException("zle haslo lub login");

            log.nazwisko = newSurrname;
            unitOfWork.LogRepo.Aktualizuj(log);
            return new LogPost(log);
        }

        public LogPost Pobierz(string login, string passwd)
        {
            if (login == null || passwd == null)
                return null;
            Log log = unitOfWork.LogRepo.Pobierz().Where(p => p.login.Contains(login) && p.haslo.Contains(passwd)).FirstOrDefault();
            if (log == null)
                return null; //throw new ArgumentException("zle haslo lub login");
            return new LogPost(log);
        }

        public Log PobierzLog(string login, string passwd)
        {
            Log log = unitOfWork.LogRepo.Pobierz().Where(p => p.login.Contains(login) && p.haslo.Contains(passwd)).FirstOrDefault();
            if (log == null)
                throw new ArgumentException("zle haslo lub login");
            return log;
        }

        public bool Usun(string login, string passwd)
        {
            Log log = PobierzLog(login, passwd);
            if (log == null)
                return false;
            return unitOfWork.LogRepo.Usun(log);

        }
    }
}
