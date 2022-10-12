
namespace SalesMangement
{
    partial class FrmCustomerData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCustomerData));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtNoteCus = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.TxtAddressCus = new MaterialSkin.Controls.MaterialTextBox();
            this.TxtPhoneCus = new MaterialSkin.Controls.MaterialTextBox();
            this.TxtIdCus = new MaterialSkin.Controls.MaterialTextBox();
            this.TxtNameCus = new MaterialSkin.Controls.MaterialTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txtSearchCust = new MaterialSkin.Controls.MaterialTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDeleteAllCus = new MaterialSkin.Controls.MaterialButton();
            this.btnDeleteCus = new MaterialSkin.Controls.MaterialButton();
            this.btnSaveCus = new MaterialSkin.Controls.MaterialButton();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.btnNewCus = new MaterialSkin.Controls.MaterialButton();
            this.btnAddCus = new MaterialSkin.Controls.MaterialButton();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnFirst = new MaterialSkin.Controls.MaterialButton();
            this.btnPrevious = new MaterialSkin.Controls.MaterialButton();
            this.btnNext = new MaterialSkin.Controls.MaterialButton();
            this.btnLast = new MaterialSkin.Controls.MaterialButton();
            this.groupBox2.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.TxtNoteCus);
            this.groupBox2.Controls.Add(this.TxtAddressCus);
            this.groupBox2.Controls.Add(this.TxtPhoneCus);
            this.groupBox2.Controls.Add(this.TxtIdCus);
            this.groupBox2.Controls.Add(this.TxtNameCus);
            this.groupBox2.Location = new System.Drawing.Point(166, 155);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(840, 264);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            // 
            // TxtNoteCus
            // 
            this.TxtNoteCus.AnimateReadOnly = false;
            this.TxtNoteCus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TxtNoteCus.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TxtNoteCus.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtNoteCus.Depth = 0;
            this.TxtNoteCus.HideSelection = true;
            this.TxtNoteCus.Hint = "Customer Notes";
            this.TxtNoteCus.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TxtNoteCus.Location = new System.Drawing.Point(488, 28);
            this.TxtNoteCus.MaxLength = 32767;
            this.TxtNoteCus.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtNoteCus.Name = "TxtNoteCus";
            this.TxtNoteCus.PasswordChar = '\0';
            this.TxtNoteCus.ReadOnly = false;
            this.TxtNoteCus.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtNoteCus.SelectedText = "";
            this.TxtNoteCus.SelectionLength = 0;
            this.TxtNoteCus.SelectionStart = 0;
            this.TxtNoteCus.ShortcutsEnabled = true;
            this.TxtNoteCus.Size = new System.Drawing.Size(346, 221);
            this.TxtNoteCus.TabIndex = 38;
            this.TxtNoteCus.TabStop = false;
            this.TxtNoteCus.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtNoteCus.UseSystemPasswordChar = false;
            // 
            // TxtAddressCus
            // 
            this.TxtAddressCus.AnimateReadOnly = false;
            this.TxtAddressCus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtAddressCus.Depth = 0;
            this.TxtAddressCus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtAddressCus.Hint = "Customer Address";
            this.TxtAddressCus.LeadingIcon = null;
            this.TxtAddressCus.Location = new System.Drawing.Point(19, 199);
            this.TxtAddressCus.MaxLength = 50;
            this.TxtAddressCus.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtAddressCus.Multiline = false;
            this.TxtAddressCus.Name = "TxtAddressCus";
            this.TxtAddressCus.Size = new System.Drawing.Size(437, 50);
            this.TxtAddressCus.TabIndex = 37;
            this.TxtAddressCus.Text = "";
            this.TxtAddressCus.TrailingIcon = ((System.Drawing.Image)(resources.GetObject("TxtAddressCus.TrailingIcon")));
            // 
            // TxtPhoneCus
            // 
            this.TxtPhoneCus.AnimateReadOnly = false;
            this.TxtPhoneCus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPhoneCus.Depth = 0;
            this.TxtPhoneCus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtPhoneCus.Hint = "Phone Number";
            this.TxtPhoneCus.LeadingIcon = null;
            this.TxtPhoneCus.Location = new System.Drawing.Point(19, 111);
            this.TxtPhoneCus.MaxLength = 50;
            this.TxtPhoneCus.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtPhoneCus.Multiline = false;
            this.TxtPhoneCus.Name = "TxtPhoneCus";
            this.TxtPhoneCus.Size = new System.Drawing.Size(437, 50);
            this.TxtPhoneCus.TabIndex = 36;
            this.TxtPhoneCus.Text = "";
            this.TxtPhoneCus.TrailingIcon = ((System.Drawing.Image)(resources.GetObject("TxtPhoneCus.TrailingIcon")));
            // 
            // TxtIdCus
            // 
            this.TxtIdCus.AccessibleName = "";
            this.TxtIdCus.AnimateReadOnly = false;
            this.TxtIdCus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.TxtIdCus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtIdCus.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TxtIdCus.Depth = 0;
            this.TxtIdCus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtIdCus.Hint = "Customer Number";
            this.TxtIdCus.LeadingIcon = null;
            this.TxtIdCus.Location = new System.Drawing.Point(19, 28);
            this.TxtIdCus.MaxLength = 50;
            this.TxtIdCus.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtIdCus.Multiline = false;
            this.TxtIdCus.Name = "TxtIdCus";
            this.TxtIdCus.Size = new System.Drawing.Size(214, 50);
            this.TxtIdCus.TabIndex = 34;
            this.TxtIdCus.Text = "";
            this.TxtIdCus.TrailingIcon = ((System.Drawing.Image)(resources.GetObject("TxtIdCus.TrailingIcon")));
            // 
            // TxtNameCus
            // 
            this.TxtNameCus.AnimateReadOnly = false;
            this.TxtNameCus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtNameCus.Depth = 0;
            this.TxtNameCus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtNameCus.Hint = "Customer Name";
            this.TxtNameCus.LeadingIcon = null;
            this.TxtNameCus.Location = new System.Drawing.Point(251, 28);
            this.TxtNameCus.MaxLength = 50;
            this.TxtNameCus.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtNameCus.Multiline = false;
            this.TxtNameCus.Name = "TxtNameCus";
            this.TxtNameCus.Size = new System.Drawing.Size(205, 50);
            this.TxtNameCus.TabIndex = 35;
            this.TxtNameCus.Text = "";
            this.TxtNameCus.TrailingIcon = ((System.Drawing.Image)(resources.GetObject("TxtNameCus.TrailingIcon")));
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(6, 67);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(155, 352);
            this.groupBox4.TabIndex = 35;
            this.groupBox4.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Location = new System.Drawing.Point(844, 0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(155, 264);
            this.groupBox5.TabIndex = 36;
            this.groupBox5.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Location = new System.Drawing.Point(1011, 67);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(155, 352);
            this.groupBox6.TabIndex = 36;
            this.groupBox6.TabStop = false;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.txtSearchCust);
            this.groupBox7.Location = new System.Drawing.Point(167, 67);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(838, 86);
            this.groupBox7.TabIndex = 37;
            this.groupBox7.TabStop = false;
            // 
            // txtSearchCust
            // 
            this.txtSearchCust.AnimateReadOnly = false;
            this.txtSearchCust.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchCust.Depth = 0;
            this.txtSearchCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearchCust.Hint = "Search for an employee";
            this.txtSearchCust.LeadingIcon = null;
            this.txtSearchCust.Location = new System.Drawing.Point(103, 25);
            this.txtSearchCust.MaxLength = 50;
            this.txtSearchCust.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSearchCust.Multiline = false;
            this.txtSearchCust.Name = "txtSearchCust";
            this.txtSearchCust.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSearchCust.Size = new System.Drawing.Size(632, 36);
            this.txtSearchCust.TabIndex = 38;
            this.txtSearchCust.Text = "";
            this.txtSearchCust.TrailingIcon = ((System.Drawing.Image)(resources.GetObject("txtSearchCust.TrailingIcon")));
            this.txtSearchCust.UseTallSize = false;
            this.txtSearchCust.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchCust_KeyPress_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox9);
            this.groupBox1.Controls.Add(this.btnDeleteAllCus);
            this.groupBox1.Controls.Add(this.btnDeleteCus);
            this.groupBox1.Controls.Add(this.btnSaveCus);
            this.groupBox1.Controls.Add(this.groupBox8);
            this.groupBox1.Controls.Add(this.btnNewCus);
            this.groupBox1.Controls.Add(this.btnAddCus);
            this.groupBox1.Location = new System.Drawing.Point(6, 425);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1159, 203);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            // 
            // btnDeleteAllCus
            // 
            this.btnDeleteAllCus.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeleteAllCus.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDeleteAllCus.Depth = 0;
            this.btnDeleteAllCus.HighEmphasis = true;
            this.btnDeleteAllCus.Icon = ((System.Drawing.Image)(resources.GetObject("btnDeleteAllCus.Icon")));
            this.btnDeleteAllCus.Location = new System.Drawing.Point(827, 36);
            this.btnDeleteAllCus.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDeleteAllCus.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDeleteAllCus.Name = "btnDeleteAllCus";
            this.btnDeleteAllCus.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDeleteAllCus.Size = new System.Drawing.Size(131, 36);
            this.btnDeleteAllCus.TabIndex = 15;
            this.btnDeleteAllCus.Text = "Delete All";
            this.btnDeleteAllCus.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDeleteAllCus.UseAccentColor = true;
            this.btnDeleteAllCus.UseVisualStyleBackColor = true;
            this.btnDeleteAllCus.Click += new System.EventHandler(this.btnDeleteAllCus_Click);
            // 
            // btnDeleteCus
            // 
            this.btnDeleteCus.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeleteCus.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDeleteCus.Depth = 0;
            this.btnDeleteCus.HighEmphasis = true;
            this.btnDeleteCus.Icon = ((System.Drawing.Image)(resources.GetObject("btnDeleteCus.Icon")));
            this.btnDeleteCus.Location = new System.Drawing.Point(655, 36);
            this.btnDeleteCus.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDeleteCus.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDeleteCus.Name = "btnDeleteCus";
            this.btnDeleteCus.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDeleteCus.Size = new System.Drawing.Size(101, 36);
            this.btnDeleteCus.TabIndex = 14;
            this.btnDeleteCus.Text = "Delete";
            this.btnDeleteCus.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDeleteCus.UseAccentColor = true;
            this.btnDeleteCus.UseVisualStyleBackColor = true;
            this.btnDeleteCus.Click += new System.EventHandler(this.btnDeleteCus_Click);
            // 
            // btnSaveCus
            // 
            this.btnSaveCus.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSaveCus.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSaveCus.Depth = 0;
            this.btnSaveCus.HighEmphasis = true;
            this.btnSaveCus.Icon = ((System.Drawing.Image)(resources.GetObject("btnSaveCus.Icon")));
            this.btnSaveCus.Location = new System.Drawing.Point(504, 36);
            this.btnSaveCus.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSaveCus.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSaveCus.Name = "btnSaveCus";
            this.btnSaveCus.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSaveCus.Size = new System.Drawing.Size(86, 36);
            this.btnSaveCus.TabIndex = 13;
            this.btnSaveCus.Text = "Save";
            this.btnSaveCus.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSaveCus.UseAccentColor = false;
            this.btnSaveCus.UseVisualStyleBackColor = true;
            this.btnSaveCus.Click += new System.EventHandler(this.btnSaveCus_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Location = new System.Drawing.Point(193, 87);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(10, 0);
            this.groupBox8.TabIndex = 16;
            this.groupBox8.TabStop = false;
            // 
            // btnNewCus
            // 
            this.btnNewCus.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNewCus.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnNewCus.Depth = 0;
            this.btnNewCus.HighEmphasis = true;
            this.btnNewCus.Icon = ((System.Drawing.Image)(resources.GetObject("btnNewCus.Icon")));
            this.btnNewCus.Location = new System.Drawing.Point(355, 36);
            this.btnNewCus.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNewCus.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNewCus.Name = "btnNewCus";
            this.btnNewCus.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnNewCus.Size = new System.Drawing.Size(81, 36);
            this.btnNewCus.TabIndex = 12;
            this.btnNewCus.Text = "New";
            this.btnNewCus.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnNewCus.UseAccentColor = false;
            this.btnNewCus.UseVisualStyleBackColor = true;
            this.btnNewCus.Click += new System.EventHandler(this.btnNewCus_Click);
            // 
            // btnAddCus
            // 
            this.btnAddCus.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddCus.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAddCus.Depth = 0;
            this.btnAddCus.HighEmphasis = true;
            this.btnAddCus.Icon = ((System.Drawing.Image)(resources.GetObject("btnAddCus.Icon")));
            this.btnAddCus.Location = new System.Drawing.Point(209, 36);
            this.btnAddCus.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddCus.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddCus.Name = "btnAddCus";
            this.btnAddCus.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAddCus.Size = new System.Drawing.Size(78, 36);
            this.btnAddCus.TabIndex = 11;
            this.btnAddCus.Text = "Add";
            this.btnAddCus.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddCus.UseAccentColor = false;
            this.btnAddCus.UseVisualStyleBackColor = true;
            this.btnAddCus.Click += new System.EventHandler(this.btnAddCus_Click);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.groupBox3);
            this.groupBox9.Location = new System.Drawing.Point(285, 103);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(570, 80);
            this.groupBox9.TabIndex = 36;
            this.groupBox9.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnFirst);
            this.groupBox3.Controls.Add(this.btnPrevious);
            this.groupBox3.Controls.Add(this.btnNext);
            this.groupBox3.Controls.Add(this.btnLast);
            this.groupBox3.Location = new System.Drawing.Point(13, 9);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(543, 63);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            // 
            // btnFirst
            // 
            this.btnFirst.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFirst.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnFirst.Depth = 0;
            this.btnFirst.HighEmphasis = true;
            this.btnFirst.Icon = ((System.Drawing.Image)(resources.GetObject("btnFirst.Icon")));
            this.btnFirst.Location = new System.Drawing.Point(7, 17);
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
            this.btnPrevious.Location = new System.Drawing.Point(137, 17);
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
            this.btnNext.Location = new System.Drawing.Point(317, 17);
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
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click_1);
            // 
            // btnLast
            // 
            this.btnLast.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLast.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLast.Depth = 0;
            this.btnLast.HighEmphasis = true;
            this.btnLast.Icon = ((System.Drawing.Image)(resources.GetObject("btnLast.Icon")));
            this.btnLast.Location = new System.Drawing.Point(451, 17);
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
            // FrmCustomerData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 634);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.Name = "FrmCustomerData";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Data";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCustomerData_FormClosing);
            this.Load += new System.EventHandler(this.FrmCustomer_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 TxtNoteCus;
        private MaterialSkin.Controls.MaterialTextBox TxtAddressCus;
        private MaterialSkin.Controls.MaterialTextBox TxtPhoneCus;
        private MaterialSkin.Controls.MaterialTextBox TxtIdCus;
        private MaterialSkin.Controls.MaterialTextBox TxtNameCus;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private MaterialSkin.Controls.MaterialTextBox txtSearchCust;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.GroupBox groupBox3;
        private MaterialSkin.Controls.MaterialButton btnFirst;
        private MaterialSkin.Controls.MaterialButton btnPrevious;
        private MaterialSkin.Controls.MaterialButton btnNext;
        private MaterialSkin.Controls.MaterialButton btnLast;
        private MaterialSkin.Controls.MaterialButton btnDeleteAllCus;
        private MaterialSkin.Controls.MaterialButton btnDeleteCus;
        private MaterialSkin.Controls.MaterialButton btnSaveCus;
        private System.Windows.Forms.GroupBox groupBox8;
        private MaterialSkin.Controls.MaterialButton btnNewCus;
        private MaterialSkin.Controls.MaterialButton btnAddCus;
    }
}