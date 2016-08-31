using System;
using System.Diagnostics;
using System.Windows.Forms;
using App1.Sub1;
using TestDriver.Sub1;

namespace TestDriver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addressSearchButton_Click(object sender, EventArgs e)
        {
            var result = AddressSearchForm.Search(this, AddressSearchServiceImpl.Current);

            Debug.WriteLine((object) result ?? "(null)");
        }

        private void addresSearchStubButton_Click(object sender, EventArgs e)
        {
            var result = AddressSearchForm.Search(this, new AddressSearchServiceStub());

            Debug.WriteLine((object) result ?? "(null)");
        }

        private void listButton_Click(object sender, EventArgs e)
        {
            var form = new ListForm();
            form.Show(this);
        }

        private void detailButton_Click(object sender, EventArgs e)
        {
            var form = new ItemForm(1, null, new AddressSearcherStub());
            form.Show(this);
        }
    }
}