
namespace Michelin_Garda_2021
{
    partial class PotwierdzenieKlikniecia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PotwierdzenieKlikniecia));
            this.nie = new System.Windows.Forms.Button();
            this.tak = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nie
            // 
            this.nie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nie.ForeColor = System.Drawing.SystemColors.InfoText;
            this.nie.Location = new System.Drawing.Point(319, 128);
            this.nie.Name = "nie";
            this.nie.Size = new System.Drawing.Size(142, 54);
            this.nie.TabIndex = 0;
            this.nie.Text = "Nie";
            this.nie.UseVisualStyleBackColor = true;
            this.nie.Click += new System.EventHandler(this.nie_Click);
            // 
            // tak
            // 
            this.tak.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tak.ForeColor = System.Drawing.SystemColors.InfoText;
            this.tak.Location = new System.Drawing.Point(159, 128);
            this.tak.Name = "tak";
            this.tak.Size = new System.Drawing.Size(142, 54);
            this.tak.TabIndex = 1;
            this.tak.Text = "Tak";
            this.tak.UseVisualStyleBackColor = true;
            this.tak.Click += new System.EventHandler(this.tak_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(51, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(537, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "\"Czy chcesz usunąć wyświetlone dane???\"";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // PotwierdzenieKlikniecia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(633, 241);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tak);
            this.Controls.Add(this.nie);
            this.ForeColor = System.Drawing.SystemColors.Menu;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PotwierdzenieKlikniecia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PotwierdzenieKlikniecia";
            this.Load += new System.EventHandler(this.PotwierdzenieKlikniecia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button nie;
        private System.Windows.Forms.Button tak;
        private System.Windows.Forms.Label label1;
    }
}