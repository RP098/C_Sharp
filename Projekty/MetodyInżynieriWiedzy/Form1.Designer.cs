
namespace MetodyInżynieriWiedzy
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
            this.Zad1Normalizuj = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Generuj = new System.Windows.Forms.Button();
            this.odczytaj = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.KnnPojObiekt = new System.Windows.Forms.Button();
            this.KnnBazaProbek = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Zad1Normalizuj
            // 
            this.Zad1Normalizuj.BackColor = System.Drawing.SystemColors.Control;
            this.Zad1Normalizuj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Zad1Normalizuj.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Zad1Normalizuj.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Zad1Normalizuj.Location = new System.Drawing.Point(25, 65);
            this.Zad1Normalizuj.Name = "Zad1Normalizuj";
            this.Zad1Normalizuj.Size = new System.Drawing.Size(215, 92);
            this.Zad1Normalizuj.TabIndex = 0;
            this.Zad1Normalizuj.Text = "Normalizuj Plik";
            this.Zad1Normalizuj.UseVisualStyleBackColor = false;
            this.Zad1Normalizuj.Click += new System.EventHandler(this.Zad1Normalizuj_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button1.Location = new System.Drawing.Point(256, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 92);
            this.button1.TabIndex = 1;
            this.button1.Text = "Walidator";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(25, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(447, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "              Zadanie 1           ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(478, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(444, 38);
            this.label2.TabIndex = 3;
            this.label2.Text = "       Zadanie 1 Struktura      ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Generuj
            // 
            this.Generuj.BackColor = System.Drawing.SystemColors.Control;
            this.Generuj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Generuj.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Generuj.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Generuj.Location = new System.Drawing.Point(477, 65);
            this.Generuj.Name = "Generuj";
            this.Generuj.Size = new System.Drawing.Size(215, 92);
            this.Generuj.TabIndex = 4;
            this.Generuj.Text = "Generuj i Zapisz";
            this.Generuj.UseVisualStyleBackColor = false;
            this.Generuj.Click += new System.EventHandler(this.Generuj_Click);
            // 
            // odczytaj
            // 
            this.odczytaj.BackColor = System.Drawing.SystemColors.Control;
            this.odczytaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.odczytaj.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.odczytaj.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.odczytaj.Location = new System.Drawing.Point(707, 65);
            this.odczytaj.Name = "odczytaj";
            this.odczytaj.Size = new System.Drawing.Size(215, 92);
            this.odczytaj.TabIndex = 5;
            this.odczytaj.Text = "Odczytaj Strukture";
            this.odczytaj.UseVisualStyleBackColor = false;
            this.odczytaj.Click += new System.EventHandler(this.odczytaj_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(25, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(444, 38);
            this.label3.TabIndex = 6;
            this.label3.Text = "            Zadanie 2 Knn        ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(478, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(444, 38);
            this.label4.TabIndex = 7;
            this.label4.Text = "  Zadanie 2  Testowanie Knn    ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // KnnPojObiekt
            // 
            this.KnnPojObiekt.BackColor = System.Drawing.SystemColors.Control;
            this.KnnPojObiekt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KnnPojObiekt.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.KnnPojObiekt.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.KnnPojObiekt.Location = new System.Drawing.Point(25, 232);
            this.KnnPojObiekt.Name = "KnnPojObiekt";
            this.KnnPojObiekt.Size = new System.Drawing.Size(446, 81);
            this.KnnPojObiekt.TabIndex = 8;
            this.KnnPojObiekt.Text = "Knn Dla Pojedyńczego Obiektu";
            this.KnnPojObiekt.UseVisualStyleBackColor = false;
            this.KnnPojObiekt.Click += new System.EventHandler(this.KnnPojObiekt_Click);
            // 
            // KnnBazaProbek
            // 
            this.KnnBazaProbek.BackColor = System.Drawing.SystemColors.Control;
            this.KnnBazaProbek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KnnBazaProbek.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.KnnBazaProbek.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.KnnBazaProbek.Location = new System.Drawing.Point(476, 232);
            this.KnnBazaProbek.Name = "KnnBazaProbek";
            this.KnnBazaProbek.Size = new System.Drawing.Size(446, 81);
            this.KnnBazaProbek.TabIndex = 9;
            this.KnnBazaProbek.Text = "Knn Dla Bazy Próbek";
            this.KnnBazaProbek.UseVisualStyleBackColor = false;
            this.KnnBazaProbek.Click += new System.EventHandler(this.KnnBazaProbek_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button2.Location = new System.Drawing.Point(476, 389);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(446, 81);
            this.button2.TabIndex = 10;
            this.button2.Text = "Twórz plik konfiguracyjny";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(479, 333);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(438, 38);
            this.label5.TabIndex = 11;
            this.label5.Text = "        Zadanie Dodatkowe      ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(25, 333);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(440, 38);
            this.label6.TabIndex = 13;
            this.label6.Text = "          Katalog Plików          ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Control;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button4.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button4.Location = new System.Drawing.Point(23, 389);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(446, 81);
            this.button4.TabIndex = 14;
            this.button4.Text = "Pokaż Katalog";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button3.Location = new System.Drawing.Point(25, 486);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(897, 54);
            this.button3.TabIndex = 15;
            this.button3.Text = "Usuń Wybraną Kolumnę";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(943, 573);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.KnnBazaProbek);
            this.Controls.Add(this.KnnPojObiekt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.odczytaj);
            this.Controls.Add(this.Generuj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Zad1Normalizuj);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "MetodyInżynieriWiedzy";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Zad1Normalizuj;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Generuj;
        private System.Windows.Forms.Button odczytaj;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button KnnPojObiekt;
        private System.Windows.Forms.Button KnnBazaProbek;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
    }
}

