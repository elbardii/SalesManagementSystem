namespace SalesMangement
{
    partial class FrmSalesReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSalesReport));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnDeleteAll = new MaterialSkin.Controls.MaterialButton();
            this.btnPrintAll = new MaterialSkin.Controls.MaterialButton();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.DateToExpR = new System.Windows.Forms.DateTimePicker();
            this.lblTo = new MaterialSkin.Controls.MaterialLabel();
            this.DateFromExpR = new System.Windows.Forms.DateTimePicker();
            this.lblFrom = new MaterialSkin.Controls.MaterialLabel();
            this.txtInNumber = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.CheckboxInNumber = new MaterialSkin.Controls.MaterialCheckbox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DateTimeSup = new System.Windows.Forms.DateTimePicker();
            this.btnPrintRep = new MaterialSkin.Controls.MaterialButton();
            this.txtTotal = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.lblTotal = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.CbxUsersRep = new MaterialSkin.Controls.MaterialComboBox();
            this.txtSearsh = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.rbtnAllUsers = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbtnSpUsers = new MaterialSkin.Controls.MaterialRadioButton();
            this.btnSearsh = new MaterialSkin.Controls.MaterialButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DgvCustRep = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTotalSpecific = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txtTotalSoldTax = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtTotalTax = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.materialCard1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCustRep)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.AutoSize = false;
            this.btnDeleteAll.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeleteAll.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDeleteAll.Depth = 0;
            this.btnDeleteAll.HighEmphasis = true;
            this.btnDeleteAll.Icon = ((System.Drawing.Image)(resources.GetObject("btnDeleteAll.Icon")));
            this.btnDeleteAll.Location = new System.Drawing.Point(1001, 569);
            this.btnDeleteAll.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDeleteAll.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDeleteAll.Size = new System.Drawing.Size(162, 37);
            this.btnDeleteAll.TabIndex = 77;
            this.btnDeleteAll.Text = "Delete invoice";
            this.btnDeleteAll.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDeleteAll.UseAccentColor = true;
            this.btnDeleteAll.UseVisualStyleBackColor = true;
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
            this.btnPrintAll.Location = new System.Drawing.Point(611, 569);
            this.btnPrintAll.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPrintAll.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPrintAll.Name = "btnPrintAll";
            this.btnPrintAll.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnPrintAll.Size = new System.Drawing.Size(181, 37);
            this.btnPrintAll.TabIndex = 76;
            this.btnPrintAll.Text = "Print all invoices";
            this.btnPrintAll.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnPrintAll.UseAccentColor = false;
            this.btnPrintAll.UseVisualStyleBackColor = true;
            this.btnPrintAll.Click += new System.EventHandler(this.btnPrintAll_Click);
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.DateToExpR);
            this.materialCard2.Controls.Add(this.lblTo);
            this.materialCard2.Controls.Add(this.DateFromExpR);
            this.materialCard2.Controls.Add(this.lblFrom);
            this.materialCard2.Controls.Add(this.txtInNumber);
            this.materialCard2.Controls.Add(this.CheckboxInNumber);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(60, 450);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(1049, 62);
            this.materialCard2.TabIndex = 75;
            // 
            // DateToExpR
            // 
            this.DateToExpR.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateToExpR.Location = new System.Drawing.Point(781, 19);
            this.DateToExpR.Name = "DateToExpR";
            this.DateToExpR.Size = new System.Drawing.Size(176, 22);
            this.DateToExpR.TabIndex = 60;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Depth = 0;
            this.lblTo.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTo.Location = new System.Drawing.Point(742, 21);
            this.lblTo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(28, 19);
            this.lblTo.TabIndex = 59;
            this.lblTo.Text = "To :";
            // 
            // DateFromExpR
            // 
            this.DateFromExpR.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateFromExpR.Location = new System.Drawing.Point(547, 20);
            this.DateFromExpR.Name = "DateFromExpR";
            this.DateFromExpR.Size = new System.Drawing.Size(176, 22);
            this.DateFromExpR.TabIndex = 58;
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Depth = 0;
            this.lblFrom.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblFrom.Location = new System.Drawing.Point(490, 22);
            this.lblFrom.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(46, 19);
            this.lblFrom.TabIndex = 57;
            this.lblFrom.Text = "From :";
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
            this.txtInNumber.Location = new System.Drawing.Point(283, 7);
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
            this.txtInNumber.Size = new System.Drawing.Size(180, 48);
            this.txtInNumber.SkipLiterals = true;
            this.txtInNumber.TabIndex = 56;
            this.txtInNumber.TabStop = false;
            this.txtInNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtInNumber.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtInNumber.TrailingIcon = null;
            this.txtInNumber.UseSystemPasswordChar = false;
            this.txtInNumber.ValidatingType = null;
            this.txtInNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInNumber_KeyPress);
            // 
            // CheckboxInNumber
            // 
            this.CheckboxInNumber.AutoSize = true;
            this.CheckboxInNumber.Depth = 0;
            this.CheckboxInNumber.Location = new System.Drawing.Point(108, 13);
            this.CheckboxInNumber.Margin = new System.Windows.Forms.Padding(0);
            this.CheckboxInNumber.MouseLocation = new System.Drawing.Point(-1, -1);
            this.CheckboxInNumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.CheckboxInNumber.Name = "CheckboxInNumber";
            this.CheckboxInNumber.ReadOnly = false;
            this.CheckboxInNumber.Ripple = true;
            this.CheckboxInNumber.Size = new System.Drawing.Size(145, 37);
            this.CheckboxInNumber.TabIndex = 0;
            this.CheckboxInNumber.Text = "Invoice Number";
            this.CheckboxInNumber.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1001, 569);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 37);
            this.pictureBox1.TabIndex = 74;
            this.pictureBox1.TabStop = false;
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
            this.DateTimeSup.Location = new System.Drawing.Point(1001, 574);
            this.DateTimeSup.Name = "DateTimeSup";
            this.DateTimeSup.Size = new System.Drawing.Size(138, 26);
            this.DateTimeSup.TabIndex = 73;
            // 
            // btnPrintRep
            // 
            this.btnPrintRep.AutoSize = false;
            this.btnPrintRep.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPrintRep.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnPrintRep.Depth = 0;
            this.btnPrintRep.HighEmphasis = true;
            this.btnPrintRep.Icon = ((System.Drawing.Image)(resources.GetObject("btnPrintRep.Icon")));
            this.btnPrintRep.Location = new System.Drawing.Point(805, 569);
            this.btnPrintRep.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPrintRep.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPrintRep.Name = "btnPrintRep";
            this.btnPrintRep.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnPrintRep.Size = new System.Drawing.Size(181, 37);
            this.btnPrintRep.TabIndex = 72;
            this.btnPrintRep.Text = "Invoice printing";
            this.btnPrintRep.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnPrintRep.UseAccentColor = false;
            this.btnPrintRep.UseVisualStyleBackColor = true;
            this.btnPrintRep.Click += new System.EventHandler(this.btnPrintRep_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.AnimateReadOnly = false;
            this.txtTotal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotal.Depth = 0;
            this.txtTotal.HideSelection = true;
            this.txtTotal.Location = new System.Drawing.Point(6, 40);
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
            this.txtTotal.Size = new System.Drawing.Size(138, 37);
            this.txtTotal.TabIndex = 71;
            this.txtTotal.TabStop = false;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTotal.UseSystemPasswordChar = false;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Depth = 0;
            this.lblTotal.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTotal.Location = new System.Drawing.Point(3, 18);
            this.lblTotal.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(141, 19);
            this.lblTotal.TabIndex = 70;
            this.lblTotal.Text = "Total Sales Amount";
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.CbxUsersRep);
            this.materialCard1.Controls.Add(this.txtSearsh);
            this.materialCard1.Controls.Add(this.rbtnAllUsers);
            this.materialCard1.Controls.Add(this.rbtnSpUsers);
            this.materialCard1.Controls.Add(this.btnSearsh);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(58, 78);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(1051, 62);
            this.materialCard1.TabIndex = 69;
            // 
            // CbxUsersRep
            // 
            this.CbxUsersRep.AutoResize = false;
            this.CbxUsersRep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CbxUsersRep.Depth = 0;
            this.CbxUsersRep.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.CbxUsersRep.DropDownHeight = 174;
            this.CbxUsersRep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxUsersRep.DropDownWidth = 121;
            this.CbxUsersRep.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.CbxUsersRep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CbxUsersRep.FormattingEnabled = true;
            this.CbxUsersRep.Hint = "Users";
            this.CbxUsersRep.IntegralHeight = false;
            this.CbxUsersRep.ItemHeight = 43;
            this.CbxUsersRep.Location = new System.Drawing.Point(356, 7);
            this.CbxUsersRep.MaxDropDownItems = 4;
            this.CbxUsersRep.MouseState = MaterialSkin.MouseState.OUT;
            this.CbxUsersRep.Name = "CbxUsersRep";
            this.CbxUsersRep.Size = new System.Drawing.Size(232, 49);
            this.CbxUsersRep.StartIndex = 0;
            this.CbxUsersRep.TabIndex = 57;
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
            this.txtSearsh.Hint = "Search Customer";
            this.txtSearsh.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtSearsh.LeadingIcon = null;
            this.txtSearsh.Location = new System.Drawing.Point(632, 8);
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
            this.txtSearsh.Size = new System.Drawing.Size(243, 48);
            this.txtSearsh.SkipLiterals = true;
            this.txtSearsh.TabIndex = 55;
            this.txtSearsh.TabStop = false;
            this.txtSearsh.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSearsh.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtSearsh.TrailingIcon = null;
            this.txtSearsh.UseSystemPasswordChar = false;
            this.txtSearsh.ValidatingType = null;
            // 
            // rbtnAllUsers
            // 
            this.rbtnAllUsers.AutoSize = true;
            this.rbtnAllUsers.Checked = true;
            this.rbtnAllUsers.Depth = 0;
            this.rbtnAllUsers.Location = new System.Drawing.Point(52, 14);
            this.rbtnAllUsers.Margin = new System.Windows.Forms.Padding(0);
            this.rbtnAllUsers.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbtnAllUsers.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtnAllUsers.Name = "rbtnAllUsers";
            this.rbtnAllUsers.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rbtnAllUsers.Ripple = true;
            this.rbtnAllUsers.Size = new System.Drawing.Size(96, 37);
            this.rbtnAllUsers.TabIndex = 42;
            this.rbtnAllUsers.TabStop = true;
            this.rbtnAllUsers.Text = "All Users";
            this.rbtnAllUsers.UseVisualStyleBackColor = true;
            // 
            // rbtnSpUsers
            // 
            this.rbtnSpUsers.AutoSize = true;
            this.rbtnSpUsers.Depth = 0;
            this.rbtnSpUsers.Location = new System.Drawing.Point(213, 14);
            this.rbtnSpUsers.Margin = new System.Windows.Forms.Padding(0);
            this.rbtnSpUsers.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbtnSpUsers.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtnSpUsers.Name = "rbtnSpUsers";
            this.rbtnSpUsers.Ripple = true;
            this.rbtnSpUsers.Size = new System.Drawing.Size(127, 37);
            this.rbtnSpUsers.TabIndex = 41;
            this.rbtnSpUsers.TabStop = true;
            this.rbtnSpUsers.Text = "Specific User";
            this.rbtnSpUsers.UseVisualStyleBackColor = true;
            // 
            // btnSearsh
            // 
            this.btnSearsh.AutoSize = false;
            this.btnSearsh.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSearsh.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSearsh.Depth = 0;
            this.btnSearsh.HighEmphasis = true;
            this.btnSearsh.Icon = ((System.Drawing.Image)(resources.GetObject("btnSearsh.Icon")));
            this.btnSearsh.Location = new System.Drawing.Point(911, 12);
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
            this.groupBox1.Controls.Add(this.DgvCustRep);
            this.groupBox1.Location = new System.Drawing.Point(6, 142);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1160, 291);
            this.groupBox1.TabIndex = 68;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sales report in a specified period";
            // 
            // DgvCustRep
            // 
            this.DgvCustRep.AllowUserToAddRows = false;
            this.DgvCustRep.AllowUserToDeleteRows = false;
            this.DgvCustRep.AllowUserToResizeColumns = false;
            this.DgvCustRep.AllowUserToResizeRows = false;
            this.DgvCustRep.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgvCustRep.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvCustRep.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.DgvCustRep.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvCustRep.ColumnHeadersHeight = 29;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(158)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvCustRep.DefaultCellStyle = dataGridViewCellStyle1;
            this.DgvCustRep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvCustRep.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DgvCustRep.Location = new System.Drawing.Point(3, 18);
            this.DgvCustRep.Name = "DgvCustRep";
            this.DgvCustRep.ReadOnly = true;
            this.DgvCustRep.RowHeadersWidth = 51;
            this.DgvCustRep.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DgvCustRep.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.DgvCustRep.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(158)))), ((int)(((byte)(128)))));
            this.DgvCustRep.RowTemplate.Height = 24;
            this.DgvCustRep.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvCustRep.Size = new System.Drawing.Size(1154, 270);
            this.DgvCustRep.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTotalSpecific);
            this.groupBox2.Controls.Add(this.materialLabel3);
            this.groupBox2.Controls.Add(this.txtTotalSoldTax);
            this.groupBox2.Controls.Add(this.materialLabel2);
            this.groupBox2.Controls.Add(this.txtTotalTax);
            this.groupBox2.Controls.Add(this.materialLabel1);
            this.groupBox2.Controls.Add(this.txtTotal);
            this.groupBox2.Controls.Add(this.lblTotal);
            this.groupBox2.Location = new System.Drawing.Point(9, 529);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(587, 96);
            this.groupBox2.TabIndex = 78;
            this.groupBox2.TabStop = false;
            // 
            // txtTotalSpecific
            // 
            this.txtTotalSpecific.AnimateReadOnly = false;
            this.txtTotalSpecific.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtTotalSpecific.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTotalSpecific.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalSpecific.Depth = 0;
            this.txtTotalSpecific.HideSelection = true;
            this.txtTotalSpecific.Location = new System.Drawing.Point(302, 40);
            this.txtTotalSpecific.MaxLength = 32767;
            this.txtTotalSpecific.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTotalSpecific.Name = "txtTotalSpecific";
            this.txtTotalSpecific.PasswordChar = '\0';
            this.txtTotalSpecific.ReadOnly = true;
            this.txtTotalSpecific.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTotalSpecific.SelectedText = "";
            this.txtTotalSpecific.SelectionLength = 0;
            this.txtTotalSpecific.SelectionStart = 0;
            this.txtTotalSpecific.ShortcutsEnabled = true;
            this.txtTotalSpecific.Size = new System.Drawing.Size(138, 37);
            this.txtTotalSpecific.TabIndex = 77;
            this.txtTotalSpecific.TabStop = false;
            this.txtTotalSpecific.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTotalSpecific.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(300, 18);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(154, 19);
            this.materialLabel3.TabIndex = 76;
            this.materialLabel3.Text = "Total specific seller %";
            // 
            // txtTotalSoldTax
            // 
            this.txtTotalSoldTax.AnimateReadOnly = false;
            this.txtTotalSoldTax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtTotalSoldTax.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTotalSoldTax.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalSoldTax.Depth = 0;
            this.txtTotalSoldTax.HideSelection = true;
            this.txtTotalSoldTax.Location = new System.Drawing.Point(154, 40);
            this.txtTotalSoldTax.MaxLength = 32767;
            this.txtTotalSoldTax.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTotalSoldTax.Name = "txtTotalSoldTax";
            this.txtTotalSoldTax.PasswordChar = '\0';
            this.txtTotalSoldTax.ReadOnly = true;
            this.txtTotalSoldTax.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTotalSoldTax.SelectedText = "";
            this.txtTotalSoldTax.SelectionLength = 0;
            this.txtTotalSoldTax.SelectionStart = 0;
            this.txtTotalSoldTax.ShortcutsEnabled = true;
            this.txtTotalSoldTax.Size = new System.Drawing.Size(138, 37);
            this.txtTotalSoldTax.TabIndex = 75;
            this.txtTotalSoldTax.TabStop = false;
            this.txtTotalSoldTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTotalSoldTax.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(156, 18);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(135, 19);
            this.materialLabel2.TabIndex = 74;
            this.materialLabel2.Text = "Total sold after tax";
            // 
            // txtTotalTax
            // 
            this.txtTotalTax.AnimateReadOnly = false;
            this.txtTotalTax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtTotalTax.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTotalTax.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalTax.Depth = 0;
            this.txtTotalTax.HideSelection = true;
            this.txtTotalTax.Location = new System.Drawing.Point(450, 40);
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
            this.txtTotalTax.Size = new System.Drawing.Size(129, 37);
            this.txtTotalTax.TabIndex = 73;
            this.txtTotalTax.TabStop = false;
            this.txtTotalTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTotalTax.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(457, 18);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(73, 19);
            this.materialLabel1.TabIndex = 72;
            this.materialLabel1.Text = "Total Tax ";
            // 
            // FrmSalesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 634);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnDeleteAll);
            this.Controls.Add(this.btnPrintAll);
            this.Controls.Add(this.materialCard2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DateTimeSup);
            this.Controls.Add(this.btnPrintRep);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "FrmSalesReport";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Reports";
            this.Load += new System.EventHandler(this.FrmSalesReport_Load);
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvCustRep)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnDeleteAll;
        private MaterialSkin.Controls.MaterialButton btnPrintAll;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private System.Windows.Forms.DateTimePicker DateToExpR;
        private MaterialSkin.Controls.MaterialLabel lblTo;
        private System.Windows.Forms.DateTimePicker DateFromExpR;
        private MaterialSkin.Controls.MaterialLabel lblFrom;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtInNumber;
        private MaterialSkin.Controls.MaterialCheckbox CheckboxInNumber;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker DateTimeSup;
        private MaterialSkin.Controls.MaterialButton btnPrintRep;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtTotal;
        private MaterialSkin.Controls.MaterialLabel lblTotal;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialComboBox CbxUsersRep;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtSearsh;
        private MaterialSkin.Controls.MaterialRadioButton rbtnAllUsers;
        private MaterialSkin.Controls.MaterialRadioButton rbtnSpUsers;
        private MaterialSkin.Controls.MaterialButton btnSearsh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DgvCustRep;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtTotalTax;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtTotalSpecific;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtTotalSoldTax;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
    }
}