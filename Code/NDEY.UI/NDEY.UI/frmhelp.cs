using ComponentFactory.Krypton.Toolkit;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace NDEY.UI
{
	public class frmHelp : KryptonForm
	{
		private IContainer components;

		private RichTextBox txtRich;

		private TableLayoutPanel tableLayoutPanel1;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHelp));
            this.txtRich = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtRich
            // 
            this.txtRich.BackColor = System.Drawing.Color.White;
            this.txtRich.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRich.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRich.Location = new System.Drawing.Point(43, 3);
            this.txtRich.Name = "txtRich";
            this.txtRich.ReadOnly = true;
            this.txtRich.Size = new System.Drawing.Size(732, 497);
            this.txtRich.TabIndex = 0;
            this.txtRich.Text = "";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.txtRich, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(778, 503);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // frmhelp
            // 
            this.ClientSize = new System.Drawing.Size(778, 503);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmhelp";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "使用指南";
            this.Load += new System.EventHandler(this.frmhelp_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		public frmHelp()
		{
			this.InitializeComponent();
		}

		private void frmhelp_Load(object sender, EventArgs e)
		{
			if (File.Exists(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Helper\\help.rtf")))
			{
				this.txtRich.LoadFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Helper\\help.rtf"));
			}
		}
	}
}
