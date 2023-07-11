using System.Drawing.Text;
using System.Drawing;

namespace TailoringManagmentWin
{
    partial class Overview
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Overview));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnOrderForm = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnClothForm = new Guna.UI2.WinForms.Guna2Button();
            this.btnCustomerForm = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_dashboard = new Guna.UI2.WinForms.Guna2Button();
            this.btn_logout = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblCustomersNum = new System.Windows.Forms.Label();
            this.guna2ImageButton2 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label2 = new System.Windows.Forms.Label();
            this.PanelOrders = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ImageButton6 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.lblOrdersNum = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblClothsNum = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2ImageButton4 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ImageButton5 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.lblPaymentSum = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dgvOverviewOrders = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MobileCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceivedMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtbSearchOrders = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.PanelOrders.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
            this.guna2Panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOverviewOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            this.guna2GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.guna2Panel1.Controls.Add(this.btnOrderForm);
            this.guna2Panel1.Controls.Add(this.guna2ImageButton1);
            this.guna2Panel1.Controls.Add(this.btnClothForm);
            this.guna2Panel1.Controls.Add(this.btnCustomerForm);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.btn_dashboard);
            this.guna2Panel1.Controls.Add(this.btn_logout);
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(67)))));
            this.guna2Panel1.Location = new System.Drawing.Point(931, 2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.BorderRadius = 10;
            this.guna2Panel1.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(38)))), ((int)(((byte)(63)))), ((int)(((byte)(13)))));
            this.guna2Panel1.ShadowDecoration.Depth = 10;
            this.guna2Panel1.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.guna2Panel1.Size = new System.Drawing.Size(218, 783);
            this.guna2Panel1.TabIndex = 0;
            // 
            // btnOrderForm
            // 
            this.btnOrderForm.Animated = true;
            this.btnOrderForm.AnimatedGIF = true;
            this.btnOrderForm.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOrderForm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnOrderForm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOrderForm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnOrderForm.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(67)))));
            this.btnOrderForm.Font = new System.Drawing.Font("YEKAN PLUS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.btnOrderForm.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(16)))), ((int)(((byte)(47)))));
            this.btnOrderForm.Image = global::TailoringManagmentWin.Properties.Resources.OrderMenu;
            this.btnOrderForm.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnOrderForm.Location = new System.Drawing.Point(-7, 300);
            this.btnOrderForm.Name = "btnOrderForm";
            this.btnOrderForm.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnOrderForm.Size = new System.Drawing.Size(213, 55);
            this.btnOrderForm.TabIndex = 6;
            this.btnOrderForm.Text = "مدیریت سفارش ها";
            this.btnOrderForm.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            this.btnOrderForm.Click += new System.EventHandler(this.btnOrderForm_Click);
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(42, 42);
            this.guna2ImageButton1.HoverState.ImageRotate = 360F;
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(42, 42);
            this.guna2ImageButton1.Image = global::TailoringManagmentWin.Properties.Resources.LogoPNG;
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(42, 42);
            this.guna2ImageButton1.Location = new System.Drawing.Point(162, 5);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(42, 42);
            this.guna2ImageButton1.Size = new System.Drawing.Size(52, 52);
            this.guna2ImageButton1.TabIndex = 2;
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
            this.btnClothForm.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(67)))));
            this.btnClothForm.Font = new System.Drawing.Font("YEKAN PLUS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClothForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.btnClothForm.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(16)))), ((int)(((byte)(47)))));
            this.btnClothForm.Image = global::TailoringManagmentWin.Properties.Resources.ClothMenu;
            this.btnClothForm.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnClothForm.Location = new System.Drawing.Point(-7, 231);
            this.btnClothForm.Name = "btnClothForm";
            this.btnClothForm.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnClothForm.Size = new System.Drawing.Size(213, 55);
            this.btnClothForm.TabIndex = 5;
            this.btnClothForm.Text = "مدیریت پارچه ها";
            this.btnClothForm.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            this.btnClothForm.Click += new System.EventHandler(this.btnClothForm_Click);
            // 
            // btnCustomerForm
            // 
            this.btnCustomerForm.Animated = true;
            this.btnCustomerForm.AnimatedGIF = true;
            this.btnCustomerForm.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.btnCustomerForm.BorderRadius = 10;
            this.btnCustomerForm.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomerForm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomerForm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCustomerForm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCustomerForm.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(67)))));
            this.btnCustomerForm.Font = new System.Drawing.Font("YEKAN PLUS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.btnCustomerForm.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(16)))), ((int)(((byte)(47)))));
            this.btnCustomerForm.Image = global::TailoringManagmentWin.Properties.Resources.UserMenu;
            this.btnCustomerForm.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCustomerForm.Location = new System.Drawing.Point(-7, 162);
            this.btnCustomerForm.Name = "btnCustomerForm";
            this.btnCustomerForm.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnCustomerForm.Size = new System.Drawing.Size(213, 55);
            this.btnCustomerForm.TabIndex = 4;
            this.btnCustomerForm.Text = "مدیریت مشتریان";
            this.btnCustomerForm.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            this.btnCustomerForm.Click += new System.EventHandler(this.btnCustomerForm_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("YEKAN PLUS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "سیستم مدیریت خیاطی";
            // 
            // btn_dashboard
            // 
            this.btn_dashboard.Animated = true;
            this.btn_dashboard.AnimatedGIF = true;
            this.btn_dashboard.BorderRadius = 10;
            this.btn_dashboard.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_dashboard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_dashboard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_dashboard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_dashboard.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(16)))), ((int)(((byte)(47)))));
            this.btn_dashboard.Font = new System.Drawing.Font("YEKAN PLUS", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dashboard.ForeColor = System.Drawing.Color.White;
            this.btn_dashboard.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(16)))), ((int)(((byte)(47)))));
            this.btn_dashboard.Image = global::TailoringManagmentWin.Properties.Resources.DashboardMenu;
            this.btn_dashboard.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_dashboard.Location = new System.Drawing.Point(-7, 93);
            this.btn_dashboard.Name = "btn_dashboard";
            this.btn_dashboard.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_dashboard.Size = new System.Drawing.Size(213, 55);
            this.btn_dashboard.TabIndex = 0;
            this.btn_dashboard.Text = "داشبورد";
            this.btn_dashboard.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            // 
            // btn_logout
            // 
            this.btn_logout.Animated = true;
            this.btn_logout.AnimatedGIF = true;
            this.btn_logout.BorderRadius = 10;
            this.btn_logout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_logout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_logout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_logout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_logout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(11)))), ((int)(((byte)(40)))));
            this.btn_logout.Font = new System.Drawing.Font("YEKAN PLUS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_logout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.btn_logout.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(7)))), ((int)(((byte)(19)))));
            this.btn_logout.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_logout.Image = global::TailoringManagmentWin.Properties.Resources.ExitMenu;
            this.btn_logout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_logout.Location = new System.Drawing.Point(16, 716);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_logout.Size = new System.Drawing.Size(190, 55);
            this.btn_logout.TabIndex = 1;
            this.btn_logout.Text = "خروج از برنامه";
            this.btn_logout.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(67)))));
            this.guna2Panel2.BorderRadius = 10;
            this.guna2Panel2.BorderThickness = 1;
            this.guna2Panel2.Controls.Add(this.lblCustomersNum);
            this.guna2Panel2.Controls.Add(this.guna2ImageButton2);
            this.guna2Panel2.Controls.Add(this.label2);
            this.guna2Panel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(39)))), ((int)(((byte)(77)))));
            this.guna2Panel2.Location = new System.Drawing.Point(699, 68);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.BorderRadius = 10;
            this.guna2Panel2.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(38)))), ((int)(((byte)(63)))), ((int)(((byte)(13)))));
            this.guna2Panel2.ShadowDecoration.Depth = 10;
            this.guna2Panel2.ShadowDecoration.Enabled = true;
            this.guna2Panel2.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.guna2Panel2.Size = new System.Drawing.Size(210, 102);
            this.guna2Panel2.TabIndex = 3;
            // 
            // lblCustomersNum
            // 
            this.lblCustomersNum.AutoSize = true;
            this.lblCustomersNum.Font = new System.Drawing.Font("YEKAN PLUS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomersNum.ForeColor = System.Drawing.Color.White;
            this.lblCustomersNum.Location = new System.Drawing.Point(139, 56);
            this.lblCustomersNum.Name = "lblCustomersNum";
            this.lblCustomersNum.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCustomersNum.Size = new System.Drawing.Size(58, 31);
            this.lblCustomersNum.TabIndex = 10;
            this.lblCustomersNum.Text = "10  عدد";
            this.lblCustomersNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2ImageButton2
            // 
            this.guna2ImageButton2.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton2.HoverState.ImageSize = new System.Drawing.Size(45, 45);
            this.guna2ImageButton2.Image = global::TailoringManagmentWin.Properties.Resources.CustomersPNG;
            this.guna2ImageButton2.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton2.ImageRotate = 0F;
            this.guna2ImageButton2.ImageSize = new System.Drawing.Size(45, 45);
            this.guna2ImageButton2.Location = new System.Drawing.Point(13, 10);
            this.guna2ImageButton2.Name = "guna2ImageButton2";
            this.guna2ImageButton2.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton2.Size = new System.Drawing.Size(52, 52);
            this.guna2ImageButton2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("YEKAN PLUS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(82, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(125, 43);
            this.label2.TabIndex = 4;
            this.label2.Text = "تعداد مشتری ها";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.UseCompatibleTextRendering = true;
            // 
            // PanelOrders
            // 
            this.PanelOrders.BackColor = System.Drawing.Color.Transparent;
            this.PanelOrders.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(67)))));
            this.PanelOrders.BorderRadius = 10;
            this.PanelOrders.BorderThickness = 1;
            this.PanelOrders.Controls.Add(this.guna2ImageButton6);
            this.PanelOrders.Controls.Add(this.lblOrdersNum);
            this.PanelOrders.Controls.Add(this.label5);
            this.PanelOrders.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(187)))), ((int)(((byte)(135)))));
            this.PanelOrders.Location = new System.Drawing.Point(471, 68);
            this.PanelOrders.Name = "PanelOrders";
            this.PanelOrders.ShadowDecoration.BorderRadius = 10;
            this.PanelOrders.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(38)))), ((int)(((byte)(63)))), ((int)(((byte)(13)))));
            this.PanelOrders.ShadowDecoration.Depth = 10;
            this.PanelOrders.ShadowDecoration.Enabled = true;
            this.PanelOrders.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.PanelOrders.Size = new System.Drawing.Size(210, 102);
            this.PanelOrders.TabIndex = 4;
            // 
            // guna2ImageButton6
            // 
            this.guna2ImageButton6.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton6.HoverState.ImageSize = new System.Drawing.Size(45, 45);
            this.guna2ImageButton6.Image = global::TailoringManagmentWin.Properties.Resources.OrdersPNG;
            this.guna2ImageButton6.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton6.ImageRotate = 0F;
            this.guna2ImageButton6.ImageSize = new System.Drawing.Size(45, 45);
            this.guna2ImageButton6.Location = new System.Drawing.Point(13, 10);
            this.guna2ImageButton6.Name = "guna2ImageButton6";
            this.guna2ImageButton6.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton6.Size = new System.Drawing.Size(52, 52);
            this.guna2ImageButton6.TabIndex = 10;
            // 
            // lblOrdersNum
            // 
            this.lblOrdersNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOrdersNum.Font = new System.Drawing.Font("YEKAN PLUS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrdersNum.ForeColor = System.Drawing.Color.White;
            this.lblOrdersNum.Location = new System.Drawing.Point(55, 56);
            this.lblOrdersNum.Name = "lblOrdersNum";
            this.lblOrdersNum.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblOrdersNum.Size = new System.Drawing.Size(139, 31);
            this.lblOrdersNum.TabIndex = 9;
            this.lblOrdersNum.Text = "100000   عدد";
            this.lblOrdersNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("YEKAN PLUS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(82, 0);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(125, 43);
            this.label5.TabIndex = 4;
            this.label5.Text = "تعداد سفارش ها";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.UseCompatibleTextRendering = true;
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(67)))));
            this.guna2Panel4.BorderRadius = 10;
            this.guna2Panel4.BorderThickness = 1;
            this.guna2Panel4.Controls.Add(this.lblClothsNum);
            this.guna2Panel4.Controls.Add(this.label1);
            this.guna2Panel4.Controls.Add(this.guna2ImageButton4);
            this.guna2Panel4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(136)))), ((int)(((byte)(218)))));
            this.guna2Panel4.Location = new System.Drawing.Point(243, 68);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.ShadowDecoration.BorderRadius = 10;
            this.guna2Panel4.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(38)))), ((int)(((byte)(63)))), ((int)(((byte)(13)))));
            this.guna2Panel4.ShadowDecoration.Depth = 10;
            this.guna2Panel4.ShadowDecoration.Enabled = true;
            this.guna2Panel4.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.guna2Panel4.Size = new System.Drawing.Size(210, 102);
            this.guna2Panel4.TabIndex = 4;
            // 
            // lblClothsNum
            // 
            this.lblClothsNum.AutoSize = true;
            this.lblClothsNum.Font = new System.Drawing.Font("YEKAN PLUS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClothsNum.ForeColor = System.Drawing.Color.White;
            this.lblClothsNum.Location = new System.Drawing.Point(141, 56);
            this.lblClothsNum.Name = "lblClothsNum";
            this.lblClothsNum.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblClothsNum.Size = new System.Drawing.Size(60, 31);
            this.lblClothsNum.TabIndex = 8;
            this.lblClothsNum.Text = "10   عدد";
            this.lblClothsNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("YEKAN PLUS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(69, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(138, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "پارچه های موجود";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.UseCompatibleTextRendering = true;
            // 
            // guna2ImageButton4
            // 
            this.guna2ImageButton4.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton4.HoverState.ImageSize = new System.Drawing.Size(45, 45);
            this.guna2ImageButton4.Image = global::TailoringManagmentWin.Properties.Resources.ClothPNG;
            this.guna2ImageButton4.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton4.ImageRotate = 0F;
            this.guna2ImageButton4.ImageSize = new System.Drawing.Size(42, 42);
            this.guna2ImageButton4.Location = new System.Drawing.Point(11, 10);
            this.guna2ImageButton4.Name = "guna2ImageButton4";
            this.guna2ImageButton4.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton4.Size = new System.Drawing.Size(52, 52);
            this.guna2ImageButton4.TabIndex = 6;
            // 
            // guna2Panel5
            // 
            this.guna2Panel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(67)))));
            this.guna2Panel5.BorderRadius = 10;
            this.guna2Panel5.BorderThickness = 1;
            this.guna2Panel5.Controls.Add(this.guna2ImageButton5);
            this.guna2Panel5.Controls.Add(this.lblPaymentSum);
            this.guna2Panel5.Controls.Add(this.label4);
            this.guna2Panel5.Controls.Add(this.guna2HtmlLabel3);
            this.guna2Panel5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(185)))), ((int)(((byte)(214)))));
            this.guna2Panel5.Location = new System.Drawing.Point(15, 68);
            this.guna2Panel5.Name = "guna2Panel5";
            this.guna2Panel5.ShadowDecoration.BorderRadius = 10;
            this.guna2Panel5.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(38)))), ((int)(((byte)(63)))), ((int)(((byte)(13)))));
            this.guna2Panel5.ShadowDecoration.Depth = 10;
            this.guna2Panel5.ShadowDecoration.Enabled = true;
            this.guna2Panel5.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.guna2Panel5.Size = new System.Drawing.Size(210, 102);
            this.guna2Panel5.TabIndex = 4;
            // 
            // guna2ImageButton5
            // 
            this.guna2ImageButton5.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton5.HoverState.ImageSize = new System.Drawing.Size(45, 45);
            this.guna2ImageButton5.Image = global::TailoringManagmentWin.Properties.Resources.MoneyPNG;
            this.guna2ImageButton5.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton5.ImageRotate = 0F;
            this.guna2ImageButton5.ImageSize = new System.Drawing.Size(45, 45);
            this.guna2ImageButton5.Location = new System.Drawing.Point(7, 10);
            this.guna2ImageButton5.Name = "guna2ImageButton5";
            this.guna2ImageButton5.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton5.Size = new System.Drawing.Size(52, 52);
            this.guna2ImageButton5.TabIndex = 7;
            // 
            // lblPaymentSum
            // 
            this.lblPaymentSum.Font = new System.Drawing.Font("YEKAN PLUS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentSum.ForeColor = System.Drawing.Color.White;
            this.lblPaymentSum.Location = new System.Drawing.Point(7, 56);
            this.lblPaymentSum.Name = "lblPaymentSum";
            this.lblPaymentSum.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPaymentSum.Size = new System.Drawing.Size(200, 31);
            this.lblPaymentSum.TabIndex = 6;
            this.lblPaymentSum.Text = "20000000000   هزارتومان";
            this.lblPaymentSum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("YEKAN PLUS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(82, 0);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(125, 43);
            this.label4.TabIndex = 4;
            this.label4.Text = "مجموع درآمد";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.UseCompatibleTextRendering = true;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.AutoSize = false;
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("YEKAN PLUS", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(239, 39);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(52, 48);
            this.guna2HtmlLabel3.TabIndex = 5;
            this.guna2HtmlLabel3.Text = "20";
            this.guna2HtmlLabel3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvOverviewOrders
            // 
            this.dgvOverviewOrders.AllowUserToAddRows = false;
            this.dgvOverviewOrders.AllowUserToDeleteRows = false;
            this.dgvOverviewOrders.AllowUserToResizeColumns = false;
            this.dgvOverviewOrders.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(67)))));
            this.dgvOverviewOrders.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOverviewOrders.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(104)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("YEKAN PLUS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOverviewOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOverviewOrders.ColumnHeadersHeight = 35;
            this.dgvOverviewOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.CustomerFullName,
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
            this.dgvOverviewOrders.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvOverviewOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOverviewOrders.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(16)))), ((int)(((byte)(47)))));
            this.dgvOverviewOrders.Location = new System.Drawing.Point(0, 40);
            this.dgvOverviewOrders.Name = "dgvOverviewOrders";
            this.dgvOverviewOrders.ReadOnly = true;
            this.dgvOverviewOrders.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvOverviewOrders.RowHeadersVisible = false;
            this.dgvOverviewOrders.RowHeadersWidth = 51;
            this.dgvOverviewOrders.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvOverviewOrders.RowTemplate.Height = 24;
            this.dgvOverviewOrders.ShowCellErrors = false;
            this.dgvOverviewOrders.ShowRowErrors = false;
            this.dgvOverviewOrders.Size = new System.Drawing.Size(903, 543);
            this.dgvOverviewOrders.TabIndex = 10;
            this.dgvOverviewOrders.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Dark;
            this.dgvOverviewOrders.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(67)))));
            this.dgvOverviewOrders.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvOverviewOrders.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvOverviewOrders.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvOverviewOrders.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvOverviewOrders.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(67)))));
            this.dgvOverviewOrders.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(16)))), ((int)(((byte)(47)))));
            this.dgvOverviewOrders.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(104)))), ((int)(((byte)(221)))));
            this.dgvOverviewOrders.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvOverviewOrders.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("YEKAN PLUS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvOverviewOrders.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvOverviewOrders.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvOverviewOrders.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvOverviewOrders.ThemeStyle.ReadOnly = true;
            this.dgvOverviewOrders.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(16)))), ((int)(((byte)(47)))));
            this.dgvOverviewOrders.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvOverviewOrders.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("YEKAN PLUS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvOverviewOrders.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvOverviewOrders.ThemeStyle.RowsStyle.Height = 24;
            this.dgvOverviewOrders.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(36)))), ((int)(((byte)(170)))));
            this.dgvOverviewOrders.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.FillWeight = 34.2246F;
            this.Id.HeaderText = "#";
            this.Id.MinimumWidth = 8;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // CustomerFullName
            // 
            this.CustomerFullName.DataPropertyName = "CustomerFullName";
            this.CustomerFullName.FillWeight = 113.5971F;
            this.CustomerFullName.HeaderText = "نام مشتری";
            this.CustomerFullName.MinimumWidth = 6;
            this.CustomerFullName.Name = "CustomerFullName";
            this.CustomerFullName.ReadOnly = true;
            // 
            // OrderCode
            // 
            this.OrderCode.DataPropertyName = "OrderCode";
            this.OrderCode.FillWeight = 113.5971F;
            this.OrderCode.HeaderText = "کد سفارش";
            this.OrderCode.MinimumWidth = 6;
            this.OrderCode.Name = "OrderCode";
            this.OrderCode.ReadOnly = true;
            // 
            // MobileCustomer
            // 
            this.MobileCustomer.DataPropertyName = "MobileCustomer";
            this.MobileCustomer.FillWeight = 113.5971F;
            this.MobileCustomer.HeaderText = "شماره تماس";
            this.MobileCustomer.MinimumWidth = 6;
            this.MobileCustomer.Name = "MobileCustomer";
            this.MobileCustomer.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.FillWeight = 113.5971F;
            this.Status.HeaderText = "وضعیت";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // PaymentMethod
            // 
            this.PaymentMethod.DataPropertyName = "PaymentMethod";
            this.PaymentMethod.FillWeight = 113.5971F;
            this.PaymentMethod.HeaderText = "نحوه پرداخت";
            this.PaymentMethod.MinimumWidth = 6;
            this.PaymentMethod.Name = "PaymentMethod";
            this.PaymentMethod.ReadOnly = true;
            // 
            // ReceivedMoney
            // 
            this.ReceivedMoney.DataPropertyName = "ReceivedMoney";
            this.ReceivedMoney.FillWeight = 98.89503F;
            this.ReceivedMoney.HeaderText = "مبلغ دریافتی";
            this.ReceivedMoney.MinimumWidth = 6;
            this.ReceivedMoney.Name = "ReceivedMoney";
            this.ReceivedMoney.ReadOnly = true;
            // 
            // TotalPrice
            // 
            this.TotalPrice.DataPropertyName = "TotalPrice";
            this.TotalPrice.FillWeight = 98.89503F;
            this.TotalPrice.HeaderText = "مبلغ کل";
            this.TotalPrice.MinimumWidth = 6;
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.ReadOnly = true;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
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
            this.txtbSearchOrders.ForeColor = System.Drawing.Color.Silver;
            this.txtbSearchOrders.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbSearchOrders.IconRight = global::TailoringManagmentWin.Properties.Resources.SearchIcon;
            this.txtbSearchOrders.Location = new System.Drawing.Point(291, 10);
            this.txtbSearchOrders.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbSearchOrders.Name = "txtbSearchOrders";
            this.txtbSearchOrders.PasswordChar = '\0';
            this.txtbSearchOrders.PlaceholderText = "... کد سفارش ، نام مشتری و یا شماره تماس را جستجو کنید";
            this.txtbSearchOrders.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtbSearchOrders.SelectedText = "";
            this.txtbSearchOrders.Size = new System.Drawing.Size(634, 48);
            this.txtbSearchOrders.TabIndex = 1;
            this.txtbSearchOrders.TextChanged += new System.EventHandler(this.txtbSearchOrders_TextChanged);
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderRadius = 10;
            this.guna2GroupBox1.BorderThickness = 0;
            this.guna2GroupBox1.Controls.Add(this.dgvOverviewOrders);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(67)))));
            this.guna2GroupBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(67)))));
            this.guna2GroupBox1.Font = new System.Drawing.Font("YEKAN PLUS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox1.Location = new System.Drawing.Point(12, 188);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(903, 583);
            this.guna2GroupBox1.TabIndex = 11;
            this.guna2GroupBox1.Text = "لیست آخرین سفارش ها";
            this.guna2GroupBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Overview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(16)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(1149, 783);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.guna2Panel5);
            this.Controls.Add(this.guna2Panel4);
            this.Controls.Add(this.PanelOrders);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.txtbSearchOrders);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Overview";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "سیستم مدیریت خیاطی | داشبورد";
            this.Load += new System.EventHandler(this.Overview_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.PanelOrders.ResumeLayout(false);
            this.guna2Panel4.ResumeLayout(false);
            this.guna2Panel4.PerformLayout();
            this.guna2Panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOverviewOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            this.guna2GroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2TextBox txtbSearchOrders;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel PanelOrders;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
        private Guna.UI2.WinForms.Guna2Button btn_dashboard;
        private Guna.UI2.WinForms.Guna2Button btn_logout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton2;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton4;
        private System.Windows.Forms.Label lblPaymentSum;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton5;
        private System.Windows.Forms.Label lblClothsNum;
        private System.Windows.Forms.Label lblCustomersNum;
        private System.Windows.Forms.Label lblOrdersNum;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton6;
        private Guna.UI2.WinForms.Guna2Button btnCustomerForm;
        private Guna.UI2.WinForms.Guna2Button btnClothForm;
        private Guna.UI2.WinForms.Guna2DataGridView dgvOverviewOrders;
        private Guna.UI2.WinForms.Guna2Button btnOrderForm;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn MobileCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentMethod;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceivedMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
    }
}

