using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

namespace EMS
{
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
            InitializeForm();
        }

        private void InitializeForm()
        {
            // Set Employee ID to auto-generated
            txtEmpID.Text = "Auto-generated";
            txtEmpID.Enabled = false;

            // Set default values
            dtpDOB.Value = DateTime.Now.AddYears(-25);
            rbMale.Checked = true;
            chkIsActive.Checked = true;

            // Initialize form in Add mode
            SwitchToAddMode();

            // Load existing employees
            LoadEmployees();
        }

        #region Form Mode Management

        private void SwitchToAddMode()
        {
            SetFormFieldsEnabled(true);
            txtEmpID.Text = "Auto-generated";
            txtEmpID.Enabled = false;

            // Button states for Add mode
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnClear.Enabled = true;
            btnEPF.Enabled = true;
            btnSearch.Enabled = true;
        }

        private void SwitchToEditMode()
        {
            SetFormFieldsEnabled(true);
            txtEmpID.Enabled = false; // ID should never be editable

            // Button states for Edit mode
            btnSave.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnClear.Enabled = true;
            btnEPF.Enabled = true;
            btnSearch.Enabled = true;
        }

        private void SetFormFieldsEnabled(bool enabled)
        {
            txtEmployeeCode.Enabled = enabled;
            txtFirstName.Enabled = enabled;
            txtLastName.Enabled = enabled;
            dtpDOB.Enabled = enabled;
            rbMale.Enabled = enabled;
            rbFemale.Enabled = enabled;
            txtEmail.Enabled = enabled;
            txtContact.Enabled = enabled;
            txtAddress.Enabled = enabled;
            txtPosition.Enabled = enabled;
            txtMonthlySalary.Enabled = enabled;
            txtOTRateHourly.Enabled = enabled;
            txtAllowance.Enabled = enabled;
            txtGovTaxPercentage.Enabled = enabled;
            txtNIC.Enabled = enabled;
            chkIsActive.Enabled = enabled;
        }

        #endregion

        #region Event Handlers

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                AddEmployee();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateForm() && ValidateEmployeeIdForUpdate())
            {
                UpdateEmployee();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (ValidateEmployeeIdForUpdate())
            {
                if (MessageBox.Show("Are you sure you want to delete this employee?", "Confirm Delete",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DeleteEmployee();
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchEmployee();
        }

        private void btnEPF_Click(object sender, EventArgs e)
        {
            CalculateEPF();
        }

        #endregion

        #region CRUD Operations

        private void AddEmployee()
        {
            try
            {
                string gender = rbMale.Checked ? "Male" : "Female";

                string insertQuery = @"
                    INSERT INTO Employees 
                    (EmployeeCode, FirstName, LastName, DateOfBirth, Gender, Email, Phone, Address, Position, Salary, OTRate, Allowance, EPFPercentage, EPFAmount, NIC, IsActive, CreatedDate)
                    VALUES 
                    (@EmployeeCode, @FirstName, @LastName, @DateOfBirth, @Gender, @Email, @Phone, @Address, @Position, @Salary, @OTRate, @Allowance, @EPFPercentage, @EPFAmount, @NIC, @IsActive, GETDATE())";

                var parameters = new SqlParameter[]
                {
                    new SqlParameter("@EmployeeCode", GetSafeTextValue(txtEmployeeCode)),
                    new SqlParameter("@FirstName", GetSafeTextValue(txtFirstName)),
                    new SqlParameter("@LastName", GetSafeTextValue(txtLastName)),
                    new SqlParameter("@DateOfBirth", dtpDOB.Value.Date),
                    new SqlParameter("@Gender", gender),
                    new SqlParameter("@Email", GetSafeTextValue(txtEmail)),
                    new SqlParameter("@Phone", GetSafeTextValue(txtContact)),
                    new SqlParameter("@Address", GetSafeTextValue(txtAddress)),
                    new SqlParameter("@Position", GetSafeTextValue(txtPosition)),
                    new SqlParameter("@Salary", GetSafeDecimalValue(txtMonthlySalary)),
                    new SqlParameter("@OTRate", GetSafeDecimalValue(txtOTRateHourly)),
                    new SqlParameter("@Allowance", GetSafeDecimalValue(txtAllowance)),
                    new SqlParameter("@EPFPercentage", GetSafeDecimalValue(txtGovTaxPercentage)),
                    new SqlParameter("@EPFAmount", GetSafeEPFAmountValue()), 
                    new SqlParameter("@NIC", GetSafeTextValue(txtNIC)),
                    new SqlParameter("@IsActive", chkIsActive.Checked)
                };

                int result = DatabaseHelper.ExecuteNonQuery(insertQuery, parameters);

                if (result > 0)
                {
                    // Get the auto-generated EmployeeID
                    string getNewIdQuery = "SELECT SCOPE_IDENTITY()";
                    object newEmployeeId = DatabaseHelper.ExecuteScalar(getNewIdQuery);

                    if (newEmployeeId != null && newEmployeeId != DBNull.Value)
                    {
                        int employeeId = Convert.ToInt32(newEmployeeId);
                        txtEmpID.Text = employeeId.ToString();
                        MessageBox.Show($"Employee added successfully! Employee ID: {employeeId}", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Employee added successfully!", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    ClearForm();
                    LoadEmployees();
                }
                else
                {
                    MessageBox.Show("Failed to add employee.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding employee: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateEmployee()
        {
            try
            {
                if (!int.TryParse(txtEmpID.Text, out int employeeId))
                {
                    MessageBox.Show("Invalid Employee ID.", "Update Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string gender = rbMale.Checked ? "Male" : "Female";

                string updateQuery = @"
                    UPDATE Employees 
                    SET EmployeeCode = @EmployeeCode, FirstName = @FirstName, LastName = @LastName, 
                        DateOfBirth = @DateOfBirth, Gender = @Gender, Email = @Email, 
                        Phone = @Phone, Address = @Address, Position = @Position, 
                        Salary = @Salary, OTRate = @OTRate, Allowance = @Allowance, 
                        EPFPercentage = @EPFPercentage, EPFAmount = @EPFAmount, NIC = @NIC, IsActive = @IsActive
                    WHERE EmployeeID = @EmployeeID";

                var parameters = new SqlParameter[]
                {
                    new SqlParameter("@EmployeeID", employeeId),
                    new SqlParameter("@EmployeeCode", GetSafeTextValue(txtEmployeeCode)),
                    new SqlParameter("@FirstName", GetSafeTextValue(txtFirstName)),
                    new SqlParameter("@LastName", GetSafeTextValue(txtLastName)),
                    new SqlParameter("@DateOfBirth", dtpDOB.Value.Date),
                    new SqlParameter("@Gender", gender),
                    new SqlParameter("@Email", GetSafeTextValue(txtEmail)),
                    new SqlParameter("@Phone", GetSafeTextValue(txtContact)),
                    new SqlParameter("@Address", GetSafeTextValue(txtAddress)),
                    new SqlParameter("@Position", GetSafeTextValue(txtPosition)),
                    new SqlParameter("@Salary", GetSafeDecimalValue(txtMonthlySalary)),
                    new SqlParameter("@OTRate", GetSafeDecimalValue(txtOTRateHourly)),
                    new SqlParameter("@Allowance", GetSafeDecimalValue(txtAllowance)),
                    new SqlParameter("@EPFPercentage", GetSafeDecimalValue(txtGovTaxPercentage)),
                    new SqlParameter("@EPFAmount", GetSafeEPFAmountValue()),
                    new SqlParameter("@NIC", GetSafeTextValue(txtNIC)),
                    new SqlParameter("@IsActive", chkIsActive.Checked)
                };

                int result = DatabaseHelper.ExecuteNonQuery(updateQuery, parameters);

                if (result > 0)
                {
                    MessageBox.Show("Employee updated successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                    LoadEmployees();
                }
                else
                {
                    MessageBox.Show("No employee found with the specified ID or no changes were made.", "Update Result",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating employee: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteEmployee()
        {
            try
            {
                if (!int.TryParse(txtEmpID.Text, out int employeeId))
                {
                    MessageBox.Show("Invalid Employee ID.", "Delete Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string deleteQuery = "DELETE FROM Employees WHERE EmployeeID = @EmployeeID";
                var parameters = new SqlParameter[]
                {
                    new SqlParameter("@EmployeeID", employeeId)
                };

                int result = DatabaseHelper.ExecuteNonQuery(deleteQuery, parameters);

                if (result > 0)
                {
                    MessageBox.Show("Employee deleted successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                    LoadEmployees();
                }
                else
                {
                    MessageBox.Show("No employee found with the specified ID.", "Delete Result",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting employee: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SearchEmployee()
        {
            try
            {
                // Check if we have any search criteria
                if ((string.IsNullOrWhiteSpace(txtEmpID.Text) || txtEmpID.Text == "Auto-generated") &&
                    string.IsNullOrWhiteSpace(txtEmployeeCode.Text) &&
                    string.IsNullOrWhiteSpace(txtFirstName.Text) &&
                    string.IsNullOrWhiteSpace(txtLastName.Text))
                {
                    MessageBox.Show("Please enter search criteria (Employee ID, Employee Code, First Name, or Last Name).",
                        "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Build search query
                var whereClauses = new List<string>();
                var parameters = new List<SqlParameter>();

                if (!string.IsNullOrWhiteSpace(txtEmpID.Text) && txtEmpID.Text != "Auto-generated" && int.TryParse(txtEmpID.Text, out int empId))
                {
                    whereClauses.Add("EmployeeID = @EmployeeID");
                    parameters.Add(new SqlParameter("@EmployeeID", empId));
                }

                if (!string.IsNullOrWhiteSpace(txtEmployeeCode.Text))
                {
                    whereClauses.Add("EmployeeCode = @EmployeeCode");
                    parameters.Add(new SqlParameter("@EmployeeCode", txtEmployeeCode.Text.Trim()));
                }

                if (!string.IsNullOrWhiteSpace(txtFirstName.Text))
                {
                    whereClauses.Add("FirstName LIKE @FirstName");
                    parameters.Add(new SqlParameter("@FirstName", "%" + txtFirstName.Text.Trim() + "%"));
                }

                if (!string.IsNullOrWhiteSpace(txtLastName.Text))
                {
                    whereClauses.Add("LastName LIKE @LastName");
                    parameters.Add(new SqlParameter("@LastName", "%" + txtLastName.Text.Trim() + "%"));
                }

                string searchQuery = "SELECT * FROM Employees WHERE " + string.Join(" OR ", whereClauses);
                DataTable result = DatabaseHelper.GetDataTable(searchQuery, parameters.ToArray());

                if (result.Rows.Count > 0)
                {
                    DataRow employee = result.Rows[0];
                    PopulateFormFromDataRow(employee);
                    SwitchToEditMode();

                    if (result.Rows.Count > 1)
                    {
                        MessageBox.Show($"Found {result.Rows.Count} employees. Showing the first match.",
                            "Multiple Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Employee found! You can now edit the record.",
                            "Search Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("No employee found with the given criteria.",
                        "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching for employee: {ex.Message}", "Search Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Helper Methods

        private string GetSafeTextValue(TextBox textBox)
        {
            return textBox?.Text?.Trim() ?? string.Empty;
        }

        private decimal GetSafeDecimalValue(TextBox textBox)
        {
            if (textBox == null || string.IsNullOrWhiteSpace(textBox.Text))
                return 0.0m;

            if (decimal.TryParse(textBox.Text.Trim(), out decimal value))
                return value;

            return 0.0m;
        }

        private void SetEPFAmountText(string value)
        {
            if (txtEPFAmount != null)
            {
                txtEPFAmount.Text = value;
            }
        }

        private string GetEPFAmountText()
        {
            return txtEPFAmount?.Text ?? "0.00";
        }

        private decimal GetSafeEPFAmountValue()
        {
            if (txtEPFAmount == null)
                return 0.0m;

            if (string.IsNullOrWhiteSpace(txtEPFAmount.Text))
                return 0.0m;

            if (decimal.TryParse(txtEPFAmount.Text.Trim(), out decimal value))
                return value;

            return 0.0m;
        }

        private void PopulateFormFromDataRow(DataRow row)
        {
            if (row == null) return;

            txtEmpID.Text = GetSafeValue(row, "EmployeeID");
            txtEmployeeCode.Text = GetSafeValue(row, "EmployeeCode");
            txtFirstName.Text = GetSafeValue(row, "FirstName");
            txtLastName.Text = GetSafeValue(row, "LastName");

            if (DateTime.TryParse(GetSafeValue(row, "DateOfBirth"), out DateTime dob))
                dtpDOB.Value = dob;

            string gender = GetSafeValue(row, "Gender");
            rbMale.Checked = gender.Equals("Male", StringComparison.OrdinalIgnoreCase);
            rbFemale.Checked = gender.Equals("Female", StringComparison.OrdinalIgnoreCase);

            txtEmail.Text = GetSafeValue(row, "Email");
            txtContact.Text = GetSafeValue(row, "Phone");
            txtAddress.Text = GetSafeValue(row, "Address");
            txtPosition.Text = GetSafeValue(row, "Position");
            txtMonthlySalary.Text = GetSafeValue(row, "Salary");
            txtOTRateHourly.Text = GetSafeValue(row, "OTRate");
            txtAllowance.Text = GetSafeValue(row, "Allowance");
            txtGovTaxPercentage.Text = GetSafeValue(row, "EPFPercentage");

            // Populate EPF Amount
            if (decimal.TryParse(GetSafeValue(row, "EPFAmount"), out decimal epfAmount))
                SetEPFAmountText(epfAmount.ToString("F2"));
            else
                SetEPFAmountText("0.00");

            txtNIC.Text = GetSafeValue(row, "NIC");

            if (bool.TryParse(GetSafeValue(row, "IsActive"), out bool isActive))
                chkIsActive.Checked = isActive;
            else
                chkIsActive.Checked = GetSafeValue(row, "IsActive") == "1";
        }

        private string GetSafeValue(DataRow row, string columnName)
        {
            try
            {
                if (row.Table.Columns.Contains(columnName) && row[columnName] != DBNull.Value)
                    return row[columnName].ToString() ?? string.Empty;
            }
            catch
            {
                // Ignore any errors and return empty string
            }
            return string.Empty;
        }

        private void ClearForm()
        {
            txtEmpID.Text = "Auto-generated";
            txtEmployeeCode.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            dtpDOB.Value = DateTime.Now.AddYears(-25);
            rbMale.Checked = true;
            txtEmail.Clear();
            txtContact.Clear();
            txtAddress.Clear();
            txtPosition.Clear();
            txtMonthlySalary.Clear();
            txtOTRateHourly.Clear();
            txtAllowance.Clear();
            txtGovTaxPercentage.Clear();
            SetEPFAmountText("0.00");
            txtNIC.Clear();
            chkIsActive.Checked = true;

            SwitchToAddMode();
        }

        #endregion

        #region Validation

        private bool ValidateForm()
        {
            // Required fields validation
            if (string.IsNullOrWhiteSpace(txtEmployeeCode.Text))
            {
                ShowValidationError("Employee Code is required.", txtEmployeeCode);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                ShowValidationError("First Name is required.", txtFirstName);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                ShowValidationError("Last Name is required.", txtLastName);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                ShowValidationError("Email is required.", txtEmail);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPosition.Text))
            {
                ShowValidationError("Position is required.", txtPosition);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtMonthlySalary.Text))
            {
                ShowValidationError("Monthly Salary is required.", txtMonthlySalary);
                return false;
            }

            // Numeric validation
            if (!decimal.TryParse(txtMonthlySalary.Text.Trim(), out decimal salary) || salary < 0)
            {
                ShowValidationError("Please enter a valid Monthly Salary (must be a positive number).", txtMonthlySalary);
                return false;
            }

            if (!string.IsNullOrWhiteSpace(txtOTRateHourly.Text) &&
                (!decimal.TryParse(txtOTRateHourly.Text.Trim(), out decimal otRate) || otRate < 0))
            {
                ShowValidationError("Please enter a valid OT Rate (must be a positive number).", txtOTRateHourly);
                return false;
            }

            if (!string.IsNullOrWhiteSpace(txtAllowance.Text) &&
                (!decimal.TryParse(txtAllowance.Text.Trim(), out decimal allowance) || allowance < 0))
            {
                ShowValidationError("Please enter a valid Allowance (must be a positive number).", txtAllowance);
                return false;
            }

            if (!string.IsNullOrWhiteSpace(txtGovTaxPercentage.Text) &&
                (!decimal.TryParse(txtGovTaxPercentage.Text.Trim(), out decimal epfPercentage) || epfPercentage < 0 || epfPercentage > 100))
            {
                ShowValidationError("Please enter a valid EPF Percentage (0-100).", txtGovTaxPercentage);
                return false;
            }

            // Date validation
            if (dtpDOB.Value > DateTime.Now.AddYears(-16))
            {
                ShowValidationError("Employee must be at least 16 years old.", dtpDOB);
                return false;
            }

            // Basic email validation
            if (!IsValidEmail(txtEmail.Text.Trim()))
            {
                ShowValidationError("Please enter a valid email address.", txtEmail);
                return false;
            }

            return true;
        }

        private bool ValidateEmployeeIdForUpdate()
        {
            if (string.IsNullOrWhiteSpace(txtEmpID.Text) || txtEmpID.Text == "Auto-generated")
            {
                MessageBox.Show("No employee selected for update/delete operation.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(txtEmpID.Text, out _))
            {
                MessageBox.Show("Invalid Employee ID format.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void ShowValidationError(string message, Control control)
        {
            MessageBox.Show(message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            control.Focus();
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        #endregion

        #region EPF Calculation

        private void CalculateEPF()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMonthlySalary.Text) || string.IsNullOrWhiteSpace(txtGovTaxPercentage.Text))
                {
                    MessageBox.Show("Please enter both Monthly Salary and EPF Percentage to calculate EPF.",
                        "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!decimal.TryParse(txtMonthlySalary.Text.Trim(), out decimal salary))
                {
                    MessageBox.Show("Please enter a valid Monthly Salary.", "Invalid Data",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!decimal.TryParse(txtGovTaxPercentage.Text.Trim(), out decimal epfPercentage))
                {
                    MessageBox.Show("Please enter a valid EPF Percentage.", "Invalid Data",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                decimal epfAmount = salary * (epfPercentage / 100);

                // Display EPF amount in the textbox
                SetEPFAmountText(epfAmount.ToString("F2"));

                string message = $"EPF Calculation:\n" +
                               $"Monthly Salary: LKR {salary:F2}\n" +
                               $"EPF Percentage: {epfPercentage}%\n" +
                               $"EPF Amount: LKR {epfAmount:F2}";

                // Save EPF amount to database if we have a valid employee ID
                if (!string.IsNullOrWhiteSpace(txtEmpID.Text) && txtEmpID.Text != "Auto-generated" &&
                    int.TryParse(txtEmpID.Text, out int employeeId))
                {
                    if (SaveEPFAmount(employeeId, epfAmount))
                    {
                        message += "\n\nEPF Amount has been saved to the database.";
                    }
                    else
                    {
                        message += "\n\nNote: EPF amount could not be saved to database.";
                    }
                }
                else
                {
                    message += "\n\nNote: EPF amount not saved - employee must be saved first.";
                }

                MessageBox.Show(message, "EPF Calculation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error calculating EPF: {ex.Message}", "Calculation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool SaveEPFAmount(int employeeId, decimal epfAmount)
        {
            try
            {
                string updateQuery = "UPDATE Employees SET EPFAmount = @EPFAmount WHERE EmployeeID = @EmployeeID";
                var parameters = new SqlParameter[]
                {
                    new SqlParameter("@EPFAmount", epfAmount),
                    new SqlParameter("@EmployeeID", employeeId)
                };

                int result = DatabaseHelper.ExecuteNonQuery(updateQuery, parameters);
                return result > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving EPF amount: {ex.Message}", "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static decimal GetEPFAmount(int employeeId)
        {
            try
            {
                string query = "SELECT EPFAmount FROM Employees WHERE EmployeeID = @EmployeeID";
                var parameters = new SqlParameter[]
                {
                    new SqlParameter("@EmployeeID", employeeId)
                };

                object result = DatabaseHelper.ExecuteScalar(query, parameters);

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

        #endregion

        #region Data Loading

        private void LoadEmployees()
        {
            try
            {
                // This method can be extended to populate a DataGridView or ComboBox
                // For now, it's a placeholder for future enhancements
                string countQuery = "SELECT COUNT(*) FROM Employees";
                object result = DatabaseHelper.ExecuteScalar(countQuery);
                int employeeCount = result != null && result != DBNull.Value ? Convert.ToInt32(result) : 0;

                // Could update a status label here if available
                // lblEmployeeCount.Text = $"Total Employees: {employeeCount}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading employees: {ex.Message}", "Load Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LoadEmployeesBasic()
        {
            // Simple version that doesn't show errors
            try
            {
                LoadEmployees();
            }
            catch
            {
                // Silently ignore errors during initial load
            }
        }

        private void LoadEmployeesSimple()
        {
            // Another alias for basic loading
            LoadEmployeesBasic();
        }

        #endregion

        #region Additional Event Handlers (for Designer compatibility)

        private void lnkViewAllEmployees_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                // Show all employees in the data grid
                string query = "SELECT EmployeeID, EmployeeCode, FirstName, LastName, Position, Email, Phone, IsActive FROM Employees ORDER BY EmployeeID";
                DataTable employees = DatabaseHelper.ExecuteQuery(query);

                if (employees.Rows.Count > 0)
                {
                    // If there's a DataGridView on the form, populate it
                    if (this.Controls.Find("dgvEmployees", true).FirstOrDefault() is DataGridView dgv)
                    {
                        dgv.DataSource = employees;
                        dgv.AutoResizeColumns();
                    }
                }
                else
                {
                    MessageBox.Show("No employees found in the database.", "No Data",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading employees: {ex.Message}", "Load Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvEmployees_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (sender is DataGridView dgv && e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgv.Rows[e.RowIndex];
                    if (row.Cells["EmployeeID"].Value != null)
                    {
                        string employeeId = row.Cells["EmployeeID"].Value.ToString();
                        txtEmpID.Text = employeeId;
                        SearchEmployee(); // This will load the full employee record
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading employee details: {ex.Message}", "Load Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            // Form load event - can be used for additional initialization
            try
            {
                // Ensure the form is properly initialized
                if (string.IsNullOrEmpty(txtEmpID.Text))
                {
                    InitializeForm();
                }

                // Initialize EPF amount field after form is fully loaded
                SetEPFAmountText("0.00");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during form load: {ex.Message}", "Initialization Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #endregion

        private void btnEPF_Click_1(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {

        }
    }
}
