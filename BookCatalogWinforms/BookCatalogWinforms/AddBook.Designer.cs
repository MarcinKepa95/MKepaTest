namespace BookCatalogWinforms
{
    partial class AddBook
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
            this.label1 = new System.Windows.Forms.Label();
            this.bookname = new System.Windows.Forms.TextBox();
            this.bookdesc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.year = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.direct = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Required = new System.Windows.Forms.CheckBox();
            this.RareBook = new System.Windows.Forms.CheckBox();
            this.Add = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.bookrel = new System.Windows.Forms.NumericUpDown();
            this.publisher = new System.Windows.Forms.ComboBox();
            this.Genre = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.bookrel)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tytuł:";
            // 
            // bookname
            // 
            this.bookname.Location = new System.Drawing.Point(54, 10);
            this.bookname.Name = "bookname";
            this.bookname.Size = new System.Drawing.Size(100, 20);
            this.bookname.TabIndex = 1;
            // 
            // bookdesc
            // 
            this.bookdesc.Location = new System.Drawing.Point(54, 36);
            this.bookdesc.Name = "bookdesc";
            this.bookdesc.Size = new System.Drawing.Size(100, 20);
            this.bookdesc.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Opis:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Rok wydania:";
            // 
            // year
            // 
            this.year.Enabled = false;
            this.year.Location = new System.Drawing.Point(241, 36);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(100, 20);
            this.year.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(171, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Rok";
            // 
            // direct
            // 
            this.direct.Enabled = false;
            this.direct.Location = new System.Drawing.Point(226, 62);
            this.direct.Name = "direct";
            this.direct.Size = new System.Drawing.Size(115, 20);
            this.direct.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(171, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Kierunek";
            // 
            // Required
            // 
            this.Required.AutoSize = true;
            this.Required.Location = new System.Drawing.Point(174, 12);
            this.Required.Name = "Required";
            this.Required.Size = new System.Drawing.Size(80, 17);
            this.Required.TabIndex = 10;
            this.Required.Text = "Wymagana";
            this.Required.UseVisualStyleBackColor = true;
            this.Required.CheckedChanged += new System.EventHandler(this.Required_CheckedChanged);
            // 
            // RareBook
            // 
            this.RareBook.AutoSize = true;
            this.RareBook.Location = new System.Drawing.Point(19, 116);
            this.RareBook.Name = "RareBook";
            this.RareBook.Size = new System.Drawing.Size(74, 17);
            this.RareBook.TabIndex = 11;
            this.RareBook.Text = "Biały kruk";
            this.RareBook.UseVisualStyleBackColor = true;
            this.RareBook.CheckedChanged += new System.EventHandler(this.CheckBox2_CheckedChanged);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(13, 180);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 12;
            this.Add.Text = "Dodaj";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(212, 180);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 13;
            this.Cancel.Text = "Anuluj";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // bookrel
            // 
            this.bookrel.Location = new System.Drawing.Point(94, 63);
            this.bookrel.Maximum = new decimal(new int[] {
            2050,
            0,
            0,
            0});
            this.bookrel.Name = "bookrel";
            this.bookrel.Size = new System.Drawing.Size(60, 20);
            this.bookrel.TabIndex = 14;
            this.bookrel.Value = new decimal(new int[] {
            1950,
            0,
            0,
            0});
            // 
            // publisher
            // 
            this.publisher.FormattingEnabled = true;
            this.publisher.Location = new System.Drawing.Point(16, 89);
            this.publisher.Name = "publisher";
            this.publisher.Size = new System.Drawing.Size(121, 21);
            this.publisher.TabIndex = 15;
            this.publisher.Text = "Wydawca";
            // 
            // Genre
            // 
            this.Genre.FormattingEnabled = true;
            this.Genre.Location = new System.Drawing.Point(203, 89);
            this.Genre.Name = "Genre";
            this.Genre.Size = new System.Drawing.Size(138, 79);
            this.Genre.TabIndex = 16;
            // 
            // AddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 216);
            this.Controls.Add(this.Genre);
            this.Controls.Add(this.publisher);
            this.Controls.Add(this.bookrel);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.RareBook);
            this.Controls.Add(this.Required);
            this.Controls.Add(this.direct);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.year);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bookdesc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bookname);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(370, 255);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(370, 255);
            this.Name = "AddBook";
            this.Text = "Add Book";
            ((System.ComponentModel.ISupportInitialize)(this.bookrel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox bookname;
        private System.Windows.Forms.TextBox bookdesc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox year;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox direct;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox Required;
        private System.Windows.Forms.CheckBox RareBook;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.NumericUpDown bookrel;
        private System.Windows.Forms.ComboBox publisher;
        private System.Windows.Forms.CheckedListBox Genre;
    }
}