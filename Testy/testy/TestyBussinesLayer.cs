using KsiazkaPrzepisyKokot.BuisnessLayer.Implementacje;
using KsiazkaPrzepisyKokot.Models;
using KsiazkaPrzepisyKokot.UnitOfWork;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;


namespace Testy
{
    class TestyBussinesLayer
    {
        UnitOfWorkTest testUnitOfWork = new UnitOfWorkTest();

        [Test]
        public void getLogByTest()
        {
            LogBL_ logBL = new LogBL_(testUnitOfWork);

            var mockRepo = new MockRepository<Log>();

            Log log = new Log { nazwisko = "abc", haslo = "xxx", imie = "abc", login = "test" };

            mockRepo.Setup(p => p.PobierzPoId(It.IsAny<int>()))
                .Returns(log);

            testUnitOfWork.log_ = mockRepo.Object;

            Assert.AreEqual(log, logBL.Pobierz(It.IsAny<string>(), It.IsAny<string>()));
        }
        [Test]
        public void getPrzepisByIdTest()
        {
            PrzepisyBL_ przepisyBL = new PrzepisyBL_(testUnitOfWork);

            var mockRepo = new MockRepository<Przepisy>();

            Przepisy przepis = new Przepisy { Przepis = "abc", czas = TimeSpan.Zero, data = DateTime.Now, idPrzepisu = 0, liczbaPorcji = 5, nazwaDania = "xx" };

            mockRepo.Setup(p => p.PobierzPoId(It.IsAny<int>()))
                .Returns(przepis);

            testUnitOfWork.przepisy_ = mockRepo.Object;

            Assert.AreEqual(przepis, przepisyBL.Pobierz(It.IsAny<int>()));

        }
    }
}
