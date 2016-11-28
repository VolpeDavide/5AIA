namespace _5AIA
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnScalaberni = new System.Windows.Forms.Button();
            this.btnGabrieleStefani = new System.Windows.Forms.Button();
            this.btnMattiaRanfagni = new System.Windows.Forms.Button();
            this.btnCalamandrei = new System.Windows.Forms.Button();
            this.matteocorsi = new System.Windows.Forms.Button();
            this.bttnMargheritaMugnai = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnScalaberni
            // 
            this.btnScalaberni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnScalaberni.Location = new System.Drawing.Point(12, 231);
            this.btnScalaberni.Name = "btnScalaberni";
            this.btnScalaberni.Size = new System.Drawing.Size(154, 23);
            this.btnScalaberni.TabIndex = 0;
            this.btnScalaberni.Text = "Scalaberni Giulia";
            this.btnScalaberni.UseVisualStyleBackColor = true;
            this.btnScalaberni.Click += new System.EventHandler(this.btnScalaberni_Click);
            // 
            // btnGabrieleStefani
            // 
            this.btnGabrieleStefani.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGabrieleStefani.Location = new System.Drawing.Point(12, 12);
            this.btnGabrieleStefani.Name = "btnGabrieleStefani";
            this.btnGabrieleStefani.Size = new System.Drawing.Size(106, 23);
            this.btnGabrieleStefani.TabIndex = 0;
            this.btnGabrieleStefani.Text = "Gabriele Stefani";
            this.btnGabrieleStefani.UseVisualStyleBackColor = true;
            this.btnGabrieleStefani.Click += new System.EventHandler(this.btnGabrieleStefani_Click);
            // 
            // btnMattiaRanfagni
            // 
            this.btnMattiaRanfagni.Location = new System.Drawing.Point(124, 12);
            this.btnMattiaRanfagni.Name = "btnMattiaRanfagni";
            this.btnMattiaRanfagni.Size = new System.Drawing.Size(109, 23);
            this.btnMattiaRanfagni.TabIndex = 1;
            this.btnMattiaRanfagni.Text = "Mattia Ranfagni";
            this.btnMattiaRanfagni.UseVisualStyleBackColor = true;
            this.btnMattiaRanfagni.Click += new System.EventHandler(this.btnMattiaRanfagni_Click);
            // 
            // btnCalamandrei
            // 
            this.btnCalamandrei.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalamandrei.Location = new System.Drawing.Point(12, 41);
            this.btnCalamandrei.Name = "btnCalamandrei";
            this.btnCalamandrei.Size = new System.Drawing.Size(114, 23);
            this.btnCalamandrei.TabIndex = 2;
            this.btnCalamandrei.Text = "Lorenzo Calamandrei";
            this.btnCalamandrei.UseVisualStyleBackColor = true;
            this.btnCalamandrei.Click += new System.EventHandler(this.btnBlogCalamandrei_Click);
            // 
            // matteocorsi
            // 
            this.matteocorsi.Location = new System.Drawing.Point(132, 41);
            this.matteocorsi.Name = "matteocorsi";
            this.matteocorsi.Size = new System.Drawing.Size(75, 23);
            this.matteocorsi.TabIndex = 3;
            this.matteocorsi.Text = "matteo corsi";
            this.matteocorsi.UseVisualStyleBackColor = true;
            this.matteocorsi.Click += new System.EventHandler(this.button1_Click);
            // 
            // bttnMargheritaMugnai
            // 
            this.bttnMargheritaMugnai.Location = new System.Drawing.Point(12, 70);
            this.bttnMargheritaMugnai.Name = "bttnMargheritaMugnai";
            this.bttnMargheritaMugnai.Size = new System.Drawing.Size(114, 23);
            this.bttnMargheritaMugnai.TabIndex = 4;
            this.bttnMargheritaMugnai.Text = "Margherita Mugnai";
            this.bttnMargheritaMugnai.UseVisualStyleBackColor = true;
            this.bttnMargheritaMugnai.Click += new System.EventHandler(this.bttnMargheritaMugnai_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.bttnMargheritaMugnai);
            this.Controls.Add(this.matteocorsi);
            this.Controls.Add(this.btnCalamandrei);
            this.Controls.Add(this.btnMattiaRanfagni);
            this.Controls.Add(this.btnScalaberni);
            this.Controls.Add(this.btnGabrieleStefani);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        
        private System.Windows.Forms.Button btnScalaberni;
        private System.Windows.Forms.Button btnGabrieleStefani;
        private System.Windows.Forms.Button btnMattiaRanfagni;
        private System.Windows.Forms.Button btnCalamandrei;
        private System.Windows.Forms.Button matteocorsi;
        private System.Windows.Forms.Button bttnMargheritaMugnai;
    }
}

