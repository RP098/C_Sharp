
namespace AdoNet_W_winforms
{
    partial class MainForm
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
            this.dataGridViewCarInventory = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button_Delete = new System.Windows.Forms.Button();
            this.buttonView = new System.Windows.Forms.Button();
            this.textBoxView = new System.Windows.Forms.TextBox();
            this.textBoxDelete = new System.Windows.Forms.TextBox();
            this.groupBoxDeleteCarID = new System.Windows.Forms.GroupBox();
            this.groupBoxViewData = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCarInventory)).BeginInit();
            this.groupBoxDeleteCarID.SuspendLayout();
            this.groupBoxViewData.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewCarInventory
            // 
            this.dataGridViewCarInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCarInventory.Location = new System.Drawing.Point(12, 40);
            this.dataGridViewCarInventory.Name = "dataGridViewCarInventory";
            this.dataGridViewCarInventory.Size = new System.Drawing.Size(463, 313);
            this.dataGridViewCarInventory.TabIndex = 0;
            this.dataGridViewCarInventory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCarInventory_CellContentClick);
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(119, 31);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(75, 23);
            this.button_Delete.TabIndex = 1;
            this.button_Delete.Text = "Delete";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // buttonView
            // 
            this.buttonView.Location = new System.Drawing.Point(119, 33);
            this.buttonView.Name = "buttonView";
            this.buttonView.Size = new System.Drawing.Size(75, 23);
            this.buttonView.TabIndex = 2;
            this.buttonView.Text = "View";
            this.buttonView.UseVisualStyleBackColor = true;
            this.buttonView.Click += new System.EventHandler(this.buttonView_Click);
            // 
            // textBoxView
            // 
            this.textBoxView.Location = new System.Drawing.Point(6, 33);
            this.textBoxView.Name = "textBoxView";
            this.textBoxView.Size = new System.Drawing.Size(100, 20);
            this.textBoxView.TabIndex = 3;
            // 
            // textBoxDelete
            // 
            this.textBoxDelete.Location = new System.Drawing.Point(6, 31);
            this.textBoxDelete.Name = "textBoxDelete";
            this.textBoxDelete.Size = new System.Drawing.Size(100, 20);
            this.textBoxDelete.TabIndex = 4;
            // 
            // groupBoxDeleteCarID
            // 
            this.groupBoxDeleteCarID.Controls.Add(this.button_Delete);
            this.groupBoxDeleteCarID.Controls.Add(this.textBoxDelete);
            this.groupBoxDeleteCarID.Location = new System.Drawing.Point(27, 359);
            this.groupBoxDeleteCarID.Name = "groupBoxDeleteCarID";
            this.groupBoxDeleteCarID.Size = new System.Drawing.Size(200, 79);
            this.groupBoxDeleteCarID.TabIndex = 5;
            this.groupBoxDeleteCarID.TabStop = false;
            this.groupBoxDeleteCarID.Text = "Enter ID of Car to Delete";
            // 
            // groupBoxViewData
            // 
            this.groupBoxViewData.Controls.Add(this.textBoxView);
            this.groupBoxViewData.Controls.Add(this.buttonView);
            this.groupBoxViewData.Location = new System.Drawing.Point(246, 359);
            this.groupBoxViewData.Name = "groupBoxViewData";
            this.groupBoxViewData.Size = new System.Drawing.Size(200, 79);
            this.groupBoxViewData.TabIndex = 6;
            this.groupBoxViewData.TabStop = false;
            this.groupBoxViewData.Text = "Enter Make to View";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 450);
            this.Controls.Add(this.groupBoxViewData);
            this.Controls.Add(this.groupBoxDeleteCarID);
            this.Controls.Add(this.dataGridViewCarInventory);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCarInventory)).EndInit();
            this.groupBoxDeleteCarID.ResumeLayout(false);
            this.groupBoxDeleteCarID.PerformLayout();
            this.groupBoxViewData.ResumeLayout(false);
            this.groupBoxViewData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCarInventory;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button buttonView;
        private System.Windows.Forms.TextBox textBoxView;
        private System.Windows.Forms.TextBox textBoxDelete;
        private System.Windows.Forms.GroupBox groupBoxDeleteCarID;
        private System.Windows.Forms.GroupBox groupBoxViewData;
    }
}

