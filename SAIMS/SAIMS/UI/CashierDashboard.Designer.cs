namespace SAIMS.UI
{
    partial class CashierDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashierDashboard));
            panel1 = new Panel();
            btnLogout = new Button();
            btnStockInquiry = new Button();
            btnTransaction = new Button();
            btnPOS = new Button();
            btnDashboard = new Button();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            dgvRecent = new DataGridView();
            btnReload = new Button();
            panel2 = new Panel();
            lblSalesToday = new Label();
            panel3 = new Panel();
            lblTransactions = new Label();
            panel4 = new Panel();
            lblItemsSold = new Label();
            panel5 = new Panel();
            lblLowStock = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRecent).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
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
            panel1.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.OrangeRed;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(37, 424);
            btnLogout.Margin = new Padding(3, 2, 3, 2);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(245, 47);
            btnLogout.TabIndex = 15;
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
            btnStockInquiry.Location = new Point(37, 373);
            btnStockInquiry.Margin = new Padding(3, 2, 3, 2);
            btnStockInquiry.Name = "btnStockInquiry";
            btnStockInquiry.Size = new Size(245, 47);
            btnStockInquiry.TabIndex = 13;
            btnStockInquiry.Text = "STOCK INQUIRY";
            btnStockInquiry.UseVisualStyleBackColor = false;
            // 
            // btnTransaction
            // 
            btnTransaction.BackColor = Color.OrangeRed;
            btnTransaction.FlatStyle = FlatStyle.Flat;
            btnTransaction.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnTransaction.ForeColor = Color.White;
            btnTransaction.Location = new Point(37, 322);
            btnTransaction.Margin = new Padding(3, 2, 3, 2);
            btnTransaction.Name = "btnTransaction";
            btnTransaction.Size = new Size(245, 47);
            btnTransaction.TabIndex = 12;
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
            btnPOS.Location = new Point(37, 271);
            btnPOS.Margin = new Padding(3, 2, 3, 2);
            btnPOS.Name = "btnPOS";
            btnPOS.Size = new Size(245, 47);
            btnPOS.TabIndex = 11;
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
            btnDashboard.Location = new Point(37, 220);
            btnDashboard.Margin = new Padding(3, 2, 3, 2);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(245, 47);
            btnDashboard.TabIndex = 10;
            btnDashboard.Text = "DASHBOARD";
            btnDashboard.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 174);
            label2.Name = "label2";
            label2.Size = new Size(80, 32);
            label2.TabIndex = 9;
            label2.Text = "Menu";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(72, 20);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(144, 116);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(386, 45);
            label1.Name = "label1";
            label1.Size = new Size(186, 37);
            label1.TabIndex = 1;
            label1.Text = "DASHBOARD";
            // 
            // dgvRecent
            // 
            dgvRecent.BackgroundColor = Color.White;
            dgvRecent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecent.Location = new Point(353, 373);
            dgvRecent.Margin = new Padding(3, 2, 3, 2);
            dgvRecent.Name = "dgvRecent";
            dgvRecent.RowHeadersWidth = 51;
            dgvRecent.Size = new Size(985, 278);
            dgvRecent.TabIndex = 9;
            // 
            // btnReload
            // 
            btnReload.BackColor = Color.SteelBlue;
            btnReload.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReload.ForeColor = Color.White;
            btnReload.Location = new Point(353, 322);
            btnReload.Margin = new Padding(3, 2, 3, 2);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(118, 43);
            btnReload.TabIndex = 10;
            btnReload.Text = "Reload";
            btnReload.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.OrangeRed;
            panel2.Controls.Add(lblSalesToday);
            panel2.Location = new Point(545, 95);
            panel2.Name = "panel2";
            panel2.Size = new Size(207, 111);
            panel2.TabIndex = 11;
            // 
            // lblSalesToday
            // 
            lblSalesToday.AutoSize = true;
            lblSalesToday.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSalesToday.ForeColor = Color.White;
            lblSalesToday.Location = new Point(40, 16);
            lblSalesToday.Name = "lblSalesToday";
            lblSalesToday.Size = new Size(114, 25);
            lblSalesToday.TabIndex = 1;
            lblSalesToday.Text = "Sales Today";
            lblSalesToday.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.BackColor = Color.OrangeRed;
            panel3.Controls.Add(lblTransactions);
            panel3.Location = new Point(862, 95);
            panel3.Name = "panel3";
            panel3.Size = new Size(207, 111);
            panel3.TabIndex = 12;
            // 
            // lblTransactions
            // 
            lblTransactions.AutoSize = true;
            lblTransactions.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTransactions.ForeColor = Color.White;
            lblTransactions.Location = new Point(31, 16);
            lblTransactions.Name = "lblTransactions";
            lblTransactions.Size = new Size(123, 25);
            lblTransactions.TabIndex = 2;
            lblTransactions.Text = "Transactions";
            lblTransactions.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            panel4.BackColor = Color.OrangeRed;
            panel4.Controls.Add(lblItemsSold);
            panel4.Location = new Point(545, 220);
            panel4.Name = "panel4";
            panel4.Size = new Size(207, 111);
            panel4.TabIndex = 12;
            // 
            // lblItemsSold
            // 
            lblItemsSold.AutoSize = true;
            lblItemsSold.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblItemsSold.ForeColor = Color.White;
            lblItemsSold.Location = new Point(51, 22);
            lblItemsSold.Name = "lblItemsSold";
            lblItemsSold.Size = new Size(97, 25);
            lblItemsSold.TabIndex = 4;
            lblItemsSold.Text = "Item Sold";
            lblItemsSold.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            panel5.BackColor = Color.OrangeRed;
            panel5.Controls.Add(lblLowStock);
            panel5.Location = new Point(862, 220);
            panel5.Name = "panel5";
            panel5.Size = new Size(207, 111);
            panel5.TabIndex = 12;
            // 
            // lblLowStock
            // 
            lblLowStock.AutoSize = true;
            lblLowStock.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLowStock.ForeColor = Color.White;
            lblLowStock.Location = new Point(50, 22);
            lblLowStock.Name = "lblLowStock";
            lblLowStock.Size = new Size(104, 25);
            lblLowStock.TabIndex = 3;
            lblLowStock.Text = "Low Stock";
            lblLowStock.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CashierDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(1350, 729);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(btnReload);
            Controls.Add(dgvRecent);
            Controls.Add(label1);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "CashierDashboard";
            Text = "CashierDashboard";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRecent).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label2;
        private Button btnLogout;
        private Button btnProfile;
        private Button btnStockInquiry;
        private Button btnTransaction;
        private Button btnPOS;
        private Button btnDashboard;
        private Label label1;
        private DataGridView dgvRecent;
        private Button btnReload;
        private Panel panel2;
        private Label lblSalesToday;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Label lblTransactions;
        private Label lblItemsSold;
        private Label lblLowStock;
    }
}