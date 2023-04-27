namespace GUI_Management_of_medical_clinic
{
    partial class FormUserEdit
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
            labelTitle = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            buttonSaveUser = new Button();
            textBoxUsername = new TextBox();
            buttonChangePassword = new Button();
            comboBoxRole = new ComboBox();
            comboBoxActive = new ComboBox();
            label6 = new Label();
            listBoxEmployees = new ListBox();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            buttonClose = new Button();
            buttonChangeStatus = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 24.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitle.Location = new Point(1002, 289);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(208, 45);
            labelTitle.TabIndex = 63;
            labelTitle.Text = "User edition";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(860, 534);
            label3.Name = "label3";
            label3.Size = new Size(140, 35);
            label3.TabIndex = 62;
            label3.Text = "Is it Active";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(860, 485);
            label2.Name = "label2";
            label2.Size = new Size(66, 35);
            label2.TabIndex = 61;
            label2.Text = "Role";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(860, 438);
            label1.Name = "label1";
            label1.Size = new Size(133, 35);
            label1.TabIndex = 60;
            label1.Text = "Username";
            // 
            // buttonSaveUser
            // 
            buttonSaveUser.Font = new Font("Segoe UI", 18.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSaveUser.Location = new Point(1284, 614);
            buttonSaveUser.Name = "buttonSaveUser";
            buttonSaveUser.Size = new Size(220, 60);
            buttonSaveUser.TabIndex = 58;
            buttonSaveUser.Text = "Save";
            buttonSaveUser.UseVisualStyleBackColor = true;
            buttonSaveUser.Click += buttonSaveUser_Click;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Font = new Font("Segoe UI", 18.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxUsername.Location = new Point(1032, 435);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(187, 41);
            textBoxUsername.TabIndex = 55;
            textBoxUsername.TextChanged += textBoxUsername_TextChanged;
            // 
            // buttonChangePassword
            // 
            buttonChangePassword.Font = new Font("Segoe UI", 18.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonChangePassword.Location = new Point(1006, 614);
            buttonChangePassword.Name = "buttonChangePassword";
            buttonChangePassword.Size = new Size(272, 60);
            buttonChangePassword.TabIndex = 68;
            buttonChangePassword.Text = "Change password";
            buttonChangePassword.UseVisualStyleBackColor = true;
            buttonChangePassword.Click += buttonChangePassword_Click;
            // 
            // comboBoxRole
            // 
            comboBoxRole.Font = new Font("Segoe UI", 18.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxRole.FormattingEnabled = true;
            comboBoxRole.Items.AddRange(new object[] { "Administrator", "Employee" });
            comboBoxRole.Location = new Point(1032, 482);
            comboBoxRole.Name = "comboBoxRole";
            comboBoxRole.Size = new Size(187, 43);
            comboBoxRole.TabIndex = 69;
            comboBoxRole.SelectedIndexChanged += comboBoxRole_SelectedIndexChanged;
            // 
            // comboBoxActive
            // 
            comboBoxActive.Font = new Font("Segoe UI", 18.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxActive.FormattingEnabled = true;
            comboBoxActive.Items.AddRange(new object[] { "Active", "Disactive" });
            comboBoxActive.Location = new Point(1032, 531);
            comboBoxActive.Name = "comboBoxActive";
            comboBoxActive.Size = new Size(187, 43);
            comboBoxActive.TabIndex = 70;
            comboBoxActive.SelectedIndexChanged += comboBoxActive_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(1178, 334);
            label6.Name = "label6";
            label6.Size = new Size(471, 35);
            label6.TabIndex = 72;
            label6.Text = "Choose an employee to create an user:";
            // 
            // listBoxEmployees
            // 
            listBoxEmployees.FormattingEnabled = true;
            listBoxEmployees.ItemHeight = 15;
            listBoxEmployees.Location = new Point(1262, 375);
            listBoxEmployees.Name = "listBoxEmployees";
            listBoxEmployees.Size = new Size(301, 199);
            listBoxEmployees.TabIndex = 71;
            listBoxEmployees.SelectedIndexChanged += listBoxEmployees_SelectedIndexChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(buttonClose);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(312, 1081);
            panel2.TabIndex = 73;
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
            // buttonClose
            // 
            buttonClose.BackColor = Color.Gainsboro;
            buttonClose.FlatAppearance.BorderColor = Color.White;
            buttonClose.FlatAppearance.BorderSize = 2;
            buttonClose.FlatStyle = FlatStyle.Flat;
            buttonClose.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            buttonClose.Location = new Point(24, 985);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(252, 66);
            buttonClose.TabIndex = 33;
            buttonClose.Text = "Cancel";
            buttonClose.UseVisualStyleBackColor = false;
            buttonClose.Click += buttonClose_Click;
            // 
            // buttonChangeStatus
            // 
            buttonChangeStatus.Font = new Font("Segoe UI", 18.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonChangeStatus.Location = new Point(696, 614);
            buttonChangeStatus.Name = "buttonChangeStatus";
            buttonChangeStatus.Size = new Size(304, 60);
            buttonChangeStatus.TabIndex = 69;
            buttonChangeStatus.Text = "Change status of user";
            buttonChangeStatus.UseVisualStyleBackColor = true;
            buttonChangeStatus.Click += buttonChangeStatus_Click;
            // 
            // FormUserEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1920, 1080);
            Controls.Add(buttonChangeStatus);
            Controls.Add(panel2);
            Controls.Add(label6);
            Controls.Add(listBoxEmployees);
            Controls.Add(comboBoxActive);
            Controls.Add(comboBoxRole);
            Controls.Add(buttonChangePassword);
            Controls.Add(labelTitle);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonSaveUser);
            Controls.Add(textBoxUsername);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormUserEdit";
            Text = "FormUserEdit";
            Load += FormUserEdit_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelTitle;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button buttonSaveUser;
        private TextBox textBoxUsername;
        private Button buttonChangePassword;
        private ComboBox comboBoxRole;
        private ComboBox comboBoxActive;
        private Label label6;
        private ListBox listBoxEmployees;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button buttonClose;
        private Button buttonChangeStatus;
    }
}