namespace NDEY.UI
{
    partial class frmAddUnit
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
            this.plButtons = new DevExpress.XtraEditors.PanelControl();
            this.btnOK = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.plContent = new DevExpress.XtraEditors.PanelControl();
            this.txtUnitBankNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUnitBankName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUnitBankUser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUnitName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUnitType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.plButtons)).BeginInit();
            this.plButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plContent)).BeginInit();
            this.plContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // plButtons
            // 
            this.plButtons.Controls.Add(this.btnOK);
            this.plButtons.Controls.Add(this.btnCancel);
            this.plButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.plButtons.Location = new System.Drawing.Point(2, 209);
            this.plButtons.Name = "plButtons";
            this.plButtons.Size = new System.Drawing.Size(393, 36);
            this.plButtons.TabIndex = 7;
            // 
            // btnOK
            // 
            this.btnOK.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnOK.Location = new System.Drawing.Point(211, 2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(90, 32);
            this.btnOK.StateCommon.Content.LongText.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOK.StateCommon.Content.ShortText.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOK.TabIndex = 28;
            this.btnOK.Values.Text = "保存";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancel.Location = new System.Drawing.Point(301, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 32);
            this.btnCancel.StateCommon.Content.LongText.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.StateCommon.Content.ShortText.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.TabIndex = 27;
            this.btnCancel.Values.Text = "取消";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // plContent
            // 
            this.plContent.Controls.Add(this.txtUnitType);
            this.plContent.Controls.Add(this.txtUnitBankNo);
            this.plContent.Controls.Add(this.txtPassword);
            this.plContent.Controls.Add(this.label5);
            this.plContent.Controls.Add(this.txtUnitBankName);
            this.plContent.Controls.Add(this.label4);
            this.plContent.Controls.Add(this.txtUnitBankUser);
            this.plContent.Controls.Add(this.label3);
            this.plContent.Controls.Add(this.label2);
            this.plContent.Controls.Add(this.txtUnitName);
            this.plContent.Controls.Add(this.label6);
            this.plContent.Controls.Add(this.label1);
            this.plContent.Controls.Add(this.plButtons);
            this.plContent.Location = new System.Drawing.Point(0, 0);
            this.plContent.Name = "plContent";
            this.plContent.Size = new System.Drawing.Size(397, 247);
            this.plContent.TabIndex = 8;
            // 
            // txtUnitBankNo
            // 
            this.txtUnitBankNo.Location = new System.Drawing.Point(79, 171);
            this.txtUnitBankNo.Name = "txtUnitBankNo";
            this.txtUnitBankNo.Size = new System.Drawing.Size(300, 22);
            this.txtUnitBankNo.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 14);
            this.label5.TabIndex = 8;
            this.label5.Text = "  账    号：";
            // 
            // txtUnitBankName
            // 
            this.txtUnitBankName.Location = new System.Drawing.Point(79, 143);
            this.txtUnitBankName.Name = "txtUnitBankName";
            this.txtUnitBankName.Size = new System.Drawing.Size(300, 22);
            this.txtUnitBankName.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 14);
            this.label4.TabIndex = 8;
            this.label4.Text = " 开 户 行：";
            // 
            // txtUnitBankUser
            // 
            this.txtUnitBankUser.Location = new System.Drawing.Point(79, 115);
            this.txtUnitBankUser.Name = "txtUnitBankUser";
            this.txtUnitBankUser.Size = new System.Drawing.Size(300, 22);
            this.txtUnitBankUser.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 14);
            this.label3.TabIndex = 8;
            this.label3.Text = "开户名称：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 14);
            this.label2.TabIndex = 8;
            this.label2.Text = "单位类型：";
            // 
            // txtUnitName
            // 
            this.txtUnitName.Location = new System.Drawing.Point(79, 59);
            this.txtUnitName.Name = "txtUnitName";
            this.txtUnitName.Size = new System.Drawing.Size(300, 22);
            this.txtUnitName.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 14);
            this.label1.TabIndex = 8;
            this.label1.Text = "单位名称：";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(79, 32);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '#';
            this.txtPassword.Size = new System.Drawing.Size(300, 22);
            this.txtPassword.TabIndex = 0;
            // 
            // txtUnitType
            // 
            this.txtUnitType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtUnitType.FormattingEnabled = true;
            this.txtUnitType.Items.AddRange(new object[] {
            "航天科技",
            "航空科技"});
            this.txtUnitType.Location = new System.Drawing.Point(79, 87);
            this.txtUnitType.Name = "txtUnitType";
            this.txtUnitType.Size = new System.Drawing.Size(300, 22);
            this.txtUnitType.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 14);
            this.label6.TabIndex = 8;
            this.label6.Text = "添加密码：";
            // 
            // frmAddUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 245);
            this.Controls.Add(this.plContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddUnit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加单位";
            ((System.ComponentModel.ISupportInitialize)(this.plButtons)).EndInit();
            this.plButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.plContent)).EndInit();
            this.plContent.ResumeLayout(false);
            this.plContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl plButtons;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnOK;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCancel;
        private DevExpress.XtraEditors.PanelControl plContent;
        private System.Windows.Forms.TextBox txtUnitName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUnitBankNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUnitBankName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUnitBankUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.ComboBox txtUnitType;
        private System.Windows.Forms.Label label6;
    }
}