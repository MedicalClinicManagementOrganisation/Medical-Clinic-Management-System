namespace GUI_Management_of_medical_clinic
{
    partial class FormCalendarsList
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
            dataGridViewCalendars = new DataGridView();
            buttonLogOut = new Button();
            panel1 = new Panel();
            buttonReviewCalendar = new Button();
            buttonActivateCalendar = new Button();
            button_Clear = new Button();
            pictureBox1 = new PictureBox();
            buttonAddCalendar = new Button();
            buttonRemoveCalendar = new Button();
            panel2 = new Panel();
            buttonSortDescending = new Button();
            buttonSortAscending = new Button();
            textBoxDateReference = new TextBox();
            buttonClearFilter = new Button();
            comboBoxStatus = new ComboBox();
            buttonFilterCalendars = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCalendars).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewCalendars
            // 
            dataGridViewCalendars.AllowUserToAddRows = false;
            dataGridViewCalendars.AllowUserToDeleteRows = false;
            dataGridViewCalendars.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCalendars.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewCalendars.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCalendars.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCalendars.Location = new Point(309, 76);
            dataGridViewCalendars.Name = "dataGridViewCalendars";
            dataGridViewCalendars.ReadOnly = true;
            dataGridViewCalendars.RowHeadersVisible = false;
            dataGridViewCalendars.RowTemplate.Height = 25;
            dataGridViewCalendars.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCalendars.Size = new Size(1611, 1005);
            dataGridViewCalendars.TabIndex = 23;
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
            buttonLogOut.TabIndex = 40;
            buttonLogOut.Text = "LOG OUT";
            buttonLogOut.UseVisualStyleBackColor = false;
            buttonLogOut.Click += buttonLogOut_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(buttonReviewCalendar);
            panel1.Controls.Add(buttonActivateCalendar);
            panel1.Controls.Add(button_Clear);
            panel1.Controls.Add(buttonLogOut);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(buttonAddCalendar);
            panel1.Controls.Add(buttonRemoveCalendar);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(312, 1081);
            panel1.TabIndex = 39;
            // 
            // buttonReviewCalendar
            // 
            buttonReviewCalendar.BackColor = Color.SteelBlue;
            buttonReviewCalendar.FlatStyle = FlatStyle.Flat;
            buttonReviewCalendar.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonReviewCalendar.Location = new Point(-17, 444);
            buttonReviewCalendar.Name = "buttonReviewCalendar";
            buttonReviewCalendar.Size = new Size(329, 87);
            buttonReviewCalendar.TabIndex = 52;
            buttonReviewCalendar.Text = "Review Selected";
            buttonReviewCalendar.UseVisualStyleBackColor = false;
            buttonReviewCalendar.Click += buttonReviewCalendar_Click;
            // 
            // buttonActivateCalendar
            // 
            buttonActivateCalendar.BackColor = Color.SteelBlue;
            buttonActivateCalendar.FlatStyle = FlatStyle.Flat;
            buttonActivateCalendar.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonActivateCalendar.Location = new Point(-17, 537);
            buttonActivateCalendar.Name = "buttonActivateCalendar";
            buttonActivateCalendar.Size = new Size(329, 87);
            buttonActivateCalendar.TabIndex = 51;
            buttonActivateCalendar.Text = "Activate Selected";
            buttonActivateCalendar.UseVisualStyleBackColor = false;
            buttonActivateCalendar.Click += buttonActivateCalendar_Click;
            // 
            // button_Clear
            // 
            button_Clear.BackColor = Color.SteelBlue;
            button_Clear.FlatAppearance.BorderColor = Color.Black;
            button_Clear.FlatStyle = FlatStyle.Flat;
            button_Clear.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button_Clear.Location = new Point(-17, 724);
            button_Clear.Margin = new Padding(3, 4, 3, 4);
            button_Clear.Name = "button_Clear";
            button_Clear.Size = new Size(329, 87);
            button_Clear.TabIndex = 50;
            button_Clear.Text = "Clear the calendars";
            button_Clear.UseVisualStyleBackColor = false;
            button_Clear.Click += button_Clear_Click;
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
            // buttonAddCalendar
            // 
            buttonAddCalendar.BackColor = Color.SteelBlue;
            buttonAddCalendar.FlatStyle = FlatStyle.Flat;
            buttonAddCalendar.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAddCalendar.ForeColor = SystemColors.ActiveCaptionText;
            buttonAddCalendar.Location = new Point(-17, 352);
            buttonAddCalendar.Name = "buttonAddCalendar";
            buttonAddCalendar.Size = new Size(329, 87);
            buttonAddCalendar.TabIndex = 27;
            buttonAddCalendar.Text = "Select Calendar and duplicate it";
            buttonAddCalendar.UseVisualStyleBackColor = false;
            buttonAddCalendar.Click += buttonDuplicateCalendar_Click;
            // 
            // buttonRemoveCalendar
            // 
            buttonRemoveCalendar.BackColor = Color.SteelBlue;
            buttonRemoveCalendar.FlatStyle = FlatStyle.Flat;
            buttonRemoveCalendar.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonRemoveCalendar.Location = new Point(-17, 630);
            buttonRemoveCalendar.Name = "buttonRemoveCalendar";
            buttonRemoveCalendar.Size = new Size(329, 87);
            buttonRemoveCalendar.TabIndex = 28;
            buttonRemoveCalendar.Text = "Delete Selected";
            buttonRemoveCalendar.UseVisualStyleBackColor = false;
            buttonRemoveCalendar.Click += buttonRemoveCalendar_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.Controls.Add(buttonSortDescending);
            panel2.Controls.Add(buttonSortAscending);
            panel2.Controls.Add(textBoxDateReference);
            panel2.Controls.Add(buttonClearFilter);
            panel2.Controls.Add(comboBoxStatus);
            panel2.Controls.Add(buttonFilterCalendars);
            panel2.Location = new Point(309, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1611, 77);
            panel2.TabIndex = 40;
            // 
            // buttonSortDescending
            // 
            buttonSortDescending.BackgroundImage = Properties.Resources.sort;
            buttonSortDescending.BackgroundImageLayout = ImageLayout.Stretch;
            buttonSortDescending.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSortDescending.Location = new Point(1523, 17);
            buttonSortDescending.Name = "buttonSortDescending";
            buttonSortDescending.Size = new Size(41, 36);
            buttonSortDescending.TabIndex = 21;
            buttonSortDescending.UseVisualStyleBackColor = true;
            buttonSortDescending.Click += buttonSortDescending_Click;
            // 
            // buttonSortAscending
            // 
            buttonSortAscending.BackgroundImage = Properties.Resources.sort__1_;
            buttonSortAscending.BackgroundImageLayout = ImageLayout.Stretch;
            buttonSortAscending.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSortAscending.Location = new Point(1451, 17);
            buttonSortAscending.Name = "buttonSortAscending";
            buttonSortAscending.Size = new Size(41, 36);
            buttonSortAscending.TabIndex = 20;
            buttonSortAscending.UseVisualStyleBackColor = true;
            buttonSortAscending.Click += buttonSortAscending_Click;
            // 
            // textBoxDateReference
            // 
            textBoxDateReference.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxDateReference.Location = new Point(101, 24);
            textBoxDateReference.MaximumSize = new Size(271, 36);
            textBoxDateReference.Name = "textBoxDateReference";
            textBoxDateReference.Size = new Size(271, 25);
            textBoxDateReference.TabIndex = 19;
            textBoxDateReference.Visible = false;
            textBoxDateReference.TextChanged += textBoxDateReference_TextChanged;
            // 
            // buttonClearFilter
            // 
            buttonClearFilter.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonClearFilter.Location = new Point(851, 22);
            buttonClearFilter.Name = "buttonClearFilter";
            buttonClearFilter.Size = new Size(103, 26);
            buttonClearFilter.TabIndex = 18;
            buttonClearFilter.Text = "Clear filter";
            buttonClearFilter.UseVisualStyleBackColor = true;
            buttonClearFilter.Click += buttonClearFilter_Click;
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.BackColor = Color.Gainsboro;
            comboBoxStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxStatus.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Items.AddRange(new object[] { "MedicalDoctor", "Nurse", "Janitor", "Technitian" });
            comboBoxStatus.Location = new Point(405, 24);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(271, 25);
            comboBoxStatus.TabIndex = 13;
            // 
            // buttonFilterCalendars
            // 
            buttonFilterCalendars.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonFilterCalendars.Location = new Point(723, 22);
            buttonFilterCalendars.Name = "buttonFilterCalendars";
            buttonFilterCalendars.Size = new Size(92, 26);
            buttonFilterCalendars.TabIndex = 14;
            buttonFilterCalendars.Text = "Filter";
            buttonFilterCalendars.UseVisualStyleBackColor = true;
            buttonFilterCalendars.Click += buttonFilterCalendars_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.SteelBlue;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(-17, 259);
            button1.Name = "button1";
            button1.Size = new Size(329, 87);
            button1.TabIndex = 41;
            button1.Text = "Add or Review Plans and Calendars";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FormCalendarsList
            // 
            AcceptButton = button1;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1920, 1080);
            Controls.Add(button1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(dataGridViewCalendars);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormCalendarsList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCalendarsList";
            WindowState = FormWindowState.Maximized;
            Load += FormCalendarsList_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewCalendars).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewCalendars;
        private Button buttonLogOut;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button buttonAddCalendar;
        private Button buttonRemoveCalendar;
        private Panel panel2;
        private Button buttonClearFilter;
        private ComboBox comboBoxStatus;
        private Button buttonFilterCalendars;
        private Button buttonSortDescending;
        private Button buttonSortAscending;
        private Button button1;
        private Button button_Clear;
        private Button buttonActivateCalendar;
        private Button buttonReviewCalendar;
        private TextBox textBoxDateReference;
    }
}