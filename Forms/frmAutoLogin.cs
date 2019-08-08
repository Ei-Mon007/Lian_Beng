using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Accpac_Interface
{
    public partial class frmAutoLogin : Form
    {
        AutoLogins oLogin;

        public frmAutoLogin()
        {
            InitializeComponent();
        }

        private void frmAutoLogin_Load(object sender, EventArgs e)
        {
            try
            {
                this.chkEnableAutoLogin.Text = string.Format("Enable Auto-Login for {0}", GV.Accpac.AccpacDBID);

                oLogin = new AutoLogins(GV.Accpac.AccpacDBID);
                this.chkEnableAutoLogin.Checked = oLogin.Enabled;
                this.EnableControls(oLogin.Enabled);
                this.txtUserName.Text = oLogin.UserID;
                this.txtPassword.Text = oLogin.Password;
            }
            catch (Exception ex)
            {
                GV.Log.Append("[ERROR] " + ex.Message);
                GV.ErrorLog.Append(ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
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

        private void txtUserName_Enter(object sender, EventArgs e)
        {
            txtUserName.SelectAll();
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            txtPassword.SelectAll();
        }

        private void EnableControls(bool bEnabled)
        {
            this.txtUserName.Enabled = bEnabled;
            this.txtPassword.Enabled = bEnabled;
            this.btnTest.Enabled = bEnabled;
        }

        private void chkEnableAutoLogin_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                EnableControls(this.chkEnableAutoLogin.Checked);
            }
            catch (Exception ex)
            {
                GV.Log.Append("[ERROR] " + ex.Message);
                GV.ErrorLog.Append(ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }

        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
            catch { }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                oLogin.Enabled = this.chkEnableAutoLogin.Checked;
                if (oLogin.Enabled)
                {
                    oLogin.UserID = this.txtUserName.Text;
                    oLogin.Password = this.txtPassword.Text;
                }
                if (oLogin.Save())
                {
                    this.Close();
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                GV.Log.Append("[ERROR] " + ex.Message);
                GV.ErrorLog.Append(ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            if (this.chkEnableAutoLogin.Checked)
            {
                AccpacSession_COM oSession = new AccpacSession_COM();
                string sMsg = "";
                try
                {
                    oSession.AccpacDBID = GV.Accpac.AccpacDBID;
                    oSession.UserID = this.txtUserName.Text.Trim();
                    oSession.Password = this.txtPassword.Text.Trim();
                    oSession.SessionDate = DateTime.Today;
                    if (oSession.Connect())
                    {
                        sMsg = "Test completed successfully.";
                        oSession.Disconnect();
                    }
                    else
                    {
                        sMsg = "Test failed.";
                    }
                    MessageBox.Show(sMsg, "Test Connection");
                }
                catch (Exception ex)
                {
                    GV.Log.Append("[ERROR] " + ex.Message);
                    GV.ErrorLog.Append(ex.ToString());
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    oSession = null;
                }
            }
        }
    }
}