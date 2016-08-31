using System;
using System.Collections.Generic;
using System.Windows.Forms;
using App1.Sub1;

namespace TestDriver.Sub1
{
    public partial class AddressSelectStubForm : Form
    {
        private readonly IList<AddressResult> _addresses = new List<AddressResult>
        {
            Address("1111111", "北海道", "札幌", "時計台"),
            Address("1111112", "東京都", "鎌田", "ソリューションスクエア"),
            AddressResult.Empty()
        };

        public AddressSelectStubForm()
        {
            InitializeComponent();
        }

        public AddressResult Selected { get; private set; }

        private static AddressResult Address(string postalCode, string prefecture, string city, string town)
        {
            return AddressResult.Success(postalCode, prefecture, city, town);
        }

        private void AddressSelectFrom_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.AddRange(Column("PostalCode"),
                Column("Prefecture"),
                Column("City"),
                Column("Town"));
            dataGridView1.DataSource = _addresses;
        }

        private static DataGridViewTextBoxColumn Column(string propertyName)
        {
            return new DataGridViewTextBoxColumn
            {
                Name = propertyName,
                DataPropertyName = propertyName,
                HeaderText = propertyName,
                ReadOnly = true
            };
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Selected = _addresses[e.RowIndex];
            DialogResult = DialogResult.OK;
        }
    }
}