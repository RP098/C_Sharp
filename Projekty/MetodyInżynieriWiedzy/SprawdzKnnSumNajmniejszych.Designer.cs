
namespace MetodyInżynieriWiedzy
{
    partial class SprawdzKnnSumNajmniejszych
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SprawdzKnnSumNajmniejszych));
            this.separator = new System.Windows.Forms.TextBox();
            this.asda = new System.Windows.Forms.Label();
            this.decyzyjna = new System.Windows.Forms.TextBox();
            this.numerDecyzja = new System.Windows.Forms.Label();
            this.konfiguracyjny = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataTak = new System.Windows.Forms.RadioButton();
            this.dataNie = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.minkowskiego = new System.Windows.Forms.RadioButton();
            this.euklidesowa = new System.Windows.Forms.RadioButton();
            this.czybyszewa = new System.Windows.Forms.RadioButton();
            this.manhatan = new System.Windows.Forms.RadioButton();
            this.logarytmiczna = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.labelParM = new System.Windows.Forms.Label();
            this.parametrM = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.buttonKlasyfikuj = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // separator
            // 
            this.separator.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.separator.Location = new System.Drawing.Point(809, 658);
            this.separator.Multiline = true;
            this.separator.Name = "separator";
            this.separator.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.separator.Size = new System.Drawing.Size(277, 52);
            this.separator.TabIndex = 136;
            this.separator.Visible = false;
            // 
            // asda
            // 
            this.asda.AutoSize = true;
            this.asda.BackColor = System.Drawing.Color.White;
            this.asda.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.asda.Location = new System.Drawing.Point(53, 645);
            this.asda.Name = "asda";
            this.asda.Size = new System.Drawing.Size(146, 38);
            this.asda.TabIndex = 135;
            this.asda.Text = "Separator";
            this.asda.Visible = false;
            // 
            // decyzyjna
            // 
            this.decyzyjna.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.decyzyjna.Location = new System.Drawing.Point(809, 568);
            this.decyzyjna.Multiline = true;
            this.decyzyjna.Name = "decyzyjna";
            this.decyzyjna.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.decyzyjna.Size = new System.Drawing.Size(277, 52);
            this.decyzyjna.TabIndex = 134;
            this.decyzyjna.Visible = false;
            // 
            // numerDecyzja
            // 
            this.numerDecyzja.AutoSize = true;
            this.numerDecyzja.BackColor = System.Drawing.Color.White;
            this.numerDecyzja.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numerDecyzja.Location = new System.Drawing.Point(53, 555);
            this.numerDecyzja.Name = "numerDecyzja";
            this.numerDecyzja.Size = new System.Drawing.Size(356, 38);
            this.numerDecyzja.TabIndex = 133;
            this.numerDecyzja.Text = "Numer kolumny decyzyjnej";
            this.numerDecyzja.Visible = false;
            // 
            // konfiguracyjny
            // 
            this.konfiguracyjny.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.konfiguracyjny.Location = new System.Drawing.Point(869, 179);
            this.konfiguracyjny.Multiline = true;
            this.konfiguracyjny.Name = "konfiguracyjny";
            this.konfiguracyjny.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.konfiguracyjny.Size = new System.Drawing.Size(215, 56);
            this.konfiguracyjny.TabIndex = 132;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(43, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(331, 38);
            this.label5.TabIndex = 131;
            this.label5.Text = "Podaj plik konfiguracyjny";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox3.Controls.Add(this.dataTak);
            this.groupBox3.Controls.Add(this.dataNie);
            this.groupBox3.Location = new System.Drawing.Point(869, 251);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(217, 59);
            this.groupBox3.TabIndex = 130;
            this.groupBox3.TabStop = false;
            // 
            // dataTak
            // 
            this.dataTak.AutoSize = true;
            this.dataTak.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataTak.Font = new System.Drawing.Font("Comic Sans MS", 15.75F);
            this.dataTak.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataTak.Location = new System.Drawing.Point(9, 16);
            this.dataTak.Name = "dataTak";
            this.dataTak.Size = new System.Drawing.Size(68, 33);
            this.dataTak.TabIndex = 90;
            this.dataTak.TabStop = true;
            this.dataTak.Text = "Tak";
            this.dataTak.UseVisualStyleBackColor = false;
            this.dataTak.CheckedChanged += new System.EventHandler(this.dataTak_CheckedChanged);
            // 
            // dataNie
            // 
            this.dataNie.AutoSize = true;
            this.dataNie.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataNie.Font = new System.Drawing.Font("Comic Sans MS", 15.75F);
            this.dataNie.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataNie.Location = new System.Drawing.Point(118, 16);
            this.dataNie.Name = "dataNie";
            this.dataNie.Size = new System.Drawing.Size(65, 33);
            this.dataNie.TabIndex = 85;
            this.dataNie.TabStop = true;
            this.dataNie.Text = "Nie";
            this.dataNie.UseVisualStyleBackColor = false;
            this.dataNie.CheckedChanged += new System.EventHandler(this.dataNie_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox2.Controls.Add(this.minkowskiego);
            this.groupBox2.Controls.Add(this.euklidesowa);
            this.groupBox2.Controls.Add(this.czybyszewa);
            this.groupBox2.Controls.Add(this.manhatan);
            this.groupBox2.Controls.Add(this.logarytmiczna);
            this.groupBox2.Location = new System.Drawing.Point(460, 322);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(625, 118);
            this.groupBox2.TabIndex = 129;
            this.groupBox2.TabStop = false;
            // 
            // minkowskiego
            // 
            this.minkowskiego.AutoSize = true;
            this.minkowskiego.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.minkowskiego.Font = new System.Drawing.Font("Comic Sans MS", 15.75F);
            this.minkowskiego.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.minkowskiego.Location = new System.Drawing.Point(218, 71);
            this.minkowskiego.Name = "minkowskiego";
            this.minkowskiego.Size = new System.Drawing.Size(165, 33);
            this.minkowskiego.TabIndex = 79;
            this.minkowskiego.TabStop = true;
            this.minkowskiego.Text = "Minkowskiego";
            this.minkowskiego.UseVisualStyleBackColor = false;
            // 
            // euklidesowa
            // 
            this.euklidesowa.AutoSize = true;
            this.euklidesowa.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.euklidesowa.Font = new System.Drawing.Font("Comic Sans MS", 15.75F);
            this.euklidesowa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.euklidesowa.Location = new System.Drawing.Point(218, 19);
            this.euklidesowa.Name = "euklidesowa";
            this.euklidesowa.Size = new System.Drawing.Size(149, 33);
            this.euklidesowa.TabIndex = 78;
            this.euklidesowa.TabStop = true;
            this.euklidesowa.Text = "Euklidesowa";
            this.euklidesowa.UseVisualStyleBackColor = false;
            // 
            // czybyszewa
            // 
            this.czybyszewa.AutoSize = true;
            this.czybyszewa.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.czybyszewa.Font = new System.Drawing.Font("Comic Sans MS", 15.75F);
            this.czybyszewa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.czybyszewa.Location = new System.Drawing.Point(6, 71);
            this.czybyszewa.Name = "czybyszewa";
            this.czybyszewa.Size = new System.Drawing.Size(146, 33);
            this.czybyszewa.TabIndex = 77;
            this.czybyszewa.TabStop = true;
            this.czybyszewa.Text = "Czybyszewa";
            this.czybyszewa.UseVisualStyleBackColor = false;
            // 
            // manhatan
            // 
            this.manhatan.AutoSize = true;
            this.manhatan.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.manhatan.Font = new System.Drawing.Font("Comic Sans MS", 15.75F);
            this.manhatan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.manhatan.Location = new System.Drawing.Point(6, 19);
            this.manhatan.Name = "manhatan";
            this.manhatan.Size = new System.Drawing.Size(126, 33);
            this.manhatan.TabIndex = 76;
            this.manhatan.TabStop = true;
            this.manhatan.Text = "Manhatan";
            this.manhatan.UseVisualStyleBackColor = false;
            // 
            // logarytmiczna
            // 
            this.logarytmiczna.AutoSize = true;
            this.logarytmiczna.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.logarytmiczna.Font = new System.Drawing.Font("Comic Sans MS", 15.75F);
            this.logarytmiczna.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.logarytmiczna.Location = new System.Drawing.Point(442, 19);
            this.logarytmiczna.Name = "logarytmiczna";
            this.logarytmiczna.Size = new System.Drawing.Size(173, 33);
            this.logarytmiczna.TabIndex = 75;
            this.logarytmiczna.TabStop = true;
            this.logarytmiczna.Text = "Logarytmiczna";
            this.logarytmiczna.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(43, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(351, 38);
            this.label4.TabIndex = 128;
            this.label4.Text = "Data set znormalizowany ?";
            // 
            // labelParM
            // 
            this.labelParM.AutoSize = true;
            this.labelParM.BackColor = System.Drawing.Color.White;
            this.labelParM.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelParM.Location = new System.Drawing.Point(53, 452);
            this.labelParM.Name = "labelParM";
            this.labelParM.Size = new System.Drawing.Size(388, 38);
            this.labelParM.TabIndex = 127;
            this.labelParM.Text = "Parametr M dla Minkowskiego";
            // 
            // parametrM
            // 
            this.parametrM.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.parametrM.Location = new System.Drawing.Point(808, 475);
            this.parametrM.Multiline = true;
            this.parametrM.Name = "parametrM";
            this.parametrM.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.parametrM.Size = new System.Drawing.Size(277, 52);
            this.parametrM.TabIndex = 126;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.Location = new System.Drawing.Point(53, 333);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(240, 38);
            this.label13.TabIndex = 125;
            this.label13.Text = "Wybierz metrykę";
            // 
            // buttonKlasyfikuj
            // 
            this.buttonKlasyfikuj.BackColor = System.Drawing.Color.Cornsilk;
            this.buttonKlasyfikuj.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonKlasyfikuj.Location = new System.Drawing.Point(68, 718);
            this.buttonKlasyfikuj.Name = "buttonKlasyfikuj";
            this.buttonKlasyfikuj.Size = new System.Drawing.Size(1017, 56);
            this.buttonKlasyfikuj.TabIndex = 124;
            this.buttonKlasyfikuj.Text = "Klasyfikuj";
            this.buttonKlasyfikuj.UseVisualStyleBackColor = false;
            this.buttonKlasyfikuj.Click += new System.EventHandler(this.buttonKlasyfikuj_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(43, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 38);
            this.label2.TabIndex = 123;
            this.label2.Text = "Podaj parametr K";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(870, 30);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(215, 56);
            this.textBox1.TabIndex = 122;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(43, 121);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(333, 38);
            this.label12.TabIndex = 121;
            this.label12.Text = "Podaj nazwę bazy próbek";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox2.Location = new System.Drawing.Point(869, 103);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox2.Size = new System.Drawing.Size(215, 56);
            this.textBox2.TabIndex = 120;
            // 
            // SprawdzKnnSumNajmniejszych
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 783);
            this.Controls.Add(this.separator);
            this.Controls.Add(this.asda);
            this.Controls.Add(this.decyzyjna);
            this.Controls.Add(this.numerDecyzja);
            this.Controls.Add(this.konfiguracyjny);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelParM);
            this.Controls.Add(this.parametrM);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.buttonKlasyfikuj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SprawdzKnnSumNajmniejszych";
            this.Text = "SprawdzKnnSumNajmniejszych";
            this.Load += new System.EventHandler(this.SprawdzKnnSumNajmniejszych_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox separator;
        private System.Windows.Forms.Label asda;
        private System.Windows.Forms.TextBox decyzyjna;
        private System.Windows.Forms.Label numerDecyzja;
        private System.Windows.Forms.TextBox konfiguracyjny;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton dataTak;
        private System.Windows.Forms.RadioButton dataNie;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton minkowskiego;
        private System.Windows.Forms.RadioButton euklidesowa;
        private System.Windows.Forms.RadioButton czybyszewa;
        private System.Windows.Forms.RadioButton manhatan;
        private System.Windows.Forms.RadioButton logarytmiczna;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelParM;
        private System.Windows.Forms.TextBox parametrM;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button buttonKlasyfikuj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox2;
    }
}