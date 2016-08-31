using System;
using System.Windows.Forms;

namespace App1.Mains
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var menuForm = new MenuForm();
            menuForm.Show();

            Hide();
            menuForm.Closed += (o, e2) => Close();
        }
    }
}