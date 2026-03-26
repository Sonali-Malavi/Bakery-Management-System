using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static BakeryManagement.FrmBillingPage;


namespace BakeryManagement
{
    public partial class FrmPrintPage : Form
    {
        private static string myConn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ATHARV\source\repos\BakeryManagement\BakeryManagement\BakeryManagement.mdf;Integrated Security=True";
        public SqlConnection conn = new SqlConnection(myConn);

        private string _billNo;
        private string _custId;
        private string _paymentMode;
        private string _totalAmount;
        private List<BillItem> _items;

            public FrmPrintPage(
                DataGridView dgvBilling,
                string billNo,
                string paymentMode,
                int custId,
                int grandTotal)
            {
                InitializeComponent();

                // Copy DataGridView data
                foreach (DataGridViewRow row in dgvBilling.Rows)
                {
                    if (row.IsNewRow) continue;
                    dataGridViewPrint.Rows.Add(
                        row.Cells["colSrNo"].Value,
                        row.Cells["colProduct"].Value,
                        row.Cells["colQty"].Value,
                        row.Cells["colPrice"].Value,
                        row.Cells["colTotal"].Value
                    );
                }

                txtBillID.Text = billNo;
                txtCustNO.Text = custId.ToString();
                txtPrintPaymentMode.Text = paymentMode;
                txtTotalAmount.Text = grandTotal.ToString();
                
            }
   
        /*private void PrintPage_Load(object sender, EventArgs e)
        {
            txtBillID.Text = _billNo;
            txtCustNO.Text = _custId;
            txtPrintPaymentMode.Text = _paymentMode;
            txtTotalAmount.Text = _totalAmount;

            txtBillID.TabStop = false;
            txtBillID.ReadOnly = true;

            lbldummy.Focus();
            txtCustNO.TabStop = false;
            txtCustNO.ReadOnly = true;
            txtCustNO.SelectionLength = 0;

            txtPrintPaymentMode.SelectionLength = 0;
            txtPrintPaymentMode.TabStop = false;
            txtPrintPaymentMode.ReadOnly = true;

            dtpDate.TabStop = false;

            dataGridViewPrint.TabStop = false;
            dataGridViewPrint.ReadOnly = true;
            dataGridViewPrint.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            dataGridViewPrint.DataSource = _items;
            dataGridViewPrint.ClearSelection();
            dataGridViewPrint.CurrentCell = null;
        }

        private void btnBackToProduct_Click(object sender, EventArgs e)
        {
            FrmHomePage hp = new FrmHomePage();
            hp.Show();
            this.Close();

        }

        private void SaveBillToDatabase()
        {
            try
            {
                string connStr = myConn;
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();

                    foreach (DataGridViewRow row in dataGridViewPrint.Rows)
                    {
                        if (row.IsNewRow) continue;

                        SqlCommand cmd = new SqlCommand(
                            "INSERT INTO Billing ([Bill_Date], [Product_Name], [Product_Price], [Qty], [Amount], [Cust_ID]) VALUES (@Bill_Date, @Product_Name, @Product_Price, @Qty, @Amount, @Cust_ID)", conn);

                        cmd.Parameters.Add("@Bill_Date", SqlDbType.Date).Value = dtpDate.Value;
                        cmd.Parameters.Add("@Product_Name", SqlDbType.NVarChar).Value = row.Cells[1].Value?.ToString() ?? "";
                        cmd.Parameters.Add("@Product_Price", SqlDbType.Int).Value = double.TryParse(row.Cells[2].Value?.ToString(), out double price) ? price : 0;
                        cmd.Parameters.Add("@Qty", SqlDbType.Int).Value = int.TryParse(row.Cells[3].Value?.ToString(), out int qty) ? qty : 0;
                        cmd.Parameters.Add("@Amount", SqlDbType.Int).Value = double.TryParse(row.Cells[4].Value?.ToString(), out double amount) ? amount : 0;
                        cmd.Parameters.Add("@Cust_ID", SqlDbType.Int).Value = int.TryParse(txtCustNO.Text, out int custId) ? custId : 0;

                        cmd.ExecuteNonQuery();
                    }

                    conn.Close();
                }

                MessageBox.Show("Bill data saved successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
            }
        }*/


        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm is FrmHomePage home)
                {
                    new FrmHomePage();

                    home.Show();
                    this.Close();
                    break;
                }
            }
        }

        private void btnSaveAsPDF_Click(object sender, EventArgs e)
        {

            try
            {
                // Panel cha screenshot
                Bitmap bmp = new Bitmap(pnlPrintPage.Width, pnlPrintPage.Height);
                pnlPrintPage.DrawToBitmap(bmp, new System.Drawing.Rectangle(0, 0, pnlPrintPage.Width, pnlPrintPage.Height));

                // Folder path
                string folderPath = @"C:\Users\ATHARV\source\repos\BakeryManagement\Bill PDF";
                if (!Directory.Exists(folderPath))
                    Directory.CreateDirectory(folderPath);

                string filePath = Path.Combine(folderPath, "Bill_" + DateTime.Now.Ticks + ".pdf");

                using (FileStream stream = new FileStream(filePath, FileMode.Create))
                {
                    // *** FIXED LINE ***
                    Document pdfDoc = new Document(new iTextSharp.text.Rectangle((float)bmp.Width, (float)bmp.Height));

                    PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();

                    using (MemoryStream ms = new MemoryStream())
                    {
                        bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                        iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(ms.ToArray());
                        img.ScaleToFit(bmp.Width, bmp.Height);
                        pdfDoc.Add(img);
                    }

                    pdfDoc.Close();
                }

                MessageBox.Show("PDF Saved Successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void lblPrintAmount_Click(object sender, EventArgs e)
        {

        }
    }
}
