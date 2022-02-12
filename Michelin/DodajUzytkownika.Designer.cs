
namespace Michelin_Garda_2021
{
    partial class DodajUzytkownika
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DodajUzytkownika));
            this.dodaj = new System.Windows.Forms.Button();
            this.email = new System.Windows.Forms.TextBox();
            this.haslo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.asd = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dodaj
            // 
            this.dodaj.BackColor = System.Drawing.SystemColors.Menu;
            this.dodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dodaj.ForeColor = System.Drawing.Color.Black;
            this.dodaj.Location = new System.Drawing.Point(638, 385);
            this.dodaj.Name = "dodaj";
            this.dodaj.Size = new System.Drawing.Size(150, 53);
            this.dodaj.TabIndex = 0;
            this.dodaj.Text = "Dodaj";
            this.dodaj.UseVisualStyleBackColor = false;
            this.dodaj.Click += new System.EventHandler(this.dodaj_Click);
            // 
            // email
            // 
            this.email.BackColor = System.Drawing.Color.SeaGreen;
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.email.ForeColor = System.Drawing.SystemColors.Menu;
            this.email.Location = new System.Drawing.Point(405, 145);
            this.email.Multiline = true;
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(383, 93);
            this.email.TabIndex = 1;
            // 
            // haslo
            // 
            this.haslo.BackColor = System.Drawing.Color.SeaGreen;
            this.haslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.haslo.ForeColor = System.Drawing.SystemColors.Menu;
            this.haslo.Location = new System.Drawing.Point(405, 253);
            this.haslo.Multiline = true;
            this.haslo.Name = "haslo";
            this.haslo.Size = new System.Drawing.Size(383, 93);
            this.haslo.TabIndex = 2;
            this.haslo.TextChanged += new System.EventHandler(this.haslo_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(131, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Email Użytkownika";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(131, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hasło";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // asd
            // 
            this.asd.AutoSize = true;
            this.asd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.asd.Location = new System.Drawing.Point(131, 31);
            this.asd.Name = "asd";
            this.asd.Size = new System.Drawing.Size(260, 31);
            this.asd.TabIndex = 6;
            this.asd.Text = "Nazwa Użytkownika";
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.Color.SeaGreen;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.name.ForeColor = System.Drawing.SystemColors.Menu;
            this.name.Location = new System.Drawing.Point(405, 31);
            this.name.Multiline = true;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(383, 93);
            this.name.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Menu;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(137, 385);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 53);
            this.button1.TabIndex = 48;
            this.button1.Text = "Anuluj";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DodajUzytkownika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(807, 458);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.asd);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.haslo);
            this.Controls.Add(this.email);
            this.Controls.Add(this.dodaj);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DodajUzytkownika";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj Użytkownika";
            this.Load += new System.EventHandler(this.DodajUzytkownika_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dodaj;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox haslo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label asd;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Button button1;
    }
}