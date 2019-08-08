using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Accpac_Interface
{
    public partial class frmDirectories : Form
    {
        public frmDirectories()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btnKAMSSource_Click(object sender, EventArgs e)
        {
            try
            {
                using (FolderBrowserDialog fbd = this.folderBrowserDialog1)
                {
                    fbd.SelectedPath = GV.Settings.KAMS_SourceFolder;
                    if (fbd.ShowDialog() == DialogResult.OK)
                    {
                        this.txtKAMSSourcePath.Text = fbd.SelectedPath;
                    }
                }
            }
            catch (Exception ex)
            {
                GV.Log.Append("[ERROR] " + ex.Message);
                GV.ErrorLog.Append(ex.ToString());
            }
        }

        private void frmDirectories_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = string.Format("Directories");
                bool function_CW = GV.Settings.FunctionCW;
                bool function_KAMS = GV.Settings.FunctionKAMS;
                if (function_CW && !function_KAMS)
                {
                    this.txtKAMSSourcePath.Text = "";
                    this.txtKAMSImportedPath.Text = "";
                    this.txtKAMSFailedPath.Text = "";
                    this.txtCWSourcePath.Text = GV.Settings.CW_SourceFolder;
                    this.txtCWImportedPath.Text = GV.Settings.CW_ImportedFolder;
                    this.txtCWFailedPath.Text = GV.Settings.CW_FailedFolder;
                    tabControl.TabPages.Remove(tabKAMS);
                }
                else if (function_KAMS && !function_CW)
                {
                    this.txtCWSourcePath.Text = "";
                    this.txtCWImportedPath.Text = "";
                    this.txtCWFailedPath.Text = "";
                    this.txtKAMSSourcePath.Text = GV.Settings.KAMS_SourceFolder;
                    this.txtKAMSImportedPath.Text = GV.Settings.KAMS_ImportedFolder;
                    this.txtKAMSFailedPath.Text = GV.Settings.KAMS_FailedFolder;
                    tabControl.TabPages.Remove(tabCW);
                }
                else
                {
                    this.txtKAMSSourcePath.Text = GV.Settings.KAMS_SourceFolder;
                    this.txtKAMSImportedPath.Text = GV.Settings.KAMS_ImportedFolder;
                    this.txtKAMSFailedPath.Text = GV.Settings.KAMS_FailedFolder;
                    this.txtCWSourcePath.Text = GV.Settings.CW_SourceFolder;
                    this.txtCWImportedPath.Text = GV.Settings.CW_ImportedFolder;
                    this.txtCWFailedPath.Text = GV.Settings.CW_FailedFolder;
                }

            }
            catch (Exception ex)
            {
                GV.Log.Append("[ERROR] " + ex.Message);
                GV.ErrorLog.Append(ex.ToString());
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                GV.dbCompany.Settings.SetSetting(GV.Settings.KAMS_SourceFolderField, this.txtKAMSSourcePath.Text.Trim());
                GV.dbCompany.Settings.SetSetting(GV.Settings.KAMS_ImportedFolderField, this.txtKAMSImportedPath.Text.Trim());
                GV.dbCompany.Settings.SetSetting(GV.Settings.KAMS_FailedFolderField, this.txtKAMSFailedPath.Text.Trim());
                GV.dbCompany.Settings.SetSetting(GV.Settings.CW_SourceFolderField, this.txtCWSourcePath.Text.Trim());
                GV.dbCompany.Settings.SetSetting(GV.Settings.CW_ImportedFolderField, this.txtCWImportedPath.Text.Trim());
                GV.dbCompany.Settings.SetSetting(GV.Settings.CW_FailedFolderField, this.txtCWFailedPath.Text.Trim());
                GV.Settings = GV.dbCompany.Settings.ReadSettings();
                
                this.Close();
                this.Dispose();
            }
            catch (Exception ex)
            {
                GV.Log.Append("[ERROR] " + ex.Message);
                GV.ErrorLog.Append(ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }

        private void btnKAMSImported_Click(object sender, EventArgs e)
        {
            try
            {
                using (FolderBrowserDialog fbd = this.folderBrowserDialog1)
                {
                    fbd.SelectedPath = GV.Settings.KAMS_ImportedFolder;
                    if (fbd.ShowDialog() == DialogResult.OK)
                    {
                        this.txtKAMSImportedPath.Text = fbd.SelectedPath;
                    }
                }
            }
            catch (Exception ex)
            {
                GV.Log.Append("[ERROR] " + ex.Message);
                GV.ErrorLog.Append(ex.ToString());
            }
        }

        private void btnKAMSFailed_Click(object sender, EventArgs e)
        {
            try
            {
                using (FolderBrowserDialog fbd = this.folderBrowserDialog1)
                {
                    fbd.SelectedPath = GV.Settings.KAMS_FailedFolder;
                    if (fbd.ShowDialog() == DialogResult.OK)
                    {
                        this.txtKAMSFailedPath.Text = fbd.SelectedPath;
                    }
                }
            }
            catch (Exception ex)
            {
                GV.Log.Append("[ERROR] " + ex.Message);
                GV.ErrorLog.Append(ex.ToString());
            }
        }

        private void btnCWSource_Click(object sender, EventArgs e)
        {
            try
            {
                using (FolderBrowserDialog fbd = this.folderBrowserDialog1)
                {
                    fbd.SelectedPath = GV.Settings.CW_SourceFolder;
                    if (fbd.ShowDialog() == DialogResult.OK)
                    {
                        this.txtCWSourcePath.Text = fbd.SelectedPath;
                    }
                }
            }
            catch (Exception ex)
            {
                GV.Log.Append("[ERROR] " + ex.Message);
                GV.ErrorLog.Append(ex.ToString());
            }
        }

        private void btnCWImported_Click(object sender, EventArgs e)
        {
            try
            {
                using (FolderBrowserDialog fbd = this.folderBrowserDialog1)
                {
                    fbd.SelectedPath = GV.Settings.CW_ImportedFolder;
                    if (fbd.ShowDialog() == DialogResult.OK)
                    {
                        this.txtCWImportedPath.Text = fbd.SelectedPath;
                    }
                }
            }
            catch (Exception ex)
            {
                GV.Log.Append("[ERROR] " + ex.Message);
                GV.ErrorLog.Append(ex.ToString());
            }
        }

        private void btnCWFailed_Click(object sender, EventArgs e)
        {
            try
            {
                using (FolderBrowserDialog fbd = this.folderBrowserDialog1)
                {
                    fbd.SelectedPath = GV.Settings.CW_FailedFolder;
                    if (fbd.ShowDialog() == DialogResult.OK)
                    {
                        this.txtCWFailedPath.Text = fbd.SelectedPath;
                    }
                }
            }
            catch (Exception ex)
            {
                GV.Log.Append("[ERROR] " + ex.Message);
                GV.ErrorLog.Append(ex.ToString());
            }
        }
    }
}