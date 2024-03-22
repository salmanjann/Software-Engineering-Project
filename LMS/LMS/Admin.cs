using System;
using System.Windows.Forms;
using MySqlConnector;

namespace LMS
{
    public partial class Admin : Form
    {
        private string connectionString;
        private MySqlConnection connection;
        private string username; // Variable to store username
        private string name;     // Variable to store name
        private string email;    // Variable to store email

        public Admin(string username, string name, string email)
        {
            InitializeComponent();
            OfferCoursePanel.Visible = false;
            DashboardPanel.Visible = true;
            AssignCoursePanel.Visible = false;
            viewStudentsPanel.Visible = false;
            connectionString = "server=localhost;port=3306;database=LMS;uid=root;password=idky;";
            connection = new MySqlConnection(connectionString);
            this.username = username; // Store the username
            this.name = name;         // Store the name
            this.email = email;       // Store the email

            adminName.Text = name;
            adminEmail.Text = email;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OfferCoursePanel.Visible = false;
            DashboardPanel.Visible = true;
            AssignCoursePanel.Visible = false;
            viewStudentsPanel.Visible = false;

        }

        private void OfferCourse_Click(object sender, EventArgs e)
        {
            OfferCoursePanel.Visible = true;
            DashboardPanel.Visible = false;
            AssignCoursePanel.Visible = false;
            viewStudentsPanel.Visible = false;

        }

