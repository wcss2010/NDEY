namespace NDEY.UI
{
    partial class frmSuperComboboxForm
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
            this.cbxItemList = new System.Windows.Forms.ComboBox();
            this.lblElseText = new System.Windows.Forms.Label();
            this.txtElseItem = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblItemList = new System.Windows.Forms.Label();
            this.cbIsUseList = new System.Windows.Forms.CheckBox();
            this.cbIsUseElseText = new System.Windows.Forms.CheckBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbxItemList
            // 
            this.cbxItemList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxItemList.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbxItemList.FormattingEnabled = true;
            this.cbxItemList.Location = new System.Drawing.Point(69, 47);
            this.cbxItemList.Name = "cbxItemList";
            this.cbxItemList.Size = new System.Drawing.Size(391, 28);
            this.cbxItemList.TabIndex = 1;
            // 
            // lblElseText
            // 
            this.lblElseText.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblElseText.Location = new System.Drawing.Point(25, 83);
            this.lblElseText.Name = "lblElseText";
            this.lblElseText.Size = new System.Drawing.Size(40, 23);
            this.lblElseText.TabIndex = 2;
            this.lblElseText.Text = "其它:";
            this.lblElseText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblElseText.Click += new System.EventHandler(this.lblElseText_Click);
            // 
            // txtElseItem
            // 
            this.txtElseItem.Enabled = false;
            this.txtElseItem.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtElseItem.Location = new System.Drawing.Point(69, 81);
            this.txtElseItem.Name = "txtElseItem";
            this.txtElseItem.Size = new System.Drawing.Size(391, 26);
            this.txtElseItem.TabIndex = 3;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(69, 118);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(63, 29);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(397, 120);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(63, 29);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblItemList
            // 
            this.lblItemList.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblItemList.Location = new System.Drawing.Point(21, 49);
            this.lblItemList.Name = "lblItemList";
            this.lblItemList.Size = new System.Drawing.Size(44, 23);
            this.lblItemList.TabIndex = 0;
            this.lblItemList.Text = "列表:";
            this.lblItemList.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblItemList.Click += new System.EventHandler(this.lblItemList_Click);
            // 
            // cbIsUseList
            // 
            this.cbIsUseList.AutoSize = true;
            this.cbIsUseList.Checked = true;
            this.cbIsUseList.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbIsUseList.Location = new System.Drawing.Point(11, 54);
            this.cbIsUseList.Name = "cbIsUseList";
            this.cbIsUseList.Size = new System.Drawing.Size(15, 14);
            this.cbIsUseList.TabIndex = 5;
            this.cbIsUseList.UseVisualStyleBackColor = true;
            this.cbIsUseList.CheckedChanged += new System.EventHandler(this.cbIsUseList_CheckedChanged);
            // 
            // cbIsUseElseText
            // 
            this.cbIsUseElseText.AutoSize = true;
            this.cbIsUseElseText.Location = new System.Drawing.Point(11, 88);
            this.cbIsUseElseText.Name = "cbIsUseElseText";
            this.cbIsUseElseText.Size = new System.Drawing.Size(15, 14);
            this.cbIsUseElseText.TabIndex = 5;
            this.cbIsUseElseText.UseVisualStyleBackColor = true;
            this.cbIsUseElseText.CheckedChanged += new System.EventHandler(this.cbIsUseElseText_CheckedChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(469, 38);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmSuperComboboxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 154);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.cbIsUseElseText);
            this.Controls.Add(this.cbIsUseList);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtElseItem);
            this.Controls.Add(this.lblElseText);
            this.Controls.Add(this.cbxItemList);
            this.Controls.Add(this.lblItemList);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSuperComboboxForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "请先从列表中选，若列表中不存在，选其它！";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbxItemList;
        private System.Windows.Forms.Label lblElseText;
        private System.Windows.Forms.TextBox txtElseItem;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblItemList;
        private System.Windows.Forms.CheckBox cbIsUseList;
        private System.Windows.Forms.CheckBox cbIsUseElseText;
        private System.Windows.Forms.Label lblTitle;
    }
}