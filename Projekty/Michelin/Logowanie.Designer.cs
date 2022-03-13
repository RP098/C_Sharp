
namespace Michelin_Garda_2021
{
    partial class Logowanie
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Logowanie));
            this.haslo = new System.Windows.Forms.TextBox();
            this.loginBut = new System.Windows.Forms.TextBox();
            this.dodaj = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // haslo
            // 
            this.haslo.BackColor = System.Drawing.SystemColors.Menu;
            this.haslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.haslo.ForeColor = System.Drawing.Color.Black;
            this.haslo.Location = new System.Drawing.Point(201, 209);
            this.haslo.MaximumSize = new System.Drawing.Size(600, 110);
            this.haslo.Multiline = true;
            this.haslo.Name = "haslo";
            this.haslo.Size = new System.Drawing.Size(413, 54);
            this.haslo.TabIndex = 5;
            // 
            // loginBut
            // 
            this.loginBut.BackColor = System.Drawing.SystemColors.Menu;
            this.loginBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loginBut.ForeColor = System.Drawing.Color.Black;
            this.loginBut.Location = new System.Drawing.Point(201, 113);
            this.loginBut.MaximumSize = new System.Drawing.Size(600, 110);
            this.loginBut.Multiline = true;
            this.loginBut.Name = "loginBut";
            this.loginBut.Size = new System.Drawing.Size(413, 54);
            this.loginBut.TabIndex = 4;
            // 
            // dodaj
            // 
            this.dodaj.BackColor = System.Drawing.SystemColors.Menu;
            this.dodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dodaj.ForeColor = System.Drawing.Color.Black;
            this.dodaj.Location = new System.Drawing.Point(464, 291);
            this.dodaj.Name = "dodaj";
            this.dodaj.Size = new System.Drawing.Size(150, 53);
            this.dodaj.TabIndex = 3;
            this.dodaj.Text = "Zaloguj";
            this.dodaj.UseVisualStyleBackColor = false;
            this.dodaj.Click += new System.EventHandler(this.dodaj_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePicker1.Location = new System.Drawing.Point(165, 31);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(474, 40);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // Logowanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.haslo);
            this.Controls.Add(this.loginBut);
            this.Controls.Add(this.dodaj);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Logowanie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logowanie";
            this.Load += new System.EventHandler(this.Logowanie_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox haslo;
        private System.Windows.Forms.TextBox loginBut;
        private System.Windows.Forms.Button dodaj;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

