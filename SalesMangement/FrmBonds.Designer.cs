namespace SalesMangement
{
    partial class FrmBonds
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBonds));
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.ReceiptVoucher = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtBondFrom = new MaterialSkin.Controls.MaterialTextBox();
            this.txtResponsibleName = new MaterialSkin.Controls.MaterialTextBox();
            this.NumAmount = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.DateBond = new System.Windows.Forms.DateTimePicker();
            this.txtNumberBond = new MaterialSkin.Controls.MaterialTextBox();
            this.txtReason = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFirstR = new MaterialSkin.Controls.MaterialButton();
            this.btnPreviousR = new MaterialSkin.Controls.MaterialButton();
            this.btnNextR = new MaterialSkin.Controls.MaterialButton();
            this.btnLastR = new MaterialSkin.Controls.MaterialButton();
            this.btnDeleteAllR = new MaterialSkin.Controls.MaterialButton();
            this.btnDeleteR = new MaterialSkin.Controls.MaterialButton();
            this.btnSaveR = new MaterialSkin.Controls.MaterialButton();
            this.btnNewR = new MaterialSkin.Controls.MaterialButton();
            this.VoucherExchange = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCashingTO = new MaterialSkin.Controls.MaterialTextBox();
            this.txtResponsibleExchange = new MaterialSkin.Controls.MaterialTextBox();
            this.NumAmountR = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.DateBondR = new System.Windows.Forms.DateTimePicker();
            this.txtNumberBondR = new MaterialSkin.Controls.MaterialTextBox();
            this.txtReasonR = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnFirst = new MaterialSkin.Controls.MaterialButton();
            this.btnPrevious = new MaterialSkin.Controls.MaterialButton();
            this.btnNext = new MaterialSkin.Controls.MaterialButton();
            this.btnLast = new MaterialSkin.Controls.MaterialButton();
            this.btnDeleteAll = new MaterialSkin.Controls.MaterialButton();
            this.btnDelete = new MaterialSkin.Controls.MaterialButton();
            this.btnSavePrint = new MaterialSkin.Controls.MaterialButton();
            this.btnNew = new MaterialSkin.Controls.MaterialButton();
            this.materialTabControl1.SuspendLayout();
            this.ReceiptVoucher.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.VoucherExchange.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTabSelector1.Location = new System.Drawing.Point(-25, 24);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(1200, 48);
            this.materialTabSelector1.TabIndex = 0;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.ReceiptVoucher);
            this.materialTabControl1.Controls.Add(this.VoucherExchange);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(5, 77);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1161, 551);
            this.materialTabControl1.TabIndex = 1;
            // 
            // ReceiptVoucher
            // 
            this.ReceiptVoucher.Controls.Add(this.pictureBox2);
            this.ReceiptVoucher.Controls.Add(this.groupBox4);
            this.ReceiptVoucher.Controls.Add(this.groupBox1);
            this.ReceiptVoucher.Controls.Add(this.btnDeleteAllR);
            this.ReceiptVoucher.Controls.Add(this.btnDeleteR);
            this.ReceiptVoucher.Controls.Add(this.btnSaveR);
            this.ReceiptVoucher.Controls.Add(this.btnNewR);
            this.ReceiptVoucher.Location = new System.Drawing.Point(4, 25);
            this.ReceiptVoucher.Name = "ReceiptVoucher";
            this.ReceiptVoucher.Padding = new System.Windows.Forms.Padding(3);
            this.ReceiptVoucher.Size = new System.Drawing.Size(1153, 522);
            this.ReceiptVoucher.TabIndex = 0;
            this.ReceiptVoucher.Text = "Receipt Voucher";
            this.ReceiptVoucher.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Enabled = false;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(542, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(629, 552);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 62;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtBondFrom);
            this.groupBox4.Controls.Add(this.txtResponsibleName);
            this.groupBox4.Controls.Add(this.NumAmount);
            this.groupBox4.Controls.Add(this.DateBond);
            this.groupBox4.Controls.Add(this.txtNumberBond);
            this.groupBox4.Controls.Add(this.txtReason);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Location = new System.Drawing.Point(7, 32);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(529, 241);
            this.groupBox4.TabIndex = 61;
            this.groupBox4.TabStop = false;
            // 
            // txtBondFrom
            // 
            this.txtBondFrom.AccessibleName = "";
            this.txtBondFrom.AnimateReadOnly = false;
            this.txtBondFrom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtBondFrom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBondFrom.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtBondFrom.Depth = 0;
            this.txtBondFrom.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBondFrom.Hint = "Take a Bond From";
            this.txtBondFrom.LeadingIcon = null;
            this.txtBondFrom.Location = new System.Drawing.Point(31, 180);
            this.txtBondFrom.MaxLength = 50;
            this.txtBondFrom.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBondFrom.Multiline = false;
            this.txtBondFrom.Name = "txtBondFrom";
            this.txtBondFrom.Size = new System.Drawing.Size(214, 50);
            this.txtBondFrom.TabIndex = 54;
            this.txtBondFrom.Text = "";
            this.txtBondFrom.TrailingIcon = null;
            // 
            // txtResponsibleName
            // 
            this.txtResponsibleName.AccessibleName = "";
            this.txtResponsibleName.AnimateReadOnly = false;
            this.txtResponsibleName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtResponsibleName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResponsibleName.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtResponsibleName.Depth = 0;
            this.txtResponsibleName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtResponsibleName.Hint = "Responsible Name";
            this.txtResponsibleName.LeadingIcon = null;
            this.txtResponsibleName.Location = new System.Drawing.Point(31, 102);
            this.txtResponsibleName.MaxLength = 50;
            this.txtResponsibleName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtResponsibleName.Multiline = false;
            this.txtResponsibleName.Name = "txtResponsibleName";
            this.txtResponsibleName.Size = new System.Drawing.Size(214, 50);
            this.txtResponsibleName.TabIndex = 53;
            this.txtResponsibleName.Text = "";
            this.txtResponsibleName.TrailingIcon = null;
            // 
            // NumAmount
            // 
            this.NumAmount.DecimalPlaces = 2;
            this.NumAmount.Location = new System.Drawing.Point(276, 108);
            this.NumAmount.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.NumAmount.Name = "NumAmount";
            this.NumAmount.Size = new System.Drawing.Size(222, 26);
            this.NumAmount.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.NumAmount.TabIndex = 18;
            this.NumAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // DateBond
            // 
            this.DateBond.CalendarFont = new System.Drawing.Font("Tahoma", 9F);
            this.DateBond.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.DateBond.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.DateBond.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.DateBond.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.DateBond.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.DateBond.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.DateBond.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateBond.Location = new System.Drawing.Point(276, 51);
            this.DateBond.Name = "DateBond";
            this.DateBond.Size = new System.Drawing.Size(222, 26);
            this.DateBond.TabIndex = 52;
            // 
            // txtNumberBond
            // 
            this.txtNumberBond.AccessibleName = "";
            this.txtNumberBond.AnimateReadOnly = false;
            this.txtNumberBond.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtNumberBond.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumberBond.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtNumberBond.Depth = 0;
            this.txtNumberBond.Enabled = false;
            this.txtNumberBond.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNumberBond.Hint = "Bond Number";
            this.txtNumberBond.LeadingIcon = null;
            this.txtNumberBond.Location = new System.Drawing.Point(31, 28);
            this.txtNumberBond.MaxLength = 50;
            this.txtNumberBond.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNumberBond.Multiline = false;
            this.txtNumberBond.Name = "txtNumberBond";
            this.txtNumberBond.Size = new System.Drawing.Size(214, 50);
            this.txtNumberBond.TabIndex = 10;
            this.txtNumberBond.Text = "";
            this.txtNumberBond.TrailingIcon = null;
            // 
            // txtReason
            // 
            this.txtReason.AnimateReadOnly = false;
            this.txtReason.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtReason.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtReason.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtReason.Depth = 0;
            this.txtReason.HideSelection = true;
            this.txtReason.Hint = "Reason";
            this.txtReason.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtReason.Location = new System.Drawing.Point(270, 145);
            this.txtReason.MaxLength = 32767;
            this.txtReason.MouseState = MaterialSkin.MouseState.OUT;
            this.txtReason.Name = "txtReason";
            this.txtReason.PasswordChar = '\0';
            this.txtReason.ReadOnly = false;
            this.txtReason.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtReason.SelectedText = "";
            this.txtReason.SelectionLength = 0;
            this.txtReason.SelectionStart = 0;
            this.txtReason.ShortcutsEnabled = true;
            this.txtReason.Size = new System.Drawing.Size(228, 85);
            this.txtReason.TabIndex = 32;
            this.txtReason.TabStop = false;
            this.txtReason.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtReason.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(276, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Date Bond :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(277, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Amount :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFirstR);
            this.groupBox1.Controls.Add(this.btnPreviousR);
            this.groupBox1.Controls.Add(this.btnNextR);
            this.groupBox1.Controls.Add(this.btnLastR);
            this.groupBox1.Location = new System.Drawing.Point(7, 378);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(529, 63);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            // 
            // btnFirstR
            // 
            this.btnFirstR.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFirstR.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnFirstR.Depth = 0;
            this.btnFirstR.HighEmphasis = true;
            this.btnFirstR.Icon = ((System.Drawing.Image)(resources.GetObject("btnFirstR.Icon")));
            this.btnFirstR.Location = new System.Drawing.Point(22, 17);
            this.btnFirstR.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnFirstR.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnFirstR.Name = "btnFirstR";
            this.btnFirstR.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnFirstR.Size = new System.Drawing.Size(89, 36);
            this.btnFirstR.TabIndex = 4;
            this.btnFirstR.Text = "First";
            this.btnFirstR.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnFirstR.UseAccentColor = false;
            this.btnFirstR.UseVisualStyleBackColor = true;
            this.btnFirstR.Click += new System.EventHandler(this.btnFirstR_Click);
            // 
            // btnPreviousR
            // 
            this.btnPreviousR.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPreviousR.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnPreviousR.Depth = 0;
            this.btnPreviousR.HighEmphasis = true;
            this.btnPreviousR.Icon = ((System.Drawing.Image)(resources.GetObject("btnPreviousR.Icon")));
            this.btnPreviousR.Location = new System.Drawing.Point(134, 17);
            this.btnPreviousR.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPreviousR.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPreviousR.Name = "btnPreviousR";
            this.btnPreviousR.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnPreviousR.Size = new System.Drawing.Size(119, 36);
            this.btnPreviousR.TabIndex = 3;
            this.btnPreviousR.Text = "Previous";
            this.btnPreviousR.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnPreviousR.UseAccentColor = false;
            this.btnPreviousR.UseVisualStyleBackColor = true;
            this.btnPreviousR.Click += new System.EventHandler(this.btnPreviousR_Click);
            // 
            // btnNextR
            // 
            this.btnNextR.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNextR.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnNextR.Depth = 0;
            this.btnNextR.HighEmphasis = true;
            this.btnNextR.Icon = ((System.Drawing.Image)(resources.GetObject("btnNextR.Icon")));
            this.btnNextR.Location = new System.Drawing.Point(291, 17);
            this.btnNextR.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNextR.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNextR.Name = "btnNextR";
            this.btnNextR.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnNextR.Size = new System.Drawing.Size(86, 36);
            this.btnNextR.TabIndex = 2;
            this.btnNextR.Text = "Next";
            this.btnNextR.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnNextR.UseAccentColor = false;
            this.btnNextR.UseVisualStyleBackColor = true;
            this.btnNextR.Click += new System.EventHandler(this.btnNextR_Click);
            // 
            // btnLastR
            // 
            this.btnLastR.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLastR.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLastR.Depth = 0;
            this.btnLastR.HighEmphasis = true;
            this.btnLastR.Icon = ((System.Drawing.Image)(resources.GetObject("btnLastR.Icon")));
            this.btnLastR.Location = new System.Drawing.Point(423, 17);
            this.btnLastR.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLastR.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLastR.Name = "btnLastR";
            this.btnLastR.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLastR.Size = new System.Drawing.Size(85, 36);
            this.btnLastR.TabIndex = 1;
            this.btnLastR.Text = "Last";
            this.btnLastR.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnLastR.UseAccentColor = false;
            this.btnLastR.UseVisualStyleBackColor = true;
            this.btnLastR.Click += new System.EventHandler(this.btnLastR_Click);
            // 
            // btnDeleteAllR
            // 
            this.btnDeleteAllR.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeleteAllR.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDeleteAllR.Depth = 0;
            this.btnDeleteAllR.HighEmphasis = true;
            this.btnDeleteAllR.Icon = ((System.Drawing.Image)(resources.GetObject("btnDeleteAllR.Icon")));
            this.btnDeleteAllR.Location = new System.Drawing.Point(402, 311);
            this.btnDeleteAllR.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDeleteAllR.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDeleteAllR.Name = "btnDeleteAllR";
            this.btnDeleteAllR.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDeleteAllR.Size = new System.Drawing.Size(131, 36);
            this.btnDeleteAllR.TabIndex = 59;
            this.btnDeleteAllR.Text = "Delete All";
            this.btnDeleteAllR.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDeleteAllR.UseAccentColor = true;
            this.btnDeleteAllR.UseVisualStyleBackColor = true;
            this.btnDeleteAllR.Click += new System.EventHandler(this.btnDeleteAllR_Click);
            // 
            // btnDeleteR
            // 
            this.btnDeleteR.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeleteR.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDeleteR.Depth = 0;
            this.btnDeleteR.HighEmphasis = true;
            this.btnDeleteR.Icon = ((System.Drawing.Image)(resources.GetObject("btnDeleteR.Icon")));
            this.btnDeleteR.Location = new System.Drawing.Point(195, 311);
            this.btnDeleteR.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDeleteR.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDeleteR.Name = "btnDeleteR";
            this.btnDeleteR.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDeleteR.Size = new System.Drawing.Size(101, 36);
            this.btnDeleteR.TabIndex = 58;
            this.btnDeleteR.Text = "Delete";
            this.btnDeleteR.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDeleteR.UseAccentColor = true;
            this.btnDeleteR.UseVisualStyleBackColor = true;
            this.btnDeleteR.Click += new System.EventHandler(this.btnDeleteR_Click);
            // 
            // btnSaveR
            // 
            this.btnSaveR.AutoSize = false;
            this.btnSaveR.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSaveR.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSaveR.Depth = 0;
            this.btnSaveR.HighEmphasis = true;
            this.btnSaveR.Icon = ((System.Drawing.Image)(resources.GetObject("btnSaveR.Icon")));
            this.btnSaveR.Location = new System.Drawing.Point(7, 474);
            this.btnSaveR.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSaveR.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSaveR.Name = "btnSaveR";
            this.btnSaveR.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSaveR.Size = new System.Drawing.Size(529, 49);
            this.btnSaveR.TabIndex = 57;
            this.btnSaveR.Text = "Save And Print";
            this.btnSaveR.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSaveR.UseAccentColor = false;
            this.btnSaveR.UseVisualStyleBackColor = true;
            this.btnSaveR.Click += new System.EventHandler(this.btnSaveR_Click);
            // 
            // btnNewR
            // 
            this.btnNewR.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNewR.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnNewR.Depth = 0;
            this.btnNewR.HighEmphasis = true;
            this.btnNewR.Icon = ((System.Drawing.Image)(resources.GetObject("btnNewR.Icon")));
            this.btnNewR.Location = new System.Drawing.Point(7, 311);
            this.btnNewR.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNewR.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNewR.Name = "btnNewR";
            this.btnNewR.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnNewR.Size = new System.Drawing.Size(81, 36);
            this.btnNewR.TabIndex = 56;
            this.btnNewR.Text = "New";
            this.btnNewR.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnNewR.UseAccentColor = false;
            this.btnNewR.UseVisualStyleBackColor = true;
            this.btnNewR.Click += new System.EventHandler(this.btnNewR_Click);
            // 
            // VoucherExchange
            // 
            this.VoucherExchange.Controls.Add(this.pictureBox1);
            this.VoucherExchange.Controls.Add(this.groupBox2);
            this.VoucherExchange.Controls.Add(this.groupBox3);
            this.VoucherExchange.Controls.Add(this.btnDeleteAll);
            this.VoucherExchange.Controls.Add(this.btnDelete);
            this.VoucherExchange.Controls.Add(this.btnSavePrint);
            this.VoucherExchange.Controls.Add(this.btnNew);
            this.VoucherExchange.Location = new System.Drawing.Point(4, 25);
            this.VoucherExchange.Name = "VoucherExchange";
            this.VoucherExchange.Padding = new System.Windows.Forms.Padding(3);
            this.VoucherExchange.Size = new System.Drawing.Size(1153, 522);
            this.VoucherExchange.TabIndex = 1;
            this.VoucherExchange.Text = "Receipt";
            this.VoucherExchange.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(542, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(629, 552);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 69;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCashingTO);
            this.groupBox2.Controls.Add(this.txtResponsibleExchange);
            this.groupBox2.Controls.Add(this.NumAmountR);
            this.groupBox2.Controls.Add(this.DateBondR);
            this.groupBox2.Controls.Add(this.txtNumberBondR);
            this.groupBox2.Controls.Add(this.txtReasonR);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(7, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(529, 241);
            this.groupBox2.TabIndex = 68;
            this.groupBox2.TabStop = false;
            // 
            // txtCashingTO
            // 
            this.txtCashingTO.AccessibleName = "";
            this.txtCashingTO.AnimateReadOnly = false;
            this.txtCashingTO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtCashingTO.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCashingTO.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtCashingTO.Depth = 0;
            this.txtCashingTO.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCashingTO.Hint = "Cashing To";
            this.txtCashingTO.LeadingIcon = null;
            this.txtCashingTO.Location = new System.Drawing.Point(31, 180);
            this.txtCashingTO.MaxLength = 50;
            this.txtCashingTO.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCashingTO.Multiline = false;
            this.txtCashingTO.Name = "txtCashingTO";
            this.txtCashingTO.Size = new System.Drawing.Size(214, 50);
            this.txtCashingTO.TabIndex = 54;
            this.txtCashingTO.Text = "";
            this.txtCashingTO.TrailingIcon = null;
            // 
            // txtResponsibleExchange
            // 
            this.txtResponsibleExchange.AccessibleName = "";
            this.txtResponsibleExchange.AnimateReadOnly = false;
            this.txtResponsibleExchange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtResponsibleExchange.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResponsibleExchange.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtResponsibleExchange.Depth = 0;
            this.txtResponsibleExchange.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtResponsibleExchange.Hint = "Responsible For Exchange";
            this.txtResponsibleExchange.LeadingIcon = null;
            this.txtResponsibleExchange.Location = new System.Drawing.Point(31, 102);
            this.txtResponsibleExchange.MaxLength = 50;
            this.txtResponsibleExchange.MouseState = MaterialSkin.MouseState.OUT;
            this.txtResponsibleExchange.Multiline = false;
            this.txtResponsibleExchange.Name = "txtResponsibleExchange";
            this.txtResponsibleExchange.Size = new System.Drawing.Size(214, 50);
            this.txtResponsibleExchange.TabIndex = 53;
            this.txtResponsibleExchange.Text = "";
            this.txtResponsibleExchange.TrailingIcon = null;
            // 
            // NumAmountR
            // 
            this.NumAmountR.DecimalPlaces = 2;
            this.NumAmountR.Location = new System.Drawing.Point(276, 108);
            this.NumAmountR.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.NumAmountR.Name = "NumAmountR";
            this.NumAmountR.Size = new System.Drawing.Size(222, 26);
            this.NumAmountR.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.NumAmountR.TabIndex = 18;
            this.NumAmountR.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // DateBondR
            // 
            this.DateBondR.CalendarFont = new System.Drawing.Font("Tahoma", 9F);
            this.DateBondR.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.DateBondR.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.DateBondR.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.DateBondR.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.DateBondR.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.DateBondR.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.DateBondR.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateBondR.Location = new System.Drawing.Point(276, 51);
            this.DateBondR.Name = "DateBondR";
            this.DateBondR.Size = new System.Drawing.Size(222, 26);
            this.DateBondR.TabIndex = 52;
            // 
            // txtNumberBondR
            // 
            this.txtNumberBondR.AccessibleName = "";
            this.txtNumberBondR.AnimateReadOnly = false;
            this.txtNumberBondR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtNumberBondR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumberBondR.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtNumberBondR.Depth = 0;
            this.txtNumberBondR.Enabled = false;
            this.txtNumberBondR.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNumberBondR.Hint = "Bond Number";
            this.txtNumberBondR.LeadingIcon = null;
            this.txtNumberBondR.Location = new System.Drawing.Point(31, 28);
            this.txtNumberBondR.MaxLength = 50;
            this.txtNumberBondR.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNumberBondR.Multiline = false;
            this.txtNumberBondR.Name = "txtNumberBondR";
            this.txtNumberBondR.Size = new System.Drawing.Size(214, 50);
            this.txtNumberBondR.TabIndex = 10;
            this.txtNumberBondR.Text = "";
            this.txtNumberBondR.TrailingIcon = null;
            // 
            // txtReasonR
            // 
            this.txtReasonR.AnimateReadOnly = false;
            this.txtReasonR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtReasonR.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtReasonR.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtReasonR.Depth = 0;
            this.txtReasonR.HideSelection = true;
            this.txtReasonR.Hint = "Reason";
            this.txtReasonR.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtReasonR.Location = new System.Drawing.Point(270, 145);
            this.txtReasonR.MaxLength = 32767;
            this.txtReasonR.MouseState = MaterialSkin.MouseState.OUT;
            this.txtReasonR.Name = "txtReasonR";
            this.txtReasonR.PasswordChar = '\0';
            this.txtReasonR.ReadOnly = false;
            this.txtReasonR.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtReasonR.SelectedText = "";
            this.txtReasonR.SelectionLength = 0;
            this.txtReasonR.SelectionStart = 0;
            this.txtReasonR.ShortcutsEnabled = true;
            this.txtReasonR.Size = new System.Drawing.Size(228, 85);
            this.txtReasonR.TabIndex = 32;
            this.txtReasonR.TabStop = false;
            this.txtReasonR.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtReasonR.UseSystemPasswordChar = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(276, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Date Bond :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(277, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Amount :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnFirst);
            this.groupBox3.Controls.Add(this.btnPrevious);
            this.groupBox3.Controls.Add(this.btnNext);
            this.groupBox3.Controls.Add(this.btnLast);
            this.groupBox3.Location = new System.Drawing.Point(7, 378);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(529, 63);
            this.groupBox3.TabIndex = 67;
            this.groupBox3.TabStop = false;
            // 
            // btnFirst
            // 
            this.btnFirst.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFirst.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnFirst.Depth = 0;
            this.btnFirst.HighEmphasis = true;
            this.btnFirst.Icon = ((System.Drawing.Image)(resources.GetObject("btnFirst.Icon")));
            this.btnFirst.Location = new System.Drawing.Point(22, 17);
            this.btnFirst.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnFirst.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnFirst.Size = new System.Drawing.Size(89, 36);
            this.btnFirst.TabIndex = 4;
            this.btnFirst.Text = "First";
            this.btnFirst.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnFirst.UseAccentColor = false;
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPrevious.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnPrevious.Depth = 0;
            this.btnPrevious.HighEmphasis = true;
            this.btnPrevious.Icon = ((System.Drawing.Image)(resources.GetObject("btnPrevious.Icon")));
            this.btnPrevious.Location = new System.Drawing.Point(134, 17);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPrevious.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnPrevious.Size = new System.Drawing.Size(119, 36);
            this.btnPrevious.TabIndex = 3;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnPrevious.UseAccentColor = false;
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNext.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnNext.Depth = 0;
            this.btnNext.HighEmphasis = true;
            this.btnNext.Icon = ((System.Drawing.Image)(resources.GetObject("btnNext.Icon")));
            this.btnNext.Location = new System.Drawing.Point(291, 17);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNext.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNext.Name = "btnNext";
            this.btnNext.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnNext.Size = new System.Drawing.Size(86, 36);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next";
            this.btnNext.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnNext.UseAccentColor = false;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLast.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLast.Depth = 0;
            this.btnLast.HighEmphasis = true;
            this.btnLast.Icon = ((System.Drawing.Image)(resources.GetObject("btnLast.Icon")));
            this.btnLast.Location = new System.Drawing.Point(423, 17);
            this.btnLast.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLast.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLast.Name = "btnLast";
            this.btnLast.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLast.Size = new System.Drawing.Size(85, 36);
            this.btnLast.TabIndex = 1;
            this.btnLast.Text = "Last";
            this.btnLast.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnLast.UseAccentColor = false;
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeleteAll.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDeleteAll.Depth = 0;
            this.btnDeleteAll.HighEmphasis = true;
            this.btnDeleteAll.Icon = ((System.Drawing.Image)(resources.GetObject("btnDeleteAll.Icon")));
            this.btnDeleteAll.Location = new System.Drawing.Point(402, 311);
            this.btnDeleteAll.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDeleteAll.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDeleteAll.Size = new System.Drawing.Size(131, 36);
            this.btnDeleteAll.TabIndex = 66;
            this.btnDeleteAll.Text = "Delete All";
            this.btnDeleteAll.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDeleteAll.UseAccentColor = true;
            this.btnDeleteAll.UseVisualStyleBackColor = true;
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDelete.Depth = 0;
            this.btnDelete.HighEmphasis = true;
            this.btnDelete.Icon = ((System.Drawing.Image)(resources.GetObject("btnDelete.Icon")));
            this.btnDelete.Location = new System.Drawing.Point(195, 311);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDelete.Size = new System.Drawing.Size(101, 36);
            this.btnDelete.TabIndex = 65;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDelete.UseAccentColor = true;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSavePrint
            // 
            this.btnSavePrint.AutoSize = false;
            this.btnSavePrint.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSavePrint.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSavePrint.Depth = 0;
            this.btnSavePrint.HighEmphasis = true;
            this.btnSavePrint.Icon = ((System.Drawing.Image)(resources.GetObject("btnSavePrint.Icon")));
            this.btnSavePrint.Location = new System.Drawing.Point(7, 474);
            this.btnSavePrint.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSavePrint.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSavePrint.Name = "btnSavePrint";
            this.btnSavePrint.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSavePrint.Size = new System.Drawing.Size(529, 49);
            this.btnSavePrint.TabIndex = 64;
            this.btnSavePrint.Text = "Save And Print";
            this.btnSavePrint.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSavePrint.UseAccentColor = false;
            this.btnSavePrint.UseVisualStyleBackColor = true;
            this.btnSavePrint.Click += new System.EventHandler(this.btnSavePrint_Click);
            // 
            // btnNew
            // 
            this.btnNew.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNew.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnNew.Depth = 0;
            this.btnNew.HighEmphasis = true;
            this.btnNew.Icon = ((System.Drawing.Image)(resources.GetObject("btnNew.Icon")));
            this.btnNew.Location = new System.Drawing.Point(7, 311);
            this.btnNew.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNew.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNew.Name = "btnNew";
            this.btnNew.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnNew.Size = new System.Drawing.Size(81, 36);
            this.btnNew.TabIndex = 63;
            this.btnNew.Text = "New";
            this.btnNew.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnNew.UseAccentColor = false;
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // FrmBonds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 634);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.materialTabSelector1);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.MaximizeBox = false;
            this.Name = "FrmBonds";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBonds";
            this.Load += new System.EventHandler(this.FrmBonds_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.ReceiptVoucher.ResumeLayout(false);
            this.ReceiptVoucher.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.VoucherExchange.ResumeLayout(false);
            this.VoucherExchange.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage ReceiptVoucher;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private MaterialSkin.Controls.MaterialTextBox txtBondFrom;
        private MaterialSkin.Controls.MaterialTextBox txtResponsibleName;
        private ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown NumAmount;
        private System.Windows.Forms.DateTimePicker DateBond;
        private MaterialSkin.Controls.MaterialTextBox txtNumberBond;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtReason;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialButton btnFirstR;
        private MaterialSkin.Controls.MaterialButton btnPreviousR;
        private MaterialSkin.Controls.MaterialButton btnNextR;
        private MaterialSkin.Controls.MaterialButton btnLastR;
        private MaterialSkin.Controls.MaterialButton btnDeleteAllR;
        private MaterialSkin.Controls.MaterialButton btnDeleteR;
        private MaterialSkin.Controls.MaterialButton btnSaveR;
        private MaterialSkin.Controls.MaterialButton btnNewR;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialTextBox txtCashingTO;
        private MaterialSkin.Controls.MaterialTextBox txtResponsibleExchange;
        private ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown NumAmountR;
        private System.Windows.Forms.DateTimePicker DateBondR;
        private MaterialSkin.Controls.MaterialTextBox txtNumberBondR;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtReasonR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private MaterialSkin.Controls.MaterialButton btnFirst;
        private MaterialSkin.Controls.MaterialButton btnPrevious;
        private MaterialSkin.Controls.MaterialButton btnNext;
        private MaterialSkin.Controls.MaterialButton btnLast;
        private MaterialSkin.Controls.MaterialButton btnDeleteAll;
        private MaterialSkin.Controls.MaterialButton btnDelete;
        private MaterialSkin.Controls.MaterialButton btnSavePrint;
        private MaterialSkin.Controls.MaterialButton btnNew;
        public System.Windows.Forms.TabPage VoucherExchange;
    }
}