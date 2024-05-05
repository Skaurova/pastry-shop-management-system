using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Windows.Forms;

namespace PastryShop
{
    public partial class VanillePastryShop : Form
    {
        public VanillePastryShop()
        {
            InitializeComponent();
            DisplayItems("Item", ItemDGV);
            GetCategory();
        }

        SqlConnection Connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\skaur\Documents\VanillePastryShopDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void Items_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
            DisplayItems("Item", ItemDGV);
            GetCategory();
        }


        private void Billing_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 3;
            DisplayItems("Item", BItemDGV);
            DisplayItems("Sale", CustomerBillsDGV);
            GetCustomer();
        }

        private void Categories_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
            DisplayItems("Category", CategoryDGV);
        }

        private void Dashboard_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 4;
            CountCustomers();
            CountItems();
            CountSales();
        }

        private void Customers_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            DisplayItems("Customer", CustomerDGV);
        }

        private void DisplayItems(string iName, DataGridView DGV)
        {
            Connect.Open();
            string Query = "select * from " + iName + "";
            SqlDataAdapter adapter = new SqlDataAdapter(Query, Connect);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            var dataSet = new DataSet();
            adapter.Fill(dataSet);
            DGV.DataSource = dataSet.Tables[0];
            Connect.Close();


        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (ItemNameTb.Text == "" || QuantityTb.Text == "" || PriceTb.Text == "" || CategoryCb.SelectedIndex == -1)
            {
                MessageBox.Show("Information entered incorrectly.");
            }
            else
            {
                try
                {
                    Connect.Open();
                    SqlCommand cmd = new SqlCommand("Insert into Item(Name, Category, Price, Quantity) values(@IN, @IC, @IP, @IQ)", Connect);
                    cmd.Parameters.AddWithValue("@IN", ItemNameTb.Text);
                    cmd.Parameters.AddWithValue("@IC", CategoryCb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@IP", PriceTb.Text);
                    cmd.Parameters.AddWithValue("@IQ", QuantityTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Item has been added.");
                    Connect.Close();
                    DisplayItems("Item", ItemDGV);
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        int key = 0;


        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (ItemNameTb.Text == "" || QuantityTb.Text == "" || PriceTb.Text == "" || CategoryCb.SelectedIndex == -1)
            {
                MessageBox.Show("Information entered incorrectly.");
            }
            else
            {
                try
                {
                    Connect.Open();
                    SqlCommand cmd = new SqlCommand("update Item set Name=@IN, Category=@IC, Price=@IP, Quantity=@IQ where Id = @IKey", Connect);
                    cmd.Parameters.AddWithValue("@IN", ItemNameTb.Text);
                    cmd.Parameters.AddWithValue("@IC", CategoryCb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@IP", PriceTb.Text);
                    cmd.Parameters.AddWithValue("@IQ", QuantityTb.Text);
                    cmd.Parameters.AddWithValue("@IKey", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Item has been updated.");
                    Connect.Close();
                    DisplayItems("Item", ItemDGV);
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void AddCustBtn_Click(object sender, EventArgs e)
        {
            if (CustNameTb.Text == "" || CustPhoneTb.Text == "" || CustAddressTb.Text == "")
            {
                MessageBox.Show("Information entered incorrectly.");
            }
            else
            {
                try
                {
                    Connect.Open();
                    SqlCommand cmd = new SqlCommand("Insert into Customer(Name, Phone, Address) values(@CN, @CP, @CA)", Connect);
                    cmd.Parameters.AddWithValue("@CN", CustNameTb.Text);
                    cmd.Parameters.AddWithValue("@CP", CustPhoneTb.Text);
                    cmd.Parameters.AddWithValue("@CA", CustAddressTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer has been added.");
                    Connect.Close();
                    DisplayItems("Customer", CustomerDGV);
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Information entered incorrectly.");
            }
            else
            {
                try
                {
                    Connect.Open();
                    SqlCommand cmd = new SqlCommand("delete from Item where Id = @IKey", Connect);
                    cmd.Parameters.AddWithValue("@IKey", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Item has been deleted.");
                    Connect.Close();
                    DisplayItems("Item", ItemDGV);
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }



        private void ItemDGV_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ItemNameTb.Text = ItemDGV.SelectedRows[0].Cells[1].Value.ToString();
            PriceTb.Text = ItemDGV.SelectedRows[0].Cells[2].Value.ToString();
            QuantityTb.Text = ItemDGV.SelectedRows[0].Cells[3].Value.ToString();
            CategoryCb.Text = ItemDGV.SelectedRows[0].Cells[4].Value.ToString();
            if (ItemNameTb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(ItemDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        int key1 = 0;

        private void CustomerDGV_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            CustNameTb.Text = CustomerDGV.SelectedRows[0].Cells[1].Value.ToString();
            CustPhoneTb.Text = CustomerDGV.SelectedRows[0].Cells[2].Value.ToString();
            CustAddressTb.Text = CustomerDGV.SelectedRows[0].Cells[3].Value.ToString();

            if (CustNameTb.Text == "")
            {
                key1 = 0;
            }
            else
            {
                key1 = Convert.ToInt32(CustomerDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void DeleteCustBtn_Click(object sender, EventArgs e)
        {
            if (key1 == 0)
            {
                MessageBox.Show("Information entered incorrectly.");
            }
            else
            {
                try
                {
                    Connect.Open();
                    SqlCommand cmd = new SqlCommand("delete from Customer where Id = @CKey", Connect);
                    cmd.Parameters.AddWithValue("@CKey", key1);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer has been deleted.");
                    Connect.Close();
                    DisplayItems("Customer", CustomerDGV);
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }


        }

        private void EditCustBtn_Click(object sender, EventArgs e)
        {
            if (CustNameTb.Text == "" || CustPhoneTb.Text == "" || CustAddressTb.Text == "")
            {
                MessageBox.Show("Information entered incorrectly.");
            }
            else
            {
                try
                {
                    Connect.Open();
                    SqlCommand cmd = new SqlCommand("update Customer set Name=@CN, Phone=@CP, Address=@CA where Id = @CKey", Connect);
                    cmd.Parameters.AddWithValue("@CN", CustNameTb.Text);
                    cmd.Parameters.AddWithValue("@CP", CustPhoneTb.Text);
                    cmd.Parameters.AddWithValue("@CA", CustAddressTb.Text);
                    cmd.Parameters.AddWithValue("@CKey", key1);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer has been updated.");
                    Connect.Close();
                    DisplayItems("Customer", CustomerDGV);
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void AddCatBtn_Click(object sender, EventArgs e)
        {
            if (CatNameTb.Text == "")
            {
                MessageBox.Show("Information entered incorrectly.");
            }
            else
            {
                try
                {
                    Connect.Open();
                    SqlCommand cmd = new SqlCommand("Insert into Category (Name) values(@CN)", Connect);
                    cmd.Parameters.AddWithValue("@CN", CatNameTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category has been added.");
                    Connect.Close();
                    DisplayItems("Category", CategoryDGV);
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        int key2 = 0;

        private void CategoryDGV_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            CatNameTb.Text = CategoryDGV.SelectedRows[0].Cells[1].Value.ToString();

            if (CatNameTb.Text == "")
            {
                key2 = 0;
            }
            else
            {
                key2 = Convert.ToInt32(CategoryDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void DeleteCatBtn_Click(object sender, EventArgs e)
        {
            if (key2 == 0)
            {
                MessageBox.Show("Information entered incorrectly.");
            }
            else
            {
                try
                {
                    Connect.Open();
                    SqlCommand cmd = new SqlCommand("delete from Category where Id = @CKey", Connect);
                    cmd.Parameters.AddWithValue("@CKey", key2);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category has been deleted.");
                    Connect.Close();
                    DisplayItems("Category", CategoryDGV);
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void EditCatBtn_Click(object sender, EventArgs e)
        {
            if (CatNameTb.Text == "")
            {
                MessageBox.Show("Information entered incorrectly.");
            }
            else
            {
                try
                {
                    Connect.Open();
                    SqlCommand cmd = new SqlCommand("Update Category set Name=@CN where Id=@CKey", Connect);
                    cmd.Parameters.AddWithValue("@CN", CatNameTb.Text);
                    cmd.Parameters.AddWithValue("@CKey", key2);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category has been updated.");
                    Connect.Close();
                    DisplayItems("Category", CategoryDGV);
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        int key3 = 0;
        int stock = 0;
        private void BItemDGV_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            BItemNameTb.Text = BItemDGV.SelectedRows[0].Cells[1].Value.ToString();
            BPriceTb.Text = BItemDGV.SelectedRows[0].Cells[3].Value.ToString();
            if (BItemNameTb.Text == "")
            {
                key3 = 0;
                stock = 0;
            }
            else
            {
                key3 = Convert.ToInt32(BItemDGV.SelectedRows[0].Cells[0].Value.ToString());
                stock = Convert.ToInt32(BItemDGV.SelectedRows[0].Cells[2].Value.ToString());

            }
        }

        int b = 0;
        int yourTotal = 0;
        private void AddToBillBtn_Click(object sender, EventArgs e)
        {
            if (BQuantityTb.Text == "")
            {
                MessageBox.Show("Enter Quantity.");
            }
            else if (Convert.ToInt32(BQuantityTb.Text) > stock)
            {
                MessageBox.Show("Not enough items in stock.");
            }
            else
            {
                int total = Convert.ToInt32(BQuantityTb.Text) * Convert.ToInt32(BPriceTb.Text);
                DataGridViewRow yourBill = new DataGridViewRow();
                yourBill.CreateCells(YourBillsDGV);
                yourBill.Cells[0].Value = b + 1;
                yourBill.Cells[1].Value = BItemNameTb.Text;
                yourBill.Cells[2].Value = BPriceTb.Text;
                yourBill.Cells[3].Value = BQuantityTb.Text;
                yourBill.Cells[4].Value = total;
                YourBillsDGV.Rows.Add(yourBill);
                b++;
                yourTotal += total;
                yourTotalLabel.Text = total + "$";

            }
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            BItemNameTb.Text = "";
            BPriceTb.Text = "";
            BQuantityTb.Text = "";
        }

        private void GetCustomer()
        {
            Connect.Open();
            SqlCommand cmd = new SqlCommand("select Id from Customer", Connect);

            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Id", typeof(int));
            dt.Load(reader);
            BCustomerCb.ValueMember = "Id";
            BCustomerCb.DataSource = dt;

            Connect.Close();

        }

        private void SaveBillBtn_Click(object sender, EventArgs e)
        {
            if (BCustomerCb.SelectedIndex == -1)
            {
                MessageBox.Show("Information entered incorrectly.");
            }
            else
            {
                try
                {
                    Connect.Open();
                    SqlCommand cmd = new SqlCommand("Insert into Sale(Customer, Quantity, Date) values(@CN, @CQ, @CD)", Connect);
                    cmd.Parameters.AddWithValue("@CN", BCustomerCb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@CQ", yourTotal);
                    cmd.Parameters.AddWithValue("@CD", DateTime.Today.Date);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("The bill has been added.");
                    Connect.Close();
                    DisplayItems("Sale", CustomerBillsDGV);
                    BItemNameTb.Text = "";
                    BPriceTb.Text = "";
                    BQuantityTb.Text = "";
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void CountCustomers()
        {
            Connect.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select Count(*) from Customer", Connect);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            CustLabel.Text = dt.Rows[0][0].ToString();
            Connect.Close();
        }

        private void CountItems()
        {
            Connect.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select Count(*) from Item", Connect);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            ItemLbl.Text = dt.Rows[0][0].ToString();
            Connect.Close();
        }

        private void CountSales()
        {
            Connect.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select Sum(Quantity) from Sale", Connect);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            SaleLbl.Text = dt.Rows[0][0].ToString() + " $";
            Connect.Close();
        }

        private void GetCategory()
        {
            Connect.Open();
            SqlCommand cmd = new SqlCommand("select Id from Category", Connect);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Id", typeof(int));
            dt.Load(reader);
            CategoryCb.ValueMember = "Id";
            CategoryCb.DataSource = dt;
            Connect.Close();
        }

        private void LogoutLbl_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }

        private void label_Click(object sender, EventArgs e)
        {

        }

        private void CustLabel_Click(object sender, EventArgs e)
        {
        }
    }
}