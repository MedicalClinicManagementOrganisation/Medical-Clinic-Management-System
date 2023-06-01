namespace GUI_Management_of_medical_clinic
{
    partial class FormDoctorCalendar
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelMenu = new Panel();
            buttonExit = new Button();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            panel9 = new Panel();
            list_ofCalendars = new ListView();
            column0 = new ColumnHeader();
            label1 = new Label();
            panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.SteelBlue;
            panelMenu.Controls.Add(buttonExit);
            panelMenu.Controls.Add(pictureBox1);
            panelMenu.Location = new Point(-3, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(312, 1081);
            panelMenu.TabIndex = 0;
            // 
            // buttonExit
            // 
            buttonExit.BackColor = Color.Gainsboro;
            buttonExit.FlatAppearance.BorderColor = Color.White;
            buttonExit.FlatAppearance.BorderSize = 2;
            buttonExit.FlatStyle = FlatStyle.Flat;
            buttonExit.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            buttonExit.Location = new Point(26, 983);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(252, 66);
            buttonExit.TabIndex = 48;
            buttonExit.Text = "Back";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.MC_Logo;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(61, 12);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(176, 168);
            pictureBox1.TabIndex = 47;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Location = new Point(307, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1888, 77);
            panel1.TabIndex = 2;
            // 
            // panel9
            // 
            panel9.BackColor = Color.White;
            panel9.Location = new Point(296, 75);
            panel9.Name = "panel9";
            panel9.Size = new Size(1888, 99);
            panel9.TabIndex = 20;
            // 
            // list_ofCalendars
            // 
            list_ofCalendars.Columns.AddRange(new ColumnHeader[] { column0 });
            list_ofCalendars.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            list_ofCalendars.HeaderStyle = ColumnHeaderStyle.None;
            list_ofCalendars.Location = new Point(419, 242);
            list_ofCalendars.MultiSelect = false;
            list_ofCalendars.Name = "list_ofCalendars";
            list_ofCalendars.Size = new Size(312, 366);
            list_ofCalendars.TabIndex = 32;
            list_ofCalendars.UseCompatibleStateImageBehavior = false;
            list_ofCalendars.View = View.Details;
            list_ofCalendars.DoubleClick += listofCalendars_DoubleClick;
            // 
            // column0
            // 
            column0.Text = "Calendars to accept";
            column0.Width = 300;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(419, 194);
            label1.Name = "label1";
            label1.Size = new Size(312, 45);
            label1.TabIndex = 33;
            label1.Text = "Calendars to accept";
            // 
            // FormDoctorCalendar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1920, 1080);
            Controls.Add(label1);
            Controls.Add(list_ofCalendars);
            Controls.Add(panelMenu);
            Controls.Add(panel9);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormDoctorCalendar";
            Text = "Calendar";
            WindowState = FormWindowState.Maximized;
            Load += FormDoctorCalendar_Load;
            panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelMenu;
        private Panel panel1;
        private Panel panel9;
        private PictureBox pictureBox1;
        private Button buttonExit;
        private ListView list_ofCalendars;
        private ColumnHeader column0;
        private Label label1;
    }
}