
namespace SalesMangement
{
    partial class FrmBuy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBuy));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CbxSupplierBuy = new MaterialSkin.Controls.MaterialComboBox();
            this.CbxItemsProBuy = new MaterialSkin.Controls.MaterialComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.rbtnDefePay = new MaterialSkin.Controls.MaterialRadioButton();
            this.lblduedate = new MaterialSkin.Controls.MaterialLabel();
            this.lblDate = new MaterialSkin.Controls.MaterialLabel();
            this.rbtnCash = new MaterialSkin.Controls.MaterialRadioButton();
            this.DtpdateDueBuy = new System.Windows.Forms.DateTimePicker();
            this.DtpDateBuy = new System.Windows.Forms.DateTimePicker();
            this.txtBarcodeBuy = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.txtInvoiceIdBuy = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.btnAddSupBuy = new MaterialSkin.Controls.MaterialButton();
            this.btnShowBuy = new MaterialSkin.Controls.MaterialButton();
            this.Dgvbuy = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRemoveBuy = new MaterialSkin.Controls.MaterialButton();
            this.lblTotalall = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblUserName = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.lblItemsBuy = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btnSaveIn = new MaterialSkin.Controls.MaterialButton();
            this.btnEdit = new MaterialSkin.Controls.MaterialButton();
            this.txtTotalAll = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.cbxChooseWarehouse = new MaterialSkin.Controls.MaterialComboBox();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgvbuy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // CbxSupplierBuy
            // 
            this.CbxSupplierBuy.AutoResize = false;
            this.CbxSupplierBuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CbxSupplierBuy.Depth = 0;
            this.CbxSupplierBuy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.CbxSupplierBuy.DropDownHeight = 174;
            this.CbxSupplierBuy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxSupplierBuy.DropDownWidth = 121;
            resources.ApplyResources(this.CbxSupplierBuy, "CbxSupplierBuy");
            this.CbxSupplierBuy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CbxSupplierBuy.FormattingEnabled = true;
            this.CbxSupplierBuy.MouseState = MaterialSkin.MouseState.OUT;
            this.CbxSupplierBuy.Name = "CbxSupplierBuy";
            this.CbxSupplierBuy.StartIndex = 0;
            this.CbxSupplierBuy.SelectedIndexChanged += new System.EventHandler(this.CbxSupplierBuy_SelectedIndexChanged);
            // 
            // CbxItemsProBuy
            // 
            this.CbxItemsProBuy.AutoResize = false;
            this.CbxItemsProBuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CbxItemsProBuy.Depth = 0;
            this.CbxItemsProBuy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.CbxItemsProBuy.DropDownHeight = 174;
            this.CbxItemsProBuy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxItemsProBuy.DropDownWidth = 121;
            resources.ApplyResources(this.CbxItemsProBuy, "CbxItemsProBuy");
            this.CbxItemsProBuy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CbxItemsProBuy.FormattingEnabled = true;
            this.CbxItemsProBuy.MouseState = MaterialSkin.MouseState.OUT;
            this.CbxItemsProBuy.Name = "CbxItemsProBuy";
            this.CbxItemsProBuy.StartIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.dateTime);
            this.groupBox1.Controls.Add(this.rbtnDefePay);
            this.groupBox1.Controls.Add(this.lblduedate);
            this.groupBox1.Controls.Add(this.lblDate);
            this.groupBox1.Controls.Add(this.rbtnCash);
            this.groupBox1.Controls.Add(this.DtpdateDueBuy);
            this.groupBox1.Controls.Add(this.DtpDateBuy);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // dateTime
            // 
            this.dateTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            resources.ApplyResources(this.dateTime, "dateTime");
            this.dateTime.Name = "dateTime";
            // 
            // rbtnDefePay
            // 
            resources.ApplyResources(this.rbtnDefePay, "rbtnDefePay");
            this.rbtnDefePay.Depth = 0;
            this.rbtnDefePay.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbtnDefePay.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtnDefePay.Name = "rbtnDefePay";
            this.rbtnDefePay.Ripple = true;
            this.rbtnDefePay.TabStop = true;
            this.rbtnDefePay.UseVisualStyleBackColor = true;
            // 
            // lblduedate
            // 
            resources.ApplyResources(this.lblduedate, "lblduedate");
            this.lblduedate.Depth = 0;
            this.lblduedate.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblduedate.Name = "lblduedate";
            // 
            // lblDate
            // 
            resources.ApplyResources(this.lblDate, "lblDate");
            this.lblDate.Depth = 0;
            this.lblDate.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDate.Name = "lblDate";
            // 
            // rbtnCash
            // 
            resources.ApplyResources(this.rbtnCash, "rbtnCash");
            this.rbtnCash.Depth = 0;
            this.rbtnCash.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbtnCash.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtnCash.Name = "rbtnCash";
            this.rbtnCash.Ripple = true;
            this.rbtnCash.TabStop = true;
            this.rbtnCash.UseVisualStyleBackColor = true;
            // 
            // DtpdateDueBuy
            // 
            this.DtpdateDueBuy.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            resources.ApplyResources(this.DtpdateDueBuy, "DtpdateDueBuy");
            this.DtpdateDueBuy.Name = "DtpdateDueBuy";
            // 
            // DtpDateBuy
            // 
            this.DtpDateBuy.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            resources.ApplyResources(this.DtpDateBuy, "DtpDateBuy");
            this.DtpDateBuy.Name = "DtpDateBuy";
            // 
            // txtBarcodeBuy
            // 
            this.txtBarcodeBuy.AllowPromptAsInput = true;
            this.txtBarcodeBuy.AnimateReadOnly = false;
            this.txtBarcodeBuy.AsciiOnly = false;
            resources.ApplyResources(this.txtBarcodeBuy, "txtBarcodeBuy");
            this.txtBarcodeBuy.BeepOnError = false;
            this.txtBarcodeBuy.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtBarcodeBuy.Depth = 0;
            this.txtBarcodeBuy.HidePromptOnLeave = false;
            this.txtBarcodeBuy.HideSelection = true;
            this.txtBarcodeBuy.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtBarcodeBuy.LeadingIcon = null;
            this.txtBarcodeBuy.Mask = "";
            this.txtBarcodeBuy.MaxLength = 32767;
            this.txtBarcodeBuy.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBarcodeBuy.Name = "txtBarcodeBuy";
            this.txtBarcodeBuy.PasswordChar = '\0';
            this.txtBarcodeBuy.PromptChar = '_';
            this.txtBarcodeBuy.ReadOnly = false;
            this.txtBarcodeBuy.RejectInputOnFirstFailure = false;
            this.txtBarcodeBuy.ResetOnPrompt = true;
            this.txtBarcodeBuy.ResetOnSpace = true;
            this.txtBarcodeBuy.SelectedText = "";
            this.txtBarcodeBuy.SelectionLength = 0;
            this.txtBarcodeBuy.SelectionStart = 0;
            this.txtBarcodeBuy.ShortcutsEnabled = true;
            this.txtBarcodeBuy.SkipLiterals = true;
            this.txtBarcodeBuy.TabStop = false;
            this.txtBarcodeBuy.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBarcodeBuy.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtBarcodeBuy.TrailingIcon = null;
            this.txtBarcodeBuy.UseSystemPasswordChar = false;
            this.txtBarcodeBuy.ValidatingType = null;
            this.txtBarcodeBuy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInvoiceIdBuy_KeyPress);
            // 
            // txtInvoiceIdBuy
            // 
            this.txtInvoiceIdBuy.AllowPromptAsInput = true;
            this.txtInvoiceIdBuy.AnimateReadOnly = false;
            this.txtInvoiceIdBuy.AsciiOnly = false;
            resources.ApplyResources(this.txtInvoiceIdBuy, "txtInvoiceIdBuy");
            this.txtInvoiceIdBuy.BeepOnError = false;
            this.txtInvoiceIdBuy.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtInvoiceIdBuy.Depth = 0;
            this.txtInvoiceIdBuy.HidePromptOnLeave = false;
            this.txtInvoiceIdBuy.HideSelection = true;
            this.txtInvoiceIdBuy.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtInvoiceIdBuy.LeadingIcon = null;
            this.txtInvoiceIdBuy.Mask = "";
            this.txtInvoiceIdBuy.MaxLength = 32767;
            this.txtInvoiceIdBuy.MouseState = MaterialSkin.MouseState.OUT;
            this.txtInvoiceIdBuy.Name = "txtInvoiceIdBuy";
            this.txtInvoiceIdBuy.PasswordChar = '\0';
            this.txtInvoiceIdBuy.PromptChar = '_';
            this.txtInvoiceIdBuy.ReadOnly = false;
            this.txtInvoiceIdBuy.RejectInputOnFirstFailure = false;
            this.txtInvoiceIdBuy.ResetOnPrompt = true;
            this.txtInvoiceIdBuy.ResetOnSpace = true;
            this.txtInvoiceIdBuy.SelectedText = "";
            this.txtInvoiceIdBuy.SelectionLength = 0;
            this.txtInvoiceIdBuy.SelectionStart = 0;
            this.txtInvoiceIdBuy.ShortcutsEnabled = true;
            this.txtInvoiceIdBuy.SkipLiterals = true;
            this.txtInvoiceIdBuy.TabStop = false;
            this.txtInvoiceIdBuy.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtInvoiceIdBuy.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtInvoiceIdBuy.TrailingIcon = null;
            this.txtInvoiceIdBuy.UseSystemPasswordChar = false;
            this.txtInvoiceIdBuy.ValidatingType = null;
            this.txtInvoiceIdBuy.Click += new System.EventHandler(this.txtInvoiceIdBuy_Click);
            // 
            // btnAddSupBuy
            // 
            resources.ApplyResources(this.btnAddSupBuy, "btnAddSupBuy");
            this.btnAddSupBuy.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAddSupBuy.Depth = 0;
            this.btnAddSupBuy.HighEmphasis = true;
            this.btnAddSupBuy.Icon = ((System.Drawing.Image)(resources.GetObject("btnAddSupBuy.Icon")));
            this.btnAddSupBuy.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddSupBuy.Name = "btnAddSupBuy";
            this.btnAddSupBuy.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAddSupBuy.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddSupBuy.UseAccentColor = false;
            this.btnAddSupBuy.UseVisualStyleBackColor = true;
            this.btnAddSupBuy.Click += new System.EventHandler(this.btnAddSupBuy_Click);
            // 
            // btnShowBuy
            // 
            resources.ApplyResources(this.btnShowBuy, "btnShowBuy");
            this.btnShowBuy.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnShowBuy.Depth = 0;
            this.btnShowBuy.HighEmphasis = true;
            this.btnShowBuy.Icon = ((System.Drawing.Image)(resources.GetObject("btnShowBuy.Icon")));
            this.btnShowBuy.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnShowBuy.Name = "btnShowBuy";
            this.btnShowBuy.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnShowBuy.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnShowBuy.UseAccentColor = false;
            this.btnShowBuy.UseVisualStyleBackColor = true;
            this.btnShowBuy.Click += new System.EventHandler(this.btnShowBuy_Click);
            // 
            // Dgvbuy
            // 
            this.Dgvbuy.AllowUserToAddRows = false;
            this.Dgvbuy.AllowUserToDeleteRows = false;
            this.Dgvbuy.AllowUserToResizeColumns = false;
            this.Dgvbuy.AllowUserToResizeRows = false;
            this.Dgvbuy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgvbuy.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Dgvbuy.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.Dgvbuy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.Dgvbuy, "Dgvbuy");
            this.Dgvbuy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column7,
            this.Column3,
            this.Column8,
            this.Column5,
            this.Column6});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(158)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgvbuy.DefaultCellStyle = dataGridViewCellStyle1;
            this.Dgvbuy.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Dgvbuy.Name = "Dgvbuy";
            this.Dgvbuy.ReadOnly = true;
            this.Dgvbuy.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Dgvbuy.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.Dgvbuy.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(158)))), ((int)(((byte)(128)))));
            this.Dgvbuy.RowTemplate.Height = 24;
            this.Dgvbuy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgvbuy.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgvbuy_CellValueChanged);
            // 
            // Column1
            // 
            resources.ApplyResources(this.Column1, "Column1");
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            resources.ApplyResources(this.Column2, "Column2");
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.FillWeight = 50F;
            resources.ApplyResources(this.Column7, "Column7");
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 50F;
            resources.ApplyResources(this.Column3, "Column3");
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.FillWeight = 50F;
            resources.ApplyResources(this.Column8, "Column8");
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.FillWeight = 50F;
            resources.ApplyResources(this.Column5, "Column5");
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.FillWeight = 60F;
            resources.ApplyResources(this.Column6, "Column6");
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // btnRemoveBuy
            // 
            resources.ApplyResources(this.btnRemoveBuy, "btnRemoveBuy");
            this.btnRemoveBuy.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRemoveBuy.Depth = 0;
            this.btnRemoveBuy.HighEmphasis = true;
            this.btnRemoveBuy.Icon = ((System.Drawing.Image)(resources.GetObject("btnRemoveBuy.Icon")));
            this.btnRemoveBuy.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRemoveBuy.Name = "btnRemoveBuy";
            this.btnRemoveBuy.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRemoveBuy.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRemoveBuy.UseAccentColor = true;
            this.btnRemoveBuy.UseVisualStyleBackColor = true;
            this.btnRemoveBuy.Click += new System.EventHandler(this.btnRemoveBuy_Click);
            // 
            // lblTotalall
            // 
            resources.ApplyResources(this.lblTotalall, "lblTotalall");
            this.lblTotalall.Depth = 0;
            this.lblTotalall.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTotalall.Name = "lblTotalall";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // lblUserName
            // 
            resources.ApplyResources(this.lblUserName, "lblUserName");
            this.lblUserName.Depth = 0;
            this.lblUserName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblUserName.Name = "lblUserName";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.materialLabel2);
            this.groupBox2.Controls.Add(this.lblItemsBuy);
            this.groupBox2.Controls.Add(this.materialLabel1);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.lblUserName);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // materialLabel2
            // 
            resources.ApplyResources(this.materialLabel2, "materialLabel2");
            this.materialLabel2.Depth = 0;
            this.materialLabel2.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            // 
            // lblItemsBuy
            // 
            resources.ApplyResources(this.lblItemsBuy, "lblItemsBuy");
            this.lblItemsBuy.Depth = 0;
            this.lblItemsBuy.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblItemsBuy.Name = "lblItemsBuy";
            // 
            // materialLabel1
            // 
            resources.ApplyResources(this.materialLabel1, "materialLabel1");
            this.materialLabel1.Depth = 0;
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            // 
            // btnSaveIn
            // 
            resources.ApplyResources(this.btnSaveIn, "btnSaveIn");
            this.btnSaveIn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSaveIn.Depth = 0;
            this.btnSaveIn.HighEmphasis = true;
            this.btnSaveIn.Icon = ((System.Drawing.Image)(resources.GetObject("btnSaveIn.Icon")));
            this.btnSaveIn.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSaveIn.Name = "btnSaveIn";
            this.btnSaveIn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSaveIn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSaveIn.UseAccentColor = false;
            this.btnSaveIn.UseVisualStyleBackColor = false;
            this.btnSaveIn.Click += new System.EventHandler(this.btnSaveIn_Click);
            // 
            // btnEdit
            // 
            resources.ApplyResources(this.btnEdit, "btnEdit");
            this.btnEdit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEdit.Depth = 0;
            this.btnEdit.HighEmphasis = true;
            this.btnEdit.Icon = ((System.Drawing.Image)(resources.GetObject("btnEdit.Icon")));
            this.btnEdit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEdit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEdit.UseAccentColor = false;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtTotalAll
            // 
            this.txtTotalAll.AnimateReadOnly = false;
            resources.ApplyResources(this.txtTotalAll, "txtTotalAll");
            this.txtTotalAll.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTotalAll.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalAll.Depth = 0;
            this.txtTotalAll.HideSelection = true;
            this.txtTotalAll.MaxLength = 32767;
            this.txtTotalAll.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTotalAll.Name = "txtTotalAll";
            this.txtTotalAll.PasswordChar = '\0';
            this.txtTotalAll.ReadOnly = true;
            this.txtTotalAll.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTotalAll.SelectedText = "";
            this.txtTotalAll.SelectionLength = 0;
            this.txtTotalAll.SelectionStart = 0;
            this.txtTotalAll.ShortcutsEnabled = true;
            this.txtTotalAll.TabStop = false;
            this.txtTotalAll.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTotalAll.UseSystemPasswordChar = false;
            // 
            // cbxChooseWarehouse
            // 
            this.cbxChooseWarehouse.AutoResize = false;
            this.cbxChooseWarehouse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbxChooseWarehouse.Depth = 0;
            this.cbxChooseWarehouse.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbxChooseWarehouse.DropDownHeight = 174;
            this.cbxChooseWarehouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxChooseWarehouse.DropDownWidth = 121;
            resources.ApplyResources(this.cbxChooseWarehouse, "cbxChooseWarehouse");
            this.cbxChooseWarehouse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbxChooseWarehouse.FormattingEnabled = true;
            this.cbxChooseWarehouse.MouseState = MaterialSkin.MouseState.OUT;
            this.cbxChooseWarehouse.Name = "cbxChooseWarehouse";
            this.cbxChooseWarehouse.StartIndex = 0;
            // 
            // materialButton1
            // 
            resources.ApplyResources(this.materialButton1, "materialButton1");
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = ((System.Drawing.Image)(resources.GetObject("materialButton1.Icon")));
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // FrmBuy
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.cbxChooseWarehouse);
            this.Controls.Add(this.txtTotalAll);
            this.Controls.Add(this.txtInvoiceIdBuy);
            this.Controls.Add(this.txtBarcodeBuy);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSaveIn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblTotalall);
            this.Controls.Add(this.btnRemoveBuy);
            this.Controls.Add(this.Dgvbuy);
            this.Controls.Add(this.btnAddSupBuy);
            this.Controls.Add(this.btnShowBuy);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CbxItemsProBuy);
            this.Controls.Add(this.CbxSupplierBuy);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmBuy";
            this.Sizable = false;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmBuy_FormClosed);
            this.Load += new System.EventHandler(this.FrmBuy_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmBuy_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgvbuy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialComboBox CbxItemsProBuy;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialLabel lblduedate;
        private MaterialSkin.Controls.MaterialLabel lblDate;
        private System.Windows.Forms.DateTimePicker DtpdateDueBuy;
        private System.Windows.Forms.DateTimePicker DtpDateBuy;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtBarcodeBuy;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtInvoiceIdBuy;
        private MaterialSkin.Controls.MaterialButton btnAddSupBuy;
        private MaterialSkin.Controls.MaterialButton btnShowBuy;
        private MaterialSkin.Controls.MaterialButton btnRemoveBuy;
        private MaterialSkin.Controls.MaterialRadioButton rbtnCash;
        private MaterialSkin.Controls.MaterialRadioButton rbtnDefePay;
        private MaterialSkin.Controls.MaterialLabel lblTotalall;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialLabel lblUserName;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel lblItemsBuy;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        public MaterialSkin.Controls.MaterialComboBox CbxSupplierBuy;
        private MaterialSkin.Controls.MaterialButton btnSaveIn;
        private MaterialSkin.Controls.MaterialButton btnEdit;
        public System.Windows.Forms.DataGridView Dgvbuy;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtTotalAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private MaterialSkin.Controls.MaterialComboBox cbxChooseWarehouse;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTime;
    }
}