using System.Windows.Forms;
using System.Drawing;

namespace EMS
{
    partial class SalaryForm
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
            this.gbSalaryDetails = new System.Windows.Forms.GroupBox();
            this.txtCycleDateRange = new System.Windows.Forms.TextBox();
            this.txtLeavesPerYear = new System.Windows.Forms.TextBox();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblCycleDateRange = new System.Windows.Forms.Label();
            this.lblLeavesPerYear = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.gbEmployeeDetails = new System.Windows.Forms.GroupBox();
            this.txtGovTaxPercentage = new System.Windows.Forms.TextBox();
            this.txtAllowance = new System.Windows.Forms.TextBox();
            this.txtOTRateHourly = new System.Windows.Forms.TextBox();
            this.txtMonthlySalary = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtNIC = new System.Windows.Forms.TextBox();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblGovTaxPercentage = new System.Windows.Forms.Label();
            this.lblAllowance = new System.Windows.Forms.Label();
            this.lblOTRateHourly = new System.Windows.Forms.Label();
            this.lblMonthlySalary = new System.Windows.Forms.Label();
            this.lblNIC = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtEmpID = new System.Windows.Forms.TextBox();
            this.lblEmpID = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.gbAttendanceTracking = new System.Windows.Forms.GroupBox();
            this.txtOverallAttendance = new System.Windows.Forms.TextBox();
            this.txtOTHours = new System.Windows.Forms.TextBox();
            this.txtHolidaysTaken = new System.Windows.Forms.TextBox();
            this.txtDaysAbsent = new System.Windows.Forms.TextBox();
            this.txtLeavesTaken = new System.Windows.Forms.TextBox();
            this.lblOverallAttendance = new System.Windows.Forms.Label();
            this.lblOTHours = new System.Windows.Forms.Label();
            this.lblHolidaysTaken = new System.Windows.Forms.Label();
            this.lblDaysAbsent = new System.Windows.Forms.Label();
            this.lblLeavesTaken = new System.Windows.Forms.Label();
            this.gbSalaryCalculation = new System.Windows.Forms.GroupBox();
            this.btnConfirmSalary = new System.Windows.Forms.Button();
            this.btnViewReport = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtGrossPay = new System.Windows.Forms.TextBox();
            this.txtNoPay = new System.Windows.Forms.TextBox();
            this.txtOT = new System.Windows.Forms.TextBox();
            this.txtBasePay = new System.Windows.Forms.TextBox();
            this.dtpPayDate = new System.Windows.Forms.DateTimePicker();
            this.txtPayRollID = new System.Windows.Forms.TextBox();
            this.txtSalaryID = new System.Windows.Forms.TextBox();
            this.lblGrossPay = new System.Windows.Forms.Label();
            this.lblNoPay = new System.Windows.Forms.Label();
            this.lblOT = new System.Windows.Forms.Label();
            this.lblBasePay = new System.Windows.Forms.Label();
            this.lblPayDate = new System.Windows.Forms.Label();
            this.lblPayRollID = new System.Windows.Forms.Label();
            this.lblSalaryID = new System.Windows.Forms.Label();
            this.btnNewSalary = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbSalaryDetails.SuspendLayout();
            this.gbEmployeeDetails.SuspendLayout();
            this.gbAttendanceTracking.SuspendLayout();
            this.gbSalaryCalculation.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSalaryDetails
            // 
            this.gbSalaryDetails.BackColor = System.Drawing.Color.White;
            this.gbSalaryDetails.Controls.Add(this.txtCycleDateRange);
            this.gbSalaryDetails.Controls.Add(this.txtLeavesPerYear);
            this.gbSalaryDetails.Controls.Add(this.dtpEndDate);
            this.gbSalaryDetails.Controls.Add(this.dtpStartDate);
            this.gbSalaryDetails.Controls.Add(this.lblCycleDateRange);
            this.gbSalaryDetails.Controls.Add(this.lblLeavesPerYear);
            this.gbSalaryDetails.Controls.Add(this.lblEndDate);
            this.gbSalaryDetails.Controls.Add(this.lblStartDate);
            this.gbSalaryDetails.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbSalaryDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(98)))));
            this.gbSalaryDetails.Location = new System.Drawing.Point(23, 80);
            this.gbSalaryDetails.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbSalaryDetails.Name = "gbSalaryDetails";
            this.gbSalaryDetails.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbSalaryDetails.Size = new System.Drawing.Size(1006, 160);
            this.gbSalaryDetails.TabIndex = 1;
            this.gbSalaryDetails.TabStop = false;
            this.gbSalaryDetails.Text = "💰 Salary Period Details";
            // 
            // txtCycleDateRange
            // 
            this.txtCycleDateRange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCycleDateRange.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCycleDateRange.Location = new System.Drawing.Point(606, 89);
            this.txtCycleDateRange.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCycleDateRange.Name = "txtCycleDateRange";
            this.txtCycleDateRange.Size = new System.Drawing.Size(205, 30);
            this.txtCycleDateRange.TabIndex = 7;
            // 
            // txtLeavesPerYear
            // 
            this.txtLeavesPerYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLeavesPerYear.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLeavesPerYear.Location = new System.Drawing.Point(606, 43);
            this.txtLeavesPerYear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLeavesPerYear.Name = "txtLeavesPerYear";
            this.txtLeavesPerYear.Size = new System.Drawing.Size(205, 30);
            this.txtLeavesPerYear.TabIndex = 5;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpEndDate.Location = new System.Drawing.Point(137, 89);
            this.dtpEndDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(251, 30);
            this.dtpEndDate.TabIndex = 3;
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
            // lblCycleDateRange
            // 
            this.lblCycleDateRange.AutoSize = true;
            this.lblCycleDateRange.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCycleDateRange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblCycleDateRange.Location = new System.Drawing.Point(457, 93);
            this.lblCycleDateRange.Name = "lblCycleDateRange";
            this.lblCycleDateRange.Size = new System.Drawing.Size(155, 23);
            this.lblCycleDateRange.TabIndex = 6;
            this.lblCycleDateRange.Text = "Cycle Date Range:";
            // 
            // lblLeavesPerYear
            // 
            this.lblLeavesPerYear.AutoSize = true;
            this.lblLeavesPerYear.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLeavesPerYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblLeavesPerYear.Location = new System.Drawing.Point(457, 47);
            this.lblLeavesPerYear.Name = "lblLeavesPerYear";
            this.lblLeavesPerYear.Size = new System.Drawing.Size(136, 23);
            this.lblLeavesPerYear.TabIndex = 4;
            this.lblLeavesPerYear.Text = "Leaves Per Year:";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEndDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblEndDate.Location = new System.Drawing.Point(23, 93);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(88, 23);
            this.lblEndDate.TabIndex = 2;
            this.lblEndDate.Text = "End Date:";
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
            // gbEmployeeDetails
            // 
            this.gbEmployeeDetails.BackColor = System.Drawing.Color.White;
            this.gbEmployeeDetails.Controls.Add(this.txtGovTaxPercentage);
            this.gbEmployeeDetails.Controls.Add(this.txtAllowance);
            this.gbEmployeeDetails.Controls.Add(this.txtOTRateHourly);
            this.gbEmployeeDetails.Controls.Add(this.txtMonthlySalary);
            this.gbEmployeeDetails.Controls.Add(this.btnSearch);
            this.gbEmployeeDetails.Controls.Add(this.txtNIC);
            this.gbEmployeeDetails.Controls.Add(this.rbFemale);
            this.gbEmployeeDetails.Controls.Add(this.rbMale);
            this.gbEmployeeDetails.Controls.Add(this.txtFirstName);
            this.gbEmployeeDetails.Controls.Add(this.lblGovTaxPercentage);
            this.gbEmployeeDetails.Controls.Add(this.lblAllowance);
            this.gbEmployeeDetails.Controls.Add(this.lblOTRateHourly);
            this.gbEmployeeDetails.Controls.Add(this.lblMonthlySalary);
            this.gbEmployeeDetails.Controls.Add(this.lblNIC);
            this.gbEmployeeDetails.Controls.Add(this.lblGender);
            this.gbEmployeeDetails.Controls.Add(this.lblFirstName);
            this.gbEmployeeDetails.Controls.Add(this.txtEmpID);
            this.gbEmployeeDetails.Controls.Add(this.lblEmpID);
            this.gbEmployeeDetails.Controls.Add(this.txtLastName);
            this.gbEmployeeDetails.Controls.Add(this.lblLastName);
            this.gbEmployeeDetails.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbEmployeeDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(98)))));
            this.gbEmployeeDetails.Location = new System.Drawing.Point(23, 267);
            this.gbEmployeeDetails.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbEmployeeDetails.Name = "gbEmployeeDetails";
            this.gbEmployeeDetails.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbEmployeeDetails.Size = new System.Drawing.Size(491, 507);
            this.gbEmployeeDetails.TabIndex = 2;
            this.gbEmployeeDetails.TabStop = false;
            this.gbEmployeeDetails.Text = "👤 Employee Details";
            // 
            // txtGovTaxPercentage
            // 
            this.txtGovTaxPercentage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGovTaxPercentage.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtGovTaxPercentage.Location = new System.Drawing.Point(160, 469);
            this.txtGovTaxPercentage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGovTaxPercentage.Name = "txtGovTaxPercentage";
            this.txtGovTaxPercentage.Size = new System.Drawing.Size(228, 30);
            this.txtGovTaxPercentage.TabIndex = 19;
            // 
            // txtAllowance
            // 
            this.txtAllowance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAllowance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAllowance.Location = new System.Drawing.Point(160, 416);
            this.txtAllowance.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAllowance.Name = "txtAllowance";
            this.txtAllowance.Size = new System.Drawing.Size(228, 30);
            this.txtAllowance.TabIndex = 17;
            // 
            // txtOTRateHourly
            // 
            this.txtOTRateHourly.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOTRateHourly.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtOTRateHourly.Location = new System.Drawing.Point(160, 363);
            this.txtOTRateHourly.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOTRateHourly.Name = "txtOTRateHourly";
            this.txtOTRateHourly.Size = new System.Drawing.Size(228, 30);
            this.txtOTRateHourly.TabIndex = 15;
            // 
            // txtMonthlySalary
            // 
            this.txtMonthlySalary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMonthlySalary.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMonthlySalary.Location = new System.Drawing.Point(160, 309);
            this.txtMonthlySalary.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMonthlySalary.Name = "txtMonthlySalary";
            this.txtMonthlySalary.Size = new System.Drawing.Size(228, 30);
            this.txtMonthlySalary.TabIndex = 13;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(400, 40);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 40);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtNIC
            // 
            this.txtNIC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNIC.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNIC.Location = new System.Drawing.Point(160, 256);
            this.txtNIC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNIC.Name = "txtNIC";
            this.txtNIC.Size = new System.Drawing.Size(228, 30);
            this.txtNIC.TabIndex = 11;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbFemale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.rbFemale.Location = new System.Drawing.Point(240, 204);
            this.rbFemale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(85, 27);
            this.rbFemale.TabIndex = 9;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbMale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.rbMale.Location = new System.Drawing.Point(160, 204);
            this.rbMale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(68, 27);
            this.rbMale.TabIndex = 8;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // txtFirstName
            // 
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFirstName.Location = new System.Drawing.Point(160, 96);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(228, 30);
            this.txtFirstName.TabIndex = 4;
            // 
            // lblGovTaxPercentage
            // 
            this.lblGovTaxPercentage.AutoSize = true;
            this.lblGovTaxPercentage.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGovTaxPercentage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblGovTaxPercentage.Location = new System.Drawing.Point(23, 473);
            this.lblGovTaxPercentage.Name = "lblGovTaxPercentage";
            this.lblGovTaxPercentage.Size = new System.Drawing.Size(136, 23);
            this.lblGovTaxPercentage.TabIndex = 18;
            this.lblGovTaxPercentage.Text = "EPF Percentage:";
            // 
            // lblAllowance
            // 
            this.lblAllowance.AutoSize = true;
            this.lblAllowance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAllowance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblAllowance.Location = new System.Drawing.Point(23, 420);
            this.lblAllowance.Name = "lblAllowance";
            this.lblAllowance.Size = new System.Drawing.Size(97, 23);
            this.lblAllowance.TabIndex = 16;
            this.lblAllowance.Text = "Allowance:";
            // 
            // lblOTRateHourly
            // 
            this.lblOTRateHourly.AutoSize = true;
            this.lblOTRateHourly.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOTRateHourly.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblOTRateHourly.Location = new System.Drawing.Point(23, 367);
            this.lblOTRateHourly.Name = "lblOTRateHourly";
            this.lblOTRateHourly.Size = new System.Drawing.Size(149, 23);
            this.lblOTRateHourly.TabIndex = 14;
            this.lblOTRateHourly.Text = "OT Rate (Hourly):";
            // 
            // lblMonthlySalary
            // 
            this.lblMonthlySalary.AutoSize = true;
            this.lblMonthlySalary.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMonthlySalary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblMonthlySalary.Location = new System.Drawing.Point(23, 313);
            this.lblMonthlySalary.Name = "lblMonthlySalary";
            this.lblMonthlySalary.Size = new System.Drawing.Size(137, 23);
            this.lblMonthlySalary.TabIndex = 12;
            this.lblMonthlySalary.Text = "Monthly Salary:";
            // 
            // lblNIC
            // 
            this.lblNIC.AutoSize = true;
            this.lblNIC.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNIC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblNIC.Location = new System.Drawing.Point(23, 260);
            this.lblNIC.Name = "lblNIC";
            this.lblNIC.Size = new System.Drawing.Size(44, 23);
            this.lblNIC.TabIndex = 10;
            this.lblNIC.Text = "NIC:";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblGender.Location = new System.Drawing.Point(23, 207);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(74, 23);
            this.lblGender.TabIndex = 7;
            this.lblGender.Text = "Gender:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblFirstName.Location = new System.Drawing.Point(23, 100);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(102, 23);
            this.lblFirstName.TabIndex = 3;
            this.lblFirstName.Text = "First Name:";
            // 
            // txtEmpID
            // 
            this.txtEmpID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmpID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmpID.Location = new System.Drawing.Point(160, 43);
            this.txtEmpID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.Size = new System.Drawing.Size(228, 30);
            this.txtEmpID.TabIndex = 1;
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
            // txtLastName
            // 
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLastName.Location = new System.Drawing.Point(160, 149);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(228, 30);
            this.txtLastName.TabIndex = 6;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblLastName.Location = new System.Drawing.Point(23, 153);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(99, 23);
            this.lblLastName.TabIndex = 5;
            this.lblLastName.Text = "Last Name:";
            // 
            // gbAttendanceTracking
            // 
            this.gbAttendanceTracking.BackColor = System.Drawing.Color.White;
            this.gbAttendanceTracking.Controls.Add(this.txtOverallAttendance);
            this.gbAttendanceTracking.Controls.Add(this.txtOTHours);
            this.gbAttendanceTracking.Controls.Add(this.txtHolidaysTaken);
            this.gbAttendanceTracking.Controls.Add(this.txtDaysAbsent);
            this.gbAttendanceTracking.Controls.Add(this.txtLeavesTaken);
            this.gbAttendanceTracking.Controls.Add(this.lblOverallAttendance);
            this.gbAttendanceTracking.Controls.Add(this.lblOTHours);
            this.gbAttendanceTracking.Controls.Add(this.lblHolidaysTaken);
            this.gbAttendanceTracking.Controls.Add(this.lblDaysAbsent);
            this.gbAttendanceTracking.Controls.Add(this.lblLeavesTaken);
            this.gbAttendanceTracking.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbAttendanceTracking.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(98)))));
            this.gbAttendanceTracking.Location = new System.Drawing.Point(537, 267);
            this.gbAttendanceTracking.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbAttendanceTracking.Name = "gbAttendanceTracking";
            this.gbAttendanceTracking.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbAttendanceTracking.Size = new System.Drawing.Size(491, 267);
            this.gbAttendanceTracking.TabIndex = 3;
            this.gbAttendanceTracking.TabStop = false;
            this.gbAttendanceTracking.Text = "📅 Attendance Tracking";
            // 
            // txtOverallAttendance
            // 
            this.txtOverallAttendance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.txtOverallAttendance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOverallAttendance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtOverallAttendance.Location = new System.Drawing.Point(400, 80);
            this.txtOverallAttendance.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOverallAttendance.Multiline = true;
            this.txtOverallAttendance.Name = "txtOverallAttendance";
            this.txtOverallAttendance.ReadOnly = true;
            this.txtOverallAttendance.Size = new System.Drawing.Size(80, 106);
            this.txtOverallAttendance.TabIndex = 9;
            this.txtOverallAttendance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtOTHours
            // 
            this.txtOTHours.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOTHours.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtOTHours.Location = new System.Drawing.Point(160, 203);
            this.txtOTHours.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOTHours.Name = "txtOTHours";
            this.txtOTHours.Size = new System.Drawing.Size(228, 30);
            this.txtOTHours.TabIndex = 7;
            // 
            // txtHolidaysTaken
            // 
            this.txtHolidaysTaken.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHolidaysTaken.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtHolidaysTaken.Location = new System.Drawing.Point(160, 149);
            this.txtHolidaysTaken.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtHolidaysTaken.Name = "txtHolidaysTaken";
            this.txtHolidaysTaken.Size = new System.Drawing.Size(228, 30);
            this.txtHolidaysTaken.TabIndex = 5;
            // 
            // txtDaysAbsent
            // 
            this.txtDaysAbsent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDaysAbsent.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDaysAbsent.Location = new System.Drawing.Point(160, 96);
            this.txtDaysAbsent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDaysAbsent.Name = "txtDaysAbsent";
            this.txtDaysAbsent.Size = new System.Drawing.Size(228, 30);
            this.txtDaysAbsent.TabIndex = 3;
            // 
            // txtLeavesTaken
            // 
            this.txtLeavesTaken.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLeavesTaken.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLeavesTaken.Location = new System.Drawing.Point(160, 43);
            this.txtLeavesTaken.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLeavesTaken.Name = "txtLeavesTaken";
            this.txtLeavesTaken.Size = new System.Drawing.Size(228, 30);
            this.txtLeavesTaken.TabIndex = 1;
            // 
            // lblOverallAttendance
            // 
            this.lblOverallAttendance.AutoSize = true;
            this.lblOverallAttendance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOverallAttendance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblOverallAttendance.Location = new System.Drawing.Point(400, 47);
            this.lblOverallAttendance.Name = "lblOverallAttendance";
            this.lblOverallAttendance.Size = new System.Drawing.Size(87, 23);
            this.lblOverallAttendance.TabIndex = 8;
            this.lblOverallAttendance.Text = "Overall %";
            // 
            // lblOTHours
            // 
            this.lblOTHours.AutoSize = true;
            this.lblOTHours.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOTHours.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblOTHours.Location = new System.Drawing.Point(23, 207);
            this.lblOTHours.Name = "lblOTHours";
            this.lblOTHours.Size = new System.Drawing.Size(89, 23);
            this.lblOTHours.TabIndex = 6;
            this.lblOTHours.Text = "OT Hours:";
            // 
            // lblHolidaysTaken
            // 
            this.lblHolidaysTaken.AutoSize = true;
            this.lblHolidaysTaken.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHolidaysTaken.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblHolidaysTaken.Location = new System.Drawing.Point(23, 153);
            this.lblHolidaysTaken.Name = "lblHolidaysTaken";
            this.lblHolidaysTaken.Size = new System.Drawing.Size(136, 23);
            this.lblHolidaysTaken.TabIndex = 4;
            this.lblHolidaysTaken.Text = "Holidays Taken:";
            // 
            // lblDaysAbsent
            // 
            this.lblDaysAbsent.AutoSize = true;
            this.lblDaysAbsent.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDaysAbsent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblDaysAbsent.Location = new System.Drawing.Point(23, 100);
            this.lblDaysAbsent.Name = "lblDaysAbsent";
            this.lblDaysAbsent.Size = new System.Drawing.Size(114, 23);
            this.lblDaysAbsent.TabIndex = 2;
            this.lblDaysAbsent.Text = "Days Absent:";
            // 
            // lblLeavesTaken
            // 
            this.lblLeavesTaken.AutoSize = true;
            this.lblLeavesTaken.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLeavesTaken.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblLeavesTaken.Location = new System.Drawing.Point(23, 47);
            this.lblLeavesTaken.Name = "lblLeavesTaken";
            this.lblLeavesTaken.Size = new System.Drawing.Size(119, 23);
            this.lblLeavesTaken.TabIndex = 0;
            this.lblLeavesTaken.Text = "Leaves Taken:";
            // 
            // gbSalaryCalculation
            // 
            this.gbSalaryCalculation.BackColor = System.Drawing.Color.White;
            this.gbSalaryCalculation.Controls.Add(this.btnConfirmSalary);
            this.gbSalaryCalculation.Controls.Add(this.btnViewReport);
            this.gbSalaryCalculation.Controls.Add(this.btnCalculate);
            this.gbSalaryCalculation.Controls.Add(this.txtGrossPay);
            this.gbSalaryCalculation.Controls.Add(this.txtNoPay);
            this.gbSalaryCalculation.Controls.Add(this.txtOT);
            this.gbSalaryCalculation.Controls.Add(this.txtBasePay);
            this.gbSalaryCalculation.Controls.Add(this.dtpPayDate);
            this.gbSalaryCalculation.Controls.Add(this.txtPayRollID);
            this.gbSalaryCalculation.Controls.Add(this.txtSalaryID);
            this.gbSalaryCalculation.Controls.Add(this.lblGrossPay);
            this.gbSalaryCalculation.Controls.Add(this.lblNoPay);
            this.gbSalaryCalculation.Controls.Add(this.lblOT);
            this.gbSalaryCalculation.Controls.Add(this.lblBasePay);
            this.gbSalaryCalculation.Controls.Add(this.lblPayDate);
            this.gbSalaryCalculation.Controls.Add(this.lblPayRollID);
            this.gbSalaryCalculation.Controls.Add(this.lblSalaryID);
            this.gbSalaryCalculation.Controls.Add(this.btnNewSalary);
            this.gbSalaryCalculation.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbSalaryCalculation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(98)))));
            this.gbSalaryCalculation.Location = new System.Drawing.Point(537, 560);
            this.gbSalaryCalculation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbSalaryCalculation.Name = "gbSalaryCalculation";
            this.gbSalaryCalculation.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbSalaryCalculation.Size = new System.Drawing.Size(491, 427);
            this.gbSalaryCalculation.TabIndex = 4;
            this.gbSalaryCalculation.TabStop = false;
            this.gbSalaryCalculation.Text = "💳 Salary Calculation";
            // 
            // btnConfirmSalary
            // 
            this.btnConfirmSalary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnConfirmSalary.FlatAppearance.BorderSize = 0;
            this.btnConfirmSalary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmSalary.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConfirmSalary.ForeColor = System.Drawing.Color.White;
            this.btnConfirmSalary.Location = new System.Drawing.Point(377, 267);
            this.btnConfirmSalary.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConfirmSalary.Name = "btnConfirmSalary";
            this.btnConfirmSalary.Size = new System.Drawing.Size(103, 47);
            this.btnConfirmSalary.TabIndex = 17;
            this.btnConfirmSalary.Text = "Confirm";
            this.btnConfirmSalary.UseVisualStyleBackColor = false;
            this.btnConfirmSalary.Click += new System.EventHandler(this.btnConfirmSalary_Click);
            // 
            // btnViewReport
            // 
            this.btnViewReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnViewReport.FlatAppearance.BorderSize = 0;
            this.btnViewReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewReport.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnViewReport.ForeColor = System.Drawing.Color.White;
            this.btnViewReport.Location = new System.Drawing.Point(263, 267);
            this.btnViewReport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnViewReport.Name = "btnViewReport";
            this.btnViewReport.Size = new System.Drawing.Size(103, 47);
            this.btnViewReport.TabIndex = 16;
            this.btnViewReport.Text = "View Report";
            this.btnViewReport.UseVisualStyleBackColor = false;
            this.btnViewReport.Click += new System.EventHandler(this.btnViewReport_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.btnCalculate.FlatAppearance.BorderSize = 0;
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCalculate.ForeColor = System.Drawing.Color.White;
            this.btnCalculate.Location = new System.Drawing.Point(149, 267);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(103, 47);
            this.btnCalculate.TabIndex = 15;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtGrossPay
            // 
            this.txtGrossPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.txtGrossPay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGrossPay.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtGrossPay.Location = new System.Drawing.Point(343, 203);
            this.txtGrossPay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGrossPay.Name = "txtGrossPay";
            this.txtGrossPay.ReadOnly = true;
            this.txtGrossPay.Size = new System.Drawing.Size(137, 32);
            this.txtGrossPay.TabIndex = 13;
            this.txtGrossPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtNoPay
            // 
            this.txtNoPay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNoPay.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNoPay.Location = new System.Drawing.Point(137, 203);
            this.txtNoPay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNoPay.Name = "txtNoPay";
            this.txtNoPay.Size = new System.Drawing.Size(137, 30);
            this.txtNoPay.TabIndex = 11;
            // 
            // txtOT
            // 
            this.txtOT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOT.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtOT.Location = new System.Drawing.Point(343, 149);
            this.txtOT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOT.Name = "txtOT";
            this.txtOT.Size = new System.Drawing.Size(137, 30);
            this.txtOT.TabIndex = 9;
            // 
            // txtBasePay
            // 
            this.txtBasePay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBasePay.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBasePay.Location = new System.Drawing.Point(137, 149);
            this.txtBasePay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBasePay.Name = "txtBasePay";
            this.txtBasePay.Size = new System.Drawing.Size(137, 30);
            this.txtBasePay.TabIndex = 7;
            // 
            // dtpPayDate
            // 
            this.dtpPayDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpPayDate.Location = new System.Drawing.Point(137, 96);
            this.dtpPayDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpPayDate.Name = "dtpPayDate";
            this.dtpPayDate.Size = new System.Drawing.Size(228, 30);
            this.dtpPayDate.TabIndex = 5;
            // 
            // txtPayRollID
            // 
            this.txtPayRollID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.txtPayRollID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPayRollID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPayRollID.Location = new System.Drawing.Point(400, 43);
            this.txtPayRollID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPayRollID.Name = "txtPayRollID";
            this.txtPayRollID.ReadOnly = true;
            this.txtPayRollID.Size = new System.Drawing.Size(80, 30);
            this.txtPayRollID.TabIndex = 3;
            // 
            // txtSalaryID
            // 
            this.txtSalaryID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.txtSalaryID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSalaryID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSalaryID.Location = new System.Drawing.Point(137, 43);
            this.txtSalaryID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSalaryID.Name = "txtSalaryID";
            this.txtSalaryID.ReadOnly = true;
            this.txtSalaryID.Size = new System.Drawing.Size(137, 30);
            this.txtSalaryID.TabIndex = 1;
            // 
            // lblGrossPay
            // 
            this.lblGrossPay.AutoSize = true;
            this.lblGrossPay.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGrossPay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(98)))));
            this.lblGrossPay.Location = new System.Drawing.Point(297, 207);
            this.lblGrossPay.Name = "lblGrossPay";
            this.lblGrossPay.Size = new System.Drawing.Size(104, 25);
            this.lblGrossPay.TabIndex = 12;
            this.lblGrossPay.Text = "Gross Pay:";
            // 
            // lblNoPay
            // 
            this.lblNoPay.AutoSize = true;
            this.lblNoPay.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNoPay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblNoPay.Location = new System.Drawing.Point(23, 207);
            this.lblNoPay.Name = "lblNoPay";
            this.lblNoPay.Size = new System.Drawing.Size(71, 23);
            this.lblNoPay.TabIndex = 10;
            this.lblNoPay.Text = "No Pay:";
            // 
            // lblOT
            // 
            this.lblOT.AutoSize = true;
            this.lblOT.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblOT.Location = new System.Drawing.Point(297, 153);
            this.lblOT.Name = "lblOT";
            this.lblOT.Size = new System.Drawing.Size(37, 23);
            this.lblOT.TabIndex = 8;
            this.lblOT.Text = "OT:";
            // 
            // lblBasePay
            // 
            this.lblBasePay.AutoSize = true;
            this.lblBasePay.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBasePay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblBasePay.Location = new System.Drawing.Point(23, 153);
            this.lblBasePay.Name = "lblBasePay";
            this.lblBasePay.Size = new System.Drawing.Size(84, 23);
            this.lblBasePay.TabIndex = 6;
            this.lblBasePay.Text = "Base Pay:";
            // 
            // lblPayDate
            // 
            this.lblPayDate.AutoSize = true;
            this.lblPayDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPayDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblPayDate.Location = new System.Drawing.Point(23, 100);
            this.lblPayDate.Name = "lblPayDate";
            this.lblPayDate.Size = new System.Drawing.Size(86, 23);
            this.lblPayDate.TabIndex = 4;
            this.lblPayDate.Text = "Pay Date:";
            // 
            // lblPayRollID
            // 
            this.lblPayRollID.AutoSize = true;
            this.lblPayRollID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPayRollID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblPayRollID.Location = new System.Drawing.Point(297, 47);
            this.lblPayRollID.Name = "lblPayRollID";
            this.lblPayRollID.Size = new System.Drawing.Size(93, 23);
            this.lblPayRollID.TabIndex = 2;
            this.lblPayRollID.Text = "Payroll ID:";
            // 
            // lblSalaryID
            // 
            this.lblSalaryID.AutoSize = true;
            this.lblSalaryID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSalaryID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblSalaryID.Location = new System.Drawing.Point(23, 47);
            this.lblSalaryID.Name = "lblSalaryID";
            this.lblSalaryID.Size = new System.Drawing.Size(88, 23);
            this.lblSalaryID.TabIndex = 0;
            this.lblSalaryID.Text = "Salary ID:";
            // 
            // btnNewSalary
            // 
            this.btnNewSalary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnNewSalary.FlatAppearance.BorderSize = 0;
            this.btnNewSalary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewSalary.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNewSalary.ForeColor = System.Drawing.Color.White;
            this.btnNewSalary.Location = new System.Drawing.Point(23, 267);
            this.btnNewSalary.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNewSalary.Name = "btnNewSalary";
            this.btnNewSalary.Size = new System.Drawing.Size(114, 47);
            this.btnNewSalary.TabIndex = 14;
            this.btnNewSalary.Text = "New Salary";
            this.btnNewSalary.UseVisualStyleBackColor = false;
            this.btnNewSalary.Click += new System.EventHandler(this.btnNewSalary_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(23, 800);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(114, 47);
            this.btnBack.TabIndex = 5;
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
            this.lblTitle.Size = new System.Drawing.Size(275, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Salary Management";
            // 
            // SalaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1051, 1013);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.gbSalaryCalculation);
            this.Controls.Add(this.gbAttendanceTracking);
            this.Controls.Add(this.gbEmployeeDetails);
            this.Controls.Add(this.gbSalaryDetails);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "SalaryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salary Management - EMS";
            this.gbSalaryDetails.ResumeLayout(false);
            this.gbSalaryDetails.PerformLayout();
            this.gbEmployeeDetails.ResumeLayout(false);
            this.gbEmployeeDetails.PerformLayout();
            this.gbAttendanceTracking.ResumeLayout(false);
            this.gbAttendanceTracking.PerformLayout();
            this.gbSalaryCalculation.ResumeLayout(false);
            this.gbSalaryCalculation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox gbSalaryDetails;
        private TextBox txtCycleDateRange;
        private TextBox txtLeavesPerYear;
        private DateTimePicker dtpEndDate;
        private DateTimePicker dtpStartDate;
        private Label lblCycleDateRange;
        private Label lblLeavesPerYear;
        private Label lblEndDate;
        private Label lblStartDate;
        private GroupBox gbEmployeeDetails;
        private TextBox txtGovTaxPercentage;
        private TextBox txtAllowance;
        private TextBox txtOTRateHourly;
        private TextBox txtMonthlySalary;
        private Button btnSearch;
        private TextBox txtNIC;
        private RadioButton rbFemale;
        private RadioButton rbMale;
        private TextBox txtFirstName;
        private Label lblGovTaxPercentage;
        private Label lblAllowance;
        private Label lblOTRateHourly;
        private Label lblMonthlySalary;
        private Label lblNIC;
        private Label lblGender;
        private Label lblFirstName;
        private GroupBox gbAttendanceTracking;
        private TextBox txtOverallAttendance;
        private TextBox txtOTHours;
        private TextBox txtHolidaysTaken;
        private TextBox txtDaysAbsent;
        private TextBox txtLeavesTaken;
        private Label lblOverallAttendance;
        private Label lblOTHours;
        private Label lblHolidaysTaken;
        private Label lblDaysAbsent;
        private Label lblLeavesTaken;
        private GroupBox gbSalaryCalculation;
        private Button btnConfirmSalary;
        private Button btnViewReport;
        private Button btnCalculate;
        private TextBox txtGrossPay;
        private TextBox txtNoPay;
        private TextBox txtOT;
        private TextBox txtBasePay;
        private DateTimePicker dtpPayDate;
        private TextBox txtPayRollID;
        private TextBox txtSalaryID;
        private Label lblGrossPay;
        private Label lblNoPay;
        private Label lblOT;
        private Label lblBasePay;
        private Label lblPayDate;
        private Label lblPayRollID;
        private Label lblSalaryID;
        private Button btnBack;
        private TextBox txtEmpID;
        private Label lblEmpID;
        private TextBox txtLastName;
        private Label lblLastName;
        private Label lblTitle;
        private Button btnNewSalary;
    }
}