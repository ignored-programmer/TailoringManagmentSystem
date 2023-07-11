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

namespace TailoringManagmentWin.ClothForms
{
    public partial class AddOrEditClothForm : Form
    {
        public int clothId = 0;
        UnitOfWork db = new UnitOfWork();
        public AddOrEditClothForm()
        {
            InitializeComponent();
        }

        private void AddOrEditClothForm_Load(object sender, EventArgs e)
        {
            combClothStatus.Items.Add("موجود");
            combClothStatus.Items.Add("ناموجود");

            if (clothId != 0)
            {
                this.Text = "ویرایش پارچه";
                btnAEcloth.Text = "ویرایش پارچه";
                var cloth = db.ClothRepository.GetClothById(clothId);
                txtbClothName.Text = cloth.ClothName;
                txtbClothCode.Text = cloth.ClothCode;
                combClothStatus.Text = cloth.Inventory;
                txtbAvalebleSize.Text = cloth.AvailableSize.ToString();
                
            }
        }

        private void btnAEcloth_Click(object sender, EventArgs e)
        {
            Cloth cloth = new Cloth()
            {
                ClothName = txtbClothName.Text,
                ClothCode = txtbClothCode.Text,
                AvailableSize = int.Parse(txtbAvalebleSize.Text),
                Inventory = combClothStatus.Text,
                IsActive = true
            };
            if (clothId == 0)
            {
                db.ClothRepository.InsertCloth(cloth);
            }
            else
            {
                cloth.Id = clothId;
                db.ClothRepository.UpdateCloth(cloth);
            }
            db.Save();
            DialogResult = DialogResult.OK;
        }
    }
}
