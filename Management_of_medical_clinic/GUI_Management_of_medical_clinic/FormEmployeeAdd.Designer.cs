namespace GUI_Management_of_medical_clinic
{
    partial class FormEmployeeAdd
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
            labelSpecialization = new Label();
            checkedListBoxSpecialization = new CheckedListBox();
            comboBoxSex = new ComboBox();
            label7 = new Label();
            textBoxPhone = new TextBox();
            textBoxEmail = new TextBox();
            label8 = new Label();
            label9 = new Label();
            textBoxAddress = new TextBox();
            label10 = new Label();
            comboBoxRole = new ComboBox();
            label5 = new Label();
            dateTimePickerDate = new DateTimePicker();
            label4 = new Label();
            textBoxPESEL = new TextBox();
            textBoxLastName = new TextBox();
            label3 = new Label();
            label1 = new Label();
            textBoxFirstName = new TextBox();
            label2 = new Label();
            labelTitle = new Label();
            buttonCancel = new Button();
            buttonNext = new Button();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelSpecialization
            // 
            labelSpecialization.AutoSize = true;
            labelSpecialization.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            labelSpecialization.Location = new Point(1219, 330);
            labelSpecialization.Name = "labelSpecialization";
            labelSpecialization.Size = new Size(229, 28);
            labelSpecialization.TabIndex = 54;
            labelSpecialization.Text = "Doctor's Specialization";
            labelSpecialization.Visible = false;
            // 
            // checkedListBoxSpecialization
            // 
            checkedListBoxSpecialization.CheckOnClick = true;
            checkedListBoxSpecialization.Font = new Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            checkedListBoxSpecialization.FormattingEnabled = true;
            checkedListBoxSpecialization.Location = new Point(1204, 377);
            checkedListBoxSpecialization.Name = "checkedListBoxSpecialization";
            checkedListBoxSpecialization.Size = new Size(273, 256);
            checkedListBoxSpecialization.TabIndex = 53;
            checkedListBoxSpecialization.Visible = false;
            checkedListBoxSpecialization.SelectedIndexChanged += checkedListBoxSpecialization_SelectedIndexChanged;
            // 
            // comboBoxSex
            // 
            comboBoxSex.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSex.Font = new Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxSex.FormattingEnabled = true;
            comboBoxSex.Location = new Point(943, 671);
            comboBoxSex.Name = "comboBoxSex";
            comboBoxSex.Size = new Size(199, 43);
            comboBoxSex.TabIndex = 52;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 19F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(697, 678);
            label7.Name = "label7";
            label7.Size = new Size(58, 36);
            label7.TabIndex = 51;
            label7.Text = "Sex";
            // 
            // textBoxPhone
            // 
            textBoxPhone.Font = new Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPhone.Location = new Point(943, 597);
            textBoxPhone.MaxLength = 9;
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(199, 41);
            textBoxPhone.TabIndex = 50;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Font = new Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxEmail.Location = new Point(943, 536);
            textBoxEmail.MaxLength = 200;
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(199, 41);
            textBoxEmail.TabIndex = 49;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 19F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(697, 600);
            label8.Name = "label8";
            label8.Size = new Size(196, 36);
            label8.TabIndex = 48;
            label8.Text = "Phone number";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 19F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(697, 536);
            label9.Name = "label9";
            label9.Size = new Size(92, 36);
            label9.TabIndex = 47;
            label9.Text = "E-mail";
            // 
            // textBoxAddress
            // 
            textBoxAddress.Font = new Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxAddress.Location = new Point(943, 479);
            textBoxAddress.MaxLength = 500;
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(199, 41);
            textBoxAddress.TabIndex = 46;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 19F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(697, 482);
            label10.Name = "label10";
            label10.Size = new Size(175, 36);
            label10.TabIndex = 45;
            label10.Text = "Corr. Address";
            // 
            // comboBoxRole
            // 
            comboBoxRole.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRole.Font = new Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxRole.FormattingEnabled = true;
            comboBoxRole.Items.AddRange(new object[] { "Medical Doctor", "Nurse", "Paramedic", "Janitor", "Technitian" });
            comboBoxRole.Location = new Point(943, 416);
            comboBoxRole.Name = "comboBoxRole";
            comboBoxRole.Size = new Size(199, 43);
            comboBoxRole.TabIndex = 44;
            comboBoxRole.SelectedIndexChanged += comboBoxRole_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 19F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(697, 423);
            label5.Name = "label5";
            label5.Size = new Size(80, 36);
            label5.TabIndex = 43;
            label5.Text = "Role*";
            // 
            // dateTimePickerDate
            // 
            dateTimePickerDate.Font = new Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerDate.Format = DateTimePickerFormat.Short;
            dateTimePickerDate.Location = new Point(943, 358);
            dateTimePickerDate.Name = "dateTimePickerDate";
            dateTimePickerDate.Size = new Size(199, 41);
            dateTimePickerDate.TabIndex = 42;
            dateTimePickerDate.Value = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 19F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(697, 363);
            label4.Name = "label4";
            label4.Size = new Size(185, 36);
            label4.TabIndex = 41;
            label4.Text = "Date of Birth*";
            // 
            // textBoxPESEL
            // 
            textBoxPESEL.Font = new Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPESEL.Location = new Point(943, 302);
            textBoxPESEL.MaxLength = 11;
            textBoxPESEL.Name = "textBoxPESEL";
            textBoxPESEL.Size = new Size(199, 41);
            textBoxPESEL.TabIndex = 40;
            textBoxPESEL.TextChanged += textBoxPESEL_TextChanged;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Font = new Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxLastName.Location = new Point(943, 235);
            textBoxLastName.MaxLength = 100;
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(199, 41);
            textBoxLastName.TabIndex = 39;
            textBoxLastName.TextChanged += textBoxLastName_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 19F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(697, 302);
            label3.Name = "label3";
            label3.Size = new Size(96, 36);
            label3.TabIndex = 38;
            label3.Text = "PESEL*";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(697, 240);
            label1.Name = "label1";
            label1.Size = new Size(155, 36);
            label1.TabIndex = 37;
            label1.Text = "Last Name*";
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Font = new Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxFirstName.Location = new Point(943, 176);
            textBoxFirstName.MaxLength = 100;
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(199, 41);
            textBoxFirstName.TabIndex = 36;
            textBoxFirstName.TextChanged += textBoxFirstName_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 19F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(697, 181);
            label2.Name = "label2";
            label2.Size = new Size(159, 36);
            label2.TabIndex = 35;
            label2.Text = "First Name*";
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 25F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitle.Location = new Point(910, 93);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(250, 46);
            labelTitle.TabIndex = 34;
            labelTitle.Text = "Add Employee";
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
            // buttonNext
            // 
            buttonNext.BackColor = Color.Gainsboro;
            buttonNext.Enabled = false;
            buttonNext.FlatAppearance.BorderSize = 2;
            buttonNext.FlatStyle = FlatStyle.Flat;
            buttonNext.Font = new Font("Segoe UI", 19F, FontStyle.Bold, GraphicsUnit.Point);
            buttonNext.Location = new Point(1249, 761);
            buttonNext.Name = "buttonNext";
            buttonNext.Size = new Size(219, 57);
            buttonNext.TabIndex = 32;
            buttonNext.Text = "Next";
            buttonNext.UseVisualStyleBackColor = false;
            buttonNext.Click += buttonNext_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(buttonCancel);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(312, 1081);
            panel2.TabIndex = 55;
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
            // FormEmployeeAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1920, 1080);
            Controls.Add(panel2);
            Controls.Add(labelSpecialization);
            Controls.Add(checkedListBoxSpecialization);
            Controls.Add(comboBoxSex);
            Controls.Add(label7);
            Controls.Add(textBoxPhone);
            Controls.Add(textBoxEmail);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(textBoxAddress);
            Controls.Add(label10);
            Controls.Add(comboBoxRole);
            Controls.Add(label5);
            Controls.Add(dateTimePickerDate);
            Controls.Add(label4);
            Controls.Add(textBoxPESEL);
            Controls.Add(textBoxLastName);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(textBoxFirstName);
            Controls.Add(label2);
            Controls.Add(labelTitle);
            Controls.Add(buttonNext);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormEmployeeAdd";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormEmployeeAdd";
            WindowState = FormWindowState.Maximized;
            Load += FormEmployeeAdd_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelSpecialization;
        private CheckedListBox checkedListBoxSpecialization;
        private ComboBox comboBoxSex;
        private Label label7;
        private TextBox textBoxPhone;
        private TextBox textBoxEmail;
        private Label label8;
        private Label label9;
        private TextBox textBoxAddress;
        private Label label10;
        private ComboBox comboBoxRole;
        private Label label5;
        private DateTimePicker dateTimePickerDate;
        private Label label4;
        private TextBox textBoxPESEL;
        private TextBox textBoxLastName;
        private Label label3;
        private Label label1;
        private TextBox textBoxFirstName;
        private Label label2;
        private Label labelTitle;
        private Button buttonCancel;
        private Button buttonNext;
        private Panel panel2;
        private PictureBox pictureBox1;
    }
}