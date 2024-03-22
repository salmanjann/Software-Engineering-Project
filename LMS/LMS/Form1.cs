using MySqlConnector;
using softwareengineering;

//using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LMS
{
    public partial class Form1 : Form
    {
        private string connectionString;
        private MySqlConnection connection;
        public Form1()
        {
            InitializeComponent();
            connectionString = "server=localhost;port=3306;database=LMS;uid=root;password=idky;";

            connection = new MySqlConnection(connectionString);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void OpenNextForm(string userType, string username, string password)
        {
            // Fetch user information from the database based on user type
            string query;
            if (userType == "Student")
            {
                query = $"SELECT s.name, u.email, s.USERID " +
                        $"FROM Student s INNER JOIN User_ u ON s.USERID = u.USERID " +
                        $"WHERE u.USERNAME = @_username AND u.PASSWORD = @_password";
            }
            else
            {
                query = $"SELECT name, email FROM {userType} WHERE username = @_username AND password = @_password";
            }

            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@_username", username);
                command.Parameters.AddWithValue("@_password", password);

                try
                {
                    //connection.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string name = reader.GetString("name");
                            string email = reader.GetString("email");
                            int userID = userType == "Student" ? reader.GetInt32("USERID") : -1;

                            // Instantiate the appropriate form based on the user type and pass user information
                            Form nextForm = null;
                            switch (userType)
                            {
                                case "Admin":
                                    nextForm = new Admin(username, name, email);
                                    break;
                                case "Teacher":
                                    nextForm = new Teacher(username, name, email);
                                    break;
                                case "Student":
                                    nextForm = new home(userID);
                                    break;
                                default:
                                    MessageBox.Show("Invalid user type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                            }

                            // Show the next form and hide the current one
                            nextForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Retrieve values from textboxes and combobox
            string _username = username.Text;
            string _password = password.Text;
            string _userType = usertypes.SelectedItem?.ToString() ?? "DefaultUserType";

            if (string.IsNullOrEmpty(_username) || string.IsNullOrEmpty(_password) || string.IsNullOrEmpty(_userType))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Construct SQL query based on selected user type
            string tableName = "";
            switch (_userType)
            {
                case "Admin":
                    tableName = "ADMIN";
                    break;
                case "Teacher":
                    tableName = "TEACHER";
                    break;
                case "Student":
                    tableName = "STUDENT";
                    break;
                default:
                    MessageBox.Show("Invalid user type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }

            string query;
            if (_userType == "Student")
            {
                query = $"SELECT COUNT(*) " +
                        $"FROM STUDENT s INNER JOIN USER_ u ON s.USERID = u.USERID " +
                        $"WHERE u.USERNAME = @_username AND u.PASSWORD = @_password";
            }
            else
            {
                query = $"SELECT COUNT(*) FROM {tableName} WHERE username = @_username AND password = @_password";
            }


            // Create MySqlCommand object
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                // Add parameters
                command.Parameters.AddWithValue("@_username", _username);
                command.Parameters.AddWithValue("@_password", _password);

                try
                {
                    // Open the connection
                    connection.Open();

                    // Execute the command and check the result
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    if (count > 0)
                    {
                        OpenNextForm(_userType,_username,_password);
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
