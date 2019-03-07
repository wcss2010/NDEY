using ComponentFactory.Krypton.Toolkit;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace NDEY.UI.NDEYUserControl
{
	public class frmIntroduction : BaseControl
	{
		private IContainer components;

		private KryptonRichTextBox rtxtIntroduction;

		private TableLayoutPanel tableLayoutPanel1;

		public frmIntroduction()
		{
			this.InitializeComponent();
		}

		protected override void OnLoad(EventArgs e)
		{
			BaseControl.AsyncDelegate del = delegate
			{
				Thread.Sleep(1500);
				BaseControl.MethodInvoker uiDelegate = delegate
				{
					if (File.Exists(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Helper\\introduction.rtf")))
					{
						this.rtxtIntroduction.LoadFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Helper\\introduction.rtf"));
					}
					this.rtxtIntroduction.Focus();
				};
				base.UpdateUI(uiDelegate, this);
			};
			base.BeginInvoke(del);
			base.OnLoad(e);
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
			this.rtxtIntroduction = new KryptonRichTextBox();
			this.tableLayoutPanel1 = new TableLayoutPanel();
			this.tableLayoutPanel1.SuspendLayout();
			base.SuspendLayout();
			this.rtxtIntroduction.Dock = DockStyle.Fill;
			this.rtxtIntroduction.Location = new Point(90, 0);
			this.rtxtIntroduction.Margin = new Padding(0);
			this.rtxtIntroduction.Name = "rtxtIntroduction";
			this.rtxtIntroduction.ReadOnly = true;
			this.rtxtIntroduction.Size = new Size(546, 619);
			this.rtxtIntroduction.TabIndex = 0;
			this.rtxtIntroduction.Text = "";
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90f));
			this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90f));
			this.tableLayoutPanel1.Controls.Add(this.rtxtIntroduction, 1, 0);
			this.tableLayoutPanel1.Dock = DockStyle.Fill;
			this.tableLayoutPanel1.Location = new Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20f));
			this.tableLayoutPanel1.Size = new Size(726, 619);
			this.tableLayoutPanel1.TabIndex = 1;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			//base.AutoScaleMode = AutoScaleMode.Font;
			base.Controls.Add(this.tableLayoutPanel1);
			base.Name = "frmIntroduction";
			base.Size = new Size(726, 619);
			this.tableLayoutPanel1.ResumeLayout(false);
			base.ResumeLayout(false);
		}
	}
}
