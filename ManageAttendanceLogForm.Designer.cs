﻿
namespace NTCSAttendanceStaffClient
{
    partial class ManageAttendanceLogForm
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
            this.AttendanceDataGridView = new System.Windows.Forms.DataGridView();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.NewAttendanceRecordButton = new System.Windows.Forms.Button();
            this.DeleteSelectedButton = new System.Windows.Forms.Button();
            this.ClearSearchButton = new System.Windows.Forms.Button();
            this.SearchActiveLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.MaxResultsCounter = new System.Windows.Forms.NumericUpDown();
            this.MaxResultsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AttendanceDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxResultsCounter)).BeginInit();
            this.SuspendLayout();
            // 
            // AttendanceDataGridView
            // 
            this.AttendanceDataGridView.AllowUserToAddRows = false;
            this.AttendanceDataGridView.AllowUserToDeleteRows = false;
            this.AttendanceDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AttendanceDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.AttendanceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AttendanceDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.AttendanceDataGridView.Location = new System.Drawing.Point(12, 128);
            this.AttendanceDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AttendanceDataGridView.Name = "AttendanceDataGridView";
            this.AttendanceDataGridView.RowHeadersWidth = 51;
            this.AttendanceDataGridView.RowTemplate.Height = 24;
            this.AttendanceDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AttendanceDataGridView.Size = new System.Drawing.Size(979, 581);
            this.AttendanceDataGridView.TabIndex = 11;
            this.AttendanceDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AttendanceDataGridView_CellDoubleClick);
            this.AttendanceDataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AttendanceDataGridView_KeyDown);
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(15, 86);
            this.RefreshButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(108, 30);
            this.RefreshButton.TabIndex = 7;
            this.RefreshButton.Text = "Refresh [F5]";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Location = new System.Drawing.Point(768, 14);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(223, 30);
            this.CloseButton.TabIndex = 10;
            this.CloseButton.Text = "Close and Return to Main Menu";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBox.Location = new System.Drawing.Point(15, 52);
            this.SearchBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(185, 27);
            this.SearchBox.TabIndex = 1;
            this.SearchBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchBox_KeyDown);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(207, 52);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 30);
            this.SearchButton.TabIndex = 2;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // NewAttendanceRecordButton
            // 
            this.NewAttendanceRecordButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NewAttendanceRecordButton.Location = new System.Drawing.Point(579, 86);
            this.NewAttendanceRecordButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NewAttendanceRecordButton.Name = "NewAttendanceRecordButton";
            this.NewAttendanceRecordButton.Size = new System.Drawing.Size(187, 30);
            this.NewAttendanceRecordButton.TabIndex = 8;
            this.NewAttendanceRecordButton.Text = "New Record... [Ctrl+N]";
            this.NewAttendanceRecordButton.UseVisualStyleBackColor = true;
            this.NewAttendanceRecordButton.Click += new System.EventHandler(this.NewStudentButton_Click);
            // 
            // DeleteSelectedButton
            // 
            this.DeleteSelectedButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteSelectedButton.Location = new System.Drawing.Point(768, 86);
            this.DeleteSelectedButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeleteSelectedButton.Name = "DeleteSelectedButton";
            this.DeleteSelectedButton.Size = new System.Drawing.Size(223, 30);
            this.DeleteSelectedButton.TabIndex = 9;
            this.DeleteSelectedButton.Text = "Delete Selected Records [Del]";
            this.DeleteSelectedButton.UseVisualStyleBackColor = true;
            this.DeleteSelectedButton.Click += new System.EventHandler(this.DeleteSelectedButton_Click);
            // 
            // ClearSearchButton
            // 
            this.ClearSearchButton.Location = new System.Drawing.Point(287, 52);
            this.ClearSearchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ClearSearchButton.Name = "ClearSearchButton";
            this.ClearSearchButton.Size = new System.Drawing.Size(107, 30);
            this.ClearSearchButton.TabIndex = 3;
            this.ClearSearchButton.Text = "Clear Search";
            this.ClearSearchButton.UseVisualStyleBackColor = true;
            this.ClearSearchButton.Click += new System.EventHandler(this.ClearSearchButton_Click);
            // 
            // SearchActiveLabel
            // 
            this.SearchActiveLabel.AutoSize = true;
            this.SearchActiveLabel.Location = new System.Drawing.Point(399, 59);
            this.SearchActiveLabel.Name = "SearchActiveLabel";
            this.SearchActiveLabel.Size = new System.Drawing.Size(95, 17);
            this.SearchActiveLabel.TabIndex = 4;
            this.SearchActiveLabel.Text = "Search Active";
            this.SearchActiveLabel.Visible = false;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(15, 11);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(294, 29);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Manage Attendance Log";
            // 
            // MaxResultsCounter
            // 
            this.MaxResultsCounter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaxResultsCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxResultsCounter.Location = new System.Drawing.Point(871, 52);
            this.MaxResultsCounter.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.MaxResultsCounter.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MaxResultsCounter.Name = "MaxResultsCounter";
            this.MaxResultsCounter.Size = new System.Drawing.Size(120, 27);
            this.MaxResultsCounter.TabIndex = 5;
            this.MaxResultsCounter.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.MaxResultsCounter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MaxResultsCounter_KeyDown);
            // 
            // MaxResultsLabel
            // 
            this.MaxResultsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaxResultsLabel.AutoSize = true;
            this.MaxResultsLabel.Location = new System.Drawing.Point(723, 57);
            this.MaxResultsLabel.Name = "MaxResultsLabel";
            this.MaxResultsLabel.Size = new System.Drawing.Size(142, 17);
            this.MaxResultsLabel.TabIndex = 6;
            this.MaxResultsLabel.Text = "Max. Results to Show";
            // 
            // ManageAttendanceLogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 721);
            this.Controls.Add(this.MaxResultsLabel);
            this.Controls.Add(this.MaxResultsCounter);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.SearchActiveLabel);
            this.Controls.Add(this.ClearSearchButton);
            this.Controls.Add(this.DeleteSelectedButton);
            this.Controls.Add(this.NewAttendanceRecordButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.AttendanceDataGridView);
            this.Icon = global::NTCSAttendanceStaffClient.Properties.Resources.NTCSIcon;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ManageAttendanceLogForm";
            this.Text = "Manage Attendance Log";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManageAttendanceLogForm_FormClosing);
            this.Load += new System.EventHandler(this.ManageAttendanceLogForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ManageAttendanceLogForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.AttendanceDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxResultsCounter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView AttendanceDataGridView;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button NewAttendanceRecordButton;
        private System.Windows.Forms.Button DeleteSelectedButton;
        private System.Windows.Forms.Button ClearSearchButton;
        private System.Windows.Forms.Label SearchActiveLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.NumericUpDown MaxResultsCounter;
        private System.Windows.Forms.Label MaxResultsLabel;
    }
}