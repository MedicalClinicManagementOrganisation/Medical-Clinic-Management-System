namespace GUI_Management_of_medical_clinic
{
    partial class FormEmployeeList
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
            buttonReactivate = new Button();
            buttonClearFilter = new Button();
            buttonDeactivateEmployee = new Button();
            buttonReviewEmployee = new Button();
            buttonAddEmployee = new Button();
            buttonFilterEmployee = new Button();
            comboBoxRole = new ComboBox();
            checkBoxIsActive = new CheckBox();
            dataGridViewEmployees = new DataGridView();
            buttonSpecializations = new Button();
            buttonEditEmployee = new Button();
            panel1 = new Panel();
            buttonBack = new Button();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmployees).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // buttonReactivate
            // 
            buttonReactivate.BackColor = Color.SteelBlue;
            buttonReactivate.FlatStyle = FlatStyle.Flat;
            buttonReactivate.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            buttonReactivate.Location = new Point(-7, 630);
            buttonReactivate.Name = "buttonReactivate";
            buttonReactivate.Size = new Size(329, 87);
            buttonReactivate.TabIndex = 19;
            buttonReactivate.Text = "Reactivate employee";
            buttonReactivate.UseVisualStyleBackColor = false;
            buttonReactivate.Click += buttonReactivate_Click;
            // 
            // buttonClearFilter
            // 
            buttonClearFilter.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonClearFilter.Location = new Point(1142, 21);
            buttonClearFilter.Name = "buttonClearFilter";
            buttonClearFilter.Size = new Size(86, 26);
            buttonClearFilter.TabIndex = 18;
            buttonClearFilter.Text = "Clear filter";
            buttonClearFilter.UseVisualStyleBackColor = true;
            buttonClearFilter.Click += buttonClearFilter_Click;
            // 
            // buttonDeactivateEmployee
            // 
            buttonDeactivateEmployee.BackColor = Color.SteelBlue;
            buttonDeactivateEmployee.FlatStyle = FlatStyle.Flat;
            buttonDeactivateEmployee.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDeactivateEmployee.Location = new Point(-7, 537);
            buttonDeactivateEmployee.Name = "buttonDeactivateEmployee";
            buttonDeactivateEmployee.Size = new Size(329, 87);
            buttonDeactivateEmployee.TabIndex = 17;
            buttonDeactivateEmployee.Text = "Deactivate employee";
            buttonDeactivateEmployee.UseVisualStyleBackColor = false;
            buttonDeactivateEmployee.Click += buttonDeactivateEmployee_Click;
            // 
            // buttonReviewEmployee
            // 
            buttonReviewEmployee.BackColor = Color.SteelBlue;
            buttonReviewEmployee.FlatStyle = FlatStyle.Flat;
            buttonReviewEmployee.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            buttonReviewEmployee.Location = new Point(-7, 440);
            buttonReviewEmployee.Name = "buttonReviewEmployee";
            buttonReviewEmployee.Size = new Size(329, 87);
            buttonReviewEmployee.TabIndex = 16;
            buttonReviewEmployee.Text = "Review employee";
            buttonReviewEmployee.UseVisualStyleBackColor = false;
            buttonReviewEmployee.Click += buttonReviewEmployee_Click;
            // 
            // buttonAddEmployee
            // 
            buttonAddEmployee.BackColor = Color.SteelBlue;
            buttonAddEmployee.FlatAppearance.BorderColor = Color.Black;
            buttonAddEmployee.FlatStyle = FlatStyle.Flat;
            buttonAddEmployee.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAddEmployee.ForeColor = SystemColors.ActiveCaptionText;
            buttonAddEmployee.Location = new Point(-7, 254);
            buttonAddEmployee.Name = "buttonAddEmployee";
            buttonAddEmployee.Size = new Size(319, 87);
            buttonAddEmployee.TabIndex = 15;
            buttonAddEmployee.Text = "Add new employee";
            buttonAddEmployee.UseVisualStyleBackColor = false;
            buttonAddEmployee.Click += buttonAddEmployee_Click;
            // 
            // buttonFilterEmployee
            // 
            buttonFilterEmployee.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonFilterEmployee.Location = new Point(288, 21);
            buttonFilterEmployee.Name = "buttonFilterEmployee";
            buttonFilterEmployee.Size = new Size(86, 26);
            buttonFilterEmployee.TabIndex = 14;
            buttonFilterEmployee.Text = "Filtruj";
            buttonFilterEmployee.UseVisualStyleBackColor = true;
            buttonFilterEmployee.Click += buttonFilterEmployee_Click;
            // 
            // comboBoxRole
            // 
            comboBoxRole.BackColor = Color.Gainsboro;
            comboBoxRole.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRole.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxRole.FormattingEnabled = true;
            comboBoxRole.Items.AddRange(new object[] { "MedicalDoctor", "Nurse", "Janitor", "Technitian" });
            comboBoxRole.Location = new Point(769, 21);
            comboBoxRole.Name = "comboBoxRole";
            comboBoxRole.Size = new Size(271, 25);
            comboBoxRole.TabIndex = 13;
            // 
            // checkBoxIsActive
            // 
            checkBoxIsActive.AutoSize = true;
            checkBoxIsActive.BackColor = Color.SteelBlue;
            checkBoxIsActive.Checked = true;
            checkBoxIsActive.CheckState = CheckState.Checked;
            checkBoxIsActive.FlatAppearance.BorderColor = Color.Black;
            checkBoxIsActive.FlatAppearance.BorderSize = 4;
            checkBoxIsActive.FlatStyle = FlatStyle.Flat;
            checkBoxIsActive.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            checkBoxIsActive.Location = new Point(516, 26);
            checkBoxIsActive.Name = "checkBoxIsActive";
            checkBoxIsActive.Size = new Size(149, 21);
            checkBoxIsActive.TabIndex = 12;
            checkBoxIsActive.Text = "Is Employee active";
            checkBoxIsActive.UseVisualStyleBackColor = false;
            // 
            // dataGridViewEmployees
            // 
            dataGridViewEmployees.AllowUserToAddRows = false;
            dataGridViewEmployees.AllowUserToDeleteRows = false;
            dataGridViewEmployees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewEmployees.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewEmployees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEmployees.GridColor = SystemColors.GrayText;
            dataGridViewEmployees.Location = new Point(312, 74);
            dataGridViewEmployees.Name = "dataGridViewEmployees";
            dataGridViewEmployees.ReadOnly = true;
            dataGridViewEmployees.RowHeadersVisible = false;
            dataGridViewEmployees.RowTemplate.Height = 25;
            dataGridViewEmployees.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewEmployees.Size = new Size(1610, 1007);
            dataGridViewEmployees.TabIndex = 10;
            dataGridViewEmployees.RowHeaderMouseClick += dataGridViewEmployees_RowHeaderMouseClick;
            // 
            // buttonSpecializations
            // 
            buttonSpecializations.BackColor = Color.SteelBlue;
            buttonSpecializations.FlatStyle = FlatStyle.Flat;
            buttonSpecializations.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSpecializations.Location = new Point(-7, 723);
            buttonSpecializations.Name = "buttonSpecializations";
            buttonSpecializations.Size = new Size(329, 87);
            buttonSpecializations.TabIndex = 20;
            buttonSpecializations.Text = "Edit Specializations";
            buttonSpecializations.UseVisualStyleBackColor = false;
            buttonSpecializations.Click += buttonSpecializations_Click;
            // 
            // buttonEditEmployee
            // 
            buttonEditEmployee.BackColor = Color.SteelBlue;
            buttonEditEmployee.FlatAppearance.BorderColor = Color.Black;
            buttonEditEmployee.FlatStyle = FlatStyle.Flat;
            buttonEditEmployee.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            buttonEditEmployee.Location = new Point(-7, 347);
            buttonEditEmployee.Name = "buttonEditEmployee";
            buttonEditEmployee.Size = new Size(329, 87);
            buttonEditEmployee.TabIndex = 21;
            buttonEditEmployee.Text = "Edit Employee";
            buttonEditEmployee.UseVisualStyleBackColor = false;
            buttonEditEmployee.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(buttonBack);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(buttonSpecializations);
            panel1.Controls.Add(buttonEditEmployee);
            panel1.Controls.Add(buttonReactivate);
            panel1.Controls.Add(buttonAddEmployee);
            panel1.Controls.Add(buttonReviewEmployee);
            panel1.Controls.Add(buttonDeactivateEmployee);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(312, 1081);
            panel1.TabIndex = 22;
            // 
            // buttonBack
            // 
            buttonBack.BackColor = Color.Gainsboro;
            buttonBack.FlatAppearance.BorderColor = Color.White;
            buttonBack.FlatAppearance.BorderSize = 2;
            buttonBack.FlatStyle = FlatStyle.Flat;
            buttonBack.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            buttonBack.Location = new Point(29, 970);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(252, 66);
            buttonBack.TabIndex = 22;
            buttonBack.Text = "LOG OUT";
            buttonBack.UseVisualStyleBackColor = false;
            buttonBack.Click += buttonBack_Click;
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
            // panel3
            // 
            panel3.BackColor = Color.SteelBlue;
            panel3.Controls.Add(comboBoxRole);
            panel3.Controls.Add(checkBoxIsActive);
            panel3.Controls.Add(buttonFilterEmployee);
            panel3.Controls.Add(buttonClearFilter);
            panel3.Location = new Point(312, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1610, 77);
            panel3.TabIndex = 32;
            // 
            // FormEmployeeList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1920, 1080);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(dataGridViewEmployees);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormEmployeeList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormEmployeeList";
            WindowState = FormWindowState.Maximized;
            Load += FormEmployeeList_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmployees).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonReactivate;
        private Button buttonClearFilter;
        private Button buttonDeactivateEmployee;
        private Button buttonReviewEmployee;
        private Button buttonAddEmployee;
        private Button buttonFilterEmployee;
        private ComboBox comboBoxRole;
        private CheckBox checkBoxIsActive;
        private DataGridView dataGridViewEmployees;
        private Button buttonSpecializations;
        private Button buttonEditEmployee;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button buttonBack;
        private Panel panel3;
    }
}