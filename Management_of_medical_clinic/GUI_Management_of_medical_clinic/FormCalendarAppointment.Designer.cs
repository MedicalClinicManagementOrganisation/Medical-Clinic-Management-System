namespace GUI_Management_of_medical_clinic
{
    partial class FormCalendarAppointment
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
            buttonDisplayAppointments = new Button();
            buttonEditPatient = new Button();
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
            buttonNextMonth = new Button();
            buttonPreviousMonth = new Button();
            buttonToday = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            panel7 = new Panel();
            panel8 = new Panel();
            panel9 = new Panel();
            label9 = new Label();
            labelSelectedDate = new Label();
            labelTitleCalendar_Year = new Label();
            flowLayoutPanelMonth = new FlowLayoutPanel();
            panelDoctor = new Panel();
            labelDoctor = new Label();
            panelTime = new Panel();
            labelTime = new Label();
            dataGridViewAppointment = new DataGridView();
            ColumnDoctor = new DataGridViewTextBoxColumn();
            ColumnTime = new DataGridViewTextBoxColumn();
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
            panelDoctor.SuspendLayout();
            panelTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAppointment).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.SteelBlue;
            panelMenu.Controls.Add(buttonDisplayAppointments);
            panelMenu.Controls.Add(buttonEditPatient);
            panelMenu.Controls.Add(pictureBox1);
            panelMenu.Controls.Add(buttonExit);
            panelMenu.Location = new Point(-3, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(312, 1081);
            panelMenu.TabIndex = 0;
            panelMenu.Paint += panelMenu_Paint;
            // 
            // buttonDisplayAppointments
            // 
            buttonDisplayAppointments.BackColor = Color.SteelBlue;
            buttonDisplayAppointments.FlatAppearance.BorderColor = Color.Black;
            buttonDisplayAppointments.FlatStyle = FlatStyle.Flat;
            buttonDisplayAppointments.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDisplayAppointments.Location = new Point(0, 378);
            buttonDisplayAppointments.Name = "buttonDisplayAppointments";
            buttonDisplayAppointments.Size = new Size(315, 63);
            buttonDisplayAppointments.TabIndex = 47;
            buttonDisplayAppointments.Text = "Display appointments";
            buttonDisplayAppointments.UseVisualStyleBackColor = false;
            buttonDisplayAppointments.Click += buttonDisplayAppointments_Click;
            // 
            // buttonEditPatient
            // 
            buttonEditPatient.BackColor = Color.SteelBlue;
            buttonEditPatient.FlatAppearance.BorderColor = Color.Black;
            buttonEditPatient.FlatStyle = FlatStyle.Flat;
            buttonEditPatient.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            buttonEditPatient.Location = new Point(3, 298);
            buttonEditPatient.Name = "buttonEditPatient";
            buttonEditPatient.Size = new Size(315, 63);
            buttonEditPatient.TabIndex = 22;
            buttonEditPatient.Text = "Add new appointment";
            buttonEditPatient.UseVisualStyleBackColor = false;
            buttonEditPatient.Click += buttonEditPatient_Click;
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
            // buttonNextMonth
            // 
            buttonNextMonth.BackColor = Color.White;
            buttonNextMonth.BackgroundImageLayout = ImageLayout.None;
            buttonNextMonth.FlatAppearance.BorderSize = 0;
            buttonNextMonth.FlatStyle = FlatStyle.Flat;
            buttonNextMonth.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonNextMonth.Location = new Point(260, 25);
            buttonNextMonth.Name = "buttonNextMonth";
            buttonNextMonth.Size = new Size(62, 62);
            buttonNextMonth.TabIndex = 11;
            buttonNextMonth.Text = ">";
            buttonNextMonth.TextAlign = ContentAlignment.TopCenter;
            buttonNextMonth.UseVisualStyleBackColor = false;
            buttonNextMonth.Click += buttonNextMonth_Click;
            // 
            // buttonPreviousMonth
            // 
            buttonPreviousMonth.BackColor = Color.White;
            buttonPreviousMonth.BackgroundImageLayout = ImageLayout.None;
            buttonPreviousMonth.FlatAppearance.BorderSize = 0;
            buttonPreviousMonth.FlatStyle = FlatStyle.Flat;
            buttonPreviousMonth.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonPreviousMonth.Location = new Point(193, 25);
            buttonPreviousMonth.Name = "buttonPreviousMonth";
            buttonPreviousMonth.Size = new Size(62, 62);
            buttonPreviousMonth.TabIndex = 12;
            buttonPreviousMonth.Text = "<";
            buttonPreviousMonth.TextAlign = ContentAlignment.TopCenter;
            buttonPreviousMonth.UseVisualStyleBackColor = false;
            buttonPreviousMonth.Click += buttonPreviousMonth_Click;
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
            buttonToday.Click += buttonToday_Click;
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
            panel9.Controls.Add(label9);
            panel9.Controls.Add(labelSelectedDate);
            panel9.Controls.Add(buttonToday);
            panel9.Controls.Add(labelTitleCalendar_Year);
            panel9.Controls.Add(labelTitleCalendar_Month);
            panel9.Controls.Add(buttonNextMonth);
            panel9.Controls.Add(buttonPreviousMonth);
            panel9.Location = new Point(296, 0);
            panel9.Name = "panel9";
            panel9.Size = new Size(1888, 99);
            panel9.TabIndex = 3;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ImageAlign = ContentAlignment.MiddleRight;
            label9.Location = new Point(805, 29);
            label9.Name = "label9";
            label9.Size = new Size(362, 54);
            label9.TabIndex = 7;
            label9.Text = "AVAILABLE DATES";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelSelectedDate
            // 
            labelSelectedDate.AutoSize = true;
            labelSelectedDate.BackColor = Color.White;
            labelSelectedDate.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            labelSelectedDate.ImageAlign = ContentAlignment.MiddleRight;
            labelSelectedDate.Location = new Point(1299, 40);
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
            // panelDoctor
            // 
            panelDoctor.BackColor = Color.White;
            panelDoctor.Controls.Add(labelDoctor);
            panelDoctor.Cursor = Cursors.PanSouth;
            panelDoctor.Location = new Point(1101, 104);
            panelDoctor.Name = "panelDoctor";
            panelDoctor.Size = new Size(405, 62);
            panelDoctor.TabIndex = 16;
            panelDoctor.Click += panelDoctor_Click;
            // 
            // labelDoctor
            // 
            labelDoctor.AutoSize = true;
            labelDoctor.BackColor = Color.White;
            labelDoctor.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            labelDoctor.ImageAlign = ContentAlignment.MiddleRight;
            labelDoctor.Location = new Point(154, 11);
            labelDoctor.Name = "labelDoctor";
            labelDoctor.Size = new Size(98, 37);
            labelDoctor.TabIndex = 7;
            labelDoctor.Text = "Doctor";
            labelDoctor.TextAlign = ContentAlignment.MiddleCenter;
            labelDoctor.Click += labelDoctor_Click;
            // 
            // panelTime
            // 
            panelTime.BackColor = Color.White;
            panelTime.Controls.Add(labelTime);
            panelTime.Cursor = Cursors.PanSouth;
            panelTime.Location = new Point(1511, 104);
            panelTime.Name = "panelTime";
            panelTime.Size = new Size(405, 62);
            panelTime.TabIndex = 17;
            panelTime.Click += panelTime_Click;
            // 
            // labelTime
            // 
            labelTime.AutoSize = true;
            labelTime.BackColor = Color.White;
            labelTime.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            labelTime.ImageAlign = ContentAlignment.MiddleRight;
            labelTime.Location = new Point(163, 12);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(75, 37);
            labelTime.TabIndex = 7;
            labelTime.Text = "Time";
            labelTime.TextAlign = ContentAlignment.MiddleCenter;
            labelTime.Click += labelTime_Click;
            // 
            // dataGridViewAppointment
            // 
            dataGridViewAppointment.AllowUserToAddRows = false;
            dataGridViewAppointment.AllowUserToDeleteRows = false;
            dataGridViewAppointment.AllowUserToResizeColumns = false;
            dataGridViewAppointment.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.Padding = new Padding(3);
            dataGridViewAppointment.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewAppointment.BackgroundColor = SystemColors.Control;
            dataGridViewAppointment.BorderStyle = BorderStyle.None;
            dataGridViewAppointment.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewAppointment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewAppointment.ColumnHeadersHeight = 60;
            dataGridViewAppointment.ColumnHeadersVisible = false;
            dataGridViewAppointment.Columns.AddRange(new DataGridViewColumn[] { ColumnDoctor, ColumnTime });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridViewAppointment.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewAppointment.Location = new Point(1101, 172);
            dataGridViewAppointment.MultiSelect = false;
            dataGridViewAppointment.Name = "dataGridViewAppointment";
            dataGridViewAppointment.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridViewAppointment.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewAppointment.RowHeadersVisible = false;
            dataGridViewAppointment.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewAppointment.RowTemplate.Height = 40;
            dataGridViewAppointment.RowTemplate.Resizable = DataGridViewTriState.False;
            dataGridViewAppointment.ScrollBars = ScrollBars.Vertical;
            dataGridViewAppointment.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewAppointment.Size = new Size(816, 888);
            dataGridViewAppointment.TabIndex = 16;
            dataGridViewAppointment.CellContentDoubleClick += dataGridViewAppointment_CellContentDoubleClick;
            // 
            // ColumnDoctor
            // 
            ColumnDoctor.HeaderText = "Doctor";
            ColumnDoctor.MinimumWidth = 6;
            ColumnDoctor.Name = "ColumnDoctor";
            ColumnDoctor.ReadOnly = true;
            ColumnDoctor.Width = 408;
            // 
            // ColumnTime
            // 
            ColumnTime.HeaderText = "Time";
            ColumnTime.MinimumWidth = 6;
            ColumnTime.Name = "ColumnTime";
            ColumnTime.ReadOnly = true;
            ColumnTime.Resizable = DataGridViewTriState.False;
            ColumnTime.Width = 408;
            // 
            // FormCalendarAppointment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1920, 1080);
            Controls.Add(panelTime);
            Controls.Add(flowLayoutPanelMonth);
            Controls.Add(panelDoctor);
            Controls.Add(panelMenu);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel5);
            Controls.Add(panel6);
            Controls.Add(panel7);
            Controls.Add(panel8);
            Controls.Add(panel9);
            Controls.Add(dataGridViewAppointment);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormCalendarAppointment";
            Text = "Calendar";
            WindowState = FormWindowState.Maximized;
            Load += FormCalendarAppointment_Load;
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
            panelDoctor.ResumeLayout(false);
            panelDoctor.PerformLayout();
            panelTime.ResumeLayout(false);
            panelTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAppointment).EndInit();
            ResumeLayout(false);
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
        private Button buttonNextMonth;
        private Button buttonPreviousMonth;
        private Button buttonToday;
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
        private Button buttonEditPatient;
        private Button buttonDisplayAppointments;
        private Panel panelDoctor;
        private Label labelDoctor;
        private Panel panelTime;
        private Label labelTime;
        private DataGridView dataGridViewAppointment;
        private DataGridViewTextBoxColumn ColumnDoctor;
        private DataGridViewTextBoxColumn ColumnTime;
        private Label label9;
    }
}