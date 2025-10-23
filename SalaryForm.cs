using System;
using System.Data;
using System.Windows.Forms;

namespace EMS
{
    public partial class SalaryForm : Form
    {
        private bool isEditMode = false;
        private int currentSalaryId = 0;

        public SalaryForm()
        {
            InitializeComponent();
            InitializeForm();
        }

        private void InitializeForm()
        {
            // Set default values
            dtpStartDate.Value = DateTime.Now.AddMonths(-1);
            dtpEndDate.Value = DateTime.Now;
            dtpPayDate.Value = DateTime.Now;

            // Set default gender
            rbMale.Checked = true;

            // Set default values for leaves and cycle
            txtLeavesPerYear.Text = "25";
            txtCycleDateRange.Text = "Monthly";

            // Auto-generate IDs
            txtSalaryID.Text = GenerateNewSalaryId();
            txtPayRollID.Text = GenerateNewPayrollId();

            // Enable all fields for better usability
            EnableAllFields();
        }

        private void EnableAllFields()
        {
            // Enable all input fields
            txtEmpID.Enabled = true;
            txtFirstName.Enabled = true;
            txtLastName.Enabled = true;
            txtNIC.Enabled = true;
            txtMonthlySalary.Enabled = true;
            txtOTRateHourly.Enabled = true;
            txtAllowance.Enabled = true;
            txtGovTaxPercentage.Enabled = true;
            txtLeavesTaken.Enabled = true;
            txtDaysAbsent.Enabled = true;
            txtHolidaysTaken.Enabled = true;
            txtOTHours.Enabled = true;
            txtBasePay.Enabled = true;
            txtOT.Enabled = true;
            txtNoPay.Enabled = true;
            txtGrossPay.Enabled = true;
            txtSalaryID.Enabled = false; // Read-only, auto-generated
            txtPayRollID.Enabled = false; // Read-only, auto-generated
        }



        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string searchQuery = "";

