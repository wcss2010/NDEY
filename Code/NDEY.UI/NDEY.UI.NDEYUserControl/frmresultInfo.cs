using ComponentFactory.Krypton.Navigator;
using ComponentFactory.Krypton.Toolkit;
using NDEY.BLL.Entity;
using NDEY.BLL.Service;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace NDEY.UI.NDEYUserControl
{
	public class frmResultInfo : BaseControl
	{
		private IContainer components;

		private TableLayoutPanel tableLayoutPanel4;

		private TableLayoutPanel tableLayoutPanel28;

		private KryptonButton btnResultSave;

		private KryptonPanel kryptonPanel19;

		private KryptonLabel kryptonLabel61;

		private Label label1;

		private HSkinTableLayoutPanel hSkinTableLayoutPanel1;

		private KryptonPanel kryptonPanel1;

		private KryptonCheckBox cbr5;

		private KryptonCheckBox cbr3;

		private KryptonCheckBox cbr4;

		private KryptonCheckBox cbr2;

		private KryptonCheckBox cbr1;

		private KryptonTextBox cbrOthertxt;

		private KryptonLabel kryptonLabel1;

		private KryptonCheckBox cbr10;

		private KryptonCheckBox cbr9;

		private KryptonCheckBox cbr11;

		private KryptonCheckBox cbr12;

		private KryptonCheckBox cbr8;

		private KryptonCheckBox cbr7;

		private KryptonCheckBox cbr6;

		private ResultFormInfoService _resultFormInfoService = new ResultFormInfoService();
        private ButtonSpecAny buttonSpecAny1;
        private bool issaved;

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmResultInfo));
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel28 = new System.Windows.Forms.TableLayoutPanel();
            this.btnResultSave = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonPanel19 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.kryptonLabel61 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.hSkinTableLayoutPanel1 = new NDEY.UI.HSkinTableLayoutPanel();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.cbr10 = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.cbr9 = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.cbr11 = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.cbr12 = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.cbr8 = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.cbr7 = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.cbr6 = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cbrOthertxt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.cbr5 = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.cbr3 = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.cbr4 = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.cbr2 = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.cbr1 = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.buttonSpecAny1 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel28.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel19)).BeginInit();
            this.kryptonPanel19.SuspendLayout();
            this.hSkinTableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel28, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.kryptonPanel19, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.hSkinTableLayoutPanel1, 1, 2);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 5;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(867, 545);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // tableLayoutPanel28
            // 
            this.tableLayoutPanel28.ColumnCount = 2;
            this.tableLayoutPanel28.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel28.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel28.Controls.Add(this.btnResultSave, 1, 0);
            this.tableLayoutPanel28.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel28.Location = new System.Drawing.Point(93, 488);
            this.tableLayoutPanel28.Name = "tableLayoutPanel28";
            this.tableLayoutPanel28.RowCount = 1;
            this.tableLayoutPanel28.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel28.Size = new System.Drawing.Size(681, 34);
            this.tableLayoutPanel28.TabIndex = 2;
            // 
            // btnResultSave
            // 
            this.btnResultSave.Location = new System.Drawing.Point(564, 3);
            this.btnResultSave.Name = "btnResultSave";
            this.btnResultSave.TabIndex = 0;
            this.btnResultSave.Values.Text = "保存";
            this.btnResultSave.Click += new System.EventHandler(this.btnResultSave_Click);
            // 
            // kryptonPanel19
            // 
            this.kryptonPanel19.Controls.Add(this.label1);
            this.kryptonPanel19.Controls.Add(this.kryptonLabel61);
            this.kryptonPanel19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel19.Location = new System.Drawing.Point(90, 20);
            this.kryptonPanel19.Margin = new System.Windows.Forms.Padding(0);
            this.kryptonPanel19.Name = "kryptonPanel19";
            this.kryptonPanel19.Size = new System.Drawing.Size(687, 100);
            this.kryptonPanel19.StateCommon.Color1 = System.Drawing.Color.White;
            this.kryptonPanel19.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("仿宋", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(0, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(687, 67);
            this.label1.TabIndex = 2;
            this.label1.Text = "    成果形式包括样品、样机、试验（演示）系统、数据库、软件、仿真模型、工程工艺、标准（规范）、试验方案（报告）、研究报告、论文、专利等。如有其他成果形式，请在" +
    "“其他”标签后面的文本框中输入其他成果形式，用顿号分隔多个其他成果形式。";
            // 
            // kryptonLabel61
            // 
            this.kryptonLabel61.Location = new System.Drawing.Point(3, 3);
            this.kryptonLabel61.Name = "kryptonLabel61";
            this.kryptonLabel61.Size = new System.Drawing.Size(130, 27);
            this.kryptonLabel61.StateCommon.LongText.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.kryptonLabel61.StateCommon.ShortText.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.kryptonLabel61.StateNormal.ShortText.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.kryptonLabel61.TabIndex = 0;
            this.kryptonLabel61.Values.Text = "三、成果形式\r\n";
            // 
            // hSkinTableLayoutPanel1
            // 
            this.hSkinTableLayoutPanel1.BorderColor = System.Drawing.Color.Black;
            this.hSkinTableLayoutPanel1.ColumnCount = 1;
            this.hSkinTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.hSkinTableLayoutPanel1.Controls.Add(this.kryptonPanel1, 0, 0);
            this.hSkinTableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hSkinTableLayoutPanel1.Location = new System.Drawing.Point(93, 123);
            this.hSkinTableLayoutPanel1.Name = "hSkinTableLayoutPanel1";
            this.hSkinTableLayoutPanel1.RowCount = 1;
            this.hSkinTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.hSkinTableLayoutPanel1.Size = new System.Drawing.Size(681, 359);
            this.hSkinTableLayoutPanel1.TabIndex = 4;
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.cbr10);
            this.kryptonPanel1.Controls.Add(this.cbr9);
            this.kryptonPanel1.Controls.Add(this.cbr11);
            this.kryptonPanel1.Controls.Add(this.cbr12);
            this.kryptonPanel1.Controls.Add(this.cbr8);
            this.kryptonPanel1.Controls.Add(this.cbr7);
            this.kryptonPanel1.Controls.Add(this.cbr6);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel1.Controls.Add(this.cbrOthertxt);
            this.kryptonPanel1.Controls.Add(this.cbr5);
            this.kryptonPanel1.Controls.Add(this.cbr3);
            this.kryptonPanel1.Controls.Add(this.cbr4);
            this.kryptonPanel1.Controls.Add(this.cbr2);
            this.kryptonPanel1.Controls.Add(this.cbr1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(3, 3);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(675, 353);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.White;
            this.kryptonPanel1.TabIndex = 0;
            // 
            // cbr10
            // 
            this.cbr10.Location = new System.Drawing.Point(115, 125);
            this.cbr10.Name = "cbr10";
            this.cbr10.Size = new System.Drawing.Size(58, 23);
            this.cbr10.StateCommon.ShortText.Font = new System.Drawing.Font("仿宋", 12F);
            this.cbr10.TabIndex = 14;
            this.cbr10.Values.Text = "专利";
            // 
            // cbr9
            // 
            this.cbr9.Location = new System.Drawing.Point(21, 125);
            this.cbr9.Name = "cbr9";
            this.cbr9.Size = new System.Drawing.Size(58, 23);
            this.cbr9.StateCommon.ShortText.Font = new System.Drawing.Font("仿宋", 12F);
            this.cbr9.TabIndex = 13;
            this.cbr9.Values.Text = "论文";
            // 
            // cbr11
            // 
            this.cbr11.Location = new System.Drawing.Point(228, 125);
            this.cbr11.Name = "cbr11";
            this.cbr11.Size = new System.Drawing.Size(91, 23);
            this.cbr11.StateCommon.ShortText.Font = new System.Drawing.Font("仿宋", 12F);
            this.cbr11.TabIndex = 12;
            this.cbr11.Values.Text = "研究报告";
            // 
            // cbr12
            // 
            this.cbr12.Location = new System.Drawing.Point(350, 125);
            this.cbr12.Name = "cbr12";
            this.cbr12.Size = new System.Drawing.Size(157, 23);
            this.cbr12.StateCommon.ShortText.Font = new System.Drawing.Font("仿宋", 12F);
            this.cbr12.TabIndex = 11;
            this.cbr12.Values.Text = "试验方案（报告）";
            // 
            // cbr8
            // 
            this.cbr8.Location = new System.Drawing.Point(350, 69);
            this.cbr8.Name = "cbr8";
            this.cbr8.Size = new System.Drawing.Size(124, 23);
            this.cbr8.StateCommon.ShortText.Font = new System.Drawing.Font("仿宋", 12F);
            this.cbr8.TabIndex = 10;
            this.cbr8.Values.Text = "标准（规范）";
            // 
            // cbr7
            // 
            this.cbr7.Location = new System.Drawing.Point(228, 69);
            this.cbr7.Name = "cbr7";
            this.cbr7.Size = new System.Drawing.Size(91, 23);
            this.cbr7.StateCommon.ShortText.Font = new System.Drawing.Font("仿宋", 12F);
            this.cbr7.TabIndex = 9;
            this.cbr7.Values.Text = "工程工艺";
            // 
            // cbr6
            // 
            this.cbr6.Location = new System.Drawing.Point(115, 69);
            this.cbr6.Name = "cbr6";
            this.cbr6.Size = new System.Drawing.Size(91, 23);
            this.cbr6.StateCommon.ShortText.Font = new System.Drawing.Font("仿宋", 12F);
            this.cbr6.TabIndex = 8;
            this.cbr6.Values.Text = "仿真模型";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(21, 186);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(45, 23);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("仿宋", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.kryptonLabel1.TabIndex = 7;
            this.kryptonLabel1.Values.Text = "其他";
            // 
            // cbrOthertxt
            // 
            this.cbrOthertxt.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny1});
            this.cbrOthertxt.Location = new System.Drawing.Point(101, 186);
            this.cbrOthertxt.Name = "cbrOthertxt";
            this.cbrOthertxt.Size = new System.Drawing.Size(500, 26);
            this.cbrOthertxt.StateCommon.Content.Font = new System.Drawing.Font("仿宋", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbrOthertxt.TabIndex = 6;
            // 
            // cbr5
            // 
            this.cbr5.Location = new System.Drawing.Point(21, 69);
            this.cbr5.Name = "cbr5";
            this.cbr5.Size = new System.Drawing.Size(58, 23);
            this.cbr5.StateCommon.ShortText.Font = new System.Drawing.Font("仿宋", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbr5.TabIndex = 4;
            this.cbr5.Values.Text = "软件";
            // 
            // cbr3
            // 
            this.cbr3.Location = new System.Drawing.Point(228, 18);
            this.cbr3.Name = "cbr3";
            this.cbr3.Size = new System.Drawing.Size(74, 23);
            this.cbr3.StateCommon.ShortText.Font = new System.Drawing.Font("仿宋", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbr3.TabIndex = 3;
            this.cbr3.Values.Text = "数据库";
            // 
            // cbr4
            // 
            this.cbr4.Location = new System.Drawing.Point(350, 18);
            this.cbr4.Name = "cbr4";
            this.cbr4.Size = new System.Drawing.Size(157, 23);
            this.cbr4.StateCommon.ShortText.Font = new System.Drawing.Font("仿宋", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbr4.TabIndex = 2;
            this.cbr4.Values.Text = "试验（演示）系统";
            // 
            // cbr2
            // 
            this.cbr2.Location = new System.Drawing.Point(115, 18);
            this.cbr2.Name = "cbr2";
            this.cbr2.Size = new System.Drawing.Size(58, 23);
            this.cbr2.StateCommon.ShortText.Font = new System.Drawing.Font("仿宋", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbr2.TabIndex = 1;
            this.cbr2.Values.Text = "样机";
            // 
            // cbr1
            // 
            this.cbr1.Location = new System.Drawing.Point(21, 18);
            this.cbr1.Name = "cbr1";
            this.cbr1.Size = new System.Drawing.Size(58, 23);
            this.cbr1.StateCommon.ShortText.Font = new System.Drawing.Font("仿宋", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbr1.TabIndex = 0;
            this.cbr1.Values.Text = "样品";
            // 
            // buttonSpecAny1
            // 
            this.buttonSpecAny1.Image = ((System.Drawing.Image)(resources.GetObject("buttonSpecAny1.Image")));
            this.buttonSpecAny1.Text = "如需填写多项,请用中文顿号隔开";
            this.buttonSpecAny1.UniqueName = "73A1BB30E5374ED8C69042CC95520922";
            // 
            // frmresultInfo
            // 
            this.Controls.Add(this.tableLayoutPanel4);
            this.Name = "frmresultInfo";
            this.Size = new System.Drawing.Size(867, 545);
            this.Leave += new System.EventHandler(this.frmresultInfo_Leave);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel28.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel19)).EndInit();
            this.kryptonPanel19.ResumeLayout(false);
            this.kryptonPanel19.PerformLayout();
            this.hSkinTableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.ResumeLayout(false);

		}

		public frmResultInfo()
		{
			this.InitializeComponent();
		}

		protected override void OnLoad(EventArgs e)
		{
			this.RefreshCall();
			base.OnLoad(e);
		}

		private void SaveProgress()
		{
			ResultFormInfo resultFormInfo = new ResultFormInfo();
			resultFormInfo.IsCBR1Checked = this.cbr1.Checked;
			resultFormInfo.IsCBR2Checked = this.cbr2.Checked;
			resultFormInfo.IsCBR3Checked = this.cbr3.Checked;
			resultFormInfo.IsCBR4Checked = this.cbr4.Checked;
			resultFormInfo.IsCBR5Checked = this.cbr5.Checked;
			resultFormInfo.IsCBR6Checked = this.cbr6.Checked;
			resultFormInfo.IsCBR7Checked = this.cbr7.Checked;
			resultFormInfo.IsCBR8Checked = this.cbr8.Checked;
			resultFormInfo.IsCBR9Checked = this.cbr9.Checked;
			resultFormInfo.IsCBR10Checked = this.cbr10.Checked;
			resultFormInfo.IsCBR11Checked = this.cbr11.Checked;
			resultFormInfo.IsCBR12Checked = this.cbr12.Checked;
			resultFormInfo.CBROtherText = this.cbrOthertxt.Text;
			this._resultFormInfoService.UpdateResultFormInfo(resultFormInfo);
		}

		public override void RefreshCall()
		{
			ResultFormInfo resultFormInfo = this._resultFormInfoService.GetResultFormInfo();
			if (resultFormInfo != null)
			{
				this.cbr1.Checked = resultFormInfo.IsCBR1Checked;
				this.cbr2.Checked = resultFormInfo.IsCBR2Checked;
				this.cbr3.Checked = resultFormInfo.IsCBR3Checked;
				this.cbr4.Checked = resultFormInfo.IsCBR4Checked;
				this.cbr5.Checked = resultFormInfo.IsCBR5Checked;
				this.cbr6.Checked = resultFormInfo.IsCBR6Checked;
				this.cbr7.Checked = resultFormInfo.IsCBR7Checked;
				this.cbr8.Checked = resultFormInfo.IsCBR8Checked;
				this.cbr9.Checked = resultFormInfo.IsCBR9Checked;
				this.cbr10.Checked = resultFormInfo.IsCBR10Checked;
				this.cbr11.Checked = resultFormInfo.IsCBR11Checked;
				this.cbr12.Checked = resultFormInfo.IsCBR12Checked;
				this.cbrOthertxt.Text = resultFormInfo.CBROtherText;
			}
		}

		private void frmresultInfo_Leave(object sender, EventArgs e)
		{
			if (this.issaved)
			{
				this.issaved = false;
				return;
			}
			this.SaveProgress();
		}

		private void btnResultSave_Click(object sender, EventArgs e)
		{
			this.SaveProgress();
			this.issaved = true;
			KryptonNavigator kryptonNavigator = (KryptonNavigator)base.Parent.Parent.Parent;
			kryptonNavigator.SelectedIndex++;
			kryptonNavigator.SelectedPage.Enabled = true;
		}
	}
}