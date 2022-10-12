namespace SalesMangement
{
    partial class FrmGeneralSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGeneralSettings));
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.printsettings = new System.Windows.Forms.TabPage();
            this.InvoiceSettings = new System.Windows.Forms.TabPage();
            this.Options = new System.Windows.Forms.TabPage();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.cbxMainPrinter = new MaterialSkin.Controls.MaterialComboBox();
            this.btnCancel = new MaterialSkin.Controls.MaterialButton();
            this.btnSaveData = new MaterialSkin.Controls.MaterialButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btnUploadPhoto = new MaterialSkin.Controls.MaterialButton();
            this.btnDeletePhoto = new MaterialSkin.Controls.MaterialButton();
            this.txtStoreName = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.txtStoreAddress = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.txtPhoneNumber1 = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.txtPhoneNumber2 = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.txtInvoiceNote = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.btnSave = new MaterialSkin.Controls.MaterialButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.RadioBtnValueMoney = new MaterialSkin.Controls.MaterialRadioButton();
            this.RadioBtnPercentage = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.NumNumberCopiesSales = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.NumNumberCopiesPurchase = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.RadioButtonPrintSA4 = new MaterialSkin.Controls.MaterialRadioButton();
            this.RadioButtonPrintS8c = new MaterialSkin.Controls.MaterialRadioButton();
            this.RadioButtonPrintP8c = new MaterialSkin.Controls.MaterialRadioButton();
            this.RadioButtonPrintPA4 = new MaterialSkin.Controls.MaterialRadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.CheckboxActivateTax = new MaterialSkin.Controls.MaterialCheckbox();
            this.CheckboxActivatePrintSales = new MaterialSkin.Controls.MaterialCheckbox();
            this.CheckboxActivateDiscountEmp = new MaterialSkin.Controls.MaterialCheckbox();
            this.CheckboxActivatePrintBuy = new MaterialSkin.Controls.MaterialCheckbox();
            this.btnSaveOption = new MaterialSkin.Controls.MaterialButton();
            this.materialTabControl1.SuspendLayout();
            this.printsettings.SuspendLayout();
            this.InvoiceSettings.SuspendLayout();
            this.Options.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
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
            this.materialTabSelector1.Size = new System.Drawing.Size(1199, 48);
            this.materialTabSelector1.TabIndex = 0;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.printsettings);
            this.materialTabControl1.Controls.Add(this.InvoiceSettings);
            this.materialTabControl1.Controls.Add(this.Options);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(6, 78);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1160, 550);
            this.materialTabControl1.TabIndex = 1;
            // 
            // printsettings
            // 
            this.printsettings.Controls.Add(this.groupBox1);
            this.printsettings.Controls.Add(this.pictureBox9);
            this.printsettings.Location = new System.Drawing.Point(4, 25);
            this.printsettings.Name = "printsettings";
            this.printsettings.Padding = new System.Windows.Forms.Padding(3);
            this.printsettings.Size = new System.Drawing.Size(1152, 521);
            this.printsettings.TabIndex = 0;
            this.printsettings.Text = "Print Settings";
            this.printsettings.UseVisualStyleBackColor = true;
            // 
            // InvoiceSettings
            // 
            this.InvoiceSettings.Controls.Add(this.btnSave);
            this.InvoiceSettings.Controls.Add(this.txtInvoiceNote);
            this.InvoiceSettings.Controls.Add(this.txtPhoneNumber2);
            this.InvoiceSettings.Controls.Add(this.txtPhoneNumber1);
            this.InvoiceSettings.Controls.Add(this.txtStoreAddress);
            this.InvoiceSettings.Controls.Add(this.txtStoreName);
            this.InvoiceSettings.Controls.Add(this.btnDeletePhoto);
            this.InvoiceSettings.Controls.Add(this.btnUploadPhoto);
            this.InvoiceSettings.Controls.Add(this.materialLabel1);
            this.InvoiceSettings.Controls.Add(this.pictureBox2);
            this.InvoiceSettings.Controls.Add(this.pictureLogo);
            this.InvoiceSettings.Location = new System.Drawing.Point(4, 25);
            this.InvoiceSettings.Name = "InvoiceSettings";
            this.InvoiceSettings.Padding = new System.Windows.Forms.Padding(3);
            this.InvoiceSettings.Size = new System.Drawing.Size(1152, 521);
            this.InvoiceSettings.TabIndex = 1;
            this.InvoiceSettings.Text = "Invoice Settings";
            this.InvoiceSettings.UseVisualStyleBackColor = true;
            // 
            // Options
            // 
            this.Options.Controls.Add(this.btnSaveOption);
            this.Options.Controls.Add(this.groupBox5);
            this.Options.Controls.Add(this.groupBox4);
            this.Options.Controls.Add(this.groupBox3);
            this.Options.Controls.Add(this.groupBox2);
            this.Options.Controls.Add(this.pictureBox1);
            this.Options.Location = new System.Drawing.Point(4, 25);
            this.Options.Name = "Options";
            this.Options.Size = new System.Drawing.Size(1152, 521);
            this.Options.TabIndex = 2;
            this.Options.Text = "Options";
            this.Options.UseVisualStyleBackColor = true;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(551, 27);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(598, 515);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 19;
            this.pictureBox9.TabStop = false;
            // 
            // cbxMainPrinter
            // 
            this.cbxMainPrinter.AutoResize = false;
            this.cbxMainPrinter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbxMainPrinter.Depth = 0;
            this.cbxMainPrinter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbxMainPrinter.DropDownHeight = 174;
            this.cbxMainPrinter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMainPrinter.DropDownWidth = 121;
            this.cbxMainPrinter.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbxMainPrinter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbxMainPrinter.FormattingEnabled = true;
            this.cbxMainPrinter.Hint = "Select the main printer";
            this.cbxMainPrinter.IntegralHeight = false;
            this.cbxMainPrinter.ItemHeight = 43;
            this.cbxMainPrinter.Location = new System.Drawing.Point(28, 29);
            this.cbxMainPrinter.MaxDropDownItems = 4;
            this.cbxMainPrinter.MouseState = MaterialSkin.MouseState.OUT;
            this.cbxMainPrinter.Name = "cbxMainPrinter";
            this.cbxMainPrinter.Size = new System.Drawing.Size(354, 49);
            this.cbxMainPrinter.StartIndex = 0;
            this.cbxMainPrinter.TabIndex = 20;
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = false;
            this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCancel.Depth = 0;
            this.btnCancel.HighEmphasis = true;
            this.btnCancel.Icon = ((System.Drawing.Image)(resources.GetObject("btnCancel.Icon")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnCancel.Location = new System.Drawing.Point(271, 87);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCancel.Size = new System.Drawing.Size(111, 41);
            this.btnCancel.TabIndex = 57;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnCancel.UseAccentColor = false;
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSaveData
            // 
            this.btnSaveData.AutoSize = false;
            this.btnSaveData.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSaveData.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSaveData.Depth = 0;
            this.btnSaveData.HighEmphasis = true;
            this.btnSaveData.Icon = ((System.Drawing.Image)(resources.GetObject("btnSaveData.Icon")));
            this.btnSaveData.Location = new System.Drawing.Point(28, 87);
            this.btnSaveData.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSaveData.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSaveData.Name = "btnSaveData";
            this.btnSaveData.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSaveData.Size = new System.Drawing.Size(235, 41);
            this.btnSaveData.TabIndex = 56;
            this.btnSaveData.Text = "Save Data";
            this.btnSaveData.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSaveData.UseAccentColor = false;
            this.btnSaveData.UseVisualStyleBackColor = true;
            this.btnSaveData.Click += new System.EventHandler(this.btnSaveData_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxMainPrinter);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnSaveData);
            this.groupBox1.Location = new System.Drawing.Point(73, 186);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 150);
            this.groupBox1.TabIndex = 58;
            this.groupBox1.TabStop = false;
            // 
            // pictureLogo
            // 
            this.pictureLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureLogo.Location = new System.Drawing.Point(12, 60);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(276, 141);
            this.pictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureLogo.TabIndex = 0;
            this.pictureLogo.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(599, 21);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(550, 515);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(12, 27);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(78, 19);
            this.materialLabel1.TabIndex = 22;
            this.materialLabel1.Text = "Store Logo";
            // 
            // btnUploadPhoto
            // 
            this.btnUploadPhoto.AutoSize = false;
            this.btnUploadPhoto.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUploadPhoto.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnUploadPhoto.Depth = 0;
            this.btnUploadPhoto.HighEmphasis = true;
            this.btnUploadPhoto.Icon = ((System.Drawing.Image)(resources.GetObject("btnUploadPhoto.Icon")));
            this.btnUploadPhoto.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnUploadPhoto.Location = new System.Drawing.Point(12, 212);
            this.btnUploadPhoto.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnUploadPhoto.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUploadPhoto.Name = "btnUploadPhoto";
            this.btnUploadPhoto.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnUploadPhoto.Size = new System.Drawing.Size(150, 40);
            this.btnUploadPhoto.TabIndex = 58;
            this.btnUploadPhoto.Text = "Upload Photo";
            this.btnUploadPhoto.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnUploadPhoto.UseAccentColor = false;
            this.btnUploadPhoto.UseVisualStyleBackColor = true;
            this.btnUploadPhoto.Click += new System.EventHandler(this.btnUploadPhoto_Click);
            // 
            // btnDeletePhoto
            // 
            this.btnDeletePhoto.AutoSize = false;
            this.btnDeletePhoto.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeletePhoto.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDeletePhoto.Depth = 0;
            this.btnDeletePhoto.HighEmphasis = true;
            this.btnDeletePhoto.Icon = ((System.Drawing.Image)(resources.GetObject("btnDeletePhoto.Icon")));
            this.btnDeletePhoto.Location = new System.Drawing.Point(170, 212);
            this.btnDeletePhoto.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDeletePhoto.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDeletePhoto.Name = "btnDeletePhoto";
            this.btnDeletePhoto.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDeletePhoto.Size = new System.Drawing.Size(118, 40);
            this.btnDeletePhoto.TabIndex = 62;
            this.btnDeletePhoto.Text = "Delete";
            this.btnDeletePhoto.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDeletePhoto.UseAccentColor = true;
            this.btnDeletePhoto.UseVisualStyleBackColor = true;
            this.btnDeletePhoto.Click += new System.EventHandler(this.btnDeletePhoto_Click);
            // 
            // txtStoreName
            // 
            this.txtStoreName.AllowPromptAsInput = true;
            this.txtStoreName.AnimateReadOnly = false;
            this.txtStoreName.AsciiOnly = false;
            this.txtStoreName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtStoreName.BeepOnError = false;
            this.txtStoreName.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtStoreName.Depth = 0;
            this.txtStoreName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtStoreName.HidePromptOnLeave = false;
            this.txtStoreName.HideSelection = true;
            this.txtStoreName.Hint = "Store Name";
            this.txtStoreName.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtStoreName.LeadingIcon = ((System.Drawing.Image)(resources.GetObject("txtStoreName.LeadingIcon")));
            this.txtStoreName.Location = new System.Drawing.Point(12, 291);
            this.txtStoreName.Mask = "";
            this.txtStoreName.MaxLength = 32767;
            this.txtStoreName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtStoreName.Name = "txtStoreName";
            this.txtStoreName.PasswordChar = '\0';
            this.txtStoreName.PrefixSuffixText = null;
            this.txtStoreName.PromptChar = '_';
            this.txtStoreName.ReadOnly = false;
            this.txtStoreName.RejectInputOnFirstFailure = false;
            this.txtStoreName.ResetOnPrompt = true;
            this.txtStoreName.ResetOnSpace = true;
            this.txtStoreName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtStoreName.SelectedText = "";
            this.txtStoreName.SelectionLength = 0;
            this.txtStoreName.SelectionStart = 0;
            this.txtStoreName.ShortcutsEnabled = true;
            this.txtStoreName.Size = new System.Drawing.Size(276, 48);
            this.txtStoreName.SkipLiterals = true;
            this.txtStoreName.TabIndex = 63;
            this.txtStoreName.TabStop = false;
            this.txtStoreName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtStoreName.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtStoreName.TrailingIcon = null;
            this.txtStoreName.UseSystemPasswordChar = false;
            this.txtStoreName.ValidatingType = null;
            // 
            // txtStoreAddress
            // 
            this.txtStoreAddress.AllowPromptAsInput = true;
            this.txtStoreAddress.AnimateReadOnly = false;
            this.txtStoreAddress.AsciiOnly = false;
            this.txtStoreAddress.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtStoreAddress.BeepOnError = false;
            this.txtStoreAddress.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtStoreAddress.Depth = 0;
            this.txtStoreAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtStoreAddress.HidePromptOnLeave = false;
            this.txtStoreAddress.HideSelection = true;
            this.txtStoreAddress.Hint = "Store Address";
            this.txtStoreAddress.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtStoreAddress.LeadingIcon = ((System.Drawing.Image)(resources.GetObject("txtStoreAddress.LeadingIcon")));
            this.txtStoreAddress.Location = new System.Drawing.Point(12, 356);
            this.txtStoreAddress.Mask = "";
            this.txtStoreAddress.MaxLength = 32767;
            this.txtStoreAddress.MouseState = MaterialSkin.MouseState.OUT;
            this.txtStoreAddress.Name = "txtStoreAddress";
            this.txtStoreAddress.PasswordChar = '\0';
            this.txtStoreAddress.PrefixSuffixText = null;
            this.txtStoreAddress.PromptChar = '_';
            this.txtStoreAddress.ReadOnly = false;
            this.txtStoreAddress.RejectInputOnFirstFailure = false;
            this.txtStoreAddress.ResetOnPrompt = true;
            this.txtStoreAddress.ResetOnSpace = true;
            this.txtStoreAddress.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtStoreAddress.SelectedText = "";
            this.txtStoreAddress.SelectionLength = 0;
            this.txtStoreAddress.SelectionStart = 0;
            this.txtStoreAddress.ShortcutsEnabled = true;
            this.txtStoreAddress.Size = new System.Drawing.Size(276, 48);
            this.txtStoreAddress.SkipLiterals = true;
            this.txtStoreAddress.TabIndex = 64;
            this.txtStoreAddress.TabStop = false;
            this.txtStoreAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtStoreAddress.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtStoreAddress.TrailingIcon = null;
            this.txtStoreAddress.UseSystemPasswordChar = false;
            this.txtStoreAddress.ValidatingType = null;
            // 
            // txtPhoneNumber1
            // 
            this.txtPhoneNumber1.AllowPromptAsInput = true;
            this.txtPhoneNumber1.AnimateReadOnly = false;
            this.txtPhoneNumber1.AsciiOnly = false;
            this.txtPhoneNumber1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtPhoneNumber1.BeepOnError = false;
            this.txtPhoneNumber1.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtPhoneNumber1.Depth = 0;
            this.txtPhoneNumber1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPhoneNumber1.HidePromptOnLeave = false;
            this.txtPhoneNumber1.HideSelection = true;
            this.txtPhoneNumber1.Hint = "Phone Number 1";
            this.txtPhoneNumber1.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtPhoneNumber1.LeadingIcon = ((System.Drawing.Image)(resources.GetObject("txtPhoneNumber1.LeadingIcon")));
            this.txtPhoneNumber1.Location = new System.Drawing.Point(306, 291);
            this.txtPhoneNumber1.Mask = "";
            this.txtPhoneNumber1.MaxLength = 32767;
            this.txtPhoneNumber1.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPhoneNumber1.Name = "txtPhoneNumber1";
            this.txtPhoneNumber1.PasswordChar = '\0';
            this.txtPhoneNumber1.PrefixSuffixText = null;
            this.txtPhoneNumber1.PromptChar = '_';
            this.txtPhoneNumber1.ReadOnly = false;
            this.txtPhoneNumber1.RejectInputOnFirstFailure = false;
            this.txtPhoneNumber1.ResetOnPrompt = true;
            this.txtPhoneNumber1.ResetOnSpace = true;
            this.txtPhoneNumber1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPhoneNumber1.SelectedText = "";
            this.txtPhoneNumber1.SelectionLength = 0;
            this.txtPhoneNumber1.SelectionStart = 0;
            this.txtPhoneNumber1.ShortcutsEnabled = true;
            this.txtPhoneNumber1.Size = new System.Drawing.Size(276, 48);
            this.txtPhoneNumber1.SkipLiterals = true;
            this.txtPhoneNumber1.TabIndex = 65;
            this.txtPhoneNumber1.TabStop = false;
            this.txtPhoneNumber1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPhoneNumber1.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtPhoneNumber1.TrailingIcon = null;
            this.txtPhoneNumber1.UseSystemPasswordChar = false;
            this.txtPhoneNumber1.ValidatingType = null;
            // 
            // txtPhoneNumber2
            // 
            this.txtPhoneNumber2.AllowPromptAsInput = true;
            this.txtPhoneNumber2.AnimateReadOnly = false;
            this.txtPhoneNumber2.AsciiOnly = false;
            this.txtPhoneNumber2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtPhoneNumber2.BeepOnError = false;
            this.txtPhoneNumber2.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtPhoneNumber2.Depth = 0;
            this.txtPhoneNumber2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPhoneNumber2.HidePromptOnLeave = false;
            this.txtPhoneNumber2.HideSelection = true;
            this.txtPhoneNumber2.Hint = "Phone Number 2";
            this.txtPhoneNumber2.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtPhoneNumber2.LeadingIcon = ((System.Drawing.Image)(resources.GetObject("txtPhoneNumber2.LeadingIcon")));
            this.txtPhoneNumber2.Location = new System.Drawing.Point(306, 358);
            this.txtPhoneNumber2.Mask = "";
            this.txtPhoneNumber2.MaxLength = 32767;
            this.txtPhoneNumber2.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPhoneNumber2.Name = "txtPhoneNumber2";
            this.txtPhoneNumber2.PasswordChar = '\0';
            this.txtPhoneNumber2.PrefixSuffixText = null;
            this.txtPhoneNumber2.PromptChar = '_';
            this.txtPhoneNumber2.ReadOnly = false;
            this.txtPhoneNumber2.RejectInputOnFirstFailure = false;
            this.txtPhoneNumber2.ResetOnPrompt = true;
            this.txtPhoneNumber2.ResetOnSpace = true;
            this.txtPhoneNumber2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPhoneNumber2.SelectedText = "";
            this.txtPhoneNumber2.SelectionLength = 0;
            this.txtPhoneNumber2.SelectionStart = 0;
            this.txtPhoneNumber2.ShortcutsEnabled = true;
            this.txtPhoneNumber2.Size = new System.Drawing.Size(276, 48);
            this.txtPhoneNumber2.SkipLiterals = true;
            this.txtPhoneNumber2.TabIndex = 66;
            this.txtPhoneNumber2.TabStop = false;
            this.txtPhoneNumber2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPhoneNumber2.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtPhoneNumber2.TrailingIcon = null;
            this.txtPhoneNumber2.UseSystemPasswordChar = false;
            this.txtPhoneNumber2.ValidatingType = null;
            // 
            // txtInvoiceNote
            // 
            this.txtInvoiceNote.AnimateReadOnly = false;
            this.txtInvoiceNote.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtInvoiceNote.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtInvoiceNote.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtInvoiceNote.Depth = 0;
            this.txtInvoiceNote.HideSelection = true;
            this.txtInvoiceNote.Hint = "Invoice Note";
            this.txtInvoiceNote.Location = new System.Drawing.Point(309, 60);
            this.txtInvoiceNote.MaxLength = 32767;
            this.txtInvoiceNote.MouseState = MaterialSkin.MouseState.OUT;
            this.txtInvoiceNote.Name = "txtInvoiceNote";
            this.txtInvoiceNote.PasswordChar = '\0';
            this.txtInvoiceNote.ReadOnly = false;
            this.txtInvoiceNote.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtInvoiceNote.SelectedText = "";
            this.txtInvoiceNote.SelectionLength = 0;
            this.txtInvoiceNote.SelectionStart = 0;
            this.txtInvoiceNote.ShortcutsEnabled = true;
            this.txtInvoiceNote.Size = new System.Drawing.Size(273, 141);
            this.txtInvoiceNote.TabIndex = 67;
            this.txtInvoiceNote.TabStop = false;
            this.txtInvoiceNote.Text = "Thank you for purchase!";
            this.txtInvoiceNote.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtInvoiceNote.UseSystemPasswordChar = false;
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = false;
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSave.Depth = 0;
            this.btnSave.HighEmphasis = true;
            this.btnSave.Icon = ((System.Drawing.Image)(resources.GetObject("btnSave.Icon")));
            this.btnSave.Location = new System.Drawing.Point(6, 438);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSave.Size = new System.Drawing.Size(586, 41);
            this.btnSave.TabIndex = 68;
            this.btnSave.Text = "Save Data";
            this.btnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSave.UseAccentColor = false;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(606, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(543, 515);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.materialLabel3);
            this.groupBox2.Controls.Add(this.NumNumberCopiesPurchase);
            this.groupBox2.Controls.Add(this.materialLabel5);
            this.groupBox2.Controls.Add(this.NumNumberCopiesSales);
            this.groupBox2.Controls.Add(this.RadioBtnPercentage);
            this.groupBox2.Controls.Add(this.RadioBtnValueMoney);
            this.groupBox2.Controls.Add(this.materialLabel2);
            this.groupBox2.Controls.Add(this.pictureBox3);
            this.groupBox2.Location = new System.Drawing.Point(3, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(597, 230);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.ErrorImage")));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(518, 14);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(46, 40);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(466, 19);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Do you want to have discount on products a percentage or value ?";
            // 
            // RadioBtnValueMoney
            // 
            this.RadioBtnValueMoney.AutoSize = true;
            this.RadioBtnValueMoney.Checked = true;
            this.RadioBtnValueMoney.Depth = 0;
            this.RadioBtnValueMoney.Location = new System.Drawing.Point(90, 80);
            this.RadioBtnValueMoney.Margin = new System.Windows.Forms.Padding(0);
            this.RadioBtnValueMoney.MouseLocation = new System.Drawing.Point(-1, -1);
            this.RadioBtnValueMoney.MouseState = MaterialSkin.MouseState.HOVER;
            this.RadioBtnValueMoney.Name = "RadioBtnValueMoney";
            this.RadioBtnValueMoney.Ripple = true;
            this.RadioBtnValueMoney.Size = new System.Drawing.Size(144, 37);
            this.RadioBtnValueMoney.TabIndex = 2;
            this.RadioBtnValueMoney.TabStop = true;
            this.RadioBtnValueMoney.Text = "value of Money";
            this.RadioBtnValueMoney.UseVisualStyleBackColor = true;
            // 
            // RadioBtnPercentage
            // 
            this.RadioBtnPercentage.AutoSize = true;
            this.RadioBtnPercentage.Depth = 0;
            this.RadioBtnPercentage.Location = new System.Drawing.Point(316, 80);
            this.RadioBtnPercentage.Margin = new System.Windows.Forms.Padding(0);
            this.RadioBtnPercentage.MouseLocation = new System.Drawing.Point(-1, -1);
            this.RadioBtnPercentage.MouseState = MaterialSkin.MouseState.HOVER;
            this.RadioBtnPercentage.Name = "RadioBtnPercentage";
            this.RadioBtnPercentage.Ripple = true;
            this.RadioBtnPercentage.Size = new System.Drawing.Size(114, 37);
            this.RadioBtnPercentage.TabIndex = 3;
            this.RadioBtnPercentage.TabStop = true;
            this.RadioBtnPercentage.Text = "Percentage";
            this.RadioBtnPercentage.UseVisualStyleBackColor = true;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(46, 140);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(248, 19);
            this.materialLabel5.TabIndex = 53;
            this.materialLabel5.Text = "Number of copies of sales invoices";
            // 
            // NumNumberCopiesSales
            // 
            this.NumNumberCopiesSales.Location = new System.Drawing.Point(298, 136);
            this.NumNumberCopiesSales.Maximum = new decimal(new int[] {
            276447232,
            23283,
            0,
            0});
            this.NumNumberCopiesSales.Name = "NumNumberCopiesSales";
            this.NumNumberCopiesSales.Size = new System.Drawing.Size(146, 26);
            this.NumNumberCopiesSales.TabIndex = 52;
            this.NumNumberCopiesSales.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(46, 179);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(276, 19);
            this.materialLabel3.TabIndex = 55;
            this.materialLabel3.Text = "Number of copies of purchase invoices";
            // 
            // NumNumberCopiesPurchase
            // 
            this.NumNumberCopiesPurchase.Location = new System.Drawing.Point(328, 176);
            this.NumNumberCopiesPurchase.Maximum = new decimal(new int[] {
            276447232,
            23283,
            0,
            0});
            this.NumNumberCopiesPurchase.Name = "NumNumberCopiesPurchase";
            this.NumNumberCopiesPurchase.Size = new System.Drawing.Size(116, 26);
            this.NumNumberCopiesPurchase.TabIndex = 54;
            this.NumNumberCopiesPurchase.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.RadioButtonPrintS8c);
            this.groupBox3.Controls.Add(this.RadioButtonPrintSA4);
            this.groupBox3.Location = new System.Drawing.Point(3, 244);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(270, 87);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sales Invoice";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.RadioButtonPrintP8c);
            this.groupBox4.Controls.Add(this.RadioButtonPrintPA4);
            this.groupBox4.Location = new System.Drawing.Point(326, 244);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(270, 87);
            this.groupBox4.TabIndex = 24;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Purchase Invoice";
            // 
            // RadioButtonPrintSA4
            // 
            this.RadioButtonPrintSA4.AutoSize = true;
            this.RadioButtonPrintSA4.Checked = true;
            this.RadioButtonPrintSA4.Depth = 0;
            this.RadioButtonPrintSA4.Location = new System.Drawing.Point(8, 30);
            this.RadioButtonPrintSA4.Margin = new System.Windows.Forms.Padding(0);
            this.RadioButtonPrintSA4.MouseLocation = new System.Drawing.Point(-1, -1);
            this.RadioButtonPrintSA4.MouseState = MaterialSkin.MouseState.HOVER;
            this.RadioButtonPrintSA4.Name = "RadioButtonPrintSA4";
            this.RadioButtonPrintSA4.Ripple = true;
            this.RadioButtonPrintSA4.Size = new System.Drawing.Size(91, 37);
            this.RadioButtonPrintSA4.TabIndex = 4;
            this.RadioButtonPrintSA4.TabStop = true;
            this.RadioButtonPrintSA4.Text = "Print A4";
            this.RadioButtonPrintSA4.UseVisualStyleBackColor = true;
            // 
            // RadioButtonPrintS8c
            // 
            this.RadioButtonPrintS8c.AutoSize = true;
            this.RadioButtonPrintS8c.Depth = 0;
            this.RadioButtonPrintS8c.Location = new System.Drawing.Point(157, 30);
            this.RadioButtonPrintS8c.Margin = new System.Windows.Forms.Padding(0);
            this.RadioButtonPrintS8c.MouseLocation = new System.Drawing.Point(-1, -1);
            this.RadioButtonPrintS8c.MouseState = MaterialSkin.MouseState.HOVER;
            this.RadioButtonPrintS8c.Name = "RadioButtonPrintS8c";
            this.RadioButtonPrintS8c.Ripple = true;
            this.RadioButtonPrintS8c.Size = new System.Drawing.Size(102, 37);
            this.RadioButtonPrintS8c.TabIndex = 5;
            this.RadioButtonPrintS8c.TabStop = true;
            this.RadioButtonPrintS8c.Text = "print 8cm";
            this.RadioButtonPrintS8c.UseVisualStyleBackColor = true;
            // 
            // RadioButtonPrintP8c
            // 
            this.RadioButtonPrintP8c.AutoSize = true;
            this.RadioButtonPrintP8c.Depth = 0;
            this.RadioButtonPrintP8c.Location = new System.Drawing.Point(158, 30);
            this.RadioButtonPrintP8c.Margin = new System.Windows.Forms.Padding(0);
            this.RadioButtonPrintP8c.MouseLocation = new System.Drawing.Point(-1, -1);
            this.RadioButtonPrintP8c.MouseState = MaterialSkin.MouseState.HOVER;
            this.RadioButtonPrintP8c.Name = "RadioButtonPrintP8c";
            this.RadioButtonPrintP8c.Ripple = true;
            this.RadioButtonPrintP8c.Size = new System.Drawing.Size(102, 37);
            this.RadioButtonPrintP8c.TabIndex = 7;
            this.RadioButtonPrintP8c.TabStop = true;
            this.RadioButtonPrintP8c.Text = "print 8cm";
            this.RadioButtonPrintP8c.UseVisualStyleBackColor = true;
            // 
            // RadioButtonPrintPA4
            // 
            this.RadioButtonPrintPA4.AutoSize = true;
            this.RadioButtonPrintPA4.Checked = true;
            this.RadioButtonPrintPA4.Depth = 0;
            this.RadioButtonPrintPA4.Location = new System.Drawing.Point(9, 30);
            this.RadioButtonPrintPA4.Margin = new System.Windows.Forms.Padding(0);
            this.RadioButtonPrintPA4.MouseLocation = new System.Drawing.Point(-1, -1);
            this.RadioButtonPrintPA4.MouseState = MaterialSkin.MouseState.HOVER;
            this.RadioButtonPrintPA4.Name = "RadioButtonPrintPA4";
            this.RadioButtonPrintPA4.Ripple = true;
            this.RadioButtonPrintPA4.Size = new System.Drawing.Size(91, 37);
            this.RadioButtonPrintPA4.TabIndex = 6;
            this.RadioButtonPrintPA4.TabStop = true;
            this.RadioButtonPrintPA4.Text = "Print A4";
            this.RadioButtonPrintPA4.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.CheckboxActivatePrintBuy);
            this.groupBox5.Controls.Add(this.CheckboxActivateDiscountEmp);
            this.groupBox5.Controls.Add(this.CheckboxActivatePrintSales);
            this.groupBox5.Controls.Add(this.CheckboxActivateTax);
            this.groupBox5.Location = new System.Drawing.Point(3, 337);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(597, 153);
            this.groupBox5.TabIndex = 25;
            this.groupBox5.TabStop = false;
            // 
            // CheckboxActivateTax
            // 
            this.CheckboxActivateTax.AutoSize = true;
            this.CheckboxActivateTax.Depth = 0;
            this.CheckboxActivateTax.Location = new System.Drawing.Point(16, 18);
            this.CheckboxActivateTax.Margin = new System.Windows.Forms.Padding(0);
            this.CheckboxActivateTax.MouseLocation = new System.Drawing.Point(-1, -1);
            this.CheckboxActivateTax.MouseState = MaterialSkin.MouseState.HOVER;
            this.CheckboxActivateTax.Name = "CheckboxActivateTax";
            this.CheckboxActivateTax.ReadOnly = false;
            this.CheckboxActivateTax.Ripple = true;
            this.CheckboxActivateTax.Size = new System.Drawing.Size(208, 37);
            this.CheckboxActivateTax.TabIndex = 0;
            this.CheckboxActivateTax.Text = "Activate value added tax";
            this.CheckboxActivateTax.UseVisualStyleBackColor = true;
            // 
            // CheckboxActivatePrintSales
            // 
            this.CheckboxActivatePrintSales.AutoSize = true;
            this.CheckboxActivatePrintSales.Depth = 0;
            this.CheckboxActivatePrintSales.Location = new System.Drawing.Point(234, 18);
            this.CheckboxActivatePrintSales.Margin = new System.Windows.Forms.Padding(0);
            this.CheckboxActivatePrintSales.MouseLocation = new System.Drawing.Point(-1, -1);
            this.CheckboxActivatePrintSales.MouseState = MaterialSkin.MouseState.HOVER;
            this.CheckboxActivatePrintSales.Name = "CheckboxActivatePrintSales";
            this.CheckboxActivatePrintSales.ReadOnly = false;
            this.CheckboxActivatePrintSales.Ripple = true;
            this.CheckboxActivatePrintSales.Size = new System.Drawing.Size(348, 37);
            this.CheckboxActivatePrintSales.TabIndex = 1;
            this.CheckboxActivatePrintSales.Text = "Activate the printing of sales screen invoices";
            this.CheckboxActivatePrintSales.UseVisualStyleBackColor = true;
            // 
            // CheckboxActivateDiscountEmp
            // 
            this.CheckboxActivateDiscountEmp.AutoSize = true;
            this.CheckboxActivateDiscountEmp.Depth = 0;
            this.CheckboxActivateDiscountEmp.Location = new System.Drawing.Point(16, 61);
            this.CheckboxActivateDiscountEmp.Margin = new System.Windows.Forms.Padding(0);
            this.CheckboxActivateDiscountEmp.MouseLocation = new System.Drawing.Point(-1, -1);
            this.CheckboxActivateDiscountEmp.MouseState = MaterialSkin.MouseState.HOVER;
            this.CheckboxActivateDiscountEmp.Name = "CheckboxActivateDiscountEmp";
            this.CheckboxActivateDiscountEmp.ReadOnly = false;
            this.CheckboxActivateDiscountEmp.Ripple = true;
            this.CheckboxActivateDiscountEmp.Size = new System.Drawing.Size(366, 37);
            this.CheckboxActivateDiscountEmp.TabIndex = 2;
            this.CheckboxActivateDiscountEmp.Text = "Activate the ability to discount sales invoices \r\n";
            this.CheckboxActivateDiscountEmp.UseVisualStyleBackColor = true;
            // 
            // CheckboxActivatePrintBuy
            // 
            this.CheckboxActivatePrintBuy.AutoSize = true;
            this.CheckboxActivatePrintBuy.Depth = 0;
            this.CheckboxActivatePrintBuy.Location = new System.Drawing.Point(16, 103);
            this.CheckboxActivatePrintBuy.Margin = new System.Windows.Forms.Padding(0);
            this.CheckboxActivatePrintBuy.MouseLocation = new System.Drawing.Point(-1, -1);
            this.CheckboxActivatePrintBuy.MouseState = MaterialSkin.MouseState.HOVER;
            this.CheckboxActivatePrintBuy.Name = "CheckboxActivatePrintBuy";
            this.CheckboxActivatePrintBuy.ReadOnly = false;
            this.CheckboxActivatePrintBuy.Ripple = true;
            this.CheckboxActivatePrintBuy.Size = new System.Drawing.Size(385, 37);
            this.CheckboxActivatePrintBuy.TabIndex = 3;
            this.CheckboxActivatePrintBuy.Text = "Activate the printing of Purchases screen invoices";
            this.CheckboxActivatePrintBuy.UseVisualStyleBackColor = true;
            // 
            // btnSaveOption
            // 
            this.btnSaveOption.AutoSize = false;
            this.btnSaveOption.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSaveOption.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSaveOption.Depth = 0;
            this.btnSaveOption.HighEmphasis = true;
            this.btnSaveOption.Icon = ((System.Drawing.Image)(resources.GetObject("btnSaveOption.Icon")));
            this.btnSaveOption.Location = new System.Drawing.Point(4, 499);
            this.btnSaveOption.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSaveOption.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSaveOption.Name = "btnSaveOption";
            this.btnSaveOption.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSaveOption.Size = new System.Drawing.Size(596, 41);
            this.btnSaveOption.TabIndex = 69;
            this.btnSaveOption.Text = "Save Data";
            this.btnSaveOption.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSaveOption.UseAccentColor = false;
            this.btnSaveOption.UseVisualStyleBackColor = true;
            this.btnSaveOption.Click += new System.EventHandler(this.btnSaveOption_Click);
            // 
            // FrmGeneralSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 634);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.materialTabSelector1);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.MaximizeBox = false;
            this.Name = "FrmGeneralSettings";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmGeneralSettings";
            this.Load += new System.EventHandler(this.FrmGeneralSettings_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.printsettings.ResumeLayout(false);
            this.InvoiceSettings.ResumeLayout(false);
            this.InvoiceSettings.PerformLayout();
            this.Options.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage printsettings;
        private System.Windows.Forms.TabPage InvoiceSettings;
        private System.Windows.Forms.TabPage Options;
        private MaterialSkin.Controls.MaterialComboBox cbxMainPrinter;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialButton btnCancel;
        private MaterialSkin.Controls.MaterialButton btnSaveData;
        private MaterialSkin.Controls.MaterialButton btnUploadPhoto;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureLogo;
        private MaterialSkin.Controls.MaterialButton btnDeletePhoto;
        private MaterialSkin.Controls.MaterialButton btnSave;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtInvoiceNote;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtPhoneNumber2;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtPhoneNumber1;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtStoreAddress;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtStoreName;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialRadioButton RadioBtnPercentage;
        private MaterialSkin.Controls.MaterialRadioButton RadioBtnValueMoney;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown NumNumberCopiesPurchase;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown NumNumberCopiesSales;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private MaterialSkin.Controls.MaterialRadioButton RadioButtonPrintS8c;
        private MaterialSkin.Controls.MaterialRadioButton RadioButtonPrintSA4;
        private System.Windows.Forms.GroupBox groupBox5;
        private MaterialSkin.Controls.MaterialCheckbox CheckboxActivatePrintSales;
        private MaterialSkin.Controls.MaterialCheckbox CheckboxActivateTax;
        private MaterialSkin.Controls.MaterialRadioButton RadioButtonPrintP8c;
        private MaterialSkin.Controls.MaterialRadioButton RadioButtonPrintPA4;
        private MaterialSkin.Controls.MaterialButton btnSaveOption;
        private MaterialSkin.Controls.MaterialCheckbox CheckboxActivatePrintBuy;
        private MaterialSkin.Controls.MaterialCheckbox CheckboxActivateDiscountEmp;
    }
}