namespace SalesMangement
{
    partial class FrmPrintBarcode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrintBarcode));
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxChooseProduct = new MaterialSkin.Controls.MaterialComboBox();
            this.btnRandomBarcode = new MaterialSkin.Controls.MaterialButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPrice = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.txtBarcode = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.txtNamePro = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.btnBarcodePrint = new MaterialSkin.Controls.MaterialButton();
            this.btnPrintDesignated = new MaterialSkin.Controls.MaterialButton();
            this.btnSaveBarcode = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(586, 67);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(564, 517);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxChooseProduct);
            this.groupBox1.Controls.Add(this.btnRandomBarcode);
            this.groupBox1.Location = new System.Drawing.Point(6, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(574, 90);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // cbxChooseProduct
            // 
            this.cbxChooseProduct.AutoResize = false;
            this.cbxChooseProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbxChooseProduct.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cbxChooseProduct.Depth = 0;
            this.cbxChooseProduct.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbxChooseProduct.DropDownHeight = 174;
            this.cbxChooseProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxChooseProduct.DropDownWidth = 121;
            this.cbxChooseProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbxChooseProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbxChooseProduct.FormattingEnabled = true;
            this.cbxChooseProduct.Hint = "Choose Product";
            this.cbxChooseProduct.IntegralHeight = false;
            this.cbxChooseProduct.ItemHeight = 43;
            this.cbxChooseProduct.Location = new System.Drawing.Point(39, 26);
            this.cbxChooseProduct.MaxDropDownItems = 4;
            this.cbxChooseProduct.MouseState = MaterialSkin.MouseState.OUT;
            this.cbxChooseProduct.Name = "cbxChooseProduct";
            this.cbxChooseProduct.Size = new System.Drawing.Size(246, 49);
            this.cbxChooseProduct.StartIndex = 0;
            this.cbxChooseProduct.TabIndex = 51;
            this.cbxChooseProduct.SelectionChangeCommitted += new System.EventHandler(this.cbxChooseProduct_SelectionChangeCommitted);
            // 
            // btnRandomBarcode
            // 
            this.btnRandomBarcode.AutoSize = false;
            this.btnRandomBarcode.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRandomBarcode.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRandomBarcode.Depth = 0;
            this.btnRandomBarcode.HighEmphasis = true;
            this.btnRandomBarcode.Icon = ((System.Drawing.Image)(resources.GetObject("btnRandomBarcode.Icon")));
            this.btnRandomBarcode.Location = new System.Drawing.Point(345, 26);
            this.btnRandomBarcode.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRandomBarcode.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRandomBarcode.Name = "btnRandomBarcode";
            this.btnRandomBarcode.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRandomBarcode.Size = new System.Drawing.Size(184, 49);
            this.btnRandomBarcode.TabIndex = 52;
            this.btnRandomBarcode.Text = "random barcode";
            this.btnRandomBarcode.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRandomBarcode.UseAccentColor = false;
            this.btnRandomBarcode.UseVisualStyleBackColor = true;
            this.btnRandomBarcode.Click += new System.EventHandler(this.btnRandomBarcode_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPrice);
            this.groupBox2.Controls.Add(this.txtBarcode);
            this.groupBox2.Controls.Add(this.txtNamePro);
            this.groupBox2.Location = new System.Drawing.Point(6, 221);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(574, 242);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Barcode Data";
            // 
            // txtPrice
            // 
            this.txtPrice.AllowPromptAsInput = true;
            this.txtPrice.AnimateReadOnly = false;
            this.txtPrice.AsciiOnly = false;
            this.txtPrice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtPrice.BeepOnError = false;
            this.txtPrice.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtPrice.Depth = 0;
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPrice.HidePromptOnLeave = false;
            this.txtPrice.HideSelection = true;
            this.txtPrice.Hint = "Price";
            this.txtPrice.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtPrice.LeadingIcon = ((System.Drawing.Image)(resources.GetObject("txtPrice.LeadingIcon")));
            this.txtPrice.Location = new System.Drawing.Point(316, 31);
            this.txtPrice.Mask = "";
            this.txtPrice.MaxLength = 32767;
            this.txtPrice.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.PrefixSuffixText = null;
            this.txtPrice.PromptChar = '_';
            this.txtPrice.ReadOnly = false;
            this.txtPrice.RejectInputOnFirstFailure = false;
            this.txtPrice.ResetOnPrompt = true;
            this.txtPrice.ResetOnSpace = true;
            this.txtPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPrice.SelectedText = "";
            this.txtPrice.SelectionLength = 0;
            this.txtPrice.SelectionStart = 0;
            this.txtPrice.ShortcutsEnabled = true;
            this.txtPrice.Size = new System.Drawing.Size(246, 48);
            this.txtPrice.SkipLiterals = true;
            this.txtPrice.TabIndex = 4;
            this.txtPrice.TabStop = false;
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPrice.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtPrice.TrailingIcon = null;
            this.txtPrice.UseSystemPasswordChar = false;
            this.txtPrice.ValidatingType = null;
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
            this.txtBarcode.Location = new System.Drawing.Point(32, 142);
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
            this.txtBarcode.Size = new System.Drawing.Size(530, 48);
            this.txtBarcode.SkipLiterals = true;
            this.txtBarcode.TabIndex = 3;
            this.txtBarcode.TabStop = false;
            this.txtBarcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBarcode.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtBarcode.TrailingIcon = null;
            this.txtBarcode.UseSystemPasswordChar = false;
            this.txtBarcode.ValidatingType = null;
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
            this.txtNamePro.Location = new System.Drawing.Point(32, 31);
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
            this.txtNamePro.Size = new System.Drawing.Size(246, 48);
            this.txtNamePro.SkipLiterals = true;
            this.txtNamePro.TabIndex = 2;
            this.txtNamePro.TabStop = false;
            this.txtNamePro.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNamePro.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtNamePro.TrailingIcon = null;
            this.txtNamePro.UseSystemPasswordChar = false;
            this.txtNamePro.ValidatingType = null;
            // 
            // btnBarcodePrint
            // 
            this.btnBarcodePrint.AutoSize = false;
            this.btnBarcodePrint.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBarcodePrint.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBarcodePrint.Depth = 0;
            this.btnBarcodePrint.HighEmphasis = true;
            this.btnBarcodePrint.Icon = ((System.Drawing.Image)(resources.GetObject("btnBarcodePrint.Icon")));
            this.btnBarcodePrint.Location = new System.Drawing.Point(4, 509);
            this.btnBarcodePrint.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBarcodePrint.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBarcodePrint.Name = "btnBarcodePrint";
            this.btnBarcodePrint.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBarcodePrint.Size = new System.Drawing.Size(184, 49);
            this.btnBarcodePrint.TabIndex = 52;
            this.btnBarcodePrint.Text = "barcode print";
            this.btnBarcodePrint.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBarcodePrint.UseAccentColor = false;
            this.btnBarcodePrint.UseVisualStyleBackColor = true;
            this.btnBarcodePrint.Click += new System.EventHandler(this.btnBarcodePrint_Click);
            // 
            // btnPrintDesignated
            // 
            this.btnPrintDesignated.AutoSize = false;
            this.btnPrintDesignated.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPrintDesignated.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnPrintDesignated.Depth = 0;
            this.btnPrintDesignated.HighEmphasis = true;
            this.btnPrintDesignated.Icon = ((System.Drawing.Image)(resources.GetObject("btnPrintDesignated.Icon")));
            this.btnPrintDesignated.Location = new System.Drawing.Point(199, 509);
            this.btnPrintDesignated.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPrintDesignated.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPrintDesignated.Name = "btnPrintDesignated";
            this.btnPrintDesignated.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnPrintDesignated.Size = new System.Drawing.Size(184, 49);
            this.btnPrintDesignated.TabIndex = 53;
            this.btnPrintDesignated.Text = "Print designated";
            this.btnPrintDesignated.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnPrintDesignated.UseAccentColor = false;
            this.btnPrintDesignated.UseVisualStyleBackColor = true;
            this.btnPrintDesignated.Click += new System.EventHandler(this.btnPrintDesignated_Click);
            // 
            // btnSaveBarcode
            // 
            this.btnSaveBarcode.AutoSize = false;
            this.btnSaveBarcode.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSaveBarcode.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSaveBarcode.Depth = 0;
            this.btnSaveBarcode.HighEmphasis = true;
            this.btnSaveBarcode.Icon = ((System.Drawing.Image)(resources.GetObject("btnSaveBarcode.Icon")));
            this.btnSaveBarcode.Location = new System.Drawing.Point(395, 509);
            this.btnSaveBarcode.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSaveBarcode.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSaveBarcode.Name = "btnSaveBarcode";
            this.btnSaveBarcode.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSaveBarcode.Size = new System.Drawing.Size(184, 49);
            this.btnSaveBarcode.TabIndex = 54;
            this.btnSaveBarcode.Text = "Save barcode";
            this.btnSaveBarcode.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSaveBarcode.UseAccentColor = false;
            this.btnSaveBarcode.UseVisualStyleBackColor = true;
            this.btnSaveBarcode.Click += new System.EventHandler(this.btnSaveBarcode_Click);
            // 
            // FrmPrintBarcode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 587);
            this.Controls.Add(this.btnSaveBarcode);
            this.Controls.Add(this.btnPrintDesignated);
            this.Controls.Add(this.btnBarcodePrint);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox4);
            this.MaximizeBox = false;
            this.Name = "FrmPrintBarcode";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Print Barcode";
            this.Load += new System.EventHandler(this.FrmPrintBarcode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialButton btnRandomBarcode;
        private MaterialSkin.Controls.MaterialComboBox cbxChooseProduct;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtNamePro;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtBarcode;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtPrice;
        private MaterialSkin.Controls.MaterialButton btnBarcodePrint;
        private MaterialSkin.Controls.MaterialButton btnPrintDesignated;
        private MaterialSkin.Controls.MaterialButton btnSaveBarcode;
    }
}