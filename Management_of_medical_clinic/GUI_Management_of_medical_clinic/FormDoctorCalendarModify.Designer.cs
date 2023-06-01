namespace GUI_Management_of_medical_clinic
{
    partial class FormDoctorCalendarModify
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
            buttonLogOut = new Button();
            panel1 = new Panel();
            buttonCancel = new Button();
            pictureBox1 = new PictureBox();
            labelModifyAppointment = new Label();
            labelOfficeNumber = new Label();
            labelTime = new Label();
            dateTimePicker = new DateTimePicker();
            labelDateOfVisit = new Label();
            comboBoxOfficeNumber = new ComboBox();
            comboBoxTerm = new ComboBox();
            buttonConfirm = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
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
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(buttonCancel);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(312, 1081);
            panel1.TabIndex = 39;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.Gainsboro;
            buttonCancel.FlatAppearance.BorderColor = Color.White;
            buttonCancel.FlatAppearance.BorderSize = 2;
            buttonCancel.FlatStyle = FlatStyle.Flat;
            buttonCancel.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCancel.Location = new Point(29, 970);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(252, 66);
            buttonCancel.TabIndex = 41;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
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
            // labelModifyAppointment
            // 
            labelModifyAppointment.AutoSize = true;
            labelModifyAppointment.FlatStyle = FlatStyle.Flat;
            labelModifyAppointment.Font = new Font("Segoe UI", 25F, FontStyle.Bold, GraphicsUnit.Point);
            labelModifyAppointment.Location = new Point(372, 12);
            labelModifyAppointment.Name = "labelModifyAppointment";
            labelModifyAppointment.Size = new Size(139, 46);
            labelModifyAppointment.TabIndex = 56;
            labelModifyAppointment.Text = "[Mode]";
            // 
            // labelOfficeNumber
            // 
            labelOfficeNumber.AutoSize = true;
            labelOfficeNumber.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelOfficeNumber.Location = new Point(380, 394);
            labelOfficeNumber.Name = "labelOfficeNumber";
            labelOfficeNumber.Size = new Size(140, 28);
            labelOfficeNumber.TabIndex = 60;
            labelOfficeNumber.Text = "Office number:";
            // 
            // labelTime
            // 
            labelTime.AutoSize = true;
            labelTime.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelTime.Location = new Point(381, 259);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(177, 28);
            labelTime.TabIndex = 58;
            labelTime.Text = "Appointment time:";
            // 
            // dateTimePicker
            // 
            dateTimePicker.CustomFormat = "";
            dateTimePicker.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker.Location = new Point(381, 165);
            dateTimePicker.MaxDate = new DateTime(2123, 9, 9, 0, 0, 0, 0);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(454, 34);
            dateTimePicker.TabIndex = 62;
            dateTimePicker.Value = new DateTime(2023, 4, 6, 0, 0, 0, 0);
            // 
            // labelDateOfVisit
            // 
            labelDateOfVisit.AutoSize = true;
            labelDateOfVisit.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelDateOfVisit.Location = new Point(381, 115);
            labelDateOfVisit.Name = "labelDateOfVisit";
            labelDateOfVisit.Size = new Size(177, 28);
            labelDateOfVisit.TabIndex = 61;
            labelDateOfVisit.Text = "Appointment date:";
            // 
            // comboBoxOfficeNumber
            // 
            comboBoxOfficeNumber.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxOfficeNumber.FormattingEnabled = true;
            comboBoxOfficeNumber.ItemHeight = 28;
            comboBoxOfficeNumber.Location = new Point(382, 436);
            comboBoxOfficeNumber.Margin = new Padding(3, 2, 3, 2);
            comboBoxOfficeNumber.Name = "comboBoxOfficeNumber";
            comboBoxOfficeNumber.Size = new Size(453, 36);
            comboBoxOfficeNumber.TabIndex = 63;
            // 
            // comboBoxTerm
            // 
            comboBoxTerm.DropDownHeight = 200;
            comboBoxTerm.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTerm.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxTerm.FormattingEnabled = true;
            comboBoxTerm.IntegralHeight = false;
            comboBoxTerm.ItemHeight = 28;
            comboBoxTerm.Items.AddRange(new object[] { "07:00 ", "07:20", "07:40", "08:00", "08:20", "08:40", "09:00", "09:20", "09:40", "10:00", "10:20", "10:40", "11:20", "11:40", "12:00", "12:20", "12:40", "13:00", "13:20 ", "13:40", "14:00 ", "14:20 ", "14:40", "15:00 ", "15:40", "16:00", "16:20", "16:40 ", "17:00", "17:20", "17:40 ", "18:00", "18:20", "18:40", "19:00", "19:20", "19:40" });
            comboBoxTerm.Location = new Point(381, 301);
            comboBoxTerm.Name = "comboBoxTerm";
            comboBoxTerm.Size = new Size(454, 36);
            comboBoxTerm.TabIndex = 64;
            // 
            // buttonConfirm
            // 
            buttonConfirm.BackColor = Color.Gainsboro;
            buttonConfirm.FlatStyle = FlatStyle.Flat;
            buttonConfirm.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            buttonConfirm.ForeColor = SystemColors.ControlText;
            buttonConfirm.Location = new Point(382, 970);
            buttonConfirm.Name = "buttonConfirm";
            buttonConfirm.Size = new Size(453, 65);
            buttonConfirm.TabIndex = 66;
            buttonConfirm.Text = "Confirm";
            buttonConfirm.UseVisualStyleBackColor = false;
            buttonConfirm.Click += buttonConfirm_Click;
            // 
            // FormDoctorCalendarModify
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1920, 1080);
            Controls.Add(buttonConfirm);
            Controls.Add(comboBoxTerm);
            Controls.Add(comboBoxOfficeNumber);
            Controls.Add(dateTimePicker);
            Controls.Add(labelDateOfVisit);
            Controls.Add(labelOfficeNumber);
            Controls.Add(labelTime);
            Controls.Add(labelModifyAppointment);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormDoctorCalendarModify";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormOfficeList";
            WindowState = FormWindowState.Maximized;
            Load += FormDoctorCalendarModify_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonLogOut;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label labelModifyAppointment;
        private Label labelOfficeNumber;
        private Label labelTime;
        private DateTimePicker dateTimePicker;
        private Label labelDateOfVisit;
        private ComboBox comboBoxOfficeNumber;
        private ComboBox comboBoxTerm;
        internal Button buttonConfirm;
        private Button buttonCancel;
    }
}