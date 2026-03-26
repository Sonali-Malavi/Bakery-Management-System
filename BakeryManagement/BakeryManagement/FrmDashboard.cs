using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace BakeryManagement
{
    public partial class FrmDashboard : Form
    {
        private static string myConn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ATHARV\source\repos\BakeryManagement\BakeryManagement\BakeryManagement.mdf;Integrated Security=True";
        public SqlConnection conn = new SqlConnection(myConn);
        public void SetConnection()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
                MessageBox.Show("Connection Open");
            }
        }
        public FrmDashboard()
        {
            InitializeComponent();
        }


        private void btnrefersh_Click(object sender, EventArgs e)
        {
             using (SqlConnection conn = new SqlConnection(myConn))
            {
                conn.Open();

                 // 1️⃣ TOTAL AVAILABLE PRODUCTS COUNT
                SqlCommand cmd1 = new SqlCommand("SELECT COUNT(*) FROM Product", conn);
                int totalProducts = (int)cmd1.ExecuteScalar();
                lblTotalSold.Text = "Total Products: " + totalProducts;

                // TOTAL PRODUCT TABLE
                SqlDataAdapter daProduct = new SqlDataAdapter("SELECT * FROM Product", conn);
                DataTable dtProduct = new DataTable();
                daProduct.Fill(dtProduct);
                dataGridViewTotal.DataSource = dtProduct;
                dataGridViewTotal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                // 2️⃣ TODAY SALES COUNT
                DateTime today = DateTime.Today;
                DateTime tomorrow = today.AddDays(1);

                SqlCommand cmd2 = new SqlCommand(
                    "SELECT ISNULL(SUM(Qty),0) FROM Billing " +
                    "WHERE Bill_Date >= @today AND Bill_Date < @tomorrow", conn);

                cmd2.Parameters.AddWithValue("@today", today);
                cmd2.Parameters.AddWithValue("@tomorrow", tomorrow);

                int todaySales = Convert.ToInt32(cmd2.ExecuteScalar());
                lblTodaysSold.Text = "Today's Sold Items: " + todaySales;

                // 2️⃣ TODAY SALES TABLE
                SqlCommand cmd3 = new SqlCommand(
                    "SELECT Bill_ID, Product_Name, Qty, Product_Price, Amount, Cust_ID " +
                    "FROM Billing " +
                    "WHERE Bill_Date >= @today AND Bill_Date < @tomorrow", conn);

                cmd3.Parameters.AddWithValue("@today", today);
                cmd3.Parameters.AddWithValue("@tomorrow", tomorrow);

                SqlDataAdapter da = new SqlDataAdapter(cmd3);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridViewToday.DataSource = dt;
                dataGridViewToday.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                // 3️⃣ LOW STOCK ALERT
                SqlCommand cmd4 = new SqlCommand(
                    "SELECT Product_Name FROM Product WHERE Qty_Available <= 5", conn);

                SqlDataReader dr = cmd4.ExecuteReader();

                string lowItems = "";
                while (dr.Read())
                {
                    lowItems += dr["Product_Name"].ToString() + ", ";
                }
                dr.Close();

                if (string.IsNullOrEmpty(lowItems))
                    lblLowStock.Text = "Low Stock Items: None";
                else
                    lblLowStock.Text = "Low Stock Items: " + lowItems.TrimEnd(',', ' ');
            }
        }
        private void LoadTodaysSales()
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            DateTime today = DateTime.Today;
            DateTime tomorrow = today.AddDays(1);

            SqlCommand cmd3 = new SqlCommand(
                "SELECT Bill_ID, Product_Name, Qty, Amount, Cust_ID " +
                "FROM Billing " +
                "WHERE Bill_Date >= @today AND Bill_Date < @tomorrow",
                conn);

            cmd3.Parameters.AddWithValue("@today", today);
            cmd3.Parameters.AddWithValue("@tomorrow", tomorrow);

            SqlDataAdapter da = new SqlDataAdapter(cmd3);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridViewToday.DataSource = dt;
            dataGridViewToday.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
             
        private void btnBackToProduct_Click(object sender, EventArgs e)
        {
            FrmHomePage hp = new FrmHomePage();
            hp.Show();
            this.Hide();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            FrmHomePage hp = new FrmHomePage();
            hp.Show();
            this.Hide();
        }

        private void btnBilling_Click(object sender, EventArgs e)
        {
            FrmBillingPage bp = new FrmBillingPage();
            bp.Show();
            this.Hide();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbCR_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedMode = cmbCR.SelectedItem?.ToString();

            if (selectedMode == "CRLogin")
            {
                FrmCRLogin crp = new FrmCRLogin();
                crp.Show();
            }
            if (selectedMode == "CRProduct")
            {
                FrmCRProduct crp = new FrmCRProduct();
                crp.Show();
            }
            if (selectedMode == "CRBilling")
            {
                FrmCRBilling crp = new FrmCRBilling();
                crp.Show();
            }
        }
    }
}
