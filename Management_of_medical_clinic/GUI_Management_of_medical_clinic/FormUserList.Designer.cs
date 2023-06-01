namespace GUI_Management_of_medical_clinic
{
    partial class FormUserList
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            buttonEditUser = new Button();
            buttonReviewUser = new Button();
            buttonAddUser = new Button();
            comboBoxRole = new ComboBox();
            dataGridViewUsers = new DataGridView();
            textBoxUsername = new TextBox();
            textBoxLastname = new TextBox();
            textBoxFirstname = new TextBox();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            buttonReactivateUser = new Button();
            buttonDeactivateUser = new Button();
            buttonLogOut = new Button();
            buttonFilterClear = new Button();
            buttonFilterUser = new Button();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // buttonEditUser
            // 
            buttonEditUser.BackColor = Color.SteelBlue;
            buttonEditUser.FlatStyle = FlatStyle.Flat;
            buttonEditUser.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonEditUser.ForeColor = SystemColors.ActiveCaptionText;
            buttonEditUser.Location = new Point(-7, 352);
            buttonEditUser.Name = "buttonEditUser";
            buttonEditUser.Size = new Size(329, 87);
            buttonEditUser.TabIndex = 33;
            buttonEditUser.Text = "Edit user";
            buttonEditUser.UseVisualStyleBackColor = false;
            buttonEditUser.Click += buttonEditUser_Click;
            // 
            // buttonReviewUser
            // 
            buttonReviewUser.BackColor = Color.SteelBlue;
            buttonReviewUser.FlatStyle = FlatStyle.Flat;
            buttonReviewUser.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonReviewUser.Location = new Point(-7, 445);
            buttonReviewUser.Name = "buttonReviewUser";
            buttonReviewUser.Size = new Size(329, 87);
            buttonReviewUser.TabIndex = 28;
            buttonReviewUser.Text = "Review user";
            buttonReviewUser.UseVisualStyleBackColor = false;
            buttonReviewUser.Click += buttonReviewUser_Click;
            // 
            // buttonAddUser
            // 
            buttonAddUser.BackColor = Color.SteelBlue;
            buttonAddUser.FlatStyle = FlatStyle.Flat;
            buttonAddUser.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAddUser.ForeColor = SystemColors.ActiveCaptionText;
            buttonAddUser.Location = new Point(-7, 259);
            buttonAddUser.Name = "buttonAddUser";
            buttonAddUser.Size = new Size(329, 87);
            buttonAddUser.TabIndex = 27;
            buttonAddUser.Text = "Add new user";
            buttonAddUser.UseVisualStyleBackColor = false;
            buttonAddUser.Click += buttonAddUser_Click;
            // 
            // comboBoxRole
            // 
            comboBoxRole.BackColor = Color.Gainsboro;
            comboBoxRole.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRole.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxRole.FormattingEnabled = true;
            comboBoxRole.Items.AddRange(new object[] { "Administrator", "Employee" });
            comboBoxRole.Location = new Point(1309, 20);
            comboBoxRole.Name = "comboBoxRole";
            comboBoxRole.Size = new Size(240, 25);
            comboBoxRole.TabIndex = 25;
            // 
            // dataGridViewUsers
            // 
            dataGridViewUsers.AllowUserToAddRows = false;
            dataGridViewUsers.AllowUserToDeleteRows = false;
            dataGridViewUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewUsers.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsers.GridColor = SystemColors.GrayText;
            dataGridViewUsers.Location = new Point(311, 65);
            dataGridViewUsers.Name = "dataGridViewUsers";
            dataGridViewUsers.ReadOnly = true;
            dataGridViewUsers.RowHeadersVisible = false;
            dataGridViewUsers.RowTemplate.Height = 25;
            dataGridViewUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewUsers.Size = new Size(1610, 1016);
            dataGridViewUsers.TabIndex = 22;
            // 
            // textBoxUsername
            // 
            textBoxUsername.BackColor = Color.Gainsboro;
            textBoxUsername.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxUsername.Location = new Point(967, 20);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.PlaceholderText = "Username";
            textBoxUsername.Size = new Size(271, 25);
            textBoxUsername.TabIndex = 34;
            // 
            // textBoxLastname
            // 
            textBoxLastname.BackColor = Color.Gainsboro;
            textBoxLastname.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxLastname.Location = new Point(619, 22);
            textBoxLastname.Name = "textBoxLastname";
            textBoxLastname.PlaceholderText = "Last name";
            textBoxLastname.Size = new Size(271, 25);
            textBoxLastname.TabIndex = 35;
            // 
            // textBoxFirstname
            // 
            textBoxFirstname.BackColor = Color.Gainsboro;
            textBoxFirstname.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxFirstname.Location = new Point(283, 22);
            textBoxFirstname.Name = "textBoxFirstname";
            textBoxFirstname.PlaceholderText = "First name";
            textBoxFirstname.Size = new Size(271, 25);
            textBoxFirstname.TabIndex = 36;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.MC_Logo;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(61, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(176, 168);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(buttonReactivateUser);
            panel1.Controls.Add(buttonDeactivateUser);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(buttonAddUser);
            panel1.Controls.Add(buttonEditUser);
            panel1.Controls.Add(buttonReviewUser);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(312, 1081);
            panel1.TabIndex = 37;
            // 
            // buttonReactivateUser
            // 
            buttonReactivateUser.BackColor = Color.SteelBlue;
            buttonReactivateUser.FlatStyle = FlatStyle.Flat;
            buttonReactivateUser.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonReactivateUser.Location = new Point(-7, 631);
            buttonReactivateUser.Name = "buttonReactivateUser";
            buttonReactivateUser.Size = new Size(329, 87);
            buttonReactivateUser.TabIndex = 35;
            buttonReactivateUser.Text = "Reactivate user";
            buttonReactivateUser.UseVisualStyleBackColor = false;
            buttonReactivateUser.Click += buttonReactivateUser_Click;
            // 
            // buttonDeactivateUser
            // 
            buttonDeactivateUser.BackColor = Color.SteelBlue;
            buttonDeactivateUser.FlatStyle = FlatStyle.Flat;
            buttonDeactivateUser.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDeactivateUser.Location = new Point(-7, 538);
            buttonDeactivateUser.Name = "buttonDeactivateUser";
            buttonDeactivateUser.Size = new Size(329, 87);
            buttonDeactivateUser.TabIndex = 34;
            buttonDeactivateUser.Text = "Deactivate user";
            buttonDeactivateUser.UseVisualStyleBackColor = false;
            buttonDeactivateUser.Click += buttonDeactivateUser_Click;
            // 
            // buttonLogOut
            // 
            buttonLogOut.BackColor = Color.Gainsboro;
            buttonLogOut.FlatAppearance.BorderColor = Color.White;
            buttonLogOut.FlatAppearance.BorderSize = 2;
            buttonLogOut.FlatStyle = FlatStyle.Flat;
            buttonLogOut.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            buttonLogOut.Location = new Point(29, 970);
            buttonLogOut.Name = "buttonLogOut";
            buttonLogOut.Size = new Size(252, 66);
            buttonLogOut.TabIndex = 38;
            buttonLogOut.Text = "LOG OUT";
            buttonLogOut.UseVisualStyleBackColor = false;
            buttonLogOut.Click += buttonLogOut_Click;
            // 
            // buttonFilterClear
            // 
            buttonFilterClear.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonFilterClear.Location = new Point(153, 20);
            buttonFilterClear.Name = "buttonFilterClear";
            buttonFilterClear.Size = new Size(86, 26);
            buttonFilterClear.TabIndex = 37;
            buttonFilterClear.Text = "Clear filter";
            buttonFilterClear.UseVisualStyleBackColor = true;
            buttonFilterClear.Click += buttonFilterClear_Click;
            // 
            // buttonFilterUser
            // 
            buttonFilterUser.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonFilterUser.Location = new Point(36, 20);
            buttonFilterUser.Name = "buttonFilterUser";
            buttonFilterUser.Size = new Size(86, 26);
            buttonFilterUser.TabIndex = 14;
            buttonFilterUser.Text = "Filter";
            buttonFilterUser.UseVisualStyleBackColor = true;
            buttonFilterUser.Click += buttonFilterUser_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.SteelBlue;
            panel3.Controls.Add(buttonFilterClear);
            panel3.Controls.Add(textBoxFirstname);
            panel3.Controls.Add(comboBoxRole);
            panel3.Controls.Add(buttonFilterUser);
            panel3.Controls.Add(textBoxLastname);
            panel3.Controls.Add(textBoxUsername);
            panel3.Location = new Point(311, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1610, 67);
            panel3.TabIndex = 41;
            // 
            // FormUserList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1920, 1080);
            Controls.Add(panel3);
            Controls.Add(buttonLogOut);
            Controls.Add(panel1);
            Controls.Add(dataGridViewUsers);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormUserList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormUserList";
            WindowState = FormWindowState.Maximized;
            Load += FormUserList_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonEditUser;
        private Button buttonClearFilter;
        private Button buttonReviewUser;
        private Button buttonAddUser;
        private ComboBox comboBoxRole;
        private DataGridView dataGridViewUsers;
        private TextBox textBoxUsername;
        private TextBox textBoxLastname;
        private TextBox textBoxFirstname;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Button buttonBack;
        private Button buttonDeactivateUser;
        private Button buttonReactivateUser;
        private Button buttonLogOut;
        //private Button buttonClearFilter;
        private Button buttonFilterUser;
        private Button buttonFilterClear;
        private Panel panel3;
    }
}