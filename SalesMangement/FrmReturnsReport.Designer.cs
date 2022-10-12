namespace SalesMangement
{
    partial class FrmReturnsReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReturnsReport));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DgvReturnsReport = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtnReturnsAll = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbtnRtuSales = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbtnRtuBuy = new MaterialSkin.Controls.MaterialRadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSearsh = new MaterialSkin.Controls.MaterialButton();
            this.DateToRut = new System.Windows.Forms.DateTimePicker();
            this.lblTo = new MaterialSkin.Controls.MaterialLabel();
            this.DateFromRut = new System.Windows.Forms.DateTimePicker();
            this.lblFrom = new MaterialSkin.Controls.MaterialLabel();
            this.btnDeleteAll = new MaterialSkin.Controls.MaterialButton();
            this.txtTotalAmount = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.lblTotal = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvReturnsReport)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DgvReturnsReport);
            this.groupBox1.Location = new System.Drawing.Point(60, 159);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1051, 404);
            this.groupBox1.TabIndex = 61;
            this.groupBox1.TabStop = false;
            // 
            // DgvReturnsReport
            // 
            this.DgvReturnsReport.AllowUserToAddRows = false;
            this.DgvReturnsReport.AllowUserToDeleteRows = false;
            this.DgvReturnsReport.AllowUserToResizeColumns = false;
            this.DgvReturnsReport.AllowUserToResizeRows = false;
            this.DgvReturnsReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgvReturnsReport.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvReturnsReport.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.DgvReturnsReport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvReturnsReport.ColumnHeadersHeight = 29;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(158)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvReturnsReport.DefaultCellStyle = dataGridViewCellStyle3;
            this.DgvReturnsReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvReturnsReport.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DgvReturnsReport.Location = new System.Drawing.Point(3, 18);
            this.DgvReturnsReport.Name = "DgvReturnsReport";
            this.DgvReturnsReport.ReadOnly = true;
            this.DgvReturnsReport.RowHeadersWidth = 51;
            this.DgvReturnsReport.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DgvReturnsReport.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.DgvReturnsReport.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(158)))), ((int)(((byte)(128)))));
            this.DgvReturnsReport.RowTemplate.Height = 24;
            this.DgvReturnsReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvReturnsReport.Size = new System.Drawing.Size(1045, 383);
            this.DgvReturnsReport.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtnReturnsAll);
            this.groupBox2.Controls.Add(this.rbtnRtuSales);
            this.groupBox2.Controls.Add(this.rbtnRtuBuy);
            this.groupBox2.Location = new System.Drawing.Point(63, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(502, 72);
            this.groupBox2.TabIndex = 62;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search Filters";
            // 
            // rbtnReturnsAll
            // 
            this.rbtnReturnsAll.AutoSize = true;
            this.rbtnReturnsAll.Checked = true;
            this.rbtnReturnsAll.Depth = 0;
            this.rbtnReturnsAll.Location = new System.Drawing.Point(18, 26);
            this.rbtnReturnsAll.Margin = new System.Windows.Forms.Padding(0);
            this.rbtnReturnsAll.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbtnReturnsAll.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtnReturnsAll.Name = "rbtnReturnsAll";
            this.rbtnReturnsAll.Ripple = true;
            this.rbtnReturnsAll.Size = new System.Drawing.Size(119, 37);
            this.rbtnReturnsAll.TabIndex = 45;
            this.rbtnReturnsAll.TabStop = true;
            this.rbtnReturnsAll.Text = " All Returns ";
            this.rbtnReturnsAll.UseVisualStyleBackColor = true;
            // 
            // rbtnRtuSales
            // 
            this.rbtnRtuSales.AutoSize = true;
            this.rbtnRtuSales.Depth = 0;
            this.rbtnRtuSales.Location = new System.Drawing.Point(175, 26);
            this.rbtnRtuSales.Margin = new System.Windows.Forms.Padding(0);
            this.rbtnRtuSales.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbtnRtuSales.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtnRtuSales.Name = "rbtnRtuSales";
            this.rbtnRtuSales.Ripple = true;
            this.rbtnRtuSales.Size = new System.Drawing.Size(132, 37);
            this.rbtnRtuSales.TabIndex = 44;
            this.rbtnRtuSales.TabStop = true;
            this.rbtnRtuSales.Text = "Returns Sales";
            this.rbtnRtuSales.UseVisualStyleBackColor = true;
            // 
            // rbtnRtuBuy
            // 
            this.rbtnRtuBuy.AutoSize = true;
            this.rbtnRtuBuy.Depth = 0;
            this.rbtnRtuBuy.Location = new System.Drawing.Point(336, 26);
            this.rbtnRtuBuy.Margin = new System.Windows.Forms.Padding(0);
            this.rbtnRtuBuy.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbtnRtuBuy.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtnRtuBuy.Name = "rbtnRtuBuy";
            this.rbtnRtuBuy.Ripple = true;
            this.rbtnRtuBuy.Size = new System.Drawing.Size(120, 37);
            this.rbtnRtuBuy.TabIndex = 43;
            this.rbtnRtuBuy.TabStop = true;
            this.rbtnRtuBuy.Text = "Returns Buy";
            this.rbtnRtuBuy.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSearsh);
            this.groupBox3.Controls.Add(this.DateToRut);
            this.groupBox3.Controls.Add(this.lblTo);
            this.groupBox3.Controls.Add(this.DateFromRut);
            this.groupBox3.Controls.Add(this.lblFrom);
            this.groupBox3.Location = new System.Drawing.Point(609, 71);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(502, 72);
            this.groupBox3.TabIndex = 63;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Interval Filters";
            // 
            // btnSearsh
            // 
            this.btnSearsh.AutoSize = false;
            this.btnSearsh.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSearsh.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSearsh.Depth = 0;
            this.btnSearsh.HighEmphasis = true;
            this.btnSearsh.Icon = ((System.Drawing.Image)(resources.GetObject("btnSearsh.Icon")));
            this.btnSearsh.Location = new System.Drawing.Point(387, 22);
            this.btnSearsh.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSearsh.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSearsh.Name = "btnSearsh";
            this.btnSearsh.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSearsh.Size = new System.Drawing.Size(100, 37);
            this.btnSearsh.TabIndex = 40;
            this.btnSearsh.Text = "Searsh";
            this.btnSearsh.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSearsh.UseAccentColor = false;
            this.btnSearsh.UseVisualStyleBackColor = true;
            this.btnSearsh.Click += new System.EventHandler(this.btnSearsh_Click);
            // 
            // DateToRut
            // 
            this.DateToRut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateToRut.Location = new System.Drawing.Point(248, 30);
            this.DateToRut.Name = "DateToRut";
            this.DateToRut.Size = new System.Drawing.Size(110, 22);
            this.DateToRut.TabIndex = 22;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Depth = 0;
            this.lblTo.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTo.Location = new System.Drawing.Point(209, 32);
            this.lblTo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(28, 19);
            this.lblTo.TabIndex = 21;
            this.lblTo.Text = "To :";
            // 
            // DateFromRut
            // 
            this.DateFromRut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateFromRut.Location = new System.Drawing.Point(74, 32);
            this.DateFromRut.Name = "DateFromRut";
            this.DateFromRut.Size = new System.Drawing.Size(113, 22);
            this.DateFromRut.TabIndex = 20;
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Depth = 0;
            this.lblFrom.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblFrom.Location = new System.Drawing.Point(17, 34);
            this.lblFrom.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(46, 19);
            this.lblFrom.TabIndex = 19;
            this.lblFrom.Text = "From :";
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.AutoSize = false;
            this.btnDeleteAll.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeleteAll.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDeleteAll.Depth = 0;
            this.btnDeleteAll.HighEmphasis = true;
            this.btnDeleteAll.Icon = ((System.Drawing.Image)(resources.GetObject("btnDeleteAll.Icon")));
            this.btnDeleteAll.Location = new System.Drawing.Point(60, 580);
            this.btnDeleteAll.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDeleteAll.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDeleteAll.Size = new System.Drawing.Size(148, 37);
            this.btnDeleteAll.TabIndex = 64;
            this.btnDeleteAll.Text = "Delete ";
            this.btnDeleteAll.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDeleteAll.UseAccentColor = true;
            this.btnDeleteAll.UseVisualStyleBackColor = false;
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.AnimateReadOnly = false;
            this.txtTotalAmount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtTotalAmount.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTotalAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalAmount.Depth = 0;
            this.txtTotalAmount.HideSelection = true;
            this.txtTotalAmount.Location = new System.Drawing.Point(244, 590);
            this.txtTotalAmount.MaxLength = 32767;
            this.txtTotalAmount.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.PasswordChar = '\0';
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTotalAmount.SelectedText = "";
            this.txtTotalAmount.SelectionLength = 0;
            this.txtTotalAmount.SelectionStart = 0;
            this.txtTotalAmount.ShortcutsEnabled = true;
            this.txtTotalAmount.Size = new System.Drawing.Size(126, 37);
            this.txtTotalAmount.TabIndex = 68;
            this.txtTotalAmount.TabStop = false;
            this.txtTotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTotalAmount.UseSystemPasswordChar = false;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Depth = 0;
            this.lblTotal.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTotal.Location = new System.Drawing.Point(247, 568);
            this.lblTotal.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(106, 19);
            this.lblTotal.TabIndex = 67;
            this.lblTotal.Text = "Total Amount :";
            // 
            // FrmReturnsReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 634);
            this.Controls.Add(this.txtTotalAmount);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnDeleteAll);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "FrmReturnsReport";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Returns Report";
            this.Load += new System.EventHandler(this.FrmReturnsReport_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvReturnsReport)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DgvReturnsReport;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialRadioButton rbtnReturnsAll;
        private MaterialSkin.Controls.MaterialRadioButton rbtnRtuSales;
        private MaterialSkin.Controls.MaterialRadioButton rbtnRtuBuy;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker DateToRut;
        private MaterialSkin.Controls.MaterialLabel lblTo;
        private System.Windows.Forms.DateTimePicker DateFromRut;
        private MaterialSkin.Controls.MaterialLabel lblFrom;
        private MaterialSkin.Controls.MaterialButton btnSearsh;
        private MaterialSkin.Controls.MaterialButton btnDeleteAll;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtTotalAmount;
        private MaterialSkin.Controls.MaterialLabel lblTotal;
    }
}