namespace TailoringManagmentWin.OrderForms
{
    partial class OrdersList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrdersList));
            this.txtbSearchOrders = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel6 = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvOrders = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MobileCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceivedMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnOrderMenu = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ImageButton2 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnClothMenu = new Guna.UI2.WinForms.Guna2Button();
            this.btnCustomersMenu = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDashboard = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteOrder = new Guna.UI2.WinForms.Guna2Button();
            this.btnEditCustomer = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddNewOrder = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtbSearchOrders
            // 
            this.txtbSearchOrders.BorderThickness = 0;
            this.txtbSearchOrders.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbSearchOrders.DefaultText = "";
            this.txtbSearchOrders.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbSearchOrders.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbSearchOrders.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbSearchOrders.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbSearchOrders.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(16)))), ((int)(((byte)(47)))));
            this.txtbSearchOrders.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbSearchOrders.Font = new System.Drawing.Font("YEKAN PLUS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbSearchOrders.ForeColor = System.Drawing.Color.Transparent;
            this.txtbSearchOrders.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbSearchOrders.IconRight = global::TailoringManagmentWin.Properties.Resources.SearchIcon;
            this.txtbSearchOrders.Location = new System.Drawing.Point(291, 10);
            this.txtbSearchOrders.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbSearchOrders.Name = "txtbSearchOrders";
            this.txtbSearchOrders.PasswordChar = '\0';
            this.txtbSearchOrders.PlaceholderText = "... نام مشتری ، کد سفارش و یا شماره تماس را جستجو کنید";
            this.txtbSearchOrders.SelectedText = "";
            this.txtbSearchOrders.Size = new System.Drawing.Size(634, 48);
            this.txtbSearchOrders.TabIndex = 1;
            this.txtbSearchOrders.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtbSearchOrders.TextChanged += new System.EventHandler(this.txtbSearchOrders_TextChanged);
            // 
            // guna2Panel6
            // 
            this.guna2Panel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.guna2Panel6.BorderRadius = 10;
            this.guna2Panel6.Controls.Add(this.dgvOrders);
            this.guna2Panel6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(67)))));
            this.guna2Panel6.Location = new System.Drawing.Point(15, 126);
            this.guna2Panel6.Name = "guna2Panel6";
            this.guna2Panel6.Size = new System.Drawing.Size(903, 645);
            this.guna2Panel6.TabIndex = 10;
            // 
            // dgvOrders
            // 
            this.dgvOrders.AllowUserToAddRows = false;
            this.dgvOrders.AllowUserToDeleteRows = false;
            this.dgvOrders.AllowUserToResizeColumns = false;
            this.dgvOrders.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(67)))));
            this.dgvOrders.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOrders.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(104)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("YEKAN PLUS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOrders.ColumnHeadersHeight = 35;
            this.dgvOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.FullName,
            this.OrderCode,
            this.MobileCustomer,
            this.Status,
            this.PaymentMethod,
            this.ReceivedMoney,
            this.TotalPrice});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(16)))), ((int)(((byte)(47)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("YEKAN PLUS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(36)))), ((int)(((byte)(170)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrders.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrders.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(16)))), ((int)(((byte)(47)))));
            this.dgvOrders.Location = new System.Drawing.Point(0, 0);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.ReadOnly = true;
            this.dgvOrders.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvOrders.RowHeadersVisible = false;
            this.dgvOrders.RowHeadersWidth = 51;
            this.dgvOrders.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvOrders.RowTemplate.Height = 26;
            this.dgvOrders.ShowCellErrors = false;
            this.dgvOrders.ShowRowErrors = false;
            this.dgvOrders.Size = new System.Drawing.Size(903, 645);
            this.dgvOrders.TabIndex = 16;
            this.dgvOrders.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Dark;
            this.dgvOrders.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(67)))));
            this.dgvOrders.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvOrders.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvOrders.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvOrders.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvOrders.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(67)))));
            this.dgvOrders.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(16)))), ((int)(((byte)(47)))));
            this.dgvOrders.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(104)))), ((int)(((byte)(221)))));
            this.dgvOrders.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvOrders.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("YEKAN PLUS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvOrders.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvOrders.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvOrders.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvOrders.ThemeStyle.ReadOnly = true;
            this.dgvOrders.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(16)))), ((int)(((byte)(47)))));
            this.dgvOrders.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvOrders.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("YEKAN PLUS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvOrders.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvOrders.ThemeStyle.RowsStyle.Height = 26;
            this.dgvOrders.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(36)))), ((int)(((byte)(170)))));
            this.dgvOrders.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
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
            // FullName
            // 
            this.FullName.DataPropertyName = "CustomerFullName";
            this.FullName.FillWeight = 109.3965F;
            this.FullName.HeaderText = "نام مشتری";
            this.FullName.MinimumWidth = 6;
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            // 
            // OrderCode
            // 
            this.OrderCode.DataPropertyName = "OrderCode";
            this.OrderCode.FillWeight = 109.3965F;
            this.OrderCode.HeaderText = "کد سفارش";
            this.OrderCode.MinimumWidth = 6;
            this.OrderCode.Name = "OrderCode";
            this.OrderCode.ReadOnly = true;
            // 
            // MobileCustomer
            // 
            this.MobileCustomer.DataPropertyName = "MobileCustomer";
            this.MobileCustomer.FillWeight = 109.3965F;
            this.MobileCustomer.HeaderText = "شماره تماس";
            this.MobileCustomer.MinimumWidth = 6;
            this.MobileCustomer.Name = "MobileCustomer";
            this.MobileCustomer.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.FillWeight = 109.3965F;
            this.Status.HeaderText = "وضعیت";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // PaymentMethod
            // 
            this.PaymentMethod.DataPropertyName = "PaymentMethod";
            this.PaymentMethod.FillWeight = 109.3965F;
            this.PaymentMethod.HeaderText = "نحوه پرداخت";
            this.PaymentMethod.MinimumWidth = 6;
            this.PaymentMethod.Name = "PaymentMethod";
            this.PaymentMethod.ReadOnly = true;
            // 
            // ReceivedMoney
            // 
            this.ReceivedMoney.DataPropertyName = "ReceivedMoney";
            this.ReceivedMoney.FillWeight = 109.3965F;
            this.ReceivedMoney.HeaderText = "مبلغ دریافتی";
            this.ReceivedMoney.MinimumWidth = 6;
            this.ReceivedMoney.Name = "ReceivedMoney";
            this.ReceivedMoney.ReadOnly = true;
            // 
            // TotalPrice
            // 
            this.TotalPrice.DataPropertyName = "TotalPrice";
            this.TotalPrice.FillWeight = 109.3965F;
            this.TotalPrice.HeaderText = "مبلغ کل";
            this.TotalPrice.MinimumWidth = 6;
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.ReadOnly = true;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.guna2Panel2.Controls.Add(this.btnOrderMenu);
            this.guna2Panel2.Controls.Add(this.guna2ImageButton2);
            this.guna2Panel2.Controls.Add(this.btnClothMenu);
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
            this.guna2Panel2.TabIndex = 15;
            // 
            // btnOrderMenu
            // 
            this.btnOrderMenu.Animated = true;
            this.btnOrderMenu.AnimatedGIF = true;
            this.btnOrderMenu.BorderRadius = 10;
            this.btnOrderMenu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOrderMenu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnOrderMenu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOrderMenu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnOrderMenu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(16)))), ((int)(((byte)(47)))));
            this.btnOrderMenu.Font = new System.Drawing.Font("YEKAN PLUS", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderMenu.ForeColor = System.Drawing.Color.White;
            this.btnOrderMenu.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(16)))), ((int)(((byte)(47)))));
            this.btnOrderMenu.Image = global::TailoringManagmentWin.Properties.Resources.OrderMenu;
            this.btnOrderMenu.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnOrderMenu.ImageSize = new System.Drawing.Size(21, 21);
            this.btnOrderMenu.Location = new System.Drawing.Point(-7, 300);
            this.btnOrderMenu.Name = "btnOrderMenu";
            this.btnOrderMenu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnOrderMenu.Size = new System.Drawing.Size(213, 55);
            this.btnOrderMenu.TabIndex = 6;
            this.btnOrderMenu.Text = "مدیریت سفارش ها";
            this.btnOrderMenu.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
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
            // btnClothMenu
            // 
            this.btnClothMenu.Animated = true;
            this.btnClothMenu.AnimatedGIF = true;
            this.btnClothMenu.BorderRadius = 10;
            this.btnClothMenu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClothMenu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClothMenu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClothMenu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClothMenu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(67)))));
            this.btnClothMenu.Font = new System.Drawing.Font("YEKAN PLUS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClothMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.btnClothMenu.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(16)))), ((int)(((byte)(47)))));
            this.btnClothMenu.Image = global::TailoringManagmentWin.Properties.Resources.ClothMenu;
            this.btnClothMenu.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnClothMenu.Location = new System.Drawing.Point(-7, 231);
            this.btnClothMenu.Name = "btnClothMenu";
            this.btnClothMenu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnClothMenu.Size = new System.Drawing.Size(213, 55);
            this.btnClothMenu.TabIndex = 5;
            this.btnClothMenu.Text = "مدیریت پارچه ها";
            this.btnClothMenu.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            this.btnClothMenu.Click += new System.EventHandler(this.btnClothMenu_Click);
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
            this.btnDashboard.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDashboard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDashboard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDashboard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDashboard.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(67)))));
            this.btnDashboard.Font = new System.Drawing.Font("YEKAN PLUS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
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
            // btnDeleteOrder
            // 
            this.btnDeleteOrder.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteOrder.BorderRadius = 10;
            this.btnDeleteOrder.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteOrder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteOrder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteOrder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteOrder.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(60)))), ((int)(((byte)(74)))));
            this.btnDeleteOrder.Font = new System.Drawing.Font("YEKAN PLUS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteOrder.ForeColor = System.Drawing.Color.White;
            this.btnDeleteOrder.Image = global::TailoringManagmentWin.Properties.Resources.IconDel;
            this.btnDeleteOrder.ImageSize = new System.Drawing.Size(24, 24);
            this.btnDeleteOrder.Location = new System.Drawing.Point(26, 7);
            this.btnDeleteOrder.Name = "btnDeleteOrder";
            this.btnDeleteOrder.Size = new System.Drawing.Size(49, 45);
            this.btnDeleteOrder.TabIndex = 19;
            this.btnDeleteOrder.Click += new System.EventHandler(this.btnDeleteOrder_Click);
            // 
            // btnEditCustomer
            // 
            this.btnEditCustomer.BackColor = System.Drawing.Color.Transparent;
            this.btnEditCustomer.BorderRadius = 10;
            this.btnEditCustomer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEditCustomer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEditCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEditCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEditCustomer.FillColor = System.Drawing.Color.Orange;
            this.btnEditCustomer.Font = new System.Drawing.Font("YEKAN PLUS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCustomer.ForeColor = System.Drawing.Color.White;
            this.btnEditCustomer.Image = global::TailoringManagmentWin.Properties.Resources.IconEdit;
            this.btnEditCustomer.ImageSize = new System.Drawing.Size(24, 24);
            this.btnEditCustomer.Location = new System.Drawing.Point(81, 7);
            this.btnEditCustomer.Name = "btnEditCustomer";
            this.btnEditCustomer.Size = new System.Drawing.Size(49, 45);
            this.btnEditCustomer.TabIndex = 18;
            // 
            // btnAddNewOrder
            // 
            this.btnAddNewOrder.BackColor = System.Drawing.Color.Transparent;
            this.btnAddNewOrder.BorderRadius = 10;
            this.btnAddNewOrder.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewOrder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewOrder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddNewOrder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddNewOrder.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(104)))), ((int)(((byte)(221)))));
            this.btnAddNewOrder.Font = new System.Drawing.Font("YEKAN PLUS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewOrder.ForeColor = System.Drawing.Color.White;
            this.btnAddNewOrder.Image = global::TailoringManagmentWin.Properties.Resources.addIcon;
            this.btnAddNewOrder.Location = new System.Drawing.Point(263, 7);
            this.btnAddNewOrder.Name = "btnAddNewOrder";
            this.btnAddNewOrder.Size = new System.Drawing.Size(180, 45);
            this.btnAddNewOrder.TabIndex = 17;
            this.btnAddNewOrder.Text = "افزودن سفارش جدید";
            this.btnAddNewOrder.Click += new System.EventHandler(this.btnAddNewOrder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("YEKAN PLUS", 13.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(731, 10);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(156, 35);
            this.label1.TabIndex = 20;
            this.label1.Text = "مدیریت سفارش ها";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderRadius = 10;
            this.guna2Panel1.Controls.Add(this.guna2Button1);
            this.guna2Panel1.Controls.Add(this.btnAddNewOrder);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.btnDeleteOrder);
            this.guna2Panel1.Controls.Add(this.btnEditCustomer);
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(67)))));
            this.guna2Panel1.Location = new System.Drawing.Point(15, 62);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(903, 58);
            this.guna2Panel1.TabIndex = 21;
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
            // OrdersList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(16)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(1149, 783);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.txtbSearchOrders);
            this.Controls.Add(this.guna2Panel6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "OrdersList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "سیستم مدیریت خیاطی | سفارش ها";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OrdersList_FormClosing);
            this.Load += new System.EventHandler(this.Overview_Load);
            this.guna2Panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox txtbSearchOrders;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel6;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button btnOrderMenu;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton2;
        private Guna.UI2.WinForms.Guna2Button btnClothMenu;
        private Guna.UI2.WinForms.Guna2Button btnCustomersMenu;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnDashboard;
        private Guna.UI2.WinForms.Guna2Button btnDeleteOrder;
        private Guna.UI2.WinForms.Guna2Button btnEditCustomer;
        private Guna.UI2.WinForms.Guna2Button btnAddNewOrder;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvOrders;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn MobileCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentMethod;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceivedMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}

