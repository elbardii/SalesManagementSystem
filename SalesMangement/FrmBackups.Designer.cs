namespace SalesMangement
{
    partial class FrmBackups
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBackups));
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnTakeBackup = new MaterialSkin.Controls.MaterialButton();
            this.btnRestoreBackups = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(6, 27);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(637, 266);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            // 
            // btnTakeBackup
            // 
            this.btnTakeBackup.AutoSize = false;
            this.btnTakeBackup.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTakeBackup.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnTakeBackup.Depth = 0;
            this.btnTakeBackup.HighEmphasis = true;
            this.btnTakeBackup.Icon = ((System.Drawing.Image)(resources.GetObject("btnTakeBackup.Icon")));
            this.btnTakeBackup.Location = new System.Drawing.Point(19, 142);
            this.btnTakeBackup.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnTakeBackup.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTakeBackup.Name = "btnTakeBackup";
            this.btnTakeBackup.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnTakeBackup.Size = new System.Drawing.Size(173, 41);
            this.btnTakeBackup.TabIndex = 12;
            this.btnTakeBackup.Text = "Take a backup";
            this.btnTakeBackup.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnTakeBackup.UseAccentColor = false;
            this.btnTakeBackup.UseVisualStyleBackColor = true;
            this.btnTakeBackup.Click += new System.EventHandler(this.btnTakeBackup_Click);
            // 
            // btnRestoreBackups
            // 
            this.btnRestoreBackups.AutoSize = false;
            this.btnRestoreBackups.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRestoreBackups.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRestoreBackups.Depth = 0;
            this.btnRestoreBackups.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRestoreBackups.HighEmphasis = true;
            this.btnRestoreBackups.Icon = ((System.Drawing.Image)(resources.GetObject("btnRestoreBackups.Icon")));
            this.btnRestoreBackups.Location = new System.Drawing.Point(458, 144);
            this.btnRestoreBackups.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRestoreBackups.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRestoreBackups.Name = "btnRestoreBackups";
            this.btnRestoreBackups.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRestoreBackups.Size = new System.Drawing.Size(173, 41);
            this.btnRestoreBackups.TabIndex = 13;
            this.btnRestoreBackups.Text = "Restore Backups";
            this.btnRestoreBackups.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRestoreBackups.UseAccentColor = false;
            this.btnRestoreBackups.UseVisualStyleBackColor = true;
            this.btnRestoreBackups.Click += new System.EventHandler(this.btnRestoreBackups_Click);
            // 
            // FrmBackups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 299);
            this.Controls.Add(this.btnRestoreBackups);
            this.Controls.Add(this.btnTakeBackup);
            this.Controls.Add(this.pictureBox4);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBackups";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Backups";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox4;
        private MaterialSkin.Controls.MaterialButton btnTakeBackup;
        public MaterialSkin.Controls.MaterialButton btnRestoreBackups;
    }
}