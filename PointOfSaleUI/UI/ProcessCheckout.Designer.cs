namespace PointOfSaleUI.UI
{
    partial class ProcessCheckout
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtLastDigits = new System.Windows.Forms.TextBox();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.txtTenderedAmount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.btnTransact = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdoUpi = new System.Windows.Forms.RadioButton();
            this.rdoCard = new System.Windows.Forms.RadioButton();
            this.rdoCash = new System.Windows.Forms.RadioButton();
            this.label41 = new System.Windows.Forms.Label();
            this.lblWarning = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.panel1.Controls.Add(this.txtLastDigits);
            this.panel1.Controls.Add(this.txtBalance);
            this.panel1.Controls.Add(this.txtTenderedAmount);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtTotalAmount);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(29, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(305, 173);
            this.panel1.TabIndex = 1;
            // 
            // txtLastDigits
            // 
            this.txtLastDigits.Enabled = false;
            this.txtLastDigits.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastDigits.Location = new System.Drawing.Point(143, 90);
            this.txtLastDigits.Name = "txtLastDigits";
            this.txtLastDigits.Size = new System.Drawing.Size(140, 27);
            this.txtLastDigits.TabIndex = 6;
            this.txtLastDigits.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBalance
            // 
            this.txtBalance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBalance.Location = new System.Drawing.Point(143, 123);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.ReadOnly = true;
            this.txtBalance.Size = new System.Drawing.Size(140, 27);
            this.txtBalance.TabIndex = 7;
            this.txtBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTenderedAmount
            // 
            this.txtTenderedAmount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenderedAmount.Location = new System.Drawing.Point(143, 57);
            this.txtTenderedAmount.Name = "txtTenderedAmount";
            this.txtTenderedAmount.Size = new System.Drawing.Size(140, 27);
            this.txtTenderedAmount.TabIndex = 5;
            this.txtTenderedAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTenderedAmount.TextChanged += new System.EventHandler(this.txtTenderedAmount_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(21, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 14);
            this.label4.TabIndex = 2;
            this.label4.Text = "Last 6 Digits of Card";
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalAmount.Location = new System.Drawing.Point(143, 24);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.Size = new System.Drawing.Size(140, 27);
            this.txtTotalAmount.TabIndex = 4;
            this.txtTotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(21, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 14);
            this.label3.TabIndex = 3;
            this.label3.Text = "Balance";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(21, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tendered Amount";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Amount";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(25, 25);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(183, 29);
            this.label21.TabIndex = 0;
            this.label21.Text = "Process Checkout";
            // 
            // btnTransact
            // 
            this.btnTransact.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTransact.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnTransact.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTransact.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnTransact.FlatAppearance.BorderSize = 0;
            this.btnTransact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransact.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransact.ForeColor = System.Drawing.Color.White;
            this.btnTransact.Location = new System.Drawing.Point(29, 389);
            this.btnTransact.Name = "btnTransact";
            this.btnTransact.Size = new System.Drawing.Size(304, 38);
            this.btnTransact.TabIndex = 4;
            this.btnTransact.Text = "Save Transaction";
            this.btnTransact.UseVisualStyleBackColor = false;
            this.btnTransact.Click += new System.EventHandler(this.btnTransact_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.panel2.Controls.Add(this.rdoUpi);
            this.panel2.Controls.Add(this.rdoCard);
            this.panel2.Controls.Add(this.rdoCash);
            this.panel2.Controls.Add(this.label41);
            this.panel2.Location = new System.Drawing.Point(29, 251);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(305, 97);
            this.panel2.TabIndex = 2;
            // 
            // rdoUpi
            // 
            this.rdoUpi.AutoSize = true;
            this.rdoUpi.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoUpi.ForeColor = System.Drawing.Color.White;
            this.rdoUpi.Location = new System.Drawing.Point(214, 54);
            this.rdoUpi.Name = "rdoUpi";
            this.rdoUpi.Size = new System.Drawing.Size(50, 23);
            this.rdoUpi.TabIndex = 3;
            this.rdoUpi.Text = "UPI";
            this.rdoUpi.UseVisualStyleBackColor = true;
            this.rdoUpi.CheckedChanged += new System.EventHandler(this.rdoUpi_CheckedChanged);
            // 
            // rdoCard
            // 
            this.rdoCard.AutoSize = true;
            this.rdoCard.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoCard.ForeColor = System.Drawing.Color.White;
            this.rdoCard.Location = new System.Drawing.Point(127, 54);
            this.rdoCard.Name = "rdoCard";
            this.rdoCard.Size = new System.Drawing.Size(58, 23);
            this.rdoCard.TabIndex = 2;
            this.rdoCard.Text = "Card";
            this.rdoCard.UseVisualStyleBackColor = true;
            this.rdoCard.CheckedChanged += new System.EventHandler(this.rdoCard_CheckedChanged);
            // 
            // rdoCash
            // 
            this.rdoCash.AutoSize = true;
            this.rdoCash.Checked = true;
            this.rdoCash.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoCash.ForeColor = System.Drawing.Color.White;
            this.rdoCash.Location = new System.Drawing.Point(40, 54);
            this.rdoCash.Name = "rdoCash";
            this.rdoCash.Size = new System.Drawing.Size(58, 23);
            this.rdoCash.TabIndex = 1;
            this.rdoCash.TabStop = true;
            this.rdoCash.Text = "Cash";
            this.rdoCash.UseVisualStyleBackColor = true;
            this.rdoCash.CheckedChanged += new System.EventHandler(this.rdoCash_CheckedChanged);
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label41.ForeColor = System.Drawing.Color.White;
            this.label41.Location = new System.Drawing.Point(98, 20);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(109, 17);
            this.label41.TabIndex = 0;
            this.label41.Text = "Transaction Type";
            // 
            // lblWarning
            // 
            this.lblWarning.BackColor = System.Drawing.Color.Transparent;
            this.lblWarning.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarning.ForeColor = System.Drawing.Color.White;
            this.lblWarning.Location = new System.Drawing.Point(26, 351);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblWarning.Size = new System.Drawing.Size(308, 21);
            this.lblWarning.TabIndex = 3;
            this.lblWarning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblWarning.Visible = false;
            // 
            // ProcessCheckout
            // 
            this.AcceptButton = this.btnTransact;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(363, 447);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.btnTransact);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProcessCheckout";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Process Checkout";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btnTransact;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.TextBox txtTenderedAmount;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rdoUpi;
        private System.Windows.Forms.RadioButton rdoCard;
        private System.Windows.Forms.RadioButton rdoCash;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.TextBox txtLastDigits;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblWarning;
    }
}