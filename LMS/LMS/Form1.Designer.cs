
namespace LMS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            username = new TextBox();
            label5 = new Label();
            label6 = new Label();
            password = new TextBox();
            usertypes = new ComboBox();
            loginButton = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(116, 86, 174);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 753);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(147, 101);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(102, 96);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(50, 709);
            label2.Name = "label2";
            label2.Size = new Size(245, 21);
            label2.TabIndex = 1;
            label2.Text = "Copyrights reserved CodeCrafters";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bodoni MT Condensed", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(116, 86, 174);
            label3.Location = new Point(647, 73);
            label3.Name = "label3";
            label3.Size = new Size(199, 57);
            label3.TabIndex = 2;
            label3.Text = "Login Page";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(519, 231);
            label4.Name = "label4";
            label4.Size = new Size(111, 30);
            label4.TabIndex = 3;
            label4.Text = "Username";
            // 
            // username
            // 
            username.Location = new Point(706, 231);
            username.Name = "username";
            username.Size = new Size(277, 26);
            username.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(519, 323);
            label5.Name = "label5";
            label5.Size = new Size(103, 30);
            label5.TabIndex = 5;
            label5.Text = "Password";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(519, 415);
            label6.Name = "label6";
            label6.Size = new Size(110, 30);
            label6.TabIndex = 7;
            label6.Text = "User Type";
            // 
            // password
            // 
            password.Location = new Point(706, 323);
            password.Name = "password";
            password.PasswordChar = '*';
            password.Size = new Size(277, 26);
            password.TabIndex = 6;
            password.TextChanged += textBox2_TextChanged;
            // 
            // usertypes
            // 
            usertypes.FormattingEnabled = true;
            usertypes.Items.AddRange(new object[] { "Admin", "Teacher", "Student" });
            usertypes.Location = new Point(706, 415);
            usertypes.Name = "usertypes";
            usertypes.Size = new Size(277, 27);
            usertypes.TabIndex = 8;
            usertypes.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.FromArgb(116, 86, 174);
            loginButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginButton.ForeColor = Color.White;
            loginButton.Location = new Point(519, 505);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(464, 57);
            loginButton.TabIndex = 9;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1182, 753);
            Controls.Add(loginButton);
            Controls.Add(usertypes);
            Controls.Add(label6);
            Controls.Add(password);
            Controls.Add(label5);
            Controls.Add(username);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "University Learning Management System";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox username;
        private Label label5;
        private Label label6;
        private TextBox password;
        private ComboBox usertypes;
        private Button loginButton;
        private PictureBox pictureBox1;
        //private EventHandler label5_Click;
    }
}
