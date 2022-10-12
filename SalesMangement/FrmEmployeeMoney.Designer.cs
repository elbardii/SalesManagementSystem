namespace SalesMangement
{
    partial class FrmEmployeeMoney
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmployeeMoney));
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.NumQuantity = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.Date = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new MaterialSkin.Controls.MaterialLabel();
            this.cbxChooseEmployee = new MaterialSkin.Controls.MaterialComboBox();
            this.cbxChooseProduct = new MaterialSkin.Controls.MaterialComboBox();
            this.TxtOperationNumber = new MaterialSkin.Controls.MaterialTextBox();
            this.txtSearchBarcode = new MaterialSkin.Controls.MaterialTextBox();
            this.btnSave = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(568, 67);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(598, 561);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 18;
            this.pictureBox9.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.materialLabel1);
            this.groupBox1.Controls.Add(this.NumQuantity);
            this.groupBox1.Controls.Add(this.Date);
            this.groupBox1.Controls.Add(this.lblDate);
            this.groupBox1.Controls.Add(this.cbxChooseEmployee);
            this.groupBox1.Controls.Add(this.cbxChooseProduct);
            this.groupBox1.Controls.Add(this.TxtOperationNumber);
            this.groupBox1.Location = new System.Drawing.Point(6, 255);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(556, 178);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(11, 129);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(69, 19);
            this.materialLabel1.TabIndex = 41;
            this.materialLabel1.Text = "Quantity :";
            // 
            // NumQuantity
            // 
            this.NumQuantity.DecimalPlaces = 2;
            this.NumQuantity.Location = new System.Drawing.Point(86, 126);
            this.NumQuantity.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.NumQuantity.Name = "NumQuantity";
            this.NumQuantity.Size = new System.Drawing.Size(149, 26);
            this.NumQuantity.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.NumQuantity.TabIndex = 40;
            this.NumQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Date
            // 
            this.Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Date.Location = new System.Drawing.Point(86, 89);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(149, 22);
            this.Date.TabIndex = 39;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Depth = 0;
            this.lblDate.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblDate.Location = new System.Drawing.Point(11, 91);
            this.lblDate.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(42, 19);
            this.lblDate.TabIndex = 38;
            this.lblDate.Text = "Date :";
            // 
            // cbxChooseEmployee
            // 
            this.cbxChooseEmployee.AutoResize = false;
            this.cbxChooseEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbxChooseEmployee.Depth = 0;
            this.cbxChooseEmployee.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbxChooseEmployee.DropDownHeight = 174;
            this.cbxChooseEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxChooseEmployee.DropDownWidth = 121;
            this.cbxChooseEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbxChooseEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbxChooseEmployee.FormattingEnabled = true;
            this.cbxChooseEmployee.Hint = "Choose an Employee";
            this.cbxChooseEmployee.IntegralHeight = false;
            this.cbxChooseEmployee.ItemHeight = 43;
            this.cbxChooseEmployee.Location = new System.Drawing.Point(306, 103);
            this.cbxChooseEmployee.MaxDropDownItems = 4;
            this.cbxChooseEmployee.MouseState = MaterialSkin.MouseState.OUT;
            this.cbxChooseEmployee.Name = "cbxChooseEmployee";
            this.cbxChooseEmployee.Size = new System.Drawing.Size(229, 49);
            this.cbxChooseEmployee.StartIndex = 0;
            this.cbxChooseEmployee.TabIndex = 37;
            // 
            // cbxChooseProduct
            // 
            this.cbxChooseProduct.AutoResize = false;
            this.cbxChooseProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbxChooseProduct.Depth = 0;
            this.cbxChooseProduct.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbxChooseProduct.DropDownHeight = 174;
            this.cbxChooseProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxChooseProduct.DropDownWidth = 121;
            this.cbxChooseProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbxChooseProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbxChooseProduct.FormattingEnabled = true;
            this.cbxChooseProduct.Hint = "Choose a Product";
            this.cbxChooseProduct.IntegralHeight = false;
            this.cbxChooseProduct.ItemHeight = 43;
            this.cbxChooseProduct.Location = new System.Drawing.Point(306, 21);
            this.cbxChooseProduct.MaxDropDownItems = 4;
            this.cbxChooseProduct.MouseState = MaterialSkin.MouseState.OUT;
            this.cbxChooseProduct.Name = "cbxChooseProduct";
            this.cbxChooseProduct.Size = new System.Drawing.Size(229, 49);
            this.cbxChooseProduct.StartIndex = 0;
            this.cbxChooseProduct.TabIndex = 36;
            // 
            // TxtOperationNumber
            // 
            this.TxtOperationNumber.AccessibleName = "";
            this.TxtOperationNumber.AnimateReadOnly = false;
            this.TxtOperationNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.TxtOperationNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtOperationNumber.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TxtOperationNumber.Depth = 0;
            this.TxtOperationNumber.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtOperationNumber.Hint = "Operation Number";
            this.TxtOperationNumber.LeadingIcon = null;
            this.TxtOperationNumber.Location = new System.Drawing.Point(6, 21);
            this.TxtOperationNumber.MaxLength = 50;
            this.TxtOperationNumber.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtOperationNumber.Multiline = false;
            this.TxtOperationNumber.Name = "TxtOperationNumber";
            this.TxtOperationNumber.Size = new System.Drawing.Size(229, 50);
            this.TxtOperationNumber.TabIndex = 35;
            this.TxtOperationNumber.Text = "";
            this.TxtOperationNumber.TrailingIcon = ((System.Drawing.Image)(resources.GetObject("TxtOperationNumber.TrailingIcon")));
            // 
            // txtSearchBarcode
            // 
            this.txtSearchBarcode.AnimateReadOnly = false;
            this.txtSearchBarcode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchBarcode.Depth = 0;
            this.txtSearchBarcode.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearchBarcode.Hint = "Search by barcode";
            this.txtSearchBarcode.LeadingIcon = null;
            this.txtSearchBarcode.Location = new System.Drawing.Point(50, 159);
            this.txtSearchBarcode.MaxLength = 50;
            this.txtSearchBarcode.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSearchBarcode.Multiline = false;
            this.txtSearchBarcode.Name = "txtSearchBarcode";
            this.txtSearchBarcode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSearchBarcode.Size = new System.Drawing.Size(461, 36);
            this.txtSearchBarcode.TabIndex = 38;
            this.txtSearchBarcode.Text = "";
            this.txtSearchBarcode.TrailingIcon = ((System.Drawing.Image)(resources.GetObject("txtSearchBarcode.TrailingIcon")));
            this.txtSearchBarcode.UseTallSize = false;
            this.txtSearchBarcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchBarcode_KeyPress);
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = false;
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSave.Depth = 0;
            this.btnSave.HighEmphasis = true;
            this.btnSave.Icon = null;
            this.btnSave.Location = new System.Drawing.Point(6, 500);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSave.Size = new System.Drawing.Size(556, 36);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Save";
            this.btnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSave.UseAccentColor = false;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FrmEmployeeMoney
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 634);
            this.Controls.Add(this.txtSearchBarcode);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox9);
            this.MaximizeBox = false;
            this.Name = "FrmEmployeeMoney";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Withdrawals (Products)";
            this.Load += new System.EventHandler(this.FrmEmployeeMoney_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialTextBox TxtOperationNumber;
        private MaterialSkin.Controls.MaterialComboBox cbxChooseEmployee;
        private MaterialSkin.Controls.MaterialComboBox cbxChooseProduct;
        private System.Windows.Forms.DateTimePicker Date;
        private MaterialSkin.Controls.MaterialLabel lblDate;
        private ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown NumQuantity;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox txtSearchBarcode;
        private MaterialSkin.Controls.MaterialButton btnSave;
    }
}