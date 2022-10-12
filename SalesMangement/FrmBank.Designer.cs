namespace SalesMangement
{
    partial class FrmBank
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBank));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.AddMoneyBank = new System.Windows.Forms.TabPage();
            this.CardAddMoneyBank = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtCurrentBalance = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnAddMoney = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.NudAddBalance = new System.Windows.Forms.NumericUpDown();
            this.DateDespoAMoney = new System.Windows.Forms.DateTimePicker();
            this.TxtNoteAMoney = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.txtDeposName = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.lblFrom = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.WithdrawBank = new System.Windows.Forms.TabPage();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.txtBalanceWMoney = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnWithdrow = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.NubAddBalanceWMoney = new System.Windows.Forms.NumericUpDown();
            this.DateWMoney = new System.Windows.Forms.DateTimePicker();
            this.txtNoteWMoney = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.txtDeposNWMoney = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Bankdeposreport = new System.Windows.Forms.TabPage();
            this.btnSearchR2 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnDeleteR = new MaterialSkin.Controls.MaterialButton();
            this.LblTotal = new MaterialSkin.Controls.MaterialLabel();
            this.txtTotalR = new System.Windows.Forms.TextBox();
            this.LblTitleExpR = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard4 = new MaterialSkin.Controls.MaterialCard();
            this.DgvR = new System.Windows.Forms.DataGridView();
            this.materialCard5 = new MaterialSkin.Controls.MaterialCard();
            this.DateToR = new System.Windows.Forms.DateTimePicker();
            this.lblTo = new MaterialSkin.Controls.MaterialLabel();
            this.DateFromR = new System.Windows.Forms.DateTimePicker();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.btnSearchR = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.BankWithdReport = new System.Windows.Forms.TabPage();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnDeleteRW = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.txtTotalRW = new System.Windows.Forms.TextBox();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard6 = new MaterialSkin.Controls.MaterialCard();
            this.DgvRW = new System.Windows.Forms.DataGridView();
            this.materialCard7 = new MaterialSkin.Controls.MaterialCard();
            this.DateToRW = new System.Windows.Forms.DateTimePicker();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.DateFromRW = new System.Windows.Forms.DateTimePicker();
            this.materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            this.btnSearchRW = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl1.SuspendLayout();
            this.AddMoneyBank.SuspendLayout();
            this.CardAddMoneyBank.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudAddBalance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.WithdrawBank.SuspendLayout();
            this.materialCard3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NubAddBalanceWMoney)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.Bankdeposreport.SuspendLayout();
            this.materialCard4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvR)).BeginInit();
            this.materialCard5.SuspendLayout();
            this.BankWithdReport.SuspendLayout();
            this.materialCard6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRW)).BeginInit();
            this.materialCard7.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.AddMoneyBank);
            this.materialTabControl1.Controls.Add(this.WithdrawBank);
            this.materialTabControl1.Controls.Add(this.Bankdeposreport);
            this.materialTabControl1.Controls.Add(this.BankWithdReport);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(6, 78);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1163, 550);
            this.materialTabControl1.TabIndex = 0;
            // 
            // AddMoneyBank
            // 
            this.AddMoneyBank.Controls.Add(this.CardAddMoneyBank);
            this.AddMoneyBank.Controls.Add(this.groupBox5);
            this.AddMoneyBank.Controls.Add(this.materialLabel2);
            this.AddMoneyBank.Controls.Add(this.groupBox4);
            this.AddMoneyBank.Controls.Add(this.pictureBox1);
            this.AddMoneyBank.Location = new System.Drawing.Point(4, 25);
            this.AddMoneyBank.Name = "AddMoneyBank";
            this.AddMoneyBank.Padding = new System.Windows.Forms.Padding(3);
            this.AddMoneyBank.Size = new System.Drawing.Size(1155, 521);
            this.AddMoneyBank.TabIndex = 0;
            this.AddMoneyBank.Text = "Deposit";
            this.AddMoneyBank.UseVisualStyleBackColor = true;
            // 
            // CardAddMoneyBank
            // 
            this.CardAddMoneyBank.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CardAddMoneyBank.Controls.Add(this.materialLabel1);
            this.CardAddMoneyBank.Controls.Add(this.txtCurrentBalance);
            this.CardAddMoneyBank.Depth = 0;
            this.CardAddMoneyBank.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CardAddMoneyBank.Location = new System.Drawing.Point(170, 58);
            this.CardAddMoneyBank.Margin = new System.Windows.Forms.Padding(14);
            this.CardAddMoneyBank.MouseState = MaterialSkin.MouseState.HOVER;
            this.CardAddMoneyBank.Name = "CardAddMoneyBank";
            this.CardAddMoneyBank.Padding = new System.Windows.Forms.Padding(14);
            this.CardAddMoneyBank.Size = new System.Drawing.Size(200, 100);
            this.CardAddMoneyBank.TabIndex = 101;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(43, 14);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(117, 19);
            this.materialLabel1.TabIndex = 89;
            this.materialLabel1.Text = "Current Balance ";
            // 
            // txtCurrentBalance
            // 
            this.txtCurrentBalance.AnimateReadOnly = false;
            this.txtCurrentBalance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtCurrentBalance.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCurrentBalance.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCurrentBalance.Depth = 0;
            this.txtCurrentBalance.HideSelection = true;
            this.txtCurrentBalance.Location = new System.Drawing.Point(11, 45);
            this.txtCurrentBalance.MaxLength = 32767;
            this.txtCurrentBalance.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCurrentBalance.Name = "txtCurrentBalance";
            this.txtCurrentBalance.PasswordChar = '\0';
            this.txtCurrentBalance.ReadOnly = true;
            this.txtCurrentBalance.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCurrentBalance.SelectedText = "";
            this.txtCurrentBalance.SelectionLength = 0;
            this.txtCurrentBalance.SelectionStart = 0;
            this.txtCurrentBalance.ShortcutsEnabled = true;
            this.txtCurrentBalance.Size = new System.Drawing.Size(180, 38);
            this.txtCurrentBalance.TabIndex = 90;
            this.txtCurrentBalance.TabStop = false;
            this.txtCurrentBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCurrentBalance.UseSystemPasswordChar = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnAddMoney);
            this.groupBox5.Location = new System.Drawing.Point(164, 407);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(218, 77);
            this.groupBox5.TabIndex = 99;
            this.groupBox5.TabStop = false;
            // 
            // btnAddMoney
            // 
            this.btnAddMoney.AutoSize = false;
            this.btnAddMoney.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddMoney.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAddMoney.Depth = 0;
            this.btnAddMoney.HighEmphasis = true;
            this.btnAddMoney.Icon = ((System.Drawing.Image)(resources.GetObject("btnAddMoney.Icon")));
            this.btnAddMoney.Location = new System.Drawing.Point(12, 21);
            this.btnAddMoney.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddMoney.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddMoney.Name = "btnAddMoney";
            this.btnAddMoney.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAddMoney.Size = new System.Drawing.Size(194, 44);
            this.btnAddMoney.TabIndex = 92;
            this.btnAddMoney.Text = "Add Money";
            this.btnAddMoney.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddMoney.UseAccentColor = false;
            this.btnAddMoney.UseVisualStyleBackColor = true;
            this.btnAddMoney.Click += new System.EventHandler(this.btnAddMoney_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(480, 138);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(1, 0);
            this.materialLabel2.TabIndex = 98;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.materialLabel3);
            this.groupBox4.Controls.Add(this.NudAddBalance);
            this.groupBox4.Controls.Add(this.DateDespoAMoney);
            this.groupBox4.Controls.Add(this.TxtNoteAMoney);
            this.groupBox4.Controls.Add(this.txtDeposName);
            this.groupBox4.Controls.Add(this.lblFrom);
            this.groupBox4.Location = new System.Drawing.Point(25, 196);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(517, 194);
            this.groupBox4.TabIndex = 97;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Add Money";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(6, 107);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(95, 19);
            this.materialLabel3.TabIndex = 97;
            this.materialLabel3.Text = "add amount :";
            // 
            // NudAddBalance
            // 
            this.NudAddBalance.Location = new System.Drawing.Point(107, 102);
            this.NudAddBalance.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.NudAddBalance.Name = "NudAddBalance";
            this.NudAddBalance.Size = new System.Drawing.Size(135, 22);
            this.NudAddBalance.TabIndex = 96;
            // 
            // DateDespoAMoney
            // 
            this.DateDespoAMoney.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateDespoAMoney.Location = new System.Drawing.Point(107, 146);
            this.DateDespoAMoney.Name = "DateDespoAMoney";
            this.DateDespoAMoney.Size = new System.Drawing.Size(136, 22);
            this.DateDespoAMoney.TabIndex = 35;
            // 
            // TxtNoteAMoney
            // 
            this.TxtNoteAMoney.AnimateReadOnly = false;
            this.TxtNoteAMoney.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TxtNoteAMoney.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TxtNoteAMoney.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtNoteAMoney.Depth = 0;
            this.TxtNoteAMoney.HideSelection = true;
            this.TxtNoteAMoney.Hint = "Reason For Deposit";
            this.TxtNoteAMoney.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TxtNoteAMoney.Location = new System.Drawing.Point(255, 36);
            this.TxtNoteAMoney.MaxLength = 32767;
            this.TxtNoteAMoney.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtNoteAMoney.Name = "TxtNoteAMoney";
            this.TxtNoteAMoney.PasswordChar = '\0';
            this.TxtNoteAMoney.ReadOnly = false;
            this.TxtNoteAMoney.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtNoteAMoney.SelectedText = "";
            this.TxtNoteAMoney.SelectionLength = 0;
            this.TxtNoteAMoney.SelectionStart = 0;
            this.TxtNoteAMoney.ShortcutsEnabled = true;
            this.TxtNoteAMoney.Size = new System.Drawing.Size(252, 137);
            this.TxtNoteAMoney.TabIndex = 33;
            this.TxtNoteAMoney.TabStop = false;
            this.TxtNoteAMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtNoteAMoney.UseSystemPasswordChar = false;
            // 
            // txtDeposName
            // 
            this.txtDeposName.AllowPromptAsInput = true;
            this.txtDeposName.AnimateReadOnly = false;
            this.txtDeposName.AsciiOnly = false;
            this.txtDeposName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtDeposName.BeepOnError = false;
            this.txtDeposName.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtDeposName.Depth = 0;
            this.txtDeposName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDeposName.HidePromptOnLeave = false;
            this.txtDeposName.HideSelection = true;
            this.txtDeposName.Hint = "Depositor\'s Name";
            this.txtDeposName.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtDeposName.LeadingIcon = null;
            this.txtDeposName.Location = new System.Drawing.Point(8, 36);
            this.txtDeposName.Mask = "";
            this.txtDeposName.MaxLength = 32767;
            this.txtDeposName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDeposName.Name = "txtDeposName";
            this.txtDeposName.PasswordChar = '\0';
            this.txtDeposName.PrefixSuffixText = null;
            this.txtDeposName.PromptChar = '_';
            this.txtDeposName.ReadOnly = false;
            this.txtDeposName.RejectInputOnFirstFailure = false;
            this.txtDeposName.ResetOnPrompt = true;
            this.txtDeposName.ResetOnSpace = true;
            this.txtDeposName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDeposName.SelectedText = "";
            this.txtDeposName.SelectionLength = 0;
            this.txtDeposName.SelectionStart = 0;
            this.txtDeposName.ShortcutsEnabled = true;
            this.txtDeposName.Size = new System.Drawing.Size(234, 48);
            this.txtDeposName.SkipLiterals = true;
            this.txtDeposName.TabIndex = 0;
            this.txtDeposName.TabStop = false;
            this.txtDeposName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDeposName.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtDeposName.TrailingIcon = null;
            this.txtDeposName.UseSystemPasswordChar = false;
            this.txtDeposName.ValidatingType = null;
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Depth = 0;
            this.lblFrom.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblFrom.Location = new System.Drawing.Point(6, 149);
            this.lblFrom.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(96, 19);
            this.lblFrom.TabIndex = 34;
            this.lblFrom.Text = "deposit date :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(568, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(587, 530);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // WithdrawBank
            // 
            this.WithdrawBank.Controls.Add(this.materialCard3);
            this.WithdrawBank.Controls.Add(this.groupBox6);
            this.WithdrawBank.Controls.Add(this.materialLabel7);
            this.WithdrawBank.Controls.Add(this.groupBox7);
            this.WithdrawBank.Controls.Add(this.pictureBox2);
            this.WithdrawBank.Location = new System.Drawing.Point(4, 25);
            this.WithdrawBank.Name = "WithdrawBank";
            this.WithdrawBank.Padding = new System.Windows.Forms.Padding(3);
            this.WithdrawBank.Size = new System.Drawing.Size(1155, 521);
            this.WithdrawBank.TabIndex = 1;
            this.WithdrawBank.Text = "Withdraw";
            this.WithdrawBank.UseVisualStyleBackColor = true;
            // 
            // materialCard3
            // 
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.materialLabel5);
            this.materialCard3.Controls.Add(this.txtBalanceWMoney);
            this.materialCard3.Depth = 0;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(170, 58);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard3.Size = new System.Drawing.Size(200, 100);
            this.materialCard3.TabIndex = 106;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(43, 14);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(117, 19);
            this.materialLabel5.TabIndex = 89;
            this.materialLabel5.Text = "Current Balance ";
            // 
            // txtBalanceWMoney
            // 
            this.txtBalanceWMoney.AnimateReadOnly = false;
            this.txtBalanceWMoney.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtBalanceWMoney.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtBalanceWMoney.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBalanceWMoney.Depth = 0;
            this.txtBalanceWMoney.HideSelection = true;
            this.txtBalanceWMoney.Location = new System.Drawing.Point(11, 45);
            this.txtBalanceWMoney.MaxLength = 32767;
            this.txtBalanceWMoney.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBalanceWMoney.Name = "txtBalanceWMoney";
            this.txtBalanceWMoney.PasswordChar = '\0';
            this.txtBalanceWMoney.ReadOnly = true;
            this.txtBalanceWMoney.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBalanceWMoney.SelectedText = "";
            this.txtBalanceWMoney.SelectionLength = 0;
            this.txtBalanceWMoney.SelectionStart = 0;
            this.txtBalanceWMoney.ShortcutsEnabled = true;
            this.txtBalanceWMoney.Size = new System.Drawing.Size(180, 38);
            this.txtBalanceWMoney.TabIndex = 90;
            this.txtBalanceWMoney.TabStop = false;
            this.txtBalanceWMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBalanceWMoney.UseSystemPasswordChar = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnWithdrow);
            this.groupBox6.Location = new System.Drawing.Point(164, 407);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(218, 77);
            this.groupBox6.TabIndex = 105;
            this.groupBox6.TabStop = false;
            // 
            // btnWithdrow
            // 
            this.btnWithdrow.AutoSize = false;
            this.btnWithdrow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnWithdrow.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnWithdrow.Depth = 0;
            this.btnWithdrow.HighEmphasis = true;
            this.btnWithdrow.Icon = ((System.Drawing.Image)(resources.GetObject("btnWithdrow.Icon")));
            this.btnWithdrow.Location = new System.Drawing.Point(12, 21);
            this.btnWithdrow.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnWithdrow.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnWithdrow.Name = "btnWithdrow";
            this.btnWithdrow.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnWithdrow.Size = new System.Drawing.Size(194, 44);
            this.btnWithdrow.TabIndex = 92;
            this.btnWithdrow.Text = "Withdrow";
            this.btnWithdrow.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnWithdrow.UseAccentColor = false;
            this.btnWithdrow.UseVisualStyleBackColor = true;
            this.btnWithdrow.Click += new System.EventHandler(this.btnWithdrow_Click);
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.Location = new System.Drawing.Point(484, 143);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(1, 0);
            this.materialLabel7.TabIndex = 104;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.materialLabel8);
            this.groupBox7.Controls.Add(this.NubAddBalanceWMoney);
            this.groupBox7.Controls.Add(this.DateWMoney);
            this.groupBox7.Controls.Add(this.txtNoteWMoney);
            this.groupBox7.Controls.Add(this.txtDeposNWMoney);
            this.groupBox7.Controls.Add(this.materialLabel9);
            this.groupBox7.Location = new System.Drawing.Point(25, 196);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(517, 194);
            this.groupBox7.TabIndex = 103;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Add Money";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.Location = new System.Drawing.Point(6, 104);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(95, 19);
            this.materialLabel8.TabIndex = 97;
            this.materialLabel8.Text = "add amount :";
            // 
            // NubAddBalanceWMoney
            // 
            this.NubAddBalanceWMoney.Location = new System.Drawing.Point(107, 101);
            this.NubAddBalanceWMoney.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.NubAddBalanceWMoney.Name = "NubAddBalanceWMoney";
            this.NubAddBalanceWMoney.Size = new System.Drawing.Size(135, 22);
            this.NubAddBalanceWMoney.TabIndex = 96;
            // 
            // DateWMoney
            // 
            this.DateWMoney.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateWMoney.Location = new System.Drawing.Point(107, 146);
            this.DateWMoney.Name = "DateWMoney";
            this.DateWMoney.Size = new System.Drawing.Size(136, 22);
            this.DateWMoney.TabIndex = 35;
            // 
            // txtNoteWMoney
            // 
            this.txtNoteWMoney.AnimateReadOnly = false;
            this.txtNoteWMoney.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtNoteWMoney.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNoteWMoney.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNoteWMoney.Depth = 0;
            this.txtNoteWMoney.HideSelection = true;
            this.txtNoteWMoney.Hint = "Reason for withdrawal";
            this.txtNoteWMoney.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtNoteWMoney.Location = new System.Drawing.Point(255, 36);
            this.txtNoteWMoney.MaxLength = 32767;
            this.txtNoteWMoney.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNoteWMoney.Name = "txtNoteWMoney";
            this.txtNoteWMoney.PasswordChar = '\0';
            this.txtNoteWMoney.ReadOnly = false;
            this.txtNoteWMoney.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNoteWMoney.SelectedText = "";
            this.txtNoteWMoney.SelectionLength = 0;
            this.txtNoteWMoney.SelectionStart = 0;
            this.txtNoteWMoney.ShortcutsEnabled = true;
            this.txtNoteWMoney.Size = new System.Drawing.Size(252, 137);
            this.txtNoteWMoney.TabIndex = 33;
            this.txtNoteWMoney.TabStop = false;
            this.txtNoteWMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNoteWMoney.UseSystemPasswordChar = false;
            // 
            // txtDeposNWMoney
            // 
            this.txtDeposNWMoney.AllowPromptAsInput = true;
            this.txtDeposNWMoney.AnimateReadOnly = false;
            this.txtDeposNWMoney.AsciiOnly = false;
            this.txtDeposNWMoney.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtDeposNWMoney.BeepOnError = false;
            this.txtDeposNWMoney.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtDeposNWMoney.Depth = 0;
            this.txtDeposNWMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDeposNWMoney.HidePromptOnLeave = false;
            this.txtDeposNWMoney.HideSelection = true;
            this.txtDeposNWMoney.Hint = "Withdrawal  Name";
            this.txtDeposNWMoney.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtDeposNWMoney.LeadingIcon = null;
            this.txtDeposNWMoney.Location = new System.Drawing.Point(8, 36);
            this.txtDeposNWMoney.Mask = "";
            this.txtDeposNWMoney.MaxLength = 32767;
            this.txtDeposNWMoney.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDeposNWMoney.Name = "txtDeposNWMoney";
            this.txtDeposNWMoney.PasswordChar = '\0';
            this.txtDeposNWMoney.PrefixSuffixText = null;
            this.txtDeposNWMoney.PromptChar = '_';
            this.txtDeposNWMoney.ReadOnly = false;
            this.txtDeposNWMoney.RejectInputOnFirstFailure = false;
            this.txtDeposNWMoney.ResetOnPrompt = true;
            this.txtDeposNWMoney.ResetOnSpace = true;
            this.txtDeposNWMoney.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDeposNWMoney.SelectedText = "";
            this.txtDeposNWMoney.SelectionLength = 0;
            this.txtDeposNWMoney.SelectionStart = 0;
            this.txtDeposNWMoney.ShortcutsEnabled = true;
            this.txtDeposNWMoney.Size = new System.Drawing.Size(234, 48);
            this.txtDeposNWMoney.SkipLiterals = true;
            this.txtDeposNWMoney.TabIndex = 0;
            this.txtDeposNWMoney.TabStop = false;
            this.txtDeposNWMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDeposNWMoney.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtDeposNWMoney.TrailingIcon = null;
            this.txtDeposNWMoney.UseSystemPasswordChar = false;
            this.txtDeposNWMoney.ValidatingType = null;
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.Location = new System.Drawing.Point(6, 149);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(96, 19);
            this.materialLabel9.TabIndex = 34;
            this.materialLabel9.Text = "deposit date :";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(568, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(587, 530);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // Bankdeposreport
            // 
            this.Bankdeposreport.Controls.Add(this.btnSearchR2);
            this.Bankdeposreport.Controls.Add(this.btnDeleteR);
            this.Bankdeposreport.Controls.Add(this.LblTotal);
            this.Bankdeposreport.Controls.Add(this.txtTotalR);
            this.Bankdeposreport.Controls.Add(this.LblTitleExpR);
            this.Bankdeposreport.Controls.Add(this.materialCard4);
            this.Bankdeposreport.Controls.Add(this.materialCard5);
            this.Bankdeposreport.Controls.Add(this.btnSearchR);
            this.Bankdeposreport.Location = new System.Drawing.Point(4, 25);
            this.Bankdeposreport.Name = "Bankdeposreport";
            this.Bankdeposreport.Size = new System.Drawing.Size(1155, 521);
            this.Bankdeposreport.TabIndex = 2;
            this.Bankdeposreport.Text = "Bank deposits report";
            this.Bankdeposreport.UseVisualStyleBackColor = true;
            // 
            // btnSearchR2
            // 
            this.btnSearchR2.Location = new System.Drawing.Point(64, 94);
            this.btnSearchR2.Name = "btnSearchR2";
            this.btnSearchR2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnSearchR2.Size = new System.Drawing.Size(126, 52);
            this.btnSearchR2.StateCommon.Back.ColorAngle = 45F;
            this.btnSearchR2.StateCommon.Border.ColorAngle = 45F;
            this.btnSearchR2.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSearchR2.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSearchR2.StateCommon.Border.Rounding = 20;
            this.btnSearchR2.StateCommon.Border.Width = 1;
            this.btnSearchR2.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.btnSearchR2.StateNormal.Border.ColorAngle = 45F;
            this.btnSearchR2.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSearchR2.StateNormal.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSearchR2.StateNormal.Border.Rounding = 20;
            this.btnSearchR2.StateNormal.Border.Width = 1;
            this.btnSearchR2.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSearchR2.StatePressed.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSearchR2.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSearchR2.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSearchR2.TabIndex = 49;
            this.btnSearchR2.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchR2.Values.Image")));
            this.btnSearchR2.Values.Text = "";
            // 
            // btnDeleteR
            // 
            this.btnDeleteR.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeleteR.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDeleteR.Depth = 0;
            this.btnDeleteR.HighEmphasis = true;
            this.btnDeleteR.Icon = ((System.Drawing.Image)(resources.GetObject("btnDeleteR.Icon")));
            this.btnDeleteR.Location = new System.Drawing.Point(989, 451);
            this.btnDeleteR.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDeleteR.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDeleteR.Name = "btnDeleteR";
            this.btnDeleteR.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDeleteR.Size = new System.Drawing.Size(101, 36);
            this.btnDeleteR.TabIndex = 48;
            this.btnDeleteR.Text = "Delete";
            this.btnDeleteR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDeleteR.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDeleteR.UseAccentColor = true;
            this.btnDeleteR.UseVisualStyleBackColor = true;
            this.btnDeleteR.Click += new System.EventHandler(this.btnDeleteR_Click);
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Depth = 0;
            this.LblTotal.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblTotal.Location = new System.Drawing.Point(61, 454);
            this.LblTotal.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(106, 19);
            this.LblTotal.TabIndex = 47;
            this.LblTotal.Text = "Total Amount :";
            // 
            // txtTotalR
            // 
            this.txtTotalR.Enabled = false;
            this.txtTotalR.Location = new System.Drawing.Point(173, 452);
            this.txtTotalR.Name = "txtTotalR";
            this.txtTotalR.ReadOnly = true;
            this.txtTotalR.Size = new System.Drawing.Size(109, 22);
            this.txtTotalR.TabIndex = 46;
            // 
            // LblTitleExpR
            // 
            this.LblTitleExpR.AutoSize = true;
            this.LblTitleExpR.Depth = 0;
            this.LblTitleExpR.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.LblTitleExpR.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.LblTitleExpR.Location = new System.Drawing.Point(329, 36);
            this.LblTitleExpR.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblTitleExpR.Name = "LblTitleExpR";
            this.LblTitleExpR.Size = new System.Drawing.Size(466, 29);
            this.LblTitleExpR.TabIndex = 45;
            this.LblTitleExpR.Text = "Total deposits in a bank between the period";
            // 
            // materialCard4
            // 
            this.materialCard4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard4.Controls.Add(this.DgvR);
            this.materialCard4.Depth = 0;
            this.materialCard4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard4.Location = new System.Drawing.Point(62, 158);
            this.materialCard4.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard4.Name = "materialCard4";
            this.materialCard4.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard4.Size = new System.Drawing.Size(1031, 286);
            this.materialCard4.TabIndex = 44;
            // 
            // DgvR
            // 
            this.DgvR.AllowUserToAddRows = false;
            this.DgvR.AllowUserToDeleteRows = false;
            this.DgvR.AllowUserToResizeColumns = false;
            this.DgvR.AllowUserToResizeRows = false;
            this.DgvR.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvR.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvR.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.DgvR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvR.ColumnHeadersHeight = 29;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(158)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvR.DefaultCellStyle = dataGridViewCellStyle5;
            this.DgvR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvR.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DgvR.Location = new System.Drawing.Point(14, 14);
            this.DgvR.Name = "DgvR";
            this.DgvR.ReadOnly = true;
            this.DgvR.RowHeadersWidth = 51;
            this.DgvR.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DgvR.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.DgvR.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(158)))), ((int)(((byte)(128)))));
            this.DgvR.RowTemplate.Height = 24;
            this.DgvR.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvR.Size = new System.Drawing.Size(1003, 258);
            this.DgvR.TabIndex = 0;
            // 
            // materialCard5
            // 
            this.materialCard5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard5.Controls.Add(this.DateToR);
            this.materialCard5.Controls.Add(this.lblTo);
            this.materialCard5.Controls.Add(this.DateFromR);
            this.materialCard5.Controls.Add(this.materialLabel6);
            this.materialCard5.Depth = 0;
            this.materialCard5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard5.Location = new System.Drawing.Point(227, 94);
            this.materialCard5.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard5.Name = "materialCard5";
            this.materialCard5.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard5.Size = new System.Drawing.Size(683, 52);
            this.materialCard5.TabIndex = 43;
            // 
            // DateToR
            // 
            this.DateToR.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateToR.Location = new System.Drawing.Point(443, 13);
            this.DateToR.Name = "DateToR";
            this.DateToR.Size = new System.Drawing.Size(176, 22);
            this.DateToR.TabIndex = 18;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Depth = 0;
            this.lblTo.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTo.Location = new System.Drawing.Point(404, 15);
            this.lblTo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(28, 19);
            this.lblTo.TabIndex = 17;
            this.lblTo.Text = "To :";
            // 
            // DateFromR
            // 
            this.DateFromR.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateFromR.Location = new System.Drawing.Point(120, 15);
            this.DateFromR.Name = "DateFromR";
            this.DateFromR.Size = new System.Drawing.Size(176, 22);
            this.DateFromR.TabIndex = 16;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(63, 17);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(46, 19);
            this.materialLabel6.TabIndex = 0;
            this.materialLabel6.Text = "From :";
            // 
            // btnSearchR
            // 
            this.btnSearchR.Location = new System.Drawing.Point(960, 94);
            this.btnSearchR.Name = "btnSearchR";
            this.btnSearchR.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnSearchR.Size = new System.Drawing.Size(133, 52);
            this.btnSearchR.StateCommon.Back.ColorAngle = 45F;
            this.btnSearchR.StateCommon.Border.ColorAngle = 45F;
            this.btnSearchR.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSearchR.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSearchR.StateCommon.Border.Rounding = 20;
            this.btnSearchR.StateCommon.Border.Width = 1;
            this.btnSearchR.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.btnSearchR.StateNormal.Border.ColorAngle = 45F;
            this.btnSearchR.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSearchR.StateNormal.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSearchR.StateNormal.Border.Rounding = 20;
            this.btnSearchR.StateNormal.Border.Width = 1;
            this.btnSearchR.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSearchR.StatePressed.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSearchR.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSearchR.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSearchR.TabIndex = 42;
            this.btnSearchR.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchR.Values.Image")));
            this.btnSearchR.Values.Text = "";
            this.btnSearchR.Click += new System.EventHandler(this.btnSearchR_Click);
            // 
            // BankWithdReport
            // 
            this.BankWithdReport.Controls.Add(this.kryptonButton1);
            this.BankWithdReport.Controls.Add(this.btnDeleteRW);
            this.BankWithdReport.Controls.Add(this.materialLabel10);
            this.BankWithdReport.Controls.Add(this.txtTotalRW);
            this.BankWithdReport.Controls.Add(this.materialLabel11);
            this.BankWithdReport.Controls.Add(this.materialCard6);
            this.BankWithdReport.Controls.Add(this.materialCard7);
            this.BankWithdReport.Controls.Add(this.btnSearchRW);
            this.BankWithdReport.Location = new System.Drawing.Point(4, 25);
            this.BankWithdReport.Name = "BankWithdReport";
            this.BankWithdReport.Size = new System.Drawing.Size(1155, 521);
            this.BankWithdReport.TabIndex = 3;
            this.BankWithdReport.Text = "Bank withdrawal report";
            this.BankWithdReport.UseVisualStyleBackColor = true;
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(59, 101);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.kryptonButton1.Size = new System.Drawing.Size(126, 52);
            this.kryptonButton1.StateCommon.Back.ColorAngle = 45F;
            this.kryptonButton1.StateCommon.Border.ColorAngle = 45F;
            this.kryptonButton1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonButton1.StateCommon.Border.Rounding = 20;
            this.kryptonButton1.StateCommon.Border.Width = 1;
            this.kryptonButton1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.kryptonButton1.StateNormal.Border.ColorAngle = 45F;
            this.kryptonButton1.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StateNormal.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonButton1.StateNormal.Border.Rounding = 20;
            this.kryptonButton1.StateNormal.Border.Width = 1;
            this.kryptonButton1.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StatePressed.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonButton1.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonButton1.TabIndex = 57;
            this.kryptonButton1.Values.Image = ((System.Drawing.Image)(resources.GetObject("kryptonButton1.Values.Image")));
            this.kryptonButton1.Values.Text = "";
            // 
            // btnDeleteRW
            // 
            this.btnDeleteRW.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeleteRW.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDeleteRW.Depth = 0;
            this.btnDeleteRW.HighEmphasis = true;
            this.btnDeleteRW.Icon = ((System.Drawing.Image)(resources.GetObject("btnDeleteRW.Icon")));
            this.btnDeleteRW.Location = new System.Drawing.Point(984, 458);
            this.btnDeleteRW.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDeleteRW.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDeleteRW.Name = "btnDeleteRW";
            this.btnDeleteRW.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDeleteRW.Size = new System.Drawing.Size(101, 36);
            this.btnDeleteRW.TabIndex = 56;
            this.btnDeleteRW.Text = "Delete";
            this.btnDeleteRW.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDeleteRW.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDeleteRW.UseAccentColor = true;
            this.btnDeleteRW.UseVisualStyleBackColor = true;
            this.btnDeleteRW.Click += new System.EventHandler(this.btnDeleteRW_Click);
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel10.Location = new System.Drawing.Point(56, 461);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(106, 19);
            this.materialLabel10.TabIndex = 55;
            this.materialLabel10.Text = "Total Amount :";
            // 
            // txtTotalRW
            // 
            this.txtTotalRW.Enabled = false;
            this.txtTotalRW.Location = new System.Drawing.Point(168, 459);
            this.txtTotalRW.Name = "txtTotalRW";
            this.txtTotalRW.ReadOnly = true;
            this.txtTotalRW.Size = new System.Drawing.Size(109, 22);
            this.txtTotalRW.TabIndex = 54;
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel11.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel11.Location = new System.Drawing.Point(366, 41);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(330, 29);
            this.materialLabel11.TabIndex = 53;
            this.materialLabel11.Text = "Total withdrawals in the period";
            // 
            // materialCard6
            // 
            this.materialCard6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard6.Controls.Add(this.DgvRW);
            this.materialCard6.Depth = 0;
            this.materialCard6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard6.Location = new System.Drawing.Point(57, 165);
            this.materialCard6.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard6.Name = "materialCard6";
            this.materialCard6.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard6.Size = new System.Drawing.Size(1031, 286);
            this.materialCard6.TabIndex = 52;
            // 
            // DgvRW
            // 
            this.DgvRW.AllowUserToAddRows = false;
            this.DgvRW.AllowUserToDeleteRows = false;
            this.DgvRW.AllowUserToResizeColumns = false;
            this.DgvRW.AllowUserToResizeRows = false;
            this.DgvRW.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvRW.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvRW.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.DgvRW.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvRW.ColumnHeadersHeight = 29;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(158)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvRW.DefaultCellStyle = dataGridViewCellStyle6;
            this.DgvRW.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvRW.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DgvRW.Location = new System.Drawing.Point(14, 14);
            this.DgvRW.Name = "DgvRW";
            this.DgvRW.ReadOnly = true;
            this.DgvRW.RowHeadersWidth = 51;
            this.DgvRW.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DgvRW.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.DgvRW.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(158)))), ((int)(((byte)(128)))));
            this.DgvRW.RowTemplate.Height = 24;
            this.DgvRW.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvRW.Size = new System.Drawing.Size(1003, 258);
            this.DgvRW.TabIndex = 0;
            // 
            // materialCard7
            // 
            this.materialCard7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard7.Controls.Add(this.DateToRW);
            this.materialCard7.Controls.Add(this.materialLabel12);
            this.materialCard7.Controls.Add(this.DateFromRW);
            this.materialCard7.Controls.Add(this.materialLabel13);
            this.materialCard7.Depth = 0;
            this.materialCard7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard7.Location = new System.Drawing.Point(222, 101);
            this.materialCard7.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard7.Name = "materialCard7";
            this.materialCard7.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard7.Size = new System.Drawing.Size(683, 52);
            this.materialCard7.TabIndex = 51;
            // 
            // DateToRW
            // 
            this.DateToRW.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateToRW.Location = new System.Drawing.Point(443, 13);
            this.DateToRW.Name = "DateToRW";
            this.DateToRW.Size = new System.Drawing.Size(176, 22);
            this.DateToRW.TabIndex = 18;
            // 
            // materialLabel12
            // 
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel12.Location = new System.Drawing.Point(404, 15);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(28, 19);
            this.materialLabel12.TabIndex = 17;
            this.materialLabel12.Text = "To :";
            // 
            // DateFromRW
            // 
            this.DateFromRW.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateFromRW.Location = new System.Drawing.Point(120, 15);
            this.DateFromRW.Name = "DateFromRW";
            this.DateFromRW.Size = new System.Drawing.Size(176, 22);
            this.DateFromRW.TabIndex = 16;
            // 
            // materialLabel13
            // 
            this.materialLabel13.AutoSize = true;
            this.materialLabel13.Depth = 0;
            this.materialLabel13.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel13.Location = new System.Drawing.Point(63, 17);
            this.materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel13.Name = "materialLabel13";
            this.materialLabel13.Size = new System.Drawing.Size(46, 19);
            this.materialLabel13.TabIndex = 0;
            this.materialLabel13.Text = "From :";
            // 
            // btnSearchRW
            // 
            this.btnSearchRW.Location = new System.Drawing.Point(955, 101);
            this.btnSearchRW.Name = "btnSearchRW";
            this.btnSearchRW.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnSearchRW.Size = new System.Drawing.Size(133, 52);
            this.btnSearchRW.StateCommon.Back.ColorAngle = 45F;
            this.btnSearchRW.StateCommon.Border.ColorAngle = 45F;
            this.btnSearchRW.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSearchRW.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSearchRW.StateCommon.Border.Rounding = 20;
            this.btnSearchRW.StateCommon.Border.Width = 1;
            this.btnSearchRW.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.btnSearchRW.StateNormal.Border.ColorAngle = 45F;
            this.btnSearchRW.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSearchRW.StateNormal.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSearchRW.StateNormal.Border.Rounding = 20;
            this.btnSearchRW.StateNormal.Border.Width = 1;
            this.btnSearchRW.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSearchRW.StatePressed.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSearchRW.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSearchRW.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSearchRW.TabIndex = 50;
            this.btnSearchRW.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchRW.Values.Image")));
            this.btnSearchRW.Values.Text = "";
            this.btnSearchRW.Click += new System.EventHandler(this.btnSearchRW_Click);
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTabSelector1.Location = new System.Drawing.Point(-33, 24);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(1209, 48);
            this.materialTabSelector1.TabIndex = 1;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // FrmBank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 634);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialTabControl1);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.MaximizeBox = false;
            this.Name = "FrmBank";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBank";
            this.Load += new System.EventHandler(this.FrmBank_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.AddMoneyBank.ResumeLayout(false);
            this.AddMoneyBank.PerformLayout();
            this.CardAddMoneyBank.ResumeLayout(false);
            this.CardAddMoneyBank.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudAddBalance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.WithdrawBank.ResumeLayout(false);
            this.WithdrawBank.PerformLayout();
            this.materialCard3.ResumeLayout(false);
            this.materialCard3.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NubAddBalanceWMoney)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.Bankdeposreport.ResumeLayout(false);
            this.Bankdeposreport.PerformLayout();
            this.materialCard4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvR)).EndInit();
            this.materialCard5.ResumeLayout(false);
            this.materialCard5.PerformLayout();
            this.BankWithdReport.ResumeLayout(false);
            this.BankWithdReport.PerformLayout();
            this.materialCard6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvRW)).EndInit();
            this.materialCard7.ResumeLayout(false);
            this.materialCard7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage AddMoneyBank;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialCard CardAddMoneyBank;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtCurrentBalance;
        private System.Windows.Forms.GroupBox groupBox5;
        private MaterialSkin.Controls.MaterialButton btnAddMoney;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.GroupBox groupBox4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.NumericUpDown NudAddBalance;
        private System.Windows.Forms.DateTimePicker DateDespoAMoney;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 TxtNoteAMoney;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtDeposName;
        private MaterialSkin.Controls.MaterialLabel lblFrom;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtBalanceWMoney;
        private System.Windows.Forms.GroupBox groupBox6;
        private MaterialSkin.Controls.MaterialButton btnWithdrow;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private System.Windows.Forms.GroupBox groupBox7;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private System.Windows.Forms.NumericUpDown NubAddBalanceWMoney;
        private System.Windows.Forms.DateTimePicker DateWMoney;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtNoteWMoney;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtDeposNWMoney;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSearchR2;
        private MaterialSkin.Controls.MaterialButton btnDeleteR;
        private MaterialSkin.Controls.MaterialLabel LblTotal;
        private System.Windows.Forms.TextBox txtTotalR;
        private MaterialSkin.Controls.MaterialLabel LblTitleExpR;
        private MaterialSkin.Controls.MaterialCard materialCard4;
        private System.Windows.Forms.DataGridView DgvR;
        private MaterialSkin.Controls.MaterialCard materialCard5;
        private System.Windows.Forms.DateTimePicker DateToR;
        private MaterialSkin.Controls.MaterialLabel lblTo;
        private System.Windows.Forms.DateTimePicker DateFromR;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSearchR;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private MaterialSkin.Controls.MaterialButton btnDeleteRW;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private System.Windows.Forms.TextBox txtTotalRW;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialCard materialCard6;
        private System.Windows.Forms.DataGridView DgvRW;
        private MaterialSkin.Controls.MaterialCard materialCard7;
        private System.Windows.Forms.DateTimePicker DateToRW;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private System.Windows.Forms.DateTimePicker DateFromRW;
        private MaterialSkin.Controls.MaterialLabel materialLabel13;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSearchRW;
        public System.Windows.Forms.TabPage WithdrawBank;
        public System.Windows.Forms.TabPage Bankdeposreport;
        public System.Windows.Forms.TabPage BankWithdReport;
    }
}