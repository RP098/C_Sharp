
namespace ProgramDoBadaniaTrasyPakietow
{
    partial class PotwierdzenieZamkniecia
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
            this.label2 = new System.Windows.Forms.Label();
            this.tak = new System.Windows.Forms.Button();
            this.nie = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(62, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(376, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "Czy chcesz zamknąć aplikację?";
            // 
            // tak
            // 
            this.tak.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.tak.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tak.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tak.Location = new System.Drawing.Point(296, 121);
            this.tak.Name = "tak";
            this.tak.Size = new System.Drawing.Size(142, 62);
            this.tak.TabIndex = 7;
            this.tak.Text = "Tak";
            this.tak.UseVisualStyleBackColor = false;
            this.tak.Click += new System.EventHandler(this.tak_Click);
            // 
            // nie
            // 
            this.nie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.nie.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nie.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.nie.Location = new System.Drawing.Point(68, 121);
            this.nie.Name = "nie";
            this.nie.Size = new System.Drawing.Size(142, 62);
            this.nie.TabIndex = 8;
            this.nie.Text = "Nie";
            this.nie.UseVisualStyleBackColor = false;
            this.nie.Click += new System.EventHandler(this.nie_Click);
            // 
            // PotwierdzenieZamkniecia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(517, 224);
            this.ControlBox = false;
            this.Controls.Add(this.nie);
            this.Controls.Add(this.tak);
            this.Controls.Add(this.label2);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "PotwierdzenieZamkniecia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.PotwierdzenieZamkniecia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button tak;
        private System.Windows.Forms.Button nie;
    }
}