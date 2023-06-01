namespace GUI_Management_of_medical_clinic
{
    partial class FormDoctorDashboard
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            buttonLogOut = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            buttonCalendar = new Button();
            buttonCurrentCalendar = new Button();
            button_patients = new Button();
            label1 = new Label();
            dataGridViewVisits = new DataGridView();
            Room = new DataGridViewTextBoxColumn();
            Hour = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            Patient = new DataGridViewTextBoxColumn();
            PatientId = new DataGridViewTextBoxColumn();
            label2 = new Label();
            labelBirthday = new Label();
            labelSex = new Label();
            labelPESEL = new Label();
            labelFullName = new Label();
            panelStatus = new Panel();
            labelStatus = new Label();
            panelRoom2 = new Panel();
            labelRoom1 = new Label();
            panelTime2 = new Panel();
            labelTime1 = new Label();
            panelDoctor = new Panel();
            labelPatient = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVisits).BeginInit();
            panelStatus.SuspendLayout();
            panelRoom2.SuspendLayout();
            panelTime2.SuspendLayout();
            panelDoctor.SuspendLayout();
            SuspendLayout();
            // 
            // buttonLogOut
            // 
            buttonLogOut.BackColor = Color.Gainsboro;
            buttonLogOut.FlatAppearance.BorderColor = Color.White;
            buttonLogOut.FlatAppearance.BorderSize = 2;
            buttonLogOut.FlatStyle = FlatStyle.Flat;
            buttonLogOut.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            buttonLogOut.Location = new Point(23, 884);
            buttonLogOut.Name = "buttonLogOut";
            buttonLogOut.Size = new Size(252, 66);
            buttonLogOut.TabIndex = 40;
            buttonLogOut.Text = "LOG OUT";
            buttonLogOut.UseVisualStyleBackColor = false;
            buttonLogOut.Click += buttonLogOut_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(buttonLogOut);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(buttonCalendar);
            panel1.Controls.Add(buttonCurrentCalendar);
            panel1.Controls.Add(button_patients);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(312, 1081);
            panel1.TabIndex = 39;
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
            // buttonCalendar
            // 
            buttonCalendar.BackColor = Color.SteelBlue;
            buttonCalendar.FlatStyle = FlatStyle.Flat;
            buttonCalendar.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCalendar.ForeColor = SystemColors.ActiveCaptionText;
            buttonCalendar.Location = new Point(-7, 259);
            buttonCalendar.Name = "buttonCalendar";
            buttonCalendar.Size = new Size(329, 87);
            buttonCalendar.TabIndex = 27;
            buttonCalendar.Text = "Calendar";
            buttonCalendar.UseVisualStyleBackColor = false;
            buttonCalendar.Click += buttonCalendar_Click;
            // 
            // buttonCurrentCalendar
            // 
            buttonCurrentCalendar.BackColor = Color.SteelBlue;
            buttonCurrentCalendar.FlatStyle = FlatStyle.Flat;
            buttonCurrentCalendar.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCurrentCalendar.ForeColor = SystemColors.ActiveCaptionText;
            buttonCurrentCalendar.Location = new Point(-7, 352);
            buttonCurrentCalendar.Name = "buttonCurrentCalendar";
            buttonCurrentCalendar.Size = new Size(329, 87);
            buttonCurrentCalendar.TabIndex = 33;
            buttonCurrentCalendar.Text = "Current calendar";
            buttonCurrentCalendar.UseVisualStyleBackColor = false;
            buttonCurrentCalendar.Click += buttonCurrentCalendar_Click;
            // 
            // button_patients
            // 
            button_patients.BackColor = Color.SteelBlue;
            button_patients.FlatStyle = FlatStyle.Flat;
            button_patients.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button_patients.Location = new Point(-7, 445);
            button_patients.Name = "button_patients";
            button_patients.Size = new Size(329, 87);
            button_patients.TabIndex = 28;
            button_patients.Text = "Patients";
            button_patients.UseVisualStyleBackColor = false;
            button_patients.Click += button_patients_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(396, 31);
            label1.Name = "label1";
            label1.Size = new Size(420, 65);
            label1.TabIndex = 40;
            label1.Text = "Welcome message";
            // 
            // dataGridViewVisits
            // 
            dataGridViewVisits.AllowUserToAddRows = false;
            dataGridViewVisits.AllowUserToDeleteRows = false;
            dataGridViewVisits.AllowUserToResizeColumns = false;
            dataGridViewVisits.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.Padding = new Padding(3);
            dataGridViewVisits.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewVisits.BackgroundColor = SystemColors.Control;
            dataGridViewVisits.BorderStyle = BorderStyle.None;
            dataGridViewVisits.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewVisits.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewVisits.ColumnHeadersHeight = 60;
            dataGridViewVisits.ColumnHeadersVisible = false;
            dataGridViewVisits.Columns.AddRange(new DataGridViewColumn[] { Room, Hour, Status, Patient, PatientId });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridViewVisits.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewVisits.Location = new Point(386, 259);
            dataGridViewVisits.Name = "dataGridViewVisits";
            dataGridViewVisits.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridViewVisits.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewVisits.RowHeadersVisible = false;
            dataGridViewVisits.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewVisits.RowTemplate.Height = 40;
            dataGridViewVisits.RowTemplate.Resizable = DataGridViewTriState.False;
            dataGridViewVisits.ScrollBars = ScrollBars.Vertical;
            dataGridViewVisits.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewVisits.Size = new Size(744, 374);
            dataGridViewVisits.TabIndex = 46;
            dataGridViewVisits.CellClick += dataGridViewVisits_CellClick;
            dataGridViewVisits.CellContentClick += dataGridViewVisits_CellClick;
            // 
            // Room
            // 
            Room.HeaderText = "Room";
            Room.Name = "Room";
            Room.ReadOnly = true;
            Room.Width = 113;
            // 
            // Hour
            // 
            Hour.HeaderText = "Hour";
            Hour.Name = "Hour";
            Hour.ReadOnly = true;
            Hour.Width = 113;
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.Name = "Status";
            Status.ReadOnly = true;
            Status.Width = 200;
            // 
            // Patient
            // 
            Patient.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Patient.HeaderText = "Patient";
            Patient.Name = "Patient";
            Patient.ReadOnly = true;
            // 
            // PatientId
            // 
            PatientId.HeaderText = "PatientId";
            PatientId.Name = "PatientId";
            PatientId.ReadOnly = true;
            PatientId.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(396, 96);
            label2.Name = "label2";
            label2.Size = new Size(103, 45);
            label2.TabIndex = 47;
            label2.Text = "[date]";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelBirthday
            // 
            labelBirthday.AutoSize = true;
            labelBirthday.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelBirthday.Location = new Point(1199, 479);
            labelBirthday.Name = "labelBirthday";
            labelBirthday.Size = new Size(97, 30);
            labelBirthday.TabIndex = 51;
            labelBirthday.Text = "Birthday";
            // 
            // labelSex
            // 
            labelSex.AutoSize = true;
            labelSex.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelSex.Location = new Point(1199, 398);
            labelSex.Name = "labelSex";
            labelSex.Size = new Size(48, 30);
            labelSex.TabIndex = 50;
            labelSex.Text = "Sex";
            // 
            // labelPESEL
            // 
            labelPESEL.AutoSize = true;
            labelPESEL.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelPESEL.Location = new Point(1199, 318);
            labelPESEL.Name = "labelPESEL";
            labelPESEL.Size = new Size(71, 30);
            labelPESEL.TabIndex = 49;
            labelPESEL.Text = "PESEL";
            // 
            // labelFullName
            // 
            labelFullName.AutoSize = true;
            labelFullName.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelFullName.Location = new Point(1199, 239);
            labelFullName.Name = "labelFullName";
            labelFullName.Size = new Size(113, 30);
            labelFullName.TabIndex = 48;
            labelFullName.Text = "Full Name";
            // 
            // panelStatus
            // 
            panelStatus.BackColor = Color.White;
            panelStatus.Controls.Add(labelStatus);
            panelStatus.Cursor = Cursors.PanSouth;
            panelStatus.Location = new Point(627, 191);
            panelStatus.Name = "panelStatus";
            panelStatus.Size = new Size(154, 62);
            panelStatus.TabIndex = 55;
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.BackColor = Color.White;
            labelStatus.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            labelStatus.ImageAlign = ContentAlignment.MiddleRight;
            labelStatus.Location = new Point(36, 12);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(88, 37);
            labelStatus.TabIndex = 7;
            labelStatus.Text = "Status";
            labelStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelRoom2
            // 
            panelRoom2.BackColor = Color.White;
            panelRoom2.Controls.Add(labelRoom1);
            panelRoom2.Cursor = Cursors.PanSouth;
            panelRoom2.Location = new Point(386, 191);
            panelRoom2.Name = "panelRoom2";
            panelRoom2.Size = new Size(113, 62);
            panelRoom2.TabIndex = 54;
            // 
            // labelRoom1
            // 
            labelRoom1.AutoSize = true;
            labelRoom1.BackColor = Color.White;
            labelRoom1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            labelRoom1.ImageAlign = ContentAlignment.MiddleRight;
            labelRoom1.Location = new Point(14, 11);
            labelRoom1.Name = "labelRoom1";
            labelRoom1.Size = new Size(87, 37);
            labelRoom1.TabIndex = 7;
            labelRoom1.Text = "Room";
            labelRoom1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelTime2
            // 
            panelTime2.BackColor = Color.White;
            panelTime2.Controls.Add(labelTime1);
            panelTime2.Cursor = Cursors.PanSouth;
            panelTime2.Location = new Point(505, 191);
            panelTime2.Name = "panelTime2";
            panelTime2.Size = new Size(116, 62);
            panelTime2.TabIndex = 53;
            // 
            // labelTime1
            // 
            labelTime1.AutoSize = true;
            labelTime1.BackColor = Color.White;
            labelTime1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            labelTime1.ImageAlign = ContentAlignment.MiddleRight;
            labelTime1.Location = new Point(21, 11);
            labelTime1.Name = "labelTime1";
            labelTime1.Size = new Size(75, 37);
            labelTime1.TabIndex = 7;
            labelTime1.Text = "Time";
            labelTime1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelDoctor
            // 
            panelDoctor.BackColor = Color.White;
            panelDoctor.Controls.Add(labelPatient);
            panelDoctor.Cursor = Cursors.PanSouth;
            panelDoctor.Location = new Point(787, 191);
            panelDoctor.Name = "panelDoctor";
            panelDoctor.Size = new Size(343, 62);
            panelDoctor.TabIndex = 52;
            // 
            // labelPatient
            // 
            labelPatient.AutoSize = true;
            labelPatient.BackColor = Color.White;
            labelPatient.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            labelPatient.ImageAlign = ContentAlignment.MiddleRight;
            labelPatient.Location = new Point(116, 12);
            labelPatient.Name = "labelPatient";
            labelPatient.Size = new Size(99, 37);
            labelPatient.TabIndex = 7;
            labelPatient.Text = "Patient";
            labelPatient.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(1196, 273);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(410, 36);
            textBox1.TabIndex = 56;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(1196, 352);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(410, 36);
            textBox2.TabIndex = 57;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(1196, 432);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(410, 36);
            textBox3.TabIndex = 58;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(1196, 513);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(410, 36);
            textBox4.TabIndex = 57;
            // 
            // FormDoctorDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1698, 996);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(panelStatus);
            Controls.Add(panelRoom2);
            Controls.Add(panelTime2);
            Controls.Add(panelDoctor);
            Controls.Add(labelBirthday);
            Controls.Add(labelSex);
            Controls.Add(labelPESEL);
            Controls.Add(labelFullName);
            Controls.Add(label2);
            Controls.Add(dataGridViewVisits);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormDoctorDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormOfficeList";
            WindowState = FormWindowState.Maximized;
            Load += FormDoctorDashboard_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVisits).EndInit();
            panelStatus.ResumeLayout(false);
            panelStatus.PerformLayout();
            panelRoom2.ResumeLayout(false);
            panelRoom2.PerformLayout();
            panelTime2.ResumeLayout(false);
            panelTime2.PerformLayout();
            panelDoctor.ResumeLayout(false);
            panelDoctor.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonLogOut;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button buttonCalendar;
        private Button buttonCurrentCalendar;
        private Button button_patients;
        private Label label1;
        private DataGridView dataGridViewVisits;
        private Label label2;
        private Label labelBirthday;
        private Label labelSex;
        private Label labelPESEL;
        private Label labelFullName;
        private Panel panelStatus;
        private Label labelStatus;
        private Panel panelRoom2;
        private Label labelRoom1;
        private Panel panelTime2;
        private Label labelTime1;
        private Panel panelDoctor;
        private Label labelPatient;
        private DataGridViewTextBoxColumn Room;
        private DataGridViewTextBoxColumn Hour;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn Patient;
        private DataGridViewTextBoxColumn PatientId;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
    }
}