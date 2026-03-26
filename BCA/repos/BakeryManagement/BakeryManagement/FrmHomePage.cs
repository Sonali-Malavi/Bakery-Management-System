using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BakeryManagement
{
    public partial class FrmHomePage : Form
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
        public FrmHomePage()
        {
            InitializeComponent();
        }
       

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (Control c in pnlProductList.Controls)
            {
                if (c is CheckBox)
                {
                    ((CheckBox)c).Checked = false;
                }
            }
        }
      

    
        FrmBillingPage bill = new FrmBillingPage();
        private void btnAddtttoCart_Click(object sender, EventArgs e)
        {

            foreach (Control c in pnlProductList.Controls)
            {
                if (c is CheckBox)
                {
                    CheckBox chk = (CheckBox)c;

                    if (chk.Checked)
                    {
                        bill.AddItem(chk.Text);
                    }
                }
            }
            bill.Show();
            this.Hide();
        }
        private void btnProduct_Click(object sender, EventArgs e)
        {
            FrmHomePage hp = new FrmHomePage();
            hp.Show();
        }
    }

}
