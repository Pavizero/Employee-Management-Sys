using System;
using System.Data;
using System.Windows.Forms;

namespace EMS
{
    public partial class UserManagementForm : Form
    {
        private DataTable userDataTable;

        public UserManagementForm()
        {
            InitializeComponent();
            LoadUsers();
        }

        private void LoadUsers()
        {
            try
            {
                string query = "SELECT UserID, Username, FullName, Email, Role, IsActive FROM Users ORDER BY Username";
                userDataTable = DatabaseHelper.ExecuteQuery(query);
                dataGridViewUsers.DataSource = userDataTable;
                dataGridViewUsers.Columns["UserID"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading users: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ClearForm();
            EnableForm(true);
            txtUsername.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridViewUsers.SelectedRows[0];
                txtUserID.Text = row.Cells["UserID"].Value.ToString();
                txtUsername.Text = row.Cells["Username"].Value.ToString();
                txtFullName.Text = row.Cells["FullName"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtPassword.Text = ""; // Don't show password
                cmbRole.Text = row.Cells["Role"].Value.ToString();
                chkIsActive.Checked = Convert.ToBoolean(row.Cells["IsActive"].Value);
                
                EnableForm(true);
                txtUsername.Enabled = false; // Don't allow username change
            }
            else
            {
                MessageBox.Show("Please select a user to edit.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this user?", "Confirm Delete", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int userID = Convert.ToInt32(dataGridViewUsers.SelectedRows[0].Cells["UserID"].Value);
                    string query = $"DELETE FROM Users WHERE UserID = {userID}";
                    
                    if (DatabaseHelper.ExecuteNonQuery(query) > 0)
                    {
                        MessageBox.Show("User deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadUsers();
                        ClearForm();
                        EnableForm(false);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a user to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                try
                {
                    string query;
                    if (string.IsNullOrEmpty(txtUserID.Text)) // New user
                    {
                        query = $"INSERT INTO Users (Username, Password, FullName, Email, Role, IsActive) " +
                                $"VALUES ('{txtUsername.Text.Trim()}', '{txtPassword.Text.Trim()}', " +
                                $"'{txtFullName.Text.Trim()}', '{txtEmail.Text.Trim()}', " +
                                $"'{cmbRole.Text}', {(chkIsActive.Checked ? "1" : "0")})";
                    }
                    else // Update existing user
                    {
                        string passwordUpdate = string.IsNullOrEmpty(txtPassword.Text) ? "" : 
                            $", Password = '{txtPassword.Text.Trim()}'";
                        
                        query = $"UPDATE Users SET FullName = '{txtFullName.Text.Trim()}', " +
                                $"Email = '{txtEmail.Text.Trim()}', Role = '{cmbRole.Text}', " +
                                $"IsActive = {(chkIsActive.Checked ? "1" : "0")}{passwordUpdate} " +
                                $"WHERE UserID = {txtUserID.Text}";
                    }

                    if (DatabaseHelper.ExecuteNonQuery(query) > 0)
                    {
                        MessageBox.Show("User saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadUsers();
                        ClearForm();
                        EnableForm(false);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error saving user: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearForm();
            EnableForm(false);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrEmpty(txtUsername.Text.Trim()))
            {
                MessageBox.Show("Username is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtFullName.Text.Trim()))
            {
                MessageBox.Show("Full Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFullName.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtEmail.Text.Trim()))
            {
                MessageBox.Show("Email is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(cmbRole.Text))
            {
                MessageBox.Show("Role is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbRole.Focus();
                return false;
            }

            // For new users, password is required
            if (string.IsNullOrEmpty(txtUserID.Text) && string.IsNullOrEmpty(txtPassword.Text.Trim()))
            {
                MessageBox.Show("Password is required for new users.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return false;
            }

            return true;
        }

        private void ClearForm()
        {
            txtUserID.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtFullName.Text = "";
            txtEmail.Text = "";
            cmbRole.Text = "";
            chkIsActive.Checked = true;
        }

        private void EnableForm(bool enable)
        {
            txtUsername.Enabled = enable;
            txtPassword.Enabled = enable;
            txtFullName.Enabled = enable;
            txtEmail.Enabled = enable;
            cmbRole.Enabled = enable;
            chkIsActive.Enabled = enable;
            btnSave.Enabled = enable;
            btnCancel.Enabled = enable;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewUsers_SelectionChanged(object sender, EventArgs e)
        {
            // Optional: Auto-populate form when user selects a row
            if (dataGridViewUsers.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridViewUsers.SelectedRows[0];
                txtUserID.Text = row.Cells["UserID"].Value.ToString();
                txtUsername.Text = row.Cells["Username"].Value.ToString();
                txtFullName.Text = row.Cells["FullName"].Value?.ToString() ?? "";
                txtEmail.Text = row.Cells["Email"].Value?.ToString() ?? "";
                txtPassword.Text = ""; // Don't show password
                cmbRole.Text = row.Cells["Role"].Value?.ToString() ?? "User";
                chkIsActive.Checked = Convert.ToBoolean(row.Cells["IsActive"].Value ?? false);
            }
        }

        private void UserManagementForm_Load(object sender, EventArgs e)
        {
            cmbRole.Items.AddRange(new string[] { "Admin", "Manager", "Employee" });
            EnableForm(false);
        }
    }
}
