﻿namespace GUI_Management_of_medical_clinic
{
    partial class FormPatientList
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
            buttonClearFilter = new Button();
            buttonAddPatient = new Button();
            buttonFilterEmployee = new Button();
            comboBoxRole = new ComboBox();
            checkBoxIsActive = new CheckBox();
            labelFilter = new Label();
            buttonEditPatient = new Button();
            panel1 = new Panel();
            button_ShowDetails = new Button();
            buttonExit = new Button();
            buttonDeactivatePatinet = new Button();
            buttonActivatePatient = new Button();
            buttonRemovePatient = new Button();
            buttonBack = new Button();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            maskedTextBox1 = new MaskedTextBox();
            textBox1 = new TextBox();
            dataGridViewPatientList = new DataGridView();
            panel2 = new Panel();
            button1 = new Button();
            buttonShowFilters = new Button();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPatientList).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // buttonClearFilter
            // 
            buttonClearFilter.Location = new Point(482, 1311);
            buttonClearFilter.Margin = new Padding(3, 4, 3, 4);
            buttonClearFilter.Name = "buttonClearFilter";
            buttonClearFilter.Size = new Size(138, 31);
            buttonClearFilter.TabIndex = 28;
            buttonClearFilter.Text = "Clear filter";
            buttonClearFilter.UseVisualStyleBackColor = true;
            // 
            // buttonAddPatient
            // 
            buttonAddPatient.BackColor = Color.SteelBlue;
            buttonAddPatient.FlatAppearance.BorderColor = Color.Black;
            buttonAddPatient.FlatStyle = FlatStyle.Flat;
            buttonAddPatient.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAddPatient.ForeColor = SystemColors.ActiveCaptionText;
            buttonAddPatient.Location = new Point(-1, 273);
            buttonAddPatient.Margin = new Padding(3, 4, 3, 4);
            buttonAddPatient.Name = "buttonAddPatient";
            buttonAddPatient.Size = new Size(360, 65);
            buttonAddPatient.TabIndex = 15;
            buttonAddPatient.Text = "Add new patient";
            buttonAddPatient.UseVisualStyleBackColor = false;
            buttonAddPatient.Click += buttonAddPatient_Click;
            // 
            // buttonFilterEmployee
            // 
            buttonFilterEmployee.Location = new Point(482, 1277);
            buttonFilterEmployee.Margin = new Padding(3, 4, 3, 4);
            buttonFilterEmployee.Name = "buttonFilterEmployee";
            buttonFilterEmployee.Size = new Size(138, 31);
            buttonFilterEmployee.TabIndex = 27;
            buttonFilterEmployee.Text = "Filtruj";
            buttonFilterEmployee.UseVisualStyleBackColor = true;
            // 
            // comboBoxRole
            // 
            comboBoxRole.FormattingEnabled = true;
            comboBoxRole.Items.AddRange(new object[] { "Medical Doctor", "Nurse", "Paramedic", "Janitor", "Technitian" });
            comboBoxRole.Location = new Point(482, 1239);
            comboBoxRole.Margin = new Padding(3, 4, 3, 4);
            comboBoxRole.Name = "comboBoxRole";
            comboBoxRole.Size = new Size(138, 23);
            comboBoxRole.TabIndex = 26;
            // 
            // checkBoxIsActive
            // 
            checkBoxIsActive.AutoSize = true;
            checkBoxIsActive.Checked = true;
            checkBoxIsActive.CheckState = CheckState.Checked;
            checkBoxIsActive.Location = new Point(482, 1205);
            checkBoxIsActive.Margin = new Padding(3, 4, 3, 4);
            checkBoxIsActive.Name = "checkBoxIsActive";
            checkBoxIsActive.Size = new Size(123, 19);
            checkBoxIsActive.TabIndex = 25;
            checkBoxIsActive.Text = "Is Employee active";
            checkBoxIsActive.UseVisualStyleBackColor = true;
            // 
            // labelFilter
            // 
            labelFilter.AutoSize = true;
            labelFilter.Location = new Point(482, 1181);
            labelFilter.Name = "labelFilter";
            labelFilter.Size = new Size(51, 15);
            labelFilter.TabIndex = 24;
            labelFilter.Text = "Filter list";
            // 
            // buttonEditPatient
            // 
            buttonEditPatient.BackColor = Color.SteelBlue;
            buttonEditPatient.FlatAppearance.BorderColor = Color.Black;
            buttonEditPatient.FlatStyle = FlatStyle.Flat;
            buttonEditPatient.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            buttonEditPatient.Location = new Point(-1, 346);
            buttonEditPatient.Margin = new Padding(3, 4, 3, 4);
            buttonEditPatient.Name = "buttonEditPatient";
            buttonEditPatient.Size = new Size(360, 65);
            buttonEditPatient.TabIndex = 21;
            buttonEditPatient.Text = "Edit patient";
            buttonEditPatient.UseVisualStyleBackColor = false;
            buttonEditPatient.Click += buttonEditPatient_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(button_ShowDetails);
            panel1.Controls.Add(buttonExit);
            panel1.Controls.Add(buttonDeactivatePatinet);
            panel1.Controls.Add(buttonActivatePatient);
            panel1.Controls.Add(buttonRemovePatient);
            panel1.Controls.Add(buttonBack);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(buttonEditPatient);
            panel1.Controls.Add(buttonAddPatient);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(357, 1080);
            panel1.TabIndex = 29;
            panel1.Paint += panel1_Paint;
            // 
            // button_ShowDetails
            // 
            button_ShowDetails.BackColor = Color.SteelBlue;
            button_ShowDetails.FlatAppearance.BorderColor = Color.Black;
            button_ShowDetails.FlatStyle = FlatStyle.Flat;
            button_ShowDetails.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button_ShowDetails.Location = new Point(-2, 639);
            button_ShowDetails.Margin = new Padding(3, 4, 3, 4);
            button_ShowDetails.Name = "button_ShowDetails";
            button_ShowDetails.Size = new Size(360, 65);
            button_ShowDetails.TabIndex = 47;
            button_ShowDetails.Text = "Show details";
            button_ShowDetails.UseVisualStyleBackColor = false;
            button_ShowDetails.Click += button_ShowDetails_Click;
            // 
            // buttonExit
            // 
            buttonExit.BackColor = Color.Gainsboro;
            buttonExit.FlatAppearance.BorderColor = Color.White;
            buttonExit.FlatAppearance.BorderSize = 2;
            buttonExit.FlatStyle = FlatStyle.Flat;
            buttonExit.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            buttonExit.Location = new Point(50, 983);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(252, 66);
            buttonExit.TabIndex = 46;
            buttonExit.Text = "Back";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // buttonDeactivatePatinet
            // 
            buttonDeactivatePatinet.BackColor = Color.SteelBlue;
            buttonDeactivatePatinet.FlatAppearance.BorderColor = Color.Black;
            buttonDeactivatePatinet.FlatStyle = FlatStyle.Flat;
            buttonDeactivatePatinet.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDeactivatePatinet.Location = new Point(-1, 565);
            buttonDeactivatePatinet.Margin = new Padding(3, 4, 3, 4);
            buttonDeactivatePatinet.Name = "buttonDeactivatePatinet";
            buttonDeactivatePatinet.Size = new Size(360, 65);
            buttonDeactivatePatinet.TabIndex = 45;
            buttonDeactivatePatinet.Text = "Deactivate patient";
            buttonDeactivatePatinet.UseVisualStyleBackColor = false;
            buttonDeactivatePatinet.Click += buttonDeactivatePatinet_Click;
            // 
            // buttonActivatePatient
            // 
            buttonActivatePatient.BackColor = Color.SteelBlue;
            buttonActivatePatient.FlatAppearance.BorderColor = Color.Black;
            buttonActivatePatient.FlatStyle = FlatStyle.Flat;
            buttonActivatePatient.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            buttonActivatePatient.Location = new Point(-1, 492);
            buttonActivatePatient.Margin = new Padding(3, 4, 3, 4);
            buttonActivatePatient.Name = "buttonActivatePatient";
            buttonActivatePatient.Size = new Size(360, 65);
            buttonActivatePatient.TabIndex = 44;
            buttonActivatePatient.Text = "Activate patient";
            buttonActivatePatient.UseVisualStyleBackColor = false;
            buttonActivatePatient.Click += buttonActivatePatient_Click;
            // 
            // buttonRemovePatient
            // 
            buttonRemovePatient.BackColor = Color.SteelBlue;
            buttonRemovePatient.FlatAppearance.BorderColor = Color.Black;
            buttonRemovePatient.FlatStyle = FlatStyle.Flat;
            buttonRemovePatient.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            buttonRemovePatient.Location = new Point(-1, 419);
            buttonRemovePatient.Margin = new Padding(3, 4, 3, 4);
            buttonRemovePatient.Name = "buttonRemovePatient";
            buttonRemovePatient.Size = new Size(360, 65);
            buttonRemovePatient.TabIndex = 43;
            buttonRemovePatient.Text = "Remove patient";
            buttonRemovePatient.UseVisualStyleBackColor = false;
            buttonRemovePatient.Click += buttonRemovePatient_Click;
            // 
            // buttonBack
            // 
            buttonBack.BackColor = Color.Gainsboro;
            buttonBack.FlatAppearance.BorderColor = Color.White;
            buttonBack.FlatAppearance.BorderSize = 2;
            buttonBack.FlatStyle = FlatStyle.Flat;
            buttonBack.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            buttonBack.Location = new Point(33, 1293);
            buttonBack.Margin = new Padding(3, 4, 3, 4);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(288, 88);
            buttonBack.TabIndex = 22;
            buttonBack.Text = "LOG OUT";
            buttonBack.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.MC_Logo;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(90, 12);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(176, 168);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Bernard MT Condensed", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(936, 18);
            label4.Name = "label4";
            label4.Size = new Size(17, 18);
            label4.TabIndex = 42;
            label4.Text = "_";
            label4.Click += label4_Click;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CalendarMonthBackground = SystemColors.Control;
            dateTimePicker2.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(958, 21);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(98, 25);
            dateTimePicker2.TabIndex = 41;
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarMonthBackground = SystemColors.ControlLight;
            dateTimePicker1.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(827, 21);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(98, 25);
            dateTimePicker1.TabIndex = 39;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.BackColor = SystemColors.ButtonFace;
            maskedTextBox1.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Regular, GraphicsUnit.Point);
            maskedTextBox1.Location = new Point(488, 24);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(129, 23);
            maskedTextBox1.TabIndex = 38;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ButtonFace;
            textBox1.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(183, 24);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(129, 23);
            textBox1.TabIndex = 37;
            // 
            // dataGridViewPatientList
            // 
            dataGridViewPatientList.AllowUserToAddRows = false;
            dataGridViewPatientList.AllowUserToDeleteRows = false;
            dataGridViewPatientList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewPatientList.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.SteelBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = Color.SteelBlue;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewPatientList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewPatientList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPatientList.Location = new Point(357, 77);
            dataGridViewPatientList.Name = "dataGridViewPatientList";
            dataGridViewPatientList.ReadOnly = true;
            dataGridViewPatientList.RowHeadersVisible = false;
            dataGridViewPatientList.RowHeadersWidth = 51;
            dataGridViewPatientList.RowTemplate.Height = 29;
            dataGridViewPatientList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewPatientList.Size = new Size(1567, 1060);
            dataGridViewPatientList.TabIndex = 30;
            dataGridViewPatientList.CellContentClick += dataGridViewPatientList_CellContentClick;
            dataGridViewPatientList.CellContentDoubleClick += dataGridViewPatientList_CellContentClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(buttonShowFilters);
            panel2.Controls.Add(pictureBox5);
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(maskedTextBox1);
            panel2.Controls.Add(dateTimePicker2);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Location = new Point(357, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1567, 77);
            panel2.TabIndex = 31;
            panel2.Paint += panel2_Paint;
            // 
            // button1
            // 
            button1.BackColor = Color.Gainsboro;
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(1215, 20);
            button1.Name = "button1";
            button1.Size = new Size(86, 26);
            button1.TabIndex = 49;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // buttonShowFilters
            // 
            buttonShowFilters.BackColor = Color.Gainsboro;
            buttonShowFilters.FlatAppearance.BorderColor = Color.White;
            buttonShowFilters.FlatAppearance.BorderSize = 2;
            buttonShowFilters.FlatStyle = FlatStyle.Flat;
            buttonShowFilters.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonShowFilters.Location = new Point(1101, 20);
            buttonShowFilters.Margin = new Padding(3, 2, 3, 2);
            buttonShowFilters.Name = "buttonShowFilters";
            buttonShowFilters.Size = new Size(86, 26);
            buttonShowFilters.TabIndex = 48;
            buttonShowFilters.Text = "Show";
            buttonShowFilters.UseVisualStyleBackColor = false;
            buttonShowFilters.Click += buttonShowFilters_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.sort;
            pictureBox5.Location = new Point(1486, 21);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(38, 36);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 46;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.sort__1_;
            pictureBox4.Location = new Point(1438, 21);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(41, 36);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 45;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(653, 25);
            label7.Name = "label7";
            label7.Size = new Size(164, 20);
            label7.TabIndex = 2;
            label7.Text = "Date of the latest visit";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(373, 25);
            label6.Name = "label6";
            label6.Size = new Size(109, 20);
            label6.TabIndex = 1;
            label6.Text = "PESEL number";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(31, 26);
            label5.Name = "label5";
            label5.Size = new Size(146, 20);
            label5.TabIndex = 0;
            label5.Text = "Name and surname";
            // 
            // FormPatientList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1920, 1055);
            Controls.Add(panel2);
            Controls.Add(dataGridViewPatientList);
            Controls.Add(buttonClearFilter);
            Controls.Add(buttonFilterEmployee);
            Controls.Add(comboBoxRole);
            Controls.Add(checkBoxIsActive);
            Controls.Add(labelFilter);
            Controls.Add(panel1);
            Font = new Font("Segoe UI Symbol", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormPatientList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormPatientList";
            WindowState = FormWindowState.Maximized;
            Load += FormPatientList_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPatientList).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonClearFilter;
        private Button buttonAddPatient;
        private Button buttonFilterEmployee;
        private ComboBox comboBoxRole;
        private CheckBox checkBoxIsActive;
        private Label labelFilter;
        private Button buttonEditPatient;
        private Panel panel1;
        private Button buttonBack;
        private PictureBox pictureBox1;
        private DataGridView dataGridViewPatientList;
        private Label label4;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private MaskedTextBox maskedTextBox1;
        private TextBox textBox1;
        private Button buttonDeactivatePatinet;
        private Button buttonActivatePatient;
        private Button buttonRemovePatient;
        private Panel panel2;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private Label label7;
        private Label label6;
        private Label label5;
        private Button buttonExit;
        private Button button_ShowDetails;
        private Button button1;
        private Button buttonShowFilters;
    }
}