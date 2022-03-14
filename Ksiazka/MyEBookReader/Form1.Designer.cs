
namespace MyEBookReader
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
            this.textBoxOknoGlowne = new System.Windows.Forms.TextBox();
            this.buttonDownload = new System.Windows.Forms.Button();
            this.buttonGetStats = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxOknoGlowne
            // 
            this.textBoxOknoGlowne.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxOknoGlowne.Location = new System.Drawing.Point(12, 12);
            this.textBoxOknoGlowne.Multiline = true;
            this.textBoxOknoGlowne.Name = "textBoxOknoGlowne";
            this.textBoxOknoGlowne.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOknoGlowne.Size = new System.Drawing.Size(776, 315);
            this.textBoxOknoGlowne.TabIndex = 0;
            // 
            // buttonDownload
            // 
            this.buttonDownload.Location = new System.Drawing.Point(668, 353);
            this.buttonDownload.Name = "buttonDownload";
            this.buttonDownload.Size = new System.Drawing.Size(120, 35);
            this.buttonDownload.TabIndex = 1;
            this.buttonDownload.Text = "Button Download";
            this.buttonDownload.UseVisualStyleBackColor = true;
            this.buttonDownload.Click += new System.EventHandler(this.buttonDownload_Click);
            // 
            // buttonGetStats
            // 
            this.buttonGetStats.Location = new System.Drawing.Point(542, 353);
            this.buttonGetStats.Name = "buttonGetStats";
            this.buttonGetStats.Size = new System.Drawing.Size(120, 35);
            this.buttonGetStats.TabIndex = 2;
            this.buttonGetStats.Text = "Button Get Stats";
            this.buttonGetStats.UseVisualStyleBackColor = true;
            this.buttonGetStats.Click += new System.EventHandler(this.buttonGetStats_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(416, 353);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(120, 35);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Cancel Search Stats";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonGetStats);
            this.Controls.Add(this.buttonDownload);
            this.Controls.Add(this.textBoxOknoGlowne);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxOknoGlowne;
        private System.Windows.Forms.Button buttonDownload;
        private System.Windows.Forms.Button buttonGetStats;
        private System.Windows.Forms.Button buttonCancel;
    }
}

