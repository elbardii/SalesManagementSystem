namespace SalesMangement
{
    partial class FrmReturns
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReturns));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.DateReturns = new System.Windows.Forms.DateTimePicker();
            this.lblFrom = new MaterialSkin.Controls.MaterialLabel();
            this.txtInNumber = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.rbtnRtuSales = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbtnRtuBuy = new MaterialSkin.Controls.MaterialRadioButton();
            this.btnSearsh = new MaterialSkin.Controls.MaterialButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DgvReturns = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.txtTotalAfterTax = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txtRemainingAmount = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.txtTotalTax = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtTotalBill = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.lblAmount = new MaterialSkin.Controls.MaterialLabel();
            this.txtAmountPaid = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblChange = new System.Windows.Forms.Label();
            this.CbxWarehSp = new MaterialSkin.Controls.MaterialComboBox();
            this.NumSpecifiedQuantity = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.btnSpecific = new MaterialSkin.Controls.MaterialButton();
            this.txtCustNameSp = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.rbtnFullQuantity = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbtnSpecifiedQuantity = new MaterialSkin.Controls.MaterialRadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnAll = new MaterialSkin.Controls.MaterialButton();
            this.CbxWareh = new MaterialSkin.Controls.MaterialComboBox();
            this.txtCustName = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.materialCard1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvReturns)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.DateReturns);
            this.materialCard1.Controls.Add(this.lblFrom);
            this.materialCard1.Controls.Add(this.txtInNumber);
            this.materialCard1.Controls.Add(this.rbtnRtuSales);
            this.materialCard1.Controls.Add(this.rbtnRtuBuy);
            this.materialCard1.Controls.Add(this.btnSearsh);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(6, 80);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(1160, 62);
            this.materialCard1.TabIndex = 59;
            // 
            // DateReturns
            // 
            this.DateReturns.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateReturns.Location = new System.Drawing.Point(504, 21);
            this.DateReturns.Name = "DateReturns";
            this.DateReturns.Size = new System.Drawing.Size(176, 22);
            this.DateReturns.TabIndex = 60;
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Depth = 0;
            this.lblFrom.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblFrom.Location = new System.Drawing.Point(399, 23);
            this.lblFrom.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(100, 19);
            this.lblFrom.TabIndex = 59;
            this.lblFrom.Text = "Returns Date :";
            // 
            // txtInNumber
            // 
            this.txtInNumber.AllowPromptAsInput = true;
            this.txtInNumber.AnimateReadOnly = false;
            this.txtInNumber.AsciiOnly = false;
            this.txtInNumber.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtInNumber.BeepOnError = false;
            this.txtInNumber.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtInNumber.Depth = 0;
            this.txtInNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtInNumber.HidePromptOnLeave = false;
            this.txtInNumber.HideSelection = true;
            this.txtInNumber.Hint = "Invoice Number";
            this.txtInNumber.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtInNumber.LeadingIcon = null;
            this.txtInNumber.Location = new System.Drawing.Point(723, 8);
            this.txtInNumber.Mask = "";
            this.txtInNumber.MaxLength = 32767;
            this.txtInNumber.MouseState = MaterialSkin.MouseState.OUT;
            this.txtInNumber.Name = "txtInNumber";
            this.txtInNumber.PasswordChar = '\0';
            this.txtInNumber.PrefixSuffixText = null;
            this.txtInNumber.PromptChar = '_';
            this.txtInNumber.ReadOnly = false;
            this.txtInNumber.RejectInputOnFirstFailure = false;
            this.txtInNumber.ResetOnPrompt = true;
            this.txtInNumber.ResetOnSpace = true;
            this.txtInNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtInNumber.SelectedText = "";
            this.txtInNumber.SelectionLength = 0;
            this.txtInNumber.SelectionStart = 0;
            this.txtInNumber.ShortcutsEnabled = true;
            this.txtInNumber.Size = new System.Drawing.Size(198, 48);
            this.txtInNumber.SkipLiterals = true;
            this.txtInNumber.TabIndex = 55;
            this.txtInNumber.TabStop = false;
            this.txtInNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtInNumber.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtInNumber.TrailingIcon = null;
            this.txtInNumber.UseSystemPasswordChar = false;
            this.txtInNumber.ValidatingType = null;
            this.txtInNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInNumber_KeyPress_1);
            // 
            // rbtnRtuSales
            // 
            this.rbtnRtuSales.AutoSize = true;
            this.rbtnRtuSales.Checked = true;
            this.rbtnRtuSales.Depth = 0;
            this.rbtnRtuSales.Location = new System.Drawing.Point(81, 14);
            this.rbtnRtuSales.Margin = new System.Windows.Forms.Padding(0);
            this.rbtnRtuSales.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbtnRtuSales.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtnRtuSales.Name = "rbtnRtuSales";
            this.rbtnRtuSales.Ripple = true;
            this.rbtnRtuSales.Size = new System.Drawing.Size(132, 37);
            this.rbtnRtuSales.TabIndex = 42;
            this.rbtnRtuSales.TabStop = true;
            this.rbtnRtuSales.Text = "Returns Sales";
            this.rbtnRtuSales.UseVisualStyleBackColor = true;
            this.rbtnRtuSales.CheckedChanged += new System.EventHandler(this.rbtnRtuSales_CheckedChanged);
            // 
            // rbtnRtuBuy
            // 
            this.rbtnRtuBuy.AutoSize = true;
            this.rbtnRtuBuy.Depth = 0;
            this.rbtnRtuBuy.Location = new System.Drawing.Point(242, 14);
            this.rbtnRtuBuy.Margin = new System.Windows.Forms.Padding(0);
            this.rbtnRtuBuy.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbtnRtuBuy.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtnRtuBuy.Name = "rbtnRtuBuy";
            this.rbtnRtuBuy.Ripple = true;
            this.rbtnRtuBuy.Size = new System.Drawing.Size(120, 37);
            this.rbtnRtuBuy.TabIndex = 41;
            this.rbtnRtuBuy.TabStop = true;
            this.rbtnRtuBuy.Text = "Returns Buy";
            this.rbtnRtuBuy.UseVisualStyleBackColor = true;
            this.rbtnRtuBuy.CheckedChanged += new System.EventHandler(this.rbtnRtuBuy_CheckedChanged);
            // 
            // btnSearsh
            // 
            this.btnSearsh.AutoSize = false;
            this.btnSearsh.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSearsh.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSearsh.Depth = 0;
            this.btnSearsh.HighEmphasis = true;
            this.btnSearsh.Icon = ((System.Drawing.Image)(resources.GetObject("btnSearsh.Icon")));
            this.btnSearsh.Location = new System.Drawing.Point(957, 12);
            this.btnSearsh.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSearsh.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSearsh.Name = "btnSearsh";
            this.btnSearsh.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSearsh.Size = new System.Drawing.Size(100, 37);
            this.btnSearsh.TabIndex = 39;
            this.btnSearsh.Text = "Searsh";
            this.btnSearsh.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSearsh.UseAccentColor = false;
            this.btnSearsh.UseVisualStyleBackColor = true;
            this.btnSearsh.Click += new System.EventHandler(this.btnSearsh_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DgvReturns);
            this.groupBox1.Location = new System.Drawing.Point(6, 150);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1160, 291);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            // 
            // DgvReturns
            // 
            this.DgvReturns.AllowUserToAddRows = false;
            this.DgvReturns.AllowUserToDeleteRows = false;
            this.DgvReturns.AllowUserToResizeColumns = false;
            this.DgvReturns.AllowUserToResizeRows = false;
            this.DgvReturns.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgvReturns.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvReturns.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.DgvReturns.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvReturns.ColumnHeadersHeight = 29;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(158)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvReturns.DefaultCellStyle = dataGridViewCellStyle1;
            this.DgvReturns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvReturns.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DgvReturns.Location = new System.Drawing.Point(3, 18);
            this.DgvReturns.Name = "DgvReturns";
            this.DgvReturns.ReadOnly = true;
            this.DgvReturns.RowHeadersWidth = 51;
            this.DgvReturns.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DgvReturns.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.DgvReturns.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(158)))), ((int)(((byte)(128)))));
            this.DgvReturns.RowTemplate.Height = 24;
            this.DgvReturns.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvReturns.Size = new System.Drawing.Size(1154, 270);
            this.DgvReturns.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.materialLabel4);
            this.groupBox2.Controls.Add(this.txtTotalAfterTax);
            this.groupBox2.Controls.Add(this.materialLabel3);
            this.groupBox2.Controls.Add(this.txtRemainingAmount);
            this.groupBox2.Controls.Add(this.txtTotalTax);
            this.groupBox2.Controls.Add(this.materialLabel2);
            this.groupBox2.Controls.Add(this.txtTotalBill);
            this.groupBox2.Controls.Add(this.materialLabel1);
            this.groupBox2.Controls.Add(this.lblAmount);
            this.groupBox2.Controls.Add(this.txtAmountPaid);
            this.groupBox2.Location = new System.Drawing.Point(815, 444);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(351, 137);
            this.groupBox2.TabIndex = 61;
            this.groupBox2.TabStop = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(198, 74);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(115, 19);
            this.materialLabel4.TabIndex = 70;
            this.materialLabel4.Text = "Total After Tax :";
            // 
            // txtTotalAfterTax
            // 
            this.txtTotalAfterTax.AnimateReadOnly = false;
            this.txtTotalAfterTax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtTotalAfterTax.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTotalAfterTax.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalAfterTax.Depth = 0;
            this.txtTotalAfterTax.HideSelection = true;
            this.txtTotalAfterTax.Location = new System.Drawing.Point(198, 96);
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
            this.txtTotalAfterTax.Size = new System.Drawing.Size(137, 37);
            this.txtTotalAfterTax.TabIndex = 69;
            this.txtTotalAfterTax.TabStop = false;
            this.txtTotalAfterTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTotalAfterTax.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(16, 73);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(145, 19);
            this.materialLabel3.TabIndex = 68;
            this.materialLabel3.Text = "Remaining Amount :";
            // 
            // txtRemainingAmount
            // 
            this.txtRemainingAmount.AnimateReadOnly = false;
            this.txtRemainingAmount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtRemainingAmount.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtRemainingAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRemainingAmount.Depth = 0;
            this.txtRemainingAmount.HideSelection = true;
            this.txtRemainingAmount.Location = new System.Drawing.Point(16, 95);
            this.txtRemainingAmount.MaxLength = 32767;
            this.txtRemainingAmount.MouseState = MaterialSkin.MouseState.OUT;
            this.txtRemainingAmount.Name = "txtRemainingAmount";
            this.txtRemainingAmount.PasswordChar = '\0';
            this.txtRemainingAmount.ReadOnly = true;
            this.txtRemainingAmount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRemainingAmount.SelectedText = "";
            this.txtRemainingAmount.SelectionLength = 0;
            this.txtRemainingAmount.SelectionStart = 0;
            this.txtRemainingAmount.ShortcutsEnabled = true;
            this.txtRemainingAmount.Size = new System.Drawing.Size(146, 37);
            this.txtRemainingAmount.TabIndex = 67;
            this.txtRemainingAmount.TabStop = false;
            this.txtRemainingAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtRemainingAmount.UseSystemPasswordChar = false;
            // 
            // txtTotalTax
            // 
            this.txtTotalTax.AnimateReadOnly = false;
            this.txtTotalTax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtTotalTax.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTotalTax.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalTax.Depth = 0;
            this.txtTotalTax.HideSelection = true;
            this.txtTotalTax.Location = new System.Drawing.Point(235, 34);
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
            this.txtTotalTax.Size = new System.Drawing.Size(98, 37);
            this.txtTotalTax.TabIndex = 66;
            this.txtTotalTax.TabStop = false;
            this.txtTotalTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTotalTax.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(232, 12);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(77, 19);
            this.materialLabel2.TabIndex = 65;
            this.materialLabel2.Text = "Total Tax :";
            // 
            // txtTotalBill
            // 
            this.txtTotalBill.AnimateReadOnly = false;
            this.txtTotalBill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtTotalBill.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTotalBill.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalBill.Depth = 0;
            this.txtTotalBill.HideSelection = true;
            this.txtTotalBill.Location = new System.Drawing.Point(126, 34);
            this.txtTotalBill.MaxLength = 32767;
            this.txtTotalBill.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTotalBill.Name = "txtTotalBill";
            this.txtTotalBill.PasswordChar = '\0';
            this.txtTotalBill.ReadOnly = true;
            this.txtTotalBill.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTotalBill.SelectedText = "";
            this.txtTotalBill.SelectionLength = 0;
            this.txtTotalBill.SelectionStart = 0;
            this.txtTotalBill.ShortcutsEnabled = true;
            this.txtTotalBill.Size = new System.Drawing.Size(98, 37);
            this.txtTotalBill.TabIndex = 64;
            this.txtTotalBill.TabStop = false;
            this.txtTotalBill.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTotalBill.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(123, 12);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(72, 19);
            this.materialLabel1.TabIndex = 63;
            this.materialLabel1.Text = "Total Bill :";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Depth = 0;
            this.lblAmount.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblAmount.Location = new System.Drawing.Point(16, 12);
            this.lblAmount.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(101, 19);
            this.lblAmount.TabIndex = 62;
            this.lblAmount.Text = "Amount Paid :";
            // 
            // txtAmountPaid
            // 
            this.txtAmountPaid.AnimateReadOnly = false;
            this.txtAmountPaid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtAmountPaid.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtAmountPaid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAmountPaid.Depth = 0;
            this.txtAmountPaid.HideSelection = true;
            this.txtAmountPaid.Location = new System.Drawing.Point(14, 34);
            this.txtAmountPaid.MaxLength = 32767;
            this.txtAmountPaid.MouseState = MaterialSkin.MouseState.OUT;
            this.txtAmountPaid.Name = "txtAmountPaid";
            this.txtAmountPaid.PasswordChar = '\0';
            this.txtAmountPaid.ReadOnly = true;
            this.txtAmountPaid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAmountPaid.SelectedText = "";
            this.txtAmountPaid.SelectionLength = 0;
            this.txtAmountPaid.SelectionStart = 0;
            this.txtAmountPaid.ShortcutsEnabled = true;
            this.txtAmountPaid.Size = new System.Drawing.Size(98, 37);
            this.txtAmountPaid.TabIndex = 61;
            this.txtAmountPaid.TabStop = false;
            this.txtAmountPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAmountPaid.UseSystemPasswordChar = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblChange);
            this.groupBox3.Controls.Add(this.CbxWarehSp);
            this.groupBox3.Controls.Add(this.NumSpecifiedQuantity);
            this.groupBox3.Controls.Add(this.btnSpecific);
            this.groupBox3.Controls.Add(this.txtCustNameSp);
            this.groupBox3.Controls.Add(this.rbtnFullQuantity);
            this.groupBox3.Controls.Add(this.rbtnSpecifiedQuantity);
            this.groupBox3.Location = new System.Drawing.Point(6, 443);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(484, 137);
            this.groupBox3.TabIndex = 62;
            this.groupBox3.TabStop = false;
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Location = new System.Drawing.Point(104, 67);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(0, 16);
            this.lblChange.TabIndex = 62;
            // 
            // CbxWarehSp
            // 
            this.CbxWarehSp.AutoResize = false;
            this.CbxWarehSp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CbxWarehSp.Depth = 0;
            this.CbxWarehSp.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.CbxWarehSp.DropDownHeight = 174;
            this.CbxWarehSp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxWarehSp.DropDownWidth = 121;
            this.CbxWarehSp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.CbxWarehSp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CbxWarehSp.FormattingEnabled = true;
            this.CbxWarehSp.Hint = "Warehouse";
            this.CbxWarehSp.IntegralHeight = false;
            this.CbxWarehSp.ItemHeight = 43;
            this.CbxWarehSp.Location = new System.Drawing.Point(159, 15);
            this.CbxWarehSp.MaxDropDownItems = 4;
            this.CbxWarehSp.MouseState = MaterialSkin.MouseState.OUT;
            this.CbxWarehSp.Name = "CbxWarehSp";
            this.CbxWarehSp.Size = new System.Drawing.Size(143, 49);
            this.CbxWarehSp.StartIndex = 0;
            this.CbxWarehSp.TabIndex = 61;
            // 
            // NumSpecifiedQuantity
            // 
            this.NumSpecifiedQuantity.DecimalPlaces = 2;
            this.NumSpecifiedQuantity.Location = new System.Drawing.Point(314, 89);
            this.NumSpecifiedQuantity.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.NumSpecifiedQuantity.Name = "NumSpecifiedQuantity";
            this.NumSpecifiedQuantity.Size = new System.Drawing.Size(162, 26);
            this.NumSpecifiedQuantity.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.NumSpecifiedQuantity.TabIndex = 59;
            this.NumSpecifiedQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnSpecific
            // 
            this.btnSpecific.AutoSize = false;
            this.btnSpecific.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSpecific.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSpecific.Depth = 0;
            this.btnSpecific.HighEmphasis = true;
            this.btnSpecific.Icon = ((System.Drawing.Image)(resources.GetObject("btnSpecific.Icon")));
            this.btnSpecific.Location = new System.Drawing.Point(6, 85);
            this.btnSpecific.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSpecific.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSpecific.Name = "btnSpecific";
            this.btnSpecific.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSpecific.Size = new System.Drawing.Size(295, 34);
            this.btnSpecific.TabIndex = 60;
            this.btnSpecific.Text = "Specific Category ";
            this.btnSpecific.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSpecific.UseAccentColor = false;
            this.btnSpecific.UseVisualStyleBackColor = true;
            this.btnSpecific.Click += new System.EventHandler(this.btnSpecific_Click);
            // 
            // txtCustNameSp
            // 
            this.txtCustNameSp.AllowPromptAsInput = true;
            this.txtCustNameSp.AnimateReadOnly = false;
            this.txtCustNameSp.AsciiOnly = false;
            this.txtCustNameSp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtCustNameSp.BeepOnError = false;
            this.txtCustNameSp.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtCustNameSp.Depth = 0;
            this.txtCustNameSp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCustNameSp.HidePromptOnLeave = false;
            this.txtCustNameSp.HideSelection = true;
            this.txtCustNameSp.Hint = "Customer Name";
            this.txtCustNameSp.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtCustNameSp.LeadingIcon = null;
            this.txtCustNameSp.Location = new System.Drawing.Point(6, 16);
            this.txtCustNameSp.Mask = "";
            this.txtCustNameSp.MaxLength = 32767;
            this.txtCustNameSp.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCustNameSp.Name = "txtCustNameSp";
            this.txtCustNameSp.PasswordChar = '\0';
            this.txtCustNameSp.PrefixSuffixText = null;
            this.txtCustNameSp.PromptChar = '_';
            this.txtCustNameSp.ReadOnly = false;
            this.txtCustNameSp.RejectInputOnFirstFailure = false;
            this.txtCustNameSp.ResetOnPrompt = true;
            this.txtCustNameSp.ResetOnSpace = true;
            this.txtCustNameSp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCustNameSp.SelectedText = "";
            this.txtCustNameSp.SelectionLength = 0;
            this.txtCustNameSp.SelectionStart = 0;
            this.txtCustNameSp.ShortcutsEnabled = true;
            this.txtCustNameSp.Size = new System.Drawing.Size(143, 48);
            this.txtCustNameSp.SkipLiterals = true;
            this.txtCustNameSp.TabIndex = 56;
            this.txtCustNameSp.TabStop = false;
            this.txtCustNameSp.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCustNameSp.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtCustNameSp.TrailingIcon = null;
            this.txtCustNameSp.UseSystemPasswordChar = false;
            this.txtCustNameSp.ValidatingType = null;
            // 
            // rbtnFullQuantity
            // 
            this.rbtnFullQuantity.AutoSize = true;
            this.rbtnFullQuantity.Checked = true;
            this.rbtnFullQuantity.Depth = 0;
            this.rbtnFullQuantity.Location = new System.Drawing.Point(312, 11);
            this.rbtnFullQuantity.Margin = new System.Windows.Forms.Padding(0);
            this.rbtnFullQuantity.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbtnFullQuantity.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtnFullQuantity.Name = "rbtnFullQuantity";
            this.rbtnFullQuantity.Ripple = true;
            this.rbtnFullQuantity.Size = new System.Drawing.Size(125, 37);
            this.rbtnFullQuantity.TabIndex = 58;
            this.rbtnFullQuantity.TabStop = true;
            this.rbtnFullQuantity.Text = "Full Quantity";
            this.rbtnFullQuantity.UseVisualStyleBackColor = true;
            // 
            // rbtnSpecifiedQuantity
            // 
            this.rbtnSpecifiedQuantity.AutoSize = true;
            this.rbtnSpecifiedQuantity.Depth = 0;
            this.rbtnSpecifiedQuantity.Location = new System.Drawing.Point(311, 47);
            this.rbtnSpecifiedQuantity.Margin = new System.Windows.Forms.Padding(0);
            this.rbtnSpecifiedQuantity.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbtnSpecifiedQuantity.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtnSpecifiedQuantity.Name = "rbtnSpecifiedQuantity";
            this.rbtnSpecifiedQuantity.Ripple = true;
            this.rbtnSpecifiedQuantity.Size = new System.Drawing.Size(165, 37);
            this.rbtnSpecifiedQuantity.TabIndex = 57;
            this.rbtnSpecifiedQuantity.TabStop = true;
            this.rbtnSpecifiedQuantity.Text = "Specified Quantity";
            this.rbtnSpecifiedQuantity.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnAll);
            this.groupBox4.Controls.Add(this.CbxWareh);
            this.groupBox4.Controls.Add(this.txtCustName);
            this.groupBox4.Location = new System.Drawing.Point(493, 443);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(316, 137);
            this.groupBox4.TabIndex = 63;
            this.groupBox4.TabStop = false;
            // 
            // btnAll
            // 
            this.btnAll.AutoSize = false;
            this.btnAll.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAll.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAll.Depth = 0;
            this.btnAll.HighEmphasis = true;
            this.btnAll.Icon = ((System.Drawing.Image)(resources.GetObject("btnAll.Icon")));
            this.btnAll.Location = new System.Drawing.Point(11, 85);
            this.btnAll.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAll.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAll.Name = "btnAll";
            this.btnAll.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAll.Size = new System.Drawing.Size(296, 34);
            this.btnAll.TabIndex = 63;
            this.btnAll.Text = "Invoice with a Full";
            this.btnAll.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAll.UseAccentColor = false;
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // CbxWareh
            // 
            this.CbxWareh.AutoResize = false;
            this.CbxWareh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CbxWareh.Depth = 0;
            this.CbxWareh.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.CbxWareh.DropDownHeight = 174;
            this.CbxWareh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxWareh.DropDownWidth = 121;
            this.CbxWareh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.CbxWareh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CbxWareh.FormattingEnabled = true;
            this.CbxWareh.Hint = "Warehouse";
            this.CbxWareh.IntegralHeight = false;
            this.CbxWareh.ItemHeight = 43;
            this.CbxWareh.Location = new System.Drawing.Point(164, 16);
            this.CbxWareh.MaxDropDownItems = 4;
            this.CbxWareh.MouseState = MaterialSkin.MouseState.OUT;
            this.CbxWareh.Name = "CbxWareh";
            this.CbxWareh.Size = new System.Drawing.Size(143, 49);
            this.CbxWareh.StartIndex = 0;
            this.CbxWareh.TabIndex = 62;
            // 
            // txtCustName
            // 
            this.txtCustName.AllowPromptAsInput = true;
            this.txtCustName.AnimateReadOnly = false;
            this.txtCustName.AsciiOnly = false;
            this.txtCustName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtCustName.BeepOnError = false;
            this.txtCustName.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtCustName.Depth = 0;
            this.txtCustName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCustName.HidePromptOnLeave = false;
            this.txtCustName.HideSelection = true;
            this.txtCustName.Hint = "Customer Name";
            this.txtCustName.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtCustName.LeadingIcon = null;
            this.txtCustName.Location = new System.Drawing.Point(11, 17);
            this.txtCustName.Mask = "";
            this.txtCustName.MaxLength = 32767;
            this.txtCustName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.PasswordChar = '\0';
            this.txtCustName.PrefixSuffixText = null;
            this.txtCustName.PromptChar = '_';
            this.txtCustName.ReadOnly = false;
            this.txtCustName.RejectInputOnFirstFailure = false;
            this.txtCustName.ResetOnPrompt = true;
            this.txtCustName.ResetOnSpace = true;
            this.txtCustName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCustName.SelectedText = "";
            this.txtCustName.SelectionLength = 0;
            this.txtCustName.SelectionStart = 0;
            this.txtCustName.ShortcutsEnabled = true;
            this.txtCustName.Size = new System.Drawing.Size(143, 48);
            this.txtCustName.SkipLiterals = true;
            this.txtCustName.TabIndex = 57;
            this.txtCustName.TabStop = false;
            this.txtCustName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCustName.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtCustName.TrailingIcon = null;
            this.txtCustName.UseSystemPasswordChar = false;
            this.txtCustName.ValidatingType = null;
            // 
            // FrmReturns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 634);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.materialCard1);
            this.MaximizeBox = false;
            this.Name = "FrmReturns";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Returns Management";
            this.Load += new System.EventHandler(this.FrmReturns_Load);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvReturns)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtInNumber;
        private MaterialSkin.Controls.MaterialRadioButton rbtnRtuSales;
        private MaterialSkin.Controls.MaterialRadioButton rbtnRtuBuy;
        private MaterialSkin.Controls.MaterialButton btnSearsh;
        private System.Windows.Forms.DateTimePicker DateReturns;
        private MaterialSkin.Controls.MaterialLabel lblFrom;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DgvReturns;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtAmountPaid;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel lblAmount;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtTotalAfterTax;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtRemainingAmount;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtTotalTax;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtTotalBill;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtCustNameSp;
        private MaterialSkin.Controls.MaterialRadioButton rbtnFullQuantity;
        private MaterialSkin.Controls.MaterialRadioButton rbtnSpecifiedQuantity;
        private MaterialSkin.Controls.MaterialButton btnSpecific;
        private ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown NumSpecifiedQuantity;
        private MaterialSkin.Controls.MaterialComboBox CbxWarehSp;
        private System.Windows.Forms.GroupBox groupBox4;
        private MaterialSkin.Controls.MaterialButton btnAll;
        private MaterialSkin.Controls.MaterialComboBox CbxWareh;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtCustName;
        private System.Windows.Forms.Label lblChange;
    }
}