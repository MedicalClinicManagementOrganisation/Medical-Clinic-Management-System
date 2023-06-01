namespace GUI_Management_of_medical_clinic
{
    partial class FormAddEditPatient
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            buttonBack = new Button();
            pictureBox1 = new PictureBox();
            buttonAddEditPatient = new Button();
            comboBoxSex = new ComboBox();
            labelAddEditNewPatient = new Label();
            labelSex = new Label();
            labelDateOfBirth = new Label();
            maskedTextBoxPESEL = new MaskedTextBox();
            labelPESEL = new Label();
            labelLastName = new Label();
            textBoxLastName = new TextBox();
            labelName = new Label();
            textBoxName = new TextBox();
            dateTimePickerBirthDate = new DateTimePicker();
            ErrorProviderFirstName = new ErrorProvider(components);
            ErrorProviderLastName = new ErrorProvider(components);
            ErrorProviderPESEL = new ErrorProvider(components);
            ErrorProviderBirthDate = new ErrorProvider(components);
            ErrorProviderSex = new ErrorProvider(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ErrorProviderFirstName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ErrorProviderLastName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ErrorProviderPESEL).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ErrorProviderBirthDate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ErrorProviderSex).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(buttonBack);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-3, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(312, 1081);
            panel1.TabIndex = 23;
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
            // buttonAddEditPatient
            // 
            buttonAddEditPatient.BackColor = Color.Gainsboro;
            buttonAddEditPatient.FlatStyle = FlatStyle.Flat;
            buttonAddEditPatient.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAddEditPatient.ForeColor = SystemColors.ControlText;
            buttonAddEditPatient.Location = new Point(370, 970);
            buttonAddEditPatient.Name = "buttonAddEditPatient";
            buttonAddEditPatient.Size = new Size(453, 65);
            buttonAddEditPatient.TabIndex = 59;
            buttonAddEditPatient.Text = "Add patient";
            buttonAddEditPatient.UseVisualStyleBackColor = false;
            buttonAddEditPatient.Click += buttonAddEditPatient_Click;
            // 
            // comboBoxSex
            // 
            comboBoxSex.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxSex.FormattingEnabled = true;
            comboBoxSex.Location = new Point(370, 600);
            comboBoxSex.Margin = new Padding(3, 2, 3, 2);
            comboBoxSex.Name = "comboBoxSex";
            comboBoxSex.Size = new Size(453, 36);
            comboBoxSex.TabIndex = 56;
            comboBoxSex.SelectedValueChanged += comboBoxSex_SelectedValueChanged;
            // 
            // labelAddEditNewPatient
            // 
            labelAddEditNewPatient.AutoSize = true;
            labelAddEditNewPatient.FlatStyle = FlatStyle.Flat;
            labelAddEditNewPatient.Font = new Font("Segoe UI", 25F, FontStyle.Bold, GraphicsUnit.Point);
            labelAddEditNewPatient.Location = new Point(365, 19);
            labelAddEditNewPatient.Name = "labelAddEditNewPatient";
            labelAddEditNewPatient.Size = new Size(284, 46);
            labelAddEditNewPatient.TabIndex = 55;
            labelAddEditNewPatient.Text = "Add new patient";
            // 
            // labelSex
            // 
            labelSex.AutoSize = true;
            labelSex.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelSex.Location = new Point(370, 550);
            labelSex.Name = "labelSex";
            labelSex.Size = new Size(46, 28);
            labelSex.TabIndex = 50;
            labelSex.Text = "Sex:";
            // 
            // labelDateOfBirth
            // 
            labelDateOfBirth.AutoSize = true;
            labelDateOfBirth.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelDateOfBirth.Location = new Point(370, 700);
            labelDateOfBirth.Name = "labelDateOfBirth";
            labelDateOfBirth.Size = new Size(127, 28);
            labelDateOfBirth.TabIndex = 48;
            labelDateOfBirth.Text = "Date of birth:";
            // 
            // maskedTextBoxPESEL
            // 
            maskedTextBoxPESEL.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            maskedTextBoxPESEL.Location = new Point(370, 450);
            maskedTextBoxPESEL.Margin = new Padding(3, 2, 3, 2);
            maskedTextBoxPESEL.Mask = "00000000000";
            maskedTextBoxPESEL.Name = "maskedTextBoxPESEL";
            maskedTextBoxPESEL.Size = new Size(453, 34);
            maskedTextBoxPESEL.TabIndex = 47;
            maskedTextBoxPESEL.Validating += maskedTextBoxPESEL_Validating;
            maskedTextBoxPESEL.Validated += maskedTextBoxPESEL_Validated;
            // 
            // labelPESEL
            // 
            labelPESEL.AutoSize = true;
            labelPESEL.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelPESEL.Location = new Point(370, 400);
            labelPESEL.Name = "labelPESEL";
            labelPESEL.Size = new Size(67, 28);
            labelPESEL.TabIndex = 46;
            labelPESEL.Text = "PESEL:";
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelLastName.Location = new Point(370, 250);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(103, 28);
            labelLastName.TabIndex = 45;
            labelLastName.Text = "Last name:";
            // 
            // textBoxLastName
            // 
            textBoxLastName.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxLastName.Location = new Point(370, 300);
            textBoxLastName.Margin = new Padding(3, 2, 3, 2);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(453, 34);
            textBoxLastName.TabIndex = 44;
            textBoxLastName.TextChanged += textBoxLastName_TextChanged;
            textBoxLastName.Validating += textBoxLastName_Validating;
            textBoxLastName.Validated += textBoxLastName_Validated;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelName.Location = new Point(370, 100);
            labelName.Name = "labelName";
            labelName.Size = new Size(68, 28);
            labelName.TabIndex = 43;
            labelName.Text = "Name:";
            // 
            // textBoxName
            // 
            textBoxName.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxName.Location = new Point(370, 150);
            textBoxName.Margin = new Padding(3, 2, 3, 2);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(453, 34);
            textBoxName.TabIndex = 42;
            textBoxName.TextChanged += textBoxName_TextChanged;
            textBoxName.Validating += textBoxName_Validating;
            textBoxName.Validated += textBoxName_Validated;
            // 
            // dateTimePickerBirthDate
            // 
            dateTimePickerBirthDate.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerBirthDate.Location = new Point(370, 750);
            dateTimePickerBirthDate.MaxDate = new DateTime(2023, 4, 6, 0, 0, 0, 0);
            dateTimePickerBirthDate.Name = "dateTimePickerBirthDate";
            dateTimePickerBirthDate.Size = new Size(454, 34);
            dateTimePickerBirthDate.TabIndex = 57;
            dateTimePickerBirthDate.Value = new DateTime(2023, 4, 6, 0, 0, 0, 0);
            dateTimePickerBirthDate.ValueChanged += dateTimePickerBirthDate_ValueChanged;
            dateTimePickerBirthDate.Validating += dateTimePickerBirthDate_Validating;
            dateTimePickerBirthDate.Validated += dateTimePickerBirthDate_Validated;
            // 
            // ErrorProviderFirstName
            // 
            ErrorProviderFirstName.BlinkRate = 0;
            ErrorProviderFirstName.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            ErrorProviderFirstName.ContainerControl = this;
            // 
            // ErrorProviderLastName
            // 
            ErrorProviderLastName.BlinkRate = 0;
            ErrorProviderLastName.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            ErrorProviderLastName.ContainerControl = this;
            // 
            // ErrorProviderPESEL
            // 
            ErrorProviderPESEL.BlinkRate = 0;
            ErrorProviderPESEL.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            ErrorProviderPESEL.ContainerControl = this;
            // 
            // ErrorProviderBirthDate
            // 
            ErrorProviderBirthDate.BlinkRate = 0;
            ErrorProviderBirthDate.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            ErrorProviderBirthDate.ContainerControl = this;
            // 
            // ErrorProviderSex
            // 
            ErrorProviderSex.BlinkRate = 0;
            ErrorProviderSex.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            ErrorProviderSex.ContainerControl = this;
            // 
            // FormAddEditPatient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1362, 1100);
            Controls.Add(dateTimePickerBirthDate);
            Controls.Add(buttonAddEditPatient);
            Controls.Add(comboBoxSex);
            Controls.Add(labelAddEditNewPatient);
            Controls.Add(labelSex);
            Controls.Add(labelDateOfBirth);
            Controls.Add(maskedTextBoxPESEL);
            Controls.Add(labelPESEL);
            Controls.Add(labelLastName);
            Controls.Add(textBoxLastName);
            Controls.Add(labelName);
            Controls.Add(textBoxName);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormAddEditPatient";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAddEditPatient";
            WindowState = FormWindowState.Maximized;
            FormClosing += FormAddEditPatient_FormClosing;
            Load += FormAddEditPatient_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ErrorProviderFirstName).EndInit();
            ((System.ComponentModel.ISupportInitialize)ErrorProviderLastName).EndInit();
            ((System.ComponentModel.ISupportInitialize)ErrorProviderPESEL).EndInit();
            ((System.ComponentModel.ISupportInitialize)ErrorProviderBirthDate).EndInit();
            ((System.ComponentModel.ISupportInitialize)ErrorProviderSex).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button buttonBack;
        private PictureBox pictureBox1;
        private ComboBox comboBoxSex;
        private Label labelAddEditNewPatient;
        private Label labelSex;
        private Label labelDateOfBirth;
        private MaskedTextBox maskedTextBoxPESEL;
        private Label labelPESEL;
        private Label labelLastName;
        private TextBox textBoxLastName;
        private Label labelName;
        private TextBox textBoxName;
        private DateTimePicker dateTimePickerBirthDate;
        private ErrorProvider ErrorProviderFirstName;
        private ErrorProvider ErrorProviderLastName;
        private ErrorProvider ErrorProviderPESEL;
        private ErrorProvider ErrorProviderBirthDate;
        internal Button buttonAddEditPatient;
        private ErrorProvider ErrorProviderSex;
    }
}