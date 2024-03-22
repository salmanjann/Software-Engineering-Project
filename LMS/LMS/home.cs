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
    public partial class home : Form
    {
        bool sidebarExpand;
        public int UserID { get; }
        private const string connectionString = "server=localhost;port=3306;database=LMS;uid=root;password=idky;";

        public home(int userID)
        {
            InitializeComponent();
            UserID = userID; // Assign the parameter value to the UserID property
            LoadStudentData();
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
        private void LoadStudentData()
        {
             string selectCommand = @"SELECT s.NAME, u.EMAIL, u.PHONE, s.DEGREE, s.BATCH, s.DEPT 
                  FROM User_ u 
                     JOIN Student s ON u.USERID = s.USERID 
                    WHERE u.USERID = @UserID
                                   ";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(selectCommand, connection))
                {
                    command.Parameters.AddWithValue("@UserID", UserID);
                    connection.Open();

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Set text box values with student information
                            name.Text = reader["NAME"].ToString();
                            email.Text = reader["EMAIL"].ToString();
                            phone.Text = reader["PHONE"].ToString();
                            degree.Text = reader["DEGREE"].ToString();
                            section.Text = reader["BATCH"].ToString();
                            adress.Text = reader["DEPT"].ToString();
                        }
                    }
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            home h = new home(UserID);
            h.Show();

            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void sidebartimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width <= 0) // Check if sidebar has collapsed
                {
                    sidebarExpand = false;
                    sidebartimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width >= sidebar.MaximumSize.Width) // Check if sidebar has expanded
                {
                    sidebarExpand = true;
                    sidebartimer.Stop();
                }
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

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
        private void announcement_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}
