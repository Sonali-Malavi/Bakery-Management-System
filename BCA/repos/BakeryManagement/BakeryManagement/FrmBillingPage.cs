using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BakeryManagement
{
   
    public partial class FrmBillingPage : Form
    {
        private static string myConn = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BakeryManagement;Integrated Security=True";
        public SqlConnection conn = new SqlConnection(myConn);
        public void SetConnection()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
                MessageBox.Show("Connection Open");
            }
        }
        int srNo = 1;
        public FrmBillingPage()
        {
            InitializeComponent();
        
        }

        private void txtBillNo_TextChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select max(Bill_ID) from Billing", conn);
            conn.Open();
            object result = cmd.ExecuteScalar();
            conn.Close();

            int BillNo;
            if (result != DBNull.Value)
            {
                BillNo = Convert.ToInt32(result) + 1;
            }
            else
            {
                BillNo = 1;
            }

            txtBillNo.Text = BillNo.ToString();

        }

        private void txtCustId_TextChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select max(Cust_ID) from Customer", conn);
            conn.Open();
            object result = cmd.ExecuteScalar();
            conn.Close();
            int nextId = (result == DBNull.Value) ? 1 : Convert.ToInt32(result) + 1;
            txtCustId.Text = nextId.ToString();

        }
        public void AddItem(string item)
        {
            lstProductList.Items.Add(item);
        }
        

        private void lstProductList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstProductList.SelectedItem == null)
                return;

            string selectedProduct = lstProductList.SelectedItem.ToString();

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT [Product_Price] FROM [Product] WHERE [Product_Name] = @pname", conn);
                cmd.Parameters.AddWithValue("@pname", selectedProduct);

                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    txtPrice.Text = result.ToString();
                }
                else
                {
                    MessageBox.Show("Product not found!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(txtPrice.Text, out double price) && int.TryParse(txtQuantity.Text, out int qty))
            {
                txtAmount.Text = (price * qty).ToString();
            }
        }

        private void btnAddtoBill_Click(object sender, EventArgs e)
        {

           
            if (lstProductList.SelectedItem == null)
            {
                MessageBox.Show("Select product first");
                return;
            }

            string product = lstProductList.SelectedItem.ToString();
            decimal price = Convert.ToDecimal(txtPrice.Text);
            int qty = Convert.ToInt32(txtQuantity.Text);

            decimal total = price * qty;

            dataGridView1.Rows.Add(srNo, product, price, qty, total);

            srNo++;
            CalculateTotalAmount();
        }
        private void CalculateTotalAmount()
        {
            decimal totalAmount = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;
                object value = row.Cells["colTotal"].Value;
                if (value != null && value.ToString() != "")
                {
                    decimal rowAmount;
                    decimal.TryParse(value.ToString(), out rowAmount);

                    totalAmount += rowAmount;
                }
            }

            txtTotalAmount.Text = totalAmount.ToString("0.00");
        }    

        private void btnSaveandPrint_Click(object sender, EventArgs e)
        {
            string billID = lblBillNo.Text;
            string custID = lblCustId.Text;
            string paymentMode = cmbModeOfPayment.Text;
            string total = lblTotalAmount.Text;
            List<BillItem> billList = new List<BillItem>();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["colTotal"].Value != null)
                {
                    billList.Add(new BillItem
                    {
                        SrNo = Convert.ToInt32(row.Cells["colSrNo"].Value),
                        ProductName = row.Cells["colProduct"].Value.ToString(),
                        Quantity = Convert.ToInt32(row.Cells["colQty"].Value),
                        Price = Convert.ToDecimal(row.Cells["colPrice"].Value),
                        Amount = Convert.ToDecimal(row.Cells["colTotal"].Value)
                    });
                }
            }
            FrmPrintPage p = new FrmPrintPage(
                    txtBillNo.Text,
                    txtCustId.Text,
                    cmbModeOfPayment.SelectedItem.ToString(),
                    (txtTotalAmount.Text),  // ✅ convert केलं
                    billList
                );
                p.Show();
        }
        public void AddProduct(string productName)
        {
            lstProductList.Items.Add(productName);
        }
        public class BillItem
        {
            public int SrNo { get; set; }
            public string ProductName { get; set; }
            public int Quantity { get; set; }
            public decimal Price { get; set; }
            public decimal Amount { get; set; }
        }

        private void FrmBillingPage_Load(object sender, EventArgs e)
        {
           MessageBox.Show(lstProductList.Items.Count.ToString());
        }

    
        private void GenerateBillNo()
        {
            SqlConnection conn = new SqlConnection(myConn);
            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT MAX(Bill_ID) FROM Billing", conn);
            var result = cmd.ExecuteScalar();

            int newBillNo;

            if (result == DBNull.Value)
                newBillNo = 1;
            else
                newBillNo = Convert.ToInt32(result) + 1;

            txtBillNo.Text = newBillNo.ToString();

            conn.Close();
        }

        private void GenerateCustomerId()
        {

            using (SqlConnection conn = new SqlConnection(myConn));
            {
                conn.Open();


                SqlCommand cmd = new SqlCommand("SELECT MAX(VAL(Cust_ID)) FROM Billing", conn);
                object result = cmd.ExecuteScalar();

                int newId = (result == DBNull.Value) ? 1 : Convert.ToInt32(result) + 1;


                txtCustId.Text = newId.ToString();
                txtBillNo.Text = newId.ToString();

                conn.Close();
            }
        }

        private void btnBilling_Click(object sender, EventArgs e)
        {
            GenerateBillNo();
            GenerateCustomerId();
        }
        private void FrmHomePage_Load(object sender, EventArgs e)
        {

            using (SqlConnection conn = new SqlConnection(myConn));
            {
                SqlCommand cmd1 = new SqlCommand("SELECT MAX(Cust_ID) FROM Customer", conn);
                conn.Open();
                object result = cmd1.ExecuteScalar();
                int nextId = (result == DBNull.Value) ? 1 : Convert.ToInt32(result) + 1;
                txtCustId.Text = nextId.ToString();
            }

            using (SqlConnection conn = new SqlConnection(myConn));
            {
                SqlCommand cmd2 = new SqlCommand("SELECT MAX(Cust_ID) FROM Customer", conn);
                conn.Open();
                object result = cmd2.ExecuteScalar();
                int nextId = (result == DBNull.Value) ? 1 : Convert.ToInt32(result) + 1;
                txtCustId.Text = nextId.ToString();
            }

            //CASH OR ONLINE
            dataGridView1.Columns.Add("SrNo", "Sr.No");
            dataGridView1.Columns.Add("ProductName", "Product Name");
            dataGridView1.Columns.Add("Price", "Price");
            dataGridView1.Columns.Add("Quantity", "Quantity");
            dataGridView1.Columns.Add("Amount", "Amount");

            string query = "SELECT Product_Name FROM Product";
            SqlCommand cmd3 = new SqlCommand(query, conn);
            // conn.Open();
            SqlDataReader reader = cmd3.ExecuteReader();
            while (reader.Read())
            {
                lstProductList.Items.Add(reader["Product_Name"].ToString());
            }
            conn.Close();

            cmbModeOfPayment.Items.Add("Cash");
            cmbModeOfPayment.Items.Add("Online");
            cmbModeOfPayment.SelectedIndex = 0;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
           
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
           
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            FrmHomePage hp = new FrmHomePage();
            hp.Show();
        }
    }
}
