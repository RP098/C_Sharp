
namespace SiecNeuronowa
{
    partial class Zadanie_1_A_LosoweWartosci_Neurony
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Zadanie_1_A_LosoweWartosci_Neurony));
            this.label1 = new System.Windows.Forms.Label();
            this.struktura = new System.Windows.Forms.TextBox();
            this.generuj = new System.Windows.Forms.Button();
            this.zakresMax = new System.Windows.Forms.TextBox();
            this.ZakresMin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(34, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(773, 38);
            this.label1.TabIndex = 6;
            this.label1.Text = "              Uwaga Uwaga Separatorem Jest Myślnik \"-\" !!         ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // struktura
            // 
            this.struktura.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.struktura.Location = new System.Drawing.Point(41, 106);
            this.struktura.Multiline = true;
            this.struktura.Name = "struktura";
            this.struktura.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.struktura.Size = new System.Drawing.Size(750, 86);
            this.struktura.TabIndex = 5;
            this.struktura.TextChanged += new System.EventHandler(this.struktura_TextChanged);
            // 
            // generuj
            // 
            this.generuj.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.generuj.Location = new System.Drawing.Point(41, 258);
            this.generuj.Name = "generuj";
            this.generuj.Size = new System.Drawing.Size(750, 54);
            this.generuj.TabIndex = 4;
            this.generuj.Text = "Generuj Strukturę np. 3-2-2";
            this.generuj.UseVisualStyleBackColor = true;
            this.generuj.Click += new System.EventHandler(this.generuj_Click);
            // 
            // zakresMax
            // 
            this.zakresMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.zakresMax.Location = new System.Drawing.Point(280, 355);
            this.zakresMax.Multiline = true;
            this.zakresMax.Name = "zakresMax";
            this.zakresMax.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.zakresMax.Size = new System.Drawing.Size(113, 86);
            this.zakresMax.TabIndex = 7;
            this.zakresMax.TextChanged += new System.EventHandler(this.zakresMax_TextChanged);
            // 
            // ZakresMin
            // 
            this.ZakresMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.ZakresMin.Location = new System.Drawing.Point(678, 355);
            this.ZakresMin.Multiline = true;
            this.ZakresMin.Name = "ZakresMin";
            this.ZakresMin.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ZakresMin.Size = new System.Drawing.Size(113, 86);
            this.ZakresMin.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(51, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 38);
            this.label2.TabIndex = 9;
            this.label2.Text = "Zakres Max       ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(417, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 38);
            this.label3.TabIndex = 10;
            this.label3.Text = "Zakres Min       ";
            // 
            // Zadanie_1_A_LosoweWartosci_Neurony
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(868, 500);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ZakresMin);
            this.Controls.Add(this.zakresMax);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.struktura);
            this.Controls.Add(this.generuj);
            this.Name = "Zadanie_1_A_LosoweWartosci_Neurony";
            this.Text = "Zadanie_1_A_LosoweWartosci_Neurony";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox struktura;
        private System.Windows.Forms.Button generuj;
        private System.Windows.Forms.TextBox zakresMax;
        private System.Windows.Forms.TextBox ZakresMin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}