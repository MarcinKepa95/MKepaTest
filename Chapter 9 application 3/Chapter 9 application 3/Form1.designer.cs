namespace Chapter_9_Application_3
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
            this.JoesCashLabel = new System.Windows.Forms.Label();
            this.BobsCashLabel = new System.Windows.Forms.Label();
            this.BankLabel = new System.Windows.Forms.Label();
            this.Button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.saveJoe = new System.Windows.Forms.Button();
            this.loadJoe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // JoesCashLabel
            // 
            this.JoesCashLabel.AutoSize = true;
            this.JoesCashLabel.Location = new System.Drawing.Point(12, 9);
            this.JoesCashLabel.Name = "JoesCashLabel";
            this.JoesCashLabel.Size = new System.Drawing.Size(65, 13);
            this.JoesCashLabel.TabIndex = 0;
            this.JoesCashLabel.Text = "Joe has $50";
            // 
            // BobsCashLabel
            // 
            this.BobsCashLabel.AutoSize = true;
            this.BobsCashLabel.Location = new System.Drawing.Point(12, 39);
            this.BobsCashLabel.Name = "BobsCashLabel";
            this.BobsCashLabel.Size = new System.Drawing.Size(73, 13);
            this.BobsCashLabel.TabIndex = 1;
            this.BobsCashLabel.Text = "Bob has $100";
            // 
            // BankLabel
            // 
            this.BankLabel.AutoSize = true;
            this.BankLabel.Location = new System.Drawing.Point(12, 70);
            this.BankLabel.Name = "BankLabel";
            this.BankLabel.Size = new System.Drawing.Size(100, 13);
            this.BankLabel.TabIndex = 2;
            this.BankLabel.Text = "The bank has $100";
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(15, 115);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(75, 37);
            this.Button1.TabIndex = 3;
            this.Button1.Text = "Give $10 to Joe";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(137, 115);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 37);
            this.button2.TabIndex = 4;
            this.button2.Text = "Receive $5 from Bob";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(137, 158);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 37);
            this.button3.TabIndex = 6;
            this.button3.Text = "Bob gives $5 to Joe";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(15, 158);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 37);
            this.button4.TabIndex = 5;
            this.button4.Text = "Joe gives $10 to Bob";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // saveJoe
            // 
            this.saveJoe.Location = new System.Drawing.Point(13, 202);
            this.saveJoe.Name = "saveJoe";
            this.saveJoe.Size = new System.Drawing.Size(75, 23);
            this.saveJoe.TabIndex = 7;
            this.saveJoe.Text = "Save Joe";
            this.saveJoe.UseVisualStyleBackColor = true;
            this.saveJoe.Click += new System.EventHandler(this.SaveJoe_Click);
            // 
            // loadJoe
            // 
            this.loadJoe.Location = new System.Drawing.Point(137, 201);
            this.loadJoe.Name = "loadJoe";
            this.loadJoe.Size = new System.Drawing.Size(75, 23);
            this.loadJoe.TabIndex = 8;
            this.loadJoe.Text = "Load Joe";
            this.loadJoe.UseVisualStyleBackColor = true;
            this.loadJoe.Click += new System.EventHandler(this.LoadJoe_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 243);
            this.Controls.Add(this.loadJoe);
            this.Controls.Add(this.saveJoe);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.BankLabel);
            this.Controls.Add(this.BobsCashLabel);
            this.Controls.Add(this.JoesCashLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label JoesCashLabel;
        private System.Windows.Forms.Label BobsCashLabel;
        private System.Windows.Forms.Label BankLabel;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button saveJoe;
        private System.Windows.Forms.Button loadJoe;
    }
}

