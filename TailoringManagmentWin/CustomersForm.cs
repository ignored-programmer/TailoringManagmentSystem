using System;
using System.Windows.Forms;
using TMS.DataLayer;

namespace TailoringManagmentWin
{
    public partial class CustomersForm : Form
    {
        public Overview overview;
        public CustomersForm()
        {
            InitializeComponent();
        }
        private void CustomersForm_Load(object sender, EventArgs e)
        {
            BindGrid();
        }
        void BindGrid()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                if (db != null)
                {
                    dgvCustomers.AutoGenerateColumns = false;
                    dgvCustomers.DataSource = db.CustomerRepository.GetAllCustomers();
                }

            }
        }
        private void textbox_SearchCustomer_TextChanged(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                dgvCustomers.DataSource = db.CustomerRepository.GetCusstomersByFilter(textbox_SearchCustomer.Text);
            }
        }
        private void CustomersForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
            overview.Show();
        }
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            overview.Show();
        }
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            AddOrEditCustomerForm AECF = new AddOrEditCustomerForm();
            if (AECF.ShowDialog() == DialogResult.OK)
            {
                BindGrid();
            }
        }
        private void btnWatchSize_Click(object sender, EventArgs e)
        {
            CustomerSizes customerSizes = new CustomerSizes();
            if (dgvCustomers.CurrentRow != null)
            {
                int customerId = int.Parse(dgvCustomers.CurrentRow.Cells[0].Value.ToString());
                customerSizes.customerId = customerId;
            }
            if (customerSizes.ShowDialog() == DialogResult.OK)
            {
                BindGrid();
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            textbox_SearchCustomer.Text = "";
            BindGrid();
        }
        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.CurrentRow != null)
            {
                int customerId = int.Parse(dgvCustomers.CurrentRow.Cells[0].Value.ToString());
                AddOrEditCustomerForm addOrEditCustomerForm = new AddOrEditCustomerForm();
                addOrEditCustomerForm.customerId = customerId;
                if (addOrEditCustomerForm.ShowDialog() == DialogResult.OK)
                {
                    BindGrid();
                }
            }
        }
        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.CurrentRow != null)
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    string name = dgvCustomers.CurrentRow.Cells[1].Value.ToString();
                    if (MessageBox.Show($"آیا از حذف {name} مطمئن هستید ؟", "توجه", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        int customerId = int.Parse(dgvCustomers.CurrentRow.Cells[0].Value.ToString());
                        db.CustomerRepository.DeleteCustomer(customerId);
                        db.Save();
                        BindGrid();
                    }
                }
            }
            else
            {
                MessageBox.Show("لطفا شخصی را انتخاب کنید");
            }
        }

        private void btnClothMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            overview.clothsForm.Show();
        }

        private void btnOrderMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            overview.ordersList.Show();
        }
    }
}
