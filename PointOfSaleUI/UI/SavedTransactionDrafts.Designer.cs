namespace PointOfSaleUI.UI
{
    partial class SavedTransactionDrafts
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
            this.savedDraftsGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.label21 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.savedDraftsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // savedDraftsGrid
            // 
            this.savedDraftsGrid.AllowUserToAddRows = false;
            this.savedDraftsGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Gainsboro;
            this.savedDraftsGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.savedDraftsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.savedDraftsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.savedDraftsGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.savedDraftsGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.savedDraftsGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.savedDraftsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.savedDraftsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.savedDraftsGrid.DoubleBuffered = true;
            this.savedDraftsGrid.EnableHeadersVisualStyles = false;
            this.savedDraftsGrid.GridColor = System.Drawing.Color.White;
            this.savedDraftsGrid.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.savedDraftsGrid.HeaderForeColor = System.Drawing.Color.White;
            this.savedDraftsGrid.Location = new System.Drawing.Point(12, 74);
            this.savedDraftsGrid.MultiSelect = false;
            this.savedDraftsGrid.Name = "savedDraftsGrid";
            this.savedDraftsGrid.ReadOnly = true;
            this.savedDraftsGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.savedDraftsGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.savedDraftsGrid.RowHeadersVisible = false;
            this.savedDraftsGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.savedDraftsGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.savedDraftsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.savedDraftsGrid.Size = new System.Drawing.Size(776, 397);
            this.savedDraftsGrid.TabIndex = 33;
            this.savedDraftsGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.savedDraftsGrid_CellDoubleClick);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(25, 27);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(200, 29);
            this.label21.TabIndex = 34;
            this.label21.Text = "Saved Transactions";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(287, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(227, 29);
            this.label4.TabIndex = 35;
            this.label4.Text = "No Saved Transactions";
            // 
            // SavedTransactionDrafts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(800, 485);
            this.Controls.Add(this.savedDraftsGrid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label21);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SavedTransactionDrafts";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Saved Transaction Drafts";
            ((System.ComponentModel.ISupportInitialize)(this.savedDraftsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid savedDraftsGrid;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label4;
    }
}