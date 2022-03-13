
namespace SiecNeuronowa
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
            this.odczytaj = new System.Windows.Forms.Button();
            this.Generuj = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // odczytaj
            // 
            this.odczytaj.BackColor = System.Drawing.SystemColors.Control;
            this.odczytaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.odczytaj.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.odczytaj.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.odczytaj.Location = new System.Drawing.Point(345, 87);
            this.odczytaj.Name = "odczytaj";
            this.odczytaj.Size = new System.Drawing.Size(294, 92);
            this.odczytaj.TabIndex = 8;
            this.odczytaj.Text = "Odczytaj Strukture";
            this.odczytaj.UseVisualStyleBackColor = false;
            this.odczytaj.Click += new System.EventHandler(this.odczytaj_Click);
            // 
            // Generuj
            // 
            this.Generuj.BackColor = System.Drawing.SystemColors.Control;
            this.Generuj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Generuj.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Generuj.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Generuj.Location = new System.Drawing.Point(45, 87);
            this.Generuj.Name = "Generuj";
            this.Generuj.Size = new System.Drawing.Size(294, 92);
            this.Generuj.TabIndex = 7;
            this.Generuj.Text = "Generuj i Zapisz";
            this.Generuj.UseVisualStyleBackColor = false;
            this.Generuj.Click += new System.EventHandler(this.Generuj_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(46, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(593, 38);
            this.label2.TabIndex = 6;
            this.label2.Text = "       Funkcjonalność Zadania numer 1      ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button1.Location = new System.Drawing.Point(342, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(294, 92);
            this.button1.TabIndex = 11;
            this.button1.Text = "Zadaj Pytanie ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button2.Location = new System.Drawing.Point(42, 251);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(294, 92);
            this.button2.TabIndex = 10;
            this.button2.Text = "Ucz ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(43, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(596, 38);
            this.label1.TabIndex = 9;
            this.label1.Text = "              Sieć Neuronowa                 ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(706, 502);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.odczytaj);
            this.Controls.Add(this.Generuj);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Sieć Neuronowa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button odczytaj;
        private System.Windows.Forms.Button Generuj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
    }
}

