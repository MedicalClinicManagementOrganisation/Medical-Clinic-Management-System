namespace GUI_Management_of_medical_clinic
{
	partial class FormShowDetailsAppointment
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
			labelTitle = new Label();
			labelOffice = new Label();
			labelDoctor = new Label();
			labelPatient = new Label();
			panel1 = new Panel();
			buttonBack = new Button();
			pictureBox1 = new PictureBox();
			labelPESEL = new Label();
			labelSpecialization = new Label();
			labelDate = new Label();
			labelCost = new Label();
			textBoxSpecialization = new TextBox();
			textBoxPESEL = new TextBox();
			textBoxPatient = new TextBox();
			textBoxDoktor = new TextBox();
			textBoxOffice = new TextBox();
			numericUpDownCost = new NumericUpDown();
			textBoxHour = new TextBox();
			labelHour = new Label();
			dateTimePickerDate = new DateTimePicker();
			buttonGeneratePDF = new Button();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)numericUpDownCost).BeginInit();
			SuspendLayout();
			// 
			// labelTitle
			// 
			labelTitle.AutoSize = true;
			labelTitle.FlatStyle = FlatStyle.Flat;
			labelTitle.Font = new Font("Segoe UI", 25F, FontStyle.Bold, GraphicsUnit.Point);
			labelTitle.Location = new Point(368, 19);
			labelTitle.Name = "labelTitle";
			labelTitle.Size = new Size(346, 46);
			labelTitle.TabIndex = 79;
			labelTitle.Text = "Details appointment";
			// 
			// labelOffice
			// 
			labelOffice.AutoSize = true;
			labelOffice.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
			labelOffice.Location = new Point(900, 347);
			labelOffice.Name = "labelOffice";
			labelOffice.Size = new Size(67, 28);
			labelOffice.TabIndex = 78;
			labelOffice.Text = "Office:";
			// 
			// labelDoctor
			// 
			labelDoctor.AutoSize = true;
			labelDoctor.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
			labelDoctor.Location = new Point(900, 100);
			labelDoctor.Name = "labelDoctor";
			labelDoctor.Size = new Size(77, 28);
			labelDoctor.TabIndex = 77;
			labelDoctor.Text = "Doctor:";
			// 
			// labelPatient
			// 
			labelPatient.AutoSize = true;
			labelPatient.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
			labelPatient.Location = new Point(373, 100);
			labelPatient.Name = "labelPatient";
			labelPatient.Size = new Size(76, 28);
			labelPatient.TabIndex = 76;
			labelPatient.Text = "Patient:";
			// 
			// panel1
			// 
			panel1.BackColor = Color.SteelBlue;
			panel1.Controls.Add(buttonBack);
			panel1.Controls.Add(pictureBox1);
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(312, 1102);
			panel1.TabIndex = 75;
			// 
			// buttonBack
			// 
			buttonBack.BackColor = Color.Gainsboro;
			buttonBack.CausesValidation = false;
			buttonBack.FlatAppearance.BorderColor = Color.White;
			buttonBack.FlatAppearance.BorderSize = 2;
			buttonBack.FlatStyle = FlatStyle.Flat;
			buttonBack.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
			buttonBack.Location = new Point(29, 970);
			buttonBack.Name = "buttonBack";
			buttonBack.Size = new Size(252, 66);
			buttonBack.TabIndex = 22;
			buttonBack.Text = "Cancel";
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
			// labelPESEL
			// 
			labelPESEL.AutoSize = true;
			labelPESEL.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
			labelPESEL.Location = new Point(373, 223);
			labelPESEL.Name = "labelPESEL";
			labelPESEL.Size = new Size(67, 28);
			labelPESEL.TabIndex = 84;
			labelPESEL.Text = "PESEL:";
			// 
			// labelSpecialization
			// 
			labelSpecialization.AutoSize = true;
			labelSpecialization.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
			labelSpecialization.Location = new Point(900, 223);
			labelSpecialization.Name = "labelSpecialization";
			labelSpecialization.Size = new Size(137, 28);
			labelSpecialization.TabIndex = 87;
			labelSpecialization.Text = "Specialization:";
			// 
			// labelDate
			// 
			labelDate.AutoSize = true;
			labelDate.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
			labelDate.Location = new Point(374, 347);
			labelDate.Name = "labelDate";
			labelDate.Size = new Size(57, 28);
			labelDate.TabIndex = 90;
			labelDate.Text = "Date:";
			// 
			// labelCost
			// 
			labelCost.AutoSize = true;
			labelCost.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
			labelCost.Location = new Point(900, 469);
			labelCost.Name = "labelCost";
			labelCost.Size = new Size(55, 28);
			labelCost.TabIndex = 92;
			labelCost.Text = "Cost:";
			// 
			// textBoxSpecialization
			// 
			textBoxSpecialization.Enabled = false;
			textBoxSpecialization.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
			textBoxSpecialization.Location = new Point(900, 269);
			textBoxSpecialization.Margin = new Padding(3, 2, 3, 2);
			textBoxSpecialization.Name = "textBoxSpecialization";
			textBoxSpecialization.Size = new Size(453, 34);
			textBoxSpecialization.TabIndex = 100;
			// 
			// textBoxPESEL
			// 
			textBoxPESEL.Enabled = false;
			textBoxPESEL.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
			textBoxPESEL.Location = new Point(374, 269);
			textBoxPESEL.Margin = new Padding(3, 2, 3, 2);
			textBoxPESEL.Name = "textBoxPESEL";
			textBoxPESEL.Size = new Size(453, 34);
			textBoxPESEL.TabIndex = 101;
			// 
			// textBoxPatient
			// 
			textBoxPatient.Enabled = false;
			textBoxPatient.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
			textBoxPatient.Location = new Point(374, 146);
			textBoxPatient.Margin = new Padding(3, 2, 3, 2);
			textBoxPatient.Name = "textBoxPatient";
			textBoxPatient.Size = new Size(453, 34);
			textBoxPatient.TabIndex = 102;
			// 
			// textBoxDoktor
			// 
			textBoxDoktor.Enabled = false;
			textBoxDoktor.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
			textBoxDoktor.Location = new Point(900, 146);
			textBoxDoktor.Margin = new Padding(3, 2, 3, 2);
			textBoxDoktor.Name = "textBoxDoktor";
			textBoxDoktor.Size = new Size(453, 34);
			textBoxDoktor.TabIndex = 103;
			// 
			// textBoxOffice
			// 
			textBoxOffice.Enabled = false;
			textBoxOffice.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
			textBoxOffice.Location = new Point(900, 393);
			textBoxOffice.Margin = new Padding(3, 2, 3, 2);
			textBoxOffice.Name = "textBoxOffice";
			textBoxOffice.Size = new Size(453, 34);
			textBoxOffice.TabIndex = 104;
			// 
			// numericUpDownCost
			// 
			numericUpDownCost.DecimalPlaces = 2;
			numericUpDownCost.Enabled = false;
			numericUpDownCost.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
			numericUpDownCost.Location = new Point(900, 513);
			numericUpDownCost.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
			numericUpDownCost.Name = "numericUpDownCost";
			numericUpDownCost.Size = new Size(453, 34);
			numericUpDownCost.TabIndex = 105;
			// 
			// textBoxHour
			// 
			textBoxHour.Enabled = false;
			textBoxHour.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
			textBoxHour.Location = new Point(373, 513);
			textBoxHour.Margin = new Padding(3, 2, 3, 2);
			textBoxHour.Name = "textBoxHour";
			textBoxHour.Size = new Size(453, 34);
			textBoxHour.TabIndex = 106;
			// 
			// labelHour
			// 
			labelHour.AutoSize = true;
			labelHour.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
			labelHour.Location = new Point(373, 469);
			labelHour.Name = "labelHour";
			labelHour.Size = new Size(60, 28);
			labelHour.TabIndex = 107;
			labelHour.Text = "Hour:";
			// 
			// dateTimePickerDate
			// 
			dateTimePickerDate.Enabled = false;
			dateTimePickerDate.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
			dateTimePickerDate.Location = new Point(374, 393);
			dateTimePickerDate.Name = "dateTimePickerDate";
			dateTimePickerDate.Size = new Size(453, 34);
			dateTimePickerDate.TabIndex = 108;
			// 
			// buttonGeneratePDF
			// 
			buttonGeneratePDF.BackColor = Color.Gainsboro;
			buttonGeneratePDF.CausesValidation = false;
			buttonGeneratePDF.FlatAppearance.BorderColor = Color.White;
			buttonGeneratePDF.FlatAppearance.BorderSize = 2;
			buttonGeneratePDF.FlatStyle = FlatStyle.Flat;
			buttonGeneratePDF.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
			buttonGeneratePDF.Location = new Point(374, 610);
			buttonGeneratePDF.Name = "buttonGeneratePDF";
			buttonGeneratePDF.Size = new Size(377, 66);
			buttonGeneratePDF.TabIndex = 109;
			buttonGeneratePDF.Text = "Generate confirmation";
			buttonGeneratePDF.UseVisualStyleBackColor = false;
			buttonGeneratePDF.Click += buttonGeneratePDF_Click;
			// 
			// FormShowDetailsAppointment
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1904, 1041);
			Controls.Add(buttonGeneratePDF);
			Controls.Add(dateTimePickerDate);
			Controls.Add(labelHour);
			Controls.Add(textBoxHour);
			Controls.Add(numericUpDownCost);
			Controls.Add(textBoxOffice);
			Controls.Add(textBoxDoktor);
			Controls.Add(textBoxPatient);
			Controls.Add(textBoxPESEL);
			Controls.Add(textBoxSpecialization);
			Controls.Add(labelCost);
			Controls.Add(labelDate);
			Controls.Add(labelSpecialization);
			Controls.Add(labelPESEL);
			Controls.Add(labelTitle);
			Controls.Add(labelOffice);
			Controls.Add(labelDoctor);
			Controls.Add(labelPatient);
			Controls.Add(panel1);
			FormBorderStyle = FormBorderStyle.None;
			Name = "FormShowDetailsAppointment";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "FormShowDetailsAppointment";
			WindowState = FormWindowState.Maximized;
			Load += FormShowDetailsAppointment_Load;
			panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)numericUpDownCost).EndInit();
			ResumeLayout(false);
			PerformLayout();
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
		private Button buttonGeneratePDF;
	}
}