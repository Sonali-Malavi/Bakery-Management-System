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
using QRCoder;

namespace BakeryManagement
{
   
    public partial class FrmBillingPage : Form
    {
        string Flag = " ";
        private static string myConn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ATHARV\source\repos\BakeryManagement\BakeryManagement\BakeryManagement.mdf;Integrated Security=True";
        public SqlConnection conn = new SqlConnection(myConn);
        SqlCommand cmd = new SqlCommand();
        public void SetConnection()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
                MessageBox.Show("Connection Open");
            }
        }
        int SrNo = 1;
        public FrmBillingPage()
        {
            InitializeComponent();
            FormClear();

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
            /*SqlCommand cmd = new SqlCommand("select max(Cust_ID) from Customer", conn);
            conn.Open();
            object result = cmd.ExecuteScalar();
            conn.Close();
            int nextId = (result == DBNull.Value) ? 1 : Convert.ToInt32(result) + 1;
            txtCustId.Text = nextId.ToString();*/

            SqlCommand cmd = new SqlCommand("select max(Cust_ID) from Customer", conn);
            conn.Open();
            object result = cmd.ExecuteScalar();
            conn.Close();

            int CustID;
            if (result != DBNull.Value)
            {
                CustID = Convert.ToInt32(result) + 1;
            }
            else
            {
                CustID = 1;
            }

            txtBillNo.Text = CustID.ToString();

        }
         public void AddItem(string item)
        {
            lstProductList.Items.Add(item);
        }
        
        private void LoadProducts()
        {
            lstProductList.Items.Clear();

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    "SELECT Product_Name FROM Product", conn);

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lstProductList.Items.Add(dr["Product_Name"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
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

            dataGridView1.Rows.Add(SrNo, product, price, qty, total);

            SrNo++;
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
            using(SqlConnection conn = new SqlConnection(myConn));
             {
                 conn.Open();


                 SqlCommand cmd = new SqlCommand("SELECT MAX(Cust_ID) FROM Billing", conn);
                 object result = cmd.ExecuteScalar();

                 int newId = (result == DBNull.Value) ? 1 : Convert.ToInt32(result) + 1;


                 txtCustId.Text = newId.ToString();
                 //txtBillNo.Text = newId.ToString();

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

           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void FormClear()
        {
            foreach (Control c in pnlBillingPage.Controls)
            {
                if (c is TextBox || c is ComboBox)
                {
                    c.Text = " ";
                }
            }
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            FormClear();
            Flag = "A";
            SetConnection();
            FrmHomePage hp = new FrmHomePage();
            cmd = new SqlCommand("Select max(Bill_ID) from Billing ", conn);
            if (System.DBNull.Value == cmd.ExecuteScalar())
            {
                txtBillNo.Text = Convert.ToString(1);
            }
            else
            {
                int i = Convert.ToInt32(cmd.ExecuteScalar());
                txtBillNo.Text = Convert.ToString(i * 1);
            }
            hp.Show();
            conn.Close();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            FrmDashboard dp = new FrmDashboard();
            dp.Show();
            this.Hide();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            FrmHomePage hp = new FrmHomePage();
            hp.Show();
            this.Hide();
        }

        private void btnSaveandPrint_Click(object sender, EventArgs e)
        {
           /* string billID = txtBillNo.Text;
            string custID = txtCustId.Text;
            string paymentMode = cmbModeOfPayment.Text;
            string total = txtTotalAmount.Text;
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
            string billNo = txtBillNo.Text;
            int custId = Convert.ToInt32(txtCustId.Text);
            string payMode = cmbModeOfPayment.Text;
            int grandTotal = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["colTotal"].Value != null)
                {
                    grandTotal += Convert.ToInt32(row.Cells["colTotal"].Value);
                }
            }

            FrmPrintPage p = new FrmPrintPage(
                dataGridView1,
                billNo,
                 payMode,
                 custId,
                 grandTotal
            );

            p.Show();
            this.Hide();
            try
            {
                conn.Open();

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.IsNewRow) continue;

                    // Prepare the INSERT command

                    SqlCommand cmd = new SqlCommand("INSERT INTO Billing ( Bill_Date, Product_Name, Product_Price, Qty, Amount, Cust_ID) VALUES (@Bill_Date,@Product_Name,@Product_Price,@Qty,@Amount,@Cust_ID)", conn);

                    //1 Bill No
                    int Bill_ID = Convert.ToInt32(txtBillNo.Text);
                    cmd.Parameters.Add("@Bill_ID", SqlDbType.Int).Value = Bill_ID;


                    // 2 Bill Date
                    cmd.Parameters.Add("@Bill_Date", SqlDbType.DateTime).Value = dtpDate.Value;

                    // 3 Product Name
                    string Product_Name = row.Cells["colProduct"].Value?.ToString() ?? "";
                    cmd.Parameters.Add("@Product_Name",SqlDbType.Char).Value = Product_Name;

                    // 4 Product Price
                    int Product_Price = Convert.ToInt32(row.Cells["colPrice"].Value);
                    cmd.Parameters.Add("@Product_Price", SqlDbType.Int).Value = Product_Price;

                    // 5 Quantity
                    int Qty = Convert.ToInt32(row.Cells["colQty"].Value);
                    cmd.Parameters.Add("@Qty", SqlDbType.Int).Value = Qty;

                    // 6  Amount
                    int Amount = Convert.ToInt32(row.Cells["colTotal"].Value);
                    cmd.Parameters.Add("@Amount", SqlDbType.Int).Value = Amount;

                    // 7 Customer ID
                    int Cust_ID = Convert.ToInt32(txtCustId.Text);
                    cmd.Parameters.Add("@Cust_ID", SqlDbType.Int).Value = Cust_ID;


                    // Execute insert
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("✅ Bill saved successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("⚠️ Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
           /*


            /*
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
                     txtTotalAmount.Text,  // ✅ convert केलं
                    billList
                );
            p.Show();*/

            try
            {
                conn.Open();

                int Bill_ID = Convert.ToInt32(txtBillNo.Text);
                int Cust_ID = Convert.ToInt32(txtCustId.Text);
                string payMode = cmbModeOfPayment.Text;
                DateTime billDate = dtpDate.Value;

                int grandTotal = 0;

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.IsNewRow) continue;

                    int amount = Convert.ToInt32(row.Cells["colTotal"].Value);
                    grandTotal += amount;

                    SqlCommand cmd = new SqlCommand(
                        "INSERT INTO Billing (Bill_ID, Bill_Date, Product_Name, Product_Price, Qty, Amount, Cust_ID) " +
                        "VALUES (@Bill_ID, @Bill_Date, @Product_Name, @Product_Price, @Qty, @Amount, @Cust_ID)",
                        conn);

                    cmd.Parameters.AddWithValue("@Bill_ID", Bill_ID);
                    cmd.Parameters.AddWithValue("@Bill_Date", billDate);
                    cmd.Parameters.AddWithValue("@Product_Name", row.Cells["colProduct"].Value.ToString());
                    cmd.Parameters.AddWithValue("@Product_Price", Convert.ToInt32(row.Cells["colPrice"].Value));
                    cmd.Parameters.AddWithValue("@Qty", Convert.ToInt32(row.Cells["colQty"].Value));
                    cmd.Parameters.AddWithValue("@Amount", amount);
                    cmd.Parameters.AddWithValue("@Cust_ID", Cust_ID);
                    
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("✅ Bill saved successfully!");

                FrmPrintPage p = new FrmPrintPage(
                    dataGridView1,
                    Bill_ID.ToString(),
                    payMode,
                    Cust_ID,
                    grandTotal
                );

                p.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("⚠️ Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbModeOfPayment_SelectedIndexChanged(object sender, EventArgs e)
        {/*
            string selectedMode = cmbModeOfPayment.SelectedItem?.ToString();

            if (selectedMode == "UPI")
            {

                string upiLink = "atharvbhosale2323@oksbi";

                QRCodeGenerator qrGenerator = new QRCodeGenerator();
                QRCodeData qrCodeData = qrGenerator.CreateQrCode(upiLink, QRCodeGenerator.ECCLevel.Q);
                QRCode qrCode = new QRCode(qrCodeData);
                Bitmap qrCodeImage = qrCode.GetGraphic(20);

                Form qrForm = new Form();
                qrForm.Text = "Scan to Pay (UPI Payment)";
                qrForm.StartPosition = FormStartPosition.CenterParent;
                qrForm.Size = new Size(350, 400);
                qrForm.FormBorderStyle = FormBorderStyle.FixedDialog;
                qrForm.MaximizeBox = false;

                PictureBox pic = new PictureBox();
                pic.Dock = DockStyle.Fill;
                pic.SizeMode = PictureBoxSizeMode.Zoom;
                pic.Image = qrCodeImage;
                qrForm.Controls.Add(pic);

                Button btnClose = new Button();
                btnClose.Text = "Close";
                btnClose.Dock = DockStyle.Bottom;
                btnClose.Click += (s, args) => qrForm.Close();
                qrForm.Controls.Add(btnClose);

                qrForm.ShowDialog();
            }
            */
         
            string selectedMode = cmbModeOfPayment.SelectedItem?.ToString();

            if (selectedMode == "UPI")
            {
                // 👇 Get Total Amount from textbox (change name if needed)
               
                    // 👇 इथे टाक
                    MessageBox.Show("Value is: " + txtTotalAmount.Text);

                    decimal amount;

                    string cleanText = txtTotalAmount.Text.Replace("₹", "").Trim();

                    if (!decimal.TryParse(cleanText, out amount))
                    {
                        MessageBox.Show("Invalid total amount!");
                        return;
                    }
                
                    // 👇 Proper UPI Payment Link Format
                string upiId = "atharvbhosale2323@oksbi";
                string payeeName = "Bakery Shop";

                string upiLink = $"upi://pay?pa={upiId}&pn={payeeName}&am={amount}&cu=INR";

                QRCodeGenerator qrGenerator = new QRCodeGenerator();
                QRCodeData qrCodeData = qrGenerator.CreateQrCode(upiLink, QRCodeGenerator.ECCLevel.Q);
                QRCode qrCode = new QRCode(qrCodeData);
                Bitmap qrCodeImage = qrCode.GetGraphic(20);

                Form qrForm = new Form();
                qrForm.Text = "Scan to Pay (UPI Payment)";
                qrForm.StartPosition = FormStartPosition.CenterParent;
                qrForm.Size = new Size(350, 420);
                qrForm.FormBorderStyle = FormBorderStyle.FixedDialog;
                qrForm.MaximizeBox = false;

                PictureBox pic = new PictureBox();
                pic.Dock = DockStyle.Fill;
                pic.SizeMode = PictureBoxSizeMode.Zoom;
                pic.Image = qrCodeImage;
                qrForm.Controls.Add(pic);

                Label lblAmount = new Label();
                lblAmount.Text = "Amount: ₹ " + amount.ToString("0.00");
                lblAmount.Dock = DockStyle.Top;
                lblAmount.TextAlign = ContentAlignment.MiddleCenter;
                lblAmount.Font = new Font("Arial", 12, FontStyle.Bold);
                qrForm.Controls.Add(lblAmount);

                Button btnClose = new Button();
                btnClose.Text = "Close";
                btnClose.Dock = DockStyle.Bottom;
                btnClose.Height = 40;
                btnClose.Click += (s, args) => qrForm.Close();
                qrForm.Controls.Add(btnClose);

                qrForm.ShowDialog();
            }
        }
        
        private void pnlBillingPage_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlBack_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtBillNo_TextChanged_1(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(myConn);
            SqlCommand cmd = new SqlCommand(
                "SELECT ISNULL(MAX(Bill_ID),0)+1 FROM Billing", conn);

            conn.Open();
            int billId = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();

            txtBillNo.Text = billId.ToString("0000");
        }

        private void txtCustId_TextChanged_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(myConn);
            SqlCommand cmd = new SqlCommand(
                "SELECT ISNULL(MAX(Cust_ID),1000)+1 FROM Customer", con);

            con.Open();
            int custId = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();

            txtCustId.Text = custId.ToString("0000");
        }
    }
}
