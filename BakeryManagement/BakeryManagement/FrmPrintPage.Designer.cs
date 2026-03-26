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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrintPage));
            this.pnlPrintPage = new System.Windows.Forms.Panel();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
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
            this.lblPrintCustID = new System.Windows.Forms.Label();
            this.lbladdress = new System.Windows.Forms.Label();
            this.lblHeading = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.txtPrintPaymentMode = new System.Windows.Forms.TextBox();
            this.lblModeOfPayment = new System.Windows.Forms.Label();
            this.lbldummy = new System.Windows.Forms.Label();
            this.txtCustNO = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSaveAsPDF = new System.Windows.Forms.Button();
            this.pnlPrintPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPrintPage
            // 
            this.pnlPrintPage.BackColor = System.Drawing.Color.PeachPuff;
            this.pnlPrintPage.Controls.Add(this.txtTotalAmount);
            this.pnlPrintPage.Controls.Add(this.dtpDate);
            this.pnlPrintPage.Controls.Add(this.txtBillID);
            this.pnlPrintPage.Controls.Add(this.lblDate);
            this.pnlPrintPage.Controls.Add(this.lblPrintBillNo);
            this.pnlPrintPage.Controls.Add(this.lblPrintTotal);
            this.pnlPrintPage.Controls.Add(this.dataGridViewPrint);
            this.pnlPrintPage.Controls.Add(this.lblPrintCustID);
            this.pnlPrintPage.Controls.Add(this.lbladdress);
            this.pnlPrintPage.Controls.Add(this.lblHeading);
            this.pnlPrintPage.Controls.Add(this.pictureBoxLogo);
            this.pnlPrintPage.Controls.Add(this.btnPrint);
            this.pnlPrintPage.Controls.Add(this.txtPrintPaymentMode);
            this.pnlPrintPage.Controls.Add(this.lblModeOfPayment);
            this.pnlPrintPage.Controls.Add(this.lbldummy);
            this.pnlPrintPage.Controls.Add(this.txtCustNO);
            this.pnlPrintPage.Location = new System.Drawing.Point(174, 12);
            this.pnlPrintPage.Name = "pnlPrintPage";
            this.pnlPrintPage.Size = new System.Drawing.Size(948, 674);
            this.pnlPrintPage.TabIndex = 0;
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalAmount.Location = new System.Drawing.Point(795, 582);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Size = new System.Drawing.Size(123, 29);
            this.txtTotalAmount.TabIndex = 76;
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Modern No. 20", 12F);
            this.dtpDate.Location = new System.Drawing.Point(539, 219);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(248, 29);
            this.dtpDate.TabIndex = 65;
            // 
            // txtBillID
            // 
            this.txtBillID.BackColor = System.Drawing.SystemColors.Window;
            this.txtBillID.Font = new System.Drawing.Font("Modern No. 20", 12F);
            this.txtBillID.HideSelection = false;
            this.txtBillID.Location = new System.Drawing.Point(147, 218);
            this.txtBillID.Name = "txtBillID";
            this.txtBillID.ReadOnly = true;
            this.txtBillID.Size = new System.Drawing.Size(110, 29);
            this.txtBillID.TabIndex = 62;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(465, 219);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(67, 25);
            this.lblDate.TabIndex = 66;
            this.lblDate.Text = "Date:";
            // 
            // lblPrintBillNo
            // 
            this.lblPrintBillNo.AutoSize = true;
            this.lblPrintBillNo.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrintBillNo.Location = new System.Drawing.Point(40, 223);
            this.lblPrintBillNo.Name = "lblPrintBillNo";
            this.lblPrintBillNo.Size = new System.Drawing.Size(101, 25);
            this.lblPrintBillNo.TabIndex = 61;
            this.lblPrintBillNo.Text = "Bill No:";
            // 
            // lblPrintTotal
            // 
            this.lblPrintTotal.AutoSize = true;
            this.lblPrintTotal.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrintTotal.Location = new System.Drawing.Point(610, 582);
            this.lblPrintTotal.Name = "lblPrintTotal";
            this.lblPrintTotal.Size = new System.Drawing.Size(168, 25);
            this.lblPrintTotal.TabIndex = 68;
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
            this.dataGridViewPrint.Location = new System.Drawing.Point(140, 357);
            this.dataGridViewPrint.Name = "dataGridViewPrint";
            this.dataGridViewPrint.ReadOnly = true;
            this.dataGridViewPrint.RowHeadersWidth = 51;
            this.dataGridViewPrint.RowTemplate.Height = 24;
            this.dataGridViewPrint.Size = new System.Drawing.Size(738, 211);
            this.dataGridViewPrint.TabIndex = 67;
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
            // lblPrintCustID
            // 
            this.lblPrintCustID.AutoSize = true;
            this.lblPrintCustID.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrintCustID.Location = new System.Drawing.Point(40, 297);
            this.lblPrintCustID.Name = "lblPrintCustID";
            this.lblPrintCustID.Size = new System.Drawing.Size(99, 26);
            this.lblPrintCustID.TabIndex = 63;
            this.lblPrintCustID.Text = "Cust ID:";
            // 
            // lbladdress
            // 
            this.lbladdress.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdress.Location = new System.Drawing.Point(272, 97);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(493, 105);
            this.lbladdress.TabIndex = 60;
            this.lbladdress.Text = "E Ward, Sambhaji Nagar Bus Stand,               Kolhapur , Maharastra - 416 002";
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Calisto MT", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(272, 21);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(506, 67);
            this.lblHeading.TabIndex = 57;
            this.lblHeading.Text = "Sai Prasad Bakery";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.BackgroundImage")));
            this.pictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxLogo.Location = new System.Drawing.Point(45, 6);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(208, 149);
            this.pictureBoxLogo.TabIndex = 59;
            this.pictureBoxLogo.TabStop = false;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(-454, 64);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 10);
            this.btnPrint.TabIndex = 73;
            // 
            // txtPrintPaymentMode
            // 
            this.txtPrintPaymentMode.BackColor = System.Drawing.SystemColors.Window;
            this.txtPrintPaymentMode.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrintPaymentMode.Location = new System.Drawing.Point(643, 297);
            this.txtPrintPaymentMode.Name = "txtPrintPaymentMode";
            this.txtPrintPaymentMode.ReadOnly = true;
            this.txtPrintPaymentMode.Size = new System.Drawing.Size(123, 27);
            this.txtPrintPaymentMode.TabIndex = 70;
            // 
            // lblModeOfPayment
            // 
            this.lblModeOfPayment.AutoSize = true;
            this.lblModeOfPayment.BackColor = System.Drawing.Color.PeachPuff;
            this.lblModeOfPayment.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModeOfPayment.Location = new System.Drawing.Point(437, 300);
            this.lblModeOfPayment.Name = "lblModeOfPayment";
            this.lblModeOfPayment.Size = new System.Drawing.Size(206, 25);
            this.lblModeOfPayment.TabIndex = 71;
            this.lblModeOfPayment.Text = "Mode of Payment:";
            // 
            // lbldummy
            // 
            this.lbldummy.AutoSize = true;
            this.lbldummy.BackColor = System.Drawing.Color.Transparent;
            this.lbldummy.Location = new System.Drawing.Point(-454, 1046);
            this.lbldummy.Name = "lbldummy";
            this.lbldummy.Size = new System.Drawing.Size(18, 17);
            this.lbldummy.TabIndex = 58;
            this.lbldummy.Text = "\"\"";
            // 
            // txtCustNO
            // 
            this.txtCustNO.BackColor = System.Drawing.SystemColors.Window;
            this.txtCustNO.Font = new System.Drawing.Font("Modern No. 20", 12F);
            this.txtCustNO.Location = new System.Drawing.Point(142, 289);
            this.txtCustNO.Name = "txtCustNO";
            this.txtCustNO.ReadOnly = true;
            this.txtCustNO.Size = new System.Drawing.Size(115, 29);
            this.txtCustNO.TabIndex = 64;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SeaShell;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(364, 684);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 43);
            this.button1.TabIndex = 73;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSaveAsPDF
            // 
            this.btnSaveAsPDF.BackColor = System.Drawing.Color.SeaShell;
            this.btnSaveAsPDF.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSaveAsPDF.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAsPDF.Location = new System.Drawing.Point(558, 682);
            this.btnSaveAsPDF.Name = "btnSaveAsPDF";
            this.btnSaveAsPDF.Size = new System.Drawing.Size(253, 45);
            this.btnSaveAsPDF.TabIndex = 75;
            this.btnSaveAsPDF.Text = "Save as PDF";
            this.btnSaveAsPDF.UseVisualStyleBackColor = false;
            this.btnSaveAsPDF.Click += new System.EventHandler(this.btnSaveAsPDF_Click);
            // 
            // FrmPrintPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1200, 737);
            this.Controls.Add(this.btnSaveAsPDF);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pnlPrintPage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmPrintPage";
            this.Text = "FrmPrintPage";
            this.pnlPrintPage.ResumeLayout(false);
            this.pnlPrintPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPrintPage;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox txtBillID;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblPrintBillNo;
        private System.Windows.Forms.Label lblPrintTotal;
        private System.Windows.Forms.DataGridView dataGridViewPrint;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Label lblPrintCustID;
        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.TextBox txtPrintPaymentMode;
        private System.Windows.Forms.Label lblModeOfPayment;
        private System.Windows.Forms.Label lbldummy;
        private System.Windows.Forms.TextBox txtCustNO;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSaveAsPDF;
        private System.Windows.Forms.TextBox txtTotalAmount;
    }
}