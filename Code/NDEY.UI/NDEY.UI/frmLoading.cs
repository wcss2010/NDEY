using ComponentFactory.Krypton.Toolkit;
using NDEY.UI.Properties;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace NDEY.UI
{
	public class frmLoading : BaseForm
	{
		private IContainer components;

		private PictureBox pictureBox1;

		private KryptonLabel kryptonLabel1;

		private KryptonPanel kryptonPanel1;

		public frmLoading()
		{
			this.InitializeComponent();
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
			this.kryptonLabel1 = new KryptonLabel();
			this.kryptonPanel1 = new KryptonPanel();
			((ISupportInitialize)this.pictureBox1).BeginInit();
			((ISupportInitialize)this.kryptonPanel1).BeginInit();
			this.kryptonPanel1.SuspendLayout();
			base.SuspendLayout();
			this.pictureBox1.BackColor = Color.Transparent;
            this.pictureBox1.Image = global::Properties.Resource.loading;
			this.pictureBox1.Location = new Point(12, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new Size(154, 141);
			this.pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.kryptonLabel1.Location = new Point(27, 150);
			this.kryptonLabel1.Name = "kryptonLabel1";
			this.kryptonLabel1.Size = new Size(125, 20);
			this.kryptonLabel1.TabIndex = 1;
			this.kryptonLabel1.Values.Text = "数据转换中,请稍后...";
			this.kryptonPanel1.Controls.Add(this.pictureBox1);
			this.kryptonPanel1.Controls.Add(this.kryptonLabel1);
			this.kryptonPanel1.Dock = DockStyle.Fill;
			this.kryptonPanel1.Location = new Point(0, 0);
			this.kryptonPanel1.Name = "kryptonPanel1";
			this.kryptonPanel1.Size = new Size(180, 179);
			this.kryptonPanel1.StateCommon.Color1 = Color.White;
			this.kryptonPanel1.StateCommon.ColorStyle = PaletteColorStyle.Solid;
			this.kryptonPanel1.TabIndex = 2;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
            ////base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.White;
			base.ClientSize = new Size(180, 179);
			base.Controls.Add(this.kryptonPanel1);
            //base.FormBorderStyle = FormBorderStyle.None;
			base.Name = "frmLoading";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.Manual;
			this.Text = "frmLoading";
			((ISupportInitialize)this.pictureBox1).EndInit();
			((ISupportInitialize)this.kryptonPanel1).EndInit();
			this.kryptonPanel1.ResumeLayout(false);
			this.kryptonPanel1.PerformLayout();
			base.ResumeLayout(false);
		}
	}
}
