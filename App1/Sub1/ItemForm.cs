using System;
using System.Windows.Forms;

namespace App1.Sub1
{
    public partial class ItemForm : Form
    {
        public ItemForm()
        {
            InitializeComponent();
        }

        private void addressSearchButton_Click(object sender, EventArgs e)
        {
            var result = AddressSearchForm.Search(this);
            if (result.IsSuccess)
            {
                postalCodeInput.Text = result.PostalCode;
                prefectureInput.Text = result.Prefecture;
                cityInput.Text = result.City;
                townInput.Text = result.Town;
                addressInput.Text = string.Empty;
            }
        }
    }
}