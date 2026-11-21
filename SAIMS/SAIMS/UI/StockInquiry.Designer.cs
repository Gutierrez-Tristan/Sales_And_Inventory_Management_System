namespace SAIMS.UI
{
    partial class StockInquiry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockInquiry));
            panel1 = new Panel();
            btnLogout = new Button();
            btnStockInquiry = new Button();
            btnTransaction = new Button();
            btnPOS = new Button();
            btnDashboard = new Button();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            txtSearch = new TextBox();
            dgvStock = new DataGridView();
            btnRefresh = new Button();
            cboStatus = new ComboBox();
            lblSummary = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvStock).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.OrangeRed;
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(btnStockInquiry);
            panel1.Controls.Add(btnTransaction);
            panel1.Controls.Add(btnPOS);
            panel1.Controls.Add(btnDashboard);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(319, 742);
            panel1.TabIndex = 2;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(370, 50);
            label1.Name = "label1";
            label1.Size = new Size(187, 37);
            label1.TabIndex = 3;
            label1.Text = "Stock Inquiry";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(379, 104);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(629, 35);
            txtSearch.TabIndex = 4;
            // 
            // dgvStock
            // 
            dgvStock.BackgroundColor = Color.White;
            dgvStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStock.Location = new Point(379, 200);
            dgvStock.Name = "dgvStock";
            dgvStock.Size = new Size(903, 480);
            dgvStock.TabIndex = 5;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(128, 128, 255);
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.Location = new Point(1141, 104);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(123, 35);
            btnRefresh.TabIndex = 11;
            btnRefresh.Text = "REFRESH";
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // cboStatus
            // 
            cboStatus.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboStatus.FormattingEnabled = true;
            cboStatus.Location = new Point(1014, 101);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(121, 38);
            cboStatus.TabIndex = 12;
            // 
            // lblSummary
            // 
            lblSummary.AutoSize = true;
            lblSummary.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSummary.Location = new Point(379, 169);
            lblSummary.Name = "lblSummary";
            lblSummary.Size = new Size(208, 15);
            lblSummary.TabIndex = 13;
            lblSummary.Text = "25 product(s) | 3 low | 1 out of stock";
            // 
            // StockInquiry
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(1350, 729);
            Controls.Add(lblSummary);
            Controls.Add(cboStatus);
            Controls.Add(btnRefresh);
            Controls.Add(dgvStock);
            Controls.Add(txtSearch);
            Controls.Add(label1);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "StockInquiry";
            Text = "StockInquiry";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnLogout;
        private Button btnStockInquiry;
        private Button btnTransaction;
        private Button btnPOS;
        private Button btnDashboard;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox txtSearch;
        private DataGridView dgvStock;
        private Button btnRefresh;
        private ComboBox cboStatus;
        private Label lblSummary;
    }
}