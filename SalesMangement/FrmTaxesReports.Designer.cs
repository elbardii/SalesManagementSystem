namespace SalesMangement
{
    partial class FrmTaxesReports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTaxesReports));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSearsh = new MaterialSkin.Controls.MaterialButton();
            this.DateToRut = new System.Windows.Forms.DateTimePicker();
            this.lblTo = new MaterialSkin.Controls.MaterialLabel();
            this.DateFromRut = new System.Windows.Forms.DateTimePicker();
            this.lblFrom = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CheckboxBuyReturnsIn = new MaterialSkin.Controls.MaterialCheckbox();
            this.CheckboxSalesReturnsIn = new MaterialSkin.Controls.MaterialCheckbox();
            this.CheckboxPurchaseInvoices = new MaterialSkin.Controls.MaterialCheckbox();
            this.CheckboxSalesInvoices = new MaterialSkin.Controls.MaterialCheckbox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DgvTaxesReport = new System.Windows.Forms.DataGridView();
            this.txtTotalInvoice = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.lblTotal = new MaterialSkin.Controls.MaterialLabel();
            this.btnDeleteAll = new MaterialSkin.Controls.MaterialButton();
            this.btnPrintAll = new MaterialSkin.Controls.MaterialButton();
            this.txtTotalTax = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtTotalAfterTax = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTaxesReport)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSearsh);
            this.groupBox3.Controls.Add(this.DateToRut);
            this.groupBox3.Controls.Add(this.lblTo);
            this.groupBox3.Controls.Add(this.DateFromRut);
            this.groupBox3.Controls.Add(this.lblFrom);
            this.groupBox3.Location = new System.Drawing.Point(718, 76);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(446, 72);
            this.groupBox3.TabIndex = 66;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Interval Filters";
            // 
            // btnSearsh
            // 
            this.btnSearsh.AutoSize = false;
            this.btnSearsh.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSearsh.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSearsh.Depth = 0;
            this.btnSearsh.HighEmphasis = true;
            this.btnSearsh.Icon = ((System.Drawing.Image)(resources.GetObject("btnSearsh.Icon")));
            this.btnSearsh.Location = new System.Drawing.Point(336, 22);
            this.btnSearsh.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSearsh.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSearsh.Name = "btnSearsh";
            this.btnSearsh.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSearsh.Size = new System.Drawing.Size(100, 37);
            this.btnSearsh.TabIndex = 40;
            this.btnSearsh.Text = "Searsh";
            this.btnSearsh.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSearsh.UseAccentColor = false;
            this.btnSearsh.UseVisualStyleBackColor = true;
            this.btnSearsh.Click += new System.EventHandler(this.btnSearsh_Click);
            // 
            // DateToRut
            // 
            this.DateToRut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateToRut.Location = new System.Drawing.Point(220, 30);
            this.DateToRut.Name = "DateToRut";
            this.DateToRut.Size = new System.Drawing.Size(110, 22);
            this.DateToRut.TabIndex = 22;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Depth = 0;
            this.lblTo.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTo.Location = new System.Drawing.Point(191, 32);
            this.lblTo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(28, 19);
            this.lblTo.TabIndex = 21;
            this.lblTo.Text = "To :";
            // 
            // DateFromRut
            // 
            this.DateFromRut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateFromRut.Location = new System.Drawing.Point(70, 32);
            this.DateFromRut.Name = "DateFromRut";
            this.DateFromRut.Size = new System.Drawing.Size(113, 22);
            this.DateFromRut.TabIndex = 20;
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Depth = 0;
            this.lblFrom.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblFrom.Location = new System.Drawing.Point(13, 34);
            this.lblFrom.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(46, 19);
            this.lblFrom.TabIndex = 19;
            this.lblFrom.Text = "From :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CheckboxBuyReturnsIn);
            this.groupBox2.Controls.Add(this.CheckboxSalesReturnsIn);
            this.groupBox2.Controls.Add(this.CheckboxPurchaseInvoices);
            this.groupBox2.Controls.Add(this.CheckboxSalesInvoices);
            this.groupBox2.Location = new System.Drawing.Point(10, 76);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(702, 72);
            this.groupBox2.TabIndex = 65;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search Filters";
            // 
            // CheckboxBuyReturnsIn
            // 
            this.CheckboxBuyReturnsIn.AutoSize = true;
            this.CheckboxBuyReturnsIn.Depth = 0;
            this.CheckboxBuyReturnsIn.Location = new System.Drawing.Point(510, 23);
            this.CheckboxBuyReturnsIn.Margin = new System.Windows.Forms.Padding(0);
            this.CheckboxBuyReturnsIn.MouseLocation = new System.Drawing.Point(-1, -1);
            this.CheckboxBuyReturnsIn.MouseState = MaterialSkin.MouseState.HOVER;
            this.CheckboxBuyReturnsIn.Name = "CheckboxBuyReturnsIn";
            this.CheckboxBuyReturnsIn.ReadOnly = false;
            this.CheckboxBuyReturnsIn.Ripple = true;
            this.CheckboxBuyReturnsIn.Size = new System.Drawing.Size(182, 37);
            this.CheckboxBuyReturnsIn.TabIndex = 3;
            this.CheckboxBuyReturnsIn.Text = "Buy Returns invoices";
            this.CheckboxBuyReturnsIn.UseVisualStyleBackColor = true;
            // 
            // CheckboxSalesReturnsIn
            // 
            this.CheckboxSalesReturnsIn.AutoSize = true;
            this.CheckboxSalesReturnsIn.Depth = 0;
            this.CheckboxSalesReturnsIn.Location = new System.Drawing.Point(310, 23);
            this.CheckboxSalesReturnsIn.Margin = new System.Windows.Forms.Padding(0);
            this.CheckboxSalesReturnsIn.MouseLocation = new System.Drawing.Point(-1, -1);
            this.CheckboxSalesReturnsIn.MouseState = MaterialSkin.MouseState.HOVER;
            this.CheckboxSalesReturnsIn.Name = "CheckboxSalesReturnsIn";
            this.CheckboxSalesReturnsIn.ReadOnly = false;
            this.CheckboxSalesReturnsIn.Ripple = true;
            this.CheckboxSalesReturnsIn.Size = new System.Drawing.Size(194, 37);
            this.CheckboxSalesReturnsIn.TabIndex = 2;
            this.CheckboxSalesReturnsIn.Text = "Sales Returns invoices";
            this.CheckboxSalesReturnsIn.UseVisualStyleBackColor = true;
            // 
            // CheckboxPurchaseInvoices
            // 
            this.CheckboxPurchaseInvoices.AutoSize = true;
            this.CheckboxPurchaseInvoices.Depth = 0;
            this.CheckboxPurchaseInvoices.Location = new System.Drawing.Point(144, 23);
            this.CheckboxPurchaseInvoices.Margin = new System.Windows.Forms.Padding(0);
            this.CheckboxPurchaseInvoices.MouseLocation = new System.Drawing.Point(-1, -1);
            this.CheckboxPurchaseInvoices.MouseState = MaterialSkin.MouseState.HOVER;
            this.CheckboxPurchaseInvoices.Name = "CheckboxPurchaseInvoices";
            this.CheckboxPurchaseInvoices.ReadOnly = false;
            this.CheckboxPurchaseInvoices.Ripple = true;
            this.CheckboxPurchaseInvoices.Size = new System.Drawing.Size(163, 37);
            this.CheckboxPurchaseInvoices.TabIndex = 1;
            this.CheckboxPurchaseInvoices.Text = "Purchase Invoices";
            this.CheckboxPurchaseInvoices.UseVisualStyleBackColor = true;
            // 
            // CheckboxSalesInvoices
            // 
            this.CheckboxSalesInvoices.AutoSize = true;
            this.CheckboxSalesInvoices.Checked = true;
            this.CheckboxSalesInvoices.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckboxSalesInvoices.Depth = 0;
            this.CheckboxSalesInvoices.Location = new System.Drawing.Point(6, 23);
            this.CheckboxSalesInvoices.Margin = new System.Windows.Forms.Padding(0);
            this.CheckboxSalesInvoices.MouseLocation = new System.Drawing.Point(-1, -1);
            this.CheckboxSalesInvoices.MouseState = MaterialSkin.MouseState.HOVER;
            this.CheckboxSalesInvoices.Name = "CheckboxSalesInvoices";
            this.CheckboxSalesInvoices.ReadOnly = false;
            this.CheckboxSalesInvoices.Ripple = true;
            this.CheckboxSalesInvoices.Size = new System.Drawing.Size(136, 37);
            this.CheckboxSalesInvoices.TabIndex = 0;
            this.CheckboxSalesInvoices.Text = "Sales Invoices";
            this.CheckboxSalesInvoices.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DgvTaxesReport);
            this.groupBox1.Location = new System.Drawing.Point(6, 158);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1160, 414);
            this.groupBox1.TabIndex = 64;
            this.groupBox1.TabStop = false;
            // 
            // DgvTaxesReport
            // 
            this.DgvTaxesReport.AllowUserToAddRows = false;
            this.DgvTaxesReport.AllowUserToDeleteRows = false;
            this.DgvTaxesReport.AllowUserToResizeColumns = false;
            this.DgvTaxesReport.AllowUserToResizeRows = false;
            this.DgvTaxesReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgvTaxesReport.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvTaxesReport.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.DgvTaxesReport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvTaxesReport.ColumnHeadersHeight = 29;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(158)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvTaxesReport.DefaultCellStyle = dataGridViewCellStyle1;
            this.DgvTaxesReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvTaxesReport.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DgvTaxesReport.Location = new System.Drawing.Point(3, 18);
            this.DgvTaxesReport.Name = "DgvTaxesReport";
            this.DgvTaxesReport.ReadOnly = true;
            this.DgvTaxesReport.RowHeadersWidth = 51;
            this.DgvTaxesReport.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DgvTaxesReport.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.DgvTaxesReport.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(158)))), ((int)(((byte)(128)))));
            this.DgvTaxesReport.RowTemplate.Height = 24;
            this.DgvTaxesReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvTaxesReport.Size = new System.Drawing.Size(1154, 393);
            this.DgvTaxesReport.TabIndex = 1;
            // 
            // txtTotalInvoice
            // 
            this.txtTotalInvoice.AnimateReadOnly = false;
            this.txtTotalInvoice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtTotalInvoice.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTotalInvoice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalInvoice.Depth = 0;
            this.txtTotalInvoice.HideSelection = true;
            this.txtTotalInvoice.Location = new System.Drawing.Point(7, 596);
            this.txtTotalInvoice.MaxLength = 32767;
            this.txtTotalInvoice.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTotalInvoice.Name = "txtTotalInvoice";
            this.txtTotalInvoice.PasswordChar = '\0';
            this.txtTotalInvoice.ReadOnly = true;
            this.txtTotalInvoice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTotalInvoice.SelectedText = "";
            this.txtTotalInvoice.SelectionLength = 0;
            this.txtTotalInvoice.SelectionStart = 0;
            this.txtTotalInvoice.ShortcutsEnabled = true;
            this.txtTotalInvoice.Size = new System.Drawing.Size(126, 37);
            this.txtTotalInvoice.TabIndex = 71;
            this.txtTotalInvoice.TabStop = false;
            this.txtTotalInvoice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTotalInvoice.UseSystemPasswordChar = false;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Depth = 0;
            this.lblTotal.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTotal.Location = new System.Drawing.Point(10, 574);
            this.lblTotal.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(96, 19);
            this.lblTotal.TabIndex = 70;
            this.lblTotal.Text = "Total Invoice:";
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.AutoSize = false;
            this.btnDeleteAll.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeleteAll.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDeleteAll.Depth = 0;
            this.btnDeleteAll.HighEmphasis = true;
            this.btnDeleteAll.Icon = ((System.Drawing.Image)(resources.GetObject("btnDeleteAll.Icon")));
            this.btnDeleteAll.Location = new System.Drawing.Point(982, 588);
            this.btnDeleteAll.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDeleteAll.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDeleteAll.Size = new System.Drawing.Size(181, 37);
            this.btnDeleteAll.TabIndex = 69;
            this.btnDeleteAll.Text = "Delete ";
            this.btnDeleteAll.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDeleteAll.UseAccentColor = true;
            this.btnDeleteAll.UseVisualStyleBackColor = false;
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // btnPrintAll
            // 
            this.btnPrintAll.AutoSize = false;
            this.btnPrintAll.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPrintAll.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnPrintAll.Depth = 0;
            this.btnPrintAll.HighEmphasis = true;
            this.btnPrintAll.Icon = ((System.Drawing.Image)(resources.GetObject("btnPrintAll.Icon")));
            this.btnPrintAll.Location = new System.Drawing.Point(788, 588);
            this.btnPrintAll.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPrintAll.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPrintAll.Name = "btnPrintAll";
            this.btnPrintAll.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnPrintAll.Size = new System.Drawing.Size(181, 37);
            this.btnPrintAll.TabIndex = 73;
            this.btnPrintAll.Text = "Print all invoices";
            this.btnPrintAll.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnPrintAll.UseAccentColor = false;
            this.btnPrintAll.UseVisualStyleBackColor = true;
            this.btnPrintAll.Click += new System.EventHandler(this.btnPrintAll_Click);
            // 
            // txtTotalTax
            // 
            this.txtTotalTax.AnimateReadOnly = false;
            this.txtTotalTax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtTotalTax.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTotalTax.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalTax.Depth = 0;
            this.txtTotalTax.HideSelection = true;
            this.txtTotalTax.Location = new System.Drawing.Point(172, 596);
            this.txtTotalTax.MaxLength = 32767;
            this.txtTotalTax.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTotalTax.Name = "txtTotalTax";
            this.txtTotalTax.PasswordChar = '\0';
            this.txtTotalTax.ReadOnly = true;
            this.txtTotalTax.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTotalTax.SelectedText = "";
            this.txtTotalTax.SelectionLength = 0;
            this.txtTotalTax.SelectionStart = 0;
            this.txtTotalTax.ShortcutsEnabled = true;
            this.txtTotalTax.Size = new System.Drawing.Size(126, 37);
            this.txtTotalTax.TabIndex = 75;
            this.txtTotalTax.TabStop = false;
            this.txtTotalTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTotalTax.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(175, 574);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(73, 19);
            this.materialLabel1.TabIndex = 74;
            this.materialLabel1.Text = "Total Tax:";
            // 
            // txtTotalAfterTax
            // 
            this.txtTotalAfterTax.AnimateReadOnly = false;
            this.txtTotalAfterTax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtTotalAfterTax.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTotalAfterTax.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalAfterTax.Depth = 0;
            this.txtTotalAfterTax.HideSelection = true;
            this.txtTotalAfterTax.Location = new System.Drawing.Point(350, 597);
            this.txtTotalAfterTax.MaxLength = 32767;
            this.txtTotalAfterTax.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTotalAfterTax.Name = "txtTotalAfterTax";
            this.txtTotalAfterTax.PasswordChar = '\0';
            this.txtTotalAfterTax.ReadOnly = true;
            this.txtTotalAfterTax.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTotalAfterTax.SelectedText = "";
            this.txtTotalAfterTax.SelectionLength = 0;
            this.txtTotalAfterTax.SelectionStart = 0;
            this.txtTotalAfterTax.ShortcutsEnabled = true;
            this.txtTotalAfterTax.Size = new System.Drawing.Size(126, 37);
            this.txtTotalAfterTax.TabIndex = 77;
            this.txtTotalAfterTax.TabStop = false;
            this.txtTotalAfterTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTotalAfterTax.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(353, 575);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(111, 19);
            this.materialLabel2.TabIndex = 76;
            this.materialLabel2.Text = "Total After Tax:";
            // 
            // FrmTaxesReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 634);
            this.Controls.Add(this.txtTotalAfterTax);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.txtTotalTax);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.btnPrintAll);
            this.Controls.Add(this.txtTotalInvoice);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnDeleteAll);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "FrmTaxesReports";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Taxes Reports";
            this.Load += new System.EventHandler(this.FrmTaxesReports_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvTaxesReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private MaterialSkin.Controls.MaterialButton btnSearsh;
        private System.Windows.Forms.DateTimePicker DateToRut;
        private MaterialSkin.Controls.MaterialLabel lblTo;
        private System.Windows.Forms.DateTimePicker DateFromRut;
        private MaterialSkin.Controls.MaterialLabel lblFrom;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DgvTaxesReport;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtTotalInvoice;
        private MaterialSkin.Controls.MaterialLabel lblTotal;
        private MaterialSkin.Controls.MaterialButton btnDeleteAll;
        private MaterialSkin.Controls.MaterialButton btnPrintAll;
        private MaterialSkin.Controls.MaterialCheckbox CheckboxBuyReturnsIn;
        private MaterialSkin.Controls.MaterialCheckbox CheckboxSalesReturnsIn;
        private MaterialSkin.Controls.MaterialCheckbox CheckboxPurchaseInvoices;
        private MaterialSkin.Controls.MaterialCheckbox CheckboxSalesInvoices;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtTotalTax;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtTotalAfterTax;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
    }
}