
namespace MetodyInżynieriWiedzy
{
    partial class KNNDlaPojObiektu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KNNDlaPojObiektu));
            this.najmniejszychWynikow = new System.Windows.Forms.Button();
            this.knnSumNajmniejszych = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // najmniejszychWynikow
            // 
            this.najmniejszychWynikow.Font = new System.Drawing.Font("Comic Sans MS", 15.75F);
            this.najmniejszychWynikow.Location = new System.Drawing.Point(82, 66);
            this.najmniejszychWynikow.Name = "najmniejszychWynikow";
            this.najmniejszychWynikow.Size = new System.Drawing.Size(542, 95);
            this.najmniejszychWynikow.TabIndex = 0;
            this.najmniejszychWynikow.Text = "Knn Najmniejszych Wyników ";
            this.najmniejszychWynikow.UseVisualStyleBackColor = true;
            this.najmniejszychWynikow.Click += new System.EventHandler(this.najmniejszychWynikow_Click);
            // 
            // knnSumNajmniejszych
            // 
            this.knnSumNajmniejszych.Font = new System.Drawing.Font("Comic Sans MS", 15.75F);
            this.knnSumNajmniejszych.Location = new System.Drawing.Point(82, 211);
            this.knnSumNajmniejszych.Name = "knnSumNajmniejszych";
            this.knnSumNajmniejszych.Size = new System.Drawing.Size(542, 95);
            this.knnSumNajmniejszych.TabIndex = 1;
            this.knnSumNajmniejszych.Text = "Knn Sum Najmniejszych";
            this.knnSumNajmniejszych.UseVisualStyleBackColor = true;
            this.knnSumNajmniejszych.Click += new System.EventHandler(this.knnSumNajmniejszych_Click);
            // 
            // KNNDlaPojObiektu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chartreuse;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(740, 415);
            this.Controls.Add(this.knnSumNajmniejszych);
            this.Controls.Add(this.najmniejszychWynikow);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "KNNDlaPojObiektu";
            this.Text = "KNN";
            this.Load += new System.EventHandler(this.KNNDlaPojObiektu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button najmniejszychWynikow;
        private System.Windows.Forms.Button knnSumNajmniejszych;
    }
}