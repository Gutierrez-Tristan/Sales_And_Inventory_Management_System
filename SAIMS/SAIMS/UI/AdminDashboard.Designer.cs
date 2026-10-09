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
            pictureBoxLogo = new PictureBox();
            label2 = new Label();
            btnLogout = new Button();
            btnProfile = new Button();
            btnProducts = new Button();
            btnSuppliers = new Button();
            btnCategories = new Button();
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
            panel1.Location = new Point(-6, -5);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1369, 742);
            panel1.TabIndex = 0;
            // 
            // dgvOverview
            // 
            dgvOverview.BackgroundColor = Color.White;
            dgvOverview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOverview.Location = new Point(344, 385);
            dgvOverview.Margin = new Padding(3, 2, 3, 2);
            dgvOverview.Name = "dgvOverview";
            dgvOverview.RowHeadersWidth = 51;
            dgvOverview.Size = new Size(985, 329);
            dgvOverview.TabIndex = 8;
            // 
            // btnReload
            // 
            btnReload.BackColor = Color.SteelBlue;
            btnReload.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReload.ForeColor = Color.White;
            btnReload.Location = new Point(344, 328);
            btnReload.Margin = new Padding(3, 2, 3, 2);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(118, 43);
            btnReload.TabIndex = 7;
            btnReload.Text = "Reload";
            btnReload.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(344, 22);
            label1.Name = "label1";
            label1.Size = new Size(186, 37);
            label1.TabIndex = 6;
            label1.Text = "DASHBOARD";
            // 
            // btnTotalSales
            // 
            btnTotalSales.BackColor = Color.DarkOrange;
            btnTotalSales.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnTotalSales.ForeColor = SystemColors.ButtonFace;
            btnTotalSales.Location = new Point(603, 237);
            btnTotalSales.Margin = new Padding(3, 2, 3, 2);
            btnTotalSales.Name = "btnTotalSales";
            btnTotalSales.Size = new Size(209, 85);
            btnTotalSales.TabIndex = 4;
            btnTotalSales.Text = "TOTAL SALES";
            btnTotalSales.UseVisualStyleBackColor = false;
            btnTotalSales.Click += btnTotalSales_Click;
            // 
            // btnRecentTransactions
            // 
            btnRecentTransactions.BackColor = Color.DarkOrange;
            btnRecentTransactions.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnRecentTransactions.ForeColor = SystemColors.ButtonFace;
            btnRecentTransactions.Location = new Point(918, 237);
            btnRecentTransactions.Margin = new Padding(3, 2, 3, 2);
            btnRecentTransactions.Name = "btnRecentTransactions";
            btnRecentTransactions.Size = new Size(209, 85);
            btnRecentTransactions.TabIndex = 5;
            btnRecentTransactions.Text = "RECENT TRANSACTIONS";
            btnRecentTransactions.UseVisualStyleBackColor = false;
  
            // 
            // btnLowStockProducts
            // 
            btnLowStockProducts.BackColor = Color.DarkOrange;
            btnLowStockProducts.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnLowStockProducts.ForeColor = SystemColors.ButtonFace;
            btnLowStockProducts.Location = new Point(1066, 114);
            btnLowStockProducts.Margin = new Padding(3, 2, 3, 2);
            btnLowStockProducts.Name = "btnLowStockProducts";
            btnLowStockProducts.Size = new Size(209, 85);
            btnLowStockProducts.TabIndex = 3;
            btnLowStockProducts.Text = "LOW STOCK PRODUCTS";
            btnLowStockProducts.UseVisualStyleBackColor = false;

            // 
            // btnAvailableStocks
            // 
            btnAvailableStocks.BackColor = Color.DarkOrange;
            btnAvailableStocks.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAvailableStocks.ForeColor = SystemColors.ButtonFace;
            btnAvailableStocks.Location = new Point(762, 114);
            btnAvailableStocks.Margin = new Padding(3, 2, 3, 2);
            btnAvailableStocks.Name = "btnAvailableStocks";
            btnAvailableStocks.Size = new Size(209, 85);
            btnAvailableStocks.TabIndex = 2;
            btnAvailableStocks.Text = "AVAILABLE STOCKS";
            btnAvailableStocks.UseVisualStyleBackColor = false;

            // 
            // btnTotalProducts
            // 
            btnTotalProducts.BackColor = Color.DarkOrange;
            btnTotalProducts.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnTotalProducts.ForeColor = SystemColors.ButtonFace;
            btnTotalProducts.Location = new Point(461, 114);
            btnTotalProducts.Margin = new Padding(3, 2, 3, 2);
            btnTotalProducts.Name = "btnTotalProducts";
            btnTotalProducts.Size = new Size(209, 85);
            btnTotalProducts.TabIndex = 1;
            btnTotalProducts.Text = "TOTAL PRODUCTS";
            btnTotalProducts.UseVisualStyleBackColor = false;

            // 
            // panel2
            // 
            panel2.BackColor = Color.OrangeRed;
            panel2.Controls.Add(pictureBoxLogo);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(btnLogout);
            panel2.Controls.Add(btnProfile);
            panel2.Controls.Add(btnProducts);
            panel2.Controls.Add(btnSuppliers);
            panel2.Controls.Add(btnCategories);
            panel2.Controls.Add(btnDashboard);
            panel2.Dock = DockStyle.Left;
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(319, 742);
            panel2.TabIndex = 0;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = Properties.Resources.ddd1;
            pictureBoxLogo.Location = new Point(86, 22);
            pictureBoxLogo.Margin = new Padding(3, 2, 3, 2);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(144, 116);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLogo.TabIndex = 7;
            pictureBoxLogo.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(18, 167);
            label2.Name = "label2";
            label2.Size = new Size(80, 32);
            label2.TabIndex = 6;
            label2.Text = "Menu";
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.OrangeRed;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(39, 456);
            btnLogout.Margin = new Padding(3, 2, 3, 2);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(245, 47);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "LOGOUT";
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // btnProfile
            // 
            btnProfile.BackColor = Color.OrangeRed;
            btnProfile.FlatStyle = FlatStyle.Flat;
            btnProfile.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProfile.Location = new Point(39, 405);
            btnProfile.Margin = new Padding(3, 2, 3, 2);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(245, 47);
            btnProfile.TabIndex = 4;
            btnProfile.Text = "PROFILE";
            btnProfile.UseVisualStyleBackColor = false;
            btnProfile.Click += btnProfile_Click;
            // 
            // btnProducts
            // 
            btnProducts.BackColor = Color.OrangeRed;
            btnProducts.FlatStyle = FlatStyle.Flat;
            btnProducts.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProducts.Location = new Point(39, 354);
            btnProducts.Margin = new Padding(3, 2, 3, 2);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(245, 47);
            btnProducts.TabIndex = 3;
            btnProducts.Text = "PRODUCTS";
            btnProducts.UseVisualStyleBackColor = false;

            // 
            // btnSuppliers
            // 
            btnSuppliers.BackColor = Color.OrangeRed;
            btnSuppliers.FlatStyle = FlatStyle.Flat;
            btnSuppliers.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSuppliers.Location = new Point(39, 303);
            btnSuppliers.Margin = new Padding(3, 2, 3, 2);
            btnSuppliers.Name = "btnSuppliers";
            btnSuppliers.Size = new Size(245, 47);
            btnSuppliers.TabIndex = 2;
            btnSuppliers.Text = "SUPPLIERS";
            btnSuppliers.UseVisualStyleBackColor = false;

            // 
            // btnCategories
            // 
            btnCategories.BackColor = Color.OrangeRed;
            btnCategories.FlatStyle = FlatStyle.Flat;
            btnCategories.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCategories.ForeColor = Color.White;
            btnCategories.Location = new Point(39, 252);
            btnCategories.Margin = new Padding(3, 2, 3, 2);
            btnCategories.Name = "btnCategories";
            btnCategories.Size = new Size(245, 47);
            btnCategories.TabIndex = 1;
            btnCategories.Text = "CATEGORIES";
            btnCategories.UseVisualStyleBackColor = false;
            btnCategories.Click += btnCategories_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.OrangeRed;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDashboard.Location = new Point(39, 201);
            btnDashboard.Margin = new Padding(3, 2, 3, 2);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(245, 47);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "DASHBOARD";
            btnDashboard.UseVisualStyleBackColor = false;
       
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 729);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AdminDashboard";
            Text = "AdminDashboard";
            Load += AdminDashboard_Load;
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
        private Button btnSuppliers;
        private Button btnProfile;
        private Button btnCategories;
        private Button btnProducts;
        private Button btnLogout;
        private PictureBox pictureBoxLogo;
        private Label label2;
    }
}