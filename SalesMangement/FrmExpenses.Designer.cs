
namespace SalesMangement
{
    partial class FrmExpenses
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmExpenses));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TabControlExpenses = new MaterialSkin.Controls.MaterialTabControl();
            this.tabTypesExpenses = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSaveExpT = new MaterialSkin.Controls.MaterialButton();
            this.btnAddExpT = new MaterialSkin.Controls.MaterialButton();
            this.btnNewExpT = new MaterialSkin.Controls.MaterialButton();
            this.btnDeleteExpT = new MaterialSkin.Controls.MaterialButton();
            this.btnDeleteAllExpT = new MaterialSkin.Controls.MaterialButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnFirstExpT = new MaterialSkin.Controls.MaterialButton();
            this.btnPreviousExpT = new MaterialSkin.Controls.MaterialButton();
            this.btnNextExpT = new MaterialSkin.Controls.MaterialButton();
            this.btnLastExpT = new MaterialSkin.Controls.MaterialButton();
            this.lblTypesofExpenses = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.TxtIdExpT = new MaterialSkin.Controls.MaterialTextBox();
            this.TxtNameExpT = new MaterialSkin.Controls.MaterialTextBox();
            this.tabExpenses = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.NumPriceExpM = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.DateTimeExpM = new System.Windows.Forms.DateTimePicker();
            this.TxtIdExpM = new MaterialSkin.Controls.MaterialTextBox();
            this.TxtNoteExpM = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.label1 = new System.Windows.Forms.Label();
            this.CbxNamTypeM = new MaterialSkin.Controls.MaterialComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFirstExpM = new MaterialSkin.Controls.MaterialButton();
            this.btnPreviousExpM = new MaterialSkin.Controls.MaterialButton();
            this.btnNextExpM = new MaterialSkin.Controls.MaterialButton();
            this.btnLastExpM = new MaterialSkin.Controls.MaterialButton();
            this.btnDeleteAllExpM = new MaterialSkin.Controls.MaterialButton();
            this.btnDeleteExpM = new MaterialSkin.Controls.MaterialButton();
            this.btnSaveExpM = new MaterialSkin.Controls.MaterialButton();
            this.btnNewExpM = new MaterialSkin.Controls.MaterialButton();
            this.btnAddExpM = new MaterialSkin.Controls.MaterialButton();
            this.tabExpensesReports = new System.Windows.Forms.TabPage();
            this.btnDeleteExpR = new MaterialSkin.Controls.MaterialButton();
            this.LblTotal = new MaterialSkin.Controls.MaterialLabel();
            this.txtTotalExpR = new System.Windows.Forms.TextBox();
            this.LblTitleExpR = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.DgvExpR = new System.Windows.Forms.DataGridView();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.DateToExpR = new System.Windows.Forms.DateTimePicker();
            this.lblTo = new MaterialSkin.Controls.MaterialLabel();
            this.DateFromExpR = new System.Windows.Forms.DateTimePicker();
            this.lblFrom = new MaterialSkin.Controls.MaterialLabel();
            this.btnSearchExpR = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.iconsExpenses = new System.Windows.Forms.ImageList(this.components);
            this.TabSelectorExpenses = new MaterialSkin.Controls.MaterialTabSelector();
            this.TabControlExpenses.SuspendLayout();
            this.tabTypesExpenses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.tabExpenses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabExpensesReports.SuspendLayout();
            this.materialCard3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvExpR)).BeginInit();
            this.materialCard2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControlExpenses
            // 
            this.TabControlExpenses.Controls.Add(this.tabTypesExpenses);
            this.TabControlExpenses.Controls.Add(this.tabExpenses);
            this.TabControlExpenses.Controls.Add(this.tabExpensesReports);
            this.TabControlExpenses.Depth = 0;
            this.TabControlExpenses.ImageList = this.iconsExpenses;
            this.TabControlExpenses.Location = new System.Drawing.Point(3, 85);
            this.TabControlExpenses.MouseState = MaterialSkin.MouseState.HOVER;
            this.TabControlExpenses.Multiline = true;
            this.TabControlExpenses.Name = "TabControlExpenses";
            this.TabControlExpenses.SelectedIndex = 0;
            this.TabControlExpenses.Size = new System.Drawing.Size(1163, 543);
            this.TabControlExpenses.TabIndex = 0;
            // 
            // tabTypesExpenses
            // 
            this.tabTypesExpenses.Controls.Add(this.pictureBox1);
            this.tabTypesExpenses.Controls.Add(this.groupBox2);
            this.tabTypesExpenses.Controls.Add(this.groupBox3);
            this.tabTypesExpenses.Controls.Add(this.lblTypesofExpenses);
            this.tabTypesExpenses.Controls.Add(this.materialCard1);
            this.tabTypesExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.tabTypesExpenses.ImageKey = "(none)";
            this.tabTypesExpenses.Location = new System.Drawing.Point(4, 39);
            this.tabTypesExpenses.Name = "tabTypesExpenses";
            this.tabTypesExpenses.Padding = new System.Windows.Forms.Padding(3);
            this.tabTypesExpenses.Size = new System.Drawing.Size(1155, 500);
            this.tabTypesExpenses.TabIndex = 0;
            this.tabTypesExpenses.Text = "types of Expenses";
            this.tabTypesExpenses.UseVisualStyleBackColor = true;
            this.tabTypesExpenses.Click += new System.EventHandler(this.tabTypesExpenses_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(660, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(499, 517);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSaveExpT);
            this.groupBox2.Controls.Add(this.btnAddExpT);
            this.groupBox2.Controls.Add(this.btnNewExpT);
            this.groupBox2.Controls.Add(this.btnDeleteExpT);
            this.groupBox2.Controls.Add(this.btnDeleteAllExpT);
            this.groupBox2.Location = new System.Drawing.Point(33, 232);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(621, 100);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            // 
            // btnSaveExpT
            // 
            this.btnSaveExpT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSaveExpT.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSaveExpT.Depth = 0;
            this.btnSaveExpT.HighEmphasis = true;
            this.btnSaveExpT.Icon = ((System.Drawing.Image)(resources.GetObject("btnSaveExpT.Icon")));
            this.btnSaveExpT.Location = new System.Drawing.Point(231, 38);
            this.btnSaveExpT.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSaveExpT.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSaveExpT.Name = "btnSaveExpT";
            this.btnSaveExpT.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSaveExpT.Size = new System.Drawing.Size(86, 36);
            this.btnSaveExpT.TabIndex = 23;
            this.btnSaveExpT.Text = "Save";
            this.btnSaveExpT.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSaveExpT.UseAccentColor = false;
            this.btnSaveExpT.UseVisualStyleBackColor = true;
            this.btnSaveExpT.Click += new System.EventHandler(this.btnSaveExpT_Click);
            // 
            // btnAddExpT
            // 
            this.btnAddExpT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddExpT.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAddExpT.Depth = 0;
            this.btnAddExpT.HighEmphasis = true;
            this.btnAddExpT.Icon = ((System.Drawing.Image)(resources.GetObject("btnAddExpT.Icon")));
            this.btnAddExpT.Location = new System.Drawing.Point(20, 38);
            this.btnAddExpT.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddExpT.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddExpT.Name = "btnAddExpT";
            this.btnAddExpT.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAddExpT.Size = new System.Drawing.Size(78, 36);
            this.btnAddExpT.TabIndex = 21;
            this.btnAddExpT.Text = "Add";
            this.btnAddExpT.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddExpT.UseAccentColor = false;
            this.btnAddExpT.UseVisualStyleBackColor = true;
            this.btnAddExpT.Click += new System.EventHandler(this.btnAddExpT_Click);
            // 
            // btnNewExpT
            // 
            this.btnNewExpT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNewExpT.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnNewExpT.Depth = 0;
            this.btnNewExpT.HighEmphasis = true;
            this.btnNewExpT.Icon = ((System.Drawing.Image)(resources.GetObject("btnNewExpT.Icon")));
            this.btnNewExpT.Location = new System.Drawing.Point(125, 38);
            this.btnNewExpT.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNewExpT.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNewExpT.Name = "btnNewExpT";
            this.btnNewExpT.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnNewExpT.Size = new System.Drawing.Size(81, 36);
            this.btnNewExpT.TabIndex = 22;
            this.btnNewExpT.Text = "New";
            this.btnNewExpT.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnNewExpT.UseAccentColor = false;
            this.btnNewExpT.UseVisualStyleBackColor = true;
            this.btnNewExpT.Click += new System.EventHandler(this.btnNewExpT_Click);
            // 
            // btnDeleteExpT
            // 
            this.btnDeleteExpT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeleteExpT.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDeleteExpT.Depth = 0;
            this.btnDeleteExpT.HighEmphasis = true;
            this.btnDeleteExpT.Icon = ((System.Drawing.Image)(resources.GetObject("btnDeleteExpT.Icon")));
            this.btnDeleteExpT.Location = new System.Drawing.Point(342, 39);
            this.btnDeleteExpT.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDeleteExpT.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDeleteExpT.Name = "btnDeleteExpT";
            this.btnDeleteExpT.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDeleteExpT.Size = new System.Drawing.Size(101, 36);
            this.btnDeleteExpT.TabIndex = 24;
            this.btnDeleteExpT.Text = "Delete";
            this.btnDeleteExpT.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDeleteExpT.UseAccentColor = true;
            this.btnDeleteExpT.UseVisualStyleBackColor = true;
            this.btnDeleteExpT.Click += new System.EventHandler(this.btnDeleteExpT_Click);
            // 
            // btnDeleteAllExpT
            // 
            this.btnDeleteAllExpT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeleteAllExpT.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDeleteAllExpT.Depth = 0;
            this.btnDeleteAllExpT.HighEmphasis = true;
            this.btnDeleteAllExpT.Icon = ((System.Drawing.Image)(resources.GetObject("btnDeleteAllExpT.Icon")));
            this.btnDeleteAllExpT.Location = new System.Drawing.Point(471, 39);
            this.btnDeleteAllExpT.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDeleteAllExpT.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDeleteAllExpT.Name = "btnDeleteAllExpT";
            this.btnDeleteAllExpT.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDeleteAllExpT.Size = new System.Drawing.Size(131, 36);
            this.btnDeleteAllExpT.TabIndex = 25;
            this.btnDeleteAllExpT.Text = "Delete All";
            this.btnDeleteAllExpT.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDeleteAllExpT.UseAccentColor = true;
            this.btnDeleteAllExpT.UseVisualStyleBackColor = true;
            this.btnDeleteAllExpT.Click += new System.EventHandler(this.btnDeleteAllExpT_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnFirstExpT);
            this.groupBox3.Controls.Add(this.btnPreviousExpT);
            this.groupBox3.Controls.Add(this.btnNextExpT);
            this.groupBox3.Controls.Add(this.btnLastExpT);
            this.groupBox3.Location = new System.Drawing.Point(63, 369);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(554, 63);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            // 
            // btnFirstExpT
            // 
            this.btnFirstExpT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFirstExpT.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnFirstExpT.Depth = 0;
            this.btnFirstExpT.HighEmphasis = true;
            this.btnFirstExpT.Icon = ((System.Drawing.Image)(resources.GetObject("btnFirstExpT.Icon")));
            this.btnFirstExpT.Location = new System.Drawing.Point(12, 17);
            this.btnFirstExpT.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnFirstExpT.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnFirstExpT.Name = "btnFirstExpT";
            this.btnFirstExpT.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnFirstExpT.Size = new System.Drawing.Size(89, 36);
            this.btnFirstExpT.TabIndex = 4;
            this.btnFirstExpT.Text = "First";
            this.btnFirstExpT.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnFirstExpT.UseAccentColor = false;
            this.btnFirstExpT.UseVisualStyleBackColor = true;
            this.btnFirstExpT.Click += new System.EventHandler(this.btnFirstExpT_Click);
            // 
            // btnPreviousExpT
            // 
            this.btnPreviousExpT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPreviousExpT.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnPreviousExpT.Depth = 0;
            this.btnPreviousExpT.HighEmphasis = true;
            this.btnPreviousExpT.Icon = ((System.Drawing.Image)(resources.GetObject("btnPreviousExpT.Icon")));
            this.btnPreviousExpT.Location = new System.Drawing.Point(142, 17);
            this.btnPreviousExpT.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPreviousExpT.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPreviousExpT.Name = "btnPreviousExpT";
            this.btnPreviousExpT.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnPreviousExpT.Size = new System.Drawing.Size(119, 36);
            this.btnPreviousExpT.TabIndex = 3;
            this.btnPreviousExpT.Text = "Previous";
            this.btnPreviousExpT.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnPreviousExpT.UseAccentColor = false;
            this.btnPreviousExpT.UseVisualStyleBackColor = true;
            this.btnPreviousExpT.Click += new System.EventHandler(this.btnPreviousExpT_Click);
            // 
            // btnNextExpT
            // 
            this.btnNextExpT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNextExpT.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnNextExpT.Depth = 0;
            this.btnNextExpT.HighEmphasis = true;
            this.btnNextExpT.Icon = ((System.Drawing.Image)(resources.GetObject("btnNextExpT.Icon")));
            this.btnNextExpT.Location = new System.Drawing.Point(322, 17);
            this.btnNextExpT.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNextExpT.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNextExpT.Name = "btnNextExpT";
            this.btnNextExpT.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnNextExpT.Size = new System.Drawing.Size(86, 36);
            this.btnNextExpT.TabIndex = 2;
            this.btnNextExpT.Text = "Next";
            this.btnNextExpT.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnNextExpT.UseAccentColor = false;
            this.btnNextExpT.UseVisualStyleBackColor = true;
            this.btnNextExpT.Click += new System.EventHandler(this.btnNextExpT_Click);
            // 
            // btnLastExpT
            // 
            this.btnLastExpT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLastExpT.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLastExpT.Depth = 0;
            this.btnLastExpT.HighEmphasis = true;
            this.btnLastExpT.Icon = ((System.Drawing.Image)(resources.GetObject("btnLastExpT.Icon")));
            this.btnLastExpT.Location = new System.Drawing.Point(456, 17);
            this.btnLastExpT.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLastExpT.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLastExpT.Name = "btnLastExpT";
            this.btnLastExpT.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLastExpT.Size = new System.Drawing.Size(85, 36);
            this.btnLastExpT.TabIndex = 1;
            this.btnLastExpT.Text = "Last";
            this.btnLastExpT.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnLastExpT.UseAccentColor = false;
            this.btnLastExpT.UseVisualStyleBackColor = true;
            this.btnLastExpT.Click += new System.EventHandler(this.btnLastExpT_Click);
            // 
            // lblTypesofExpenses
            // 
            this.lblTypesofExpenses.AutoSize = true;
            this.lblTypesofExpenses.Depth = 0;
            this.lblTypesofExpenses.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTypesofExpenses.Location = new System.Drawing.Point(37, 55);
            this.lblTypesofExpenses.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTypesofExpenses.Name = "lblTypesofExpenses";
            this.lblTypesofExpenses.Size = new System.Drawing.Size(134, 19);
            this.lblTypesofExpenses.TabIndex = 27;
            this.lblTypesofExpenses.Text = "Types of Expenses";
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.TxtIdExpT);
            this.materialCard1.Controls.Add(this.TxtNameExpT);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(33, 83);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(621, 100);
            this.materialCard1.TabIndex = 26;
            // 
            // TxtIdExpT
            // 
            this.TxtIdExpT.AccessibleName = "";
            this.TxtIdExpT.AnimateReadOnly = false;
            this.TxtIdExpT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.TxtIdExpT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtIdExpT.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TxtIdExpT.Depth = 0;
            this.TxtIdExpT.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtIdExpT.Hint = "Type Number";
            this.TxtIdExpT.LeadingIcon = null;
            this.TxtIdExpT.Location = new System.Drawing.Point(33, 26);
            this.TxtIdExpT.MaxLength = 50;
            this.TxtIdExpT.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtIdExpT.Multiline = false;
            this.TxtIdExpT.Name = "TxtIdExpT";
            this.TxtIdExpT.Size = new System.Drawing.Size(267, 50);
            this.TxtIdExpT.TabIndex = 18;
            this.TxtIdExpT.Text = "";
            this.TxtIdExpT.TrailingIcon = null;
            this.TxtIdExpT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtIdExpT_KeyPress);
            // 
            // TxtNameExpT
            // 
            this.TxtNameExpT.AnimateReadOnly = false;
            this.TxtNameExpT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtNameExpT.Depth = 0;
            this.TxtNameExpT.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtNameExpT.Hint = "Expenses Name";
            this.TxtNameExpT.LeadingIcon = null;
            this.TxtNameExpT.Location = new System.Drawing.Point(323, 26);
            this.TxtNameExpT.MaxLength = 50;
            this.TxtNameExpT.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtNameExpT.Multiline = false;
            this.TxtNameExpT.Name = "TxtNameExpT";
            this.TxtNameExpT.Size = new System.Drawing.Size(267, 50);
            this.TxtNameExpT.TabIndex = 19;
            this.TxtNameExpT.Text = "";
            this.TxtNameExpT.TrailingIcon = null;
            // 
            // tabExpenses
            // 
            this.tabExpenses.Controls.Add(this.pictureBox2);
            this.tabExpenses.Controls.Add(this.groupBox4);
            this.tabExpenses.Controls.Add(this.groupBox1);
            this.tabExpenses.Controls.Add(this.btnDeleteAllExpM);
            this.tabExpenses.Controls.Add(this.btnDeleteExpM);
            this.tabExpenses.Controls.Add(this.btnSaveExpM);
            this.tabExpenses.Controls.Add(this.btnNewExpM);
            this.tabExpenses.Controls.Add(this.btnAddExpM);
            this.tabExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabExpenses.ImageKey = "(none)";
            this.tabExpenses.Location = new System.Drawing.Point(4, 39);
            this.tabExpenses.Name = "tabExpenses";
            this.tabExpenses.Padding = new System.Windows.Forms.Padding(3);
            this.tabExpenses.Size = new System.Drawing.Size(1155, 500);
            this.tabExpenses.TabIndex = 1;
            this.tabExpenses.Text = "Expense Management";
            this.tabExpenses.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(552, -19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(629, 552);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 54;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.NumPriceExpM);
            this.groupBox4.Controls.Add(this.DateTimeExpM);
            this.groupBox4.Controls.Add(this.TxtIdExpM);
            this.groupBox4.Controls.Add(this.TxtNoteExpM);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.CbxNamTypeM);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Location = new System.Drawing.Point(17, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(529, 241);
            this.groupBox4.TabIndex = 53;
            this.groupBox4.TabStop = false;
            // 
            // NumPriceExpM
            // 
            this.NumPriceExpM.DecimalPlaces = 2;
            this.NumPriceExpM.Location = new System.Drawing.Point(22, 194);
            this.NumPriceExpM.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.NumPriceExpM.Name = "NumPriceExpM";
            this.NumPriceExpM.Size = new System.Drawing.Size(222, 26);
            this.NumPriceExpM.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.NumPriceExpM.TabIndex = 18;
            this.NumPriceExpM.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // DateTimeExpM
            // 
            this.DateTimeExpM.CalendarFont = new System.Drawing.Font("Tahoma", 9F);
            this.DateTimeExpM.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.DateTimeExpM.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.DateTimeExpM.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.DateTimeExpM.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.DateTimeExpM.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.DateTimeExpM.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.DateTimeExpM.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimeExpM.Location = new System.Drawing.Point(23, 119);
            this.DateTimeExpM.Name = "DateTimeExpM";
            this.DateTimeExpM.Size = new System.Drawing.Size(222, 26);
            this.DateTimeExpM.TabIndex = 52;
            // 
            // TxtIdExpM
            // 
            this.TxtIdExpM.AccessibleName = "";
            this.TxtIdExpM.AnimateReadOnly = false;
            this.TxtIdExpM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.TxtIdExpM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtIdExpM.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TxtIdExpM.Depth = 0;
            this.TxtIdExpM.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtIdExpM.Hint = "Expense Number";
            this.TxtIdExpM.LeadingIcon = null;
            this.TxtIdExpM.Location = new System.Drawing.Point(31, 28);
            this.TxtIdExpM.MaxLength = 50;
            this.TxtIdExpM.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtIdExpM.Multiline = false;
            this.TxtIdExpM.Name = "TxtIdExpM";
            this.TxtIdExpM.Size = new System.Drawing.Size(214, 50);
            this.TxtIdExpM.TabIndex = 10;
            this.TxtIdExpM.Text = "";
            this.TxtIdExpM.TrailingIcon = null;
            this.TxtIdExpM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtIdExpM_KeyPress);
            // 
            // TxtNoteExpM
            // 
            this.TxtNoteExpM.AnimateReadOnly = false;
            this.TxtNoteExpM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TxtNoteExpM.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TxtNoteExpM.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtNoteExpM.Depth = 0;
            this.TxtNoteExpM.HideSelection = true;
            this.TxtNoteExpM.Hint = "Notes Expenses";
            this.TxtNoteExpM.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TxtNoteExpM.Location = new System.Drawing.Point(279, 102);
            this.TxtNoteExpM.MaxLength = 32767;
            this.TxtNoteExpM.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtNoteExpM.Name = "TxtNoteExpM";
            this.TxtNoteExpM.PasswordChar = '\0';
            this.TxtNoteExpM.ReadOnly = false;
            this.TxtNoteExpM.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtNoteExpM.SelectedText = "";
            this.TxtNoteExpM.SelectionLength = 0;
            this.TxtNoteExpM.SelectionStart = 0;
            this.TxtNoteExpM.ShortcutsEnabled = true;
            this.TxtNoteExpM.Size = new System.Drawing.Size(214, 118);
            this.TxtNoteExpM.TabIndex = 32;
            this.TxtNoteExpM.TabStop = false;
            this.TxtNoteExpM.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtNoteExpM.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Date :";
            // 
            // CbxNamTypeM
            // 
            this.CbxNamTypeM.AutoResize = false;
            this.CbxNamTypeM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CbxNamTypeM.Depth = 0;
            this.CbxNamTypeM.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.CbxNamTypeM.DropDownHeight = 174;
            this.CbxNamTypeM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxNamTypeM.DropDownWidth = 121;
            this.CbxNamTypeM.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.CbxNamTypeM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CbxNamTypeM.Hint = "Types Expenses   ";
            this.CbxNamTypeM.IntegralHeight = false;
            this.CbxNamTypeM.ItemHeight = 43;
            this.CbxNamTypeM.Location = new System.Drawing.Point(278, 30);
            this.CbxNamTypeM.MaxDropDownItems = 4;
            this.CbxNamTypeM.MouseState = MaterialSkin.MouseState.OUT;
            this.CbxNamTypeM.Name = "CbxNamTypeM";
            this.CbxNamTypeM.Size = new System.Drawing.Size(214, 49);
            this.CbxNamTypeM.StartIndex = 0;
            this.CbxNamTypeM.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Amount :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFirstExpM);
            this.groupBox1.Controls.Add(this.btnPreviousExpM);
            this.groupBox1.Controls.Add(this.btnNextExpM);
            this.groupBox1.Controls.Add(this.btnLastExpM);
            this.groupBox1.Location = new System.Drawing.Point(17, 352);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(529, 63);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            // 
            // btnFirstExpM
            // 
            this.btnFirstExpM.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFirstExpM.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnFirstExpM.Depth = 0;
            this.btnFirstExpM.HighEmphasis = true;
            this.btnFirstExpM.Icon = ((System.Drawing.Image)(resources.GetObject("btnFirstExpM.Icon")));
            this.btnFirstExpM.Location = new System.Drawing.Point(17, 17);
            this.btnFirstExpM.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnFirstExpM.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnFirstExpM.Name = "btnFirstExpM";
            this.btnFirstExpM.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnFirstExpM.Size = new System.Drawing.Size(89, 36);
            this.btnFirstExpM.TabIndex = 4;
            this.btnFirstExpM.Text = "First";
            this.btnFirstExpM.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnFirstExpM.UseAccentColor = false;
            this.btnFirstExpM.UseVisualStyleBackColor = true;
            this.btnFirstExpM.Click += new System.EventHandler(this.btnFirstExpM_Click);
            // 
            // btnPreviousExpM
            // 
            this.btnPreviousExpM.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPreviousExpM.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnPreviousExpM.Depth = 0;
            this.btnPreviousExpM.HighEmphasis = true;
            this.btnPreviousExpM.Icon = ((System.Drawing.Image)(resources.GetObject("btnPreviousExpM.Icon")));
            this.btnPreviousExpM.Location = new System.Drawing.Point(134, 17);
            this.btnPreviousExpM.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPreviousExpM.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPreviousExpM.Name = "btnPreviousExpM";
            this.btnPreviousExpM.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnPreviousExpM.Size = new System.Drawing.Size(119, 36);
            this.btnPreviousExpM.TabIndex = 3;
            this.btnPreviousExpM.Text = "Previous";
            this.btnPreviousExpM.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnPreviousExpM.UseAccentColor = false;
            this.btnPreviousExpM.UseVisualStyleBackColor = true;
            this.btnPreviousExpM.Click += new System.EventHandler(this.btnPreviousExpM_Click);
            // 
            // btnNextExpM
            // 
            this.btnNextExpM.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNextExpM.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnNextExpM.Depth = 0;
            this.btnNextExpM.HighEmphasis = true;
            this.btnNextExpM.Icon = ((System.Drawing.Image)(resources.GetObject("btnNextExpM.Icon")));
            this.btnNextExpM.Location = new System.Drawing.Point(291, 17);
            this.btnNextExpM.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNextExpM.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNextExpM.Name = "btnNextExpM";
            this.btnNextExpM.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnNextExpM.Size = new System.Drawing.Size(86, 36);
            this.btnNextExpM.TabIndex = 2;
            this.btnNextExpM.Text = "Next";
            this.btnNextExpM.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnNextExpM.UseAccentColor = false;
            this.btnNextExpM.UseVisualStyleBackColor = true;
            this.btnNextExpM.Click += new System.EventHandler(this.btnNextExpM_Click);
            // 
            // btnLastExpM
            // 
            this.btnLastExpM.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLastExpM.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLastExpM.Depth = 0;
            this.btnLastExpM.HighEmphasis = true;
            this.btnLastExpM.Icon = ((System.Drawing.Image)(resources.GetObject("btnLastExpM.Icon")));
            this.btnLastExpM.Location = new System.Drawing.Point(423, 17);
            this.btnLastExpM.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLastExpM.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLastExpM.Name = "btnLastExpM";
            this.btnLastExpM.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLastExpM.Size = new System.Drawing.Size(85, 36);
            this.btnLastExpM.TabIndex = 1;
            this.btnLastExpM.Text = "Last";
            this.btnLastExpM.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnLastExpM.UseAccentColor = false;
            this.btnLastExpM.UseVisualStyleBackColor = true;
            this.btnLastExpM.Click += new System.EventHandler(this.btnLastExpM_Click);
            // 
            // btnDeleteAllExpM
            // 
            this.btnDeleteAllExpM.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeleteAllExpM.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDeleteAllExpM.Depth = 0;
            this.btnDeleteAllExpM.HighEmphasis = true;
            this.btnDeleteAllExpM.Icon = ((System.Drawing.Image)(resources.GetObject("btnDeleteAllExpM.Icon")));
            this.btnDeleteAllExpM.Location = new System.Drawing.Point(415, 283);
            this.btnDeleteAllExpM.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDeleteAllExpM.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDeleteAllExpM.Name = "btnDeleteAllExpM";
            this.btnDeleteAllExpM.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDeleteAllExpM.Size = new System.Drawing.Size(131, 36);
            this.btnDeleteAllExpM.TabIndex = 30;
            this.btnDeleteAllExpM.Text = "Delete All";
            this.btnDeleteAllExpM.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDeleteAllExpM.UseAccentColor = true;
            this.btnDeleteAllExpM.UseVisualStyleBackColor = true;
            this.btnDeleteAllExpM.Click += new System.EventHandler(this.btnDeleteAllExpM_Click);
            // 
            // btnDeleteExpM
            // 
            this.btnDeleteExpM.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeleteExpM.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDeleteExpM.Depth = 0;
            this.btnDeleteExpM.HighEmphasis = true;
            this.btnDeleteExpM.Icon = ((System.Drawing.Image)(resources.GetObject("btnDeleteExpM.Icon")));
            this.btnDeleteExpM.Location = new System.Drawing.Point(301, 283);
            this.btnDeleteExpM.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDeleteExpM.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDeleteExpM.Name = "btnDeleteExpM";
            this.btnDeleteExpM.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDeleteExpM.Size = new System.Drawing.Size(101, 36);
            this.btnDeleteExpM.TabIndex = 29;
            this.btnDeleteExpM.Text = "Delete";
            this.btnDeleteExpM.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDeleteExpM.UseAccentColor = true;
            this.btnDeleteExpM.UseVisualStyleBackColor = true;
            this.btnDeleteExpM.Click += new System.EventHandler(this.btnDeleteExpM_Click);
            // 
            // btnSaveExpM
            // 
            this.btnSaveExpM.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSaveExpM.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSaveExpM.Depth = 0;
            this.btnSaveExpM.HighEmphasis = true;
            this.btnSaveExpM.Icon = ((System.Drawing.Image)(resources.GetObject("btnSaveExpM.Icon")));
            this.btnSaveExpM.Location = new System.Drawing.Point(204, 283);
            this.btnSaveExpM.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSaveExpM.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSaveExpM.Name = "btnSaveExpM";
            this.btnSaveExpM.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSaveExpM.Size = new System.Drawing.Size(86, 36);
            this.btnSaveExpM.TabIndex = 28;
            this.btnSaveExpM.Text = "Save";
            this.btnSaveExpM.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSaveExpM.UseAccentColor = false;
            this.btnSaveExpM.UseVisualStyleBackColor = true;
            this.btnSaveExpM.Click += new System.EventHandler(this.btnSaveExpM_Click);
            // 
            // btnNewExpM
            // 
            this.btnNewExpM.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNewExpM.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnNewExpM.Depth = 0;
            this.btnNewExpM.HighEmphasis = true;
            this.btnNewExpM.Icon = ((System.Drawing.Image)(resources.GetObject("btnNewExpM.Icon")));
            this.btnNewExpM.Location = new System.Drawing.Point(108, 283);
            this.btnNewExpM.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNewExpM.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNewExpM.Name = "btnNewExpM";
            this.btnNewExpM.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnNewExpM.Size = new System.Drawing.Size(81, 36);
            this.btnNewExpM.TabIndex = 27;
            this.btnNewExpM.Text = "New";
            this.btnNewExpM.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnNewExpM.UseAccentColor = false;
            this.btnNewExpM.UseVisualStyleBackColor = true;
            this.btnNewExpM.Click += new System.EventHandler(this.btnNewExpM_Click);
            // 
            // btnAddExpM
            // 
            this.btnAddExpM.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddExpM.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAddExpM.Depth = 0;
            this.btnAddExpM.HighEmphasis = true;
            this.btnAddExpM.Icon = ((System.Drawing.Image)(resources.GetObject("btnAddExpM.Icon")));
            this.btnAddExpM.Location = new System.Drawing.Point(17, 283);
            this.btnAddExpM.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddExpM.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddExpM.Name = "btnAddExpM";
            this.btnAddExpM.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAddExpM.Size = new System.Drawing.Size(78, 36);
            this.btnAddExpM.TabIndex = 26;
            this.btnAddExpM.Text = "Add";
            this.btnAddExpM.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddExpM.UseAccentColor = false;
            this.btnAddExpM.UseVisualStyleBackColor = true;
            this.btnAddExpM.Click += new System.EventHandler(this.btnAddExpM_Click);
            // 
            // tabExpensesReports
            // 
            this.tabExpensesReports.Controls.Add(this.btnDeleteExpR);
            this.tabExpensesReports.Controls.Add(this.LblTotal);
            this.tabExpensesReports.Controls.Add(this.txtTotalExpR);
            this.tabExpensesReports.Controls.Add(this.LblTitleExpR);
            this.tabExpensesReports.Controls.Add(this.materialCard3);
            this.tabExpensesReports.Controls.Add(this.materialCard2);
            this.tabExpensesReports.Controls.Add(this.btnSearchExpR);
            this.tabExpensesReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabExpensesReports.ImageKey = "(none)";
            this.tabExpensesReports.Location = new System.Drawing.Point(4, 39);
            this.tabExpensesReports.Name = "tabExpensesReports";
            this.tabExpensesReports.Size = new System.Drawing.Size(1155, 500);
            this.tabExpensesReports.TabIndex = 2;
            this.tabExpensesReports.Text = "Expenses Reports";
            // 
            // btnDeleteExpR
            // 
            this.btnDeleteExpR.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeleteExpR.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDeleteExpR.Depth = 0;
            this.btnDeleteExpR.HighEmphasis = true;
            this.btnDeleteExpR.Icon = ((System.Drawing.Image)(resources.GetObject("btnDeleteExpR.Icon")));
            this.btnDeleteExpR.Location = new System.Drawing.Point(988, 437);
            this.btnDeleteExpR.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDeleteExpR.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDeleteExpR.Name = "btnDeleteExpR";
            this.btnDeleteExpR.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDeleteExpR.Size = new System.Drawing.Size(101, 36);
            this.btnDeleteExpR.TabIndex = 33;
            this.btnDeleteExpR.Text = "Delete";
            this.btnDeleteExpR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDeleteExpR.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDeleteExpR.UseAccentColor = true;
            this.btnDeleteExpR.UseVisualStyleBackColor = true;
            this.btnDeleteExpR.Click += new System.EventHandler(this.btnDeleteExpR_Click);
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Depth = 0;
            this.LblTotal.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblTotal.Location = new System.Drawing.Point(60, 440);
            this.LblTotal.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(106, 19);
            this.LblTotal.TabIndex = 32;
            this.LblTotal.Text = "Total Amount :";
            // 
            // txtTotalExpR
            // 
            this.txtTotalExpR.Enabled = false;
            this.txtTotalExpR.Location = new System.Drawing.Point(172, 438);
            this.txtTotalExpR.Name = "txtTotalExpR";
            this.txtTotalExpR.ReadOnly = true;
            this.txtTotalExpR.Size = new System.Drawing.Size(109, 27);
            this.txtTotalExpR.TabIndex = 31;
            // 
            // LblTitleExpR
            // 
            this.LblTitleExpR.AutoSize = true;
            this.LblTitleExpR.Depth = 0;
            this.LblTitleExpR.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.LblTitleExpR.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.LblTitleExpR.Location = new System.Drawing.Point(422, 21);
            this.LblTitleExpR.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblTitleExpR.Name = "LblTitleExpR";
            this.LblTitleExpR.Size = new System.Drawing.Size(327, 29);
            this.LblTitleExpR.TabIndex = 29;
            this.LblTitleExpR.Text = "Expense Management Reports";
            // 
            // materialCard3
            // 
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.DgvExpR);
            this.materialCard3.Depth = 0;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(61, 144);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard3.Size = new System.Drawing.Size(1031, 286);
            this.materialCard3.TabIndex = 28;
            // 
            // DgvExpR
            // 
            this.DgvExpR.AllowUserToAddRows = false;
            this.DgvExpR.AllowUserToDeleteRows = false;
            this.DgvExpR.AllowUserToResizeColumns = false;
            this.DgvExpR.AllowUserToResizeRows = false;
            this.DgvExpR.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvExpR.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvExpR.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.DgvExpR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvExpR.ColumnHeadersHeight = 29;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(158)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvExpR.DefaultCellStyle = dataGridViewCellStyle1;
            this.DgvExpR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvExpR.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DgvExpR.Location = new System.Drawing.Point(14, 14);
            this.DgvExpR.Name = "DgvExpR";
            this.DgvExpR.ReadOnly = true;
            this.DgvExpR.RowHeadersWidth = 51;
            this.DgvExpR.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DgvExpR.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.DgvExpR.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(158)))), ((int)(((byte)(128)))));
            this.DgvExpR.RowTemplate.Height = 24;
            this.DgvExpR.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvExpR.Size = new System.Drawing.Size(1003, 258);
            this.DgvExpR.TabIndex = 0;
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.DateToExpR);
            this.materialCard2.Controls.Add(this.lblTo);
            this.materialCard2.Controls.Add(this.DateFromExpR);
            this.materialCard2.Controls.Add(this.lblFrom);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(196, 80);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(683, 52);
            this.materialCard2.TabIndex = 27;
            // 
            // DateToExpR
            // 
            this.DateToExpR.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateToExpR.Location = new System.Drawing.Point(443, 13);
            this.DateToExpR.Name = "DateToExpR";
            this.DateToExpR.Size = new System.Drawing.Size(176, 27);
            this.DateToExpR.TabIndex = 18;
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
            // DateFromExpR
            // 
            this.DateFromExpR.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateFromExpR.Location = new System.Drawing.Point(120, 15);
            this.DateFromExpR.Name = "DateFromExpR";
            this.DateFromExpR.Size = new System.Drawing.Size(176, 27);
            this.DateFromExpR.TabIndex = 16;
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Depth = 0;
            this.lblFrom.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblFrom.Location = new System.Drawing.Point(63, 17);
            this.lblFrom.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(46, 19);
            this.lblFrom.TabIndex = 0;
            this.lblFrom.Text = "From :";
            // 
            // btnSearchExpR
            // 
            this.btnSearchExpR.Location = new System.Drawing.Point(887, 80);
            this.btnSearchExpR.Name = "btnSearchExpR";
            this.btnSearchExpR.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnSearchExpR.Size = new System.Drawing.Size(69, 52);
            this.btnSearchExpR.StateCommon.Back.ColorAngle = 45F;
            this.btnSearchExpR.StateCommon.Border.ColorAngle = 45F;
            this.btnSearchExpR.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSearchExpR.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSearchExpR.StateCommon.Border.Rounding = 20;
            this.btnSearchExpR.StateCommon.Border.Width = 1;
            this.btnSearchExpR.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.btnSearchExpR.StateNormal.Border.ColorAngle = 45F;
            this.btnSearchExpR.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSearchExpR.StateNormal.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSearchExpR.StateNormal.Border.Rounding = 20;
            this.btnSearchExpR.StateNormal.Border.Width = 1;
            this.btnSearchExpR.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSearchExpR.StatePressed.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSearchExpR.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSearchExpR.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSearchExpR.TabIndex = 17;
            this.btnSearchExpR.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchExpR.Values.Image")));
            this.btnSearchExpR.Values.Text = "";
            this.btnSearchExpR.Click += new System.EventHandler(this.btnSearchExpR_Click);
            // 
            // iconsExpenses
            // 
            this.iconsExpenses.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconsExpenses.ImageStream")));
            this.iconsExpenses.TransparentColor = System.Drawing.Color.Transparent;
            this.iconsExpenses.Images.SetKeyName(0, "icons_Expenses Reports.ico");
            this.iconsExpenses.Images.SetKeyName(1, "icons_Expenses.ico");
            this.iconsExpenses.Images.SetKeyName(2, "icons_TypesExpenses.ico");
            // 
            // TabSelectorExpenses
            // 
            this.TabSelectorExpenses.BaseTabControl = this.TabControlExpenses;
            this.TabSelectorExpenses.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.TabSelectorExpenses.Depth = 0;
            this.TabSelectorExpenses.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TabSelectorExpenses.Location = new System.Drawing.Point(-25, 23);
            this.TabSelectorExpenses.MouseState = MaterialSkin.MouseState.HOVER;
            this.TabSelectorExpenses.Name = "TabSelectorExpenses";
            this.TabSelectorExpenses.Size = new System.Drawing.Size(1202, 48);
            this.TabSelectorExpenses.TabIndex = 1;
            this.TabSelectorExpenses.Text = "TabSelectorExpenses";
            this.TabSelectorExpenses.Click += new System.EventHandler(this.TabSelectorExpenses_Click);
            // 
            // FrmExpenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 634);
            this.Controls.Add(this.TabSelectorExpenses);
            this.Controls.Add(this.TabControlExpenses);
            this.DrawerUseColors = true;
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.MaximizeBox = false;
            this.Name = "FrmExpenses";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expenses";
            this.Load += new System.EventHandler(this.FrmExpenses_Load);
            this.TabControlExpenses.ResumeLayout(false);
            this.tabTypesExpenses.ResumeLayout(false);
            this.tabTypesExpenses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.materialCard1.ResumeLayout(false);
            this.tabExpenses.ResumeLayout(false);
            this.tabExpenses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabExpensesReports.ResumeLayout(false);
            this.tabExpensesReports.PerformLayout();
            this.materialCard3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvExpR)).EndInit();
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabTypesExpenses;
        private System.Windows.Forms.ImageList iconsExpenses;
        private MaterialSkin.Controls.MaterialTextBox TxtIdExpT;
        private MaterialSkin.Controls.MaterialTextBox TxtNameExpT;
        private MaterialSkin.Controls.MaterialLabel lblTypesofExpenses;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialButton btnDeleteAllExpT;
        private MaterialSkin.Controls.MaterialButton btnDeleteExpT;
        private MaterialSkin.Controls.MaterialButton btnSaveExpT;
        private MaterialSkin.Controls.MaterialButton btnNewExpT;
        private MaterialSkin.Controls.MaterialButton btnAddExpT;
        private System.Windows.Forms.GroupBox groupBox3;
        private MaterialSkin.Controls.MaterialButton btnFirstExpT;
        private MaterialSkin.Controls.MaterialButton btnPreviousExpT;
        private MaterialSkin.Controls.MaterialButton btnNextExpT;
        private MaterialSkin.Controls.MaterialButton btnLastExpT;
        private MaterialSkin.Controls.MaterialTabSelector TabSelectorExpenses;
        private MaterialSkin.Controls.MaterialTextBox TxtIdExpM;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialComboBox CbxNamTypeM;
        private System.Windows.Forms.Label label2;
        private ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown NumPriceExpM;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialButton btnFirstExpM;
        private MaterialSkin.Controls.MaterialButton btnPreviousExpM;
        private MaterialSkin.Controls.MaterialButton btnNextExpM;
        private MaterialSkin.Controls.MaterialButton btnLastExpM;
        private MaterialSkin.Controls.MaterialButton btnDeleteAllExpM;
        private MaterialSkin.Controls.MaterialButton btnDeleteExpM;
        private MaterialSkin.Controls.MaterialButton btnSaveExpM;
        private MaterialSkin.Controls.MaterialButton btnNewExpM;
        private MaterialSkin.Controls.MaterialButton btnAddExpM;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSearchExpR;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private System.Windows.Forms.DateTimePicker DateFromExpR;
        private MaterialSkin.Controls.MaterialLabel lblFrom;
        private System.Windows.Forms.DateTimePicker DateToExpR;
        private MaterialSkin.Controls.MaterialLabel lblTo;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private MaterialSkin.Controls.MaterialLabel LblTitleExpR;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 TxtNoteExpM;
        private MaterialSkin.Controls.MaterialLabel LblTotal;
        private System.Windows.Forms.TextBox txtTotalExpR;
        private System.Windows.Forms.DataGridView DgvExpR;
        private MaterialSkin.Controls.MaterialButton btnDeleteExpR;
        private System.Windows.Forms.DateTimePicker DateTimeExpM;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        public MaterialSkin.Controls.MaterialTabControl TabControlExpenses;
        public System.Windows.Forms.TabPage tabExpensesReports;
        public System.Windows.Forms.TabPage tabExpenses;
    }
}