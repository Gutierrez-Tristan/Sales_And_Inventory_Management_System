namespace SAIMS.UI
{
    partial class POS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(POS));
            panel1 = new Panel();
            btnLogout = new Button();
            btnStockInquiry = new Button();
            btnTransaction = new Button();
            btnCategories = new Button();
            btnDashboard = new Button();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            dgvProducts = new DataGridView();
            txtSearch = new TextBox();
            label1 = new Label();
            btnAddToCart = new Button();
            btnRemoveItem = new Button();
            panel2 = new Panel();
            lblCart = new Label();
            dgvCart = new DataGridView();
            label3 = new Label();
            label4 = new Label();
            txtDiscount = new TextBox();
            txtTotal = new TextBox();
            label5 = new Label();
            numQty = new NumericUpDown();
            btnClear = new Button();
            label6 = new Label();
            txtSubtotal = new TextBox();
            btnCheckout = new Button();
            pnlPayment = new Panel();
            panel4 = new Panel();
            btnPayCancel = new Button();
            btnPayConfirm = new Button();
            txtPayChange = new TextBox();
            txtPayAmount = new TextBox();
            txtPayTotal = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numQty).BeginInit();
            pnlPayment.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.OrangeRed;
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(btnStockInquiry);
            panel1.Controls.Add(btnTransaction);
            panel1.Controls.Add(btnCategories);
            panel1.Controls.Add(btnDashboard);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(3, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(319, 742);
            panel1.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.OrangeRed;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(36, 450);
            btnLogout.Margin = new Padding(3, 2, 3, 2);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(245, 47);
            btnLogout.TabIndex = 22;
            btnLogout.Text = "LOGOUT";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnStockInquiry
            // 
            btnStockInquiry.BackColor = Color.OrangeRed;
            btnStockInquiry.FlatStyle = FlatStyle.Flat;
            btnStockInquiry.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnStockInquiry.ForeColor = Color.White;
            btnStockInquiry.Location = new Point(36, 399);
            btnStockInquiry.Margin = new Padding(3, 2, 3, 2);
            btnStockInquiry.Name = "btnStockInquiry";
            btnStockInquiry.Size = new Size(245, 47);
            btnStockInquiry.TabIndex = 20;
            btnStockInquiry.Text = "STOCK INQUIRY";
            btnStockInquiry.UseVisualStyleBackColor = false;
            btnStockInquiry.Click += btnStockInquiry_Click;
            // 
            // btnTransaction
            // 
            btnTransaction.BackColor = Color.OrangeRed;
            btnTransaction.FlatStyle = FlatStyle.Flat;
            btnTransaction.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnTransaction.ForeColor = Color.White;
            btnTransaction.Location = new Point(36, 348);
            btnTransaction.Margin = new Padding(3, 2, 3, 2);
            btnTransaction.Name = "btnTransaction";
            btnTransaction.Size = new Size(245, 47);
            btnTransaction.TabIndex = 19;
            btnTransaction.Text = "TRANSACTION";
            btnTransaction.UseVisualStyleBackColor = false;
            btnTransaction.Click += btnTransaction_Click;
            // 
            // btnCategories
            // 
            btnCategories.BackColor = Color.OrangeRed;
            btnCategories.FlatStyle = FlatStyle.Flat;
            btnCategories.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnCategories.ForeColor = Color.White;
            btnCategories.Location = new Point(36, 297);
            btnCategories.Margin = new Padding(3, 2, 3, 2);
            btnCategories.Name = "btnCategories";
            btnCategories.Size = new Size(245, 47);
            btnCategories.TabIndex = 18;
            btnCategories.Text = "POS";
            btnCategories.UseVisualStyleBackColor = false;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.OrangeRed;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(36, 246);
            btnDashboard.Margin = new Padding(3, 2, 3, 2);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(245, 47);
            btnDashboard.TabIndex = 17;
            btnDashboard.Text = "DASHBOARD";
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(11, 200);
            label2.Name = "label2";
            label2.Size = new Size(80, 32);
            label2.TabIndex = 16;
            label2.Text = "Menu";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(78, 11);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(144, 116);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // dgvProducts
            // 
            dgvProducts.BackgroundColor = Color.White;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(354, 154);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.Size = new Size(903, 139);
            dgvProducts.TabIndex = 11;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(354, 109);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(903, 35);
            txtSearch.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(345, 55);
            label1.Name = "label1";
            label1.Size = new Size(69, 37);
            label1.TabIndex = 9;
            label1.Text = "POS";
            // 
            // btnAddToCart
            // 
            btnAddToCart.BackColor = Color.Lime;
            btnAddToCart.FlatStyle = FlatStyle.Flat;
            btnAddToCart.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddToCart.ForeColor = SystemColors.ControlText;
            btnAddToCart.Location = new Point(632, 308);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.Size = new Size(106, 36);
            btnAddToCart.TabIndex = 12;
            btnAddToCart.Text = "Add to cart";
            btnAddToCart.UseVisualStyleBackColor = false;
            // 
            // btnRemoveItem
            // 
            btnRemoveItem.BackColor = Color.LightCoral;
            btnRemoveItem.FlatStyle = FlatStyle.Flat;
            btnRemoveItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemoveItem.Location = new Point(744, 308);
            btnRemoveItem.Name = "btnRemoveItem";
            btnRemoveItem.Size = new Size(120, 36);
            btnRemoveItem.TabIndex = 13;
            btnRemoveItem.Text = "Remove Item";
            btnRemoveItem.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.OrangeRed;
            panel2.Location = new Point(321, 357);
            panel2.Name = "panel2";
            panel2.Size = new Size(1030, 20);
            panel2.TabIndex = 14;
            // 
            // lblCart
            // 
            lblCart.AutoSize = true;
            lblCart.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCart.Location = new Point(354, 382);
            lblCart.Name = "lblCart";
            lblCart.Size = new Size(72, 37);
            lblCart.TabIndex = 15;
            lblCart.Text = "Cart";
            // 
            // dgvCart
            // 
            dgvCart.BackgroundColor = Color.White;
            dgvCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCart.Location = new Point(354, 434);
            dgvCart.Name = "dgvCart";
            dgvCart.Size = new Size(903, 140);
            dgvCart.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(1092, 617);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 17;
            label3.Text = "Discount:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(1114, 648);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 18;
            label4.Text = "Total:";
            // 
            // txtDiscount
            // 
            txtDiscount.Location = new Point(1157, 614);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(100, 23);
            txtDiscount.TabIndex = 19;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(1157, 645);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(100, 23);
            txtTotal.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(354, 316);
            label5.Name = "label5";
            label5.Size = new Size(81, 21);
            label5.TabIndex = 21;
            label5.Text = "Quantity:";
            // 
            // numQty
            // 
            numQty.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numQty.Location = new Point(441, 314);
            numQty.Name = "numQty";
            numQty.Size = new Size(120, 29);
            numQty.TabIndex = 22;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(255, 255, 128);
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(354, 588);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 32);
            btnClear.TabIndex = 23;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(1092, 588);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 24;
            label6.Text = "Subtotal:";
            // 
            // txtSubtotal
            // 
            txtSubtotal.Location = new Point(1157, 585);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.Size = new Size(100, 23);
            txtSubtotal.TabIndex = 25;
            // 
            // btnCheckout
            // 
            btnCheckout.BackColor = Color.FromArgb(128, 255, 128);
            btnCheckout.FlatStyle = FlatStyle.Flat;
            btnCheckout.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCheckout.Location = new Point(1092, 674);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(165, 30);
            btnCheckout.TabIndex = 26;
            btnCheckout.Text = "Checkout";
            btnCheckout.UseVisualStyleBackColor = false;
            // 
            // pnlPayment
            // 
            pnlPayment.BackColor = Color.OrangeRed;
            pnlPayment.Controls.Add(panel4);
            pnlPayment.Location = new Point(650, 150);
            pnlPayment.Name = "pnlPayment";
            pnlPayment.Size = new Size(376, 438);
            pnlPayment.TabIndex = 27;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(btnPayCancel);
            panel4.Controls.Add(btnPayConfirm);
            panel4.Controls.Add(txtPayChange);
            panel4.Controls.Add(txtPayAmount);
            panel4.Controls.Add(txtPayTotal);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(label7);
            panel4.Location = new Point(14, 13);
            panel4.Name = "panel4";
            panel4.Size = new Size(347, 411);
            panel4.TabIndex = 0;
            // 
            // btnPayCancel
            // 
            btnPayCancel.BackColor = Color.FromArgb(255, 128, 128);
            btnPayCancel.FlatStyle = FlatStyle.Flat;
            btnPayCancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPayCancel.Location = new Point(202, 351);
            btnPayCancel.Name = "btnPayCancel";
            btnPayCancel.Size = new Size(101, 34);
            btnPayCancel.TabIndex = 8;
            btnPayCancel.Text = "Cancel";
            btnPayCancel.UseVisualStyleBackColor = false;
            // 
            // btnPayConfirm
            // 
            btnPayConfirm.BackColor = Color.FromArgb(128, 255, 128);
            btnPayConfirm.FlatStyle = FlatStyle.Flat;
            btnPayConfirm.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPayConfirm.Location = new Point(38, 351);
            btnPayConfirm.Name = "btnPayConfirm";
            btnPayConfirm.Size = new Size(101, 34);
            btnPayConfirm.TabIndex = 7;
            btnPayConfirm.Text = "Confirm";
            btnPayConfirm.UseVisualStyleBackColor = false;
            // 
            // txtPayChange
            // 
            txtPayChange.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPayChange.Location = new Point(103, 259);
            txtPayChange.Name = "txtPayChange";
            txtPayChange.Size = new Size(200, 29);
            txtPayChange.TabIndex = 6;
            // 
            // txtPayAmount
            // 
            txtPayAmount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPayAmount.Location = new Point(145, 190);
            txtPayAmount.Name = "txtPayAmount";
            txtPayAmount.Size = new Size(158, 29);
            txtPayAmount.TabIndex = 5;
            // 
            // txtPayTotal
            // 
            txtPayTotal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPayTotal.Location = new Point(92, 121);
            txtPayTotal.Name = "txtPayTotal";
            txtPayTotal.Size = new Size(211, 29);
            txtPayTotal.TabIndex = 4;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(25, 262);
            label10.Name = "label10";
            label10.Size = new Size(72, 21);
            label10.TabIndex = 3;
            label10.Text = "Change:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(25, 193);
            label9.Name = "label9";
            label9.Size = new Size(114, 21);
            label9.TabIndex = 2;
            label9.Text = "Amount Paid:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(25, 121);
            label8.Name = "label8";
            label8.Size = new Size(52, 21);
            label8.TabIndex = 1;
            label8.Text = "Total:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(101, 33);
            label7.Name = "label7";
            label7.Size = new Size(142, 37);
            label7.TabIndex = 0;
            label7.Text = "PAYMENT";
            // 
            // POS
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(1350, 729);
            Controls.Add(pnlPayment);
            Controls.Add(btnCheckout);
            Controls.Add(txtSubtotal);
            Controls.Add(label6);
            Controls.Add(btnClear);
            Controls.Add(numQty);
            Controls.Add(label5);
            Controls.Add(txtTotal);
            Controls.Add(txtDiscount);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dgvCart);
            Controls.Add(lblCart);
            Controls.Add(panel2);
            Controls.Add(btnRemoveItem);
            Controls.Add(btnAddToCart);
            Controls.Add(dgvProducts);
            Controls.Add(txtSearch);
            Controls.Add(label1);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "POS";
            Text = "POS";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCart).EndInit();
            ((System.ComponentModel.ISupportInitialize)numQty).EndInit();
            pnlPayment.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Button btnLogout;
        private Button btnStockInquiry;
        private Button btnTransaction;
        private Button btnCategories;
        private Button btnDashboard;
        private Label label2;
        private DataGridView dgvProducts;
        private TextBox txtSearch;
        private Label label1;
        private Button btnAddToCart;
        private Button btnRemoveItem;
        private Panel panel2;
        private Label lblCart;
        private DataGridView dgvCart;
        private Label label3;
        private Label label4;
        private TextBox txtDiscount;
        private TextBox txtTotal;
        private Label label5;
        private NumericUpDown numQty;
        private Button btnClear;
        private Label label6;
        private TextBox txtSubtotal;
        private Button btnCheckout;
        private Panel pnlPayment;
        private Panel panel4;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private TextBox txtPayAmount;
        private TextBox txtPayTotal;
        private Button btnPayCancel;
        private Button btnPayConfirm;
        private TextBox txtPayChange;
    }
}