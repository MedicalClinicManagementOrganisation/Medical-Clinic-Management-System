namespace GUI_Management_of_medical_clinic
{
    partial class FormDoctorCurrentCalendar
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panelMenu = new Panel();
            button_ShowVisits = new Button();
            buttonExit = new Button();
            pictureBox1 = new PictureBox();
            flowLayoutPanelMonth = new FlowLayoutPanel();
            panel1 = new Panel();
            labelTitleCalendar_Month = new Label();
            labelTitleCalendar_Year = new Label();
            panel9 = new Panel();
            buttonToday = new Button();
            labelDate = new Label();
            labelTitleCalendarMonth = new Label();
            labelTitleCalendarYear = new Label();
            dataGridViewAppointments = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            Room = new DataGridViewTextBoxColumn();
            Term = new DataGridViewTextBoxColumn();
            Patient = new DataGridViewTextBoxColumn();
            ColumnOffice = new DataGridViewTextBoxColumn();
            ColumnTerm = new DataGridViewTextBoxColumn();
            ColumnPatient = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            label6 = new Label();
            panel3 = new Panel();
            labelMonday = new Label();
            panel4 = new Panel();
            label1 = new Label();
            panel5 = new Panel();
            label3 = new Label();
            panel6 = new Panel();
            label2 = new Label();
            panel7 = new Panel();
            label4 = new Label();
            panel8 = new Panel();
            label5 = new Label();
            panelRoom2 = new Panel();
            labelRoom1 = new Label();
            labelTime1 = new Label();
            panelTime2 = new Panel();
            panelDoctor = new Panel();
            labelPatient = new Label();
            panelStatus = new Panel();
            labelStatus = new Label();
            button_cancelAppointment = new Button();
            panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAppointments).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panelRoom2.SuspendLayout();
            panelTime2.SuspendLayout();
            panelDoctor.SuspendLayout();
            panelStatus.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.SteelBlue;
            panelMenu.Controls.Add(button_ShowVisits);
            panelMenu.Controls.Add(buttonExit);
            panelMenu.Controls.Add(pictureBox1);
            panelMenu.Location = new Point(-3, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(312, 1081);
            panelMenu.TabIndex = 0;
            // 
            // button_ShowVisits
            // 
            button_ShowVisits.BackColor = Color.SteelBlue;
            button_ShowVisits.FlatStyle = FlatStyle.Flat;
            button_ShowVisits.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button_ShowVisits.Location = new Point(-7, 248);
            button_ShowVisits.Name = "button_ShowVisits";
            button_ShowVisits.Size = new Size(329, 87);
            button_ShowVisits.TabIndex = 49;
            button_ShowVisits.Text = "Show Visits";
            button_ShowVisits.UseVisualStyleBackColor = false;
            button_ShowVisits.Click += button_ShowVisits_Click;
            // 
            // buttonExit
            // 
            buttonExit.BackColor = Color.Gainsboro;
            buttonExit.FlatAppearance.BorderColor = Color.White;
            buttonExit.FlatAppearance.BorderSize = 2;
            buttonExit.FlatStyle = FlatStyle.Flat;
            buttonExit.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            buttonExit.Location = new Point(26, 983);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(252, 66);
            buttonExit.TabIndex = 48;
            buttonExit.Text = "Back";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.MC_Logo;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(61, 12);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(176, 168);
            pictureBox1.TabIndex = 47;
            pictureBox1.TabStop = false;
            // 
            // flowLayoutPanelMonth
            // 
            flowLayoutPanelMonth.BackColor = SystemColors.Control;
            flowLayoutPanelMonth.Location = new Point(309, 248);
            flowLayoutPanelMonth.Name = "flowLayoutPanelMonth";
            flowLayoutPanelMonth.Size = new Size(782, 895);
            flowLayoutPanelMonth.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Location = new Point(307, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1888, 77);
            panel1.TabIndex = 2;
            // 
            // labelTitleCalendar_Month
            // 
            labelTitleCalendar_Month.AutoSize = true;
            labelTitleCalendar_Month.BackColor = Color.White;
            labelTitleCalendar_Month.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitleCalendar_Month.Location = new Point(337, 29);
            labelTitleCalendar_Month.Name = "labelTitleCalendar_Month";
            labelTitleCalendar_Month.Size = new Size(149, 54);
            labelTitleCalendar_Month.TabIndex = 10;
            labelTitleCalendar_Month.Text = "Month";
            labelTitleCalendar_Month.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelTitleCalendar_Year
            // 
            labelTitleCalendar_Year.AutoSize = true;
            labelTitleCalendar_Year.BackColor = Color.White;
            labelTitleCalendar_Year.Font = new Font("Segoe UI", 40F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitleCalendar_Year.Location = new Point(1074, 15);
            labelTitleCalendar_Year.Name = "labelTitleCalendar_Year";
            labelTitleCalendar_Year.Size = new Size(154, 72);
            labelTitleCalendar_Year.TabIndex = 17;
            labelTitleCalendar_Year.Text = "2023";
            labelTitleCalendar_Year.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel9
            // 
            panel9.Location = new Point(0, 0);
            panel9.Name = "panel9";
            panel9.Size = new Size(200, 100);
            panel9.TabIndex = 29;
            // 
            // buttonToday
            // 
            buttonToday.BackColor = Color.White;
            buttonToday.FlatAppearance.BorderSize = 0;
            buttonToday.FlatStyle = FlatStyle.Flat;
            buttonToday.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonToday.Location = new Point(20, 25);
            buttonToday.Name = "buttonToday";
            buttonToday.Size = new Size(165, 62);
            buttonToday.TabIndex = 14;
            buttonToday.Text = "Today";
            buttonToday.UseVisualStyleBackColor = false;
            buttonToday.Visible = false;
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelDate.Location = new Point(1385, 129);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(122, 30);
            labelDate.TabIndex = 28;
            labelDate.Text = "Select Date";
            // 
            // labelTitleCalendarMonth
            // 
            labelTitleCalendarMonth.AutoSize = true;
            labelTitleCalendarMonth.BackColor = SystemColors.Control;
            labelTitleCalendarMonth.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitleCalendarMonth.Location = new Point(630, 110);
            labelTitleCalendarMonth.Name = "labelTitleCalendarMonth";
            labelTitleCalendarMonth.Size = new Size(149, 54);
            labelTitleCalendarMonth.TabIndex = 30;
            labelTitleCalendarMonth.Text = "Month";
            labelTitleCalendarMonth.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelTitleCalendarYear
            // 
            labelTitleCalendarYear.AutoSize = true;
            labelTitleCalendarYear.BackColor = SystemColors.Control;
            labelTitleCalendarYear.Font = new Font("Segoe UI", 40F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitleCalendarYear.Location = new Point(937, 95);
            labelTitleCalendarYear.Name = "labelTitleCalendarYear";
            labelTitleCalendarYear.Size = new Size(154, 72);
            labelTitleCalendarYear.TabIndex = 32;
            labelTitleCalendarYear.Text = "2023";
            labelTitleCalendarYear.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridViewAppointments
            // 
            dataGridViewAppointments.AllowUserToAddRows = false;
            dataGridViewAppointments.AllowUserToDeleteRows = false;
            dataGridViewAppointments.AllowUserToResizeColumns = false;
            dataGridViewAppointments.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.Padding = new Padding(3);
            dataGridViewAppointments.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewAppointments.BackgroundColor = Color.Gainsboro;
            dataGridViewAppointments.BorderStyle = BorderStyle.None;
            dataGridViewAppointments.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewAppointments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewAppointments.ColumnHeadersHeight = 60;
            dataGridViewAppointments.ColumnHeadersVisible = false;
            dataGridViewAppointments.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, Status, dataGridViewTextBoxColumn3 });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridViewAppointments.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewAppointments.Location = new Point(1121, 248);
            dataGridViewAppointments.MultiSelect = false;
            dataGridViewAppointments.Name = "dataGridViewAppointments";
            dataGridViewAppointments.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridViewAppointments.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewAppointments.RowHeadersVisible = false;
            dataGridViewAppointments.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewAppointments.RowTemplate.Height = 40;
            dataGridViewAppointments.RowTemplate.Resizable = DataGridViewTriState.False;
            dataGridViewAppointments.ScrollBars = ScrollBars.Vertical;
            dataGridViewAppointments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewAppointments.Size = new Size(668, 783);
            dataGridViewAppointments.TabIndex = 33;
            dataGridViewAppointments.CellClick += dataGridViewAppointments_CellClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Office";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 113;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Term";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 113;
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.Name = "Status";
            Status.ReadOnly = true;
            Status.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn3.HeaderText = "Patient";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // Room
            // 
            Room.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Room.HeaderText = "Room";
            Room.Name = "Room";
            // 
            // Term
            // 
            Term.HeaderText = "Term";
            Term.Name = "Term";
            Term.Width = 40;
            // 
            // Patient
            // 
            Patient.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Patient.HeaderText = "Patient";
            Patient.Name = "Patient";
            // 
            // ColumnOffice
            // 
            ColumnOffice.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            ColumnOffice.HeaderText = "Office";
            ColumnOffice.Name = "ColumnOffice";
            // 
            // ColumnTerm
            // 
            ColumnTerm.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            ColumnTerm.HeaderText = "Term";
            ColumnTerm.Name = "ColumnTerm";
            // 
            // ColumnPatient
            // 
            ColumnPatient.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ColumnPatient.HeaderText = "Patient";
            ColumnPatient.Name = "ColumnPatient";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gainsboro;
            panel2.Controls.Add(label6);
            panel2.Location = new Point(315, 180);
            panel2.Name = "panel2";
            panel2.Size = new Size(105, 62);
            panel2.TabIndex = 36;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Gainsboro;
            label6.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ImageAlign = ContentAlignment.MiddleRight;
            label6.Location = new Point(25, 11);
            label6.Name = "label6";
            label6.Size = new Size(61, 37);
            label6.TabIndex = 9;
            label6.Text = "Sun";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(labelMonday);
            panel3.Location = new Point(426, 180);
            panel3.Name = "panel3";
            panel3.Size = new Size(105, 62);
            panel3.TabIndex = 37;
            // 
            // labelMonday
            // 
            labelMonday.AutoSize = true;
            labelMonday.BackColor = Color.White;
            labelMonday.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            labelMonday.ImageAlign = ContentAlignment.MiddleRight;
            labelMonday.Location = new Point(17, 12);
            labelMonday.Name = "labelMonday";
            labelMonday.Size = new Size(72, 37);
            labelMonday.TabIndex = 3;
            labelMonday.Text = "Mon";
            labelMonday.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(label1);
            panel4.Location = new Point(537, 180);
            panel4.Name = "panel4";
            panel4.Size = new Size(105, 62);
            panel4.TabIndex = 38;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ImageAlign = ContentAlignment.MiddleRight;
            label1.Location = new Point(23, 11);
            label1.Name = "label1";
            label1.Size = new Size(60, 37);
            label1.TabIndex = 4;
            label1.Text = "Tue";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(label3);
            panel5.Location = new Point(648, 180);
            panel5.Name = "panel5";
            panel5.Size = new Size(105, 62);
            panel5.TabIndex = 39;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ImageAlign = ContentAlignment.MiddleRight;
            label3.Location = new Point(17, 12);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.No;
            label3.Size = new Size(71, 37);
            label3.TabIndex = 5;
            label3.Text = "Wed";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(label2);
            panel6.Location = new Point(759, 180);
            panel6.Name = "panel6";
            panel6.Size = new Size(105, 62);
            panel6.TabIndex = 40;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ImageAlign = ContentAlignment.MiddleRight;
            label2.Location = new Point(23, 12);
            label2.Name = "label2";
            label2.Size = new Size(61, 37);
            label2.TabIndex = 6;
            label2.Text = "Thu";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Controls.Add(label4);
            panel7.Location = new Point(870, 180);
            panel7.Name = "panel7";
            panel7.Size = new Size(105, 62);
            panel7.TabIndex = 41;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ImageAlign = ContentAlignment.MiddleRight;
            label4.Location = new Point(27, 12);
            label4.Name = "label4";
            label4.Size = new Size(46, 37);
            label4.TabIndex = 8;
            label4.Text = "Fri";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel8
            // 
            panel8.BackColor = Color.White;
            panel8.Controls.Add(label5);
            panel8.Location = new Point(981, 180);
            panel8.Name = "panel8";
            panel8.Size = new Size(105, 62);
            panel8.TabIndex = 42;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ImageAlign = ContentAlignment.MiddleRight;
            label5.Location = new Point(27, 12);
            label5.Name = "label5";
            label5.Size = new Size(54, 37);
            label5.TabIndex = 7;
            label5.Text = "Sat";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelRoom2
            // 
            panelRoom2.BackColor = Color.White;
            panelRoom2.Controls.Add(labelRoom1);
            panelRoom2.Cursor = Cursors.PanSouth;
            panelRoom2.Location = new Point(1121, 180);
            panelRoom2.Name = "panelRoom2";
            panelRoom2.Size = new Size(113, 62);
            panelRoom2.TabIndex = 45;
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
            // panelTime2
            // 
            panelTime2.BackColor = Color.White;
            panelTime2.Controls.Add(labelTime1);
            panelTime2.Cursor = Cursors.PanSouth;
            panelTime2.Location = new Point(1240, 180);
            panelTime2.Name = "panelTime2";
            panelTime2.Size = new Size(116, 62);
            panelTime2.TabIndex = 44;
            // 
            // panelDoctor
            // 
            panelDoctor.BackColor = Color.White;
            panelDoctor.Controls.Add(labelPatient);
            panelDoctor.Cursor = Cursors.PanSouth;
            panelDoctor.Location = new Point(1522, 180);
            panelDoctor.Name = "panelDoctor";
            panelDoctor.Size = new Size(267, 62);
            panelDoctor.TabIndex = 43;
            // 
            // labelPatient
            // 
            labelPatient.AutoSize = true;
            labelPatient.BackColor = Color.White;
            labelPatient.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            labelPatient.ImageAlign = ContentAlignment.MiddleRight;
            labelPatient.Location = new Point(78, 11);
            labelPatient.Name = "labelPatient";
            labelPatient.Size = new Size(99, 37);
            labelPatient.TabIndex = 7;
            labelPatient.Text = "Patient";
            labelPatient.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelStatus
            // 
            panelStatus.BackColor = Color.White;
            panelStatus.Controls.Add(labelStatus);
            panelStatus.Cursor = Cursors.PanSouth;
            panelStatus.Location = new Point(1362, 180);
            panelStatus.Name = "panelStatus";
            panelStatus.Size = new Size(154, 62);
            panelStatus.TabIndex = 46;
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
            // button_cancelAppointment
            // 
            button_cancelAppointment.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button_cancelAppointment.Location = new Point(1799, 248);
            button_cancelAppointment.Name = "button_cancelAppointment";
            button_cancelAppointment.Size = new Size(113, 57);
            button_cancelAppointment.TabIndex = 47;
            button_cancelAppointment.Text = "Cancel Visit(s)";
            button_cancelAppointment.UseVisualStyleBackColor = true;
            button_cancelAppointment.Click += button_cancelAppointment_Click;
            // 
            // FormDoctorCurrentCalendar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1920, 1080);
            Controls.Add(button_cancelAppointment);
            Controls.Add(panelStatus);
            Controls.Add(panelRoom2);
            Controls.Add(panelTime2);
            Controls.Add(panelDoctor);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel5);
            Controls.Add(panel6);
            Controls.Add(panel7);
            Controls.Add(panel8);
            Controls.Add(dataGridViewAppointments);
            Controls.Add(labelTitleCalendarYear);
            Controls.Add(labelTitleCalendarMonth);
            Controls.Add(labelDate);
            Controls.Add(panel1);
            Controls.Add(panelMenu);
            Controls.Add(panel9);
            Controls.Add(flowLayoutPanelMonth);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormDoctorCurrentCalendar";
            Text = "Calendar";
            WindowState = FormWindowState.Maximized;
            Load += FormDoctorCalendar_Load;
            panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAppointments).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panelRoom2.ResumeLayout(false);
            panelRoom2.PerformLayout();
            panelTime2.ResumeLayout(false);
            panelTime2.PerformLayout();
            panelDoctor.ResumeLayout(false);
            panelDoctor.PerformLayout();
            panelStatus.ResumeLayout(false);
            panelStatus.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelMenu;
        private FlowLayoutPanel flowLayoutPanelMonth;
        private Panel panel1;
        private Label labelTitleCalendar_Month;
        private Label labelTitleCalendar_Year;
        private Panel panel9;
        private PictureBox pictureBox1;
        private Button buttonExit;
        private Button buttonToday;
        private Label labelDate;
        private Label labelTitleCalendarMonth;
        private Label labelTitleCalendarYear;
        private DataGridView dataGridViewAppointments;
        private DataGridViewTextBoxColumn Room;
        private DataGridViewTextBoxColumn Term;
        private DataGridViewTextBoxColumn Patient;
        private DataGridViewTextBoxColumn ColumnOffice;
        private DataGridViewTextBoxColumn ColumnTerm;
        private DataGridViewTextBoxColumn ColumnPatient;
        private Panel panel2;
        private Label label6;
        private Panel panel3;
        private Label labelMonday;
        private Panel panel4;
        private Label label1;
        private Panel panel5;
        private Label label3;
        private Panel panel6;
        private Label label2;
        private Panel panel7;
        private Label label4;
        private Panel panel8;
        private Label label5;
        private Button button_ShowVisits;
        private Panel panelRoom2;
        private Label labelRoom1;
        private Label labelTime1;
        private Panel panelTime2;
        private Panel panelDoctor;
        private Label labelPatient;
        private Panel panelStatus;
        private Label labelStatus;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private Button button_cancelAppointment;
    }
}