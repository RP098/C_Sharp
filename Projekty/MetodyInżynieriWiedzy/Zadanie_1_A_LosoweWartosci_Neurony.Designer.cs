
namespace MetodyInżynieriWiedzy
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Zadanie_1_A_LosoweWartosci_Neurony));
            this.generuj = new System.Windows.Forms.Button();
            this.struktura = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // generuj
            // 
            this.generuj.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.generuj.Location = new System.Drawing.Point(23, 277);
            this.generuj.Name = "generuj";
            this.generuj.Size = new System.Drawing.Size(750, 54);
            this.generuj.TabIndex = 0;
            this.generuj.Text = "Generuj Strukturę np. 3-2-2";
            this.generuj.UseVisualStyleBackColor = true;
            this.generuj.Click += new System.EventHandler(this.generuj_Click);
            // 
            // struktura
            // 
            this.struktura.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.struktura.Location = new System.Drawing.Point(23, 150);
            this.struktura.Multiline = true;
            this.struktura.Name = "struktura";
            this.struktura.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.struktura.Size = new System.Drawing.Size(750, 86);
            this.struktura.TabIndex = 1;
            this.struktura.TextChanged += new System.EventHandler(this.struktura_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(16, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(773, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "              Uwaga Uwaga Separatorem Jest Myślnik \"-\" !!         ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Zadanie_1_A_LosoweWartosci_Neurony
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(866, 635);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.struktura);
            this.Controls.Add(this.generuj);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "Zadanie_1_A_LosoweWartosci_Neurony";
            this.Text = "Zadanie_1_A_LosoweWartosci_Neurony";
            this.Load += new System.EventHandler(this.Zadanie_1_A_LosoweWartosci_Neurony_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button generuj;
        private System.Windows.Forms.TextBox struktura;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
    }
}