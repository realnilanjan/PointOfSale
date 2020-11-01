namespace PointOfSaleUI.UI
{
    partial class ShowQR
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
            this.lblUPIProvider = new System.Windows.Forms.Label();
            this.picUPIQR = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picUPIQR)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUPIProvider
            // 
            this.lblUPIProvider.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblUPIProvider.Font = new System.Drawing.Font("Calibri", 18F);
            this.lblUPIProvider.Location = new System.Drawing.Point(0, 525);
            this.lblUPIProvider.Name = "lblUPIProvider";
            this.lblUPIProvider.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblUPIProvider.Size = new System.Drawing.Size(584, 36);
            this.lblUPIProvider.TabIndex = 0;
            this.lblUPIProvider.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picUPIQR
            // 
            this.picUPIQR.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picUPIQR.BackColor = System.Drawing.Color.Black;
            this.picUPIQR.Location = new System.Drawing.Point(12, 12);
            this.picUPIQR.Name = "picUPIQR";
            this.picUPIQR.Size = new System.Drawing.Size(560, 510);
            this.picUPIQR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUPIQR.TabIndex = 1;
            this.picUPIQR.TabStop = false;
            // 
            // ShowQR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.picUPIQR);
            this.Controls.Add(this.lblUPIProvider);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShowQR";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "QR Code";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.picUPIQR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblUPIProvider;
        private System.Windows.Forms.PictureBox picUPIQR;
    }
}