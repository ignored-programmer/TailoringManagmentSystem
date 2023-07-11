using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TMS.DataLayer;
using TMS.DataLayer.Models;

namespace TailoringManagmentWin
{
    public partial class CustomerSizes : Form
    {
        public int customerId = 0;
        UnitOfWork db = new UnitOfWork();

        public CustomerSizes()
        {
            InitializeComponent();
        }
        private void CustomerSizes_Load(object sender, EventArgs e)
        {
            if (customerId != 0)
            {
                var customer = db.CustomerRepository.GetCustomerById(customerId);
                txtCustomerName.Text += " " + customer.FullName;
                txtPhoneNumber.Text += " " + customer.PhoneNumber;

                txtBalaroPant.Text += " " + customer.BalaRoPant;
                txtGhadZanooPant.Text += " " + customer.GhadZanooPant;
                txtGhadKamelPant.Text += " " + customer.GhadKamelPant;
                txtKamarPant.Text += " " + customer.KamarPant;
                txtKamarPant.Text += " " + customer.BasanPant;
                txtRanPant.Text  += " " + customer.RanPant;
                txtZanooPant.Text += " " + customer.ZanooPant;
                txtDampaPant.Text += " " + customer.DampaPant;

                txtSarshaneShirt.Text += " " + customer.SarShaneShirt;
                txtGhadastinShirt.Text += " " + customer.GhadAstinShirt;
                txtGhadPirahanShirt.Text += " " + customer.GhadPirahanShirt;
                txtSineShirt.Text += " " + customer.SineShirt;
                txtKamarShirt.Text += " " + customer.KamarShirt;
                txtYagheShirt.Text += " " + customer.YagheShirt;
            }
        }

        private void CustomerSizes_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            e.Cancel = true;
            this.Hide();
        }
    }
}
