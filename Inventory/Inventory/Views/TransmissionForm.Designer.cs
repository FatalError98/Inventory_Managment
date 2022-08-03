﻿namespace Inventory.Views
{
    partial class TransmissionForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.transmissionBtn = new System.Windows.Forms.Button();
            this.searchTxt = new System.Windows.Forms.TextBox();
            this.transmissionItemDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.transmissionUpdateTapControl = new System.Windows.Forms.TabControl();
            this.transmissionUpdatePage = new System.Windows.Forms.TabPage();
            this.buildingComboBox = new System.Windows.Forms.ComboBox();
            this.departmentComboBox = new System.Windows.Forms.ComboBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.dateLabel = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.saveBtn = new System.Windows.Forms.Button();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.quantityNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.categoryTxt = new System.Windows.Forms.TextBox();
            this.descriptionTxt = new System.Windows.Forms.TextBox();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.itemTxt = new System.Windows.Forms.TextBox();
            this.buildingLabel = new System.Windows.Forms.Label();
            this.itemLabel = new System.Windows.Forms.Label();
            this.departmentLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transmissionItemDataGridView)).BeginInit();
            this.transmissionUpdateTapControl.SuspendLayout();
            this.transmissionUpdatePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.deleteBtn);
            this.panel2.Controls.Add(this.updateBtn);
            this.panel2.Controls.Add(this.searchBtn);
            this.panel2.Controls.Add(this.transmissionBtn);
            this.panel2.Controls.Add(this.searchTxt);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(10, 176);
            this.panel2.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(979, 100);
            this.panel2.TabIndex = 7;
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.deleteBtn.FlatAppearance.BorderSize = 0;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.ForeColor = System.Drawing.Color.White;
            this.deleteBtn.Location = new System.Drawing.Point(9, 39);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(0);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(76, 32);
            this.deleteBtn.TabIndex = 5;
            this.deleteBtn.Text = "حذف";
            this.deleteBtn.UseVisualStyleBackColor = false;
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.updateBtn.FlatAppearance.BorderSize = 0;
            this.updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.ForeColor = System.Drawing.Color.White;
            this.updateBtn.Location = new System.Drawing.Point(98, 39);
            this.updateBtn.Margin = new System.Windows.Forms.Padding(0);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(89, 32);
            this.updateBtn.TabIndex = 4;
            this.updateBtn.Text = "تحديث";
            this.updateBtn.UseVisualStyleBackColor = false;
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.searchBtn.FlatAppearance.BorderSize = 0;
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.ForeColor = System.Drawing.Color.White;
            this.searchBtn.Location = new System.Drawing.Point(850, 39);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(0);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(117, 32);
            this.searchBtn.TabIndex = 1;
            this.searchBtn.Text = "بحث";
            this.searchBtn.UseVisualStyleBackColor = false;
            // 
            // transmissionBtn
            // 
            this.transmissionBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.transmissionBtn.FlatAppearance.BorderSize = 0;
            this.transmissionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transmissionBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transmissionBtn.ForeColor = System.Drawing.Color.White;
            this.transmissionBtn.Location = new System.Drawing.Point(200, 39);
            this.transmissionBtn.Margin = new System.Windows.Forms.Padding(0);
            this.transmissionBtn.Name = "transmissionBtn";
            this.transmissionBtn.Size = new System.Drawing.Size(89, 32);
            this.transmissionBtn.TabIndex = 3;
            this.transmissionBtn.Text = "تسليم";
            this.transmissionBtn.UseVisualStyleBackColor = false;
            // 
            // searchTxt
            // 
            this.searchTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(231)))));
            this.searchTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchTxt.Font = new System.Drawing.Font("Tajawal", 15F);
            this.searchTxt.Location = new System.Drawing.Point(302, 41);
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.Size = new System.Drawing.Size(535, 28);
            this.searchTxt.TabIndex = 2;
            this.searchTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // transmissionItemDataGridView
            // 
            this.transmissionItemDataGridView.AllowUserToAddRows = false;
            this.transmissionItemDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.transmissionItemDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.transmissionItemDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.transmissionItemDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.transmissionItemDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.transmissionItemDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.transmissionItemDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            dataGridViewCellStyle12.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.transmissionItemDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.transmissionItemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle13.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.transmissionItemDataGridView.DefaultCellStyle = dataGridViewCellStyle13;
            this.transmissionItemDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.transmissionItemDataGridView.EnableHeadersVisualStyles = false;
            this.transmissionItemDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(231)))));
            this.transmissionItemDataGridView.Location = new System.Drawing.Point(10, 279);
            this.transmissionItemDataGridView.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.transmissionItemDataGridView.Name = "transmissionItemDataGridView";
            this.transmissionItemDataGridView.ReadOnly = true;
            this.transmissionItemDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.transmissionItemDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            dataGridViewCellStyle14.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White;
            this.transmissionItemDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.transmissionItemDataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.transmissionItemDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.transmissionItemDataGridView.Size = new System.Drawing.Size(979, 421);
            this.transmissionItemDataGridView.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(10, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(979, 176);
            this.panel1.TabIndex = 6;
            // 
            // transmissionUpdateTapControl
            // 
            this.transmissionUpdateTapControl.Controls.Add(this.transmissionUpdatePage);
            this.transmissionUpdateTapControl.Dock = System.Windows.Forms.DockStyle.Right;
            this.transmissionUpdateTapControl.Location = new System.Drawing.Point(989, 0);
            this.transmissionUpdateTapControl.Margin = new System.Windows.Forms.Padding(0);
            this.transmissionUpdateTapControl.Name = "transmissionUpdateTapControl";
            this.transmissionUpdateTapControl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.transmissionUpdateTapControl.RightToLeftLayout = true;
            this.transmissionUpdateTapControl.SelectedIndex = 0;
            this.transmissionUpdateTapControl.Size = new System.Drawing.Size(302, 700);
            this.transmissionUpdateTapControl.TabIndex = 5;
            // 
            // transmissionUpdatePage
            // 
            this.transmissionUpdatePage.BackColor = System.Drawing.Color.White;
            this.transmissionUpdatePage.Controls.Add(this.buildingComboBox);
            this.transmissionUpdatePage.Controls.Add(this.departmentComboBox);
            this.transmissionUpdatePage.Controls.Add(this.cancelBtn);
            this.transmissionUpdatePage.Controls.Add(this.dateLabel);
            this.transmissionUpdatePage.Controls.Add(this.dateTimePicker);
            this.transmissionUpdatePage.Controls.Add(this.saveBtn);
            this.transmissionUpdatePage.Controls.Add(this.descriptionLabel);
            this.transmissionUpdatePage.Controls.Add(this.quantityNumUpDown);
            this.transmissionUpdatePage.Controls.Add(this.categoryTxt);
            this.transmissionUpdatePage.Controls.Add(this.descriptionTxt);
            this.transmissionUpdatePage.Controls.Add(this.quantityLabel);
            this.transmissionUpdatePage.Controls.Add(this.itemTxt);
            this.transmissionUpdatePage.Controls.Add(this.buildingLabel);
            this.transmissionUpdatePage.Controls.Add(this.itemLabel);
            this.transmissionUpdatePage.Controls.Add(this.departmentLabel);
            this.transmissionUpdatePage.Controls.Add(this.titleLabel);
            this.transmissionUpdatePage.Controls.Add(this.categoryLabel);
            this.transmissionUpdatePage.Location = new System.Drawing.Point(4, 22);
            this.transmissionUpdatePage.Margin = new System.Windows.Forms.Padding(0);
            this.transmissionUpdatePage.Name = "transmissionUpdatePage";
            this.transmissionUpdatePage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.transmissionUpdatePage.Size = new System.Drawing.Size(294, 674);
            this.transmissionUpdatePage.TabIndex = 0;
            this.transmissionUpdatePage.Click += new System.EventHandler(this.transmissionUpdatePage_Click);
            // 
            // buildingComboBox
            // 
            this.buildingComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(231)))));
            this.buildingComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buildingComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buildingComboBox.FormattingEnabled = true;
            this.buildingComboBox.Items.AddRange(new object[] {
            "المنصور",
            "القاهرة"});
            this.buildingComboBox.Location = new System.Drawing.Point(26, 249);
            this.buildingComboBox.Name = "buildingComboBox";
            this.buildingComboBox.Size = new System.Drawing.Size(157, 28);
            this.buildingComboBox.TabIndex = 4;
            // 
            // departmentComboBox
            // 
            this.departmentComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(231)))));
            this.departmentComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.departmentComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departmentComboBox.FormattingEnabled = true;
            this.departmentComboBox.Items.AddRange(new object[] {
            "قسم طب الاسنان",
            "قسم المختبرات الطبية",
            "قسم هندسة تقنيات الحاسوب",
            "قسم هندسة تقنيات التبريد والتكييف",
            "قسم تقنيات الاشعة و السونار",
            "قسم تقنيات التخدير و العناية المركزة",
            "قسم القانون",
            "قسم ادارة الاعمال",
            "االحسابات",
            "التسجيل",
            "الادارية",
            "القانونية",
            "الجودة",
            "المتابعة",
            "العمادة",
            "معاون العميد العلمي",
            "معاون العميد الاداري",
            "المخزن",
            "مركز التعليم الالكتروني",
            "المكتبة",
            "الاعلام",
            "الاستعلامات"});
            this.departmentComboBox.Location = new System.Drawing.Point(26, 316);
            this.departmentComboBox.Name = "departmentComboBox";
            this.departmentComboBox.Size = new System.Drawing.Size(251, 32);
            this.departmentComboBox.TabIndex = 5;
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.Transparent;
            this.cancelBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.cancelBtn.FlatAppearance.BorderSize = 2;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.cancelBtn.Location = new System.Drawing.Point(28, 581);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(0);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(119, 31);
            this.cancelBtn.TabIndex = 9;
            this.cancelBtn.Text = "الغاء";
            this.cancelBtn.UseVisualStyleBackColor = false;
            // 
            // dateLabel
            // 
            this.dateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateLabel.BackColor = System.Drawing.Color.Transparent;
            this.dateLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.dateLabel.Location = new System.Drawing.Point(167, 357);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateLabel.Size = new System.Drawing.Size(107, 24);
            this.dateLabel.TabIndex = 0;
            this.dateLabel.Text = "التاريخ";
            this.dateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Location = new System.Drawing.Point(25, 388);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateTimePicker.Size = new System.Drawing.Size(249, 20);
            this.dateTimePicker.TabIndex = 6;
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(160, 581);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(0);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(117, 31);
            this.saveBtn.TabIndex = 8;
            this.saveBtn.Text = "حفظ";
            this.saveBtn.UseVisualStyleBackColor = false;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionLabel.BackColor = System.Drawing.Color.Transparent;
            this.descriptionLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.descriptionLabel.Location = new System.Drawing.Point(169, 415);
            this.descriptionLabel.Margin = new System.Windows.Forms.Padding(0);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.descriptionLabel.Size = new System.Drawing.Size(107, 24);
            this.descriptionLabel.TabIndex = 0;
            this.descriptionLabel.Text = "الملاحظات";
            this.descriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // quantityNumUpDown
            // 
            this.quantityNumUpDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(231)))));
            this.quantityNumUpDown.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.quantityNumUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityNumUpDown.Location = new System.Drawing.Point(193, 251);
            this.quantityNumUpDown.Margin = new System.Windows.Forms.Padding(0);
            this.quantityNumUpDown.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.quantityNumUpDown.Name = "quantityNumUpDown";
            this.quantityNumUpDown.Size = new System.Drawing.Size(83, 23);
            this.quantityNumUpDown.TabIndex = 3;
            this.quantityNumUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // categoryTxt
            // 
            this.categoryTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(231)))));
            this.categoryTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.categoryTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryTxt.Location = new System.Drawing.Point(25, 185);
            this.categoryTxt.Name = "categoryTxt";
            this.categoryTxt.Size = new System.Drawing.Size(250, 22);
            this.categoryTxt.TabIndex = 2;
            this.categoryTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // descriptionTxt
            // 
            this.descriptionTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(231)))));
            this.descriptionTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descriptionTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionTxt.Location = new System.Drawing.Point(27, 446);
            this.descriptionTxt.Multiline = true;
            this.descriptionTxt.Name = "descriptionTxt";
            this.descriptionTxt.Size = new System.Drawing.Size(250, 95);
            this.descriptionTxt.TabIndex = 7;
            this.descriptionTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // quantityLabel
            // 
            this.quantityLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.quantityLabel.BackColor = System.Drawing.Color.Transparent;
            this.quantityLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.quantityLabel.Location = new System.Drawing.Point(202, 219);
            this.quantityLabel.Margin = new System.Windows.Forms.Padding(0);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.quantityLabel.Size = new System.Drawing.Size(73, 25);
            this.quantityLabel.TabIndex = 0;
            this.quantityLabel.Text = "الكمية";
            this.quantityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // itemTxt
            // 
            this.itemTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(231)))));
            this.itemTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.itemTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemTxt.Location = new System.Drawing.Point(24, 120);
            this.itemTxt.Name = "itemTxt";
            this.itemTxt.Size = new System.Drawing.Size(250, 22);
            this.itemTxt.TabIndex = 1;
            this.itemTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buildingLabel
            // 
            this.buildingLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buildingLabel.BackColor = System.Drawing.Color.Transparent;
            this.buildingLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buildingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buildingLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.buildingLabel.Location = new System.Drawing.Point(116, 219);
            this.buildingLabel.Margin = new System.Windows.Forms.Padding(0);
            this.buildingLabel.Name = "buildingLabel";
            this.buildingLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buildingLabel.Size = new System.Drawing.Size(64, 24);
            this.buildingLabel.TabIndex = 0;
            this.buildingLabel.Text = "البناية";
            this.buildingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // itemLabel
            // 
            this.itemLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.itemLabel.BackColor = System.Drawing.Color.Transparent;
            this.itemLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.itemLabel.Location = new System.Drawing.Point(215, 89);
            this.itemLabel.Margin = new System.Windows.Forms.Padding(0);
            this.itemLabel.Name = "itemLabel";
            this.itemLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.itemLabel.Size = new System.Drawing.Size(56, 24);
            this.itemLabel.TabIndex = 0;
            this.itemLabel.Text = "المادة";
            this.itemLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // departmentLabel
            // 
            this.departmentLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.departmentLabel.BackColor = System.Drawing.Color.Transparent;
            this.departmentLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.departmentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departmentLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.departmentLabel.Location = new System.Drawing.Point(210, 285);
            this.departmentLabel.Margin = new System.Windows.Forms.Padding(0);
            this.departmentLabel.Name = "departmentLabel";
            this.departmentLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.departmentLabel.Size = new System.Drawing.Size(64, 24);
            this.departmentLabel.TabIndex = 0;
            this.departmentLabel.Text = "القسم";
            this.departmentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.titleLabel.Location = new System.Drawing.Point(49, 17);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.titleLabel.Size = new System.Drawing.Size(198, 39);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "تسليم مادة جديدة";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // categoryLabel
            // 
            this.categoryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.categoryLabel.BackColor = System.Drawing.Color.Transparent;
            this.categoryLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.categoryLabel.Location = new System.Drawing.Point(211, 154);
            this.categoryLabel.Margin = new System.Windows.Forms.Padding(0);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.categoryLabel.Size = new System.Drawing.Size(64, 24);
            this.categoryLabel.TabIndex = 0;
            this.categoryLabel.Text = "الفئة";
            this.categoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 700);
            this.panel3.TabIndex = 12;
            // 
            // TransmissionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1291, 700);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.transmissionItemDataGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.transmissionUpdateTapControl);
            this.Controls.Add(this.panel3);
            this.Name = "TransmissionForm";
            this.Text = "الاخراج";
            this.Load += new System.EventHandler(this.TransmissionForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transmissionItemDataGridView)).EndInit();
            this.transmissionUpdateTapControl.ResumeLayout(false);
            this.transmissionUpdatePage.ResumeLayout(false);
            this.transmissionUpdatePage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button transmissionBtn;
        private System.Windows.Forms.TextBox searchTxt;
        private System.Windows.Forms.DataGridView transmissionItemDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl transmissionUpdateTapControl;
        private System.Windows.Forms.TabPage transmissionUpdatePage;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.NumericUpDown quantityNumUpDown;
        private System.Windows.Forms.TextBox categoryTxt;
        private System.Windows.Forms.TextBox descriptionTxt;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.TextBox itemTxt;
        private System.Windows.Forms.Label itemLabel;
        private System.Windows.Forms.Label departmentLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox buildingComboBox;
        private System.Windows.Forms.ComboBox departmentComboBox;
        private System.Windows.Forms.Label buildingLabel;
    }
}