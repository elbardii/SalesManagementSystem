namespace SalesMangement
{
    partial class FrmPaySales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPaySales));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CheckboxCreditCard = new MaterialSkin.Controls.MaterialCheckbox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtPaidUp = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.btnSaveEdit = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtTotal = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.txtRestAmount = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.lblTotal = new MaterialSkin.Controls.MaterialLabel();
            this.btnReturn = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CheckboxCreditCard);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.txtPaidUp);
            this.groupBox1.Controls.Add(this.btnSaveEdit);
            this.groupBox1.Controls.Add(this.materialLabel2);
            this.groupBox1.Controls.Add(this.txtTotal);
            this.groupBox1.Controls.Add(this.txtRestAmount);
            this.groupBox1.Controls.Add(this.lblTotal);
            this.groupBox1.Controls.Add(this.btnReturn);
            this.groupBox1.Controls.Add(this.materialLabel1);
            this.groupBox1.Location = new System.Drawing.Point(6, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(618, 384);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // CheckboxCreditCard
            // 
            this.CheckboxCreditCard.AutoSize = true;
            this.CheckboxCreditCard.Depth = 0;
            this.CheckboxCreditCard.Location = new System.Drawing.Point(40, 335);
            this.CheckboxCreditCard.Margin = new System.Windows.Forms.Padding(0);
            this.CheckboxCreditCard.MouseLocation = new System.Drawing.Point(-1, -1);
            this.CheckboxCreditCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.CheckboxCreditCard.Name = "CheckboxCreditCard";
            this.CheckboxCreditCard.ReadOnly = false;
            this.CheckboxCreditCard.Ripple = true;
            this.CheckboxCreditCard.Size = new System.Drawing.Size(161, 37);
            this.CheckboxCreditCard.TabIndex = 21;
            this.CheckboxCreditCard.Text = "Pay by credit card";
            this.CheckboxCreditCard.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(258, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(354, 304);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // txtPaidUp
            // 
            this.txtPaidUp.AnimateReadOnly = false;
            this.txtPaidUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtPaidUp.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPaidUp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPaidUp.Depth = 0;
            this.txtPaidUp.HideSelection = true;
            this.txtPaidUp.Location = new System.Drawing.Point(14, 167);
            this.txtPaidUp.MaxLength = 32767;
            this.txtPaidUp.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPaidUp.Name = "txtPaidUp";
            this.txtPaidUp.PasswordChar = '\0';
            this.txtPaidUp.ReadOnly = false;
            this.txtPaidUp.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPaidUp.SelectedText = "";
            this.txtPaidUp.SelectionLength = 0;
            this.txtPaidUp.SelectionStart = 0;
            this.txtPaidUp.ShortcutsEnabled = true;
            this.txtPaidUp.Size = new System.Drawing.Size(238, 48);
            this.txtPaidUp.TabIndex = 19;
            this.txtPaidUp.TabStop = false;
            this.txtPaidUp.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPaidUp.UseSystemPasswordChar = false;
            this.txtPaidUp.TextChanged += new System.EventHandler(this.txtPaidUp_TextChanged);
            // 
            // btnSaveEdit
            // 
            this.btnSaveEdit.AccessibleDescription = "";
            this.btnSaveEdit.AutoSize = false;
            this.btnSaveEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSaveEdit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSaveEdit.Depth = 0;
            this.btnSaveEdit.HighEmphasis = true;
            this.btnSaveEdit.Icon = ((System.Drawing.Image)(resources.GetObject("btnSaveEdit.Icon")));
            this.btnSaveEdit.Location = new System.Drawing.Point(444, 335);
            this.btnSaveEdit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSaveEdit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSaveEdit.Name = "btnSaveEdit";
            this.btnSaveEdit.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSaveEdit.Size = new System.Drawing.Size(117, 36);
            this.btnSaveEdit.TabIndex = 11;
            this.btnSaveEdit.Text = "Save Edit";
            this.btnSaveEdit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSaveEdit.UseAccentColor = false;
            this.btnSaveEdit.UseVisualStyleBackColor = true;
            this.btnSaveEdit.Click += new System.EventHandler(this.btnSaveEdit_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(7, 230);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(183, 19);
            this.materialLabel2.TabIndex = 18;
            this.materialLabel2.Text = "The Rest Of The Amount :";
            // 
            // txtTotal
            // 
            this.txtTotal.AnimateReadOnly = false;
            this.txtTotal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotal.Depth = 0;
            this.txtTotal.Enabled = false;
            this.txtTotal.HideSelection = true;
            this.txtTotal.Location = new System.Drawing.Point(13, 51);
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
            this.txtTotal.Size = new System.Drawing.Size(238, 48);
            this.txtTotal.TabIndex = 12;
            this.txtTotal.TabStop = false;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTotal.UseSystemPasswordChar = false;
            // 
            // txtRestAmount
            // 
            this.txtRestAmount.AnimateReadOnly = false;
            this.txtRestAmount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtRestAmount.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtRestAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRestAmount.Depth = 0;
            this.txtRestAmount.Enabled = false;
            this.txtRestAmount.HideSelection = true;
            this.txtRestAmount.Location = new System.Drawing.Point(10, 277);
            this.txtRestAmount.MaxLength = 32767;
            this.txtRestAmount.MouseState = MaterialSkin.MouseState.OUT;
            this.txtRestAmount.Name = "txtRestAmount";
            this.txtRestAmount.PasswordChar = '\0';
            this.txtRestAmount.ReadOnly = true;
            this.txtRestAmount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRestAmount.SelectedText = "";
            this.txtRestAmount.SelectionLength = 0;
            this.txtRestAmount.SelectionStart = 0;
            this.txtRestAmount.ShortcutsEnabled = true;
            this.txtRestAmount.Size = new System.Drawing.Size(238, 48);
            this.txtRestAmount.TabIndex = 17;
            this.txtRestAmount.TabStop = false;
            this.txtRestAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtRestAmount.UseSystemPasswordChar = false;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Depth = 0;
            this.lblTotal.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTotal.Location = new System.Drawing.Point(7, 14);
            this.lblTotal.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(46, 19);
            this.lblTotal.TabIndex = 13;
            this.lblTotal.Text = "Total :";
            // 
            // btnReturn
            // 
            this.btnReturn.AutoSize = false;
            this.btnReturn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnReturn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnReturn.Depth = 0;
            this.btnReturn.HighEmphasis = true;
            this.btnReturn.Icon = ((System.Drawing.Image)(resources.GetObject("btnReturn.Icon")));
            this.btnReturn.Location = new System.Drawing.Point(303, 335);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnReturn.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnReturn.Size = new System.Drawing.Size(117, 36);
            this.btnReturn.TabIndex = 16;
            this.btnReturn.Text = "Return";
            this.btnReturn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnReturn.UseAccentColor = false;
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(7, 119);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(64, 19);
            this.materialLabel1.TabIndex = 15;
            this.materialLabel1.Text = "Paid Up :";
            // 
            // FrmPaySales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(630, 394);
            this.Controls.Add(this.groupBox1);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.StatusAndActionBar_None;
            this.Name = "FrmPaySales";
            this.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPaySales";
            this.Load += new System.EventHandler(this.FrmPaySales_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmPaySales_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtPaidUp;
        private MaterialSkin.Controls.MaterialButton btnSaveEdit;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtTotal;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtRestAmount;
        private MaterialSkin.Controls.MaterialLabel lblTotal;
        private MaterialSkin.Controls.MaterialButton btnReturn;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialCheckbox CheckboxCreditCard;
    }
}