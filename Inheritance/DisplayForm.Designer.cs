namespace Inheritance
{
    partial class DisplayForm
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
            this.lstAutomobile = new System.Windows.Forms.ListBox();
            this.lstTrucks = new System.Windows.Forms.ListBox();
            this.lstSUV = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstAutomobile
            // 
            this.lstAutomobile.FormattingEnabled = true;
            this.lstAutomobile.Location = new System.Drawing.Point(12, 161);
            this.lstAutomobile.Name = "lstAutomobile";
            this.lstAutomobile.Size = new System.Drawing.Size(177, 173);
            this.lstAutomobile.TabIndex = 0;
            // 
            // lstTrucks
            // 
            this.lstTrucks.FormattingEnabled = true;
            this.lstTrucks.Location = new System.Drawing.Point(207, 161);
            this.lstTrucks.Name = "lstTrucks";
            this.lstTrucks.Size = new System.Drawing.Size(182, 173);
            this.lstTrucks.TabIndex = 1;
            // 
            // lstSUV
            // 
            this.lstSUV.FormattingEnabled = true;
            this.lstSUV.Location = new System.Drawing.Point(407, 161);
            this.lstSUV.Name = "lstSUV";
            this.lstSUV.Size = new System.Drawing.Size(193, 173);
            this.lstSUV.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cars";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Trucks";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(474, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "SUVs";
            // 
            // DisplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 393);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstSUV);
            this.Controls.Add(this.lstTrucks);
            this.Controls.Add(this.lstAutomobile);
            this.Name = "DisplayForm";
            this.Text = "DisplayForm";
            this.Load += new System.EventHandler(this.DisplayForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstAutomobile;
        private System.Windows.Forms.ListBox lstTrucks;
        private System.Windows.Forms.ListBox lstSUV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}