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
            this.dataGridViewTotal = new System.Windows.Forms.DataGridView();
            this.dataGridViewToday = new System.Windows.Forms.DataGridView();
            this.lblTotalSold = new System.Windows.Forms.Label();
            this.lblTodaysSold = new System.Windows.Forms.Label();
            this.btnrefersh = new System.Windows.Forms.Button();
            this.lblLowStock = new System.Windows.Forms.Label();
            this.btnBackToProduct = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewToday)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTotal
            // 
            this.dataGridViewTotal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTotal.Location = new System.Drawing.Point(74, 28);
            this.dataGridViewTotal.Name = "dataGridViewTotal";
            this.dataGridViewTotal.RowHeadersWidth = 51;
            this.dataGridViewTotal.RowTemplate.Height = 24;
            this.dataGridViewTotal.Size = new System.Drawing.Size(807, 201);
            this.dataGridViewTotal.TabIndex = 0;
             // 
            // dataGridViewToday
            // 
            this.dataGridViewToday.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewToday.Location = new System.Drawing.Point(74, 268);
            this.dataGridViewToday.Name = "dataGridViewToday";
            this.dataGridViewToday.RowHeadersWidth = 51;
            this.dataGridViewToday.RowTemplate.Height = 24;
            this.dataGridViewToday.Size = new System.Drawing.Size(680, 210);
            this.dataGridViewToday.TabIndex = 1;
            // 
            // lblTotalSold
            // 
            this.lblTotalSold.AutoSize = true;
            this.lblTotalSold.Location = new System.Drawing.Point(35, 9);
            this.lblTotalSold.Name = "lblTotalSold";
            this.lblTotalSold.Size = new System.Drawing.Size(131, 16);
            this.lblTotalSold.TabIndex = 2;
            this.lblTotalSold.Text = "Total Sold Products :";
             // 
            // lblTodaysSold
            // 
            this.lblTodaysSold.AutoSize = true;
            this.lblTodaysSold.Location = new System.Drawing.Point(35, 249);
            this.lblTodaysSold.Name = "lblTodaysSold";
            this.lblTodaysSold.Size = new System.Drawing.Size(129, 16);
            this.lblTodaysSold.TabIndex = 3;
            this.lblTodaysSold.Text = "Today\'s Sold Items :";
            // 
            // btnrefersh
            // 
            this.btnrefersh.Location = new System.Drawing.Point(949, 584);
            this.btnrefersh.Name = "btnrefersh";
            this.btnrefersh.Size = new System.Drawing.Size(75, 46);
            this.btnrefersh.TabIndex = 4;
            this.btnrefersh.Text = "Refresh";
            this.btnrefersh.UseVisualStyleBackColor = true;
            this.btnrefersh.Click += new System.EventHandler(this.btnrefersh_Click);
            // 
            // lblLowStock
            // 
            this.lblLowStock.AutoSize = true;
            this.lblLowStock.Location = new System.Drawing.Point(71, 517);
            this.lblLowStock.Name = "lblLowStock";
            this.lblLowStock.Size = new System.Drawing.Size(68, 16);
            this.lblLowStock.TabIndex = 5;
            this.lblLowStock.Text = "Low Stock";
            // 
            // btnBackToProduct
            // 
            this.btnBackToProduct.Location = new System.Drawing.Point(785, 596);
            this.btnBackToProduct.Name = "btnBackToProduct";
            this.btnBackToProduct.Size = new System.Drawing.Size(135, 34);
            this.btnBackToProduct.TabIndex = 6;
            this.btnBackToProduct.Text = "Back To Product";
            this.btnBackToProduct.UseVisualStyleBackColor = true;
            this.btnBackToProduct.Click += new System.EventHandler(this.btnBackToProduct_Click);
            // 
            // FrmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 705);
            this.Controls.Add(this.btnBackToProduct);
            this.Controls.Add(this.lblLowStock);
            this.Controls.Add(this.btnrefersh);
            this.Controls.Add(this.lblTodaysSold);
            this.Controls.Add(this.lblTotalSold);
            this.Controls.Add(this.dataGridViewToday);
            this.Controls.Add(this.dataGridViewTotal);
            this.Name = "FrmDashboard";
            this.Text = "FrmDashboard";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewToday)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTotal;
        private System.Windows.Forms.DataGridView dataGridViewToday;
        private System.Windows.Forms.Label lblTotalSold;
        private System.Windows.Forms.Label lblTodaysSold;
        private System.Windows.Forms.Button btnrefersh;
        private System.Windows.Forms.Label lblLowStock;
        private System.Windows.Forms.Button btnBackToProduct;
    }
}