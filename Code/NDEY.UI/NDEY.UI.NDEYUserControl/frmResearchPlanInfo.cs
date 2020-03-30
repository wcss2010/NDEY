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

		private KryptonLabel kryptonLabel1;

        private Label label1;

		private HSkinTableLayoutPanel hSkinTableLayoutPanel1;

        private string rtfFile = Path.Combine(EntityElement.UserPath, "Files\\拟开展的研究工作.doc");

        private DocumentPasteEditor dpContent;

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
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.kryptonPanel20 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.hSkinTableLayoutPanel1 = new NDEY.UI.HSkinTableLayoutPanel();
            this.dpContent = new NDEY.UI.NDEYUserControl.DocumentPasteEditor();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel20)).BeginInit();
            this.kryptonPanel20.SuspendLayout();
            this.hSkinTableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel5.Controls.Add(this.kryptonPanel20, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.hSkinTableLayoutPanel1, 1, 2);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 5;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(917, 541);
            this.tableLayoutPanel5.TabIndex = 2;
            // 
            // kryptonPanel20
            // 
            this.kryptonPanel20.Controls.Add(this.label1);
            this.kryptonPanel20.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel20.Location = new System.Drawing.Point(90, 20);
            this.kryptonPanel20.Margin = new System.Windows.Forms.Padding(0);
            this.kryptonPanel20.Name = "kryptonPanel20";
            this.kryptonPanel20.Size = new System.Drawing.Size(737, 100);
            this.kryptonPanel20.StateCommon.Color1 = System.Drawing.Color.White;
            this.kryptonPanel20.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("仿宋_GB2312", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(0, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(737, 67);
            this.label1.TabIndex = 2;
            this.label1.Text = "    着重阐述拟开展的研究工作的背景（科学价值、军事意义、国内外研究现状等），总体思路和研究目标，主要研究内容和初步研究方案等，请简要阐述。\r\n    体例结构" +
    "可自行组织。\r\n    正文要求：仿宋小四号字，行间距24磅，支持从Word粘贴。";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(1, 3);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(314, 27);
            this.kryptonLabel1.StateCommon.LongText.Font = new System.Drawing.Font("楷体_GB2312", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.kryptonLabel1.TabIndex = 1;
            this.kryptonLabel1.Values.ExtraText = "（2000字内）";
            this.kryptonLabel1.Values.Text = "二、拟开展的研究工作";
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
            this.hSkinTableLayoutPanel1.Size = new System.Drawing.Size(731, 355);
            this.hSkinTableLayoutPanel1.TabIndex = 5;
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
            this.dpContent.Size = new System.Drawing.Size(723, 347);
            this.dpContent.TabIndex = 0;
            this.dpContent.EditDocumentEvent += new System.EventHandler(this.dpContent_EditDocumentEvent);
            // 
            // frmResearchPlanInfo
            // 
            this.Controls.Add(this.tableLayoutPanel5);
            this.Name = "frmResearchPlanInfo";
            this.Size = new System.Drawing.Size(917, 541);
            this.tableLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel20)).EndInit();
            this.kryptonPanel20.ResumeLayout(false);
            this.kryptonPanel20.PerformLayout();
            this.hSkinTableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		public frmResearchPlanInfo()
		{
			this.InitializeComponent();
		}

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            dpContent.initEditor(Path.GetFileNameWithoutExtension(rtfFile), string.Empty, EntityElement.FilesStorePath, Path.Combine(Application.StartupPath, Path.Combine("Helper", "emptyPaste.doc")), Path.Combine(Application.StartupPath, Path.Combine("Helper", "documentPasteReadme.rtf")));
        }

		public override void RefreshCall()
		{

		}

        private void dpContent_EditDocumentEvent(object sender, EventArgs e)
        {
            KryptonNavigator kryptonNavigator = (KryptonNavigator)base.Parent.Parent.Parent;
            kryptonNavigator.SelectedIndex++;
            kryptonNavigator.SelectedPage.Enabled = true;
        }
	}
}