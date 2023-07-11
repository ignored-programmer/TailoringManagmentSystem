using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using TMS.DataLayer;
using TMS.DataLayer.Models;

namespace TailoringManagmentWin.OrderForms
{
    public partial class Basket : Form
    {
        public int customerId = 0;
        UnitOfWork db = new UnitOfWork();
        DataTable dt = new DataTable();
        public Basket()
        {
            InitializeComponent();
        }
        private void Basket_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("نام مشتری");
            dt.Columns.Add("شماره تماس");
            dt.Columns.Add("شماره سفارش");
            dt.Columns.Add("وضعیت");
            dt.Columns.Add("پارچه");
            dt.Columns.Add("روش پرداخت");
            dt.Columns.Add("میلغ دریافتی");
            dt.Columns.Add("مبلغ کل");
            guna2DataGridView1.DataSource = dt;


            combStatus.Items.Add("درحال انجام");
            combStatus.Items.Add("آماده تحویل");
            combStatus.Items.Add("تحویل داده شده");

            combPaymentMethod.Items.Add("نقدی");
            combPaymentMethod.Items.Add("کارتی");

            using (UnitOfWork db = new UnitOfWork())
            {
                if (db != null)
                {
                    var customersinit = db.CustomerRepository.GetAllCustomers();
                    foreach (var item in customersinit)
                    {
                        combChooseCustomer.Items.Add(item.FullName);
                    }
                    var clothinit = db.ClothRepository.GetAllCloths();
                    foreach (var item in clothinit)
                    {
                        combChooseCloth.Items.Add(item.ClothName);
                    }

                }

            }
        }
        private void btnAddToBasket_Click(object sender, EventArgs e)
        {
            DataRow dr = dt.NewRow();
            dr[0] = combChooseCustomer.Text;
            dr[1] = txtbMobileCustomer.Text;
            dr[2] = txtbOrderCode.Text;
            dr[3] = combStatus.Text;
            dr[4] = combChooseCloth.Text;
            dr[5] = combPaymentMethod.Text;
            dr[6] = txtbReceivedMoney.Text;
            dr[7] = txtbTotalPrice.Text;
            dt.Rows.Add(dr);
            guna2DataGridView1.DataSource = dt;
        }

        private void combChooseCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            var customermobile = db.CustomerRepository.GetCustomerMobileByName(combChooseCustomer.Text);
            txtbMobileCustomer.Text = customermobile;
        }

        private void btnAddOrders_Click(object sender, EventArgs e)
        {
            var iduser = db.CustomerRepository.GetCustomerIdByName(combChooseCustomer.Text);
            var clothid = db.ClothRepository.GetClothIdByName(combChooseCloth.Text);

            for (int i = 0; i < guna2DataGridView1.Rows.Count; i++)
            {
                
                Order orders = new Order()
                {
                    
                    CustomerFullName = guna2DataGridView1.Rows[i].Cells[0].Value.ToString(),
                    MobileCustomer = guna2DataGridView1.Rows[i].Cells[1].Value.ToString(),
                    OrderCode = int.Parse(guna2DataGridView1.Rows[i].Cells[2].Value.ToString()),
                    Status = guna2DataGridView1.Rows[i].Cells[3].Value.ToString(),
                    ClothId = clothid,
                    PaymentMethod = guna2DataGridView1.Rows[i].Cells[5].Value.ToString(),
                    ReceivedMoney = int.Parse(guna2DataGridView1.Rows[i].Cells[6].Value.ToString()),
                    TotalPrice = int.Parse(guna2DataGridView1.Rows[i].Cells[7].Value.ToString()),
                    CustomerId = iduser
            };

                db.OrderRepository.InsertOrder(orders);
                db.Save();
                DialogResult = DialogResult.OK;
            }
        }
    }
}

