using System;
using System.Windows.Forms;

namespace App1.Sub1
{
    public partial class ItemForm : Form
    {
        private readonly int _customerId;
        private readonly IAddressSearcher _addressSearcher;
        private readonly ICustomerService _customerService;

        public ItemForm(int id, ICustomerService customerService = null, IAddressSearcher addressSearcher = null)
        {
            _customerId = id;
            _customerService = customerService ?? CustomerServiceImpl.Current;
            _addressSearcher = addressSearcher ?? AddressSearcherImpl.Current;

            InitializeComponent();
        }

        private void addressSearchButton_Click(object sender, EventArgs e)
        {
            var result = _addressSearcher.Search(this);
            if (result.IsSuccess)
            {
                postalCodeInput.Text = result.PostalCode;
                prefectureInput.Text = result.Prefecture;
                cityInput.Text = result.City;
                townInput.Text = result.Town;
                addressInput.Text = string.Empty;
            }
        }

        private async void ItemForm_Load(object sender, EventArgs e)
        {
            var customer = await _customerService.GetCustomer(_customerId);
            if (customer != null)
            {
                nameInput.Text = customer.Name;
                postalCodeInput.Text = customer.PostalCode;
                prefectureInput.Text = customer.Prefecture;
                cityInput.Text = customer.City;
                townInput.Text = customer.Town;
                addressInput.Text = customer.Address;
            }
        }
    }
}