using dependencyinjectiontest.daos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dependencyinjectiontest.services
{
    class UserService : IUserService
    {
        private StudentDao StudentDao;

        public UserService(StudentDao studentDao)
        {
            StudentDao = studentDao;
        }

        public void Auth(String login, String pass)
        {
            StudentDao.getById(123);
            Console.WriteLine("Авторизация успешна");
        }
    }
}
