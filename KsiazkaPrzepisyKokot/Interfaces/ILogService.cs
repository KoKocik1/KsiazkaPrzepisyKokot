
using KsiazkaPrzepisyKokot.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KsiazkaPrzepisyKokot.Interfaces
{
    public interface ILogService
    {
        public bool Login(LogDto dto);
        public bool AddUser(LogDto dto);
        public bool DeleteUser(string login, string passwd);
        public bool EditUser(string login, string passwd);
    }
}
