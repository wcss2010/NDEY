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
        private string rtfFile = Path.Combine(EntityElement.UserPath, "Files\\军事意义.doc");

		private bool issaved;

		private frmLoading loading;

		private IContainer components;

        private TableLayoutPanel tableLayoutPanel4;

		private KryptonPanel kryptonPanel19;

		private KryptonLabel kryptonLabel61;

        private Label label1;
        private DocumentPasteEditor dpContent;

		private HSkinTableLayoutPanel hSkinTableLayoutPanel1;

		public frmContributionInfo()
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
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.kryptonPanel19 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.kryptonLabel61 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.hSkinTableLayoutPanel1 = new NDEY.UI.HSkinTableLayoutPanel();
            this.dpContent = new NDEY.UI.NDEYUserControl.DocumentPasteEditor();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel19)).BeginInit();
            this.kryptonPanel19.SuspendLayout();
            this.hSkinTableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel4.Controls.Add(this.kryptonPanel19, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.hSkinTableLayoutPanel1, 1, 2);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 5;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(867, 545);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // kryptonPanel19
            // 
            this.kryptonPanel19.Controls.Add(this.label1);
            this.kryptonPanel19.Controls.Add(this.kryptonLabel61);
            this.kryptonPanel19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel19.Location = new System.Drawing.Point(90, 20);
            this.kryptonPanel19.Margin = new System.Windows.Forms.Padding(0);
            this.kryptonPanel19.Name = "kryptonPanel19";
            this.kryptonPanel19.Size = new System.Drawing.Size(687, 100);
            this.kryptonPanel19.StateCommon.Color1 = System.Drawing.Color.White;
            this.kryptonPanel19.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("仿宋_GB2312", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(0, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(687, 67);
            this.label1.TabIndex = 2;
            this.label1.Text = "    着重阐述近5年来在国防科技领域的主要成绩和突出贡献，包括在基础研究、技术攻关、工程和型号任务中取得的成绩和代表性成果，产生的影响以及转化应用取得的军事效益" +
    "。\r\n    体例结构可自行组织。\r\n    正文要求：仿宋小四号字，行间距24磅，支持从Word粘贴。";
            // 
            // kryptonLabel61
            // 
            this.kryptonLabel61.Location = new System.Drawing.Point(3, 3);
            this.kryptonLabel61.Name = "kryptonLabel61";
            this.kryptonLabel61.Size = new System.Drawing.Size(334, 27);
            this.kryptonLabel61.StateCommon.LongText.Font = new System.Drawing.Font("楷体_GB2312", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.kryptonLabel61.StateCommon.ShortText.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.kryptonLabel61.StateNormal.ShortText.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.kryptonLabel61.TabIndex = 0;
            this.kryptonLabel61.Values.ExtraText = "（3000字内）";
            this.kryptonLabel61.Values.Text = "一、主要成绩和突出贡献\r\n";
            // 
            // hSkinTableLayoutPanel1
            // 
            this.hSkinTableLayoutPanel1.BorderColor = System.Drawing.Color.Black;
            this.hSkinTableLayoutPanel1.ColumnCount = 1;
            this.hSkinTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.hSkinTableLayoutPanel1.Controls.Add(this.dpContent, 0, 0);
            this.hSkinTableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hSkinTableLayoutPanel1.Location = new System.Drawing.Point(93, 123);
            this.hSkinTableLayoutPanel1.Name = "hSkinTableLayoutPanel1";
            this.hSkinTableLayoutPanel1.RowCount = 1;
            this.hSkinTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.hSkinTableLayoutPanel1.Size = new System.Drawing.Size(681, 359);
            this.hSkinTableLayoutPanel1.TabIndex = 4;
            // 
            // dpContent
            // 
            this.dpContent.BackColor = System.Drawing.Color.White;
            this.dpContent.DestDocumentPath = null;
            this.dpContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dpContent.EditorName = null;
            this.dpContent.EmptyTempleteFile = null;
            this.dpContent.Font = new System.Drawing.Font("仿宋", 12F);
            this.dpContent.InfoLabelAutoHeight = true;
            this.dpContent.InfoLabelHeight = 51;
            this.dpContent.InfoLabelText = "";
            this.dpContent.Location = new System.Drawing.Point(4, 4);
            this.dpContent.Margin = new System.Windows.Forms.Padding(4);
            this.dpContent.Name = "dpContent";
            this.dpContent.Size = new System.Drawing.Size(673, 351);
            this.dpContent.TabIndex = 0;
            // 
            // frmContributionInfo
            // 
            this.Controls.Add(this.tableLayoutPanel4);
            this.Name = "frmContributionInfo";
            this.Size = new System.Drawing.Size(867, 545);
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel19)).EndInit();
            this.kryptonPanel19.ResumeLayout(false);
            this.kryptonPanel19.PerformLayout();
            this.hSkinTableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            dpContent.initEditor(Path.GetFileNameWithoutExtension(rtfFile), string.Empty, EntityElement.UserPath, Path.Combine(Application.StartupPath, Path.Combine("Helper", "emptyPaste.doc")), Path.Combine(Application.StartupPath, Path.Combine("Helper", "documentPasteReadme.rtf")));
        }

        public override void RefreshCall()
        {

        }
	}
}