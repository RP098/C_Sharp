﻿
namespace SiecNeuronowa
{
    partial class OdczytajStrukture
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OdczytajStrukture));
            this.label1 = new System.Windows.Forms.Label();
            this.odczytaj = new System.Windows.Forms.Button();
            this.NazwaStruktury = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(150, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 38);
            this.label1.TabIndex = 5;
            this.label1.Text = "Podaj Nazwę :)";
            // 
            // odczytaj
            // 
            this.odczytaj.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.odczytaj.Location = new System.Drawing.Point(148, 207);
            this.odczytaj.Name = "odczytaj";
            this.odczytaj.Size = new System.Drawing.Size(464, 59);
            this.odczytaj.TabIndex = 4;
            this.odczytaj.Text = "Odczytaj";
            this.odczytaj.UseVisualStyleBackColor = true;
            this.odczytaj.Click += new System.EventHandler(this.odczytaj_Click);
            // 
            // NazwaStruktury
            // 
            this.NazwaStruktury.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NazwaStruktury.Location = new System.Drawing.Point(386, 103);
            this.NazwaStruktury.Multiline = true;
            this.NazwaStruktury.Name = "NazwaStruktury";
            this.NazwaStruktury.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.NazwaStruktury.Size = new System.Drawing.Size(226, 58);
            this.NazwaStruktury.TabIndex = 3;
            this.NazwaStruktury.TextChanged += new System.EventHandler(this.NazwaStruktury_TextChanged);
            // 
            // OdczytajStrukture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.odczytaj);
            this.Controls.Add(this.NazwaStruktury);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "OdczytajStrukture";
            this.Text = "OdczytajStrukture";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button odczytaj;
        private System.Windows.Forms.TextBox NazwaStruktury;
    }
}