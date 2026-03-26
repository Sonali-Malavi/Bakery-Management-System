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

namespace BakeryManagement
{
    public partial class FrmLoginPage : Form
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
        public FrmLoginPage()
        {
            InitializeComponent();
            SetConnection();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        { 
                string Username = "Admin";
                string Password = "A1234";

                if (txtUsername.Text == Username && txtPassword.Text == Password)
                {
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand("select * from Login where Username='" + txtUsername.Text + "' and Password='" + txtPassword.Text + "'", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows == true)
                {
                    MessageBox.Show("Login Correct");
                }
                else
                {
                    MessageBox.Show("Login Incorrect");
                }
                 FrmHomePage hp = new FrmHomePage();
                hp.Show();
                this.Hide();
               
            }
            else
            {
                MessageBox.Show("Inavlid username or password", "Login failed",
                    MessageBoxButtons.OK);
            }
            conn.Close();
        }
    }
}
