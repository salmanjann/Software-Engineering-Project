using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;
namespace LMS
{
    public partial class Student : Form
    {
        private string connectionString;
        private MySqlConnection connection;
        private string username; // Variable to store username
        private string name;     // Variable to store name
        private string email;    // Variable to store email
        private string rollNo;
        public Student(string username, string name, string email, string rollNo)
        {
            InitializeComponent();
            connectionString = "server=localhost;port=3306;database=LMS;uid=root;password=idky;";
            connection = new MySqlConnection(connectionString);
            this.username = username; // Store the username
            this.name = name;         // Store the name
            this.email = email;       // Store the email
            this.rollNo = rollNo;       // Store the email

            //adminName.Text = name;
            //adminEmail.Text = email;
        }

        private void Student_Load(object sender, EventArgs e)
        {

        }
    }
}
