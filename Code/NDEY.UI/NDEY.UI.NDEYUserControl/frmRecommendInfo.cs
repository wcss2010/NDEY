using ComponentFactory.Krypton.Navigator;
using ComponentFactory.Krypton.Toolkit;
using NDEY.BLL.Entity;
using NDEY.BLL.Service;
using NDEY.UI.Utility;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace NDEY.UI.NDEYUserControl
{
	public class frmRecommendInfo : BaseControl
	{
		private IContainer components;

		private TableLayoutPanel tableLayoutPanel16;

		private KryptonPanel kryptonPanel31;

		private KryptonLabel kryptonLabel65;

		private KryptonPanel kryptonPanel22;

		private KryptonRadioButton rbprofessional;

		private KryptonRadioButton rbcompany;

		private KryptonNavigator requesttablehost;

		private KryptonPage kryptonPage1;

		private KryptonPage kryptonPage2;

		private KryptonButton btncomsave;

		private KryptonButton btnComsel;

		private KryptonPanel kryptonPanel32;

		private KryptonLabel kryptonLabel67;

		private Label label3;

		private Label label2;

		private TableLayoutPanel tableLayoutPanel21;

		private KryptonButton btnexp2rm;

		private KryptonButton btnexp2sel;

		private KryptonLabel kryptonLabel71;

		private KryptonLabel kryptonLabel73;

		private KryptonLabel kryptonLabel74;

		private KryptonLabel kryptonLabel75;

		private KryptonLabel kryptonLabel76;

		private KryptonLabel kryptonLabel98;

		private KryptonLabel kryptonLabel99;

		private KryptonLabel kryptonLabel101;

		private KryptonLabel kryptonLabel103;

		private KryptonLabel kryptonLabel105;

		private KryptonLabel kryptonLabel106;

		private KryptonLabel kryptonLabel107;

		private KryptonLabel kryptonLabel108;

		private KryptonLabel kryptonLabel109;

		private KryptonTextBox txtExpertName1;

		private KryptonTextBox txtExpertArea1;

		private KryptonTextBox txtExpertUnitPosition1;

		private KryptonTextBox txtExpertUnit1;

		private KryptonTextBox txtExpertName2;

		private KryptonTextBox txtExpertArea2;

		private KryptonTextBox txtExpertUnitPosition2;

		private KryptonTextBox txtExpertUnit2;

		private KryptonTextBox txtExpertName3;

		private KryptonTextBox txtExpertArea3;

		private KryptonTextBox txtExpertUnitPosition3;

		private KryptonTextBox txtExpertUnit3;

		private KryptonPanel kryptonPanel23;

		private KryptonLabel kryptonLabel102;

		private TableLayoutPanel tableLayoutPanel19;

		private KryptonButton btnexp1rm;

		private KryptonButton btnexp1sel;

		private TableLayoutPanel tableLayoutPanel22;

		private KryptonButton btnexp3rm;

		private KryptonButton btnexp3sel;

		private Label label1;

		private TableLayoutPanel tableLayoutPanel1;

		private KryptonButton btnexpsave;

		private HSkinTableLayoutPanel tableLayoutPanel18;

		private HSkinTableLayoutPanel tableLayoutPanel17;

		private HSkinTableLayoutPanel tableLayoutPanel20;

		private HSkinTableLayoutPanel tableLayoutPanel23;

		private Label label4;

		private Label label5;

		private KryptonLinkLabel lbcomattpath;

		private KryptonLinkLabel lbexp1attpath;

		private KryptonLinkLabel lbexp2attpath;

		private KryptonLinkLabel lbexp3attpath;

		private RecommendInfo _rinfo;

		private RecommendInfoService _irecommendInfoService = new RecommendInfoService();

		private bool issaved;

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
            this.tableLayoutPanel16 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel17 = new NDEY.UI.HSkinTableLayoutPanel();
            this.kryptonPanel31 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel65 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonPanel22 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.rbprofessional = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.rbcompany = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.requesttablehost = new ComponentFactory.Krypton.Navigator.KryptonNavigator();
            this.kryptonPage1 = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.tableLayoutPanel23 = new NDEY.UI.HSkinTableLayoutPanel();
            this.btncomsave = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.tableLayoutPanel20 = new NDEY.UI.HSkinTableLayoutPanel();
            this.btnComsel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonPanel32 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.kryptonLabel67 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbcomattpath = new ComponentFactory.Krypton.Toolkit.KryptonLinkLabel();
            this.kryptonPage2 = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnexpsave = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.tableLayoutPanel18 = new NDEY.UI.HSkinTableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel21 = new System.Windows.Forms.TableLayoutPanel();
            this.btnexp2rm = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnexp2sel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonLabel71 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel73 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel74 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel75 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel76 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel98 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel99 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel101 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel103 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel105 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel106 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel107 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel108 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtExpertName1 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtExpertArea1 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtExpertUnitPosition1 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtExpertUnit1 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtExpertName2 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtExpertArea2 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtExpertUnitPosition2 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtExpertUnit2 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtExpertName3 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtExpertArea3 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtExpertUnitPosition3 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtExpertUnit3 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonPanel23 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.kryptonLabel102 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.tableLayoutPanel19 = new System.Windows.Forms.TableLayoutPanel();
            this.btnexp1rm = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnexp1sel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.tableLayoutPanel22 = new System.Windows.Forms.TableLayoutPanel();
            this.btnexp3rm = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnexp3sel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label1 = new System.Windows.Forms.Label();
            this.kryptonLabel109 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbexp1attpath = new ComponentFactory.Krypton.Toolkit.KryptonLinkLabel();
            this.lbexp2attpath = new ComponentFactory.Krypton.Toolkit.KryptonLinkLabel();
            this.lbexp3attpath = new ComponentFactory.Krypton.Toolkit.KryptonLinkLabel();
            this.tableLayoutPanel16.SuspendLayout();
            this.tableLayoutPanel17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel31)).BeginInit();
            this.kryptonPanel31.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel22)).BeginInit();
            this.kryptonPanel22.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.requesttablehost)).BeginInit();
            this.requesttablehost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage1)).BeginInit();
            this.kryptonPage1.SuspendLayout();
            this.tableLayoutPanel23.SuspendLayout();
            this.tableLayoutPanel20.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel32)).BeginInit();
            this.kryptonPanel32.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage2)).BeginInit();
            this.kryptonPage2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel18.SuspendLayout();
            this.tableLayoutPanel21.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel23)).BeginInit();
            this.kryptonPanel23.SuspendLayout();
            this.tableLayoutPanel19.SuspendLayout();
            this.tableLayoutPanel22.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel16
            // 
            this.tableLayoutPanel16.ColumnCount = 3;
            this.tableLayoutPanel16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel16.Controls.Add(this.tableLayoutPanel17, 1, 1);
            this.tableLayoutPanel16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel16.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel16.Name = "tableLayoutPanel16";
            this.tableLayoutPanel16.RowCount = 3;
            this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.tableLayoutPanel16.Size = new System.Drawing.Size(1035, 692);
            this.tableLayoutPanel16.TabIndex = 1;
            // 
            // tableLayoutPanel17
            // 
            this.tableLayoutPanel17.BorderColor = System.Drawing.Color.Black;
            this.tableLayoutPanel17.ColumnCount = 2;
            this.tableLayoutPanel17.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel17.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel17.Controls.Add(this.kryptonPanel31, 0, 0);
            this.tableLayoutPanel17.Controls.Add(this.kryptonPanel22, 1, 0);
            this.tableLayoutPanel17.Controls.Add(this.requesttablehost, 0, 1);
            this.tableLayoutPanel17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel17.Location = new System.Drawing.Point(53, 23);
            this.tableLayoutPanel17.Name = "tableLayoutPanel17";
            this.tableLayoutPanel17.RowCount = 2;
            this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel17.Size = new System.Drawing.Size(929, 657);
            this.tableLayoutPanel17.TabIndex = 0;
            // 
            // kryptonPanel31
            // 
            this.kryptonPanel31.Controls.Add(this.kryptonLabel65);
            this.kryptonPanel31.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel31.Location = new System.Drawing.Point(1, 1);
            this.kryptonPanel31.Margin = new System.Windows.Forms.Padding(1, 1, 0, 1);
            this.kryptonPanel31.Name = "kryptonPanel31";
            this.kryptonPanel31.Size = new System.Drawing.Size(119, 37);
            this.kryptonPanel31.StateCommon.Color1 = System.Drawing.Color.White;
            this.kryptonPanel31.StateCommon.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.kryptonPanel31.StateCommon.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.kryptonPanel31.TabIndex = 5;
            // 
            // kryptonLabel65
            // 
            this.kryptonLabel65.Location = new System.Drawing.Point(13, 7);
            this.kryptonLabel65.Name = "kryptonLabel65";
            this.kryptonLabel65.Size = new System.Drawing.Size(78, 23);
            this.kryptonLabel65.StateCommon.ShortText.Font = new System.Drawing.Font("仿宋_GB2312", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.kryptonLabel65.TabIndex = 0;
            this.kryptonLabel65.Values.Text = "申报方式";
            // 
            // kryptonPanel22
            // 
            this.kryptonPanel22.Controls.Add(this.rbprofessional);
            this.kryptonPanel22.Controls.Add(this.rbcompany);
            this.kryptonPanel22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel22.Location = new System.Drawing.Point(121, 1);
            this.kryptonPanel22.Margin = new System.Windows.Forms.Padding(1);
            this.kryptonPanel22.Name = "kryptonPanel22";
            this.kryptonPanel22.Size = new System.Drawing.Size(807, 37);
            this.kryptonPanel22.StateCommon.Color1 = System.Drawing.Color.White;
            this.kryptonPanel22.TabIndex = 6;
            // 
            // rbprofessional
            // 
            this.rbprofessional.Location = new System.Drawing.Point(128, 7);
            this.rbprofessional.Name = "rbprofessional";
            this.rbprofessional.Size = new System.Drawing.Size(90, 23);
            this.rbprofessional.StateCommon.ShortText.Font = new System.Drawing.Font("仿宋_GB2312", 12F);
            this.rbprofessional.TabIndex = 1;
            this.rbprofessional.Values.Text = "专家提名";
            this.rbprofessional.CheckedChanged += new System.EventHandler(this.rbprofessional_CheckedChanged);
            // 
            // rbcompany
            // 
            this.rbcompany.Checked = true;
            this.rbcompany.Location = new System.Drawing.Point(19, 8);
            this.rbcompany.Name = "rbcompany";
            this.rbcompany.Size = new System.Drawing.Size(90, 23);
            this.rbcompany.StateCommon.ShortText.Font = new System.Drawing.Font("仿宋_GB2312", 12F);
            this.rbcompany.TabIndex = 0;
            this.rbcompany.Values.Text = "单位推荐";
            this.rbcompany.CheckedChanged += new System.EventHandler(this.rbcompany_CheckedChanged);
            // 
            // requesttablehost
            // 
            this.tableLayoutPanel17.SetColumnSpan(this.requesttablehost, 2);
            this.requesttablehost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.requesttablehost.Location = new System.Drawing.Point(9, 40);
            this.requesttablehost.Margin = new System.Windows.Forms.Padding(9, 1, 1, 3);
            this.requesttablehost.Name = "requesttablehost";
            this.requesttablehost.NavigatorMode = ComponentFactory.Krypton.Navigator.NavigatorMode.Panel;
            this.requesttablehost.Pages.AddRange(new ComponentFactory.Krypton.Navigator.KryptonPage[] {
            this.kryptonPage1,
            this.kryptonPage2});
            this.requesttablehost.SelectedIndex = 0;
            this.requesttablehost.Size = new System.Drawing.Size(919, 614);
            this.requesttablehost.TabIndex = 7;
            this.requesttablehost.Text = "kryptonNavigator1";
            // 
            // kryptonPage1
            // 
            this.kryptonPage1.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kryptonPage1.Controls.Add(this.tableLayoutPanel23);
            this.kryptonPage1.Controls.Add(this.tableLayoutPanel20);
            this.kryptonPage1.Flags = 65534;
            this.kryptonPage1.LastVisibleSet = true;
            this.kryptonPage1.MinimumSize = new System.Drawing.Size(50, 50);
            this.kryptonPage1.Name = "kryptonPage1";
            this.kryptonPage1.Size = new System.Drawing.Size(919, 614);
            this.kryptonPage1.Text = "kryptonPage1";
            this.kryptonPage1.ToolTipTitle = "Page ToolTip";
            this.kryptonPage1.UniqueName = "0A1174E27C4849056C9265A4232A51C7";
            // 
            // tableLayoutPanel23
            // 
            this.tableLayoutPanel23.BorderColor = System.Drawing.Color.Empty;
            this.tableLayoutPanel23.ColumnCount = 2;
            this.tableLayoutPanel23.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel23.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel23.Controls.Add(this.btncomsave, 1, 0);
            this.tableLayoutPanel23.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel23.Location = new System.Drawing.Point(0, 122);
            this.tableLayoutPanel23.Name = "tableLayoutPanel23";
            this.tableLayoutPanel23.RowCount = 1;
            this.tableLayoutPanel23.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel23.Size = new System.Drawing.Size(919, 44);
            this.tableLayoutPanel23.TabIndex = 4;
            // 
            // btncomsave
            // 
            this.btncomsave.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btncomsave.Location = new System.Drawing.Point(802, 16);
            this.btncomsave.Name = "btncomsave";
            this.btncomsave.Size = new System.Drawing.Size(114, 25);
            this.btncomsave.TabIndex = 1;
            this.btncomsave.Values.Text = "保存";
            this.btncomsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // tableLayoutPanel20
            // 
            this.tableLayoutPanel20.BorderColor = System.Drawing.Color.Black;
            this.tableLayoutPanel20.ColumnCount = 3;
            this.tableLayoutPanel20.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel20.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel20.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel20.Controls.Add(this.btnComsel, 2, 1);
            this.tableLayoutPanel20.Controls.Add(this.kryptonPanel32, 0, 0);
            this.tableLayoutPanel20.Controls.Add(this.kryptonLabel67, 0, 1);
            this.tableLayoutPanel20.Controls.Add(this.lbcomattpath, 1, 1);
            this.tableLayoutPanel20.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel20.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel20.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.tableLayoutPanel20.Name = "tableLayoutPanel20";
            this.tableLayoutPanel20.RowCount = 3;
            this.tableLayoutPanel20.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tableLayoutPanel20.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel20.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel20.Size = new System.Drawing.Size(919, 122);
            this.tableLayoutPanel20.TabIndex = 3;
            // 
            // btnComsel
            // 
            this.btnComsel.Location = new System.Drawing.Point(772, 85);
            this.btnComsel.Name = "btnComsel";
            this.btnComsel.Size = new System.Drawing.Size(82, 29);
            this.btnComsel.TabIndex = 5;
            this.btnComsel.Values.Text = "选择附件";
            this.btnComsel.Click += new System.EventHandler(this.btnComsel_Click);
            // 
            // kryptonPanel32
            // 
            this.tableLayoutPanel20.SetColumnSpan(this.kryptonPanel32, 3);
            this.kryptonPanel32.Controls.Add(this.label5);
            this.kryptonPanel32.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel32.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel32.Margin = new System.Windows.Forms.Padding(0);
            this.kryptonPanel32.Name = "kryptonPanel32";
            this.kryptonPanel32.Size = new System.Drawing.Size(919, 82);
            this.kryptonPanel32.StateCommon.Color1 = System.Drawing.Color.White;
            this.kryptonPanel32.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("楷体_GB2312", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(919, 82);
            this.label5.TabIndex = 1;
            this.label5.Text = "单位推荐：\r\n     申报内容填写完整,并保存后，点击右上角的“预览”图标，将导出的Word文档中的推荐意见填写完整，签字盖章后，把推荐意见页扫描制作pdf文件" +
                "或者jpg图像文件上传到系统中。";
            // 
            // kryptonLabel67
            // 
            this.kryptonLabel67.Location = new System.Drawing.Point(3, 85);
            this.kryptonLabel67.Name = "kryptonLabel67";
            this.kryptonLabel67.Size = new System.Drawing.Size(45, 23);
            this.kryptonLabel67.StateCommon.ShortText.Font = new System.Drawing.Font("仿宋_GB2312", 12F);
            this.kryptonLabel67.TabIndex = 1;
            this.kryptonLabel67.Values.Text = "附件";
            // 
            // lbcomattpath
            // 
            this.lbcomattpath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbcomattpath.Location = new System.Drawing.Point(63, 85);
            this.lbcomattpath.Name = "lbcomattpath";
            this.lbcomattpath.Size = new System.Drawing.Size(703, 33);
            this.lbcomattpath.StateCommon.ShortText.Font = new System.Drawing.Font("仿宋_GB2312", 12F);
            this.lbcomattpath.TabIndex = 8;
            this.lbcomattpath.Values.Text = "0";
            this.lbcomattpath.LinkClicked += new System.EventHandler(this.lbcomattpath_LinkClicked);
            // 
            // kryptonPage2
            // 
            this.kryptonPage2.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kryptonPage2.AutoScroll = true;
            this.kryptonPage2.Controls.Add(this.tableLayoutPanel1);
            this.kryptonPage2.Controls.Add(this.tableLayoutPanel18);
            this.kryptonPage2.Flags = 65534;
            this.kryptonPage2.LastVisibleSet = true;
            this.kryptonPage2.MinimumSize = new System.Drawing.Size(50, 50);
            this.kryptonPage2.Name = "kryptonPage2";
            this.kryptonPage2.Size = new System.Drawing.Size(919, 614);
            this.kryptonPage2.Text = "kryptonPage2";
            this.kryptonPage2.ToolTipTitle = "Page ToolTip";
            this.kryptonPage2.UniqueName = "67147A7D03784FBED18BCB4642CEC653";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.Controls.Add(this.btnexpsave, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 491);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(919, 42);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // btnexpsave
            // 
            this.btnexpsave.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnexpsave.Location = new System.Drawing.Point(802, 14);
            this.btnexpsave.Name = "btnexpsave";
            this.btnexpsave.Size = new System.Drawing.Size(114, 25);
            this.btnexpsave.TabIndex = 1;
            this.btnexpsave.Values.Text = "保存";
            this.btnexpsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // tableLayoutPanel18
            // 
            this.tableLayoutPanel18.BorderColor = System.Drawing.Color.Black;
            this.tableLayoutPanel18.ColumnCount = 4;
            this.tableLayoutPanel18.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel18.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel18.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel18.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel18.Controls.Add(this.label3, 0, 9);
            this.tableLayoutPanel18.Controls.Add(this.label2, 0, 5);
            this.tableLayoutPanel18.Controls.Add(this.tableLayoutPanel21, 3, 8);
            this.tableLayoutPanel18.Controls.Add(this.kryptonLabel71, 0, 2);
            this.tableLayoutPanel18.Controls.Add(this.kryptonLabel73, 2, 2);
            this.tableLayoutPanel18.Controls.Add(this.kryptonLabel74, 0, 3);
            this.tableLayoutPanel18.Controls.Add(this.kryptonLabel75, 2, 3);
            this.tableLayoutPanel18.Controls.Add(this.kryptonLabel76, 0, 4);
            this.tableLayoutPanel18.Controls.Add(this.kryptonLabel98, 0, 6);
            this.tableLayoutPanel18.Controls.Add(this.kryptonLabel99, 2, 6);
            this.tableLayoutPanel18.Controls.Add(this.kryptonLabel101, 0, 7);
            this.tableLayoutPanel18.Controls.Add(this.kryptonLabel103, 0, 8);
            this.tableLayoutPanel18.Controls.Add(this.kryptonLabel105, 0, 10);
            this.tableLayoutPanel18.Controls.Add(this.kryptonLabel106, 2, 10);
            this.tableLayoutPanel18.Controls.Add(this.kryptonLabel107, 0, 11);
            this.tableLayoutPanel18.Controls.Add(this.kryptonLabel108, 2, 11);
            this.tableLayoutPanel18.Controls.Add(this.txtExpertName1, 1, 2);
            this.tableLayoutPanel18.Controls.Add(this.txtExpertArea1, 3, 2);
            this.tableLayoutPanel18.Controls.Add(this.txtExpertUnitPosition1, 1, 3);
            this.tableLayoutPanel18.Controls.Add(this.txtExpertUnit1, 3, 3);
            this.tableLayoutPanel18.Controls.Add(this.txtExpertName2, 1, 6);
            this.tableLayoutPanel18.Controls.Add(this.txtExpertArea2, 3, 6);
            this.tableLayoutPanel18.Controls.Add(this.txtExpertUnitPosition2, 1, 7);
            this.tableLayoutPanel18.Controls.Add(this.txtExpertUnit2, 3, 7);
            this.tableLayoutPanel18.Controls.Add(this.txtExpertName3, 1, 10);
            this.tableLayoutPanel18.Controls.Add(this.txtExpertArea3, 3, 10);
            this.tableLayoutPanel18.Controls.Add(this.txtExpertUnitPosition3, 1, 11);
            this.tableLayoutPanel18.Controls.Add(this.txtExpertUnit3, 3, 11);
            this.tableLayoutPanel18.Controls.Add(this.kryptonPanel23, 0, 0);
            this.tableLayoutPanel18.Controls.Add(this.kryptonLabel102, 2, 7);
            this.tableLayoutPanel18.Controls.Add(this.tableLayoutPanel19, 3, 4);
            this.tableLayoutPanel18.Controls.Add(this.tableLayoutPanel22, 3, 12);
            this.tableLayoutPanel18.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel18.Controls.Add(this.kryptonLabel109, 0, 12);
            this.tableLayoutPanel18.Controls.Add(this.lbexp1attpath, 1, 4);
            this.tableLayoutPanel18.Controls.Add(this.lbexp2attpath, 1, 8);
            this.tableLayoutPanel18.Controls.Add(this.lbexp3attpath, 1, 12);
            this.tableLayoutPanel18.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel18.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel18.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.tableLayoutPanel18.Name = "tableLayoutPanel18";
            this.tableLayoutPanel18.RowCount = 14;
            this.tableLayoutPanel18.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel18.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel18.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel18.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel18.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel18.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel18.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel18.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel18.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel18.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel18.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel18.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel18.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel18.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel18.Size = new System.Drawing.Size(919, 491);
            this.tableLayoutPanel18.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.tableLayoutPanel18.SetColumnSpan(this.label3, 4);
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("黑体", 12F);
            this.label3.Location = new System.Drawing.Point(3, 351);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 1, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(913, 34);
            this.label3.TabIndex = 39;
            this.label3.Text = "专家三";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.tableLayoutPanel18.SetColumnSpan(this.label2, 4);
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(3, 211);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(913, 33);
            this.label2.TabIndex = 38;
            this.label2.Text = "专家二";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel21
            // 
            this.tableLayoutPanel21.ColumnCount = 2;
            this.tableLayoutPanel21.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel21.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel21.Controls.Add(this.btnexp2rm, 1, 0);
            this.tableLayoutPanel21.Controls.Add(this.btnexp2sel, 0, 0);
            this.tableLayoutPanel21.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel21.Location = new System.Drawing.Point(582, 318);
            this.tableLayoutPanel21.Name = "tableLayoutPanel21";
            this.tableLayoutPanel21.RowCount = 1;
            this.tableLayoutPanel21.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel21.Size = new System.Drawing.Size(200, 29);
            this.tableLayoutPanel21.TabIndex = 35;
            // 
            // btnexp2rm
            // 
            this.btnexp2rm.Location = new System.Drawing.Point(95, 0);
            this.btnexp2rm.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnexp2rm.Name = "btnexp2rm";
            this.btnexp2rm.Size = new System.Drawing.Size(90, 29);
            this.btnexp2rm.TabIndex = 0;
            this.btnexp2rm.Values.Text = "移除附件";
            this.btnexp2rm.Visible = false;
            // 
            // btnexp2sel
            // 
            this.btnexp2sel.Location = new System.Drawing.Point(0, 0);
            this.btnexp2sel.Margin = new System.Windows.Forms.Padding(0);
            this.btnexp2sel.Name = "btnexp2sel";
            this.btnexp2sel.Size = new System.Drawing.Size(90, 28);
            this.btnexp2sel.TabIndex = 1;
            this.btnexp2sel.Values.Text = "选择附件";
            this.btnexp2sel.Click += new System.EventHandler(this.btnexp2sel_Click);
            // 
            // kryptonLabel71
            // 
            this.kryptonLabel71.Location = new System.Drawing.Point(3, 108);
            this.kryptonLabel71.Name = "kryptonLabel71";
            this.kryptonLabel71.Size = new System.Drawing.Size(86, 23);
            this.kryptonLabel71.StateCommon.ShortText.Font = new System.Drawing.Font("仿宋_GB2312", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.kryptonLabel71.TabIndex = 1;
            this.kryptonLabel71.Values.Text = "专家姓名:";
            // 
            // kryptonLabel73
            // 
            this.kryptonLabel73.Location = new System.Drawing.Point(462, 108);
            this.kryptonLabel73.Name = "kryptonLabel73";
            this.kryptonLabel73.Size = new System.Drawing.Size(86, 23);
            this.kryptonLabel73.StateCommon.ShortText.Font = new System.Drawing.Font("仿宋_GB2312", 12F);
            this.kryptonLabel73.TabIndex = 2;
            this.kryptonLabel73.Values.Text = "研究领域:";
            // 
            // kryptonLabel74
            // 
            this.kryptonLabel74.Location = new System.Drawing.Point(3, 143);
            this.kryptonLabel74.Name = "kryptonLabel74";
            this.kryptonLabel74.Size = new System.Drawing.Size(94, 23);
            this.kryptonLabel74.StateCommon.ShortText.Font = new System.Drawing.Font("仿宋_GB2312", 12F);
            this.kryptonLabel74.TabIndex = 3;
            this.kryptonLabel74.Values.Text = "职务/职称:";
            // 
            // kryptonLabel75
            // 
            this.kryptonLabel75.Location = new System.Drawing.Point(462, 143);
            this.kryptonLabel75.Name = "kryptonLabel75";
            this.kryptonLabel75.Size = new System.Drawing.Size(86, 23);
            this.kryptonLabel75.StateCommon.ShortText.Font = new System.Drawing.Font("仿宋_GB2312", 12F);
            this.kryptonLabel75.TabIndex = 4;
            this.kryptonLabel75.Values.Text = "工作单位:";
            // 
            // kryptonLabel76
            // 
            this.kryptonLabel76.Location = new System.Drawing.Point(3, 178);
            this.kryptonLabel76.Name = "kryptonLabel76";
            this.kryptonLabel76.Size = new System.Drawing.Size(45, 23);
            this.kryptonLabel76.StateCommon.ShortText.Font = new System.Drawing.Font("仿宋_GB2312", 12F);
            this.kryptonLabel76.TabIndex = 5;
            this.kryptonLabel76.Values.Text = "附件";
            // 
            // kryptonLabel98
            // 
            this.kryptonLabel98.Location = new System.Drawing.Point(3, 248);
            this.kryptonLabel98.Name = "kryptonLabel98";
            this.kryptonLabel98.Size = new System.Drawing.Size(78, 23);
            this.kryptonLabel98.StateCommon.ShortText.Font = new System.Drawing.Font("仿宋_GB2312", 12F);
            this.kryptonLabel98.TabIndex = 6;
            this.kryptonLabel98.Values.Text = "专家姓名";
            // 
            // kryptonLabel99
            // 
            this.kryptonLabel99.Location = new System.Drawing.Point(462, 248);
            this.kryptonLabel99.Name = "kryptonLabel99";
            this.kryptonLabel99.Size = new System.Drawing.Size(86, 23);
            this.kryptonLabel99.StateCommon.ShortText.Font = new System.Drawing.Font("仿宋_GB2312", 12F);
            this.kryptonLabel99.TabIndex = 7;
            this.kryptonLabel99.Values.Text = "研究领域:";
            // 
            // kryptonLabel101
            // 
            this.kryptonLabel101.Location = new System.Drawing.Point(3, 283);
            this.kryptonLabel101.Name = "kryptonLabel101";
            this.kryptonLabel101.Size = new System.Drawing.Size(94, 23);
            this.kryptonLabel101.StateCommon.ShortText.Font = new System.Drawing.Font("仿宋_GB2312", 12F);
            this.kryptonLabel101.TabIndex = 9;
            this.kryptonLabel101.Values.Text = "职务/职称:";
            // 
            // kryptonLabel103
            // 
            this.kryptonLabel103.Location = new System.Drawing.Point(3, 318);
            this.kryptonLabel103.Name = "kryptonLabel103";
            this.kryptonLabel103.Size = new System.Drawing.Size(45, 23);
            this.kryptonLabel103.StateCommon.ShortText.Font = new System.Drawing.Font("仿宋_GB2312", 12F);
            this.kryptonLabel103.TabIndex = 11;
            this.kryptonLabel103.Values.Text = "附件";
            // 
            // kryptonLabel105
            // 
            this.kryptonLabel105.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonLabel105.Location = new System.Drawing.Point(3, 388);
            this.kryptonLabel105.Name = "kryptonLabel105";
            this.kryptonLabel105.Size = new System.Drawing.Size(114, 29);
            this.kryptonLabel105.StateCommon.ShortText.Font = new System.Drawing.Font("仿宋_GB2312", 12F);
            this.kryptonLabel105.TabIndex = 13;
            this.kryptonLabel105.Values.Text = "专家姓名";
            // 
            // kryptonLabel106
            // 
            this.kryptonLabel106.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonLabel106.Location = new System.Drawing.Point(462, 388);
            this.kryptonLabel106.Name = "kryptonLabel106";
            this.kryptonLabel106.Size = new System.Drawing.Size(114, 29);
            this.kryptonLabel106.StateCommon.ShortText.Font = new System.Drawing.Font("仿宋_GB2312", 12F);
            this.kryptonLabel106.TabIndex = 14;
            this.kryptonLabel106.Values.Text = "研究领域:";
            // 
            // kryptonLabel107
            // 
            this.kryptonLabel107.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonLabel107.Location = new System.Drawing.Point(3, 423);
            this.kryptonLabel107.Name = "kryptonLabel107";
            this.kryptonLabel107.Size = new System.Drawing.Size(114, 29);
            this.kryptonLabel107.StateCommon.ShortText.Font = new System.Drawing.Font("仿宋_GB2312", 12F);
            this.kryptonLabel107.TabIndex = 15;
            this.kryptonLabel107.Values.Text = "职务/职称:";
            // 
            // kryptonLabel108
            // 
            this.kryptonLabel108.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonLabel108.Location = new System.Drawing.Point(462, 423);
            this.kryptonLabel108.Name = "kryptonLabel108";
            this.kryptonLabel108.Size = new System.Drawing.Size(114, 29);
            this.kryptonLabel108.StateCommon.ShortText.Font = new System.Drawing.Font("仿宋_GB2312", 12F);
            this.kryptonLabel108.TabIndex = 16;
            this.kryptonLabel108.Values.Text = "工作单位:";
            // 
            // txtExpertName1
            // 
            this.txtExpertName1.AlwaysActive = false;
            this.txtExpertName1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtExpertName1.Location = new System.Drawing.Point(123, 108);
            this.txtExpertName1.Name = "txtExpertName1";
            this.txtExpertName1.Size = new System.Drawing.Size(333, 24);
            this.txtExpertName1.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtExpertName1.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtExpertName1.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.txtExpertName1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtExpertName1.StateCommon.Content.Font = new System.Drawing.Font("仿宋_GB2312", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtExpertName1.TabIndex = 21;
            // 
            // txtExpertArea1
            // 
            this.txtExpertArea1.AlwaysActive = false;
            this.txtExpertArea1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtExpertArea1.Location = new System.Drawing.Point(582, 108);
            this.txtExpertArea1.Name = "txtExpertArea1";
            this.txtExpertArea1.Size = new System.Drawing.Size(334, 24);
            this.txtExpertArea1.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtExpertArea1.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtExpertArea1.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.txtExpertArea1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtExpertArea1.StateCommon.Content.Font = new System.Drawing.Font("仿宋_GB2312", 12F);
            this.txtExpertArea1.TabIndex = 22;
            // 
            // txtExpertUnitPosition1
            // 
            this.txtExpertUnitPosition1.AlwaysActive = false;
            this.txtExpertUnitPosition1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtExpertUnitPosition1.Location = new System.Drawing.Point(123, 143);
            this.txtExpertUnitPosition1.Name = "txtExpertUnitPosition1";
            this.txtExpertUnitPosition1.Size = new System.Drawing.Size(333, 24);
            this.txtExpertUnitPosition1.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtExpertUnitPosition1.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtExpertUnitPosition1.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.txtExpertUnitPosition1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtExpertUnitPosition1.StateCommon.Content.Font = new System.Drawing.Font("仿宋_GB2312", 12F);
            this.txtExpertUnitPosition1.TabIndex = 23;
            // 
            // txtExpertUnit1
            // 
            this.txtExpertUnit1.AlwaysActive = false;
            this.txtExpertUnit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtExpertUnit1.Location = new System.Drawing.Point(582, 143);
            this.txtExpertUnit1.Name = "txtExpertUnit1";
            this.txtExpertUnit1.Size = new System.Drawing.Size(334, 24);
            this.txtExpertUnit1.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtExpertUnit1.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtExpertUnit1.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.txtExpertUnit1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtExpertUnit1.StateCommon.Content.Font = new System.Drawing.Font("仿宋_GB2312", 12F);
            this.txtExpertUnit1.TabIndex = 24;
            // 
            // txtExpertName2
            // 
            this.txtExpertName2.AlwaysActive = false;
            this.txtExpertName2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtExpertName2.Location = new System.Drawing.Point(123, 248);
            this.txtExpertName2.Name = "txtExpertName2";
            this.txtExpertName2.Size = new System.Drawing.Size(333, 24);
            this.txtExpertName2.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtExpertName2.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtExpertName2.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.txtExpertName2.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtExpertName2.StateCommon.Content.Font = new System.Drawing.Font("仿宋_GB2312", 12F);
            this.txtExpertName2.TabIndex = 25;
            // 
            // txtExpertArea2
            // 
            this.txtExpertArea2.AlwaysActive = false;
            this.txtExpertArea2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtExpertArea2.Location = new System.Drawing.Point(582, 248);
            this.txtExpertArea2.Name = "txtExpertArea2";
            this.txtExpertArea2.Size = new System.Drawing.Size(334, 24);
            this.txtExpertArea2.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtExpertArea2.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtExpertArea2.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.txtExpertArea2.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtExpertArea2.StateCommon.Content.Font = new System.Drawing.Font("仿宋_GB2312", 12F);
            this.txtExpertArea2.TabIndex = 26;
            // 
            // txtExpertUnitPosition2
            // 
            this.txtExpertUnitPosition2.AlwaysActive = false;
            this.txtExpertUnitPosition2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtExpertUnitPosition2.Location = new System.Drawing.Point(123, 283);
            this.txtExpertUnitPosition2.Name = "txtExpertUnitPosition2";
            this.txtExpertUnitPosition2.Size = new System.Drawing.Size(333, 24);
            this.txtExpertUnitPosition2.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtExpertUnitPosition2.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtExpertUnitPosition2.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.txtExpertUnitPosition2.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtExpertUnitPosition2.StateCommon.Content.Font = new System.Drawing.Font("仿宋_GB2312", 12F);
            this.txtExpertUnitPosition2.TabIndex = 27;
            // 
            // txtExpertUnit2
            // 
            this.txtExpertUnit2.AlwaysActive = false;
            this.txtExpertUnit2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtExpertUnit2.Location = new System.Drawing.Point(582, 283);
            this.txtExpertUnit2.Name = "txtExpertUnit2";
            this.txtExpertUnit2.Size = new System.Drawing.Size(334, 24);
            this.txtExpertUnit2.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtExpertUnit2.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtExpertUnit2.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.txtExpertUnit2.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtExpertUnit2.StateCommon.Content.Font = new System.Drawing.Font("仿宋_GB2312", 12F);
            this.txtExpertUnit2.TabIndex = 28;
            // 
            // txtExpertName3
            // 
            this.txtExpertName3.AlwaysActive = false;
            this.txtExpertName3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtExpertName3.Location = new System.Drawing.Point(123, 388);
            this.txtExpertName3.Name = "txtExpertName3";
            this.txtExpertName3.Size = new System.Drawing.Size(333, 24);
            this.txtExpertName3.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtExpertName3.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtExpertName3.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.txtExpertName3.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtExpertName3.StateCommon.Content.Font = new System.Drawing.Font("仿宋_GB2312", 12F);
            this.txtExpertName3.TabIndex = 29;
            // 
            // txtExpertArea3
            // 
            this.txtExpertArea3.AlwaysActive = false;
            this.txtExpertArea3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtExpertArea3.Location = new System.Drawing.Point(582, 388);
            this.txtExpertArea3.Name = "txtExpertArea3";
            this.txtExpertArea3.Size = new System.Drawing.Size(334, 24);
            this.txtExpertArea3.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtExpertArea3.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtExpertArea3.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.txtExpertArea3.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtExpertArea3.StateCommon.Content.Font = new System.Drawing.Font("仿宋_GB2312", 12F);
            this.txtExpertArea3.TabIndex = 30;
            // 
            // txtExpertUnitPosition3
            // 
            this.txtExpertUnitPosition3.AlwaysActive = false;
            this.txtExpertUnitPosition3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtExpertUnitPosition3.Location = new System.Drawing.Point(123, 423);
            this.txtExpertUnitPosition3.Name = "txtExpertUnitPosition3";
            this.txtExpertUnitPosition3.Size = new System.Drawing.Size(333, 24);
            this.txtExpertUnitPosition3.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtExpertUnitPosition3.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtExpertUnitPosition3.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.txtExpertUnitPosition3.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtExpertUnitPosition3.StateCommon.Content.Font = new System.Drawing.Font("仿宋_GB2312", 12F);
            this.txtExpertUnitPosition3.TabIndex = 31;
            // 
            // txtExpertUnit3
            // 
            this.txtExpertUnit3.AlwaysActive = false;
            this.txtExpertUnit3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtExpertUnit3.Location = new System.Drawing.Point(582, 423);
            this.txtExpertUnit3.Name = "txtExpertUnit3";
            this.txtExpertUnit3.Size = new System.Drawing.Size(334, 24);
            this.txtExpertUnit3.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtExpertUnit3.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtExpertUnit3.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.txtExpertUnit3.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtExpertUnit3.StateCommon.Content.Font = new System.Drawing.Font("仿宋_GB2312", 12F);
            this.txtExpertUnit3.TabIndex = 32;
            // 
            // kryptonPanel23
            // 
            this.tableLayoutPanel18.SetColumnSpan(this.kryptonPanel23, 4);
            this.kryptonPanel23.Controls.Add(this.label4);
            this.kryptonPanel23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel23.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel23.Margin = new System.Windows.Forms.Padding(0);
            this.kryptonPanel23.Name = "kryptonPanel23";
            this.kryptonPanel23.Size = new System.Drawing.Size(919, 70);
            this.kryptonPanel23.StateCommon.Color1 = System.Drawing.Color.White;
            this.kryptonPanel23.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("楷体_GB2312", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(919, 70);
            this.label4.TabIndex = 1;
            this.label4.Text = "专家提名：\r\n    申报内容填写完整，填写一名及以上专家信息，并保存后，点击右上角的“预览”图标，将导出的Word文档中的提名意见填写完整，专家签字后，把提名意" +
                "见页扫描制作pdf文件或者jpg图像文件上传到系统中。";
            // 
            // kryptonLabel102
            // 
            this.kryptonLabel102.Location = new System.Drawing.Point(462, 283);
            this.kryptonLabel102.Name = "kryptonLabel102";
            this.kryptonLabel102.Size = new System.Drawing.Size(86, 23);
            this.kryptonLabel102.StateCommon.ShortText.Font = new System.Drawing.Font("仿宋_GB2312", 12F);
            this.kryptonLabel102.TabIndex = 10;
            this.kryptonLabel102.Values.Text = "工作单位:";
            // 
            // tableLayoutPanel19
            // 
            this.tableLayoutPanel19.ColumnCount = 2;
            this.tableLayoutPanel19.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel19.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel19.Controls.Add(this.btnexp1rm, 1, 0);
            this.tableLayoutPanel19.Controls.Add(this.btnexp1sel, 0, 0);
            this.tableLayoutPanel19.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel19.Location = new System.Drawing.Point(582, 178);
            this.tableLayoutPanel19.Name = "tableLayoutPanel19";
            this.tableLayoutPanel19.RowCount = 1;
            this.tableLayoutPanel19.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel19.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel19.Size = new System.Drawing.Size(197, 29);
            this.tableLayoutPanel19.TabIndex = 34;
            // 
            // btnexp1rm
            // 
            this.btnexp1rm.Location = new System.Drawing.Point(95, 0);
            this.btnexp1rm.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnexp1rm.Name = "btnexp1rm";
            this.btnexp1rm.Size = new System.Drawing.Size(90, 29);
            this.btnexp1rm.TabIndex = 0;
            this.btnexp1rm.Values.Text = "移除附件";
            this.btnexp1rm.Visible = false;
            // 
            // btnexp1sel
            // 
            this.btnexp1sel.Location = new System.Drawing.Point(0, 0);
            this.btnexp1sel.Margin = new System.Windows.Forms.Padding(0);
            this.btnexp1sel.Name = "btnexp1sel";
            this.btnexp1sel.Size = new System.Drawing.Size(90, 29);
            this.btnexp1sel.TabIndex = 1;
            this.btnexp1sel.Values.Text = "选择附件";
            this.btnexp1sel.Click += new System.EventHandler(this.btnexp1sel_Click);
            // 
            // tableLayoutPanel22
            // 
            this.tableLayoutPanel22.ColumnCount = 2;
            this.tableLayoutPanel22.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel22.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel22.Controls.Add(this.btnexp3rm, 1, 0);
            this.tableLayoutPanel22.Controls.Add(this.btnexp3sel, 0, 0);
            this.tableLayoutPanel22.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel22.Location = new System.Drawing.Point(582, 458);
            this.tableLayoutPanel22.Name = "tableLayoutPanel22";
            this.tableLayoutPanel22.RowCount = 1;
            this.tableLayoutPanel22.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel22.Size = new System.Drawing.Size(200, 29);
            this.tableLayoutPanel22.TabIndex = 36;
            // 
            // btnexp3rm
            // 
            this.btnexp3rm.Location = new System.Drawing.Point(95, 0);
            this.btnexp3rm.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnexp3rm.Name = "btnexp3rm";
            this.btnexp3rm.Size = new System.Drawing.Size(90, 29);
            this.btnexp3rm.TabIndex = 0;
            this.btnexp3rm.Values.Text = "移除附件";
            this.btnexp3rm.Visible = false;
            // 
            // btnexp3sel
            // 
            this.btnexp3sel.Location = new System.Drawing.Point(0, 0);
            this.btnexp3sel.Margin = new System.Windows.Forms.Padding(0);
            this.btnexp3sel.Name = "btnexp3sel";
            this.btnexp3sel.Size = new System.Drawing.Size(90, 29);
            this.btnexp3sel.TabIndex = 1;
            this.btnexp3sel.Values.Text = "选择附件";
            this.btnexp3sel.Click += new System.EventHandler(this.btnexp3sel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tableLayoutPanel18.SetColumnSpan(this.label1, 4);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(3, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 1, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(913, 34);
            this.label1.TabIndex = 37;
            this.label1.Text = "专家一";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // kryptonLabel109
            // 
            this.kryptonLabel109.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonLabel109.Location = new System.Drawing.Point(3, 458);
            this.kryptonLabel109.Name = "kryptonLabel109";
            this.kryptonLabel109.Size = new System.Drawing.Size(114, 29);
            this.kryptonLabel109.StateCommon.ShortText.Font = new System.Drawing.Font("仿宋_GB2312", 12F);
            this.kryptonLabel109.TabIndex = 17;
            this.kryptonLabel109.Values.Text = "附件";
            // 
            // lbexp1attpath
            // 
            this.lbexp1attpath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbexp1attpath.Location = new System.Drawing.Point(123, 178);
            this.lbexp1attpath.Name = "lbexp1attpath";
            this.lbexp1attpath.Size = new System.Drawing.Size(333, 29);
            this.lbexp1attpath.StateCommon.ShortText.Font = new System.Drawing.Font("仿宋_GB2312", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbexp1attpath.TabIndex = 43;
            this.lbexp1attpath.Values.Text = "kryptonLinkLabel1";
            this.lbexp1attpath.LinkClicked += new System.EventHandler(this.lbexp1attpath_LinkClicked);
            // 
            // lbexp2attpath
            // 
            this.lbexp2attpath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbexp2attpath.Location = new System.Drawing.Point(123, 318);
            this.lbexp2attpath.Name = "lbexp2attpath";
            this.lbexp2attpath.Size = new System.Drawing.Size(333, 29);
            this.lbexp2attpath.StateCommon.ShortText.Font = new System.Drawing.Font("仿宋_GB2312", 12F);
            this.lbexp2attpath.TabIndex = 44;
            this.lbexp2attpath.Values.Text = "kryptonLinkLabel1";
            this.lbexp2attpath.LinkClicked += new System.EventHandler(this.lbexp2attpath_LinkClicked);
            // 
            // lbexp3attpath
            // 
            this.lbexp3attpath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbexp3attpath.Location = new System.Drawing.Point(123, 458);
            this.lbexp3attpath.Name = "lbexp3attpath";
            this.lbexp3attpath.Size = new System.Drawing.Size(333, 29);
            this.lbexp3attpath.StateCommon.ShortText.Font = new System.Drawing.Font("仿宋_GB2312", 12F);
            this.lbexp3attpath.TabIndex = 45;
            this.lbexp3attpath.Values.Text = "kryptonLinkLabel1";
            this.lbexp3attpath.LinkClicked += new System.EventHandler(this.lbexp3attpath_LinkClicked);
            // 
            // frmRecommendInfo
            // 
            this.Controls.Add(this.tableLayoutPanel16);
            this.Name = "frmRecommendInfo";
            this.Size = new System.Drawing.Size(1035, 692);
            this.Leave += new System.EventHandler(this.frmRecommendInfo_Leave);
            this.tableLayoutPanel16.ResumeLayout(false);
            this.tableLayoutPanel17.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel31)).EndInit();
            this.kryptonPanel31.ResumeLayout(false);
            this.kryptonPanel31.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel22)).EndInit();
            this.kryptonPanel22.ResumeLayout(false);
            this.kryptonPanel22.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.requesttablehost)).EndInit();
            this.requesttablehost.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage1)).EndInit();
            this.kryptonPage1.ResumeLayout(false);
            this.tableLayoutPanel23.ResumeLayout(false);
            this.tableLayoutPanel20.ResumeLayout(false);
            this.tableLayoutPanel20.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel32)).EndInit();
            this.kryptonPanel32.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage2)).EndInit();
            this.kryptonPage2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel18.ResumeLayout(false);
            this.tableLayoutPanel18.PerformLayout();
            this.tableLayoutPanel21.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel23)).EndInit();
            this.kryptonPanel23.ResumeLayout(false);
            this.tableLayoutPanel19.ResumeLayout(false);
            this.tableLayoutPanel22.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		public frmRecommendInfo()
		{
			this.InitializeComponent();
		}

		protected override void OnLoad(EventArgs e)
		{
			this.RefreshCall();
			base.OnLoad(e);
		}

		private void SetContent()
		{
			if (this._rinfo.ApplicationType == "专家提名")
			{
				this.rbprofessional.Checked = true;
			}
			else
			{
				this.rbcompany.Checked = true;
			}
			this.lbcomattpath.Text = this._rinfo.RAttachmentInfo.UploadName;
			this.txtExpertName1.Text = this._rinfo.ExperInfoList[0].ExpertName;
			this.txtExpertArea1.Text = this._rinfo.ExperInfoList[0].ExpertArea;
			this.txtExpertUnitPosition1.Text = this._rinfo.ExperInfoList[0].ExpertUnitPosition;
			this.txtExpertUnit1.Text = this._rinfo.ExperInfoList[0].ExpertUnit;
			this.lbexp1attpath.Text = this._rinfo.ExperInfoList[0].EAttachmentInfo.UploadName;
			this.txtExpertName2.Text = this._rinfo.ExperInfoList[1].ExpertName;
			this.txtExpertArea2.Text = this._rinfo.ExperInfoList[1].ExpertArea;
			this.txtExpertUnitPosition2.Text = this._rinfo.ExperInfoList[1].ExpertUnitPosition;
			this.txtExpertUnit2.Text = this._rinfo.ExperInfoList[1].ExpertUnit;
			this.lbexp2attpath.Text = this._rinfo.ExperInfoList[1].EAttachmentInfo.UploadName;
			this.txtExpertName3.Text = this._rinfo.ExperInfoList[2].ExpertName;
			this.txtExpertArea3.Text = this._rinfo.ExperInfoList[2].ExpertArea;
			this.txtExpertUnitPosition3.Text = this._rinfo.ExperInfoList[2].ExpertUnitPosition;
			this.txtExpertUnit3.Text = this._rinfo.ExperInfoList[2].ExpertUnit;
			this.lbexp3attpath.Text = this._rinfo.ExperInfoList[2].EAttachmentInfo.UploadName;
		}

		private void rbcompany_CheckedChanged(object sender, EventArgs e)
		{
			this.requesttablehost.SelectedIndex = 0;
			this._rinfo.ApplicationType = "单位推荐";
		}

		private void rbprofessional_CheckedChanged(object sender, EventArgs e)
		{
			this.requesttablehost.SelectedIndex = 1;
			this._rinfo.ApplicationType = "专家提名";
		}

		private void btnComsel_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "Adobe PDF 文件,JPEG图像文件|*.pdf;*.jpg;*.jpeg";
			openFileDialog.Multiselect = false;
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				this.lbcomattpath.Text = openFileDialog.FileName;
			}
		}

		private void btnexp1sel_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Multiselect = false;
			openFileDialog.Filter = "Adobe PDF 文件,JPEG图像文件|*.pdf;*.jpg;*.jpeg";
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				this.lbexp1attpath.Text = openFileDialog.FileName;
			}
		}

		private void btnexp2sel_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Multiselect = false;
			openFileDialog.Filter = "Adobe PDF 文件,JPEG图像文件|*.pdf;*.jpg;*.jpeg";
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				this.lbexp2attpath.Text = openFileDialog.FileName;
			}
		}

		private void btnexp3sel_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Multiselect = false;
			openFileDialog.Filter = "Adobe PDF 文件,JPEG图像文件|*.pdf;*.jpg;*.jpeg";
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				this.lbexp3attpath.Text = openFileDialog.FileName;
			}
		}

		private RecommendInfo GetCurrentRecommend()
		{
			RecommendInfo recommendInfo = new RecommendInfo();
			if (this.requesttablehost.SelectedIndex == 0)
			{
				recommendInfo.ApplicationType = "单位推荐";
				if (this.lbcomattpath.Text == "")
				{
					recommendInfo.RAttachmentInfo.UploadName = "";
					recommendInfo.RAttachmentInfo.StoreName = "";
					recommendInfo.RAttachmentInfo.UploadFullPath = "";
				}
				else if (this.lbcomattpath.Text == this._rinfo.RAttachmentInfo.UploadName)
				{
					recommendInfo.RAttachmentInfo.UploadName = this._rinfo.RAttachmentInfo.UploadName;
					recommendInfo.RAttachmentInfo.StoreName = this._rinfo.RAttachmentInfo.StoreName;
					recommendInfo.RAttachmentInfo.UploadFullPath = "";
				}
				else if (File.Exists(this.lbcomattpath.Text))
				{
					recommendInfo.RAttachmentInfo.UploadName = Path.GetFileName(this.lbcomattpath.Text);
					recommendInfo.RAttachmentInfo.UploadFullPath = this.lbcomattpath.Text;
					recommendInfo.RAttachmentInfo.StoreName = Path.GetFileNameWithoutExtension(this.lbcomattpath.Text) + "_" + DateTime.Now.ToString("yyyy_MM_dd_hh_mm_ss") + Path.GetExtension(this.lbcomattpath.Text);
				}
				recommendInfo.ExperInfoList.Add(new ExpertInfo());
				recommendInfo.ExperInfoList.Add(new ExpertInfo());
				recommendInfo.ExperInfoList.Add(new ExpertInfo());
			}
			else
			{
				recommendInfo.ApplicationType = "专家提名";
				recommendInfo.ExperInfoList.Add(new ExpertInfo());
				recommendInfo.ExperInfoList[0].ExpertName = this.txtExpertName1.Text;
				recommendInfo.ExperInfoList[0].ExpertArea = this.txtExpertArea1.Text;
				recommendInfo.ExperInfoList[0].ExpertUnitPosition = this.txtExpertUnitPosition1.Text;
				recommendInfo.ExperInfoList[0].ExpertUnit = this.txtExpertUnit1.Text;
				if (this.lbexp1attpath.Text == "")
				{
					recommendInfo.ExperInfoList[0].EAttachmentInfo.UploadName = "";
					recommendInfo.ExperInfoList[0].EAttachmentInfo.StoreName = "";
					recommendInfo.ExperInfoList[0].EAttachmentInfo.UploadFullPath = "";
				}
				else if (this.lbexp1attpath.Text == this._rinfo.ExperInfoList[0].EAttachmentInfo.UploadName)
				{
					recommendInfo.ExperInfoList[0].EAttachmentInfo.UploadName = this._rinfo.ExperInfoList[0].EAttachmentInfo.UploadName;
					recommendInfo.ExperInfoList[0].EAttachmentInfo.StoreName = this._rinfo.ExperInfoList[0].EAttachmentInfo.StoreName;
					recommendInfo.ExperInfoList[0].EAttachmentInfo.UploadFullPath = "";
				}
				else if (File.Exists(this.lbexp1attpath.Text))
				{
					recommendInfo.ExperInfoList[0].EAttachmentInfo.UploadName = Path.GetFileName(this.lbexp1attpath.Text);
					recommendInfo.ExperInfoList[0].EAttachmentInfo.UploadFullPath = this.lbexp1attpath.Text;
					recommendInfo.ExperInfoList[0].EAttachmentInfo.StoreName = Path.GetFileNameWithoutExtension(this.lbexp1attpath.Text) + "_" + DateTime.Now.ToString("yyyy_MM_dd_hh_mm_ss") + Path.GetExtension(this.lbexp1attpath.Text);
				}
				recommendInfo.ExperInfoList.Add(new ExpertInfo());
				recommendInfo.ExperInfoList[1].ExpertName = this.txtExpertName2.Text;
				recommendInfo.ExperInfoList[1].ExpertArea = this.txtExpertArea2.Text;
				recommendInfo.ExperInfoList[1].ExpertUnitPosition = this.txtExpertUnitPosition2.Text;
				recommendInfo.ExperInfoList[1].ExpertUnit = this.txtExpertUnit2.Text;
				if (this.lbexp2attpath.Text == "")
				{
					recommendInfo.ExperInfoList[1].EAttachmentInfo.UploadName = "";
					recommendInfo.ExperInfoList[1].EAttachmentInfo.StoreName = "";
					recommendInfo.ExperInfoList[1].EAttachmentInfo.UploadFullPath = "";
				}
				else if (this.lbexp2attpath.Text == this._rinfo.ExperInfoList[1].EAttachmentInfo.UploadName)
				{
					recommendInfo.ExperInfoList[1].EAttachmentInfo.UploadName = this._rinfo.ExperInfoList[1].EAttachmentInfo.UploadName;
					recommendInfo.ExperInfoList[1].EAttachmentInfo.StoreName = this._rinfo.ExperInfoList[1].EAttachmentInfo.StoreName;
					recommendInfo.ExperInfoList[1].EAttachmentInfo.UploadFullPath = "";
				}
				else if (File.Exists(this.lbexp2attpath.Text))
				{
					recommendInfo.ExperInfoList[1].EAttachmentInfo.UploadName = Path.GetFileName(this.lbexp2attpath.Text);
					recommendInfo.ExperInfoList[1].EAttachmentInfo.UploadFullPath = this.lbexp2attpath.Text;
					recommendInfo.ExperInfoList[1].EAttachmentInfo.StoreName = Path.GetFileNameWithoutExtension(this.lbexp2attpath.Text) + "_" + DateTime.Now.ToString("yyyy_MM_dd_hh_mm_ss") + Path.GetExtension(this.lbexp2attpath.Text);
				}
				recommendInfo.ExperInfoList.Add(new ExpertInfo());
				recommendInfo.ExperInfoList[2].ExpertName = this.txtExpertName3.Text;
				recommendInfo.ExperInfoList[2].ExpertArea = this.txtExpertArea3.Text;
				recommendInfo.ExperInfoList[2].ExpertUnitPosition = this.txtExpertUnitPosition3.Text;
				recommendInfo.ExperInfoList[2].ExpertUnit = this.txtExpertUnit3.Text;
				if (this.lbexp3attpath.Text == "")
				{
					recommendInfo.ExperInfoList[2].EAttachmentInfo.UploadName = "";
					recommendInfo.ExperInfoList[2].EAttachmentInfo.StoreName = "";
					recommendInfo.ExperInfoList[2].EAttachmentInfo.UploadFullPath = "";
				}
				else if (this.lbexp3attpath.Text == this._rinfo.ExperInfoList[2].EAttachmentInfo.UploadName)
				{
					recommendInfo.ExperInfoList[2].EAttachmentInfo.UploadName = this._rinfo.ExperInfoList[2].EAttachmentInfo.UploadName;
					recommendInfo.ExperInfoList[2].EAttachmentInfo.StoreName = this._rinfo.ExperInfoList[2].EAttachmentInfo.StoreName;
					recommendInfo.ExperInfoList[2].EAttachmentInfo.UploadFullPath = "";
				}
				else if (File.Exists(this.lbexp3attpath.Text))
				{
					recommendInfo.ExperInfoList[2].EAttachmentInfo.UploadName = Path.GetFileName(this.lbexp3attpath.Text);
					recommendInfo.ExperInfoList[2].EAttachmentInfo.UploadFullPath = this.lbexp3attpath.Text;
					recommendInfo.ExperInfoList[2].EAttachmentInfo.StoreName = Path.GetFileNameWithoutExtension(this.lbexp3attpath.Text) + "_" + DateTime.Now.ToString("yyyy_MM_dd_hh_mm_ss") + Path.GetExtension(this.lbexp3attpath.Text);
				}
			}
			return recommendInfo;
		}

		private bool SaveProgress()
		{
			RecommendInfo currentRecommend = this.GetCurrentRecommend();
			this.OnSaveCheckPassedEvent(EventArgs.Empty);
			this._irecommendInfoService.UpdateRecommendInfo(currentRecommend, this._rinfo);
			this._rinfo = this._irecommendInfoService.GetRecommendInfo();
			this.SetContent();
			return true;
		}

		private void btnsave_Click(object sender, EventArgs e)
		{
			if (!this.SaveProgress())
			{
				return;
			}
			this.issaved = true;
			MessageBox.Show("保存完成!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		public override void RefreshCall()
		{
			this._rinfo = this._irecommendInfoService.GetRecommendInfo();
			if (this._rinfo == null)
			{
				this._rinfo = new RecommendInfo();
			}
			this.SetContent();
		}

		private void frmRecommendInfo_Leave(object sender, EventArgs e)
		{
			if (this.issaved)
			{
				this.issaved = false;
				return;
			}
			this.SaveProgress();
		}

		private void lbcomattpath_LinkClicked(object sender, EventArgs e)
		{
			if (this.lbcomattpath.Text == string.Empty)
			{
				return;
			}
			if (File.Exists(this.lbcomattpath.Text))
			{
				FileOp.OpenFile(this.lbcomattpath.Text);
				return;
			}
			if (File.Exists(Path.Combine(EntityElement.FilesStorePath, this._rinfo.RAttachmentInfo.StoreName)))
			{
				FileOp.OpenFile(Path.Combine(EntityElement.FilesStorePath, this._rinfo.RAttachmentInfo.StoreName));
				return;
			}
			MessageBox.Show("文件不存在。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		private void lbexp1attpath_LinkClicked(object sender, EventArgs e)
		{
			if (this.lbexp1attpath.Text == string.Empty)
			{
				return;
			}
			if (File.Exists(this.lbexp1attpath.Text))
			{
				FileOp.OpenFile(this.lbexp1attpath.Text);
				return;
			}
			if (File.Exists(Path.Combine(EntityElement.FilesStorePath, this._rinfo.ExperInfoList[0].EAttachmentInfo.StoreName)))
			{
				FileOp.OpenFile(Path.Combine(EntityElement.FilesStorePath, this._rinfo.ExperInfoList[0].EAttachmentInfo.StoreName));
				return;
			}
			MessageBox.Show("文件不存在。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		private void lbexp2attpath_LinkClicked(object sender, EventArgs e)
		{
			if (this.lbexp2attpath.Text == string.Empty)
			{
				return;
			}
			if (File.Exists(this.lbexp2attpath.Text))
			{
				FileOp.OpenFile(this.lbexp2attpath.Text);
				return;
			}
			if (File.Exists(Path.Combine(EntityElement.FilesStorePath, this._rinfo.ExperInfoList[1].EAttachmentInfo.StoreName)))
			{
				FileOp.OpenFile(Path.Combine(EntityElement.FilesStorePath, this._rinfo.ExperInfoList[1].EAttachmentInfo.StoreName));
				return;
			}
			MessageBox.Show("文件不存在。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		private void lbexp3attpath_LinkClicked(object sender, EventArgs e)
		{
			if (this.lbexp3attpath.Text == string.Empty)
			{
				return;
			}
			if (File.Exists(this.lbexp3attpath.Text))
			{
				FileOp.OpenFile(this.lbexp3attpath.Text);
				return;
			}
			if (File.Exists(Path.Combine(EntityElement.FilesStorePath, this._rinfo.ExperInfoList[2].EAttachmentInfo.StoreName)))
			{
				FileOp.OpenFile(Path.Combine(EntityElement.FilesStorePath, this._rinfo.ExperInfoList[2].EAttachmentInfo.StoreName));
				return;
			}
			MessageBox.Show("文件不存在。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}
	}
}
