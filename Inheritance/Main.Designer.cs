namespace Inheritance
{
    partial class Main
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnAnyCar = new System.Windows.Forms.Button();
            this.btndisplayCars = new System.Windows.Forms.Button();
            this.btndisplayTrucks = new System.Windows.Forms.Button();
            this.btnDisplaySUVs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(95, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add Car";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(95, 95);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Add Truck";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(95, 138);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Add SUV";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(77, 309);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(114, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Display Automobiles";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnAnyCar
            // 
            this.btnAnyCar.Location = new System.Drawing.Point(95, 347);
            this.btnAnyCar.Name = "btnAnyCar";
            this.btnAnyCar.Size = new System.Drawing.Size(75, 23);
            this.btnAnyCar.TabIndex = 4;
            this.btnAnyCar.Text = "Start any car";
            this.btnAnyCar.UseVisualStyleBackColor = true;
            this.btnAnyCar.Click += new System.EventHandler(this.btnAnyCar_Click);
            // 
            // btndisplayCars
            // 
            this.btndisplayCars.Location = new System.Drawing.Point(86, 185);
            this.btndisplayCars.Name = "btndisplayCars";
            this.btndisplayCars.Size = new System.Drawing.Size(96, 23);
            this.btndisplayCars.TabIndex = 5;
            this.btndisplayCars.Text = "Display Cars";
            this.btndisplayCars.UseVisualStyleBackColor = true;
            this.btndisplayCars.Click += new System.EventHandler(this.btndisplayCars_Click);
            // 
            // btndisplayTrucks
            // 
            this.btndisplayTrucks.Location = new System.Drawing.Point(86, 225);
            this.btndisplayTrucks.Name = "btndisplayTrucks";
            this.btndisplayTrucks.Size = new System.Drawing.Size(96, 23);
            this.btndisplayTrucks.TabIndex = 6;
            this.btndisplayTrucks.Text = "Display Trucks";
            this.btndisplayTrucks.UseVisualStyleBackColor = true;
            this.btndisplayTrucks.Click += new System.EventHandler(this.btndisplayTrucks_Click);
            // 
            // btnDisplaySUVs
            // 
            this.btnDisplaySUVs.Location = new System.Drawing.Point(86, 270);
            this.btnDisplaySUVs.Name = "btnDisplaySUVs";
            this.btnDisplaySUVs.Size = new System.Drawing.Size(96, 23);
            this.btnDisplaySUVs.TabIndex = 7;
            this.btnDisplaySUVs.Text = "Display SUVs";
            this.btnDisplaySUVs.UseVisualStyleBackColor = true;
            this.btnDisplaySUVs.Click += new System.EventHandler(this.btnDisplaySUVs_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 452);
            this.Controls.Add(this.btnDisplaySUVs);
            this.Controls.Add(this.btndisplayTrucks);
            this.Controls.Add(this.btndisplayCars);
            this.Controls.Add(this.btnAnyCar);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnAnyCar;
        private System.Windows.Forms.Button btndisplayCars;
        private System.Windows.Forms.Button btndisplayTrucks;
        private System.Windows.Forms.Button btnDisplaySUVs;
    }
}

