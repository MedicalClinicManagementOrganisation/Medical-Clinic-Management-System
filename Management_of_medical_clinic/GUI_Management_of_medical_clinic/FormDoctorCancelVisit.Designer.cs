namespace GUI_Management_of_medical_clinic
{
    partial class FormDoctorCancelVisit
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
            pictureBox1 = new PictureBox();
            listBox1 = new ListBox();
            button1 = new Button();
            label1 = new Label();
            buttonRemoveFromList = new Button();
            buttonCancelAppointment = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.MC_Logo;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(12, 14);
            pictureBox1.Margin = new Padding(3, 5, 3, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(111, 113);
            pictureBox1.TabIndex = 48;
            pictureBox1.TabStop = false;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(138, 101);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(583, 224);
            listBox1.TabIndex = 49;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(12, 344);
            button1.Name = "button1";
            button1.Size = new Size(111, 52);
            button1.TabIndex = 50;
            button1.Text = "Back to Current Calendar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(245, 43);
            label1.Name = "label1";
            label1.Size = new Size(353, 20);
            label1.TabIndex = 51;
            label1.Text = "Are you shure , that you want to cancell there visits ?";
            // 
            // buttonRemoveFromList
            // 
            buttonRemoveFromList.Location = new Point(618, 344);
            buttonRemoveFromList.Name = "buttonRemoveFromList";
            buttonRemoveFromList.Size = new Size(148, 52);
            buttonRemoveFromList.TabIndex = 53;
            buttonRemoveFromList.Text = "Remove from Cancel List";
            buttonRemoveFromList.UseVisualStyleBackColor = true;
            buttonRemoveFromList.Click += buttonRemoveFromList_Click;
            // 
            // buttonCancelAppointment
            // 
            buttonCancelAppointment.Location = new Point(348, 344);
            buttonCancelAppointment.Name = "buttonCancelAppointment";
            buttonCancelAppointment.Size = new Size(148, 52);
            buttonCancelAppointment.TabIndex = 54;
            buttonCancelAppointment.Text = "Cancel all the visits";
            buttonCancelAppointment.UseVisualStyleBackColor = true;
            buttonCancelAppointment.Click += buttonCancelAppointment_Click;
            // 
            // FormDoctorCancelVisit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 415);
            Controls.Add(buttonCancelAppointment);
            Controls.Add(buttonRemoveFromList);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormDoctorCancelVisit";
            Text = "Cancellation confirmation";
            Load += FormDoctorCancelVisit_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private ListBox listBox1;
        private Button button1;
        private Label label1;
        private Button button2;
        private Button buttonRemoveFromList;
        private Button buttonCancelAppointment;
    }
}