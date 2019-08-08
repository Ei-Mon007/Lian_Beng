using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Accpac_Interface
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Dispose();
            }
            catch (Exception ex)
            {
                GV.Log.Append("[ERROR] " + ex.Message);
                GV.ErrorLog.Append(ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            string sVersion = Application.ProductVersion;
            this.Text = string.Format("{0} - Accpac Interface {1}", GV.Accpac.AccpacDBID, sVersion);
            ExecuteAuthorization();
        }

        private void userPermissionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsers oUsers = new frmUsers();
            oUsers.MdiParent = this;
            oUsers.Show();
        }

        private void ExecuteAuthorization()
        {
            if (GV.Accpac.UserID == "ADMIN")
            {
                this.settingsToolStripMenuItem.Enabled = true;
            }
            else
            {
                this.settingsToolStripMenuItem.Enabled = false;
            }
        }

        private void openLogFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FileInfo oFile;
                oFile = new FileInfo(GV.Log.FullPath);
                if (oFile.Exists)
                {
                    Process.Start(oFile.DirectoryName);
                }
            }
            catch (Exception ex)
            {
                GV.Log.Append("[ERROR] " + ex.Message);
                GV.ErrorLog.Append(ex.ToString());
                MessageBox.Show(ex.Message, "Open Log Folder");
            }
        }

        private void FTPSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmFTPSetting oFTP = new frmFTPSetting();
                oFTP.MdiParent = this;
                oFTP.Show();
            }
            catch (Exception ex)
            {
                GV.Log.Append("[ERROR] " + ex.Message);
                GV.ErrorLog.Append(ex.ToString());
                MessageBox.Show(ex.Message, "FTP Settings");
            }
        }

        private void importToGLJournalToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void autoLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmAutoLogin frm = new frmAutoLogin();
                frm.MdiParent = this;
                frm.Show();
            }
            catch (Exception ex)
            {
                GV.Log.Append("[ERROR] " + ex.Message);
                GV.ErrorLog.Append(ex.ToString());
                MessageBox.Show(ex.Message, "Auto-Login");
            }
        }

        private void otherSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmOtherSettings frm = new frmOtherSettings();
                frm.MdiParent = this;
                frm.Show();
            }
            catch (Exception ex)
            {
                GV.Log.Append("[ERROR] " + ex.Message);
                GV.ErrorLog.Append(ex.ToString());
                MessageBox.Show(ex.Message, "Other Settings");
            }
        }

        private void emailSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmEmailSetting frm = new frmEmailSetting();
                frm.MdiParent = this;
                frm.Show();
            }
            catch (Exception ex)
            {
                GV.Log.Append("[ERROR] " + ex.Message);
                GV.ErrorLog.Append(ex.ToString());
                MessageBox.Show(ex.Message, "Email Settings");
            }
        }

        private void importToARCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmImportToARCustomer frm = new frmImportToARCustomer();
                frm.MdiParent = this;
                frm.Show();
            }
            catch (Exception ex)
            {
                GV.Log.Append("[ERROR] " + ex.Message);
                GV.ErrorLog.Append(ex.ToString());
                MessageBox.Show(ex.Message, "Import to AR Customer");
            }
        }

        private void emailListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmEmailList frm = new frmEmailList();
                frm.MdiParent = this;
                frm.Show();
            }
            catch (Exception ex)
            {
                GV.Log.Append("[ERROR] " + ex.Message);
                GV.ErrorLog.Append(ex.ToString());
                MessageBox.Show(ex.Message, "Email List");
            }
        }

        private void importToARShipToLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmImportToARShipToLocation frm = new frmImportToARShipToLocation();
                frm.MdiParent = this;
                frm.Show();
            }
            catch (Exception ex)
            {
                GV.Log.Append("[ERROR] " + ex.Message);
                GV.ErrorLog.Append(ex.ToString());
                MessageBox.Show(ex.Message, "Import to AR Ship-To Location");
            }
        }

        private void importToARInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmImportToARInvoice frm = new frmImportToARInvoice();
                frm.MdiParent = this;
                frm.Show();
            }
            catch (Exception ex)
            {
                GV.Log.Append("[ERROR] " + ex.Message);
                GV.ErrorLog.Append(ex.ToString());
                MessageBox.Show(ex.Message, "Import to AR Invoice");
            }
        }

        private void importToARReceiptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmImportToARReceipt frm = new frmImportToARReceipt();
                frm.MdiParent = this;
                frm.Show();
            }
            catch (Exception ex)
            {
                GV.Log.Append("[ERROR] " + ex.Message);
                GV.ErrorLog.Append(ex.ToString());
                MessageBox.Show(ex.Message, "Import to AR Receipt");
            }
        }

        private void directoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmDirectories frm = new frmDirectories();
                frm.MdiParent = this;
                frm.Show();
            }
            catch (Exception ex)
            {
                GV.Log.Append("[ERROR] " + ex.Message);
                GV.ErrorLog.Append(ex.ToString());
                MessageBox.Show(ex.Message, "Directories");
            }
        }

        private void downloadFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmDownload oDownload = new frmDownload();
                oDownload.MdiParent = this;
                oDownload.Show();
            }
            catch (Exception ex)
            {
                GV.Log.Append("[ERROR] " + ex.Message);
                GV.ErrorLog.Append(ex.ToString());
                MessageBox.Show(ex.Message, "Download Files");
            }
        }
    }
}