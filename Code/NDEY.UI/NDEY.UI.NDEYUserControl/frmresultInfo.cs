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
	public class frmresultInfo : BaseControl
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
			this.tableLayoutPanel4 = new TableLayoutPanel();
			this.tableLayoutPanel28 = new TableLayoutPanel();
			this.btnResultSave = new KryptonButton();
			this.kryptonPanel19 = new KryptonPanel();
			this.label1 = new Label();
			this.kryptonLabel61 = new KryptonLabel();
			this.hSkinTableLayoutPanel1 = new HSkinTableLayoutPanel();
			this.kryptonPanel1 = new KryptonPanel();
			this.kryptonLabel1 = new KryptonLabel();
			this.cbrOthertxt = new KryptonTextBox();
			this.cbr5 = new KryptonCheckBox();
			this.cbr3 = new KryptonCheckBox();
			this.cbr4 = new KryptonCheckBox();
			this.cbr2 = new KryptonCheckBox();
			this.cbr1 = new KryptonCheckBox();
			this.cbr6 = new KryptonCheckBox();
			this.cbr7 = new KryptonCheckBox();
			this.cbr8 = new KryptonCheckBox();
			this.cbr12 = new KryptonCheckBox();
			this.cbr11 = new KryptonCheckBox();
			this.cbr9 = new KryptonCheckBox();
			this.cbr10 = new KryptonCheckBox();
			this.tableLayoutPanel4.SuspendLayout();
			this.tableLayoutPanel28.SuspendLayout();
			((ISupportInitialize)this.kryptonPanel19).BeginInit();
			this.kryptonPanel19.SuspendLayout();
			this.hSkinTableLayoutPanel1.SuspendLayout();
			((ISupportInitialize)this.kryptonPanel1).BeginInit();
			this.kryptonPanel1.SuspendLayout();
			base.SuspendLayout();
			this.tableLayoutPanel4.ColumnCount = 3;
			this.tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90f));
			this.tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90f));
			this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel28, 1, 3);
			this.tableLayoutPanel4.Controls.Add(this.kryptonPanel19, 1, 1);
			this.tableLayoutPanel4.Controls.Add(this.hSkinTableLayoutPanel1, 1, 2);
			this.tableLayoutPanel4.Dock = DockStyle.Fill;
			this.tableLayoutPanel4.Location = new Point(0, 0);
			this.tableLayoutPanel4.Name = "tableLayoutPanel4";
			this.tableLayoutPanel4.RowCount = 5;
			this.tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20f));
			this.tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 100f));
			this.tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 40f));
			this.tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20f));
			this.tableLayoutPanel4.Size = new Size(867, 545);
			this.tableLayoutPanel4.TabIndex = 1;
			this.tableLayoutPanel28.ColumnCount = 2;
			this.tableLayoutPanel28.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel28.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120f));
			this.tableLayoutPanel28.Controls.Add(this.btnResultSave, 1, 0);
			this.tableLayoutPanel28.Dock = DockStyle.Fill;
			this.tableLayoutPanel28.Location = new Point(93, 488);
			this.tableLayoutPanel28.Name = "tableLayoutPanel28";
			this.tableLayoutPanel28.RowCount = 1;
			this.tableLayoutPanel28.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel28.Size = new Size(681, 34);
			this.tableLayoutPanel28.TabIndex = 2;
			this.btnResultSave.Location = new Point(564, 3);
			this.btnResultSave.Name = "btnResultSave";
			this.btnResultSave.Size = new Size(90, 25);
			this.btnResultSave.TabIndex = 0;
			this.btnResultSave.Values.Text = "保存";
			this.btnResultSave.Click += new EventHandler(this.btnResultSave_Click);
			this.kryptonPanel19.Controls.Add(this.label1);
			this.kryptonPanel19.Controls.Add(this.kryptonLabel61);
			this.kryptonPanel19.Dock = DockStyle.Fill;
			this.kryptonPanel19.Location = new Point(90, 20);
			this.kryptonPanel19.Margin = new Padding(0);
			this.kryptonPanel19.Name = "kryptonPanel19";
			this.kryptonPanel19.Size = new Size(687, 100);
			this.kryptonPanel19.StateCommon.Color1 = Color.White;
			this.kryptonPanel19.TabIndex = 0;
			this.label1.BackColor = Color.White;
			this.label1.Dock = DockStyle.Bottom;
			this.label1.Font = new Font("FangSong_GB2312", 12f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.label1.Location = new Point(0, 33);
			this.label1.Name = "label1";
			this.label1.Size = new Size(687, 67);
			this.label1.TabIndex = 2;
			this.label1.Text = "    成果形式包括样品、样机、试验（演示）系统、数据库、软件、仿真模型、工程工艺、标准（规范）、试验方案（报告）、研究报告、论文、专利等。如有其他成果形式，请在“其他”标签后面的文本框中输入其他成果形式，用顿号分隔多个其他成果形式。";
			this.kryptonLabel61.Location = new Point(3, 3);
			this.kryptonLabel61.Name = "kryptonLabel61";
			this.kryptonLabel61.Size = new Size(130, 27);
			this.kryptonLabel61.StateCommon.LongText.Font = new Font("KaiTi_GB2312", 12f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.kryptonLabel61.StateCommon.ShortText.Font = new Font("SimSun", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.kryptonLabel61.StateNormal.ShortText.Font = new Font("SimHei", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.kryptonLabel61.TabIndex = 0;
			this.kryptonLabel61.Values.Text = "三、成果形式\r\n";
			this.hSkinTableLayoutPanel1.BorderColor = Color.Black;
			this.hSkinTableLayoutPanel1.ColumnCount = 1;
			this.hSkinTableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
			this.hSkinTableLayoutPanel1.Controls.Add(this.kryptonPanel1, 0, 0);
			this.hSkinTableLayoutPanel1.Dock = DockStyle.Fill;
			this.hSkinTableLayoutPanel1.Location = new Point(93, 123);
			this.hSkinTableLayoutPanel1.Name = "hSkinTableLayoutPanel1";
			this.hSkinTableLayoutPanel1.RowCount = 1;
			this.hSkinTableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50f));
			this.hSkinTableLayoutPanel1.Size = new Size(681, 359);
			this.hSkinTableLayoutPanel1.TabIndex = 4;
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
			this.kryptonPanel1.Dock = DockStyle.Fill;
			this.kryptonPanel1.Location = new Point(3, 3);
			this.kryptonPanel1.Name = "kryptonPanel1";
			this.kryptonPanel1.Size = new Size(675, 353);
			this.kryptonPanel1.StateCommon.Color1 = Color.White;
			this.kryptonPanel1.TabIndex = 0;
			this.kryptonLabel1.Location = new Point(21, 186);
			this.kryptonLabel1.Name = "kryptonLabel1";
			this.kryptonLabel1.Size = new Size(45, 23);
			this.kryptonLabel1.StateCommon.ShortText.Font = new Font("FangSong_GB2312", 12f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.kryptonLabel1.TabIndex = 7;
			this.kryptonLabel1.Values.Text = "其他";
			this.cbrOthertxt.Location = new Point(101, 186);
			this.cbrOthertxt.Name = "cbrOthertxt";
			this.cbrOthertxt.Size = new Size(326, 23);
			this.cbrOthertxt.StateCommon.Content.Font = new Font("FangSong_GB2312", 12f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.cbrOthertxt.TabIndex = 6;
			this.cbr5.Location = new Point(21, 69);
			this.cbr5.Name = "cbr5";
			this.cbr5.Size = new Size(58, 23);
			this.cbr5.StateCommon.ShortText.Font = new Font("FangSong_GB2312", 12f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.cbr5.TabIndex = 4;
			this.cbr5.Values.Text = "软件";
			this.cbr3.Location = new Point(228, 18);
			this.cbr3.Name = "cbr3";
			this.cbr3.Size = new Size(74, 23);
			this.cbr3.StateCommon.ShortText.Font = new Font("FangSong_GB2312", 12f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.cbr3.TabIndex = 3;
			this.cbr3.Values.Text = "数据库";
			this.cbr4.Location = new Point(350, 18);
			this.cbr4.Name = "cbr4";
			this.cbr4.Size = new Size(157, 23);
			this.cbr4.StateCommon.ShortText.Font = new Font("FangSong_GB2312", 12f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.cbr4.TabIndex = 2;
			this.cbr4.Values.Text = "试验（演示）系统";
			this.cbr2.Location = new Point(115, 18);
			this.cbr2.Name = "cbr2";
			this.cbr2.Size = new Size(58, 23);
			this.cbr2.StateCommon.ShortText.Font = new Font("FangSong_GB2312", 12f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.cbr2.TabIndex = 1;
			this.cbr2.Values.Text = "样机";
			this.cbr1.Location = new Point(21, 18);
			this.cbr1.Name = "cbr1";
			this.cbr1.Size = new Size(58, 23);
			this.cbr1.StateCommon.ShortText.Font = new Font("FangSong_GB2312", 12f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.cbr1.TabIndex = 0;
			this.cbr1.Values.Text = "样品";
			this.cbr6.Location = new Point(115, 69);
			this.cbr6.Name = "cbr6";
			this.cbr6.Size = new Size(91, 23);
			this.cbr6.StateCommon.ShortText.Font = new Font("FangSong_GB2312", 12f);
			this.cbr6.TabIndex = 8;
			this.cbr6.Values.Text = "仿真模型";
			this.cbr7.Location = new Point(228, 69);
			this.cbr7.Name = "cbr7";
			this.cbr7.Size = new Size(91, 23);
			this.cbr7.StateCommon.ShortText.Font = new Font("FangSong_GB2312", 12f);
			this.cbr7.TabIndex = 9;
			this.cbr7.Values.Text = "工程工艺";
			this.cbr8.Location = new Point(350, 69);
			this.cbr8.Name = "cbr8";
			this.cbr8.Size = new Size(124, 23);
			this.cbr8.StateCommon.ShortText.Font = new Font("FangSong_GB2312", 12f);
			this.cbr8.TabIndex = 10;
			this.cbr8.Values.Text = "标准（规范）";
			this.cbr12.Location = new Point(350, 125);
			this.cbr12.Name = "cbr12";
			this.cbr12.Size = new Size(157, 23);
			this.cbr12.StateCommon.ShortText.Font = new Font("FangSong_GB2312", 12f);
			this.cbr12.TabIndex = 11;
			this.cbr12.Values.Text = "试验方案（报告）";
			this.cbr11.Location = new Point(228, 125);
			this.cbr11.Name = "cbr11";
			this.cbr11.Size = new Size(91, 23);
			this.cbr11.StateCommon.ShortText.Font = new Font("FangSong_GB2312", 12f);
			this.cbr11.TabIndex = 12;
			this.cbr11.Values.Text = "研究报告";
			this.cbr9.Location = new Point(21, 125);
			this.cbr9.Name = "cbr9";
			this.cbr9.Size = new Size(58, 23);
			this.cbr9.StateCommon.ShortText.Font = new Font("FangSong_GB2312", 12f);
			this.cbr9.TabIndex = 13;
			this.cbr9.Values.Text = "论文";
			this.cbr10.Location = new Point(115, 125);
			this.cbr10.Name = "cbr10";
			this.cbr10.Size = new Size(58, 23);
			this.cbr10.StateCommon.ShortText.Font = new Font("FangSong_GB2312", 12f);
			this.cbr10.TabIndex = 14;
			this.cbr10.Values.Text = "专利";
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			//base.AutoScaleMode = AutoScaleMode.Font;
			base.Controls.Add(this.tableLayoutPanel4);
			base.Name = "frmresultInfo";
			base.Size = new Size(867, 545);
			base.Leave += new EventHandler(this.frmresultInfo_Leave);
			this.tableLayoutPanel4.ResumeLayout(false);
			this.tableLayoutPanel28.ResumeLayout(false);
			((ISupportInitialize)this.kryptonPanel19).EndInit();
			this.kryptonPanel19.ResumeLayout(false);
			this.kryptonPanel19.PerformLayout();
			this.hSkinTableLayoutPanel1.ResumeLayout(false);
			((ISupportInitialize)this.kryptonPanel1).EndInit();
			this.kryptonPanel1.ResumeLayout(false);
			this.kryptonPanel1.PerformLayout();
			base.ResumeLayout(false);
		}

		public frmresultInfo()
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
			resultFormInfo.IsCBR3Checked = this.cbr4.Checked;
			resultFormInfo.IsCBR4Checked = this.cbr3.Checked;
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
				this.cbr4.Checked = resultFormInfo.IsCBR3Checked;
				this.cbr3.Checked = resultFormInfo.IsCBR4Checked;
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
