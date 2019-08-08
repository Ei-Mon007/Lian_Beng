namespace Accpac_Interface
{
    partial class frmUsers
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
            this.components = new System.ComponentModel.Container();
            this.boxDetail = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkSurchargeSettings = new System.Windows.Forms.CheckBox();
            this.chkClearHistory = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lvUsers = new System.Windows.Forms.ListView();
            this.UserID = new System.Windows.Forms.ColumnHeader();
            this.UserName = new System.Windows.Forms.ColumnHeader();
            this.Status = new System.Windows.Forms.ColumnHeader();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.ctxUsers = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.boxDetail.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.ctxUsers.SuspendLayout();
            this.SuspendLayout();
            // 
            // boxDetail
            // 
            this.boxDetail.Controls.Add(this.btnCancel);
            this.boxDetail.Controls.Add(this.btnUpdate);
            this.boxDetail.Controls.Add(this.groupBox2);
            this.boxDetail.Controls.Add(this.label1);
            this.boxDetail.Controls.Add(this.chkActive);
            this.boxDetail.Controls.Add(this.txtUserID);
            this.boxDetail.Controls.Add(this.txtUserName);
            this.boxDetail.Controls.Add(this.label2);
            this.boxDetail.Location = new System.Drawing.Point(13, 167);
            this.boxDetail.Name = "boxDetail";
            this.boxDetail.Size = new System.Drawing.Size(445, 172);
            this.boxDetail.TabIndex = 4;
            this.boxDetail.TabStop = false;
            this.boxDetail.Text = "Detail";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(364, 135);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Ca&ncel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(283, 135);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "&Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkSurchargeSettings);
            this.groupBox2.Controls.Add(this.chkClearHistory);
            this.groupBox2.Location = new System.Drawing.Point(85, 75);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(354, 54);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Authorized Modules";
            // 
            // chkSurchargeSettings
            // 
            this.chkSurchargeSettings.AutoSize = true;
            this.chkSurchargeSettings.Location = new System.Drawing.Point(17, 19);
            this.chkSurchargeSettings.Name = "chkSurchargeSettings";
            this.chkSurchargeSettings.Size = new System.Drawing.Size(113, 17);
            this.chkSurchargeSettings.TabIndex = 0;
            this.chkSurchargeSettings.Text = "Surchage Settings";
            this.chkSurchargeSettings.UseVisualStyleBackColor = true;
            // 
            // chkClearHistory
            // 
            this.chkClearHistory.AutoSize = true;
            this.chkClearHistory.Location = new System.Drawing.Point(200, 19);
            this.chkClearHistory.Name = "chkClearHistory";
            this.chkClearHistory.Size = new System.Drawing.Size(85, 17);
            this.chkClearHistory.TabIndex = 1;
            this.chkClearHistory.Text = "Clear History";
            this.chkClearHistory.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "User ID";
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.Location = new System.Drawing.Point(297, 22);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(56, 17);
            this.chkActive.TabIndex = 2;
            this.chkActive.Text = "Active";
            this.chkActive.UseVisualStyleBackColor = true;
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(85, 23);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(100, 20);
            this.txtUserID.TabIndex = 1;
            this.txtUserID.TextChanged += new System.EventHandler(this.txtUserID_TextChanged);
            this.txtUserID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUserID_KeyPress);
            this.txtUserID.Enter += new System.EventHandler(this.txtUserID_Enter);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(85, 49);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(354, 20);
            this.txtUserName.TabIndex = 4;
            this.txtUserName.Enter += new System.EventHandler(this.txtUserName_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "User Name";
            // 
            // lvUsers
            // 
            this.lvUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.UserID,
            this.UserName,
            this.Status});
            this.lvUsers.ContextMenuStrip = this.ctxUsers;
            this.lvUsers.FullRowSelect = true;
            this.lvUsers.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvUsers.Location = new System.Drawing.Point(12, 12);
            this.lvUsers.Name = "lvUsers";
            this.lvUsers.Size = new System.Drawing.Size(445, 120);
            this.lvUsers.TabIndex = 0;
            this.lvUsers.UseCompatibleStateImageBehavior = false;
            this.lvUsers.View = System.Windows.Forms.View.Details;
            // 
            // UserID
            // 
            this.UserID.Text = "User ID";
            this.UserID.Width = 100;
            // 
            // UserName
            // 
            this.UserName.Text = "User Name";
            this.UserName.Width = 250;
            // 
            // Status
            // 
            this.Status.Text = "Status";
            this.Status.Width = 90;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(382, 138);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(301, 138);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(383, 345);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(220, 138);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // ctxUsers
            // 
            this.ctxUsers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxEdit,
            this.ctxDelete});
            this.ctxUsers.Name = "ctxUsers";
            this.ctxUsers.Size = new System.Drawing.Size(117, 48);
            this.ctxUsers.Opening += new System.ComponentModel.CancelEventHandler(this.ctxUsers_Opening);
            // 
            // ctxEdit
            // 
            this.ctxEdit.Name = "ctxEdit";
            this.ctxEdit.Size = new System.Drawing.Size(116, 22);
            this.ctxEdit.Text = "Edit";
            this.ctxEdit.Click += new System.EventHandler(this.ctxEdit_Click);
            // 
            // ctxDelete
            // 
            this.ctxDelete.Name = "ctxDelete";
            this.ctxDelete.Size = new System.Drawing.Size(116, 22);
            this.ctxDelete.Text = "Delete";
            this.ctxDelete.Click += new System.EventHandler(this.ctxDelete_Click);
            // 
            // frmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 380);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lvUsers);
            this.Controls.Add(this.boxDetail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUsers";
            this.Text = "Users";
            this.Load += new System.EventHandler(this.frmUsers_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmUsers_FormClosing);
            this.boxDetail.ResumeLayout(false);
            this.boxDetail.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ctxUsers.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox boxDetail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkActive;
        private System.Windows.Forms.CheckBox chkSurchargeSettings;
        private System.Windows.Forms.CheckBox chkClearHistory;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lvUsers;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ColumnHeader UserID;
        private System.Windows.Forms.ColumnHeader UserName;
        private System.Windows.Forms.ColumnHeader Status;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ContextMenuStrip ctxUsers;
        private System.Windows.Forms.ToolStripMenuItem ctxEdit;
        private System.Windows.Forms.ToolStripMenuItem ctxDelete;
    }
}