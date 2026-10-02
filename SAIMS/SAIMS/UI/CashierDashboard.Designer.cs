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
            panel1 = new Panel();
            btnLogout = new Button();
            btnStockInquiry = new Button();
            this.btnTransaction = new Button();
            btnPos = new Button();
            btnDashboard = new Button();
            label1 = new Label();
            btnStockAlert = new Button();
            btnRecentTransaction = new Button();
            btnNoOfTransaction = new Button();
            btnTodaySale = new Button();
            btnProfile = new Button();
            this.pictureBoxLogo = new PictureBox();
            panel2 = new Panel();
            label2 = new Label();
            label3 = new Label();
            dgvOverview = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.pictureBoxLogo).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOverview).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.NavajoWhite;
            panel1.Controls.Add(dgvOverview);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnStockAlert);
            panel1.Controls.Add(btnRecentTransaction);
            panel1.Controls.Add(btnNoOfTransaction);
            panel1.Controls.Add(btnTodaySale);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(-6, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(896, 508);
            panel1.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 8F);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(46, 418);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(142, 28);
            btnLogout.TabIndex = 10;
            btnLogout.Text = "LOGOUT";
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnStockInquiry
            // 
            btnStockInquiry.BackColor = Color.OrangeRed;
            btnStockInquiry.FlatStyle = FlatStyle.Flat;
            btnStockInquiry.Font = new Font("Segoe UI", 8F);
            btnStockInquiry.ForeColor = Color.White;
            btnStockInquiry.Location = new Point(46, 350);
            btnStockInquiry.Name = "btnStockInquiry";
            btnStockInquiry.Size = new Size(142, 28);
            btnStockInquiry.TabIndex = 8;
            btnStockInquiry.Text = "STOCKINQUIRY";
            btnStockInquiry.UseVisualStyleBackColor = false;
            btnStockInquiry.Click += btnStockInquiry_Click;
            // 
            // btnTransaction
            // 
            this.btnTransaction.BackColor = Color.OrangeRed;
            this.btnTransaction.FlatStyle = FlatStyle.Flat;
            this.btnTransaction.Font = new Font("Segoe UI", 8F);
            this.btnTransaction.ForeColor = Color.White;
            this.btnTransaction.Location = new Point(46, 316);
            this.btnTransaction.Name = "btnTransaction";
            this.btnTransaction.Size = new Size(142, 28);
            this.btnTransaction.TabIndex = 7;
            this.btnTransaction.Text = "TRANSACTION";
            this.btnTransaction.UseVisualStyleBackColor = false;
            // 
            // btnPos
            // 
            btnPos.BackColor = Color.OrangeRed;
            btnPos.FlatStyle = FlatStyle.Flat;
            btnPos.Font = new Font("Segoe UI", 8F);
            btnPos.ForeColor = Color.White;
            btnPos.Location = new Point(46, 282);
            btnPos.Name = "btnPos";
            btnPos.Size = new Size(142, 28);
            btnPos.TabIndex = 6;
            btnPos.Text = "POS";
            btnPos.UseVisualStyleBackColor = false;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.OrangeRed;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 8F);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(46, 248);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(142, 28);
            btnDashboard.TabIndex = 5;
            btnDashboard.Text = "DASHBOARD";
            btnDashboard.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(288, 26);
            label1.Name = "label1";
            label1.Size = new Size(118, 23);
            label1.TabIndex = 4;
            label1.Text = "DASHBOARD";
            // 
            // btnStockAlert
            // 
            btnStockAlert.Font = new Font("Segoe UI", 8F);
            btnStockAlert.Location = new Point(621, 145);
            btnStockAlert.Name = "btnStockAlert";
            btnStockAlert.Size = new Size(138, 46);
            btnStockAlert.TabIndex = 3;
            btnStockAlert.Text = "STOCK ALERT";
            btnStockAlert.UseVisualStyleBackColor = true;
            // 
            // btnRecentTransaction
            // 
            btnRecentTransaction.Font = new Font("Segoe UI", 8F);
            btnRecentTransaction.Location = new Point(368, 145);
            btnRecentTransaction.Name = "btnRecentTransaction";
            btnRecentTransaction.Size = new Size(138, 46);
            btnRecentTransaction.TabIndex = 2;
            btnRecentTransaction.Text = "RECENT TRANSACTION";
            btnRecentTransaction.UseVisualStyleBackColor = true;
            // 
            // btnNoOfTransaction
            // 
            btnNoOfTransaction.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNoOfTransaction.Location = new Point(621, 79);
            btnNoOfTransaction.Name = "btnNoOfTransaction";
            btnNoOfTransaction.Size = new Size(138, 46);
            btnNoOfTransaction.TabIndex = 1;
            btnNoOfTransaction.Text = "NO. OF TRANSACTION";
            btnNoOfTransaction.UseVisualStyleBackColor = true;
            // 
            // btnTodaySale
            // 
            btnTodaySale.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTodaySale.Location = new Point(368, 79);
            btnTodaySale.Name = "btnTodaySale";
            btnTodaySale.Size = new Size(138, 46);
            btnTodaySale.TabIndex = 0;
            btnTodaySale.Text = "TODAY'S SALE";
            btnTodaySale.UseVisualStyleBackColor = true;
            // 
            // btnProfile
            // 
            btnProfile.BackColor = Color.OrangeRed;
            btnProfile.FlatStyle = FlatStyle.Flat;
            btnProfile.Font = new Font("Segoe UI", 8F);
            btnProfile.ForeColor = Color.White;
            btnProfile.Location = new Point(46, 384);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(142, 28);
            btnProfile.TabIndex = 11;
            btnProfile.Text = "PROFILE";
            btnProfile.UseVisualStyleBackColor = false;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = Properties.Resources.ddd3;
            this.pictureBoxLogo.Location = new Point(57, 26);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new Size(115, 99);
            this.pictureBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 12;
            this.pictureBoxLogo.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.OrangeRed;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(btnProfile);
            panel2.Controls.Add(this.pictureBoxLogo);
            panel2.Controls.Add(btnStockInquiry);
            panel2.Controls.Add(btnLogout);
            panel2.Controls.Add(this.btnTransaction);
            panel2.Controls.Add(btnDashboard);
            panel2.Controls.Add(btnPos);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(229, 508);
            panel2.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(19, 212);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 13;
            label2.Text = "Menu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(39, 128);
            label3.Name = "label3";
            label3.Size = new Size(149, 31);
            label3.TabIndex = 14;
            label3.Text = "LOGO NAME";
            // 
            // dgvOverview
            // 
            dgvOverview.BackgroundColor = Color.White;
            dgvOverview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOverview.Location = new Point(288, 225);
            dgvOverview.Name = "dgvOverview";
            dgvOverview.RowHeadersWidth = 51;
            dgvOverview.Size = new Size(548, 248);
            dgvOverview.TabIndex = 14;
            // 
            // CashierDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(887, 503);
            Controls.Add(panel1);
            Name = "CashierDashboard";
            Text = "CashierDashboard";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)this.pictureBoxLogo).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOverview).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnNoOfTransaction;
        private Button btnTodaySale;
        private Label label1;
        private Button btnStockAlert;
        private Button btnRecentTransaction;
        private Button button3;
        private Button btnPos;
        private Button btnDashboard;
        private Button button2;
        private Button btnStockInquiry;
        private Button btnTransaction;
        private Button btnLogout;
        private Button btnProfile;
        private PictureBox pictureBoxLogo;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label label2;
        private Label label3;
        private DataGridView dgvOverview;
    }
}