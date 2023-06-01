namespace GUI_Management_of_medical_clinic
{
    partial class UserControlBlank
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
            labelNumberOfDay.Size = new Size(0, 37);
            labelNumberOfDay.TabIndex = 1;
            // 
            // UserControlBlank
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            Controls.Add(labelNumberOfDay);
            Name = "UserControlBlank";
            Size = new Size(105, 143);
            Load += UserControlBlank_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNumberOfDay;
    }
}
