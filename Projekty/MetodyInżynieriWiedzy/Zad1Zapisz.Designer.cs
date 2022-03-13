
namespace MetodyInżynieriWiedzy
{
    partial class Zad1Zapisz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Zad1Zapisz));
            this.zapiszWariant1 = new System.Windows.Forms.Button();
            this.zapiszWariant2 = new System.Windows.Forms.Button();
            this.zapiszWariant3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // zapiszWariant1
            // 
            this.zapiszWariant1.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zapiszWariant1.Location = new System.Drawing.Point(141, 98);
            this.zapiszWariant1.Name = "zapiszWariant1";
            this.zapiszWariant1.Size = new System.Drawing.Size(519, 60);
            this.zapiszWariant1.TabIndex = 0;
            this.zapiszWariant1.Text = "Zapisz Wariant I";
            this.zapiszWariant1.UseVisualStyleBackColor = true;
            this.zapiszWariant1.Click += new System.EventHandler(this.zapiszWariant1_Click);
            // 
            // zapiszWariant2
            // 
            this.zapiszWariant2.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zapiszWariant2.Location = new System.Drawing.Point(141, 195);
            this.zapiszWariant2.Name = "zapiszWariant2";
            this.zapiszWariant2.Size = new System.Drawing.Size(519, 60);
            this.zapiszWariant2.TabIndex = 1;
            this.zapiszWariant2.Text = "Zapisz Wariant II";
            this.zapiszWariant2.UseVisualStyleBackColor = true;
            this.zapiszWariant2.Click += new System.EventHandler(this.zapiszWariant2_Click);
            // 
            // zapiszWariant3
            // 
            this.zapiszWariant3.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zapiszWariant3.Location = new System.Drawing.Point(141, 299);
            this.zapiszWariant3.Name = "zapiszWariant3";
            this.zapiszWariant3.Size = new System.Drawing.Size(519, 60);
            this.zapiszWariant3.TabIndex = 2;
            this.zapiszWariant3.Text = "Zapisz Wariant III";
            this.zapiszWariant3.UseVisualStyleBackColor = true;
            this.zapiszWariant3.Click += new System.EventHandler(this.zapiszWariant3_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(141, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(519, 60);
            this.button1.TabIndex = 3;
            this.button1.Text = "Pokaż Katalog";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Zad1Zapisz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(851, 602);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.zapiszWariant3);
            this.Controls.Add(this.zapiszWariant2);
            this.Controls.Add(this.zapiszWariant1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Zad1Zapisz";
            this.Text = "Zad1Zapisz";
            this.Load += new System.EventHandler(this.Zad1Zapisz_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button zapiszWariant1;
        private System.Windows.Forms.Button zapiszWariant2;
        private System.Windows.Forms.Button zapiszWariant3;
        private System.Windows.Forms.Button button1;
    }
}