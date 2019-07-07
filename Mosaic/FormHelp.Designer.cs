namespace Mosaic
{
    partial class FormHelp
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
            this.picBoxHelp = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHelp)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxHelp
            // 
            this.picBoxHelp.Location = new System.Drawing.Point(0, 0);
            this.picBoxHelp.Name = "picBoxHelp";
            this.picBoxHelp.Size = new System.Drawing.Size(300, 300);
            this.picBoxHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxHelp.TabIndex = 0;
            this.picBoxHelp.TabStop = false;
            // 
            // FormHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.picBoxHelp);
            this.Name = "FormHelp";
            this.Text = "FormHelp";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHelp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxHelp;
    }
}