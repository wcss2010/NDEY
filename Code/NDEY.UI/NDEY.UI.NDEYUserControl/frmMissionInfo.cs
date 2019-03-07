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
	public class frmMissionInfo : BaseControl
	{
		private IContainer components;

		private TableLayoutPanel tableLayoutPanel4;

		private TableLayoutPanel tableLayoutPanel28;

		private KryptonButton btnmissionSave;

		private KryptonPanel kryptonPanel19;

		private KryptonLabel kryptonLabel61;

		private Label label1;

		private RichTextBoxTableClass rtfmission;

		private HSkinTableLayoutPanel hSkinTableLayoutPanel1;

		private string rtfFile = Path.Combine(EntityElement.UserPath, "Files\\第一年研究任务.rtf");

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
			this.tableLayoutPanel4 = new TableLayoutPanel();
			this.tableLayoutPanel28 = new TableLayoutPanel();
			this.btnmissionSave = new KryptonButton();
			this.kryptonPanel19 = new KryptonPanel();
			this.label1 = new Label();
			this.kryptonLabel61 = new KryptonLabel();
			this.hSkinTableLayoutPanel1 = new HSkinTableLayoutPanel();
			this.rtfmission = new RichTextBoxTableClass();
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
			this.tableLayoutPanel28.Controls.Add(this.btnmissionSave, 1, 0);
			this.tableLayoutPanel28.Dock = DockStyle.Fill;
			this.tableLayoutPanel28.Location = new Point(93, 488);
			this.tableLayoutPanel28.Name = "tableLayoutPanel28";
			this.tableLayoutPanel28.RowCount = 1;
			this.tableLayoutPanel28.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel28.Size = new Size(681, 34);
			this.tableLayoutPanel28.TabIndex = 2;
			this.btnmissionSave.Location = new Point(564, 3);
			this.btnmissionSave.Name = "btnmissionSave";
			this.btnmissionSave.Size = new Size(90, 25);
			this.btnmissionSave.TabIndex = 0;
			this.btnmissionSave.Values.Text = "保存";
			this.btnmissionSave.Click += new EventHandler(this.btnmissionSave_Click);
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
			this.label1.Text = "    阐述第一年研究任务。\r\n    体例结构可自行组织。\r\n    正文要求：仿宋小四号字，行间距24磅，支持从Word粘贴。";
			this.kryptonLabel61.Location = new Point(3, 3);
			this.kryptonLabel61.Name = "kryptonLabel61";
			this.kryptonLabel61.Size = new Size(286, 27);
			this.kryptonLabel61.StateCommon.LongText.Font = new Font("KaiTi_GB2312", 12f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.kryptonLabel61.StateCommon.ShortText.Font = new Font("SimSun", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.kryptonLabel61.StateNormal.ShortText.Font = new Font("SimHei", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.kryptonLabel61.TabIndex = 0;
			this.kryptonLabel61.Values.ExtraText = "（200字内）";
			this.kryptonLabel61.Values.Text = "四、第一年研究任务";
			this.hSkinTableLayoutPanel1.BorderColor = Color.Black;
			this.hSkinTableLayoutPanel1.ColumnCount = 1;
			this.hSkinTableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
			this.hSkinTableLayoutPanel1.Controls.Add(this.rtfmission, 0, 0);
			this.hSkinTableLayoutPanel1.Dock = DockStyle.Fill;
			this.hSkinTableLayoutPanel1.Location = new Point(93, 123);
			this.hSkinTableLayoutPanel1.Name = "hSkinTableLayoutPanel1";
			this.hSkinTableLayoutPanel1.RowCount = 1;
			this.hSkinTableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50f));
			this.hSkinTableLayoutPanel1.Size = new Size(681, 359);
			this.hSkinTableLayoutPanel1.TabIndex = 4;
            //this.rtfmission.BorderStyle = BorderStyle.None;
			this.rtfmission.Dock = DockStyle.Fill;
			this.rtfmission.Font = new Font("FangSong_GB2312", 12f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.rtfmission.Location = new Point(1, 1);
			this.rtfmission.Margin = new Padding(1);
			this.rtfmission.Name = "rtfmission";
			this.rtfmission.Size = new Size(679, 357);
			this.rtfmission.TabIndex = 3;
			this.rtfmission.Text = "";
			this.rtfmission.TextChanged += new EventHandler(this.rtfmission_TextChanged);
			this.rtfmission.KeyDown += new KeyEventHandler(this.rtfmission_KeyDown);
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			//base.AutoScaleMode = AutoScaleMode.Font;
			base.Controls.Add(this.tableLayoutPanel4);
			base.Name = "frmMissionInfo";
			base.Size = new Size(867, 545);
			base.Leave += new EventHandler(this.frmMissionInfo_Leave);
			this.tableLayoutPanel4.ResumeLayout(false);
			this.tableLayoutPanel28.ResumeLayout(false);
			((ISupportInitialize)this.kryptonPanel19).EndInit();
			this.kryptonPanel19.ResumeLayout(false);
			this.kryptonPanel19.PerformLayout();
			this.hSkinTableLayoutPanel1.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		public frmMissionInfo()
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
			if (this.rtfmission.Text.Length > 400)
			{
				MessageBox.Show("内容超长,请精简内容！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return false;
			}
			this.OnSaveCheckPassedEvent(EventArgs.Empty);
			return true;
		}

		public override void RefreshCall()
		{
			if (File.Exists(this.rtfFile))
			{
				this.rtfmission.LoadFile(this.rtfFile);
				return;
			}
			this.rtfmission.Clear();
		}

		private void btnmissionSave_Click(object sender, EventArgs e)
		{
			if (!this.CanSave())
			{
				return;
			}
			this.rtfmission.SaveFile(this.rtfFile);
			this.issaved = true;
			KryptonNavigator kryptonNavigator = (KryptonNavigator)base.Parent.Parent.Parent.Parent.Parent.Parent;
			kryptonNavigator.SelectedIndex++;
			kryptonNavigator.SelectedPage.Enabled = true;
		}

		private void rtfmission_TextChanged(object sender, EventArgs e)
		{
			if (this.loading != null)
			{
				this.loading.Close();
				this.loading = null;
			}
		}

		private void rtfmission_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.Control && e.KeyCode == Keys.V)
			{
				e.Handled = true;
				this.loading = new frmLoading();
				this.loading.TopMost = true;
				Point point = this.rtfmission.PointToScreen(base.FindForm().Location);
				this.loading.Location = new Point(point.X + (this.rtfmission.Width - this.loading.Width) / 2, point.Y + (this.rtfmission.Height - this.loading.Height) / 2);
				this.loading.Show();
				IDataObject obj = Clipboard.GetDataObject();
				BaseControl.AsyncDelegate del = delegate
				{
					object data = obj.GetData("Rich Text Format");
					if (data != null)
					{
						BaseControl.MethodInvoker uiDelegate = delegate
						{
							this.rtfmission.SelectedRtf = (string)data;
							data = null;
						};
						this.UpdateUI(uiDelegate, this);
						return;
					}
					BaseControl.MethodInvoker uiDelegate2 = delegate
					{
						this.rtfmission.Paste();
					};
					this.UpdateUI(uiDelegate2, this);
				};
				base.BeginInvoke(del);
			}
		}

		private void frmMissionInfo_Leave(object sender, EventArgs e)
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
			this.rtfmission.SaveFile(this.rtfFile);
		}
	}
}
