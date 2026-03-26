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
            this.pnlDashboard = new System.Windows.Forms.Panel();
            this.cmbCR = new System.Windows.Forms.ComboBox();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnBilling = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.pnlBillingPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlBack.SuspendLayout();
            this.pnlDashboard.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBillingPage
            // 
            this.pnlBillingPage.BackColor = System.Drawing.Color.PeachPuff;
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
            // 
            // btnAddtoBill
            // 
            this.btnAddtoBill.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnAddtoBill.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Bold);
            this.btnAddtoBill.Location = new System.Drawing.Point(96, 287);
            this.btnAddtoBill.Name = "btnAddtoBill";
            this.btnAddtoBill.Size = new System.Drawing.Size(171, 40);
            this.btnAddtoBill.TabIndex = 20;
            this.btnAddtoBill.Text = "Add To Bill";
            this.btnAddtoBill.UseVisualStyleBackColor = false;
            this.btnAddtoBill.Click += new System.EventHandler(this.btnAddtoBill_Click);
            // 
            // cmbModeOfPayment
            // 
            this.cmbModeOfPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cmbModeOfPayment.FormattingEnabled = true;
            this.cmbModeOfPayment.Items.AddRange(new object[] {
            "Cash",
            "UPI"});
            this.cmbModeOfPayment.Location = new System.Drawing.Point(483, 199);
            this.cmbModeOfPayment.Name = "cmbModeOfPayment";
            this.cmbModeOfPayment.Size = new System.Drawing.Size(121, 30);
            this.cmbModeOfPayment.TabIndex = 19;
            this.cmbModeOfPayment.SelectedIndexChanged += new System.EventHandler(this.cmbModeOfPayment_SelectedIndexChanged);
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtAmount.Location = new System.Drawing.Point(662, 261);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 28);
            this.txtAmount.TabIndex = 18;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtQuantity.Location = new System.Drawing.Point(400, 261);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 28);
            this.txtQuantity.TabIndex = 17;
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtPrice.Location = new System.Drawing.Point(96, 250);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 28);
            this.txtPrice.TabIndex = 16;
            // 
            // txtSrNo
            // 
            this.txtSrNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtSrNo.Location = new System.Drawing.Point(96, 196);
            this.txtSrNo.Name = "txtSrNo";
            this.txtSrNo.Size = new System.Drawing.Size(100, 28);
            this.txtSrNo.TabIndex = 15;
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtTotalAmount.Location = new System.Drawing.Point(709, 527);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Size = new System.Drawing.Size(100, 28);
            this.txtTotalAmount.TabIndex = 14;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SeaShell;
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
            this.lstProductList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lstProductList.FormattingEnabled = true;
            this.lstProductList.ItemHeight = 22;
            this.lstProductList.Location = new System.Drawing.Point(62, 98);
            this.lstProductList.Name = "lstProductList";
            this.lstProductList.Size = new System.Drawing.Size(134, 70);
            this.lstProductList.TabIndex = 12;
            this.lstProductList.SelectedIndexChanged += new System.EventHandler(this.lstProductList_SelectedIndexChanged);
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dtpDate.Location = new System.Drawing.Point(598, 47);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(180, 28);
            this.dtpDate.TabIndex = 11;
            // 
            // txtCustId
            // 
            this.txtCustId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtCustId.Location = new System.Drawing.Point(372, 46);
            this.txtCustId.Name = "txtCustId";
            this.txtCustId.Size = new System.Drawing.Size(100, 28);
            this.txtCustId.TabIndex = 10;
            this.txtCustId.TextChanged += new System.EventHandler(this.txtCustId_TextChanged_1);
            // 
            // txtBillNo
            // 
            this.txtBillNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtBillNo.Location = new System.Drawing.Point(121, 43);
            this.txtBillNo.Name = "txtBillNo";
            this.txtBillNo.Size = new System.Drawing.Size(96, 28);
            this.txtBillNo.TabIndex = 9;
            this.txtBillNo.TextChanged += new System.EventHandler(this.txtBillNo_TextChanged_1);
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.Location = new System.Drawing.Point(541, 527);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(176, 25);
            this.lblTotalAmount.TabIndex = 8;
            this.lblTotalAmount.Text = "Total Amount :";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(555, 259);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(111, 25);
            this.lblAmount.TabIndex = 7;
            this.lblAmount.Text = "Amount :";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(284, 259);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(120, 25);
            this.lblQuantity.TabIndex = 6;
            this.lblQuantity.Text = "Quantity :";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(20, 250);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(84, 25);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "Price :";
            // 
            // lblModeOfPayment
            // 
            this.lblModeOfPayment.AutoSize = true;
            this.lblModeOfPayment.BackColor = System.Drawing.Color.PeachPuff;
            this.lblModeOfPayment.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModeOfPayment.Location = new System.Drawing.Point(255, 204);
            this.lblModeOfPayment.Name = "lblModeOfPayment";
            this.lblModeOfPayment.Size = new System.Drawing.Size(226, 25);
            this.lblModeOfPayment.TabIndex = 4;
            this.lblModeOfPayment.Text = "Mode Of Payment : ";
            // 
            // lblSrNo
            // 
            this.lblSrNo.AutoSize = true;
            this.lblSrNo.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSrNo.Location = new System.Drawing.Point(18, 196);
            this.lblSrNo.Name = "lblSrNo";
            this.lblSrNo.Size = new System.Drawing.Size(86, 25);
            this.lblSrNo.TabIndex = 3;
            this.lblSrNo.Text = "Sr.No :";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(529, 47);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(75, 25);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Date :";
            // 
            // lblCustId
            // 
            this.lblCustId.AutoSize = true;
            this.lblCustId.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustId.Location = new System.Drawing.Point(266, 47);
            this.lblCustId.Name = "lblCustId";
            this.lblCustId.Size = new System.Drawing.Size(113, 25);
            this.lblCustId.TabIndex = 1;
            this.lblCustId.Text = "Cust_Id :";
            // 
            // lblBillNo
            // 
            this.lblBillNo.AutoSize = true;
            this.lblBillNo.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillNo.Location = new System.Drawing.Point(18, 44);
            this.lblBillNo.Name = "lblBillNo";
            this.lblBillNo.Size = new System.Drawing.Size(109, 25);
            this.lblBillNo.TabIndex = 0;
            this.lblBillNo.Text = "Bill No :";
            // 
            // pnlBack
            // 
            this.pnlBack.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlBack.BackgroundImage")));
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
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.Window;
            this.btnExit.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(654, 611);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(91, 32);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit ";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSaveandPrint
            // 
            this.btnSaveandPrint.BackColor = System.Drawing.SystemColors.Window;
            this.btnSaveandPrint.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveandPrint.Location = new System.Drawing.Point(402, 611);
            this.btnSaveandPrint.Name = "btnSaveandPrint";
            this.btnSaveandPrint.Size = new System.Drawing.Size(216, 32);
            this.btnSaveandPrint.TabIndex = 3;
            this.btnSaveandPrint.Text = "Save and Print";
            this.btnSaveandPrint.UseVisualStyleBackColor = false;
            this.btnSaveandPrint.Click += new System.EventHandler(this.btnSaveandPrint_Click);
            // 
            // btncancel
            // 
            this.btncancel.BackColor = System.Drawing.SystemColors.Window;
            this.btncancel.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.Location = new System.Drawing.Point(250, 611);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(118, 32);
            this.btncancel.TabIndex = 2;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = false;
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.SystemColors.Window;
            this.btnNew.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(115, 611);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(88, 32);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // pnlDashboard
            // 
            this.pnlDashboard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlDashboard.BackgroundImage")));
            this.pnlDashboard.Controls.Add(this.cmbCR);
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
            // cmbCR
            // 
            this.cmbCR.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cmbCR.FormattingEnabled = true;
            this.cmbCR.Location = new System.Drawing.Point(49, 352);
            this.cmbCR.Name = "cmbCR";
            this.cmbCR.Size = new System.Drawing.Size(121, 30);
            this.cmbCR.TabIndex = 9;
            this.cmbCR.Text = "Reports";
            this.cmbCR.SelectedIndexChanged += new System.EventHandler(this.cmbCR_SelectedIndexChanged);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnLogOut.Location = new System.Drawing.Point(49, 308);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(121, 38);
            this.btnLogOut.TabIndex = 6;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click_1);
            // 
            // btnBilling
            // 
            this.btnBilling.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnBilling.Location = new System.Drawing.Point(49, 262);
            this.btnBilling.Name = "btnBilling";
            this.btnBilling.Size = new System.Drawing.Size(121, 40);
            this.btnBilling.TabIndex = 8;
            this.btnBilling.Text = "Billing";
            this.btnBilling.UseVisualStyleBackColor = true;
            // 
            // btnProduct
            // 
            this.btnProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnProduct.Location = new System.Drawing.Point(49, 212);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(121, 42);
            this.btnProduct.TabIndex = 7;
            this.btnProduct.Text = "Product";
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click_1);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnDashboard.Location = new System.Drawing.Point(49, 162);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(121, 44);
            this.btnDashboard.TabIndex = 5;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // FrmBillingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 671);
            this.Controls.Add(this.pnlBack);
            this.Controls.Add(this.pnlDashboard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnBilling;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.ComboBox cmbCR;
    }
}