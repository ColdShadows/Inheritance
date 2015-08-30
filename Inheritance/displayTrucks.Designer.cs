namespace Inheritance
{
    partial class displayTrucks
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
            this.lstTrucks = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstTrucks
            // 
            this.lstTrucks.FormattingEnabled = true;
            this.lstTrucks.Location = new System.Drawing.Point(54, 62);
            this.lstTrucks.Name = "lstTrucks";
            this.lstTrucks.Size = new System.Drawing.Size(166, 147);
            this.lstTrucks.TabIndex = 0;
            // 
            // displayTrucks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lstTrucks);
            this.Name = "displayTrucks";
            this.Text = "displayTrucks";
            this.Load += new System.EventHandler(this.displayTrucks_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstTrucks;
    }
}