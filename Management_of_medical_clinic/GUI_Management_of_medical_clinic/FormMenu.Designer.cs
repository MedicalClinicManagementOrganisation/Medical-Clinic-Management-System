﻿namespace GUI_Management_of_medical_clinic
{
    partial class FormMenu
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
            buttonOpenEmployeeList = new Button();
            textBoxLogin = new TextBox();
            textBoxPassword = new TextBox();
            panel2 = new Panel();
            buttonExit = new Button();
            pictureBox1 = new PictureBox();
            buttonOpenUserList = new Button();
            label1 = new Label();
            panelLogIn = new Panel();
            buttonOpenDoctorDashboard = new Button();
            buttonOpenCalendarsList = new Button();
            buttonOpenPatientsList = new Button();
            buttonOfficeList = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelLogIn.SuspendLayout();
            SuspendLayout();
            // 
            // buttonOpenEmployeeList
            // 
            buttonOpenEmployeeList.Anchor = AnchorStyles.None;
            buttonOpenEmployeeList.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonOpenEmployeeList.BackColor = Color.Gray;
            buttonOpenEmployeeList.Enabled = false;
            buttonOpenEmployeeList.FlatAppearance.BorderColor = Color.AntiqueWhite;
            buttonOpenEmployeeList.FlatAppearance.BorderSize = 5;
            buttonOpenEmployeeList.FlatStyle = FlatStyle.Flat;
            buttonOpenEmployeeList.Font = new Font("Microsoft Sans Serif", 19F, FontStyle.Regular, GraphicsUnit.Point);
            buttonOpenEmployeeList.Location = new Point(147, 202);
            buttonOpenEmployeeList.Name = "buttonOpenEmployeeList";
            buttonOpenEmployeeList.Size = new Size(325, 125);
            buttonOpenEmployeeList.TabIndex = 2;
            buttonOpenEmployeeList.Text = "EMPLOYEE LIST";
            buttonOpenEmployeeList.UseVisualStyleBackColor = false;
            // 
            // textBoxLogin
            // 
            textBoxLogin.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxLogin.BackColor = Color.MintCream;
            textBoxLogin.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxLogin.ForeColor = SystemColors.MenuText;
            textBoxLogin.Location = new Point(49, 45);
            textBoxLogin.Multiline = true;
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.PlaceholderText = "Login";
            textBoxLogin.Size = new Size(509, 42);
            textBoxLogin.TabIndex = 4;
            textBoxLogin.TextChanged += textBoxLogin_TextChanged;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxPassword.BackColor = Color.MintCream;
            textBoxPassword.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxPassword.ForeColor = SystemColors.MenuText;
            textBoxPassword.Location = new Point(49, 111);
            textBoxPassword.Multiline = true;
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.PlaceholderText = "Password";
            textBoxPassword.Size = new Size(509, 43);
            textBoxPassword.TabIndex = 5;
            textBoxPassword.TextChanged += textBoxPassword_TextChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.Controls.Add(buttonExit);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(0, -2);
            panel2.Name = "panel2";
            panel2.Size = new Size(312, 1081);
            panel2.TabIndex = 7;
            // 
            // buttonExit
            // 
            buttonExit.BackColor = Color.Gainsboro;
            buttonExit.FlatAppearance.BorderColor = Color.White;
            buttonExit.FlatAppearance.BorderSize = 2;
            buttonExit.FlatStyle = FlatStyle.Flat;
            buttonExit.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            buttonExit.Location = new Point(29, 982);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(252, 66);
            buttonExit.TabIndex = 3;
            buttonExit.Text = "EXIT";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click_2;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.MC_Logo;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(61, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(176, 168);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // buttonOpenUserList
            // 
            buttonOpenUserList.Anchor = AnchorStyles.None;
            buttonOpenUserList.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonOpenUserList.BackColor = Color.Gray;
            buttonOpenUserList.Enabled = false;
            buttonOpenUserList.FlatAppearance.BorderColor = Color.AntiqueWhite;
            buttonOpenUserList.FlatAppearance.BorderSize = 5;
            buttonOpenUserList.FlatStyle = FlatStyle.Flat;
            buttonOpenUserList.Font = new Font("Microsoft Sans Serif", 19F, FontStyle.Regular, GraphicsUnit.Point);
            buttonOpenUserList.Location = new Point(147, 329);
            buttonOpenUserList.Name = "buttonOpenUserList";
            buttonOpenUserList.Size = new Size(325, 125);
            buttonOpenUserList.TabIndex = 8;
            buttonOpenUserList.Text = "USER LIST";
            buttonOpenUserList.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(208, 171);
            label1.Name = "label1";
            label1.Size = new Size(194, 24);
            label1.TabIndex = 9;
            label1.Text = "Choose Log In Option";
            // 
            // panelLogIn
            // 
            panelLogIn.BackColor = SystemColors.ControlLight;
            panelLogIn.BorderStyle = BorderStyle.FixedSingle;
            panelLogIn.Controls.Add(buttonOpenDoctorDashboard);
            panelLogIn.Controls.Add(buttonOpenCalendarsList);
            panelLogIn.Controls.Add(buttonOpenPatientsList);
            panelLogIn.Controls.Add(buttonOfficeList);
            panelLogIn.Controls.Add(buttonOpenEmployeeList);
            panelLogIn.Controls.Add(label1);
            panelLogIn.Controls.Add(textBoxPassword);
            panelLogIn.Controls.Add(buttonOpenUserList);
            panelLogIn.Controls.Add(textBoxLogin);
            panelLogIn.Location = new Point(748, 223);
            panelLogIn.Name = "panelLogIn";
            panelLogIn.Size = new Size(598, 725);
            panelLogIn.TabIndex = 10;
            // 
            // buttonOpenDoctorDashboard
            // 
            buttonOpenDoctorDashboard.Anchor = AnchorStyles.None;
            buttonOpenDoctorDashboard.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonOpenDoctorDashboard.BackColor = Color.Gray;
            buttonOpenDoctorDashboard.FlatAppearance.BorderColor = Color.AntiqueWhite;
            buttonOpenDoctorDashboard.FlatAppearance.BorderSize = 5;
            buttonOpenDoctorDashboard.FlatStyle = FlatStyle.Flat;
            buttonOpenDoctorDashboard.Font = new Font("Microsoft Sans Serif", 19F, FontStyle.Regular, GraphicsUnit.Point);
            buttonOpenDoctorDashboard.Location = new Point(147, 654);
            buttonOpenDoctorDashboard.Name = "buttonOpenDoctorDashboard";
            buttonOpenDoctorDashboard.Size = new Size(325, 61);
            buttonOpenDoctorDashboard.TabIndex = 13;
            buttonOpenDoctorDashboard.Text = "DOCTOR DASHBOARD";
            buttonOpenDoctorDashboard.UseVisualStyleBackColor = false;
            buttonOpenDoctorDashboard.Click += buttonOpenDoctorDashboard_Click;
            // 
            // buttonOpenCalendarsList
            // 
            buttonOpenCalendarsList.Anchor = AnchorStyles.None;
            buttonOpenCalendarsList.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonOpenCalendarsList.BackColor = Color.Gray;
            buttonOpenCalendarsList.FlatAppearance.BorderColor = Color.AntiqueWhite;
            buttonOpenCalendarsList.FlatAppearance.BorderSize = 5;
            buttonOpenCalendarsList.FlatStyle = FlatStyle.Flat;
            buttonOpenCalendarsList.Font = new Font("Microsoft Sans Serif", 19F, FontStyle.Regular, GraphicsUnit.Point);
            buttonOpenCalendarsList.Location = new Point(147, 590);
            buttonOpenCalendarsList.Name = "buttonOpenCalendarsList";
            buttonOpenCalendarsList.Size = new Size(325, 61);
            buttonOpenCalendarsList.TabIndex = 12;
            buttonOpenCalendarsList.Text = "CALENDARS LIST";
            buttonOpenCalendarsList.UseVisualStyleBackColor = false;
            buttonOpenCalendarsList.Click += buttonOpenCalendarsList_Click_1;
            // 
            // buttonOpenPatientsList
            // 
            buttonOpenPatientsList.Anchor = AnchorStyles.None;
            buttonOpenPatientsList.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonOpenPatientsList.BackColor = Color.Gray;
            buttonOpenPatientsList.Enabled = false;
            buttonOpenPatientsList.FlatAppearance.BorderColor = Color.AntiqueWhite;
            buttonOpenPatientsList.FlatAppearance.BorderSize = 5;
            buttonOpenPatientsList.FlatStyle = FlatStyle.Flat;
            buttonOpenPatientsList.Font = new Font("Microsoft Sans Serif", 19F, FontStyle.Regular, GraphicsUnit.Point);
            buttonOpenPatientsList.Location = new Point(147, 524);
            buttonOpenPatientsList.Name = "buttonOpenPatientsList";
            buttonOpenPatientsList.Size = new Size(325, 61);
            buttonOpenPatientsList.TabIndex = 11;
            buttonOpenPatientsList.Text = "PATIENTS LIST";
            buttonOpenPatientsList.UseVisualStyleBackColor = false;
            // 
            // buttonOfficeList
            // 
            buttonOfficeList.Anchor = AnchorStyles.None;
            buttonOfficeList.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonOfficeList.BackColor = Color.Gray;
            buttonOfficeList.Enabled = false;
            buttonOfficeList.FlatAppearance.BorderColor = Color.AntiqueWhite;
            buttonOfficeList.FlatAppearance.BorderSize = 5;
            buttonOfficeList.FlatStyle = FlatStyle.Flat;
            buttonOfficeList.Font = new Font("Microsoft Sans Serif", 19F, FontStyle.Regular, GraphicsUnit.Point);
            buttonOfficeList.Location = new Point(147, 459);
            buttonOfficeList.Name = "buttonOfficeList";
            buttonOfficeList.Size = new Size(325, 61);
            buttonOfficeList.TabIndex = 10;
            buttonOfficeList.Text = "OFFICE LIST";
            buttonOfficeList.UseVisualStyleBackColor = false;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Website_Headers_5;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1920, 1080);
            Controls.Add(panelLogIn);
            Controls.Add(panel2);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelLogIn.ResumeLayout(false);
            panelLogIn.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonOpenEmployeeList;
        private TextBox textBoxLogin;
        private TextBox textBoxPassword;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button buttonExit;
        private Button buttonOpenUserList;
        private Label label1;
        private Panel panelLogIn;
        private Button buttonOfficeList;
        private Button buttonOpenPatientsList;
        private Button buttonOpenCalendarsList;
        private Button buttonOpenDoctorDashboard;
    }
}