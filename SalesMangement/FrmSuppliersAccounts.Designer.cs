namespace SalesMangement
{
    partial class FrmSuppliersAccounts
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSuppliersAccounts));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DgvSupAccounts = new System.Windows.Forms.DataGridView();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.txtSearsh = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.rbtnAllSup = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbtnSpSup = new MaterialSkin.Controls.MaterialRadioButton();
            this.btnSearsh = new MaterialSkin.Controls.MaterialButton();
            this.btnPrintReport = new MaterialSkin.Controls.MaterialButton();
            this.lblTotal = new MaterialSkin.Controls.MaterialLabel();
            this.txtTotal = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.NumPricePayPart = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.rbtnPayingPart = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbtnPayFull = new MaterialSkin.Controls.MaterialRadioButton();
            this.btnDefinitePay = new MaterialSkin.Controls.MaterialButton();
            this.DateTimeSup = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CbxSupAc = new MaterialSkin.Controls.MaterialComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSupAccounts)).BeginInit();
            this.materialCard1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DgvSupAccounts);
            this.groupBox1.Location = new System.Drawing.Point(6, 205);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1160, 308);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Remaining Amounts To Suppliers";
            // 
            // DgvSupAccounts
            // 
            this.DgvSupAccounts.AllowUserToAddRows = false;
            this.DgvSupAccounts.AllowUserToDeleteRows = false;
            this.DgvSupAccounts.AllowUserToResizeColumns = false;
            this.DgvSupAccounts.AllowUserToResizeRows = false;
            this.DgvSupAccounts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvSupAccounts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvSupAccounts.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.DgvSupAccounts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvSupAccounts.ColumnHeadersHeight = 29;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(158)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvSupAccounts.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvSupAccounts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvSupAccounts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DgvSupAccounts.Location = new System.Drawing.Point(3, 18);
            this.DgvSupAccounts.Name = "DgvSupAccounts";
            this.DgvSupAccounts.ReadOnly = true;
            this.DgvSupAccounts.RowHeadersWidth = 51;
            this.DgvSupAccounts.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DgvSupAccounts.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.DgvSupAccounts.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(158)))), ((int)(((byte)(128)))));
            this.DgvSupAccounts.RowTemplate.Height = 24;
            this.DgvSupAccounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvSupAccounts.Size = new System.Drawing.Size(1154, 287);
            this.DgvSupAccounts.TabIndex = 1;
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.txtSearsh);
            this.materialCard1.Controls.Add(this.rbtnAllSup);
            this.materialCard1.Controls.Add(this.rbtnSpSup);
            this.materialCard1.Controls.Add(this.btnSearsh);
            this.materialCard1.Controls.Add(this.btnPrintReport);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(63, 76);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(1052, 72);
            this.materialCard1.TabIndex = 39;
            // 
            // txtSearsh
            // 
            this.txtSearsh.AllowPromptAsInput = true;
            this.txtSearsh.AnimateReadOnly = false;
            this.txtSearsh.AsciiOnly = false;
            this.txtSearsh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtSearsh.BeepOnError = false;
            this.txtSearsh.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtSearsh.Depth = 0;
            this.txtSearsh.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearsh.HidePromptOnLeave = false;
            this.txtSearsh.HideSelection = true;
            this.txtSearsh.Hint = "Search  Suppliers";
            this.txtSearsh.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtSearsh.LeadingIcon = null;
            this.txtSearsh.Location = new System.Drawing.Point(417, 13);
            this.txtSearsh.Mask = "";
            this.txtSearsh.MaxLength = 32767;
            this.txtSearsh.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSearsh.Name = "txtSearsh";
            this.txtSearsh.PasswordChar = '\0';
            this.txtSearsh.PrefixSuffixText = null;
            this.txtSearsh.PromptChar = '_';
            this.txtSearsh.ReadOnly = false;
            this.txtSearsh.RejectInputOnFirstFailure = false;
            this.txtSearsh.ResetOnPrompt = true;
            this.txtSearsh.ResetOnSpace = true;
            this.txtSearsh.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSearsh.SelectedText = "";
            this.txtSearsh.SelectionLength = 0;
            this.txtSearsh.SelectionStart = 0;
            this.txtSearsh.ShortcutsEnabled = true;
            this.txtSearsh.Size = new System.Drawing.Size(268, 48);
            this.txtSearsh.SkipLiterals = true;
            this.txtSearsh.TabIndex = 55;
            this.txtSearsh.TabStop = false;
            this.txtSearsh.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSearsh.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtSearsh.TrailingIcon = null;
            this.txtSearsh.UseSystemPasswordChar = false;
            this.txtSearsh.ValidatingType = null;
            this.txtSearsh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearsh_KeyPress);
            // 
            // rbtnAllSup
            // 
            this.rbtnAllSup.AutoSize = true;
            this.rbtnAllSup.Checked = true;
            this.rbtnAllSup.Depth = 0;
            this.rbtnAllSup.Location = new System.Drawing.Point(64, 18);
            this.rbtnAllSup.Margin = new System.Windows.Forms.Padding(0);
            this.rbtnAllSup.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbtnAllSup.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtnAllSup.Name = "rbtnAllSup";
            this.rbtnAllSup.Ripple = true;
            this.rbtnAllSup.Size = new System.Drawing.Size(123, 37);
            this.rbtnAllSup.TabIndex = 42;
            this.rbtnAllSup.TabStop = true;
            this.rbtnAllSup.Text = "All Suppliers";
            this.rbtnAllSup.UseVisualStyleBackColor = true;
            // 
            // rbtnSpSup
            // 
            this.rbtnSpSup.AutoSize = true;
            this.rbtnSpSup.Depth = 0;
            this.rbtnSpSup.Location = new System.Drawing.Point(210, 19);
            this.rbtnSpSup.Margin = new System.Windows.Forms.Padding(0);
            this.rbtnSpSup.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbtnSpSup.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtnSpSup.Name = "rbtnSpSup";
            this.rbtnSpSup.Ripple = true;
            this.rbtnSpSup.Size = new System.Drawing.Size(162, 37);
            this.rbtnSpSup.TabIndex = 41;
            this.rbtnSpSup.TabStop = true;
            this.rbtnSpSup.Text = "Specific Suppliers";
            this.rbtnSpSup.UseVisualStyleBackColor = true;
            // 
            // btnSearsh
            // 
            this.btnSearsh.AutoSize = false;
            this.btnSearsh.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSearsh.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSearsh.Depth = 0;
            this.btnSearsh.HighEmphasis = true;
            this.btnSearsh.Icon = ((System.Drawing.Image)(resources.GetObject("btnSearsh.Icon")));
            this.btnSearsh.Location = new System.Drawing.Point(720, 18);
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
            // btnPrintReport
            // 
            this.btnPrintReport.AutoSize = false;
            this.btnPrintReport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPrintReport.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnPrintReport.Depth = 0;
            this.btnPrintReport.HighEmphasis = true;
            this.btnPrintReport.Icon = ((System.Drawing.Image)(resources.GetObject("btnPrintReport.Icon")));
            this.btnPrintReport.Location = new System.Drawing.Point(849, 18);
            this.btnPrintReport.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPrintReport.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPrintReport.Name = "btnPrintReport";
            this.btnPrintReport.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnPrintReport.Size = new System.Drawing.Size(145, 37);
            this.btnPrintReport.TabIndex = 40;
            this.btnPrintReport.Text = "Print Report";
            this.btnPrintReport.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnPrintReport.UseAccentColor = false;
            this.btnPrintReport.UseVisualStyleBackColor = true;
            this.btnPrintReport.Click += new System.EventHandler(this.btnPrintReport_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Depth = 0;
            this.lblTotal.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTotal.Location = new System.Drawing.Point(1040, 524);
            this.lblTotal.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(122, 19);
            this.lblTotal.TabIndex = 40;
            this.lblTotal.Text = "Remaining Total ";
            // 
            // txtTotal
            // 
            this.txtTotal.AnimateReadOnly = false;
            this.txtTotal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotal.Depth = 0;
            this.txtTotal.HideSelection = true;
            this.txtTotal.Location = new System.Drawing.Point(1037, 548);
            this.txtTotal.MaxLength = 32767;
            this.txtTotal.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.PasswordChar = '\0';
            this.txtTotal.ReadOnly = true;
            this.txtTotal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTotal.SelectedText = "";
            this.txtTotal.SelectionLength = 0;
            this.txtTotal.SelectionStart = 0;
            this.txtTotal.ShortcutsEnabled = true;
            this.txtTotal.Size = new System.Drawing.Size(126, 37);
            this.txtTotal.TabIndex = 41;
            this.txtTotal.TabStop = false;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTotal.UseSystemPasswordChar = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.NumPricePayPart);
            this.groupBox2.Controls.Add(this.rbtnPayingPart);
            this.groupBox2.Controls.Add(this.rbtnPayFull);
            this.groupBox2.Controls.Add(this.btnDefinitePay);
            this.groupBox2.Location = new System.Drawing.Point(9, 518);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(697, 63);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            // 
            // NumPricePayPart
            // 
            this.NumPricePayPart.DecimalPlaces = 2;
            this.NumPricePayPart.Location = new System.Drawing.Point(361, 22);
            this.NumPricePayPart.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.NumPricePayPart.Name = "NumPricePayPart";
            this.NumPricePayPart.Size = new System.Drawing.Size(102, 26);
            this.NumPricePayPart.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.NumPricePayPart.TabIndex = 41;
            this.NumPricePayPart.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // rbtnPayingPart
            // 
            this.rbtnPayingPart.AutoSize = true;
            this.rbtnPayingPart.Depth = 0;
            this.rbtnPayingPart.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rbtnPayingPart.Location = new System.Drawing.Point(194, 17);
            this.rbtnPayingPart.Margin = new System.Windows.Forms.Padding(0);
            this.rbtnPayingPart.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbtnPayingPart.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtnPayingPart.Name = "rbtnPayingPart";
            this.rbtnPayingPart.Ripple = true;
            this.rbtnPayingPart.Size = new System.Drawing.Size(151, 37);
            this.rbtnPayingPart.TabIndex = 40;
            this.rbtnPayingPart.TabStop = true;
            this.rbtnPayingPart.Text = "Paying Part Of It";
            this.rbtnPayingPart.UseVisualStyleBackColor = true;
            // 
            // rbtnPayFull
            // 
            this.rbtnPayFull.AutoSize = true;
            this.rbtnPayFull.Checked = true;
            this.rbtnPayFull.Depth = 0;
            this.rbtnPayFull.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rbtnPayFull.Location = new System.Drawing.Point(10, 17);
            this.rbtnPayFull.Margin = new System.Windows.Forms.Padding(0);
            this.rbtnPayFull.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbtnPayFull.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtnPayFull.Name = "rbtnPayFull";
            this.rbtnPayFull.Ripple = true;
            this.rbtnPayFull.Size = new System.Drawing.Size(174, 37);
            this.rbtnPayFull.TabIndex = 39;
            this.rbtnPayFull.TabStop = true;
            this.rbtnPayFull.Text = "Pay the full amount";
            this.rbtnPayFull.UseVisualStyleBackColor = true;
            // 
            // btnDefinitePay
            // 
            this.btnDefinitePay.AutoSize = false;
            this.btnDefinitePay.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDefinitePay.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDefinitePay.Depth = 0;
            this.btnDefinitePay.HighEmphasis = true;
            this.btnDefinitePay.Icon = ((System.Drawing.Image)(resources.GetObject("btnDefinitePay.Icon")));
            this.btnDefinitePay.Location = new System.Drawing.Point(491, 17);
            this.btnDefinitePay.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDefinitePay.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDefinitePay.Name = "btnDefinitePay";
            this.btnDefinitePay.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDefinitePay.Size = new System.Drawing.Size(181, 37);
            this.btnDefinitePay.TabIndex = 43;
            this.btnDefinitePay.Text = "Definite Payment";
            this.btnDefinitePay.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDefinitePay.UseAccentColor = false;
            this.btnDefinitePay.UseVisualStyleBackColor = true;
            this.btnDefinitePay.Click += new System.EventHandler(this.btnDefinitePay_Click);
            // 
            // DateTimeSup
            // 
            this.DateTimeSup.CalendarFont = new System.Drawing.Font("Tahoma", 9F);
            this.DateTimeSup.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.DateTimeSup.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.DateTimeSup.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.DateTimeSup.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.DateTimeSup.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.DateTimeSup.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.DateTimeSup.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimeSup.Location = new System.Drawing.Point(759, 160);
            this.DateTimeSup.Name = "DateTimeSup";
            this.DateTimeSup.Size = new System.Drawing.Size(129, 26);
            this.DateTimeSup.TabIndex = 53;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(759, 160);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 26);
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            // 
            // CbxSupAc
            // 
            this.CbxSupAc.AutoResize = false;
            this.CbxSupAc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CbxSupAc.Depth = 0;
            this.CbxSupAc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.CbxSupAc.DropDownHeight = 174;
            this.CbxSupAc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxSupAc.DropDownWidth = 121;
            this.CbxSupAc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.CbxSupAc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CbxSupAc.FormattingEnabled = true;
            this.CbxSupAc.Hint = "Suppliers";
            this.CbxSupAc.IntegralHeight = false;
            this.CbxSupAc.ItemHeight = 43;
            this.CbxSupAc.Location = new System.Drawing.Point(911, 159);
            this.CbxSupAc.MaxDropDownItems = 4;
            this.CbxSupAc.MouseState = MaterialSkin.MouseState.OUT;
            this.CbxSupAc.Name = "CbxSupAc";
            this.CbxSupAc.Size = new System.Drawing.Size(158, 49);
            this.CbxSupAc.StartIndex = 0;
            this.CbxSupAc.TabIndex = 55;
            // 
            // FrmSuppliersAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(1172, 634);
            this.Controls.Add(this.CbxSupAc);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DateTimeSup);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "FrmSuppliersAccounts";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Suppliers Accounts";
            this.Load += new System.EventHandler(this.FrmSuppliersAccounts_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvSupAccounts)).EndInit();
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialButton btnSearsh;
        private MaterialSkin.Controls.MaterialButton btnPrintReport;
        private System.Windows.Forms.DataGridView DgvSupAccounts;
        private MaterialSkin.Controls.MaterialLabel lblTotal;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtTotal;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialRadioButton rbtnPayingPart;
        private MaterialSkin.Controls.MaterialRadioButton rbtnPayFull;
        private ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown NumPricePayPart;
        private MaterialSkin.Controls.MaterialButton btnDefinitePay;
        private MaterialSkin.Controls.MaterialRadioButton rbtnSpSup;
        private MaterialSkin.Controls.MaterialRadioButton rbtnAllSup;
        private System.Windows.Forms.DateTimePicker DateTimeSup;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtSearsh;
        private MaterialSkin.Controls.MaterialComboBox CbxSupAc;
    }
}