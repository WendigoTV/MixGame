namespace MixGame
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.glass1 = new System.Windows.Forms.PictureBox();
            this.glass2 = new System.Windows.Forms.PictureBox();
            this.glass3 = new System.Windows.Forms.PictureBox();
            this.startButton = new System.Windows.Forms.Button();
            this.marble = new System.Windows.Forms.PictureBox();
            this.animationFPS = new System.Windows.Forms.Timer(this.components);
            this.currentMoney = new System.Windows.Forms.Label();
            this.gameResults = new System.Windows.Forms.Label();
            this.difficulty = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bankrot = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.glass1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glass2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glass3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marble)).BeginInit();
            this.SuspendLayout();
            // 
            // glass1
            // 
            this.glass1.Image = global::MixGame.Properties.Resources.GlassEmpty;
            this.glass1.Location = new System.Drawing.Point(11, 65);
            this.glass1.Margin = new System.Windows.Forms.Padding(2);
            this.glass1.Name = "glass1";
            this.glass1.Size = new System.Drawing.Size(148, 205);
            this.glass1.TabIndex = 0;
            this.glass1.TabStop = false;
            this.glass1.Click += new System.EventHandler(this.glass1_Click);
            // 
            // glass2
            // 
            this.glass2.Image = global::MixGame.Properties.Resources.GlassEmpty;
            this.glass2.Location = new System.Drawing.Point(227, 65);
            this.glass2.Margin = new System.Windows.Forms.Padding(2);
            this.glass2.Name = "glass2";
            this.glass2.Size = new System.Drawing.Size(148, 205);
            this.glass2.TabIndex = 1;
            this.glass2.TabStop = false;
            this.glass2.Click += new System.EventHandler(this.glass2_Click);
            // 
            // glass3
            // 
            this.glass3.Image = global::MixGame.Properties.Resources.GlassEmpty;
            this.glass3.Location = new System.Drawing.Point(441, 65);
            this.glass3.Margin = new System.Windows.Forms.Padding(2);
            this.glass3.Name = "glass3";
            this.glass3.Size = new System.Drawing.Size(148, 205);
            this.glass3.TabIndex = 2;
            this.glass3.TabStop = false;
            this.glass3.Click += new System.EventHandler(this.glass3_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(227, 284);
            this.startButton.Margin = new System.Windows.Forms.Padding(2);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(148, 62);
            this.startButton.TabIndex = 3;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // marble
            // 
            this.marble.Image = global::MixGame.Properties.Resources.Marble;
            this.marble.Location = new System.Drawing.Point(264, 145);
            this.marble.Margin = new System.Windows.Forms.Padding(2);
            this.marble.Name = "marble";
            this.marble.Size = new System.Drawing.Size(72, 72);
            this.marble.TabIndex = 4;
            this.marble.TabStop = false;
            // 
            // animationFPS
            // 
            this.animationFPS.Tick += new System.EventHandler(this.animationFPS_Tick);
            // 
            // currentMoney
            // 
            this.currentMoney.AutoSize = true;
            this.currentMoney.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.currentMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.currentMoney.Location = new System.Drawing.Point(12, 9);
            this.currentMoney.Name = "currentMoney";
            this.currentMoney.Size = new System.Drawing.Size(65, 33);
            this.currentMoney.TabIndex = 5;
            this.currentMoney.Text = "$:   ";
            // 
            // gameResults
            // 
            this.gameResults.AutoSize = true;
            this.gameResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gameResults.Location = new System.Drawing.Point(209, 9);
            this.gameResults.Name = "gameResults";
            this.gameResults.Size = new System.Drawing.Size(177, 39);
            this.gameResults.TabIndex = 6;
            this.gameResults.Text = "Smůla! ;-;";
            // 
            // difficulty
            // 
            this.difficulty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.difficulty.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.difficulty.FormattingEnabled = true;
            this.difficulty.Location = new System.Drawing.Point(441, 12);
            this.difficulty.Name = "difficulty";
            this.difficulty.Size = new System.Drawing.Size(147, 21);
            this.difficulty.TabIndex = 7;
            this.difficulty.SelectedValueChanged += new System.EventHandler(this.difficulty_SelectedValueChanged);
            this.difficulty.MouseHover += new System.EventHandler(this.difficulty_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(487, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Obtížnost:";
            // 
            // bankrot
            // 
            this.bankrot.AutoSize = true;
            this.bankrot.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bankrot.Location = new System.Drawing.Point(12, 285);
            this.bankrot.Name = "bankrot";
            this.bankrot.Size = new System.Drawing.Size(592, 61);
            this.bankrot.TabIndex = 9;
            this.bankrot.Text = "BANKROT, HAHAHA!!!";
            this.bankrot.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "© WendigoTV, 2020";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bankrot);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.difficulty);
            this.Controls.Add(this.gameResults);
            this.Controls.Add(this.currentMoney);
            this.Controls.Add(this.marble);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.glass3);
            this.Controls.Add(this.glass2);
            this.Controls.Add(this.glass1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.glass1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glass2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glass3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marble)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox glass1;
        private System.Windows.Forms.PictureBox glass2;
        private System.Windows.Forms.PictureBox glass3;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.PictureBox marble;
        private System.Windows.Forms.Timer animationFPS;
        private System.Windows.Forms.Label currentMoney;
        private System.Windows.Forms.Label gameResults;
        private System.Windows.Forms.ComboBox difficulty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label bankrot;
        private System.Windows.Forms.Label label2;
    }
}

