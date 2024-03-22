using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySqlConnector;


namespace softwareengineering
{
    public partial class signup : Form
    {
        public signup()
        {
            InitializeComponent();
        }

        private void registerbutton_Click(object sender, EventArgs e)
        {
            string username = name.Text;
            string userPassword = password.Text;
            string userDob = dob.Text;
            string userPhone = phone.Text;
            string userEmail = email.Text;

            // Check if any field is empty
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(userPassword) ||
                string.IsNullOrEmpty(userDob) || string.IsNullOrEmpty(userPhone) || string.IsNullOrEmpty(userEmail))
            {
                MessageBox.Show("Please enter all credentials.");
                return;
            }

            // Create connection string
            string connectionString = "server=localhost;port=3306;database=LMS;uid=root;password=idky;";

            // MySql query to insert user details into the database
            string insertQuery = "INSERT INTO User_ (USERNAME, PASSWORD, DOB, PHONE, EMAIL) " +
                                 "VALUES (@Username, @Password, @Dob, @Phone, @Email); SELECT SCOPE_IDENTITY();";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                // Check if username already exists
                string checkUsernameQuery = "SELECT COUNT(*) FROM User_ WHERE USERNAME = @Username";
                using (MySqlCommand checkUsernameCmd = new MySqlCommand(checkUsernameQuery, conn))
                {
                    checkUsernameCmd.Parameters.AddWithValue("@Username", username);
                    int userCount = (int)checkUsernameCmd.ExecuteScalar();
                    if (userCount > 0)
                    {
                        MessageBox.Show("Username already exists. Please choose a different username.");
                        return;
                    }
                }

                // Insert user details into the database
                using (MySqlCommand insertCmd = new MySqlCommand(insertQuery, conn))
                {
                    insertCmd.Parameters.AddWithValue("@Username", username);
                    insertCmd.Parameters.AddWithValue("@Password", userPassword);
                    insertCmd.Parameters.AddWithValue("@Dob", userDob);
                    insertCmd.Parameters.AddWithValue("@Phone", userPhone);
                    insertCmd.Parameters.AddWithValue("@Email", userEmail);

                    // Execute the query and get the generated USERID
                    int userId = Convert.ToInt32(insertCmd.ExecuteScalar());

                    MessageBox.Show("Registration successful! Your USERID is: " + userId);
                }
            }
            login loginForm = new login();
            loginForm.Show();

            // Hide the current signup form
            this.Hide();
        }


        private void loginlink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            login lg = new login();

            
            lg.Show();

            
            this.Hide();
        }

        
    }
}
