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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.allTransactionsGridView = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLoadTransactions = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.fromDate = new Bunifu.Framework.UI.BunifuDatepicker();
            this.toDate = new Bunifu.Framework.UI.BunifuDatepicker();
            this.btnPrint = new System.Windows.Forms.Button();
            this.allSalesByCustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saleIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerAddressLine1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerAddressLine2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerAddressPinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.allTransactionsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allSalesByCustomerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // allTransactionsGridView
            // 
            this.allTransactionsGridView.AllowUserToAddRows = false;
            this.allTransactionsGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            this.allTransactionsGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.allTransactionsGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.allTransactionsGridView.AutoGenerateColumns = false;
            this.allTransactionsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.allTransactionsGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.allTransactionsGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.allTransactionsGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.allTransactionsGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.allTransactionsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allTransactionsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.saleIdDataGridViewTextBoxColumn,
            this.invoiceNumberDataGridViewTextBoxColumn,
            this.saleDateDataGridViewTextBoxColumn,
            this.customerIdDataGridViewTextBoxColumn,
            this.customerNameDataGridViewTextBoxColumn,
            this.customerAddressLine1DataGridViewTextBoxColumn,
            this.customerAddressLine2DataGridViewTextBoxColumn,
            this.customerAddressPinDataGridViewTextBoxColumn,
            this.customerPhoneDataGridViewTextBoxColumn});
            this.allTransactionsGridView.DataSource = this.allSalesByCustomerBindingSource;
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.allTransactionsGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.allTransactionsGridView.RowHeadersVisible = false;
            this.allTransactionsGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.allTransactionsGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.allTransactionsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.allTransactionsGridView.Size = new System.Drawing.Size(1116, 595);
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
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // allSalesByCustomerBindingSource
            // 
            this.allSalesByCustomerBindingSource.DataSource = typeof(PointOfSale.Lib.Models.ReportModels.AllSalesByCustomer);
            // 
            // saleIdDataGridViewTextBoxColumn
            // 
            this.saleIdDataGridViewTextBoxColumn.DataPropertyName = "SaleId";
            this.saleIdDataGridViewTextBoxColumn.HeaderText = "SaleId";
            this.saleIdDataGridViewTextBoxColumn.Name = "saleIdDataGridViewTextBoxColumn";
            this.saleIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // invoiceNumberDataGridViewTextBoxColumn
            // 
            this.invoiceNumberDataGridViewTextBoxColumn.DataPropertyName = "InvoiceNumber";
            this.invoiceNumberDataGridViewTextBoxColumn.HeaderText = "InvoiceNumber";
            this.invoiceNumberDataGridViewTextBoxColumn.Name = "invoiceNumberDataGridViewTextBoxColumn";
            this.invoiceNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // saleDateDataGridViewTextBoxColumn
            // 
            this.saleDateDataGridViewTextBoxColumn.DataPropertyName = "SaleDate";
            this.saleDateDataGridViewTextBoxColumn.HeaderText = "SaleDate";
            this.saleDateDataGridViewTextBoxColumn.Name = "saleDateDataGridViewTextBoxColumn";
            this.saleDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerIdDataGridViewTextBoxColumn
            // 
            this.customerIdDataGridViewTextBoxColumn.DataPropertyName = "CustomerId";
            this.customerIdDataGridViewTextBoxColumn.HeaderText = "CustomerId";
            this.customerIdDataGridViewTextBoxColumn.Name = "customerIdDataGridViewTextBoxColumn";
            this.customerIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerNameDataGridViewTextBoxColumn
            // 
            this.customerNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.HeaderText = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
            this.customerNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerAddressLine1DataGridViewTextBoxColumn
            // 
            this.customerAddressLine1DataGridViewTextBoxColumn.DataPropertyName = "CustomerAddressLine1";
            this.customerAddressLine1DataGridViewTextBoxColumn.HeaderText = "CustomerAddressLine1";
            this.customerAddressLine1DataGridViewTextBoxColumn.Name = "customerAddressLine1DataGridViewTextBoxColumn";
            this.customerAddressLine1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerAddressLine2DataGridViewTextBoxColumn
            // 
            this.customerAddressLine2DataGridViewTextBoxColumn.DataPropertyName = "CustomerAddressLine2";
            this.customerAddressLine2DataGridViewTextBoxColumn.HeaderText = "CustomerAddressLine2";
            this.customerAddressLine2DataGridViewTextBoxColumn.Name = "customerAddressLine2DataGridViewTextBoxColumn";
            this.customerAddressLine2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerAddressPinDataGridViewTextBoxColumn
            // 
            this.customerAddressPinDataGridViewTextBoxColumn.DataPropertyName = "CustomerAddressPin";
            this.customerAddressPinDataGridViewTextBoxColumn.HeaderText = "CustomerAddressPin";
            this.customerAddressPinDataGridViewTextBoxColumn.Name = "customerAddressPinDataGridViewTextBoxColumn";
            this.customerAddressPinDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerPhoneDataGridViewTextBoxColumn
            // 
            this.customerPhoneDataGridViewTextBoxColumn.DataPropertyName = "CustomerPhone";
            this.customerPhoneDataGridViewTextBoxColumn.HeaderText = "CustomerPhone";
            this.customerPhoneDataGridViewTextBoxColumn.Name = "customerPhoneDataGridViewTextBoxColumn";
            this.customerPhoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ViewAllTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1140, 724);
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
            this.Name = "ViewAllTransaction";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "View All Transactions";
            ((System.ComponentModel.ISupportInitialize)(this.allTransactionsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allSalesByCustomerBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerAddressLine1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerAddressLine2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerAddressPinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource allSalesByCustomerBindingSource;
    }
}