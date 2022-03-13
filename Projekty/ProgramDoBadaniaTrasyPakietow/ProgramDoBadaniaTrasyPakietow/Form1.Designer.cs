
namespace ProgramDoBadaniaTrasyPakietow
{
    partial class oknoGlowne
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(oknoGlowne));
            this.ipPodane = new System.Windows.Forms.TextBox();
            this.sledzTrase = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.zamknij = new System.Windows.Forms.Button();
            this.ttl = new System.Windows.Forms.NumericUpDown();
            this.czasOczekiwania = new System.Windows.Forms.NumericUpDown();
            this.wynik = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rozmiarBuforu = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.minimalizuj = new System.Windows.Forms.Button();
            this.wyczysc = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.ttl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.czasOczekiwania)).BeginInit();
            this.SuspendLayout();
            // 
            // ipPodane
            // 
            this.ipPodane.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ipPodane.Location = new System.Drawing.Point(290, 84);
            this.ipPodane.Multiline = true;
            this.ipPodane.Name = "ipPodane";
            this.ipPodane.Size = new System.Drawing.Size(341, 41);
            this.ipPodane.TabIndex = 0;
            // 
            // sledzTrase
            // 
            this.sledzTrase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.sledzTrase.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sledzTrase.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.sledzTrase.Location = new System.Drawing.Point(716, 84);
            this.sledzTrase.Name = "sledzTrase";
            this.sledzTrase.Size = new System.Drawing.Size(200, 62);
            this.sledzTrase.TabIndex = 1;
            this.sledzTrase.Text = "Śledź trasę";
            this.sledzTrase.UseVisualStyleBackColor = false;
            this.sledzTrase.Click += new System.EventHandler(this.sledzTrase_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Wynik śledzenia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "Podaj adres pakietu";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // zamknij
            // 
            this.zamknij.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.zamknij.Cursor = System.Windows.Forms.Cursors.Default;
            this.zamknij.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.zamknij.Font = new System.Drawing.Font("Segoe UI Historic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zamknij.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.zamknij.Location = new System.Drawing.Point(945, 12);
            this.zamknij.Name = "zamknij";
            this.zamknij.Size = new System.Drawing.Size(58, 54);
            this.zamknij.TabIndex = 6;
            this.zamknij.Text = "X";
            this.zamknij.UseVisualStyleBackColor = false;
            this.zamknij.Click += new System.EventHandler(this.zamknij_Click);
            // 
            // ttl
            // 
            this.ttl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ttl.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ttl.Location = new System.Drawing.Point(290, 142);
            this.ttl.Name = "ttl";
            this.ttl.Size = new System.Drawing.Size(341, 31);
            this.ttl.TabIndex = 7;
            // 
            // czasOczekiwania
            // 
            this.czasOczekiwania.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.czasOczekiwania.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.czasOczekiwania.Location = new System.Drawing.Point(290, 192);
            this.czasOczekiwania.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.czasOczekiwania.Name = "czasOczekiwania";
            this.czasOczekiwania.Size = new System.Drawing.Size(341, 31);
            this.czasOczekiwania.TabIndex = 8;
            this.czasOczekiwania.ValueChanged += new System.EventHandler(this.czasOczekiwania_ValueChanged);
            // 
            // wynik
            // 
            this.wynik.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.wynik.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wynik.Location = new System.Drawing.Point(12, 345);
            this.wynik.Multiline = true;
            this.wynik.Name = "wynik";
            this.wynik.ReadOnly = true;
            this.wynik.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.wynik.Size = new System.Drawing.Size(619, 295);
            this.wynik.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(12, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(252, 31);
            this.label3.TabIndex = 10;
            this.label3.Text = "Czas życia max TTL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(12, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(266, 31);
            this.label4.TabIndex = 11;
            this.label4.Text = "Czas Oczekiwania ms";
            // 
            // rozmiarBuforu
            // 
            this.rozmiarBuforu.Cursor = System.Windows.Forms.Cursors.Default;
            this.rozmiarBuforu.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rozmiarBuforu.FormattingEnabled = true;
            this.rozmiarBuforu.Items.AddRange(new object[] {
            "32",
            "64",
            "128"});
            this.rozmiarBuforu.Location = new System.Drawing.Point(290, 245);
            this.rozmiarBuforu.Name = "rozmiarBuforu";
            this.rozmiarBuforu.Size = new System.Drawing.Size(341, 35);
            this.rozmiarBuforu.TabIndex = 12;
            this.rozmiarBuforu.Text = "32";
            this.rozmiarBuforu.SelectedIndexChanged += new System.EventHandler(this.rozmiarBuforu_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(12, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(209, 31);
            this.label5.TabIndex = 13;
            this.label5.Text = "Wielkość buforu";
            // 
            // minimalizuj
            // 
            this.minimalizuj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.minimalizuj.Cursor = System.Windows.Forms.Cursors.Default;
            this.minimalizuj.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.minimalizuj.Font = new System.Drawing.Font("Showcard Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimalizuj.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.minimalizuj.Location = new System.Drawing.Point(881, 12);
            this.minimalizuj.Name = "minimalizuj";
            this.minimalizuj.Size = new System.Drawing.Size(58, 54);
            this.minimalizuj.TabIndex = 14;
            this.minimalizuj.Text = "-";
            this.minimalizuj.UseVisualStyleBackColor = false;
            this.minimalizuj.Click += new System.EventHandler(this.minimalizuj_Click);
            // 
            // wyczysc
            // 
            this.wyczysc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.wyczysc.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wyczysc.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.wyczysc.Location = new System.Drawing.Point(716, 152);
            this.wyczysc.Name = "wyczysc";
            this.wyczysc.Size = new System.Drawing.Size(200, 62);
            this.wyczysc.TabIndex = 16;
            this.wyczysc.Text = "Wyczyść";
            this.wyczysc.UseVisualStyleBackColor = false;
            this.wyczysc.Click += new System.EventHandler(this.wyczysc_Click_1);
            // 
            // oknoGlowne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1015, 652);
            this.ControlBox = false;
            this.Controls.Add(this.wyczysc);
            this.Controls.Add(this.minimalizuj);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rozmiarBuforu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.wynik);
            this.Controls.Add(this.czasOczekiwania);
            this.Controls.Add(this.ttl);
            this.Controls.Add(this.zamknij);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sledzTrase);
            this.Controls.Add(this.ipPodane);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "oknoGlowne";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AplikacjaInżynierskaAdamGórski";
            ((System.ComponentModel.ISupportInitialize)(this.ttl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.czasOczekiwania)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ipPodane;
        private System.Windows.Forms.Button sledzTrase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button zamknij;
        private System.Windows.Forms.NumericUpDown ttl;
        private System.Windows.Forms.NumericUpDown czasOczekiwania;
        private System.Windows.Forms.TextBox wynik;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox rozmiarBuforu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button minimalizuj;
        private System.Windows.Forms.Button wyczysc;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

