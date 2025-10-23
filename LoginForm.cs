using System;
using System.Data;
using System.Windows.Forms;

namespace EMS
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Validation Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ValidateUser(username, password))
            {
                this.Hide();
                MainMenuForm mainMenu = new MainMenuForm();
                mainMenu.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Failed", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Clear();
                txtPassword.Focus();
            }
        }

        private bool ValidateUser(string username, string password)
        {
            try
            {
                string query = $"SELECT COUNT(*) FROM Users WHERE Username = '{username}' AND Password = '{password}'";
                object result = DatabaseHelper.ExecuteScalar(query);
                return result != null && Convert.ToInt32(result) > 0;
            }
            catch
            {
                return false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {

        }
    }
}
