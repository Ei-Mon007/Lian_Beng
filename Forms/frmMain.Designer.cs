namespace Accpac_Interface
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openLogFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToARInvoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToARReceiptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.importToARCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToARShipToLocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoLoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emailSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emailListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.directoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otherSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fTPSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.downloadFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(413, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openLogFolderToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openLogFolderToolStripMenuItem
            // 
            this.openLogFolderToolStripMenuItem.Name = "openLogFolderToolStripMenuItem";
            this.openLogFolderToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.openLogFolderToolStripMenuItem.Text = "&Open Log Folder";
            this.openLogFolderToolStripMenuItem.Click += new System.EventHandler(this.openLogFolderToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(150, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importToARInvoiceToolStripMenuItem,
            this.importToARReceiptToolStripMenuItem,
            this.toolStripMenuItem2,
            this.importToARCustomerToolStripMenuItem,
            this.importToARShipToLocationToolStripMenuItem,
            this.toolStripMenuItem3,
            this.downloadFilesToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.toolsToolStripMenuItem.Text = "&Functions";
            // 
            // importToARInvoiceToolStripMenuItem
            // 
            this.importToARInvoiceToolStripMenuItem.Name = "importToARInvoiceToolStripMenuItem";
            this.importToARInvoiceToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.importToARInvoiceToolStripMenuItem.Text = "Import to AR Invoice";
            this.importToARInvoiceToolStripMenuItem.Click += new System.EventHandler(this.importToARInvoiceToolStripMenuItem_Click);
            // 
            // importToARReceiptToolStripMenuItem
            // 
            this.importToARReceiptToolStripMenuItem.Name = "importToARReceiptToolStripMenuItem";
            this.importToARReceiptToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.importToARReceiptToolStripMenuItem.Text = "Import to AR Receipt";
            this.importToARReceiptToolStripMenuItem.Click += new System.EventHandler(this.importToARReceiptToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(215, 6);
            // 
            // importToARCustomerToolStripMenuItem
            // 
            this.importToARCustomerToolStripMenuItem.Name = "importToARCustomerToolStripMenuItem";
            this.importToARCustomerToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.importToARCustomerToolStripMenuItem.Text = "Import to AR Customer";
            this.importToARCustomerToolStripMenuItem.Click += new System.EventHandler(this.importToARCustomerToolStripMenuItem_Click);
            // 
            // importToARShipToLocationToolStripMenuItem
            // 
            this.importToARShipToLocationToolStripMenuItem.Name = "importToARShipToLocationToolStripMenuItem";
            this.importToARShipToLocationToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.importToARShipToLocationToolStripMenuItem.Text = "Import to AR Ship-To Location";
            this.importToARShipToLocationToolStripMenuItem.Click += new System.EventHandler(this.importToARShipToLocationToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autoLoginToolStripMenuItem,
            this.emailSettingsToolStripMenuItem,
            this.emailListToolStripMenuItem,
            this.fTPSettingsToolStripMenuItem,
            this.directoriesToolStripMenuItem,
            this.otherSettingsToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.settingsToolStripMenuItem.Text = "&Settings";
            // 
            // autoLoginToolStripMenuItem
            // 
            this.autoLoginToolStripMenuItem.Name = "autoLoginToolStripMenuItem";
            this.autoLoginToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.autoLoginToolStripMenuItem.Text = "Auto-&Login";
            this.autoLoginToolStripMenuItem.Click += new System.EventHandler(this.autoLoginToolStripMenuItem_Click);
            // 
            // emailSettingsToolStripMenuItem
            // 
            this.emailSettingsToolStripMenuItem.Name = "emailSettingsToolStripMenuItem";
            this.emailSettingsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.emailSettingsToolStripMenuItem.Text = "&Email Settings";
            this.emailSettingsToolStripMenuItem.Click += new System.EventHandler(this.emailSettingsToolStripMenuItem_Click);
            // 
            // emailListToolStripMenuItem
            // 
            this.emailListToolStripMenuItem.Name = "emailListToolStripMenuItem";
            this.emailListToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.emailListToolStripMenuItem.Text = "E&mail List";
            this.emailListToolStripMenuItem.Click += new System.EventHandler(this.emailListToolStripMenuItem_Click);
            // 
            // directoriesToolStripMenuItem
            // 
            this.directoriesToolStripMenuItem.Name = "directoriesToolStripMenuItem";
            this.directoriesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.directoriesToolStripMenuItem.Text = "&Directories";
            this.directoriesToolStripMenuItem.Click += new System.EventHandler(this.directoriesToolStripMenuItem_Click);
            // 
            // otherSettingsToolStripMenuItem
            // 
            this.otherSettingsToolStripMenuItem.Name = "otherSettingsToolStripMenuItem";
            this.otherSettingsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.otherSettingsToolStripMenuItem.Text = "Other &Settings";
            this.otherSettingsToolStripMenuItem.Click += new System.EventHandler(this.otherSettingsToolStripMenuItem_Click);
            // 
            // fTPSettingsToolStripMenuItem
            // 
            this.fTPSettingsToolStripMenuItem.Name = "fTPSettingsToolStripMenuItem";
            this.fTPSettingsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.fTPSettingsToolStripMenuItem.Text = "&FTP Settings";
            this.fTPSettingsToolStripMenuItem.Click += new System.EventHandler(this.FTPSettingsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(215, 6);
            // 
            // downloadFilesToolStripMenuItem
            // 
            this.downloadFilesToolStripMenuItem.Name = "downloadFilesToolStripMenuItem";
            this.downloadFilesToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.downloadFilesToolStripMenuItem.Text = "Download Files";
            this.downloadFilesToolStripMenuItem.Click += new System.EventHandler(this.downloadFilesToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 302);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openLogFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem autoLoginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otherSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emailSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToARCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToARInvoiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToARReceiptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emailListToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem importToARShipToLocationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem directoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fTPSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem downloadFilesToolStripMenuItem;
    }
}

