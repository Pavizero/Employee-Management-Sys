using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace EMS
{
    public partial class ReportsForm : Form
    {
        private DataTable currentReportData;
        private string currentReportTitle;

        public ReportsForm()
        {
            InitializeComponent();
        }

        private void ReportsForm_Load(object sender, EventArgs e)
        {
            lblReportTitle.Text = "Simple Reports";
            dataGridViewReport.Visible = false;
            lblReportInfo.Text = "Select a report type to generate";
        }

        private void btnEmployeeReport_Click(object sender, EventArgs e)
        {
            try
            {
                string query = @"SELECT e.EmployeeID, e.EmployeeCode, e.FirstName, e.LastName, e.Email, 
                                e.Position, e.Salary, e.OTRate, e.Allowance, e.EPFPercentage, e.EPFAmount, e.IsActive,
                                e.DateOfBirth, e.Gender, e.Phone, e.Address, e.NIC, e.CreatedDate
                                FROM Employees e 
                                ORDER BY e.LastName, e.FirstName";

                DataTable dt = DatabaseHelper.ExecuteQuery(query);
                DisplayReport(dt, "Employee Report");
                currentReportData = dt;
                currentReportTitle = "Employee Report";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating employee report: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalaryReport_Click(object sender, EventArgs e)
        {
            try
            {
                string query = @"SELECT s.SalaryID, s.PayrollID, s.EmployeeID, 
                                e.FirstName + ' ' + e.LastName AS EmployeeName,
                                s.BasicSalary, s.Overtime, s.Allowance, s.Deductions, s.NetSalary, 
                                s.Month, s.Year, s.PaymentDate, s.CreatedDate
                                FROM Salaries s
                                INNER JOIN Employees e ON s.EmployeeID = e.EmployeeID
                                ORDER BY s.PaymentDate DESC";

                DataTable dt = DatabaseHelper.ExecuteQuery(query);
                DisplayReport(dt, "Salary Report");
                currentReportData = dt;
                currentReportTitle = "Salary Report";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating salary report: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUserReport_Click(object sender, EventArgs e)
        {
            try
            {
                string query = @"SELECT UserID, Username, FullName, Email, Role, IsActive, CreatedDate
                                FROM Users 
                                ORDER BY Username";

                DataTable dt = DatabaseHelper.ExecuteQuery(query);
                DisplayReport(dt, "User Report");
                currentReportData = dt;
                currentReportTitle = "User Report";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating user report: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEPFReport_Click(object sender, EventArgs e)
        {
            try
            {
                string query = @"SELECT EmployeeID, EmployeeCode, FirstName, LastName, Salary, 
                                EPFPercentage, EPFAmount, 
                                (Salary * EPFPercentage / 100) AS CalculatedEPF,
                                (EPFAmount - (Salary * EPFPercentage / 100)) AS Difference
                                FROM Employees 
                                WHERE EPFPercentage > 0
                                ORDER BY LastName, FirstName";

                DataTable dt = DatabaseHelper.ExecuteQuery(query);
                DisplayReport(dt, "EPF Report");
                currentReportData = dt;
                currentReportTitle = "EPF Report";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating EPF report: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayReport(DataTable data, string reportTitle)
        {
            try
            {
                // Configure DataGridView
                dataGridViewReport.DataSource = data;
                dataGridViewReport.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                dataGridViewReport.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
                dataGridViewReport.EnableHeadersVisualStyles = false;
                dataGridViewReport.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(46, 74, 98);
                dataGridViewReport.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
                dataGridViewReport.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);

                // Show report
                dataGridViewReport.Visible = true;
                lblReportTitle.Text = reportTitle;
                lblReportInfo.Text = $"Generated: {DateTime.Now:yyyy-MM-dd HH:mm:ss} | Total Records: {data.Rows.Count}";

                // Enable export and print buttons
                btnExport.Enabled = true;
                btnPrint.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error displaying report: {ex.Message}", "Display Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (currentReportData != null && currentReportData.Rows.Count > 0)
            {
                try
                {
                    SaveFileDialog saveDialog = new SaveFileDialog();
                    saveDialog.Filter = "CSV files (*.csv)|*.csv|Text files (*.txt)|*.txt";
                    saveDialog.FileName = $"{currentReportTitle.Replace(" ", "_")}_{DateTime.Now:yyyyMMdd}.csv";
                    saveDialog.DefaultExt = "csv";

                    if (saveDialog.ShowDialog() == DialogResult.OK)
                    {
                        ExportToCSV(currentReportData, saveDialog.FileName);
                        MessageBox.Show($"Report exported successfully to:\n{saveDialog.FileName}", "Export Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error exporting report: {ex.Message}", "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please generate a report first before exporting.", "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ExportToCSV(DataTable dataTable, string filePath)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(filePath, false))
                {
                    // Write headers
                    for (int i = 0; i < dataTable.Columns.Count; i++)
                    {
                        sw.Write(dataTable.Columns[i].ColumnName);
                        if (i < dataTable.Columns.Count - 1)
                            sw.Write(",");
                    }
                    sw.WriteLine();

                    // Write data rows
                    foreach (DataRow row in dataTable.Rows)
                    {
                        for (int i = 0; i < dataTable.Columns.Count; i++)
                        {
                            string value = row[i]?.ToString() ?? "";
                            // Escape commas and quotes
                            if (value.Contains(",") || value.Contains("\"") || value.Contains("\n"))
                            {
                                value = "\"" + value.Replace("\"", "\"\"") + "\"";
                            }
                            sw.Write(value);
                            if (i < dataTable.Columns.Count - 1)
                                sw.Write(",");
                        }
                        sw.WriteLine();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"CSV export failed: {ex.Message}");
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (currentReportData != null && currentReportData.Rows.Count > 0)
            {
                try
                {
                    // Simple print functionality - print the DataGridView
                    PrintDialog printDialog = new PrintDialog();
                    PrintDocument printDocument = new PrintDocument();
                    printDocument.PrintPage += PrintDocument_PrintPage;
                    
                    if (printDialog.ShowDialog() == DialogResult.OK)
                    {
                        printDocument.PrinterSettings = printDialog.PrinterSettings;
                        printDocument.Print();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error printing report: {ex.Message}", "Print Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please generate a report first before printing.", "Print Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            try
            {
                // Simple text-based printing
                string reportContent = $"{currentReportTitle}\n";
                reportContent += $"Generated: {DateTime.Now:yyyy-MM-dd HH:mm:ss}\n";
                reportContent += $"Total Records: {currentReportData.Rows.Count}\n";
                reportContent += "=".PadRight(50, '=') + "\n\n";

                // Add column headers
                foreach (DataColumn col in currentReportData.Columns)
                {
                    reportContent += $"{col.ColumnName,-15}";
                }
                reportContent += "\n";
                reportContent += "-".PadRight(15 * currentReportData.Columns.Count, '-') + "\n";

                // Add data rows (limit to first 50 for printing)
                int maxRows = Math.Min(50, currentReportData.Rows.Count);
                for (int i = 0; i < maxRows; i++)
                {
                    DataRow row = currentReportData.Rows[i];
                    foreach (DataColumn col in currentReportData.Columns)
                    {
                        string value = row[col]?.ToString() ?? "";
                        if (value.Length > 14) value = value.Substring(0, 11) + "...";
                        reportContent += $"{value,-15}";
                    }
                    reportContent += "\n";
                }

                if (currentReportData.Rows.Count > 50)
                {
                    reportContent += $"\n... and {currentReportData.Rows.Count - 50} more records (truncated for printing)";
                }

                // Print the content
                using (Font font = new Font("Courier New", 8))
                {
                    e.Graphics.DrawString(reportContent, font, Brushes.Black, 50, 50);
                }
            }
            catch (Exception ex)
            {
                e.Graphics.DrawString($"Error printing report: {ex.Message}", new Font("Arial", 10), Brushes.Red, 50, 50);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dataGridViewReport.Visible = false;
            dataGridViewReport.DataSource = null;
            lblReportTitle.Text = "Simple Reports";
            lblReportInfo.Text = "Select a report type to generate";
            btnExport.Enabled = false;
            btnPrint.Enabled = false;
            currentReportData = null;
            currentReportTitle = null;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


