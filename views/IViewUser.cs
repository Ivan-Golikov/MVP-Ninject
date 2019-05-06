using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dependencyinjectiontest.views
{
    public interface IViewUser
    {
        void ShowMessageError(string msg);
        void ShowMessage(string msg);
        void Show();
        void Close();

        event EventHandler<EventArgs> EventTest;
    }
}
