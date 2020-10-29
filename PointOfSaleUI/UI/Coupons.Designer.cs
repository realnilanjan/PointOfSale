namespace PointOfSaleUI.UI
{
    partial class Coupons
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Coupons));
            this.couponGridView = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.imagesList = new System.Windows.Forms.ImageList(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtBulkDescription = new System.Windows.Forms.TextBox();
            this.numNoOfCoupons = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBulkPercentDiscount = new System.Windows.Forms.TextBox();
            this.rdoBulkDPercentage = new System.Windows.Forms.RadioButton();
            this.txtBulkFlatDiscount = new System.Windows.Forms.TextBox();
            this.rdoBulkPDiscount = new System.Windows.Forms.RadioButton();
            this.btnBulkGenerate = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bulkStartDate = new Bunifu.Framework.UI.BunifuDatepicker();
            this.bulkExpiryDate = new Bunifu.Framework.UI.BunifuDatepicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSingleDescription = new System.Windows.Forms.TextBox();
            this.txtSinglePercentDiscount = new System.Windows.Forms.TextBox();
            this.txtSingleFlatDiscount = new System.Windows.Forms.TextBox();
            this.rdoSingleDPercentage = new System.Windows.Forms.RadioButton();
            this.rdoSinglePDiscount = new System.Windows.Forms.RadioButton();
            this.btnGenerateCoupon = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSaveCoupon = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.singleExpiryDate = new Bunifu.Framework.UI.BunifuDatepicker();
            this.singleStartDate = new Bunifu.Framework.UI.BunifuDatepicker();
            this.txtCouponCode = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblNoCoupons = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblWarning = new System.Windows.Forms.Label();
            this.btnDeleteCoupon = new System.Windows.Forms.Button();
            this.btnUpdateCoupon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.couponGridView)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNoOfCoupons)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // couponGridView
            // 
            this.couponGridView.AllowUserToAddRows = false;
            this.couponGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            this.couponGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.couponGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.couponGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.couponGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.couponGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.couponGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.couponGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.couponGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.couponGridView.DoubleBuffered = true;
            this.couponGridView.EnableHeadersVisualStyles = false;
            this.couponGridView.GridColor = System.Drawing.Color.White;
            this.couponGridView.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.couponGridView.HeaderForeColor = System.Drawing.Color.White;
            this.couponGridView.Location = new System.Drawing.Point(12, 375);
            this.couponGridView.Name = "couponGridView";
            this.couponGridView.ReadOnly = true;
            this.couponGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.couponGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.couponGridView.RowHeadersVisible = false;
            this.couponGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.couponGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.couponGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.couponGridView.Size = new System.Drawing.Size(905, 315);
            this.couponGridView.TabIndex = 2;
            this.couponGridView.Visible = false;
            this.couponGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.couponGridView_CellClick);
            this.couponGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.couponGridView_CellDoubleClick);
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomLabel5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuCustomLabel5.ImageKey = "coupon.png";
            this.bunifuCustomLabel5.ImageList = this.imagesList;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(25, 25);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(145, 30);
            this.bunifuCustomLabel5.TabIndex = 0;
            this.bunifuCustomLabel5.Text = "Coupons";
            this.bunifuCustomLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // imagesList
            // 
            this.imagesList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imagesList.ImageStream")));
            this.imagesList.TransparentColor = System.Drawing.Color.Transparent;
            this.imagesList.Images.SetKeyName(0, "dashboard.png");
            this.imagesList.Images.SetKeyName(1, "staff.png");
            this.imagesList.Images.SetKeyName(2, "categories.png");
            this.imagesList.Images.SetKeyName(3, "stock.png");
            this.imagesList.Images.SetKeyName(4, "supplier.png");
            this.imagesList.Images.SetKeyName(5, "report.png");
            this.imagesList.Images.SetKeyName(6, "terminal.png");
            this.imagesList.Images.SetKeyName(7, "settings.png");
            this.imagesList.Images.SetKeyName(8, "logout.png");
            this.imagesList.Images.SetKeyName(9, "rupee.png");
            this.imagesList.Images.SetKeyName(10, "coupon.png");
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.panel2.Controls.Add(this.txtBulkDescription);
            this.panel2.Controls.Add(this.numNoOfCoupons);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtBulkPercentDiscount);
            this.panel2.Controls.Add(this.rdoBulkDPercentage);
            this.panel2.Controls.Add(this.txtBulkFlatDiscount);
            this.panel2.Controls.Add(this.rdoBulkPDiscount);
            this.panel2.Controls.Add(this.btnBulkGenerate);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.bulkStartDate);
            this.panel2.Controls.Add(this.bulkExpiryDate);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(455, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(447, 300);
            this.panel2.TabIndex = 1;
            // 
            // txtBulkDescription
            // 
            this.txtBulkDescription.Location = new System.Drawing.Point(15, 66);
            this.txtBulkDescription.Multiline = true;
            this.txtBulkDescription.Name = "txtBulkDescription";
            this.txtBulkDescription.Size = new System.Drawing.Size(218, 51);
            this.txtBulkDescription.TabIndex = 10;
            // 
            // numNoOfCoupons
            // 
            this.numNoOfCoupons.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numNoOfCoupons.Location = new System.Drawing.Point(146, 41);
            this.numNoOfCoupons.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numNoOfCoupons.Name = "numNoOfCoupons";
            this.numNoOfCoupons.Size = new System.Drawing.Size(87, 22);
            this.numNoOfCoupons.TabIndex = 10;
            this.numNoOfCoupons.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numNoOfCoupons.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 14);
            this.label6.TabIndex = 9;
            this.label6.Text = "No. Of Coupons";
            // 
            // txtBulkPercentDiscount
            // 
            this.txtBulkPercentDiscount.Enabled = false;
            this.txtBulkPercentDiscount.Location = new System.Drawing.Point(153, 152);
            this.txtBulkPercentDiscount.Name = "txtBulkPercentDiscount";
            this.txtBulkPercentDiscount.Size = new System.Drawing.Size(80, 22);
            this.txtBulkPercentDiscount.TabIndex = 4;
            this.txtBulkPercentDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rdoBulkDPercentage
            // 
            this.rdoBulkDPercentage.AutoSize = true;
            this.rdoBulkDPercentage.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBulkDPercentage.ForeColor = System.Drawing.Color.White;
            this.rdoBulkDPercentage.Location = new System.Drawing.Point(15, 154);
            this.rdoBulkDPercentage.Name = "rdoBulkDPercentage";
            this.rdoBulkDPercentage.Size = new System.Drawing.Size(136, 18);
            this.rdoBulkDPercentage.TabIndex = 3;
            this.rdoBulkDPercentage.Text = "Discount Percentage";
            this.rdoBulkDPercentage.UseVisualStyleBackColor = true;
            this.rdoBulkDPercentage.CheckedChanged += new System.EventHandler(this.rdoBulkDPercentage_CheckedChanged);
            // 
            // txtBulkFlatDiscount
            // 
            this.txtBulkFlatDiscount.Location = new System.Drawing.Point(153, 122);
            this.txtBulkFlatDiscount.Name = "txtBulkFlatDiscount";
            this.txtBulkFlatDiscount.Size = new System.Drawing.Size(80, 22);
            this.txtBulkFlatDiscount.TabIndex = 2;
            this.txtBulkFlatDiscount.Text = "20";
            this.txtBulkFlatDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rdoBulkPDiscount
            // 
            this.rdoBulkPDiscount.AutoSize = true;
            this.rdoBulkPDiscount.Checked = true;
            this.rdoBulkPDiscount.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBulkPDiscount.ForeColor = System.Drawing.Color.White;
            this.rdoBulkPDiscount.Location = new System.Drawing.Point(15, 124);
            this.rdoBulkPDiscount.Name = "rdoBulkPDiscount";
            this.rdoBulkPDiscount.Size = new System.Drawing.Size(126, 18);
            this.rdoBulkPDiscount.TabIndex = 1;
            this.rdoBulkPDiscount.TabStop = true;
            this.rdoBulkPDiscount.Text = "Flat Price Discount";
            this.rdoBulkPDiscount.UseVisualStyleBackColor = true;
            this.rdoBulkPDiscount.CheckedChanged += new System.EventHandler(this.rdoBulkPDiscount_CheckedChanged);
            // 
            // btnBulkGenerate
            // 
            this.btnBulkGenerate.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnBulkGenerate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnBulkGenerate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnBulkGenerate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBulkGenerate.BorderRadius = 0;
            this.btnBulkGenerate.ButtonText = "Generate";
            this.btnBulkGenerate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBulkGenerate.DisabledColor = System.Drawing.Color.Gray;
            this.btnBulkGenerate.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBulkGenerate.Iconcolor = System.Drawing.Color.Transparent;
            this.btnBulkGenerate.Iconimage = null;
            this.btnBulkGenerate.Iconimage_right = null;
            this.btnBulkGenerate.Iconimage_right_Selected = null;
            this.btnBulkGenerate.Iconimage_Selected = null;
            this.btnBulkGenerate.IconMarginLeft = 0;
            this.btnBulkGenerate.IconMarginRight = 0;
            this.btnBulkGenerate.IconRightVisible = true;
            this.btnBulkGenerate.IconRightZoom = 0D;
            this.btnBulkGenerate.IconVisible = true;
            this.btnBulkGenerate.IconZoom = 90D;
            this.btnBulkGenerate.IsTab = false;
            this.btnBulkGenerate.Location = new System.Drawing.Point(317, 197);
            this.btnBulkGenerate.Name = "btnBulkGenerate";
            this.btnBulkGenerate.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnBulkGenerate.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnBulkGenerate.OnHoverTextColor = System.Drawing.Color.White;
            this.btnBulkGenerate.selected = false;
            this.btnBulkGenerate.Size = new System.Drawing.Size(116, 93);
            this.btnBulkGenerate.TabIndex = 11;
            this.btnBulkGenerate.Text = "Generate";
            this.btnBulkGenerate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBulkGenerate.Textcolor = System.Drawing.Color.White;
            this.btnBulkGenerate.TextFont = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.btnBulkGenerate.Click += new System.EventHandler(this.btnBulkGenerate_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 14);
            this.label5.TabIndex = 7;
            this.label5.Text = "Expiry Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Generate Bulk Coupons";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 14);
            this.label4.TabIndex = 5;
            this.label4.Text = "Issue Date";
            // 
            // bulkStartDate
            // 
            this.bulkStartDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bulkStartDate.BackColor = System.Drawing.Color.Teal;
            this.bulkStartDate.BorderRadius = 0;
            this.bulkStartDate.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bulkStartDate.ForeColor = System.Drawing.Color.White;
            this.bulkStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.bulkStartDate.FormatCustom = null;
            this.bulkStartDate.Location = new System.Drawing.Point(15, 197);
            this.bulkStartDate.Name = "bulkStartDate";
            this.bulkStartDate.Size = new System.Drawing.Size(296, 36);
            this.bulkStartDate.TabIndex = 6;
            this.bulkStartDate.Value = new System.DateTime(2020, 10, 29, 0, 28, 24, 754);
            this.bulkStartDate.onValueChanged += new System.EventHandler(this.bulkStartDate_onValueChanged);
            // 
            // bulkExpiryDate
            // 
            this.bulkExpiryDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bulkExpiryDate.BackColor = System.Drawing.Color.Teal;
            this.bulkExpiryDate.BorderRadius = 0;
            this.bulkExpiryDate.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bulkExpiryDate.ForeColor = System.Drawing.Color.White;
            this.bulkExpiryDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.bulkExpiryDate.FormatCustom = null;
            this.bulkExpiryDate.Location = new System.Drawing.Point(15, 254);
            this.bulkExpiryDate.Name = "bulkExpiryDate";
            this.bulkExpiryDate.Size = new System.Drawing.Size(296, 36);
            this.bulkExpiryDate.TabIndex = 8;
            this.bulkExpiryDate.Value = new System.DateTime(2020, 10, 29, 0, 28, 22, 343);
            this.bulkExpiryDate.onValueChanged += new System.EventHandler(this.bulkExpiryDate_onValueChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.panel1.Controls.Add(this.txtSingleDescription);
            this.panel1.Controls.Add(this.txtSinglePercentDiscount);
            this.panel1.Controls.Add(this.txtSingleFlatDiscount);
            this.panel1.Controls.Add(this.rdoSingleDPercentage);
            this.panel1.Controls.Add(this.rdoSinglePDiscount);
            this.panel1.Controls.Add(this.btnGenerateCoupon);
            this.panel1.Controls.Add(this.btnSaveCoupon);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label41);
            this.panel1.Controls.Add(this.singleExpiryDate);
            this.panel1.Controls.Add(this.singleStartDate);
            this.panel1.Controls.Add(this.txtCouponCode);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(446, 300);
            this.panel1.TabIndex = 0;
            // 
            // txtSingleDescription
            // 
            this.txtSingleDescription.Location = new System.Drawing.Point(15, 66);
            this.txtSingleDescription.Multiline = true;
            this.txtSingleDescription.Name = "txtSingleDescription";
            this.txtSingleDescription.Size = new System.Drawing.Size(218, 51);
            this.txtSingleDescription.TabIndex = 10;
            // 
            // txtSinglePercentDiscount
            // 
            this.txtSinglePercentDiscount.Enabled = false;
            this.txtSinglePercentDiscount.Location = new System.Drawing.Point(153, 153);
            this.txtSinglePercentDiscount.Name = "txtSinglePercentDiscount";
            this.txtSinglePercentDiscount.Size = new System.Drawing.Size(80, 21);
            this.txtSinglePercentDiscount.TabIndex = 4;
            this.txtSinglePercentDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSingleFlatDiscount
            // 
            this.txtSingleFlatDiscount.Location = new System.Drawing.Point(153, 123);
            this.txtSingleFlatDiscount.Name = "txtSingleFlatDiscount";
            this.txtSingleFlatDiscount.Size = new System.Drawing.Size(80, 21);
            this.txtSingleFlatDiscount.TabIndex = 2;
            this.txtSingleFlatDiscount.Text = "20";
            this.txtSingleFlatDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rdoSingleDPercentage
            // 
            this.rdoSingleDPercentage.AutoSize = true;
            this.rdoSingleDPercentage.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoSingleDPercentage.ForeColor = System.Drawing.Color.White;
            this.rdoSingleDPercentage.Location = new System.Drawing.Point(15, 154);
            this.rdoSingleDPercentage.Name = "rdoSingleDPercentage";
            this.rdoSingleDPercentage.Size = new System.Drawing.Size(136, 18);
            this.rdoSingleDPercentage.TabIndex = 3;
            this.rdoSingleDPercentage.Text = "Discount Percentage";
            this.rdoSingleDPercentage.UseVisualStyleBackColor = true;
            this.rdoSingleDPercentage.CheckedChanged += new System.EventHandler(this.rdoSingleDPercentage_CheckedChanged);
            // 
            // rdoSinglePDiscount
            // 
            this.rdoSinglePDiscount.AutoSize = true;
            this.rdoSinglePDiscount.Checked = true;
            this.rdoSinglePDiscount.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoSinglePDiscount.ForeColor = System.Drawing.Color.White;
            this.rdoSinglePDiscount.Location = new System.Drawing.Point(15, 124);
            this.rdoSinglePDiscount.Name = "rdoSinglePDiscount";
            this.rdoSinglePDiscount.Size = new System.Drawing.Size(126, 18);
            this.rdoSinglePDiscount.TabIndex = 1;
            this.rdoSinglePDiscount.TabStop = true;
            this.rdoSinglePDiscount.Text = "Flat Price Discount";
            this.rdoSinglePDiscount.UseVisualStyleBackColor = true;
            this.rdoSinglePDiscount.CheckedChanged += new System.EventHandler(this.rdoSinglePDiscount_CheckedChanged);
            // 
            // btnGenerateCoupon
            // 
            this.btnGenerateCoupon.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnGenerateCoupon.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnGenerateCoupon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnGenerateCoupon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGenerateCoupon.BorderRadius = 0;
            this.btnGenerateCoupon.ButtonText = "";
            this.btnGenerateCoupon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerateCoupon.DisabledColor = System.Drawing.Color.Gray;
            this.btnGenerateCoupon.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateCoupon.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGenerateCoupon.Iconimage = global::PointOfSaleUI.Properties.Resources.reload;
            this.btnGenerateCoupon.Iconimage_right = null;
            this.btnGenerateCoupon.Iconimage_right_Selected = null;
            this.btnGenerateCoupon.Iconimage_Selected = null;
            this.btnGenerateCoupon.IconMarginLeft = 0;
            this.btnGenerateCoupon.IconMarginRight = 0;
            this.btnGenerateCoupon.IconRightVisible = true;
            this.btnGenerateCoupon.IconRightZoom = 0D;
            this.btnGenerateCoupon.IconVisible = true;
            this.btnGenerateCoupon.IconZoom = 50D;
            this.btnGenerateCoupon.IsTab = false;
            this.btnGenerateCoupon.Location = new System.Drawing.Point(207, 36);
            this.btnGenerateCoupon.Name = "btnGenerateCoupon";
            this.btnGenerateCoupon.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnGenerateCoupon.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnGenerateCoupon.OnHoverTextColor = System.Drawing.Color.White;
            this.btnGenerateCoupon.selected = false;
            this.btnGenerateCoupon.Size = new System.Drawing.Size(27, 27);
            this.btnGenerateCoupon.TabIndex = 9;
            this.btnGenerateCoupon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGenerateCoupon.Textcolor = System.Drawing.Color.White;
            this.btnGenerateCoupon.TextFont = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.btnGenerateCoupon.Click += new System.EventHandler(this.btnGenerateCoupon_Click);
            // 
            // btnSaveCoupon
            // 
            this.btnSaveCoupon.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSaveCoupon.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSaveCoupon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSaveCoupon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSaveCoupon.BorderRadius = 0;
            this.btnSaveCoupon.ButtonText = "Save";
            this.btnSaveCoupon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveCoupon.DisabledColor = System.Drawing.Color.Gray;
            this.btnSaveCoupon.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveCoupon.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSaveCoupon.Iconimage = null;
            this.btnSaveCoupon.Iconimage_right = null;
            this.btnSaveCoupon.Iconimage_right_Selected = null;
            this.btnSaveCoupon.Iconimage_Selected = null;
            this.btnSaveCoupon.IconMarginLeft = 0;
            this.btnSaveCoupon.IconMarginRight = 0;
            this.btnSaveCoupon.IconRightVisible = true;
            this.btnSaveCoupon.IconRightZoom = 0D;
            this.btnSaveCoupon.IconVisible = true;
            this.btnSaveCoupon.IconZoom = 90D;
            this.btnSaveCoupon.IsTab = false;
            this.btnSaveCoupon.Location = new System.Drawing.Point(317, 197);
            this.btnSaveCoupon.Name = "btnSaveCoupon";
            this.btnSaveCoupon.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSaveCoupon.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnSaveCoupon.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSaveCoupon.selected = false;
            this.btnSaveCoupon.Size = new System.Drawing.Size(116, 93);
            this.btnSaveCoupon.TabIndex = 9;
            this.btnSaveCoupon.Text = "Save";
            this.btnSaveCoupon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSaveCoupon.Textcolor = System.Drawing.Color.White;
            this.btnSaveCoupon.TextFont = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.btnSaveCoupon.Click += new System.EventHandler(this.btnSingleGenerate_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Expiry Date";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Issue Date";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label41.ForeColor = System.Drawing.Color.White;
            this.label41.Location = new System.Drawing.Point(12, 12);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(151, 17);
            this.label41.TabIndex = 0;
            this.label41.Text = "Generate Single Coupon";
            // 
            // singleExpiryDate
            // 
            this.singleExpiryDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.singleExpiryDate.BackColor = System.Drawing.Color.Teal;
            this.singleExpiryDate.BorderRadius = 0;
            this.singleExpiryDate.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.singleExpiryDate.ForeColor = System.Drawing.Color.White;
            this.singleExpiryDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.singleExpiryDate.FormatCustom = null;
            this.singleExpiryDate.Location = new System.Drawing.Point(15, 254);
            this.singleExpiryDate.Name = "singleExpiryDate";
            this.singleExpiryDate.Size = new System.Drawing.Size(296, 36);
            this.singleExpiryDate.TabIndex = 8;
            this.singleExpiryDate.Value = new System.DateTime(2020, 10, 29, 0, 28, 21, 207);
            this.singleExpiryDate.onValueChanged += new System.EventHandler(this.singleExpiryDate_onValueChanged);
            // 
            // singleStartDate
            // 
            this.singleStartDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.singleStartDate.BackColor = System.Drawing.Color.Teal;
            this.singleStartDate.BorderRadius = 0;
            this.singleStartDate.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.singleStartDate.ForeColor = System.Drawing.Color.White;
            this.singleStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.singleStartDate.FormatCustom = null;
            this.singleStartDate.Location = new System.Drawing.Point(15, 197);
            this.singleStartDate.Name = "singleStartDate";
            this.singleStartDate.Size = new System.Drawing.Size(296, 36);
            this.singleStartDate.TabIndex = 6;
            this.singleStartDate.Value = new System.DateTime(2020, 10, 29, 0, 28, 21, 207);
            this.singleStartDate.onValueChanged += new System.EventHandler(this.singleStartDate_onValueChanged);
            // 
            // txtCouponCode
            // 
            this.txtCouponCode.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCouponCode.Location = new System.Drawing.Point(15, 36);
            this.txtCouponCode.Name = "txtCouponCode";
            this.txtCouponCode.ReadOnly = true;
            this.txtCouponCode.Size = new System.Drawing.Size(218, 27);
            this.txtCouponCode.TabIndex = 2;
            this.txtCouponCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 61);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(905, 306);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lblNoCoupons
            // 
            this.lblNoCoupons.AutoSize = true;
            this.lblNoCoupons.BackColor = System.Drawing.Color.Transparent;
            this.lblNoCoupons.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoCoupons.ForeColor = System.Drawing.Color.Gray;
            this.lblNoCoupons.Location = new System.Drawing.Point(368, 524);
            this.lblNoCoupons.Name = "lblNoCoupons";
            this.lblNoCoupons.Size = new System.Drawing.Size(193, 29);
            this.lblNoCoupons.TabIndex = 34;
            this.lblNoCoupons.Text = "No Coupons Added";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.lblWarning, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnDeleteCoupon, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnUpdateCoupon, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 693);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(905, 44);
            this.tableLayoutPanel2.TabIndex = 35;
            // 
            // lblWarning
            // 
            this.lblWarning.BackColor = System.Drawing.Color.Transparent;
            this.lblWarning.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblWarning.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarning.Location = new System.Drawing.Point(148, 12);
            this.lblWarning.Margin = new System.Windows.Forms.Padding(3, 12, 3, 0);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(609, 21);
            this.lblWarning.TabIndex = 37;
            this.lblWarning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblWarning.Visible = false;
            // 
            // btnDeleteCoupon
            // 
            this.btnDeleteCoupon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDeleteCoupon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteCoupon.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDeleteCoupon.Enabled = false;
            this.btnDeleteCoupon.FlatAppearance.BorderSize = 0;
            this.btnDeleteCoupon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteCoupon.ForeColor = System.Drawing.Color.White;
            this.btnDeleteCoupon.Location = new System.Drawing.Point(3, 3);
            this.btnDeleteCoupon.Name = "btnDeleteCoupon";
            this.btnDeleteCoupon.Size = new System.Drawing.Size(139, 38);
            this.btnDeleteCoupon.TabIndex = 35;
            this.btnDeleteCoupon.Text = "Delete Coupon";
            this.btnDeleteCoupon.UseVisualStyleBackColor = false;
            this.btnDeleteCoupon.Click += new System.EventHandler(this.btnDeleteCoupon_Click);
            // 
            // btnUpdateCoupon
            // 
            this.btnUpdateCoupon.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnUpdateCoupon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateCoupon.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnUpdateCoupon.Enabled = false;
            this.btnUpdateCoupon.FlatAppearance.BorderSize = 0;
            this.btnUpdateCoupon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateCoupon.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCoupon.ForeColor = System.Drawing.Color.White;
            this.btnUpdateCoupon.Location = new System.Drawing.Point(763, 3);
            this.btnUpdateCoupon.Name = "btnUpdateCoupon";
            this.btnUpdateCoupon.Size = new System.Drawing.Size(139, 38);
            this.btnUpdateCoupon.TabIndex = 36;
            this.btnUpdateCoupon.Text = "Update Coupon";
            this.btnUpdateCoupon.UseVisualStyleBackColor = false;
            this.btnUpdateCoupon.Visible = false;
            // 
            // Coupons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(929, 747);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.couponGridView);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.lblNoCoupons);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Coupons";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Generate Coupons";
            ((System.ComponentModel.ISupportInitialize)(this.couponGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNoOfCoupons)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid couponGridView;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private System.Windows.Forms.ImageList imagesList;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtBulkDescription;
        private System.Windows.Forms.NumericUpDown numNoOfCoupons;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBulkPercentDiscount;
        private System.Windows.Forms.RadioButton rdoBulkDPercentage;
        private System.Windows.Forms.TextBox txtBulkFlatDiscount;
        private System.Windows.Forms.RadioButton rdoBulkPDiscount;
        private Bunifu.Framework.UI.BunifuFlatButton btnBulkGenerate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuDatepicker bulkStartDate;
        private Bunifu.Framework.UI.BunifuDatepicker bulkExpiryDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSingleDescription;
        private System.Windows.Forms.TextBox txtSinglePercentDiscount;
        private System.Windows.Forms.TextBox txtSingleFlatDiscount;
        private System.Windows.Forms.RadioButton rdoSingleDPercentage;
        private System.Windows.Forms.RadioButton rdoSinglePDiscount;
        private Bunifu.Framework.UI.BunifuFlatButton btnGenerateCoupon;
        private Bunifu.Framework.UI.BunifuFlatButton btnSaveCoupon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label41;
        private Bunifu.Framework.UI.BunifuDatepicker singleExpiryDate;
        private Bunifu.Framework.UI.BunifuDatepicker singleStartDate;
        private System.Windows.Forms.TextBox txtCouponCode;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblNoCoupons;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnDeleteCoupon;
        private System.Windows.Forms.Button btnUpdateCoupon;
        private System.Windows.Forms.Label lblWarning;
    }
}