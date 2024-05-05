using System.Windows.Forms;

namespace PastryShop
{
    partial class VanillePastryShop
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VanillePastryShop));
            label1 = new Label();
            Items = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            Billing = new Label();
            Dashboard = new Label();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            panel1 = new Panel();
            LogoutLbl = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label3 = new Label();
            DeleteBtn = new Button();
            EditBtn = new Button();
            AddBtn = new Button();
            ItemDGV = new DataGridView();
            CategoryCb = new ComboBox();
            QuantityTb = new TextBox();
            PriceTb = new TextBox();
            ItemNameTb = new TextBox();
            label2 = new Label();
            tabPage2 = new TabPage();
            label4 = new Label();
            DeleteCustBtn = new Button();
            EditCustBtn = new Button();
            AddCustBtn = new Button();
            CustomerDGV = new DataGridView();
            CustAddressTb = new TextBox();
            CustPhoneTb = new TextBox();
            CustNameTb = new TextBox();
            label5 = new Label();
            tabPage3 = new TabPage();
            label6 = new Label();
            DeleteCatBtn = new Button();
            EditCatBtn = new Button();
            AddCatBtn = new Button();
            CategoryDGV = new DataGridView();
            CatNameTb = new TextBox();
            label7 = new Label();
            tabPage4 = new TabPage();
            SaveBillBtn = new Button();
            yourTotalLabel = new Label();
            label12 = new Label();
            label11 = new Label();
            YourBillsDGV = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            BItemDGV = new DataGridView();
            label10 = new Label();
            label8 = new Label();
            AddToBillBtn = new Button();
            RefreshBtn = new Button();
            CustomerBillsDGV = new DataGridView();
            BCustomerCb = new ComboBox();
            BQuantityTb = new TextBox();
            BPriceTb = new TextBox();
            BItemNameTb = new TextBox();
            label9 = new Label();
            tabPage5 = new TabPage();
            label15 = new Label();
            SaleLbl = new Label();
            label14 = new Label();
            label = new Label();
            CustLabel = new Label();
            ItemLbl = new Label();
            Customers = new Label();
            Categories = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ItemDGV).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CustomerDGV).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CategoryDGV).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)YourBillsDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BItemDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CustomerBillsDGV).BeginInit();
            tabPage5.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto Black", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.MistyRose;
            label1.Location = new Point(454, 33);
            label1.Name = "label1";
            label1.Size = new Size(369, 37);
            label1.TabIndex = 0;
            label1.Text = "Vanille Pastry And Sweets";
            // 
            // Items
            // 
            Items.AutoSize = true;
            Items.Font = new Font("Roboto", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Items.ForeColor = Color.MistyRose;
            Items.Location = new Point(66, 183);
            Items.Name = "Items";
            Items.Size = new Size(74, 29);
            Items.TabIndex = 3;
            Items.Text = "Items";
            Items.Click += Items_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(30, 179);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 41);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(30, 243);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 41);
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // Billing
            // 
            Billing.AutoSize = true;
            Billing.Font = new Font("Roboto", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Billing.ForeColor = Color.MistyRose;
            Billing.Location = new Point(66, 373);
            Billing.Name = "Billing";
            Billing.Size = new Size(78, 29);
            Billing.TabIndex = 9;
            Billing.Text = "Billing";
            Billing.Click += Billing_Click;
            // 
            // Dashboard
            // 
            Dashboard.AutoSize = true;
            Dashboard.Font = new Font("Roboto", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Dashboard.ForeColor = Color.MistyRose;
            Dashboard.Location = new Point(66, 436);
            Dashboard.Name = "Dashboard";
            Dashboard.Size = new Size(129, 29);
            Dashboard.TabIndex = 10;
            Dashboard.Text = "Dashboard";
            Dashboard.Click += Dashboard_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(30, 305);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(40, 41);
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(30, 368);
            pictureBox4.Margin = new Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(40, 41);
            pictureBox4.TabIndex = 12;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(30, 432);
            pictureBox5.Margin = new Padding(3, 4, 3, 4);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(40, 41);
            pictureBox5.TabIndex = 13;
            pictureBox5.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.IndianRed;
            panel1.Controls.Add(LogoutLbl);
            panel1.Controls.Add(tabControl1);
            panel1.Controls.Add(Customers);
            panel1.Controls.Add(Categories);
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(Dashboard);
            panel1.Controls.Add(Billing);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(Items);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-3, -8);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1051, 635);
            panel1.TabIndex = 0;
            // 
            // LogoutLbl
            // 
            LogoutLbl.AutoSize = true;
            LogoutLbl.Font = new Font("Roboto", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LogoutLbl.ForeColor = Color.MistyRose;
            LogoutLbl.Location = new Point(67, 576);
            LogoutLbl.Name = "LogoutLbl";
            LogoutLbl.Size = new Size(97, 29);
            LogoutLbl.TabIndex = 20;
            LogoutLbl.Text = "Log Out";
            LogoutLbl.Click += LogoutLbl_Click;
            // 
            // tabControl1
            // 
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.Location = new Point(241, 91);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(785, 518);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            tabControl1.TabIndex = 19;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Transparent;
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(DeleteBtn);
            tabPage1.Controls.Add(EditBtn);
            tabPage1.Controls.Add(AddBtn);
            tabPage1.Controls.Add(ItemDGV);
            tabPage1.Controls.Add(CategoryCb);
            tabPage1.Controls.Add(QuantityTb);
            tabPage1.Controls.Add(PriceTb);
            tabPage1.Controls.Add(ItemNameTb);
            tabPage1.Controls.Add(label2);
            tabPage1.Location = new Point(4, 5);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(777, 509);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Roboto", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.IndianRed;
            label3.ImageAlign = ContentAlignment.TopCenter;
            label3.Location = new Point(347, 172);
            label3.Name = "label3";
            label3.Size = new Size(89, 24);
            label3.TabIndex = 10;
            label3.Text = "Item List";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.IndianRed;
            DeleteBtn.Font = new Font("Roboto Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            DeleteBtn.ForeColor = Color.White;
            DeleteBtn.Location = new Point(496, 108);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(129, 42);
            DeleteBtn.TabIndex = 9;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // EditBtn
            // 
            EditBtn.BackColor = Color.IndianRed;
            EditBtn.Font = new Font("Roboto Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            EditBtn.ForeColor = Color.White;
            EditBtn.Location = new Point(328, 108);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(129, 42);
            EditBtn.TabIndex = 8;
            EditBtn.Text = "Edit";
            EditBtn.UseVisualStyleBackColor = false;
            EditBtn.Click += EditBtn_Click;
            // 
            // AddBtn
            // 
            AddBtn.BackColor = Color.IndianRed;
            AddBtn.Font = new Font("Roboto Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            AddBtn.ForeColor = Color.White;
            AddBtn.Location = new Point(158, 108);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(129, 42);
            AddBtn.TabIndex = 7;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // ItemDGV
            // 
            ItemDGV.BackgroundColor = Color.White;
            ItemDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ItemDGV.Location = new Point(29, 209);
            ItemDGV.Name = "ItemDGV";
            ItemDGV.RowHeadersWidth = 94;
            ItemDGV.RowTemplate.Height = 50;
            ItemDGV.Size = new Size(721, 269);
            ItemDGV.TabIndex = 6;
            ItemDGV.RowHeaderMouseClick += ItemDGV_RowHeaderMouseClick;
            // 
            // CategoryCb
            // 
            CategoryCb.FormattingEnabled = true;
            CategoryCb.Location = new Point(598, 59);
            CategoryCb.Name = "CategoryCb";
            CategoryCb.Size = new Size(151, 28);
            CategoryCb.TabIndex = 5;
            // 
            // QuantityTb
            // 
            QuantityTb.Font = new Font("Roboto", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            QuantityTb.ForeColor = SystemColors.ControlText;
            QuantityTb.Location = new Point(406, 59);
            QuantityTb.Name = "QuantityTb";
            QuantityTb.PlaceholderText = "Quantity";
            QuantityTb.Size = new Size(160, 28);
            QuantityTb.TabIndex = 4;
            // 
            // PriceTb
            // 
            PriceTb.Font = new Font("Roboto", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            PriceTb.ForeColor = SystemColors.ControlText;
            PriceTb.Location = new Point(217, 59);
            PriceTb.Name = "PriceTb";
            PriceTb.PlaceholderText = "Price";
            PriceTb.Size = new Size(160, 28);
            PriceTb.TabIndex = 3;
            // 
            // ItemNameTb
            // 
            ItemNameTb.Font = new Font("Roboto", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            ItemNameTb.ForeColor = SystemColors.ControlText;
            ItemNameTb.Location = new Point(28, 59);
            ItemNameTb.Name = "ItemNameTb";
            ItemNameTb.PlaceholderText = "Item Name";
            ItemNameTb.Size = new Size(160, 28);
            ItemNameTb.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Roboto", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.IndianRed;
            label2.ImageAlign = ContentAlignment.TopCenter;
            label2.Location = new Point(300, 17);
            label2.Name = "label2";
            label2.Size = new Size(185, 24);
            label2.TabIndex = 1;
            label2.Text = "Items Management";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(DeleteCustBtn);
            tabPage2.Controls.Add(EditCustBtn);
            tabPage2.Controls.Add(AddCustBtn);
            tabPage2.Controls.Add(CustomerDGV);
            tabPage2.Controls.Add(CustAddressTb);
            tabPage2.Controls.Add(CustPhoneTb);
            tabPage2.Controls.Add(CustNameTb);
            tabPage2.Controls.Add(label5);
            tabPage2.Location = new Point(4, 5);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(777, 509);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Roboto", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.IndianRed;
            label4.ImageAlign = ContentAlignment.TopCenter;
            label4.Location = new Point(325, 172);
            label4.Name = "label4";
            label4.Size = new Size(135, 24);
            label4.TabIndex = 20;
            label4.Text = "Customer List";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DeleteCustBtn
            // 
            DeleteCustBtn.BackColor = Color.IndianRed;
            DeleteCustBtn.Font = new Font("Roboto Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            DeleteCustBtn.ForeColor = Color.White;
            DeleteCustBtn.Location = new Point(496, 108);
            DeleteCustBtn.Name = "DeleteCustBtn";
            DeleteCustBtn.Size = new Size(129, 42);
            DeleteCustBtn.TabIndex = 19;
            DeleteCustBtn.Text = "Delete";
            DeleteCustBtn.UseVisualStyleBackColor = false;
            DeleteCustBtn.Click += DeleteCustBtn_Click;
            // 
            // EditCustBtn
            // 
            EditCustBtn.BackColor = Color.IndianRed;
            EditCustBtn.Font = new Font("Roboto Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            EditCustBtn.ForeColor = Color.White;
            EditCustBtn.Location = new Point(328, 108);
            EditCustBtn.Name = "EditCustBtn";
            EditCustBtn.Size = new Size(129, 42);
            EditCustBtn.TabIndex = 18;
            EditCustBtn.Text = "Edit";
            EditCustBtn.UseVisualStyleBackColor = false;
            EditCustBtn.Click += EditCustBtn_Click;
            // 
            // AddCustBtn
            // 
            AddCustBtn.BackColor = Color.IndianRed;
            AddCustBtn.Font = new Font("Roboto Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            AddCustBtn.ForeColor = Color.White;
            AddCustBtn.Location = new Point(158, 108);
            AddCustBtn.Name = "AddCustBtn";
            AddCustBtn.Size = new Size(129, 42);
            AddCustBtn.TabIndex = 17;
            AddCustBtn.Text = "Add";
            AddCustBtn.UseVisualStyleBackColor = false;
            AddCustBtn.Click += AddCustBtn_Click;
            // 
            // CustomerDGV
            // 
            CustomerDGV.BackgroundColor = Color.White;
            CustomerDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CustomerDGV.Location = new Point(29, 209);
            CustomerDGV.Name = "CustomerDGV";
            CustomerDGV.RowHeadersWidth = 94;
            CustomerDGV.RowTemplate.Height = 50;
            CustomerDGV.Size = new Size(721, 269);
            CustomerDGV.TabIndex = 16;
            CustomerDGV.RowHeaderMouseClick += CustomerDGV_RowHeaderMouseClick;
            // 
            // CustAddressTb
            // 
            CustAddressTb.Font = new Font("Roboto", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            CustAddressTb.ForeColor = SystemColors.ControlText;
            CustAddressTb.Location = new Point(501, 59);
            CustAddressTb.Name = "CustAddressTb";
            CustAddressTb.PlaceholderText = "Address";
            CustAddressTb.Size = new Size(160, 28);
            CustAddressTb.TabIndex = 14;
            // 
            // CustPhoneTb
            // 
            CustPhoneTb.Font = new Font("Roboto", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            CustPhoneTb.ForeColor = SystemColors.ControlText;
            CustPhoneTb.Location = new Point(312, 59);
            CustPhoneTb.Name = "CustPhoneTb";
            CustPhoneTb.PlaceholderText = "Phone";
            CustPhoneTb.Size = new Size(160, 28);
            CustPhoneTb.TabIndex = 13;
            // 
            // CustNameTb
            // 
            CustNameTb.Font = new Font("Roboto", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            CustNameTb.ForeColor = SystemColors.ControlText;
            CustNameTb.Location = new Point(123, 59);
            CustNameTb.Name = "CustNameTb";
            CustNameTb.PlaceholderText = "Name";
            CustNameTb.Size = new Size(160, 28);
            CustNameTb.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Roboto", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.IndianRed;
            label5.ImageAlign = ContentAlignment.TopCenter;
            label5.Location = new Point(282, 17);
            label5.Name = "label5";
            label5.Size = new Size(221, 24);
            label5.TabIndex = 11;
            label5.Text = "Customer Management";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(label6);
            tabPage3.Controls.Add(DeleteCatBtn);
            tabPage3.Controls.Add(EditCatBtn);
            tabPage3.Controls.Add(AddCatBtn);
            tabPage3.Controls.Add(CategoryDGV);
            tabPage3.Controls.Add(CatNameTb);
            tabPage3.Controls.Add(label7);
            tabPage3.Location = new Point(4, 5);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(777, 509);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Roboto", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.IndianRed;
            label6.ImageAlign = ContentAlignment.TopRight;
            label6.Location = new Point(329, 172);
            label6.Name = "label6";
            label6.Size = new Size(129, 24);
            label6.TabIndex = 17;
            label6.Text = "Category List";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DeleteCatBtn
            // 
            DeleteCatBtn.BackColor = Color.IndianRed;
            DeleteCatBtn.Font = new Font("Roboto Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            DeleteCatBtn.ForeColor = Color.White;
            DeleteCatBtn.Location = new Point(496, 108);
            DeleteCatBtn.Name = "DeleteCatBtn";
            DeleteCatBtn.Size = new Size(129, 42);
            DeleteCatBtn.TabIndex = 16;
            DeleteCatBtn.Text = "Delete";
            DeleteCatBtn.UseVisualStyleBackColor = false;
            DeleteCatBtn.Click += DeleteCatBtn_Click;
            // 
            // EditCatBtn
            // 
            EditCatBtn.BackColor = Color.IndianRed;
            EditCatBtn.Font = new Font("Roboto Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            EditCatBtn.ForeColor = Color.White;
            EditCatBtn.Location = new Point(328, 108);
            EditCatBtn.Name = "EditCatBtn";
            EditCatBtn.Size = new Size(129, 42);
            EditCatBtn.TabIndex = 15;
            EditCatBtn.Text = "Edit";
            EditCatBtn.UseVisualStyleBackColor = false;
            EditCatBtn.Click += EditCatBtn_Click;
            // 
            // AddCatBtn
            // 
            AddCatBtn.BackColor = Color.IndianRed;
            AddCatBtn.Font = new Font("Roboto Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            AddCatBtn.ForeColor = Color.White;
            AddCatBtn.Location = new Point(158, 108);
            AddCatBtn.Name = "AddCatBtn";
            AddCatBtn.Size = new Size(129, 42);
            AddCatBtn.TabIndex = 14;
            AddCatBtn.Text = "Add";
            AddCatBtn.UseVisualStyleBackColor = false;
            AddCatBtn.Click += AddCatBtn_Click;
            // 
            // CategoryDGV
            // 
            CategoryDGV.BackgroundColor = Color.White;
            CategoryDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CategoryDGV.Location = new Point(29, 209);
            CategoryDGV.Name = "CategoryDGV";
            CategoryDGV.RowHeadersWidth = 94;
            CategoryDGV.RowTemplate.Height = 50;
            CategoryDGV.Size = new Size(721, 269);
            CategoryDGV.TabIndex = 13;
            CategoryDGV.RowHeaderMouseClick += CategoryDGV_RowHeaderMouseClick;
            // 
            // CatNameTb
            // 
            CatNameTb.Font = new Font("Roboto", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            CatNameTb.ForeColor = SystemColors.ControlText;
            CatNameTb.Location = new Point(314, 59);
            CatNameTb.Name = "CatNameTb";
            CatNameTb.PlaceholderText = "Category Name";
            CatNameTb.Size = new Size(160, 28);
            CatNameTb.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Roboto", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.IndianRed;
            label7.ImageAlign = ContentAlignment.TopCenter;
            label7.Location = new Point(285, 17);
            label7.Name = "label7";
            label7.Size = new Size(215, 24);
            label7.TabIndex = 11;
            label7.Text = "Category Management";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(SaveBillBtn);
            tabPage4.Controls.Add(yourTotalLabel);
            tabPage4.Controls.Add(label12);
            tabPage4.Controls.Add(label11);
            tabPage4.Controls.Add(YourBillsDGV);
            tabPage4.Controls.Add(BItemDGV);
            tabPage4.Controls.Add(label10);
            tabPage4.Controls.Add(label8);
            tabPage4.Controls.Add(AddToBillBtn);
            tabPage4.Controls.Add(RefreshBtn);
            tabPage4.Controls.Add(CustomerBillsDGV);
            tabPage4.Controls.Add(BCustomerCb);
            tabPage4.Controls.Add(BQuantityTb);
            tabPage4.Controls.Add(BPriceTb);
            tabPage4.Controls.Add(BItemNameTb);
            tabPage4.Controls.Add(label9);
            tabPage4.Location = new Point(4, 5);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(777, 509);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "tabPage4";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // SaveBillBtn
            // 
            SaveBillBtn.BackColor = Color.IndianRed;
            SaveBillBtn.Font = new Font("Roboto", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            SaveBillBtn.ForeColor = Color.White;
            SaveBillBtn.Location = new Point(255, 442);
            SaveBillBtn.Name = "SaveBillBtn";
            SaveBillBtn.Size = new Size(116, 42);
            SaveBillBtn.TabIndex = 27;
            SaveBillBtn.Text = "Save Bill";
            SaveBillBtn.UseVisualStyleBackColor = false;
            SaveBillBtn.Click += SaveBillBtn_Click;
            // 
            // yourTotalLabel
            // 
            yourTotalLabel.AutoSize = true;
            yourTotalLabel.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            yourTotalLabel.ForeColor = Color.DimGray;
            yourTotalLabel.ImageAlign = ContentAlignment.TopCenter;
            yourTotalLabel.Location = new Point(120, 450);
            yourTotalLabel.Name = "yourTotalLabel";
            yourTotalLabel.Size = new Size(30, 22);
            yourTotalLabel.TabIndex = 26;
            yourTotalLabel.Text = "0$";
            yourTotalLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = Color.DimGray;
            label12.ImageAlign = ContentAlignment.TopCenter;
            label12.Location = new Point(28, 450);
            label12.Name = "label12";
            label12.Size = new Size(94, 22);
            label12.TabIndex = 25;
            label12.Text = "Your Total:";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Roboto", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.IndianRed;
            label11.ImageAlign = ContentAlignment.TopCenter;
            label11.Location = new Point(24, 274);
            label11.Name = "label11";
            label11.Size = new Size(93, 24);
            label11.TabIndex = 24;
            label11.Text = "Your Bills";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // YourBillsDGV
            // 
            YourBillsDGV.BackgroundColor = Color.White;
            YourBillsDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            YourBillsDGV.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            YourBillsDGV.Location = new Point(28, 304);
            YourBillsDGV.Name = "YourBillsDGV";
            YourBillsDGV.RowHeadersWidth = 51;
            YourBillsDGV.RowTemplate.Height = 29;
            YourBillsDGV.Size = new Size(343, 130);
            YourBillsDGV.TabIndex = 23;
            // 
            // Column1
            // 
            Column1.HeaderText = "Id";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Item Name";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Quantity";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Price";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Total";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // BItemDGV
            // 
            BItemDGV.BackgroundColor = Color.White;
            BItemDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BItemDGV.Location = new Point(418, 68);
            BItemDGV.Name = "BItemDGV";
            BItemDGV.RowHeadersWidth = 51;
            BItemDGV.RowTemplate.Height = 29;
            BItemDGV.Size = new Size(332, 138);
            BItemDGV.TabIndex = 22;
            BItemDGV.RowHeaderMouseClick += BItemDGV_RowHeaderMouseClick;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Roboto", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.IndianRed;
            label10.ImageAlign = ContentAlignment.TopCenter;
            label10.Location = new Point(54, 49);
            label10.Name = "label10";
            label10.Size = new Size(108, 15);
            label10.TabIndex = 21;
            label10.Text = "Choose Customer";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Roboto", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.IndianRed;
            label8.ImageAlign = ContentAlignment.TopCenter;
            label8.Location = new Point(403, 274);
            label8.Name = "label8";
            label8.Size = new Size(140, 24);
            label8.TabIndex = 20;
            label8.Text = "Customer Bills";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AddToBillBtn
            // 
            AddToBillBtn.BackColor = Color.IndianRed;
            AddToBillBtn.Font = new Font("Roboto", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            AddToBillBtn.ForeColor = Color.White;
            AddToBillBtn.Location = new Point(57, 217);
            AddToBillBtn.Name = "AddToBillBtn";
            AddToBillBtn.Size = new Size(146, 42);
            AddToBillBtn.TabIndex = 19;
            AddToBillBtn.Text = "Add to Bill";
            AddToBillBtn.UseVisualStyleBackColor = false;
            AddToBillBtn.Click += AddToBillBtn_Click;
            // 
            // RefreshBtn
            // 
            RefreshBtn.BackColor = Color.IndianRed;
            RefreshBtn.Font = new Font("Roboto", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            RefreshBtn.ForeColor = Color.White;
            RefreshBtn.Location = new Point(209, 217);
            RefreshBtn.Name = "RefreshBtn";
            RefreshBtn.Size = new Size(107, 42);
            RefreshBtn.TabIndex = 17;
            RefreshBtn.Text = "Refresh";
            RefreshBtn.UseVisualStyleBackColor = false;
            RefreshBtn.Click += RefreshBtn_Click;
            // 
            // CustomerBillsDGV
            // 
            CustomerBillsDGV.BackgroundColor = Color.White;
            CustomerBillsDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CustomerBillsDGV.Location = new Point(407, 304);
            CustomerBillsDGV.Name = "CustomerBillsDGV";
            CustomerBillsDGV.RowHeadersWidth = 51;
            CustomerBillsDGV.RowTemplate.Height = 29;
            CustomerBillsDGV.Size = new Size(343, 180);
            CustomerBillsDGV.TabIndex = 16;
            // 
            // BCustomerCb
            // 
            BCustomerCb.FormattingEnabled = true;
            BCustomerCb.Location = new Point(57, 68);
            BCustomerCb.Name = "BCustomerCb";
            BCustomerCb.Size = new Size(259, 28);
            BCustomerCb.TabIndex = 15;
            // 
            // BQuantityTb
            // 
            BQuantityTb.Font = new Font("Roboto", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            BQuantityTb.ForeColor = SystemColors.ControlText;
            BQuantityTb.Location = new Point(57, 178);
            BQuantityTb.Name = "BQuantityTb";
            BQuantityTb.PlaceholderText = "Quantity";
            BQuantityTb.Size = new Size(259, 28);
            BQuantityTb.TabIndex = 14;
            // 
            // BPriceTb
            // 
            BPriceTb.Font = new Font("Roboto", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            BPriceTb.ForeColor = SystemColors.ControlText;
            BPriceTb.Location = new Point(57, 144);
            BPriceTb.Name = "BPriceTb";
            BPriceTb.PlaceholderText = "Price";
            BPriceTb.Size = new Size(259, 28);
            BPriceTb.TabIndex = 13;
            // 
            // BItemNameTb
            // 
            BItemNameTb.Font = new Font("Roboto", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            BItemNameTb.ForeColor = SystemColors.ControlText;
            BItemNameTb.Location = new Point(57, 110);
            BItemNameTb.Name = "BItemNameTb";
            BItemNameTb.PlaceholderText = "Item Name";
            BItemNameTb.Size = new Size(259, 28);
            BItemNameTb.TabIndex = 12;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Roboto", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.IndianRed;
            label9.ImageAlign = ContentAlignment.TopCenter;
            label9.Location = new Point(327, 17);
            label9.Name = "label9";
            label9.Size = new Size(132, 24);
            label9.TabIndex = 11;
            label9.Text = "Billing Details";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(label15);
            tabPage5.Controls.Add(SaleLbl);
            tabPage5.Controls.Add(label14);
            tabPage5.Controls.Add(label);
            tabPage5.Controls.Add(CustLabel);
            tabPage5.Controls.Add(ItemLbl);
            tabPage5.Location = new Point(4, 5);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(777, 509);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "tabPage5";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label15.ForeColor = SystemColors.ActiveCaptionText;
            label15.Location = new Point(69, 399);
            label15.Name = "label15";
            label15.Size = new Size(54, 22);
            label15.TabIndex = 0;
            label15.Text = "Sales";
            // 
            // SaleLbl
            // 
            SaleLbl.AutoSize = true;
            SaleLbl.Font = new Font("Roboto", 60F, FontStyle.Bold, GraphicsUnit.Point);
            SaleLbl.ForeColor = Color.IndianRed;
            SaleLbl.Location = new Point(140, 348);
            SaleLbl.Name = "SaleLbl";
            SaleLbl.Size = new Size(107, 120);
            SaleLbl.TabIndex = 1;
            SaleLbl.Text = "0";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = SystemColors.ActiveCaptionText;
            label14.Location = new Point(67, 239);
            label14.Name = "label14";
            label14.Size = new Size(56, 22);
            label14.TabIndex = 0;
            label14.Text = "Items";
            // 
            // label
            // 
            label.AutoSize = true;
            label.BackColor = Color.Transparent;
            label.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label.ForeColor = Color.Black;
            label.Location = new Point(46, 89);
            label.Name = "label";
            label.Size = new Size(98, 22);
            label.TabIndex = 0;
            label.Text = "Customers";
            label.Click += label_Click;
            // 
            // CustLabel
            // 
            CustLabel.AutoSize = true;
            CustLabel.BackColor = Color.Transparent;
            CustLabel.Font = new Font("Roboto", 60F, FontStyle.Bold, GraphicsUnit.Point);
            CustLabel.ForeColor = Color.IndianRed;
            CustLabel.Location = new Point(140, 41);
            CustLabel.Name = "CustLabel";
            CustLabel.Size = new Size(107, 120);
            CustLabel.TabIndex = 1;
            CustLabel.Text = "0";
            CustLabel.Click += CustLabel_Click;
            // 
            // ItemLbl
            // 
            ItemLbl.AutoSize = true;
            ItemLbl.BackColor = Color.Transparent;
            ItemLbl.Font = new Font("Roboto", 60F, FontStyle.Bold, GraphicsUnit.Point);
            ItemLbl.ForeColor = Color.IndianRed;
            ItemLbl.Location = new Point(140, 190);
            ItemLbl.Name = "ItemLbl";
            ItemLbl.Size = new Size(107, 120);
            ItemLbl.TabIndex = 1;
            ItemLbl.Text = "0";
            // 
            // Customers
            // 
            Customers.AutoSize = true;
            Customers.BackColor = Color.Transparent;
            Customers.Font = new Font("Roboto", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Customers.ForeColor = Color.MistyRose;
            Customers.Location = new Point(67, 247);
            Customers.Name = "Customers";
            Customers.Size = new Size(130, 29);
            Customers.TabIndex = 18;
            Customers.Text = "Customers";
            Customers.Click += Customers_Click;
            // 
            // Categories
            // 
            Categories.AutoSize = true;
            Categories.BackColor = Color.Transparent;
            Categories.Font = new Font("Roboto", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Categories.ForeColor = Color.MistyRose;
            Categories.Location = new Point(67, 310);
            Categories.Name = "Categories";
            Categories.Size = new Size(129, 29);
            Categories.TabIndex = 16;
            Categories.Text = "Categories";
            Categories.Click += Categories_Click;
            // 
            // VanillePastryShop
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1035, 613);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            Name = "VanillePastryShop";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Vanille Pastry And Sweets";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ItemDGV).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CustomerDGV).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CategoryDGV).EndInit();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)YourBillsDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)BItemDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)CustomerBillsDGV).EndInit();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label Items;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label Billing;
        private Label Dashboard;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Panel panel1;
        private Label Categories;
        private Label Customers;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label2;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox ItemNameTb;
        private TextBox QuantityTb;
        private TextBox PriceTb;
        private DataGridView ItemDGV;
        private Button DeleteBtn;
        private Button EditBtn;
        private Button AddBtn;
        private Label label3;
        private ComboBox CategoryCb;
        private Label label4;
        private Button DeleteCustBtn;
        private Button EditCustBtn;
        private Button AddCustBtn;
        private DataGridView CustomerDGV;
        private TextBox CustAddressTb;
        private TextBox CustPhoneTb;
        private TextBox CustNameTb;
        private Label label5;
        private TabPage tabPage3;
        private Label label6;
        private Button DeleteCatBtn;
        private Button EditCatBtn;
        private Button AddCatBtn;
        private DataGridView CategoryDGV;
        private TextBox CatNameTb;
        private Label label7;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private Button AddToBillBtn;
        private Button RefreshBtn;
        private DataGridView CustomerBillsDGV;
        private ComboBox BCustomerCb;
        private TextBox BQuantityTb;
        private TextBox BPriceTb;
        private TextBox BItemNameTb;
        private Label label9;
        private DataGridView BItemDGV;
        private Label label10;
        private Label label11;
        private DataGridView YourBillsDGV;
        private Label label8;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Label yourTotalLabel;
        private Label label12;
        private Button SaveBillBtn;
        private Label ItemLbl;
        private Label label14;
        private Label SaleLbl;
        private Label label15;
        private Label LogoutLbl;
        private Label CustLabel;
        private Label label;
    }
}