namespace BakeryManagement
{
    partial class FrmPrintPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSaveAsPDF = new System.Windows.Forms.Button();
            this.lbladdress = new System.Windows.Forms.Label();
            this.lblHeading = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.btnBackToProduct = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.txtPrintPaymentMode = new System.Windows.Forms.TextBox();
            this.lblPrintAmount = new System.Windows.Forms.Label();
            this.lblModeOfPayment = new System.Windows.Forms.Label();
            this.lbldummy = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtBillID = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblPrintBillNo = new System.Windows.Forms.Label();
            this.lblPrintTotal = new System.Windows.Forms.Label();
            this.dataGridViewPrint = new System.Windows.Forms.DataGridView();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCustNO = new System.Windows.Forms.TextBox();
            this.lblPrintCustID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrint)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSaveAsPDF
            // 
            this.btnSaveAsPDF.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnSaveAsPDF.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSaveAsPDF.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAsPDF.Location = new System.Drawing.Point(560, 641);
            this.btnSaveAsPDF.Name = "btnSaveAsPDF";
            this.btnSaveAsPDF.Size = new System.Drawing.Size(253, 45);
            this.btnSaveAsPDF.TabIndex = 38;
            this.btnSaveAsPDF.Text = "Save as PDF";
            this.btnSaveAsPDF.UseVisualStyleBackColor = false;
            this.btnSaveAsPDF.Click += new System.EventHandler(this.btnSaveAsPDF_Click);
            // 
            // lbladdress
            // 
            this.lbladdress.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdress.Location = new System.Drawing.Point(460, 89);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(493, 105);
            this.lbladdress.TabIndex = 24;
            this.lbladdress.Text = "\r\n  700,4th Ln, E Ward, Shahupuri, \r\n  Kolhapur, Maharashtra 416001\r\n\r\n";
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Calisto MT", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(453, 22);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(506, 67);
            this.lblHeading.TabIndex = 21;
            this.lblHeading.Text = "Sai Prasad Bakery";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Location = new System.Drawing.Point(239, 22);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(197, 150);
            this.pictureBoxLogo.TabIndex = 23;
            this.pictureBoxLogo.TabStop = false;
            // 
            // btnBackToProduct
            // 
            this.btnBackToProduct.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnBackToProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBackToProduct.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToProduct.Location = new System.Drawing.Point(353, 641);
            this.btnBackToProduct.Name = "btnBackToProduct";
            this.btnBackToProduct.Size = new System.Drawing.Size(144, 43);
            this.btnBackToProduct.TabIndex = 36;
            this.btnBackToProduct.Text = "Back";
            this.btnBackToProduct.UseVisualStyleBackColor = false;
            this.btnBackToProduct.Click += new System.EventHandler(this.btnBackToProduct_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(-260, 80);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 10);
            this.btnPrint.TabIndex = 37;
            // 
            // txtPrintPaymentMode
            // 
            this.txtPrintPaymentMode.BackColor = System.Drawing.SystemColors.Window;
            this.txtPrintPaymentMode.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrintPaymentMode.Location = new System.Drawing.Point(837, 313);
            this.txtPrintPaymentMode.Name = "txtPrintPaymentMode";
            this.txtPrintPaymentMode.ReadOnly = true;
            this.txtPrintPaymentMode.Size = new System.Drawing.Size(123, 34);
            this.txtPrintPaymentMode.TabIndex = 34;
            // 
            // lblPrintAmount
            // 
            this.lblPrintAmount.BackColor = System.Drawing.SystemColors.Window;
            this.lblPrintAmount.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrintAmount.Location = new System.Drawing.Point(971, 598);
            this.lblPrintAmount.Name = "lblPrintAmount";
            this.lblPrintAmount.Size = new System.Drawing.Size(128, 26);
            this.lblPrintAmount.TabIndex = 33;
            // 
            // lblModeOfPayment
            // 
            this.lblModeOfPayment.AutoSize = true;
            this.lblModeOfPayment.BackColor = System.Drawing.Color.White;
            this.lblModeOfPayment.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModeOfPayment.Location = new System.Drawing.Point(631, 316);
            this.lblModeOfPayment.Name = "lblModeOfPayment";
            this.lblModeOfPayment.Size = new System.Drawing.Size(200, 25);
            this.lblModeOfPayment.TabIndex = 35;
            this.lblModeOfPayment.Text = "Mode of Payment:";
            // 
            // lbldummy
            // 
            this.lbldummy.AutoSize = true;
            this.lbldummy.BackColor = System.Drawing.Color.Transparent;
            this.lbldummy.Location = new System.Drawing.Point(-260, 1062);
            this.lbldummy.Name = "lbldummy";
            this.lbldummy.Size = new System.Drawing.Size(17, 16);
            this.lbldummy.TabIndex = 22;
            this.lbldummy.Text = "\"\"";
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Location = new System.Drawing.Point(733, 235);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(248, 34);
            this.dtpDate.TabIndex = 29;
            // 
            // txtBillID
            // 
            this.txtBillID.BackColor = System.Drawing.SystemColors.Window;
            this.txtBillID.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBillID.HideSelection = false;
            this.txtBillID.Location = new System.Drawing.Point(354, 239);
            this.txtBillID.Name = "txtBillID";
            this.txtBillID.ReadOnly = true;
            this.txtBillID.Size = new System.Drawing.Size(110, 34);
            this.txtBillID.TabIndex = 26;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(650, 242);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(68, 25);
            this.lblDate.TabIndex = 30;
            this.lblDate.Text = "Date:";
            // 
            // lblPrintBillNo
            // 
            this.lblPrintBillNo.AutoSize = true;
            this.lblPrintBillNo.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrintBillNo.Location = new System.Drawing.Point(234, 239);
            this.lblPrintBillNo.Name = "lblPrintBillNo";
            this.lblPrintBillNo.Size = new System.Drawing.Size(86, 25);
            this.lblPrintBillNo.TabIndex = 25;
            this.lblPrintBillNo.Text = "Bill No:";
            // 
            // lblPrintTotal
            // 
            this.lblPrintTotal.AutoSize = true;
            this.lblPrintTotal.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrintTotal.Location = new System.Drawing.Point(816, 598);
            this.lblPrintTotal.Name = "lblPrintTotal";
            this.lblPrintTotal.Size = new System.Drawing.Size(149, 26);
            this.lblPrintTotal.TabIndex = 32;
            this.lblPrintTotal.Text = "Total Amount:";
            // 
            // dataGridViewPrint
            // 
            this.dataGridViewPrint.AllowUserToAddRows = false;
            this.dataGridViewPrint.AllowUserToDeleteRows = false;
            this.dataGridViewPrint.AllowUserToResizeColumns = false;
            this.dataGridViewPrint.AllowUserToResizeRows = false;
            this.dataGridViewPrint.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewPrint.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPrint.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductName,
            this.Qty,
            this.Price,
            this.Total});
            this.dataGridViewPrint.Location = new System.Drawing.Point(156, 372);
            this.dataGridViewPrint.Name = "dataGridViewPrint";
            this.dataGridViewPrint.ReadOnly = true;
            this.dataGridViewPrint.RowHeadersWidth = 51;
            this.dataGridViewPrint.RowTemplate.Height = 24;
            this.dataGridViewPrint.Size = new System.Drawing.Size(956, 211);
            this.dataGridViewPrint.TabIndex = 31;
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "Product";
            this.ProductName.MinimumWidth = 6;
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.Width = 125;
            // 
            // Qty
            // 
            this.Qty.HeaderText = "Quantity";
            this.Qty.MinimumWidth = 6;
            this.Qty.Name = "Qty";
            this.Qty.ReadOnly = true;
            this.Qty.Width = 125;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 125;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 125;
            // 
            // txtCustNO
            // 
            this.txtCustNO.BackColor = System.Drawing.SystemColors.Window;
            this.txtCustNO.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustNO.Location = new System.Drawing.Point(349, 316);
            this.txtCustNO.Name = "txtCustNO";
            this.txtCustNO.ReadOnly = true;
            this.txtCustNO.Size = new System.Drawing.Size(115, 34);
            this.txtCustNO.TabIndex = 28;
            // 
            // lblPrintCustID
            // 
            this.lblPrintCustID.AutoSize = true;
            this.lblPrintCustID.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrintCustID.Location = new System.Drawing.Point(234, 325);
            this.lblPrintCustID.Name = "lblPrintCustID";
            this.lblPrintCustID.Size = new System.Drawing.Size(99, 25);
            this.lblPrintCustID.TabIndex = 27;
            this.lblPrintCustID.Text = "Cust ID:";
            // 
            // FrmPrintPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 713);
            this.Controls.Add(this.btnSaveAsPDF);
            this.Controls.Add(this.lbladdress);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.btnBackToProduct);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.txtPrintPaymentMode);
            this.Controls.Add(this.lblPrintAmount);
            this.Controls.Add(this.lblModeOfPayment);
            this.Controls.Add(this.lbldummy);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.txtBillID);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblPrintBillNo);
            this.Controls.Add(this.lblPrintTotal);
            this.Controls.Add(this.dataGridViewPrint);
            this.Controls.Add(this.txtCustNO);
            this.Controls.Add(this.lblPrintCustID);
            this.Name = "FrmPrintPage";
            this.Text = "FrmPrintPage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrint)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaveAsPDF;
        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button btnBackToProduct;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.TextBox txtPrintPaymentMode;
        private System.Windows.Forms.Label lblPrintAmount;
        private System.Windows.Forms.Label lblModeOfPayment;
        private System.Windows.Forms.Label lbldummy;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox txtBillID;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblPrintBillNo;
        private System.Windows.Forms.Label lblPrintTotal;
        private System.Windows.Forms.DataGridView dataGridViewPrint;
        private System.Windows.Forms.TextBox txtCustNO;
        private System.Windows.Forms.Label lblPrintCustID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}