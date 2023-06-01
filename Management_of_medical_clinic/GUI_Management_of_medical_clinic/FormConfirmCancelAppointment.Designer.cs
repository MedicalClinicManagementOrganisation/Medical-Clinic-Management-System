namespace GUI_Management_of_medical_clinic
{
    partial class FormConfirmCancelAppointment
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
            buttonConfirm = new Button();
            panel1 = new Panel();
            button3 = new Button();
            buttonCancel = new Button();
            label1 = new Label();
            textBoxPassword = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonConfirm
            // 
            buttonConfirm.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonConfirm.BackColor = Color.SteelBlue;
            buttonConfirm.FlatAppearance.BorderColor = SystemColors.Control;
            buttonConfirm.FlatAppearance.BorderSize = 5;
            buttonConfirm.FlatStyle = FlatStyle.Flat;
            buttonConfirm.Font = new Font("Tw Cen MT Condensed Extra Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonConfirm.ForeColor = SystemColors.Control;
            buttonConfirm.Location = new Point(75, 25);
            buttonConfirm.Name = "buttonConfirm";
            buttonConfirm.Size = new Size(200, 55);
            buttonConfirm.TabIndex = 19;
            buttonConfirm.Text = "Confirm";
            buttonConfirm.UseVisualStyleBackColor = false;
            buttonConfirm.Click += buttonConfirm_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(buttonConfirm);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(buttonCancel);
            panel1.Location = new Point(0, 145);
            panel1.Name = "panel1";
            panel1.Size = new Size(600, 105);
            panel1.TabIndex = 29;
            // 
            // button3
            // 
            button3.BackColor = Color.Gainsboro;
            button3.FlatAppearance.BorderColor = Color.White;
            button3.FlatAppearance.BorderSize = 2;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(28, 978);
            button3.Name = "button3";
            button3.Size = new Size(252, 66);
            button3.TabIndex = 3;
            button3.Text = "EXIT";
            button3.UseVisualStyleBackColor = false;
            // 
            // buttonCancel
            // 
            buttonCancel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonCancel.BackColor = Color.SteelBlue;
            buttonCancel.FlatAppearance.BorderColor = SystemColors.Control;
            buttonCancel.FlatAppearance.BorderSize = 5;
            buttonCancel.FlatStyle = FlatStyle.Flat;
            buttonCancel.Font = new Font("Tw Cen MT Condensed Extra Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCancel.ForeColor = SystemColors.Control;
            buttonCancel.Location = new Point(325, 25);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(200, 55);
            buttonCancel.TabIndex = 20;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(76, 39);
            label1.Name = "label1";
            label1.Size = new Size(426, 25);
            label1.TabIndex = 30;
            label1.Text = "Confirm appointment cancelling. Input password:";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxPassword.BackColor = Color.MintCream;
            textBoxPassword.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxPassword.ForeColor = SystemColors.MenuText;
            textBoxPassword.Location = new Point(75, 75);
            textBoxPassword.Multiline = true;
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.PlaceholderText = "Input Password";
            textBoxPassword.Size = new Size(450, 40);
            textBoxPassword.TabIndex = 28;
            textBoxPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // FormConfirmCancelAppointment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = Properties.Resources.Website_Headers_5;
            ClientSize = new Size(600, 250);
            Controls.Add(textBoxPassword);
            Controls.Add(panel1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormConfirmCancelAppointment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormConfirmCancelAppointment";
            Load += FormConfirmCancelAppointment_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonConfirm;
        private Panel panel1;
        private Button button3;
        private Button buttonCancel;
        private Label label1;
        private TextBox textBoxPassword;
    }
}