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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }







        private void loginbutton_Click(object sender, EventArgs e)
        {
            string loginuemail = email.Text;
            string loginpassword = password.Text;

            if (string.IsNullOrEmpty(loginuemail) || string.IsNullOrEmpty(loginpassword))
            {
                MessageBox.Show("Sorry, please enter both username and password.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection("server=localhost;port=3306;database=LMS;uid=root;password=idky;"))
            {
                conn.Open();
                string query = "SELECT * FROM User_ WHERE EMAIL = @Email AND PASSWORD = @Password";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Email", loginuemail);
                    cmd.Parameters.AddWithValue("@Password", loginpassword);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        // Get the UserID from the MySqlDataReader
                        int userID = Convert.ToInt32(dr["USERID"]);

                        // Instantiate the new form
                        home homeForm = new home(userID);

                        // Show the new form
                        homeForm.Show();

                        // Optionally, you can hide the current form if needed
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Sorry, login was not successful.");
                    }
                }
            }
        }


        private void registerlink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            signup s = new signup();

            // Show the courseregister form
            s.Show();

            // Optionally, you can hide the current form if needed
            this.Hide();
        }
    }
}
