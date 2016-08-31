using System;
using System.Windows.Forms;

namespace App1.Sub1
{
    public partial class ListForm : Form
    {
        private readonly ICustomerService _customerService;

        public ListForm(ICustomerService customerService = null)
        {
            _customerService = customerService ?? CustomerServiceImpl.Current;

            InitializeComponent();
        }

        private async void ListForm_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.AddRange(
                ButtonColumn("ShowButton", "表示"),
                Column("Id", false),
                Column("Name"),
                Column("PostalCode"),
                Column("Prefecture"),
                Column("City"),
                Column("Town"),
                Column("Address"));
            dataGridView1.DataSource = await _customerService.GetCustomers();
        }

        private static DataGridViewColumn ButtonColumn(string name, string text)
        {
            return new DataGridViewButtonColumn
            {
                Name = name,
                HeaderText = string.Empty,
                Text = text,
                UseColumnTextForButtonValue = true
            };
        }

        private static DataGridViewColumn Column(string propertyName, bool visible = true)
        {
            return new DataGridViewTextBoxColumn
            {
                Name = propertyName,
                DataPropertyName = propertyName,
                HeaderText = propertyName,
                ReadOnly = true,
                Visible = visible
            };
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "ShowButton")
            {
                var id = (int) dataGridView1.Rows[e.RowIndex].Cells["Id"].Value;

                var form = new ItemForm(id, _customerService);
                form.Show(this);
            }
        }
    }
}