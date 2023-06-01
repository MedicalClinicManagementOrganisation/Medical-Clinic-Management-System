namespace GUI_Management_of_medical_clinic
{
    partial class FormDoctorCalendarDetails
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
            panel1 = new Panel();
            buttonBack = new Button();
            pictureBox1 = new PictureBox();
            labelDetailsAppointment = new Label();
            lblOfficeNumber = new Label();
            lblTerm = new Label();
            lblAppDate = new Label();
            buttonModify = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(buttonBack);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(312, 1081);
            panel1.TabIndex = 39;
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
            buttonBack.TabIndex = 42;
            buttonBack.Text = "Back";
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
            // labelDetailsAppointment
            // 
            labelDetailsAppointment.AutoSize = true;
            labelDetailsAppointment.FlatStyle = FlatStyle.Flat;
            labelDetailsAppointment.Font = new Font("Segoe UI", 25F, FontStyle.Bold, GraphicsUnit.Point);
            labelDetailsAppointment.Location = new Point(372, 12);
            labelDetailsAppointment.Name = "labelDetailsAppointment";
            labelDetailsAppointment.Size = new Size(348, 46);
            labelDetailsAppointment.TabIndex = 56;
            labelDetailsAppointment.Text = "Appointment details";
            // 
            // lblOfficeNumber
            // 
            lblOfficeNumber.AutoSize = true;
            lblOfficeNumber.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblOfficeNumber.Location = new Point(382, 283);
            lblOfficeNumber.Name = "lblOfficeNumber";
            lblOfficeNumber.Size = new Size(140, 28);
            lblOfficeNumber.TabIndex = 60;
            lblOfficeNumber.Text = "Office number:";
            // 
            // lblTerm
            // 
            lblTerm.AutoSize = true;
            lblTerm.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblTerm.Location = new Point(382, 220);
            lblTerm.Name = "lblTerm";
            lblTerm.Size = new Size(58, 28);
            lblTerm.TabIndex = 58;
            lblTerm.Text = "Term:";
            // 
            // lblAppDate
            // 
            lblAppDate.AutoSize = true;
            lblAppDate.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblAppDate.Location = new Point(382, 161);
            lblAppDate.Name = "lblAppDate";
            lblAppDate.Size = new Size(57, 28);
            lblAppDate.TabIndex = 61;
            lblAppDate.Text = "Date:";
            // 
            // buttonModify
            // 
            buttonModify.BackColor = Color.Gainsboro;
            buttonModify.FlatStyle = FlatStyle.Flat;
            buttonModify.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            buttonModify.ForeColor = SystemColors.ControlText;
            buttonModify.Location = new Point(382, 970);
            buttonModify.Name = "buttonModify";
            buttonModify.Size = new Size(453, 65);
            buttonModify.TabIndex = 66;
            buttonModify.Text = "Modify";
            buttonModify.UseVisualStyleBackColor = false;
            buttonModify.Click += buttonConfirm_Click;
            // 
            // FormDoctorCalendarDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1920, 1080);
            Controls.Add(buttonModify);
            Controls.Add(lblAppDate);
            Controls.Add(lblOfficeNumber);
            Controls.Add(lblTerm);
            Controls.Add(labelDetailsAppointment);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormDoctorCalendarDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormOfficeList";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label labelDetailsAppointment;
        private Label lblOfficeNumber;
        private Label lblTerm;
        private Label lblAppDate;
        internal Button buttonModify;
        private Button buttonBack;
    }
}