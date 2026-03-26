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
        private static string myConn = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BakeryManagement;Integrated Security=True";
        public SqlConnection conn = new SqlConnection(myConn);
        private string _billNo;
        private string _custId;
        private string _paymentMode;
        private string _totalAmount;
        private List<BillItem> _items;
        public FrmPrintPage(string billNo, string custId, string paymentMode, string totalAmount, List<BillItem> items)
        {

            InitializeComponent();


            _billNo = billNo;
            _custId = custId;
            _paymentMode = paymentMode;
            _totalAmount = totalAmount;
            _items = items;

        }
        private void PrintPage_Load(object sender, EventArgs e)
        {
            txtBillID.Text = _billNo;
            txtCustNO.Text = _custId;
            txtPrintPaymentMode.Text = _paymentMode;
            lblPrintAmount.Text = _totalAmount;

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
            /*string folderPath = Path.Combine(Application.StartupPath, "BillsPDF");
            Directory.CreateDirectory(folderPath);

            string fileName = "Bill_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".pdf";
            string filePath = Path.Combine(folderPath, fileName);

            PdfWriter writer = new PdfWriter(filePath);
            PdfDocument pdf = new PdfDocument(writer);
            Document document = new Document(pdf, PageSize.A4);

            // 🔹 Title
            Paragraph title = new Paragraph("Bakery Billing Receipt")
                .SetTextAlignment(TextAlignment.CENTER)
                .SetFontSize(18)
                .SetBold();

            document.Add(title);
            document.Add(new Paragraph("\n"));

            // 🔹 Table (same columns as DataGridView)
            int columnCount = dataGridViewPrint.Columns.Count;
            Table table = new Table(columnCount).UseAllAvailableWidth();

            // Header
            foreach (DataGridViewColumn col in dataGridViewPrint.Columns)
            {
                table.AddHeaderCell(new Cell().Add(new Paragraph(col.HeaderText).SetBold()));
            }

            // Rows
            foreach (DataGridViewRow row in dataGridViewPrint.Rows)
            {
                if (row.IsNewRow) continue;

                foreach (DataGridViewCell cell in row.Cells)
                {
                    table.AddCell(cell.Value?.ToString() ?? "");
                }
            }

            document.Add(table);
            document.Add(new Paragraph("\n"));

            // 🔹 Total (optional)
            document.Add(new Paragraph("Total Amount: ₹" + lblPrintTotal.Text)
                .SetTextAlignment(TextAlignment.RIGHT)
                .SetBold());

            document.Close();

            MessageBox.Show("PDF Bill Saved Successfully ✅");*/
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
        }
    }
}
