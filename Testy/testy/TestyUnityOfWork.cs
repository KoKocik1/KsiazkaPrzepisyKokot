using KsiazkaPrzepisyKokot.Database;
using KsiazkaPrzepisyKokot.Models;
using KsiazkaPrzepisyKokot.Repository.Implementacje;
using KsiazkaPrzepisyKokot.UnitOfWork;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Testy.testy
{
    class TestyUnityOfWork
    {
        BazaDanych dbContex = new BazaDanych();
        [Test]
        public void getLogByTest()
        {
            Repository<Log> logBL = new Repository<Log>(dbContex);

            var mockRepo = new MockRepository<Log>();


            UnitOfWork_ unit = new UnitOfWork_(dbContex);
            Assert.IsNotNull(unit.LogRepo);
        }
    }
}
