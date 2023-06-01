namespace GUI_Management_of_medical_clinic
{
    partial class FormDoctorCalendarInChosenMonth
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            panelMenu = new Panel();
            buttonRejectCalendar = new Button();
            buttonAcceptCalendar = new Button();
            pictureBox1 = new PictureBox();
            buttonExit = new Button();
            labelTitleCalendar_Month = new Label();
            labelMonday = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label4 = new Label();
            label6 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            panel7 = new Panel();
            panel8 = new Panel();
            panel9 = new Panel();
            labelSelectedDate = new Label();
            labelTitleCalendar_Year = new Label();
            flowLayoutPanelMonth = new FlowLayoutPanel();
            panelTime = new Panel();
            labelTime = new Label();
            dataGridViewTerms = new DataGridView();
            ColumnTime = new DataGridViewTextBoxColumn();
            RoomNumber = new DataGridViewTextBoxColumn();
            IdDoctorPlanDay = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            labelRoom = new Label();
            button_cancelAppointment = new Button();
            button_modifyAppointment = new Button();
            dataGridViewOtherAppointments = new DataGridView();
            Doctor = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            panelRoom2 = new Panel();
            labelRoom1 = new Label();
            panelTime2 = new Panel();
            labelTime1 = new Label();
            panelDoctor = new Panel();
            labelDoctor = new Label();
            labelDuty = new Label();
            button_createTerm = new Button();
            panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            panelTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTerms).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOtherAppointments).BeginInit();
            panelRoom2.SuspendLayout();
            panelTime2.SuspendLayout();
            panelDoctor.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.SteelBlue;
            panelMenu.Controls.Add(buttonRejectCalendar);
            panelMenu.Controls.Add(buttonAcceptCalendar);
            panelMenu.Controls.Add(pictureBox1);
            panelMenu.Controls.Add(buttonExit);
            panelMenu.Location = new Point(-3, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(312, 1081);
            panelMenu.TabIndex = 0;
            // 
            // buttonRejectCalendar
            // 
            buttonRejectCalendar.BackColor = Color.SteelBlue;
            buttonRejectCalendar.FlatAppearance.BorderColor = Color.Black;
            buttonRejectCalendar.FlatStyle = FlatStyle.Flat;
            buttonRejectCalendar.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            buttonRejectCalendar.Location = new Point(0, 367);
            buttonRejectCalendar.Name = "buttonRejectCalendar";
            buttonRejectCalendar.Size = new Size(315, 63);
            buttonRejectCalendar.TabIndex = 48;
            buttonRejectCalendar.Text = "Reject calendar";
            buttonRejectCalendar.UseVisualStyleBackColor = false;
            buttonRejectCalendar.Click += buttonRejectCalendar_Click;
            // 
            // buttonAcceptCalendar
            // 
            buttonAcceptCalendar.BackColor = Color.SteelBlue;
            buttonAcceptCalendar.FlatAppearance.BorderColor = Color.Black;
            buttonAcceptCalendar.FlatStyle = FlatStyle.Flat;
            buttonAcceptCalendar.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAcceptCalendar.Location = new Point(3, 298);
            buttonAcceptCalendar.Name = "buttonAcceptCalendar";
            buttonAcceptCalendar.Size = new Size(315, 63);
            buttonAcceptCalendar.TabIndex = 22;
            buttonAcceptCalendar.Text = "Accept calendar";
            buttonAcceptCalendar.UseVisualStyleBackColor = false;
            buttonAcceptCalendar.Click += buttonAcceptCalendar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.MC_Logo;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(61, 12);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(176, 168);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
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
            buttonExit.TabIndex = 46;
            buttonExit.Text = "Cancel";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // labelTitleCalendar_Month
            // 
            labelTitleCalendar_Month.AutoSize = true;
            labelTitleCalendar_Month.BackColor = Color.White;
            labelTitleCalendar_Month.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitleCalendar_Month.Location = new Point(482, 27);
            labelTitleCalendar_Month.Name = "labelTitleCalendar_Month";
            labelTitleCalendar_Month.Size = new Size(149, 54);
            labelTitleCalendar_Month.TabIndex = 10;
            labelTitleCalendar_Month.Text = "Month";
            labelTitleCalendar_Month.TextAlign = ContentAlignment.MiddleCenter;
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
            // panel2
            // 
            panel2.BackColor = Color.Gainsboro;
            panel2.Controls.Add(label6);
            panel2.Location = new Point(311, 104);
            panel2.Name = "panel2";
            panel2.Size = new Size(105, 62);
            panel2.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(labelMonday);
            panel3.Location = new Point(422, 104);
            panel3.Name = "panel3";
            panel3.Size = new Size(105, 62);
            panel3.TabIndex = 10;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(label1);
            panel4.Location = new Point(533, 104);
            panel4.Name = "panel4";
            panel4.Size = new Size(105, 62);
            panel4.TabIndex = 11;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(label3);
            panel5.Location = new Point(644, 104);
            panel5.Name = "panel5";
            panel5.Size = new Size(105, 62);
            panel5.TabIndex = 12;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(label2);
            panel6.Location = new Point(755, 104);
            panel6.Name = "panel6";
            panel6.Size = new Size(105, 62);
            panel6.TabIndex = 13;
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Controls.Add(label4);
            panel7.Location = new Point(866, 104);
            panel7.Name = "panel7";
            panel7.Size = new Size(105, 62);
            panel7.TabIndex = 14;
            // 
            // panel8
            // 
            panel8.BackColor = Color.White;
            panel8.Controls.Add(label5);
            panel8.Location = new Point(977, 104);
            panel8.Name = "panel8";
            panel8.Size = new Size(105, 62);
            panel8.TabIndex = 15;
            // 
            // panel9
            // 
            panel9.BackColor = Color.White;
            panel9.Controls.Add(labelSelectedDate);
            panel9.Controls.Add(labelTitleCalendar_Year);
            panel9.Controls.Add(labelTitleCalendar_Month);
            panel9.Location = new Point(296, 0);
            panel9.Name = "panel9";
            panel9.Size = new Size(1888, 99);
            panel9.TabIndex = 3;
            // 
            // labelSelectedDate
            // 
            labelSelectedDate.AutoSize = true;
            labelSelectedDate.BackColor = Color.White;
            labelSelectedDate.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            labelSelectedDate.ImageAlign = ContentAlignment.MiddleRight;
            labelSelectedDate.Location = new Point(819, 47);
            labelSelectedDate.Name = "labelSelectedDate";
            labelSelectedDate.Size = new Size(0, 37);
            labelSelectedDate.TabIndex = 8;
            labelSelectedDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelTitleCalendar_Year
            // 
            labelTitleCalendar_Year.AutoSize = true;
            labelTitleCalendar_Year.BackColor = Color.White;
            labelTitleCalendar_Year.Font = new Font("Segoe UI", 40F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitleCalendar_Year.Location = new Point(328, 12);
            labelTitleCalendar_Year.Name = "labelTitleCalendar_Year";
            labelTitleCalendar_Year.Size = new Size(154, 72);
            labelTitleCalendar_Year.TabIndex = 17;
            labelTitleCalendar_Year.Text = "2023";
            labelTitleCalendar_Year.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanelMonth
            // 
            flowLayoutPanelMonth.BackColor = SystemColors.Control;
            flowLayoutPanelMonth.Location = new Point(309, 172);
            flowLayoutPanelMonth.Name = "flowLayoutPanelMonth";
            flowLayoutPanelMonth.Size = new Size(782, 895);
            flowLayoutPanelMonth.TabIndex = 1;
            // 
            // panelTime
            // 
            panelTime.BackColor = Color.White;
            panelTime.Controls.Add(labelTime);
            panelTime.Cursor = Cursors.PanSouth;
            panelTime.Location = new Point(1101, 105);
            panelTime.Name = "panelTime";
            panelTime.Size = new Size(282, 62);
            panelTime.TabIndex = 17;
            panelTime.Click += panelTime_Click;
            // 
            // labelTime
            // 
            labelTime.AutoSize = true;
            labelTime.BackColor = Color.White;
            labelTime.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            labelTime.ImageAlign = ContentAlignment.MiddleRight;
            labelTime.Location = new Point(103, 11);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(75, 37);
            labelTime.TabIndex = 7;
            labelTime.Text = "Time";
            labelTime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridViewTerms
            // 
            dataGridViewTerms.AllowUserToAddRows = false;
            dataGridViewTerms.AllowUserToDeleteRows = false;
            dataGridViewTerms.AllowUserToResizeColumns = false;
            dataGridViewTerms.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.Padding = new Padding(3);
            dataGridViewTerms.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewTerms.BackgroundColor = SystemColors.Control;
            dataGridViewTerms.BorderStyle = BorderStyle.None;
            dataGridViewTerms.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewTerms.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewTerms.ColumnHeadersHeight = 60;
            dataGridViewTerms.ColumnHeadersVisible = false;
            dataGridViewTerms.Columns.AddRange(new DataGridViewColumn[] { ColumnTime, RoomNumber, IdDoctorPlanDay });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridViewTerms.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewTerms.Location = new Point(1101, 171);
            dataGridViewTerms.Name = "dataGridViewTerms";
            dataGridViewTerms.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridViewTerms.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewTerms.RowHeadersVisible = false;
            dataGridViewTerms.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewTerms.RowTemplate.Height = 40;
            dataGridViewTerms.RowTemplate.Resizable = DataGridViewTriState.False;
            dataGridViewTerms.ScrollBars = ScrollBars.Vertical;
            dataGridViewTerms.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTerms.Size = new Size(522, 374);
            dataGridViewTerms.TabIndex = 16;
            dataGridViewTerms.CellClick += dataGridViewAppointment_CellContentClick;
            // 
            // ColumnTime
            // 
            ColumnTime.HeaderText = "Time";
            ColumnTime.MinimumWidth = 6;
            ColumnTime.Name = "ColumnTime";
            ColumnTime.ReadOnly = true;
            ColumnTime.Resizable = DataGridViewTriState.False;
            ColumnTime.Width = 261;
            // 
            // RoomNumber
            // 
            RoomNumber.HeaderText = "Room Number";
            RoomNumber.MinimumWidth = 6;
            RoomNumber.Name = "RoomNumber";
            RoomNumber.ReadOnly = true;
            RoomNumber.Resizable = DataGridViewTriState.False;
            RoomNumber.Width = 261;
            // 
            // IdDoctorPlanDay
            // 
            IdDoctorPlanDay.HeaderText = "IdDoctor";
            IdDoctorPlanDay.Name = "IdDoctorPlanDay";
            IdDoctorPlanDay.ReadOnly = true;
            IdDoctorPlanDay.Visible = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(labelRoom);
            panel1.Cursor = Cursors.PanSouth;
            panel1.Location = new Point(1389, 105);
            panel1.Name = "panel1";
            panel1.Size = new Size(234, 62);
            panel1.TabIndex = 18;
            panel1.Click += panel1_Click;
            // 
            // labelRoom
            // 
            labelRoom.AutoSize = true;
            labelRoom.BackColor = Color.White;
            labelRoom.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            labelRoom.ImageAlign = ContentAlignment.MiddleRight;
            labelRoom.Location = new Point(21, 12);
            labelRoom.Name = "labelRoom";
            labelRoom.Size = new Size(186, 37);
            labelRoom.TabIndex = 7;
            labelRoom.Text = "Room number";
            labelRoom.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button_cancelAppointment
            // 
            button_cancelAppointment.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button_cancelAppointment.Location = new Point(1670, 191);
            button_cancelAppointment.Name = "button_cancelAppointment";
            button_cancelAppointment.Size = new Size(238, 57);
            button_cancelAppointment.TabIndex = 20;
            button_cancelAppointment.Text = "Reject term(s)";
            button_cancelAppointment.UseVisualStyleBackColor = true;
            button_cancelAppointment.Click += button_cancelAppointment_Click;
            // 
            // button_modifyAppointment
            // 
            button_modifyAppointment.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button_modifyAppointment.Location = new Point(1670, 317);
            button_modifyAppointment.Name = "button_modifyAppointment";
            button_modifyAppointment.Size = new Size(238, 57);
            button_modifyAppointment.TabIndex = 21;
            button_modifyAppointment.Text = "Modify term";
            button_modifyAppointment.UseVisualStyleBackColor = true;
            button_modifyAppointment.Click += button_modifyAppointment_Click;
            // 
            // dataGridViewOtherAppointments
            // 
            dataGridViewOtherAppointments.AllowUserToAddRows = false;
            dataGridViewOtherAppointments.AllowUserToDeleteRows = false;
            dataGridViewOtherAppointments.AllowUserToResizeColumns = false;
            dataGridViewOtherAppointments.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.Padding = new Padding(3);
            dataGridViewOtherAppointments.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewOtherAppointments.BackgroundColor = SystemColors.Control;
            dataGridViewOtherAppointments.BorderStyle = BorderStyle.None;
            dataGridViewOtherAppointments.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridViewOtherAppointments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewOtherAppointments.ColumnHeadersHeight = 60;
            dataGridViewOtherAppointments.ColumnHeadersVisible = false;
            dataGridViewOtherAppointments.Columns.AddRange(new DataGridViewColumn[] { Doctor, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = SystemColors.Window;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            dataGridViewOtherAppointments.DefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewOtherAppointments.Location = new Point(1100, 700);
            dataGridViewOtherAppointments.MultiSelect = false;
            dataGridViewOtherAppointments.Name = "dataGridViewOtherAppointments";
            dataGridViewOtherAppointments.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Control;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dataGridViewOtherAppointments.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewOtherAppointments.RowHeadersVisible = false;
            dataGridViewOtherAppointments.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewOtherAppointments.RowTemplate.Height = 40;
            dataGridViewOtherAppointments.RowTemplate.Resizable = DataGridViewTriState.False;
            dataGridViewOtherAppointments.ScrollBars = ScrollBars.Vertical;
            dataGridViewOtherAppointments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewOtherAppointments.Size = new Size(523, 367);
            dataGridViewOtherAppointments.TabIndex = 22;
            // 
            // Doctor
            // 
            Doctor.HeaderText = "Doctor";
            Doctor.Name = "Doctor";
            Doctor.ReadOnly = true;
            Doctor.Width = 290;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Time";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Resizable = DataGridViewTriState.False;
            dataGridViewTextBoxColumn2.Width = 120;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Room Number";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Resizable = DataGridViewTriState.False;
            dataGridViewTextBoxColumn3.Width = 120;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "IdDoctor";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.Visible = false;
            // 
            // panelRoom2
            // 
            panelRoom2.BackColor = Color.White;
            panelRoom2.Controls.Add(labelRoom1);
            panelRoom2.Cursor = Cursors.PanSouth;
            panelRoom2.Location = new Point(1510, 631);
            panelRoom2.Name = "panelRoom2";
            panelRoom2.Size = new Size(113, 62);
            panelRoom2.TabIndex = 21;
            panelRoom2.Click += panelRoom2_Click;
            // 
            // labelRoom1
            // 
            labelRoom1.AutoSize = true;
            labelRoom1.BackColor = Color.White;
            labelRoom1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            labelRoom1.ImageAlign = ContentAlignment.MiddleRight;
            labelRoom1.Location = new Point(17, 12);
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
            panelTime2.Location = new Point(1389, 631);
            panelTime2.Name = "panelTime2";
            panelTime2.Size = new Size(116, 62);
            panelTime2.TabIndex = 20;
            panelTime2.Click += panelTime2_Click;
            // 
            // labelTime1
            // 
            labelTime1.AutoSize = true;
            labelTime1.BackColor = Color.White;
            labelTime1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            labelTime1.ImageAlign = ContentAlignment.MiddleRight;
            labelTime1.Location = new Point(23, 12);
            labelTime1.Name = "labelTime1";
            labelTime1.Size = new Size(75, 37);
            labelTime1.TabIndex = 7;
            labelTime1.Text = "Time";
            labelTime1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelDoctor
            // 
            panelDoctor.BackColor = Color.White;
            panelDoctor.Controls.Add(labelDoctor);
            panelDoctor.Cursor = Cursors.PanSouth;
            panelDoctor.Location = new Point(1100, 631);
            panelDoctor.Name = "panelDoctor";
            panelDoctor.Size = new Size(285, 62);
            panelDoctor.TabIndex = 19;
            panelDoctor.Click += panelDoctor_Click;
            // 
            // labelDoctor
            // 
            labelDoctor.AutoSize = true;
            labelDoctor.BackColor = Color.White;
            labelDoctor.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            labelDoctor.ImageAlign = ContentAlignment.MiddleRight;
            labelDoctor.Location = new Point(85, 11);
            labelDoctor.Name = "labelDoctor";
            labelDoctor.Size = new Size(98, 37);
            labelDoctor.TabIndex = 7;
            labelDoctor.Text = "Doctor";
            labelDoctor.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelDuty
            // 
            labelDuty.AutoSize = true;
            labelDuty.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelDuty.Location = new Point(1185, 580);
            labelDuty.Name = "labelDuty";
            labelDuty.Size = new Size(361, 30);
            labelDuty.TabIndex = 23;
            labelDuty.Text = "Other doctor's duties in chosen day";
            // 
            // button_createTerm
            // 
            button_createTerm.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button_createTerm.Location = new Point(1670, 254);
            button_createTerm.Name = "button_createTerm";
            button_createTerm.Size = new Size(238, 57);
            button_createTerm.TabIndex = 25;
            button_createTerm.Text = "Create new term(s)";
            button_createTerm.UseVisualStyleBackColor = true;
            button_createTerm.Click += button_createTerm_Click;
            // 
            // FormDoctorCalendarInChosenMonth
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1920, 1080);
            Controls.Add(button_createTerm);
            Controls.Add(labelDuty);
            Controls.Add(panelRoom2);
            Controls.Add(dataGridViewOtherAppointments);
            Controls.Add(panelTime2);
            Controls.Add(button_modifyAppointment);
            Controls.Add(panelDoctor);
            Controls.Add(button_cancelAppointment);
            Controls.Add(panel1);
            Controls.Add(panelTime);
            Controls.Add(flowLayoutPanelMonth);
            Controls.Add(panelMenu);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel5);
            Controls.Add(panel6);
            Controls.Add(panel7);
            Controls.Add(panel8);
            Controls.Add(panel9);
            Controls.Add(dataGridViewTerms);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormDoctorCalendarInChosenMonth";
            Text = "Calendar";
            WindowState = FormWindowState.Maximized;
            Load += FormDoctorCalendarInChosenMonth_Load;
            panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panelTime.ResumeLayout(false);
            panelTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTerms).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOtherAppointments).EndInit();
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

        private Panel panelMenu;
        private Label labelMonday;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label4;
        private Label label6;
        private Label labelTitleCalendar_Month;
        private Button buttonExit;
        private Label labelDate;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Panel panel8;
        private Panel panel9;
        private FlowLayoutPanel flowLayoutPanelMonth;
        private Label labelTitleCalendar_Year;
        private Label labelSelectedDate;
        private Button buttonAcceptCalendar;
        private Panel panelTime;
        private Label labelTime;
        private DataGridView dataGridViewTerms;
        private Panel panel1;
        private Label labelRoom;
        private Button buttonRejectCalendar;
        private Button button_cancelAppointment;
        private Button button_modifyAppointment;
        private DataGridView dataGridViewOtherAppointments;
        private Panel panelRoom2;
        private Label labelRoom1;
        private Panel panelTime2;
        private Label labelTime1;
        private Panel panelDoctor;
        private Label labelDoctor;
        private DataGridViewTextBoxColumn Doctor;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private Label labelDuty;
        private Button button_createTerm;
        private DataGridViewTextBoxColumn ColumnTime;
        private DataGridViewTextBoxColumn RoomNumber;
        private DataGridViewTextBoxColumn IdDoctorPlanDay;
    }
}