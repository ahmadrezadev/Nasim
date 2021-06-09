
namespace NasimImageEditor.Forms
{
    sealed partial class CompressImageForm
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
            System.Windows.Forms.StatusStrip statusStrip1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompressImageForm));
            this.pbStatus = new System.Windows.Forms.ToolStripProgressBar();
            this.lblResult = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.FilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOpenOutputFiles = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LanguageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSelectPersianLanguage = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSelectEnglishLanguage = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAutoUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDonate = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCheckForUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            statusStrip1 = new System.Windows.Forms.StatusStrip();
            statusStrip1.SuspendLayout();
            this.mainMenu.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pbStatus,
            this.lblResult});
            statusStrip1.Location = new System.Drawing.Point(0, 183);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new System.Drawing.Size(386, 26);
            statusStrip1.SizingGrip = false;
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // pbStatus
            // 
            this.pbStatus.Margin = new System.Windows.Forms.Padding(10, 4, 1, 4);
            this.pbStatus.Name = "pbStatus";
            this.pbStatus.Size = new System.Drawing.Size(100, 18);
            // 
            // lblResult
            // 
            this.lblResult.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblResult.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblResult.Margin = new System.Windows.Forms.Padding(10, 4, 0, 2);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 20);
            // 
            // mainMenu
            // 
            this.mainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FilesToolStripMenuItem,
            this.SettingsToolStripMenuItem,
            this.HelpToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(386, 28);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "menuStrip1";
            // 
            // FilesToolStripMenuItem
            // 
            this.FilesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOpenOutputFiles});
            this.FilesToolStripMenuItem.Name = "FilesToolStripMenuItem";
            this.FilesToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.FilesToolStripMenuItem.Text = "فایل ها";
            // 
            // btnOpenOutputFiles
            // 
            this.btnOpenOutputFiles.Name = "btnOpenOutputFiles";
            this.btnOpenOutputFiles.Size = new System.Drawing.Size(250, 26);
            this.btnOpenOutputFiles.Text = "باز کردن محل ذخیره سازی";
            this.btnOpenOutputFiles.Click += new System.EventHandler(this.btnOpenOutputFiles_Click);
            // 
            // SettingsToolStripMenuItem
            // 
            this.SettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LanguageToolStripMenuItem,
            this.btnAutoUpdate});
            this.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem";
            this.SettingsToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.SettingsToolStripMenuItem.Text = "تنظیمات";
            // 
            // LanguageToolStripMenuItem
            // 
            this.LanguageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSelectPersianLanguage,
            this.btnSelectEnglishLanguage});
            this.LanguageToolStripMenuItem.Name = "LanguageToolStripMenuItem";
            this.LanguageToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.LanguageToolStripMenuItem.Text = "زبان ها";
            // 
            // btnSelectPersianLanguage
            // 
            this.btnSelectPersianLanguage.Checked = true;
            this.btnSelectPersianLanguage.CheckOnClick = true;
            this.btnSelectPersianLanguage.CheckState = System.Windows.Forms.CheckState.Checked;
            this.btnSelectPersianLanguage.Name = "btnSelectPersianLanguage";
            this.btnSelectPersianLanguage.Size = new System.Drawing.Size(139, 26);
            this.btnSelectPersianLanguage.Text = "فارسی";
            this.btnSelectPersianLanguage.Click += new System.EventHandler(this.btnSelectPersianLanguage_Click);
            // 
            // btnSelectEnglishLanguage
            // 
            this.btnSelectEnglishLanguage.CheckOnClick = true;
            this.btnSelectEnglishLanguage.Name = "btnSelectEnglishLanguage";
            this.btnSelectEnglishLanguage.Size = new System.Drawing.Size(139, 26);
            this.btnSelectEnglishLanguage.Text = "English";
            this.btnSelectEnglishLanguage.Click += new System.EventHandler(this.btnSelectEnglishLanguage_Click);
            // 
            // btnAutoUpdate
            // 
            this.btnAutoUpdate.Checked = true;
            this.btnAutoUpdate.CheckOnClick = true;
            this.btnAutoUpdate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.btnAutoUpdate.Name = "btnAutoUpdate";
            this.btnAutoUpdate.Size = new System.Drawing.Size(265, 26);
            this.btnAutoUpdate.Text = "بررسی خودکار بروز رسانی ها";
            this.btnAutoUpdate.Click += new System.EventHandler(this.btnAutoUpdate_Click);
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDonate,
            this.btnCheckForUpdate,
            this.btnAbout});
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.HelpToolStripMenuItem.Text = "راهنما";
            // 
            // btnDonate
            // 
            this.btnDonate.Name = "btnDonate";
            this.btnDonate.Size = new System.Drawing.Size(224, 26);
            this.btnDonate.Text = "حمایت مالی";
            this.btnDonate.Click += new System.EventHandler(this.btnDonate_Click);
            // 
            // btnCheckForUpdate
            // 
            this.btnCheckForUpdate.Name = "btnCheckForUpdate";
            this.btnCheckForUpdate.Size = new System.Drawing.Size(224, 26);
            this.btnCheckForUpdate.Text = "بررسی بروز رسانی";
            this.btnCheckForUpdate.Click += new System.EventHandler(this.btnCheckForUpdate_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(224, 26);
            this.btnAbout.Text = "درباره ما";
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.lblStatus);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 28);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(386, 181);
            this.pnlMain.TabIndex = 1;
            this.pnlMain.Click += new System.EventHandler(this.pnlMain_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStatus.Location = new System.Drawing.Point(12, 9);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(362, 133);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "تصاویر خود را بکشید و در اینجا رها کنید\r\n--------- یا ---------\r\nبرای انتخاب تصاو" +
    "یر کلیک کنید";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblStatus.Click += new System.EventHandler(this.pnlMain_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.Location = new System.Drawing.Point(315, 0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(67, 27);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "انصراف";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // CompressImageForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 209);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(statusStrip1);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.mainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CompressImageForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "فشرده ساز تصویر نسیم";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CompressImageForm_FormClosing);
            this.Load += new System.EventHandler(this.CompressImageForm_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.CompressImageForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.CompressImageForm_DragEnter);
            this.DragLeave += new System.EventHandler(this.CompressImageForm_DragLeave);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem FilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnOpenOutputFiles;
        private System.Windows.Forms.ToolStripMenuItem SettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LanguageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnSelectPersianLanguage;
        private System.Windows.Forms.ToolStripMenuItem btnSelectEnglishLanguage;
        private System.Windows.Forms.ToolStripMenuItem btnAutoUpdate;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnDonate;
        private System.Windows.Forms.ToolStripMenuItem btnCheckForUpdate;
        private System.Windows.Forms.ToolStripMenuItem btnAbout;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar pbStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ToolStripStatusLabel lblResult;
        private System.Windows.Forms.Button btnCancel;
    }
}