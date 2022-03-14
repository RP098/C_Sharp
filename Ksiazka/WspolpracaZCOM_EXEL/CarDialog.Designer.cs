
namespace WspolpracaZCOM_EXEL
{
    partial class CarDialog
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
            this.textBoxCarName = new System.Windows.Forms.TextBox();
            this.textBoxMeterStatus = new System.Windows.Forms.TextBox();
            this.textBoxCarSpeed = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AddCar = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxCarName
            // 
            this.textBoxCarName.Location = new System.Drawing.Point(150, 26);
            this.textBoxCarName.Name = "textBoxCarName";
            this.textBoxCarName.Size = new System.Drawing.Size(100, 20);
            this.textBoxCarName.TabIndex = 0;
            // 
            // textBoxMeterStatus
            // 
            this.textBoxMeterStatus.Location = new System.Drawing.Point(150, 100);
            this.textBoxMeterStatus.Name = "textBoxMeterStatus";
            this.textBoxMeterStatus.Size = new System.Drawing.Size(100, 20);
            this.textBoxMeterStatus.TabIndex = 1;
            // 
            // textBoxCarSpeed
            // 
            this.textBoxCarSpeed.Location = new System.Drawing.Point(150, 63);
            this.textBoxCarSpeed.Name = "textBoxCarSpeed";
            this.textBoxCarSpeed.Size = new System.Drawing.Size(100, 20);
            this.textBoxCarSpeed.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Car name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Meter status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Car Speed";
            // 
            // AddCar
            // 
            this.AddCar.Location = new System.Drawing.Point(24, 142);
            this.AddCar.Name = "AddCar";
            this.AddCar.Size = new System.Drawing.Size(75, 23);
            this.AddCar.TabIndex = 7;
            this.AddCar.Text = "Add Car";
            this.AddCar.UseVisualStyleBackColor = true;
            this.AddCar.Click += new System.EventHandler(this.AddCar_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(175, 142);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 8;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // CarDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 230);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.AddCar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCarSpeed);
            this.Controls.Add(this.textBoxMeterStatus);
            this.Controls.Add(this.textBoxCarName);
            this.Name = "CarDialog";
            this.Text = "CarDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCarName;
        private System.Windows.Forms.TextBox textBoxMeterStatus;
        private System.Windows.Forms.TextBox textBoxCarSpeed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AddCar;
        private System.Windows.Forms.Button Exit;
    }
}