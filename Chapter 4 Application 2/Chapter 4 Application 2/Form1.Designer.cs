namespace Chapter_4_Application_2
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
            this.Start = new System.Windows.Forms.NumericUpDown();
            this.End = new System.Windows.Forms.NumericUpDown();
            this.StartingMileageLabel = new System.Windows.Forms.Label();
            this.EndingMileageLabel = new System.Windows.Forms.Label();
            this.AmountOwnedLabel = new System.Windows.Forms.Label();
            this.Amount = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Start)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.End)).BeginInit();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(116, 12);
            this.Start.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(120, 20);
            this.Start.TabIndex = 0;
            this.Start.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // End
            // 
            this.End.Location = new System.Drawing.Point(116, 51);
            this.End.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.End.Name = "End";
            this.End.Size = new System.Drawing.Size(120, 20);
            this.End.TabIndex = 1;
            this.End.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // StartingMileageLabel
            // 
            this.StartingMileageLabel.AutoSize = true;
            this.StartingMileageLabel.Location = new System.Drawing.Point(12, 14);
            this.StartingMileageLabel.Name = "StartingMileageLabel";
            this.StartingMileageLabel.Size = new System.Drawing.Size(86, 13);
            this.StartingMileageLabel.TabIndex = 2;
            this.StartingMileageLabel.Text = "Starting Mileage:";
            // 
            // EndingMileageLabel
            // 
            this.EndingMileageLabel.AutoSize = true;
            this.EndingMileageLabel.Location = new System.Drawing.Point(12, 53);
            this.EndingMileageLabel.Name = "EndingMileageLabel";
            this.EndingMileageLabel.Size = new System.Drawing.Size(83, 13);
            this.EndingMileageLabel.TabIndex = 3;
            this.EndingMileageLabel.Text = "Ending Mileage:";
            // 
            // AmountOwnedLabel
            // 
            this.AmountOwnedLabel.AutoSize = true;
            this.AmountOwnedLabel.Location = new System.Drawing.Point(12, 90);
            this.AmountOwnedLabel.Name = "AmountOwnedLabel";
            this.AmountOwnedLabel.Size = new System.Drawing.Size(83, 13);
            this.AmountOwnedLabel.TabIndex = 4;
            this.AmountOwnedLabel.Text = "Amount Owned:";
            // 
            // Amount
            // 
            this.Amount.AutoSize = true;
            this.Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Amount.Location = new System.Drawing.Point(112, 85);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(29, 20);
            this.Amount.TabIndex = 5;
            this.Amount.Text = "$0";
            this.Amount.Click += new System.EventHandler(this.Label4_Click);
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(12, 123);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(75, 23);
            this.CalculateButton.TabIndex = 6;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(161, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Display miles";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 183);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.Amount);
            this.Controls.Add(this.AmountOwnedLabel);
            this.Controls.Add(this.EndingMileageLabel);
            this.Controls.Add(this.StartingMileageLabel);
            this.Controls.Add(this.End);
            this.Controls.Add(this.Start);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(280, 222);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(280, 222);
            this.Name = "Form1";
            this.Text = "Mileage Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.Start)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.End)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown Start;
        private System.Windows.Forms.NumericUpDown End;
        private System.Windows.Forms.Label StartingMileageLabel;
        private System.Windows.Forms.Label EndingMileageLabel;
        private System.Windows.Forms.Label AmountOwnedLabel;
        private System.Windows.Forms.Label Amount;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button button1;
    }
}

