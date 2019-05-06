using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dependencyinjectiontest.services
{
    interface IUserService
    {
        void Auth(String login, String pass);
    }
}
