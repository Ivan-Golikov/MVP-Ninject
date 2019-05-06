using dependencyinjectiontest.models.universities;
using dependencyinjectiontest.services;
using dependencyinjectiontest.views;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dependencyinjectiontest.controllers
{
    class StudentController : IController
    {
        private StudentService _studentService;
        private IViewStudent view;

        public StudentController(IViewStudent aView, StudentService studentService)
        {
            view = aView;
            view.EventGetStudents += GetBestStudents;
            view.EventOpenUserForm += OpenUserForm;
            _studentService = studentService;
        }

        public void GetBestStudents(object sender, EventArgs e)
        {
            try {
                List<Student> students = _studentService.GetBestStudents();
                //.. view.dataGridView1.DataSource = students
            } catch(Exception ex) {
                view.ShowMessageError(ex.Message);
            }
        }

        public void Run()
        {
            view.Show();
        }

        public void OpenUserForm(object sender, EventArgs e)
        {
            IKernel kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());
            // UserController userController = new UserController(new UserForm(), new UserService(new daos.StudentDao(new daos.DatabaseConnection())));
            UserController userController = kernel.Get<UserController>();
            userController.Run();
        }
    }
}
