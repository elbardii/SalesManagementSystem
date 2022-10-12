namespace SalesMangement
{
    partial class FrmBondReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBondReport));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DateTo = new System.Windows.Forms.DateTimePicker();
            this.lblTo = new MaterialSkin.Controls.MaterialLabel();
            this.DateFrom = new System.Windows.Forms.DateTimePicker();
            this.lblFrom = new MaterialSkin.Controls.MaterialLabel();
            this.txtTotal = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.lblTotal = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.rbtnCatchReceipt = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbtnReceipt = new MaterialSkin.Controls.MaterialRadioButton();
            this.btnSearsh = new MaterialSkin.Controls.MaterialButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DgvReport = new System.Windows.Forms.DataGridView();
            this.btnDelete = new MaterialSkin.Controls.MaterialButton();
            this.materialCard1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvReport)).BeginInit();
            this.SuspendLayout();
            // 
            // DateTo
            // 
            this.DateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTo.Location = new System.Drawing.Point(657, 21);
            this.DateTo.Name = "DateTo";
            this.DateTo.Size = new System.Drawing.Size(176, 22);
            this.DateTo.TabIndex = 60;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Depth = 0;
            this.lblTo.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTo.Location = new System.Drawing.Point(618, 23);
            this.lblTo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(28, 19);
            this.lblTo.TabIndex = 59;
            this.lblTo.Text = "To :";
            // 
            // DateFrom
            // 
            this.DateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateFrom.Location = new System.Drawing.Point(423, 22);
            this.DateFrom.Name = "DateFrom";
            this.DateFrom.Size = new System.Drawing.Size(176, 22);
            this.DateFrom.TabIndex = 58;
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Depth = 0;
            this.lblFrom.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblFrom.Location = new System.Drawing.Point(366, 24);
            this.lblFrom.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(46, 19);
            this.lblFrom.TabIndex = 57;
            this.lblFrom.Text = "From :";
            // 
            // txtTotal
            // 
            this.txtTotal.AnimateReadOnly = false;
            this.txtTotal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotal.Depth = 0;
            this.txtTotal.HideSelection = true;
            this.txtTotal.Location = new System.Drawing.Point(12, 585);
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
            this.txtTotal.TabIndex = 81;
            this.txtTotal.TabStop = false;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTotal.UseSystemPasswordChar = false;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Depth = 0;
            this.lblTotal.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTotal.Location = new System.Drawing.Point(9, 563);
            this.lblTotal.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(141, 19);
            this.lblTotal.TabIndex = 80;
            this.lblTotal.Text = "Total Sales Amount";
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.DateTo);
            this.materialCard1.Controls.Add(this.rbtnCatchReceipt);
            this.materialCard1.Controls.Add(this.lblTo);
            this.materialCard1.Controls.Add(this.rbtnReceipt);
            this.materialCard1.Controls.Add(this.DateFrom);
            this.materialCard1.Controls.Add(this.btnSearsh);
            this.materialCard1.Controls.Add(this.lblFrom);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(60, 87);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(1051, 62);
            this.materialCard1.TabIndex = 79;
            // 
            // rbtnCatchReceipt
            // 
            this.rbtnCatchReceipt.AutoSize = true;
            this.rbtnCatchReceipt.Checked = true;
            this.rbtnCatchReceipt.Depth = 0;
            this.rbtnCatchReceipt.Location = new System.Drawing.Point(52, 14);
            this.rbtnCatchReceipt.Margin = new System.Windows.Forms.Padding(0);
            this.rbtnCatchReceipt.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbtnCatchReceipt.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtnCatchReceipt.Name = "rbtnCatchReceipt";
            this.rbtnCatchReceipt.Ripple = true;
            this.rbtnCatchReceipt.Size = new System.Drawing.Size(132, 37);
            this.rbtnCatchReceipt.TabIndex = 42;
            this.rbtnCatchReceipt.TabStop = true;
            this.rbtnCatchReceipt.Text = "Catch Receipt";
            this.rbtnCatchReceipt.UseVisualStyleBackColor = true;
            // 
            // rbtnReceipt
            // 
            this.rbtnReceipt.AutoSize = true;
            this.rbtnReceipt.Depth = 0;
            this.rbtnReceipt.Location = new System.Drawing.Point(213, 14);
            this.rbtnReceipt.Margin = new System.Windows.Forms.Padding(0);
            this.rbtnReceipt.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbtnReceipt.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtnReceipt.Name = "rbtnReceipt";
            this.rbtnReceipt.Ripple = true;
            this.rbtnReceipt.Size = new System.Drawing.Size(87, 37);
            this.rbtnReceipt.TabIndex = 41;
            this.rbtnReceipt.TabStop = true;
            this.rbtnReceipt.Text = "Receipt";
            this.rbtnReceipt.UseVisualStyleBackColor = true;
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
            this.groupBox1.Controls.Add(this.DgvReport);
            this.groupBox1.Location = new System.Drawing.Point(8, 160);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1158, 390);
            this.groupBox1.TabIndex = 78;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sales report in a specified period";
            // 
            // DgvReport
            // 
            this.DgvReport.AllowUserToAddRows = false;
            this.DgvReport.AllowUserToDeleteRows = false;
            this.DgvReport.AllowUserToResizeColumns = false;
            this.DgvReport.AllowUserToResizeRows = false;
            this.DgvReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvReport.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvReport.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.DgvReport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvReport.ColumnHeadersHeight = 29;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(158)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvReport.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvReport.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DgvReport.Location = new System.Drawing.Point(3, 18);
            this.DgvReport.Name = "DgvReport";
            this.DgvReport.ReadOnly = true;
            this.DgvReport.RowHeadersWidth = 51;
            this.DgvReport.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DgvReport.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.DgvReport.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(158)))), ((int)(((byte)(128)))));
            this.DgvReport.RowTemplate.Height = 24;
            this.DgvReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvReport.Size = new System.Drawing.Size(1152, 369);
            this.DgvReport.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDelete.Depth = 0;
            this.btnDelete.HighEmphasis = true;
            this.btnDelete.Icon = ((System.Drawing.Image)(resources.GetObject("btnDelete.Icon")));
            this.btnDelete.Location = new System.Drawing.Point(1062, 575);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDelete.Size = new System.Drawing.Size(101, 36);
            this.btnDelete.TabIndex = 82;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDelete.UseAccentColor = true;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // FrmBondReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 634);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "FrmBondReport";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bond Report";
            this.Load += new System.EventHandler(this.FrmBondReport_Load);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker DateTo;
        private MaterialSkin.Controls.MaterialLabel lblTo;
        private System.Windows.Forms.DateTimePicker DateFrom;
        private MaterialSkin.Controls.MaterialLabel lblFrom;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtTotal;
        private MaterialSkin.Controls.MaterialLabel lblTotal;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialRadioButton rbtnCatchReceipt;
        private MaterialSkin.Controls.MaterialRadioButton rbtnReceipt;
        private MaterialSkin.Controls.MaterialButton btnSearsh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DgvReport;
        private MaterialSkin.Controls.MaterialButton btnDelete;
    }
}