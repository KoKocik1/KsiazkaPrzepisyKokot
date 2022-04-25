using KsiazkaPrzepisyKokot.BuisnessLayer.Implementacje;
using KsiazkaPrzepisyKokot.Database;
using KsiazkaPrzepisyKokot.Models;
using KsiazkaPrzepisyKokot.Repository.Implementacje;
using KsiazkaPrzepisyKokot.UnitOfWork;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Testy
{
    class TestyRepozytoria
    {

        [Test]
        public void DummyExample()
        {
            LogBL logBl = new LogBL(new UnitOfWork_(new BazaDanych()));
            Log log = new Log { nazwisko = "abc", haslo = "xxx", imie = "abc", login = "test" };
            Action act = () => logBl.Pobierz("xxx","xxx");
            //act.ShouldThrow<ArgumentException>();
        }

        [Test]
        public void StubExample()
        {
            LogBL logBl = new LogBL(new UnitOfWork_(new BazaDanych()));
            Log log = new Log { nazwisko = "abc", haslo = "xxx", imie = "abc", login = "test" };
            var customer = Mock.Of<Log>(c => c.haslo == "xxx"); // Stub
            Assert.AreEqual(customer.haslo, "xxx");
        }
        [Test]
        public void FakeExample()
        {
            var repo = new Repository<Log>(new BazaDanych());
            Log log = new Log { nazwisko = "abc", haslo = "xxx", imie = "abc", login = "test" , idLog=0};

            repo.Dodaj(log);

            Log logTest = repo.PobierzPoId(1);
            Assert.IsNotNull(logTest);
        }

    }
}
