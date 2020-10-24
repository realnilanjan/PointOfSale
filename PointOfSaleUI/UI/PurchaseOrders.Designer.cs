namespace PointOfSaleUI.UI
{
    partial class PurchaseOrders
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridReceivedOrders = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gridPurchaseOrders = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            ((System.ComponentModel.ISupportInitialize)(this.gridReceivedOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPurchaseOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // gridReceivedOrders
            // 
            this.gridReceivedOrders.AllowUserToAddRows = false;
            this.gridReceivedOrders.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Gainsboro;
            this.gridReceivedOrders.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.gridReceivedOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridReceivedOrders.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.gridReceivedOrders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridReceivedOrders.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridReceivedOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.gridReceivedOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridReceivedOrders.DoubleBuffered = true;
            this.gridReceivedOrders.EnableHeadersVisualStyles = false;
            this.gridReceivedOrders.GridColor = System.Drawing.Color.White;
            this.gridReceivedOrders.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.gridReceivedOrders.HeaderForeColor = System.Drawing.Color.White;
            this.gridReceivedOrders.Location = new System.Drawing.Point(29, 369);
            this.gridReceivedOrders.Name = "gridReceivedOrders";
            this.gridReceivedOrders.ReadOnly = true;
            this.gridReceivedOrders.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridReceivedOrders.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.gridReceivedOrders.RowHeadersVisible = false;
            this.gridReceivedOrders.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gridReceivedOrders.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gridReceivedOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridReceivedOrders.Size = new System.Drawing.Size(743, 233);
            this.gridReceivedOrders.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 29);
            this.label1.TabIndex = 29;
            this.label1.Text = "Purchase Orders";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(27, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 14);
            this.label2.TabIndex = 30;
            this.label2.Text = "Barcode";
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(84, 75);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(315, 21);
            this.txtBarcode.TabIndex = 31;
            this.txtBarcode.TextChanged += new System.EventHandler(this.txtBarcode_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(25, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 29);
            this.label3.TabIndex = 29;
            this.label3.Text = "Received Orders";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(633, 316);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(139, 41);
            this.btnAdd.TabIndex = 32;
            this.btnAdd.Text = "Save New Stock";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gridPurchaseOrders
            // 
            this.gridPurchaseOrders.AllowUserToAddRows = false;
            this.gridPurchaseOrders.AllowUserToDeleteRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            this.gridPurchaseOrders.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.gridPurchaseOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridPurchaseOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridPurchaseOrders.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.gridPurchaseOrders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridPurchaseOrders.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridPurchaseOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.gridPurchaseOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPurchaseOrders.DoubleBuffered = true;
            this.gridPurchaseOrders.EnableHeadersVisualStyles = false;
            this.gridPurchaseOrders.GridColor = System.Drawing.Color.White;
            this.gridPurchaseOrders.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.gridPurchaseOrders.HeaderForeColor = System.Drawing.Color.White;
            this.gridPurchaseOrders.Location = new System.Drawing.Point(29, 102);
            this.gridPurchaseOrders.Name = "gridPurchaseOrders";
            this.gridPurchaseOrders.ReadOnly = true;
            this.gridPurchaseOrders.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridPurchaseOrders.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.gridPurchaseOrders.RowHeadersVisible = false;
            this.gridPurchaseOrders.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gridPurchaseOrders.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gridPurchaseOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPurchaseOrders.Size = new System.Drawing.Size(743, 208);
            this.gridPurchaseOrders.TabIndex = 33;
            // 
            // PurchaseOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(800, 614);
            this.Controls.Add(this.gridPurchaseOrders);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridReceivedOrders);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PurchaseOrders";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Manage Purchase Orders";
            ((System.ComponentModel.ISupportInitialize)(this.gridReceivedOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPurchaseOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid gridReceivedOrders;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdd;
        private Bunifu.Framework.UI.BunifuCustomDataGrid gridPurchaseOrders;
    }
}