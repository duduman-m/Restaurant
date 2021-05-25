
namespace RestaurantFormApp
{
    partial class RestaurantForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RestaurantForm));
            this.TbAdd = new System.Windows.Forms.TabControl();
            this.AddOrder = new System.Windows.Forms.TabPage();
            this.BtnDeleteOrder = new System.Windows.Forms.Button();
            this.BtnUpdateOrder = new System.Windows.Forms.Button();
            this.ErrOrderProducts = new System.Windows.Forms.Label();
            this.LbOrderMessage = new System.Windows.Forms.Label();
            this.BtnAddOrder = new System.Windows.Forms.Button();
            this.ComboOrderProducts = new System.Windows.Forms.CheckedListBox();
            this.LbOrderProducts = new System.Windows.Forms.Label();
            this.ErrOrderTable = new System.Windows.Forms.Label();
            this.ComboOrderTable = new System.Windows.Forms.ComboBox();
            this.LbOrderTable = new System.Windows.Forms.Label();
            this.ErrOrderDiscount = new System.Windows.Forms.Label();
            this.ComboOrderDiscount = new System.Windows.Forms.ComboBox();
            this.LbOrderDiscount = new System.Windows.Forms.Label();
            this.ErrOrderStatus = new System.Windows.Forms.Label();
            this.ComboOrderStatus = new System.Windows.Forms.ComboBox();
            this.LbOrderStatus = new System.Windows.Forms.Label();
            this.ErrOrderInfo = new System.Windows.Forms.Label();
            this.TxtOrderInfo = new System.Windows.Forms.RichTextBox();
            this.LbOrderInfo = new System.Windows.Forms.Label();
            this.ErrOrderClient = new System.Windows.Forms.Label();
            this.LbOrderClient = new System.Windows.Forms.Label();
            this.TxtOrderClient = new System.Windows.Forms.TextBox();
            this.AddProduct = new System.Windows.Forms.TabPage();
            this.LbProductMessage = new System.Windows.Forms.Label();
            this.BtnDeleteProduct = new System.Windows.Forms.Button();
            this.BtnUpdateProduct = new System.Windows.Forms.Button();
            this.BtnAddProduct = new System.Windows.Forms.Button();
            this.ErrProductWeight = new System.Windows.Forms.Label();
            this.ErrProductTime = new System.Windows.Forms.Label();
            this.ErrProductPrice = new System.Windows.Forms.Label();
            this.ErrProductCategory = new System.Windows.Forms.Label();
            this.ErrProductInfo = new System.Windows.Forms.Label();
            this.ErrProductName = new System.Windows.Forms.Label();
            this.ComboProductCategory = new System.Windows.Forms.ComboBox();
            this.NumProductWeight = new System.Windows.Forms.NumericUpDown();
            this.NumProductTime = new System.Windows.Forms.NumericUpDown();
            this.NumProductPrice = new System.Windows.Forms.NumericUpDown();
            this.TxtProductInfo = new System.Windows.Forms.RichTextBox();
            this.TxtProductName = new System.Windows.Forms.TextBox();
            this.LbProductTime = new System.Windows.Forms.Label();
            this.LbProductWeight = new System.Windows.Forms.Label();
            this.LbProductPrice = new System.Windows.Forms.Label();
            this.LbProductCategory = new System.Windows.Forms.Label();
            this.LbProductInfo = new System.Windows.Forms.Label();
            this.LbProductName = new System.Windows.Forms.Label();
            this.AddCategory = new System.Windows.Forms.TabPage();
            this.BtnDeleteCategory = new System.Windows.Forms.Button();
            this.BtnUpdateCategory = new System.Windows.Forms.Button();
            this.ErrCategoryInfo = new System.Windows.Forms.Label();
            this.ErrCategoryName = new System.Windows.Forms.Label();
            this.LbCategoryMessage = new System.Windows.Forms.Label();
            this.BtnAddCategory = new System.Windows.Forms.Button();
            this.TxtCategoryInfo = new System.Windows.Forms.RichTextBox();
            this.TxtCategoryName = new System.Windows.Forms.TextBox();
            this.LbCategoryInfo = new System.Windows.Forms.Label();
            this.LbCategoryName = new System.Windows.Forms.Label();
            this.AddTable = new System.Windows.Forms.TabPage();
            this.LbTableMessage = new System.Windows.Forms.Label();
            this.BtnDeleteTable = new System.Windows.Forms.Button();
            this.BtnUpdateTable = new System.Windows.Forms.Button();
            this.BtAddTable = new System.Windows.Forms.Button();
            this.ChxOcuppied = new System.Windows.Forms.CheckBox();
            this.ChxReserved = new System.Windows.Forms.CheckBox();
            this.NumSeats = new System.Windows.Forms.NumericUpDown();
            this.LbOcuppied = new System.Windows.Forms.Label();
            this.LbReserved = new System.Windows.Forms.Label();
            this.LbSeats = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LblLog = new System.Windows.Forms.Label();
            this.TpOrders = new System.Windows.Forms.TabPage();
            this.ComboFilterOrderStatus = new System.Windows.Forms.ComboBox();
            this.TxtFilterOrderClient = new System.Windows.Forms.TextBox();
            this.ChxFilterOrderStatus = new System.Windows.Forms.CheckBox();
            this.ChxFilterOrderClient = new System.Windows.Forms.CheckBox();
            this.BtnFilterOrders = new System.Windows.Forms.Button();
            this.LbResetOrders = new System.Windows.Forms.Label();
            this.ListOrders = new System.Windows.Forms.ListBox();
            this.TpTables = new System.Windows.Forms.TabPage();
            this.ListTables = new System.Windows.Forms.ListBox();
            this.NumFilterSeats = new System.Windows.Forms.NumericUpDown();
            this.ChxFilterStatusTables = new System.Windows.Forms.CheckBox();
            this.ChxFilterSeats = new System.Windows.Forms.CheckBox();
            this.BtnFilterTables = new System.Windows.Forms.Button();
            this.LbResetTables = new System.Windows.Forms.Label();
            this.ChxFilterReserved = new System.Windows.Forms.CheckBox();
            this.ChxFilterOcuppied = new System.Windows.Forms.CheckBox();
            this.TpCategories = new System.Windows.Forms.TabPage();
            this.ChxCategoryInfo = new System.Windows.Forms.CheckBox();
            this.ChxCategoryName = new System.Windows.Forms.CheckBox();
            this.BtnFilterCategories = new System.Windows.Forms.Button();
            this.TxtFilterCategoryInfo = new System.Windows.Forms.TextBox();
            this.TxtFilterCategoryName = new System.Windows.Forms.TextBox();
            this.LbResetCategories = new System.Windows.Forms.Label();
            this.ListCategories = new System.Windows.Forms.ListBox();
            this.TpProducts = new System.Windows.Forms.TabPage();
            this.BtnFilterProducts = new System.Windows.Forms.Button();
            this.ComboFilterProductCategory = new System.Windows.Forms.ComboBox();
            this.ChxProductCategory = new System.Windows.Forms.CheckBox();
            this.ChxProductInfo = new System.Windows.Forms.CheckBox();
            this.TxtFilterProductInfo = new System.Windows.Forms.TextBox();
            this.TxtFilterProductName = new System.Windows.Forms.TextBox();
            this.ChxProductName = new System.Windows.Forms.CheckBox();
            this.LbResetProducts = new System.Windows.Forms.Label();
            this.ListProducts = new System.Windows.Forms.ListBox();
            this.TbLog = new System.Windows.Forms.TabControl();
            this.LbLastSync = new System.Windows.Forms.Label();
            this.TxtLastSync = new System.Windows.Forms.Label();
            this.BtnFeedbackForm = new System.Windows.Forms.Button();
            this.RefreshOrders = new System.Windows.Forms.PictureBox();
            this.RefreshProducts = new System.Windows.Forms.PictureBox();
            this.RefreshCategories = new System.Windows.Forms.PictureBox();
            this.RefreshTables = new System.Windows.Forms.PictureBox();
            this.PbBorderAdd = new System.Windows.Forms.PictureBox();
            this.PbLog = new System.Windows.Forms.PictureBox();
            this.TbAdd.SuspendLayout();
            this.AddOrder.SuspendLayout();
            this.AddProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumProductWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumProductTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumProductPrice)).BeginInit();
            this.AddCategory.SuspendLayout();
            this.AddTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumSeats)).BeginInit();
            this.TpOrders.SuspendLayout();
            this.TpTables.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumFilterSeats)).BeginInit();
            this.TpCategories.SuspendLayout();
            this.TpProducts.SuspendLayout();
            this.TbLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RefreshOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RefreshProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RefreshCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RefreshTables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbBorderAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbLog)).BeginInit();
            this.SuspendLayout();
            // 
            // TbAdd
            // 
            this.TbAdd.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.TbAdd.Controls.Add(this.AddOrder);
            this.TbAdd.Controls.Add(this.AddProduct);
            this.TbAdd.Controls.Add(this.AddCategory);
            this.TbAdd.Controls.Add(this.AddTable);
            this.TbAdd.Location = new System.Drawing.Point(80, 43);
            this.TbAdd.Name = "TbAdd";
            this.TbAdd.SelectedIndex = 0;
            this.TbAdd.Size = new System.Drawing.Size(288, 391);
            this.TbAdd.TabIndex = 1;
            this.TbAdd.Selected += new System.Windows.Forms.TabControlEventHandler(this.Tb_Selected);
            // 
            // AddOrder
            // 
            this.AddOrder.Controls.Add(this.BtnDeleteOrder);
            this.AddOrder.Controls.Add(this.BtnUpdateOrder);
            this.AddOrder.Controls.Add(this.ErrOrderProducts);
            this.AddOrder.Controls.Add(this.LbOrderMessage);
            this.AddOrder.Controls.Add(this.BtnAddOrder);
            this.AddOrder.Controls.Add(this.ComboOrderProducts);
            this.AddOrder.Controls.Add(this.LbOrderProducts);
            this.AddOrder.Controls.Add(this.ErrOrderTable);
            this.AddOrder.Controls.Add(this.ComboOrderTable);
            this.AddOrder.Controls.Add(this.LbOrderTable);
            this.AddOrder.Controls.Add(this.ErrOrderDiscount);
            this.AddOrder.Controls.Add(this.ComboOrderDiscount);
            this.AddOrder.Controls.Add(this.LbOrderDiscount);
            this.AddOrder.Controls.Add(this.ErrOrderStatus);
            this.AddOrder.Controls.Add(this.ComboOrderStatus);
            this.AddOrder.Controls.Add(this.LbOrderStatus);
            this.AddOrder.Controls.Add(this.ErrOrderInfo);
            this.AddOrder.Controls.Add(this.TxtOrderInfo);
            this.AddOrder.Controls.Add(this.LbOrderInfo);
            this.AddOrder.Controls.Add(this.ErrOrderClient);
            this.AddOrder.Controls.Add(this.LbOrderClient);
            this.AddOrder.Controls.Add(this.TxtOrderClient);
            this.AddOrder.Location = new System.Drawing.Point(4, 25);
            this.AddOrder.Name = "AddOrder";
            this.AddOrder.Size = new System.Drawing.Size(280, 362);
            this.AddOrder.TabIndex = 3;
            this.AddOrder.Text = "Order";
            this.AddOrder.UseVisualStyleBackColor = true;
            // 
            // BtnDeleteOrder
            // 
            this.BtnDeleteOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnDeleteOrder.Location = new System.Drawing.Point(16, 308);
            this.BtnDeleteOrder.Name = "BtnDeleteOrder";
            this.BtnDeleteOrder.Size = new System.Drawing.Size(75, 23);
            this.BtnDeleteOrder.TabIndex = 35;
            this.BtnDeleteOrder.Text = "Delete";
            this.BtnDeleteOrder.UseVisualStyleBackColor = true;
            this.BtnDeleteOrder.Visible = false;
            this.BtnDeleteOrder.Click += new System.EventHandler(this.BtnDeleteOrder_Click);
            // 
            // BtnUpdateOrder
            // 
            this.BtnUpdateOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnUpdateOrder.Location = new System.Drawing.Point(97, 308);
            this.BtnUpdateOrder.Name = "BtnUpdateOrder";
            this.BtnUpdateOrder.Size = new System.Drawing.Size(75, 23);
            this.BtnUpdateOrder.TabIndex = 36;
            this.BtnUpdateOrder.Text = "Update";
            this.BtnUpdateOrder.UseVisualStyleBackColor = true;
            this.BtnUpdateOrder.Visible = false;
            this.BtnUpdateOrder.Click += new System.EventHandler(this.BtnUpdateOrder_Click);
            // 
            // ErrOrderProducts
            // 
            this.ErrOrderProducts.AutoSize = true;
            this.ErrOrderProducts.BackColor = System.Drawing.Color.Red;
            this.ErrOrderProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrOrderProducts.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ErrOrderProducts.Location = new System.Drawing.Point(16, 292);
            this.ErrOrderProducts.Name = "ErrOrderProducts";
            this.ErrOrderProducts.Size = new System.Drawing.Size(34, 13);
            this.ErrOrderProducts.TabIndex = 34;
            this.ErrOrderProducts.Text = "Error";
            this.ErrOrderProducts.Visible = false;
            // 
            // LbOrderMessage
            // 
            this.LbOrderMessage.AutoSize = true;
            this.LbOrderMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.LbOrderMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbOrderMessage.Location = new System.Drawing.Point(71, 334);
            this.LbOrderMessage.Name = "LbOrderMessage";
            this.LbOrderMessage.Size = new System.Drawing.Size(122, 20);
            this.LbOrderMessage.TabIndex = 33;
            this.LbOrderMessage.Text = "Order message!";
            // 
            // BtnAddOrder
            // 
            this.BtnAddOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAddOrder.Location = new System.Drawing.Point(178, 307);
            this.BtnAddOrder.Name = "BtnAddOrder";
            this.BtnAddOrder.Size = new System.Drawing.Size(75, 23);
            this.BtnAddOrder.TabIndex = 32;
            this.BtnAddOrder.Text = "Add";
            this.BtnAddOrder.UseVisualStyleBackColor = true;
            this.BtnAddOrder.Click += new System.EventHandler(this.BtnAddOrder_Click);
            // 
            // ComboOrderProducts
            // 
            this.ComboOrderProducts.CheckOnClick = true;
            this.ComboOrderProducts.FormattingEnabled = true;
            this.ComboOrderProducts.HorizontalScrollbar = true;
            this.ComboOrderProducts.Location = new System.Drawing.Point(101, 240);
            this.ComboOrderProducts.Name = "ComboOrderProducts";
            this.ComboOrderProducts.Size = new System.Drawing.Size(152, 49);
            this.ComboOrderProducts.TabIndex = 31;
            // 
            // LbOrderProducts
            // 
            this.LbOrderProducts.AutoSize = true;
            this.LbOrderProducts.BackColor = System.Drawing.Color.Transparent;
            this.LbOrderProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbOrderProducts.Location = new System.Drawing.Point(15, 240);
            this.LbOrderProducts.Name = "LbOrderProducts";
            this.LbOrderProducts.Size = new System.Drawing.Size(80, 20);
            this.LbOrderProducts.TabIndex = 29;
            this.LbOrderProducts.Text = "Products";
            // 
            // ErrOrderTable
            // 
            this.ErrOrderTable.AutoSize = true;
            this.ErrOrderTable.BackColor = System.Drawing.Color.Red;
            this.ErrOrderTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrOrderTable.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ErrOrderTable.Location = new System.Drawing.Point(16, 227);
            this.ErrOrderTable.Name = "ErrOrderTable";
            this.ErrOrderTable.Size = new System.Drawing.Size(34, 13);
            this.ErrOrderTable.TabIndex = 28;
            this.ErrOrderTable.Text = "Error";
            this.ErrOrderTable.Visible = false;
            // 
            // ComboOrderTable
            // 
            this.ComboOrderTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboOrderTable.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ComboOrderTable.FormattingEnabled = true;
            this.ComboOrderTable.Location = new System.Drawing.Point(101, 204);
            this.ComboOrderTable.Name = "ComboOrderTable";
            this.ComboOrderTable.Size = new System.Drawing.Size(121, 21);
            this.ComboOrderTable.Sorted = true;
            this.ComboOrderTable.TabIndex = 27;
            // 
            // LbOrderTable
            // 
            this.LbOrderTable.AutoSize = true;
            this.LbOrderTable.BackColor = System.Drawing.Color.Transparent;
            this.LbOrderTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbOrderTable.Location = new System.Drawing.Point(15, 205);
            this.LbOrderTable.Name = "LbOrderTable";
            this.LbOrderTable.Size = new System.Drawing.Size(53, 20);
            this.LbOrderTable.TabIndex = 26;
            this.LbOrderTable.Text = "Table";
            // 
            // ErrOrderDiscount
            // 
            this.ErrOrderDiscount.AutoSize = true;
            this.ErrOrderDiscount.BackColor = System.Drawing.Color.Red;
            this.ErrOrderDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrOrderDiscount.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ErrOrderDiscount.Location = new System.Drawing.Point(16, 187);
            this.ErrOrderDiscount.Name = "ErrOrderDiscount";
            this.ErrOrderDiscount.Size = new System.Drawing.Size(34, 13);
            this.ErrOrderDiscount.TabIndex = 25;
            this.ErrOrderDiscount.Text = "Error";
            this.ErrOrderDiscount.Visible = false;
            // 
            // ComboOrderDiscount
            // 
            this.ComboOrderDiscount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboOrderDiscount.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ComboOrderDiscount.FormattingEnabled = true;
            this.ComboOrderDiscount.Location = new System.Drawing.Point(101, 166);
            this.ComboOrderDiscount.Name = "ComboOrderDiscount";
            this.ComboOrderDiscount.Size = new System.Drawing.Size(121, 21);
            this.ComboOrderDiscount.Sorted = true;
            this.ComboOrderDiscount.TabIndex = 24;
            // 
            // LbOrderDiscount
            // 
            this.LbOrderDiscount.AutoSize = true;
            this.LbOrderDiscount.BackColor = System.Drawing.Color.Transparent;
            this.LbOrderDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbOrderDiscount.Location = new System.Drawing.Point(15, 164);
            this.LbOrderDiscount.Name = "LbOrderDiscount";
            this.LbOrderDiscount.Size = new System.Drawing.Size(80, 20);
            this.LbOrderDiscount.TabIndex = 23;
            this.LbOrderDiscount.Text = "Discount";
            // 
            // ErrOrderStatus
            // 
            this.ErrOrderStatus.AutoSize = true;
            this.ErrOrderStatus.BackColor = System.Drawing.Color.Red;
            this.ErrOrderStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrOrderStatus.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ErrOrderStatus.Location = new System.Drawing.Point(16, 151);
            this.ErrOrderStatus.Name = "ErrOrderStatus";
            this.ErrOrderStatus.Size = new System.Drawing.Size(34, 13);
            this.ErrOrderStatus.TabIndex = 22;
            this.ErrOrderStatus.Text = "Error";
            this.ErrOrderStatus.Visible = false;
            // 
            // ComboOrderStatus
            // 
            this.ComboOrderStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboOrderStatus.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ComboOrderStatus.FormattingEnabled = true;
            this.ComboOrderStatus.Location = new System.Drawing.Point(101, 127);
            this.ComboOrderStatus.Name = "ComboOrderStatus";
            this.ComboOrderStatus.Size = new System.Drawing.Size(121, 21);
            this.ComboOrderStatus.Sorted = true;
            this.ComboOrderStatus.TabIndex = 21;
            // 
            // LbOrderStatus
            // 
            this.LbOrderStatus.AutoSize = true;
            this.LbOrderStatus.BackColor = System.Drawing.Color.Transparent;
            this.LbOrderStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbOrderStatus.Location = new System.Drawing.Point(15, 128);
            this.LbOrderStatus.Name = "LbOrderStatus";
            this.LbOrderStatus.Size = new System.Drawing.Size(62, 20);
            this.LbOrderStatus.TabIndex = 20;
            this.LbOrderStatus.Text = "Status";
            // 
            // ErrOrderInfo
            // 
            this.ErrOrderInfo.AutoSize = true;
            this.ErrOrderInfo.BackColor = System.Drawing.Color.Red;
            this.ErrOrderInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrOrderInfo.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ErrOrderInfo.Location = new System.Drawing.Point(18, 115);
            this.ErrOrderInfo.Name = "ErrOrderInfo";
            this.ErrOrderInfo.Size = new System.Drawing.Size(34, 13);
            this.ErrOrderInfo.TabIndex = 19;
            this.ErrOrderInfo.Text = "Error";
            this.ErrOrderInfo.Visible = false;
            // 
            // TxtOrderInfo
            // 
            this.TxtOrderInfo.Location = new System.Drawing.Point(86, 44);
            this.TxtOrderInfo.MaxLength = 100;
            this.TxtOrderInfo.Name = "TxtOrderInfo";
            this.TxtOrderInfo.Size = new System.Drawing.Size(157, 71);
            this.TxtOrderInfo.TabIndex = 18;
            this.TxtOrderInfo.Text = "";
            // 
            // LbOrderInfo
            // 
            this.LbOrderInfo.AutoSize = true;
            this.LbOrderInfo.BackColor = System.Drawing.Color.Transparent;
            this.LbOrderInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbOrderInfo.Location = new System.Drawing.Point(16, 43);
            this.LbOrderInfo.Name = "LbOrderInfo";
            this.LbOrderInfo.Size = new System.Drawing.Size(41, 20);
            this.LbOrderInfo.TabIndex = 17;
            this.LbOrderInfo.Text = "Info";
            // 
            // ErrOrderClient
            // 
            this.ErrOrderClient.AutoSize = true;
            this.ErrOrderClient.BackColor = System.Drawing.Color.Red;
            this.ErrOrderClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrOrderClient.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ErrOrderClient.Location = new System.Drawing.Point(18, 30);
            this.ErrOrderClient.Name = "ErrOrderClient";
            this.ErrOrderClient.Size = new System.Drawing.Size(34, 13);
            this.ErrOrderClient.TabIndex = 16;
            this.ErrOrderClient.Text = "Error";
            this.ErrOrderClient.Visible = false;
            // 
            // LbOrderClient
            // 
            this.LbOrderClient.AutoSize = true;
            this.LbOrderClient.BackColor = System.Drawing.Color.Transparent;
            this.LbOrderClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbOrderClient.Location = new System.Drawing.Point(15, 7);
            this.LbOrderClient.Name = "LbOrderClient";
            this.LbOrderClient.Size = new System.Drawing.Size(55, 20);
            this.LbOrderClient.TabIndex = 10;
            this.LbOrderClient.Text = "Client";
            // 
            // TxtOrderClient
            // 
            this.TxtOrderClient.Location = new System.Drawing.Point(86, 7);
            this.TxtOrderClient.MaxLength = 50;
            this.TxtOrderClient.Name = "TxtOrderClient";
            this.TxtOrderClient.Size = new System.Drawing.Size(157, 20);
            this.TxtOrderClient.TabIndex = 9;
            // 
            // AddProduct
            // 
            this.AddProduct.BackColor = System.Drawing.SystemColors.Control;
            this.AddProduct.Controls.Add(this.LbProductMessage);
            this.AddProduct.Controls.Add(this.BtnDeleteProduct);
            this.AddProduct.Controls.Add(this.BtnUpdateProduct);
            this.AddProduct.Controls.Add(this.BtnAddProduct);
            this.AddProduct.Controls.Add(this.ErrProductWeight);
            this.AddProduct.Controls.Add(this.ErrProductTime);
            this.AddProduct.Controls.Add(this.ErrProductPrice);
            this.AddProduct.Controls.Add(this.ErrProductCategory);
            this.AddProduct.Controls.Add(this.ErrProductInfo);
            this.AddProduct.Controls.Add(this.ErrProductName);
            this.AddProduct.Controls.Add(this.ComboProductCategory);
            this.AddProduct.Controls.Add(this.NumProductWeight);
            this.AddProduct.Controls.Add(this.NumProductTime);
            this.AddProduct.Controls.Add(this.NumProductPrice);
            this.AddProduct.Controls.Add(this.TxtProductInfo);
            this.AddProduct.Controls.Add(this.TxtProductName);
            this.AddProduct.Controls.Add(this.LbProductTime);
            this.AddProduct.Controls.Add(this.LbProductWeight);
            this.AddProduct.Controls.Add(this.LbProductPrice);
            this.AddProduct.Controls.Add(this.LbProductCategory);
            this.AddProduct.Controls.Add(this.LbProductInfo);
            this.AddProduct.Controls.Add(this.LbProductName);
            this.AddProduct.Location = new System.Drawing.Point(4, 25);
            this.AddProduct.Name = "AddProduct";
            this.AddProduct.Padding = new System.Windows.Forms.Padding(3);
            this.AddProduct.Size = new System.Drawing.Size(280, 362);
            this.AddProduct.TabIndex = 0;
            this.AddProduct.Text = "Product";
            // 
            // LbProductMessage
            // 
            this.LbProductMessage.AutoSize = true;
            this.LbProductMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.LbProductMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbProductMessage.Location = new System.Drawing.Point(58, 318);
            this.LbProductMessage.Name = "LbProductMessage";
            this.LbProductMessage.Size = new System.Drawing.Size(146, 20);
            this.LbProductMessage.TabIndex = 20;
            this.LbProductMessage.Text = "Category message!";
            // 
            // BtnDeleteProduct
            // 
            this.BtnDeleteProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnDeleteProduct.Location = new System.Drawing.Point(16, 292);
            this.BtnDeleteProduct.Name = "BtnDeleteProduct";
            this.BtnDeleteProduct.Size = new System.Drawing.Size(75, 23);
            this.BtnDeleteProduct.TabIndex = 18;
            this.BtnDeleteProduct.Text = "Delete";
            this.BtnDeleteProduct.UseVisualStyleBackColor = true;
            this.BtnDeleteProduct.Visible = false;
            this.BtnDeleteProduct.Click += new System.EventHandler(this.BtnDeleteProduct_Click);
            // 
            // BtnUpdateProduct
            // 
            this.BtnUpdateProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnUpdateProduct.Location = new System.Drawing.Point(97, 292);
            this.BtnUpdateProduct.Name = "BtnUpdateProduct";
            this.BtnUpdateProduct.Size = new System.Drawing.Size(75, 23);
            this.BtnUpdateProduct.TabIndex = 19;
            this.BtnUpdateProduct.Text = "Update";
            this.BtnUpdateProduct.UseVisualStyleBackColor = true;
            this.BtnUpdateProduct.Visible = false;
            this.BtnUpdateProduct.Click += new System.EventHandler(this.BtnUpdateProduct_Click);
            // 
            // BtnAddProduct
            // 
            this.BtnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAddProduct.Location = new System.Drawing.Point(177, 292);
            this.BtnAddProduct.Name = "BtnAddProduct";
            this.BtnAddProduct.Size = new System.Drawing.Size(75, 23);
            this.BtnAddProduct.TabIndex = 17;
            this.BtnAddProduct.Text = "Add";
            this.BtnAddProduct.UseVisualStyleBackColor = true;
            this.BtnAddProduct.Click += new System.EventHandler(this.BtnAddProduct_Click);
            // 
            // ErrProductWeight
            // 
            this.ErrProductWeight.AutoSize = true;
            this.ErrProductWeight.BackColor = System.Drawing.Color.Red;
            this.ErrProductWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrProductWeight.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ErrProductWeight.Location = new System.Drawing.Point(142, 235);
            this.ErrProductWeight.Name = "ErrProductWeight";
            this.ErrProductWeight.Size = new System.Drawing.Size(34, 13);
            this.ErrProductWeight.TabIndex = 16;
            this.ErrProductWeight.Text = "Error";
            this.ErrProductWeight.Visible = false;
            // 
            // ErrProductTime
            // 
            this.ErrProductTime.AutoSize = true;
            this.ErrProductTime.BackColor = System.Drawing.Color.Red;
            this.ErrProductTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrProductTime.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ErrProductTime.Location = new System.Drawing.Point(18, 275);
            this.ErrProductTime.Name = "ErrProductTime";
            this.ErrProductTime.Size = new System.Drawing.Size(34, 13);
            this.ErrProductTime.TabIndex = 16;
            this.ErrProductTime.Text = "Error";
            this.ErrProductTime.Visible = false;
            // 
            // ErrProductPrice
            // 
            this.ErrProductPrice.AutoSize = true;
            this.ErrProductPrice.BackColor = System.Drawing.Color.Red;
            this.ErrProductPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrProductPrice.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ErrProductPrice.Location = new System.Drawing.Point(18, 235);
            this.ErrProductPrice.Name = "ErrProductPrice";
            this.ErrProductPrice.Size = new System.Drawing.Size(34, 13);
            this.ErrProductPrice.TabIndex = 16;
            this.ErrProductPrice.Text = "Error";
            this.ErrProductPrice.Visible = false;
            // 
            // ErrProductCategory
            // 
            this.ErrProductCategory.AutoSize = true;
            this.ErrProductCategory.BackColor = System.Drawing.Color.Red;
            this.ErrProductCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrProductCategory.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ErrProductCategory.Location = new System.Drawing.Point(18, 194);
            this.ErrProductCategory.Name = "ErrProductCategory";
            this.ErrProductCategory.Size = new System.Drawing.Size(34, 13);
            this.ErrProductCategory.TabIndex = 16;
            this.ErrProductCategory.Text = "Error";
            this.ErrProductCategory.Visible = false;
            // 
            // ErrProductInfo
            // 
            this.ErrProductInfo.AutoSize = true;
            this.ErrProductInfo.BackColor = System.Drawing.Color.Red;
            this.ErrProductInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrProductInfo.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ErrProductInfo.Location = new System.Drawing.Point(18, 151);
            this.ErrProductInfo.Name = "ErrProductInfo";
            this.ErrProductInfo.Size = new System.Drawing.Size(34, 13);
            this.ErrProductInfo.TabIndex = 16;
            this.ErrProductInfo.Text = "Error";
            this.ErrProductInfo.Visible = false;
            // 
            // ErrProductName
            // 
            this.ErrProductName.AutoSize = true;
            this.ErrProductName.BackColor = System.Drawing.Color.Red;
            this.ErrProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrProductName.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ErrProductName.Location = new System.Drawing.Point(18, 37);
            this.ErrProductName.Name = "ErrProductName";
            this.ErrProductName.Size = new System.Drawing.Size(34, 13);
            this.ErrProductName.TabIndex = 15;
            this.ErrProductName.Text = "Error";
            this.ErrProductName.Visible = false;
            // 
            // ComboProductCategory
            // 
            this.ComboProductCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboProductCategory.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ComboProductCategory.FormattingEnabled = true;
            this.ComboProductCategory.Location = new System.Drawing.Point(117, 170);
            this.ComboProductCategory.Name = "ComboProductCategory";
            this.ComboProductCategory.Size = new System.Drawing.Size(121, 21);
            this.ComboProductCategory.Sorted = true;
            this.ComboProductCategory.TabIndex = 8;
            // 
            // NumProductWeight
            // 
            this.NumProductWeight.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.NumProductWeight.Location = new System.Drawing.Point(212, 212);
            this.NumProductWeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NumProductWeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumProductWeight.Name = "NumProductWeight";
            this.NumProductWeight.Size = new System.Drawing.Size(49, 20);
            this.NumProductWeight.TabIndex = 10;
            this.NumProductWeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NumProductTime
            // 
            this.NumProductTime.DecimalPlaces = 2;
            this.NumProductTime.Location = new System.Drawing.Point(160, 252);
            this.NumProductTime.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.NumProductTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumProductTime.Name = "NumProductTime";
            this.NumProductTime.Size = new System.Drawing.Size(94, 20);
            this.NumProductTime.TabIndex = 10;
            this.NumProductTime.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NumProductPrice
            // 
            this.NumProductPrice.DecimalPlaces = 2;
            this.NumProductPrice.Location = new System.Drawing.Point(74, 212);
            this.NumProductPrice.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.NumProductPrice.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumProductPrice.Name = "NumProductPrice";
            this.NumProductPrice.Size = new System.Drawing.Size(49, 20);
            this.NumProductPrice.TabIndex = 10;
            this.NumProductPrice.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // TxtProductInfo
            // 
            this.TxtProductInfo.Location = new System.Drawing.Point(97, 53);
            this.TxtProductInfo.MaxLength = 100;
            this.TxtProductInfo.Name = "TxtProductInfo";
            this.TxtProductInfo.Size = new System.Drawing.Size(157, 96);
            this.TxtProductInfo.TabIndex = 9;
            this.TxtProductInfo.Text = "";
            // 
            // TxtProductName
            // 
            this.TxtProductName.Location = new System.Drawing.Point(97, 15);
            this.TxtProductName.MaxLength = 25;
            this.TxtProductName.Name = "TxtProductName";
            this.TxtProductName.Size = new System.Drawing.Size(157, 20);
            this.TxtProductName.TabIndex = 8;
            // 
            // LbProductTime
            // 
            this.LbProductTime.AutoSize = true;
            this.LbProductTime.BackColor = System.Drawing.Color.Transparent;
            this.LbProductTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbProductTime.Location = new System.Drawing.Point(17, 252);
            this.LbProductTime.Name = "LbProductTime";
            this.LbProductTime.Size = new System.Drawing.Size(135, 20);
            this.LbProductTime.TabIndex = 7;
            this.LbProductTime.Text = "Time to prepare";
            // 
            // LbProductWeight
            // 
            this.LbProductWeight.AutoSize = true;
            this.LbProductWeight.BackColor = System.Drawing.Color.Transparent;
            this.LbProductWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbProductWeight.Location = new System.Drawing.Point(139, 212);
            this.LbProductWeight.Name = "LbProductWeight";
            this.LbProductWeight.Size = new System.Drawing.Size(65, 20);
            this.LbProductWeight.TabIndex = 7;
            this.LbProductWeight.Text = "Weight";
            // 
            // LbProductPrice
            // 
            this.LbProductPrice.AutoSize = true;
            this.LbProductPrice.BackColor = System.Drawing.Color.Transparent;
            this.LbProductPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbProductPrice.Location = new System.Drawing.Point(17, 212);
            this.LbProductPrice.Name = "LbProductPrice";
            this.LbProductPrice.Size = new System.Drawing.Size(49, 20);
            this.LbProductPrice.TabIndex = 7;
            this.LbProductPrice.Text = "Price";
            // 
            // LbProductCategory
            // 
            this.LbProductCategory.AutoSize = true;
            this.LbProductCategory.BackColor = System.Drawing.Color.Transparent;
            this.LbProductCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbProductCategory.Location = new System.Drawing.Point(17, 170);
            this.LbProductCategory.Name = "LbProductCategory";
            this.LbProductCategory.Size = new System.Drawing.Size(81, 20);
            this.LbProductCategory.TabIndex = 7;
            this.LbProductCategory.Text = "Category";
            // 
            // LbProductInfo
            // 
            this.LbProductInfo.AutoSize = true;
            this.LbProductInfo.BackColor = System.Drawing.Color.Transparent;
            this.LbProductInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbProductInfo.Location = new System.Drawing.Point(17, 53);
            this.LbProductInfo.Name = "LbProductInfo";
            this.LbProductInfo.Size = new System.Drawing.Size(41, 20);
            this.LbProductInfo.TabIndex = 7;
            this.LbProductInfo.Text = "Info";
            // 
            // LbProductName
            // 
            this.LbProductName.AutoSize = true;
            this.LbProductName.BackColor = System.Drawing.Color.Transparent;
            this.LbProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbProductName.Location = new System.Drawing.Point(17, 13);
            this.LbProductName.Name = "LbProductName";
            this.LbProductName.Size = new System.Drawing.Size(55, 20);
            this.LbProductName.TabIndex = 7;
            this.LbProductName.Text = "Name";
            // 
            // AddCategory
            // 
            this.AddCategory.BackColor = System.Drawing.SystemColors.Control;
            this.AddCategory.Controls.Add(this.BtnDeleteCategory);
            this.AddCategory.Controls.Add(this.BtnUpdateCategory);
            this.AddCategory.Controls.Add(this.ErrCategoryInfo);
            this.AddCategory.Controls.Add(this.ErrCategoryName);
            this.AddCategory.Controls.Add(this.LbCategoryMessage);
            this.AddCategory.Controls.Add(this.BtnAddCategory);
            this.AddCategory.Controls.Add(this.TxtCategoryInfo);
            this.AddCategory.Controls.Add(this.TxtCategoryName);
            this.AddCategory.Controls.Add(this.LbCategoryInfo);
            this.AddCategory.Controls.Add(this.LbCategoryName);
            this.AddCategory.Location = new System.Drawing.Point(4, 25);
            this.AddCategory.Name = "AddCategory";
            this.AddCategory.Size = new System.Drawing.Size(280, 362);
            this.AddCategory.TabIndex = 1;
            this.AddCategory.Text = "Category";
            // 
            // BtnDeleteCategory
            // 
            this.BtnDeleteCategory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnDeleteCategory.Location = new System.Drawing.Point(28, 234);
            this.BtnDeleteCategory.Name = "BtnDeleteCategory";
            this.BtnDeleteCategory.Size = new System.Drawing.Size(75, 23);
            this.BtnDeleteCategory.TabIndex = 15;
            this.BtnDeleteCategory.Text = "Delete";
            this.BtnDeleteCategory.UseVisualStyleBackColor = true;
            this.BtnDeleteCategory.Visible = false;
            this.BtnDeleteCategory.Click += new System.EventHandler(this.BtnDeleteCategory_Click);
            // 
            // BtnUpdateCategory
            // 
            this.BtnUpdateCategory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnUpdateCategory.Location = new System.Drawing.Point(109, 234);
            this.BtnUpdateCategory.Name = "BtnUpdateCategory";
            this.BtnUpdateCategory.Size = new System.Drawing.Size(75, 23);
            this.BtnUpdateCategory.TabIndex = 16;
            this.BtnUpdateCategory.Text = "Update";
            this.BtnUpdateCategory.UseVisualStyleBackColor = true;
            this.BtnUpdateCategory.Visible = false;
            this.BtnUpdateCategory.Click += new System.EventHandler(this.BtnUpdateCategory_Click);
            // 
            // ErrCategoryInfo
            // 
            this.ErrCategoryInfo.AutoSize = true;
            this.ErrCategoryInfo.BackColor = System.Drawing.Color.Red;
            this.ErrCategoryInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrCategoryInfo.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ErrCategoryInfo.Location = new System.Drawing.Point(20, 202);
            this.ErrCategoryInfo.Name = "ErrCategoryInfo";
            this.ErrCategoryInfo.Size = new System.Drawing.Size(34, 13);
            this.ErrCategoryInfo.TabIndex = 14;
            this.ErrCategoryInfo.Text = "Error";
            this.ErrCategoryInfo.Visible = false;
            // 
            // ErrCategoryName
            // 
            this.ErrCategoryName.AutoSize = true;
            this.ErrCategoryName.BackColor = System.Drawing.Color.Red;
            this.ErrCategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrCategoryName.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ErrCategoryName.Location = new System.Drawing.Point(16, 76);
            this.ErrCategoryName.Name = "ErrCategoryName";
            this.ErrCategoryName.Size = new System.Drawing.Size(34, 13);
            this.ErrCategoryName.TabIndex = 14;
            this.ErrCategoryName.Text = "Error";
            this.ErrCategoryName.Visible = false;
            // 
            // LbCategoryMessage
            // 
            this.LbCategoryMessage.AutoSize = true;
            this.LbCategoryMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.LbCategoryMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbCategoryMessage.Location = new System.Drawing.Point(63, 273);
            this.LbCategoryMessage.Name = "LbCategoryMessage";
            this.LbCategoryMessage.Size = new System.Drawing.Size(146, 20);
            this.LbCategoryMessage.TabIndex = 13;
            this.LbCategoryMessage.Text = "Category message!";
            // 
            // BtnAddCategory
            // 
            this.BtnAddCategory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAddCategory.Location = new System.Drawing.Point(189, 234);
            this.BtnAddCategory.Name = "BtnAddCategory";
            this.BtnAddCategory.Size = new System.Drawing.Size(75, 23);
            this.BtnAddCategory.TabIndex = 12;
            this.BtnAddCategory.Text = "Add";
            this.BtnAddCategory.UseVisualStyleBackColor = true;
            this.BtnAddCategory.Click += new System.EventHandler(this.BtnAddCategory_Click);
            // 
            // TxtCategoryInfo
            // 
            this.TxtCategoryInfo.Location = new System.Drawing.Point(94, 98);
            this.TxtCategoryInfo.MaxLength = 100;
            this.TxtCategoryInfo.Name = "TxtCategoryInfo";
            this.TxtCategoryInfo.Size = new System.Drawing.Size(157, 96);
            this.TxtCategoryInfo.TabIndex = 8;
            this.TxtCategoryInfo.Text = "";
            // 
            // TxtCategoryName
            // 
            this.TxtCategoryName.Location = new System.Drawing.Point(94, 49);
            this.TxtCategoryName.MaxLength = 25;
            this.TxtCategoryName.Name = "TxtCategoryName";
            this.TxtCategoryName.Size = new System.Drawing.Size(157, 20);
            this.TxtCategoryName.TabIndex = 7;
            // 
            // LbCategoryInfo
            // 
            this.LbCategoryInfo.AutoSize = true;
            this.LbCategoryInfo.BackColor = System.Drawing.Color.Transparent;
            this.LbCategoryInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbCategoryInfo.Location = new System.Drawing.Point(15, 100);
            this.LbCategoryInfo.Name = "LbCategoryInfo";
            this.LbCategoryInfo.Size = new System.Drawing.Size(41, 20);
            this.LbCategoryInfo.TabIndex = 6;
            this.LbCategoryInfo.Text = "Info";
            // 
            // LbCategoryName
            // 
            this.LbCategoryName.AutoSize = true;
            this.LbCategoryName.BackColor = System.Drawing.Color.Transparent;
            this.LbCategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbCategoryName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LbCategoryName.Location = new System.Drawing.Point(15, 49);
            this.LbCategoryName.Name = "LbCategoryName";
            this.LbCategoryName.Size = new System.Drawing.Size(55, 20);
            this.LbCategoryName.TabIndex = 6;
            this.LbCategoryName.Text = "Name";
            // 
            // AddTable
            // 
            this.AddTable.BackColor = System.Drawing.Color.Transparent;
            this.AddTable.Controls.Add(this.LbTableMessage);
            this.AddTable.Controls.Add(this.BtnDeleteTable);
            this.AddTable.Controls.Add(this.BtnUpdateTable);
            this.AddTable.Controls.Add(this.BtAddTable);
            this.AddTable.Controls.Add(this.ChxOcuppied);
            this.AddTable.Controls.Add(this.ChxReserved);
            this.AddTable.Controls.Add(this.NumSeats);
            this.AddTable.Controls.Add(this.LbOcuppied);
            this.AddTable.Controls.Add(this.LbReserved);
            this.AddTable.Controls.Add(this.LbSeats);
            this.AddTable.Location = new System.Drawing.Point(4, 25);
            this.AddTable.Name = "AddTable";
            this.AddTable.Size = new System.Drawing.Size(280, 362);
            this.AddTable.TabIndex = 2;
            this.AddTable.Text = "Table";
            // 
            // LbTableMessage
            // 
            this.LbTableMessage.AutoSize = true;
            this.LbTableMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.LbTableMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTableMessage.Location = new System.Drawing.Point(73, 243);
            this.LbTableMessage.Name = "LbTableMessage";
            this.LbTableMessage.Size = new System.Drawing.Size(121, 20);
            this.LbTableMessage.TabIndex = 12;
            this.LbTableMessage.Text = "Table message!";
            // 
            // BtnDeleteTable
            // 
            this.BtnDeleteTable.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnDeleteTable.Location = new System.Drawing.Point(26, 205);
            this.BtnDeleteTable.Name = "BtnDeleteTable";
            this.BtnDeleteTable.Size = new System.Drawing.Size(75, 23);
            this.BtnDeleteTable.TabIndex = 11;
            this.BtnDeleteTable.Text = "Delete";
            this.BtnDeleteTable.UseVisualStyleBackColor = true;
            this.BtnDeleteTable.Visible = false;
            this.BtnDeleteTable.Click += new System.EventHandler(this.BtnDeleteTable_Click);
            // 
            // BtnUpdateTable
            // 
            this.BtnUpdateTable.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnUpdateTable.Location = new System.Drawing.Point(107, 205);
            this.BtnUpdateTable.Name = "BtnUpdateTable";
            this.BtnUpdateTable.Size = new System.Drawing.Size(75, 23);
            this.BtnUpdateTable.TabIndex = 11;
            this.BtnUpdateTable.Text = "Update";
            this.BtnUpdateTable.UseVisualStyleBackColor = true;
            this.BtnUpdateTable.Visible = false;
            this.BtnUpdateTable.Click += new System.EventHandler(this.BtnUpdateTable_Click);
            // 
            // BtAddTable
            // 
            this.BtAddTable.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtAddTable.Location = new System.Drawing.Point(188, 205);
            this.BtAddTable.Name = "BtAddTable";
            this.BtAddTable.Size = new System.Drawing.Size(75, 23);
            this.BtAddTable.TabIndex = 11;
            this.BtAddTable.Text = "Add";
            this.BtAddTable.UseVisualStyleBackColor = true;
            this.BtAddTable.Click += new System.EventHandler(this.BtAddTable_Click);
            // 
            // ChxOcuppied
            // 
            this.ChxOcuppied.AutoSize = true;
            this.ChxOcuppied.Location = new System.Drawing.Point(120, 123);
            this.ChxOcuppied.Name = "ChxOcuppied";
            this.ChxOcuppied.Size = new System.Drawing.Size(15, 14);
            this.ChxOcuppied.TabIndex = 10;
            this.ChxOcuppied.UseVisualStyleBackColor = true;
            // 
            // ChxReserved
            // 
            this.ChxReserved.AutoSize = true;
            this.ChxReserved.Location = new System.Drawing.Point(120, 162);
            this.ChxReserved.Name = "ChxReserved";
            this.ChxReserved.Size = new System.Drawing.Size(15, 14);
            this.ChxReserved.TabIndex = 9;
            this.ChxReserved.UseVisualStyleBackColor = true;
            // 
            // NumSeats
            // 
            this.NumSeats.Location = new System.Drawing.Point(174, 85);
            this.NumSeats.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.NumSeats.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumSeats.Name = "NumSeats";
            this.NumSeats.Size = new System.Drawing.Size(70, 20);
            this.NumSeats.TabIndex = 8;
            this.NumSeats.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // LbOcuppied
            // 
            this.LbOcuppied.AutoSize = true;
            this.LbOcuppied.BackColor = System.Drawing.Color.Transparent;
            this.LbOcuppied.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbOcuppied.Location = new System.Drawing.Point(14, 118);
            this.LbOcuppied.Name = "LbOcuppied";
            this.LbOcuppied.Size = new System.Drawing.Size(85, 20);
            this.LbOcuppied.TabIndex = 7;
            this.LbOcuppied.Text = "Ocuppied";
            // 
            // LbReserved
            // 
            this.LbReserved.AutoSize = true;
            this.LbReserved.BackColor = System.Drawing.Color.Transparent;
            this.LbReserved.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbReserved.Location = new System.Drawing.Point(14, 158);
            this.LbReserved.Name = "LbReserved";
            this.LbReserved.Size = new System.Drawing.Size(85, 20);
            this.LbReserved.TabIndex = 6;
            this.LbReserved.Text = "Reserved";
            // 
            // LbSeats
            // 
            this.LbSeats.AutoSize = true;
            this.LbSeats.BackColor = System.Drawing.SystemColors.Control;
            this.LbSeats.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbSeats.Location = new System.Drawing.Point(14, 83);
            this.LbSeats.Name = "LbSeats";
            this.LbSeats.Size = new System.Drawing.Size(141, 20);
            this.LbSeats.TabIndex = 5;
            this.LbSeats.Text = "Number of seats";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(195, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Add";
            // 
            // LblLog
            // 
            this.LblLog.AutoSize = true;
            this.LblLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLog.Location = new System.Drawing.Point(690, 9);
            this.LblLog.Name = "LblLog";
            this.LblLog.Size = new System.Drawing.Size(62, 31);
            this.LblLog.TabIndex = 5;
            this.LblLog.Text = "Log";
            // 
            // TpOrders
            // 
            this.TpOrders.Controls.Add(this.ComboFilterOrderStatus);
            this.TpOrders.Controls.Add(this.TxtFilterOrderClient);
            this.TpOrders.Controls.Add(this.ChxFilterOrderStatus);
            this.TpOrders.Controls.Add(this.ChxFilterOrderClient);
            this.TpOrders.Controls.Add(this.BtnFilterOrders);
            this.TpOrders.Controls.Add(this.LbResetOrders);
            this.TpOrders.Controls.Add(this.RefreshOrders);
            this.TpOrders.Controls.Add(this.ListOrders);
            this.TpOrders.Location = new System.Drawing.Point(4, 25);
            this.TpOrders.Name = "TpOrders";
            this.TpOrders.Size = new System.Drawing.Size(296, 358);
            this.TpOrders.TabIndex = 3;
            this.TpOrders.Text = "Orders";
            this.TpOrders.UseVisualStyleBackColor = true;
            // 
            // ComboFilterOrderStatus
            // 
            this.ComboFilterOrderStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboFilterOrderStatus.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ComboFilterOrderStatus.FormattingEnabled = true;
            this.ComboFilterOrderStatus.Location = new System.Drawing.Point(104, 21);
            this.ComboFilterOrderStatus.Name = "ComboFilterOrderStatus";
            this.ComboFilterOrderStatus.Size = new System.Drawing.Size(76, 21);
            this.ComboFilterOrderStatus.Sorted = true;
            this.ComboFilterOrderStatus.TabIndex = 25;
            this.ComboFilterOrderStatus.Visible = false;
            // 
            // TxtFilterOrderClient
            // 
            this.TxtFilterOrderClient.Location = new System.Drawing.Point(6, 22);
            this.TxtFilterOrderClient.Name = "TxtFilterOrderClient";
            this.TxtFilterOrderClient.Size = new System.Drawing.Size(78, 20);
            this.TxtFilterOrderClient.TabIndex = 24;
            this.TxtFilterOrderClient.Visible = false;
            // 
            // ChxFilterOrderStatus
            // 
            this.ChxFilterOrderStatus.AutoSize = true;
            this.ChxFilterOrderStatus.Location = new System.Drawing.Point(104, 3);
            this.ChxFilterOrderStatus.Name = "ChxFilterOrderStatus";
            this.ChxFilterOrderStatus.Size = new System.Drawing.Size(56, 17);
            this.ChxFilterOrderStatus.TabIndex = 23;
            this.ChxFilterOrderStatus.Text = "Status";
            this.ChxFilterOrderStatus.UseVisualStyleBackColor = true;
            this.ChxFilterOrderStatus.CheckedChanged += new System.EventHandler(this.ChxFilterOrderStatus_CheckedChanged);
            // 
            // ChxFilterOrderClient
            // 
            this.ChxFilterOrderClient.AutoSize = true;
            this.ChxFilterOrderClient.Location = new System.Drawing.Point(8, 3);
            this.ChxFilterOrderClient.Name = "ChxFilterOrderClient";
            this.ChxFilterOrderClient.Size = new System.Drawing.Size(52, 17);
            this.ChxFilterOrderClient.TabIndex = 23;
            this.ChxFilterOrderClient.Text = "Client";
            this.ChxFilterOrderClient.UseVisualStyleBackColor = true;
            this.ChxFilterOrderClient.CheckedChanged += new System.EventHandler(this.ChxFilterOrderClient_CheckedChanged);
            // 
            // BtnFilterOrders
            // 
            this.BtnFilterOrders.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnFilterOrders.Location = new System.Drawing.Point(220, 53);
            this.BtnFilterOrders.Name = "BtnFilterOrders";
            this.BtnFilterOrders.Size = new System.Drawing.Size(70, 23);
            this.BtnFilterOrders.TabIndex = 22;
            this.BtnFilterOrders.Text = "Filter";
            this.BtnFilterOrders.UseVisualStyleBackColor = true;
            this.BtnFilterOrders.Click += new System.EventHandler(this.Filter_Click);
            // 
            // LbResetOrders
            // 
            this.LbResetOrders.AutoSize = true;
            this.LbResetOrders.Location = new System.Drawing.Point(2, 58);
            this.LbResetOrders.Name = "LbResetOrders";
            this.LbResetOrders.Size = new System.Drawing.Size(35, 13);
            this.LbResetOrders.TabIndex = 17;
            this.LbResetOrders.Text = "Reset";
            // 
            // ListOrders
            // 
            this.ListOrders.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListOrders.FormattingEnabled = true;
            this.ListOrders.HorizontalScrollbar = true;
            this.ListOrders.Location = new System.Drawing.Point(0, 81);
            this.ListOrders.Name = "ListOrders";
            this.ListOrders.Size = new System.Drawing.Size(296, 264);
            this.ListOrders.TabIndex = 2;
            this.ListOrders.SelectedIndexChanged += new System.EventHandler(this.ListOrders_SelectedIndexChanged);
            // 
            // TpTables
            // 
            this.TpTables.Controls.Add(this.ListTables);
            this.TpTables.Controls.Add(this.NumFilterSeats);
            this.TpTables.Controls.Add(this.ChxFilterStatusTables);
            this.TpTables.Controls.Add(this.ChxFilterSeats);
            this.TpTables.Controls.Add(this.BtnFilterTables);
            this.TpTables.Controls.Add(this.LbResetTables);
            this.TpTables.Controls.Add(this.ChxFilterReserved);
            this.TpTables.Controls.Add(this.ChxFilterOcuppied);
            this.TpTables.Controls.Add(this.RefreshTables);
            this.TpTables.Location = new System.Drawing.Point(4, 25);
            this.TpTables.Name = "TpTables";
            this.TpTables.Size = new System.Drawing.Size(296, 358);
            this.TpTables.TabIndex = 2;
            this.TpTables.Text = "Tables";
            this.TpTables.UseVisualStyleBackColor = true;
            // 
            // ListTables
            // 
            this.ListTables.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListTables.FormattingEnabled = true;
            this.ListTables.Location = new System.Drawing.Point(0, 80);
            this.ListTables.Name = "ListTables";
            this.ListTables.Size = new System.Drawing.Size(296, 264);
            this.ListTables.TabIndex = 15;
            this.ListTables.SelectedIndexChanged += new System.EventHandler(this.ListTables_SelectedIndexChanged);
            // 
            // NumFilterSeats
            // 
            this.NumFilterSeats.Location = new System.Drawing.Point(32, 19);
            this.NumFilterSeats.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.NumFilterSeats.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumFilterSeats.Name = "NumFilterSeats";
            this.NumFilterSeats.Size = new System.Drawing.Size(70, 20);
            this.NumFilterSeats.TabIndex = 13;
            this.NumFilterSeats.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumFilterSeats.Visible = false;
            // 
            // ChxFilterStatusTables
            // 
            this.ChxFilterStatusTables.AutoSize = true;
            this.ChxFilterStatusTables.Location = new System.Drawing.Point(121, 3);
            this.ChxFilterStatusTables.Name = "ChxFilterStatusTables";
            this.ChxFilterStatusTables.Size = new System.Drawing.Size(56, 17);
            this.ChxFilterStatusTables.TabIndex = 14;
            this.ChxFilterStatusTables.Text = "Status";
            this.ChxFilterStatusTables.UseVisualStyleBackColor = true;
            this.ChxFilterStatusTables.CheckedChanged += new System.EventHandler(this.ChxFilterStatusTables_CheckedChanged);
            // 
            // ChxFilterSeats
            // 
            this.ChxFilterSeats.AutoSize = true;
            this.ChxFilterSeats.Location = new System.Drawing.Point(12, 3);
            this.ChxFilterSeats.Name = "ChxFilterSeats";
            this.ChxFilterSeats.Size = new System.Drawing.Size(103, 17);
            this.ChxFilterSeats.TabIndex = 14;
            this.ChxFilterSeats.Text = "Number of seats";
            this.ChxFilterSeats.UseVisualStyleBackColor = true;
            this.ChxFilterSeats.CheckedChanged += new System.EventHandler(this.ChxFilterSeats_CheckedChanged);
            // 
            // BtnFilterTables
            // 
            this.BtnFilterTables.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnFilterTables.Location = new System.Drawing.Point(218, 52);
            this.BtnFilterTables.Name = "BtnFilterTables";
            this.BtnFilterTables.Size = new System.Drawing.Size(70, 23);
            this.BtnFilterTables.TabIndex = 13;
            this.BtnFilterTables.Text = "Filter";
            this.BtnFilterTables.UseVisualStyleBackColor = true;
            this.BtnFilterTables.Click += new System.EventHandler(this.Filter_Click);
            // 
            // LbResetTables
            // 
            this.LbResetTables.AutoSize = true;
            this.LbResetTables.Location = new System.Drawing.Point(1, 60);
            this.LbResetTables.Name = "LbResetTables";
            this.LbResetTables.Size = new System.Drawing.Size(35, 13);
            this.LbResetTables.TabIndex = 11;
            this.LbResetTables.Text = "Reset";
            // 
            // ChxFilterReserved
            // 
            this.ChxFilterReserved.AutoSize = true;
            this.ChxFilterReserved.Location = new System.Drawing.Point(121, 42);
            this.ChxFilterReserved.Name = "ChxFilterReserved";
            this.ChxFilterReserved.Size = new System.Drawing.Size(72, 17);
            this.ChxFilterReserved.TabIndex = 10;
            this.ChxFilterReserved.Text = "Reserved";
            this.ChxFilterReserved.UseVisualStyleBackColor = true;
            this.ChxFilterReserved.Visible = false;
            // 
            // ChxFilterOcuppied
            // 
            this.ChxFilterOcuppied.AutoSize = true;
            this.ChxFilterOcuppied.Location = new System.Drawing.Point(121, 22);
            this.ChxFilterOcuppied.Name = "ChxFilterOcuppied";
            this.ChxFilterOcuppied.Size = new System.Drawing.Size(72, 17);
            this.ChxFilterOcuppied.TabIndex = 8;
            this.ChxFilterOcuppied.Text = "Ocuppied";
            this.ChxFilterOcuppied.UseVisualStyleBackColor = true;
            this.ChxFilterOcuppied.Visible = false;
            // 
            // TpCategories
            // 
            this.TpCategories.BackColor = System.Drawing.SystemColors.Control;
            this.TpCategories.Controls.Add(this.ChxCategoryInfo);
            this.TpCategories.Controls.Add(this.ChxCategoryName);
            this.TpCategories.Controls.Add(this.BtnFilterCategories);
            this.TpCategories.Controls.Add(this.TxtFilterCategoryInfo);
            this.TpCategories.Controls.Add(this.TxtFilterCategoryName);
            this.TpCategories.Controls.Add(this.LbResetCategories);
            this.TpCategories.Controls.Add(this.RefreshCategories);
            this.TpCategories.Controls.Add(this.ListCategories);
            this.TpCategories.Location = new System.Drawing.Point(4, 25);
            this.TpCategories.Name = "TpCategories";
            this.TpCategories.Size = new System.Drawing.Size(296, 358);
            this.TpCategories.TabIndex = 1;
            this.TpCategories.Text = "Categories";
            // 
            // ChxCategoryInfo
            // 
            this.ChxCategoryInfo.AutoSize = true;
            this.ChxCategoryInfo.Location = new System.Drawing.Point(115, 3);
            this.ChxCategoryInfo.Name = "ChxCategoryInfo";
            this.ChxCategoryInfo.Size = new System.Drawing.Size(44, 17);
            this.ChxCategoryInfo.TabIndex = 16;
            this.ChxCategoryInfo.Text = "Info";
            this.ChxCategoryInfo.UseVisualStyleBackColor = true;
            this.ChxCategoryInfo.CheckedChanged += new System.EventHandler(this.ChxCategoryInfo_CheckedChanged);
            // 
            // ChxCategoryName
            // 
            this.ChxCategoryName.AutoSize = true;
            this.ChxCategoryName.Location = new System.Drawing.Point(5, 3);
            this.ChxCategoryName.Name = "ChxCategoryName";
            this.ChxCategoryName.Size = new System.Drawing.Size(54, 17);
            this.ChxCategoryName.TabIndex = 16;
            this.ChxCategoryName.Text = "Name";
            this.ChxCategoryName.UseVisualStyleBackColor = true;
            this.ChxCategoryName.CheckedChanged += new System.EventHandler(this.ChxCategoryName_CheckedChanged);
            // 
            // BtnFilterCategories
            // 
            this.BtnFilterCategories.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnFilterCategories.Location = new System.Drawing.Point(220, 53);
            this.BtnFilterCategories.Name = "BtnFilterCategories";
            this.BtnFilterCategories.Size = new System.Drawing.Size(70, 23);
            this.BtnFilterCategories.TabIndex = 15;
            this.BtnFilterCategories.Text = "Filter";
            this.BtnFilterCategories.UseVisualStyleBackColor = true;
            this.BtnFilterCategories.Click += new System.EventHandler(this.Filter_Click);
            // 
            // TxtFilterCategoryInfo
            // 
            this.TxtFilterCategoryInfo.Location = new System.Drawing.Point(115, 23);
            this.TxtFilterCategoryInfo.Name = "TxtFilterCategoryInfo";
            this.TxtFilterCategoryInfo.Size = new System.Drawing.Size(100, 20);
            this.TxtFilterCategoryInfo.TabIndex = 14;
            this.TxtFilterCategoryInfo.Visible = false;
            // 
            // TxtFilterCategoryName
            // 
            this.TxtFilterCategoryName.Location = new System.Drawing.Point(5, 23);
            this.TxtFilterCategoryName.Name = "TxtFilterCategoryName";
            this.TxtFilterCategoryName.Size = new System.Drawing.Size(100, 20);
            this.TxtFilterCategoryName.TabIndex = 14;
            this.TxtFilterCategoryName.Visible = false;
            // 
            // LbResetCategories
            // 
            this.LbResetCategories.AutoSize = true;
            this.LbResetCategories.Location = new System.Drawing.Point(2, 60);
            this.LbResetCategories.Name = "LbResetCategories";
            this.LbResetCategories.Size = new System.Drawing.Size(35, 13);
            this.LbResetCategories.TabIndex = 13;
            this.LbResetCategories.Text = "Reset";
            // 
            // ListCategories
            // 
            this.ListCategories.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListCategories.FormattingEnabled = true;
            this.ListCategories.HorizontalScrollbar = true;
            this.ListCategories.Location = new System.Drawing.Point(0, 82);
            this.ListCategories.Name = "ListCategories";
            this.ListCategories.Size = new System.Drawing.Size(296, 264);
            this.ListCategories.TabIndex = 0;
            this.ListCategories.SelectedIndexChanged += new System.EventHandler(this.ListCategories_SelectedIndexChanged);
            // 
            // TpProducts
            // 
            this.TpProducts.BackColor = System.Drawing.SystemColors.Control;
            this.TpProducts.Controls.Add(this.BtnFilterProducts);
            this.TpProducts.Controls.Add(this.ComboFilterProductCategory);
            this.TpProducts.Controls.Add(this.ChxProductCategory);
            this.TpProducts.Controls.Add(this.ChxProductInfo);
            this.TpProducts.Controls.Add(this.TxtFilterProductInfo);
            this.TpProducts.Controls.Add(this.TxtFilterProductName);
            this.TpProducts.Controls.Add(this.ChxProductName);
            this.TpProducts.Controls.Add(this.LbResetProducts);
            this.TpProducts.Controls.Add(this.RefreshProducts);
            this.TpProducts.Controls.Add(this.ListProducts);
            this.TpProducts.Location = new System.Drawing.Point(4, 25);
            this.TpProducts.Name = "TpProducts";
            this.TpProducts.Padding = new System.Windows.Forms.Padding(3);
            this.TpProducts.Size = new System.Drawing.Size(296, 358);
            this.TpProducts.TabIndex = 0;
            this.TpProducts.Text = "Products";
            // 
            // BtnFilterProducts
            // 
            this.BtnFilterProducts.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnFilterProducts.Location = new System.Drawing.Point(220, 53);
            this.BtnFilterProducts.Name = "BtnFilterProducts";
            this.BtnFilterProducts.Size = new System.Drawing.Size(70, 23);
            this.BtnFilterProducts.TabIndex = 21;
            this.BtnFilterProducts.Text = "Filter";
            this.BtnFilterProducts.UseVisualStyleBackColor = true;
            this.BtnFilterProducts.Click += new System.EventHandler(this.Filter_Click);
            // 
            // ComboFilterProductCategory
            // 
            this.ComboFilterProductCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboFilterProductCategory.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ComboFilterProductCategory.FormattingEnabled = true;
            this.ComboFilterProductCategory.Location = new System.Drawing.Point(184, 21);
            this.ComboFilterProductCategory.Name = "ComboFilterProductCategory";
            this.ComboFilterProductCategory.Size = new System.Drawing.Size(93, 21);
            this.ComboFilterProductCategory.Sorted = true;
            this.ComboFilterProductCategory.TabIndex = 20;
            this.ComboFilterProductCategory.Visible = false;
            // 
            // ChxProductCategory
            // 
            this.ChxProductCategory.AutoSize = true;
            this.ChxProductCategory.Location = new System.Drawing.Point(184, 3);
            this.ChxProductCategory.Name = "ChxProductCategory";
            this.ChxProductCategory.Size = new System.Drawing.Size(68, 17);
            this.ChxProductCategory.TabIndex = 19;
            this.ChxProductCategory.Text = "Category";
            this.ChxProductCategory.UseVisualStyleBackColor = true;
            this.ChxProductCategory.CheckedChanged += new System.EventHandler(this.ChxProductCategory_CheckedChanged);
            // 
            // ChxProductInfo
            // 
            this.ChxProductInfo.AutoSize = true;
            this.ChxProductInfo.Location = new System.Drawing.Point(87, 3);
            this.ChxProductInfo.Name = "ChxProductInfo";
            this.ChxProductInfo.Size = new System.Drawing.Size(44, 17);
            this.ChxProductInfo.TabIndex = 19;
            this.ChxProductInfo.Text = "Info";
            this.ChxProductInfo.UseVisualStyleBackColor = true;
            this.ChxProductInfo.CheckedChanged += new System.EventHandler(this.ChxProductInfo_CheckedChanged);
            // 
            // TxtFilterProductInfo
            // 
            this.TxtFilterProductInfo.Location = new System.Drawing.Point(87, 22);
            this.TxtFilterProductInfo.Name = "TxtFilterProductInfo";
            this.TxtFilterProductInfo.Size = new System.Drawing.Size(83, 20);
            this.TxtFilterProductInfo.TabIndex = 18;
            this.TxtFilterProductInfo.Visible = false;
            // 
            // TxtFilterProductName
            // 
            this.TxtFilterProductName.Location = new System.Drawing.Point(2, 22);
            this.TxtFilterProductName.Name = "TxtFilterProductName";
            this.TxtFilterProductName.Size = new System.Drawing.Size(78, 20);
            this.TxtFilterProductName.TabIndex = 17;
            this.TxtFilterProductName.Visible = false;
            // 
            // ChxProductName
            // 
            this.ChxProductName.AutoSize = true;
            this.ChxProductName.Location = new System.Drawing.Point(4, 3);
            this.ChxProductName.Name = "ChxProductName";
            this.ChxProductName.Size = new System.Drawing.Size(54, 17);
            this.ChxProductName.TabIndex = 16;
            this.ChxProductName.Text = "Name";
            this.ChxProductName.UseVisualStyleBackColor = true;
            this.ChxProductName.CheckedChanged += new System.EventHandler(this.ChxProductName_CheckedChanged);
            // 
            // LbResetProducts
            // 
            this.LbResetProducts.AutoSize = true;
            this.LbResetProducts.Location = new System.Drawing.Point(1, 59);
            this.LbResetProducts.Name = "LbResetProducts";
            this.LbResetProducts.Size = new System.Drawing.Size(35, 13);
            this.LbResetProducts.TabIndex = 15;
            this.LbResetProducts.Text = "Reset";
            // 
            // ListProducts
            // 
            this.ListProducts.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListProducts.FormattingEnabled = true;
            this.ListProducts.HorizontalScrollbar = true;
            this.ListProducts.Location = new System.Drawing.Point(0, 82);
            this.ListProducts.Name = "ListProducts";
            this.ListProducts.Size = new System.Drawing.Size(296, 264);
            this.ListProducts.TabIndex = 1;
            this.ListProducts.SelectedIndexChanged += new System.EventHandler(this.ListProducts_SelectedIndexChanged);
            // 
            // TbLog
            // 
            this.TbLog.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.TbLog.Controls.Add(this.TpOrders);
            this.TbLog.Controls.Add(this.TpProducts);
            this.TbLog.Controls.Add(this.TpCategories);
            this.TbLog.Controls.Add(this.TpTables);
            this.TbLog.Location = new System.Drawing.Point(568, 43);
            this.TbLog.Name = "TbLog";
            this.TbLog.SelectedIndex = 0;
            this.TbLog.Size = new System.Drawing.Size(304, 387);
            this.TbLog.TabIndex = 7;
            this.TbLog.Selected += new System.Windows.Forms.TabControlEventHandler(this.Tb_Selected);
            // 
            // LbLastSync
            // 
            this.LbLastSync.AutoSize = true;
            this.LbLastSync.Location = new System.Drawing.Point(743, 462);
            this.LbLastSync.Name = "LbLastSync";
            this.LbLastSync.Size = new System.Drawing.Size(57, 13);
            this.LbLastSync.TabIndex = 8;
            this.LbLastSync.Text = "Last Sync:";
            // 
            // TxtLastSync
            // 
            this.TxtLastSync.AutoSize = true;
            this.TxtLastSync.Location = new System.Drawing.Point(806, 462);
            this.TxtLastSync.Name = "TxtLastSync";
            this.TxtLastSync.Size = new System.Drawing.Size(63, 13);
            this.TxtLastSync.TabIndex = 9;
            this.TxtLastSync.Text = "Placeholder";
            // 
            // BtnFeedbackForm
            // 
            this.BtnFeedbackForm.Location = new System.Drawing.Point(642, 457);
            this.BtnFeedbackForm.Name = "BtnFeedbackForm";
            this.BtnFeedbackForm.Size = new System.Drawing.Size(75, 23);
            this.BtnFeedbackForm.TabIndex = 10;
            this.BtnFeedbackForm.Text = "Feedback";
            this.BtnFeedbackForm.UseVisualStyleBackColor = true;
            this.BtnFeedbackForm.Click += new System.EventHandler(this.BtnFeedbackForm_Click);
            // 
            // RefreshOrders
            // 
            this.RefreshOrders.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RefreshOrders.Image = global::RestaurantFormApp.Properties.Resources.refresh;
            this.RefreshOrders.Location = new System.Drawing.Point(41, 55);
            this.RefreshOrders.Name = "RefreshOrders";
            this.RefreshOrders.Size = new System.Drawing.Size(21, 20);
            this.RefreshOrders.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RefreshOrders.TabIndex = 16;
            this.RefreshOrders.TabStop = false;
            this.RefreshOrders.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // RefreshProducts
            // 
            this.RefreshProducts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RefreshProducts.Image = global::RestaurantFormApp.Properties.Resources.refresh;
            this.RefreshProducts.Location = new System.Drawing.Point(42, 56);
            this.RefreshProducts.Name = "RefreshProducts";
            this.RefreshProducts.Size = new System.Drawing.Size(21, 20);
            this.RefreshProducts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RefreshProducts.TabIndex = 14;
            this.RefreshProducts.TabStop = false;
            this.RefreshProducts.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // RefreshCategories
            // 
            this.RefreshCategories.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RefreshCategories.Image = global::RestaurantFormApp.Properties.Resources.refresh;
            this.RefreshCategories.Location = new System.Drawing.Point(38, 56);
            this.RefreshCategories.Name = "RefreshCategories";
            this.RefreshCategories.Size = new System.Drawing.Size(21, 20);
            this.RefreshCategories.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RefreshCategories.TabIndex = 12;
            this.RefreshCategories.TabStop = false;
            this.RefreshCategories.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // RefreshTables
            // 
            this.RefreshTables.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RefreshTables.Image = global::RestaurantFormApp.Properties.Resources.refresh;
            this.RefreshTables.Location = new System.Drawing.Point(42, 55);
            this.RefreshTables.Name = "RefreshTables";
            this.RefreshTables.Size = new System.Drawing.Size(21, 20);
            this.RefreshTables.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RefreshTables.TabIndex = 9;
            this.RefreshTables.TabStop = false;
            this.RefreshTables.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // PbBorderAdd
            // 
            this.PbBorderAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PbBorderAdd.Image = global::RestaurantFormApp.Properties.Resources.border;
            this.PbBorderAdd.Location = new System.Drawing.Point(-14, -19);
            this.PbBorderAdd.Name = "PbBorderAdd";
            this.PbBorderAdd.Size = new System.Drawing.Size(495, 489);
            this.PbBorderAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbBorderAdd.TabIndex = 3;
            this.PbBorderAdd.TabStop = false;
            // 
            // PbLog
            // 
            this.PbLog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PbLog.Image = global::RestaurantFormApp.Properties.Resources.border;
            this.PbLog.Location = new System.Drawing.Point(476, -19);
            this.PbLog.Name = "PbLog";
            this.PbLog.Size = new System.Drawing.Size(475, 489);
            this.PbLog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbLog.TabIndex = 6;
            this.PbLog.TabStop = false;
            // 
            // RestaurantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 484);
            this.Controls.Add(this.BtnFeedbackForm);
            this.Controls.Add(this.TxtLastSync);
            this.Controls.Add(this.LbLastSync);
            this.Controls.Add(this.TbLog);
            this.Controls.Add(this.LblLog);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbAdd);
            this.Controls.Add(this.PbBorderAdd);
            this.Controls.Add(this.PbLog);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RestaurantForm";
            this.Text = "Restaurant";
            this.TbAdd.ResumeLayout(false);
            this.AddOrder.ResumeLayout(false);
            this.AddOrder.PerformLayout();
            this.AddProduct.ResumeLayout(false);
            this.AddProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumProductWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumProductTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumProductPrice)).EndInit();
            this.AddCategory.ResumeLayout(false);
            this.AddCategory.PerformLayout();
            this.AddTable.ResumeLayout(false);
            this.AddTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumSeats)).EndInit();
            this.TpOrders.ResumeLayout(false);
            this.TpOrders.PerformLayout();
            this.TpTables.ResumeLayout(false);
            this.TpTables.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumFilterSeats)).EndInit();
            this.TpCategories.ResumeLayout(false);
            this.TpCategories.PerformLayout();
            this.TpProducts.ResumeLayout(false);
            this.TpProducts.PerformLayout();
            this.TbLog.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RefreshOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RefreshProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RefreshCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RefreshTables)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbBorderAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbLog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl TbAdd;
        private System.Windows.Forms.TabPage AddProduct;
        private System.Windows.Forms.PictureBox PbBorderAdd;
        private System.Windows.Forms.TabPage AddCategory;
        private System.Windows.Forms.TabPage AddTable;
        private System.Windows.Forms.TabPage AddOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LbSeats;
        private System.Windows.Forms.Label LbOcuppied;
        private System.Windows.Forms.Label LbReserved;
        private System.Windows.Forms.CheckBox ChxOcuppied;
        private System.Windows.Forms.CheckBox ChxReserved;
        private System.Windows.Forms.NumericUpDown NumSeats;
        private System.Windows.Forms.Button BtAddTable;
        private System.Windows.Forms.Label LbTableMessage;
        private System.Windows.Forms.Label LblLog;
        private System.Windows.Forms.PictureBox PbLog;
        private System.Windows.Forms.TabPage TpOrders;
        private System.Windows.Forms.TabPage TpTables;
        private System.Windows.Forms.TabPage TpCategories;
        private System.Windows.Forms.TabPage TpProducts;
        private System.Windows.Forms.TabControl TbLog;
        private System.Windows.Forms.PictureBox RefreshTables;
        private System.Windows.Forms.CheckBox ChxFilterOcuppied;
        private System.Windows.Forms.Button BtnFilterTables;
        private System.Windows.Forms.NumericUpDown NumFilterSeats;
        private System.Windows.Forms.Label LbResetTables;
        private System.Windows.Forms.CheckBox ChxFilterSeats;
        private System.Windows.Forms.CheckBox ChxFilterReserved;
        private System.Windows.Forms.CheckBox ChxFilterStatusTables;
        private System.Windows.Forms.Label LbCategoryMessage;
        private System.Windows.Forms.Button BtnAddCategory;
        private System.Windows.Forms.RichTextBox TxtCategoryInfo;
        private System.Windows.Forms.TextBox TxtCategoryName;
        private System.Windows.Forms.Label LbCategoryInfo;
        private System.Windows.Forms.Label LbCategoryName;
        private System.Windows.Forms.Label ErrCategoryName;
        private System.Windows.Forms.Label ErrCategoryInfo;
        private System.Windows.Forms.ListBox ListTables;
        private System.Windows.Forms.Button BtnUpdateTable;
        private System.Windows.Forms.Button BtnDeleteTable;
        private System.Windows.Forms.ListBox ListCategories;
        private System.Windows.Forms.Button BtnDeleteCategory;
        private System.Windows.Forms.Button BtnUpdateCategory;
        private System.Windows.Forms.Label LbResetCategories;
        private System.Windows.Forms.PictureBox RefreshCategories;
        private System.Windows.Forms.CheckBox ChxCategoryInfo;
        private System.Windows.Forms.CheckBox ChxCategoryName;
        private System.Windows.Forms.Button BtnFilterCategories;
        private System.Windows.Forms.TextBox TxtFilterCategoryInfo;
        private System.Windows.Forms.TextBox TxtFilterCategoryName;
        private System.Windows.Forms.Label LbProductTime;
        private System.Windows.Forms.Label LbProductWeight;
        private System.Windows.Forms.Label LbProductPrice;
        private System.Windows.Forms.Label LbProductCategory;
        private System.Windows.Forms.Label LbProductInfo;
        private System.Windows.Forms.Label LbProductName;
        private System.Windows.Forms.NumericUpDown NumProductPrice;
        private System.Windows.Forms.RichTextBox TxtProductInfo;
        private System.Windows.Forms.TextBox TxtProductName;
        private System.Windows.Forms.NumericUpDown NumProductWeight;
        private System.Windows.Forms.NumericUpDown NumProductTime;
        private System.Windows.Forms.ComboBox ComboProductCategory;
        private System.Windows.Forms.Label LbProductMessage;
        private System.Windows.Forms.Button BtnDeleteProduct;
        private System.Windows.Forms.Button BtnUpdateProduct;
        private System.Windows.Forms.Button BtnAddProduct;
        private System.Windows.Forms.Label ErrProductWeight;
        private System.Windows.Forms.Label ErrProductTime;
        private System.Windows.Forms.Label ErrProductPrice;
        private System.Windows.Forms.Label ErrProductCategory;
        private System.Windows.Forms.Label ErrProductInfo;
        private System.Windows.Forms.Label ErrProductName;
        private System.Windows.Forms.Label LbResetProducts;
        private System.Windows.Forms.PictureBox RefreshProducts;
        private System.Windows.Forms.ListBox ListProducts;
        private System.Windows.Forms.CheckBox ChxProductName;
        private System.Windows.Forms.ComboBox ComboFilterProductCategory;
        private System.Windows.Forms.CheckBox ChxProductCategory;
        private System.Windows.Forms.CheckBox ChxProductInfo;
        private System.Windows.Forms.TextBox TxtFilterProductInfo;
        private System.Windows.Forms.TextBox TxtFilterProductName;
        private System.Windows.Forms.Button BtnFilterProducts;
        private System.Windows.Forms.Label ErrOrderClient;
        private System.Windows.Forms.Label LbOrderClient;
        private System.Windows.Forms.TextBox TxtOrderClient;
        private System.Windows.Forms.Label ErrOrderInfo;
        private System.Windows.Forms.RichTextBox TxtOrderInfo;
        private System.Windows.Forms.Label LbOrderInfo;
        private System.Windows.Forms.Label ErrOrderDiscount;
        private System.Windows.Forms.ComboBox ComboOrderDiscount;
        private System.Windows.Forms.Label LbOrderDiscount;
        private System.Windows.Forms.Label ErrOrderStatus;
        private System.Windows.Forms.ComboBox ComboOrderStatus;
        private System.Windows.Forms.Label LbOrderStatus;
        private System.Windows.Forms.Label LbOrderTable;
        private System.Windows.Forms.Label ErrOrderTable;
        private System.Windows.Forms.ComboBox ComboOrderTable;
        private System.Windows.Forms.Label LbOrderProducts;
        private System.Windows.Forms.CheckedListBox ComboOrderProducts;
        private System.Windows.Forms.Button BtnAddOrder;
        private System.Windows.Forms.Label LbOrderMessage;
        private System.Windows.Forms.Label ErrOrderProducts;
        private System.Windows.Forms.ListBox ListOrders;
        private System.Windows.Forms.TextBox TxtFilterOrderClient;
        private System.Windows.Forms.CheckBox ChxFilterOrderClient;
        private System.Windows.Forms.Button BtnFilterOrders;
        private System.Windows.Forms.Label LbResetOrders;
        private System.Windows.Forms.PictureBox RefreshOrders;
        private System.Windows.Forms.CheckBox ChxFilterOrderStatus;
        private System.Windows.Forms.ComboBox ComboFilterOrderStatus;
        private System.Windows.Forms.Button BtnDeleteOrder;
        private System.Windows.Forms.Button BtnUpdateOrder;
        private System.Windows.Forms.Label LbLastSync;
        private System.Windows.Forms.Label TxtLastSync;
        private System.Windows.Forms.Button BtnFeedbackForm;
    }
}

