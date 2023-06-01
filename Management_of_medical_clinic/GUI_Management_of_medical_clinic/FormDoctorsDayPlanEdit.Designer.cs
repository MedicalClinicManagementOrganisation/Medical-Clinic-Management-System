namespace GUI_Management_of_medical_clinic
{
    partial class FormDoctorsDayPlanEdit
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
            labelTerm = new Label();
            label7 = new Label();
            buttonAdd = new Button();
            panel1 = new Panel();
            buttonBack = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            comboBoxDoctor = new ComboBox();
            comboBoxOffice = new ComboBox();
            labelDay = new Label();
            checkedListBoxTerms = new CheckedListBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelTerm
            // 
            labelTerm.AutoSize = true;
            labelTerm.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelTerm.Location = new Point(1025, 416);
            labelTerm.Name = "labelTerm";
            labelTerm.Size = new Size(94, 37);
            labelTerm.TabIndex = 1;
            labelTerm.Text = "Terms";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(855, 301);
            label7.Name = "label7";
            label7.Size = new Size(113, 37);
            label7.TabIndex = 7;
            label7.Text = "Doctor ";
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.Gainsboro;
            buttonAdd.FlatAppearance.BorderColor = Color.White;
            buttonAdd.FlatAppearance.BorderSize = 2;
            buttonAdd.FlatStyle = FlatStyle.Flat;
            buttonAdd.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAdd.Location = new Point(938, 703);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(252, 66);
            buttonAdd.TabIndex = 14;
            buttonAdd.Text = "Edit";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonEdit_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(buttonBack);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(312, 1081);
            panel1.TabIndex = 40;
            // 
            // buttonBack
            // 
            buttonBack.BackColor = Color.Gainsboro;
            buttonBack.FlatAppearance.BorderColor = Color.White;
            buttonBack.FlatAppearance.BorderSize = 2;
            buttonBack.FlatStyle = FlatStyle.Flat;
            buttonBack.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            buttonBack.Location = new Point(28, 953);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(252, 66);
            buttonBack.TabIndex = 40;
            buttonBack.Text = "CANCEL";
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(855, 354);
            label1.Name = "label1";
            label1.Size = new Size(100, 37);
            label1.TabIndex = 42;
            label1.Text = "Office ";
            // 
            // comboBoxDoctor
            // 
            comboBoxDoctor.FormattingEnabled = true;
            comboBoxDoctor.Location = new Point(1025, 315);
            comboBoxDoctor.Name = "comboBoxDoctor";
            comboBoxDoctor.Size = new Size(218, 23);
            comboBoxDoctor.TabIndex = 46;
            comboBoxDoctor.SelectedIndexChanged += comboBoxDoctor_SelectedIndexChanged;
            // 
            // comboBoxOffice
            // 
            comboBoxOffice.FormattingEnabled = true;
            comboBoxOffice.Location = new Point(1025, 368);
            comboBoxOffice.Name = "comboBoxOffice";
            comboBoxOffice.Size = new Size(218, 23);
            comboBoxOffice.TabIndex = 47;
            // 
            // labelDay
            // 
            labelDay.AutoSize = true;
            labelDay.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelDay.Location = new Point(855, 246);
            labelDay.Name = "labelDay";
            labelDay.Size = new Size(201, 37);
            labelDay.TabIndex = 48;
            labelDay.Text = "Selected Date:";
            // 
            // checkedListBoxTerms
            // 
            checkedListBoxTerms.FormattingEnabled = true;
            checkedListBoxTerms.Location = new Point(870, 456);
            checkedListBoxTerms.MultiColumn = true;
            checkedListBoxTerms.Name = "checkedListBoxTerms";
            checkedListBoxTerms.Size = new Size(388, 220);
            checkedListBoxTerms.TabIndex = 49;
            // 
            // FormDoctorsDayPlanEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1920, 1080);
            Controls.Add(checkedListBoxTerms);
            Controls.Add(labelDay);
            Controls.Add(comboBoxOffice);
            Controls.Add(comboBoxDoctor);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(buttonAdd);
            Controls.Add(label7);
            Controls.Add(labelTerm);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormDoctorsDayPlanEdit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAppointmentEdit";
            WindowState = FormWindowState.Maximized;
            Load += FormAppointmentAdd_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelTerm;
        private Label label7;
        private Button buttonAdd;
        private Panel panel1;
        private Button buttonBack;
        private PictureBox pictureBox1;
        private Label label1;
        private ComboBox comboBoxDoctor;
        private ComboBox comboBoxOffice;
        private Label labelDay;
        private CheckedListBox checkedListBoxTerms;
    }
}