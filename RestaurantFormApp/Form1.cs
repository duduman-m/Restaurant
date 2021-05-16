using DataAccess;
using RestaurantObjects;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace RestaurantFormApp
{
    public partial class RestaurantForm : Form
    {
        //Constants

        const int CATEGORY_NAME_LIMIT = 25;
        const int INFO_LIMIT = 100;
        const int PRODUCT_NAME_LIMIT = 50;
        const int PRODUCT_PRICE_LOWER_LIMIT = 1;
        const int PRODUCT_PRICE_UPPER_LIMIT = 250;
        const int PRODUCT_WEIGHT_LOWER_LIMIT = 1;
        const int PRODUCT_WEIGHT_UPPER_LIMIT = 1000;
        const int PRODUCT_TIME_LOWER_LIMIT = 1;
        const int PRODUCT_TIME_UPPER_LIMIT = 60;
        const int ORDER_CLIENT_UPPER_LIMIT = 50;
        const int ORDER_CLIENT_LOWER_LIMIT = 0;
        const int ORDER_INFO_UPPER_LIMIT = 100;
        const int ORDER_INFO_LOWER_LIMIT = 0;

        //Admins

        IDataAccessProducts adminProducts = ProductDataFactory.GetProductsDataAccess();
        IDataAccessCategories adminCategories = CategoryDataFactory.GetCategoriesDataAccess();
        IDataAccessTables adminTables = TableDataFactory.GetTablesDataAccess();
        IDataAccessOrders adminOrders = OrderDataFactory.GetOrdersDataAccess();

        //Timer

        Timer timer = new Timer();

        //Constructor

        public RestaurantForm()
        {
            InitializeComponent();
            HideMessages();
            PopulateCategoriesLog(false);
            PopulateTablesLog(false);
            PopulateProductsLog(false);
            PopulateOrdersLog(false);
            ComboOrderStatus.Items.Clear();
            foreach (string s in Enum.GetNames(typeof(Status)))
            {
                ComboOrderStatus.Items.Add(s);
                ComboFilterOrderStatus.Items.Add(s);
            }
            ComboOrderDiscount.Items.Clear();
            foreach (string s in Enum.GetNames(typeof(Discount)))
            {
                ComboOrderDiscount.Items.Add(s);
            }
            ComboOrderDiscount.SelectedItem = "None";
        }

        //Timer methods

        private void StartTimer(string _case)
        {
            switch (_case)
            {
                case "messages":
                    timer.Interval = 10000;
                    timer.Tick += new EventHandler(Timer_Messages);
                    break;
                case "refresh":
                    timer.Interval = 1000;
                    timer.Tick += new EventHandler(Timer_Refresh);
                    break;
            }
            timer.Start();
        }

        private void Timer_Messages(object sender, EventArgs e)
        {
            HideMessages();
        }

        private void Timer_Refresh(object sender, EventArgs e)
        {
            foreach (PictureBox p in TbLog.SelectedTab.Controls.OfType<PictureBox>().Where(p => p.Name.Contains("Refresh")))
            {
                p.BorderStyle = BorderStyle.FixedSingle;
            }
        }

        //Controls Reset and Hide

        private void HideMessages()
        {
            foreach (TabPage t in TbAdd.TabPages)
            {
                foreach (Label l in t.Controls.OfType<Label>().Where(l => l.Name.Contains("Message")))
                {
                    l.Hide();
                }
            }
        }

        private void HideErrors()
        {
            foreach (Label l in TbAdd.SelectedTab.Controls.OfType<Label>())
            {
                if (!l.Name.Contains("Err"))
                {
                    l.ForeColor = Color.Black;
                }
                else
                {
                    l.Hide();
                }
            }
        }

        public void ResetControls()
        {
            foreach (CheckBox c in TbAdd.SelectedTab.Controls.OfType<CheckBox>())
            {
                c.Checked = false;
            }

            foreach (NumericUpDown n in TbAdd.SelectedTab.Controls.OfType<NumericUpDown>())
            {
                n.Value = n.Minimum;
            }

            foreach (TextBox t in TbAdd.SelectedTab.Controls.OfType<TextBox>())
            {
                t.Text = String.Empty;
            }

            foreach (RichTextBox t in TbAdd.SelectedTab.Controls.OfType<RichTextBox>())
            {
                t.Text = String.Empty;
            }

            foreach (Button b in TbAdd.SelectedTab.Controls.OfType<Button>().Where(b => !b.Name.Contains("Add")))
            {
                b.Hide();
            }

            foreach (ComboBox cb in TbAdd.SelectedTab.Controls.OfType<ComboBox>())
            {
                cb.SelectedItem = null;
            }

            foreach (CheckedListBox chx in TbAdd.SelectedTab.Controls.OfType<CheckedListBox>())
            {
                foreach (int i in chx.CheckedIndices)
                {
                    chx.SetItemCheckState(i, CheckState.Unchecked);
                }
            }
        }

        public void SetError(string _case, string _message)
        {
            switch (_case)
            {
                //Category Errors
                case "Category-Name":
                    ErrCategoryName.Text = _message;
                    ErrCategoryName.Show();
                    LbCategoryName.ForeColor = Color.Red;
                    break;
                case "Category-Info":
                    ErrCategoryInfo.Text = _message;
                    ErrCategoryInfo.Show();
                    LbCategoryInfo.ForeColor = Color.Red;
                    break;

                //Product Errors
                case "Product-Name":
                    ErrProductName.Text = _message;
                    ErrProductName.Show();
                    LbProductName.ForeColor = Color.Red;
                    break;
                case "Product-Info":
                    ErrProductInfo.Text = _message;
                    ErrProductInfo.Show();
                    LbProductInfo.ForeColor = Color.Red;
                    break;
                case "Product-Category":
                    ErrProductCategory.Text = _message;
                    ErrProductCategory.Show();
                    LbProductCategory.ForeColor = Color.Red;
                    break;
                case "Product-Price":
                    ErrProductPrice.Text = _message;
                    ErrProductPrice.Show();
                    LbProductPrice.ForeColor = Color.Red;
                    break;
                case "Product-Weight":
                    ErrProductWeight.Text = _message;
                    ErrProductWeight.Show();
                    LbProductWeight.ForeColor = Color.Red;
                    break;
                case "Product-Time":
                    ErrProductTime.Text = _message;
                    ErrProductTime.Show();
                    LbProductTime.ForeColor = Color.Red;
                    break;

                //Order Errors
                case "Order-Client":
                    ErrOrderClient.Text = _message;
                    ErrOrderClient.Show();
                    LbOrderClient.ForeColor = Color.Red;
                    break;
                case "Order-Info":
                    ErrOrderInfo.Text = _message;
                    ErrOrderInfo.Show();
                    LbOrderInfo.ForeColor = Color.Red;
                    break;
                case "Order-Status":
                    ErrOrderStatus.Text = _message;
                    ErrOrderStatus.Show();
                    LbOrderStatus.ForeColor = Color.Red;
                    break;
                case "Order-Discount":
                    ErrOrderDiscount.Text = _message;
                    ErrOrderDiscount.Show();
                    LbOrderDiscount.ForeColor = Color.Red;
                    break;
                case "Order-Table":
                    ErrOrderTable.Text = _message;
                    ErrOrderTable.Show();
                    LbOrderTable.ForeColor = Color.Red;
                    break;
                case "Order-Products":
                    ErrOrderProducts.Text = _message;
                    ErrOrderProducts.Show();
                    LbOrderProducts.ForeColor = Color.Red;
                    break;
            }
        }

        //Validations

        public bool ValidateFieldsCategory(string initial="")
        {
            bool _clean = true;
            string _name = TxtCategoryName.Text.Trim();
            string _info = TxtCategoryInfo.Text.Trim();
            if (_name == "")
            {
                SetError("Category-Name", "Name field is required");
                _clean = false;
            }
            else
            {
                if (_name.Length > CATEGORY_NAME_LIMIT)
                {
                    SetError("Category-Name", $"Name field has a length of maximum {CATEGORY_NAME_LIMIT}");
                    _clean = false;
                }
                if (adminCategories.SearchByNameC(_name) != null && !(_name.Equals(initial)))
                {
                    SetError("Category-Name", "Category with this name already exists");
                    _clean = false;
                }
            }
            if (_info == "")
            {
                SetError("Category-Info", "Info field is required");
                _clean = false;
            }
            else
            {
                if (_info.Length > INFO_LIMIT)
                {
                    SetError("Category-Info", $"Info field has a length of maximum {INFO_LIMIT}");
                    _clean = false;
                }
            }
            return _clean;
        }

        public bool ValidateFieldsProduct(string initial="")
        {
            bool _clean = true;

            string _name = TxtProductName.Text.Trim();
            string _info = TxtProductInfo.Text.Trim();
            string _category = string.Empty;
            if (ComboProductCategory.SelectedItem != null)
            {
                _category = ComboProductCategory.SelectedItem.ToString();
            }
            float _price = (float)NumProductPrice.Value;
            float _weight = (float)NumProductWeight.Value;
            float _time = (float)NumProductTime.Value;

            if (_name == "")
            {
                SetError("Product-Name", "Name field is required");
                _clean = false;
            }
            else
            {
                if (_name.Length > PRODUCT_NAME_LIMIT)
                {
                    SetError("Product-Name", $"Name field has a length of maximum {PRODUCT_NAME_LIMIT}");
                    _clean = false;
                }
                if (adminProducts.SearchByNameP(_name) != null && !(_name.Equals(initial)))
                {
                    SetError("Product-Name", "Product with this name already exists");
                    _clean = false;
                }
            }

            if (_info == "")
            {
                SetError("Product-Info", "Info field is required");
                _clean = false;
            }
            else
            {
                if (_info.Length > INFO_LIMIT)
                {
                    SetError("Product-Info", $"Info field has a length of maximum {INFO_LIMIT}");
                    _clean = false;
                }
            }

            if (_category == "")
            {
                SetError("Product-Category", "Category is required");
                _clean = false;
            }
            else
            {
                if (adminCategories.SearchByNameC(_category) == null)
                {
                    SetError("Product-Category", "Selected category does not exist");
                    _clean = false;
                }
            }

            if (_price < PRODUCT_PRICE_LOWER_LIMIT)
            {
                SetError("Product-Price", $"Price lower limit is {PRODUCT_PRICE_LOWER_LIMIT}");
                _clean = false;
            }
            else
            {
                if (_price > PRODUCT_PRICE_UPPER_LIMIT)
                {
                    SetError("Product-Price", $"Price upper limit is {PRODUCT_PRICE_UPPER_LIMIT}");
                    _clean = false;
                }
            }

            if (_weight < PRODUCT_WEIGHT_LOWER_LIMIT)
            {
                SetError("Product-Weight", $"Price weight limit is {PRODUCT_WEIGHT_LOWER_LIMIT}");
                _clean = false;
            }
            else
            {
                if (_weight > PRODUCT_WEIGHT_UPPER_LIMIT)
                {
                    SetError("Product-Weight", $"Price weight limit is {PRODUCT_WEIGHT_UPPER_LIMIT}");
                    _clean = false;
                }
            }

            if (_time < PRODUCT_TIME_LOWER_LIMIT)
            {
                SetError("Product-Time", $"Price time limit is {PRODUCT_TIME_LOWER_LIMIT}");
                _clean = false;
            }
            else
            {
                if (_time > PRODUCT_WEIGHT_UPPER_LIMIT)
                {
                    SetError("Product-Time", $"Price time limit is {PRODUCT_TIME_UPPER_LIMIT}");
                    _clean = false;
                }
            }

            return _clean;
        }

        public bool ValidateFieldsOrder(string initial="")
        {
            bool _clean = true;

            string _client = TxtOrderClient.Text.Trim();
            string _info = TxtOrderInfo.Text.Trim();
            string _status = "";
            if (ComboOrderStatus.SelectedItem != null)
            {
                _status = ComboOrderStatus.SelectedItem.ToString();
            }
            string _discount = "";
            if (ComboOrderDiscount.SelectedItem != null)
            {
                _discount = ComboOrderDiscount.SelectedItem.ToString();
            }
            string _table = "";
            if (ComboOrderTable.SelectedItem != null)
            {
                _table = ComboOrderTable.SelectedItem.ToString();
            }

            if (_client == "")
            {
                SetError("Order-Client", "Client is required");
                _clean = false;
            }
            else
            {
                if (_client.Length > ORDER_CLIENT_UPPER_LIMIT)
                {
                    SetError("Order-Client", $"Client upper limit is {ORDER_CLIENT_UPPER_LIMIT}");
                    _clean = false;
                }
                if (_client.Length < ORDER_CLIENT_LOWER_LIMIT)
                {
                    SetError("Order-Client", $"Client lower limit is {ORDER_CLIENT_LOWER_LIMIT}");
                    _clean = false;
                }
            }

            if (_info.Length > ORDER_INFO_UPPER_LIMIT)
            {
                SetError("Order-Info", $"Info upper limit is {ORDER_INFO_UPPER_LIMIT}");
                _clean = false;
            }
            if (_info.Length < ORDER_INFO_LOWER_LIMIT)
            {
                SetError("Order-Info", $"Info lower limit is {ORDER_INFO_LOWER_LIMIT}");
                _clean = false;
            }

            if (_status == "")
            {
                SetError("Order-Status", "Status is required");
                _clean = false;
            }

            if (_discount == "")
            {
                SetError("Order-Discount", "Discount is required");
                _clean = false;
            }

            if (_table == "")
            {
                SetError("Order-Table", "Table is required");
                _clean = false;
            }
            else
            {
                if (initial == "")
                {
                    Table t = adminTables.GetTable(int.Parse(_table));
                    if (t.occupied || t.reserved)
                    {
                        SetError("Order-Table", "Table is used right now");
                        _clean = false;
                    }
                }
            }

            if (ComboOrderProducts.CheckedItems.Count < 1)
            {
                SetError("Order-Products", "Select at least one product");
                _clean = false;
            }

            return _clean;
        }

        //Table buttons

        private void BtAddTable_Click(object sender, System.EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            string _reserved = ChxReserved.Checked ? "yes" : "no";
            string _occupied = ChxOcuppied.Checked ? "yes" : "no";
            string _seats = NumSeats.Value.ToString();
            Table _table = new Table($"{_seats};{_occupied};{_reserved}");
            adminTables.AddTable(_table);
            ResetControls();
            StartTimer("messages");
            LbTableMessage.Text = "Table was added";
            LbTableMessage.BackColor = Color.LightGreen;
            LbTableMessage.Show();
            PopulateTablesLog(false);
            Cursor.Current = Cursors.Default;
        }

        private void BtnUpdateTable_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            int _number = -1;
            if (ListTables.SelectedItem != null)
            {
                _number = int.Parse(ListTables.SelectedItem.ToString().Split(' ').First());
            }
            Table t = adminTables.GetTable(_number);
            if (t != null)
            {
                if (Log.AllOrders.Find(o => o.CheckTable(t) && o.status != Status.Done) == null)
                {
                    t.SetFields((int)NumSeats.Value, ChxOcuppied.Checked, ChxReserved.Checked);
                    adminTables.UpdateTable(t);
                    ResetControls();
                    LbTableMessage.Text = "Table was updated";
                    LbTableMessage.BackColor = Color.CadetBlue;
                }
                else
                {
                    LbTableMessage.Text = "Table is in use right now";
                    LbTableMessage.BackColor = Color.IndianRed;
                }
                StartTimer("messages");
                LbTableMessage.Show();
                PopulateTablesLog(true);
            }
            Cursor.Current = Cursors.Default;
        }

        private void BtnDeleteTable_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            int _number = -1;
            if (ListTables.SelectedItem != null)
            {
                _number = int.Parse(ListTables.SelectedItem.ToString().Split(' ').First());
            }
            Table t = adminTables.GetTable(_number);
            if (t != null)
            {
                if (Log.AllOrders.Find(o => o.CheckTable(t) && o.status != Status.Done) == null)
                {
                    adminTables.DeleteTable(t);
                    ResetControls();
                    LbTableMessage.Text = "Table was removed";
                    LbTableMessage.BackColor = Color.IndianRed;
                }
                else
                {
                    LbTableMessage.Text = "Table is in use right now";
                    LbTableMessage.BackColor = Color.IndianRed;
                }
                StartTimer("messages");
                LbTableMessage.Show();
                PopulateTablesLog(true);
            }
            Cursor.Current = Cursors.Default;
        }

        //Category buttons

        private void BtnAddCategory_Click(object sender, EventArgs e)
        {
            HideErrors();
            if (ValidateFieldsCategory())
            {
                Cursor.Current = Cursors.WaitCursor;
                Category _category = new Category($"{TxtCategoryName.Text.Trim()};{0};{TxtCategoryInfo.Text.Trim()}");
                adminCategories.AddCategory(_category);
                ResetControls();
                StartTimer("messages");
                LbCategoryMessage.Text = "Category was added";
                LbCategoryMessage.BackColor = Color.LightGreen;
                LbCategoryMessage.Show();
                PopulateCategoriesLog(false);
                Cursor.Current = Cursors.Default;
            }
        }

        private void BtnUpdateCategory_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            int _number = -1;
            if (ListCategories.SelectedItem != null)
            {
                _number = int.Parse(ListCategories.SelectedItem.ToString().Split(' ').First());
            }
            Category c = adminCategories.GetCategory(_number);
            HideErrors();
            if (c != null)
            {
                if (ValidateFieldsCategory(c.name))
                {
                    c.SetFields(TxtCategoryName.Text.Trim(), TxtCategoryInfo.Text.Trim());
                    adminCategories.UpdateCategory(c);
                    ResetControls();
                    StartTimer("messages");
                    LbCategoryMessage.Text = "Category was updated";
                    LbCategoryMessage.BackColor = Color.CadetBlue;
                    LbCategoryMessage.Show();
                    PopulateCategoriesLog(true);
                }
            }
            Cursor.Current = Cursors.Default;
        }

        private void BtnDeleteCategory_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            int _number = -1;
            if (ListCategories.SelectedItem != null)
            {
                _number = int.Parse(ListCategories.SelectedItem.ToString().Split(' ').First());
            }
            Category c = adminCategories.GetCategory(_number);
            if (c != null)
            {
                if (c.products_number > 0)
                {
                    LbCategoryMessage.Text = "Category can't be deleted\nbecause it has products";
                }
                else
                {
                    adminCategories.DeleteCategory(c);
                    LbCategoryMessage.Text = "Category was deleted";
                    ResetControls();
                    PopulateCategoriesLog(true);
                    StartTimer("messages");
                    LbCategoryMessage.BackColor = Color.IndianRed;
                    LbCategoryMessage.Show();
                }
            }
            Cursor.Current = Cursors.Default;
        }

        //Product buttons

        private void BtnAddProduct_Click(object sender, EventArgs e)
        {
            HideErrors();
            if (ValidateFieldsProduct())
            {
                Cursor.Current = Cursors.WaitCursor;
                Product _product = new Product($"{TxtProductName.Text.Trim()};{TxtProductInfo.Text.Trim()};{(float)NumProductPrice.Value};{(float)NumProductWeight.Value};{(float)NumProductTime.Value};{ComboProductCategory.SelectedItem}");
                adminProducts.AddProduct(_product);
                ResetControls();
                StartTimer("messages");
                LbProductMessage.Text = "Product was added";
                LbProductMessage.BackColor = Color.LightGreen;
                LbProductMessage.Show();
                PopulateCategoriesLog(false);
                PopulateProductsLog(false);
                Cursor.Current = Cursors.Default;
            }
        }

        private void BtnUpdateProduct_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            int _number = -1;
            if (ListProducts.SelectedItem != null)
            {
                _number = int.Parse(ListProducts.SelectedItem.ToString().Split(' ').First());
            }
            Product p = adminProducts.GetProduct(_number);
            HideErrors();
            if (p != null)
            {
                if (ValidateFieldsProduct(p.name))
                {
                    Category c = adminCategories.SearchByNameC(ComboProductCategory.SelectedItem.ToString());
                    p.SetFields(TxtProductName.Text.Trim(), TxtProductInfo.Text.Trim(), c, (float)NumProductPrice.Value, (float)NumProductWeight.Value, (float)NumProductTime.Value);
                    adminProducts.UpdateProduct(p);
                    ResetControls();
                    StartTimer("messages");
                    LbProductMessage.Text = "Product was updated";
                    LbProductMessage.BackColor = Color.CadetBlue;
                    LbProductMessage.Show();
                    PopulateProductsLog(true);
                }
            }
            Cursor.Current = Cursors.Default;
        }

        private void BtnDeleteProduct_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            int _number = -1;
            if (ListProducts.SelectedItem != null)
            {
                _number = int.Parse(ListProducts.SelectedItem.ToString().Split(' ').First());
            }
            Product p = adminProducts.GetProduct(_number);
            if (p != null)
            {
                if (Log.AllOrders.Exists(o => o.CheckProduct(p) && o.status != Status.Done))
                {
                    LbProductMessage.Text = "You can't delete this product\nThere are orders using it";
                }
                else
                {
                    //ResetControls();
                    adminProducts.DeleteProduct(p);
                    LbProductMessage.Text = "Product was deleted";
                }
                
                PopulateProductsLog(true);
                StartTimer("messages");
                LbProductMessage.BackColor = Color.IndianRed;
                LbProductMessage.Show();
            }
            Cursor.Current = Cursors.Default;
        }

        //Order buttons

        private void BtnAddOrder_Click(object sender, EventArgs e)
        {
            HideErrors();
            if (ValidateFieldsOrder())
            {
                Cursor.Current = Cursors.WaitCursor;
                List<string> products = new List<string>();
                float _price =0, _time = 0;
                foreach (string item in ComboOrderProducts.CheckedItems)
                {
                    Product p = adminProducts.SearchByNameP(item);
                    products.Add(p.number.ToString());
                    _price += p.price;
                    _time += p.time_to_prepare;
                }
                string product_string = string.Join(",", products);

                Order o = new Order($"{TxtOrderClient.Text.Trim()};{TxtOrderInfo.Text.Trim()};{_price};{_time};{(int)Enum.Parse(typeof(Status), ComboOrderStatus.Text.Trim())};{(int)ComboOrderTable.SelectedItem};{product_string};{(int)Enum.Parse(typeof(Discount), ComboOrderDiscount.Text.Trim())}");
                adminOrders.AddOrder(o);
                Table t = adminTables.GetTable((int)ComboOrderTable.SelectedItem);
                t.SetAsOcupied();
                adminTables.UpdateTable(t);
                ResetControls();
                StartTimer("messages");
                LbOrderMessage.Text = "Order was added";
                LbOrderMessage.BackColor = Color.LightGreen;
                LbOrderMessage.Show();
                PopulateTablesLog(true);
                PopulateOrdersLog();
                Cursor.Current = Cursors.Default;
            }
        }

        private void BtnUpdateOrder_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            int _number = -1;
            if (ListOrders.SelectedItem != null)
            {
                _number = int.Parse(ListOrders.SelectedItem.ToString().Split(' ').First());
            }
            Order o = adminOrders.GetOrder(_number);
            HideErrors();
            if (o != null)
            {
                if (ValidateFieldsOrder(o.GetTableNumber().ToString()))
                {
                    Table t = adminTables.GetTable(int.Parse(ComboOrderTable.SelectedItem.ToString()));
                    if (!o.CheckTable(t))
                    {
                        Table order_table = adminTables.GetTable(o.GetTableNumber());
                        order_table.SetAsNotOcupied();
                        order_table.SetAsNotReserved();
                        adminTables.UpdateTable(order_table);
                        t.SetAsOcupied();
                        adminTables.UpdateTable(t);
                    }
                    List<string> products = new List<string>();
                    foreach (string item in ComboOrderProducts.CheckedItems)
                    {
                        Product p = adminProducts.SearchByNameP(item);
                        products.Add(p.number.ToString());
                    }
                    string product_string = string.Join(",", products);
                    o.SetFields(TxtOrderClient.Text.Trim(), TxtOrderInfo.Text.Trim(), ComboOrderStatus.SelectedItem.ToString(), ComboOrderDiscount.SelectedItem.ToString(), t, product_string);
                    adminOrders.UpdateOrder(o);
                    ResetControls();
                    StartTimer("messages");
                    LbOrderMessage.Text = "Order was updated";
                    LbOrderMessage.BackColor = Color.CadetBlue;
                    LbOrderMessage.Show();
                    PopulateTablesLog(true);
                    PopulateOrdersLog(true);
                }
            }
            Cursor.Current = Cursors.Default;
        }

        private void BtnDeleteOrder_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            int _number = -1;
            if (ListOrders.SelectedItem != null)
            {
                _number = int.Parse(ListOrders.SelectedItem.ToString().Split(' ').First());
            }

            Order o = adminOrders.GetOrder(_number);
            if (o != null)
            {
                Table t = adminTables.GetTable(o.GetTableNumber());
                adminOrders.DeleteOrder(o);
                t.SetAsNotOcupied();
                t.SetAsNotReserved();
                adminTables.UpdateTable(t);
                ResetControls();
                PopulateOrdersLog(true);
                StartTimer("messages");
                LbOrderMessage.Text = "Order was deleted";
                LbOrderMessage.BackColor = Color.IndianRed;
                LbOrderMessage.Show();
            }
            Cursor.Current = Cursors.Default;
        }

        //Log Populations

        private void PopulateTablesLog(bool filter=true)
        {
            Log.AllTables.Clear();
            Log.AllTables = adminTables.GetTables();
            ListTables.Items.Clear();
            ListTables.Items.Add($"{"Number",-10}{"Seats",-10}{"Occupied",-10}{"Reserved",-10}");
            ComboOrderTable.Items.Clear();
            if (filter)
            {
                int _seats = -1;
                if (ChxFilterSeats.Checked)
                {
                    _seats = (int)NumFilterSeats.Value;
                }
                foreach (Table t in adminTables.FilterTables(_seats, ChxFilterOcuppied.Checked, ChxFilterReserved.Checked, ChxFilterStatusTables.Checked))
                {
                    ListTables.Items.Add(t.ConvertToListString());
                    if(!t.occupied && !t.reserved) 
                        ComboOrderTable.Items.Add(t.number);
                }
            }
            else
            {
                foreach (Table t in Log.AllTables)
                {
                    ListTables.Items.Add(t.ConvertToListString());
                    if (!t.occupied && !t.reserved)
                        ComboOrderTable.Items.Add(t.number);
                }
            }    
        }

        private void PopulateCategoriesLog(bool filter = true)
        {
            Log.AllCategories.Clear();
            Log.AllCategories = adminCategories.GetCategories();
            foreach (Category c in Log.AllCategories)
            {
                c.ResetProductsNumber();
                foreach (Product p in Log.AllProducts.Where(p => p.CheckCategory(c)))
                {
                    c.IncreaseProductsNumber();
                }
            }

            int max_name = Log.GetMaxLengthCategoryName();

            ListCategories.Items.Clear();
            ListCategories.Items.Add($"{"Number",-10}{"Name".PadRight(max_name)}{"Number of products",-20}");
            ComboProductCategory.Items.Clear();
            ComboFilterProductCategory.Items.Clear();
            if (filter)
            {
                foreach (Category c in adminCategories.FilterCategories(ChxCategoryName.Checked, ChxCategoryInfo.Checked, TxtFilterCategoryName.Text.Trim(), TxtFilterCategoryInfo.Text.Trim()))
                {
                    ListCategories.Items.Add(c.ConvertToListString(max_name));
                    ComboProductCategory.Items.Add(c.name);
                    ComboFilterProductCategory.Items.Add(c.name);
                }
            }
            else
            {
                foreach (Category c in Log.AllCategories)
                {
                    ListCategories.Items.Add(c.ConvertToListString(max_name));
                    ComboProductCategory.Items.Add(c.name);
                    ComboFilterProductCategory.Items.Add(c.name);
                }
            }
        }

        private void PopulateProductsLog(bool filter = true)
        {
            Log.AllProducts.Clear();
            Log.AllProducts = adminProducts.GetProducts();
            ListProducts.Items.Clear();
            int max_product_name = Log.GetMaxLengthProductName();
            int max_category_name = Log.GetMaxLengthCategoryName();
            ListProducts.Items.Add($"{"Number",-10}{"Name".PadRight(max_product_name)}{"Category".PadRight(max_category_name)}{"Price",-10}{"Weight",-10}{"Time to prepare",-20}");
            ComboOrderProducts.Items.Clear();
            if (filter)
            {
                string _category = string.Empty;
                if (ComboFilterProductCategory.SelectedItem != null)
                {
                    _category = ComboFilterProductCategory.SelectedItem.ToString();
                }
                foreach (Product p in adminProducts.FilterProducts(ChxProductName.Checked, ChxProductInfo.Checked, ChxProductCategory.Checked, TxtFilterProductName.Text.Trim(), TxtFilterProductInfo.Text.Trim(), _category))
                {
                    ListProducts.Items.Add(p.ConvertToListString(max_product_name, max_category_name));
                    ComboOrderProducts.Items.Add(p.name);
                }
            }
            else
            {
                foreach (Product p in Log.AllProducts)
                {
                    ListProducts.Items.Add(p.ConvertToListString(max_product_name, max_category_name));
                    ComboOrderProducts.Items.Add(p.name);
                }
            }
        }

        private void PopulateOrdersLog(bool filter = true)
        {
            Log.AllOrders.Clear();
            Log.AllOrders = adminOrders.GetOrders();
            int max_client = Log.GetMaxLengthOrderClient();
            ListOrders.Items.Clear();
            ListOrders.Items.Add($"{"Number",-10}{"Client".PadRight(max_client)}{"Table",-10}{"Status",-20}{"Price",-10}{"Discount",-20}{"Time to prepare",-20}");
            if (filter)
            {
                string _status = "";
                if (ComboFilterOrderStatus.SelectedItem != null)
                {
                    _status = ComboFilterOrderStatus.SelectedItem.ToString();
                }
                foreach (Order o in adminOrders.FilterOrders(ChxFilterOrderClient.Checked, ChxFilterOrderStatus.Checked, TxtFilterOrderClient.Text.Trim(), _status))
                {
                    ListOrders.Items.Add(o.ConvertToListString(max_client));
                }
            }
            else
            {
                foreach (Order o in Log.AllOrders)
                {
                    ListOrders.Items.Add(o.ConvertToListString(max_client));
                }
            }
        }


        //Other clicks and changes

        private void Tb_Selected(object sender, TabControlEventArgs e)
        {
            var tabcontrol = sender as TabControl;
            if (tabcontrol.Name == "TbLog")
            {
                switch(tabcontrol.SelectedTab.Name)
                {
                    case "TpTables":
                        PopulateTablesLog(false);
                        break;
                    case "TpCategories":
                        PopulateCategoriesLog(false);
                        break;
                    case "TpProducts":
                        PopulateProductsLog(false);
                        break;
                    case "TpOrders":
                        PopulateOrdersLog(false);
                        break;
                }
            }
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            HideErrors();
            var pictureBox = sender as PictureBox;
            if (pictureBox != null)
            {
                switch (pictureBox.Name)
                {
                    case "RefreshTables":
                        PopulateTablesLog(false);
                        ChxFilterSeats.Checked = false;
                        ChxFilterStatusTables.Checked = false;
                        break;
                    case "RefreshCategories":
                        PopulateCategoriesLog(false);
                        ChxCategoryInfo.Checked = false;
                        ChxCategoryName.Checked = false;
                        break;
                    case "RefreshProducts":
                        PopulateProductsLog(false);
                        ChxProductCategory.Checked = false;
                        ChxProductName.Checked = false;
                        ChxCategoryInfo.Checked = false;
                        break;
                    case "RefreshOrders":
                        PopulateOrdersLog(false);
                        ChxFilterOrderClient.Checked = false;
                        ChxFilterOrderStatus.Checked = false;
                        break;
                }
                pictureBox.BorderStyle = BorderStyle.Fixed3D;
                StartTimer("refresh");
            }
        }

        private void Filter_Click(object sender, EventArgs e)
        {
            ResetControls();
            var button = sender as Button;
            if (button != null)
            {
                switch (button.Name)
                {
                    case "BtnFilterTables":
                        PopulateTablesLog(true);
                        break;
                    case "BtnFilterCategories":
                        PopulateCategoriesLog(true);
                        break;
                    case "BtnFilterProducts":
                        PopulateProductsLog(true);
                        break;
                    case "BtnFilterOrders":
                        PopulateOrdersLog(true);
                        break;
                }
            }
        }

        //Filters changes

        private void ChxFilterSeats_CheckedChanged(object sender, EventArgs e)
        {
            if(ChxFilterSeats.Checked)
            {
                NumFilterSeats.Show();
            }
            else
            {
                NumFilterSeats.Hide();
            }    
        }

        private void ChxFilterStatusTables_CheckedChanged(object sender, EventArgs e)
        {
            if(ChxFilterStatusTables.Checked)
            {
                ChxFilterOcuppied.Show();
                ChxFilterReserved.Show();
            }
            else
            {
                ChxFilterOcuppied.Hide();
                ChxFilterReserved.Hide();
            }    
        }

        private void ChxCategoryName_CheckedChanged(object sender, EventArgs e)
        {
            if (ChxCategoryName.Checked)
            {
                TxtFilterCategoryName.Show();
            }
            else
            {
                TxtFilterCategoryName.Hide();
            }
        }

        private void ChxCategoryInfo_CheckedChanged(object sender, EventArgs e)
        {
            if (ChxCategoryInfo.Checked)
            {
                TxtFilterCategoryInfo.Show();
            }
            else
            {
                TxtFilterCategoryInfo.Hide();
            }
        }

        private void ChxProductName_CheckedChanged(object sender, EventArgs e)
        {
            if (ChxProductName.Checked)
            {
                TxtFilterProductName.Show();
            }
            else
            {
                TxtFilterProductName.Hide();
            }
        }

        private void ChxProductInfo_CheckedChanged(object sender, EventArgs e)
        {
            if (ChxProductInfo.Checked)
            {
                TxtFilterProductInfo.Show();
            }                   
            else               
            {                   
                TxtFilterProductInfo.Hide();
            }
        }

        private void ChxProductCategory_CheckedChanged(object sender, EventArgs e)
        {
            if (ChxProductCategory.Checked)
            {
                ComboFilterProductCategory.Show();
            }
            else
            {
                ComboFilterProductCategory.Hide();
            }
        }

        private void ChxFilterOrderClient_CheckedChanged(object sender, EventArgs e)
        {
            if (ChxFilterOrderClient.Checked)
            {
                TxtFilterOrderClient.Show();
            }
            else
            {
                TxtFilterOrderClient.Hide();
            }
        }

        private void ChxFilterOrderStatus_CheckedChanged(object sender, EventArgs e)
        {
            if (ChxFilterOrderStatus.Checked)
            {
                ComboFilterOrderStatus.Show();
            }
            else
            {
                ComboFilterOrderStatus.Hide();
            }
        }

        //Selected item in list changes

        private void ListTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            int _number = ListTables.SelectedIndex;
            if (_number != 0)
            {
                TbAdd.SelectedTab = AddTable;
                if (ListTables.SelectedItem != null)
                {
                    _number = int.Parse(ListTables.SelectedItem.ToString().Split(' ').First());
                }
                Table t = adminTables.GetTable(_number);
                if (t != null)
                {
                    NumSeats.Value = t.seats;
                    ChxOcuppied.Checked = t.occupied;
                    ChxReserved.Checked = t.reserved;
                }
                BtnUpdateTable.Show();
                BtnDeleteTable.Show();
            }
            else
            {
                ResetControls();
            }
        }

        private void ListCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            int _number = ListCategories.SelectedIndex;
            if (_number != 0)
            {
                TbAdd.SelectedTab = AddCategory;
                if (ListCategories.SelectedItem != null)
                {
                    _number = int.Parse(ListCategories.SelectedItem.ToString().Split(' ').First());
                }
                Category c = adminCategories.GetCategory(_number);
                if (c != null)
                {
                    TxtCategoryInfo.Text = c.info;
                    TxtCategoryName.Text = c.name;
                }
                BtnUpdateCategory.Show();
                BtnDeleteCategory.Show();
            }
            else
            {
                ResetControls();
            }
        }

        private void ListProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            HideErrors();
            int _number = ListProducts.SelectedIndex;
            if (_number != 0)
            {
                TbAdd.SelectedTab = AddProduct;
                if (ListProducts.SelectedItem != null)
                {
                    _number = int.Parse(ListProducts.SelectedItem.ToString().Split(' ').First());
                }
                Product p = adminProducts.GetProduct(_number);
                if (p != null)
                {
                    TxtProductName.Text = p.name;
                    TxtProductInfo.Text = p.info;
                    ComboProductCategory.SelectedItem = p.GetCategoryName();
                    NumProductPrice.Value = (decimal) p.price;
                    NumProductTime.Value = (decimal) p.time_to_prepare;
                    NumProductWeight.Value = (decimal) p.weight;

                }
                BtnUpdateProduct.Show();
                BtnDeleteProduct.Show();
            }
            else
            {
                ResetControls();
            }
        }

        private void ListOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            HideErrors();
            int _number = ListOrders.SelectedIndex;
            if (_number != 0)
            {
                TbAdd.SelectedTab = AddOrder;
                if (ListOrders.SelectedItem != null)
                {
                    _number = int.Parse(ListOrders.SelectedItem.ToString().Split(' ').First());
                }

                Order o = adminOrders.GetOrder(_number);
                if (o != null)
                {
                    TxtOrderClient.Text = o.client;
                    TxtOrderInfo.Text = o.info;
                    ComboOrderStatus.SelectedItem = o.status.ToString();
                    ComboOrderDiscount.SelectedItem = o.discount.ToString();
                    ComboOrderTable.Items.Add(o.GetTableNumber());
                    ComboOrderTable.SelectedItem = o.GetTableNumber();
                    for (int i = 0; i < ComboOrderProducts.Items.Count; i++)
                    {
                        Product p = adminProducts.SearchByNameP(ComboOrderProducts.GetItemText(ComboOrderProducts.Items[i]));
                        if (o.CheckProduct(p))
                        {
                            ComboOrderProducts.SetItemChecked(i, true);
                        }
                    }
                }
                BtnUpdateOrder.Show();
                BtnDeleteOrder.Show();
            }
            else
            {
                ResetControls();
            }
        }

    }
}
