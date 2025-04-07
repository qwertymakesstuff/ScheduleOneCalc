namespace Schedule_1_Calculator
{
    partial class frmGit
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
            this.wbGit = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // wbGit
            // 
            this.wbGit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbGit.Location = new System.Drawing.Point(0, 0);
            this.wbGit.Margin = new System.Windows.Forms.Padding(4);
            this.wbGit.MinimumSize = new System.Drawing.Size(27, 25);
            this.wbGit.Name = "wbGit";
            this.wbGit.Size = new System.Drawing.Size(764, 478);
            this.wbGit.TabIndex = 0;
            // 
            // frmGit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 478);
            this.Controls.Add(this.wbGit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmGit";
            this.Text = "frmGit";
            this.Load += new System.EventHandler(this.frmGit_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser wbGit;
    }
}