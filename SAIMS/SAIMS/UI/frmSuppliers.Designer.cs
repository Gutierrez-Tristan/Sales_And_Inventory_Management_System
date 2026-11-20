namespace SAIMS.UI
{
    partial class frmSuppliers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSuppliers));
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            btnLogout = new Button();
            btnProducts = new Button();
            btnSuppliers = new Button();
            btnSupplierProduct = new Button();
            btnDashboard = new Button();
            label1 = new Label();
            btnAddNew = new Button();
            btnRefresh = new Button();
            txtSearch = new TextBox();
            dgvSuppliers = new DataGridView();
            pnlSupplierForm = new Panel();
            panel3 = new Panel();
            chkActive = new CheckBox();
            btnCancel = new Button();
            btnSave = new Button();
            txtAddress = new TextBox();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            txtName = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            lblFormTitle = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSuppliers).BeginInit();
            pnlSupplierForm.SuspendLayout();
            panel3.SuspendLayout();
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
            label1.Location = new Point(355, 22);
            label1.Name = "label1";
            label1.Size = new Size(362, 37);
            label1.TabIndex = 3;
            label1.Text = "SUPPLIER'S INFORMATION";
            // 
            // btnAddNew
            // 
            btnAddNew.BackColor = Color.Lime;
            btnAddNew.FlatStyle = FlatStyle.Flat;
            btnAddNew.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddNew.Location = new Point(364, 109);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(108, 29);
            btnAddNew.TabIndex = 4;
            btnAddNew.Text = "ADD NEW";
            btnAddNew.UseVisualStyleBackColor = false;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(128, 128, 255);
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.Location = new Point(800, 109);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(108, 29);
            btnRefresh.TabIndex = 5;
            btnRefresh.Text = "REFRESH";
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(914, 109);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(342, 29);
            txtSearch.TabIndex = 6;
            // 
            // dgvSuppliers
            // 
            dgvSuppliers.BackgroundColor = Color.White;
            dgvSuppliers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSuppliers.Location = new Point(343, 167);
            dgvSuppliers.Name = "dgvSuppliers";
            dgvSuppliers.Size = new Size(892, 447);
            dgvSuppliers.TabIndex = 7;
            // 
            // pnlSupplierForm
            // 
            pnlSupplierForm.BackColor = Color.OrangeRed;
            pnlSupplierForm.BackgroundImageLayout = ImageLayout.None;
            pnlSupplierForm.Controls.Add(panel3);
            pnlSupplierForm.Location = new Point(657, 186);
            pnlSupplierForm.Name = "pnlSupplierForm";
            pnlSupplierForm.Size = new Size(306, 384);
            pnlSupplierForm.TabIndex = 8;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(chkActive);
            panel3.Controls.Add(btnCancel);
            panel3.Controls.Add(btnSave);
            panel3.Controls.Add(txtAddress);
            panel3.Controls.Add(txtPhone);
            panel3.Controls.Add(txtEmail);
            panel3.Controls.Add(txtName);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(lblFormTitle);
            panel3.Location = new Point(18, 15);
            panel3.Name = "panel3";
            panel3.Size = new Size(272, 350);
            panel3.TabIndex = 0;
            // 
            // chkActive
            // 
            chkActive.AutoSize = true;
            chkActive.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkActive.Location = new Point(17, 256);
            chkActive.Name = "chkActive";
            chkActive.Size = new Size(78, 25);
            chkActive.TabIndex = 11;
            chkActive.Text = "Active?";
            chkActive.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(255, 128, 128);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(163, 287);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(83, 30);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(128, 255, 128);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(37, 287);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(83, 30);
            btnSave.TabIndex = 9;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(92, 216);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(154, 23);
            txtAddress.TabIndex = 8;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(92, 165);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(154, 23);
            txtPhone.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(92, 114);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(154, 23);
            txtEmail.TabIndex = 6;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(92, 63);
            txtName.Name = "txtName";
            txtName.Size = new Size(154, 23);
            txtName.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 216);
            label7.Name = "label7";
            label7.Size = new Size(74, 21);
            label7.TabIndex = 4;
            label7.Text = "Address:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 165);
            label6.Name = "label6";
            label6.Size = new Size(63, 21);
            label6.TabIndex = 3;
            label6.Text = "Phone:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 114);
            label5.Name = "label5";
            label5.Size = new Size(57, 21);
            label5.TabIndex = 2;
            label5.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 63);
            label4.Name = "label4";
            label4.Size = new Size(60, 21);
            label4.TabIndex = 1;
            label4.Text = "Name:";
            // 
            // lblFormTitle
            // 
            lblFormTitle.AutoSize = true;
            lblFormTitle.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFormTitle.Location = new Point(62, 5);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(160, 30);
            lblFormTitle.TabIndex = 0;
            lblFormTitle.Text = "ADD SUPPLIER";
            // 
            // frmSuppliers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(1350, 729);
            Controls.Add(pnlSupplierForm);
            Controls.Add(dgvSuppliers);
            Controls.Add(txtSearch);
            Controls.Add(btnRefresh);
            Controls.Add(btnAddNew);
            Controls.Add(label1);
            Controls.Add(panel2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmSuppliers";
            Text = "frmSuppliers";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSuppliers).EndInit();
            pnlSupplierForm.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
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
        private Button btnAddNew;
        private Button btnRefresh;
        private TextBox txtSearch;
        private DataGridView dgvSuppliers;
        private Panel pnlSupplierForm;
        private Panel panel3;
        private Label lblFormTitle;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private TextBox txtName;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button btnCancel;
        private Button btnSave;
        private TextBox txtAddress;
        private CheckBox chkActive;
    }
}