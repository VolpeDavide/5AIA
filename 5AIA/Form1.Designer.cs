﻿namespace _5AIA
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
            this.btnGabrieleStefani = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGabrieleStefani
            // 
            this.btnGabrieleStefani.Location = new System.Drawing.Point(12, 12);
            this.btnGabrieleStefani.Name = "btnGabrieleStefani";
            this.btnGabrieleStefani.Size = new System.Drawing.Size(90, 23);
            this.btnGabrieleStefani.TabIndex = 0;
            this.btnGabrieleStefani.Text = "Gabriele Stefani";
            this.btnGabrieleStefani.UseVisualStyleBackColor = true;
            this.btnGabrieleStefani.Click += new System.EventHandler(this.btnGabrieleStefani_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnGabrieleStefani);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGabrieleStefani;
    }
}
