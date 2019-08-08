namespace Accpac_Interface
{
    partial class frmDirectories
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabKAMS = new System.Windows.Forms.TabPage();
            this.boxKAMS = new System.Windows.Forms.GroupBox();
            this.btnKAMSFailed = new System.Windows.Forms.Button();
            this.txtKAMSFailedPath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnKAMSImported = new System.Windows.Forms.Button();
            this.txtKAMSImportedPath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnKAMSSource = new System.Windows.Forms.Button();
            this.txtKAMSSourcePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabCW = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCWFailed = new System.Windows.Forms.Button();
            this.txtCWFailedPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCWImported = new System.Windows.Forms.Button();
            this.txtCWImportedPath = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCWSource = new System.Windows.Forms.Button();
            this.txtCWSourcePath = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabKAMS.SuspendLayout();
            this.boxKAMS.SuspendLayout();
            this.tabCW.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(599, 205);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(518, 205);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tabControl1
            // 
            this.tabControl.Controls.Add(this.tabKAMS);
            this.tabControl.Controls.Add(this.tabCW);
            this.tabControl.Location = new System.Drawing.Point(16, 24);
            this.tabControl.Name = "tabControl1";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(658, 173);
            this.tabControl.TabIndex = 4;
            // 
            // tabKAMS
            // 
            this.tabKAMS.Controls.Add(this.boxKAMS);
            this.tabKAMS.Location = new System.Drawing.Point(4, 22);
            this.tabKAMS.Name = "tabKAMS";
            this.tabKAMS.Padding = new System.Windows.Forms.Padding(3);
            this.tabKAMS.Size = new System.Drawing.Size(650, 147);
            this.tabKAMS.TabIndex = 0;
            this.tabKAMS.Text = "KAMS";
            this.tabKAMS.UseVisualStyleBackColor = true;
            // 
            // boxKAMS
            // 
            this.boxKAMS.Controls.Add(this.btnKAMSFailed);
            this.boxKAMS.Controls.Add(this.txtKAMSFailedPath);
            this.boxKAMS.Controls.Add(this.label4);
            this.boxKAMS.Controls.Add(this.btnKAMSImported);
            this.boxKAMS.Controls.Add(this.txtKAMSImportedPath);
            this.boxKAMS.Controls.Add(this.label3);
            this.boxKAMS.Controls.Add(this.btnKAMSSource);
            this.boxKAMS.Controls.Add(this.txtKAMSSourcePath);
            this.boxKAMS.Controls.Add(this.label1);
            this.boxKAMS.Location = new System.Drawing.Point(13, 15);
            this.boxKAMS.Name = "boxKAMS";
            this.boxKAMS.Size = new System.Drawing.Size(625, 111);
            this.boxKAMS.TabIndex = 1;
            this.boxKAMS.TabStop = false;
            this.boxKAMS.Text = "KAMS";
            // 
            // btnKAMSFailed
            // 
            this.btnKAMSFailed.Location = new System.Drawing.Point(576, 73);
            this.btnKAMSFailed.Name = "btnKAMSFailed";
            this.btnKAMSFailed.Size = new System.Drawing.Size(29, 21);
            this.btnKAMSFailed.TabIndex = 8;
            this.btnKAMSFailed.Text = "...";
            this.btnKAMSFailed.UseVisualStyleBackColor = true;
            this.btnKAMSFailed.Click += new System.EventHandler(this.btnKAMSFailed_Click);
            // 
            // txtKAMSFailedPath
            // 
            this.txtKAMSFailedPath.Location = new System.Drawing.Point(94, 74);
            this.txtKAMSFailedPath.Name = "txtKAMSFailedPath";
            this.txtKAMSFailedPath.ReadOnly = true;
            this.txtKAMSFailedPath.Size = new System.Drawing.Size(476, 20);
            this.txtKAMSFailedPath.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Failed Path";
            // 
            // btnKAMSImported
            // 
            this.btnKAMSImported.Location = new System.Drawing.Point(576, 46);
            this.btnKAMSImported.Name = "btnKAMSImported";
            this.btnKAMSImported.Size = new System.Drawing.Size(29, 21);
            this.btnKAMSImported.TabIndex = 5;
            this.btnKAMSImported.Text = "...";
            this.btnKAMSImported.UseVisualStyleBackColor = true;
            this.btnKAMSImported.Click += new System.EventHandler(this.btnKAMSImported_Click);
            // 
            // txtKAMSImportedPath
            // 
            this.txtKAMSImportedPath.Location = new System.Drawing.Point(94, 47);
            this.txtKAMSImportedPath.Name = "txtKAMSImportedPath";
            this.txtKAMSImportedPath.ReadOnly = true;
            this.txtKAMSImportedPath.Size = new System.Drawing.Size(476, 20);
            this.txtKAMSImportedPath.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Imported Path";
            // 
            // btnKAMSSource
            // 
            this.btnKAMSSource.Location = new System.Drawing.Point(576, 19);
            this.btnKAMSSource.Name = "btnKAMSSource";
            this.btnKAMSSource.Size = new System.Drawing.Size(29, 21);
            this.btnKAMSSource.TabIndex = 2;
            this.btnKAMSSource.Text = "...";
            this.btnKAMSSource.UseVisualStyleBackColor = true;
            this.btnKAMSSource.Click += new System.EventHandler(this.btnKAMSSource_Click);
            // 
            // txtKAMSSourcePath
            // 
            this.txtKAMSSourcePath.Location = new System.Drawing.Point(94, 20);
            this.txtKAMSSourcePath.Name = "txtKAMSSourcePath";
            this.txtKAMSSourcePath.ReadOnly = true;
            this.txtKAMSSourcePath.Size = new System.Drawing.Size(476, 20);
            this.txtKAMSSourcePath.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source Path";
            // 
            // tabCW
            // 
            this.tabCW.Controls.Add(this.groupBox1);
            this.tabCW.Location = new System.Drawing.Point(4, 22);
            this.tabCW.Name = "tabCW";
            this.tabCW.Padding = new System.Windows.Forms.Padding(3);
            this.tabCW.Size = new System.Drawing.Size(650, 147);
            this.tabCW.TabIndex = 1;
            this.tabCW.Text = "C & W";
            this.tabCW.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCWFailed);
            this.groupBox1.Controls.Add(this.txtCWFailedPath);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnCWImported);
            this.groupBox1.Controls.Add(this.txtCWImportedPath);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnCWSource);
            this.groupBox1.Controls.Add(this.txtCWSourcePath);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(13, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(625, 111);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "C && W";
            // 
            // btnCWFailed
            // 
            this.btnCWFailed.Location = new System.Drawing.Point(576, 73);
            this.btnCWFailed.Name = "btnCWFailed";
            this.btnCWFailed.Size = new System.Drawing.Size(29, 21);
            this.btnCWFailed.TabIndex = 8;
            this.btnCWFailed.Text = "...";
            this.btnCWFailed.UseVisualStyleBackColor = true;
            this.btnCWFailed.Click += new System.EventHandler(this.btnCWFailed_Click);
            // 
            // txtCWFailedPath
            // 
            this.txtCWFailedPath.Location = new System.Drawing.Point(94, 74);
            this.txtCWFailedPath.Name = "txtCWFailedPath";
            this.txtCWFailedPath.ReadOnly = true;
            this.txtCWFailedPath.Size = new System.Drawing.Size(476, 20);
            this.txtCWFailedPath.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Failed Path";
            // 
            // btnCWImported
            // 
            this.btnCWImported.Location = new System.Drawing.Point(576, 46);
            this.btnCWImported.Name = "btnCWImported";
            this.btnCWImported.Size = new System.Drawing.Size(29, 21);
            this.btnCWImported.TabIndex = 5;
            this.btnCWImported.Text = "...";
            this.btnCWImported.UseVisualStyleBackColor = true;
            this.btnCWImported.Click += new System.EventHandler(this.btnCWImported_Click);
            // 
            // txtCWImportedPath
            // 
            this.txtCWImportedPath.Location = new System.Drawing.Point(94, 47);
            this.txtCWImportedPath.Name = "txtCWImportedPath";
            this.txtCWImportedPath.ReadOnly = true;
            this.txtCWImportedPath.Size = new System.Drawing.Size(476, 20);
            this.txtCWImportedPath.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Imported Path";
            // 
            // btnCWSource
            // 
            this.btnCWSource.Location = new System.Drawing.Point(576, 19);
            this.btnCWSource.Name = "btnCWSource";
            this.btnCWSource.Size = new System.Drawing.Size(29, 21);
            this.btnCWSource.TabIndex = 2;
            this.btnCWSource.Text = "...";
            this.btnCWSource.UseVisualStyleBackColor = true;
            this.btnCWSource.Click += new System.EventHandler(this.btnCWSource_Click);
            // 
            // txtCWSourcePath
            // 
            this.txtCWSourcePath.Location = new System.Drawing.Point(94, 20);
            this.txtCWSourcePath.Name = "txtCWSourcePath";
            this.txtCWSourcePath.ReadOnly = true;
            this.txtCWSourcePath.Size = new System.Drawing.Size(476, 20);
            this.txtCWSourcePath.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Source Path";
            // 
            // frmDirectories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 247);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDirectories";
            this.Text = "frmDirectories";
            this.Load += new System.EventHandler(this.frmDirectories_Load);
            this.tabControl.ResumeLayout(false);
            this.tabKAMS.ResumeLayout(false);
            this.boxKAMS.ResumeLayout(false);
            this.boxKAMS.PerformLayout();
            this.tabCW.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabKAMS;
        private System.Windows.Forms.GroupBox boxKAMS;
        private System.Windows.Forms.Button btnKAMSFailed;
        private System.Windows.Forms.TextBox txtKAMSFailedPath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnKAMSImported;
        private System.Windows.Forms.TextBox txtKAMSImportedPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnKAMSSource;
        private System.Windows.Forms.TextBox txtKAMSSourcePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabCW;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCWFailed;
        private System.Windows.Forms.TextBox txtCWFailedPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCWImported;
        private System.Windows.Forms.TextBox txtCWImportedPath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCWSource;
        private System.Windows.Forms.TextBox txtCWSourcePath;
        private System.Windows.Forms.Label label6;
    }
}