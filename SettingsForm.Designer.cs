using System.Windows.Forms;
using System.Drawing;

namespace EMS
{
    partial class SettingsForm
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
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.txtLeavesPerYear = new System.Windows.Forms.TextBox();
            this.txtCycleDateRange = new System.Windows.Forms.TextBox();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblLeavesPerYear = new System.Windows.Forms.Label();
            this.lblCycleDateRange = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbSystemSettings = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbCompanyInfo = new System.Windows.Forms.GroupBox();
            this.txtCompanyEmail = new System.Windows.Forms.TextBox();
            this.lblCompanyEmail = new System.Windows.Forms.Label();
            this.txtCompanyPhone = new System.Windows.Forms.TextBox();
            this.lblCompanyPhone = new System.Windows.Forms.Label();
            this.txtCompanyAddress = new System.Windows.Forms.TextBox();
            this.lblCompanyAddress = new System.Windows.Forms.Label();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.gbPayrollSettings = new System.Windows.Forms.GroupBox();
            this.gbSystemSettings.SuspendLayout();
            this.gbCompanyInfo.SuspendLayout();
            this.gbPayrollSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpStartDate.Location = new System.Drawing.Point(137, 43);
            this.dtpStartDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(251, 30);
            this.dtpStartDate.TabIndex = 1;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpEndDate.Location = new System.Drawing.Point(137, 96);
            this.dtpEndDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(251, 30);
            this.dtpEndDate.TabIndex = 3;
            // 
            // txtLeavesPerYear
            // 
            this.txtLeavesPerYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLeavesPerYear.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLeavesPerYear.Location = new System.Drawing.Point(571, 43);
            this.txtLeavesPerYear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLeavesPerYear.Name = "txtLeavesPerYear";
            this.txtLeavesPerYear.Size = new System.Drawing.Size(205, 30);
            this.txtLeavesPerYear.TabIndex = 5;
            // 
            // txtCycleDateRange
            // 
            this.txtCycleDateRange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCycleDateRange.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCycleDateRange.Location = new System.Drawing.Point(571, 96);
            this.txtCycleDateRange.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCycleDateRange.Name = "txtCycleDateRange";
            this.txtCycleDateRange.Size = new System.Drawing.Size(205, 30);
            this.txtCycleDateRange.TabIndex = 7;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStartDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblStartDate.Location = new System.Drawing.Point(23, 47);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(98, 23);
            this.lblStartDate.TabIndex = 0;
            this.lblStartDate.Text = "Start Date:";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEndDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblEndDate.Location = new System.Drawing.Point(23, 100);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(88, 23);
            this.lblEndDate.TabIndex = 2;
            this.lblEndDate.Text = "End Date:";
            // 
            // lblLeavesPerYear
            // 
            this.lblLeavesPerYear.AutoSize = true;
            this.lblLeavesPerYear.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLeavesPerYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblLeavesPerYear.Location = new System.Drawing.Point(423, 47);
            this.lblLeavesPerYear.Name = "lblLeavesPerYear";
            this.lblLeavesPerYear.Size = new System.Drawing.Size(136, 23);
            this.lblLeavesPerYear.TabIndex = 4;
            this.lblLeavesPerYear.Text = "Leaves Per Year:";
            // 
            // lblCycleDateRange
            // 
            this.lblCycleDateRange.AutoSize = true;
            this.lblCycleDateRange.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCycleDateRange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblCycleDateRange.Location = new System.Drawing.Point(423, 100);
            this.lblCycleDateRange.Name = "lblCycleDateRange";
            this.lblCycleDateRange.Size = new System.Drawing.Size(155, 23);
            this.lblCycleDateRange.TabIndex = 6;
            this.lblCycleDateRange.Text = "Cycle Date Range:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(23, 53);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(274, 47);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Update System Settings";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(23, 560);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(114, 47);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "← Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(98)))));
            this.lblTitle.Location = new System.Drawing.Point(23, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(221, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "System Settings";
            // 
            // gbSystemSettings
            // 
            this.gbSystemSettings.BackColor = System.Drawing.Color.White;
            this.gbSystemSettings.Controls.Add(this.btnReset);
            this.gbSystemSettings.Controls.Add(this.btnSave);
            this.gbSystemSettings.Controls.Add(this.btnUpdate);
            this.gbSystemSettings.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbSystemSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(98)))));
            this.gbSystemSettings.Location = new System.Drawing.Point(526, 80);
            this.gbSystemSettings.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbSystemSettings.Name = "gbSystemSettings";
            this.gbSystemSettings.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbSystemSettings.Size = new System.Drawing.Size(320, 267);
            this.gbSystemSettings.TabIndex = 3;
            this.gbSystemSettings.TabStop = false;
            this.gbSystemSettings.Text = "⚙️ System Actions";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(23, 187);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(274, 47);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset to Default";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(23, 120);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(274, 47);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save All Settings";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gbCompanyInfo
            // 
            this.gbCompanyInfo.BackColor = System.Drawing.Color.White;
            this.gbCompanyInfo.Controls.Add(this.txtCompanyEmail);
            this.gbCompanyInfo.Controls.Add(this.lblCompanyEmail);
            this.gbCompanyInfo.Controls.Add(this.txtCompanyPhone);
            this.gbCompanyInfo.Controls.Add(this.lblCompanyPhone);
            this.gbCompanyInfo.Controls.Add(this.txtCompanyAddress);
            this.gbCompanyInfo.Controls.Add(this.lblCompanyAddress);
            this.gbCompanyInfo.Controls.Add(this.txtCompanyName);
            this.gbCompanyInfo.Controls.Add(this.lblCompanyName);
            this.gbCompanyInfo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbCompanyInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(98)))));
            this.gbCompanyInfo.Location = new System.Drawing.Point(23, 80);
            this.gbCompanyInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbCompanyInfo.Name = "gbCompanyInfo";
            this.gbCompanyInfo.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbCompanyInfo.Size = new System.Drawing.Size(480, 267);
            this.gbCompanyInfo.TabIndex = 1;
            this.gbCompanyInfo.TabStop = false;
            this.gbCompanyInfo.Text = "🏢 Company Information";
            // 
            // txtCompanyEmail
            // 
            this.txtCompanyEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCompanyEmail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCompanyEmail.Location = new System.Drawing.Point(171, 216);
            this.txtCompanyEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCompanyEmail.Name = "txtCompanyEmail";
            this.txtCompanyEmail.Size = new System.Drawing.Size(285, 30);
            this.txtCompanyEmail.TabIndex = 7;
            // 
            // lblCompanyEmail
            // 
            this.lblCompanyEmail.AutoSize = true;
            this.lblCompanyEmail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCompanyEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblCompanyEmail.Location = new System.Drawing.Point(23, 220);
            this.lblCompanyEmail.Name = "lblCompanyEmail";
            this.lblCompanyEmail.Size = new System.Drawing.Size(59, 23);
            this.lblCompanyEmail.TabIndex = 6;
            this.lblCompanyEmail.Text = "Email:";
            // 
            // txtCompanyPhone
            // 
            this.txtCompanyPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCompanyPhone.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCompanyPhone.Location = new System.Drawing.Point(171, 169);
            this.txtCompanyPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCompanyPhone.Name = "txtCompanyPhone";
            this.txtCompanyPhone.Size = new System.Drawing.Size(285, 30);
            this.txtCompanyPhone.TabIndex = 5;
            // 
            // lblCompanyPhone
            // 
            this.lblCompanyPhone.AutoSize = true;
            this.lblCompanyPhone.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCompanyPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblCompanyPhone.Location = new System.Drawing.Point(23, 173);
            this.lblCompanyPhone.Name = "lblCompanyPhone";
            this.lblCompanyPhone.Size = new System.Drawing.Size(64, 23);
            this.lblCompanyPhone.TabIndex = 4;
            this.lblCompanyPhone.Text = "Phone:";
            // 
            // txtCompanyAddress
            // 
            this.txtCompanyAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCompanyAddress.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCompanyAddress.Location = new System.Drawing.Point(171, 89);
            this.txtCompanyAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCompanyAddress.Multiline = true;
            this.txtCompanyAddress.Name = "txtCompanyAddress";
            this.txtCompanyAddress.Size = new System.Drawing.Size(285, 66);
            this.txtCompanyAddress.TabIndex = 3;
            // 
            // lblCompanyAddress
            // 
            this.lblCompanyAddress.AutoSize = true;
            this.lblCompanyAddress.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCompanyAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblCompanyAddress.Location = new System.Drawing.Point(23, 93);
            this.lblCompanyAddress.Name = "lblCompanyAddress";
            this.lblCompanyAddress.Size = new System.Drawing.Size(79, 23);
            this.lblCompanyAddress.TabIndex = 2;
            this.lblCompanyAddress.Text = "Address:";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCompanyName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCompanyName.Location = new System.Drawing.Point(171, 43);
            this.txtCompanyName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(285, 30);
            this.txtCompanyName.TabIndex = 1;
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCompanyName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblCompanyName.Location = new System.Drawing.Point(23, 47);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(143, 23);
            this.lblCompanyName.TabIndex = 0;
            this.lblCompanyName.Text = "Company Name:";
            // 
            // gbPayrollSettings
            // 
            this.gbPayrollSettings.BackColor = System.Drawing.Color.White;
            this.gbPayrollSettings.Controls.Add(this.txtCycleDateRange);
            this.gbPayrollSettings.Controls.Add(this.lblCycleDateRange);
            this.gbPayrollSettings.Controls.Add(this.txtLeavesPerYear);
            this.gbPayrollSettings.Controls.Add(this.lblLeavesPerYear);
            this.gbPayrollSettings.Controls.Add(this.dtpEndDate);
            this.gbPayrollSettings.Controls.Add(this.lblEndDate);
            this.gbPayrollSettings.Controls.Add(this.dtpStartDate);
            this.gbPayrollSettings.Controls.Add(this.lblStartDate);
            this.gbPayrollSettings.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbPayrollSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(98)))));
            this.gbPayrollSettings.Location = new System.Drawing.Point(23, 373);
            this.gbPayrollSettings.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbPayrollSettings.Name = "gbPayrollSettings";
            this.gbPayrollSettings.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbPayrollSettings.Size = new System.Drawing.Size(823, 160);
            this.gbPayrollSettings.TabIndex = 2;
            this.gbPayrollSettings.TabStop = false;
            this.gbPayrollSettings.Text = "💰 Payroll Settings";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(869, 640);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.gbSystemSettings);
            this.Controls.Add(this.gbPayrollSettings);
            this.Controls.Add(this.gbCompanyInfo);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "System Settings - EMS";
            this.gbSystemSettings.ResumeLayout(false);
            this.gbCompanyInfo.ResumeLayout(false);
            this.gbCompanyInfo.PerformLayout();
            this.gbPayrollSettings.ResumeLayout(false);
            this.gbPayrollSettings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker dtpStartDate;
        private DateTimePicker dtpEndDate;
        private TextBox txtLeavesPerYear;
        private TextBox txtCycleDateRange;
        private Label lblStartDate;
        private Label lblEndDate;
        private Label lblLeavesPerYear;
        private Label lblCycleDateRange;
        private Button btnUpdate;
        private Button btnBack;
        private Label lblTitle;
        private GroupBox gbSystemSettings;
        private GroupBox gbCompanyInfo;
        private TextBox txtCompanyName;
        private Label lblCompanyName;
        private TextBox txtCompanyAddress;
        private Label lblCompanyAddress;
        private TextBox txtCompanyPhone;
        private Label lblCompanyPhone;
        private TextBox txtCompanyEmail;
        private Label lblCompanyEmail;
        private GroupBox gbPayrollSettings;
        private Button btnSave;
        private Button btnReset;
    }
}