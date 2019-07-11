namespace HideAndSeekChapter7
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
            this.components = new System.ComponentModel.Container();
            this.Description = new System.Windows.Forms.TextBox();
            this.GoHere = new System.Windows.Forms.Button();
            this.GoOutside = new System.Windows.Forms.Button();
            this.Exits = new System.Windows.Forms.ComboBox();
            this.CheckButton = new System.Windows.Forms.Button();
            this.HideButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Description
            // 
            this.Description.Location = new System.Drawing.Point(13, 13);
            this.Description.Multiline = true;
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(334, 167);
            this.Description.TabIndex = 0;
            // 
            // GoHere
            // 
            this.GoHere.Location = new System.Drawing.Point(13, 186);
            this.GoHere.Name = "GoHere";
            this.GoHere.Size = new System.Drawing.Size(75, 23);
            this.GoHere.TabIndex = 1;
            this.GoHere.Text = "Go here:";
            this.GoHere.UseVisualStyleBackColor = true;
            this.GoHere.Click += new System.EventHandler(this.GoHere_Click);
            // 
            // GoOutside
            // 
            this.GoOutside.Location = new System.Drawing.Point(13, 216);
            this.GoOutside.Name = "GoOutside";
            this.GoOutside.Size = new System.Drawing.Size(334, 23);
            this.GoOutside.TabIndex = 2;
            this.GoOutside.Text = "Go through the door";
            this.GoOutside.UseVisualStyleBackColor = true;
            this.GoOutside.Click += new System.EventHandler(this.GoOutside_Click);
            // 
            // Exits
            // 
            this.Exits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Exits.FormattingEnabled = true;
            this.Exits.Location = new System.Drawing.Point(95, 186);
            this.Exits.Name = "Exits";
            this.Exits.Size = new System.Drawing.Size(252, 21);
            this.Exits.TabIndex = 3;
            // 
            // CheckButton
            // 
            this.CheckButton.Location = new System.Drawing.Point(13, 245);
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.Size = new System.Drawing.Size(334, 23);
            this.CheckButton.TabIndex = 4;
            this.CheckButton.Text = "check";
            this.CheckButton.UseVisualStyleBackColor = true;
            this.CheckButton.Click += new System.EventHandler(this.CheckButton_Click);
            // 
            // HideButton
            // 
            this.HideButton.Location = new System.Drawing.Point(13, 274);
            this.HideButton.Name = "HideButton";
            this.HideButton.Size = new System.Drawing.Size(334, 23);
            this.HideButton.TabIndex = 5;
            this.HideButton.Text = "Hide!";
            this.HideButton.UseVisualStyleBackColor = true;
            this.HideButton.Click += new System.EventHandler(this.HideButton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 329);
            this.Controls.Add(this.HideButton);
            this.Controls.Add(this.CheckButton);
            this.Controls.Add(this.Exits);
            this.Controls.Add(this.GoOutside);
            this.Controls.Add(this.GoHere);
            this.Controls.Add(this.Description);
            this.Name = "Form1";
            this.Text = "Explore the house";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Description;
        private System.Windows.Forms.Button GoHere;
        private System.Windows.Forms.Button GoOutside;
        private System.Windows.Forms.ComboBox Exits;
        private System.Windows.Forms.Button CheckButton;
        private System.Windows.Forms.Button HideButton;
        private System.Windows.Forms.Timer timer1;
    }
}

