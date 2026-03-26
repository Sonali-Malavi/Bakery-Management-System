namespace BakeryManagement
{
    partial class FrmDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDashboard));
            this.dataGridViewTotal = new System.Windows.Forms.DataGridView();
            this.dataGridViewToday = new System.Windows.Forms.DataGridView();
            this.lblTotalSold = new System.Windows.Forms.Label();
            this.lblTodaysSold = new System.Windows.Forms.Label();
            this.btnrefersh = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.pnlDashboard = new System.Windows.Forms.Panel();
            this.cmbCR = new System.Windows.Forms.ComboBox();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnBilling = new System.Windows.Forms.Button();
            this.btnBackToProduct = new System.Windows.Forms.Button();
            this.lblLowStock = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewToday)).BeginInit();
            this.pnlDashboard.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewTotal
            // 
            this.dataGridViewTotal.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.dataGridViewTotal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTotal.Location = new System.Drawing.Point(252, 37);
            this.dataGridViewTotal.Name = "dataGridViewTotal";
            this.dataGridViewTotal.RowHeadersWidth = 51;
            this.dataGridViewTotal.RowTemplate.Height = 24;
            this.dataGridViewTotal.Size = new System.Drawing.Size(807, 201);
            this.dataGridViewTotal.TabIndex = 0;
            // 
            // dataGridViewToday
            // 
            this.dataGridViewToday.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.dataGridViewToday.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewToday.Location = new System.Drawing.Point(254, 294);
            this.dataGridViewToday.Name = "dataGridViewToday";
            this.dataGridViewToday.RowHeadersWidth = 51;
            this.dataGridViewToday.RowTemplate.Height = 24;
            this.dataGridViewToday.Size = new System.Drawing.Size(680, 210);
            this.dataGridViewToday.TabIndex = 1;
            // 
            // lblTotalSold
            // 
            this.lblTotalSold.AutoSize = true;
            this.lblTotalSold.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSold.Location = new System.Drawing.Point(249, 5);
            this.lblTotalSold.Name = "lblTotalSold";
            this.lblTotalSold.Size = new System.Drawing.Size(241, 25);
            this.lblTotalSold.TabIndex = 2;
            this.lblTotalSold.Text = "Total Sold Products :";
            // 
            // lblTodaysSold
            // 
            this.lblTodaysSold.AutoSize = true;
            this.lblTodaysSold.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodaysSold.Location = new System.Drawing.Point(249, 262);
            this.lblTodaysSold.Name = "lblTodaysSold";
            this.lblTodaysSold.Size = new System.Drawing.Size(228, 25);
            this.lblTodaysSold.TabIndex = 3;
            this.lblTodaysSold.Text = "Today\'s Sold Items :";
            // 
            // btnrefersh
            // 
            this.btnrefersh.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrefersh.Location = new System.Drawing.Point(949, 584);
            this.btnrefersh.Name = "btnrefersh";
            this.btnrefersh.Size = new System.Drawing.Size(137, 46);
            this.btnrefersh.TabIndex = 4;
            this.btnrefersh.Text = "Refresh";
            this.btnrefersh.UseVisualStyleBackColor = true;
            this.btnrefersh.Click += new System.EventHandler(this.btnrefersh_Click);
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
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
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
            this.pnlDashboard.Size = new System.Drawing.Size(218, 705);
            this.pnlDashboard.TabIndex = 7;
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
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
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
            this.btnBilling.Click += new System.EventHandler(this.btnBilling_Click);
            // 
            // btnBackToProduct
            // 
            this.btnBackToProduct.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToProduct.Location = new System.Drawing.Point(637, 584);
            this.btnBackToProduct.Name = "btnBackToProduct";
            this.btnBackToProduct.Size = new System.Drawing.Size(266, 40);
            this.btnBackToProduct.TabIndex = 6;
            this.btnBackToProduct.Text = "Back To Product";
            this.btnBackToProduct.UseVisualStyleBackColor = true;
            this.btnBackToProduct.Click += new System.EventHandler(this.btnBackToProduct_Click);
            // 
            // lblLowStock
            // 
            this.lblLowStock.AutoSize = true;
            this.lblLowStock.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLowStock.Location = new System.Drawing.Point(262, 517);
            this.lblLowStock.Name = "lblLowStock";
            this.lblLowStock.Size = new System.Drawing.Size(139, 25);
            this.lblLowStock.TabIndex = 5;
            this.lblLowStock.Text = "Low Stock :";
            // 
            // FrmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1222, 705);
            this.Controls.Add(this.pnlDashboard);
            this.Controls.Add(this.btnBackToProduct);
            this.Controls.Add(this.lblLowStock);
            this.Controls.Add(this.btnrefersh);
            this.Controls.Add(this.lblTodaysSold);
            this.Controls.Add(this.lblTotalSold);
            this.Controls.Add(this.dataGridViewToday);
            this.Controls.Add(this.dataGridViewTotal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmDashboard";
            this.Text = "FrmDashboard";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewToday)).EndInit();
            this.pnlDashboard.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTotal;
        private System.Windows.Forms.DataGridView dataGridViewToday;
        private System.Windows.Forms.Label lblTotalSold;
        private System.Windows.Forms.Label lblTodaysSold;
        private System.Windows.Forms.Button btnrefersh;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Panel pnlDashboard;
        private System.Windows.Forms.ComboBox cmbCR;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnBilling;
        private System.Windows.Forms.Button btnBackToProduct;
        private System.Windows.Forms.Label lblLowStock;
    }
}