using System;
using System.Linq;
using System.Windows.Forms;
using TailoringManagmentWin.ClothForms;
using TailoringManagmentWin.OrderForms;
using TMS.DataLayer;

namespace TailoringManagmentWin
{
    public partial class Overview : Form
    {
        public LoginForm loginForm = new LoginForm();

        public CustomersForm customersForm = new CustomersForm();
        public ClothsForm clothsForm = new ClothsForm();
        public OrdersList ordersList = new OrdersList();

        public Overview()
        {
            InitializeComponent();
            customersForm.overview = this;
            clothsForm.overview = this;
            ordersList.overview = this;
        }


        private void Overview_Load(object sender, EventArgs e)
        {
            BindGrid();

            DialogResult result = loginForm.ShowDialog();

            using (UnitOfWork db = new UnitOfWork())
            {
                var CustomersNum = db.CustomerRepository.GetAllCustomers().Count;
                var OrdersNum = db.OrderRepository.GetAllOrders().Count;
                var PaymentSum = db.OrderRepository.GetTotal();
                var ClothsNum = db.ClothRepository.GetAllCloths().Count;
                lblCustomersNum.Text = CustomersNum.ToString() + "  عدد";
                lblOrdersNum.Text = OrdersNum.ToString() + "  عدد";
                lblPaymentSum.Text = PaymentSum.ToString() + "  هزارتومان";
                lblClothsNum.Text = ClothsNum.ToString() + "  عدد";
            }

            if (result == DialogResult.OK)
            {
                this.Show();
            }
            else
            {
                Application.Exit();
            }
        }

        void BindGrid()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                if (db != null)
                {
                    dgvOverviewOrders.AutoGenerateColumns = false;
                    dgvOverviewOrders.DataSource = db.OrderRepository.GetAllOrders();
                }

            }
        }
        private void btn_logout_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }
        private void txtbSearchOrders_TextChanged(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                dgvOverviewOrders.DataSource = db.OrderRepository.GetOrderssByFilter(txtbSearchOrders.Text);
            }
        }
        private void btnCustomerForm_Click(object sender, EventArgs e)
        {
            customersForm.Show();
            this.Hide();
        }


        private void btnClothForm_Click(object sender, EventArgs e)
        {
            clothsForm.Show();
            this.Hide();
        }

        private void btnOrderForm_Click(object sender, EventArgs e)
        {
            ordersList.Show();
            this.Hide();
        }
    }
}
