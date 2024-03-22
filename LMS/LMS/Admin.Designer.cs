namespace LMS
{
    partial class Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            viewStudents = new Button();
            AssignCourse = new Button();
            OfferCourse = new Button();
            Dashboard = new Button();
            AdminDashboard = new Label();
            OfferCoursePanel = new Panel();
            Offer = new Button();
            CourseDescription = new TextBox();
            label4 = new Label();
            CourseName = new TextBox();
            label3 = new Label();
            CourseID = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            label6 = new Label();
            adminName = new Label();
            adminEmail = new Label();
            DashboardPanel = new Panel();
            AssignCoursePanel = new Panel();
            AssignTeacher = new Button();
            CourseTeacher = new ComboBox();
            CourseSection = new ComboBox();
            CourseNames = new ComboBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            AssignCourseLabel = new Label();
            viewStudentsPanel = new Panel();
            studentList = new DataGridView();
            RollNos = new DataGridViewTextBoxColumn();
            CourseSections = new ComboBox();
            label12 = new Label();
            CourseNamess = new ComboBox();
            label11 = new Label();
            label10 = new Label();
            panel1.SuspendLayout();
            OfferCoursePanel.SuspendLayout();
            DashboardPanel.SuspendLayout();
            AssignCoursePanel.SuspendLayout();
            viewStudentsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)studentList).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(116, 86, 174);
            panel1.Controls.Add(viewStudents);
            panel1.Controls.Add(AssignCourse);
            panel1.Controls.Add(OfferCourse);
            panel1.Controls.Add(Dashboard);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(271, 565);
            panel1.TabIndex = 0;
            // 
            // viewStudents
            // 
            viewStudents.BackColor = Color.FromArgb(116, 86, 174);
            viewStudents.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            viewStudents.ForeColor = Color.White;
            viewStudents.Location = new Point(32, 356);
            viewStudents.Margin = new Padding(3, 2, 3, 2);
            viewStudents.Name = "viewStudents";
            viewStudents.Size = new Size(167, 40);
            viewStudents.TabIndex = 3;
            viewStudents.Text = "View Students";
            viewStudents.UseVisualStyleBackColor = false;
            viewStudents.Click += viewStudents_Click;
            // 
            // AssignCourse
            // 
            AssignCourse.BackColor = Color.FromArgb(116, 86, 174);
            AssignCourse.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AssignCourse.ForeColor = Color.White;
            AssignCourse.Location = new Point(32, 275);
            AssignCourse.Margin = new Padding(3, 2, 3, 2);
            AssignCourse.Name = "AssignCourse";
            AssignCourse.Size = new Size(167, 40);
            AssignCourse.TabIndex = 2;
            AssignCourse.Text = "Assign Course";
            AssignCourse.UseVisualStyleBackColor = false;
            AssignCourse.Click += AssignCourse_Click;
            // 
            // OfferCourse
            // 
            OfferCourse.BackColor = Color.FromArgb(116, 86, 174);
            OfferCourse.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            OfferCourse.ForeColor = Color.White;
            OfferCourse.Location = new Point(32, 190);
            OfferCourse.Margin = new Padding(3, 2, 3, 2);
            OfferCourse.Name = "OfferCourse";
            OfferCourse.Size = new Size(167, 40);
            OfferCourse.TabIndex = 1;
            OfferCourse.Text = "Offer Course";
            OfferCourse.UseVisualStyleBackColor = false;
            OfferCourse.Click += OfferCourse_Click;
            // 
            // Dashboard
            // 
            Dashboard.BackColor = Color.FromArgb(116, 86, 174);
            Dashboard.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Dashboard.ForeColor = Color.White;
            Dashboard.Location = new Point(32, 117);
            Dashboard.Margin = new Padding(3, 2, 3, 2);
            Dashboard.Name = "Dashboard";
            Dashboard.Size = new Size(167, 40);
            Dashboard.TabIndex = 0;
            Dashboard.Text = "Dashboard";
            Dashboard.UseVisualStyleBackColor = false;
            Dashboard.Click += button1_Click;
            // 
            // AdminDashboard
            // 
            AdminDashboard.AutoSize = true;
            AdminDashboard.Font = new Font("Bodoni MT Condensed", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AdminDashboard.ForeColor = Color.FromArgb(116, 86, 174);
            AdminDashboard.Location = new Point(228, 34);
            AdminDashboard.Name = "AdminDashboard";
            AdminDashboard.Size = new Size(261, 56);
            AdminDashboard.TabIndex = 1;
            AdminDashboard.Text = "Admin Dashboard";
            // 
            // OfferCoursePanel
            // 
            OfferCoursePanel.BackColor = Color.White;
            OfferCoursePanel.Controls.Add(Offer);
            OfferCoursePanel.Controls.Add(CourseDescription);
            OfferCoursePanel.Controls.Add(label4);
            OfferCoursePanel.Controls.Add(CourseName);
            OfferCoursePanel.Controls.Add(label3);
            OfferCoursePanel.Controls.Add(CourseID);
            OfferCoursePanel.Controls.Add(label2);
            OfferCoursePanel.Controls.Add(label1);
            OfferCoursePanel.Dock = DockStyle.Fill;
            OfferCoursePanel.Location = new Point(271, 0);
            OfferCoursePanel.Margin = new Padding(3, 2, 3, 2);
            OfferCoursePanel.Name = "OfferCoursePanel";
            OfferCoursePanel.Size = new Size(763, 565);
            OfferCoursePanel.TabIndex = 2;
            OfferCoursePanel.Visible = false;
            // 
            // Offer
            // 
            Offer.BackColor = Color.FromArgb(116, 86, 174);
            Offer.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Offer.ForeColor = Color.White;
            Offer.Location = new Point(107, 421);
            Offer.Margin = new Padding(3, 2, 3, 2);
            Offer.Name = "Offer";
            Offer.Size = new Size(463, 40);
            Offer.TabIndex = 7;
            Offer.Text = "Offer";
            Offer.UseVisualStyleBackColor = false;
            Offer.Click += Offer_Click;
            // 
            // CourseDescription
            // 
            CourseDescription.Location = new Point(360, 304);
            CourseDescription.Margin = new Padding(3, 2, 3, 2);
            CourseDescription.Multiline = true;
            CourseDescription.Name = "CourseDescription";
            CourseDescription.Size = new Size(210, 77);
            CourseDescription.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(107, 296);
            label4.Name = "label4";
            label4.Size = new Size(235, 32);
            label4.TabIndex = 5;
            label4.Text = "Course Description : ";
            // 
            // CourseName
            // 
            CourseName.Location = new Point(308, 228);
            CourseName.Margin = new Padding(3, 2, 3, 2);
            CourseName.Name = "CourseName";
            CourseName.Size = new Size(262, 23);
            CourseName.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(107, 218);
            label3.Name = "label3";
            label3.Size = new Size(178, 32);
            label3.TabIndex = 3;
            label3.Text = "Course Name : ";
            // 
            // CourseID
            // 
            CourseID.Location = new Point(308, 159);
            CourseID.Margin = new Padding(3, 2, 3, 2);
            CourseID.Name = "CourseID";
            CourseID.Size = new Size(262, 23);
            CourseID.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(107, 148);
            label2.Name = "label2";
            label2.Size = new Size(137, 32);
            label2.TabIndex = 1;
            label2.Text = "Course ID : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bodoni MT", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(116, 86, 174);
            label1.Location = new Point(240, 45);
            label1.Name = "label1";
            label1.Size = new Size(275, 56);
            label1.TabIndex = 0;
            label1.Text = "Offer Course";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(88, 126);
            label5.Name = "label5";
            label5.Size = new Size(74, 25);
            label5.TabIndex = 3;
            label5.Text = "Name :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(88, 200);
            label6.Name = "label6";
            label6.Size = new Size(69, 25);
            label6.TabIndex = 4;
            label6.Text = "Email :";
            // 
            // adminName
            // 
            adminName.AutoSize = true;
            adminName.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            adminName.Location = new Point(178, 128);
            adminName.Name = "adminName";
            adminName.Size = new Size(0, 23);
            adminName.TabIndex = 5;
            // 
            // adminEmail
            // 
            adminEmail.AutoSize = true;
            adminEmail.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            adminEmail.Location = new Point(178, 202);
            adminEmail.Name = "adminEmail";
            adminEmail.Size = new Size(0, 23);
            adminEmail.TabIndex = 6;
            // 
            // DashboardPanel
            // 
            DashboardPanel.BackColor = Color.White;
            DashboardPanel.Controls.Add(adminEmail);
            DashboardPanel.Controls.Add(AdminDashboard);
            DashboardPanel.Controls.Add(label5);
            DashboardPanel.Controls.Add(label6);
            DashboardPanel.Controls.Add(adminName);
            DashboardPanel.Dock = DockStyle.Fill;
            DashboardPanel.ForeColor = Color.Black;
            DashboardPanel.Location = new Point(271, 0);
            DashboardPanel.Margin = new Padding(3, 2, 3, 2);
            DashboardPanel.Name = "DashboardPanel";
            DashboardPanel.Size = new Size(763, 565);
            DashboardPanel.TabIndex = 3;
            // 
            // AssignCoursePanel
            // 
            AssignCoursePanel.BackColor = Color.White;
            AssignCoursePanel.Controls.Add(AssignTeacher);
            AssignCoursePanel.Controls.Add(CourseTeacher);
            AssignCoursePanel.Controls.Add(CourseSection);
            AssignCoursePanel.Controls.Add(CourseNames);
            AssignCoursePanel.Controls.Add(label9);
            AssignCoursePanel.Controls.Add(label8);
            AssignCoursePanel.Controls.Add(label7);
            AssignCoursePanel.Controls.Add(AssignCourseLabel);
            AssignCoursePanel.Dock = DockStyle.Fill;
            AssignCoursePanel.ForeColor = Color.Black;
            AssignCoursePanel.Location = new Point(271, 0);
            AssignCoursePanel.Margin = new Padding(3, 2, 3, 2);
            AssignCoursePanel.Name = "AssignCoursePanel";
            AssignCoursePanel.Size = new Size(763, 565);
            AssignCoursePanel.TabIndex = 4;
            // 
            // AssignTeacher
            // 
            AssignTeacher.BackColor = Color.FromArgb(116, 86, 174);
            AssignTeacher.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AssignTeacher.ForeColor = Color.White;
            AssignTeacher.Location = new Point(141, 385);
            AssignTeacher.Margin = new Padding(3, 2, 3, 2);
            AssignTeacher.Name = "AssignTeacher";
            AssignTeacher.Size = new Size(408, 40);
            AssignTeacher.TabIndex = 9;
            AssignTeacher.Text = "Assign Teacher";
            AssignTeacher.UseVisualStyleBackColor = false;
            AssignTeacher.Click += AssignTeacher_Click;
            // 
            // CourseTeacher
            // 
            CourseTeacher.FormattingEnabled = true;
            CourseTeacher.Location = new Point(366, 275);
            CourseTeacher.Margin = new Padding(3, 2, 3, 2);
            CourseTeacher.Name = "CourseTeacher";
            CourseTeacher.Size = new Size(183, 23);
            CourseTeacher.TabIndex = 8;
            // 
            // CourseSection
            // 
            CourseSection.FormattingEnabled = true;
            CourseSection.Location = new Point(366, 208);
            CourseSection.Margin = new Padding(3, 2, 3, 2);
            CourseSection.Name = "CourseSection";
            CourseSection.Size = new Size(183, 23);
            CourseSection.TabIndex = 7;
            // 
            // CourseNames
            // 
            CourseNames.FormattingEnabled = true;
            CourseNames.Location = new Point(366, 142);
            CourseNames.Margin = new Padding(3, 2, 3, 2);
            CourseNames.Name = "CourseNames";
            CourseNames.Size = new Size(183, 23);
            CourseNames.TabIndex = 6;
            CourseNames.SelectedIndexChanged += CourseNames_SelectedIndexChanged_1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(141, 266);
            label9.Name = "label9";
            label9.Size = new Size(122, 32);
            label9.TabIndex = 5;
            label9.Text = "Teacher  : ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(141, 202);
            label8.Name = "label8";
            label8.Size = new Size(193, 32);
            label8.TabIndex = 4;
            label8.Text = "Course Section : ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(141, 133);
            label7.Name = "label7";
            label7.Size = new Size(178, 32);
            label7.TabIndex = 3;
            label7.Text = "Course Name : ";
            // 
            // AssignCourseLabel
            // 
            AssignCourseLabel.AutoSize = true;
            AssignCourseLabel.Font = new Font("Bodoni MT Condensed", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AssignCourseLabel.ForeColor = Color.FromArgb(116, 86, 174);
            AssignCourseLabel.Location = new Point(178, 45);
            AssignCourseLabel.Name = "AssignCourseLabel";
            AssignCourseLabel.Size = new Size(367, 56);
            AssignCourseLabel.TabIndex = 2;
            AssignCourseLabel.Text = "Assign Course To Teacher";
            // 
            // viewStudentsPanel
            // 
            viewStudentsPanel.BackColor = Color.White;
            viewStudentsPanel.Controls.Add(studentList);
            viewStudentsPanel.Controls.Add(CourseSections);
            viewStudentsPanel.Controls.Add(label12);
            viewStudentsPanel.Controls.Add(CourseNamess);
            viewStudentsPanel.Controls.Add(label11);
            viewStudentsPanel.Controls.Add(label10);
            viewStudentsPanel.Dock = DockStyle.Fill;
            viewStudentsPanel.Location = new Point(271, 0);
            viewStudentsPanel.Name = "viewStudentsPanel";
            viewStudentsPanel.Size = new Size(763, 565);
            viewStudentsPanel.TabIndex = 10;
            // 
            // studentList
            // 
            studentList.AllowUserToDeleteRows = false;
            studentList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            studentList.Columns.AddRange(new DataGridViewColumn[] { RollNos });
            studentList.Location = new Point(141, 253);
            studentList.Name = "studentList";
            studentList.ReadOnly = true;
            studentList.Size = new Size(390, 150);
            studentList.TabIndex = 10;
            studentList.CellContentClick += dataGridView1_CellContentClick;
            // 
            // RollNos
            // 
            RollNos.HeaderText = "Student Roll Numbers";
            RollNos.Name = "RollNos";
            RollNos.ReadOnly = true;
            RollNos.Width = 400;
            // 
            // CourseSections
            // 
            CourseSections.FormattingEnabled = true;
            CourseSections.Location = new Point(348, 181);
            CourseSections.Margin = new Padding(3, 2, 3, 2);
            CourseSections.Name = "CourseSections";
            CourseSections.Size = new Size(183, 23);
            CourseSections.TabIndex = 9;
            CourseSections.SelectedIndexChanged += CourseSections_SelectedIndexChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(141, 172);
            label12.Name = "label12";
            label12.Size = new Size(193, 32);
            label12.TabIndex = 8;
            label12.Text = "Course Section : ";
            label12.Click += label12_Click;
            // 
            // CourseNamess
            // 
            CourseNamess.FormattingEnabled = true;
            CourseNamess.Location = new Point(348, 130);
            CourseNamess.Margin = new Padding(3, 2, 3, 2);
            CourseNamess.Name = "CourseNamess";
            CourseNamess.Size = new Size(183, 23);
            CourseNamess.TabIndex = 7;
            CourseNamess.SelectedIndexChanged += CourseNamess_SelectedIndexChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(141, 128);
            label11.Name = "label11";
            label11.Size = new Size(178, 32);
            label11.TabIndex = 4;
            label11.Text = "Course Name : ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Bodoni MT Condensed", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(116, 86, 174);
            label10.Location = new Point(259, 34);
            label10.Name = "label10";
            label10.Size = new Size(213, 56);
            label10.TabIndex = 3;
            label10.Text = "View Students";
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(1034, 565);
            Controls.Add(viewStudentsPanel);
            Controls.Add(AssignCoursePanel);
            Controls.Add(OfferCoursePanel);
            Controls.Add(DashboardPanel);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Admin";
            Text = "Admin";
            Load += Admin_Load;
            panel1.ResumeLayout(false);
            OfferCoursePanel.ResumeLayout(false);
            OfferCoursePanel.PerformLayout();
            DashboardPanel.ResumeLayout(false);
            DashboardPanel.PerformLayout();
            AssignCoursePanel.ResumeLayout(false);
            AssignCoursePanel.PerformLayout();
            viewStudentsPanel.ResumeLayout(false);
            viewStudentsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)studentList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label AdminDashboard;
        private Button Dashboard;
        private Button OfferCourse;
        private Panel OfferCoursePanel;
        private Label label1;
        private TextBox CourseID;
        private Label label2;
        private TextBox CourseName;
        private Label label3;
        private TextBox CourseDescription;
        private Label label4;
        private Button Offer;
        private Label label5;
        private Label label6;
        private Label adminName;
        private Label adminEmail;
        private Panel DashboardPanel;
        private Button AssignCourse;
        private Panel AssignCoursePanel;
        private Label AssignCourseLabel;
        private ComboBox CourseSection;
        private ComboBox CourseNames;
        private Label label9;
        private Label label8;
        private Label label7;
        private Button AssignTeacher;
        private ComboBox CourseTeacher;
        private Button viewStudents;
        private Panel viewStudentsPanel;
        private ComboBox CourseSections;
        private Label label12;
        private ComboBox CourseNamess;
        private Label label11;
        private Label label10;
        private DataGridView studentList;
        private DataGridViewTextBoxColumn RollNos;
    }
}