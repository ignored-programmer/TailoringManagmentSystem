using System;
using System.Windows.Forms;
using TMS.DataLayer;
using TMS.DataLayer.Models;

namespace TailoringManagmentWin.OrderForms
{
    public partial class AddOrEditOrserForm : Form
    {
        public int customerId = 0;
        UnitOfWork db = new UnitOfWork();
        public AddOrEditOrserForm()
        {
            InitializeComponent();
        }

        private void AddOrEditOrserForm_Load(object sender, EventArgs e)
        {
            if (customerId != 0)
            {
                btnAEC.Text = "ویرایش اطلاعات";
                var customer = db.CustomerRepository.GetCustomerById(customerId);
                txtbFullName.Text = customer.FullName;
                txtbPhoneNumber.Text = customer.PhoneNumber;
                txtbPostalCode.Text = customer.PostalCode;
                txtbAddress.Text = customer.Address;

                txtbBalaroPant.Text = customer.BalaRoPant;
                txtbGhadZanooPant.Text = customer.GhadZanooPant;
                txtbGhadKamelPant.Text = customer.GhadKamelPant;
                txtbKamarPant.Text = customer.KamarPant;
                txtbBasanPant.Text = customer.BasanPant;
                txtbRanPant.Text = customer.RanPant;
                txtbZanooPant.Text = customer.ZanooPant;
                txtbDampaPant.Text = customer.DampaPant;

                txtbSarshaneShirt.Text = customer.SarShaneShirt;
                txtbGhadastinShirt.Text = customer.GhadAstinShirt;
                txtbGhadPirahanShirt.Text = customer.GhadPirahanShirt;
                txtbSineShirt.Text = customer.SineShirt;
                txtbKamarShirt.Text = customer.KamarShirt;
                txtbYagheShirt.Text = customer.YagheShirt;
            }
        }

        private void btnAEC_Click(object sender, EventArgs e)
        {
            Customer customers = new Customer()
            {
                FullName = txtbFullName.Text,
                PhoneNumber = txtbPhoneNumber.Text,
                PostalCode = txtbPostalCode.Text,
                Address = txtbAddress.Text,

                BalaRoPant = txtbBalaroPant.Text,
                GhadZanooPant = txtbGhadZanooPant.Text,
                GhadKamelPant = txtbGhadKamelPant.Text,
                KamarPant = txtbKamarPant.Text,
                BasanPant = txtbBasanPant.Text,
                RanPant = txtbRanPant.Text,
                ZanooPant = txtbZanooPant.Text,
                DampaPant = txtbDampaPant.Text,

                SarShaneShirt = txtbSarshaneShirt.Text,
                GhadAstinShirt = txtbGhadastinShirt.Text,
                GhadPirahanShirt = txtbGhadPirahanShirt.Text,
                SineShirt = txtbSineShirt.Text,
                KamarShirt = txtbKamarShirt.Text,
                YagheShirt = txtbYagheShirt.Text,
                IsActive = true
            };
            if (customerId == 0)
            {
                db.CustomerRepository.InsertCustomer(customers);
            }
            else
            {
                customers.Id = customerId;
                db.CustomerRepository.UpdateCustomer(customers);
            }
            db.Save();
            DialogResult = DialogResult.OK;
        }
    }
}
