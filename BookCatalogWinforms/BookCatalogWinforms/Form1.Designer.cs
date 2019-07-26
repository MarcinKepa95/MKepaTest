namespace BookCatalogWinforms
{
    partial class BookCatalog
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.BookList = new System.Windows.Forms.ListBox();
            this.BookDescription = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Genre = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Publisher = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Dodaj książkę";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(103, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Zapisz książki";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(200, 13);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Wczytaj książki";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // BookList
            // 
            this.BookList.FormattingEnabled = true;
            this.BookList.Location = new System.Drawing.Point(16, 243);
            this.BookList.Name = "BookList";
            this.BookList.Size = new System.Drawing.Size(177, 264);
            this.BookList.TabIndex = 3;
            this.BookList.SelectedIndexChanged += new System.EventHandler(this.BookList_SelectedIndexChanged);
            // 
            // BookDescription
            // 
            this.BookDescription.Enabled = false;
            this.BookDescription.Location = new System.Drawing.Point(199, 58);
            this.BookDescription.Multiline = true;
            this.BookDescription.Name = "BookDescription";
            this.BookDescription.Size = new System.Drawing.Size(221, 449);
            this.BookDescription.TabIndex = 4;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(295, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(125, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "Edytuj książke";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Filtr (Gatunek):";
            // 
            // Genre
            // 
            this.Genre.FormattingEnabled = true;
            this.Genre.Location = new System.Drawing.Point(16, 58);
            this.Genre.Name = "Genre";
            this.Genre.Size = new System.Drawing.Size(178, 79);
            this.Genre.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Filtr (Wydawca):";
            // 
            // Publisher
            // 
            this.Publisher.FormattingEnabled = true;
            this.Publisher.Location = new System.Drawing.Point(16, 156);
            this.Publisher.Name = "Publisher";
            this.Publisher.Size = new System.Drawing.Size(178, 64);
            this.Publisher.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Książki:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(197, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Opis książki";
            // 
            // BookCatalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 521);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Publisher);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Genre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.BookDescription);
            this.Controls.Add(this.BookList);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(460, 560);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(460, 560);
            this.Name = "BookCatalog";
            this.Text = "Book Catalog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox BookList;
        private System.Windows.Forms.TextBox BookDescription;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox Genre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox Publisher;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

