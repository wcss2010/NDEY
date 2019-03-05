using ComponentFactory.Krypton.Toolkit;
using NDEY.BLL.Entity;
using NDEY.BLL.Service;
using NDEY.UI.NDEYUserControl;
using NDEY.UI.Properties;
using NDEY.UI.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace NDEY.UI
{
	public class frmClear : BaseForm
	{
		public delegate void ClearOKHandler(object sender, EventArgs e);

		private IList<BaseControl> _baseControls;

		private IContainer components;

		private PictureBox pictureBox1;

		private KryptonPanel kryptonPanel1;

		private KryptonLabel lbinfo;

		private KryptonButton btnCancel;

		private KryptonButton btnConfirm;

		public event frmClear.ClearOKHandler ClearOK;

		protected virtual void OnClearOKEvent(EventArgs e)
		{
			if (this.ClearOK != null)
			{
				this.ClearOK(this, e);
			}
		}

		public frmClear(IList<BaseControl> controls)
		{
			this.InitializeComponent();
			this._baseControls = controls;
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		private void btnConfirm_Click(object sender, EventArgs e)
		{
			this.lbinfo.Text = "请稍后...";
			this.btnCancel.Enabled = false;
			this.btnConfirm.Enabled = false;
			string text = "";
			FileOp.RunWordInstCheck(out text);
			BaseForm.AsyncDelegate del = delegate
			{
				DirectoryInfo directoryInfo = new DirectoryInfo(EntityElement.FilesStorePath);
				FileInfo[] files = directoryInfo.GetFiles();
				FileInfo[] array = files;
				for (int i = 0; i < array.Length; i++)
				{
					FileInfo fileInfo = array[i];
					try
					{
						fileInfo.Delete();
					}
					catch (Exception ex)
					{
						BaseForm.MethodInvoker uiDelegate = delegate
						{
							MessageBox.Show("待删除文件正在被其他程序使用，请关闭其他程序后，再重新新建。\r\n详细错误:" + ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
							this.Close();
						};
						base.UpdateUI(uiDelegate, this);
						return;
					}
				}
				DBMgrService dBMgrService = new DBMgrService();
				dBMgrService.InitDB();
				BaseForm.MethodInvoker uiDelegate2 = delegate
				{
					this.OnClearOKEvent(EventArgs.Empty);
					if (this._baseControls != null)
					{
						foreach (BaseControl current in this._baseControls)
						{
							current.RefreshCall();
						}
					}
					base.Close();
				};
				base.UpdateUI(uiDelegate2, this);
			};
			base.BeginInvoke(del);
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
			this.pictureBox1 = new PictureBox();
			this.kryptonPanel1 = new KryptonPanel();
			this.lbinfo = new KryptonLabel();
			this.btnCancel = new KryptonButton();
			this.btnConfirm = new KryptonButton();
			((ISupportInitialize)this.pictureBox1).BeginInit();
			((ISupportInitialize)this.kryptonPanel1).BeginInit();
			this.kryptonPanel1.SuspendLayout();
			base.SuspendLayout();
			this.pictureBox1.BackColor = Color.Transparent;
			this.pictureBox1.Dock = DockStyle.Left;
            this.pictureBox1.Image = global::Properties.Resource.CLEAN;
			this.pictureBox1.Location = new Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new Size(86, 90);
			this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.kryptonPanel1.Controls.Add(this.lbinfo);
			this.kryptonPanel1.Controls.Add(this.btnCancel);
			this.kryptonPanel1.Controls.Add(this.btnConfirm);
			this.kryptonPanel1.Controls.Add(this.pictureBox1);
			this.kryptonPanel1.Dock = DockStyle.Fill;
			this.kryptonPanel1.Location = new Point(0, 0);
			this.kryptonPanel1.Name = "kryptonPanel1";
			this.kryptonPanel1.Size = new Size(375, 90);
			this.kryptonPanel1.StateCommon.Color1 = Color.White;
			this.kryptonPanel1.StateCommon.ColorStyle = PaletteColorStyle.SolidAllLine;
			this.kryptonPanel1.TabIndex = 1;
			this.lbinfo.Location = new Point(94, 12);
			this.lbinfo.Name = "lbinfo";
			this.lbinfo.Size = new Size(269, 20);
			this.lbinfo.TabIndex = 3;
			this.lbinfo.Values.Text = "是否确认清空用户所有填报数据，并初始化？";
			this.btnCancel.Location = new Point(273, 53);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new Size(90, 25);
			this.btnCancel.TabIndex = 2;
			this.btnCancel.Values.Text = "取消";
			this.btnCancel.Click += new EventHandler(this.btnCancel_Click);
			this.btnConfirm.Location = new Point(166, 53);
			this.btnConfirm.Name = "btnConfirm";
			this.btnConfirm.Size = new Size(90, 25);
			this.btnConfirm.TabIndex = 1;
			this.btnConfirm.Values.Text = "确认";
			this.btnConfirm.Click += new EventHandler(this.btnConfirm_Click);
			base.AutoScaleDimensions = new SizeF(6f, 12f);
            ////base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(375, 90);
			base.Controls.Add(this.kryptonPanel1);
            //base.FormBorderStyle = FormBorderStyle.None;
			base.Name = "frmClear";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "frmClear";
			((ISupportInitialize)this.pictureBox1).EndInit();
			((ISupportInitialize)this.kryptonPanel1).EndInit();
			this.kryptonPanel1.ResumeLayout(false);
			this.kryptonPanel1.PerformLayout();
			base.ResumeLayout(false);
		}
	}
}