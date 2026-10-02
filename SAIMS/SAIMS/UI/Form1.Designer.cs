namespace SAIMS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label6 = new Label();
            pictureBoxLogo = new PictureBox();
            label5 = new Label();
            panel2 = new Panel();
            lnkSigUp = new LinkLabel();
            label4 = new Label();
            btnLogin = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.OrangeRed;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(pictureBoxLogo);
            panel1.Controls.Add(label5);
            panel1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel1.Location = new Point(-1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(272, 513);
            panel1.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(55, 331);
            label6.Name = "label6";
            label6.Size = new Size(149, 31);
            label6.TabIndex = 2;
            label6.Text = "LOGO NAME";
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = Properties.Resources.ddd;
            pictureBoxLogo.Location = new Point(37, 133);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(195, 185);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLogo.TabIndex = 1;
            pictureBoxLogo.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(37, 80);
            label5.Name = "label5";
            label5.Size = new Size(195, 38);
            label5.TabIndex = 0;
            label5.Text = "GET STARTED";
            // 
            // panel2
            // 
            panel2.BackColor = Color.NavajoWhite;
            panel2.Controls.Add(lnkSigUp);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(btnLogin);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtPassword);
            panel2.Controls.Add(txtUsername);
            panel2.Font = new Font("Segoe UI Light", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel2.Location = new Point(265, -1);
            panel2.Name = "panel2";
            panel2.Size = new Size(624, 503);
            panel2.TabIndex = 1;
            // 
            // lnkSigUp
            // 
            lnkSigUp.AutoSize = true;
            lnkSigUp.Location = new Point(352, 403);
            lnkSigUp.Name = "lnkSigUp";
            lnkSigUp.Size = new Size(50, 17);
            lnkSigUp.TabIndex = 7;
            lnkSigUp.TabStop = true;
            lnkSigUp.Text = "Sign Up";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Light", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(219, 403);
            label4.Name = "label4";
            label4.Size = new Size(140, 17);
            label4.TabIndex = 6;
            label4.Text = "Don't have an account? \r\n";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.OrangeRed;
            btnLogin.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(202, 331);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(216, 52);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(78, 224);
            label3.Name = "label3";
            label3.Size = new Size(80, 23);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(78, 145);
            label2.Name = "label2";
            label2.Size = new Size(87, 23);
            label2.TabIndex = 3;
            label2.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(247, 74);
            label1.Name = "label1";
            label1.Size = new Size(124, 46);
            label1.TabIndex = 2;
            label1.Text = "LOGIN";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(78, 250);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(456, 25);
            txtPassword.TabIndex = 1;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(78, 171);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(456, 25);
            txtUsername.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(887, 503);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        private Form1 NewMethod()
        {
            return this;
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label label4;
        private Button btnLogin;
        private Label label5;
        private LinkLabel linkLabel1;
        private PictureBox pictureBoxLogo;
        private Label label6;
        private LinkLabel lnkSigUp;
    }
}
