namespace SAIMS.UI
{
    partial class Transaction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transaction));
            panel1 = new Panel();
            btnStockInquiry = new Button();
            btnLogout = new Button();
            btnTransaction = new Button();
            btnPOS = new Button();
            btnDashboard = new Button();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            dgvTransactions = new DataGridView();
            txtSearch = new TextBox();
            label1 = new Label();
            btnViewReceipt = new Button();
            btnRefresh = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.OrangeRed;
            panel1.Controls.Add(btnStockInquiry);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(btnTransaction);
            panel1.Controls.Add(btnPOS);
            panel1.Controls.Add(btnDashboard);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(319, 742);
            panel1.TabIndex = 1;
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
            btnStockInquiry.TabIndex = 23;
            btnStockInquiry.Text = "STOCK INQUIRY";
            btnStockInquiry.UseVisualStyleBackColor = false;
            btnStockInquiry.Click += btnStockInquiry_Click_1;
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
            // 
            // btnPOS
            // 
            btnPOS.BackColor = Color.OrangeRed;
            btnPOS.FlatStyle = FlatStyle.Flat;
            btnPOS.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnPOS.ForeColor = Color.White;
            btnPOS.Location = new Point(36, 297);
            btnPOS.Margin = new Padding(3, 2, 3, 2);
            btnPOS.Name = "btnPOS";
            btnPOS.Size = new Size(245, 47);
            btnPOS.TabIndex = 18;
            btnPOS.Text = "POS";
            btnPOS.UseVisualStyleBackColor = false;
            btnPOS.Click += btnPOS_Click;
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
            // dgvTransactions
            // 
            dgvTransactions.BackgroundColor = Color.White;
            dgvTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransactions.Location = new Point(362, 203);
            dgvTransactions.Name = "dgvTransactions";
            dgvTransactions.Size = new Size(903, 480);
            dgvTransactions.TabIndex = 8;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(362, 107);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(774, 35);
            txtSearch.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(362, 51);
            label1.Name = "label1";
            label1.Size = new Size(208, 37);
            label1.TabIndex = 6;
            label1.Text = "TRANSACTION";
            // 
            // btnViewReceipt
            // 
            btnViewReceipt.BackColor = Color.FromArgb(255, 255, 128);
            btnViewReceipt.FlatStyle = FlatStyle.Flat;
            btnViewReceipt.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewReceipt.Location = new Point(1142, 164);
            btnViewReceipt.Name = "btnViewReceipt";
            btnViewReceipt.Size = new Size(123, 33);
            btnViewReceipt.TabIndex = 9;
            btnViewReceipt.Text = "View Receipt";
            btnViewReceipt.UseVisualStyleBackColor = false;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(128, 128, 255);
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.Location = new Point(1142, 107);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(123, 35);
            btnRefresh.TabIndex = 10;
            btnRefresh.Text = "REFRESH";
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // Transaction
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(1350, 729);
            Controls.Add(btnRefresh);
            Controls.Add(btnViewReceipt);
            Controls.Add(dgvTransactions);
            Controls.Add(txtSearch);
            Controls.Add(label1);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Transaction";
            Text = "Transaction";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnLogout;
        private Button btnProfile;
        private Button btnProducts;
        private Button btnTransaction;
        private Button btnPOS;
        private Button btnDashboard;
        private Label label2;
        private PictureBox pictureBox1;
        private DataGridView dgvTransactions;
        private TextBox txtSearch;
        private Label label1;
        private Button btnViewReceipt;
        private Button btnRefresh;
        private Button btnStockInquiry;
    }
}