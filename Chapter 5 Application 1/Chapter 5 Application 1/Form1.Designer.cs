namespace Chapter_5_Application_1
{
    partial class Form1
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

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.FancyDecorations = new System.Windows.Forms.CheckBox();
            this.HealthyOption = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Cost = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // FancyDecorations
            // 
            this.FancyDecorations.AutoSize = true;
            this.FancyDecorations.Checked = true;
            this.FancyDecorations.CheckState = System.Windows.Forms.CheckState.Checked;
            this.FancyDecorations.Location = new System.Drawing.Point(15, 51);
            this.FancyDecorations.Name = "FancyDecorations";
            this.FancyDecorations.Size = new System.Drawing.Size(115, 17);
            this.FancyDecorations.TabIndex = 0;
            this.FancyDecorations.Text = "Fancy Decorations";
            this.FancyDecorations.UseVisualStyleBackColor = true;
            this.FancyDecorations.CheckedChanged += new System.EventHandler(this.FancyDecorations_CheckedChanged);
            // 
            // HealthyOption
            // 
            this.HealthyOption.AutoSize = true;
            this.HealthyOption.Location = new System.Drawing.Point(15, 84);
            this.HealthyOption.Name = "HealthyOption";
            this.HealthyOption.Size = new System.Drawing.Size(96, 17);
            this.HealthyOption.TabIndex = 1;
            this.HealthyOption.Text = "Healthy Option";
            this.HealthyOption.UseVisualStyleBackColor = true;
            this.HealthyOption.CheckedChanged += new System.EventHandler(this.HealthyOption_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(14, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cost";
            // 
            // Cost
            // 
            this.Cost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Cost.Location = new System.Drawing.Point(60, 117);
            this.Cost.Name = "Cost";
            this.Cost.Size = new System.Drawing.Size(63, 16);
            this.Cost.TabIndex = 3;
            this.Cost.Text = "$0.00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Number of People";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(15, 25);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 5;
            this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.NumericUpDown1_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(165, 151);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Cost);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HealthyOption);
            this.Controls.Add(this.FancyDecorations);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Party Planner";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox FancyDecorations;
        private System.Windows.Forms.CheckBox HealthyOption;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Cost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

