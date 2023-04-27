namespace GUI_Management_of_medical_clinic
{
    partial class FormOfficeEdit
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
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            buttonCancel = new Button();
            labelTitle = new Label();
            buttonEditOffice = new Button();
            label2 = new Label();
            label4 = new Label();
            textBoxNumber = new TextBox();
            listBoxSpecializations = new ListBox();
            textBoxInfo = new TextBox();
            label3 = new Label();
            comboBoxActive = new ComboBox();
            label1 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(buttonCancel);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(312, 1081);
            panel2.TabIndex = 62;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.MC_Logo;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(61, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(176, 168);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.Gainsboro;
            buttonCancel.FlatAppearance.BorderColor = Color.White;
            buttonCancel.FlatAppearance.BorderSize = 2;
            buttonCancel.FlatStyle = FlatStyle.Flat;
            buttonCancel.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCancel.Location = new Point(24, 985);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(252, 66);
            buttonCancel.TabIndex = 33;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 24.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitle.Location = new Point(1034, 334);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(178, 45);
            labelTitle.TabIndex = 70;
            labelTitle.Text = "Edit office";
            // 
            // buttonEditOffice
            // 
            buttonEditOffice.Font = new Font("Segoe UI", 18.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonEditOffice.Location = new Point(1316, 721);
            buttonEditOffice.Name = "buttonEditOffice";
            buttonEditOffice.Size = new Size(220, 60);
            buttonEditOffice.TabIndex = 77;
            buttonEditOffice.Text = "Save";
            buttonEditOffice.UseVisualStyleBackColor = true;
            buttonEditOffice.Click += buttonEditOffice_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(710, 475);
            label2.Name = "label2";
            label2.Size = new Size(113, 35);
            label2.TabIndex = 71;
            label2.Text = "Number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(1126, 402);
            label4.Name = "label4";
            label4.Size = new Size(401, 35);
            label4.TabIndex = 76;
            label4.Text = "Choose specialization to a office:";
            // 
            // textBoxNumber
            // 
            textBoxNumber.Font = new Font("Segoe UI", 18.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNumber.Location = new Point(889, 472);
            textBoxNumber.MaxLength = 100;
            textBoxNumber.Name = "textBoxNumber";
            textBoxNumber.Size = new Size(199, 41);
            textBoxNumber.TabIndex = 72;
            textBoxNumber.TextChanged += textBoxNumber_TextChanged;
            // 
            // listBoxSpecializations
            // 
            listBoxSpecializations.FormattingEnabled = true;
            listBoxSpecializations.ItemHeight = 15;
            listBoxSpecializations.Location = new Point(1174, 456);
            listBoxSpecializations.Name = "listBoxSpecializations";
            listBoxSpecializations.Size = new Size(296, 229);
            listBoxSpecializations.TabIndex = 75;
            listBoxSpecializations.SelectedIndexChanged += listBoxSpecializations_SelectedIndexChanged;
            // 
            // textBoxInfo
            // 
            textBoxInfo.Font = new Font("Segoe UI", 18.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxInfo.Location = new Point(889, 540);
            textBoxInfo.MaxLength = 300;
            textBoxInfo.Name = "textBoxInfo";
            textBoxInfo.Size = new Size(199, 41);
            textBoxInfo.TabIndex = 74;
            textBoxInfo.TextChanged += textBoxInfo_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(710, 543);
            label3.Name = "label3";
            label3.Size = new Size(63, 35);
            label3.TabIndex = 73;
            label3.Text = "Info";
            // 
            // comboBoxActive
            // 
            comboBoxActive.Font = new Font("Segoe UI", 18.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxActive.FormattingEnabled = true;
            comboBoxActive.Items.AddRange(new object[] { "Active", "Non active" });
            comboBoxActive.Location = new Point(889, 605);
            comboBoxActive.Name = "comboBoxActive";
            comboBoxActive.Size = new Size(199, 43);
            comboBoxActive.TabIndex = 72;
            comboBoxActive.SelectedIndexChanged += comboBoxActive_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(710, 608);
            label1.Name = "label1";
            label1.Size = new Size(87, 35);
            label1.TabIndex = 71;
            label1.Text = "Status";
            // 
            // FormOfficeEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1920, 1080);
            Controls.Add(comboBoxActive);
            Controls.Add(label1);
            Controls.Add(labelTitle);
            Controls.Add(buttonEditOffice);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(textBoxNumber);
            Controls.Add(listBoxSpecializations);
            Controls.Add(textBoxInfo);
            Controls.Add(label3);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormOfficeEdit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormOfficeEdit";
            WindowState = FormWindowState.Maximized;
            Load += FormOfficeEdit_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private PictureBox pictureBox1;
        private Button buttonCancel;
        private Label labelTitle;
        private Button buttonEditOffice;
        private Label label2;
        private Label label4;
        private TextBox textBoxNumber;
        private ListBox listBoxSpecializations;
        private TextBox textBoxInfo;
        private Label label3;
        private ComboBox comboBoxActive;
        private Label label1;
    }
}