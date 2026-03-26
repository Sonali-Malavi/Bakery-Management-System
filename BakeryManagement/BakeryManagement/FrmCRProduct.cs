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
    public partial class FrmCRProduct : Form
    {
        public FrmCRProduct()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            string myconn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ATHARV\source\repos\BakeryManagement\BakeryManagement\BakeryManagement.mdf;Integrated Security=True";
            SqlDataAdapter da = new SqlDataAdapter("Select * from Product", myconn);
            DataSet ds = new DataSet();
            da.Fill(ds, "Product");
            ReportDocument crypt = new ReportDocument();
            crypt.Load(@"C:\Users\ATHARV\source\repos\BakeryManagement\BakeryManagement\CrystalReportProduct.rpt");
            crypt.SetDataSource(ds);

            crypt.Refresh();
            crystalReportViewer1.ReportSource = crypt;
            crystalReportViewer1.Show();
        }
    }
}
