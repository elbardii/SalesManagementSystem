namespace SalesMangement
{
    partial class FrmShowProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmShowProducts));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearshBarcode = new MaterialSkin.Controls.MaterialButton();
            this.btnSearshProName = new MaterialSkin.Controls.MaterialButton();
            this.btnSearshCategory = new MaterialSkin.Controls.MaterialButton();
            this.txtNamePro = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.txtBarcode = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.cbxCategory = new MaterialSkin.Controls.MaterialComboBox();
            this.DgvShowPro = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTotalWholesale = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtTotalQuantity = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.lblTotal = new MaterialSkin.Controls.MaterialLabel();
            this.txtTotalSaleTax = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtTotalRetail = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvShowPro)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearshBarcode);
            this.groupBox1.Controls.Add(this.btnSearshProName);
            this.groupBox1.Controls.Add(this.btnSearshCategory);
            this.groupBox1.Controls.Add(this.txtNamePro);
            this.groupBox1.Controls.Add(this.txtBarcode);
            this.groupBox1.Controls.Add(this.cbxCategory);
            this.groupBox1.Location = new System.Drawing.Point(6, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1157, 82);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // btnSearshBarcode
            // 
            this.btnSearshBarcode.AutoSize = false;
            this.btnSearshBarcode.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSearshBarcode.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSearshBarcode.Depth = 0;
            this.btnSearshBarcode.HighEmphasis = true;
            this.btnSearshBarcode.Icon = ((System.Drawing.Image)(resources.GetObject("btnSearshBarcode.Icon")));
            this.btnSearshBarcode.Location = new System.Drawing.Point(1103, 23);
            this.btnSearshBarcode.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSearshBarcode.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSearshBarcode.Name = "btnSearshBarcode";
            this.btnSearshBarcode.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSearshBarcode.Size = new System.Drawing.Size(41, 45);
            this.btnSearshBarcode.TabIndex = 53;
            this.btnSearshBarcode.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSearshBarcode.UseAccentColor = false;
            this.btnSearshBarcode.UseVisualStyleBackColor = true;
            this.btnSearshBarcode.Click += new System.EventHandler(this.btnSearshBarcode_Click);
            // 
            // btnSearshProName
            // 
            this.btnSearshProName.AutoSize = false;
            this.btnSearshProName.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSearshProName.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSearshProName.Depth = 0;
            this.btnSearshProName.HighEmphasis = true;
            this.btnSearshProName.Icon = ((System.Drawing.Image)(resources.GetObject("btnSearshProName.Icon")));
            this.btnSearshProName.Location = new System.Drawing.Point(692, 23);
            this.btnSearshProName.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSearshProName.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSearshProName.Name = "btnSearshProName";
            this.btnSearshProName.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSearshProName.Size = new System.Drawing.Size(41, 45);
            this.btnSearshProName.TabIndex = 52;
            this.btnSearshProName.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSearshProName.UseAccentColor = false;
            this.btnSearshProName.UseVisualStyleBackColor = true;
            this.btnSearshProName.Click += new System.EventHandler(this.btnSearshProName_Click);
            // 
            // btnSearshCategory
            // 
            this.btnSearshCategory.AutoSize = false;
            this.btnSearshCategory.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSearshCategory.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSearshCategory.Depth = 0;
            this.btnSearshCategory.HighEmphasis = true;
            this.btnSearshCategory.Icon = ((System.Drawing.Image)(resources.GetObject("btnSearshCategory.Icon")));
            this.btnSearshCategory.Location = new System.Drawing.Point(274, 23);
            this.btnSearshCategory.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSearshCategory.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSearshCategory.Name = "btnSearshCategory";
            this.btnSearshCategory.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSearshCategory.Size = new System.Drawing.Size(41, 45);
            this.btnSearshCategory.TabIndex = 51;
            this.btnSearshCategory.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSearshCategory.UseAccentColor = false;
            this.btnSearshCategory.UseVisualStyleBackColor = true;
            this.btnSearshCategory.Click += new System.EventHandler(this.btnSearshCategory_Click);
            // 
            // txtNamePro
            // 
            this.txtNamePro.AllowPromptAsInput = true;
            this.txtNamePro.AnimateReadOnly = false;
            this.txtNamePro.AsciiOnly = false;
            this.txtNamePro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtNamePro.BeepOnError = false;
            this.txtNamePro.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtNamePro.Depth = 0;
            this.txtNamePro.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNamePro.HidePromptOnLeave = false;
            this.txtNamePro.HideSelection = true;
            this.txtNamePro.Hint = "Product  Name";
            this.txtNamePro.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtNamePro.LeadingIcon = ((System.Drawing.Image)(resources.GetObject("txtNamePro.LeadingIcon")));
            this.txtNamePro.Location = new System.Drawing.Point(434, 21);
            this.txtNamePro.Mask = "";
            this.txtNamePro.MaxLength = 32767;
            this.txtNamePro.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNamePro.Name = "txtNamePro";
            this.txtNamePro.PasswordChar = '\0';
            this.txtNamePro.PrefixSuffixText = null;
            this.txtNamePro.PromptChar = '_';
            this.txtNamePro.ReadOnly = false;
            this.txtNamePro.RejectInputOnFirstFailure = false;
            this.txtNamePro.ResetOnPrompt = true;
            this.txtNamePro.ResetOnSpace = true;
            this.txtNamePro.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNamePro.SelectedText = "";
            this.txtNamePro.SelectionLength = 0;
            this.txtNamePro.SelectionStart = 0;
            this.txtNamePro.ShortcutsEnabled = true;
            this.txtNamePro.Size = new System.Drawing.Size(250, 48);
            this.txtNamePro.SkipLiterals = true;
            this.txtNamePro.TabIndex = 49;
            this.txtNamePro.TabStop = false;
            this.txtNamePro.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNamePro.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtNamePro.TrailingIcon = null;
            this.txtNamePro.UseSystemPasswordChar = false;
            this.txtNamePro.ValidatingType = null;
            // 
            // txtBarcode
            // 
            this.txtBarcode.AllowPromptAsInput = true;
            this.txtBarcode.AnimateReadOnly = false;
            this.txtBarcode.AsciiOnly = false;
            this.txtBarcode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtBarcode.BeepOnError = false;
            this.txtBarcode.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtBarcode.Depth = 0;
            this.txtBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBarcode.HidePromptOnLeave = false;
            this.txtBarcode.HideSelection = true;
            this.txtBarcode.Hint = "Barcode  ";
            this.txtBarcode.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtBarcode.LeadingIcon = ((System.Drawing.Image)(resources.GetObject("txtBarcode.LeadingIcon")));
            this.txtBarcode.Location = new System.Drawing.Point(847, 21);
            this.txtBarcode.Mask = "";
            this.txtBarcode.MaxLength = 32767;
            this.txtBarcode.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.PasswordChar = '\0';
            this.txtBarcode.PrefixSuffixText = null;
            this.txtBarcode.PromptChar = '_';
            this.txtBarcode.ReadOnly = false;
            this.txtBarcode.RejectInputOnFirstFailure = false;
            this.txtBarcode.ResetOnPrompt = true;
            this.txtBarcode.ResetOnSpace = true;
            this.txtBarcode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBarcode.SelectedText = "";
            this.txtBarcode.SelectionLength = 0;
            this.txtBarcode.SelectionStart = 0;
            this.txtBarcode.ShortcutsEnabled = true;
            this.txtBarcode.Size = new System.Drawing.Size(250, 48);
            this.txtBarcode.SkipLiterals = true;
            this.txtBarcode.TabIndex = 50;
            this.txtBarcode.TabStop = false;
            this.txtBarcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBarcode.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtBarcode.TrailingIcon = null;
            this.txtBarcode.UseSystemPasswordChar = false;
            this.txtBarcode.ValidatingType = null;
            // 
            // cbxCategory
            // 
            this.cbxCategory.AutoResize = false;
            this.cbxCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbxCategory.Depth = 0;
            this.cbxCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbxCategory.DropDownHeight = 174;
            this.cbxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategory.DropDownWidth = 121;
            this.cbxCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbxCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Hint = "Category";
            this.cbxCategory.IntegralHeight = false;
            this.cbxCategory.ItemHeight = 43;
            this.cbxCategory.Location = new System.Drawing.Point(16, 21);
            this.cbxCategory.MaxDropDownItems = 4;
            this.cbxCategory.MouseState = MaterialSkin.MouseState.OUT;
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(250, 49);
            this.cbxCategory.StartIndex = 0;
            this.cbxCategory.TabIndex = 47;
            // 
            // DgvShowPro
            // 
            this.DgvShowPro.AllowUserToAddRows = false;
            this.DgvShowPro.AllowUserToDeleteRows = false;
            this.DgvShowPro.AllowUserToResizeColumns = false;
            this.DgvShowPro.AllowUserToResizeRows = false;
            this.DgvShowPro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvShowPro.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvShowPro.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.DgvShowPro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvShowPro.ColumnHeadersHeight = 29;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(158)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvShowPro.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvShowPro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvShowPro.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DgvShowPro.Location = new System.Drawing.Point(3, 18);
            this.DgvShowPro.Name = "DgvShowPro";
            this.DgvShowPro.ReadOnly = true;
            this.DgvShowPro.RowHeadersWidth = 51;
            this.DgvShowPro.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DgvShowPro.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.DgvShowPro.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(158)))), ((int)(((byte)(128)))));
            this.DgvShowPro.RowTemplate.Height = 24;
            this.DgvShowPro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvShowPro.Size = new System.Drawing.Size(1154, 382);
            this.DgvShowPro.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DgvShowPro);
            this.groupBox2.Location = new System.Drawing.Point(6, 155);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1160, 403);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Products Data";
            // 
            // txtTotalWholesale
            // 
            this.txtTotalWholesale.AnimateReadOnly = false;
            this.txtTotalWholesale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtTotalWholesale.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTotalWholesale.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalWholesale.Depth = 0;
            this.txtTotalWholesale.Enabled = false;
            this.txtTotalWholesale.HideSelection = true;
            this.txtTotalWholesale.Location = new System.Drawing.Point(415, 26);
            this.txtTotalWholesale.MaxLength = 32767;
            this.txtTotalWholesale.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTotalWholesale.Name = "txtTotalWholesale";
            this.txtTotalWholesale.PasswordChar = '\0';
            this.txtTotalWholesale.ReadOnly = true;
            this.txtTotalWholesale.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTotalWholesale.SelectedText = "";
            this.txtTotalWholesale.SelectionLength = 0;
            this.txtTotalWholesale.SelectionStart = 0;
            this.txtTotalWholesale.ShortcutsEnabled = true;
            this.txtTotalWholesale.Size = new System.Drawing.Size(150, 40);
            this.txtTotalWholesale.TabIndex = 74;
            this.txtTotalWholesale.TabStop = false;
            this.txtTotalWholesale.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTotalWholesale.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(282, 42);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(127, 19);
            this.materialLabel1.TabIndex = 73;
            this.materialLabel1.Text = "Total Wholesale : ";
            // 
            // txtTotalQuantity
            // 
            this.txtTotalQuantity.AnimateReadOnly = false;
            this.txtTotalQuantity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtTotalQuantity.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTotalQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalQuantity.Depth = 0;
            this.txtTotalQuantity.Enabled = false;
            this.txtTotalQuantity.HideSelection = true;
            this.txtTotalQuantity.Location = new System.Drawing.Point(122, 26);
            this.txtTotalQuantity.MaxLength = 32767;
            this.txtTotalQuantity.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTotalQuantity.Name = "txtTotalQuantity";
            this.txtTotalQuantity.PasswordChar = '\0';
            this.txtTotalQuantity.ReadOnly = true;
            this.txtTotalQuantity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTotalQuantity.SelectedText = "";
            this.txtTotalQuantity.SelectionLength = 0;
            this.txtTotalQuantity.SelectionStart = 0;
            this.txtTotalQuantity.ShortcutsEnabled = true;
            this.txtTotalQuantity.Size = new System.Drawing.Size(150, 40);
            this.txtTotalQuantity.TabIndex = 72;
            this.txtTotalQuantity.TabStop = false;
            this.txtTotalQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTotalQuantity.UseSystemPasswordChar = false;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Depth = 0;
            this.lblTotal.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTotal.Location = new System.Drawing.Point(8, 42);
            this.lblTotal.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(110, 19);
            this.lblTotal.TabIndex = 71;
            this.lblTotal.Text = "Total Quantity :";
            // 
            // txtTotalSaleTax
            // 
            this.txtTotalSaleTax.AnimateReadOnly = false;
            this.txtTotalSaleTax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtTotalSaleTax.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTotalSaleTax.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalSaleTax.Depth = 0;
            this.txtTotalSaleTax.Enabled = false;
            this.txtTotalSaleTax.HideSelection = true;
            this.txtTotalSaleTax.Location = new System.Drawing.Point(996, 26);
            this.txtTotalSaleTax.MaxLength = 32767;
            this.txtTotalSaleTax.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTotalSaleTax.Name = "txtTotalSaleTax";
            this.txtTotalSaleTax.PasswordChar = '\0';
            this.txtTotalSaleTax.ReadOnly = true;
            this.txtTotalSaleTax.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTotalSaleTax.SelectedText = "";
            this.txtTotalSaleTax.SelectionLength = 0;
            this.txtTotalSaleTax.SelectionStart = 0;
            this.txtTotalSaleTax.ShortcutsEnabled = true;
            this.txtTotalSaleTax.Size = new System.Drawing.Size(150, 40);
            this.txtTotalSaleTax.TabIndex = 78;
            this.txtTotalSaleTax.TabStop = false;
            this.txtTotalSaleTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTotalSaleTax.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(846, 42);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(142, 19);
            this.materialLabel2.TabIndex = 77;
            this.materialLabel2.Text = "Total sale after tax :";
            // 
            // txtTotalRetail
            // 
            this.txtTotalRetail.AnimateReadOnly = false;
            this.txtTotalRetail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtTotalRetail.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTotalRetail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalRetail.Depth = 0;
            this.txtTotalRetail.Enabled = false;
            this.txtTotalRetail.HideSelection = true;
            this.txtTotalRetail.Location = new System.Drawing.Point(685, 26);
            this.txtTotalRetail.MaxLength = 32767;
            this.txtTotalRetail.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTotalRetail.Name = "txtTotalRetail";
            this.txtTotalRetail.PasswordChar = '\0';
            this.txtTotalRetail.ReadOnly = true;
            this.txtTotalRetail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTotalRetail.SelectedText = "";
            this.txtTotalRetail.SelectionLength = 0;
            this.txtTotalRetail.SelectionStart = 0;
            this.txtTotalRetail.ShortcutsEnabled = true;
            this.txtTotalRetail.Size = new System.Drawing.Size(150, 40);
            this.txtTotalRetail.TabIndex = 76;
            this.txtTotalRetail.TabStop = false;
            this.txtTotalRetail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTotalRetail.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(589, 42);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(90, 19);
            this.materialLabel3.TabIndex = 75;
            this.materialLabel3.Text = "Total Retail :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtTotalQuantity);
            this.groupBox3.Controls.Add(this.txtTotalSaleTax);
            this.groupBox3.Controls.Add(this.lblTotal);
            this.groupBox3.Controls.Add(this.materialLabel2);
            this.groupBox3.Controls.Add(this.materialLabel1);
            this.groupBox3.Controls.Add(this.txtTotalRetail);
            this.groupBox3.Controls.Add(this.txtTotalWholesale);
            this.groupBox3.Controls.Add(this.materialLabel3);
            this.groupBox3.Location = new System.Drawing.Point(9, 556);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1154, 72);
            this.groupBox3.TabIndex = 79;
            this.groupBox3.TabStop = false;
            // 
            // FrmShowProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 634);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "FrmShowProducts";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Show Products";
            this.Load += new System.EventHandler(this.FrmShowProducts_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvShowPro)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialComboBox cbxCategory;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtNamePro;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtBarcode;
        private MaterialSkin.Controls.MaterialButton btnSearshBarcode;
        private MaterialSkin.Controls.MaterialButton btnSearshProName;
        private MaterialSkin.Controls.MaterialButton btnSearshCategory;
        private System.Windows.Forms.DataGridView DgvShowPro;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtTotalWholesale;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtTotalQuantity;
        private MaterialSkin.Controls.MaterialLabel lblTotal;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtTotalSaleTax;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtTotalRetail;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}