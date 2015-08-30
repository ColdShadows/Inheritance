namespace Inheritance
{
    partial class displaySUVs
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
            this.lstSUVs = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstSUVs
            // 
            this.lstSUVs.FormattingEnabled = true;
            this.lstSUVs.Location = new System.Drawing.Point(53, 64);
            this.lstSUVs.Name = "lstSUVs";
            this.lstSUVs.Size = new System.Drawing.Size(156, 160);
            this.lstSUVs.TabIndex = 0;
            // 
            // displaySUVs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lstSUVs);
            this.Name = "displaySUVs";
            this.Text = "displaySUVs";
            this.Load += new System.EventHandler(this.displaySUVs_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstSUVs;
    }
}