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
            this.addItemBtn = new System.Windows.Forms.Button();
            this.transferItemBtn = new System.Windows.Forms.Button();
            this.inventoryBtn = new System.Windows.Forms.Button();
            this.usersBtn = new System.Windows.Forms.Button();
            this.versionLabel = new System.Windows.Forms.Label();
            this.programmerLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.settingsBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addItemBtn
            // 
            this.addItemBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.addItemBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addItemBtn.FlatAppearance.BorderSize = 0;
            this.addItemBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addItemBtn.Font = new System.Drawing.Font("Tajawal", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addItemBtn.ForeColor = System.Drawing.Color.White;
            this.addItemBtn.Image = global::Inventory.Properties.Resources.baseline_add_box_white_36dp;
            this.addItemBtn.Location = new System.Drawing.Point(236, 10);
            this.addItemBtn.Margin = new System.Windows.Forms.Padding(10);
            this.addItemBtn.Name = "addItemBtn";
            this.addItemBtn.Size = new System.Drawing.Size(206, 157);
            this.addItemBtn.TabIndex = 3;
            this.addItemBtn.Text = "الادخال";
            this.addItemBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.addItemBtn.UseVisualStyleBackColor = false;
            this.addItemBtn.Click += new System.EventHandler(this.addItemBtn_Click);
            // 
            // transferItemBtn
            // 
            this.transferItemBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.transferItemBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.transferItemBtn.FlatAppearance.BorderSize = 0;
            this.transferItemBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transferItemBtn.Font = new System.Drawing.Font("Tajawal", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transferItemBtn.ForeColor = System.Drawing.Color.White;
            this.transferItemBtn.Image = global::Inventory.Properties.Resources.baseline_outbox_white_36dp;
            this.transferItemBtn.Location = new System.Drawing.Point(10, 10);
            this.transferItemBtn.Margin = new System.Windows.Forms.Padding(10);
            this.transferItemBtn.Name = "transferItemBtn";
            this.transferItemBtn.Size = new System.Drawing.Size(206, 157);
            this.transferItemBtn.TabIndex = 4;
            this.transferItemBtn.Text = "الاخراج";
            this.transferItemBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.transferItemBtn.UseVisualStyleBackColor = false;
            this.transferItemBtn.Click += new System.EventHandler(this.transferItemBtn_Click);
            // 
            // inventoryBtn
            // 
            this.inventoryBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.inventoryBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inventoryBtn.FlatAppearance.BorderSize = 0;
            this.inventoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inventoryBtn.Font = new System.Drawing.Font("Tajawal", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryBtn.ForeColor = System.Drawing.Color.White;
            this.inventoryBtn.Image = global::Inventory.Properties.Resources.baseline_list_alt_white_36dp;
            this.inventoryBtn.Location = new System.Drawing.Point(236, 187);
            this.inventoryBtn.Margin = new System.Windows.Forms.Padding(10);
            this.inventoryBtn.Name = "inventoryBtn";
            this.inventoryBtn.Size = new System.Drawing.Size(206, 157);
            this.inventoryBtn.TabIndex = 5;
            this.inventoryBtn.Text = "الجرد";
            this.inventoryBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.inventoryBtn.UseVisualStyleBackColor = false;
            this.inventoryBtn.Click += new System.EventHandler(this.inventoryBtn_Click);
            // 
            // usersBtn
            // 
            this.usersBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.usersBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usersBtn.FlatAppearance.BorderSize = 0;
            this.usersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usersBtn.Font = new System.Drawing.Font("Tajawal", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersBtn.ForeColor = System.Drawing.Color.White;
            this.usersBtn.Image = global::Inventory.Properties.Resources.baseline_manage_accounts_white_36dp1;
            this.usersBtn.Location = new System.Drawing.Point(10, 364);
            this.usersBtn.Margin = new System.Windows.Forms.Padding(10);
            this.usersBtn.Name = "usersBtn";
            this.usersBtn.Size = new System.Drawing.Size(206, 159);
            this.usersBtn.TabIndex = 6;
            this.usersBtn.Text = "المستخدمون";
            this.usersBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.usersBtn.UseVisualStyleBackColor = false;
            this.usersBtn.Click += new System.EventHandler(this.usersBtn_Click);
            // 
            // versionLabel
            // 
            this.versionLabel.BackColor = System.Drawing.Color.Transparent;
            this.versionLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.versionLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.versionLabel.Font = new System.Drawing.Font("Tajawal", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versionLabel.ForeColor = System.Drawing.Color.Gray;
            this.versionLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.versionLabel.Location = new System.Drawing.Point(778, 0);
            this.versionLabel.Margin = new System.Windows.Forms.Padding(0);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.versionLabel.Size = new System.Drawing.Size(113, 29);
            this.versionLabel.TabIndex = 7;
            this.versionLabel.Text = "Version: 2.0";
            this.versionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // programmerLabel
            // 
            this.programmerLabel.BackColor = System.Drawing.Color.Transparent;
            this.programmerLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.programmerLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.programmerLabel.Font = new System.Drawing.Font("Tajawal", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.programmerLabel.ForeColor = System.Drawing.Color.Gray;
            this.programmerLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.programmerLabel.Location = new System.Drawing.Point(0, 0);
            this.programmerLabel.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.programmerLabel.Name = "programmerLabel";
            this.programmerLabel.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.programmerLabel.Size = new System.Drawing.Size(134, 29);
            this.programmerLabel.TabIndex = 8;
            this.programmerLabel.Text = "By Ammar Talal";
            this.programmerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.versionLabel);
            this.panel1.Controls.Add(this.programmerLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 563);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(891, 29);
            this.panel1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::Inventory.Properties.Resources.Fitting_piece_amico;
            this.pictureBox1.Location = new System.Drawing.Point(0, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.pictureBox1.Size = new System.Drawing.Size(396, 533);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // settingsBtn
            // 
            this.settingsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.settingsBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsBtn.FlatAppearance.BorderSize = 0;
            this.settingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsBtn.Font = new System.Drawing.Font("Tajawal", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsBtn.ForeColor = System.Drawing.Color.White;
            this.settingsBtn.Image = global::Inventory.Properties.Resources.baseline_settings_white_36dp;
            this.settingsBtn.Location = new System.Drawing.Point(236, 364);
            this.settingsBtn.Margin = new System.Windows.Forms.Padding(10);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Size = new System.Drawing.Size(206, 159);
            this.settingsBtn.TabIndex = 0;
            this.settingsBtn.Text = "الاعدادات";
            this.settingsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.settingsBtn.UseVisualStyleBackColor = false;
            this.settingsBtn.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.inventoryBtn, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.addItemBtn, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.transferItemBtn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.usersBtn, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.settingsBtn, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(439, 30);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(452, 533);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Enabled = false;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tajawal", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(10, 187);
            this.button1.Margin = new System.Windows.Forms.Padding(10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 157);
            this.button1.TabIndex = 7;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(891, 30);
            this.panel2.TabIndex = 13;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(891, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(30, 592);
            this.panel4.TabIndex = 14;
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(921, 592);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الواجهة الرئيسية";
            this.Load += new System.EventHandler(this.DashboardFrom_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button settingsBtn;
        private System.Windows.Forms.Button addItemBtn;
        private System.Windows.Forms.Button transferItemBtn;
        private System.Windows.Forms.Button inventoryBtn;
        private System.Windows.Forms.Button usersBtn;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.Label programmerLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
    }
}

