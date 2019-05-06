using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Ninject.Modules;
using dependencyinjectiontest.controllers;
using dependencyinjectiontest.services;
using dependencyinjectiontest.daos;
using dependencyinjectiontest.views;
using System.Windows.Forms;

namespace dependencyinjectiontest
{
    public class Bindings : NinjectModule
    {
        public override void Load()
        {
            Bind<IViewStudent>().To<StudentForm>().InSingletonScope();
            Bind<DatabaseConnection>().To<DatabaseConnection>();
            Bind<StudentDao>().To<StudentDao>();
            Bind<StudentService>().To<StudentService>();
            Bind<StudentController>().To<StudentController>().InSingletonScope();

            Bind<IViewUser>().To<UserForm>().InSingletonScope();
            Bind<IUserService>().To<UserService>();
            Bind<UserController>().To<UserController>().InSingletonScope();
        }
    }
}
