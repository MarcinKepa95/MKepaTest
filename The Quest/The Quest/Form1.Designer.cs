namespace The_Quest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.generalBackground = new System.Windows.Forms.PictureBox();
            this.table = new System.Windows.Forms.TableLayoutPanel();
            this.LeftAttack = new System.Windows.Forms.Button();
            this.RightAttack = new System.Windows.Forms.Button();
            this.UpAttack = new System.Windows.Forms.Button();
            this.DownAttack = new System.Windows.Forms.Button();
            this.attackGroupBox = new System.Windows.Forms.GroupBox();
            this.moveGroupBox = new System.Windows.Forms.GroupBox();
            this.UpMove = new System.Windows.Forms.Button();
            this.DownMove = new System.Windows.Forms.Button();
            this.LeftMove = new System.Windows.Forms.Button();
            this.RightMove = new System.Windows.Forms.Button();
            this.Hero = new System.Windows.Forms.PictureBox();
            this.Bat = new System.Windows.Forms.PictureBox();
            this.Ghost = new System.Windows.Forms.PictureBox();
            this.Ghoul = new System.Windows.Forms.PictureBox();
            this.RedPotion = new System.Windows.Forms.PictureBox();
            this.BluePotion = new System.Windows.Forms.PictureBox();
            this.Sword = new System.Windows.Forms.PictureBox();
            this.Bow = new System.Windows.Forms.PictureBox();
            this.Mace = new System.Windows.Forms.PictureBox();
            this.Weapon1 = new System.Windows.Forms.PictureBox();
            this.Weapon2 = new System.Windows.Forms.PictureBox();
            this.Weapon3 = new System.Windows.Forms.PictureBox();
            this.bluePotionInEq = new System.Windows.Forms.PictureBox();
            this.RedPotionInEq = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.generalBackground)).BeginInit();
            this.attackGroupBox.SuspendLayout();
            this.moveGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Hero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ghost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ghoul)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedPotion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BluePotion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Weapon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Weapon2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Weapon3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bluePotionInEq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedPotionInEq)).BeginInit();
            this.SuspendLayout();
            // 
            // generalBackground
            // 
            this.generalBackground.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("generalBackground.BackgroundImage")));
            this.generalBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generalBackground.Image = ((System.Drawing.Image)(resources.GetObject("generalBackground.Image")));
            this.generalBackground.Location = new System.Drawing.Point(0, 0);
            this.generalBackground.Name = "generalBackground";
            this.generalBackground.Size = new System.Drawing.Size(600, 400);
            this.generalBackground.TabIndex = 0;
            this.generalBackground.TabStop = false;
            // 
            // table
            // 
            this.table.BackColor = System.Drawing.Color.Transparent;
            this.table.ColumnCount = 2;
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.69633F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.30367F));
            this.table.Location = new System.Drawing.Point(333, 217);
            this.table.Name = "table";
            this.table.RowCount = 4;
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.table.Size = new System.Drawing.Size(191, 64);
            this.table.TabIndex = 1;
            this.table.Paint += new System.Windows.Forms.PaintEventHandler(this.TableLayoutPanel1_Paint);
            // 
            // LeftAttack
            // 
            this.LeftAttack.Location = new System.Drawing.Point(9, 33);
            this.LeftAttack.Name = "LeftAttack";
            this.LeftAttack.Size = new System.Drawing.Size(24, 24);
            this.LeftAttack.TabIndex = 2;
            this.LeftAttack.Text = "←";
            this.LeftAttack.UseVisualStyleBackColor = true;
            this.LeftAttack.Click += new System.EventHandler(this.LeftAttack_Click);
            // 
            // RightAttack
            // 
            this.RightAttack.Location = new System.Drawing.Point(55, 34);
            this.RightAttack.Name = "RightAttack";
            this.RightAttack.Size = new System.Drawing.Size(24, 24);
            this.RightAttack.TabIndex = 3;
            this.RightAttack.Text = "→";
            this.RightAttack.UseVisualStyleBackColor = true;
            this.RightAttack.Click += new System.EventHandler(this.RightAttack_Click);
            // 
            // UpAttack
            // 
            this.UpAttack.Location = new System.Drawing.Point(31, 12);
            this.UpAttack.Name = "UpAttack";
            this.UpAttack.Size = new System.Drawing.Size(24, 24);
            this.UpAttack.TabIndex = 4;
            this.UpAttack.Text = "↑";
            this.UpAttack.UseVisualStyleBackColor = true;
            this.UpAttack.Click += new System.EventHandler(this.UpAttack_Click);
            // 
            // DownAttack
            // 
            this.DownAttack.Location = new System.Drawing.Point(32, 56);
            this.DownAttack.Name = "DownAttack";
            this.DownAttack.Size = new System.Drawing.Size(24, 24);
            this.DownAttack.TabIndex = 5;
            this.DownAttack.Text = "↓";
            this.DownAttack.UseVisualStyleBackColor = true;
            this.DownAttack.Click += new System.EventHandler(this.DownAttack_Click);
            // 
            // attackGroupBox
            // 
            this.attackGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.attackGroupBox.Controls.Add(this.UpAttack);
            this.attackGroupBox.Controls.Add(this.DownAttack);
            this.attackGroupBox.Controls.Add(this.LeftAttack);
            this.attackGroupBox.Controls.Add(this.RightAttack);
            this.attackGroupBox.Location = new System.Drawing.Point(438, 306);
            this.attackGroupBox.Name = "attackGroupBox";
            this.attackGroupBox.Size = new System.Drawing.Size(86, 85);
            this.attackGroupBox.TabIndex = 6;
            this.attackGroupBox.TabStop = false;
            this.attackGroupBox.Text = "Attack";
            this.attackGroupBox.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // moveGroupBox
            // 
            this.moveGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.moveGroupBox.Controls.Add(this.UpMove);
            this.moveGroupBox.Controls.Add(this.DownMove);
            this.moveGroupBox.Controls.Add(this.LeftMove);
            this.moveGroupBox.Controls.Add(this.RightMove);
            this.moveGroupBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.moveGroupBox.Location = new System.Drawing.Point(346, 306);
            this.moveGroupBox.Name = "moveGroupBox";
            this.moveGroupBox.Size = new System.Drawing.Size(86, 85);
            this.moveGroupBox.TabIndex = 7;
            this.moveGroupBox.TabStop = false;
            this.moveGroupBox.Text = "Move";
            // 
            // UpMove
            // 
            this.UpMove.Location = new System.Drawing.Point(28, 12);
            this.UpMove.Name = "UpMove";
            this.UpMove.Size = new System.Drawing.Size(24, 24);
            this.UpMove.TabIndex = 4;
            this.UpMove.Text = "↑";
            this.UpMove.UseVisualStyleBackColor = true;
            this.UpMove.Click += new System.EventHandler(this.UpMove_Click);
            // 
            // DownMove
            // 
            this.DownMove.Location = new System.Drawing.Point(29, 56);
            this.DownMove.Name = "DownMove";
            this.DownMove.Size = new System.Drawing.Size(24, 24);
            this.DownMove.TabIndex = 5;
            this.DownMove.Text = "↓";
            this.DownMove.UseVisualStyleBackColor = true;
            this.DownMove.Click += new System.EventHandler(this.DownMove_Click);
            // 
            // LeftMove
            // 
            this.LeftMove.Location = new System.Drawing.Point(6, 33);
            this.LeftMove.Name = "LeftMove";
            this.LeftMove.Size = new System.Drawing.Size(24, 24);
            this.LeftMove.TabIndex = 2;
            this.LeftMove.Text = "←";
            this.LeftMove.UseVisualStyleBackColor = true;
            this.LeftMove.Click += new System.EventHandler(this.LeftMove_Click);
            // 
            // RightMove
            // 
            this.RightMove.Location = new System.Drawing.Point(52, 34);
            this.RightMove.Name = "RightMove";
            this.RightMove.Size = new System.Drawing.Size(24, 24);
            this.RightMove.TabIndex = 3;
            this.RightMove.Text = "→";
            this.RightMove.UseVisualStyleBackColor = true;
            this.RightMove.Click += new System.EventHandler(this.RightMove_Click);
            // 
            // Hero
            // 
            this.Hero.Image = ((System.Drawing.Image)(resources.GetObject("Hero.Image")));
            this.Hero.Location = new System.Drawing.Point(79, 59);
            this.Hero.Name = "Hero";
            this.Hero.Size = new System.Drawing.Size(30, 30);
            this.Hero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Hero.TabIndex = 8;
            this.Hero.TabStop = false;
            // 
            // Bat
            // 
            this.Bat.Image = ((System.Drawing.Image)(resources.GetObject("Bat.Image")));
            this.Bat.Location = new System.Drawing.Point(115, 59);
            this.Bat.Name = "Bat";
            this.Bat.Size = new System.Drawing.Size(30, 30);
            this.Bat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Bat.TabIndex = 9;
            this.Bat.TabStop = false;
            // 
            // Ghost
            // 
            this.Ghost.Image = ((System.Drawing.Image)(resources.GetObject("Ghost.Image")));
            this.Ghost.Location = new System.Drawing.Point(151, 59);
            this.Ghost.Name = "Ghost";
            this.Ghost.Size = new System.Drawing.Size(30, 30);
            this.Ghost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ghost.TabIndex = 10;
            this.Ghost.TabStop = false;
            // 
            // Ghoul
            // 
            this.Ghoul.Image = ((System.Drawing.Image)(resources.GetObject("Ghoul.Image")));
            this.Ghoul.Location = new System.Drawing.Point(187, 59);
            this.Ghoul.Name = "Ghoul";
            this.Ghoul.Size = new System.Drawing.Size(30, 30);
            this.Ghoul.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ghoul.TabIndex = 11;
            this.Ghoul.TabStop = false;
            // 
            // RedPotion
            // 
            this.RedPotion.Image = ((System.Drawing.Image)(resources.GetObject("RedPotion.Image")));
            this.RedPotion.Location = new System.Drawing.Point(223, 59);
            this.RedPotion.Name = "RedPotion";
            this.RedPotion.Size = new System.Drawing.Size(30, 30);
            this.RedPotion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RedPotion.TabIndex = 12;
            this.RedPotion.TabStop = false;
            // 
            // BluePotion
            // 
            this.BluePotion.Image = ((System.Drawing.Image)(resources.GetObject("BluePotion.Image")));
            this.BluePotion.Location = new System.Drawing.Point(259, 59);
            this.BluePotion.Name = "BluePotion";
            this.BluePotion.Size = new System.Drawing.Size(30, 30);
            this.BluePotion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BluePotion.TabIndex = 13;
            this.BluePotion.TabStop = false;
            // 
            // Sword
            // 
            this.Sword.Image = ((System.Drawing.Image)(resources.GetObject("Sword.Image")));
            this.Sword.Location = new System.Drawing.Point(295, 59);
            this.Sword.Name = "Sword";
            this.Sword.Size = new System.Drawing.Size(30, 30);
            this.Sword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Sword.TabIndex = 14;
            this.Sword.TabStop = false;
            // 
            // Bow
            // 
            this.Bow.Image = ((System.Drawing.Image)(resources.GetObject("Bow.Image")));
            this.Bow.Location = new System.Drawing.Point(331, 59);
            this.Bow.Name = "Bow";
            this.Bow.Size = new System.Drawing.Size(30, 30);
            this.Bow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Bow.TabIndex = 15;
            this.Bow.TabStop = false;
            // 
            // Mace
            // 
            this.Mace.Image = ((System.Drawing.Image)(resources.GetObject("Mace.Image")));
            this.Mace.Location = new System.Drawing.Point(367, 59);
            this.Mace.Name = "Mace";
            this.Mace.Size = new System.Drawing.Size(30, 30);
            this.Mace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Mace.TabIndex = 16;
            this.Mace.TabStop = false;
            // 
            // Weapon1
            // 
            this.Weapon1.Image = ((System.Drawing.Image)(resources.GetObject("Weapon1.Image")));
            this.Weapon1.Location = new System.Drawing.Point(68, 318);
            this.Weapon1.Name = "Weapon1";
            this.Weapon1.Size = new System.Drawing.Size(50, 50);
            this.Weapon1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Weapon1.TabIndex = 17;
            this.Weapon1.TabStop = false;
            this.Weapon1.Click += new System.EventHandler(this.Weapon1_Click);
            // 
            // Weapon2
            // 
            this.Weapon2.Image = ((System.Drawing.Image)(resources.GetObject("Weapon2.Image")));
            this.Weapon2.Location = new System.Drawing.Point(124, 318);
            this.Weapon2.Name = "Weapon2";
            this.Weapon2.Size = new System.Drawing.Size(50, 50);
            this.Weapon2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Weapon2.TabIndex = 18;
            this.Weapon2.TabStop = false;
            this.Weapon2.Click += new System.EventHandler(this.Weapon2_Click);
            // 
            // Weapon3
            // 
            this.Weapon3.Image = ((System.Drawing.Image)(resources.GetObject("Weapon3.Image")));
            this.Weapon3.Location = new System.Drawing.Point(180, 318);
            this.Weapon3.Name = "Weapon3";
            this.Weapon3.Size = new System.Drawing.Size(50, 50);
            this.Weapon3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Weapon3.TabIndex = 19;
            this.Weapon3.TabStop = false;
            this.Weapon3.Click += new System.EventHandler(this.Weapon3_Click);
            // 
            // bluePotionInEq
            // 
            this.bluePotionInEq.Image = ((System.Drawing.Image)(resources.GetObject("bluePotionInEq.Image")));
            this.bluePotionInEq.Location = new System.Drawing.Point(236, 318);
            this.bluePotionInEq.Name = "bluePotionInEq";
            this.bluePotionInEq.Size = new System.Drawing.Size(50, 50);
            this.bluePotionInEq.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.bluePotionInEq.TabIndex = 20;
            this.bluePotionInEq.TabStop = false;
            this.bluePotionInEq.Click += new System.EventHandler(this.BluePotionInEq_Click);
            // 
            // RedPotionInEq
            // 
            this.RedPotionInEq.Image = ((System.Drawing.Image)(resources.GetObject("RedPotionInEq.Image")));
            this.RedPotionInEq.Location = new System.Drawing.Point(290, 318);
            this.RedPotionInEq.Name = "RedPotionInEq";
            this.RedPotionInEq.Size = new System.Drawing.Size(50, 50);
            this.RedPotionInEq.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.RedPotionInEq.TabIndex = 21;
            this.RedPotionInEq.TabStop = false;
            this.RedPotionInEq.Click += new System.EventHandler(this.RedPotionInEq_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.RedPotionInEq);
            this.Controls.Add(this.bluePotionInEq);
            this.Controls.Add(this.Weapon3);
            this.Controls.Add(this.Weapon2);
            this.Controls.Add(this.Weapon1);
            this.Controls.Add(this.Hero);
            this.Controls.Add(this.Bat);
            this.Controls.Add(this.Ghost);
            this.Controls.Add(this.Ghoul);
            this.Controls.Add(this.Mace);
            this.Controls.Add(this.Bow);
            this.Controls.Add(this.Sword);
            this.Controls.Add(this.BluePotion);
            this.Controls.Add(this.RedPotion);
            this.Controls.Add(this.moveGroupBox);
            this.Controls.Add(this.attackGroupBox);
            this.Controls.Add(this.table);
            this.Controls.Add(this.generalBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "The Quest";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.generalBackground)).EndInit();
            this.attackGroupBox.ResumeLayout(false);
            this.moveGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Hero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ghost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ghoul)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedPotion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BluePotion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Weapon1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Weapon2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Weapon3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bluePotionInEq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedPotionInEq)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox generalBackground;
        private System.Windows.Forms.TableLayoutPanel table;
        private System.Windows.Forms.Button LeftAttack;
        private System.Windows.Forms.Button RightAttack;
        private System.Windows.Forms.Button UpAttack;
        private System.Windows.Forms.Button DownAttack;
        private System.Windows.Forms.GroupBox attackGroupBox;
        private System.Windows.Forms.GroupBox moveGroupBox;
        private System.Windows.Forms.Button UpMove;
        private System.Windows.Forms.Button DownMove;
        private System.Windows.Forms.Button LeftMove;
        private System.Windows.Forms.Button RightMove;
        private System.Windows.Forms.PictureBox Hero;
        private System.Windows.Forms.PictureBox Bat;
        private System.Windows.Forms.PictureBox Ghost;
        private System.Windows.Forms.PictureBox Ghoul;
        private System.Windows.Forms.PictureBox RedPotion;
        private System.Windows.Forms.PictureBox BluePotion;
        private System.Windows.Forms.PictureBox Sword;
        private System.Windows.Forms.PictureBox Bow;
        private System.Windows.Forms.PictureBox Mace;
        private System.Windows.Forms.PictureBox Weapon1;
        private System.Windows.Forms.PictureBox Weapon2;
        private System.Windows.Forms.PictureBox Weapon3;
        private System.Windows.Forms.PictureBox bluePotionInEq;
        private System.Windows.Forms.PictureBox RedPotionInEq;
    }
}

