
namespace SiecNeuronowa
{
    partial class Ucz
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ucz));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonUcz = new System.Windows.Forms.Button();
            this.Buttonzapisz = new System.Windows.Forms.Button();
            this.nazwaProbki = new System.Windows.Forms.TextBox();
            this.wagi = new System.Windows.Forms.TextBox();
            this.zasiegIteracji = new System.Windows.Forms.TextBox();
            this.zIluProbekBlad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.radioIteracja = new System.Windows.Forms.RadioButton();
            this.radioBlad = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.struktura = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.BladPodany = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeight = 50;
            this.dataGridView1.Location = new System.Drawing.Point(668, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(657, 684);
            this.dataGridView1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(663, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wynik Uczenia";
            // 
            // ButtonUcz
            // 
            this.ButtonUcz.Location = new System.Drawing.Point(31, 728);
            this.ButtonUcz.Name = "ButtonUcz";
            this.ButtonUcz.Size = new System.Drawing.Size(292, 53);
            this.ButtonUcz.TabIndex = 2;
            this.ButtonUcz.Text = "Ucz";
            this.ButtonUcz.UseVisualStyleBackColor = true;
            this.ButtonUcz.Click += new System.EventHandler(this.ButtonUcz_Click);
            // 
            // Buttonzapisz
            // 
            this.Buttonzapisz.Location = new System.Drawing.Point(329, 728);
            this.Buttonzapisz.Name = "Buttonzapisz";
            this.Buttonzapisz.Size = new System.Drawing.Size(292, 53);
            this.Buttonzapisz.TabIndex = 3;
            this.Buttonzapisz.Text = "Zapisz ";
            this.Buttonzapisz.UseVisualStyleBackColor = true;
            this.Buttonzapisz.Click += new System.EventHandler(this.Buttonzapisz_Click);
            // 
            // nazwaProbki
            // 
            this.nazwaProbki.Location = new System.Drawing.Point(329, 60);
            this.nazwaProbki.Multiline = true;
            this.nazwaProbki.Name = "nazwaProbki";
            this.nazwaProbki.Size = new System.Drawing.Size(292, 59);
            this.nazwaProbki.TabIndex = 4;
            // 
            // wagi
            // 
            this.wagi.Location = new System.Drawing.Point(329, 148);
            this.wagi.Multiline = true;
            this.wagi.Name = "wagi";
            this.wagi.Size = new System.Drawing.Size(292, 59);
            this.wagi.TabIndex = 5;
            // 
            // zasiegIteracji
            // 
            this.zasiegIteracji.Location = new System.Drawing.Point(329, 486);
            this.zasiegIteracji.Multiline = true;
            this.zasiegIteracji.Name = "zasiegIteracji";
            this.zasiegIteracji.Size = new System.Drawing.Size(292, 59);
            this.zasiegIteracji.TabIndex = 6;
            // 
            // zIluProbekBlad
            // 
            this.zIluProbekBlad.Location = new System.Drawing.Point(329, 569);
            this.zIluProbekBlad.Multiline = true;
            this.zIluProbekBlad.Name = "zIluProbekBlad";
            this.zIluProbekBlad.Size = new System.Drawing.Size(292, 59);
            this.zIluProbekBlad.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Próbka Ucząca";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Wagi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(324, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Nazwa Pliku";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(324, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Sposób działania";
            // 
            // radioIteracja
            // 
            this.radioIteracja.AutoSize = true;
            this.radioIteracja.Location = new System.Drawing.Point(329, 279);
            this.radioIteracja.Name = "radioIteracja";
            this.radioIteracja.Size = new System.Drawing.Size(100, 29);
            this.radioIteracja.TabIndex = 13;
            this.radioIteracja.TabStop = true;
            this.radioIteracja.Text = "Iteracja";
            this.radioIteracja.UseVisualStyleBackColor = true;
            // 
            // radioBlad
            // 
            this.radioBlad.AutoSize = true;
            this.radioBlad.Location = new System.Drawing.Point(329, 335);
            this.radioBlad.Name = "radioBlad";
            this.radioBlad.Size = new System.Drawing.Size(246, 29);
            this.radioBlad.TabIndex = 14;
            this.radioBlad.TabStop = true;
            this.radioBlad.Text = "Do Określonego Błędu";
            this.radioBlad.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 486);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "Zasięg Iteracji";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 572);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(243, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "Z Ilu Próbek Liczyć Błąd";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 399);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(214, 25);
            this.label8.TabIndex = 18;
            this.label8.Text = "Struktura  separator :";
            // 
            // struktura
            // 
            this.struktura.Location = new System.Drawing.Point(329, 399);
            this.struktura.Multiline = true;
            this.struktura.Name = "struktura";
            this.struktura.Size = new System.Drawing.Size(292, 59);
            this.struktura.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 651);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 25);
            this.label9.TabIndex = 20;
            this.label9.Text = "Podaj Błąd";
            // 
            // BladPodany
            // 
            this.BladPodany.Location = new System.Drawing.Point(329, 648);
            this.BladPodany.Multiline = true;
            this.BladPodany.Name = "BladPodany";
            this.BladPodany.Size = new System.Drawing.Size(292, 59);
            this.BladPodany.TabIndex = 19;
            // 
            // Ucz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1924, 812);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.BladPodany);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.struktura);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.radioBlad);
            this.Controls.Add(this.radioIteracja);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.zIluProbekBlad);
            this.Controls.Add(this.zasiegIteracji);
            this.Controls.Add(this.wagi);
            this.Controls.Add(this.nazwaProbki);
            this.Controls.Add(this.Buttonzapisz);
            this.Controls.Add(this.ButtonUcz);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Ucz";
            this.Text = "Z Ilu Próbek Liczyć Błąd";
            this.Load += new System.EventHandler(this.Ucz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonUcz;
        private System.Windows.Forms.Button Buttonzapisz;
        private System.Windows.Forms.TextBox nazwaProbki;
        private System.Windows.Forms.TextBox wagi;
        private System.Windows.Forms.TextBox zasiegIteracji;
        private System.Windows.Forms.TextBox zIluProbekBlad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioIteracja;
        private System.Windows.Forms.RadioButton radioBlad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox struktura;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox BladPodany;
    }
}