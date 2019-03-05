using ComponentFactory.Krypton.Toolkit;
using ICSharpCode.SharpZipLib.Zip;
using NDEY.BLL.Entity;
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
	public class frmRequestImport : BaseForm
	{
		public delegate void ImportOKHandler(object sender, EventArgs e);

		private IContainer components;

		private KryptonPanel kryptonPanel1;

		private PictureBox pictureBox1;

		private ProgressBar pbar;

		private KryptonButton btncancel;

		private KryptonButton btnconfirm;

		private KryptonLabel lbcontinue;

		private KryptonLabel lbmsg;

		private string _zipfilepath = string.Empty;

		private IList<BaseControl> _baseControls;

		public event frmRequestImport.ImportOKHandler ImportOK;

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
			this.kryptonPanel1 = new KryptonPanel();
			this.btnconfirm = new KryptonButton();
			this.lbmsg = new KryptonLabel();
			this.lbcontinue = new KryptonLabel();
			this.btncancel = new KryptonButton();
			this.pbar = new ProgressBar();
			this.pictureBox1 = new PictureBox();
			((ISupportInitialize)this.kryptonPanel1).BeginInit();
			this.kryptonPanel1.SuspendLayout();
			((ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.kryptonPanel1.Controls.Add(this.lbmsg);
			this.kryptonPanel1.Controls.Add(this.btnconfirm);
			this.kryptonPanel1.Controls.Add(this.lbcontinue);
			this.kryptonPanel1.Controls.Add(this.btncancel);
			this.kryptonPanel1.Controls.Add(this.pbar);
			this.kryptonPanel1.Controls.Add(this.pictureBox1);
			this.kryptonPanel1.Dock = DockStyle.Fill;
			this.kryptonPanel1.Location = new Point(0, 0);
			this.kryptonPanel1.Name = "kryptonPanel1";
			this.kryptonPanel1.Size = new Size(375, 90);
			this.kryptonPanel1.StateCommon.Color1 = Color.White;
			this.kryptonPanel1.StateCommon.ColorStyle = PaletteColorStyle.SolidAllLine;
			this.kryptonPanel1.TabIndex = 0;
			this.btnconfirm.Location = new Point(177, 58);
			this.btnconfirm.Name = "btnconfirm";
			this.btnconfirm.Size = new Size(90, 25);
			this.btnconfirm.TabIndex = 6;
			this.btnconfirm.Values.Text = "继续";
			this.btnconfirm.Click += new EventHandler(this.btnconfirm_Click);
			this.lbmsg.Location = new Point(92, 58);
			this.lbmsg.Name = "lbmsg";
			this.lbmsg.Size = new Size(53, 20);
			this.lbmsg.TabIndex = 9;
			this.lbmsg.Values.Text = "krypton";
			this.lbcontinue.Location = new Point(88, 12);
			this.lbcontinue.Name = "lbcontinue";
			this.lbcontinue.Size = new Size(275, 20);
			this.lbcontinue.TabIndex = 8;
			this.lbcontinue.Values.Text = "导入申请将会清空系统中当前数据，是否继续?";
			this.btncancel.Location = new Point(273, 58);
			this.btncancel.Name = "btncancel";
			this.btncancel.Size = new Size(90, 25);
			this.btncancel.TabIndex = 7;
			this.btncancel.Values.Text = "取消";
			this.btncancel.Click += new EventHandler(this.btncancel_Click);
			this.pbar.Location = new Point(95, 27);
			this.pbar.Name = "pbar";
			this.pbar.Size = new Size(268, 23);
			this.pbar.TabIndex = 1;
			this.pbar.Visible = false;
			this.pictureBox1.BackColor = Color.Transparent;
			this.pictureBox1.Dock = DockStyle.Left;
            this.pictureBox1.Image = global::Properties.Resource.Import_128;
			this.pictureBox1.Location = new Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new Size(86, 90);
			this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
            ////base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(375, 90);
			base.Controls.Add(this.kryptonPanel1);
            //base.FormBorderStyle = FormBorderStyle.None;
			base.Name = "frmRequestImport";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "frmRequestImport";
			base.Load += new EventHandler(this.frmRequestImport_Load);
			((ISupportInitialize)this.kryptonPanel1).EndInit();
			this.kryptonPanel1.ResumeLayout(false);
			this.kryptonPanel1.PerformLayout();
			((ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
		}

		public frmRequestImport()
		{
			this.InitializeComponent();
		}

		protected virtual void OnImportOKEvent(EventArgs e)
		{
			if (this.ImportOK != null)
			{
				this.ImportOK(this, e);
			}
		}

		public frmRequestImport(string filepath, IList<BaseControl> controls)
		{
			this.InitializeComponent();
			this._zipfilepath = filepath;
			this._baseControls = controls;
		}

		private void btncancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		private void btnconfirm_Click(object sender, EventArgs e)
		{
			this.btncancel.Visible = false;
			this.btnconfirm.Visible = false;
			this.lbcontinue.Visible = false;
			this.pbar.Visible = true;
			string text = "";
			FileOp.RunWordInstCheck(out text);
			BaseForm.AsyncDelegate del = delegate
			{
				if (File.Exists(this._zipfilepath))
				{
					this.setprogress(1, "解压缩文件...");
					DirectoryInfo directoryInfo = new DirectoryInfo(EntityElement.TempPath);
					FileInfo[] files = directoryInfo.GetFiles();
					FileInfo[] array = files;
					for (int i = 0; i < array.Length; i++)
					{
						FileInfo fileInfo = array[i];
						try
						{
							fileInfo.Delete();
						}
						catch (Exception)
						{
						}
					}
					bool flag = false;
					ZipInputStream zipInputStream = null;
					try
					{
						ZipInputStream zipInputStream2;
						zipInputStream = (zipInputStream2 = new ZipInputStream(File.OpenRead(this._zipfilepath)));
						try
						{
							int num = 2;
							ZipEntry nextEntry;
							while ((nextEntry = zipInputStream.GetNextEntry()) != null)
							{
								this.setprogress(num++, "解压缩文件...");
								if (nextEntry.IsFile)
								{
									string fileName = Path.GetFileName(nextEntry.Name);
									if (fileName == EntityElement.DBName)
									{
										flag = true;
									}
									using (FileStream fileStream = File.Create(Path.Combine(EntityElement.TempPath, fileName)))
									{
										byte[] array2 = new byte[2048];
										while (true)
										{
											int num2 = zipInputStream.Read(array2, 0, array2.Length);
											if (num2 <= 0)
											{
												break;
											}
											fileStream.Write(array2, 0, num2);
										}
										fileStream.Close();
									}
								}
							}
							zipInputStream.Close();
						}
						finally
						{
							if (zipInputStream2 != null)
							{
								((IDisposable)zipInputStream2).Dispose();
							}
						}
					}
					catch (Exception ex)
					{
						if (zipInputStream != null)
						{
							try
							{
								zipInputStream.Close();
							}
							catch (Exception)
							{
							}
						}
						BaseForm.MethodInvoker uiDelegate = delegate
						{
							MessageBox.Show("文件解压失败，请检查压缩包是否正确。\r\n详细错误：" + ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Hand);
							this.dofinish();
						};
						base.UpdateUI(uiDelegate, this);
						return;
					}
					if (flag)
					{
						this.setprogress(40, "清理目标文件夹...");
						directoryInfo = new DirectoryInfo(EntityElement.FilesStorePath);
						files = directoryInfo.GetFiles();
						FileInfo[] array3 = files;
						for (int j = 0; j < array3.Length; j++)
						{
							FileInfo fileInfo2 = array3[j];
							try
							{
								fileInfo2.Delete();
							}
							catch (Exception ex)
							{
								BaseForm.MethodInvoker uiDelegate2 = delegate
								{
									MessageBox.Show("文件删除失败，请关闭任何使用该文件的进程后重新导入。\r\n详细错误：" + ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Hand);
									this.dofinish();
								};
								base.UpdateUI(uiDelegate2, this);
								return;
							}
						}
						this.setprogress(60, "导入数据库...");
						File.Copy(Path.Combine(EntityElement.TempPath, EntityElement.DBName), Path.Combine(EntityElement.DBStorePath, EntityElement.DBName), true);
						File.Delete(Path.Combine(EntityElement.TempPath, EntityElement.DBName));
						this.setprogress(70, "导入附件...");
						directoryInfo = new DirectoryInfo(EntityElement.TempPath);
						files = directoryInfo.GetFiles();
						FileInfo[] array4 = files;
						for (int k = 0; k < array4.Length; k++)
						{
							FileInfo fileInfo3 = array4[k];
							File.Move(fileInfo3.FullName, Path.Combine(EntityElement.FilesStorePath, Path.GetFileName(fileInfo3.FullName)));
						}
						this.setprogress(85, "读取新数据...");
						BaseForm.MethodInvoker uiDelegate3 = delegate
						{
							this.OnImportOKEvent(EventArgs.Empty);
							if (this._baseControls != null)
							{
								foreach (BaseControl current in this._baseControls)
								{
									current.RefreshCall();
								}
								this.setprogress(95, "更新完成...");
								this.dofinish();
							}
						};
						base.UpdateUI(uiDelegate3, this);
						return;
					}
					BaseForm.MethodInvoker uiDelegate4 = delegate
					{
						MessageBox.Show("导入数据中用户数据丢失，导入失败。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Hand);
						this.dofinish();
					};
					base.UpdateUI(uiDelegate4, this);
				}
			};
			base.BeginInvoke(del);
		}

		private void dofinish()
		{
			BaseForm.AsyncDelegate del = delegate
			{
				DirectoryInfo directoryInfo = new DirectoryInfo(EntityElement.TempPath);
				this.setprogress(99, "删除导入过程中的所有临时文件...");
				FileInfo[] files = directoryInfo.GetFiles();
				FileInfo[] array = files;
				for (int i = 0; i < array.Length; i++)
				{
					FileInfo fileInfo = array[i];
					try
					{
						fileInfo.Delete();
					}
					catch (Exception)
					{
					}
				}
				BaseForm.MethodInvoker uiDelegate = delegate
				{
					base.Close();
				};
				base.UpdateUI(uiDelegate, this);
			};
			base.BeginInvoke(del);
		}

		private void setprogress(int cval, string msg)
		{
			BaseForm.MethodInvoker uiDelegate = delegate
			{
				this.pbar.Value = cval;
				this.lbmsg.Text = msg;
			};
			base.UpdateUI(uiDelegate, this);
		}

		private void frmRequestImport_Load(object sender, EventArgs e)
		{
			this.lbmsg.Text = "";
		}
	}
}