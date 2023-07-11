using System.Drawing.Text;
using System.Drawing;

namespace TailoringManagmentWin.ClothForms
{
    partial class ClothsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClothsForm));
            this.textbSearchCloth = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel6 = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvCloths = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClothName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClothCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClothPic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inventory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvailableSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnOrderMenu = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ImageButton2 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnClothForm = new Guna.UI2.WinForms.Guna2Button();
            this.btnCustomersMenu = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDashboard = new Guna.UI2.WinForms.Guna2Button();
            this.btnEditCloth = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddNewCloth = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteCloth = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCloths)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textbSearchCloth
            // 
            this.textbSearchCloth.BorderThickness = 0;
            this.textbSearchCloth.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textbSearchCloth.DefaultText = "";
            this.textbSearchCloth.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textbSearchCloth.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textbSearchCloth.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textbSearchCloth.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textbSearchCloth.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(16)))), ((int)(((byte)(47)))));
            this.textbSearchCloth.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textbSearchCloth.Font = new System.Drawing.Font("YEKAN PLUS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbSearchCloth.ForeColor = System.Drawing.Color.Transparent;
            this.textbSearchCloth.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textbSearchCloth.IconRight = global::TailoringManagmentWin.Properties.Resources.SearchIcon;
            this.textbSearchCloth.Location = new System.Drawing.Point(291, 10);
            this.textbSearchCloth.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textbSearchCloth.Name = "textbSearchCloth";
            this.textbSearchCloth.PasswordChar = '\0';
            this.textbSearchCloth.PlaceholderText = "... نام پارچه و یا کد پارچه را جستجو کنید";
            this.textbSearchCloth.SelectedText = "";
            this.textbSearchCloth.Size = new System.Drawing.Size(634, 48);
            this.textbSearchCloth.TabIndex = 1;
            this.textbSearchCloth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textbSearchCloth.TextChanged += new System.EventHandler(this.textbSearchCloth_TextChanged);
            // 
            // guna2Panel6
            // 
            this.guna2Panel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.guna2Panel6.BorderRadius = 10;
            this.guna2Panel6.Controls.Add(this.dgvCloths);
            this.guna2Panel6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(67)))));
            this.guna2Panel6.Location = new System.Drawing.Point(15, 126);
            this.guna2Panel6.Name = "guna2Panel6";
            this.guna2Panel6.Size = new System.Drawing.Size(903, 645);
            this.guna2Panel6.TabIndex = 10;
            // 
            // dgvCloths
            // 
            this.dgvCloths.AllowUserToAddRows = false;
            this.dgvCloths.AllowUserToDeleteRows = false;
            this.dgvCloths.AllowUserToResizeColumns = false;
            this.dgvCloths.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(67)))));
            this.dgvCloths.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCloths.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(104)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("YEKAN PLUS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCloths.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCloths.ColumnHeadersHeight = 35;
            this.dgvCloths.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.ClothName,
            this.ClothCode,
            this.ClothPic,
            this.Inventory,
            this.AvailableSize});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(16)))), ((int)(((byte)(47)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("YEKAN PLUS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(36)))), ((int)(((byte)(170)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCloths.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCloths.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCloths.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(16)))), ((int)(((byte)(47)))));
            this.dgvCloths.Location = new System.Drawing.Point(0, 0);
            this.dgvCloths.Name = "dgvCloths";
            this.dgvCloths.ReadOnly = true;
            this.dgvCloths.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvCloths.RowHeadersVisible = false;
            this.dgvCloths.RowHeadersWidth = 51;
            this.dgvCloths.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCloths.RowTemplate.Height = 26;
            this.dgvCloths.ShowCellErrors = false;
            this.dgvCloths.ShowRowErrors = false;
            this.dgvCloths.Size = new System.Drawing.Size(903, 645);
            this.dgvCloths.TabIndex = 17;
            this.dgvCloths.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Dark;
            this.dgvCloths.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(67)))));
            this.dgvCloths.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvCloths.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvCloths.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvCloths.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvCloths.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(67)))));
            this.dgvCloths.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(16)))), ((int)(((byte)(47)))));
            this.dgvCloths.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(104)))), ((int)(((byte)(221)))));
            this.dgvCloths.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCloths.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("YEKAN PLUS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCloths.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvCloths.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCloths.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvCloths.ThemeStyle.ReadOnly = true;
            this.dgvCloths.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(16)))), ((int)(((byte)(47)))));
            this.dgvCloths.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCloths.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("YEKAN PLUS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCloths.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvCloths.ThemeStyle.RowsStyle.Height = 26;
            this.dgvCloths.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(36)))), ((int)(((byte)(170)))));
            this.dgvCloths.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.FillWeight = 34.2246F;
            this.Id.HeaderText = "#";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // ClothName
            // 
            this.ClothName.DataPropertyName = "ClothName";
            this.ClothName.FillWeight = 109.3965F;
            this.ClothName.HeaderText = "نام پارچه";
            this.ClothName.MinimumWidth = 6;
            this.ClothName.Name = "ClothName";
            this.ClothName.ReadOnly = true;
            // 
            // ClothCode
            // 
            this.ClothCode.DataPropertyName = "ClothCode";
            this.ClothCode.FillWeight = 109.3965F;
            this.ClothCode.HeaderText = "کد پارچه";
            this.ClothCode.MinimumWidth = 6;
            this.ClothCode.Name = "ClothCode";
            this.ClothCode.ReadOnly = true;
            // 
            // ClothPic
            // 
            this.ClothPic.DataPropertyName = "ClothPic";
            this.ClothPic.FillWeight = 109.3965F;
            this.ClothPic.HeaderText = "عکس";
            this.ClothPic.MinimumWidth = 6;
            this.ClothPic.Name = "ClothPic";
            this.ClothPic.ReadOnly = true;
            this.ClothPic.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Inventory
            // 
            this.Inventory.DataPropertyName = "Inventory";
            this.Inventory.FillWeight = 109.3965F;
            this.Inventory.HeaderText = "وضعیت";
            this.Inventory.MinimumWidth = 6;
            this.Inventory.Name = "Inventory";
            this.Inventory.ReadOnly = true;
            // 
            // AvailableSize
            // 
            this.AvailableSize.DataPropertyName = "AvailableSize";
            this.AvailableSize.FillWeight = 109.3965F;
            this.AvailableSize.HeaderText = "متراژ موجود";
            this.AvailableSize.MinimumWidth = 6;
            this.AvailableSize.Name = "AvailableSize";
            this.AvailableSize.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("YEKAN PLUS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(746, 11);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(140, 35);
            this.label1.TabIndex = 11;
            this.label1.Text = "مدیریت پارچه ها";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.guna2Panel2.Controls.Add(this.btnOrderMenu);
            this.guna2Panel2.Controls.Add(this.guna2ImageButton2);
            this.guna2Panel2.Controls.Add(this.btnClothForm);
            this.guna2Panel2.Controls.Add(this.btnCustomersMenu);
            this.guna2Panel2.Controls.Add(this.label2);
            this.guna2Panel2.Controls.Add(this.btnDashboard);
            this.guna2Panel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(67)))));
            this.guna2Panel2.Location = new System.Drawing.Point(931, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.BorderRadius = 10;
            this.guna2Panel2.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(38)))), ((int)(((byte)(63)))), ((int)(((byte)(13)))));
            this.guna2Panel2.ShadowDecoration.Depth = 10;
            this.guna2Panel2.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.guna2Panel2.Size = new System.Drawing.Size(218, 783);
            this.guna2Panel2.TabIndex = 13;
            // 
            // btnOrderMenu
            // 
            this.btnOrderMenu.Animated = true;
            this.btnOrderMenu.AnimatedGIF = true;
            this.btnOrderMenu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOrderMenu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnOrderMenu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOrderMenu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnOrderMenu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(67)))));
            this.btnOrderMenu.Font = new System.Drawing.Font("YEKAN PLUS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.btnOrderMenu.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(16)))), ((int)(((byte)(47)))));
            this.btnOrderMenu.Image = global::TailoringManagmentWin.Properties.Resources.OrderMenu;
            this.btnOrderMenu.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnOrderMenu.Location = new System.Drawing.Point(-7, 300);
            this.btnOrderMenu.Name = "btnOrderMenu";
            this.btnOrderMenu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnOrderMenu.Size = new System.Drawing.Size(213, 55);
            this.btnOrderMenu.TabIndex = 6;
            this.btnOrderMenu.Text = "مدیریت سفارش ها";
            this.btnOrderMenu.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            this.btnOrderMenu.Click += new System.EventHandler(this.btnOrderMenu_Click);
            // 
            // guna2ImageButton2
            // 
            this.guna2ImageButton2.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton2.HoverState.ImageSize = new System.Drawing.Size(42, 42);
            this.guna2ImageButton2.Image = global::TailoringManagmentWin.Properties.Resources.LogoPNG;
            this.guna2ImageButton2.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton2.ImageRotate = 0F;
            this.guna2ImageButton2.ImageSize = new System.Drawing.Size(42, 42);
            this.guna2ImageButton2.Location = new System.Drawing.Point(162, 5);
            this.guna2ImageButton2.Name = "guna2ImageButton2";
            this.guna2ImageButton2.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton2.Size = new System.Drawing.Size(52, 52);
            this.guna2ImageButton2.TabIndex = 2;
            // 
            // btnClothForm
            // 
            this.btnClothForm.Animated = true;
            this.btnClothForm.AnimatedGIF = true;
            this.btnClothForm.BorderRadius = 10;
            this.btnClothForm.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClothForm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClothForm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClothForm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClothForm.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(16)))), ((int)(((byte)(47)))));
            this.btnClothForm.Font = new System.Drawing.Font("YEKAN PLUS", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClothForm.ForeColor = System.Drawing.Color.White;
            this.btnClothForm.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(16)))), ((int)(((byte)(47)))));
            this.btnClothForm.Image = global::TailoringManagmentWin.Properties.Resources.ClothMenu;
            this.btnClothForm.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnClothForm.ImageSize = new System.Drawing.Size(22, 22);
            this.btnClothForm.Location = new System.Drawing.Point(-7, 231);
            this.btnClothForm.Name = "btnClothForm";
            this.btnClothForm.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnClothForm.Size = new System.Drawing.Size(213, 55);
            this.btnClothForm.TabIndex = 5;
            this.btnClothForm.Text = "مدیریت پارچه ها";
            this.btnClothForm.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            // 
            // btnCustomersMenu
            // 
            this.btnCustomersMenu.Animated = true;
            this.btnCustomersMenu.AnimatedGIF = true;
            this.btnCustomersMenu.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.btnCustomersMenu.BorderRadius = 10;
            this.btnCustomersMenu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomersMenu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomersMenu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCustomersMenu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCustomersMenu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(67)))));
            this.btnCustomersMenu.Font = new System.Drawing.Font("YEKAN PLUS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomersMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.btnCustomersMenu.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(16)))), ((int)(((byte)(47)))));
            this.btnCustomersMenu.Image = global::TailoringManagmentWin.Properties.Resources.UserMenu;
            this.btnCustomersMenu.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCustomersMenu.Location = new System.Drawing.Point(-7, 162);
            this.btnCustomersMenu.Name = "btnCustomersMenu";
            this.btnCustomersMenu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnCustomersMenu.Size = new System.Drawing.Size(213, 55);
            this.btnCustomersMenu.TabIndex = 4;
            this.btnCustomersMenu.Text = "مدیریت مشتریان";
            this.btnCustomersMenu.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            this.btnCustomersMenu.Click += new System.EventHandler(this.btnCustomersMenu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("YEKAN PLUS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "سیستم مدیریت خیاطی";
            // 
            // btnDashboard
            // 
            this.btnDashboard.Animated = true;
            this.btnDashboard.AnimatedGIF = true;
            this.btnDashboard.BorderRadius = 10;
            this.btnDashboard.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDashboard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDashboard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDashboard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDashboard.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(67)))));
            this.btnDashboard.Font = new System.Drawing.Font("YEKAN PLUS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.btnDashboard.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(16)))), ((int)(((byte)(47)))));
            this.btnDashboard.Image = global::TailoringManagmentWin.Properties.Resources.DashboardMenu;
            this.btnDashboard.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDashboard.ImageSize = new System.Drawing.Size(18, 18);
            this.btnDashboard.Location = new System.Drawing.Point(-7, 93);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnDashboard.Size = new System.Drawing.Size(213, 55);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "داشبورد";
            this.btnDashboard.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnEditCloth
            // 
            this.btnEditCloth.BackColor = System.Drawing.Color.Transparent;
            this.btnEditCloth.BorderRadius = 10;
            this.btnEditCloth.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEditCloth.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEditCloth.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEditCloth.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEditCloth.FillColor = System.Drawing.Color.Orange;
            this.btnEditCloth.Font = new System.Drawing.Font("YEKAN PLUS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCloth.ForeColor = System.Drawing.Color.White;
            this.btnEditCloth.Image = global::TailoringManagmentWin.Properties.Resources.IconEdit;
            this.btnEditCloth.ImageSize = new System.Drawing.Size(24, 24);
            this.btnEditCloth.Location = new System.Drawing.Point(81, 7);
            this.btnEditCloth.Name = "btnEditCloth";
            this.btnEditCloth.Size = new System.Drawing.Size(49, 45);
            this.btnEditCloth.TabIndex = 21;
            this.btnEditCloth.Click += new System.EventHandler(this.btnEditCloth_Click);
            // 
            // btnAddNewCloth
            // 
            this.btnAddNewCloth.BackColor = System.Drawing.Color.Transparent;
            this.btnAddNewCloth.BorderRadius = 10;
            this.btnAddNewCloth.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewCloth.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewCloth.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddNewCloth.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddNewCloth.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(104)))), ((int)(((byte)(221)))));
            this.btnAddNewCloth.Font = new System.Drawing.Font("YEKAN PLUS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewCloth.ForeColor = System.Drawing.Color.White;
            this.btnAddNewCloth.Image = global::TailoringManagmentWin.Properties.Resources.addIcon;
            this.btnAddNewCloth.Location = new System.Drawing.Point(263, 7);
            this.btnAddNewCloth.Name = "btnAddNewCloth";
            this.btnAddNewCloth.Size = new System.Drawing.Size(180, 45);
            this.btnAddNewCloth.TabIndex = 20;
            this.btnAddNewCloth.Text = "افزودن پارچه جدید";
            this.btnAddNewCloth.Click += new System.EventHandler(this.btnAddNewCloth_Click);
            // 
            // btnDeleteCloth
            // 
            this.btnDeleteCloth.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteCloth.BorderRadius = 10;
            this.btnDeleteCloth.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteCloth.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteCloth.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteCloth.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteCloth.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(60)))), ((int)(((byte)(74)))));
            this.btnDeleteCloth.Font = new System.Drawing.Font("YEKAN PLUS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCloth.ForeColor = System.Drawing.Color.White;
            this.btnDeleteCloth.Image = global::TailoringManagmentWin.Properties.Resources.IconDel;
            this.btnDeleteCloth.ImageSize = new System.Drawing.Size(24, 24);
            this.btnDeleteCloth.Location = new System.Drawing.Point(26, 7);
            this.btnDeleteCloth.Name = "btnDeleteCloth";
            this.btnDeleteCloth.Size = new System.Drawing.Size(49, 45);
            this.btnDeleteCloth.TabIndex = 22;
            this.btnDeleteCloth.Click += new System.EventHandler(this.btnDeleteCloth_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderRadius = 10;
            this.guna2Panel1.Controls.Add(this.guna2Button1);
            this.guna2Panel1.Controls.Add(this.btnDeleteCloth);
            this.guna2Panel1.Controls.Add(this.btnAddNewCloth);
            this.guna2Panel1.Controls.Add(this.btnEditCloth);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(67)))));
            this.guna2Panel1.Location = new System.Drawing.Point(15, 62);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(903, 58);
            this.guna2Panel1.TabIndex = 23;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(184)))), ((int)(((byte)(180)))));
            this.guna2Button1.Font = new System.Drawing.Font("YEKAN PLUS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(136, 7);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(121, 45);
            this.guna2Button1.TabIndex = 18;
            this.guna2Button1.Text = "بروزرسانی";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // ClothsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(16)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(1149, 783);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.textbSearchCloth);
            this.Controls.Add(this.guna2Panel6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ClothsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "سیستم مدیریت خیاطی | پارچه ها";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClothsForm_FormClosing);
            this.Load += new System.EventHandler(this.Overview_Load);
            this.guna2Panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCloths)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox textbSearchCloth;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel6;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button btnOrderMenu;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton2;
        private Guna.UI2.WinForms.Guna2Button btnClothForm;
        private Guna.UI2.WinForms.Guna2Button btnCustomersMenu;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnDashboard;
        private Guna.UI2.WinForms.Guna2Button btnEditCloth;
        private Guna.UI2.WinForms.Guna2Button btnAddNewCloth;
        private Guna.UI2.WinForms.Guna2DataGridView dgvCloths;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClothName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClothCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClothPic;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn AvailableSize;
        private Guna.UI2.WinForms.Guna2Button btnDeleteCloth;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}

