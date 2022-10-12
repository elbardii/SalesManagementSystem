namespace SalesMangement
{
    partial class FrmCustomerReports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCustomerReports));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DateTimeSup = new System.Windows.Forms.DateTimePicker();
            this.btnDeleteAllRep = new MaterialSkin.Controls.MaterialButton();
            this.txtTotal = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.lblTotal = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.CbxCustRep = new MaterialSkin.Controls.MaterialComboBox();
            this.txtSearsh = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.rbtnAllCust = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbtnSpCust = new MaterialSkin.Controls.MaterialRadioButton();
            this.btnSearsh = new MaterialSkin.Controls.MaterialButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DgvCustRep = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.materialCard1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCustRep)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(809, 547);
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
            this.DateTimeSup.Location = new System.Drawing.Point(815, 553);
            this.DateTimeSup.Name = "DateTimeSup";
            this.DateTimeSup.Size = new System.Drawing.Size(138, 26);
            this.DateTimeSup.TabIndex = 62;
            // 
            // btnDeleteAllRep
            // 
            this.btnDeleteAllRep.AutoSize = false;
            this.btnDeleteAllRep.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeleteAllRep.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDeleteAllRep.Depth = 0;
            this.btnDeleteAllRep.HighEmphasis = true;
            this.btnDeleteAllRep.Icon = ((System.Drawing.Image)(resources.GetObject("btnDeleteAllRep.Icon")));
            this.btnDeleteAllRep.Location = new System.Drawing.Point(980, 548);
            this.btnDeleteAllRep.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDeleteAllRep.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDeleteAllRep.Name = "btnDeleteAllRep";
            this.btnDeleteAllRep.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDeleteAllRep.Size = new System.Drawing.Size(181, 37);
            this.btnDeleteAllRep.TabIndex = 61;
            this.btnDeleteAllRep.Text = "Delete All";
            this.btnDeleteAllRep.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDeleteAllRep.UseAccentColor = true;
            this.btnDeleteAllRep.UseVisualStyleBackColor = true;
            this.btnDeleteAllRep.Click += new System.EventHandler(this.btnDeleteAllRep_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.AnimateReadOnly = false;
            this.txtTotal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotal.Depth = 0;
            this.txtTotal.HideSelection = true;
            this.txtTotal.Location = new System.Drawing.Point(144, 550);
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
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Depth = 0;
            this.lblTotal.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTotal.Location = new System.Drawing.Point(16, 559);
            this.lblTotal.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(122, 19);
            this.lblTotal.TabIndex = 59;
            this.lblTotal.Text = "Remaining Total ";
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.CbxCustRep);
            this.materialCard1.Controls.Add(this.txtSearsh);
            this.materialCard1.Controls.Add(this.rbtnAllCust);
            this.materialCard1.Controls.Add(this.rbtnSpCust);
            this.materialCard1.Controls.Add(this.btnSearsh);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(65, 77);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(1052, 72);
            this.materialCard1.TabIndex = 58;
            // 
            // CbxCustRep
            // 
            this.CbxCustRep.AutoResize = false;
            this.CbxCustRep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CbxCustRep.Depth = 0;
            this.CbxCustRep.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.CbxCustRep.DropDownHeight = 174;
            this.CbxCustRep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxCustRep.DropDownWidth = 121;
            this.CbxCustRep.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.CbxCustRep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CbxCustRep.FormattingEnabled = true;
            this.CbxCustRep.Hint = "Customers";
            this.CbxCustRep.IntegralHeight = false;
            this.CbxCustRep.ItemHeight = 43;
            this.CbxCustRep.Location = new System.Drawing.Point(416, 12);
            this.CbxCustRep.MaxDropDownItems = 4;
            this.CbxCustRep.MouseState = MaterialSkin.MouseState.OUT;
            this.CbxCustRep.Name = "CbxCustRep";
            this.CbxCustRep.Size = new System.Drawing.Size(158, 49);
            this.CbxCustRep.StartIndex = 0;
            this.CbxCustRep.TabIndex = 56;
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
            this.txtSearsh.Location = new System.Drawing.Point(633, 13);
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
            // rbtnAllCust
            // 
            this.rbtnAllCust.AutoSize = true;
            this.rbtnAllCust.Checked = true;
            this.rbtnAllCust.Depth = 0;
            this.rbtnAllCust.Location = new System.Drawing.Point(47, 19);
            this.rbtnAllCust.Margin = new System.Windows.Forms.Padding(0);
            this.rbtnAllCust.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbtnAllCust.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtnAllCust.Name = "rbtnAllCust";
            this.rbtnAllCust.Ripple = true;
            this.rbtnAllCust.Size = new System.Drawing.Size(133, 37);
            this.rbtnAllCust.TabIndex = 42;
            this.rbtnAllCust.TabStop = true;
            this.rbtnAllCust.Text = "All Customers";
            this.rbtnAllCust.UseVisualStyleBackColor = true;
            // 
            // rbtnSpCust
            // 
            this.rbtnSpCust.AutoSize = true;
            this.rbtnSpCust.Depth = 0;
            this.rbtnSpCust.Location = new System.Drawing.Point(195, 19);
            this.rbtnSpCust.Margin = new System.Windows.Forms.Padding(0);
            this.rbtnSpCust.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbtnSpCust.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtnSpCust.Name = "rbtnSpCust";
            this.rbtnSpCust.Ripple = true;
            this.rbtnSpCust.Size = new System.Drawing.Size(164, 37);
            this.rbtnSpCust.TabIndex = 41;
            this.rbtnSpCust.TabStop = true;
            this.rbtnSpCust.Text = "Specific Customer";
            this.rbtnSpCust.UseVisualStyleBackColor = true;
            // 
            // btnSearsh
            // 
            this.btnSearsh.AutoSize = false;
            this.btnSearsh.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSearsh.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSearsh.Depth = 0;
            this.btnSearsh.HighEmphasis = true;
            this.btnSearsh.Icon = ((System.Drawing.Image)(resources.GetObject("btnSearsh.Icon")));
            this.btnSearsh.Location = new System.Drawing.Point(910, 17);
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
            this.groupBox1.Location = new System.Drawing.Point(6, 155);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1160, 370);
            this.groupBox1.TabIndex = 57;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Amount  Paid To Customers";
            // 
            // DgvCustRep
            // 
            this.DgvCustRep.AllowUserToAddRows = false;
            this.DgvCustRep.AllowUserToDeleteRows = false;
            this.DgvCustRep.AllowUserToResizeColumns = false;
            this.DgvCustRep.AllowUserToResizeRows = false;
            this.DgvCustRep.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            this.DgvCustRep.Size = new System.Drawing.Size(1154, 349);
            this.DgvCustRep.TabIndex = 1;
            // 
            // FrmCustomerReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 634);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DateTimeSup);
            this.Controls.Add(this.btnDeleteAllRep);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "FrmCustomerReports";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customers Reports";
            this.Load += new System.EventHandler(this.FrmCustomerReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvCustRep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker DateTimeSup;
        private MaterialSkin.Controls.MaterialButton btnDeleteAllRep;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtTotal;
        private MaterialSkin.Controls.MaterialLabel lblTotal;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialComboBox CbxCustRep;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtSearsh;
        private MaterialSkin.Controls.MaterialRadioButton rbtnAllCust;
        private MaterialSkin.Controls.MaterialRadioButton rbtnSpCust;
        private MaterialSkin.Controls.MaterialButton btnSearsh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DgvCustRep;
    }
}