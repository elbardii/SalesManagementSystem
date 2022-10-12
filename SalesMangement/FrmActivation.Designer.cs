namespace SalesMangement
{
    partial class FrmActivation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmActivation));
            this.txtActivationNumber = new MaterialSkin.Controls.MaterialTextBox();
            this.btnCancel = new MaterialSkin.Controls.MaterialButton();
            this.btnActivation = new MaterialSkin.Controls.MaterialButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtActivationNumber
            // 
            this.txtActivationNumber.AnimateReadOnly = false;
            this.txtActivationNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtActivationNumber.Depth = 0;
            this.txtActivationNumber.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtActivationNumber.Hint = "Activation Number";
            this.txtActivationNumber.LeadingIcon = ((System.Drawing.Image)(resources.GetObject("txtActivationNumber.LeadingIcon")));
            this.txtActivationNumber.Location = new System.Drawing.Point(7, 90);
            this.txtActivationNumber.MaxLength = 50;
            this.txtActivationNumber.MouseState = MaterialSkin.MouseState.OUT;
            this.txtActivationNumber.Multiline = false;
            this.txtActivationNumber.Name = "txtActivationNumber";
            this.txtActivationNumber.Size = new System.Drawing.Size(316, 50);
            this.txtActivationNumber.TabIndex = 3;
            this.txtActivationNumber.Text = "";
            this.txtActivationNumber.TrailingIcon = null;
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = false;
            this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCancel.Depth = 0;
            this.btnCancel.HighEmphasis = true;
            this.btnCancel.Icon = ((System.Drawing.Image)(resources.GetObject("btnCancel.Icon")));
            this.btnCancel.Location = new System.Drawing.Point(7, 149);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCancel.Size = new System.Drawing.Size(99, 36);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnCancel.UseAccentColor = false;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnActivation
            // 
            this.btnActivation.AutoSize = false;
            this.btnActivation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnActivation.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnActivation.Depth = 0;
            this.btnActivation.HighEmphasis = true;
            this.btnActivation.Icon = ((System.Drawing.Image)(resources.GetObject("btnActivation.Icon")));
            this.btnActivation.Location = new System.Drawing.Point(109, 149);
            this.btnActivation.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnActivation.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActivation.Name = "btnActivation";
            this.btnActivation.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnActivation.Size = new System.Drawing.Size(214, 36);
            this.btnActivation.TabIndex = 18;
            this.btnActivation.Text = "activation";
            this.btnActivation.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnActivation.UseAccentColor = false;
            this.btnActivation.UseVisualStyleBackColor = true;
            this.btnActivation.Click += new System.EventHandler(this.btnActivation_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.materialLabel1);
            this.groupBox1.Location = new System.Drawing.Point(7, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 81);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(49, 35);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(205, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Please Activate The Program";
            // 
            // FrmActivation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 194);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnActivation);
            this.Controls.Add(this.txtActivationNumber);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.StatusAndActionBar_None;
            this.Name = "FrmActivation";
            this.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmActivation";
            this.Load += new System.EventHandler(this.FrmActivation_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialTextBox txtActivationNumber;
        private MaterialSkin.Controls.MaterialButton btnCancel;
        private MaterialSkin.Controls.MaterialButton btnActivation;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}