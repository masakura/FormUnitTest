using System;
using System.Windows.Forms;

namespace App1.Sub1
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new ListForm();
            form.Show(this);
        }
    }
}