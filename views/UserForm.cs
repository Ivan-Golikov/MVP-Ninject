using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dependencyinjectiontest.views
{
    public partial class UserForm : Form, IViewUser
    {
        public event EventHandler<EventArgs> EventTest;

        public UserForm()
        {
            InitializeComponent();
        }

        public void ShowMessageError(string msg)
        {
            label1.Text = msg;
        }

        public void ShowMessage(string msg)
        {
            label2.Text = msg;
        }

        public new void Show()
        {
            // запуск второй формы в отдельном потоке
            Thread t = new Thread(new ThreadStart(() => Application.Run(this)));
            t.Start();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Используется механизм событий
            // При нажатии на кнопку интерфейса, мы генерируем новое собственное событые
            // определенное выше, а в контроллере подписываемся на него
            EventTest?.Invoke(this, e);
        }

        private void UserForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
