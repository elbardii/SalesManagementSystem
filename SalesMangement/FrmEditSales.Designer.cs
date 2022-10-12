namespace SalesMangement
{
    partial class FrmEditSales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditSales));
            this.btnReturn = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.lblBuyPrice = new MaterialSkin.Controls.MaterialLabel();
            this.lblQuantity = new MaterialSkin.Controls.MaterialLabel();
            this.btnSaveEdit = new MaterialSkin.Controls.MaterialButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtQuantity = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.txtSalesPrice = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.txtDiscount = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CheckboxVisa = new MaterialSkin.Controls.MaterialCheckbox();
            this.CbxItemsUnit = new MaterialSkin.Controls.MaterialComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.AutoSize = false;
            this.btnReturn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnReturn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnReturn.Depth = 0;
            this.btnReturn.HighEmphasis = true;
            this.btnReturn.Icon = ((System.Drawing.Image)(resources.GetObject("btnReturn.Icon")));
            this.btnReturn.Location = new System.Drawing.Point(304, 330);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnReturn.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnReturn.Size = new System.Drawing.Size(117, 36);
            this.btnReturn.TabIndex = 28;
            this.btnReturn.Text = "Return";
            this.btnReturn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnReturn.UseAccentColor = false;
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(6, 22);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(72, 19);
            this.materialLabel2.TabIndex = 27;
            this.materialLabel2.Text = "Discount :";
            // 
            // lblBuyPrice
            // 
            this.lblBuyPrice.AutoSize = true;
            this.lblBuyPrice.Depth = 0;
            this.lblBuyPrice.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblBuyPrice.Location = new System.Drawing.Point(5, 158);
            this.lblBuyPrice.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblBuyPrice.Name = "lblBuyPrice";
            this.lblBuyPrice.Size = new System.Drawing.Size(87, 19);
            this.lblBuyPrice.TabIndex = 25;
            this.lblBuyPrice.Text = "Sales Price :";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Depth = 0;
            this.lblQuantity.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblQuantity.Location = new System.Drawing.Point(5, 231);
            this.lblQuantity.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(69, 19);
            this.lblQuantity.TabIndex = 24;
            this.lblQuantity.Text = "Quantity :";
            // 
            // btnSaveEdit
            // 
            this.btnSaveEdit.AutoSize = false;
            this.btnSaveEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSaveEdit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSaveEdit.Depth = 0;
            this.btnSaveEdit.HighEmphasis = true;
            this.btnSaveEdit.Icon = ((System.Drawing.Image)(resources.GetObject("btnSaveEdit.Icon")));
            this.btnSaveEdit.Location = new System.Drawing.Point(456, 330);
            this.btnSaveEdit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSaveEdit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSaveEdit.Name = "btnSaveEdit";
            this.btnSaveEdit.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSaveEdit.Size = new System.Drawing.Size(117, 36);
            this.btnSaveEdit.TabIndex = 23;
            this.btnSaveEdit.Text = "Save Edit";
            this.btnSaveEdit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSaveEdit.UseAccentColor = false;
            this.btnSaveEdit.UseVisualStyleBackColor = true;
            this.btnSaveEdit.Click += new System.EventHandler(this.btnSaveEdit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(270, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(343, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // txtQuantity
            // 
            this.txtQuantity.AllowPromptAsInput = true;
            this.txtQuantity.AnimateReadOnly = false;
            this.txtQuantity.AsciiOnly = false;
            this.txtQuantity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtQuantity.BeepOnError = false;
            this.txtQuantity.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtQuantity.Depth = 0;
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtQuantity.HidePromptOnLeave = false;
            this.txtQuantity.HideSelection = true;
            this.txtQuantity.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtQuantity.LeadingIcon = null;
            this.txtQuantity.Location = new System.Drawing.Point(27, 255);
            this.txtQuantity.Mask = "";
            this.txtQuantity.MaxLength = 32767;
            this.txtQuantity.MouseState = MaterialSkin.MouseState.OUT;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.PasswordChar = '\0';
            this.txtQuantity.PrefixSuffixText = null;
            this.txtQuantity.PromptChar = '_';
            this.txtQuantity.ReadOnly = false;
            this.txtQuantity.RejectInputOnFirstFailure = false;
            this.txtQuantity.ResetOnPrompt = true;
            this.txtQuantity.ResetOnSpace = true;
            this.txtQuantity.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtQuantity.SelectedText = "";
            this.txtQuantity.SelectionLength = 0;
            this.txtQuantity.SelectionStart = 0;
            this.txtQuantity.ShortcutsEnabled = true;
            this.txtQuantity.Size = new System.Drawing.Size(238, 48);
            this.txtQuantity.SkipLiterals = true;
            this.txtQuantity.TabIndex = 21;
            this.txtQuantity.TabStop = false;
            this.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtQuantity.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtQuantity.TrailingIcon = null;
            this.txtQuantity.UseSystemPasswordChar = false;
            this.txtQuantity.ValidatingType = null;
            // 
            // txtSalesPrice
            // 
            this.txtSalesPrice.AllowPromptAsInput = true;
            this.txtSalesPrice.AnimateReadOnly = false;
            this.txtSalesPrice.AsciiOnly = false;
            this.txtSalesPrice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtSalesPrice.BeepOnError = false;
            this.txtSalesPrice.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtSalesPrice.Depth = 0;
            this.txtSalesPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.txtSalesPrice.HidePromptOnLeave = false;
            this.txtSalesPrice.HideSelection = true;
            this.txtSalesPrice.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtSalesPrice.LeadingIcon = null;
            this.txtSalesPrice.Location = new System.Drawing.Point(27, 180);
            this.txtSalesPrice.Mask = "";
            this.txtSalesPrice.MaxLength = 32767;
            this.txtSalesPrice.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSalesPrice.Name = "txtSalesPrice";
            this.txtSalesPrice.PasswordChar = '\0';
            this.txtSalesPrice.PrefixSuffixText = null;
            this.txtSalesPrice.PromptChar = '_';
            this.txtSalesPrice.ReadOnly = false;
            this.txtSalesPrice.RejectInputOnFirstFailure = false;
            this.txtSalesPrice.ResetOnPrompt = true;
            this.txtSalesPrice.ResetOnSpace = true;
            this.txtSalesPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSalesPrice.SelectedText = "";
            this.txtSalesPrice.SelectionLength = 0;
            this.txtSalesPrice.SelectionStart = 0;
            this.txtSalesPrice.ShortcutsEnabled = true;
            this.txtSalesPrice.Size = new System.Drawing.Size(238, 48);
            this.txtSalesPrice.SkipLiterals = true;
            this.txtSalesPrice.TabIndex = 20;
            this.txtSalesPrice.TabStop = false;
            this.txtSalesPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSalesPrice.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtSalesPrice.TrailingIcon = null;
            this.txtSalesPrice.UseSystemPasswordChar = false;
            this.txtSalesPrice.ValidatingType = null;
            // 
            // txtDiscount
            // 
            this.txtDiscount.AllowPromptAsInput = true;
            this.txtDiscount.AnimateReadOnly = false;
            this.txtDiscount.AsciiOnly = false;
            this.txtDiscount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtDiscount.BeepOnError = false;
            this.txtDiscount.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtDiscount.Depth = 0;
            this.txtDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDiscount.HidePromptOnLeave = false;
            this.txtDiscount.HideSelection = true;
            this.txtDiscount.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtDiscount.LeadingIcon = null;
            this.txtDiscount.Location = new System.Drawing.Point(27, 46);
            this.txtDiscount.Mask = "";
            this.txtDiscount.MaxLength = 32767;
            this.txtDiscount.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.PasswordChar = '\0';
            this.txtDiscount.PrefixSuffixText = null;
            this.txtDiscount.PromptChar = '_';
            this.txtDiscount.ReadOnly = false;
            this.txtDiscount.RejectInputOnFirstFailure = false;
            this.txtDiscount.ResetOnPrompt = true;
            this.txtDiscount.ResetOnSpace = true;
            this.txtDiscount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDiscount.SelectedText = "";
            this.txtDiscount.SelectionLength = 0;
            this.txtDiscount.SelectionStart = 0;
            this.txtDiscount.ShortcutsEnabled = true;
            this.txtDiscount.Size = new System.Drawing.Size(238, 48);
            this.txtDiscount.SkipLiterals = true;
            this.txtDiscount.TabIndex = 18;
            this.txtDiscount.TabStop = false;
            this.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDiscount.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtDiscount.TrailingIcon = null;
            this.txtDiscount.UseSystemPasswordChar = false;
            this.txtDiscount.ValidatingType = null;
            this.txtDiscount.TextChanged += new System.EventHandler(this.txtDiscount_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CheckboxVisa);
            this.groupBox1.Controls.Add(this.CbxItemsUnit);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btnReturn);
            this.groupBox1.Controls.Add(this.txtDiscount);
            this.groupBox1.Controls.Add(this.materialLabel2);
            this.groupBox1.Controls.Add(this.txtSalesPrice);
            this.groupBox1.Controls.Add(this.lblBuyPrice);
            this.groupBox1.Controls.Add(this.txtQuantity);
            this.groupBox1.Controls.Add(this.lblQuantity);
            this.groupBox1.Controls.Add(this.btnSaveEdit);
            this.groupBox1.Location = new System.Drawing.Point(5, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(622, 367);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            // 
            // CheckboxVisa
            // 
            this.CheckboxVisa.AutoSize = true;
            this.CheckboxVisa.Depth = 0;
            this.CheckboxVisa.Location = new System.Drawing.Point(36, 322);
            this.CheckboxVisa.Margin = new System.Windows.Forms.Padding(0);
            this.CheckboxVisa.MouseLocation = new System.Drawing.Point(-1, -1);
            this.CheckboxVisa.MouseState = MaterialSkin.MouseState.HOVER;
            this.CheckboxVisa.Name = "CheckboxVisa";
            this.CheckboxVisa.ReadOnly = false;
            this.CheckboxVisa.Ripple = true;
            this.CheckboxVisa.Size = new System.Drawing.Size(202, 37);
            this.CheckboxVisa.TabIndex = 30;
            this.CheckboxVisa.Text = "Payment By Credit Card";
            this.CheckboxVisa.UseVisualStyleBackColor = true;
            // 
            // CbxItemsUnit
            // 
            this.CbxItemsUnit.AutoResize = false;
            this.CbxItemsUnit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CbxItemsUnit.Depth = 0;
            this.CbxItemsUnit.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.CbxItemsUnit.DropDownHeight = 174;
            this.CbxItemsUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxItemsUnit.DropDownWidth = 121;
            this.CbxItemsUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.CbxItemsUnit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CbxItemsUnit.FormattingEnabled = true;
            this.CbxItemsUnit.Hint = "Choose a Unit ";
            this.CbxItemsUnit.IntegralHeight = false;
            this.CbxItemsUnit.ItemHeight = 43;
            this.CbxItemsUnit.Location = new System.Drawing.Point(27, 106);
            this.CbxItemsUnit.MaxDropDownItems = 4;
            this.CbxItemsUnit.MouseState = MaterialSkin.MouseState.OUT;
            this.CbxItemsUnit.Name = "CbxItemsUnit";
            this.CbxItemsUnit.Size = new System.Drawing.Size(238, 49);
            this.CbxItemsUnit.StartIndex = 0;
            this.CbxItemsUnit.TabIndex = 29;
            this.CbxItemsUnit.SelectionChangeCommitted += new System.EventHandler(this.CbxItemsUnit_SelectionChangeCommitted);
            // 
            // FrmEditSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 373);
            this.Controls.Add(this.groupBox1);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.StatusAndActionBar_None;
            this.KeyPreview = true;
            this.Name = "FrmEditSales";
            this.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Sales";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmEditSales_FormClosing);
            this.Load += new System.EventHandler(this.FrmEditSales_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmEditSales_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnReturn;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel lblBuyPrice;
        private MaterialSkin.Controls.MaterialLabel lblQuantity;
        private MaterialSkin.Controls.MaterialButton btnSaveEdit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtQuantity;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtSalesPrice;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtDiscount;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialComboBox CbxItemsUnit;
        private MaterialSkin.Controls.MaterialCheckbox CheckboxVisa;
    }
}