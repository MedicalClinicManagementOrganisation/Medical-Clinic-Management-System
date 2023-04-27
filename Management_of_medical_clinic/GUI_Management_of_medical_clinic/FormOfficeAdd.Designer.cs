﻿namespace GUI_Management_of_medical_clinic
{
    partial class FormOfficeAdd
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
            buttonAddNewOffice = new Button();
            label4 = new Label();
            listBoxSpecializations = new ListBox();
            textBoxInfo = new TextBox();
            label3 = new Label();
            textBoxNumber = new TextBox();
            label2 = new Label();
            labelTitle = new Label();
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
            panel2.TabIndex = 61;
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
            // buttonAddNewOffice
            // 
            buttonAddNewOffice.Font = new Font("Segoe UI", 18.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAddNewOffice.Location = new Point(960, 727);
            buttonAddNewOffice.Name = "buttonAddNewOffice";
            buttonAddNewOffice.Size = new Size(220, 60);
            buttonAddNewOffice.TabIndex = 69;
            buttonAddNewOffice.Text = "Add";
            buttonAddNewOffice.UseVisualStyleBackColor = true;
            buttonAddNewOffice.Click += buttonAddNewUser_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(1205, 397);
            label4.Name = "label4";
            label4.Size = new Size(327, 35);
            label4.TabIndex = 68;
            label4.Text = "Select office specialization";
            // 
            // listBoxSpecializations
            // 
            listBoxSpecializations.FormattingEnabled = true;
            listBoxSpecializations.ItemHeight = 15;
            listBoxSpecializations.Location = new Point(1217, 448);
            listBoxSpecializations.Name = "listBoxSpecializations";
            listBoxSpecializations.Size = new Size(296, 229);
            listBoxSpecializations.TabIndex = 67;
            listBoxSpecializations.SelectedIndexChanged += listBoxSpecializations_SelectedIndexChanged;
            // 
            // textBoxInfo
            // 
            textBoxInfo.Font = new Font("Segoe UI", 18.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxInfo.Location = new Point(925, 513);
            textBoxInfo.MaxLength = 300;
            textBoxInfo.Name = "textBoxInfo";
            textBoxInfo.Size = new Size(255, 41);
            textBoxInfo.TabIndex = 66;
            textBoxInfo.TextChanged += textBoxInfo_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(731, 519);
            label3.Name = "label3";
            label3.Size = new Size(156, 35);
            label3.TabIndex = 64;
            label3.Text = "Information";
            // 
            // textBoxNumber
            // 
            textBoxNumber.Font = new Font("Segoe UI", 18.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNumber.Location = new Point(925, 448);
            textBoxNumber.MaxLength = 100;
            textBoxNumber.Name = "textBoxNumber";
            textBoxNumber.Size = new Size(255, 41);
            textBoxNumber.TabIndex = 62;
            textBoxNumber.TextChanged += textBoxNumber_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(731, 451);
            label2.Name = "label2";
            label2.Size = new Size(188, 35);
            label2.TabIndex = 61;
            label2.Text = "Room Number";
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 24.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitle.Location = new Point(731, 387);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(292, 45);
            labelTitle.TabIndex = 60;
            labelTitle.Text = "Add a New Office";
            // 
            // FormOfficeAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1920, 1080);
            Controls.Add(panel2);
            Controls.Add(labelTitle);
            Controls.Add(buttonAddNewOffice);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(textBoxNumber);
            Controls.Add(listBoxSpecializations);
            Controls.Add(textBoxInfo);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormOfficeAdd";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormOfficeAdd";
            WindowState = FormWindowState.Maximized;
            Load += FormOfficeAdd_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private PictureBox pictureBox1;
        private Button buttonCancel;
        private Button buttonAddNewOffice;
        private Label label4;
        private ListBox listBoxSpecializations;
        private TextBox textBoxInfo;
        private Label label3;
        private TextBox textBoxNumber;
        private Label label2;
        private Label labelTitle;
    }
}