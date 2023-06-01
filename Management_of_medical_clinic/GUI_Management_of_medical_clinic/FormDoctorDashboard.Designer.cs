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
            buttonLogOut = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            buttonCalendar = new Button();
            buttonCurrentCalendar = new Button();
            button_patients = new Button();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            labelFullName = new Label();
            labelPESEL = new Label();
            labelSex = new Label();
            labelBirthday = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            label1.Location = new Point(385, 115);
            label1.Name = "label1";
            label1.Size = new Size(420, 65);
            label1.TabIndex = 40;
            label1.Text = "Welcome message";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(385, 259);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(415, 179);
            dataGridView1.TabIndex = 41;
            // 
            // labelFullName
            // 
            labelFullName.AutoSize = true;
            labelFullName.Location = new Point(881, 296);
            labelFullName.Name = "labelFullName";
            labelFullName.Size = new Size(38, 15);
            labelFullName.TabIndex = 42;
            labelFullName.Text = "label2";
            // 
            // labelPESEL
            // 
            labelPESEL.AutoSize = true;
            labelPESEL.Location = new Point(881, 323);
            labelPESEL.Name = "labelPESEL";
            labelPESEL.Size = new Size(38, 15);
            labelPESEL.TabIndex = 43;
            labelPESEL.Text = "label3";
            // 
            // labelSex
            // 
            labelSex.AutoSize = true;
            labelSex.Location = new Point(881, 352);
            labelSex.Name = "labelSex";
            labelSex.Size = new Size(38, 15);
            labelSex.TabIndex = 44;
            labelSex.Text = "label4";
            // 
            // labelBirthday
            // 
            labelBirthday.AutoSize = true;
            labelBirthday.Location = new Point(881, 380);
            labelBirthday.Name = "labelBirthday";
            labelBirthday.Size = new Size(38, 15);
            labelBirthday.TabIndex = 45;
            labelBirthday.Text = "label5";
            // 
            // FormDoctorDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1698, 996);
            Controls.Add(labelBirthday);
            Controls.Add(labelSex);
            Controls.Add(labelPESEL);
            Controls.Add(labelFullName);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormDoctorDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormOfficeList";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private DataGridView dataGridView1;
        private Label labelFullName;
        private Label labelPESEL;
        private Label labelSex;
        private Label labelBirthday;
    }
}