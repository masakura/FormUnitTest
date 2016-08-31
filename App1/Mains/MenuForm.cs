using System;
using System.Windows.Forms;

namespace App1.Mains
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new Sub1.MenuForm();
            form.Show(this);
        }
    }
}