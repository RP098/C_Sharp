
namespace MetodyInżynieriWiedzy
{
    partial class KnnDlaBazyProbek
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KnnDlaBazyProbek));
            this.knnSumNajmniejszych = new System.Windows.Forms.Button();
            this.najmniejszychWynikow = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // knnSumNajmniejszych
            // 
            this.knnSumNajmniejszych.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.knnSumNajmniejszych.Location = new System.Drawing.Point(128, 278);
            this.knnSumNajmniejszych.Name = "knnSumNajmniejszych";
            this.knnSumNajmniejszych.Size = new System.Drawing.Size(542, 95);
            this.knnSumNajmniejszych.TabIndex = 3;
            this.knnSumNajmniejszych.Text = "Knn Sum Najmniejszych";
            this.knnSumNajmniejszych.UseVisualStyleBackColor = true;
            this.knnSumNajmniejszych.Click += new System.EventHandler(this.knnSumNajmniejszych_Click);
            // 
            // najmniejszychWynikow
            // 
            this.najmniejszychWynikow.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.najmniejszychWynikow.Location = new System.Drawing.Point(128, 145);
            this.najmniejszychWynikow.Name = "najmniejszychWynikow";
            this.najmniejszychWynikow.Size = new System.Drawing.Size(542, 95);
            this.najmniejszychWynikow.TabIndex = 2;
            this.najmniejszychWynikow.Text = "Knn Najmniejszych Wyników ";
            this.najmniejszychWynikow.UseVisualStyleBackColor = true;
            this.najmniejszychWynikow.Click += new System.EventHandler(this.najmniejszychWynikow_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(215, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(401, 40);
            this.label1.TabIndex = 4;
            this.label1.Text = "Wybierz Sposób Testowania";
            // 
            // KnnDlaBazyProbek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.knnSumNajmniejszych);
            this.Controls.Add(this.najmniejszychWynikow);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KnnDlaBazyProbek";
            this.Text = "KnnDlaBazyProbek";
            this.Load += new System.EventHandler(this.KnnDlaBazyProbek_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button knnSumNajmniejszych;
        private System.Windows.Forms.Button najmniejszychWynikow;
        private System.Windows.Forms.Label label1;
    }
}