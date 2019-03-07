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
	public class frmResearchPlanInfo : BaseControl
	{
		private IContainer components;

		private TableLayoutPanel tableLayoutPanel5;

		private KryptonPanel kryptonPanel20;

		private TableLayoutPanel tableLayoutPanel28;

		private KryptonButton btnResearchPlanSave;

		private KryptonLabel kryptonLabel1;

		private Label label1;

		private RichTextBoxTableClass rtfResearchPlan;

		private HSkinTableLayoutPanel hSkinTableLayoutPanel1;

		private string rtfFile = Path.Combine(EntityElement.UserPath, "Files\\主要研究.rtf");

		private bool issaved;

		private frmLoading loading;

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
			this.tableLayoutPanel5 = new TableLayoutPanel();
			this.tableLayoutPanel28 = new TableLayoutPanel();
			this.btnResearchPlanSave = new KryptonButton();
			this.kryptonPanel20 = new KryptonPanel();
			this.label1 = new Label();
			this.kryptonLabel1 = new KryptonLabel();
			this.hSkinTableLayoutPanel1 = new HSkinTableLayoutPanel();
			this.rtfResearchPlan = new RichTextBoxTableClass();
			this.tableLayoutPanel5.SuspendLayout();
			this.tableLayoutPanel28.SuspendLayout();
			((ISupportInitialize)this.kryptonPanel20).BeginInit();
			this.kryptonPanel20.SuspendLayout();
			this.hSkinTableLayoutPanel1.SuspendLayout();
			base.SuspendLayout();
			this.tableLayoutPanel5.ColumnCount = 3;
			this.tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90f));
			this.tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90f));
			this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel28, 1, 3);
			this.tableLayoutPanel5.Controls.Add(this.kryptonPanel20, 1, 1);
			this.tableLayoutPanel5.Controls.Add(this.hSkinTableLayoutPanel1, 1, 2);
			this.tableLayoutPanel5.Dock = DockStyle.Fill;
			this.tableLayoutPanel5.Location = new Point(0, 0);
			this.tableLayoutPanel5.Name = "tableLayoutPanel5";
			this.tableLayoutPanel5.RowCount = 5;
			this.tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20f));
			this.tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 100f));
			this.tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 40f));
			this.tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20f));
			this.tableLayoutPanel5.Size = new Size(917, 541);
			this.tableLayoutPanel5.TabIndex = 2;
			this.tableLayoutPanel28.ColumnCount = 2;
			this.tableLayoutPanel28.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel28.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120f));
			this.tableLayoutPanel28.Controls.Add(this.btnResearchPlanSave, 1, 0);
			this.tableLayoutPanel28.Dock = DockStyle.Fill;
			this.tableLayoutPanel28.Location = new Point(93, 484);
			this.tableLayoutPanel28.Name = "tableLayoutPanel28";
			this.tableLayoutPanel28.RowCount = 1;
			this.tableLayoutPanel28.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel28.Size = new Size(731, 34);
			this.tableLayoutPanel28.TabIndex = 3;
			this.btnResearchPlanSave.Location = new Point(614, 3);
			this.btnResearchPlanSave.Name = "btnResearchPlanSave";
			this.btnResearchPlanSave.Size = new Size(90, 25);
			this.btnResearchPlanSave.TabIndex = 0;
			this.btnResearchPlanSave.Values.Text = "保存";
			this.btnResearchPlanSave.Click += new EventHandler(this.btnResearchPlanSave_Click);
			this.kryptonPanel20.Controls.Add(this.label1);
			this.kryptonPanel20.Controls.Add(this.kryptonLabel1);
			this.kryptonPanel20.Dock = DockStyle.Fill;
			this.kryptonPanel20.Location = new Point(90, 20);
			this.kryptonPanel20.Margin = new Padding(0);
			this.kryptonPanel20.Name = "kryptonPanel20";
			this.kryptonPanel20.Size = new Size(737, 100);
			this.kryptonPanel20.StateCommon.Color1 = Color.White;
			this.kryptonPanel20.TabIndex = 0;
			this.label1.BackColor = Color.White;
			this.label1.Dock = DockStyle.Bottom;
			this.label1.Font = new Font("FangSong_GB2312", 12f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.label1.Location = new Point(0, 33);
			this.label1.Name = "label1";
			this.label1.Size = new Size(737, 67);
			this.label1.TabIndex = 2;
			this.label1.Text = "    着重阐述拟开展的研究工作的背景（科学价值、军事意义、国内外研究现状等），总体思路和研究目标，主要研究内容和初步研究方案等，请简要阐述。\r\n    体例结构可自行组织。\r\n    正文要求：仿宋小四号字，行间距24磅，支持从Word粘贴。";
			this.kryptonLabel1.Location = new Point(1, 3);
			this.kryptonLabel1.Name = "kryptonLabel1";
			this.kryptonLabel1.Size = new Size(314, 27);
			this.kryptonLabel1.StateCommon.LongText.Font = new Font("KaiTi_GB2312", 12f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.kryptonLabel1.StateCommon.ShortText.Font = new Font("SimHei", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.kryptonLabel1.TabIndex = 1;
			this.kryptonLabel1.Values.ExtraText = "（2000字内）";
			this.kryptonLabel1.Values.Text = "二、拟开展的研究工作";
			this.hSkinTableLayoutPanel1.BorderColor = Color.Black;
			this.hSkinTableLayoutPanel1.ColumnCount = 1;
			this.hSkinTableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
			this.hSkinTableLayoutPanel1.Controls.Add(this.rtfResearchPlan, 0, 0);
			this.hSkinTableLayoutPanel1.Dock = DockStyle.Fill;
			this.hSkinTableLayoutPanel1.Location = new Point(93, 123);
			this.hSkinTableLayoutPanel1.Name = "hSkinTableLayoutPanel1";
			this.hSkinTableLayoutPanel1.RowCount = 1;
			this.hSkinTableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50f));
			this.hSkinTableLayoutPanel1.Size = new Size(731, 355);
			this.hSkinTableLayoutPanel1.TabIndex = 5;
            //this.rtfResearchPlan.BorderStyle = BorderStyle.None;
			this.rtfResearchPlan.Dock = DockStyle.Fill;
			this.rtfResearchPlan.Font = new Font("FangSong_GB2312", 12f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.rtfResearchPlan.Location = new Point(1, 1);
			this.rtfResearchPlan.Margin = new Padding(1);
			this.rtfResearchPlan.Name = "rtfResearchPlan";
			this.rtfResearchPlan.Size = new Size(729, 353);
			this.rtfResearchPlan.TabIndex = 4;
			this.rtfResearchPlan.Text = "";
			this.rtfResearchPlan.TextChanged += new EventHandler(this.rtfResearchPlan_TextChanged);
			this.rtfResearchPlan.KeyDown += new KeyEventHandler(this.rtfResearchPlan_KeyDown);
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			//base.AutoScaleMode = AutoScaleMode.Font;
			base.Controls.Add(this.tableLayoutPanel5);
			base.Name = "frmResearchPlanInfo";
			base.Size = new Size(917, 541);
			base.Leave += new EventHandler(this.frmResearchPlanInfo_Leave);
			this.tableLayoutPanel5.ResumeLayout(false);
			this.tableLayoutPanel28.ResumeLayout(false);
			((ISupportInitialize)this.kryptonPanel20).EndInit();
			this.kryptonPanel20.ResumeLayout(false);
			this.kryptonPanel20.PerformLayout();
			this.hSkinTableLayoutPanel1.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		public frmResearchPlanInfo()
		{
			this.InitializeComponent();
		}

		protected override void OnLoad(EventArgs e)
		{
			this.RefreshCall();
			base.OnLoad(e);
		}

		private bool CanSave()
		{
			this.OnSaveCheckDenyEvent(EventArgs.Empty);
			if (this.rtfResearchPlan.Text.Length > 4000)
			{
				MessageBox.Show("内容超长，请精简内容！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return false;
			}
			this.OnSaveCheckPassedEvent(EventArgs.Empty);
			return true;
		}

		private void btnResearchPlanSave_Click(object sender, EventArgs e)
		{
			if (!this.CanSave())
			{
				return;
			}
			this.rtfResearchPlan.SaveFile(this.rtfFile);
			this.issaved = true;
			KryptonNavigator kryptonNavigator = (KryptonNavigator)base.Parent.Parent.Parent;
			kryptonNavigator.SelectedIndex++;
			kryptonNavigator.SelectedPage.Enabled = true;
		}

		public override void RefreshCall()
		{
			if (File.Exists(this.rtfFile))
			{
				this.rtfResearchPlan.LoadFile(this.rtfFile);
				return;
			}
			this.rtfResearchPlan.Clear();
		}

		private void frmResearchPlanInfo_Leave(object sender, EventArgs e)
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
			this.rtfResearchPlan.SaveFile(this.rtfFile);
		}

		private void rtfResearchPlan_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.Control && e.KeyCode == Keys.V)
			{
				e.Handled = true;
				this.loading = new frmLoading();
				this.loading.TopMost = true;
				Point point = this.rtfResearchPlan.PointToScreen(base.FindForm().Location);
				this.loading.Location = new Point(point.X + (this.rtfResearchPlan.Width - this.loading.Width) / 2, point.Y + (this.rtfResearchPlan.Height - this.loading.Height) / 2);
				this.loading.Show();
				IDataObject obj = Clipboard.GetDataObject();
				BaseControl.AsyncDelegate del = delegate
				{
					object data = obj.GetData("Rich Text Format");
					if (data != null)
					{
						BaseControl.MethodInvoker uiDelegate = delegate
						{
							this.rtfResearchPlan.SelectedRtf = (string)data;
							data = null;
						};
						this.UpdateUI(uiDelegate, this);
						return;
					}
					BaseControl.MethodInvoker uiDelegate2 = delegate
					{
						this.rtfResearchPlan.Paste();
					};
					this.UpdateUI(uiDelegate2, this);
				};
				base.BeginInvoke(del);
			}
		}

		private void rtfResearchPlan_TextChanged(object sender, EventArgs e)
		{
			if (this.loading != null)
			{
				this.loading.Close();
				this.loading = null;
			}
		}
	}
}
