namespace SAIMS.UI
{
    partial class AdminDashboard
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
            panel1 = new Panel();
            dgvOverview = new DataGridView();
            btnReload = new Button();
            label1 = new Label();
            btnTotalSales = new Button();
            btnRecentTransactions = new Button();
            btnLowStockProducts = new Button();
            btnAvailableStocks = new Button();
            btnTotalProducts = new Button();
            panel2 = new Panel();
            label3 = new Label();
            pictureBoxLogo = new PictureBox();
            label2 = new Label();
            btnLogout = new Button();
            btnProfile = new Button();
            btnStockInquiry = new Button();
            btnTransaction = new Button();
            btnPos = new Button();
            btnDashboard = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOverview).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.NavajoWhite;
            panel1.Controls.Add(dgvOverview);
            panel1.Controls.Add(btnReload);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnTotalSales);
            panel1.Controls.Add(btnRecentTransactions);
            panel1.Controls.Add(btnLowStockProducts);
            panel1.Controls.Add(btnAvailableStocks);
            panel1.Controls.Add(btnTotalProducts);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(-7, -7);
            panel1.Name = "panel1";
            panel1.Size = new Size(898, 516);
            panel1.TabIndex = 0;
            // 
            // dgvOverview
            // 
            dgvOverview.BackgroundColor = Color.White;
            dgvOverview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOverview.Location = new Point(295, 238);
            dgvOverview.Name = "dgvOverview";
            dgvOverview.RowHeadersWidth = 51;
            dgvOverview.Size = new Size(548, 248);
            dgvOverview.TabIndex = 8;
            // 
            // btnReload
            // 
            btnReload.BackColor = Color.SteelBlue;
            btnReload.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReload.ForeColor = Color.White;
            btnReload.Location = new Point(260, 190);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(83, 28);
            btnReload.TabIndex = 7;
            btnReload.Text = "Reload";
            btnReload.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(260, 30);
            label1.Name = "label1";
            label1.Size = new Size(118, 23);
            label1.TabIndex = 6;
            label1.Text = "DASHBOARD";
            // 
            // btnTotalSales
            // 
            btnTotalSales.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTotalSales.Location = new Point(395, 133);
            btnTotalSales.Name = "btnTotalSales";
            btnTotalSales.Size = new Size(162, 43);
            btnTotalSales.TabIndex = 4;
            btnTotalSales.Text = "TOTAL SALES";
            btnTotalSales.UseVisualStyleBackColor = true;
            // 
            // btnRecentTransactions
            // 
            btnRecentTransactions.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRecentTransactions.Location = new Point(590, 133);
            btnRecentTransactions.Name = "btnRecentTransactions";
            btnRecentTransactions.Size = new Size(162, 43);
            btnRecentTransactions.TabIndex = 5;
            btnRecentTransactions.Text = "RECENT TRANSACTIONS";
            btnRecentTransactions.UseVisualStyleBackColor = true;
            // 
            // btnLowStockProducts
            // 
            btnLowStockProducts.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLowStockProducts.Location = new Point(681, 69);
            btnLowStockProducts.Name = "btnLowStockProducts";
            btnLowStockProducts.Size = new Size(162, 43);
            btnLowStockProducts.TabIndex = 3;
            btnLowStockProducts.Text = "LOW STOCK PRODUCTS";
            btnLowStockProducts.UseVisualStyleBackColor = true;
            // 
            // btnAvailableStocks
            // 
            btnAvailableStocks.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAvailableStocks.Location = new Point(489, 69);
            btnAvailableStocks.Name = "btnAvailableStocks";
            btnAvailableStocks.Size = new Size(162, 43);
            btnAvailableStocks.TabIndex = 2;
            btnAvailableStocks.Text = "AVAILABLE STOCKS";
            btnAvailableStocks.UseVisualStyleBackColor = true;
            // 
            // btnTotalProducts
            // 
            btnTotalProducts.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTotalProducts.Location = new Point(295, 69);
            btnTotalProducts.Name = "btnTotalProducts";
            btnTotalProducts.Size = new Size(162, 43);
            btnTotalProducts.TabIndex = 1;
            btnTotalProducts.Text = "TOTAL PRODUCTS";
            btnTotalProducts.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.OrangeRed;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(pictureBoxLogo);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(btnLogout);
            panel2.Controls.Add(btnProfile);
            panel2.Controls.Add(btnStockInquiry);
            panel2.Controls.Add(btnTransaction);
            panel2.Controls.Add(btnPos);
            panel2.Controls.Add(btnDashboard);
            panel2.Dock = DockStyle.Left;
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(231, 516);
            panel2.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(46, 135);
            label3.Name = "label3";
            label3.Size = new Size(149, 31);
            label3.TabIndex = 8;
            label3.Text = "LOGO NAME";
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = Properties.Resources.ddd1;
            pictureBoxLogo.Location = new Point(63, 30);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(115, 99);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLogo.TabIndex = 7;
            pictureBoxLogo.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 212);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 6;
            label2.Text = "Menu";
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.OrangeRed;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(46, 418);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(142, 28);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "LOGOUT";
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // btnProfile
            // 
            btnProfile.BackColor = Color.OrangeRed;
            btnProfile.FlatStyle = FlatStyle.Flat;
            btnProfile.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProfile.Location = new Point(46, 384);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(142, 28);
            btnProfile.TabIndex = 4;
            btnProfile.Text = "PROFILE";
            btnProfile.UseVisualStyleBackColor = false;
            // 
            // btnStockInquiry
            // 
            btnStockInquiry.BackColor = Color.OrangeRed;
            btnStockInquiry.FlatStyle = FlatStyle.Flat;
            btnStockInquiry.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnStockInquiry.Location = new Point(46, 350);
            btnStockInquiry.Name = "btnStockInquiry";
            btnStockInquiry.Size = new Size(142, 28);
            btnStockInquiry.TabIndex = 3;
            btnStockInquiry.Text = "STOCK INQUIRY";
            btnStockInquiry.UseVisualStyleBackColor = false;
            // 
            // btnTransaction
            // 
            btnTransaction.BackColor = Color.OrangeRed;
            btnTransaction.FlatStyle = FlatStyle.Flat;
            btnTransaction.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTransaction.Location = new Point(46, 316);
            btnTransaction.Name = "btnTransaction";
            btnTransaction.Size = new Size(142, 28);
            btnTransaction.TabIndex = 2;
            btnTransaction.Text = "TRANSACTION";
            btnTransaction.UseVisualStyleBackColor = false;
            // 
            // btnPos
            // 
            btnPos.BackColor = Color.OrangeRed;
            btnPos.FlatStyle = FlatStyle.Flat;
            btnPos.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPos.ForeColor = Color.White;
            btnPos.Location = new Point(46, 282);
            btnPos.Name = "btnPos";
            btnPos.Size = new Size(142, 28);
            btnPos.TabIndex = 1;
            btnPos.Text = "POS";
            btnPos.UseVisualStyleBackColor = false;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.OrangeRed;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDashboard.Location = new Point(46, 248);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(142, 28);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "DASHBOARD";
            btnDashboard.UseVisualStyleBackColor = false;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(887, 503);
            Controls.Add(panel1);
            Name = "AdminDashboard";
            Text = "AdminDashboard";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOverview).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnTotalProducts;
        private Panel panel2;
        private Button btnLowStockProducts;
        private Button btnAvailableStocks;
        private Button btnTotalSales;
        private Button btnRecentTransactions;
        private Button btnReload;
        private Label label1;
        private DataGridView dgvOverview;
        private Button button1;
        private Button btnDashboard;
        private Button btnTransaction;
        private Button btnProfile;
        private Button btnPos;
        private Button btnStockInquiry;
        private Button btnLogout;
        private PictureBox pictureBoxLogo;
        private Label label2;
        private Label label3;
    }
}