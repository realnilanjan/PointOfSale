namespace PointOfSaleUI.UI.Reports
{
    partial class TerminalTransactions
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.allTransactionsGridView = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.allSalesByCustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLoadTransactions = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.fromDate = new Bunifu.Framework.UI.BunifuDatepicker();
            this.toDate = new Bunifu.Framework.UI.BunifuDatepicker();
            this.btnPrint = new System.Windows.Forms.Button();
            this.rdoAllSales = new System.Windows.Forms.RadioButton();
            this.rdoAllSalesDated = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbSearchTransactionBy = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtTransactionSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.allTransactionsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allSalesByCustomerBindingSource)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // allTransactionsGridView
            // 
            this.allTransactionsGridView.AllowUserToAddRows = false;
            this.allTransactionsGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Gainsboro;
            this.allTransactionsGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.allTransactionsGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.allTransactionsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.allTransactionsGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.allTransactionsGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.allTransactionsGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.allTransactionsGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.allTransactionsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allTransactionsGridView.DoubleBuffered = true;
            this.allTransactionsGridView.EnableHeadersVisualStyles = false;
            this.allTransactionsGridView.GridColor = System.Drawing.Color.White;
            this.allTransactionsGridView.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.allTransactionsGridView.HeaderForeColor = System.Drawing.Color.White;
            this.allTransactionsGridView.Location = new System.Drawing.Point(12, 142);
            this.allTransactionsGridView.MultiSelect = false;
            this.allTransactionsGridView.Name = "allTransactionsGridView";
            this.allTransactionsGridView.ReadOnly = true;
            this.allTransactionsGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.allTransactionsGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.allTransactionsGridView.RowHeadersVisible = false;
            this.allTransactionsGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.allTransactionsGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.allTransactionsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.allTransactionsGridView.Size = new System.Drawing.Size(1116, 524);
            this.allTransactionsGridView.TabIndex = 33;
            this.allTransactionsGridView.Visible = false;
            // 
            // allSalesByCustomerBindingSource
            // 
            this.allSalesByCustomerBindingSource.DataSource = typeof(PointOfSale.Lib.Models.ReportModels.OrderDetailModel);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(192, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 14);
            this.label1.TabIndex = 36;
            this.label1.Text = "From Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(570, 35);
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
            this.btnLoadTransactions.Location = new System.Drawing.Point(926, 24);
            this.btnLoadTransactions.Name = "btnLoadTransactions";
            this.btnLoadTransactions.Size = new System.Drawing.Size(139, 36);
            this.btnLoadTransactions.TabIndex = 38;
            this.btnLoadTransactions.Text = "Load Transactions";
            this.btnLoadTransactions.UseVisualStyleBackColor = false;
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
            this.fromDate.Enabled = false;
            this.fromDate.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromDate.ForeColor = System.Drawing.Color.White;
            this.fromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fromDate.FormatCustom = "yyyy-MM-dd hh:mm:ss";
            this.fromDate.Location = new System.Drawing.Point(261, 24);
            this.fromDate.Name = "fromDate";
            this.fromDate.Size = new System.Drawing.Size(296, 36);
            this.fromDate.TabIndex = 40;
            this.fromDate.Value = new System.DateTime(2020, 10, 29, 0, 28, 21, 207);
            // 
            // toDate
            // 
            this.toDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.toDate.BackColor = System.Drawing.Color.Teal;
            this.toDate.BorderRadius = 0;
            this.toDate.Enabled = false;
            this.toDate.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toDate.ForeColor = System.Drawing.Color.White;
            this.toDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.toDate.FormatCustom = "yyyy-MM-dd hh:mm:ss";
            this.toDate.Location = new System.Drawing.Point(624, 24);
            this.toDate.Name = "toDate";
            this.toDate.Size = new System.Drawing.Size(296, 36);
            this.toDate.TabIndex = 40;
            this.toDate.Value = new System.DateTime(2020, 10, 29, 0, 28, 21, 207);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.BackColor = System.Drawing.Color.Green;
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(989, 676);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(139, 36);
            this.btnPrint.TabIndex = 38;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            // 
            // rdoAllSales
            // 
            this.rdoAllSales.AutoSize = true;
            this.rdoAllSales.Checked = true;
            this.rdoAllSales.ForeColor = System.Drawing.Color.White;
            this.rdoAllSales.Location = new System.Drawing.Point(25, 33);
            this.rdoAllSales.Name = "rdoAllSales";
            this.rdoAllSales.Size = new System.Drawing.Size(40, 18);
            this.rdoAllSales.TabIndex = 41;
            this.rdoAllSales.TabStop = true;
            this.rdoAllSales.Text = "All";
            this.rdoAllSales.UseVisualStyleBackColor = true;
            this.rdoAllSales.CheckedChanged += new System.EventHandler(this.rdoAllSales_CheckedChanged);
            // 
            // rdoAllSalesDated
            // 
            this.rdoAllSalesDated.AutoSize = true;
            this.rdoAllSalesDated.ForeColor = System.Drawing.Color.White;
            this.rdoAllSalesDated.Location = new System.Drawing.Point(71, 33);
            this.rdoAllSalesDated.Name = "rdoAllSalesDated";
            this.rdoAllSalesDated.Size = new System.Drawing.Size(107, 18);
            this.rdoAllSalesDated.TabIndex = 42;
            this.rdoAllSalesDated.Text = "Selected Dates";
            this.rdoAllSalesDated.UseVisualStyleBackColor = true;
            this.rdoAllSalesDated.CheckedChanged += new System.EventHandler(this.rdoAllSalesDated_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.cmbSearchTransactionBy);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.txtTransactionSearch);
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(12, 69);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1116, 60);
            this.panel3.TabIndex = 43;
            this.panel3.Text = "Search Category";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(822, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 14);
            this.label7.TabIndex = 5;
            this.label7.Text = "Search By:";
            // 
            // cmbSearchTransactionBy
            // 
            this.cmbSearchTransactionBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSearchTransactionBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearchTransactionBy.FormattingEnabled = true;
            this.cmbSearchTransactionBy.Items.AddRange(new object[] {
            "- Select -",
            "Invoice Number",
            "Customer Name",
            "Customer Contact"});
            this.cmbSearchTransactionBy.Location = new System.Drawing.Point(889, 20);
            this.cmbSearchTransactionBy.Name = "cmbSearchTransactionBy";
            this.cmbSearchTransactionBy.Size = new System.Drawing.Size(216, 22);
            this.cmbSearchTransactionBy.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PointOfSaleUI.Properties.Resources.search2;
            this.pictureBox1.Location = new System.Drawing.Point(15, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // txtTransactionSearch
            // 
            this.txtTransactionSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTransactionSearch.Enabled = false;
            this.txtTransactionSearch.Location = new System.Drawing.Point(43, 19);
            this.txtTransactionSearch.Name = "txtTransactionSearch";
            this.txtTransactionSearch.Size = new System.Drawing.Size(773, 22);
            this.txtTransactionSearch.TabIndex = 0;
            this.txtTransactionSearch.TextChanged += new System.EventHandler(this.txtTransactionSearch_TextChanged);
            // 
            // TerminalTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1140, 724);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.rdoAllSalesDated);
            this.Controls.Add(this.rdoAllSales);
            this.Controls.Add(this.toDate);
            this.Controls.Add(this.fromDate);
            this.Controls.Add(this.btnPrint);
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
            this.Name = "TerminalTransactions";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Terminal Transactions";
            ((System.ComponentModel.ISupportInitialize)(this.allTransactionsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allSalesByCustomerBindingSource)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource allSalesByCustomerBindingSource;
        private System.Windows.Forms.RadioButton rdoAllSales;
        private System.Windows.Forms.RadioButton rdoAllSalesDated;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbSearchTransactionBy;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtTransactionSearch;
    }
}