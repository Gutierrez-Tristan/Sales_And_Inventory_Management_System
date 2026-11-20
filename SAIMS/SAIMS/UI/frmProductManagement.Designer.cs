namespace SAIMS.UI
{
    partial class frmProductManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductManagement));
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            btnLogout = new Button();
            btnProducts = new Button();
            btnSuppliers = new Button();
            btnSupplierProduct = new Button();
            btnDashboard = new Button();
            label1 = new Label();
            label3 = new Label();
            txtProduct = new TextBox();
            label8 = new Label();
            btnSelectSupplier = new Button();
            txtSupplier = new TextBox();
            label4 = new Label();
            dgvMain = new DataGridView();
            txtSearch = new TextBox();
            btnRefresh = new Button();
            btnAddProductToStore = new Button();
            pnlAddProduct = new Panel();
            panel4 = new Panel();
            numSellingPrice = new NumericUpDown();
            numCostPrice = new NumericUpDown();
            txtReorderLevel = new TextBox();
            txtOpeningStock = new TextBox();
            txtAddCategory = new TextBox();
            txtAddItem = new TextBox();
            txtAddSupplier = new TextBox();
            btnAddCancel = new Button();
            btnAddSave = new Button();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label7 = new Label();
            label5 = new Label();
            pnlRestock = new Panel();
            panel5 = new Panel();
            numRsTotal = new NumericUpDown();
            txtRsQty = new TextBox();
            numRsCost = new NumericUpDown();
            txtRsSupplierStock = new TextBox();
            txtRsStoreStock = new TextBox();
            txtRsCategory = new TextBox();
            txtRsSupplier = new TextBox();
            txtRsProduct = new TextBox();
            btnRestockCancel = new Button();
            btnConfirm = new Button();
            label22 = new Label();
            label21 = new Label();
            label20 = new Label();
            label19 = new Label();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            label6 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMain).BeginInit();
            pnlAddProduct.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numSellingPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCostPrice).BeginInit();
            pnlRestock.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numRsTotal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numRsCost).BeginInit();
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
            panel2.Controls.Add(btnSupplierProduct);
            panel2.Controls.Add(btnDashboard);
            panel2.Dock = DockStyle.Left;
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(319, 729);
            panel2.TabIndex = 3;
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
            // btnSupplierProduct
            // 
            btnSupplierProduct.BackColor = Color.OrangeRed;
            btnSupplierProduct.FlatStyle = FlatStyle.Flat;
            btnSupplierProduct.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnSupplierProduct.ForeColor = Color.White;
            btnSupplierProduct.Location = new Point(39, 303);
            btnSupplierProduct.Margin = new Padding(3, 2, 3, 2);
            btnSupplierProduct.Name = "btnSupplierProduct";
            btnSupplierProduct.Size = new Size(245, 47);
            btnSupplierProduct.TabIndex = 1;
            btnSupplierProduct.Text = "SUPPLIER'S PRODUCTS";
            btnSupplierProduct.UseVisualStyleBackColor = false;
            btnSupplierProduct.Click += btnSupplierProduct_Click;
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
            label1.Size = new Size(347, 37);
            label1.TabIndex = 4;
            label1.Text = "PRODUCT MANAGEMENT";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(377, 87);
            label3.Name = "label3";
            label3.Size = new Size(0, 21);
            label3.TabIndex = 5;
            // 
            // txtProduct
            // 
            txtProduct.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtProduct.Location = new Point(472, 123);
            txtProduct.Name = "txtProduct";
            txtProduct.Size = new Size(221, 29);
            txtProduct.TabIndex = 21;
            txtProduct.TextChanged += txtProduct_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(379, 126);
            label8.Name = "label8";
            label8.Size = new Size(89, 21);
            label8.TabIndex = 20;
            label8.Text = "PRODUCT:";
            // 
            // btnSelectSupplier
            // 
            btnSelectSupplier.BackColor = Color.FromArgb(255, 224, 192);
            btnSelectSupplier.FlatStyle = FlatStyle.Flat;
            btnSelectSupplier.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSelectSupplier.Location = new Point(699, 79);
            btnSelectSupplier.Name = "btnSelectSupplier";
            btnSelectSupplier.Size = new Size(111, 29);
            btnSelectSupplier.TabIndex = 19;
            btnSelectSupplier.Text = "Select Supplier";
            btnSelectSupplier.UseVisualStyleBackColor = false;
            // 
            // txtSupplier
            // 
            txtSupplier.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSupplier.Location = new Point(472, 79);
            txtSupplier.Name = "txtSupplier";
            txtSupplier.Size = new Size(221, 29);
            txtSupplier.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(379, 82);
            label4.Name = "label4";
            label4.Size = new Size(87, 21);
            label4.TabIndex = 17;
            label4.Text = "SUPPLIER:";
            // 
            // dgvMain
            // 
            dgvMain.BackgroundColor = Color.White;
            dgvMain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMain.Location = new Point(379, 205);
            dgvMain.Name = "dgvMain";
            dgvMain.Size = new Size(931, 442);
            dgvMain.TabIndex = 24;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(379, 170);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(814, 29);
            txtSearch.TabIndex = 23;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(128, 128, 255);
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.Location = new Point(1199, 170);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(111, 29);
            btnRefresh.TabIndex = 22;
            btnRefresh.Text = "REFRESH";
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // btnAddProductToStore
            // 
            btnAddProductToStore.BackColor = Color.FromArgb(128, 255, 128);
            btnAddProductToStore.FlatStyle = FlatStyle.Flat;
            btnAddProductToStore.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddProductToStore.Location = new Point(699, 114);
            btnAddProductToStore.Name = "btnAddProductToStore";
            btnAddProductToStore.Size = new Size(276, 38);
            btnAddProductToStore.TabIndex = 25;
            btnAddProductToStore.Text = "ADD PRODUCT TO THE STORE";
            btnAddProductToStore.UseVisualStyleBackColor = false;
            // 
            // pnlAddProduct
            // 
            pnlAddProduct.BackColor = Color.OrangeRed;
            pnlAddProduct.Controls.Add(panel4);
            pnlAddProduct.Location = new Point(402, 158);
            pnlAddProduct.Name = "pnlAddProduct";
            pnlAddProduct.Size = new Size(360, 520);
            pnlAddProduct.TabIndex = 26;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(numSellingPrice);
            panel4.Controls.Add(numCostPrice);
            panel4.Controls.Add(txtReorderLevel);
            panel4.Controls.Add(txtOpeningStock);
            panel4.Controls.Add(txtAddCategory);
            panel4.Controls.Add(txtAddItem);
            panel4.Controls.Add(txtAddSupplier);
            panel4.Controls.Add(btnAddCancel);
            panel4.Controls.Add(btnAddSave);
            panel4.Controls.Add(label14);
            panel4.Controls.Add(label13);
            panel4.Controls.Add(label12);
            panel4.Controls.Add(label11);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label5);
            panel4.Location = new Point(14, 12);
            panel4.Name = "panel4";
            panel4.Size = new Size(334, 492);
            panel4.TabIndex = 0;
            panel4.Paint += panel4_Paint;
            // 
            // numSellingPrice
            // 
            numSellingPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numSellingPrice.Location = new Point(128, 259);
            numSellingPrice.Name = "numSellingPrice";
            numSellingPrice.Size = new Size(171, 29);
            numSellingPrice.TabIndex = 17;
            numSellingPrice.ValueChanged += numericUpDown2_ValueChanged;
            // 
            // numCostPrice
            // 
            numCostPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numCostPrice.Location = new Point(108, 208);
            numCostPrice.Name = "numCostPrice";
            numCostPrice.Size = new Size(191, 29);
            numCostPrice.TabIndex = 16;
            // 
            // txtReorderLevel
            // 
            txtReorderLevel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtReorderLevel.Location = new Point(142, 350);
            txtReorderLevel.Name = "txtReorderLevel";
            txtReorderLevel.Size = new Size(157, 29);
            txtReorderLevel.TabIndex = 15;
            // 
            // txtOpeningStock
            // 
            txtOpeningStock.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtOpeningStock.Location = new Point(142, 308);
            txtOpeningStock.Name = "txtOpeningStock";
            txtOpeningStock.Size = new Size(157, 29);
            txtOpeningStock.TabIndex = 14;
            // 
            // txtAddCategory
            // 
            txtAddCategory.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAddCategory.Location = new Point(98, 159);
            txtAddCategory.Name = "txtAddCategory";
            txtAddCategory.Size = new Size(201, 29);
            txtAddCategory.TabIndex = 12;
            // 
            // txtAddItem
            // 
            txtAddItem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAddItem.Location = new Point(98, 108);
            txtAddItem.Name = "txtAddItem";
            txtAddItem.Size = new Size(201, 29);
            txtAddItem.TabIndex = 11;
            // 
            // txtAddSupplier
            // 
            txtAddSupplier.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAddSupplier.Location = new Point(98, 66);
            txtAddSupplier.Name = "txtAddSupplier";
            txtAddSupplier.Size = new Size(201, 29);
            txtAddSupplier.TabIndex = 10;
            // 
            // btnAddCancel
            // 
            btnAddCancel.BackColor = Color.FromArgb(255, 128, 128);
            btnAddCancel.FlatStyle = FlatStyle.Flat;
            btnAddCancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddCancel.Location = new Point(202, 421);
            btnAddCancel.Name = "btnAddCancel";
            btnAddCancel.Size = new Size(75, 33);
            btnAddCancel.TabIndex = 9;
            btnAddCancel.Text = "Cancel";
            btnAddCancel.UseVisualStyleBackColor = false;
            btnAddCancel.Click += button3_Click;
            // 
            // btnAddSave
            // 
            btnAddSave.BackColor = Color.FromArgb(128, 255, 128);
            btnAddSave.FlatStyle = FlatStyle.Flat;
            btnAddSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddSave.Location = new Point(56, 421);
            btnAddSave.Name = "btnAddSave";
            btnAddSave.Size = new Size(75, 33);
            btnAddSave.TabIndex = 8;
            btnAddSave.Text = "Save";
            btnAddSave.UseVisualStyleBackColor = false;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(13, 353);
            label14.Name = "label14";
            label14.Size = new Size(118, 21);
            label14.TabIndex = 7;
            label14.Text = "Reorder Level:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(13, 311);
            label13.Name = "label13";
            label13.Size = new Size(127, 21);
            label13.TabIndex = 6;
            label13.Text = "Opening Stock:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(13, 261);
            label12.Name = "label12";
            label12.Size = new Size(109, 21);
            label12.TabIndex = 5;
            label12.Text = "Selling Price:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(13, 210);
            label11.Name = "label11";
            label11.Size = new Size(89, 21);
            label11.TabIndex = 4;
            label11.Text = "Cost Price:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(13, 159);
            label10.Name = "label10";
            label10.Size = new Size(84, 21);
            label10.TabIndex = 3;
            label10.Text = "Category:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(13, 108);
            label9.Name = "label9";
            label9.Size = new Size(49, 21);
            label9.TabIndex = 2;
            label9.Text = "Item:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(13, 69);
            label7.Name = "label7";
            label7.Size = new Size(79, 21);
            label7.TabIndex = 1;
            label7.Text = "Supplier:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(81, 17);
            label5.Name = "label5";
            label5.Size = new Size(162, 30);
            label5.TabIndex = 0;
            label5.Text = "ADD PRODUCT";
            // 
            // pnlRestock
            // 
            pnlRestock.BackColor = Color.OrangeRed;
            pnlRestock.Controls.Add(panel5);
            pnlRestock.Location = new Point(813, 158);
            pnlRestock.Name = "pnlRestock";
            pnlRestock.Size = new Size(360, 520);
            pnlRestock.TabIndex = 27;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(numRsTotal);
            panel5.Controls.Add(txtRsQty);
            panel5.Controls.Add(numRsCost);
            panel5.Controls.Add(txtRsSupplierStock);
            panel5.Controls.Add(txtRsStoreStock);
            panel5.Controls.Add(txtRsCategory);
            panel5.Controls.Add(txtRsSupplier);
            panel5.Controls.Add(txtRsProduct);
            panel5.Controls.Add(btnRestockCancel);
            panel5.Controls.Add(btnConfirm);
            panel5.Controls.Add(label22);
            panel5.Controls.Add(label21);
            panel5.Controls.Add(label20);
            panel5.Controls.Add(label19);
            panel5.Controls.Add(label18);
            panel5.Controls.Add(label17);
            panel5.Controls.Add(label16);
            panel5.Controls.Add(label15);
            panel5.Controls.Add(label6);
            panel5.Location = new Point(13, 14);
            panel5.Name = "panel5";
            panel5.Size = new Size(334, 492);
            panel5.TabIndex = 1;
            panel5.Paint += panel5_Paint;
            // 
            // numRsTotal
            // 
            numRsTotal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numRsTotal.Location = new Point(122, 386);
            numRsTotal.Name = "numRsTotal";
            numRsTotal.Size = new Size(184, 29);
            numRsTotal.TabIndex = 19;
            // 
            // txtRsQty
            // 
            txtRsQty.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRsQty.Location = new Point(131, 343);
            txtRsQty.Name = "txtRsQty";
            txtRsQty.Size = new Size(175, 29);
            txtRsQty.TabIndex = 18;
            // 
            // numRsCost
            // 
            numRsCost.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numRsCost.Location = new Point(141, 301);
            numRsCost.Name = "numRsCost";
            numRsCost.Size = new Size(165, 29);
            numRsCost.TabIndex = 17;
            numRsCost.ValueChanged += numericUpDown3_ValueChanged;
            // 
            // txtRsSupplierStock
            // 
            txtRsSupplierStock.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRsSupplierStock.Location = new Point(156, 251);
            txtRsSupplierStock.Name = "txtRsSupplierStock";
            txtRsSupplierStock.Size = new Size(150, 29);
            txtRsSupplierStock.TabIndex = 16;
            // 
            // txtRsStoreStock
            // 
            txtRsStoreStock.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRsStoreStock.Location = new Point(131, 200);
            txtRsStoreStock.Name = "txtRsStoreStock";
            txtRsStoreStock.Size = new Size(175, 29);
            txtRsStoreStock.TabIndex = 15;
            // 
            // txtRsCategory
            // 
            txtRsCategory.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRsCategory.Location = new Point(115, 149);
            txtRsCategory.Name = "txtRsCategory";
            txtRsCategory.Size = new Size(191, 29);
            txtRsCategory.TabIndex = 14;
            // 
            // txtRsSupplier
            // 
            txtRsSupplier.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRsSupplier.Location = new Point(105, 98);
            txtRsSupplier.Name = "txtRsSupplier";
            txtRsSupplier.Size = new Size(201, 29);
            txtRsSupplier.TabIndex = 13;
            // 
            // txtRsProduct
            // 
            txtRsProduct.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRsProduct.Location = new Point(105, 59);
            txtRsProduct.Name = "txtRsProduct";
            txtRsProduct.Size = new Size(201, 29);
            txtRsProduct.TabIndex = 12;
            // 
            // btnRestockCancel
            // 
            btnRestockCancel.BackColor = Color.FromArgb(255, 128, 128);
            btnRestockCancel.FlatStyle = FlatStyle.Flat;
            btnRestockCancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRestockCancel.Location = new Point(190, 430);
            btnRestockCancel.Name = "btnRestockCancel";
            btnRestockCancel.Size = new Size(87, 33);
            btnRestockCancel.TabIndex = 11;
            btnRestockCancel.Text = "Cancel";
            btnRestockCancel.UseVisualStyleBackColor = false;
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.FromArgb(128, 255, 128);
            btnConfirm.FlatStyle = FlatStyle.Flat;
            btnConfirm.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirm.Location = new Point(63, 430);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(87, 33);
            btnConfirm.TabIndex = 10;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = false;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label22.Location = new Point(27, 388);
            label22.Name = "label22";
            label22.Size = new Size(89, 21);
            label22.TabIndex = 9;
            label22.Text = "Total Cost:";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label21.Location = new Point(29, 346);
            label21.Name = "label21";
            label21.Size = new Size(97, 21);
            label21.TabIndex = 8;
            label21.Text = "QTY to Buy:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.Location = new Point(25, 304);
            label20.Name = "label20";
            label20.Size = new Size(113, 21);
            label20.TabIndex = 7;
            label20.Text = "Cost Per Unit:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.Location = new Point(25, 254);
            label19.Name = "label19";
            label19.Size = new Size(125, 21);
            label19.TabIndex = 6;
            label19.Text = "Supplier Stock:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.Location = new Point(25, 203);
            label18.Name = "label18";
            label18.Size = new Size(101, 21);
            label18.TabIndex = 5;
            label18.Text = "Store Stock:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(25, 152);
            label17.Name = "label17";
            label17.Size = new Size(84, 21);
            label17.TabIndex = 4;
            label17.Text = "Category:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(25, 101);
            label16.Name = "label16";
            label16.Size = new Size(79, 21);
            label16.TabIndex = 2;
            label16.Text = "Supplier:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(25, 62);
            label15.Name = "label15";
            label15.Size = new Size(74, 21);
            label15.TabIndex = 1;
            label15.Text = "Product:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(117, 15);
            label6.Name = "label6";
            label6.Size = new Size(104, 30);
            label6.TabIndex = 0;
            label6.Text = "RESTOCK";
            // 
            // frmProductManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(1350, 729);
            Controls.Add(pnlRestock);
            Controls.Add(pnlAddProduct);
            Controls.Add(btnAddProductToStore);
            Controls.Add(dgvMain);
            Controls.Add(txtSearch);
            Controls.Add(btnRefresh);
            Controls.Add(txtProduct);
            Controls.Add(label8);
            Controls.Add(btnSelectSupplier);
            Controls.Add(txtSupplier);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(panel2);
            Name = "frmProductManagement";
            Text = "frmProductManagement";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMain).EndInit();
            pnlAddProduct.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numSellingPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCostPrice).EndInit();
            pnlRestock.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numRsTotal).EndInit();
            ((System.ComponentModel.ISupportInitialize)numRsCost).EndInit();
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
        private Button btnSupplierProduct;
        private Button btnDashboard;
        private Label label1;
        private Label label3;
        private TextBox txtProduct;
        private Label label8;
        private Button btnSelectSupplier;
        private TextBox txtSupplier;
        private Label label4;
        private DataGridView dgvMain;
        private TextBox txtSearch;
        private Button btnRefresh;
        private Button btnAddProductToStore;
        private Panel pnlAddProduct;
        private Panel pnlRestock;
        private Panel panel4;
        private Label label5;
        private Panel panel5;
        private Label label10;
        private Label label9;
        private Label label7;
        private Label label6;
        private Button btnAddCancel;
        private Button btnAddSave;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label22;
        private Label label21;
        private Label label20;
        private Label label19;
        private Label label18;
        private Label label17;
        private Label label16;
        private Label label15;
        private NumericUpDown numSellingPrice;
        private NumericUpDown numCostPrice;
        private TextBox txtReorderLevel;
        private TextBox txtOpeningStock;
        private TextBox txtAddCategory;
        private TextBox txtAddItem;
        private TextBox txtAddSupplier;
        private TextBox txtRsSupplierStock;
        private TextBox txtRsStoreStock;
        private TextBox txtRsCategory;
        private TextBox txtRsSupplier;
        private TextBox txtRsProduct;
        private Button btnRestockCancel;
        private Button btnConfirm;
        private NumericUpDown numRsTotal;
        private TextBox txtRsQty;
        private NumericUpDown numRsCost;
        private Button button6;
    }
}