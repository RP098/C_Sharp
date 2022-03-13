
namespace SiecNeuronowa
{
    partial class ZapiszStrukture
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZapiszStrukture));
            this.label1 = new System.Windows.Forms.Label();
            this.nazwaStruktury = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(233, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 76);
            this.label1.TabIndex = 6;
            this.label1.Text = "Podaj Nazwę :)\r\nZ Rozszerzeniem";
            // 
            // nazwaStruktury
            // 
            this.nazwaStruktury.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nazwaStruktury.Location = new System.Drawing.Point(482, 203);
            this.nazwaStruktury.Multiline = true;
            this.nazwaStruktury.Name = "nazwaStruktury";
            this.nazwaStruktury.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.nazwaStruktury.Size = new System.Drawing.Size(290, 67);
            this.nazwaStruktury.TabIndex = 5;
            this.nazwaStruktury.TextChanged += new System.EventHandler(this.nazwaStruktury_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(226, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(546, 65);
            this.button1.TabIndex = 4;
            this.button1.Text = "Zapisz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ZapiszStrukture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1009, 626);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nazwaStruktury);
            this.Controls.Add(this.button1);
            this.Name = "ZapiszStrukture";
            this.Text = "ZapiszStrukture";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nazwaStruktury;
        private System.Windows.Forms.Button button1;
    }
}