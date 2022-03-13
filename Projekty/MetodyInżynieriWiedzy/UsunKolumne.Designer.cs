
namespace MetodyInżynieriWiedzy
{
    partial class UsunKolumne
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsunKolumne));
            this.label7 = new System.Windows.Forms.Label();
            this.dlugoscPliku = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.separator = new System.Windows.Forms.TextBox();
            this.nazwa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numerKolumny = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(55, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(412, 38);
            this.label7.TabIndex = 28;
            this.label7.Text = "Podaj  ilość wierszy z data setu";
            // 
            // dlugoscPliku
            // 
            this.dlugoscPliku.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dlugoscPliku.Location = new System.Drawing.Point(593, 292);
            this.dlugoscPliku.Multiline = true;
            this.dlugoscPliku.Name = "dlugoscPliku";
            this.dlugoscPliku.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.dlugoscPliku.Size = new System.Drawing.Size(215, 56);
            this.dlugoscPliku.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(55, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 38);
            this.label2.TabIndex = 19;
            this.label2.Text = "Podaj  separator ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(55, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(439, 38);
            this.label1.TabIndex = 18;
            this.label1.Text = "Podaj nazwę z rozszeżeniem pliku";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Cornsilk;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(55, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(753, 56);
            this.button1.TabIndex = 17;
            this.button1.Text = "Usuń";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // separator
            // 
            this.separator.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.separator.Location = new System.Drawing.Point(593, 132);
            this.separator.Multiline = true;
            this.separator.Name = "separator";
            this.separator.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.separator.Size = new System.Drawing.Size(215, 56);
            this.separator.TabIndex = 16;
            // 
            // nazwa
            // 
            this.nazwa.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nazwa.Location = new System.Drawing.Point(593, 49);
            this.nazwa.Multiline = true;
            this.nazwa.Name = "nazwa";
            this.nazwa.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.nazwa.Size = new System.Drawing.Size(215, 56);
            this.nazwa.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(55, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(367, 38);
            this.label3.TabIndex = 30;
            this.label3.Text = "Numer kolumny do usunięcia";
            // 
            // numerKolumny
            // 
            this.numerKolumny.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numerKolumny.Location = new System.Drawing.Point(593, 212);
            this.numerKolumny.Multiline = true;
            this.numerKolumny.Name = "numerKolumny";
            this.numerKolumny.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.numerKolumny.Size = new System.Drawing.Size(215, 56);
            this.numerKolumny.TabIndex = 29;
            // 
            // UsunKolumne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(863, 471);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numerKolumny);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dlugoscPliku);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.separator);
            this.Controls.Add(this.nazwa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UsunKolumne";
            this.Text = "UsunKolumne";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox dlugoscPliku;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox separator;
        private System.Windows.Forms.TextBox nazwa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox numerKolumny;
    }
}