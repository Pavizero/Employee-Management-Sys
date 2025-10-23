using System;
using System.Drawing;
using System.Windows.Forms;

namespace EMS
{
    partial class EmployeeForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbEmployeeDetails = new System.Windows.Forms.GroupBox();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.lblPosition = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.txtNIC = new System.Windows.Forms.TextBox();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtEmpID = new System.Windows.Forms.TextBox();
            this.txtEmployeeCode = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.chkIsActive = new System.Windows.Forms.CheckBox();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblNIC = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblEmpID = new System.Windows.Forms.Label();
            this.lblEmployeeCode = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.gbSalaryDetails = new System.Windows.Forms.GroupBox();
            this.btnEPF = new System.Windows.Forms.Button();
            this.txtEPFAmount = new System.Windows.Forms.TextBox();
            this.lblEPFAmount = new System.Windows.Forms.Label();
            this.txtGovTaxPercentage = new System.Windows.Forms.TextBox();
            this.txtAllowance = new System.Windows.Forms.TextBox();
            this.txtOTRateHourly = new System.Windows.Forms.TextBox();
            this.txtMonthlySalary = new System.Windows.Forms.TextBox();
            this.lblGovTaxPercentage = new System.Windows.Forms.Label();
            this.lblAllowance = new System.Windows.Forms.Label();
            this.lblOTRateHourly = new System.Windows.Forms.Label();
            this.lblMonthlySalary = new System.Windows.Forms.Label();
            this.pnlActionButtons = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lnkViewAllEmployees = new System.Windows.Forms.LinkLabel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbEmployeeDetails.SuspendLayout();
            this.gbSalaryDetails.SuspendLayout();
            this.pnlActionButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // gbEmployeeDetails
            // 
            this.gbEmployeeDetails.BackColor = System.Drawing.Color.White;
            this.gbEmployeeDetails.Controls.Add(this.txtPosition);
            this.gbEmployeeDetails.Controls.Add(this.lblPosition);
            this.gbEmployeeDetails.Controls.Add(this.txtContact);
            this.gbEmployeeDetails.Controls.Add(this.dtpDOB);
            this.gbEmployeeDetails.Controls.Add(this.txtNIC);
            this.gbEmployeeDetails.Controls.Add(this.rbFemale);
            this.gbEmployeeDetails.Controls.Add(this.rbMale);
            this.gbEmployeeDetails.Controls.Add(this.txtAddress);
            this.gbEmployeeDetails.Controls.Add(this.txtLastName);
            this.gbEmployeeDetails.Controls.Add(this.txtFirstName);
            this.gbEmployeeDetails.Controls.Add(this.txtEmpID);
            this.gbEmployeeDetails.Controls.Add(this.txtEmployeeCode);
            this.gbEmployeeDetails.Controls.Add(this.txtEmail);
            this.gbEmployeeDetails.Controls.Add(this.chkIsActive);
            this.gbEmployeeDetails.Controls.Add(this.lblContact);
            this.gbEmployeeDetails.Controls.Add(this.lblDOB);
            this.gbEmployeeDetails.Controls.Add(this.lblNIC);
            this.gbEmployeeDetails.Controls.Add(this.lblGender);
            this.gbEmployeeDetails.Controls.Add(this.lblAddress);
            this.gbEmployeeDetails.Controls.Add(this.lblLastName);
            this.gbEmployeeDetails.Controls.Add(this.lblFirstName);
            this.gbEmployeeDetails.Controls.Add(this.lblEmpID);
            this.gbEmployeeDetails.Controls.Add(this.lblEmployeeCode);
            this.gbEmployeeDetails.Controls.Add(this.lblEmail);
            this.gbEmployeeDetails.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbEmployeeDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(98)))));
            this.gbEmployeeDetails.Location = new System.Drawing.Point(23, 80);
            this.gbEmployeeDetails.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbEmployeeDetails.Name = "gbEmployeeDetails";
            this.gbEmployeeDetails.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbEmployeeDetails.Size = new System.Drawing.Size(514, 637);
            this.gbEmployeeDetails.TabIndex = 1;
            this.gbEmployeeDetails.TabStop = false;
            this.gbEmployeeDetails.Text = "Employee Information";
            // 
            // txtPosition
            // 
            this.txtPosition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPosition.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPosition.Location = new System.Drawing.Point(171, 276);
            this.txtPosition.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(320, 30);
            this.txtPosition.TabIndex = 11;
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPosition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblPosition.Location = new System.Drawing.Point(23, 280);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(78, 23);
            this.lblPosition.TabIndex = 10;
            this.lblPosition.Text = "Position:";
            // 
            // txtContact
            // 
            this.txtContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContact.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtContact.Location = new System.Drawing.Point(171, 416);
            this.txtContact.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(320, 30);
            this.txtContact.TabIndex = 18;
            // 
            // dtpDOB
            // 
            this.dtpDOB.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpDOB.Location = new System.Drawing.Point(171, 323);
            this.dtpDOB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(319, 30);
            this.dtpDOB.TabIndex = 13;
            // 
            // txtNIC
            // 
            this.txtNIC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNIC.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNIC.Location = new System.Drawing.Point(171, 463);
            this.txtNIC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNIC.Name = "txtNIC";
            this.txtNIC.Size = new System.Drawing.Size(320, 30);
            this.txtNIC.TabIndex = 20;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbFemale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.rbFemale.Location = new System.Drawing.Point(251, 371);
            this.rbFemale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(85, 27);
            this.rbFemale.TabIndex = 16;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbMale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.rbMale.Location = new System.Drawing.Point(171, 371);
            this.rbMale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(68, 27);
            this.rbMale.TabIndex = 15;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // txtAddress
            // 
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAddress.Location = new System.Drawing.Point(171, 509);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(320, 79);
            this.txtAddress.TabIndex = 22;
            // 
            // txtLastName
            // 
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLastName.Location = new System.Drawing.Point(171, 183);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(320, 30);
            this.txtLastName.TabIndex = 7;
            // 
            // txtFirstName
            // 
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFirstName.Location = new System.Drawing.Point(171, 136);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(320, 30);
            this.txtFirstName.TabIndex = 5;
            // 
            // txtEmpID
            // 
            this.txtEmpID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.txtEmpID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmpID.Location = new System.Drawing.Point(171, 43);
            this.txtEmpID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.Size = new System.Drawing.Size(228, 30);
            this.txtEmpID.TabIndex = 1;
            // 
            // txtEmployeeCode
            // 
            this.txtEmployeeCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmployeeCode.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmployeeCode.Location = new System.Drawing.Point(171, 89);
            this.txtEmployeeCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmployeeCode.Name = "txtEmployeeCode";
            this.txtEmployeeCode.Size = new System.Drawing.Size(320, 30);
            this.txtEmployeeCode.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.Location = new System.Drawing.Point(171, 229);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(320, 30);
            this.txtEmail.TabIndex = 9;
            // 
            // chkIsActive
            // 
            this.chkIsActive.AutoSize = true;
            this.chkIsActive.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chkIsActive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(98)))));
            this.chkIsActive.Location = new System.Drawing.Point(171, 597);
            this.chkIsActive.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(165, 27);
            this.chkIsActive.TabIndex = 23;
            this.chkIsActive.Text = "Active Employee";
            this.chkIsActive.UseVisualStyleBackColor = true;
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblContact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblContact.Location = new System.Drawing.Point(23, 420);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(77, 23);
            this.lblContact.TabIndex = 17;
            this.lblContact.Text = "Contact:";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDOB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblDOB.Location = new System.Drawing.Point(23, 327);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(120, 23);
            this.lblDOB.TabIndex = 12;
            this.lblDOB.Text = "Date of Birth:";
            // 
            // lblNIC
            // 
            this.lblNIC.AutoSize = true;
            this.lblNIC.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNIC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblNIC.Location = new System.Drawing.Point(23, 467);
            this.lblNIC.Name = "lblNIC";
            this.lblNIC.Size = new System.Drawing.Size(44, 23);
            this.lblNIC.TabIndex = 19;
            this.lblNIC.Text = "NIC:";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblGender.Location = new System.Drawing.Point(23, 373);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(74, 23);
            this.lblGender.TabIndex = 14;
            this.lblGender.Text = "Gender:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblAddress.Location = new System.Drawing.Point(23, 513);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(79, 23);
            this.lblAddress.TabIndex = 21;
            this.lblAddress.Text = "Address:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblLastName.Location = new System.Drawing.Point(23, 187);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(99, 23);
            this.lblLastName.TabIndex = 6;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblFirstName.Location = new System.Drawing.Point(23, 140);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(102, 23);
            this.lblFirstName.TabIndex = 4;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblEmpID
            // 
            this.lblEmpID.AutoSize = true;
            this.lblEmpID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEmpID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblEmpID.Location = new System.Drawing.Point(23, 47);
            this.lblEmpID.Name = "lblEmpID";
            this.lblEmpID.Size = new System.Drawing.Size(116, 23);
            this.lblEmpID.TabIndex = 0;
            this.lblEmpID.Text = "Employee ID:";
            // 
            // lblEmployeeCode
            // 
            this.lblEmployeeCode.AutoSize = true;
            this.lblEmployeeCode.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEmployeeCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblEmployeeCode.Location = new System.Drawing.Point(23, 93);
            this.lblEmployeeCode.Name = "lblEmployeeCode";
            this.lblEmployeeCode.Size = new System.Drawing.Size(139, 23);
            this.lblEmployeeCode.TabIndex = 2;
            this.lblEmployeeCode.Text = "Employee Code:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblEmail.Location = new System.Drawing.Point(23, 233);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(59, 23);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "Email:";
            // 
            // gbSalaryDetails
            // 
            this.gbSalaryDetails.BackColor = System.Drawing.Color.White;
            this.gbSalaryDetails.Controls.Add(this.btnEPF);
            this.gbSalaryDetails.Controls.Add(this.txtEPFAmount);
            this.gbSalaryDetails.Controls.Add(this.lblEPFAmount);
            this.gbSalaryDetails.Controls.Add(this.txtGovTaxPercentage);
            this.gbSalaryDetails.Controls.Add(this.txtAllowance);
            this.gbSalaryDetails.Controls.Add(this.txtOTRateHourly);
            this.gbSalaryDetails.Controls.Add(this.txtMonthlySalary);
            this.gbSalaryDetails.Controls.Add(this.lblGovTaxPercentage);
            this.gbSalaryDetails.Controls.Add(this.lblAllowance);
            this.gbSalaryDetails.Controls.Add(this.lblOTRateHourly);
            this.gbSalaryDetails.Controls.Add(this.lblMonthlySalary);
            this.gbSalaryDetails.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbSalaryDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(98)))));
            this.gbSalaryDetails.Location = new System.Drawing.Point(560, 80);
            this.gbSalaryDetails.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbSalaryDetails.Name = "gbSalaryDetails";
            this.gbSalaryDetails.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbSalaryDetails.Size = new System.Drawing.Size(457, 427);
            this.gbSalaryDetails.TabIndex = 2;
            this.gbSalaryDetails.TabStop = false;
            this.gbSalaryDetails.Text = "Salary Information";
            // 
            // btnEPF
            // 
            this.btnEPF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.btnEPF.FlatAppearance.BorderSize = 0;
            this.btnEPF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEPF.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEPF.ForeColor = System.Drawing.Color.White;
            this.btnEPF.Location = new System.Drawing.Point(171, 240);
            this.btnEPF.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEPF.Name = "btnEPF";
            this.btnEPF.Size = new System.Drawing.Size(263, 47);
            this.btnEPF.TabIndex = 8;
            this.btnEPF.Text = "Calculate EPF";
            this.btnEPF.UseVisualStyleBackColor = false;
            this.btnEPF.Click += new System.EventHandler(this.btnEPF_Click);
            // 
            // txtEPFAmount
            // 
            this.txtEPFAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEPFAmount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEPFAmount.Location = new System.Drawing.Point(171, 293);
            this.txtEPFAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEPFAmount.Name = "txtEPFAmount";
            this.txtEPFAmount.ReadOnly = true;
            this.txtEPFAmount.Size = new System.Drawing.Size(263, 30);
            this.txtEPFAmount.TabIndex = 9;
            this.txtEPFAmount.Text = "0.00";
            // 
            // lblEPFAmount
            // 
            this.lblEPFAmount.AutoSize = true;
            this.lblEPFAmount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEPFAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblEPFAmount.Location = new System.Drawing.Point(23, 297);
            this.lblEPFAmount.Name = "lblEPFAmount";
            this.lblEPFAmount.Size = new System.Drawing.Size(113, 23);
            this.lblEPFAmount.TabIndex = 8;
            this.lblEPFAmount.Text = "EPF Amount:";
            // 
            // txtGovTaxPercentage
            // 
            this.txtGovTaxPercentage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGovTaxPercentage.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtGovTaxPercentage.Location = new System.Drawing.Point(171, 183);
            this.txtGovTaxPercentage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGovTaxPercentage.Name = "txtGovTaxPercentage";
            this.txtGovTaxPercentage.Size = new System.Drawing.Size(263, 30);
            this.txtGovTaxPercentage.TabIndex = 7;
            // 
            // txtAllowance
            // 
            this.txtAllowance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAllowance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAllowance.Location = new System.Drawing.Point(171, 136);
            this.txtAllowance.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAllowance.Name = "txtAllowance";
            this.txtAllowance.Size = new System.Drawing.Size(263, 30);
            this.txtAllowance.TabIndex = 5;
            // 
            // txtOTRateHourly
            // 
            this.txtOTRateHourly.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOTRateHourly.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtOTRateHourly.Location = new System.Drawing.Point(171, 89);
            this.txtOTRateHourly.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOTRateHourly.Name = "txtOTRateHourly";
            this.txtOTRateHourly.Size = new System.Drawing.Size(263, 30);
            this.txtOTRateHourly.TabIndex = 3;
            // 
            // txtMonthlySalary
            // 
            this.txtMonthlySalary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMonthlySalary.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMonthlySalary.Location = new System.Drawing.Point(171, 43);
            this.txtMonthlySalary.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMonthlySalary.Name = "txtMonthlySalary";
            this.txtMonthlySalary.Size = new System.Drawing.Size(263, 30);
            this.txtMonthlySalary.TabIndex = 1;
            // 
            // lblGovTaxPercentage
            // 
            this.lblGovTaxPercentage.AutoSize = true;
            this.lblGovTaxPercentage.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGovTaxPercentage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblGovTaxPercentage.Location = new System.Drawing.Point(23, 187);
            this.lblGovTaxPercentage.Name = "lblGovTaxPercentage";
            this.lblGovTaxPercentage.Size = new System.Drawing.Size(136, 23);
            this.lblGovTaxPercentage.TabIndex = 6;
            this.lblGovTaxPercentage.Text = "EPF Percentage:";
            // 
            // lblAllowance
            // 
            this.lblAllowance.AutoSize = true;
            this.lblAllowance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAllowance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblAllowance.Location = new System.Drawing.Point(23, 140);
            this.lblAllowance.Name = "lblAllowance";
            this.lblAllowance.Size = new System.Drawing.Size(97, 23);
            this.lblAllowance.TabIndex = 4;
            this.lblAllowance.Text = "Allowance:";
            // 
            // lblOTRateHourly
            // 
            this.lblOTRateHourly.AutoSize = true;
            this.lblOTRateHourly.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOTRateHourly.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblOTRateHourly.Location = new System.Drawing.Point(23, 93);
            this.lblOTRateHourly.Name = "lblOTRateHourly";
            this.lblOTRateHourly.Size = new System.Drawing.Size(149, 23);
            this.lblOTRateHourly.TabIndex = 2;
            this.lblOTRateHourly.Text = "OT Rate (Hourly):";
            // 
            // lblMonthlySalary
            // 
            this.lblMonthlySalary.AutoSize = true;
            this.lblMonthlySalary.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMonthlySalary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblMonthlySalary.Location = new System.Drawing.Point(23, 47);
            this.lblMonthlySalary.Name = "lblMonthlySalary";
            this.lblMonthlySalary.Size = new System.Drawing.Size(137, 23);
            this.lblMonthlySalary.TabIndex = 0;
            this.lblMonthlySalary.Text = "Monthly Salary:";
            // 
            // pnlActionButtons
            // 
            this.pnlActionButtons.BackColor = System.Drawing.Color.White;
            this.pnlActionButtons.Controls.Add(this.btnClear);
            this.pnlActionButtons.Controls.Add(this.btnDelete);
            this.pnlActionButtons.Controls.Add(this.lnkViewAllEmployees);
            this.pnlActionButtons.Controls.Add(this.btnUpdate);
            this.pnlActionButtons.Controls.Add(this.btnSave);
            this.pnlActionButtons.Controls.Add(this.btnSearch);
            this.pnlActionButtons.Location = new System.Drawing.Point(560, 533);
            this.pnlActionButtons.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlActionButtons.Name = "pnlActionButtons";
            this.pnlActionButtons.Size = new System.Drawing.Size(457, 184);
            this.pnlActionButtons.TabIndex = 3;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(136, 79);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(123, 39);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear Form";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(303, 20);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(86, 47);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lnkViewAllEmployees
            // 
            this.lnkViewAllEmployees.AutoSize = true;
            this.lnkViewAllEmployees.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lnkViewAllEmployees.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(98)))));
            this.lnkViewAllEmployees.Location = new System.Drawing.Point(11, 137);
            this.lnkViewAllEmployees.Name = "lnkViewAllEmployees";
            this.lnkViewAllEmployees.Size = new System.Drawing.Size(166, 23);
            this.lnkViewAllEmployees.TabIndex = 4;
            this.lnkViewAllEmployees.TabStop = true;
            this.lnkViewAllEmployees.Text = "View All Employees";
            this.lnkViewAllEmployees.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkViewAllEmployees_LinkClicked);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(206, 20);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(86, 47);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(109, 20);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 47);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Teal;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(11, 20);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(86, 47);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.AllowUserToAddRows = false;
            this.dgvEmployees.AllowUserToDeleteRows = false;
            this.dgvEmployees.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.dgvEmployees.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEmployees.BackgroundColor = System.Drawing.Color.White;
            this.dgvEmployees.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(98)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmployees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.EnableHeadersVisualStyles = false;
            this.dgvEmployees.GridColor = System.Drawing.Color.LightGray;
            this.dgvEmployees.Location = new System.Drawing.Point(194, 737);
            this.dgvEmployees.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.ReadOnly = true;
            this.dgvEmployees.RowHeadersVisible = false;
            this.dgvEmployees.RowHeadersWidth = 51;
            this.dgvEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployees.Size = new System.Drawing.Size(823, 237);
            this.dgvEmployees.TabIndex = 5;
            this.dgvEmployees.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployees_CellDoubleClick);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(23, 928);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(114, 47);
            this.btnBack.TabIndex = 6;
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
            this.lblTitle.Size = new System.Drawing.Size(321, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Employee Management";
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1280, 1000);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvEmployees);
            this.Controls.Add(this.pnlActionButtons);
            this.Controls.Add(this.gbSalaryDetails);
            this.Controls.Add(this.gbEmployeeDetails);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "EmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Management - EMS";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            this.gbEmployeeDetails.ResumeLayout(false);
            this.gbEmployeeDetails.PerformLayout();
            this.gbSalaryDetails.ResumeLayout(false);
            this.gbSalaryDetails.PerformLayout();
            this.pnlActionButtons.ResumeLayout(false);
            this.pnlActionButtons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox gbEmployeeDetails;
        private TextBox txtContact;
        private DateTimePicker dtpDOB;
        private TextBox txtNIC;
        private RadioButton rbFemale;
        private RadioButton rbMale;
        private TextBox txtAddress;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private TextBox txtEmpID;
        private TextBox txtEmployeeCode;
        private TextBox txtEmail;
        private CheckBox chkIsActive;
        private Label lblContact;
        private Label lblDOB;
        private Label lblNIC;
        private Label lblGender;
        private Label lblAddress;
        private Label lblLastName;
        private Label lblFirstName;
        private Label lblEmpID;
        private Label lblEmployeeCode;
        private Label lblEmail;
        private GroupBox gbSalaryDetails;
        private Button btnEPF;
        private TextBox txtEPFAmount;
        private Label lblEPFAmount;
        private TextBox txtGovTaxPercentage;
        private TextBox txtAllowance;
        private TextBox txtOTRateHourly;
        private TextBox txtMonthlySalary;
        private Label lblGovTaxPercentage;
        private Label lblAllowance;
        private Label lblOTRateHourly;
        private Label lblMonthlySalary;
        private Panel pnlActionButtons;
        private Button btnClear;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnSave;
        private Button btnSearch;
        private LinkLabel lnkViewAllEmployees;
        private DataGridView dgvEmployees;
        private Button btnBack;
        private TextBox txtPosition;
        private Label lblPosition;
        private Label lblTitle;
    }
}