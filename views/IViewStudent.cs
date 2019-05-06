using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dependencyinjectiontest.views
{
    public interface IViewStudent
    {
        void ShowMessageError(string msg);
        void Show();
        void Close();

        event EventHandler<EventArgs> EventGetStudents;
        event EventHandler<EventArgs> EventOpenUserForm;
    }
}
