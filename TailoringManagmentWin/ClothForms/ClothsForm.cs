using System;
using System.Windows.Forms;
using TailoringManagmentWin.OrderForms;
using TMS.DataLayer;

namespace TailoringManagmentWin.ClothForms
{
    public partial class ClothsForm : Form
    {
        public Overview overview;
        public ClothsForm()
        {
            InitializeComponent();
        }
        void BindGrid()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                if (db != null)
                {
                    dgvCloths.AutoGenerateColumns = false;
                    dgvCloths.DataSource = db.ClothRepository.GetAllCloths();
                }

            }
        }

        private void Overview_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClothsForm_FormClosing(object sender, FormClosingEventArgs e)
        {

            e.Cancel = true;
            this.Hide();
            overview.Show();
        }

        private void textbSearchCloth_TextChanged(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                dgvCloths.DataSource = db.ClothRepository.GetClothByFilter(textbSearchCloth.Text);
            }
        }

        private void btnAddNewCloth_Click(object sender, EventArgs e)
        {
            AddOrEditClothForm AEClothForm = new AddOrEditClothForm();
            if (AEClothForm.ShowDialog() == DialogResult.OK)
            {
                BindGrid();
            }
        }

        private void btnEditCloth_Click(object sender, EventArgs e)
        {
            if (dgvCloths.CurrentRow != null)
            {
                int clothId = int.Parse(dgvCloths.CurrentRow.Cells[0].Value.ToString());
                AddOrEditClothForm addOrEditClothForm = new AddOrEditClothForm();
                addOrEditClothForm.clothId = clothId;
                if (addOrEditClothForm.ShowDialog() == DialogResult.OK)
                {
                    BindGrid();
                }
            }
        }

        private void btnDeleteCloth_Click(object sender, EventArgs e)
        {
            if (dgvCloths.CurrentRow != null)
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    string name = dgvCloths.CurrentRow.Cells[1].Value.ToString();
                    if (MessageBox.Show($"آیا از حذف {name} مطمئن هستید ؟", "توجه", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        int clothId = int.Parse(dgvCloths.CurrentRow.Cells[0].Value.ToString());
                        db.ClothRepository.DeleteCloth(clothId);
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
        private void btnOrderMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            overview.ordersList.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            textbSearchCloth.Text = "";
            BindGrid();
        }
    }
}
