using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dependencyinjectiontest.services;
using dependencyinjectiontest.views;

namespace dependencyinjectiontest.controllers
{
    internal class UserController : IController
    {
        private IUserService _userService;
        private IViewUser _view;

        public UserController(IViewUser aView, IUserService userService)
        {
            _userService = userService;
            _view = aView;
            _view.EventTest += TestMethod;
        }

        public void TestMethod(object sender, EventArgs e)
        {
            _view.ShowMessage("DSTU");
        }

        public void Auth(String login, String pass)
        {
            try
            {
                _userService.Auth(login, pass);
            }
            catch (Exception ex)
            {
                _view.ShowMessageError(ex.Message);
            }
        }

        public void Run()
        {
            _view.Show();
        }
    }
}
