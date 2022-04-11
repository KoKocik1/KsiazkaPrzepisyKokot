using KsiazkaPrzepisyKokot.BuisnessLayer.Implementacje;
using KsiazkaPrzepisyKokot.Models;
using KsiazkaPrzepisyKokot.UnitOfWork;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using static Testy.TestMockRepo;

namespace Testy
{
    class TestBL
    {
        UnitOfWorkTest testUnitOfWork = new UnitOfWorkTest();

        [Test]
        public void getLogByTest()
        {
            var mockRepo = new MockRepository<Log>();

            mockRepo.Setup(p => p.PobierzPoId(It.IsAny<int>()))
                .Returns(new Log { nazwisko = "abc", haslo = "xxx", imie = "abc", login = "test" });
            testUnitOfWork.log_ = mockRepo.Object;

            LogBL_ logBL = new LogBL_(testUnitOfWork);
            Assert.Equals("ABC", logBL.Pobierz("test", "xxx"));
        }
        public void getPrzepisByIdTest()
        {
            var mockRepo = new MockRepository<Przepisy>();

            mockRepo.Setup(p => p.PobierzPoId(It.IsAny<int>()))
                .Returns(new Przepisy { Przepis = "abc", czas = TimeSpan.Zero, data = DateTime.Now, idPrzepisu = 0, liczbaPorcji = 5, nazwaDania = "xx" });

            testUnitOfWork.przepisy_ = mockRepo.Object;

            //KompletnyPrzepisBL przepisy = new KompletnyPrzepisBL(testUnitOfWork);

           // Assert.Equals("abc", przepisy.Pobierz(0));
        }
    }
}