        private void Offer_Click(object sender, EventArgs e)
        {
            // Retrieve values from textboxes and combobox
            string courseId = CourseID.Text;
            string courseName = CourseName.Text;
            string courseDescription = CourseDescription.Text;

            if (string.IsNullOrEmpty(courseId) || string.IsNullOrEmpty(courseName) || string.IsNullOrEmpty(courseDescription))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if the courseId or courseName already exist in the Course table
            string query = "SELECT COUNT(*) FROM Course WHERE courseId = @courseId OR courseName = @courseName";
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@courseId", courseId);
                command.Parameters.AddWithValue("@courseName", courseName);

                try
                {
                    connection.Open();
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    if (count > 0)
                    {
                        // Course with the same courseId or courseName already exists
                        MessageBox.Show("Course with the same courseId or courseName already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        // Course doesn't exist, insert the new course into the Course table
                        query = "INSERT INTO Course (courseId, courseName, courseDescription) VALUES (@courseId, @courseName, @courseDescription)";
                        command.CommandText = query;
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("@courseId", courseId);
                        command.Parameters.AddWithValue("@courseName", courseName);
                        command.Parameters.AddWithValue("@courseDescription", courseDescription);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            // Insert a new entry into the courseSection table for the newly added course
                            InsertCourseSection(courseName);

                            MessageBox.Show("Course added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CourseID.Text = "";
                            CourseName.Text = "";
                            CourseDescription.Text = "";
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Failed to add course.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void InsertCourseSection(string courseName)
        {
            // Insert a new entry into the courseSection table for the newly added course
            string insertQuery = "INSERT INTO courseSection (sectionName, courseName) VALUES (@sectionName, @courseName)";
            using (MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection))
            {
                insertCommand.Parameters.AddWithValue("@sectionName", "A"); // Set the initial sectionName to 'A'
                insertCommand.Parameters.AddWithValue("@courseName", courseName);

                try
                {
                    //connection.Open();
                    insertCommand.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error inserting into courseSection table: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void AssignCourse_Click(object sender, EventArgs e)
        {
            OfferCoursePanel.Visible = false;
            DashboardPanel.Visible = false;
            AssignCoursePanel.Visible = true;
            viewStudentsPanel.Visible = false;

            LoadCourseNames();
        }

        private void LoadCourseNames()
        {
            CourseNames.Items.Clear();
            using (MySqlCommand command = new MySqlCommand("SELECT DISTINCT courseName FROM courseSection WHERE teacherName IS NULL", connection))
            {
                try
                {
                    connection.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            CourseNames.Items.Add(reader["courseName"].ToString());
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error loading course names: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void LoadCourseSections(string courseName)
        {
            CourseSection.Items.Clear();
            using (MySqlCommand command = new MySqlCommand("SELECT DISTINCT sectionName FROM courseSection WHERE teacherName IS NULL AND courseName = @courseName", connection))
            {
                command.Parameters.AddWithValue("@courseName", courseName);
                try
                {
                    connection.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            CourseSection.Items.Add(reader["sectionName"].ToString());
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error loading course sections: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }
        }


        private void Admin_Load(object sender, EventArgs e)
        {
            LoadTeachers();
        }

        private void LoadTeachers()
        {
            CourseTeacher.Items.Clear();
            using (MySqlCommand command = new MySqlCommand("SELECT name FROM Teacher", connection))
            {
                try
                {
                    connection.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            CourseTeacher.Items.Add(reader["name"].ToString());
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error loading teachers: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void AssignTeacher_Click(object sender, EventArgs e)
        {
            if (CourseNames.SelectedItem != null && CourseSection.SelectedItem != null && CourseTeacher.SelectedItem != null)
            {
                string courseName = CourseNames.SelectedItem.ToString();
                string sectionName = CourseSection.SelectedItem.ToString();
                string teacherName = CourseTeacher.SelectedItem.ToString();

                // Update the teacher in the courseSection table
                string updateQuery = "UPDATE courseSection SET teacherName = @teacherName WHERE courseName = @courseName AND sectionName = @sectionName";
                using (MySqlCommand updateCommand = new MySqlCommand(updateQuery, connection))
                {
                    updateCommand.Parameters.AddWithValue("@teacherName", teacherName);
                    updateCommand.Parameters.AddWithValue("@courseName", courseName);
                    updateCommand.Parameters.AddWithValue("@sectionName", sectionName);

                    try
                    {
                        connection.Open();
                        int rowsAffected = updateCommand.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Teacher assigned successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Failed to assign teacher.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Error assigning teacher: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select course, section, and teacher.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CourseNames_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (CourseNames.SelectedItem != null)
            {
                LoadCourseSections(CourseNames.SelectedItem.ToString());
            }
        }

        private void viewStudents_Click(object sender, EventArgs e)
        {
            OfferCoursePanel.Visible = false;
            DashboardPanel.Visible = false;
            AssignCoursePanel.Visible = false;
            viewStudentsPanel.Visible = true;
            LoadCourseNames2();
        }

        private void LoadCourseNames2()
        {
            CourseNamess.Items.Clear();
            using (MySqlCommand command = new MySqlCommand("SELECT DISTINCT courseName FROM REGISTERED_STUDENTS", connection))
            {
                try
                {
                    connection.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            CourseNamess.Items.Add(reader["courseName"].ToString());
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error loading course names: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void viewStudentsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CourseNamess_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CourseNamess.SelectedItem != null)
            {
                LoadCourseSections2(CourseNamess.SelectedItem.ToString());
            }
        }
        private void LoadCourseSections2(string courseName)
        {
            CourseSections.Items.Clear();
            using (MySqlCommand command = new MySqlCommand("SELECT DISTINCT sectionName FROM REGISTERED_STUDENTS WHERE courseName = @courseName", connection))
            {
                command.Parameters.AddWithValue("@courseName", courseName);
                try
                {
                    connection.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            CourseSections.Items.Add(reader["sectionName"].ToString());
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error loading course sections: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        private void LoadRegisteredStudents(string courseName, string sectionName)
        {
            studentList.Rows.Clear(); // Clear existing rows in the DataGridView
            using (MySqlCommand command = new MySqlCommand("SELECT studentRollNo FROM REGISTERED_STUDENTS WHERE courseName = @courseName AND sectionName = @sectionName", connection))
            {
                command.Parameters.AddWithValue("@courseName", courseName);
                command.Parameters.AddWithValue("@sectionName", sectionName);
                try
                {
                    connection.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Add a row to the DataGridView with the student details
                            studentList.Rows.Add(reader["studentRollNo"]);
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error loading registered students: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        private void CourseSections_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CourseNamess.SelectedItem != null && CourseSections.SelectedItem != null)
            {
                string courseName = CourseNamess.SelectedItem.ToString();
                string sectionName = CourseSections.SelectedItem.ToString();
                LoadRegisteredStudents(courseName, sectionName);
            }
        }
    }
}
