namespace GUI_Management_of_medical_clinic
{
	partial class FormDoctorPatientVisitDetails
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelOffice = new System.Windows.Forms.Label();
            this.labelDoctor = new System.Windows.Forms.Label();
            this.labelPatient = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonBack = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelPESEL = new System.Windows.Forms.Label();
            this.labelSpecialization = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelCost = new System.Windows.Forms.Label();
            this.textBoxSpecialization = new System.Windows.Forms.TextBox();
            this.textBoxPESEL = new System.Windows.Forms.TextBox();
            this.textBoxPatient = new System.Windows.Forms.TextBox();
            this.textBoxDoktor = new System.Windows.Forms.TextBox();
            this.textBoxOffice = new System.Windows.Forms.TextBox();
            this.numericUpDownCost = new System.Windows.Forms.NumericUpDown();
            this.textBoxHour = new System.Windows.Forms.TextBox();
            this.labelHour = new System.Windows.Forms.Label();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox_result = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCost)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.Location = new System.Drawing.Point(368, 19);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(348, 46);
            this.labelTitle.TabIndex = 79;
            this.labelTitle.Text = "Appointment details";
            // 
            // labelOffice
            // 
            this.labelOffice.AutoSize = true;
            this.labelOffice.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelOffice.Location = new System.Drawing.Point(900, 347);
            this.labelOffice.Name = "labelOffice";
            this.labelOffice.Size = new System.Drawing.Size(67, 28);
            this.labelOffice.TabIndex = 78;
            this.labelOffice.Text = "Office:";
            // 
            // labelDoctor
            // 
            this.labelDoctor.AutoSize = true;
            this.labelDoctor.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDoctor.Location = new System.Drawing.Point(900, 100);
            this.labelDoctor.Name = "labelDoctor";
            this.labelDoctor.Size = new System.Drawing.Size(77, 28);
            this.labelDoctor.TabIndex = 77;
            this.labelDoctor.Text = "Doctor:";
            // 
            // labelPatient
            // 
            this.labelPatient.AutoSize = true;
            this.labelPatient.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPatient.Location = new System.Drawing.Point(373, 100);
            this.labelPatient.Name = "labelPatient";
            this.labelPatient.Size = new System.Drawing.Size(76, 28);
            this.labelPatient.TabIndex = 76;
            this.labelPatient.Text = "Patient:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.buttonBack);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(312, 1102);
            this.panel1.TabIndex = 75;
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonBack.CausesValidation = false;
            this.buttonBack.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonBack.FlatAppearance.BorderSize = 2;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonBack.Location = new System.Drawing.Point(29, 970);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(252, 66);
            this.buttonBack.TabIndex = 22;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::GUI_Management_of_medical_clinic.Properties.Resources.MC_Logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(61, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 168);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // labelPESEL
            // 
            this.labelPESEL.AutoSize = true;
            this.labelPESEL.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPESEL.Location = new System.Drawing.Point(373, 223);
            this.labelPESEL.Name = "labelPESEL";
            this.labelPESEL.Size = new System.Drawing.Size(67, 28);
            this.labelPESEL.TabIndex = 84;
            this.labelPESEL.Text = "PESEL:";
            // 
            // labelSpecialization
            // 
            this.labelSpecialization.AutoSize = true;
            this.labelSpecialization.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSpecialization.Location = new System.Drawing.Point(900, 223);
            this.labelSpecialization.Name = "labelSpecialization";
            this.labelSpecialization.Size = new System.Drawing.Size(137, 28);
            this.labelSpecialization.TabIndex = 87;
            this.labelSpecialization.Text = "Specialization:";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDate.Location = new System.Drawing.Point(374, 347);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(57, 28);
            this.labelDate.TabIndex = 90;
            this.labelDate.Text = "Date:";
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCost.Location = new System.Drawing.Point(900, 469);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(55, 28);
            this.labelCost.TabIndex = 92;
            this.labelCost.Text = "Cost:";
            // 
            // textBoxSpecialization
            // 
            this.textBoxSpecialization.Enabled = false;
            this.textBoxSpecialization.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSpecialization.Location = new System.Drawing.Point(900, 269);
            this.textBoxSpecialization.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSpecialization.Name = "textBoxSpecialization";
            this.textBoxSpecialization.Size = new System.Drawing.Size(453, 34);
            this.textBoxSpecialization.TabIndex = 100;
            // 
            // textBoxPESEL
            // 
            this.textBoxPESEL.Enabled = false;
            this.textBoxPESEL.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPESEL.Location = new System.Drawing.Point(374, 269);
            this.textBoxPESEL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPESEL.Name = "textBoxPESEL";
            this.textBoxPESEL.Size = new System.Drawing.Size(453, 34);
            this.textBoxPESEL.TabIndex = 101;
            // 
            // textBoxPatient
            // 
            this.textBoxPatient.Enabled = false;
            this.textBoxPatient.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPatient.Location = new System.Drawing.Point(374, 146);
            this.textBoxPatient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPatient.Name = "textBoxPatient";
            this.textBoxPatient.Size = new System.Drawing.Size(453, 34);
            this.textBoxPatient.TabIndex = 102;
            // 
            // textBoxDoktor
            // 
            this.textBoxDoktor.Enabled = false;
            this.textBoxDoktor.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxDoktor.Location = new System.Drawing.Point(900, 146);
            this.textBoxDoktor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxDoktor.Name = "textBoxDoktor";
            this.textBoxDoktor.Size = new System.Drawing.Size(453, 34);
            this.textBoxDoktor.TabIndex = 103;
            // 
            // textBoxOffice
            // 
            this.textBoxOffice.Enabled = false;
            this.textBoxOffice.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxOffice.Location = new System.Drawing.Point(900, 393);
            this.textBoxOffice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxOffice.Name = "textBoxOffice";
            this.textBoxOffice.Size = new System.Drawing.Size(453, 34);
            this.textBoxOffice.TabIndex = 104;
            // 
            // numericUpDownCost
            // 
            this.numericUpDownCost.DecimalPlaces = 2;
            this.numericUpDownCost.Enabled = false;
            this.numericUpDownCost.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericUpDownCost.Location = new System.Drawing.Point(900, 513);
            this.numericUpDownCost.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownCost.Name = "numericUpDownCost";
            this.numericUpDownCost.Size = new System.Drawing.Size(453, 34);
            this.numericUpDownCost.TabIndex = 105;
            // 
            // textBoxHour
            // 
            this.textBoxHour.Enabled = false;
            this.textBoxHour.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxHour.Location = new System.Drawing.Point(373, 513);
            this.textBoxHour.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxHour.Name = "textBoxHour";
            this.textBoxHour.Size = new System.Drawing.Size(453, 34);
            this.textBoxHour.TabIndex = 106;
            // 
            // labelHour
            // 
            this.labelHour.AutoSize = true;
            this.labelHour.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelHour.Location = new System.Drawing.Point(373, 469);
            this.labelHour.Name = "labelHour";
            this.labelHour.Size = new System.Drawing.Size(60, 28);
            this.labelHour.TabIndex = 107;
            this.labelHour.Text = "Hour:";
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Enabled = false;
            this.dateTimePickerDate.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerDate.Location = new System.Drawing.Point(374, 393);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(453, 34);
            this.dateTimePickerDate.TabIndex = 108;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(373, 577);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 28);
            this.label1.TabIndex = 110;
            this.label1.Text = "Result:";
            // 
            // richTextBox_result
            // 
            this.richTextBox_result.Enabled = false;
            this.richTextBox_result.Location = new System.Drawing.Point(373, 618);
            this.richTextBox_result.Name = "richTextBox_result";
            this.richTextBox_result.Size = new System.Drawing.Size(454, 175);
            this.richTextBox_result.TabIndex = 111;
            this.richTextBox_result.Text = "";
            // 
            // FormDoctorPatientVisitDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.richTextBox_result);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerDate);
            this.Controls.Add(this.labelHour);
            this.Controls.Add(this.textBoxHour);
            this.Controls.Add(this.numericUpDownCost);
            this.Controls.Add(this.textBoxOffice);
            this.Controls.Add(this.textBoxDoktor);
            this.Controls.Add(this.textBoxPatient);
            this.Controls.Add(this.textBoxPESEL);
            this.Controls.Add(this.textBoxSpecialization);
            this.Controls.Add(this.labelCost);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelSpecialization);
            this.Controls.Add(this.labelPESEL);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelOffice);
            this.Controls.Add(this.labelDoctor);
            this.Controls.Add(this.labelPatient);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDoctorPatientVisitDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormShowDetailsAppointment";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Label labelTitle;
		private Label labelOffice;
		private Label labelDoctor;
		private Label labelPatient;
		private Panel panel1;
		private Button buttonBack;
		private PictureBox pictureBox1;
		private Label labelPESEL;
		private Label labelSpecialization;
		private Label labelDate;
		private Label labelCost;
		private TextBox textBoxSpecialization;
		private TextBox textBoxPESEL;
		private TextBox textBoxPatient;
		private TextBox textBoxDoktor;
		private TextBox textBoxOffice;
		private NumericUpDown numericUpDownCost;
		private TextBox textBoxHour;
		private Label labelHour;
		private DateTimePicker dateTimePickerDate;
		private Label label1;
        private RichTextBox richTextBox_result;
    }
}