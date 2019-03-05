using NDEY.UI.Properties;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace NDEY.UI
{
	public class startform : BaseForm
	{
		private IContainer components;

		private PictureBox pictureBox1;

		public startform()
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
			((ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.pictureBox1.BackColor = SystemColors.Control;
			this.pictureBox1.Dock = DockStyle.Fill;
            this.pictureBox1.Image = global::Properties.Resource.First5001;
			this.pictureBox1.Location = new Point(0, 0);
			this.pictureBox1.Margin = new Padding(0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new Size(490, 295);
			this.pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
            ////base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = SystemColors.Control;
			base.ClientSize = new Size(490, 295);
			base.Controls.Add(this.pictureBox1);
            //base.FormBorderStyle = FormBorderStyle.None;
			base.Name = "startform";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "startform";
			((ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}
	}
}
