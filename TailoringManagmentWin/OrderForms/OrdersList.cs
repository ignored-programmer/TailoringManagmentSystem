using System;
using System.Linq;
using System.Windows.Forms;
using TailoringManagmentWin.ClothForms;
using TMS.DataLayer;

namespace TailoringManagmentWin.OrderForms
{
    public partial class OrdersList : Form
    {
        public Overview overview;

        public OrdersList()
        {
            InitializeComponent();
        }
        void BindGrid()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                if (db != null)
                {
                    dgvOrders.AutoGenerateColumns = false;
                    dgvOrders.DataSource = db.OrderRepository.GetAllOrders();
                }

            }
        }
        private void Overview_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void btnCustomerForm_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void txtbSearchOrders_TextChanged(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                dgvOrders.DataSource = db.OrderRepository.GetOrderssByFilter(txtbSearchOrders.Text);
            }
        }

        private void btnAddNewOrder_Click(object sender, EventArgs e)
        {
            Basket basket = new Basket();
            if (basket.ShowDialog() == DialogResult.OK)
            {
                BindGrid();
            }
        }
        private void OrdersList_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
            overview.Show();
        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            if (dgvOrders.CurrentRow != null)
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    string name = dgvOrders.CurrentRow.Cells[1].Value.ToString();
                    if (MessageBox.Show($"آیا از حذف {name} مطمئن هستید ؟", "توجه", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        int orderId = int.Parse(dgvOrders.CurrentRow.Cells[0].Value.ToString());
                        db.OrderRepository.DeleteOrder(orderId);
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

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            overview.Show();
        }

        private void btnCustomersMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            overview.customersForm.Show();
        }

        private void btnClothMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            overview.clothsForm.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            txtbSearchOrders.Text = "";
            BindGrid();
        }
    }
}
