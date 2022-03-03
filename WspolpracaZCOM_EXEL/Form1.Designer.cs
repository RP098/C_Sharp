
namespace WspolpracaZCOM_EXEL
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
            this.dataGridCars = new System.Windows.Forms.DataGridView();
            this.Export_to_Excel_Button = new System.Windows.Forms.Button();
            this.AddInventoryButton = new System.Windows.Forms.Button();
            this.Current_Inventory_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCars)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridCars
            // 
            this.dataGridCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCars.Location = new System.Drawing.Point(12, 40);
            this.dataGridCars.Name = "dataGridCars";
            this.dataGridCars.Size = new System.Drawing.Size(776, 350);
            this.dataGridCars.TabIndex = 0;
            // 
            // Export_to_Excel_Button
            // 
            this.Export_to_Excel_Button.Location = new System.Drawing.Point(568, 407);
            this.Export_to_Excel_Button.Name = "Export_to_Excel_Button";
            this.Export_to_Excel_Button.Size = new System.Drawing.Size(220, 23);
            this.Export_to_Excel_Button.TabIndex = 1;
            this.Export_to_Excel_Button.Text = "Export Current Inventory to Excel";
            this.Export_to_Excel_Button.UseVisualStyleBackColor = true;
            this.Export_to_Excel_Button.Click += new System.EventHandler(this.Export_to_Excel_Button_Click);
            // 
            // AddInventoryButton
            // 
            this.AddInventoryButton.Location = new System.Drawing.Point(12, 407);
            this.AddInventoryButton.Name = "AddInventoryButton";
            this.AddInventoryButton.Size = new System.Drawing.Size(220, 23);
            this.AddInventoryButton.TabIndex = 2;
            this.AddInventoryButton.Text = "Add New Entry Inventory";
            this.AddInventoryButton.UseVisualStyleBackColor = true;
            this.AddInventoryButton.Click += new System.EventHandler(this.AddInventoryButton_Click);
            // 
            // Current_Inventory_label
            // 
            this.Current_Inventory_label.AutoSize = true;
            this.Current_Inventory_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Current_Inventory_label.Location = new System.Drawing.Point(12, 9);
            this.Current_Inventory_label.Name = "Current_Inventory_label";
            this.Current_Inventory_label.Size = new System.Drawing.Size(177, 25);
            this.Current_Inventory_label.TabIndex = 4;
            this.Current_Inventory_label.Text = "Current Inventory";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Current_Inventory_label);
            this.Controls.Add(this.AddInventoryButton);
            this.Controls.Add(this.Export_to_Excel_Button);
            this.Controls.Add(this.dataGridCars);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridCars;
        private System.Windows.Forms.Button Export_to_Excel_Button;
        private System.Windows.Forms.Button AddInventoryButton;
        private System.Windows.Forms.Label Current_Inventory_label;
    }
}