                if (!string.IsNullOrEmpty(txtEmpID.Text))
                {
                    searchQuery = $"SELECT * FROM Employees WHERE EmployeeID = '{txtEmpID.Text}'";
                }
                else if (!string.IsNullOrEmpty(txtNIC.Text))
                {
                    searchQuery = $"SELECT * FROM Employees WHERE NIC = '{txtNIC.Text}'";
                }
                else if (!string.IsNullOrEmpty(txtFirstName.Text) || !string.IsNullOrEmpty(txtLastName.Text))
                {
                    string firstName = string.IsNullOrEmpty(txtFirstName.Text) ? "" : $"FirstName LIKE '%{txtFirstName.Text}%'";
                    string lastName = string.IsNullOrEmpty(txtLastName.Text) ? "" : $"LastName LIKE '%{txtLastName.Text}%'";

                    if (!string.IsNullOrEmpty(firstName) && !string.IsNullOrEmpty(lastName))
                        searchQuery = $"SELECT * FROM Employees WHERE {firstName} AND {lastName}";
                    else if (!string.IsNullOrEmpty(firstName))
                        searchQuery = $"SELECT * FROM Employees WHERE {firstName}";
                    else
                        searchQuery = $"SELECT * FROM Employees WHERE {lastName}";
                }
                else
                {
                    MessageBox.Show("Please enter search criteria (Employee ID, NIC, or Name)\n\nOr you can enter employee details manually and proceed with salary calculation.", "Search Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                DataTable result = DatabaseHelper.ExecuteQuery(searchQuery);

                if (result.Rows.Count > 0)
                {
                    DataRow employee = result.Rows[0];

                    // Populate employee details
                    txtEmpID.Text = employee["EmployeeID"].ToString();
                    txtFirstName.Text = employee["FirstName"].ToString();
                    txtLastName.Text = employee["LastName"].ToString();
                    txtNIC.Text = employee["NIC"]?.ToString() ?? "";

                    // Set gender
                    string gender = employee["Gender"]?.ToString()?.ToUpper() ?? "";
                    if (gender == "MALE" || gender == "M")
                        rbMale.Checked = true;
                    else if (gender == "FEMALE" || gender == "F")
                        rbFemale.Checked = true;

                    // Populate salary details
                    txtMonthlySalary.Text = employee["Salary"].ToString();
                    txtOTRateHourly.Text = employee["OTRate"]?.ToString() ?? "0";
                    txtAllowance.Text = employee["Allowance"]?.ToString() ?? "0";
                    txtGovTaxPercentage.Text = employee["EPFPercentage"]?.ToString() ?? "0";

                    // Retrieve and display stored EPF amount
                    if (employee["EPFAmount"] != DBNull.Value)
                    {
                        decimal storedEPFAmount = Convert.ToDecimal(employee["EPFAmount"]);
                        if (storedEPFAmount > 0)
                        {
                            MessageBox.Show($"Employee found!\n\nStored EPF Amount: LKR {storedEPFAmount:F2}\n\nYou can now calculate salary using this stored EPF data.", 
                                "Search Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Employee found! EPF amount not yet calculated. You can now calculate salary.", 
                                "Search Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Employee found! EPF amount not yet calculated. You can now calculate salary.", 
                            "Search Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    // Generate new salary ID and Payroll ID
                    txtSalaryID.Text = GenerateNewSalaryId();
                    txtPayRollID.Text = GenerateNewPayrollId();
                }
                else
                {
                    MessageBox.Show("No employee found with the given criteria.\n\nYou can enter employee details manually and proceed with salary calculation.", "Search Result",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching for employee: {ex.Message}", "Search Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnManualEntry_Click(object sender, EventArgs e)
        {
            // Allow user to enter employee details manually
            EnableAllFields();
            
            // Generate new IDs
            txtSalaryID.Text = GenerateNewSalaryId();
            txtPayRollID.Text = GenerateNewPayrollId();
            
            MessageBox.Show("Manual entry mode enabled. You can now enter employee details and calculate salary.", 
                "Manual Entry", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void EnableManualEntry()
        {
            // Clear employee fields to allow manual entry
            txtEmpID.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtNIC.Clear();
            
            // Enable all fields for manual entry
            EnableAllFields();
            
            // Generate new IDs
            txtSalaryID.Text = GenerateNewSalaryId();
            txtPayRollID.Text = GenerateNewPayrollId();
            
            MessageBox.Show("Manual entry mode enabled. You can now enter employee details manually and proceed with salary calculation.", 
                "Manual Entry", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnNewSalary_Click(object sender, EventArgs e)
        {
            // Start a new salary calculation
            ClearForm();
            EnableManualEntry();
        }

        private string GenerateNewSalaryId()
        {
            try
            {
                // Check if Salaries table exists and has data
                string checkQuery = "SELECT COUNT(*) FROM Salaries";
                object countResult = DatabaseHelper.ExecuteScalar(checkQuery);
                
                if (countResult != null && countResult != DBNull.Value && Convert.ToInt32(countResult) > 0)
                {
                    // Get the next number from existing SalaryIDs
                    string query = "SELECT MAX(CAST(SUBSTRING(SalaryID, 4, LEN(SalaryID)-3) AS INT)) FROM Salaries WHERE SalaryID LIKE 'SAL%'";
                    object result = DatabaseHelper.ExecuteScalar(query);

                    if (result != null && result != DBNull.Value)
                    {
                        int nextNumber = Convert.ToInt32(result) + 1;
                        return $"SAL{nextNumber:D4}";
                    }
                }
                return "SAL0001";
            }
            catch
            {
                // If table doesn't exist or any error, return default
                return "SAL0001";
            }
        }

        private string GenerateNewPayrollId()
        {
            try
            {
                // Check if Salaries table exists and has data
                string checkQuery = "SELECT COUNT(*) FROM Salaries";
                object countResult = DatabaseHelper.ExecuteScalar(checkQuery);
                
                if (countResult != null && countResult != DBNull.Value && Convert.ToInt32(countResult) > 0)
                {
                    // Get the next number from existing PayrollIDs
                    string query = "SELECT MAX(CAST(SUBSTRING(PayrollID, 4, LEN(PayrollID)-3) AS INT)) FROM Salaries WHERE PayrollID LIKE 'PRL%'";
                    object result = DatabaseHelper.ExecuteScalar(query);

                    if (result != null && result != DBNull.Value)
                    {
                        int nextNumber = Convert.ToInt32(result) + 1;
                        return $"PRL{nextNumber:D4}";
                    }
                }
                return "PRL0001";
            }
            catch
            {
                // If table doesn't exist or any error, return default
                return "PRL0001";
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if we have the minimum required information
                if (string.IsNullOrEmpty(txtMonthlySalary.Text))
                {
                    MessageBox.Show("Please enter Monthly Salary to calculate salary.", "Calculation Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrEmpty(txtLeavesTaken.Text))
                {
                    txtLeavesTaken.Text = "0";
                }

                if (string.IsNullOrEmpty(txtDaysAbsent.Text))
                {
                    txtDaysAbsent.Text = "0";
                }

                if (string.IsNullOrEmpty(txtHolidaysTaken.Text))
                {
                    txtHolidaysTaken.Text = "0";
                }

                if (string.IsNullOrEmpty(txtOTHours.Text))
                {
                    txtOTHours.Text = "0";
                }

                if (string.IsNullOrEmpty(txtOTRateHourly.Text))
                {
                    txtOTRateHourly.Text = "0";
                }

                if (string.IsNullOrEmpty(txtAllowance.Text))
                {
                    txtAllowance.Text = "0";
                }

                if (string.IsNullOrEmpty(txtGovTaxPercentage.Text))
                {
                    txtGovTaxPercentage.Text = "0";
                }

                decimal monthlySalary = Convert.ToDecimal(txtMonthlySalary.Text);
                decimal otRate = Convert.ToDecimal(txtOTRateHourly.Text);
                decimal allowance = Convert.ToDecimal(txtAllowance.Text);
                decimal epfPercentage = Convert.ToDecimal(txtGovTaxPercentage.Text);

                int leavesTaken = Convert.ToInt32(txtLeavesTaken.Text);
                int daysAbsent = Convert.ToInt32(txtDaysAbsent.Text);
                int holidaysTaken = Convert.ToInt32(txtHolidaysTaken.Text);
                decimal otHours = Convert.ToDecimal(txtOTHours.Text);

                // Calculate base pay (monthly salary minus deductions for leaves and absences)
                decimal dailyRate = monthlySalary / 30;
                decimal leavesDeduction = dailyRate * leavesTaken;
                decimal absenceDeduction = dailyRate * daysAbsent;
                decimal basePay = monthlySalary - leavesDeduction - absenceDeduction;

                // Calculate overtime
                decimal overtimePay = otRate * otHours;

                // Calculate no pay (for excessive absences)
                decimal noPay = 0;
                if (daysAbsent > 5) // Assuming 5 days is the limit
                {
                    noPay = dailyRate * (daysAbsent - 5);
                }

                // Calculate gross pay
                decimal grossPay = basePay + overtimePay + allowance - noPay;

                // Apply EPF
                decimal epfAmount = grossPay * (epfPercentage / 100);
                decimal netPay = grossPay - epfAmount;

                // Display results
                txtBasePay.Text = basePay.ToString("F2");
                txtOT.Text = overtimePay.ToString("F2");
                txtNoPay.Text = noPay.ToString("F2");
                txtGrossPay.Text = netPay.ToString("F2");

                // Calculate overall attendance
                int totalWorkingDays = 30 - Convert.ToInt32(txtHolidaysTaken.Text);
                int actualWorkingDays = totalWorkingDays - leavesTaken - daysAbsent;
                decimal attendancePercentage = (actualWorkingDays * 100.0m) / totalWorkingDays;
                txtOverallAttendance.Text = attendancePercentage.ToString("F1") + "%";

                // Check if we have stored EPF amount for this employee
                string epfMessage = "";
                if (!string.IsNullOrEmpty(txtEmpID.Text))
                {
                    try
                    {
                        int employeeId = Convert.ToInt32(txtEmpID.Text);
                        decimal storedEPFAmount = GetStoredEPFAmount(employeeId);
                        
                        if (storedEPFAmount > 0)
                        {
                            epfMessage = $"\n\nEPF Information:\nStored EPF Amount: LKR {storedEPFAmount:F2}\nCurrent EPF Calculation: LKR {epfAmount:F2}\nEPF Percentage: {epfPercentage}%";
                        }
                        else
                        {
                            epfMessage = $"\n\nEPF Calculation:\nEPF Percentage: {epfPercentage}%\nEPF Amount: LKR {epfAmount:F2}\n\nNote: EPF amount not yet stored. Use EPF button in Employee Form to save it.";
                        }
                    }
                    catch
                    {
                        epfMessage = $"\n\nEPF Calculation:\nEPF Percentage: {epfPercentage}%\nEPF Amount: LKR {epfAmount:F2}";
                    }
                }
                else
                {
                    epfMessage = $"\n\nEPF Calculation:\nEPF Percentage: {epfPercentage}%\nEPF Amount: LKR {epfAmount:F2}";
                }

                MessageBox.Show($"Salary calculation completed successfully!\n\nBase Pay: LKR {basePay:F2}\nOvertime: LKR {overtimePay:F2}\nNo Pay: LKR {noPay:F2}\nGross Pay: LKR {grossPay:F2}\nNet Pay (after EPF): LKR {netPay:F2}{epfMessage}", 
                    "Calculation Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error calculating salary: {ex.Message}", "Calculation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConfirmSalary_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtSalaryID.Text) || string.IsNullOrEmpty(txtEmpID.Text))
                {
                    MessageBox.Show("Please search for an employee and calculate salary first.",
                        "Confirmation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string insertQuery = $@"
                    INSERT INTO Salaries (SalaryID, PayrollID, EmployeeID, BasicSalary, Overtime, Allowance, 
                                        Deductions, NetSalary, Month, Year, PaymentDate, CreatedDate)
                    VALUES ('{txtSalaryID.Text}', '{txtPayRollID.Text}', '{txtEmpID.Text}', 
                            {txtBasePay.Text}, {txtOT.Text}, {txtAllowance.Text}, {txtNoPay.Text}, 
                            {txtGrossPay.Text}, {dtpPayDate.Value.Month}, {dtpPayDate.Value.Year}, 
                            '{dtpPayDate.Value:yyyy-MM-dd}', GETDATE())";

                int result = DatabaseHelper.ExecuteNonQuery(insertQuery);

                if (result > 0)
                {
                    MessageBox.Show("Salary confirmed and saved successfully!", "Confirmation Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Failed to save salary record.", "Save Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error confirming salary: {ex.Message}", "Confirmation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnViewReport_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtEmpID.Text))
                {
                    MessageBox.Show("Please search for an employee first.", "Report Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string reportQuery = $@"
                    SELECT s.SalaryID, s.PayrollID, s.EmployeeID, e.FirstName + ' ' + e.LastName as EmployeeName,
                           s.BasicSalary, s.Overtime, s.Allowance, s.Deductions, s.NetSalary,
                           s.Month, s.Year, s.PaymentDate
                    FROM Salaries s
                    INNER JOIN Employees e ON s.EmployeeID = e.EmployeeID
                    WHERE s.EmployeeID = '{txtEmpID.Text}'
                    ORDER BY s.PaymentDate DESC";

                DataTable reportData = DatabaseHelper.ExecuteQuery(reportQuery);

                if (reportData.Rows.Count > 0)
                {
                    // Create a simple report form or show in message box
                    string report = $"Salary Report for {txtFirstName.Text} {txtLastName.Text}\n\n";
                    report += $"Employee ID: {txtEmpID.Text}\n";
                    report += $"Period: {dtpStartDate.Value:MMM yyyy} - {dtpEndDate.Value:MMM yyyy}\n\n";

                    foreach (DataRow row in reportData.Rows)
                    {
                        report += $"Salary ID: {row["SalaryID"]}\n";
                        report += $"Basic Salary: ${row["BasicSalary"]}\n";
                        report += $"Overtime: ${row["Overtime"]}\n";
                        report += $"Allowance: ${row["Allowance"]}\n";
                        report += $"Deductions: ${row["Deductions"]}\n";
                        report += $"Net Salary: ${row["NetSalary"]}\n";
                        report += $"Payment Date: {Convert.ToDateTime(row["PaymentDate"]):MMM dd, yyyy}\n";
                        report += "----------------------------------------\n";
                    }

                    MessageBox.Show(report, "Salary Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No salary records found for this employee.", "Report Result",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating report: {ex.Message}", "Report Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearForm()
        {
            txtEmpID.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtNIC.Clear();
            txtMonthlySalary.Clear();
            txtOTRateHourly.Clear();
            txtAllowance.Clear();
            txtGovTaxPercentage.Clear();
            txtLeavesTaken.Clear();
            txtDaysAbsent.Clear();
            txtHolidaysTaken.Clear();
            txtOTHours.Clear();
            txtOverallAttendance.Clear();
            txtBasePay.Clear();
            txtOT.Clear();
            txtNoPay.Clear();
            txtGrossPay.Clear();

            // Regenerate IDs
            txtSalaryID.Text = GenerateNewSalaryId();
            txtPayRollID.Text = GenerateNewPayrollId();

            rbMale.Checked = true;
            
            // Enable all fields
            EnableAllFields();
            
            // Set default values
            txtLeavesPerYear.Text = "25";
            txtCycleDateRange.Text = "Monthly";
        }

        private void SalaryForm_Load(object sender, EventArgs e)
        {
            // Form load event - already handled in InitializeForm
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblFirstName_Click(object sender, EventArgs e)
        {

        }

        // Method to retrieve stored EPF amount for an employee
        public decimal GetStoredEPFAmount(int employeeId)
        {
            try
            {
                string query = $"SELECT EPFAmount FROM Employees WHERE EmployeeID = {employeeId}";
                object result = DatabaseHelper.ExecuteScalar(query);
                
                if (result != null && result != DBNull.Value)
                {
                    return Convert.ToDecimal(result);
                }
                return 0.00m;
            }
            catch
            {
                return 0.00m;
            }
        }

        // Method to display EPF information
        public void ShowEPFInformation(int employeeId)
        {
            try
            {
                string query = $"SELECT FirstName, LastName, Salary, EPFPercentage, EPFAmount FROM Employees WHERE EmployeeID = {employeeId}";
                DataTable dt = DatabaseHelper.ExecuteQuery(query);
                
                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    string firstName = row["FirstName"].ToString();
                    string lastName = row["LastName"].ToString();
                    decimal salary = Convert.ToDecimal(row["Salary"]);
                    decimal epfPercentage = Convert.ToDecimal(row["EPFPercentage"]);
                    decimal epfAmount = Convert.ToDecimal(row["EPFAmount"]);
                    
                    string message = $"EPF Information for {firstName} {lastName}:\n\n";
                    message += $"Monthly Salary: LKR {salary:F2}\n";
                    message += $"EPF Percentage: {epfPercentage}%\n";
                    message += $"Stored EPF Amount: LKR {epfAmount:F2}\n\n";
                    
                    if (epfAmount > 0)
                    {
                        message += "✅ EPF amount is stored and available for salary calculations.";
                    }
                    else
                    {
                        message += "⚠️ EPF amount not yet calculated. Use the EPF button in Employee Form first.";
                    }
                    
                    MessageBox.Show(message, "EPF Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving EPF information: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCalculate_Click_1(object sender, EventArgs e)
        {

        }
    }
}
