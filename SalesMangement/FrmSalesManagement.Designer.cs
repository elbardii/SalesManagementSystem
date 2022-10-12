namespace SalesMangement
{
    partial class FrmSalesManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSalesManagement));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtInvoiceId = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.txtBarcode = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.btnEdit = new MaterialSkin.Controls.MaterialButton();
            this.btnSaveIn = new MaterialSkin.Controls.MaterialButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LabelInfo = new MaterialSkin.Controls.MaterialLabel();
            this.lblItems = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblUserName = new MaterialSkin.Controls.MaterialLabel();
            this.lblTotalall = new MaterialSkin.Controls.MaterialLabel();
            this.txtTotalAll = new System.Windows.Forms.TextBox();
            this.btnRemove = new MaterialSkin.Controls.MaterialButton();
            this.DgvSales = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddCust = new MaterialSkin.Controls.MaterialButton();
            this.btnShow = new MaterialSkin.Controls.MaterialButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.rbtnDefePay = new MaterialSkin.Controls.MaterialRadioButton();
            this.lblduedate = new MaterialSkin.Controls.MaterialLabel();
            this.lblDate = new MaterialSkin.Controls.MaterialLabel();
            this.rbtnCash = new MaterialSkin.Controls.MaterialRadioButton();
            this.DtpdateDue = new System.Windows.Forms.DateTimePicker();
            this.DtpDate = new System.Windows.Forms.DateTimePicker();
            this.CbxItemsPro = new MaterialSkin.Controls.MaterialComboBox();
            this.CbxCustomer = new MaterialSkin.Controls.MaterialComboBox();
            this.txtCustomer = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSales)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtInvoiceId
            // 
            this.txtInvoiceId.AllowPromptAsInput = true;
            this.txtInvoiceId.AnimateReadOnly = false;
            this.txtInvoiceId.AsciiOnly = false;
            this.txtInvoiceId.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtInvoiceId.BeepOnError = false;
            this.txtInvoiceId.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtInvoiceId.Depth = 0;
            this.txtInvoiceId.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtInvoiceId.HidePromptOnLeave = false;
            this.txtInvoiceId.HideSelection = true;
            this.txtInvoiceId.Hint = "Invoice N°";
            this.txtInvoiceId.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtInvoiceId.LeadingIcon = null;
            this.txtInvoiceId.Location = new System.Drawing.Point(753, 137);
            this.txtInvoiceId.Mask = "";
            this.txtInvoiceId.MaxLength = 32767;
            this.txtInvoiceId.MouseState = MaterialSkin.MouseState.OUT;
            this.txtInvoiceId.Name = "txtInvoiceId";
            this.txtInvoiceId.PasswordChar = '\0';
            this.txtInvoiceId.PrefixSuffixText = null;
            this.txtInvoiceId.PromptChar = '_';
            this.txtInvoiceId.ReadOnly = false;
            this.txtInvoiceId.RejectInputOnFirstFailure = false;
            this.txtInvoiceId.ResetOnPrompt = true;
            this.txtInvoiceId.ResetOnSpace = true;
            this.txtInvoiceId.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtInvoiceId.SelectedText = "";
            this.txtInvoiceId.SelectionLength = 0;
            this.txtInvoiceId.SelectionStart = 0;
            this.txtInvoiceId.ShortcutsEnabled = true;
            this.txtInvoiceId.Size = new System.Drawing.Size(100, 48);
            this.txtInvoiceId.SkipLiterals = true;
            this.txtInvoiceId.TabIndex = 52;
            this.txtInvoiceId.TabStop = false;
            this.txtInvoiceId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtInvoiceId.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtInvoiceId.TrailingIcon = null;
            this.txtInvoiceId.UseSystemPasswordChar = false;
            this.txtInvoiceId.ValidatingType = null;
            this.txtInvoiceId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInvoiceId_KeyPress_1);
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
            this.txtBarcode.Hint = "Barcode ";
            this.txtBarcode.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtBarcode.LeadingIcon = null;
            this.txtBarcode.Location = new System.Drawing.Point(601, 137);
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
            this.txtBarcode.Size = new System.Drawing.Size(146, 48);
            this.txtBarcode.SkipLiterals = true;
            this.txtBarcode.TabIndex = 53;
            this.txtBarcode.TabStop = false;
            this.txtBarcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBarcode.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtBarcode.TrailingIcon = null;
            this.txtBarcode.UseSystemPasswordChar = false;
            this.txtBarcode.ValidatingType = null;
            this.txtBarcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBarcode_KeyPress_1);
            // 
            // btnEdit
            // 
            this.btnEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEdit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEdit.Depth = 0;
            this.btnEdit.HighEmphasis = true;
            this.btnEdit.Icon = ((System.Drawing.Image)(resources.GetObject("btnEdit.Icon")));
            this.btnEdit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnEdit.Location = new System.Drawing.Point(773, 558);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEdit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEdit.Size = new System.Drawing.Size(81, 36);
            this.btnEdit.TabIndex = 62;
            this.btnEdit.Text = "edit";
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEdit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEdit.UseAccentColor = false;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSaveIn
            // 
            this.btnSaveIn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSaveIn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSaveIn.Depth = 0;
            this.btnSaveIn.HighEmphasis = true;
            this.btnSaveIn.Icon = ((System.Drawing.Image)(resources.GetObject("btnSaveIn.Icon")));
            this.btnSaveIn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSaveIn.Location = new System.Drawing.Point(879, 558);
            this.btnSaveIn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSaveIn.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSaveIn.Name = "btnSaveIn";
            this.btnSaveIn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSaveIn.Size = new System.Drawing.Size(150, 36);
            this.btnSaveIn.TabIndex = 61;
            this.btnSaveIn.Text = "Save  invoice";
            this.btnSaveIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSaveIn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSaveIn.UseAccentColor = false;
            this.btnSaveIn.UseVisualStyleBackColor = false;
            this.btnSaveIn.Click += new System.EventHandler(this.btnSaveIn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LabelInfo);
            this.groupBox2.Controls.Add(this.lblItems);
            this.groupBox2.Controls.Add(this.materialLabel1);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.lblUserName);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(3, 594);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1166, 37);
            this.groupBox2.TabIndex = 60;
            this.groupBox2.TabStop = false;
            // 
            // LabelInfo
            // 
            this.LabelInfo.AutoSize = true;
            this.LabelInfo.Depth = 0;
            this.LabelInfo.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LabelInfo.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.LabelInfo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelInfo.Location = new System.Drawing.Point(1018, 12);
            this.LabelInfo.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelInfo.Name = "LabelInfo";
            this.LabelInfo.Size = new System.Drawing.Size(138, 19);
            this.LabelInfo.TabIndex = 48;
            this.LabelInfo.Text = "Save and print: F12";
            // 
            // lblItems
            // 
            this.lblItems.AutoSize = true;
            this.lblItems.Depth = 0;
            this.lblItems.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblItems.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblItems.Location = new System.Drawing.Point(219, 12);
            this.lblItems.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblItems.Name = "lblItems";
            this.lblItems.Size = new System.Drawing.Size(13, 19);
            this.lblItems.TabIndex = 47;
            this.lblItems.Text = "...";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.materialLabel1.Location = new System.Drawing.Point(165, 12);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(48, 19);
            this.materialLabel1.TabIndex = 46;
            this.materialLabel1.Text = "Items :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(6, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Depth = 0;
            this.lblUserName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblUserName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblUserName.Location = new System.Drawing.Point(42, 11);
            this.lblUserName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(74, 19);
            this.lblUserName.TabIndex = 45;
            this.lblUserName.Text = "UserName";
            // 
            // lblTotalall
            // 
            this.lblTotalall.AutoSize = true;
            this.lblTotalall.Depth = 0;
            this.lblTotalall.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTotalall.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTotalall.Location = new System.Drawing.Point(6, 568);
            this.lblTotalall.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTotalall.Name = "lblTotalall";
            this.lblTotalall.Size = new System.Drawing.Size(68, 19);
            this.lblTotalall.TabIndex = 59;
            this.lblTotalall.Text = "Total All :";
            // 
            // txtTotalAll
            // 
            this.txtTotalAll.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTotalAll.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalAll.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalAll.Enabled = false;
            this.txtTotalAll.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.txtTotalAll.ForeColor = System.Drawing.Color.White;
            this.txtTotalAll.Location = new System.Drawing.Point(89, 564);
            this.txtTotalAll.Multiline = true;
            this.txtTotalAll.Name = "txtTotalAll";
            this.txtTotalAll.ReadOnly = true;
            this.txtTotalAll.Size = new System.Drawing.Size(123, 26);
            this.txtTotalAll.TabIndex = 58;
            // 
            // btnRemove
            // 
            this.btnRemove.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRemove.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRemove.Depth = 0;
            this.btnRemove.HighEmphasis = true;
            this.btnRemove.Icon = ((System.Drawing.Image)(resources.GetObject("btnRemove.Icon")));
            this.btnRemove.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnRemove.Location = new System.Drawing.Point(1054, 558);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRemove.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRemove.Size = new System.Drawing.Size(108, 36);
            this.btnRemove.TabIndex = 57;
            this.btnRemove.Text = "Remove";
            this.btnRemove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRemove.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRemove.UseAccentColor = true;
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // DgvSales
            // 
            this.DgvSales.AllowUserToAddRows = false;
            this.DgvSales.AllowUserToDeleteRows = false;
            this.DgvSales.AllowUserToResizeColumns = false;
            this.DgvSales.AllowUserToResizeRows = false;
            this.DgvSales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvSales.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvSales.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.DgvSales.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvSales.ColumnHeadersHeight = 29;
            this.DgvSales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column7,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(158)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvSales.DefaultCellStyle = dataGridViewCellStyle1;
            this.DgvSales.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DgvSales.Location = new System.Drawing.Point(9, 190);
            this.DgvSales.Name = "DgvSales";
            this.DgvSales.ReadOnly = true;
            this.DgvSales.RowHeadersWidth = 51;
            this.DgvSales.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DgvSales.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.DgvSales.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(158)))), ((int)(((byte)(128)))));
            this.DgvSales.RowTemplate.Height = 24;
            this.DgvSales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvSales.Size = new System.Drawing.Size(1157, 359);
            this.DgvSales.TabIndex = 56;
            this.DgvSales.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvSales_CellValueChanged);
            // 
            // Column1
            // 
            this.Column1.FillWeight = 50F;
            this.Column1.HeaderText = "Product Number";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 70F;
            this.Column2.HeaderText = "Product Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.FillWeight = 60F;
            this.Column7.HeaderText = "Unit";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 50F;
            this.Column3.HeaderText = "Quantity";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 60F;
            this.Column4.HeaderText = "Price Tax";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.FillWeight = 50F;
            this.Column5.HeaderText = "Discount";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.FillWeight = 60F;
            this.Column6.HeaderText = "Total";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // btnAddCust
            // 
            this.btnAddCust.AutoSize = false;
            this.btnAddCust.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddCust.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAddCust.Depth = 0;
            this.btnAddCust.HighEmphasis = true;
            this.btnAddCust.Icon = ((System.Drawing.Image)(resources.GetObject("btnAddCust.Icon")));
            this.btnAddCust.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAddCust.Location = new System.Drawing.Point(879, 88);
            this.btnAddCust.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddCust.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddCust.Name = "btnAddCust";
            this.btnAddCust.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAddCust.Size = new System.Drawing.Size(92, 36);
            this.btnAddCust.TabIndex = 55;
            this.btnAddCust.Text = "add";
            this.btnAddCust.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddCust.UseAccentColor = false;
            this.btnAddCust.UseVisualStyleBackColor = true;
            this.btnAddCust.Click += new System.EventHandler(this.btnAddCust_Click);
            // 
            // btnShow
            // 
            this.btnShow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnShow.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnShow.Depth = 0;
            this.btnShow.HighEmphasis = true;
            this.btnShow.Icon = ((System.Drawing.Image)(resources.GetObject("btnShow.Icon")));
            this.btnShow.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnShow.Location = new System.Drawing.Point(879, 145);
            this.btnShow.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnShow.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnShow.Name = "btnShow";
            this.btnShow.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnShow.Size = new System.Drawing.Size(92, 36);
            this.btnShow.TabIndex = 54;
            this.btnShow.Text = "Show";
            this.btnShow.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnShow.UseAccentColor = false;
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.dateTime);
            this.groupBox1.Controls.Add(this.rbtnDefePay);
            this.groupBox1.Controls.Add(this.lblduedate);
            this.groupBox1.Controls.Add(this.lblDate);
            this.groupBox1.Controls.Add(this.rbtnCash);
            this.groupBox1.Controls.Add(this.DtpdateDue);
            this.groupBox1.Controls.Add(this.DtpDate);
            this.groupBox1.Location = new System.Drawing.Point(16, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(462, 111);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(91, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(173, 28);
            this.panel1.TabIndex = 65;
            // 
            // dateTime
            // 
            this.dateTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTime.Location = new System.Drawing.Point(93, 50);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(161, 22);
            this.dateTime.TabIndex = 64;
            // 
            // rbtnDefePay
            // 
            this.rbtnDefePay.AutoSize = true;
            this.rbtnDefePay.Depth = 0;
            this.rbtnDefePay.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rbtnDefePay.Location = new System.Drawing.Point(288, 13);
            this.rbtnDefePay.Margin = new System.Windows.Forms.Padding(0);
            this.rbtnDefePay.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbtnDefePay.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtnDefePay.Name = "rbtnDefePay";
            this.rbtnDefePay.Ripple = true;
            this.rbtnDefePay.Size = new System.Drawing.Size(162, 37);
            this.rbtnDefePay.TabIndex = 36;
            this.rbtnDefePay.TabStop = true;
            this.rbtnDefePay.Text = "Deferred Payment";
            this.rbtnDefePay.UseVisualStyleBackColor = true;
            this.rbtnDefePay.CheckedChanged += new System.EventHandler(this.rbtnDefePay_CheckedChanged);
            // 
            // lblduedate
            // 
            this.lblduedate.AutoSize = true;
            this.lblduedate.Depth = 0;
            this.lblduedate.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblduedate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblduedate.Location = new System.Drawing.Point(15, 21);
            this.lblduedate.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblduedate.Name = "lblduedate";
            this.lblduedate.Size = new System.Drawing.Size(70, 19);
            this.lblduedate.TabIndex = 20;
            this.lblduedate.Text = "due date :";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Depth = 0;
            this.lblDate.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDate.Location = new System.Drawing.Point(26, 80);
            this.lblDate.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(58, 19);
            this.lblDate.TabIndex = 19;
            this.lblDate.Text = "Date     :";
            // 
            // rbtnCash
            // 
            this.rbtnCash.AutoSize = true;
            this.rbtnCash.Checked = true;
            this.rbtnCash.Depth = 0;
            this.rbtnCash.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rbtnCash.Location = new System.Drawing.Point(288, 66);
            this.rbtnCash.Margin = new System.Windows.Forms.Padding(0);
            this.rbtnCash.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbtnCash.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtnCash.Name = "rbtnCash";
            this.rbtnCash.Ripple = true;
            this.rbtnCash.Size = new System.Drawing.Size(102, 37);
            this.rbtnCash.TabIndex = 35;
            this.rbtnCash.TabStop = true;
            this.rbtnCash.Text = "Pay Cash";
            this.rbtnCash.UseVisualStyleBackColor = true;
            this.rbtnCash.CheckedChanged += new System.EventHandler(this.rbtnCash_CheckedChanged);
            // 
            // DtpdateDue
            // 
            this.DtpdateDue.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpdateDue.Location = new System.Drawing.Point(91, 19);
            this.DtpdateDue.Name = "DtpdateDue";
            this.DtpdateDue.Size = new System.Drawing.Size(176, 22);
            this.DtpdateDue.TabIndex = 18;
            // 
            // DtpDate
            // 
            this.DtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpDate.Location = new System.Drawing.Point(91, 79);
            this.DtpDate.Name = "DtpDate";
            this.DtpDate.Size = new System.Drawing.Size(176, 22);
            this.DtpDate.TabIndex = 17;
            // 
            // CbxItemsPro
            // 
            this.CbxItemsPro.AutoResize = false;
            this.CbxItemsPro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CbxItemsPro.Depth = 0;
            this.CbxItemsPro.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.CbxItemsPro.DropDownHeight = 174;
            this.CbxItemsPro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxItemsPro.DropDownWidth = 121;
            this.CbxItemsPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.CbxItemsPro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CbxItemsPro.FormattingEnabled = true;
            this.CbxItemsPro.Hint = "Choose a Product ";
            this.CbxItemsPro.IntegralHeight = false;
            this.CbxItemsPro.ItemHeight = 43;
            this.CbxItemsPro.Location = new System.Drawing.Point(992, 137);
            this.CbxItemsPro.MaxDropDownItems = 4;
            this.CbxItemsPro.MouseState = MaterialSkin.MouseState.OUT;
            this.CbxItemsPro.Name = "CbxItemsPro";
            this.CbxItemsPro.Size = new System.Drawing.Size(170, 49);
            this.CbxItemsPro.StartIndex = 0;
            this.CbxItemsPro.TabIndex = 50;
            // 
            // CbxCustomer
            // 
            this.CbxCustomer.AutoResize = false;
            this.CbxCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CbxCustomer.Depth = 0;
            this.CbxCustomer.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.CbxCustomer.DropDownHeight = 174;
            this.CbxCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxCustomer.DropDownWidth = 121;
            this.CbxCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.CbxCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CbxCustomer.Hint = "Customer Name ";
            this.CbxCustomer.IntegralHeight = false;
            this.CbxCustomer.ItemHeight = 43;
            this.CbxCustomer.Location = new System.Drawing.Point(992, 82);
            this.CbxCustomer.MaxDropDownItems = 4;
            this.CbxCustomer.MouseState = MaterialSkin.MouseState.OUT;
            this.CbxCustomer.Name = "CbxCustomer";
            this.CbxCustomer.Size = new System.Drawing.Size(170, 49);
            this.CbxCustomer.StartIndex = 0;
            this.CbxCustomer.TabIndex = 49;
            // 
            // txtCustomer
            // 
            this.txtCustomer.AllowPromptAsInput = true;
            this.txtCustomer.AnimateReadOnly = false;
            this.txtCustomer.AsciiOnly = false;
            this.txtCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtCustomer.BeepOnError = false;
            this.txtCustomer.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtCustomer.Depth = 0;
            this.txtCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCustomer.HidePromptOnLeave = false;
            this.txtCustomer.HideSelection = true;
            this.txtCustomer.Hint = "Cash Customer";
            this.txtCustomer.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtCustomer.LeadingIcon = null;
            this.txtCustomer.Location = new System.Drawing.Point(601, 81);
            this.txtCustomer.Mask = "";
            this.txtCustomer.MaxLength = 32767;
            this.txtCustomer.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.PasswordChar = '\0';
            this.txtCustomer.PrefixSuffixText = null;
            this.txtCustomer.PromptChar = '_';
            this.txtCustomer.ReadOnly = false;
            this.txtCustomer.RejectInputOnFirstFailure = false;
            this.txtCustomer.ResetOnPrompt = true;
            this.txtCustomer.ResetOnSpace = true;
            this.txtCustomer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCustomer.SelectedText = "";
            this.txtCustomer.SelectionLength = 0;
            this.txtCustomer.SelectionStart = 0;
            this.txtCustomer.ShortcutsEnabled = true;
            this.txtCustomer.Size = new System.Drawing.Size(252, 48);
            this.txtCustomer.SkipLiterals = true;
            this.txtCustomer.TabIndex = 63;
            this.txtCustomer.TabStop = false;
            this.txtCustomer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCustomer.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtCustomer.TrailingIcon = null;
            this.txtCustomer.UseSystemPasswordChar = false;
            this.txtCustomer.ValidatingType = null;
            // 
            // FrmSalesManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 634);
            this.Controls.Add(this.txtCustomer);
            this.Controls.Add(this.txtInvoiceId);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSaveIn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblTotalall);
            this.Controls.Add(this.txtTotalAll);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.DgvSales);
            this.Controls.Add(this.btnAddCust);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CbxItemsPro);
            this.Controls.Add(this.CbxCustomer);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmSalesManagement";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Management";
            this.Load += new System.EventHandler(this.FrmSalesManagement_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmSalesManagement_KeyDown);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSales)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialMaskedTextBox txtInvoiceId;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtBarcode;
        private MaterialSkin.Controls.MaterialButton btnEdit;
        private MaterialSkin.Controls.MaterialButton btnSaveIn;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialLabel LabelInfo;
        private MaterialSkin.Controls.MaterialLabel lblItems;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialLabel lblUserName;
        private MaterialSkin.Controls.MaterialLabel lblTotalall;
        private System.Windows.Forms.TextBox txtTotalAll;
        private MaterialSkin.Controls.MaterialButton btnRemove;
        public System.Windows.Forms.DataGridView DgvSales;
        private MaterialSkin.Controls.MaterialButton btnAddCust;
        private MaterialSkin.Controls.MaterialButton btnShow;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialRadioButton rbtnDefePay;
        private MaterialSkin.Controls.MaterialLabel lblduedate;
        private MaterialSkin.Controls.MaterialLabel lblDate;
        private MaterialSkin.Controls.MaterialRadioButton rbtnCash;
        private System.Windows.Forms.DateTimePicker DtpdateDue;
        private System.Windows.Forms.DateTimePicker DtpDate;
        private MaterialSkin.Controls.MaterialComboBox CbxItemsPro;
        public MaterialSkin.Controls.MaterialComboBox CbxCustomer;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTime;
    }
}