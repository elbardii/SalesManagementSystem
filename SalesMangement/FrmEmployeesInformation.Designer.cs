namespace SalesMangement
{
    partial class FrmEmployeesInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmployeesInformation));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.DateDue = new System.Windows.Forms.DateTimePicker();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.txtNational = new MaterialSkin.Controls.MaterialTextBox();
            this.txtAddressEmp = new MaterialSkin.Controls.MaterialTextBox();
            this.txtSalary = new MaterialSkin.Controls.MaterialTextBox();
            this.txtPhoneEmp = new MaterialSkin.Controls.MaterialTextBox();
            this.TxtNoteEmp = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.txtIdEmp = new MaterialSkin.Controls.MaterialTextBox();
            this.txtNameEmp = new MaterialSkin.Controls.MaterialTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnFirst = new MaterialSkin.Controls.MaterialButton();
            this.btnPrevious = new MaterialSkin.Controls.MaterialButton();
            this.btnNext = new MaterialSkin.Controls.MaterialButton();
            this.btnLast = new MaterialSkin.Controls.MaterialButton();
            this.btnDeleteAll = new MaterialSkin.Controls.MaterialButton();
            this.btnDelete = new MaterialSkin.Controls.MaterialButton();
            this.btnSave = new MaterialSkin.Controls.MaterialButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnNew = new MaterialSkin.Controls.MaterialButton();
            this.btnAdd = new MaterialSkin.Controls.MaterialButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.txtSearch = new MaterialSkin.Controls.MaterialTextBox();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.txtNational);
            this.groupBox1.Controls.Add(this.txtAddressEmp);
            this.groupBox1.Controls.Add(this.txtSalary);
            this.groupBox1.Controls.Add(this.txtPhoneEmp);
            this.groupBox1.Controls.Add(this.TxtNoteEmp);
            this.groupBox1.Controls.Add(this.txtIdEmp);
            this.groupBox1.Controls.Add(this.txtNameEmp);
            this.groupBox1.Location = new System.Drawing.Point(137, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(896, 312);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.DateDue);
            this.groupBox4.Controls.Add(this.materialLabel9);
            this.groupBox4.Location = new System.Drawing.Point(45, 253);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(228, 53);
            this.groupBox4.TabIndex = 43;
            this.groupBox4.TabStop = false;
            // 
            // DateDue
            // 
            this.DateDue.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateDue.Location = new System.Drawing.Point(90, 19);
            this.DateDue.Name = "DateDue";
            this.DateDue.Size = new System.Drawing.Size(124, 22);
            this.DateDue.TabIndex = 36;
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.Location = new System.Drawing.Point(14, 20);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(70, 19);
            this.materialLabel9.TabIndex = 41;
            this.materialLabel9.Text = "due date :";
            // 
            // txtNational
            // 
            this.txtNational.AccessibleName = "";
            this.txtNational.AnimateReadOnly = false;
            this.txtNational.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtNational.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNational.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtNational.Depth = 0;
            this.txtNational.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNational.Hint = "National ID ";
            this.txtNational.LeadingIcon = null;
            this.txtNational.Location = new System.Drawing.Point(45, 90);
            this.txtNational.MaxLength = 50;
            this.txtNational.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNational.Multiline = false;
            this.txtNational.Name = "txtNational";
            this.txtNational.Size = new System.Drawing.Size(214, 50);
            this.txtNational.TabIndex = 40;
            this.txtNational.Text = "";
            this.txtNational.TrailingIcon = ((System.Drawing.Image)(resources.GetObject("txtNational.TrailingIcon")));
            // 
            // txtAddressEmp
            // 
            this.txtAddressEmp.AnimateReadOnly = false;
            this.txtAddressEmp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddressEmp.Depth = 0;
            this.txtAddressEmp.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtAddressEmp.Hint = "Employee  Address";
            this.txtAddressEmp.LeadingIcon = null;
            this.txtAddressEmp.Location = new System.Drawing.Point(45, 205);
            this.txtAddressEmp.MaxLength = 50;
            this.txtAddressEmp.MouseState = MaterialSkin.MouseState.OUT;
            this.txtAddressEmp.Multiline = false;
            this.txtAddressEmp.Name = "txtAddressEmp";
            this.txtAddressEmp.Size = new System.Drawing.Size(437, 50);
            this.txtAddressEmp.TabIndex = 37;
            this.txtAddressEmp.Text = "";
            this.txtAddressEmp.TrailingIcon = ((System.Drawing.Image)(resources.GetObject("txtAddressEmp.TrailingIcon")));
            // 
            // txtSalary
            // 
            this.txtSalary.AnimateReadOnly = false;
            this.txtSalary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSalary.Depth = 0;
            this.txtSalary.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSalary.Hint = "salary";
            this.txtSalary.LeadingIcon = null;
            this.txtSalary.Location = new System.Drawing.Point(277, 90);
            this.txtSalary.MaxLength = 50;
            this.txtSalary.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSalary.Multiline = false;
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(205, 50);
            this.txtSalary.TabIndex = 39;
            this.txtSalary.Text = "";
            this.txtSalary.TrailingIcon = ((System.Drawing.Image)(resources.GetObject("txtSalary.TrailingIcon")));
            // 
            // txtPhoneEmp
            // 
            this.txtPhoneEmp.AnimateReadOnly = false;
            this.txtPhoneEmp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhoneEmp.Depth = 0;
            this.txtPhoneEmp.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPhoneEmp.Hint = "Phone Number";
            this.txtPhoneEmp.LeadingIcon = null;
            this.txtPhoneEmp.Location = new System.Drawing.Point(45, 146);
            this.txtPhoneEmp.MaxLength = 50;
            this.txtPhoneEmp.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPhoneEmp.Multiline = false;
            this.txtPhoneEmp.Name = "txtPhoneEmp";
            this.txtPhoneEmp.Size = new System.Drawing.Size(437, 50);
            this.txtPhoneEmp.TabIndex = 36;
            this.txtPhoneEmp.Text = "";
            this.txtPhoneEmp.TrailingIcon = ((System.Drawing.Image)(resources.GetObject("txtPhoneEmp.TrailingIcon")));
            // 
            // TxtNoteEmp
            // 
            this.TxtNoteEmp.AnimateReadOnly = false;
            this.TxtNoteEmp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TxtNoteEmp.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TxtNoteEmp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtNoteEmp.Depth = 0;
            this.TxtNoteEmp.HideSelection = true;
            this.TxtNoteEmp.Hint = "Employee  Notes";
            this.TxtNoteEmp.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TxtNoteEmp.Location = new System.Drawing.Point(498, 34);
            this.TxtNoteEmp.MaxLength = 32767;
            this.TxtNoteEmp.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtNoteEmp.Name = "TxtNoteEmp";
            this.TxtNoteEmp.PasswordChar = '\0';
            this.TxtNoteEmp.ReadOnly = false;
            this.TxtNoteEmp.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtNoteEmp.SelectedText = "";
            this.TxtNoteEmp.SelectionLength = 0;
            this.TxtNoteEmp.SelectionStart = 0;
            this.TxtNoteEmp.ShortcutsEnabled = true;
            this.TxtNoteEmp.Size = new System.Drawing.Size(346, 221);
            this.TxtNoteEmp.TabIndex = 38;
            this.TxtNoteEmp.TabStop = false;
            this.TxtNoteEmp.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtNoteEmp.UseSystemPasswordChar = false;
            // 
            // txtIdEmp
            // 
            this.txtIdEmp.AccessibleName = "";
            this.txtIdEmp.AnimateReadOnly = false;
            this.txtIdEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtIdEmp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdEmp.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtIdEmp.Depth = 0;
            this.txtIdEmp.Enabled = false;
            this.txtIdEmp.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtIdEmp.Hint = "Employee Number";
            this.txtIdEmp.LeadingIcon = null;
            this.txtIdEmp.Location = new System.Drawing.Point(45, 34);
            this.txtIdEmp.MaxLength = 50;
            this.txtIdEmp.MouseState = MaterialSkin.MouseState.OUT;
            this.txtIdEmp.Multiline = false;
            this.txtIdEmp.Name = "txtIdEmp";
            this.txtIdEmp.Size = new System.Drawing.Size(214, 50);
            this.txtIdEmp.TabIndex = 34;
            this.txtIdEmp.Text = "";
            this.txtIdEmp.TrailingIcon = ((System.Drawing.Image)(resources.GetObject("txtIdEmp.TrailingIcon")));
            // 
            // txtNameEmp
            // 
            this.txtNameEmp.AnimateReadOnly = false;
            this.txtNameEmp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNameEmp.Depth = 0;
            this.txtNameEmp.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNameEmp.Hint = "Employee  Name";
            this.txtNameEmp.LeadingIcon = null;
            this.txtNameEmp.Location = new System.Drawing.Point(277, 34);
            this.txtNameEmp.MaxLength = 50;
            this.txtNameEmp.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNameEmp.Multiline = false;
            this.txtNameEmp.Name = "txtNameEmp";
            this.txtNameEmp.Size = new System.Drawing.Size(205, 50);
            this.txtNameEmp.TabIndex = 35;
            this.txtNameEmp.Text = "";
            this.txtNameEmp.TrailingIcon = ((System.Drawing.Image)(resources.GetObject("txtNameEmp.TrailingIcon")));
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnFirst);
            this.groupBox3.Controls.Add(this.btnPrevious);
            this.groupBox3.Controls.Add(this.btnNext);
            this.groupBox3.Controls.Add(this.btnLast);
            this.groupBox3.Location = new System.Drawing.Point(135, 547);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(889, 63);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            // 
            // btnFirst
            // 
            this.btnFirst.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFirst.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnFirst.Depth = 0;
            this.btnFirst.HighEmphasis = true;
            this.btnFirst.Icon = ((System.Drawing.Image)(resources.GetObject("btnFirst.Icon")));
            this.btnFirst.Location = new System.Drawing.Point(179, 17);
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
            this.btnPrevious.Location = new System.Drawing.Point(309, 17);
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
            this.btnNext.Location = new System.Drawing.Point(489, 17);
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
            this.btnLast.Location = new System.Drawing.Point(623, 17);
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
            this.btnDeleteAll.Location = new System.Drawing.Point(837, 488);
            this.btnDeleteAll.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDeleteAll.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDeleteAll.Size = new System.Drawing.Size(131, 36);
            this.btnDeleteAll.TabIndex = 15;
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
            this.btnDelete.Location = new System.Drawing.Point(665, 488);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDelete.Size = new System.Drawing.Size(101, 36);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDelete.UseAccentColor = true;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSave.Depth = 0;
            this.btnSave.HighEmphasis = true;
            this.btnSave.Icon = ((System.Drawing.Image)(resources.GetObject("btnSave.Icon")));
            this.btnSave.Location = new System.Drawing.Point(514, 488);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSave.Size = new System.Drawing.Size(86, 36);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSave.UseAccentColor = false;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(174, 565);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(0, 0);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            // 
            // btnNew
            // 
            this.btnNew.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNew.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnNew.Depth = 0;
            this.btnNew.HighEmphasis = true;
            this.btnNew.Icon = ((System.Drawing.Image)(resources.GetObject("btnNew.Icon")));
            this.btnNew.Location = new System.Drawing.Point(365, 488);
            this.btnNew.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNew.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNew.Name = "btnNew";
            this.btnNew.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnNew.Size = new System.Drawing.Size(81, 36);
            this.btnNew.TabIndex = 12;
            this.btnNew.Text = "New";
            this.btnNew.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnNew.UseAccentColor = false;
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAdd.Depth = 0;
            this.btnAdd.HighEmphasis = true;
            this.btnAdd.Icon = ((System.Drawing.Image)(resources.GetObject("btnAdd.Icon")));
            this.btnAdd.Location = new System.Drawing.Point(219, 488);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAdd.Size = new System.Drawing.Size(78, 36);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add";
            this.btnAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAdd.UseAccentColor = false;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Location = new System.Drawing.Point(6, 496);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(206, 16);
            this.groupBox5.TabIndex = 18;
            this.groupBox5.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Location = new System.Drawing.Point(975, 496);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(191, 16);
            this.groupBox6.TabIndex = 19;
            this.groupBox6.TabStop = false;
            // 
            // groupBox7
            // 
            this.groupBox7.Location = new System.Drawing.Point(775, 496);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(57, 16);
            this.groupBox7.TabIndex = 20;
            this.groupBox7.TabStop = false;
            // 
            // groupBox8
            // 
            this.groupBox8.Location = new System.Drawing.Point(604, 496);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(57, 16);
            this.groupBox8.TabIndex = 21;
            this.groupBox8.TabStop = false;
            // 
            // groupBox9
            // 
            this.groupBox9.Location = new System.Drawing.Point(452, 496);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(57, 16);
            this.groupBox9.TabIndex = 22;
            this.groupBox9.TabStop = false;
            // 
            // groupBox10
            // 
            this.groupBox10.Location = new System.Drawing.Point(304, 496);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(57, 16);
            this.groupBox10.TabIndex = 23;
            this.groupBox10.TabStop = false;
            // 
            // groupBox11
            // 
            this.groupBox11.Location = new System.Drawing.Point(7, 71);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(124, 376);
            this.groupBox11.TabIndex = 24;
            this.groupBox11.TabStop = false;
            // 
            // groupBox12
            // 
            this.groupBox12.Location = new System.Drawing.Point(1039, 70);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(125, 377);
            this.groupBox12.TabIndex = 25;
            this.groupBox12.TabStop = false;
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.txtSearch);
            this.groupBox13.Location = new System.Drawing.Point(137, 70);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(896, 67);
            this.groupBox13.TabIndex = 26;
            this.groupBox13.TabStop = false;
            // 
            // txtSearch
            // 
            this.txtSearch.AnimateReadOnly = false;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Depth = 0;
            this.txtSearch.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearch.Hint = "Search for an employee";
            this.txtSearch.LeadingIcon = null;
            this.txtSearch.Location = new System.Drawing.Point(142, 21);
            this.txtSearch.MaxLength = 50;
            this.txtSearch.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSearch.Multiline = false;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSearch.Size = new System.Drawing.Size(632, 36);
            this.txtSearch.TabIndex = 37;
            this.txtSearch.Text = "";
            this.txtSearch.TrailingIcon = ((System.Drawing.Image)(resources.GetObject("txtSearch.TrailingIcon")));
            this.txtSearch.UseTallSize = false;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // groupBox14
            // 
            this.groupBox14.Location = new System.Drawing.Point(1030, 547);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(136, 63);
            this.groupBox14.TabIndex = 27;
            this.groupBox14.TabStop = false;
            // 
            // groupBox15
            // 
            this.groupBox15.Location = new System.Drawing.Point(6, 547);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(123, 63);
            this.groupBox15.TabIndex = 28;
            this.groupBox15.TabStop = false;
            // 
            // FrmEmployeesInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1172, 634);
            this.Controls.Add(this.groupBox15);
            this.Controls.Add(this.groupBox14);
            this.Controls.Add(this.groupBox13);
            this.Controls.Add(this.groupBox12);
            this.Controls.Add(this.groupBox11);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnDeleteAll);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "FrmEmployeesInformation";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employees Information";
            this.Load += new System.EventHandler(this.FrmEmployeesInformation_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialTextBox txtNational;
        private MaterialSkin.Controls.MaterialTextBox txtAddressEmp;
        private MaterialSkin.Controls.MaterialTextBox txtSalary;
        private MaterialSkin.Controls.MaterialTextBox txtPhoneEmp;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 TxtNoteEmp;
        private MaterialSkin.Controls.MaterialTextBox txtIdEmp;
        private MaterialSkin.Controls.MaterialTextBox txtNameEmp;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private System.Windows.Forms.GroupBox groupBox3;
        private MaterialSkin.Controls.MaterialButton btnFirst;
        private MaterialSkin.Controls.MaterialButton btnPrevious;
        private MaterialSkin.Controls.MaterialButton btnNext;
        private MaterialSkin.Controls.MaterialButton btnLast;
        private MaterialSkin.Controls.MaterialButton btnDeleteAll;
        private MaterialSkin.Controls.MaterialButton btnDelete;
        private MaterialSkin.Controls.MaterialButton btnSave;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialButton btnNew;
        private MaterialSkin.Controls.MaterialButton btnAdd;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.DateTimePicker DateDue;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.GroupBox groupBox15;
        private MaterialSkin.Controls.MaterialTextBox txtSearch;
    }
}