namespace EMS
{
    partial class ReportsForm
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
            this.groupBoxReports = new System.Windows.Forms.GroupBox();
            this.btnEPFReport = new System.Windows.Forms.Button();
            this.btnUserReport = new System.Windows.Forms.Button();
            this.btnSalaryReport = new System.Windows.Forms.Button();
            this.btnEmployeeReport = new System.Windows.Forms.Button();
            this.groupBoxActions = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.lblReportTitle = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.dataGridViewReport = new System.Windows.Forms.DataGridView();
            this.lblReportInfo = new System.Windows.Forms.Label();
            this.groupBoxReports.SuspendLayout();
            this.groupBoxActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxReports
            // 
            this.groupBoxReports.BackColor = System.Drawing.Color.White;
            this.groupBoxReports.Controls.Add(this.btnEPFReport);
            this.groupBoxReports.Controls.Add(this.btnUserReport);
            this.groupBoxReports.Controls.Add(this.btnSalaryReport);
            this.groupBoxReports.Controls.Add(this.btnEmployeeReport);
            this.groupBoxReports.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxReports.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(98)))));
            this.groupBoxReports.Location = new System.Drawing.Point(20, 60);
            this.groupBoxReports.Name = "groupBoxReports";
            this.groupBoxReports.Size = new System.Drawing.Size(220, 220);
            this.groupBoxReports.TabIndex = 0;
            this.groupBoxReports.TabStop = false;
            this.groupBoxReports.Text = "📊 Generate Reports";
            // 
            // btnEmployeeReport
            // 
            this.btnEmployeeReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnEmployeeReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployeeReport.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEmployeeReport.ForeColor = System.Drawing.Color.White;
            this.btnEmployeeReport.Location = new System.Drawing.Point(15, 30);
            this.btnEmployeeReport.Name = "btnEmployeeReport";
            this.btnEmployeeReport.Size = new System.Drawing.Size(190, 35);
            this.btnEmployeeReport.TabIndex = 0;
            this.btnEmployeeReport.Text = "Employee Report";
            this.btnEmployeeReport.UseVisualStyleBackColor = false;
            this.btnEmployeeReport.Click += new System.EventHandler(this.btnEmployeeReport_Click);
            this.btnEmployeeReport.FlatAppearance.BorderSize = 0;
            // 
            // btnSalaryReport
            // 
            this.btnSalaryReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnSalaryReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalaryReport.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalaryReport.ForeColor = System.Drawing.Color.White;
            this.btnSalaryReport.Location = new System.Drawing.Point(15, 75);
            this.btnSalaryReport.Name = "btnSalaryReport";
            this.btnSalaryReport.Size = new System.Drawing.Size(190, 35);
            this.btnSalaryReport.TabIndex = 1;
            this.btnSalaryReport.Text = "Salary Report";
            this.btnSalaryReport.UseVisualStyleBackColor = false;
            this.btnSalaryReport.Click += new System.EventHandler(this.btnSalaryReport_Click);
            this.btnSalaryReport.FlatAppearance.BorderSize = 0;
            // 
            // btnUserReport
            // 
            this.btnUserReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnUserReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserReport.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUserReport.ForeColor = System.Drawing.Color.White;
            this.btnUserReport.Location = new System.Drawing.Point(15, 120);
            this.btnUserReport.Name = "btnUserReport";
            this.btnUserReport.Size = new System.Drawing.Size(190, 35);
            this.btnUserReport.TabIndex = 2;
            this.btnUserReport.Text = "User Report";
            this.btnUserReport.UseVisualStyleBackColor = false;
            this.btnUserReport.Click += new System.EventHandler(this.btnUserReport_Click);
            this.btnUserReport.FlatAppearance.BorderSize = 0;
            // 
            // btnEPFReport
            // 
            this.btnEPFReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.btnEPFReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEPFReport.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEPFReport.ForeColor = System.Drawing.Color.White;
            this.btnEPFReport.Location = new System.Drawing.Point(15, 165);
            this.btnEPFReport.Name = "btnEPFReport";
            this.btnEPFReport.Size = new System.Drawing.Size(190, 35);
            this.btnEPFReport.TabIndex = 3;
            this.btnEPFReport.Text = "EPF Report";
            this.btnEPFReport.UseVisualStyleBackColor = false;
            this.btnEPFReport.Click += new System.EventHandler(this.btnEPFReport_Click);
            this.btnEPFReport.FlatAppearance.BorderSize = 0;
            // 
            // groupBoxActions
            // 
            this.groupBoxActions.BackColor = System.Drawing.Color.White;
            this.groupBoxActions.Controls.Add(this.btnClear);
            this.groupBoxActions.Controls.Add(this.btnExport);
            this.groupBoxActions.Controls.Add(this.btnPrint);
            this.groupBoxActions.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxActions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(98)))));
            this.groupBoxActions.Location = new System.Drawing.Point(20, 300);
            this.groupBoxActions.Name = "groupBoxActions";
            this.groupBoxActions.Size = new System.Drawing.Size(220, 180);
            this.groupBoxActions.TabIndex = 1;
            this.groupBoxActions.TabStop = false;
            this.groupBoxActions.Text = "⚡ Actions";
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnPrint.Enabled = false;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(15, 30);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(190, 35);
            this.btnPrint.TabIndex = 0;
            this.btnPrint.Text = "🖨️ Print Report";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            this.btnPrint.FlatAppearance.BorderSize = 0;
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnExport.Enabled = false;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(15, 75);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(190, 35);
            this.btnExport.TabIndex = 1;
            this.btnExport.Text = "📁 Export to CSV";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            this.btnExport.FlatAppearance.BorderSize = 0;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(15, 120);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(190, 35);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "🗑️ Clear Report";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            this.btnClear.FlatAppearance.BorderSize = 0;
            // 
            // lblReportTitle
            // 
            this.lblReportTitle.AutoSize = true;
            this.lblReportTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblReportTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(98)))));
            this.lblReportTitle.Location = new System.Drawing.Point(20, 15);
            this.lblReportTitle.Name = "lblReportTitle";
            this.lblReportTitle.Size = new System.Drawing.Size(150, 30);
            this.lblReportTitle.TabIndex = 2;
            this.lblReportTitle.Text = "Simple Reports";
            // 
            // dataGridViewReport
            // 
            this.dataGridViewReport.AllowUserToAddRows = false;
            this.dataGridViewReport.AllowUserToDeleteRows = false;
            this.dataGridViewReport.AllowUserToResizeRows = false;
            this.dataGridViewReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewReport.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewReport.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReport.EnableHeadersVisualStyles = false;
            this.dataGridViewReport.GridColor = System.Drawing.Color.LightGray;
            this.dataGridViewReport.Location = new System.Drawing.Point(270, 80);
            this.dataGridViewReport.Name = "dataGridViewReport";
            this.dataGridViewReport.ReadOnly = true;
            this.dataGridViewReport.RowHeadersVisible = false;
            this.dataGridViewReport.RowTemplate.Height = 25;
            this.dataGridViewReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewReport.Size = new System.Drawing.Size(700, 400);
            this.dataGridViewReport.TabIndex = 4;
            this.dataGridViewReport.Visible = false;
            this.dataGridViewReport.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(98)))));
            this.dataGridViewReport.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridViewReport.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dataGridViewReport.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
            // 
            // lblReportInfo
            // 
            this.lblReportInfo.AutoSize = true;
            this.lblReportInfo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblReportInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblReportInfo.Location = new System.Drawing.Point(270, 50);
            this.lblReportInfo.Name = "lblReportInfo";
            this.lblReportInfo.Size = new System.Drawing.Size(200, 19);
            this.lblReportInfo.TabIndex = 5;
            this.lblReportInfo.Text = "Select a report type to generate";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(20, 500);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(120, 35);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "← Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            this.btnBack.FlatAppearance.BorderSize = 0;
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.lblReportInfo);
            this.Controls.Add(this.dataGridViewReport);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblReportTitle);
            this.Controls.Add(this.groupBoxActions);
            this.Controls.Add(this.groupBoxReports);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ReportsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple Reports - EMS";
            this.Load += new System.EventHandler(this.ReportsForm_Load);
            this.groupBoxReports.ResumeLayout(false);
            this.groupBoxActions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxReports;
        private System.Windows.Forms.Button btnEPFReport;
        private System.Windows.Forms.Button btnUserReport;
        private System.Windows.Forms.Button btnSalaryReport;
        private System.Windows.Forms.Button btnEmployeeReport;
        private System.Windows.Forms.GroupBox groupBoxActions;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label lblReportTitle;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dataGridViewReport;
        private System.Windows.Forms.Label lblReportInfo;
    }
}