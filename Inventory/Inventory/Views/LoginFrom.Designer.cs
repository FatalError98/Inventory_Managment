namespace Inventory.Views
{
    partial class LoginFrom
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.userNameTxt = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.SignInBtn = new System.Windows.Forms.Button();
            this.programmerLabel = new System.Windows.Forms.Label();
            this.versionLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.minimizedBtn = new System.Windows.Forms.Button();
            this.maximizedBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.minimizedBtn);
            this.panel1.Controls.Add(this.maximizedBtn);
            this.panel1.Controls.Add(this.exitBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(342, 31);
            this.panel1.TabIndex = 0;
            // 
            // userNameLabel
            // 
            this.userNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.userNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.userNameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userNameLabel.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.userNameLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.userNameLabel.Location = new System.Drawing.Point(183, 335);
            this.userNameLabel.Margin = new System.Windows.Forms.Padding(0);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(124, 31);
            this.userNameLabel.TabIndex = 2;
            this.userNameLabel.Text = "اسم المستخدم";
            this.userNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // userNameTxt
            // 
            this.userNameTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userNameTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(231)))));
            this.userNameTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userNameTxt.Font = new System.Drawing.Font("Tajawal", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameTxt.Location = new System.Drawing.Point(36, 371);
            this.userNameTxt.Margin = new System.Windows.Forms.Padding(0);
            this.userNameTxt.Name = "userNameTxt";
            this.userNameTxt.Size = new System.Drawing.Size(271, 30);
            this.userNameTxt.TabIndex = 3;
            this.userNameTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // passwordLabel
            // 
            this.passwordLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordLabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.passwordLabel.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.passwordLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.passwordLabel.Location = new System.Drawing.Point(183, 406);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(124, 31);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.Text = "كلمة المرور";
            this.passwordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // passwordTxt
            // 
            this.passwordTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(231)))));
            this.passwordTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTxt.Font = new System.Drawing.Font("Tajawal", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTxt.Location = new System.Drawing.Point(36, 442);
            this.passwordTxt.Margin = new System.Windows.Forms.Padding(0);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.PasswordChar = '*';
            this.passwordTxt.Size = new System.Drawing.Size(271, 30);
            this.passwordTxt.TabIndex = 3;
            this.passwordTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // SignInBtn
            // 
            this.SignInBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SignInBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.SignInBtn.FlatAppearance.BorderSize = 0;
            this.SignInBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignInBtn.ForeColor = System.Drawing.Color.White;
            this.SignInBtn.Location = new System.Drawing.Point(105, 515);
            this.SignInBtn.Name = "SignInBtn";
            this.SignInBtn.Size = new System.Drawing.Size(132, 42);
            this.SignInBtn.TabIndex = 4;
            this.SignInBtn.Text = "تسجيل دخول";
            this.SignInBtn.UseVisualStyleBackColor = false;
            // 
            // programmerLabel
            // 
            this.programmerLabel.BackColor = System.Drawing.Color.Transparent;
            this.programmerLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.programmerLabel.Font = new System.Drawing.Font("Tajawal", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.programmerLabel.ForeColor = System.Drawing.Color.Gray;
            this.programmerLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.programmerLabel.Location = new System.Drawing.Point(18, 590);
            this.programmerLabel.Margin = new System.Windows.Forms.Padding(0);
            this.programmerLabel.Name = "programmerLabel";
            this.programmerLabel.Size = new System.Drawing.Size(94, 18);
            this.programmerLabel.TabIndex = 2;
            this.programmerLabel.Text = "By Ammar Talal";
            this.programmerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // versionLabel
            // 
            this.versionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.versionLabel.AutoSize = true;
            this.versionLabel.BackColor = System.Drawing.Color.Transparent;
            this.versionLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.versionLabel.Font = new System.Drawing.Font("Tajawal", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versionLabel.ForeColor = System.Drawing.Color.Gray;
            this.versionLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.versionLabel.Location = new System.Drawing.Point(251, 590);
            this.versionLabel.Margin = new System.Windows.Forms.Padding(0);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(70, 18);
            this.versionLabel.TabIndex = 2;
            this.versionLabel.Text = "Version: 2.0";
            this.versionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::Inventory.Properties.Resources.Sign_in_amico;
            this.pictureBox1.Location = new System.Drawing.Point(0, 31);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(342, 276);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // minimizedBtn
            // 
            this.minimizedBtn.BackColor = System.Drawing.Color.Transparent;
            this.minimizedBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.minimizedBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizedBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.minimizedBtn.FlatAppearance.BorderSize = 0;
            this.minimizedBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizedBtn.Image = global::Inventory.Properties.Resources.Min;
            this.minimizedBtn.Location = new System.Drawing.Point(267, 0);
            this.minimizedBtn.Margin = new System.Windows.Forms.Padding(0);
            this.minimizedBtn.Name = "minimizedBtn";
            this.minimizedBtn.Size = new System.Drawing.Size(25, 31);
            this.minimizedBtn.TabIndex = 0;
            this.minimizedBtn.UseVisualStyleBackColor = false;
            // 
            // maximizedBtn
            // 
            this.maximizedBtn.BackColor = System.Drawing.Color.Transparent;
            this.maximizedBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.maximizedBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.maximizedBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.maximizedBtn.FlatAppearance.BorderSize = 0;
            this.maximizedBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maximizedBtn.Image = global::Inventory.Properties.Resources.max;
            this.maximizedBtn.Location = new System.Drawing.Point(292, 0);
            this.maximizedBtn.Margin = new System.Windows.Forms.Padding(0);
            this.maximizedBtn.Name = "maximizedBtn";
            this.maximizedBtn.Size = new System.Drawing.Size(25, 31);
            this.maximizedBtn.TabIndex = 0;
            this.maximizedBtn.UseVisualStyleBackColor = false;
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.Transparent;
            this.exitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.exitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.exitBtn.FlatAppearance.BorderSize = 0;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Image = global::Inventory.Properties.Resources.exit;
            this.exitBtn.Location = new System.Drawing.Point(317, 0);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(0);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(25, 31);
            this.exitBtn.TabIndex = 0;
            this.exitBtn.UseVisualStyleBackColor = false;
            // 
            // LoginFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(342, 617);
            this.Controls.Add(this.SignInBtn);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.programmerLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.userNameTxt);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LoginFrom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginFrom";
            this.Load += new System.EventHandler(this.LoginFrom_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button minimizedBtn;
        private System.Windows.Forms.Button maximizedBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.TextBox userNameTxt;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.Button SignInBtn;
        private System.Windows.Forms.Label programmerLabel;
        private System.Windows.Forms.Label versionLabel;
    }
}