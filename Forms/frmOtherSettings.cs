using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Accpac_Interface
{
    public partial class frmOtherSettings : Form
    {
        public frmOtherSettings()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void frmOtherSettings_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = string.Format("Other Settings");
                this.txtUtility.Text = GV.Settings.UtilityCode;
                this.txtInterest.Text = GV.Settings.InterestCode;
                this.txtAdjustment.Text = GV.Settings.AdjustmentCode;
                this.txtBankCode.Text = GV.Settings.CWBankCode;
                this.txtCurrency.Text = GV.Settings.CWCurrency;
                this.chkCW.Checked = GV.Settings.FunctionCW;
                this.chkKAMS.Checked = GV.Settings.FunctionKAMS;
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
                validateCheckbox();

                GV.dbCompany.Settings.SetSetting(GV.Settings.UtilityCodeField, this.txtUtility.Text.Trim());
                GV.dbCompany.Settings.SetSetting(GV.Settings.InterestCodeField, this.txtInterest.Text.Trim());
                GV.dbCompany.Settings.SetSetting(GV.Settings.AdjustmentCodeField, this.txtAdjustment.Text.Trim());
                GV.dbCompany.Settings.SetSetting(GV.Settings.CWBankCodeField, this.txtBankCode.Text.Trim());
                GV.dbCompany.Settings.SetSetting(GV.Settings.CWCurrencyField, this.txtCurrency.Text.Trim());
                GV.dbCompany.Settings.SetSetting(GV.Settings.FunctionCWField, (chkCW.Checked ? "1" : "0"));
                GV.dbCompany.Settings.SetSetting(GV.Settings.FunctionKAMSField, (chkKAMS.Checked ? "1" : "0"));
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

        private void txtUtility_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }

        private void txtInterest_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }

        private void txtBankCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }

        private void txtCurrency_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }

        private void chkCW_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkKAMS_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void validateCheckbox()
        {
            if (!chkCW.Checked && !chkKAMS.Checked)
            {
                throw new Exception("Please select at least one function ");
            }
        }
    }
}