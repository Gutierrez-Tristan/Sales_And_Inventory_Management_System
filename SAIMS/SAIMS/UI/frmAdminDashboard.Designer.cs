namespace SAIMS.UI
{
    partial class frmAdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminDashboard));
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            btnLogout = new Button();
            btnProductManagement = new Button();
            btnSuppliers = new Button();
            btnSupplierProduct = new Button();
            btnDashboard = new Button();
            panel1 = new Panel();
            lblSuppliersCount = new Label();
            label3 = new Label();
            label1 = new Label();
            panel3 = new Panel();
            lblProductsCount = new Label();
            label5 = new Label();
            label4 = new Label();
            panel4 = new Panel();
            lblLowStockCount = new Label();
            label7 = new Label();
            label6 = new Label();
            panel5 = new Panel();
            lblInventoryValue = new Label();
            label9 = new Label();
            label8 = new Label();
            label10 = new Label();
            label11 = new Label();
            panel6 = new Panel();
            panel7 = new Panel();
            lblLowReorder3 = new Label();
            btnRestock = new Button();
            lblLowReorder2 = new Label();
            label12 = new Label();
            lblLowStock3 = new Label();
            label13 = new Label();
            lblLowStock2 = new Label();
            label14 = new Label();
            lblLowReorder1 = new Label();
            lblLowProduct1 = new Label();
            lblLowProduct3 = new Label();
            lblLowStock1 = new Label();
            lblLowProduct2 = new Label();
            label28 = new Label();
            panel8 = new Panel();
            panel9 = new Panel();
            lblRecentQty3 = new Label();
            lblRecentQty2 = new Label();
            lblRecentQty1 = new Label();
            lblRecentItem3 = new Label();
            lblRecentItem2 = new Label();
            lblRecentItem1 = new Label();
            lblRecentDate3 = new Label();
            lblRecentDate2 = new Label();
            lblRecentDate1 = new Label();
            label31 = new Label();
            label30 = new Label();
            label29 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.OrangeRed;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(btnLogout);
            panel2.Controls.Add(btnProductManagement);
            panel2.Controls.Add(btnSuppliers);
            panel2.Controls.Add(btnSupplierProduct);
            panel2.Controls.Add(btnDashboard);
            panel2.Dock = DockStyle.Left;
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(319, 729);
            panel2.TabIndex = 1;
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
            // btnProductManagement
            // 
            btnProductManagement.BackColor = Color.OrangeRed;
            btnProductManagement.FlatStyle = FlatStyle.Flat;
            btnProductManagement.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnProductManagement.Location = new Point(39, 354);
            btnProductManagement.Margin = new Padding(3, 2, 3, 2);
            btnProductManagement.Name = "btnProductManagement";
            btnProductManagement.Size = new Size(245, 47);
            btnProductManagement.TabIndex = 3;
            btnProductManagement.Text = "PRODUCT MANAGEMENT";
            btnProductManagement.UseVisualStyleBackColor = false;
            btnProductManagement.Click += btnProductManagement_Click;
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
            // 
            // panel1
            // 
            panel1.BackColor = Color.OrangeRed;
            panel1.Controls.Add(lblSuppliersCount);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(419, 113);
            panel1.Name = "panel1";
            panel1.Size = new Size(155, 135);
            panel1.TabIndex = 2;
            // 
            // lblSuppliersCount
            // 
            lblSuppliersCount.AutoSize = true;
            lblSuppliersCount.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSuppliersCount.ForeColor = Color.White;
            lblSuppliersCount.Location = new Point(68, 61);
            lblSuppliersCount.Name = "lblSuppliersCount";
            lblSuppliersCount.Size = new Size(19, 21);
            lblSuppliersCount.TabIndex = 2;
            lblSuppliersCount.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(36, 21);
            label3.Name = "label3";
            label3.Size = new Size(92, 21);
            label3.TabIndex = 1;
            label3.Text = "SUPPLIERS";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(46, 94);
            label1.Name = "label1";
            label1.Size = new Size(65, 21);
            label1.TabIndex = 0;
            label1.Text = "ACTIVE";
            // 
            // panel3
            // 
            panel3.BackColor = Color.OrangeRed;
            panel3.Controls.Add(lblProductsCount);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(629, 113);
            panel3.Name = "panel3";
            panel3.Size = new Size(155, 135);
            panel3.TabIndex = 3;
            // 
            // lblProductsCount
            // 
            lblProductsCount.AutoSize = true;
            lblProductsCount.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblProductsCount.ForeColor = Color.White;
            lblProductsCount.Location = new Point(69, 61);
            lblProductsCount.Name = "lblProductsCount";
            lblProductsCount.Size = new Size(19, 21);
            lblProductsCount.TabIndex = 2;
            lblProductsCount.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.OrangeRed;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(38, 94);
            label5.Name = "label5";
            label5.Size = new Size(80, 21);
            label5.TabIndex = 1;
            label5.Text = "IN STORE";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(30, 21);
            label4.Name = "label4";
            label4.Size = new Size(94, 21);
            label4.TabIndex = 0;
            label4.Text = "PRODUCTS";
            // 
            // panel4
            // 
            panel4.BackColor = Color.OrangeRed;
            panel4.Controls.Add(lblLowStockCount);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label6);
            panel4.Location = new Point(841, 113);
            panel4.Name = "panel4";
            panel4.Size = new Size(155, 135);
            panel4.TabIndex = 4;
            // 
            // lblLowStockCount
            // 
            lblLowStockCount.AutoSize = true;
            lblLowStockCount.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLowStockCount.ForeColor = Color.White;
            lblLowStockCount.Location = new Point(67, 61);
            lblLowStockCount.Name = "lblLowStockCount";
            lblLowStockCount.Size = new Size(19, 21);
            lblLowStockCount.TabIndex = 2;
            lblLowStockCount.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(10, 94);
            label7.Name = "label7";
            label7.Size = new Size(134, 21);
            label7.TabIndex = 1;
            label7.Text = "NEEDS RESTOCK";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(27, 21);
            label6.Name = "label6";
            label6.Size = new Size(99, 21);
            label6.TabIndex = 0;
            label6.Text = "LOW STOCK";
            // 
            // panel5
            // 
            panel5.BackColor = Color.OrangeRed;
            panel5.Controls.Add(lblInventoryValue);
            panel5.Controls.Add(label9);
            panel5.Controls.Add(label8);
            panel5.Location = new Point(1054, 113);
            panel5.Name = "panel5";
            panel5.Size = new Size(155, 135);
            panel5.TabIndex = 5;
            // 
            // lblInventoryValue
            // 
            lblInventoryValue.AutoSize = true;
            lblInventoryValue.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInventoryValue.ForeColor = Color.White;
            lblInventoryValue.Location = new Point(64, 62);
            lblInventoryValue.Name = "lblInventoryValue";
            lblInventoryValue.Size = new Size(19, 21);
            lblInventoryValue.TabIndex = 2;
            lblInventoryValue.Text = "0";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(47, 93);
            label9.Name = "label9";
            label9.Size = new Size(60, 21);
            label9.TabIndex = 1;
            label9.Text = "VALUE";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(27, 21);
            label8.Name = "label8";
            label8.Size = new Size(101, 21);
            label8.TabIndex = 0;
            label8.Text = "INVENTORY";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(361, 22);
            label10.Name = "label10";
            label10.Size = new Size(186, 37);
            label10.TabIndex = 7;
            label10.Text = "DASHBOARD";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(374, 308);
            label11.Name = "label11";
            label11.Size = new Size(213, 30);
            label11.TabIndex = 8;
            label11.Text = "LOW STOCK ALERTS";
            // 
            // panel6
            // 
            panel6.BackColor = Color.OrangeRed;
            panel6.Controls.Add(panel7);
            panel6.Location = new Point(374, 367);
            panel6.Name = "panel6";
            panel6.Size = new Size(410, 241);
            panel6.TabIndex = 9;
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Controls.Add(lblLowReorder3);
            panel7.Controls.Add(btnRestock);
            panel7.Controls.Add(lblLowReorder2);
            panel7.Controls.Add(label12);
            panel7.Controls.Add(lblLowStock3);
            panel7.Controls.Add(label13);
            panel7.Controls.Add(lblLowStock2);
            panel7.Controls.Add(label14);
            panel7.Controls.Add(lblLowReorder1);
            panel7.Controls.Add(lblLowProduct1);
            panel7.Controls.Add(lblLowProduct3);
            panel7.Controls.Add(lblLowStock1);
            panel7.Controls.Add(lblLowProduct2);
            panel7.Location = new Point(21, 19);
            panel7.Name = "panel7";
            panel7.Size = new Size(369, 203);
            panel7.TabIndex = 13;
            // 
            // lblLowReorder3
            // 
            lblLowReorder3.AutoSize = true;
            lblLowReorder3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLowReorder3.Location = new Point(312, 133);
            lblLowReorder3.Name = "lblLowReorder3";
            lblLowReorder3.Size = new Size(14, 15);
            lblLowReorder3.TabIndex = 11;
            lblLowReorder3.Text = "0";
            // 
            // btnRestock
            // 
            btnRestock.BackColor = Color.FromArgb(192, 192, 255);
            btnRestock.FlatStyle = FlatStyle.Flat;
            btnRestock.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRestock.Location = new Point(146, 168);
            btnRestock.Name = "btnRestock";
            btnRestock.Size = new Size(75, 23);
            btnRestock.TabIndex = 12;
            btnRestock.Text = "RESTOCK";
            btnRestock.UseVisualStyleBackColor = false;
            // 
            // lblLowReorder2
            // 
            lblLowReorder2.AutoSize = true;
            lblLowReorder2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLowReorder2.Location = new Point(312, 92);
            lblLowReorder2.Name = "lblLowReorder2";
            lblLowReorder2.Size = new Size(14, 15);
            lblLowReorder2.TabIndex = 10;
            lblLowReorder2.Text = "0";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(3, 9);
            label12.Name = "label12";
            label12.Size = new Size(85, 21);
            label12.TabIndex = 0;
            label12.Text = "PRODUCT";
            // 
            // lblLowStock3
            // 
            lblLowStock3.AutoSize = true;
            lblLowStock3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLowStock3.Location = new Point(222, 133);
            lblLowStock3.Name = "lblLowStock3";
            lblLowStock3.Size = new Size(14, 15);
            lblLowStock3.TabIndex = 8;
            lblLowStock3.Text = "0";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(202, 9);
            label13.Name = "label13";
            label13.Size = new Size(59, 21);
            label13.TabIndex = 1;
            label13.Text = "STOCK";
            // 
            // lblLowStock2
            // 
            lblLowStock2.AutoSize = true;
            lblLowStock2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLowStock2.Location = new Point(222, 92);
            lblLowStock2.Name = "lblLowStock2";
            lblLowStock2.Size = new Size(14, 15);
            lblLowStock2.TabIndex = 7;
            lblLowStock2.Text = "0";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(276, 9);
            label14.Name = "label14";
            label14.Size = new Size(82, 21);
            label14.TabIndex = 2;
            label14.Text = "REORDER";
            // 
            // lblLowReorder1
            // 
            lblLowReorder1.AutoSize = true;
            lblLowReorder1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLowReorder1.Location = new Point(312, 51);
            lblLowReorder1.Name = "lblLowReorder1";
            lblLowReorder1.Size = new Size(14, 15);
            lblLowReorder1.TabIndex = 9;
            lblLowReorder1.Text = "0";
            // 
            // lblLowProduct1
            // 
            lblLowProduct1.AutoSize = true;
            lblLowProduct1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLowProduct1.Location = new Point(4, 51);
            lblLowProduct1.Name = "lblLowProduct1";
            lblLowProduct1.Size = new Size(74, 15);
            lblLowProduct1.TabIndex = 3;
            lblLowProduct1.Text = "PRODUCT A";
            // 
            // lblLowProduct3
            // 
            lblLowProduct3.AutoSize = true;
            lblLowProduct3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLowProduct3.Location = new Point(5, 133);
            lblLowProduct3.Name = "lblLowProduct3";
            lblLowProduct3.Size = new Size(73, 15);
            lblLowProduct3.TabIndex = 5;
            lblLowProduct3.Text = "PRODUCT C";
            // 
            // lblLowStock1
            // 
            lblLowStock1.AutoSize = true;
            lblLowStock1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLowStock1.Location = new Point(222, 51);
            lblLowStock1.Name = "lblLowStock1";
            lblLowStock1.Size = new Size(14, 15);
            lblLowStock1.TabIndex = 6;
            lblLowStock1.Text = "0";
            // 
            // lblLowProduct2
            // 
            lblLowProduct2.AutoSize = true;
            lblLowProduct2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLowProduct2.Location = new Point(4, 92);
            lblLowProduct2.Name = "lblLowProduct2";
            lblLowProduct2.Size = new Size(74, 15);
            lblLowProduct2.TabIndex = 4;
            lblLowProduct2.Text = "PRODUCT B";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label28.Location = new Point(936, 308);
            label28.Name = "label28";
            label28.Size = new Size(175, 30);
            label28.TabIndex = 10;
            label28.Text = "RECENT STOCKS";
            // 
            // panel8
            // 
            panel8.BackColor = Color.OrangeRed;
            panel8.Controls.Add(panel9);
            panel8.Location = new Point(936, 367);
            panel8.Name = "panel8";
            panel8.Size = new Size(317, 241);
            panel8.TabIndex = 11;
            // 
            // panel9
            // 
            panel9.BackColor = Color.White;
            panel9.Controls.Add(lblRecentQty3);
            panel9.Controls.Add(lblRecentQty2);
            panel9.Controls.Add(lblRecentQty1);
            panel9.Controls.Add(lblRecentItem3);
            panel9.Controls.Add(lblRecentItem2);
            panel9.Controls.Add(lblRecentItem1);
            panel9.Controls.Add(lblRecentDate3);
            panel9.Controls.Add(lblRecentDate2);
            panel9.Controls.Add(lblRecentDate1);
            panel9.Controls.Add(label31);
            panel9.Controls.Add(label30);
            panel9.Controls.Add(label29);
            panel9.Location = new Point(16, 19);
            panel9.Name = "panel9";
            panel9.Size = new Size(285, 203);
            panel9.TabIndex = 0;
            // 
            // lblRecentQty3
            // 
            lblRecentQty3.AutoSize = true;
            lblRecentQty3.Location = new Point(249, 133);
            lblRecentQty3.Name = "lblRecentQty3";
            lblRecentQty3.Size = new Size(13, 15);
            lblRecentQty3.TabIndex = 11;
            lblRecentQty3.Text = "0";
            // 
            // lblRecentQty2
            // 
            lblRecentQty2.AutoSize = true;
            lblRecentQty2.Location = new Point(249, 92);
            lblRecentQty2.Name = "lblRecentQty2";
            lblRecentQty2.Size = new Size(13, 15);
            lblRecentQty2.TabIndex = 10;
            lblRecentQty2.Text = "0";
            // 
            // lblRecentQty1
            // 
            lblRecentQty1.AutoSize = true;
            lblRecentQty1.Location = new Point(249, 65);
            lblRecentQty1.Name = "lblRecentQty1";
            lblRecentQty1.Size = new Size(13, 15);
            lblRecentQty1.TabIndex = 9;
            lblRecentQty1.Text = "0";
            // 
            // lblRecentItem3
            // 
            lblRecentItem3.AutoSize = true;
            lblRecentItem3.Location = new Point(115, 136);
            lblRecentItem3.Name = "lblRecentItem3";
            lblRecentItem3.Size = new Size(71, 15);
            lblRecentItem3.TabIndex = 8;
            lblRecentItem3.Text = "PRODUCT C";
            // 
            // lblRecentItem2
            // 
            lblRecentItem2.AutoSize = true;
            lblRecentItem2.Location = new Point(115, 99);
            lblRecentItem2.Name = "lblRecentItem2";
            lblRecentItem2.Size = new Size(70, 15);
            lblRecentItem2.TabIndex = 7;
            lblRecentItem2.Text = "PRODUCT B";
            // 
            // lblRecentItem1
            // 
            lblRecentItem1.AutoSize = true;
            lblRecentItem1.Location = new Point(115, 65);
            lblRecentItem1.Name = "lblRecentItem1";
            lblRecentItem1.Size = new Size(71, 15);
            lblRecentItem1.TabIndex = 6;
            lblRecentItem1.Text = "PRODUCT A";
            // 
            // lblRecentDate3
            // 
            lblRecentDate3.AutoSize = true;
            lblRecentDate3.Location = new Point(23, 136);
            lblRecentDate3.Name = "lblRecentDate3";
            lblRecentDate3.Size = new Size(53, 15);
            lblRecentDate3.TabIndex = 5;
            lblRecentDate3.Text = "00/00/00";
            // 
            // lblRecentDate2
            // 
            lblRecentDate2.AutoSize = true;
            lblRecentDate2.Location = new Point(23, 99);
            lblRecentDate2.Name = "lblRecentDate2";
            lblRecentDate2.Size = new Size(53, 15);
            lblRecentDate2.TabIndex = 4;
            lblRecentDate2.Text = "00/00/00";
            // 
            // lblRecentDate1
            // 
            lblRecentDate1.AutoSize = true;
            lblRecentDate1.Location = new Point(23, 65);
            lblRecentDate1.Name = "lblRecentDate1";
            lblRecentDate1.Size = new Size(53, 15);
            lblRecentDate1.TabIndex = 3;
            lblRecentDate1.Text = "00/00/00";
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label31.Location = new Point(234, 15);
            label31.Name = "label31";
            label31.Size = new Size(40, 21);
            label31.TabIndex = 2;
            label31.Text = "QTY";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label30.Location = new Point(124, 15);
            label30.Name = "label30";
            label30.Size = new Size(48, 21);
            label30.TabIndex = 1;
            label30.Text = "ITEM";
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label29.Location = new Point(23, 15);
            label29.Name = "label29";
            label29.Size = new Size(50, 21);
            label29.TabIndex = 0;
            label29.Text = "DATE";
            // 
            // frmAdminDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(1350, 729);
            Controls.Add(panel8);
            Controls.Add(label28);
            Controls.Add(panel6);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAdminDashboard";
            Text = "frmAdminDashboard";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label2;
        private Button btnLogout;
        private Button btnProductManagement;
        private Button btnSuppliers;
        private Button btnSupplierProduct;
        private Button btnDashboard;
        private Panel panel1;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Label label3;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label6;
        private Label label7;
        private Label label9;
        private Label label8;
        private Label label10;
        private Label label11;
        private Panel panel6;
        private Label label12;
        private Label lblLowReorder3;
        private Label lblLowReorder2;
        private Label lblLowReorder1;
        private Label lblLowStock3;
        private Label lblLowStock2;
        private Label lblLowStock1;
        private Label lblLowProduct3;
        private Label lblLowProduct2;
        private Label lblLowProduct1;
        private Label label14;
        private Label label13;
        private Button btnRestock;
        private Panel panel7;
        private Label lblSuppliersCount;
        private Label lblProductsCount;
        private Label lblLowStockCount;
        private Label lblInventoryValue;
        private Label label28;
        private Panel panel8;
        private Panel panel9;
        private Label lblRecentQty3;
        private Label lblRecentQty2;
        private Label lblRecentQty1;
        private Label lblRecentItem3;
        private Label lblRecentItem2;
        private Label lblRecentItem1;
        private Label lblRecentDate3;
        private Label lblRecentDate2;
        private Label lblRecentDate1;
        private Label label31;
        private Label label30;
        private Label label29;
    }
}