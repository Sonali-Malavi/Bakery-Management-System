namespace BakeryManagement
{
    partial class FrmBillingPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBillingPage));
            this.pnlBillingPage = new System.Windows.Forms.Panel();
            this.btnAddtoBill = new System.Windows.Forms.Button();
            this.cmbModeOfPayment = new System.Windows.Forms.ComboBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtSrNo = new System.Windows.Forms.TextBox();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colSrNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lstProductList = new System.Windows.Forms.ListBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtCustId = new System.Windows.Forms.TextBox();
            this.txtBillNo = new System.Windows.Forms.TextBox();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblModeOfPayment = new System.Windows.Forms.Label();
            this.lblSrNo = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblCustId = new System.Windows.Forms.Label();
            this.lblBillNo = new System.Windows.Forms.Label();
            this.pnlBack = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSaveandPrint = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnBilling = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.pnlDashboard = new System.Windows.Forms.Panel();
            this.pnlBillingPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlBack.SuspendLayout();
            this.pnlDashboard.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBillingPage
            // 
            this.pnlBillingPage.BackColor = System.Drawing.SystemColors.Window;
            this.pnlBillingPage.Controls.Add(this.btnAddtoBill);
            this.pnlBillingPage.Controls.Add(this.cmbModeOfPayment);
            this.pnlBillingPage.Controls.Add(this.txtAmount);
            this.pnlBillingPage.Controls.Add(this.txtQuantity);
            this.pnlBillingPage.Controls.Add(this.txtPrice);
            this.pnlBillingPage.Controls.Add(this.txtSrNo);
            this.pnlBillingPage.Controls.Add(this.txtTotalAmount);
            this.pnlBillingPage.Controls.Add(this.dataGridView1);
            this.pnlBillingPage.Controls.Add(this.lstProductList);
            this.pnlBillingPage.Controls.Add(this.dtpDate);
            this.pnlBillingPage.Controls.Add(this.txtCustId);
            this.pnlBillingPage.Controls.Add(this.txtBillNo);
            this.pnlBillingPage.Controls.Add(this.lblTotalAmount);
            this.pnlBillingPage.Controls.Add(this.lblAmount);
            this.pnlBillingPage.Controls.Add(this.lblQuantity);
            this.pnlBillingPage.Controls.Add(this.lblPrice);
            this.pnlBillingPage.Controls.Add(this.lblModeOfPayment);
            this.pnlBillingPage.Controls.Add(this.lblSrNo);
            this.pnlBillingPage.Controls.Add(this.lblDate);
            this.pnlBillingPage.Controls.Add(this.lblCustId);
            this.pnlBillingPage.Controls.Add(this.lblBillNo);
            this.pnlBillingPage.Location = new System.Drawing.Point(71, 12);
            this.pnlBillingPage.Name = "pnlBillingPage";
            this.pnlBillingPage.Size = new System.Drawing.Size(840, 580);
            this.pnlBillingPage.TabIndex = 0;
            this.pnlBillingPage.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBillingPage_Paint);
            // 
            // btnAddtoBill
            // 
            this.btnAddtoBill.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnAddtoBill.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddtoBill.Location = new System.Drawing.Point(96, 287);
            this.btnAddtoBill.Name = "btnAddtoBill";
            this.btnAddtoBill.Size = new System.Drawing.Size(134, 40);
            this.btnAddtoBill.TabIndex = 20;
            this.btnAddtoBill.Text = "Add To Bill";
            this.btnAddtoBill.UseVisualStyleBackColor = false;
            this.btnAddtoBill.Click += new System.EventHandler(this.btnAddtoBill_Click);
            // 
            // cmbModeOfPayment
            // 
            this.cmbModeOfPayment.FormattingEnabled = true;
            this.cmbModeOfPayment.Items.AddRange(new object[] {
            "Cash",
            "UPI"});
            this.cmbModeOfPayment.Location = new System.Drawing.Point(460, 204);
            this.cmbModeOfPayment.Name = "cmbModeOfPayment";
            this.cmbModeOfPayment.Size = new System.Drawing.Size(121, 24);
            this.cmbModeOfPayment.TabIndex = 19;
            this.cmbModeOfPayment.SelectedIndexChanged += new System.EventHandler(this.cmbModeOfPayment_SelectedIndexChanged);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(662, 261);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 22);
            this.txtAmount.TabIndex = 18;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(400, 261);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 22);
            this.txtQuantity.TabIndex = 17;
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(96, 259);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 22);
            this.txtPrice.TabIndex = 16;
            // 
            // txtSrNo
            // 
            this.txtSrNo.Location = new System.Drawing.Point(96, 204);
            this.txtSrNo.Name = "txtSrNo";
            this.txtSrNo.Size = new System.Drawing.Size(100, 22);
            this.txtSrNo.TabIndex = 15;
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Location = new System.Drawing.Point(709, 527);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Size = new System.Drawing.Size(100, 22);
            this.txtTotalAmount.TabIndex = 14;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSrNo,
            this.colProduct,
            this.colPrice,
            this.colQty,
            this.colTotal});
            this.dataGridView1.Location = new System.Drawing.Point(32, 333);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(777, 191);
            this.dataGridView1.TabIndex = 13;
            // 
            // colSrNo
            // 
            this.colSrNo.HeaderText = "Sr No";
            this.colSrNo.MinimumWidth = 6;
            this.colSrNo.Name = "colSrNo";
            this.colSrNo.Width = 125;
            // 
            // colProduct
            // 
            this.colProduct.HeaderText = "Product";
            this.colProduct.MinimumWidth = 6;
            this.colProduct.Name = "colProduct";
            this.colProduct.Width = 125;
            // 
            // colPrice
            // 
            this.colPrice.HeaderText = "Price";
            this.colPrice.MinimumWidth = 6;
            this.colPrice.Name = "colPrice";
            this.colPrice.Width = 125;
            // 
            // colQty
            // 
            this.colQty.HeaderText = "Qty";
            this.colQty.MinimumWidth = 6;
            this.colQty.Name = "colQty";
            this.colQty.Width = 125;
            // 
            // colTotal
            // 
            this.colTotal.HeaderText = "Total";
            this.colTotal.MinimumWidth = 6;
            this.colTotal.Name = "colTotal";
            this.colTotal.Width = 125;
            // 
            // lstProductList
            // 
            this.lstProductList.FormattingEnabled = true;
            this.lstProductList.ItemHeight = 16;
            this.lstProductList.Location = new System.Drawing.Point(62, 98);
            this.lstProductList.Name = "lstProductList";
            this.lstProductList.Size = new System.Drawing.Size(134, 84);
            this.lstProductList.TabIndex = 12;
            this.lstProductList.SelectedIndexChanged += new System.EventHandler(this.lstProductList_SelectedIndexChanged);
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(594, 49);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(180, 22);
            this.dtpDate.TabIndex = 11;
            // 
            // txtCustId
            // 
            this.txtCustId.Location = new System.Drawing.Point(363, 49);
            this.txtCustId.Name = "txtCustId";
            this.txtCustId.Size = new System.Drawing.Size(100, 22);
            this.txtCustId.TabIndex = 10;
            this.txtCustId.TextChanged += new System.EventHandler(this.txtCustId_TextChanged_1);
            // 
            // txtBillNo
            // 
            this.txtBillNo.Location = new System.Drawing.Point(114, 47);
            this.txtBillNo.Name = "txtBillNo";
            this.txtBillNo.Size = new System.Drawing.Size(100, 22);
            this.txtBillNo.TabIndex = 9;
            this.txtBillNo.TextChanged += new System.EventHandler(this.txtBillNo_TextChanged_1);
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.Location = new System.Drawing.Point(571, 527);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(132, 22);
            this.lblTotalAmount.TabIndex = 8;
            this.lblTotalAmount.Text = "Total Amount :";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(555, 259);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(85, 22);
            this.lblAmount.TabIndex = 7;
            this.lblAmount.Text = "Amount :";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(304, 259);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(90, 22);
            this.lblQuantity.TabIndex = 6;
            this.lblQuantity.Text = "Quantity :";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(28, 257);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(63, 22);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "Price :";
            // 
            // lblModeOfPayment
            // 
            this.lblModeOfPayment.AutoSize = true;
            this.lblModeOfPayment.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModeOfPayment.Location = new System.Drawing.Point(293, 202);
            this.lblModeOfPayment.Name = "lblModeOfPayment";
            this.lblModeOfPayment.Size = new System.Drawing.Size(170, 22);
            this.lblModeOfPayment.TabIndex = 4;
            this.lblModeOfPayment.Text = "Mode Of Payment : ";
            // 
            // lblSrNo
            // 
            this.lblSrNo.AutoSize = true;
            this.lblSrNo.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSrNo.Location = new System.Drawing.Point(32, 202);
            this.lblSrNo.Name = "lblSrNo";
            this.lblSrNo.Size = new System.Drawing.Size(67, 22);
            this.lblSrNo.TabIndex = 3;
            this.lblSrNo.Text = "Sr.No :";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(540, 49);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(58, 22);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Date :";
            // 
            // lblCustId
            // 
            this.lblCustId.AutoSize = true;
            this.lblCustId.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustId.Location = new System.Drawing.Point(270, 47);
            this.lblCustId.Name = "lblCustId";
            this.lblCustId.Size = new System.Drawing.Size(87, 22);
            this.lblCustId.TabIndex = 1;
            this.lblCustId.Text = "Cust_Id :";
            // 
            // lblBillNo
            // 
            this.lblBillNo.AutoSize = true;
            this.lblBillNo.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillNo.Location = new System.Drawing.Point(28, 45);
            this.lblBillNo.Name = "lblBillNo";
            this.lblBillNo.Size = new System.Drawing.Size(80, 22);
            this.lblBillNo.TabIndex = 0;
            this.lblBillNo.Text = "Bill No :";
            // 
            // pnlBack
            // 
            this.pnlBack.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlBack.Controls.Add(this.btnExit);
            this.pnlBack.Controls.Add(this.btnSaveandPrint);
            this.pnlBack.Controls.Add(this.btncancel);
            this.pnlBack.Controls.Add(this.btnNew);
            this.pnlBack.Controls.Add(this.pnlBillingPage);
            this.pnlBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBack.Location = new System.Drawing.Point(218, 0);
            this.pnlBack.Name = "pnlBack";
            this.pnlBack.Size = new System.Drawing.Size(1002, 671);
            this.pnlBack.TabIndex = 3;
            this.pnlBack.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBack_Paint);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(699, 611);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 32);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit ";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSaveandPrint
            // 
            this.btnSaveandPrint.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveandPrint.Location = new System.Drawing.Point(481, 611);
            this.btnSaveandPrint.Name = "btnSaveandPrint";
            this.btnSaveandPrint.Size = new System.Drawing.Size(151, 32);
            this.btnSaveandPrint.TabIndex = 3;
            this.btnSaveandPrint.Text = "Save and Print";
            this.btnSaveandPrint.UseVisualStyleBackColor = true;
            this.btnSaveandPrint.Click += new System.EventHandler(this.btnSaveandPrint_Click);
            // 
            // btncancel
            // 
            this.btncancel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.Location = new System.Drawing.Point(353, 611);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 32);
            this.btncancel.TabIndex = 2;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(226, 611);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 32);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(103, 308);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 23);
            this.btnLogOut.TabIndex = 1;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnBilling
            // 
            this.btnBilling.Location = new System.Drawing.Point(103, 262);
            this.btnBilling.Name = "btnBilling";
            this.btnBilling.Size = new System.Drawing.Size(75, 23);
            this.btnBilling.TabIndex = 2;
            this.btnBilling.Text = "Billing";
            this.btnBilling.UseVisualStyleBackColor = true;
            this.btnBilling.Click += new System.EventHandler(this.btnBilling_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.Location = new System.Drawing.Point(103, 214);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(75, 25);
            this.btnProduct.TabIndex = 1;
            this.btnProduct.Text = "Product";
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Location = new System.Drawing.Point(103, 173);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(94, 22);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // pnlDashboard
            // 
            this.pnlDashboard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlDashboard.BackgroundImage")));
            this.pnlDashboard.Controls.Add(this.btnLogOut);
            this.pnlDashboard.Controls.Add(this.btnBilling);
            this.pnlDashboard.Controls.Add(this.btnProduct);
            this.pnlDashboard.Controls.Add(this.btnDashboard);
            this.pnlDashboard.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlDashboard.Location = new System.Drawing.Point(0, 0);
            this.pnlDashboard.Name = "pnlDashboard";
            this.pnlDashboard.Size = new System.Drawing.Size(218, 671);
            this.pnlDashboard.TabIndex = 2;
            // 
            // FrmBillingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 671);
            this.Controls.Add(this.pnlBack);
            this.Controls.Add(this.pnlDashboard);
            this.Name = "FrmBillingPage";
            this.Text = "FrmBillingPage";
            this.pnlBillingPage.ResumeLayout(false);
            this.pnlBillingPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlBack.ResumeLayout(false);
            this.pnlDashboard.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlBillingPage;
        private System.Windows.Forms.Panel pnlBack;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnBilling;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Panel pnlDashboard;
        private System.Windows.Forms.Label lblBillNo;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblModeOfPayment;
        private System.Windows.Forms.Label lblSrNo;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblCustId;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.TextBox txtBillNo;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox txtCustId;
        private System.Windows.Forms.ComboBox cmbModeOfPayment;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtSrNo;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListBox lstProductList;
        private System.Windows.Forms.Button btnAddtoBill;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSaveandPrint;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSrNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
    }
}