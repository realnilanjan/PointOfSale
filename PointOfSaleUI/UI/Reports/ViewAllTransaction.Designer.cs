namespace PointOfSaleUI.UI.Reports
{
    partial class ViewAllTransaction
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.allTransactionsGridView = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLoadTransactions = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.fromDate = new Bunifu.Framework.UI.BunifuDatepicker();
            this.toDate = new Bunifu.Framework.UI.BunifuDatepicker();
            ((System.ComponentModel.ISupportInitialize)(this.allTransactionsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // allTransactionsGridView
            // 
            this.allTransactionsGridView.AllowUserToAddRows = false;
            this.allTransactionsGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Gainsboro;
            this.allTransactionsGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.allTransactionsGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.allTransactionsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.allTransactionsGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.allTransactionsGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.allTransactionsGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.allTransactionsGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.allTransactionsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allTransactionsGridView.DoubleBuffered = true;
            this.allTransactionsGridView.EnableHeadersVisualStyles = false;
            this.allTransactionsGridView.GridColor = System.Drawing.Color.White;
            this.allTransactionsGridView.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.allTransactionsGridView.HeaderForeColor = System.Drawing.Color.White;
            this.allTransactionsGridView.Location = new System.Drawing.Point(12, 71);
            this.allTransactionsGridView.MultiSelect = false;
            this.allTransactionsGridView.Name = "allTransactionsGridView";
            this.allTransactionsGridView.ReadOnly = true;
            this.allTransactionsGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.allTransactionsGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.allTransactionsGridView.RowHeadersVisible = false;
            this.allTransactionsGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.allTransactionsGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.allTransactionsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.allTransactionsGridView.Size = new System.Drawing.Size(1116, 641);
            this.allTransactionsGridView.TabIndex = 33;
            this.allTransactionsGridView.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 14);
            this.label1.TabIndex = 36;
            this.label1.Text = "From Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(387, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 14);
            this.label2.TabIndex = 37;
            this.label2.Text = "To Date";
            // 
            // btnLoadTransactions
            // 
            this.btnLoadTransactions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadTransactions.BackColor = System.Drawing.Color.Green;
            this.btnLoadTransactions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoadTransactions.FlatAppearance.BorderSize = 0;
            this.btnLoadTransactions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadTransactions.ForeColor = System.Drawing.Color.White;
            this.btnLoadTransactions.Location = new System.Drawing.Point(743, 20);
            this.btnLoadTransactions.Name = "btnLoadTransactions";
            this.btnLoadTransactions.Size = new System.Drawing.Size(139, 36);
            this.btnLoadTransactions.TabIndex = 38;
            this.btnLoadTransactions.Text = "Load Transactions";
            this.btnLoadTransactions.UseVisualStyleBackColor = false;
            this.btnLoadTransactions.Click += new System.EventHandler(this.btnLoadTransactions_Click);
            // 
            // lblError
            // 
            this.lblError.BackColor = System.Drawing.Color.Transparent;
            this.lblError.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Gray;
            this.lblError.Location = new System.Drawing.Point(397, 382);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(347, 29);
            this.lblError.TabIndex = 39;
            this.lblError.Text = "Select Dates and Load Transactions";
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fromDate
            // 
            this.fromDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.fromDate.BackColor = System.Drawing.Color.Teal;
            this.fromDate.BorderRadius = 0;
            this.fromDate.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromDate.ForeColor = System.Drawing.Color.White;
            this.fromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fromDate.FormatCustom = "yyyy-MM-dd hh:mm:ss";
            this.fromDate.Location = new System.Drawing.Point(78, 20);
            this.fromDate.Name = "fromDate";
            this.fromDate.Size = new System.Drawing.Size(296, 36);
            this.fromDate.TabIndex = 40;
            this.fromDate.Value = new System.DateTime(2020, 10, 29, 0, 28, 21, 207);
            this.fromDate.onValueChanged += new System.EventHandler(this.fromDate_onValueChanged);
            // 
            // toDate
            // 
            this.toDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.toDate.BackColor = System.Drawing.Color.Teal;
            this.toDate.BorderRadius = 0;
            this.toDate.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toDate.ForeColor = System.Drawing.Color.White;
            this.toDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.toDate.FormatCustom = "yyyy-MM-dd hh:mm:ss";
            this.toDate.Location = new System.Drawing.Point(441, 20);
            this.toDate.Name = "toDate";
            this.toDate.Size = new System.Drawing.Size(296, 36);
            this.toDate.TabIndex = 40;
            this.toDate.Value = new System.DateTime(2020, 10, 29, 0, 28, 21, 207);
            this.toDate.onValueChanged += new System.EventHandler(this.toDate_onValueChanged);
            // 
            // ViewAllTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1140, 724);
            this.Controls.Add(this.toDate);
            this.Controls.Add(this.fromDate);
            this.Controls.Add(this.btnLoadTransactions);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.allTransactionsGridView);
            this.Controls.Add(this.lblError);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViewAllTransaction";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "View All Transactions";
            ((System.ComponentModel.ISupportInitialize)(this.allTransactionsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid allTransactionsGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLoadTransactions;
        private System.Windows.Forms.Label lblError;
        private Bunifu.Framework.UI.BunifuDatepicker fromDate;
        private Bunifu.Framework.UI.BunifuDatepicker toDate;
    }
}