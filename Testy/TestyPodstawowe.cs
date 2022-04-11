using KsiazkaPrzepisyKokot.Models;
using KsiazkaPrzepisyKokot.UnitOfWork;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Testy
{
    class TestyPodstawowe
    {
        [Test]
        public void DummyExample()
        {
            
            string firstName = null;
            string lastName = It.IsAny<string>(); // Dummy

            Action act = () => new UnitOfWorkTest();

            Assert.IsNotNull(act);
        }
        [Test]
        public void StubExample()
        {
            string firstName = null;
            string lastName = It.IsAny<string>(); // Dummy

            var unit = new UnitOfWorkTest();
            var pobranieRepo = unit.PrzepisyRepo;

            Assert.IsNotNull(pobranieRepo);
        }
        [Test]
        public void FakeExample()
        {
            var fakeRepo = new FakeRepo<Log>();

            fakeRepo.Dodaj(new Log { nazwisko = "abc", haslo = "xxx", imie = "abc", login = "test" });

            Log log= new Log { nazwisko = "abc", haslo = "xxx", imie = "abc", login = "test" };

            Assert.AreSame(log.login, fakeRepo.PobierzPoId(0).login);
            Assert.AreSame(log.nazwisko, fakeRepo.PobierzPoId(0).nazwisko);
            Assert.AreSame(log.haslo, fakeRepo.PobierzPoId(0).haslo);
            Assert.AreSame(log.imie, fakeRepo.PobierzPoId(0).imie);
        }

    }
}
