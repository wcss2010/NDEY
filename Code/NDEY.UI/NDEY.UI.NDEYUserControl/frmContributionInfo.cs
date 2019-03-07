using ComponentFactory.Krypton.Navigator;
using ComponentFactory.Krypton.Toolkit;
using NDEY.BLL.Entity;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace NDEY.UI.NDEYUserControl
{
	public class frmContributionInfo : BaseControl
	{
		private string rtfFile = Path.Combine(EntityElement.UserPath, "Files\\军事意义.rtf");

		private bool issaved;

		private frmLoading loading;

		private IContainer components;

		private TableLayoutPanel tableLayoutPanel4;

		private TableLayoutPanel tableLayoutPanel28;

		private KryptonButton btnContributionSave;

		private KryptonPanel kryptonPanel19;

		private KryptonLabel kryptonLabel61;

		private Label label1;

		private RichTextBoxTableClass rtfContribution;

		private HSkinTableLayoutPanel hSkinTableLayoutPanel1;

		public frmContributionInfo()
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
		}

		private bool CanSave()
		{
			this.OnSaveCheckDenyEvent(EventArgs.Empty);
			if (this.rtfContribution.Text.Length > 5000)
			{
				MessageBox.Show("内容超长,请精简内容！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return false;
			}
			this.OnSaveCheckPassedEvent(EventArgs.Empty);
			return true;
		}

		private void btnContributionSave_Click(object sender, EventArgs e)
		{
			if (!this.CanSave())
			{
				return;
			}
			this.rtfContribution.SaveFile(this.rtfFile);
			this.issaved = true;
			KryptonNavigator kryptonNavigator = (KryptonNavigator)base.Parent.Parent.Parent;
			kryptonNavigator.SelectedIndex++;
			kryptonNavigator.SelectedPage.Enabled = true;
		}

		public override void RefreshCall()
		{
			if (File.Exists(this.rtfFile))
			{
				this.rtfContribution.LoadFile(this.rtfFile);
				return;
			}
			this.rtfContribution.Clear();
		}

		private void frmContributionInfo_Leave(object sender, EventArgs e)
		{
			if (this.issaved)
			{
				this.issaved = false;
				return;
			}
			if (!this.CanSave())
			{
				return;
			}
			this.rtfContribution.SaveFile(this.rtfFile);
		}

		private void rtfContribution_TextChanged(object sender, EventArgs e)
		{
			if (this.loading != null)
			{
				this.loading.Close();
				this.loading = null;
			}
		}

		private void rtfContribution_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.Control && e.KeyCode == Keys.V)
			{
				e.Handled = true;
				this.loading = new frmLoading();
				this.loading.TopMost = true;
				Point point = this.rtfContribution.PointToScreen(base.FindForm().Location);
				this.loading.Location = new Point(point.X + (this.rtfContribution.Width - this.loading.Width) / 2, point.Y + (this.rtfContribution.Height - this.loading.Height) / 2);
				this.loading.Show();
				IDataObject obj = Clipboard.GetDataObject();
				BaseControl.AsyncDelegate del = delegate
				{
					object data = obj.GetData("Rich Text Format");
					if (data != null)
					{
						BaseControl.MethodInvoker uiDelegate = delegate
						{
							this.rtfContribution.SelectedRtf = (string)data;
							data = null;
						};
						this.UpdateUI(uiDelegate, this);
						return;
					}
					BaseControl.MethodInvoker uiDelegate2 = delegate
					{
						this.rtfContribution.Paste();
					};
					this.UpdateUI(uiDelegate2, this);
				};
				base.BeginInvoke(del);
			}
		}

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
			this.btnContributionSave = new KryptonButton();
			this.kryptonPanel19 = new KryptonPanel();
			this.label1 = new Label();
			this.kryptonLabel61 = new KryptonLabel();
			this.hSkinTableLayoutPanel1 = new HSkinTableLayoutPanel();
			this.rtfContribution = new RichTextBoxTableClass();
			this.tableLayoutPanel4.SuspendLayout();
			this.tableLayoutPanel28.SuspendLayout();
			((ISupportInitialize)this.kryptonPanel19).BeginInit();
			this.kryptonPanel19.SuspendLayout();
			this.hSkinTableLayoutPanel1.SuspendLayout();
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
			this.tableLayoutPanel28.Controls.Add(this.btnContributionSave, 1, 0);
			this.tableLayoutPanel28.Dock = DockStyle.Fill;
			this.tableLayoutPanel28.Location = new Point(93, 488);
			this.tableLayoutPanel28.Name = "tableLayoutPanel28";
			this.tableLayoutPanel28.RowCount = 1;
			this.tableLayoutPanel28.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel28.Size = new Size(681, 34);
			this.tableLayoutPanel28.TabIndex = 2;
			this.btnContributionSave.Location = new Point(564, 3);
			this.btnContributionSave.Name = "btnContributionSave";
			this.btnContributionSave.Size = new Size(90, 25);
			this.btnContributionSave.TabIndex = 0;
			this.btnContributionSave.Values.Text = "保存";
			this.btnContributionSave.Click += new EventHandler(this.btnContributionSave_Click);
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
			this.label1.Text = "    着重阐述近5年来在国防科技领域的主要成绩和突出贡献，包括在基础研究、技术攻关、工程和型号任务中取得的成绩和代表性成果，产生的影响以及转化应用取得的军事效益。\r\n    体例结构可自行组织。\r\n    正文要求：仿宋小四号字，行间距24磅，支持从Word粘贴。";
			this.kryptonLabel61.Location = new Point(3, 3);
			this.kryptonLabel61.Name = "kryptonLabel61";
			this.kryptonLabel61.Size = new Size(334, 27);
			this.kryptonLabel61.StateCommon.LongText.Font = new Font("KaiTi_GB2312", 12f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.kryptonLabel61.StateCommon.ShortText.Font = new Font("SimSun", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.kryptonLabel61.StateNormal.ShortText.Font = new Font("SimHei", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.kryptonLabel61.TabIndex = 0;
			this.kryptonLabel61.Values.ExtraText = "（3000字内）";
			this.kryptonLabel61.Values.Text = "一、主要成绩和突出贡献\r\n";
			this.hSkinTableLayoutPanel1.BorderColor = Color.Black;
			this.hSkinTableLayoutPanel1.ColumnCount = 1;
			this.hSkinTableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
			this.hSkinTableLayoutPanel1.Controls.Add(this.rtfContribution, 0, 0);
			this.hSkinTableLayoutPanel1.Dock = DockStyle.Fill;
			this.hSkinTableLayoutPanel1.Location = new Point(93, 123);
			this.hSkinTableLayoutPanel1.Name = "hSkinTableLayoutPanel1";
			this.hSkinTableLayoutPanel1.RowCount = 1;
			this.hSkinTableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50f));
			this.hSkinTableLayoutPanel1.Size = new Size(681, 359);
			this.hSkinTableLayoutPanel1.TabIndex = 4;
            //this.rtfContribution.BorderStyle = BorderStyle.None;
			this.rtfContribution.Dock = DockStyle.Fill;
			this.rtfContribution.Font = new Font("FangSong_GB2312", 12f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.rtfContribution.Location = new Point(1, 1);
			this.rtfContribution.Margin = new Padding(1);
			this.rtfContribution.Name = "rtfContribution";
			this.rtfContribution.Size = new Size(679, 357);
			this.rtfContribution.TabIndex = 3;
			this.rtfContribution.Text = "";
			this.rtfContribution.TextChanged += new EventHandler(this.rtfContribution_TextChanged);
			this.rtfContribution.KeyDown += new KeyEventHandler(this.rtfContribution_KeyDown);
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			//base.AutoScaleMode = AutoScaleMode.Font;
			base.Controls.Add(this.tableLayoutPanel4);
			base.Name = "frmContributionInfo";
			base.Size = new Size(867, 545);
			base.Leave += new EventHandler(this.frmContributionInfo_Leave);
			this.tableLayoutPanel4.ResumeLayout(false);
			this.tableLayoutPanel28.ResumeLayout(false);
			((ISupportInitialize)this.kryptonPanel19).EndInit();
			this.kryptonPanel19.ResumeLayout(false);
			this.kryptonPanel19.PerformLayout();
			this.hSkinTableLayoutPanel1.ResumeLayout(false);
			base.ResumeLayout(false);
		}
	}
}
