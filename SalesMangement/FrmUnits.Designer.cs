namespace SalesMangement
{
    partial class FrmUnits
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUnits));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSave = new MaterialSkin.Controls.MaterialButton();
            this.btnAdd = new MaterialSkin.Controls.MaterialButton();
            this.btnNew = new MaterialSkin.Controls.MaterialButton();
            this.btnDelete = new MaterialSkin.Controls.MaterialButton();
            this.btnDeleteAll = new MaterialSkin.Controls.MaterialButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnFirst = new MaterialSkin.Controls.MaterialButton();
            this.btnPrevious = new MaterialSkin.Controls.MaterialButton();
            this.btnNext = new MaterialSkin.Controls.MaterialButton();
            this.btnLast = new MaterialSkin.Controls.MaterialButton();
            this.lblTypesofExpenses = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.TxtIdUnit = new MaterialSkin.Controls.MaterialTextBox();
            this.TxtNameUnit = new MaterialSkin.Controls.MaterialTextBox();
            this.materialCard4 = new MaterialSkin.Controls.MaterialCard();
            this.DgvUnit = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.materialCard4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUnit)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.btnNew);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnDeleteAll);
            this.groupBox2.Location = new System.Drawing.Point(18, 170);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(621, 100);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSave.Depth = 0;
            this.btnSave.HighEmphasis = true;
            this.btnSave.Icon = ((System.Drawing.Image)(resources.GetObject("btnSave.Icon")));
            this.btnSave.Location = new System.Drawing.Point(231, 38);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSave.Size = new System.Drawing.Size(86, 36);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Save";
            this.btnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSave.UseAccentColor = false;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAdd.Depth = 0;
            this.btnAdd.HighEmphasis = true;
            this.btnAdd.Icon = ((System.Drawing.Image)(resources.GetObject("btnAdd.Icon")));
            this.btnAdd.Location = new System.Drawing.Point(20, 38);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAdd.Size = new System.Drawing.Size(78, 36);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = "Add";
            this.btnAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAdd.UseAccentColor = false;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnNew
            // 
            this.btnNew.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNew.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnNew.Depth = 0;
            this.btnNew.HighEmphasis = true;
            this.btnNew.Icon = ((System.Drawing.Image)(resources.GetObject("btnNew.Icon")));
            this.btnNew.Location = new System.Drawing.Point(125, 38);
            this.btnNew.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNew.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNew.Name = "btnNew";
            this.btnNew.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnNew.Size = new System.Drawing.Size(81, 36);
            this.btnNew.TabIndex = 22;
            this.btnNew.Text = "New";
            this.btnNew.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnNew.UseAccentColor = false;
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDelete.Depth = 0;
            this.btnDelete.HighEmphasis = true;
            this.btnDelete.Icon = ((System.Drawing.Image)(resources.GetObject("btnDelete.Icon")));
            this.btnDelete.Location = new System.Drawing.Point(342, 39);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDelete.Size = new System.Drawing.Size(101, 36);
            this.btnDelete.TabIndex = 24;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDelete.UseAccentColor = true;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeleteAll.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDeleteAll.Depth = 0;
            this.btnDeleteAll.HighEmphasis = true;
            this.btnDeleteAll.Icon = ((System.Drawing.Image)(resources.GetObject("btnDeleteAll.Icon")));
            this.btnDeleteAll.Location = new System.Drawing.Point(471, 39);
            this.btnDeleteAll.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDeleteAll.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDeleteAll.Size = new System.Drawing.Size(131, 36);
            this.btnDeleteAll.TabIndex = 25;
            this.btnDeleteAll.Text = "Delete All";
            this.btnDeleteAll.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDeleteAll.UseAccentColor = true;
            this.btnDeleteAll.UseVisualStyleBackColor = true;
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnFirst);
            this.groupBox3.Controls.Add(this.btnPrevious);
            this.groupBox3.Controls.Add(this.btnNext);
            this.groupBox3.Controls.Add(this.btnLast);
            this.groupBox3.Location = new System.Drawing.Point(18, 280);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(621, 63);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            // 
            // btnFirst
            // 
            this.btnFirst.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFirst.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnFirst.Depth = 0;
            this.btnFirst.HighEmphasis = true;
            this.btnFirst.Icon = ((System.Drawing.Image)(resources.GetObject("btnFirst.Icon")));
            this.btnFirst.Location = new System.Drawing.Point(44, 17);
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
            this.btnPrevious.Location = new System.Drawing.Point(174, 17);
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
            this.btnNext.Location = new System.Drawing.Point(354, 17);
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
            this.btnLast.Location = new System.Drawing.Point(488, 17);
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
            // lblTypesofExpenses
            // 
            this.lblTypesofExpenses.AutoSize = true;
            this.lblTypesofExpenses.Depth = 0;
            this.lblTypesofExpenses.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTypesofExpenses.Location = new System.Drawing.Point(22, 38);
            this.lblTypesofExpenses.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTypesofExpenses.Name = "lblTypesofExpenses";
            this.lblTypesofExpenses.Size = new System.Drawing.Size(67, 19);
            this.lblTypesofExpenses.TabIndex = 31;
            this.lblTypesofExpenses.Text = "Unit Data";
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.TxtIdUnit);
            this.materialCard1.Controls.Add(this.TxtNameUnit);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(18, 66);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(621, 100);
            this.materialCard1.TabIndex = 30;
            // 
            // TxtIdUnit
            // 
            this.TxtIdUnit.AccessibleName = "";
            this.TxtIdUnit.AnimateReadOnly = false;
            this.TxtIdUnit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.TxtIdUnit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtIdUnit.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TxtIdUnit.Depth = 0;
            this.TxtIdUnit.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtIdUnit.Hint = "Unit Number";
            this.TxtIdUnit.LeadingIcon = null;
            this.TxtIdUnit.Location = new System.Drawing.Point(33, 26);
            this.TxtIdUnit.MaxLength = 50;
            this.TxtIdUnit.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtIdUnit.Multiline = false;
            this.TxtIdUnit.Name = "TxtIdUnit";
            this.TxtIdUnit.Size = new System.Drawing.Size(267, 50);
            this.TxtIdUnit.TabIndex = 18;
            this.TxtIdUnit.Text = "";
            this.TxtIdUnit.TrailingIcon = null;
            // 
            // TxtNameUnit
            // 
            this.TxtNameUnit.AnimateReadOnly = false;
            this.TxtNameUnit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtNameUnit.Depth = 0;
            this.TxtNameUnit.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtNameUnit.Hint = "Unit Name";
            this.TxtNameUnit.LeadingIcon = null;
            this.TxtNameUnit.Location = new System.Drawing.Point(323, 26);
            this.TxtNameUnit.MaxLength = 50;
            this.TxtNameUnit.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtNameUnit.Multiline = false;
            this.TxtNameUnit.Name = "TxtNameUnit";
            this.TxtNameUnit.Size = new System.Drawing.Size(267, 50);
            this.TxtNameUnit.TabIndex = 19;
            this.TxtNameUnit.Text = "";
            this.TxtNameUnit.TrailingIcon = null;
            // 
            // materialCard4
            // 
            this.materialCard4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard4.Controls.Add(this.DgvUnit);
            this.materialCard4.Depth = 0;
            this.materialCard4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard4.Location = new System.Drawing.Point(18, 354);
            this.materialCard4.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard4.Name = "materialCard4";
            this.materialCard4.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard4.Size = new System.Drawing.Size(621, 235);
            this.materialCard4.TabIndex = 37;
            // 
            // DgvUnit
            // 
            this.DgvUnit.AllowUserToAddRows = false;
            this.DgvUnit.AllowUserToDeleteRows = false;
            this.DgvUnit.AllowUserToResizeColumns = false;
            this.DgvUnit.AllowUserToResizeRows = false;
            this.DgvUnit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvUnit.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvUnit.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.DgvUnit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvUnit.ColumnHeadersHeight = 29;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(158)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvUnit.DefaultCellStyle = dataGridViewCellStyle1;
            this.DgvUnit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvUnit.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DgvUnit.Location = new System.Drawing.Point(14, 14);
            this.DgvUnit.Name = "DgvUnit";
            this.DgvUnit.ReadOnly = true;
            this.DgvUnit.RowHeadersWidth = 51;
            this.DgvUnit.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DgvUnit.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.DgvUnit.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(158)))), ((int)(((byte)(128)))));
            this.DgvUnit.RowTemplate.Height = 24;
            this.DgvUnit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvUnit.Size = new System.Drawing.Size(593, 207);
            this.DgvUnit.TabIndex = 0;
            this.DgvUnit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DgvUnit_MouseClick);
            // 
            // FrmUnits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 598);
            this.Controls.Add(this.materialCard4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lblTypesofExpenses);
            this.Controls.Add(this.materialCard1);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmUnits";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmUnits";
            this.Load += new System.EventHandler(this.FrmUnits_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.materialCard1.ResumeLayout(false);
            this.materialCard4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvUnit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialButton btnSave;
        private MaterialSkin.Controls.MaterialButton btnAdd;
        private MaterialSkin.Controls.MaterialButton btnNew;
        private MaterialSkin.Controls.MaterialButton btnDelete;
        private MaterialSkin.Controls.MaterialButton btnDeleteAll;
        private System.Windows.Forms.GroupBox groupBox3;
        private MaterialSkin.Controls.MaterialButton btnFirst;
        private MaterialSkin.Controls.MaterialButton btnPrevious;
        private MaterialSkin.Controls.MaterialButton btnNext;
        private MaterialSkin.Controls.MaterialButton btnLast;
        private MaterialSkin.Controls.MaterialLabel lblTypesofExpenses;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialTextBox TxtIdUnit;
        private MaterialSkin.Controls.MaterialTextBox TxtNameUnit;
        private MaterialSkin.Controls.MaterialCard materialCard4;
        private System.Windows.Forms.DataGridView DgvUnit;
    }
}