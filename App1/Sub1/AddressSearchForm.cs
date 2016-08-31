using System;
using System.Windows.Forms;

namespace App1.Sub1
{
    public partial class AddressSearchForm : Form
    {
        private readonly IAddressSearchService _addressSearchService;
        private AddressResult _addressResult;

        public AddressSearchForm(IAddressSearchService addressSearchService)
        {
            _addressSearchService = addressSearchService ?? AddressSearchServiceImpl.Current;

            InitializeComponent();

            AddressResult = AddressResult.Empty();
        }

        public AddressResult AddressResult
        {
            get { return _addressResult; }
            private set
            {
                _addressResult = value;

                postalCodeInput.Text = value.PostalCode;
                prefectureInput.Text = value.Prefecture;
                cityInput.Text = value.City;
                townInput.Text = value.Town;
            }
        }

        public static AddressResult Search(IWin32Window parent, IAddressSearchService addressSearchService = null)
        {
            using (var form = new AddressSearchForm(addressSearchService))
            {
                var result = form.ShowDialog(parent);
                return result == DialogResult.OK ? form.AddressResult : AddressResult.Empty();
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            AddressResult = await _addressSearchService.Search(input.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}