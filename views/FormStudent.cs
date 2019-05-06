using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dependencyinjectiontest.controllers;
using Ninject;
using System.Reflection;
using dependencyinjectiontest.views;

namespace dependencyinjectiontest
{
    internal partial class StudentForm : Form, IViewStudent
    {
        public event EventHandler<EventArgs> EventGetStudents;
        public event EventHandler<EventArgs> EventOpenUserForm;


        public StudentForm()
        {
            InitializeComponent();
        }

        public void ShowMessageError(string msg)
        {
            label1.Text = msg;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Используется механизм событий
            // При нажатии на кнопку интерфейса, мы генерируем новое собственное событые
            // определенное выше, а в контроллере подписываемся на него
            EventGetStudents?.Invoke(this, e);
        }

        public new void Show()
        {
            Application.Run(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Инициализация события запуска второй формы из первой
        // На это событие подписан контроллер StudentController
        private void button2_Click(object sender, EventArgs e)
        {
            EventOpenUserForm?.Invoke(this, e);
        }
    }
}
