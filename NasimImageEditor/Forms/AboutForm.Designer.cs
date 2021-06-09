
namespace NasimImageEditor.Forms
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.pbCompanyLogo = new System.Windows.Forms.PictureBox();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.lblAboutDescription = new System.Windows.Forms.Label();
            this.lblAboutTitle = new System.Windows.Forms.Label();
            this.lblAppVersion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbCompanyLogo)).BeginInit();
            this.pnlLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbCompanyLogo
            // 
            this.pbCompanyLogo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbCompanyLogo.Image = global::NasimImageEditor.Properties.Resources.ahmadrezadev;
            this.pbCompanyLogo.Location = new System.Drawing.Point(12, 12);
            this.pbCompanyLogo.Name = "pbCompanyLogo";
            this.pbCompanyLogo.Size = new System.Drawing.Size(388, 235);
            this.pbCompanyLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCompanyLogo.TabIndex = 0;
            this.pbCompanyLogo.TabStop = false;
            this.pbCompanyLogo.Click += new System.EventHandler(this.pbCompanyLogo_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.White;
            this.pnlLogo.Controls.Add(this.pbCompanyLogo);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(412, 257);
            this.pnlLogo.TabIndex = 1;
            // 
            // lblAboutDescription
            // 
            this.lblAboutDescription.Location = new System.Drawing.Point(12, 314);
            this.lblAboutDescription.Name = "lblAboutDescription";
            this.lblAboutDescription.Size = new System.Drawing.Size(388, 134);
            this.lblAboutDescription.TabIndex = 2;
            this.lblAboutDescription.Text = "این اپلیکیشن توسط ahmadrezadev و به صورت رایگان برای کاربران طراحی و تولید شده اس" +
    "ت تا با استفاده از آن بتوانند تصاویر دلخواد خود را به ساده ترین صورت ممکن و سریع" +
    " ویرایش کنند.";
            // 
            // lblAboutTitle
            // 
            this.lblAboutTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblAboutTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAboutTitle.Location = new System.Drawing.Point(12, 275);
            this.lblAboutTitle.Name = "lblAboutTitle";
            this.lblAboutTitle.Size = new System.Drawing.Size(388, 50);
            this.lblAboutTitle.TabIndex = 3;
            this.lblAboutTitle.Text = "ویرایشگر تصویر نسیم";
            // 
            // lblAppVersion
            // 
            this.lblAppVersion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblAppVersion.Location = new System.Drawing.Point(272, 463);
            this.lblAppVersion.Name = "lblAppVersion";
            this.lblAppVersion.Size = new System.Drawing.Size(128, 25);
            this.lblAppVersion.TabIndex = 4;
            this.lblAppVersion.Text = "V-1.0.0";
            this.lblAppVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 497);
            this.Controls.Add(this.lblAboutDescription);
            this.Controls.Add(this.lblAppVersion);
            this.Controls.Add(this.lblAboutTitle);
            this.Controls.Add(this.pnlLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "درباره ما";
            this.Load += new System.EventHandler(this.AboutForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCompanyLogo)).EndInit();
            this.pnlLogo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCompanyLogo;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Label lblAboutDescription;
        private System.Windows.Forms.Label lblAboutTitle;
        private System.Windows.Forms.Label lblAppVersion;
    }
}