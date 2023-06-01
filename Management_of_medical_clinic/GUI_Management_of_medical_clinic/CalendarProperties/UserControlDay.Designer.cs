namespace GUI_Management_of_medical_clinic
{
    partial class UserControlDay
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            labelNumberOfDay = new Label();
            SuspendLayout();
            // 
            // labelNumberOfDay
            // 
            labelNumberOfDay.AutoSize = true;
            labelNumberOfDay.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            labelNumberOfDay.Location = new Point(13, 13);
            labelNumberOfDay.Name = "labelNumberOfDay";
            labelNumberOfDay.Size = new Size(47, 37);
            labelNumberOfDay.TabIndex = 0;
            labelNumberOfDay.Text = "00";
            // 
            // UserControlDay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(labelNumberOfDay);
            Name = "UserControlDay";
            Size = new Size(105, 143);
            Load += UserControlDay_Load;
            Leave += UserControlDay_Leave;
            MouseClick += UserControlDay_MouseClick;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNumberOfDay;
    }
}
