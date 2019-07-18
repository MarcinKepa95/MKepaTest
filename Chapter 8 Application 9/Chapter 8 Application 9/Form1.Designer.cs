namespace Chapter_8_Application_9
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
            this.lumberjackNameLabel = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.addLumberjackButton = new System.Windows.Forms.Button();
            this.crispyRadio = new System.Windows.Forms.RadioButton();
            this.line = new System.Windows.Forms.ListBox();
            this.numberOfLumberjack = new System.Windows.Forms.NumericUpDown();
            this.feedALumberjackGroup = new System.Windows.Forms.GroupBox();
            this.soggyRadio = new System.Windows.Forms.RadioButton();
            this.brownedRadio = new System.Windows.Forms.RadioButton();
            this.bananaRadio = new System.Windows.Forms.RadioButton();
            this.addFlapjackButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nextLumberjackButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfLumberjack)).BeginInit();
            this.feedALumberjackGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // lumberjackNameLabel
            // 
            this.lumberjackNameLabel.AutoSize = true;
            this.lumberjackNameLabel.Location = new System.Drawing.Point(13, 16);
            this.lumberjackNameLabel.Name = "lumberjackNameLabel";
            this.lumberjackNameLabel.Size = new System.Drawing.Size(91, 13);
            this.lumberjackNameLabel.TabIndex = 0;
            this.lumberjackNameLabel.Text = "Lumberjack name";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(110, 13);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(119, 20);
            this.name.TabIndex = 1;
            this.name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Name_KeyDown);
            // 
            // addLumberjackButton
            // 
            this.addLumberjackButton.Location = new System.Drawing.Point(13, 42);
            this.addLumberjackButton.Name = "addLumberjackButton";
            this.addLumberjackButton.Size = new System.Drawing.Size(216, 23);
            this.addLumberjackButton.TabIndex = 2;
            this.addLumberjackButton.Text = "Add Lumberjack";
            this.addLumberjackButton.UseVisualStyleBackColor = true;
            this.addLumberjackButton.Click += new System.EventHandler(this.AddLumberjackButton_Click);
            // 
            // crispyRadio
            // 
            this.crispyRadio.AutoSize = true;
            this.crispyRadio.Location = new System.Drawing.Point(6, 45);
            this.crispyRadio.Name = "crispyRadio";
            this.crispyRadio.Size = new System.Drawing.Size(53, 17);
            this.crispyRadio.TabIndex = 3;
            this.crispyRadio.TabStop = true;
            this.crispyRadio.Text = "Crispy";
            this.crispyRadio.UseVisualStyleBackColor = true;
            // 
            // line
            // 
            this.line.FormattingEnabled = true;
            this.line.Location = new System.Drawing.Point(12, 114);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(120, 251);
            this.line.TabIndex = 4;
            // 
            // numberOfLumberjack
            // 
            this.numberOfLumberjack.Location = new System.Drawing.Point(6, 19);
            this.numberOfLumberjack.Name = "numberOfLumberjack";
            this.numberOfLumberjack.Size = new System.Drawing.Size(60, 20);
            this.numberOfLumberjack.TabIndex = 5;
            // 
            // feedALumberjackGroup
            // 
            this.feedALumberjackGroup.Controls.Add(this.nextLumberjackButton);
            this.feedALumberjackGroup.Controls.Add(this.label2);
            this.feedALumberjackGroup.Controls.Add(this.addFlapjackButton);
            this.feedALumberjackGroup.Controls.Add(this.bananaRadio);
            this.feedALumberjackGroup.Controls.Add(this.brownedRadio);
            this.feedALumberjackGroup.Controls.Add(this.soggyRadio);
            this.feedALumberjackGroup.Controls.Add(this.crispyRadio);
            this.feedALumberjackGroup.Controls.Add(this.numberOfLumberjack);
            this.feedALumberjackGroup.Location = new System.Drawing.Point(138, 88);
            this.feedALumberjackGroup.Name = "feedALumberjackGroup";
            this.feedALumberjackGroup.Size = new System.Drawing.Size(147, 277);
            this.feedALumberjackGroup.TabIndex = 6;
            this.feedALumberjackGroup.TabStop = false;
            this.feedALumberjackGroup.Text = "Feed a Lumberjack";
            // 
            // soggyRadio
            // 
            this.soggyRadio.AutoSize = true;
            this.soggyRadio.Location = new System.Drawing.Point(6, 68);
            this.soggyRadio.Name = "soggyRadio";
            this.soggyRadio.Size = new System.Drawing.Size(55, 17);
            this.soggyRadio.TabIndex = 6;
            this.soggyRadio.TabStop = true;
            this.soggyRadio.Text = "Soggy";
            this.soggyRadio.UseVisualStyleBackColor = true;
            // 
            // brownedRadio
            // 
            this.brownedRadio.AutoSize = true;
            this.brownedRadio.Location = new System.Drawing.Point(6, 91);
            this.brownedRadio.Name = "brownedRadio";
            this.brownedRadio.Size = new System.Drawing.Size(67, 17);
            this.brownedRadio.TabIndex = 7;
            this.brownedRadio.TabStop = true;
            this.brownedRadio.Text = "Browned";
            this.brownedRadio.UseVisualStyleBackColor = true;
            // 
            // bananaRadio
            // 
            this.bananaRadio.AutoSize = true;
            this.bananaRadio.Location = new System.Drawing.Point(6, 114);
            this.bananaRadio.Name = "bananaRadio";
            this.bananaRadio.Size = new System.Drawing.Size(62, 17);
            this.bananaRadio.TabIndex = 8;
            this.bananaRadio.TabStop = true;
            this.bananaRadio.Text = "Banana";
            this.bananaRadio.UseVisualStyleBackColor = true;
            // 
            // addFlapjackButton
            // 
            this.addFlapjackButton.Location = new System.Drawing.Point(6, 137);
            this.addFlapjackButton.Name = "addFlapjackButton";
            this.addFlapjackButton.Size = new System.Drawing.Size(135, 23);
            this.addFlapjackButton.TabIndex = 7;
            this.addFlapjackButton.Text = "Add Flapjack";
            this.addFlapjackButton.UseVisualStyleBackColor = true;
            this.addFlapjackButton.Click += new System.EventHandler(this.AddFlapjackButton_Click);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(6, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 73);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            // 
            // nextLumberjackButton
            // 
            this.nextLumberjackButton.Location = new System.Drawing.Point(6, 248);
            this.nextLumberjackButton.Name = "nextLumberjackButton";
            this.nextLumberjackButton.Size = new System.Drawing.Size(135, 23);
            this.nextLumberjackButton.TabIndex = 9;
            this.nextLumberjackButton.Text = "Next Lumberjack";
            this.nextLumberjackButton.UseVisualStyleBackColor = true;
            this.nextLumberjackButton.Click += new System.EventHandler(this.NextLumberjackButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Breakfast line";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 372);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.feedALumberjackGroup);
            this.Controls.Add(this.line);
            this.Controls.Add(this.addLumberjackButton);
            this.Controls.Add(this.name);
            this.Controls.Add(this.lumberjackNameLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numberOfLumberjack)).EndInit();
            this.feedALumberjackGroup.ResumeLayout(false);
            this.feedALumberjackGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lumberjackNameLabel;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Button addLumberjackButton;
        private System.Windows.Forms.RadioButton crispyRadio;
        private System.Windows.Forms.ListBox line;
        private System.Windows.Forms.NumericUpDown numberOfLumberjack;
        private System.Windows.Forms.GroupBox feedALumberjackGroup;
        private System.Windows.Forms.Button nextLumberjackButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addFlapjackButton;
        private System.Windows.Forms.RadioButton bananaRadio;
        private System.Windows.Forms.RadioButton brownedRadio;
        private System.Windows.Forms.RadioButton soggyRadio;
        private System.Windows.Forms.Label label3;
    }
}

