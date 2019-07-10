namespace Chapter_8_Application_7
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
            this.DeckListBox1 = new System.Windows.Forms.ListBox();
            this.DeckListBox2 = new System.Windows.Forms.ListBox();
            this.LeftToRight = new System.Windows.Forms.Button();
            this.RightToLeft = new System.Windows.Forms.Button();
            this.ResetDeck1 = new System.Windows.Forms.Button();
            this.ShuffleDeck1 = new System.Windows.Forms.Button();
            this.ResetDeck2 = new System.Windows.Forms.Button();
            this.ShuffleDeck2 = new System.Windows.Forms.Button();
            this.Deck1Label = new System.Windows.Forms.Label();
            this.Deck2Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DeckListBox1
            // 
            this.DeckListBox1.FormattingEnabled = true;
            this.DeckListBox1.Location = new System.Drawing.Point(13, 26);
            this.DeckListBox1.Name = "DeckListBox1";
            this.DeckListBox1.Size = new System.Drawing.Size(151, 225);
            this.DeckListBox1.TabIndex = 0;
            // 
            // DeckListBox2
            // 
            this.DeckListBox2.FormattingEnabled = true;
            this.DeckListBox2.Location = new System.Drawing.Point(222, 26);
            this.DeckListBox2.Name = "DeckListBox2";
            this.DeckListBox2.Size = new System.Drawing.Size(151, 225);
            this.DeckListBox2.TabIndex = 1;
            // 
            // LeftToRight
            // 
            this.LeftToRight.Location = new System.Drawing.Point(171, 85);
            this.LeftToRight.Name = "LeftToRight";
            this.LeftToRight.Size = new System.Drawing.Size(45, 23);
            this.LeftToRight.TabIndex = 2;
            this.LeftToRight.Text = ">>";
            this.LeftToRight.UseVisualStyleBackColor = true;
            this.LeftToRight.Click += new System.EventHandler(this.LeftToRight_Click);
            // 
            // RightToLeft
            // 
            this.RightToLeft.Location = new System.Drawing.Point(171, 145);
            this.RightToLeft.Name = "RightToLeft";
            this.RightToLeft.Size = new System.Drawing.Size(45, 23);
            this.RightToLeft.TabIndex = 3;
            this.RightToLeft.Text = "<<";
            this.RightToLeft.UseVisualStyleBackColor = true;
            this.RightToLeft.Click += new System.EventHandler(this.RightToLeft_Click);
            // 
            // ResetDeck1
            // 
            this.ResetDeck1.Location = new System.Drawing.Point(13, 258);
            this.ResetDeck1.Name = "ResetDeck1";
            this.ResetDeck1.Size = new System.Drawing.Size(151, 23);
            this.ResetDeck1.TabIndex = 4;
            this.ResetDeck1.Text = "Reset deck #1";
            this.ResetDeck1.UseVisualStyleBackColor = true;
            this.ResetDeck1.Click += new System.EventHandler(this.ResetDeck1_Click);
            // 
            // ShuffleDeck1
            // 
            this.ShuffleDeck1.Location = new System.Drawing.Point(13, 288);
            this.ShuffleDeck1.Name = "ShuffleDeck1";
            this.ShuffleDeck1.Size = new System.Drawing.Size(151, 23);
            this.ShuffleDeck1.TabIndex = 5;
            this.ShuffleDeck1.Text = "Shuffle deck #1";
            this.ShuffleDeck1.UseVisualStyleBackColor = true;
            this.ShuffleDeck1.Click += new System.EventHandler(this.ShuffleDeck1_Click);
            // 
            // ResetDeck2
            // 
            this.ResetDeck2.Location = new System.Drawing.Point(222, 258);
            this.ResetDeck2.Name = "ResetDeck2";
            this.ResetDeck2.Size = new System.Drawing.Size(151, 23);
            this.ResetDeck2.TabIndex = 6;
            this.ResetDeck2.Text = "Reset deck #2";
            this.ResetDeck2.UseVisualStyleBackColor = true;
            this.ResetDeck2.Click += new System.EventHandler(this.ResetDeck2_Click);
            // 
            // ShuffleDeck2
            // 
            this.ShuffleDeck2.Location = new System.Drawing.Point(222, 288);
            this.ShuffleDeck2.Name = "ShuffleDeck2";
            this.ShuffleDeck2.Size = new System.Drawing.Size(151, 23);
            this.ShuffleDeck2.TabIndex = 7;
            this.ShuffleDeck2.Text = "Shuffle deck #2";
            this.ShuffleDeck2.UseVisualStyleBackColor = true;
            this.ShuffleDeck2.Click += new System.EventHandler(this.ShuffleDeck2_Click);
            // 
            // Deck1Label
            // 
            this.Deck1Label.AutoSize = true;
            this.Deck1Label.Location = new System.Drawing.Point(12, 9);
            this.Deck1Label.Name = "Deck1Label";
            this.Deck1Label.Size = new System.Drawing.Size(49, 13);
            this.Deck1Label.TabIndex = 8;
            this.Deck1Label.Text = "Deck #1";
            // 
            // Deck2Label
            // 
            this.Deck2Label.AutoSize = true;
            this.Deck2Label.Location = new System.Drawing.Point(219, 9);
            this.Deck2Label.Name = "Deck2Label";
            this.Deck2Label.Size = new System.Drawing.Size(49, 13);
            this.Deck2Label.TabIndex = 9;
            this.Deck2Label.Text = "Deck #2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 320);
            this.Controls.Add(this.Deck2Label);
            this.Controls.Add(this.Deck1Label);
            this.Controls.Add(this.ShuffleDeck2);
            this.Controls.Add(this.ResetDeck2);
            this.Controls.Add(this.ShuffleDeck1);
            this.Controls.Add(this.ResetDeck1);
            this.Controls.Add(this.RightToLeft);
            this.Controls.Add(this.LeftToRight);
            this.Controls.Add(this.DeckListBox2);
            this.Controls.Add(this.DeckListBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox DeckListBox1;
        private System.Windows.Forms.ListBox DeckListBox2;
        private System.Windows.Forms.Button LeftToRight;
        private System.Windows.Forms.Button RightToLeft;
        private System.Windows.Forms.Button ResetDeck1;
        private System.Windows.Forms.Button ShuffleDeck1;
        private System.Windows.Forms.Button ResetDeck2;
        private System.Windows.Forms.Button ShuffleDeck2;
        private System.Windows.Forms.Label Deck1Label;
        private System.Windows.Forms.Label Deck2Label;
    }
}

