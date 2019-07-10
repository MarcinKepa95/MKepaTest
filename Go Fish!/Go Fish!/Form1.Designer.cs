namespace Go_Fish_
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
            this.yourNameLabel = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.gameProgressLabel = new System.Windows.Forms.Label();
            this.textProgress = new System.Windows.Forms.TextBox();
            this.textBooks = new System.Windows.Forms.TextBox();
            this.BooksLabel = new System.Windows.Forms.Label();
            this.buttonAsk = new System.Windows.Forms.Button();
            this.listHand = new System.Windows.Forms.ListBox();
            this.handLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // yourNameLabel
            // 
            this.yourNameLabel.AutoSize = true;
            this.yourNameLabel.Location = new System.Drawing.Point(12, 14);
            this.yourNameLabel.Name = "yourNameLabel";
            this.yourNameLabel.Size = new System.Drawing.Size(60, 13);
            this.yourNameLabel.TabIndex = 0;
            this.yourNameLabel.Text = "Your Name";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(15, 30);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(127, 20);
            this.textName.TabIndex = 1;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(148, 30);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(159, 20);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "Start the game!";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // gameProgressLabel
            // 
            this.gameProgressLabel.AutoSize = true;
            this.gameProgressLabel.Location = new System.Drawing.Point(12, 53);
            this.gameProgressLabel.Name = "gameProgressLabel";
            this.gameProgressLabel.Size = new System.Drawing.Size(78, 13);
            this.gameProgressLabel.TabIndex = 3;
            this.gameProgressLabel.Text = "Game progress";
            // 
            // textProgress
            // 
            this.textProgress.Location = new System.Drawing.Point(15, 70);
            this.textProgress.Multiline = true;
            this.textProgress.Name = "textProgress";
            this.textProgress.ReadOnly = true;
            this.textProgress.Size = new System.Drawing.Size(292, 266);
            this.textProgress.TabIndex = 4;
            // 
            // textBooks
            // 
            this.textBooks.Location = new System.Drawing.Point(15, 355);
            this.textBooks.Multiline = true;
            this.textBooks.Name = "textBooks";
            this.textBooks.ReadOnly = true;
            this.textBooks.Size = new System.Drawing.Size(292, 152);
            this.textBooks.TabIndex = 5;
            // 
            // BooksLabel
            // 
            this.BooksLabel.AutoSize = true;
            this.BooksLabel.Location = new System.Drawing.Point(12, 339);
            this.BooksLabel.Name = "BooksLabel";
            this.BooksLabel.Size = new System.Drawing.Size(37, 13);
            this.BooksLabel.TabIndex = 6;
            this.BooksLabel.Text = "Books";
            // 
            // buttonAsk
            // 
            this.buttonAsk.Enabled = false;
            this.buttonAsk.Location = new System.Drawing.Point(313, 484);
            this.buttonAsk.Name = "buttonAsk";
            this.buttonAsk.Size = new System.Drawing.Size(203, 23);
            this.buttonAsk.TabIndex = 8;
            this.buttonAsk.Text = "Ask for a card";
            this.buttonAsk.UseVisualStyleBackColor = true;
            this.buttonAsk.Click += new System.EventHandler(this.ButtonAsk_Click);
            // 
            // listHand
            // 
            this.listHand.FormattingEnabled = true;
            this.listHand.Location = new System.Drawing.Point(313, 30);
            this.listHand.Name = "listHand";
            this.listHand.Size = new System.Drawing.Size(203, 446);
            this.listHand.TabIndex = 9;
            // 
            // handLabel
            // 
            this.handLabel.AutoSize = true;
            this.handLabel.Location = new System.Drawing.Point(310, 9);
            this.handLabel.Name = "handLabel";
            this.handLabel.Size = new System.Drawing.Size(56, 13);
            this.handLabel.TabIndex = 10;
            this.handLabel.Text = "Your hand";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 519);
            this.Controls.Add(this.handLabel);
            this.Controls.Add(this.listHand);
            this.Controls.Add(this.buttonAsk);
            this.Controls.Add(this.BooksLabel);
            this.Controls.Add(this.textBooks);
            this.Controls.Add(this.textProgress);
            this.Controls.Add(this.gameProgressLabel);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.yourNameLabel);
            this.Name = "Form1";
            this.Text = "Go Fish!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label yourNameLabel;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label gameProgressLabel;
        private System.Windows.Forms.TextBox textProgress;
        private System.Windows.Forms.TextBox textBooks;
        private System.Windows.Forms.Label BooksLabel;
        private System.Windows.Forms.Button buttonAsk;
        private System.Windows.Forms.ListBox listHand;
        private System.Windows.Forms.Label handLabel;
    }
}

