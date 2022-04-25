using KsiazkaPrzepisyKokot.Models;
using KsiazkaPrzepisyKokot.Repository.Interfaces;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;

namespace Testy
{

        public class MockRepository<T> : Mock<IRepository<T>>
        {
            public MockRepository<T> MockGetByID(T result)
            {
                Setup(x => x.PobierzPoId(It.IsAny<int>()))
                .Returns(result);

                return this;
            }
            public MockRepository<T> MockGetWithoutID()
            {
                Setup(x => x.PobierzPoId(It.IsAny<int>()))
                .Throws(new Exception());

                return this;
            }

        }
    
}
