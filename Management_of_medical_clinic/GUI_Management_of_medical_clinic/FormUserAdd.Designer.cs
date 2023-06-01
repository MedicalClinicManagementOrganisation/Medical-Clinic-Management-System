namespace GUI_Management_of_medical_clinic
{
    partial class FormUserAdd
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
            textBoxPasswordConfirm = new TextBox();
            textBoxPassword = new TextBox();
            label3 = new Label();
            label1 = new Label();
            textBoxUsername = new TextBox();
            label2 = new Label();
            labelTitle = new Label();
            listBoxEmployees = new ListBox();
            label4 = new Label();
            buttonAddNewUser = new Button();
            label5 = new Label();
            comboBoxRole = new ComboBox();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            buttonCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxPasswordConfirm
            // 
            textBoxPasswordConfirm.Font = new Font("Segoe UI", 18.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPasswordConfirm.Location = new Point(934, 546);
            textBoxPasswordConfirm.MaxLength = 11;
            textBoxPasswordConfirm.Name = "textBoxPasswordConfirm";
            textBoxPasswordConfirm.PasswordChar = '*';
            textBoxPasswordConfirm.Size = new Size(199, 41);
            textBoxPasswordConfirm.TabIndex = 53;
            textBoxPasswordConfirm.TextChanged += textBoxPasswordConfirm_TextChanged;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new Font("Segoe UI", 18.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPassword.Location = new Point(934, 499);
            textBoxPassword.MaxLength = 100;
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(199, 41);
            textBoxPassword.TabIndex = 52;
            textBoxPassword.TextChanged += textBoxPassword_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(683, 549);
            label3.Name = "label3";
            label3.Size = new Size(213, 35);
            label3.TabIndex = 51;
            label3.Text = "Repeat Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(683, 502);
            label1.Name = "label1";
            label1.Size = new Size(124, 35);
            label1.TabIndex = 50;
            label1.Text = "Password";
            // 
            // textBoxUsername
            // 
            textBoxUsername.Font = new Font("Segoe UI", 18.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxUsername.Location = new Point(934, 431);
            textBoxUsername.MaxLength = 100;
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(199, 41);
            textBoxUsername.TabIndex = 49;
            textBoxUsername.TextChanged += textBoxUsername_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(683, 434);
            label2.Name = "label2";
            label2.Size = new Size(133, 35);
            label2.TabIndex = 48;
            label2.Text = "Username";
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 24.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitle.Location = new Point(863, 308);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(672, 45);
            labelTitle.TabIndex = 47;
            labelTitle.Text = "Set Username and Password for Employee";
            // 
            // listBoxEmployees
            // 
            listBoxEmployees.FormattingEnabled = true;
            listBoxEmployees.ItemHeight = 15;
            listBoxEmployees.Location = new Point(1239, 431);
            listBoxEmployees.Name = "listBoxEmployees";
            listBoxEmployees.Size = new Size(296, 229);
            listBoxEmployees.TabIndex = 54;
            listBoxEmployees.SelectedIndexChanged += listBoxEmployeesWithout_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(1239, 393);
            label4.Name = "label4";
            label4.Size = new Size(304, 35);
            label4.TabIndex = 55;
            label4.Text = "Assign employee to user";
            // 
            // buttonAddNewUser
            // 
            buttonAddNewUser.Font = new Font("Segoe UI", 18.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAddNewUser.Location = new Point(1381, 696);
            buttonAddNewUser.Name = "buttonAddNewUser";
            buttonAddNewUser.Size = new Size(220, 60);
            buttonAddNewUser.TabIndex = 56;
            buttonAddNewUser.Text = "Add";
            buttonAddNewUser.UseVisualStyleBackColor = true;
            buttonAddNewUser.Click += buttonAddNewUser_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(683, 615);
            label5.Name = "label5";
            label5.Size = new Size(66, 35);
            label5.TabIndex = 58;
            label5.Text = "Role";
            // 
            // comboBoxRole
            // 
            comboBoxRole.Font = new Font("Segoe UI", 18.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxRole.FormattingEnabled = true;
            comboBoxRole.Items.AddRange(new object[] { "Administrator", "Employee" });
            comboBoxRole.Location = new Point(934, 612);
            comboBoxRole.Name = "comboBoxRole";
            comboBoxRole.Size = new Size(199, 43);
            comboBoxRole.TabIndex = 59;
            comboBoxRole.SelectedIndexChanged += comboBoxRole_SelectedIndexChanged;
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
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(buttonCancel);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(312, 1081);
            panel2.TabIndex = 60;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.Gainsboro;
            buttonCancel.FlatAppearance.BorderColor = Color.White;
            buttonCancel.FlatAppearance.BorderSize = 2;
            buttonCancel.FlatStyle = FlatStyle.Flat;
            buttonCancel.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCancel.Location = new Point(24, 985);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(252, 66);
            buttonCancel.TabIndex = 33;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // FormUserAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1920, 1080);
            Controls.Add(panel2);
            Controls.Add(comboBoxRole);
            Controls.Add(label5);
            Controls.Add(buttonAddNewUser);
            Controls.Add(label4);
            Controls.Add(listBoxEmployees);
            Controls.Add(textBoxPasswordConfirm);
            Controls.Add(textBoxPassword);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(textBoxUsername);
            Controls.Add(label2);
            Controls.Add(labelTitle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormUserAdd";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormUserAdd";
            WindowState = FormWindowState.Maximized;
            Load += FormUserAdd_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxPasswordConfirm;
        private TextBox textBoxPassword;
        private Label label3;
        private Label label1;
        private TextBox textBoxUsername;
        private Label label2;
        private Label labelTitle;
        private ListBox listBoxEmployees;
        private Label label4;
        private Button buttonAddNewUser;
        private Label label5;
        private ComboBox comboBoxRole;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Button buttonCancel;
    }
}