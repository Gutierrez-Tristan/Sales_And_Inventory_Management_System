namespace SAIMS.UI
{
    partial class frmSupplierProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSupplierProduct));
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            btnLogout = new Button();
            btnProducts = new Button();
            btnSuppliers = new Button();
            btnCategories = new Button();
            btnDashboard = new Button();
            label1 = new Label();
            label3 = new Label();
            btnRefresh = new Button();
            txtSearch = new TextBox();
            dgvMain = new DataGridView();
            panel3 = new Panel();
            panel4 = new Panel();
            label9 = new Label();
            cboCategory = new ComboBox();
            txtStock = new TextBox();
            label7 = new Label();
            btnCancel = new Button();
            btnSave = new Button();
            numUnitCost = new NumericUpDown();
            label6 = new Label();
            txtItemName = new TextBox();
            label5 = new Label();
            txtPanelSupplier = new TextBox();
            label4 = new Label();
            txtSupplier = new TextBox();
            btnSelectSupplier = new Button();
            panel1 = new Panel();
            label8 = new Label();
            txtProduct = new TextBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMain).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numUnitCost).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.OrangeRed;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(btnLogout);
            panel2.Controls.Add(btnProducts);
            panel2.Controls.Add(btnSuppliers);
            panel2.Controls.Add(btnCategories);
            panel2.Controls.Add(btnDashboard);
            panel2.Dock = DockStyle.Left;
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(319, 729);
            panel2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(86, 22);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(144, 116);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
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
            btnLogout.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnLogout.Location = new Point(39, 405);
            btnLogout.Margin = new Padding(3, 2, 3, 2);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(245, 47);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "LOGOUT";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnProducts
            // 
            btnProducts.BackColor = Color.OrangeRed;
            btnProducts.FlatStyle = FlatStyle.Flat;
            btnProducts.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnProducts.Location = new Point(39, 354);
            btnProducts.Margin = new Padding(3, 2, 3, 2);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(245, 47);
            btnProducts.TabIndex = 3;
            btnProducts.Text = "PRODUCT MANAGEMENT";
            btnProducts.UseVisualStyleBackColor = false;
            btnProducts.Click += btnProducts_Click;
            // 
            // btnSuppliers
            // 
            btnSuppliers.BackColor = Color.OrangeRed;
            btnSuppliers.FlatStyle = FlatStyle.Flat;
            btnSuppliers.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnSuppliers.Location = new Point(39, 252);
            btnSuppliers.Margin = new Padding(3, 2, 3, 2);
            btnSuppliers.Name = "btnSuppliers";
            btnSuppliers.Size = new Size(245, 47);
            btnSuppliers.TabIndex = 2;
            btnSuppliers.Text = "SUPPLIERS";
            btnSuppliers.UseVisualStyleBackColor = false;
            btnSuppliers.Click += btnSuppliers_Click;
            // 
            // btnCategories
            // 
            btnCategories.BackColor = Color.OrangeRed;
            btnCategories.FlatStyle = FlatStyle.Flat;
            btnCategories.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnCategories.ForeColor = Color.White;
            btnCategories.Location = new Point(39, 303);
            btnCategories.Margin = new Padding(3, 2, 3, 2);
            btnCategories.Name = "btnCategories";
            btnCategories.Size = new Size(245, 47);
            btnCategories.TabIndex = 1;
            btnCategories.Text = "SUPPLIER'S PRODUCTS";
            btnCategories.UseVisualStyleBackColor = false;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.OrangeRed;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnDashboard.Location = new Point(39, 201);
            btnDashboard.Margin = new Padding(3, 2, 3, 2);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(245, 47);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "DASHBOARD";
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(368, 22);
            label1.Name = "label1";
            label1.Size = new Size(314, 37);
            label1.TabIndex = 3;
            label1.Text = "SUPPLIER'S PRODUCTS";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(374, 83);
            label3.Name = "label3";
            label3.Size = new Size(87, 21);
            label3.TabIndex = 4;
            label3.Text = "SUPPLIER:";
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(128, 128, 255);
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.Location = new Point(694, 165);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(111, 29);
            btnRefresh.TabIndex = 7;
            btnRefresh.Text = "REFRESH";
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(374, 166);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(314, 29);
            txtSearch.TabIndex = 8;
            // 
            // dgvMain
            // 
            dgvMain.BackgroundColor = Color.White;
            dgvMain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMain.Location = new Point(374, 201);
            dgvMain.Name = "dgvMain";
            dgvMain.Size = new Size(431, 442);
            dgvMain.TabIndex = 9;
            // 
            // panel3
            // 
            panel3.BackColor = Color.OrangeRed;
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(948, 154);
            panel3.Name = "panel3";
            panel3.Size = new Size(379, 403);
            panel3.TabIndex = 12;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(label9);
            panel4.Controls.Add(cboCategory);
            panel4.Controls.Add(txtStock);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(btnCancel);
            panel4.Controls.Add(btnSave);
            panel4.Controls.Add(numUnitCost);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(txtItemName);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(txtPanelSupplier);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(22, 25);
            panel4.Name = "panel4";
            panel4.Size = new Size(339, 354);
            panel4.TabIndex = 0;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(15, 144);
            label9.Name = "label9";
            label9.Size = new Size(95, 21);
            label9.TabIndex = 11;
            label9.Text = "CATEGORY:";
            // 
            // cboCategory
            // 
            cboCategory.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(125, 141);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(189, 29);
            cboCategory.TabIndex = 10;
            // 
            // txtStock
            // 
            txtStock.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStock.Location = new Point(161, 235);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(153, 29);
            txtStock.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(15, 238);
            label7.Name = "label7";
            label7.Size = new Size(140, 21);
            label7.TabIndex = 8;
            label7.Text = "SUPPLIER STOCK:";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(255, 128, 128);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(190, 296);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 32);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(128, 255, 128);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(56, 296);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 32);
            btnSave.TabIndex = 6;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // numUnitCost
            // 
            numUnitCost.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numUnitCost.Location = new Point(118, 185);
            numUnitCost.Name = "numUnitCost";
            numUnitCost.Size = new Size(196, 29);
            numUnitCost.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(15, 187);
            label6.Name = "label6";
            label6.Size = new Size(97, 21);
            label6.TabIndex = 4;
            label6.Text = "UNIT COST:";
            // 
            // txtItemName
            // 
            txtItemName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtItemName.Location = new Point(125, 98);
            txtItemName.Name = "txtItemName";
            txtItemName.Size = new Size(189, 29);
            txtItemName.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(15, 101);
            label5.Name = "label5";
            label5.Size = new Size(104, 21);
            label5.TabIndex = 2;
            label5.Text = "ITEM NAME:";
            // 
            // txtPanelSupplier
            // 
            txtPanelSupplier.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPanelSupplier.Location = new Point(108, 45);
            txtPanelSupplier.Name = "txtPanelSupplier";
            txtPanelSupplier.Size = new Size(206, 29);
            txtPanelSupplier.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(15, 48);
            label4.Name = "label4";
            label4.Size = new Size(87, 21);
            label4.TabIndex = 0;
            label4.Text = "SUPPLIER:";
            // 
            // txtSupplier
            // 
            txtSupplier.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSupplier.Location = new Point(467, 80);
            txtSupplier.Name = "txtSupplier";
            txtSupplier.Size = new Size(221, 29);
            txtSupplier.TabIndex = 13;
            // 
            // btnSelectSupplier
            // 
            btnSelectSupplier.BackColor = Color.FromArgb(255, 224, 192);
            btnSelectSupplier.FlatStyle = FlatStyle.Flat;
            btnSelectSupplier.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSelectSupplier.Location = new Point(694, 80);
            btnSelectSupplier.Name = "btnSelectSupplier";
            btnSelectSupplier.Size = new Size(111, 29);
            btnSelectSupplier.TabIndex = 14;
            btnSelectSupplier.Text = "Select Supplier";
            btnSelectSupplier.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.OrangeRed;
            panel1.Location = new Point(863, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(27, 729);
            panel1.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(374, 127);
            label8.Name = "label8";
            label8.Size = new Size(89, 21);
            label8.TabIndex = 15;
            label8.Text = "PRODUCT:";
            // 
            // txtProduct
            // 
            txtProduct.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtProduct.Location = new Point(467, 124);
            txtProduct.Name = "txtProduct";
            txtProduct.Size = new Size(221, 29);
            txtProduct.TabIndex = 16;
            // 
            // frmSupplierProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(1350, 729);
            Controls.Add(txtProduct);
            Controls.Add(label8);
            Controls.Add(btnSelectSupplier);
            Controls.Add(txtSupplier);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(dgvMain);
            Controls.Add(txtSearch);
            Controls.Add(btnRefresh);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(panel2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmSupplierProduct";
            Text = "frmSupplierProduct";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMain).EndInit();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numUnitCost).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label2;
        private Button btnLogout;
        private Button btnProducts;
        private Button btnSuppliers;
        private Button btnCategories;
        private Button btnDashboard;
        private Label label1;
        private Label label3;
        private Button btnRefresh;
        private TextBox txtSearch;
        private DataGridView dgvMain;
        private Panel panel3;
        private Panel panel4;
        private Label label6;
        private TextBox txtItemName;
        private Label label5;
        private TextBox txtPanelSupplier;
        private Label label4;
        private NumericUpDown numUnitCost;
        private TextBox txtSupplier;
        private Button btnSelectSupplier;
        private Button btnCancel;
        private Button btnSave;
        private Label label7;
        private TextBox txtStock;
        private Panel panel1;
        private Label label8;
        private TextBox txtProduct;
        private Label label9;
        private ComboBox cboCategory;
    }
}