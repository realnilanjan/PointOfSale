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
            this.lblWarning = new System.Windows.Forms.Label();
            this.picUPIQR = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picUPIQR)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWarning
            // 
            this.lblWarning.BackColor = System.Drawing.Color.Transparent;
            this.lblWarning.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarning.ForeColor = System.Drawing.Color.Gray;
            this.lblWarning.Location = new System.Drawing.Point(12, 248);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblWarning.Size = new System.Drawing.Size(560, 65);
            this.lblWarning.TabIndex = 0;
            this.lblWarning.Text = "No QR Code file found.\r\nPlease go to Admin > Settings to add one.";
            this.lblWarning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picUPIQR
            // 
            this.picUPIQR.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picUPIQR.BackColor = System.Drawing.Color.Black;
            this.picUPIQR.Location = new System.Drawing.Point(12, 12);
            this.picUPIQR.Name = "picUPIQR";
            this.picUPIQR.Size = new System.Drawing.Size(560, 537);
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
            this.Controls.Add(this.lblWarning);
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

        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.PictureBox picUPIQR;
    }
}