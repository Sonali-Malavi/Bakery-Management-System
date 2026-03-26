namespace BakeryManagement
{
    partial class FrmHomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHomePage));
            this.pnlDashboard = new System.Windows.Forms.Panel();
            this.cmbCR = new System.Windows.Forms.ComboBox();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnBilling = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.pnlBack = new System.Windows.Forms.Panel();
            this.pnlProductList = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAddtttoCart = new System.Windows.Forms.Button();
            this.chCreamRoll = new System.Windows.Forms.CheckBox();
            this.chPestry = new System.Windows.Forms.CheckBox();
            this.chbarCake = new System.Windows.Forms.CheckBox();
            this.chCupcake = new System.Windows.Forms.CheckBox();
            this.chToast = new System.Windows.Forms.CheckBox();
            this.chMilkBread = new System.Windows.Forms.CheckBox();
            this.chVegPuff = new System.Windows.Forms.CheckBox();
            this.chCake = new System.Windows.Forms.CheckBox();
            this.chCashioBiscuit = new System.Windows.Forms.CheckBox();
            this.chSandwitchbreads = new System.Windows.Forms.CheckBox();
            this.chNormalbread = new System.Windows.Forms.CheckBox();
            this.chButter = new System.Windows.Forms.CheckBox();
            this.chPizzaBase = new System.Windows.Forms.CheckBox();
            this.chBurgerBun = new System.Windows.Forms.CheckBox();
            this.chNankataiBiscuit = new System.Windows.Forms.CheckBox();
            this.chPavBhajiBread = new System.Windows.Forms.CheckBox();
            this.chMethiKhari = new System.Windows.Forms.CheckBox();
            this.chKhari = new System.Windows.Forms.CheckBox();
            this.pnlDashboard.SuspendLayout();
            this.pnlBack.SuspendLayout();
            this.pnlProductList.SuspendLayout();
            this.SuspendLayout();
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
            this.pnlDashboard.Size = new System.Drawing.Size(218, 646);
            this.pnlDashboard.TabIndex = 0;
            // 
            // cmbCR
            // 
            this.cmbCR.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cmbCR.FormattingEnabled = true;
            this.cmbCR.Items.AddRange(new object[] {
            "CRLogin",
            "CRProduct",
            "CRBilling"});
            this.cmbCR.Location = new System.Drawing.Point(57, 361);
            this.cmbCR.Name = "cmbCR";
            this.cmbCR.Size = new System.Drawing.Size(121, 30);
            this.cmbCR.TabIndex = 4;
            this.cmbCR.Text = "Reports";
            this.cmbCR.SelectedIndexChanged += new System.EventHandler(this.cmbCR_SelectedIndexChanged);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnLogOut.Location = new System.Drawing.Point(57, 308);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(121, 38);
            this.btnLogOut.TabIndex = 1;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnBilling
            // 
            this.btnBilling.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnBilling.Location = new System.Drawing.Point(57, 262);
            this.btnBilling.Name = "btnBilling";
            this.btnBilling.Size = new System.Drawing.Size(121, 40);
            this.btnBilling.TabIndex = 2;
            this.btnBilling.Text = "Billing";
            this.btnBilling.UseVisualStyleBackColor = true;
            this.btnBilling.Click += new System.EventHandler(this.btnBilling_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnProduct.Location = new System.Drawing.Point(57, 214);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(121, 42);
            this.btnProduct.TabIndex = 1;
            this.btnProduct.Text = "Product";
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnDashboard.Location = new System.Drawing.Point(57, 164);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(121, 44);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // pnlBack
            // 
            this.pnlBack.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlBack.BackgroundImage")));
            this.pnlBack.Controls.Add(this.pnlProductList);
            this.pnlBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBack.Location = new System.Drawing.Point(218, 0);
            this.pnlBack.Name = "pnlBack";
            this.pnlBack.Size = new System.Drawing.Size(998, 646);
            this.pnlBack.TabIndex = 1;
            // 
            // pnlProductList
            // 
            this.pnlProductList.BackColor = System.Drawing.Color.PeachPuff;
            this.pnlProductList.Controls.Add(this.btnClear);
            this.pnlProductList.Controls.Add(this.btnAddtttoCart);
            this.pnlProductList.Controls.Add(this.chCreamRoll);
            this.pnlProductList.Controls.Add(this.chPestry);
            this.pnlProductList.Controls.Add(this.chbarCake);
            this.pnlProductList.Controls.Add(this.chCupcake);
            this.pnlProductList.Controls.Add(this.chToast);
            this.pnlProductList.Controls.Add(this.chMilkBread);
            this.pnlProductList.Controls.Add(this.chVegPuff);
            this.pnlProductList.Controls.Add(this.chCake);
            this.pnlProductList.Controls.Add(this.chCashioBiscuit);
            this.pnlProductList.Controls.Add(this.chSandwitchbreads);
            this.pnlProductList.Controls.Add(this.chNormalbread);
            this.pnlProductList.Controls.Add(this.chButter);
            this.pnlProductList.Controls.Add(this.chPizzaBase);
            this.pnlProductList.Controls.Add(this.chBurgerBun);
            this.pnlProductList.Controls.Add(this.chNankataiBiscuit);
            this.pnlProductList.Controls.Add(this.chPavBhajiBread);
            this.pnlProductList.Controls.Add(this.chMethiKhari);
            this.pnlProductList.Controls.Add(this.chKhari);
            this.pnlProductList.Location = new System.Drawing.Point(77, 61);
            this.pnlProductList.Name = "pnlProductList";
            this.pnlProductList.Size = new System.Drawing.Size(840, 530);
            this.pnlProductList.TabIndex = 0;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnClear.Font = new System.Drawing.Font("Modern No. 20", 17F);
            this.btnClear.Location = new System.Drawing.Point(441, 466);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 41);
            this.btnClear.TabIndex = 38;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAddtttoCart
            // 
            this.btnAddtttoCart.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnAddtttoCart.Font = new System.Drawing.Font("Modern No. 20", 17F);
            this.btnAddtttoCart.Location = new System.Drawing.Point(214, 466);
            this.btnAddtttoCart.Name = "btnAddtttoCart";
            this.btnAddtttoCart.Size = new System.Drawing.Size(187, 41);
            this.btnAddtttoCart.TabIndex = 37;
            this.btnAddtttoCart.Text = "Add to Cart";
            this.btnAddtttoCart.UseVisualStyleBackColor = false;
            this.btnAddtttoCart.Click += new System.EventHandler(this.btnAddtttoCart_Click);
            // 
            // chCreamRoll
            // 
            this.chCreamRoll.AutoSize = true;
            this.chCreamRoll.Font = new System.Drawing.Font("Modern No. 20", 18F);
            this.chCreamRoll.Location = new System.Drawing.Point(598, 369);
            this.chCreamRoll.Name = "chCreamRoll";
            this.chCreamRoll.Size = new System.Drawing.Size(172, 35);
            this.chCreamRoll.TabIndex = 36;
            this.chCreamRoll.Text = "Cream Roll";
            this.chCreamRoll.UseVisualStyleBackColor = true;
            // 
            // chPestry
            // 
            this.chPestry.AutoSize = true;
            this.chPestry.Font = new System.Drawing.Font("Modern No. 20", 18F);
            this.chPestry.Location = new System.Drawing.Point(598, 311);
            this.chPestry.Name = "chPestry";
            this.chPestry.Size = new System.Drawing.Size(111, 35);
            this.chPestry.TabIndex = 35;
            this.chPestry.Text = "Pestry";
            this.chPestry.UseVisualStyleBackColor = true;
            // 
            // chbarCake
            // 
            this.chbarCake.AutoSize = true;
            this.chbarCake.Font = new System.Drawing.Font("Modern No. 20", 18F);
            this.chbarCake.Location = new System.Drawing.Point(598, 252);
            this.chbarCake.Name = "chbarCake";
            this.chbarCake.Size = new System.Drawing.Size(148, 35);
            this.chbarCake.TabIndex = 34;
            this.chbarCake.Text = "Bar Cake";
            this.chbarCake.UseVisualStyleBackColor = true;
            // 
            // chCupcake
            // 
            this.chCupcake.AutoSize = true;
            this.chCupcake.Font = new System.Drawing.Font("Modern No. 20", 18F);
            this.chCupcake.Location = new System.Drawing.Point(598, 187);
            this.chCupcake.Name = "chCupcake";
            this.chCupcake.Size = new System.Drawing.Size(148, 35);
            this.chCupcake.TabIndex = 33;
            this.chCupcake.Text = "Cup Cake";
            this.chCupcake.UseVisualStyleBackColor = true;
            // 
            // chToast
            // 
            this.chToast.AutoSize = true;
            this.chToast.Font = new System.Drawing.Font("Modern No. 20", 18F);
            this.chToast.Location = new System.Drawing.Point(598, 130);
            this.chToast.Name = "chToast";
            this.chToast.Size = new System.Drawing.Size(100, 35);
            this.chToast.TabIndex = 32;
            this.chToast.Text = "Toast";
            this.chToast.UseVisualStyleBackColor = true;
            // 
            // chMilkBread
            // 
            this.chMilkBread.AutoSize = true;
            this.chMilkBread.Font = new System.Drawing.Font("Modern No. 20", 18F);
            this.chMilkBread.Location = new System.Drawing.Point(598, 89);
            this.chMilkBread.Name = "chMilkBread";
            this.chMilkBread.Size = new System.Drawing.Size(178, 35);
            this.chMilkBread.TabIndex = 31;
            this.chMilkBread.Text = "Milk Bread";
            this.chMilkBread.UseVisualStyleBackColor = true;
            // 
            // chVegPuff
            // 
            this.chVegPuff.AutoSize = true;
            this.chVegPuff.Font = new System.Drawing.Font("Modern No. 20", 18F);
            this.chVegPuff.Location = new System.Drawing.Point(330, 369);
            this.chVegPuff.Name = "chVegPuff";
            this.chVegPuff.Size = new System.Drawing.Size(145, 35);
            this.chVegPuff.TabIndex = 30;
            this.chVegPuff.Text = "Veg Puff";
            this.chVegPuff.UseVisualStyleBackColor = true;
            // 
            // chCake
            // 
            this.chCake.AutoSize = true;
            this.chCake.Font = new System.Drawing.Font("Modern No. 20", 18F);
            this.chCake.Location = new System.Drawing.Point(330, 311);
            this.chCake.Name = "chCake";
            this.chCake.Size = new System.Drawing.Size(94, 35);
            this.chCake.TabIndex = 29;
            this.chCake.Text = "Cake";
            this.chCake.UseVisualStyleBackColor = true;
            // 
            // chCashioBiscuit
            // 
            this.chCashioBiscuit.AutoSize = true;
            this.chCashioBiscuit.Font = new System.Drawing.Font("Modern No. 20", 18F);
            this.chCashioBiscuit.Location = new System.Drawing.Point(330, 252);
            this.chCashioBiscuit.Name = "chCashioBiscuit";
            this.chCashioBiscuit.Size = new System.Drawing.Size(211, 35);
            this.chCashioBiscuit.TabIndex = 28;
            this.chCashioBiscuit.Text = "Cashio Biscuit";
            this.chCashioBiscuit.UseVisualStyleBackColor = true;
            // 
            // chSandwitchbreads
            // 
            this.chSandwitchbreads.AutoSize = true;
            this.chSandwitchbreads.Font = new System.Drawing.Font("Modern No. 20", 18F);
            this.chSandwitchbreads.Location = new System.Drawing.Point(321, 187);
            this.chSandwitchbreads.Name = "chSandwitchbreads";
            this.chSandwitchbreads.Size = new System.Drawing.Size(246, 35);
            this.chSandwitchbreads.TabIndex = 27;
            this.chSandwitchbreads.Text = "Sandwitch Bread";
            this.chSandwitchbreads.UseVisualStyleBackColor = true;
            // 
            // chNormalbread
            // 
            this.chNormalbread.AutoSize = true;
            this.chNormalbread.Font = new System.Drawing.Font("Modern No. 20", 18F);
            this.chNormalbread.Location = new System.Drawing.Point(321, 130);
            this.chNormalbread.Name = "chNormalbread";
            this.chNormalbread.Size = new System.Drawing.Size(209, 35);
            this.chNormalbread.TabIndex = 26;
            this.chNormalbread.Text = "Normal Bread";
            this.chNormalbread.UseVisualStyleBackColor = true;
            // 
            // chButter
            // 
            this.chButter.AutoSize = true;
            this.chButter.Font = new System.Drawing.Font("Modern No. 20", 18F);
            this.chButter.Location = new System.Drawing.Point(321, 83);
            this.chButter.Name = "chButter";
            this.chButter.Size = new System.Drawing.Size(115, 35);
            this.chButter.TabIndex = 25;
            this.chButter.Text = "Butter";
            this.chButter.UseVisualStyleBackColor = true;
            // 
            // chPizzaBase
            // 
            this.chPizzaBase.AutoSize = true;
            this.chPizzaBase.Font = new System.Drawing.Font("Modern No. 20", 18F);
            this.chPizzaBase.Location = new System.Drawing.Point(60, 369);
            this.chPizzaBase.Name = "chPizzaBase";
            this.chPizzaBase.Size = new System.Drawing.Size(169, 35);
            this.chPizzaBase.TabIndex = 24;
            this.chPizzaBase.Text = "Pizaa Base";
            this.chPizzaBase.UseVisualStyleBackColor = true;
            // 
            // chBurgerBun
            // 
            this.chBurgerBun.AutoSize = true;
            this.chBurgerBun.Font = new System.Drawing.Font("Modern No. 20", 18F);
            this.chBurgerBun.Location = new System.Drawing.Point(60, 311);
            this.chBurgerBun.Name = "chBurgerBun";
            this.chBurgerBun.Size = new System.Drawing.Size(182, 35);
            this.chBurgerBun.TabIndex = 23;
            this.chBurgerBun.Text = "Burger Bun";
            this.chBurgerBun.UseVisualStyleBackColor = true;
            // 
            // chNankataiBiscuit
            // 
            this.chNankataiBiscuit.AutoSize = true;
            this.chNankataiBiscuit.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chNankataiBiscuit.Location = new System.Drawing.Point(60, 252);
            this.chNankataiBiscuit.Name = "chNankataiBiscuit";
            this.chNankataiBiscuit.Size = new System.Drawing.Size(245, 35);
            this.chNankataiBiscuit.TabIndex = 22;
            this.chNankataiBiscuit.Text = "Nankatai Biscuit";
            this.chNankataiBiscuit.UseVisualStyleBackColor = true;
            // 
            // chPavBhajiBread
            // 
            this.chPavBhajiBread.AutoSize = true;
            this.chPavBhajiBread.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chPavBhajiBread.Location = new System.Drawing.Point(60, 187);
            this.chPavBhajiBread.Name = "chPavBhajiBread";
            this.chPavBhajiBread.Size = new System.Drawing.Size(245, 35);
            this.chPavBhajiBread.TabIndex = 21;
            this.chPavBhajiBread.Text = "Pav-Bhaji Bread";
            this.chPavBhajiBread.UseVisualStyleBackColor = true;
            // 
            // chMethiKhari
            // 
            this.chMethiKhari.AutoSize = true;
            this.chMethiKhari.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chMethiKhari.Location = new System.Drawing.Point(60, 130);
            this.chMethiKhari.Name = "chMethiKhari";
            this.chMethiKhari.Size = new System.Drawing.Size(192, 35);
            this.chMethiKhari.TabIndex = 20;
            this.chMethiKhari.Text = "Methi Khari";
            this.chMethiKhari.UseVisualStyleBackColor = true;
            // 
            // chKhari
            // 
            this.chKhari.AutoSize = true;
            this.chKhari.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chKhari.Location = new System.Drawing.Point(60, 74);
            this.chKhari.Name = "chKhari";
            this.chKhari.Size = new System.Drawing.Size(111, 35);
            this.chKhari.TabIndex = 19;
            this.chKhari.Text = "Khari";
            this.chKhari.UseVisualStyleBackColor = true;
            // 
            // FrmHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 646);
            this.Controls.Add(this.pnlBack);
            this.Controls.Add(this.pnlDashboard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmHomePage";
            this.Text = "FrmHomePage";
            this.pnlDashboard.ResumeLayout(false);
            this.pnlBack.ResumeLayout(false);
            this.pnlProductList.ResumeLayout(false);
            this.pnlProductList.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDashboard;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnBilling;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Panel pnlBack;
        private System.Windows.Forms.Panel pnlProductList;
        private System.Windows.Forms.CheckBox chKhari;
        private System.Windows.Forms.CheckBox chMethiKhari;
        private System.Windows.Forms.CheckBox chPavBhajiBread;
        private System.Windows.Forms.CheckBox chPizzaBase;
        private System.Windows.Forms.CheckBox chBurgerBun;
        private System.Windows.Forms.CheckBox chNankataiBiscuit;
        private System.Windows.Forms.CheckBox chButter;
        private System.Windows.Forms.CheckBox chNormalbread;
        private System.Windows.Forms.CheckBox chCashioBiscuit;
        private System.Windows.Forms.CheckBox chSandwitchbreads;
        private System.Windows.Forms.CheckBox chVegPuff;
        private System.Windows.Forms.CheckBox chCake;
        private System.Windows.Forms.CheckBox chMilkBread;
        private System.Windows.Forms.CheckBox chCreamRoll;
        private System.Windows.Forms.CheckBox chPestry;
        private System.Windows.Forms.CheckBox chbarCake;
        private System.Windows.Forms.CheckBox chCupcake;
        private System.Windows.Forms.CheckBox chToast;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAddtttoCart;
        private System.Windows.Forms.ComboBox cmbCR;
    }
}