namespace Accpac_Interface
{
    partial class frmOtherSettings
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
            this.boxCW = new System.Windows.Forms.GroupBox();
            this.txtAdjustment = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCurrency = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBankCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtInterest = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUtility = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkKAMS = new System.Windows.Forms.CheckBox();
            this.chkCW = new System.Windows.Forms.CheckBox();
            this.boxCW.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // boxCW
            // 
            this.boxCW.Controls.Add(this.txtAdjustment);
            this.boxCW.Controls.Add(this.label5);
            this.boxCW.Controls.Add(this.txtCurrency);
            this.boxCW.Controls.Add(this.label2);
            this.boxCW.Controls.Add(this.txtBankCode);
            this.boxCW.Controls.Add(this.label4);
            this.boxCW.Controls.Add(this.txtInterest);
            this.boxCW.Controls.Add(this.label3);
            this.boxCW.Controls.Add(this.txtUtility);
            this.boxCW.Controls.Add(this.label1);
            this.boxCW.Location = new System.Drawing.Point(12, 12);
            this.boxCW.Name = "boxCW";
            this.boxCW.Size = new System.Drawing.Size(227, 163);
            this.boxCW.TabIndex = 0;
            this.boxCW.TabStop = false;
            this.boxCW.Text = "Codes";
            // 
            // txtAdjustment
            // 
            this.txtAdjustment.Location = new System.Drawing.Point(111, 73);
            this.txtAdjustment.MaxLength = 6;
            this.txtAdjustment.Name = "txtAdjustment";
            this.txtAdjustment.Size = new System.Drawing.Size(102, 20);
            this.txtAdjustment.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Adjustment Code";
            // 
            // txtCurrency
            // 
            this.txtCurrency.Location = new System.Drawing.Point(111, 126);
            this.txtCurrency.MaxLength = 6;
            this.txtCurrency.Name = "txtCurrency";
            this.txtCurrency.Size = new System.Drawing.Size(102, 20);
            this.txtCurrency.TabIndex = 9;
            this.txtCurrency.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCurrency_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Currency";
            // 
            // txtBankCode
            // 
            this.txtBankCode.Location = new System.Drawing.Point(111, 99);
            this.txtBankCode.MaxLength = 6;
            this.txtBankCode.Name = "txtBankCode";
            this.txtBankCode.Size = new System.Drawing.Size(102, 20);
            this.txtBankCode.TabIndex = 7;
            this.txtBankCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBankCode_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Bank Code";
            // 
            // txtInterest
            // 
            this.txtInterest.Location = new System.Drawing.Point(111, 47);
            this.txtInterest.MaxLength = 6;
            this.txtInterest.Name = "txtInterest";
            this.txtInterest.Size = new System.Drawing.Size(102, 20);
            this.txtInterest.TabIndex = 3;
            this.txtInterest.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInterest_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Interest Code";
            // 
            // txtUtility
            // 
            this.txtUtility.Location = new System.Drawing.Point(111, 20);
            this.txtUtility.MaxLength = 6;
            this.txtUtility.Name = "txtUtility";
            this.txtUtility.Size = new System.Drawing.Size(102, 20);
            this.txtUtility.TabIndex = 1;
            this.txtUtility.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUtility_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Utility Code";
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(319, 181);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(238, 181);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkKAMS);
            this.groupBox1.Controls.Add(this.chkCW);
            this.groupBox1.Location = new System.Drawing.Point(251, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(143, 163);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Functions";
            // 
            // chkKAMS
            // 
            this.chkKAMS.AutoSize = true;
            this.chkKAMS.Location = new System.Drawing.Point(18, 51);
            this.chkKAMS.Name = "chkKAMS";
            this.chkKAMS.Size = new System.Drawing.Size(56, 17);
            this.chkKAMS.TabIndex = 2;
            this.chkKAMS.Text = "&KAMS";
            this.chkKAMS.UseVisualStyleBackColor = true;
            // 
            // chkCW
            // 
            this.chkCW.AutoSize = true;
            this.chkCW.Location = new System.Drawing.Point(18, 25);
            this.chkCW.Name = "chkCW";
            this.chkCW.Size = new System.Drawing.Size(44, 17);
            this.chkCW.TabIndex = 1;
            this.chkCW.Text = "&CW";
            this.chkCW.UseVisualStyleBackColor = true;
            // 
            // frmOtherSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 220);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.boxCW);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOtherSettings";
            this.Text = "frmOtherSettings";
            this.Load += new System.EventHandler(this.frmOtherSettings_Load);
            this.boxCW.ResumeLayout(false);
            this.boxCW.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox boxCW;
        private System.Windows.Forms.TextBox txtUtility;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox txtInterest;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCurrency;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBankCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAdjustment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkCW;
        private System.Windows.Forms.CheckBox chkKAMS;
    }
}