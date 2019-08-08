using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Accpac_Interface
{
    public partial class frmUsers : Form
    {
        List<User> oUserList = new List<User>();

        private enum EnumEditStatus
        {
            None = 0,
            Insert = 1,
            Update = 2
        };

        private enum EnumLoginBy
        {
            EmailCredentials = 0,
            WindowsCredentials = 1
        };

        public frmUsers()
        {
            InitializeComponent();
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = string.Format("Users");
                SetEditBoxStatus(EnumEditStatus.None);
                EnableEditBox(false);
                oUserList = User.ReadAll();
                FillUsers();
            }
            catch (Exception ex)
            {
                GV.Log.Append("[ERROR] " + ex.Message);
                GV.ErrorLog.Append(ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }

        private void frmUsers_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.btnDelete.Enabled = true;
            this.btnEdit.Enabled = true;
        }

        private void txtUserID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUserID_Enter(object sender, EventArgs e)
        {
            this.txtUserID.SelectAll();
        }

        private void txtUserName_Enter(object sender, EventArgs e)
        {
            this.txtUserName.SelectAll();
        }

        private void EnableEditBox(bool bEnable)
        {
            this.boxDetail.Enabled = bEnable;
            this.btnAdd.Enabled = !bEnable;
            this.btnEdit.Enabled = !bEnable;
            this.btnDelete.Enabled = !bEnable;
            this.ctxUsers.Enabled = !bEnable;
            this.btnClose.Enabled = !bEnable;
        }

        private void SetEditBoxStatus(EnumEditStatus iStatus)
        {
            switch (iStatus)
            {
                case EnumEditStatus.Insert:
                    EnableEditBox(true);
                    this.txtUserID.Text = "";
                    this.chkActive.Checked = true;
                    this.txtUserName.Text = "";
                    this.chkSurchargeSettings.Checked = false;
                    this.chkClearHistory.Checked = false;
                    this.txtUserID.ReadOnly = false;
                    this.btnUpdate.Text = "Insert";
                    break;

                case EnumEditStatus.Update:
                    EnableEditBox(true);
                    this.txtUserID.Text = oUserList[lvUsers.FocusedItem.Index].UserID;
                    this.chkActive.Checked = (oUserList[lvUsers.FocusedItem.Index].Status == User.EnumStatus.Active);
                    this.txtUserName.Text = oUserList[lvUsers.FocusedItem.Index].UserName;
                    this.chkSurchargeSettings.Checked = (oUserList[lvUsers.FocusedItem.Index].RightOfSurchargeSettings == UserRight.EnumAuthorization.Authorized);
                    this.chkClearHistory.Checked = (oUserList[lvUsers.FocusedItem.Index].RightOfClearHistory == UserRight.EnumAuthorization.Authorized);
                    this.txtUserID.ReadOnly = true;
                    this.btnUpdate.Text = "Update";
                    break;

                case EnumEditStatus.None:
                    EnableEditBox(false);
                    this.txtUserID.Text = "";
                    this.chkActive.Checked = true;
                    this.txtUserName.Text = "";
                    this.chkSurchargeSettings.Checked = false;
                    this.chkClearHistory.Checked = false;
                    this.txtUserID.ReadOnly = false;
                    this.btnUpdate.Text = "Insert";
                    break;
            }

            // Special treatment for ADMIN
            if (this.txtUserID.Text == "ADMIN")
            {
                this.chkActive.Visible = false;
            }
            else
            {
                this.chkActive.Visible = true;
            }
        }

        private void FillUsers()
        {
            lvUsers.Items.Clear();
            foreach (User u in oUserList)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.SubItems[0].Text = u.UserID;
                lvi.SubItems.Add(u.UserName);
                lvi.SubItems.Add(u.Status == User.EnumStatus.Active ? "Active" : "-");
                lvUsers.Items.Add(lvi);
            }
            lvUsers.Refresh();
            System.Windows.Forms.Application.DoEvents();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvUsers.FocusedItem == null)
                {
                    MessageBox.Show("Please select a user from the list !", "Delete User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (lvUsers.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Please select a user from the list !", "Delete User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (lvUsers.FocusedItem.Index != lvUsers.SelectedItems[0].Index)
                {
                    MessageBox.Show("Please select a user from the list !", "Delete User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                User oSelectedUser = oUserList[lvUsers.FocusedItem.Index];
                if (MessageBox.Show(string.Format("Delete user \"{0}\" ?", oSelectedUser.UserID), "Delete User", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }

                // Delete the user
                if (oSelectedUser.DeleteFromTable())
                {
                    oUserList = User.ReadAll();
                    FillUsers();
                    MessageBox.Show(string.Format("User \"{0}\" deleted !", oSelectedUser.UserID), "Delete User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(string.Format("Could not delete user \"{0}\".", oSelectedUser.UserID), "Delete User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                if (ex.Message != "")
                {
                    GV.Log.Append("[ERROR] " + ex.Message);
                    GV.ErrorLog.Append(ex.ToString());
                }
                string sStatus = "There is a problem when deleting User Information.";
                MessageBox.Show(sStatus, "Delete User Information");
                GV.Log.Append(sStatus);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvUsers.FocusedItem == null)
                {
                    MessageBox.Show("Please select a user from the list !", "Edit User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (lvUsers.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Please select a user from the list !", "Edit User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (lvUsers.FocusedItem.Index != lvUsers.SelectedItems[0].Index)
                {
                    MessageBox.Show("Please select a user from the list !", "Edit User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                SetEditBoxStatus(EnumEditStatus.Update);
            }
            catch (Exception ex)
            {
                if (ex.Message != "")
                {
                    GV.Log.Append("[ERROR] " + ex.Message);
                    GV.ErrorLog.Append(ex.ToString());
                }
                string sStatus = "There is a problem when preparing User Information editor.";
                MessageBox.Show(sStatus, "Edit User Information");
                GV.Log.Append(sStatus);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                SetEditBoxStatus(EnumEditStatus.Insert);
            }
            catch (Exception ex)
            {
                if (ex.Message != "")
                {
                    GV.Log.Append("[ERROR] " + ex.Message);
                    GV.ErrorLog.Append(ex.ToString());
                }
                string sStatus = "There is a problem when preparing User Information editor.";
                MessageBox.Show(sStatus, "Add User Information");
                GV.Log.Append(sStatus);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            this.Cursor = Cursors.WaitCursor;

            try
            {
                User oEntryUser = new User();

                // Read entry
                oEntryUser.UserID = txtUserID.Text.Trim();
                oEntryUser.Status = (this.chkActive.Checked == true ? User.EnumStatus.Active : User.EnumStatus.Inactive);
                oEntryUser.UserName = txtUserName.Text.Trim();
                oEntryUser.RightOfSurchargeSettings = (this.chkSurchargeSettings.Checked == true ? UserRight.EnumAuthorization.Authorized : UserRight.EnumAuthorization.Unauthorized);
                oEntryUser.RightOfClearHistory = (this.chkClearHistory.Checked == true ? UserRight.EnumAuthorization.Authorized : UserRight.EnumAuthorization.Unauthorized);

                // Validate inputs
                string msg = "";
                if (string.IsNullOrEmpty(oEntryUser.UserID))
                {
                    msg += "User ID is mandatory.";
                }
                if (msg != "")
                {
                    MessageBox.Show(msg, "Validate User Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }


                // If text = "Update" then perform update, else perform Insert
                if (btnUpdate.Text == "Update")
                {
                    if (oEntryUser.UpdateTable())
                    {
                        // Update the LV first
                        oUserList = User.ReadAll();
                        this.FillUsers();
                        MessageBox.Show(string.Format("User ID \"{0}\" updated.", oEntryUser.UserID), "Update User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Clear out and set the detail box
                        SetEditBoxStatus(EnumEditStatus.None);
                    }
                    else
                    {
                        MessageBox.Show(string.Format("Failed updating user \"{0}\".", oEntryUser.UserID), "Update User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    // Add the user
                    // Validate for duplicate User ID First
                    foreach (User u in oUserList)
                    {
                        if (u.UserID.ToUpper() == oEntryUser.UserID.ToUpper())
                        {
                            MessageBox.Show(string.Format("User ID \"{0}\" already exists.", oEntryUser.UserID), "Validate User Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }
                    if (oEntryUser.InsertIntoTable())
                    {
                        // Update the lvusers
                        oUserList = User.ReadAll();
                        this.FillUsers();
                        MessageBox.Show(string.Format("User \"{0}\" created.", oEntryUser.UserID), "Insert User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Clear out the detail box
                        SetEditBoxStatus(EnumEditStatus.None);
                    }
                    else
                    {
                        MessageBox.Show(string.Format("Failed inserting user \"{0}\".", oEntryUser.UserID), "Insert User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
            catch (Exception ex)
            {
                if (ex.Message != "")
                {
                    GV.Log.Append("[ERROR] " + ex.Message);
                    GV.ErrorLog.Append(ex.ToString());
                }
                string sStatus = "There is a problem when updating user information.";
                MessageBox.Show(sStatus, btnUpdate.Text + " User Information");
                GV.Log.Append(sStatus);
            }

            this.Enabled = true;
            this.Cursor = Cursors.Default;
        }

        private void ctxEdit_Click(object sender, EventArgs e)
        {
            this.btnEdit.PerformClick();
        }

        private void ctxDelete_Click(object sender, EventArgs e)
        {
            this.btnDelete.PerformClick();
        }

        private void ctxUsers_Opening(object sender, CancelEventArgs e)
        {
            try
            {
                if (this.btnDelete.Visible == false)
                {
                    this.ctxDelete.Visible = false;
                }
                else
                {
                    this.ctxDelete.Visible = true;
                }

                if (this.btnEdit.Visible == false)
                {
                    this.ctxEdit.Visible = false;
                }
                else
                {
                    this.ctxEdit.Visible = true;
                }
            }
            catch (Exception ex)
            {
                GV.Log.Append("[ERROR] " + ex.Message);
                GV.ErrorLog.Append(ex.ToString());
            }
        }

        private void txtUserID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                SetEditBoxStatus(EnumEditStatus.None);
            }
            catch (Exception ex)
            {
                if (ex.Message != "")
                {
                    GV.Log.Append("[ERROR] " + ex.Message);
                    GV.ErrorLog.Append(ex.ToString());
                }
                string sStatus = "There is a problem when cancelling update.";
                MessageBox.Show(sStatus, "Cancel Update");
                GV.Log.Append(sStatus);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                this.txtUserID.Text = "";
                this.txtUserID.ReadOnly = false;
                this.txtUserName.Text = "";
                this.boxDetail.Enabled = false;
                this.btnUpdate.Text = "Update";

                this.btnAdd.Enabled = true;
                this.btnEdit.Enabled = true;
                this.btnDelete.Enabled = true;
                this.ctxUsers.Enabled = true;

                this.Close();
                this.Dispose();
            }
            catch (Exception ex)
            {
                GV.Log.Append("[ERROR] " + ex.Message);
                GV.ErrorLog.Append(ex.ToString());
            }
        }
    }
}