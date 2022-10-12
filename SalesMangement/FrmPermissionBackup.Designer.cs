namespace SalesMangement
{
    partial class FrmPermissionBackup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPermissionBackup));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new MaterialSkin.Controls.MaterialButton();
            this.btnSaveUser = new MaterialSkin.Controls.MaterialButton();
            this.cbxChooseUsername = new MaterialSkin.Controls.MaterialComboBox();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.CheckboxRestoreBackups = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCard24 = new MaterialSkin.Controls.MaterialCard();
            this.CheckboxTakeBackup = new MaterialSkin.Controls.MaterialCheckbox();
            this.groupBox4.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.materialCard24.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnCancel);
            this.groupBox4.Controls.Add(this.btnSaveUser);
            this.groupBox4.Controls.Add(this.cbxChooseUsername);
            this.groupBox4.Controls.Add(this.materialCard1);
            this.groupBox4.Controls.Add(this.materialCard24);
            this.groupBox4.Location = new System.Drawing.Point(9, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(533, 222);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = false;
            this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCancel.Depth = 0;
            this.btnCancel.HighEmphasis = true;
            this.btnCancel.Icon = ((System.Drawing.Image)(resources.GetObject("btnCancel.Icon")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnCancel.Location = new System.Drawing.Point(369, 154);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCancel.Size = new System.Drawing.Size(147, 41);
            this.btnCancel.TabIndex = 55;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnCancel.UseAccentColor = false;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSaveUser
            // 
            this.btnSaveUser.AutoSize = false;
            this.btnSaveUser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSaveUser.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSaveUser.Depth = 0;
            this.btnSaveUser.HighEmphasis = true;
            this.btnSaveUser.Icon = ((System.Drawing.Image)(resources.GetObject("btnSaveUser.Icon")));
            this.btnSaveUser.Location = new System.Drawing.Point(7, 154);
            this.btnSaveUser.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSaveUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSaveUser.Name = "btnSaveUser";
            this.btnSaveUser.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSaveUser.Size = new System.Drawing.Size(354, 41);
            this.btnSaveUser.TabIndex = 54;
            this.btnSaveUser.Text = "Save user data";
            this.btnSaveUser.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSaveUser.UseAccentColor = false;
            this.btnSaveUser.UseVisualStyleBackColor = true;
            this.btnSaveUser.Click += new System.EventHandler(this.btnSaveUser_Click);
            // 
            // cbxChooseUsername
            // 
            this.cbxChooseUsername.AutoResize = false;
            this.cbxChooseUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbxChooseUsername.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cbxChooseUsername.Depth = 0;
            this.cbxChooseUsername.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbxChooseUsername.DropDownHeight = 174;
            this.cbxChooseUsername.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxChooseUsername.DropDownWidth = 121;
            this.cbxChooseUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbxChooseUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbxChooseUsername.FormattingEnabled = true;
            this.cbxChooseUsername.Hint = "Choose a Username";
            this.cbxChooseUsername.IntegralHeight = false;
            this.cbxChooseUsername.ItemHeight = 43;
            this.cbxChooseUsername.Location = new System.Drawing.Point(7, 26);
            this.cbxChooseUsername.MaxDropDownItems = 4;
            this.cbxChooseUsername.MouseState = MaterialSkin.MouseState.OUT;
            this.cbxChooseUsername.Name = "cbxChooseUsername";
            this.cbxChooseUsername.Size = new System.Drawing.Size(249, 49);
            this.cbxChooseUsername.StartIndex = 0;
            this.cbxChooseUsername.TabIndex = 53;
            this.cbxChooseUsername.SelectionChangeCommitted += new System.EventHandler(this.cbxChooseUsername_SelectionChangeCommitted);
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.CheckboxRestoreBackups);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(267, 94);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(249, 41);
            this.materialCard1.TabIndex = 23;
            // 
            // CheckboxRestoreBackups
            // 
            this.CheckboxRestoreBackups.AutoSize = true;
            this.CheckboxRestoreBackups.Depth = 0;
            this.CheckboxRestoreBackups.Location = new System.Drawing.Point(3, 1);
            this.CheckboxRestoreBackups.Margin = new System.Windows.Forms.Padding(0);
            this.CheckboxRestoreBackups.MouseLocation = new System.Drawing.Point(-1, -1);
            this.CheckboxRestoreBackups.MouseState = MaterialSkin.MouseState.HOVER;
            this.CheckboxRestoreBackups.Name = "CheckboxRestoreBackups";
            this.CheckboxRestoreBackups.ReadOnly = false;
            this.CheckboxRestoreBackups.Ripple = true;
            this.CheckboxRestoreBackups.Size = new System.Drawing.Size(153, 37);
            this.CheckboxRestoreBackups.TabIndex = 56;
            this.CheckboxRestoreBackups.Text = "Restore Backups";
            this.CheckboxRestoreBackups.UseVisualStyleBackColor = true;
            // 
            // materialCard24
            // 
            this.materialCard24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard24.Controls.Add(this.CheckboxTakeBackup);
            this.materialCard24.Depth = 0;
            this.materialCard24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard24.Location = new System.Drawing.Point(7, 94);
            this.materialCard24.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard24.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard24.Name = "materialCard24";
            this.materialCard24.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard24.Size = new System.Drawing.Size(249, 41);
            this.materialCard24.TabIndex = 22;
            // 
            // CheckboxTakeBackup
            // 
            this.CheckboxTakeBackup.AutoSize = true;
            this.CheckboxTakeBackup.Depth = 0;
            this.CheckboxTakeBackup.Location = new System.Drawing.Point(3, 2);
            this.CheckboxTakeBackup.Margin = new System.Windows.Forms.Padding(0);
            this.CheckboxTakeBackup.MouseLocation = new System.Drawing.Point(-1, -1);
            this.CheckboxTakeBackup.MouseState = MaterialSkin.MouseState.HOVER;
            this.CheckboxTakeBackup.Name = "CheckboxTakeBackup";
            this.CheckboxTakeBackup.ReadOnly = false;
            this.CheckboxTakeBackup.Ripple = true;
            this.CheckboxTakeBackup.Size = new System.Drawing.Size(140, 37);
            this.CheckboxTakeBackup.TabIndex = 0;
            this.CheckboxTakeBackup.Text = "Take a Backup";
            this.CheckboxTakeBackup.UseVisualStyleBackColor = true;
            // 
            // FrmPermissionBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 238);
            this.Controls.Add(this.groupBox4);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.StatusAndActionBar_None;
            this.Name = "FrmPermissionBackup";
            this.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmPermissionBackup";
            this.Load += new System.EventHandler(this.FrmPermissionBackup_Load);
            this.groupBox4.ResumeLayout(false);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.materialCard24.ResumeLayout(false);
            this.materialCard24.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private MaterialSkin.Controls.MaterialButton btnCancel;
        private MaterialSkin.Controls.MaterialButton btnSaveUser;
        private MaterialSkin.Controls.MaterialComboBox cbxChooseUsername;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialCheckbox CheckboxRestoreBackups;
        private MaterialSkin.Controls.MaterialCard materialCard24;
        private MaterialSkin.Controls.MaterialCheckbox CheckboxTakeBackup;
    }
}