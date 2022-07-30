namespace Inventory
{
    partial class DashboardForm
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.MainMenuPanel = new System.Windows.Forms.Panel();
            this.addItemBtn = new System.Windows.Forms.Button();
            this.transferItemBtn = new System.Windows.Forms.Button();
            this.inventoryBtn = new System.Windows.Forms.Button();
            this.usersBtn = new System.Windows.Forms.Button();
            this.settingsBtn = new System.Windows.Forms.Button();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.titlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Controls.Add(this.addItemBtn);
            this.flowLayoutPanel1.Controls.Add(this.transferItemBtn);
            this.flowLayoutPanel1.Controls.Add(this.MainMenuPanel);
            this.flowLayoutPanel1.Controls.Add(this.inventoryBtn);
            this.flowLayoutPanel1.Controls.Add(this.usersBtn);
            this.flowLayoutPanel1.Controls.Add(this.settingsBtn);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(894, 83);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(206, 509);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // MainMenuPanel
            // 
            this.MainMenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MainMenuPanel.Location = new System.Drawing.Point(3, 123);
            this.MainMenuPanel.Name = "MainMenuPanel";
            this.MainMenuPanel.Size = new System.Drawing.Size(200, 0);
            this.MainMenuPanel.TabIndex = 0;
            // 
            // addItemBtn
            // 
            this.addItemBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.addItemBtn.FlatAppearance.BorderSize = 0;
            this.addItemBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addItemBtn.Font = new System.Drawing.Font("Tajawal", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addItemBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.addItemBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addItemBtn.Location = new System.Drawing.Point(0, 0);
            this.addItemBtn.Margin = new System.Windows.Forms.Padding(0);
            this.addItemBtn.Name = "addItemBtn";
            this.addItemBtn.Padding = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.addItemBtn.Size = new System.Drawing.Size(220, 60);
            this.addItemBtn.TabIndex = 3;
            this.addItemBtn.Text = "الادخال";
            this.addItemBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addItemBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.addItemBtn.UseVisualStyleBackColor = true;
            this.addItemBtn.Click += new System.EventHandler(this.addItemBtn_Click);
            // 
            // transferItemBtn
            // 
            this.transferItemBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.transferItemBtn.FlatAppearance.BorderSize = 0;
            this.transferItemBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transferItemBtn.Font = new System.Drawing.Font("Tajawal", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transferItemBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.transferItemBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.transferItemBtn.Location = new System.Drawing.Point(0, 60);
            this.transferItemBtn.Margin = new System.Windows.Forms.Padding(0);
            this.transferItemBtn.Name = "transferItemBtn";
            this.transferItemBtn.Padding = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.transferItemBtn.Size = new System.Drawing.Size(220, 60);
            this.transferItemBtn.TabIndex = 4;
            this.transferItemBtn.Text = "الاخراج";
            this.transferItemBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.transferItemBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.transferItemBtn.UseVisualStyleBackColor = true;
            this.transferItemBtn.Click += new System.EventHandler(this.transferItemBtn_Click);
            // 
            // inventoryBtn
            // 
            this.inventoryBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.inventoryBtn.FlatAppearance.BorderSize = 0;
            this.inventoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inventoryBtn.Font = new System.Drawing.Font("Tajawal", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.inventoryBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.inventoryBtn.Location = new System.Drawing.Point(0, 126);
            this.inventoryBtn.Margin = new System.Windows.Forms.Padding(0);
            this.inventoryBtn.Name = "inventoryBtn";
            this.inventoryBtn.Padding = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.inventoryBtn.Size = new System.Drawing.Size(220, 60);
            this.inventoryBtn.TabIndex = 5;
            this.inventoryBtn.Text = "الجرد";
            this.inventoryBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.inventoryBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.inventoryBtn.UseVisualStyleBackColor = true;
            this.inventoryBtn.Click += new System.EventHandler(this.inventoryBtn_Click);
            // 
            // usersBtn
            // 
            this.usersBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.usersBtn.FlatAppearance.BorderSize = 0;
            this.usersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usersBtn.Font = new System.Drawing.Font("Tajawal", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.usersBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.usersBtn.Location = new System.Drawing.Point(0, 186);
            this.usersBtn.Margin = new System.Windows.Forms.Padding(0);
            this.usersBtn.Name = "usersBtn";
            this.usersBtn.Padding = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.usersBtn.Size = new System.Drawing.Size(220, 60);
            this.usersBtn.TabIndex = 6;
            this.usersBtn.Text = "المستخدمون";
            this.usersBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.usersBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.usersBtn.UseVisualStyleBackColor = true;
            this.usersBtn.Click += new System.EventHandler(this.usersBtn_Click);
            // 
            // settingsBtn
            // 
            this.settingsBtn.BackColor = System.Drawing.Color.Transparent;
            this.settingsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.settingsBtn.FlatAppearance.BorderSize = 0;
            this.settingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsBtn.Font = new System.Drawing.Font("Tajawal", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.settingsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.settingsBtn.Location = new System.Drawing.Point(0, 246);
            this.settingsBtn.Margin = new System.Windows.Forms.Padding(0);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Padding = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.settingsBtn.Size = new System.Drawing.Size(220, 60);
            this.settingsBtn.TabIndex = 0;
            this.settingsBtn.Text = "الاعدادات";
            this.settingsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.settingsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.settingsBtn.UseVisualStyleBackColor = false;
            this.settingsBtn.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // titlePanel
            // 
            this.titlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.titlePanel.Controls.Add(this.titleLabel);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePanel.Location = new System.Drawing.Point(0, 0);
            this.titlePanel.Margin = new System.Windows.Forms.Padding(0);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(1100, 83);
            this.titlePanel.TabIndex = 1;
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.titleLabel.Font = new System.Drawing.Font("Tajawal", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(105, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(659, 60);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1100, 592);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.titlePanel);
            this.ForeColor = System.Drawing.Color.White;
            this.IsMdiContainer = true;
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.DashboardFrom_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.titlePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel MainMenuPanel;
        private System.Windows.Forms.Button settingsBtn;
        private System.Windows.Forms.Button addItemBtn;
        private System.Windows.Forms.Button transferItemBtn;
        private System.Windows.Forms.Button inventoryBtn;
        private System.Windows.Forms.Button usersBtn;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Label titleLabel;
    }
}

