using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using MySqlConnector;
namespace softwareengineering
{
    public partial class courseregister : Form

    {
        public int UserID { get; }
        private const string connectionString = "server=localhost;port=3306;database=LMS;uid=root;password=idky;";

        public courseregister(int userID)
        {
            InitializeComponent();
            UserID = userID;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView1.ReadOnly = true;
            LoadData(); // Call the method to load data into DataGridView
            LoadStudentName();
        }
        
        private void LoadStudentName()
        {
            string selectCommand = @"SELECT NAME
                             FROM Student
                             WHERE USERID = @UserID";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(selectCommand, connection))
                {
                    command.Parameters.AddWithValue("@UserID", UserID);
                    connection.Open();

                    string userName = (string)command.ExecuteScalar();
                    user.Text = userName;
                }
            }
        }
        private void LoadData()
        {
            string selectCommand = "SELECT courseid, cname FROM offered_course";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(selectCommand, connection))
                {
                    connection.Open();

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        // Clear existing data in DataGridView
                        dataGridView1.Rows.Clear();

                        // Populate existing columns with retrieved data
                        foreach (DataRow row in dt.Rows)
                        {
                            int rowIndex = dataGridView1.Rows.Add();
                            dataGridView1.Rows[rowIndex].Cells["courseid"].Value = row["courseid"];
                            dataGridView1.Rows[rowIndex].Cells["cname"].Value = row["cname"];

                            // Add a new column for registering courses (checkbox)
                            DataGridViewCheckBoxCell checkboxCell = new DataGridViewCheckBoxCell();
                            dataGridView1.Rows[rowIndex].Cells["register"] = checkboxCell;
                            checkboxCell.Value = false; // Initialize checkbox to unchecked
                        }
                    }
                }
            }
        }
       
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is in the "Register" column
            if (dataGridView1.Columns[e.ColumnIndex].Name == "register" && e.RowIndex >= 0)
            {
                DataGridViewCheckBoxCell checkboxCell = (DataGridViewCheckBoxCell)dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];

                // Toggle checkbox value
                checkboxCell.Value = !(bool)checkboxCell.Value;

                // Count the number of checkboxes checked
                int checkedCount = 0;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["register"].Value != null && (bool)row.Cells["register"].Value)
                    {
                        checkedCount++;
                    }
                }

                // If more than 5 checkboxes are checked, uncheck the clicked checkbox
                if (checkedCount > 5)
                {
                    checkboxCell.Value = false;
                    MessageBox.Show("You can only select up to 5 courses.");
                }
            }
        }

        private void registerbutton_Click(object sender, EventArgs e)
        {
            // Iterate through the DataGridView rows
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // Check if the "Register" checkbox is checked for the current row
                DataGridViewCheckBoxCell checkboxCell = row.Cells["register"] as DataGridViewCheckBoxCell;
                if (checkboxCell != null && (bool)checkboxCell.Value)
                {
                    // Get the course ID from the DataGridView
                    string courseID = row.Cells["courseid"].Value.ToString();

                    // Save the selected course to the registered_Courses table
                    SaveRegisteredCourse(courseID);

                    // Optionally, you can update the DataGridView to reflect the registration status
                    checkboxCell.Value = false; // Reset the checkbox after registration
                }
            }
            dataGridView1.Visible = false;
            // Show a message indicating successful course registration
            MessageBox.Show("Courses registered successfully!");
        }

        private void SaveRegisteredCourse(string courseID)
        {
            string insertCommand = "INSERT INTO registered_Courses (courseID, StudentID, RegisterCourse) VALUES (@CourseID, @StudentID, 'Yes')";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(insertCommand, connection))
                {
                    command.Parameters.AddWithValue("@CourseID", courseID);
                    command.Parameters.AddWithValue("@StudentID", UserID);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            home h = new home(UserID);
            h.Show();

            this.Hide();
        }
        private void coursebutton_Click(object sender, EventArgs e)
        {
            courseregister courseregisterForm = new courseregister(UserID);

            courseregisterForm.Show();

            this.Hide();
        }

        private void attendance_Click(object sender, EventArgs e)
        {
            attendance a = new attendance(UserID);
            a.Show();
            this.Hide();
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            login lg = new login();


            lg.Show();


            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
                courseregister courseregisterForm = new courseregister(UserID);

                courseregisterForm.Show();

                this.Hide();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
           

            
                attendance a = new attendance(UserID);
                a.Show();
                this.Hide();
            
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
                login lg = new login();


                lg.Show();


                this.Hide();
            
        }
    }

}