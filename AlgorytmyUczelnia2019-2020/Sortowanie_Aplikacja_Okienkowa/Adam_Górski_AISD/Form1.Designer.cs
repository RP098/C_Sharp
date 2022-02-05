namespace Adam_Górski_AISD
{
    partial class Form1
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
            this.bombelkowe = new System.Windows.Forms.Button();
            this.przez_wybor = new System.Windows.Forms.Button();
            this.przez_wstawianie = new System.Windows.Forms.Button();
            this.przez_zliczanie = new System.Windows.Forms.Button();
            this.dane = new System.Windows.Forms.TextBox();
            this.merge_sort = new System.Windows.Forms.Button();
            this.ciagFib = new System.Windows.Forms.Button();
            this.ciag_fib_it = new System.Windows.Forms.Button();
            this.euklides = new System.Windows.Forms.Button();
            this.NWP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bombelkowe
            // 
            this.bombelkowe.Location = new System.Drawing.Point(12, 71);
            this.bombelkowe.Name = "bombelkowe";
            this.bombelkowe.Size = new System.Drawing.Size(156, 23);
            this.bombelkowe.TabIndex = 0;
            this.bombelkowe.Text = "Bombelkowe";
            this.bombelkowe.UseVisualStyleBackColor = true;
            this.bombelkowe.Click += new System.EventHandler(this.bombelkowe_Click);
            // 
            // przez_wybor
            // 
            this.przez_wybor.Location = new System.Drawing.Point(12, 103);
            this.przez_wybor.Name = "przez_wybor";
            this.przez_wybor.Size = new System.Drawing.Size(156, 23);
            this.przez_wybor.TabIndex = 1;
            this.przez_wybor.Text = "Przez Wybór";
            this.przez_wybor.UseVisualStyleBackColor = true;
            this.przez_wybor.Click += new System.EventHandler(this.przez_wybor_Click);
            // 
            // przez_wstawianie
            // 
            this.przez_wstawianie.Location = new System.Drawing.Point(12, 132);
            this.przez_wstawianie.Name = "przez_wstawianie";
            this.przez_wstawianie.Size = new System.Drawing.Size(156, 23);
            this.przez_wstawianie.TabIndex = 2;
            this.przez_wstawianie.Text = "Przez wstawianie";
            this.przez_wstawianie.UseVisualStyleBackColor = true;
            this.przez_wstawianie.Click += new System.EventHandler(this.przez_wstawianie_Click);
            // 
            // przez_zliczanie
            // 
            this.przez_zliczanie.Location = new System.Drawing.Point(12, 161);
            this.przez_zliczanie.Name = "przez_zliczanie";
            this.przez_zliczanie.Size = new System.Drawing.Size(156, 23);
            this.przez_zliczanie.TabIndex = 3;
            this.przez_zliczanie.Text = "Przez Zliczanie";
            this.przez_zliczanie.UseVisualStyleBackColor = true;
            this.przez_zliczanie.Click += new System.EventHandler(this.przez_zliczanie_Click);
            // 
            // dane
            // 
            this.dane.Location = new System.Drawing.Point(13, 12);
            this.dane.Multiline = true;
            this.dane.Name = "dane";
            this.dane.Size = new System.Drawing.Size(155, 53);
            this.dane.TabIndex = 4;
            this.dane.TextChanged += new System.EventHandler(this.dane_TextChanged);
            // 
            // merge_sort
            // 
            this.merge_sort.Location = new System.Drawing.Point(13, 190);
            this.merge_sort.Name = "merge_sort";
            this.merge_sort.Size = new System.Drawing.Size(155, 23);
            this.merge_sort.TabIndex = 5;
            this.merge_sort.Text = "Merge Sort";
            this.merge_sort.UseVisualStyleBackColor = true;
            this.merge_sort.Click += new System.EventHandler(this.merge_sort_Click);
            // 
            // ciagFib
            // 
            this.ciagFib.Location = new System.Drawing.Point(174, 42);
            this.ciagFib.Name = "ciagFib";
            this.ciagFib.Size = new System.Drawing.Size(155, 23);
            this.ciagFib.TabIndex = 6;
            this.ciagFib.Text = "Ciąg fib rekurencyjnie";
            this.ciagFib.UseVisualStyleBackColor = true;
            this.ciagFib.Click += new System.EventHandler(this.ciagFib_Click);
            // 
            // ciag_fib_it
            // 
            this.ciag_fib_it.Location = new System.Drawing.Point(174, 12);
            this.ciag_fib_it.Name = "ciag_fib_it";
            this.ciag_fib_it.Size = new System.Drawing.Size(155, 23);
            this.ciag_fib_it.TabIndex = 7;
            this.ciag_fib_it.Text = "Ciag Fib Iteracyjnie";
            this.ciag_fib_it.UseVisualStyleBackColor = true;
            this.ciag_fib_it.Click += new System.EventHandler(this.ciag_fib_it_Click);
            // 
            // euklides
            // 
            this.euklides.Location = new System.Drawing.Point(174, 71);
            this.euklides.Name = "euklides";
            this.euklides.Size = new System.Drawing.Size(155, 23);
            this.euklides.TabIndex = 8;
            this.euklides.Text = "Algorytm Euklidesa";
            this.euklides.UseVisualStyleBackColor = true;
            this.euklides.Click += new System.EventHandler(this.euklides_Click);
            // 
            // NWP
            // 
            this.NWP.Location = new System.Drawing.Point(174, 101);
            this.NWP.Name = "NWP";
            this.NWP.Size = new System.Drawing.Size(155, 23);
            this.NWP.TabIndex = 9;
            this.NWP.Text = "NWP";
            this.NWP.UseVisualStyleBackColor = true;
            this.NWP.Click += new System.EventHandler(this.NWP_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 289);
            this.Controls.Add(this.NWP);
            this.Controls.Add(this.euklides);
            this.Controls.Add(this.ciag_fib_it);
            this.Controls.Add(this.ciagFib);
            this.Controls.Add(this.merge_sort);
            this.Controls.Add(this.dane);
            this.Controls.Add(this.przez_zliczanie);
            this.Controls.Add(this.przez_wstawianie);
            this.Controls.Add(this.przez_wybor);
            this.Controls.Add(this.bombelkowe);
            this.Name = "Form1";
            this.Text = "Algorytmy";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bombelkowe;
        private System.Windows.Forms.Button przez_wybor;
        private System.Windows.Forms.Button przez_wstawianie;
        private System.Windows.Forms.Button przez_zliczanie;
        private System.Windows.Forms.TextBox dane;
        private System.Windows.Forms.Button merge_sort;
        private System.Windows.Forms.Button ciagFib;
        private System.Windows.Forms.Button ciag_fib_it;
        private System.Windows.Forms.Button euklides;
        private System.Windows.Forms.Button NWP;
    }
}

