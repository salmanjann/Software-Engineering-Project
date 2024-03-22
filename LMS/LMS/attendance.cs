using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using MySqlConnector;
namespace softwareengineering
{
    public partial class attendance : Form
    {
        public int UserID { get; }
        private const string connectionString = "server=localhost;port=3306;database=LMS;uid=root;password=idky;";
        public attendance(int userID)
        {
            InitializeComponent();
            UserID = userID;
            LoadRegisteredCourses();
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
        private void LoadRegisteredCourses()
        {
            string selectCommand = "SELECT courseID FROM registered_Courses WHERE Studentid = @USERID";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(selectCommand, connection))
                {
                    command.Parameters.AddWithValue("@USERID", UserID);
                    connection.Open();

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string courseID = reader["courseID"].ToString();
                            courses.Items.Add(courseID);
                        }
                    }
                }
            }
        }


        private void courses_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCourse = courses.SelectedItem.ToString();
            string selectAttendanceCommand = "SELECT lecture_no AS LectureNo, date_ AS Date, status AS Presence FROM attendance WHERE courseid = @CourseId AND studentid = @USERID";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(selectAttendanceCommand, connection))
                {
                    command.Parameters.AddWithValue("@CourseId", selectedCourse);
                    command.Parameters.AddWithValue("@USERID", UserID);
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
                            dataGridView1.Rows[rowIndex].Cells["lectureno"].Value = row["LectureNo"];
                            dataGridView1.Rows[rowIndex].Cells["date"].Value = row["Date"];
                            dataGridView1.Rows[rowIndex].Cells["presence"].Value = row["Presence"];
                        }
                    }
                }
            }
        }


        private void sidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            home h = new home(UserID);
            h.Show();

            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            courseregister courseregisterForm = new courseregister(UserID);

            courseregisterForm.Show();

            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
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
