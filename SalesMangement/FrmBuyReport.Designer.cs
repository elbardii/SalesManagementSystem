
namespace SalesMangement
{
    partial class FrmBuyReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBuyReport));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DateTimeSup = new System.Windows.Forms.DateTimePicker();
            this.btnPrintRep = new MaterialSkin.Controls.MaterialButton();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.CbxSupRep = new MaterialSkin.Controls.MaterialComboBox();
            this.txtSearsh = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.rbtnAllSup = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbtnSpSup = new MaterialSkin.Controls.MaterialRadioButton();
            this.btnSearsh = new MaterialSkin.Controls.MaterialButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DgvSupRep = new System.Windows.Forms.DataGridView();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.DateToExpR = new System.Windows.Forms.DateTimePicker();
            this.lblTo = new MaterialSkin.Controls.MaterialLabel();
            this.DateFromExpR = new System.Windows.Forms.DateTimePicker();
            this.lblFrom = new MaterialSkin.Controls.MaterialLabel();
            this.txtInNumber = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.CheckboxInNumber = new MaterialSkin.Controls.MaterialCheckbox();
            this.btnPrintAll = new MaterialSkin.Controls.MaterialButton();
            this.btnDeleteAll = new MaterialSkin.Controls.MaterialButton();
            this.lblTotal = new MaterialSkin.Controls.MaterialLabel();
            this.txtTotal = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.txtToatalTax = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.materialCard1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSupRep)).BeginInit();
            this.materialCard2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(980, 588);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 37);
            this.pictureBox1.TabIndex = 63;
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
            this.DateTimeSup.Location = new System.Drawing.Point(986, 593);
            this.DateTimeSup.Name = "DateTimeSup";
            this.DateTimeSup.Size = new System.Drawing.Size(138, 26);
            this.DateTimeSup.TabIndex = 62;
            // 
            // btnPrintRep
            // 
            this.btnPrintRep.AutoSize = false;
            this.btnPrintRep.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPrintRep.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnPrintRep.Depth = 0;
            this.btnPrintRep.HighEmphasis = true;
            this.btnPrintRep.Icon = ((System.Drawing.Image)(resources.GetObject("btnPrintRep.Icon")));
            this.btnPrintRep.Location = new System.Drawing.Point(753, 588);
            this.btnPrintRep.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPrintRep.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPrintRep.Name = "btnPrintRep";
            this.btnPrintRep.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnPrintRep.Size = new System.Drawing.Size(181, 37);
            this.btnPrintRep.TabIndex = 61;
            this.btnPrintRep.Text = "Invoice printing";
            this.btnPrintRep.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnPrintRep.UseAccentColor = false;
            this.btnPrintRep.UseVisualStyleBackColor = true;
            this.btnPrintRep.Click += new System.EventHandler(this.btnPrintRep_Click);
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.CbxSupRep);
            this.materialCard1.Controls.Add(this.txtSearsh);
            this.materialCard1.Controls.Add(this.rbtnAllSup);
            this.materialCard1.Controls.Add(this.rbtnSpSup);
            this.materialCard1.Controls.Add(this.btnSearsh);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(67, 72);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(1051, 62);
            this.materialCard1.TabIndex = 58;
            // 
            // CbxSupRep
            // 
            this.CbxSupRep.AutoResize = false;
            this.CbxSupRep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CbxSupRep.Depth = 0;
            this.CbxSupRep.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.CbxSupRep.DropDownHeight = 174;
            this.CbxSupRep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxSupRep.DropDownWidth = 121;
            this.CbxSupRep.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.CbxSupRep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CbxSupRep.FormattingEnabled = true;
            this.CbxSupRep.Hint = "Suppliers";
            this.CbxSupRep.IntegralHeight = false;
            this.CbxSupRep.ItemHeight = 43;
            this.CbxSupRep.Location = new System.Drawing.Point(421, 7);
            this.CbxSupRep.MaxDropDownItems = 4;
            this.CbxSupRep.MouseState = MaterialSkin.MouseState.OUT;
            this.CbxSupRep.Name = "CbxSupRep";
            this.CbxSupRep.Size = new System.Drawing.Size(167, 49);
            this.CbxSupRep.StartIndex = 0;
            this.CbxSupRep.TabIndex = 57;
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
            this.txtSearsh.Hint = "Search Supplier";
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
            this.txtSearsh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearsh_KeyPress);
            // 
            // rbtnAllSup
            // 
            this.rbtnAllSup.AutoSize = true;
            this.rbtnAllSup.Checked = true;
            this.rbtnAllSup.Depth = 0;
            this.rbtnAllSup.Location = new System.Drawing.Point(52, 14);
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
            this.rbtnSpSup.Location = new System.Drawing.Point(213, 14);
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
            this.groupBox1.Controls.Add(this.DgvSupRep);
            this.groupBox1.Location = new System.Drawing.Point(6, 140);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1160, 352);
            this.groupBox1.TabIndex = 57;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buy report in a specified period";
            // 
            // DgvSupRep
            // 
            this.DgvSupRep.AllowUserToAddRows = false;
            this.DgvSupRep.AllowUserToDeleteRows = false;
            this.DgvSupRep.AllowUserToResizeColumns = false;
            this.DgvSupRep.AllowUserToResizeRows = false;
            this.DgvSupRep.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgvSupRep.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvSupRep.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.DgvSupRep.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvSupRep.ColumnHeadersHeight = 29;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(158)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvSupRep.DefaultCellStyle = dataGridViewCellStyle1;
            this.DgvSupRep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvSupRep.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DgvSupRep.Location = new System.Drawing.Point(3, 18);
            this.DgvSupRep.Name = "DgvSupRep";
            this.DgvSupRep.ReadOnly = true;
            this.DgvSupRep.RowHeadersWidth = 51;
            this.DgvSupRep.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DgvSupRep.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.DgvSupRep.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(158)))), ((int)(((byte)(128)))));
            this.DgvSupRep.RowTemplate.Height = 24;
            this.DgvSupRep.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvSupRep.Size = new System.Drawing.Size(1154, 331);
            this.DgvSupRep.TabIndex = 1;
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
            this.materialCard2.Location = new System.Drawing.Point(54, 502);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(1049, 62);
            this.materialCard2.TabIndex = 64;
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
            // btnPrintAll
            // 
            this.btnPrintAll.AutoSize = false;
            this.btnPrintAll.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPrintAll.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnPrintAll.Depth = 0;
            this.btnPrintAll.HighEmphasis = true;
            this.btnPrintAll.Icon = ((System.Drawing.Image)(resources.GetObject("btnPrintAll.Icon")));
            this.btnPrintAll.Location = new System.Drawing.Point(521, 588);
            this.btnPrintAll.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPrintAll.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPrintAll.Name = "btnPrintAll";
            this.btnPrintAll.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnPrintAll.Size = new System.Drawing.Size(181, 37);
            this.btnPrintAll.TabIndex = 66;
            this.btnPrintAll.Text = "Print all invoices";
            this.btnPrintAll.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnPrintAll.UseAccentColor = false;
            this.btnPrintAll.UseVisualStyleBackColor = true;
            this.btnPrintAll.Click += new System.EventHandler(this.btnPrintAll_Click);
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.AutoSize = false;
            this.btnDeleteAll.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeleteAll.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDeleteAll.Depth = 0;
            this.btnDeleteAll.HighEmphasis = true;
            this.btnDeleteAll.Icon = ((System.Drawing.Image)(resources.GetObject("btnDeleteAll.Icon")));
            this.btnDeleteAll.Location = new System.Drawing.Point(978, 588);
            this.btnDeleteAll.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDeleteAll.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDeleteAll.Size = new System.Drawing.Size(181, 37);
            this.btnDeleteAll.TabIndex = 67;
            this.btnDeleteAll.Text = "Delete invoice";
            this.btnDeleteAll.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDeleteAll.UseAccentColor = true;
            this.btnDeleteAll.UseVisualStyleBackColor = true;
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Depth = 0;
            this.lblTotal.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTotal.Location = new System.Drawing.Point(6, 566);
            this.lblTotal.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(129, 19);
            this.lblTotal.TabIndex = 59;
            this.lblTotal.Text = "Total Buy Amount";
            // 
            // txtTotal
            // 
            this.txtTotal.AnimateReadOnly = false;
            this.txtTotal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotal.Depth = 0;
            this.txtTotal.HideSelection = true;
            this.txtTotal.Location = new System.Drawing.Point(9, 588);
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
            this.txtTotal.TabIndex = 60;
            this.txtTotal.TabStop = false;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTotal.UseSystemPasswordChar = false;
            // 
            // txtToatalTax
            // 
            this.txtToatalTax.AnimateReadOnly = false;
            this.txtToatalTax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtToatalTax.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtToatalTax.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtToatalTax.Depth = 0;
            this.txtToatalTax.HideSelection = true;
            this.txtToatalTax.Location = new System.Drawing.Point(153, 588);
            this.txtToatalTax.MaxLength = 32767;
            this.txtToatalTax.MouseState = MaterialSkin.MouseState.OUT;
            this.txtToatalTax.Name = "txtToatalTax";
            this.txtToatalTax.PasswordChar = '\0';
            this.txtToatalTax.ReadOnly = true;
            this.txtToatalTax.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtToatalTax.SelectedText = "";
            this.txtToatalTax.SelectionLength = 0;
            this.txtToatalTax.SelectionStart = 0;
            this.txtToatalTax.ShortcutsEnabled = true;
            this.txtToatalTax.Size = new System.Drawing.Size(126, 37);
            this.txtToatalTax.TabIndex = 69;
            this.txtToatalTax.TabStop = false;
            this.txtToatalTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtToatalTax.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(150, 566);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(69, 19);
            this.materialLabel1.TabIndex = 68;
            this.materialLabel1.Text = "Total Tax";
            // 
            // FrmBuyReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 634);
            this.Controls.Add(this.txtToatalTax);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.btnDeleteAll);
            this.Controls.Add(this.btnPrintAll);
            this.Controls.Add(this.materialCard2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DateTimeSup);
            this.Controls.Add(this.btnPrintRep);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "FrmBuyReport";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buy Reports";
            this.Load += new System.EventHandler(this.FrmBuyReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvSupRep)).EndInit();
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker DateTimeSup;
        private MaterialSkin.Controls.MaterialButton btnPrintRep;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtSearsh;
        private MaterialSkin.Controls.MaterialRadioButton rbtnAllSup;
        private MaterialSkin.Controls.MaterialRadioButton rbtnSpSup;
        private MaterialSkin.Controls.MaterialButton btnSearsh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DgvSupRep;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtInNumber;
        private MaterialSkin.Controls.MaterialCheckbox CheckboxInNumber;
        private System.Windows.Forms.DateTimePicker DateToExpR;
        private MaterialSkin.Controls.MaterialLabel lblTo;
        private System.Windows.Forms.DateTimePicker DateFromExpR;
        private MaterialSkin.Controls.MaterialLabel lblFrom;
        private MaterialSkin.Controls.MaterialButton btnPrintAll;
        private MaterialSkin.Controls.MaterialButton btnDeleteAll;
        private MaterialSkin.Controls.MaterialComboBox CbxSupRep;
        private MaterialSkin.Controls.MaterialLabel lblTotal;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtTotal;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtToatalTax;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}