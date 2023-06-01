namespace GUI_Management_of_medical_clinic
{
    partial class FormDoctorAppointmentList
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
            panel1 = new Panel();
            buttonRemove = new Button();
            buttonShowDetails = new Button();
            buttonExit = new Button();
            pictureBox1 = new PictureBox();
            dataGridViewAppointmentList = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            ColumnPatient = new DataGridViewTextBoxColumn();
            Columnfirstname = new DataGridViewTextBoxColumn();
            ColumnPESEL = new DataGridViewTextBoxColumn();
            ColumnDate = new DataGridViewTextBoxColumn();
            ColumnHour = new DataGridViewTextBoxColumn();
            ColumnOffice = new DataGridViewTextBoxColumn();
            ColumnCost = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            checkBoxDateOfVisit = new CheckBox();
            maskedTextBoxPESEL = new MaskedTextBox();
            buttonClearFiltr = new Button();
            buttonAddFiltr = new Button();
            dateTimePickerDateOfVisit = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            textBoxLastName = new TextBox();
            label1 = new Label();
            textBoxName = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAppointmentList).BeginInit();
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
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(buttonRemove);
            panel1.Controls.Add(buttonShowDetails);
            panel1.Controls.Add(buttonExit);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(357, 1080);
            panel1.TabIndex = 29;
            // 
            // buttonRemove
            // 
            buttonRemove.BackColor = Color.SteelBlue;
            buttonRemove.FlatAppearance.BorderColor = Color.Black;
            buttonRemove.FlatStyle = FlatStyle.Flat;
            buttonRemove.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            buttonRemove.Location = new Point(-1, 346);
            buttonRemove.Margin = new Padding(3, 4, 3, 4);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(360, 65);
            buttonRemove.TabIndex = 48;
            buttonRemove.Text = "Cancel appointment";
            buttonRemove.UseVisualStyleBackColor = false;
            buttonRemove.Click += buttonRemove_Click;
            // 
            // buttonShowDetails
            // 
            buttonShowDetails.BackColor = Color.SteelBlue;
            buttonShowDetails.FlatAppearance.BorderColor = Color.Black;
            buttonShowDetails.FlatStyle = FlatStyle.Flat;
            buttonShowDetails.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            buttonShowDetails.Location = new Point(-1, 273);
            buttonShowDetails.Margin = new Padding(3, 4, 3, 4);
            buttonShowDetails.Name = "buttonShowDetails";
            buttonShowDetails.Size = new Size(360, 65);
            buttonShowDetails.TabIndex = 47;
            buttonShowDetails.Text = "[Show details]";
            buttonShowDetails.UseVisualStyleBackColor = false;
            buttonShowDetails.Click += buttonShowDetails_Click;
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
            buttonExit.Text = "Cancel";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
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
            // dataGridViewAppointmentList
            // 
            dataGridViewAppointmentList.AllowUserToAddRows = false;
            dataGridViewAppointmentList.AllowUserToDeleteRows = false;
            dataGridViewAppointmentList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewAppointmentList.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.SteelBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = Color.SteelBlue;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewAppointmentList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewAppointmentList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAppointmentList.Columns.AddRange(new DataGridViewColumn[] { Column1, ColumnPatient, Columnfirstname, ColumnPESEL, ColumnDate, ColumnHour, ColumnOffice, ColumnCost });
            dataGridViewAppointmentList.Location = new Point(357, 84);
            dataGridViewAppointmentList.MultiSelect = false;
            dataGridViewAppointmentList.Name = "dataGridViewAppointmentList";
            dataGridViewAppointmentList.ReadOnly = true;
            dataGridViewAppointmentList.RowHeadersVisible = false;
            dataGridViewAppointmentList.RowHeadersWidth = 51;
            dataGridViewAppointmentList.RowTemplate.Height = 29;
            dataGridViewAppointmentList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewAppointmentList.Size = new Size(1564, 1053);
            dataGridViewAppointmentList.TabIndex = 30;
            // 
            // Column1
            // 
            Column1.HeaderText = "IdVisit";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Visible = false;
            // 
            // ColumnPatient
            // 
            ColumnPatient.HeaderText = "Last name";
            ColumnPatient.Name = "ColumnPatient";
            ColumnPatient.ReadOnly = true;
            // 
            // Columnfirstname
            // 
            Columnfirstname.HeaderText = "First Name";
            Columnfirstname.Name = "Columnfirstname";
            Columnfirstname.ReadOnly = true;
            // 
            // ColumnPESEL
            // 
            ColumnPESEL.HeaderText = "PESEL";
            ColumnPESEL.Name = "ColumnPESEL";
            ColumnPESEL.ReadOnly = true;
            // 
            // ColumnDate
            // 
            ColumnDate.HeaderText = "Date";
            ColumnDate.Name = "ColumnDate";
            ColumnDate.ReadOnly = true;
            // 
            // ColumnHour
            // 
            ColumnHour.HeaderText = "Hour";
            ColumnHour.Name = "ColumnHour";
            ColumnHour.ReadOnly = true;
            // 
            // ColumnOffice
            // 
            ColumnOffice.HeaderText = "Office";
            ColumnOffice.Name = "ColumnOffice";
            ColumnOffice.ReadOnly = true;
            // 
            // ColumnCost
            // 
            ColumnCost.HeaderText = "Cost";
            ColumnCost.Name = "ColumnCost";
            ColumnCost.ReadOnly = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.Controls.Add(pictureBox5);
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(checkBoxDateOfVisit);
            panel2.Controls.Add(maskedTextBoxPESEL);
            panel2.Controls.Add(buttonClearFiltr);
            panel2.Controls.Add(buttonAddFiltr);
            panel2.Controls.Add(dateTimePickerDateOfVisit);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(textBoxLastName);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(textBoxName);
            panel2.Location = new Point(357, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1567, 212);
            panel2.TabIndex = 31;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.sort;
            pictureBox5.Location = new Point(249, 21);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(38, 35);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 47;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.sort__1_;
            pictureBox4.Location = new Point(202, 20);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(41, 36);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 46;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // checkBoxDateOfVisit
            // 
            checkBoxDateOfVisit.AutoSize = true;
            checkBoxDateOfVisit.Location = new Point(710, 8);
            checkBoxDateOfVisit.Name = "checkBoxDateOfVisit";
            checkBoxDateOfVisit.Size = new Size(88, 19);
            checkBoxDateOfVisit.TabIndex = 15;
            checkBoxDateOfVisit.Text = "Date of visit";
            checkBoxDateOfVisit.UseVisualStyleBackColor = true;
            // 
            // maskedTextBoxPESEL
            // 
            maskedTextBoxPESEL.Location = new Point(508, 31);
            maskedTextBoxPESEL.Mask = "00000000000";
            maskedTextBoxPESEL.Name = "maskedTextBoxPESEL";
            maskedTextBoxPESEL.Size = new Size(178, 23);
            maskedTextBoxPESEL.TabIndex = 14;
            maskedTextBoxPESEL.ValidatingType = typeof(DateTime);
            // 
            // buttonClearFiltr
            // 
            buttonClearFiltr.Location = new Point(1153, 30);
            buttonClearFiltr.Name = "buttonClearFiltr";
            buttonClearFiltr.Size = new Size(117, 23);
            buttonClearFiltr.TabIndex = 13;
            buttonClearFiltr.Text = "Clear";
            buttonClearFiltr.UseVisualStyleBackColor = true;
            buttonClearFiltr.Click += buttonClearFiltr_Click;
            // 
            // buttonAddFiltr
            // 
            buttonAddFiltr.Location = new Point(1044, 30);
            buttonAddFiltr.Name = "buttonAddFiltr";
            buttonAddFiltr.Size = new Size(103, 23);
            buttonAddFiltr.TabIndex = 12;
            buttonAddFiltr.Text = "Set filters";
            buttonAddFiltr.UseVisualStyleBackColor = true;
            buttonAddFiltr.Click += buttonAddFiltr_Click;
            // 
            // dateTimePickerDateOfVisit
            // 
            dateTimePickerDateOfVisit.Format = DateTimePickerFormat.Short;
            dateTimePickerDateOfVisit.Location = new Point(710, 30);
            dateTimePickerDateOfVisit.Name = "dateTimePickerDateOfVisit";
            dateTimePickerDateOfVisit.Size = new Size(178, 23);
            dateTimePickerDateOfVisit.TabIndex = 6;
            dateTimePickerDateOfVisit.Value = new DateTime(2023, 5, 2, 0, 0, 0, 0);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(508, 9);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 5;
            label3.Text = "PESEL";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 12);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 3;
            label2.Text = "Last name";
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(15, 33);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(178, 23);
            textBoxLastName.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(304, 10);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 1;
            label1.Text = "Name";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(304, 31);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(178, 23);
            textBoxName.TabIndex = 0;
            // 
            // FormDoctorAppointmentList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1920, 1055);
            Controls.Add(dataGridViewAppointmentList);
            Controls.Add(panel2);
            Controls.Add(buttonClearFilter);
            Controls.Add(panel1);
            Font = new Font("Segoe UI Symbol", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormDoctorAppointmentList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormPatientList";
            WindowState = FormWindowState.Maximized;
            Load += FormDoctorAppointmentList_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAppointmentList).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonClearFilter;
        private Button buttonAddPatient;
        private Button buttonEditPatient;
        private Panel panel1;
        private PictureBox pictureBox1;
        private DataGridView dataGridViewAppointmentList;
        private Button buttonDeactivatePatinet;
        private Button buttonActivatePatient;
        private Button buttonRemovePatient;
        private Panel panel2;
        private Button buttonExit;
        private Button buttonShowDetails;
        private Button buttonRemove;
        private Button buttonViewAppointments;
        private TextBox textBoxLastName;
        private TextBox textBoxName;
        private DateTimePicker dateTimePickerDateOfVisit;
        private Button buttonClearFiltr;
        private Button buttonAddFiltr;
        private MaskedTextBox maskedTextBoxPESEL;
        private Label label3;
        private Label label2;
        private Label label1;
        private CheckBox checkBoxDateOfVisit;
        private CheckBox checkBoxName;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn ColumnPatient;
        private DataGridViewTextBoxColumn Columnfirstname;
        private DataGridViewTextBoxColumn ColumnPESEL;
        private DataGridViewTextBoxColumn ColumnDate;
        private DataGridViewTextBoxColumn ColumnHour;
        private DataGridViewTextBoxColumn ColumnOffice;
        private DataGridViewTextBoxColumn ColumnCost;
    }
}