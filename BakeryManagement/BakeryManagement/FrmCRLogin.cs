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
using CrystalDecisions.CrystalReports.Engine;

namespace BakeryManagement
{
    public partial class FrmCRLogin : Form
    {
        public FrmCRLogin()
        {
            InitializeComponent();
        }

        private void FrmCRLogin_Load(object sender, EventArgs e)
        {

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            string myconn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ATHARV\source\repos\BakeryManagement\BakeryManagement\BakeryManagement.mdf;Integrated Security=True";
            SqlDataAdapter da = new SqlDataAdapter("Select * from Login", myconn);
            DataSet ds = new DataSet();
            da.Fill(ds, "Login");
            ReportDocument crypt = new ReportDocument();
            crypt.Load(@"C:\Users\ATHARV\source\repos\BakeryManagement\BakeryManagement\CrystalReportLogin.rpt");
            crypt.SetDataSource(ds);

            crypt.Refresh();
            crystalReportViewer1.ReportSource = crypt;
            crystalReportViewer1.Show();

        }
    }
}
