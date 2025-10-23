using System;
using System.Data;
using System.Windows.Forms;

namespace EMS
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            LoadCurrentSettings();
        }

        private void LoadCurrentSettings()
        {
            try
            {
                // Load current settings from database or use defaults
                string query = "SELECT TOP 1 * FROM SystemSettings";
                DataTable dt = DatabaseHelper.ExecuteQuery(query);
                
                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    
                    if (row["StartDate"] != DBNull.Value)
                        dtpStartDate.Value = Convert.ToDateTime(row["StartDate"]);
                    if (row["EndDate"] != DBNull.Value)
                        dtpEndDate.Value = Convert.ToDateTime(row["EndDate"]);
                    if (row["LeavesPerYear"] != DBNull.Value)
                        txtLeavesPerYear.Text = row["LeavesPerYear"].ToString();
                    if (row["CycleDateRange"] != DBNull.Value)
                        txtCycleDateRange.Text = row["CycleDateRange"].ToString();
                }
                else
                {
                    // Set default values
                    dtpStartDate.Value = DateTime.Now.AddMonths(-1);
                    dtpEndDate.Value = DateTime.Now;
                    txtLeavesPerYear.Text = "25";
                    txtCycleDateRange.Text = "Monthly";
                }

                // Load company information with defaults
                txtCompanyName.Text = "Your Company Name";
                txtCompanyAddress.Text = "123 Business Street\nCity, State 12345";
                txtCompanyPhone.Text = "+1 (555) 123-4567";
                txtCompanyEmail.Text = "info@yourcompany.com";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading settings: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                // Set default values if database error occurs
                dtpStartDate.Value = DateTime.Now.AddMonths(-1);
                dtpEndDate.Value = DateTime.Now;
                txtLeavesPerYear.Text = "25";
                txtCycleDateRange.Text = "Monthly";
                
                // Default company info
                txtCompanyName.Text = "Your Company Name";
                txtCompanyAddress.Text = "123 Business Street\nCity, State 12345";
                txtCompanyPhone.Text = "+1 (555) 123-4567";
                txtCompanyEmail.Text = "info@yourcompany.com";
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateForm())
                {
                    // Check if settings exist, if not create them
                    string checkQuery = "SELECT COUNT(*) FROM SystemSettings";
                    int count = Convert.ToInt32(DatabaseHelper.ExecuteScalar(checkQuery));
                    
                    string query;
                    if (count > 0)
                    {
                        // Update existing settings
                        query = $@"UPDATE SystemSettings SET 
                                  StartDate = '{dtpStartDate.Value:yyyy-MM-dd}',
                                  EndDate = '{dtpEndDate.Value:yyyy-MM-dd}',
                                  LeavesPerYear = {txtLeavesPerYear.Text},
                                  CycleDateRange = '{txtCycleDateRange.Text}',
                                  LastUpdated = GETDATE()";
                    }
                    else
                    {
                        // Insert new settings
                        query = $@"INSERT INTO SystemSettings (StartDate, EndDate, LeavesPerYear, CycleDateRange, LastUpdated)
                                  VALUES ('{dtpStartDate.Value:yyyy-MM-dd}', '{dtpEndDate.Value:yyyy-MM-dd}', 
                                          {txtLeavesPerYear.Text}, '{txtCycleDateRange.Text}', GETDATE())";
                    }

                    int result = DatabaseHelper.ExecuteNonQuery(query);
                    
                    if (result > 0)
                    {
                        MessageBox.Show("Settings updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed to update settings.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating settings: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateForm()
        {
            if (dtpStartDate.Value >= dtpEndDate.Value)
            {
                MessageBox.Show("Start Date must be before End Date.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpStartDate.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtLeavesPerYear.Text))
            {
                MessageBox.Show("Leaves Per Year is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLeavesPerYear.Focus();
                return false;
            }

            if (!int.TryParse(txtLeavesPerYear.Text, out int leaves) || leaves < 0 || leaves > 365)
            {
                MessageBox.Show("Leaves Per Year must be a valid number between 0 and 365.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLeavesPerYear.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCycleDateRange.Text))
            {
                MessageBox.Show("Cycle Date Range is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCycleDateRange.Focus();
                return false;
            }

            return true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateForm() && ValidateCompanyInfo())
                {
                    // Save both system and company settings
                    btnUpdate_Click(sender, e); // Save system settings
                    
                    MessageBox.Show("All settings saved successfully!", "Success", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving settings: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show(
                    "Are you sure you want to reset all settings to default values?", 
                    "Reset Settings", 
                    MessageBoxButtons.YesNo, 
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Reset to default values
                    dtpStartDate.Value = DateTime.Now.AddMonths(-1);
                    dtpEndDate.Value = DateTime.Now;
                    txtLeavesPerYear.Text = "25";
                    txtCycleDateRange.Text = "Monthly";
                    
                    // Reset company info
                    txtCompanyName.Text = "Your Company Name";
                    txtCompanyAddress.Text = "123 Business Street\nCity, State 12345";
                    txtCompanyPhone.Text = "+1 (555) 123-4567";
                    txtCompanyEmail.Text = "info@yourcompany.com";
                    
                    MessageBox.Show("Settings have been reset to default values.", "Reset Complete", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error resetting settings: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateCompanyInfo()
        {
            if (string.IsNullOrWhiteSpace(txtCompanyName.Text))
            {
                MessageBox.Show("Company Name is required.", "Validation", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCompanyName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCompanyEmail.Text))
            {
                MessageBox.Show("Company Email is required.", "Validation", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCompanyEmail.Focus();
                return false;
            }

            // Basic email validation
            if (!txtCompanyEmail.Text.Contains("@") || !txtCompanyEmail.Text.Contains("."))
            {
                MessageBox.Show("Please enter a valid email address.", "Validation", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCompanyEmail.Focus();
                return false;
            }

            return true;
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            // Form load event - already handled in constructor
        }
    }
}
