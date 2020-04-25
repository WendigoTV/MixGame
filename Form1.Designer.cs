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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.marble);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.glass3);
            this.Controls.Add(this.glass2);
            this.Controls.Add(this.glass1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.glass1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glass2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glass3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marble)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox glass1;
        private System.Windows.Forms.PictureBox glass2;
        private System.Windows.Forms.PictureBox glass3;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.PictureBox marble;
        private System.Windows.Forms.Timer animationFPS;
    }
}

