using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ninject;
using System.Reflection;
using dependencyinjectiontest.daos;
using dependencyinjectiontest.services;
using dependencyinjectiontest.controllers;
using dependencyinjectiontest.views;

namespace dependencyinjectiontest
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            IKernel kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());
        
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            StudentController studentController = kernel.Get<StudentController>();
            studentController.Run();
        }
    }
}

//form1 view = new form1();
//databaseconnection db = new databaseconnection();
//studentdao studentdao = new studentdao(db);
//studentservice studentservice = new studentservice(studentdao);
//studentcontroller studentcontroller = new studentcontroller(view, studentservice);