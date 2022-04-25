using KsiazkaPrzepisyKokot.BuisnessLayer.Implementacje;
using KsiazkaPrzepisyKokot.Database;
using KsiazkaPrzepisyKokot.Models;
using KsiazkaPrzepisyKokot.UnitOfWork;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Testy.testy
{
    class TestNaPamieci
    {
        [Test]
        public void setAndGetLog()
        {
            BazaDanych baza = new BazaDanych();
            UnitOfWork_ unit = new UnitOfWork_(baza);
            LogBL log_bl = new LogBL(unit);
            Log log = new Log { nazwisko = "abc", haslo = "xxx", imie = "abc", login = "test" };
            log_bl.Dodaj(log);
            unit.Save();
            log_bl.EdytujLogin("test", "xxx", "test1");
            Log pobranyLog=log_bl.Pobierz("test", "xxx");
            Assert.AreEqual("test1", pobranyLog.login);
            Assert.AreEqual(log.nazwisko, pobranyLog.nazwisko);
            Assert.AreEqual(log.haslo, pobranyLog.haslo);
            Assert.AreEqual(log.imie, pobranyLog.imie);
        }
    }
}
