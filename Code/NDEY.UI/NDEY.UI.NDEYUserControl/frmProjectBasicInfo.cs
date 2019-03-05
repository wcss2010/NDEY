using ComponentFactory.Krypton.Navigator;
using ComponentFactory.Krypton.Toolkit;
using NDEY.BLL.Entity;
using NDEY.BLL.Service;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace NDEY.UI.NDEYUserControl
{
	public class frmProjectBasicInfo : BaseControl
	{
		private ProjectBasicInfoService _projectBasicInfoService = new ProjectBasicInfoService();

		private bool issaved;

		private IContainer components;

		private TableLayoutPanel tableLayoutPanel6;

		private HSkinTableLayoutPanel hSkinProHost;

		private KryptonPanel kryptonPanel15;

		private KryptonLabel kryptonLabel34;

		private KryptonComboBox txtApplicationArea;

		private KryptonTextBox txtProjectBaseT;

		private KryptonLabel kryptonLabel29;

		private KryptonTextBox ProjectMRD;

		private KryptonTextBox txtProjectTD;

		private KryptonPanel kryptonPanel14;

		private KryptonPanel kryptonPanel11;

		private KryptonLabel kryptonLabel33;

		private KryptonLabel kryptonLabel31;

		private KryptonLabel kryptonLabel28;

		private KryptonLabel kryptonLabel27;

		private KryptonLabel kryptonLabel26;

		private KryptonLabel kryptonLabel25;

		private KryptonPanel kryptonPanel10;

		private KryptonLabel kryptonLabel24;

		private KryptonPanel kryptonPanel13;

		private KryptonLabel kryptonLabel35;

		private KryptonNumericUpDown txtProjectLimitTStart;

		private KryptonNumericUpDown txtProjectLimitTEnd;

		private TableLayoutPanel tableLayoutPanel27;

		private KryptonButton btnProjectBasicInfoSave;

		private KryptonComboBox txtProjectSecret;

		private KryptonLabel kryptonLabel1;

		private KryptonPanel kryptonPanel1;

		private KryptonTextBox txtProjectName;

		private KryptonPanel kryptonPanel2;

		private KryptonTextBox txtProjectKeyWord;

		private KryptonPanel kryptonPanel3;

		private KryptonPanel kryptonPanel5;

		private KryptonLabel kryptonLabel5;

		private KryptonLabel kryptonLabel6;

		private KryptonLabel kryptonLabel7;

		private KryptonLabel kryptonLabel8;

		private KryptonLabel kryptonLabel9;

		private HSkinTableLayoutPanel tableLayoutPanel1;

		private WaterTextbox txtgen6;

		private WaterTextbox txtgen5;

		private WaterTextbox txtgen3;

		private WaterTextbox txtgen4;

		public frmProjectBasicInfo()
		{
			this.InitializeComponent();
		}

		protected override void OnLoad(EventArgs e)
		{
			this.RefreshCall();
			base.OnLoad(e);
		}

		private bool CanSave()
		{
			this.OnSaveCheckDenyEvent(EventArgs.Empty);
			//if (this.txtgen1.Text.Length + this.txtgen2.Text.Length > 200)
			//{
			//	MessageBox.Show("个人简介内容超过200字,请检查。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			//	return false;
			//}
			if (this.txtgen3.Text.Length + this.txtgen4.Text.Length + this.txtgen5.Text.Length + this.txtgen6.Text.Length > 350)
			{
				MessageBox.Show("项目摘要内容超过350字,请检查。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return false;
			}
			this.OnSaveCheckPassedEvent(EventArgs.Empty);
			return true;
		}

		private void SaveProgress()
		{
			ProjectBasicInfo projectBasicInfo = new ProjectBasicInfo();
			projectBasicInfo.ProjectName = this.txtProjectName.Text;
			projectBasicInfo.ProjectTD = this.txtProjectTD.Text;
			projectBasicInfo.ProjectMRD = this.ProjectMRD.Text;
			projectBasicInfo.ProjectBaseT = this.txtProjectBaseT.Text;
			projectBasicInfo.ApplicationArea = this.txtApplicationArea.Text;
			projectBasicInfo.ProjectLimitStart = this.txtProjectLimitTStart.Value.ToString();
			projectBasicInfo.ProjectLimitEnd = this.txtProjectLimitTEnd.Value.ToString();
			projectBasicInfo.ProjectSecret = this.txtProjectSecret.Text;
			projectBasicInfo.ProjectKeyWord = this.txtProjectKeyWord.Text;
			projectBasicInfo.ProjectBrief = string.Concat(new string[]
			{
                "%{GenText1}%",
				"|",
                "%{GenText2}%",
                "|",
				this.txtgen3.Text,
				"|",
				this.txtgen4.Text,
				"|",
				this.txtgen5.Text,
				"|",
				this.txtgen6.Text
			});
			this._projectBasicInfoService.UpdateProjectBasicInfo(projectBasicInfo);
		}

		private void btnProjectBasicInfoSave_Click(object sender, EventArgs e)
		{
			if (!this.CanSave())
			{
				return;
			}
			this.SaveProgress();
			this.issaved = true;
			KryptonNavigator kryptonNavigator = (KryptonNavigator)base.Parent.Parent.Parent.Parent.Parent.Parent;
			kryptonNavigator.SelectedIndex++;
			kryptonNavigator.SelectedPage.Enabled = true;
		}

		public override void RefreshCall()
		{
			ProjectBasicInfo projectBasicInfo = this._projectBasicInfoService.GetProjectBasicInfo();
			if (projectBasicInfo != null)
			{
				this.txtProjectName.Text = projectBasicInfo.ProjectName;
				this.txtProjectTD.Text = projectBasicInfo.ProjectTD;
				this.ProjectMRD.Text = projectBasicInfo.ProjectMRD;
				this.txtProjectBaseT.Text = projectBasicInfo.ProjectBaseT;
				if (string.IsNullOrEmpty(projectBasicInfo.ApplicationArea))
				{
					this.txtApplicationArea.SelectedIndex = -1;
				}
				else
				{
					this.txtApplicationArea.Text = projectBasicInfo.ApplicationArea;
				}
				this.txtProjectLimitTStart.Value = decimal.Parse(projectBasicInfo.ProjectLimitStart);
				this.txtProjectLimitTEnd.Value = decimal.Parse(projectBasicInfo.ProjectLimitEnd);
				if (string.IsNullOrEmpty(projectBasicInfo.ProjectSecret))
				{
					this.txtProjectSecret.SelectedIndex = 1;
				}
				else
				{
					this.txtProjectSecret.Text = projectBasicInfo.ProjectSecret;
				}
				this.txtProjectKeyWord.Text = projectBasicInfo.ProjectKeyWord;
				string[] array = projectBasicInfo.ProjectBrief.Split(new char[]
				{
					'|'
				});
				if (array.Length == 6)
				{
					//this.txtgen1.Text = array[0];
					//this.txtgen2.Text = array[1];
					this.txtgen3.Text = array[2];
					this.txtgen4.Text = array[3];
					this.txtgen5.Text = array[4];
					this.txtgen6.Text = array[5];
					return;
				}
				//this.txtgen1.Text = "";
				//this.txtgen2.Text = "";
				this.txtgen3.Text = "";
				this.txtgen4.Text = "";
				this.txtgen5.Text = "";
				this.txtgen6.Text = "";
			}
		}

		private void frmProjectBasicInfo_Leave(object sender, EventArgs e)
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
			this.SaveProgress();
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
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.hSkinProHost = new NDEY.UI.HSkinTableLayoutPanel();
            this.txtProjectSecret = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonPanel15 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel34 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtApplicationArea = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.txtProjectBaseT = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel29 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ProjectMRD = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtProjectTD = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonPanel14 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.txtProjectName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonPanel11 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel33 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel31 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel28 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel27 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel26 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel25 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonPanel10 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel24 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonPanel13 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel35 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtProjectLimitTStart = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.txtProjectLimitTEnd = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.txtProjectKeyWord = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonPanel3 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.tableLayoutPanel1 = new NDEY.UI.HSkinTableLayoutPanel();
            this.txtgen6 = new NDEY.UI.NDEYUserControl.WaterTextbox();
            this.txtgen5 = new NDEY.UI.NDEYUserControl.WaterTextbox();
            this.kryptonPanel5 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel6 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel7 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel8 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel9 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtgen3 = new NDEY.UI.NDEYUserControl.WaterTextbox();
            this.txtgen4 = new NDEY.UI.NDEYUserControl.WaterTextbox();
            this.tableLayoutPanel27 = new System.Windows.Forms.TableLayoutPanel();
            this.btnProjectBasicInfoSave = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.tableLayoutPanel6.SuspendLayout();
            this.hSkinProHost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtProjectSecret)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel15)).BeginInit();
            this.kryptonPanel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtApplicationArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel14)).BeginInit();
            this.kryptonPanel14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel11)).BeginInit();
            this.kryptonPanel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel10)).BeginInit();
            this.kryptonPanel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel13)).BeginInit();
            this.kryptonPanel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel5)).BeginInit();
            this.kryptonPanel5.SuspendLayout();
            this.tableLayoutPanel27.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.AutoScroll = true;
            this.tableLayoutPanel6.ColumnCount = 3;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.Controls.Add(this.hSkinProHost, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel27, 1, 2);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 4;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(847, 767);
            this.tableLayoutPanel6.TabIndex = 2;
            // 
            // hSkinProHost
            // 
            this.hSkinProHost.BorderColor = System.Drawing.Color.Black;
            this.hSkinProHost.ColumnCount = 5;
            this.hSkinProHost.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.hSkinProHost.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.hSkinProHost.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.hSkinProHost.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.hSkinProHost.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.hSkinProHost.Controls.Add(this.txtProjectSecret, 4, 3);
            this.hSkinProHost.Controls.Add(this.kryptonLabel1, 3, 3);
            this.hSkinProHost.Controls.Add(this.kryptonPanel15, 0, 5);
            this.hSkinProHost.Controls.Add(this.txtApplicationArea, 4, 2);
            this.hSkinProHost.Controls.Add(this.txtProjectBaseT, 2, 2);
            this.hSkinProHost.Controls.Add(this.kryptonLabel29, 3, 2);
            this.hSkinProHost.Controls.Add(this.ProjectMRD, 4, 1);
            this.hSkinProHost.Controls.Add(this.txtProjectTD, 2, 1);
            this.hSkinProHost.Controls.Add(this.kryptonPanel14, 2, 0);
            this.hSkinProHost.Controls.Add(this.kryptonPanel11, 0, 4);
            this.hSkinProHost.Controls.Add(this.kryptonLabel31, 3, 1);
            this.hSkinProHost.Controls.Add(this.kryptonLabel28, 1, 3);
            this.hSkinProHost.Controls.Add(this.kryptonLabel27, 1, 2);
            this.hSkinProHost.Controls.Add(this.kryptonLabel26, 1, 1);
            this.hSkinProHost.Controls.Add(this.kryptonLabel25, 1, 0);
            this.hSkinProHost.Controls.Add(this.kryptonPanel10, 0, 0);
            this.hSkinProHost.Controls.Add(this.kryptonPanel13, 2, 3);
            this.hSkinProHost.Controls.Add(this.kryptonPanel1, 2, 4);
            this.hSkinProHost.Controls.Add(this.tableLayoutPanel1, 1, 5);
            this.hSkinProHost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hSkinProHost.Location = new System.Drawing.Point(53, 28);
            this.hSkinProHost.Name = "hSkinProHost";
            this.hSkinProHost.RowCount = 6;
            this.hSkinProHost.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.hSkinProHost.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.hSkinProHost.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.hSkinProHost.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.hSkinProHost.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.hSkinProHost.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.hSkinProHost.Size = new System.Drawing.Size(791, 645);
            this.hSkinProHost.TabIndex = 0;
            // 
            // txtProjectSecret
            // 
            this.txtProjectSecret.AlwaysActive = false;
            this.txtProjectSecret.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtProjectSecret.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtProjectSecret.DropDownWidth = 62;
            this.txtProjectSecret.Items.AddRange(new object[] {
            "秘密",
            "机密"});
            this.txtProjectSecret.Location = new System.Drawing.Point(552, 128);
            this.txtProjectSecret.Margin = new System.Windows.Forms.Padding(2, 8, 8, 8);
            this.txtProjectSecret.Name = "txtProjectSecret";
            this.txtProjectSecret.Size = new System.Drawing.Size(231, 25);
            this.txtProjectSecret.StateActive.ComboBox.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtProjectSecret.StateActive.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtProjectSecret.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.Transparent;
            this.txtProjectSecret.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtProjectSecret.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("仿宋_GB2312", 12F);
            this.txtProjectSecret.TabIndex = 36;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonLabel1.Location = new System.Drawing.Point(423, 134);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(124, 23);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("仿宋_GB2312", 12F);
            this.kryptonLabel1.TabIndex = 35;
            this.kryptonLabel1.Values.Text = "密   级";
            // 
            // kryptonPanel15
            // 
            this.kryptonPanel15.Controls.Add(this.kryptonLabel34);
            this.kryptonPanel15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel15.Location = new System.Drawing.Point(1, 201);
            this.kryptonPanel15.Margin = new System.Windows.Forms.Padding(1);
            this.kryptonPanel15.Name = "kryptonPanel15";
            this.kryptonPanel15.Size = new System.Drawing.Size(78, 443);
            this.kryptonPanel15.StateCommon.Color1 = System.Drawing.Color.White;
            this.kryptonPanel15.TabIndex = 29;
            // 
            // kryptonLabel34
            // 
            this.kryptonLabel34.Location = new System.Drawing.Point(12, 224);
            this.kryptonLabel34.Name = "kryptonLabel34";
            this.kryptonLabel34.Size = new System.Drawing.Size(45, 23);
            this.kryptonLabel34.StateCommon.ShortText.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.kryptonLabel34.TabIndex = 0;
            this.kryptonLabel34.Values.Text = "摘要";
            // 
            // txtApplicationArea
            // 
            this.txtApplicationArea.AlwaysActive = false;
            this.txtApplicationArea.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtApplicationArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtApplicationArea.DropDownWidth = 62;
            this.txtApplicationArea.Items.AddRange(new object[] {
            "应用基础类",
            "工程技术类"});
            this.txtApplicationArea.Location = new System.Drawing.Point(552, 88);
            this.txtApplicationArea.Margin = new System.Windows.Forms.Padding(2, 8, 8, 8);
            this.txtApplicationArea.Name = "txtApplicationArea";
            this.txtApplicationArea.Size = new System.Drawing.Size(231, 25);
            this.txtApplicationArea.StateActive.ComboBox.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtApplicationArea.StateActive.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtApplicationArea.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.Transparent;
            this.txtApplicationArea.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtApplicationArea.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("仿宋_GB2312", 12F);
            this.txtApplicationArea.TabIndex = 6;
            // 
            // txtProjectBaseT
            // 
            this.txtProjectBaseT.AlwaysActive = false;
            this.txtProjectBaseT.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtProjectBaseT.Location = new System.Drawing.Point(182, 88);
            this.txtProjectBaseT.Margin = new System.Windows.Forms.Padding(2, 8, 8, 8);
            this.txtProjectBaseT.Name = "txtProjectBaseT";
            this.txtProjectBaseT.Size = new System.Drawing.Size(230, 24);
            this.txtProjectBaseT.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtProjectBaseT.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtProjectBaseT.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.txtProjectBaseT.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtProjectBaseT.StateCommon.Content.Font = new System.Drawing.Font("仿宋_GB2312", 12F);
            this.txtProjectBaseT.TabIndex = 28;
            // 
            // kryptonLabel29
            // 
            this.kryptonLabel29.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonLabel29.Location = new System.Drawing.Point(423, 94);
            this.kryptonLabel29.Name = "kryptonLabel29";
            this.kryptonLabel29.Size = new System.Drawing.Size(124, 23);
            this.kryptonLabel29.StateCommon.ShortText.Font = new System.Drawing.Font("仿宋_GB2312", 12F);
            this.kryptonLabel29.TabIndex = 27;
            this.kryptonLabel29.Values.Text = "申报类别";
            // 
            // ProjectMRD
            // 
            this.ProjectMRD.AlwaysActive = false;
            this.ProjectMRD.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ProjectMRD.Location = new System.Drawing.Point(552, 48);
            this.ProjectMRD.Margin = new System.Windows.Forms.Padding(2, 8, 8, 8);
            this.ProjectMRD.Name = "ProjectMRD";
            this.ProjectMRD.Size = new System.Drawing.Size(231, 24);
            this.ProjectMRD.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ProjectMRD.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ProjectMRD.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.ProjectMRD.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ProjectMRD.StateCommon.Content.Font = new System.Drawing.Font("仿宋_GB2312", 12F);
            this.ProjectMRD.TabIndex = 26;
            // 
            // txtProjectTD
            // 
            this.txtProjectTD.AlwaysActive = false;
            this.txtProjectTD.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtProjectTD.Location = new System.Drawing.Point(182, 48);
            this.txtProjectTD.Margin = new System.Windows.Forms.Padding(2, 8, 8, 8);
            this.txtProjectTD.Name = "txtProjectTD";
            this.txtProjectTD.Size = new System.Drawing.Size(230, 24);
            this.txtProjectTD.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtProjectTD.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtProjectTD.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.txtProjectTD.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtProjectTD.StateCommon.Content.Font = new System.Drawing.Font("仿宋_GB2312", 12F);
            this.txtProjectTD.TabIndex = 21;
            // 
            // kryptonPanel14
            // 
            this.hSkinProHost.SetColumnSpan(this.kryptonPanel14, 3);
            this.kryptonPanel14.Controls.Add(this.txtProjectName);
            this.kryptonPanel14.Controls.Add(this.kryptonPanel2);
            this.kryptonPanel14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel14.Location = new System.Drawing.Point(181, 1);
            this.kryptonPanel14.Margin = new System.Windows.Forms.Padding(1, 1, 1, 0);
            this.kryptonPanel14.Name = "kryptonPanel14";
            this.kryptonPanel14.Size = new System.Drawing.Size(609, 39);
            this.kryptonPanel14.StateCommon.Color1 = System.Drawing.Color.White;
            this.kryptonPanel14.TabIndex = 25;
            // 
            // txtProjectName
            // 
            this.txtProjectName.AlwaysActive = false;
            this.txtProjectName.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtProjectName.Location = new System.Drawing.Point(0, 10);
            this.txtProjectName.Margin = new System.Windows.Forms.Padding(0);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(609, 24);
            this.txtProjectName.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtProjectName.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtProjectName.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.txtProjectName.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtProjectName.StateCommon.Content.Font = new System.Drawing.Font("仿宋_GB2312", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtProjectName.TabIndex = 2;
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(609, 10);
            this.kryptonPanel2.StateCommon.Color1 = System.Drawing.Color.White;
            this.kryptonPanel2.TabIndex = 1;
            // 
            // kryptonPanel11
            // 
            this.hSkinProHost.SetColumnSpan(this.kryptonPanel11, 2);
            this.kryptonPanel11.Controls.Add(this.kryptonLabel33);
            this.kryptonPanel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel11.Location = new System.Drawing.Point(1, 161);
            this.kryptonPanel11.Margin = new System.Windows.Forms.Padding(1, 1, 0, 0);
            this.kryptonPanel11.Name = "kryptonPanel11";
            this.kryptonPanel11.Size = new System.Drawing.Size(179, 39);
            this.kryptonPanel11.StateCommon.Color1 = System.Drawing.Color.White;
            this.kryptonPanel11.TabIndex = 11;
            // 
            // kryptonLabel33
            // 
            this.kryptonLabel33.Location = new System.Drawing.Point(49, 11);
            this.kryptonLabel33.Name = "kryptonLabel33";
            this.kryptonLabel33.Size = new System.Drawing.Size(61, 23);
            this.kryptonLabel33.StateCommon.ShortText.Font = new System.Drawing.Font("仿宋_GB2312", 12F);
            this.kryptonLabel33.TabIndex = 0;
            this.kryptonLabel33.Values.Text = "关键词";
            // 
            // kryptonLabel31
            // 
            this.kryptonLabel31.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonLabel31.Location = new System.Drawing.Point(423, 54);
            this.kryptonLabel31.Name = "kryptonLabel31";
            this.kryptonLabel31.Size = new System.Drawing.Size(124, 23);
            this.kryptonLabel31.StateCommon.ShortText.Font = new System.Drawing.Font("仿宋_GB2312", 12F);
            this.kryptonLabel31.TabIndex = 9;
            this.kryptonLabel31.Values.Text = "主要研究方向";
            // 
            // kryptonLabel28
            // 
            this.kryptonLabel28.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonLabel28.Location = new System.Drawing.Point(83, 134);
            this.kryptonLabel28.Name = "kryptonLabel28";
            this.kryptonLabel28.Size = new System.Drawing.Size(94, 23);
            this.kryptonLabel28.StateCommon.ShortText.Font = new System.Drawing.Font("仿宋_GB2312", 12F);
            this.kryptonLabel28.TabIndex = 6;
            this.kryptonLabel28.Values.Text = "研究周期";
            // 
            // kryptonLabel27
            // 
            this.kryptonLabel27.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonLabel27.Location = new System.Drawing.Point(83, 94);
            this.kryptonLabel27.Name = "kryptonLabel27";
            this.kryptonLabel27.Size = new System.Drawing.Size(94, 23);
            this.kryptonLabel27.StateCommon.ShortText.Font = new System.Drawing.Font("仿宋_GB2312", 12F);
            this.kryptonLabel27.TabIndex = 5;
            this.kryptonLabel27.Values.Text = "基地类别";
            // 
            // kryptonLabel26
            // 
            this.kryptonLabel26.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonLabel26.Location = new System.Drawing.Point(83, 54);
            this.kryptonLabel26.Name = "kryptonLabel26";
            this.kryptonLabel26.Size = new System.Drawing.Size(94, 23);
            this.kryptonLabel26.StateCommon.ShortText.Font = new System.Drawing.Font("仿宋_GB2312", 12F);
            this.kryptonLabel26.TabIndex = 4;
            this.kryptonLabel26.Values.Text = "技术方向";
            // 
            // kryptonLabel25
            // 
            this.kryptonLabel25.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonLabel25.Location = new System.Drawing.Point(83, 14);
            this.kryptonLabel25.Name = "kryptonLabel25";
            this.kryptonLabel25.Size = new System.Drawing.Size(94, 23);
            this.kryptonLabel25.StateCommon.ShortText.Font = new System.Drawing.Font("仿宋_GB2312", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.kryptonLabel25.TabIndex = 1;
            this.kryptonLabel25.Values.Text = "项目名称";
            // 
            // kryptonPanel10
            // 
            this.kryptonPanel10.Controls.Add(this.kryptonLabel24);
            this.kryptonPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel10.Location = new System.Drawing.Point(1, 1);
            this.kryptonPanel10.Margin = new System.Windows.Forms.Padding(1, 1, 0, 0);
            this.kryptonPanel10.Name = "kryptonPanel10";
            this.hSkinProHost.SetRowSpan(this.kryptonPanel10, 4);
            this.kryptonPanel10.Size = new System.Drawing.Size(79, 159);
            this.kryptonPanel10.StateCommon.Color1 = System.Drawing.Color.White;
            this.kryptonPanel10.TabIndex = 2;
            // 
            // kryptonLabel24
            // 
            this.kryptonLabel24.Location = new System.Drawing.Point(24, 40);
            this.kryptonLabel24.Name = "kryptonLabel24";
            this.kryptonLabel24.Size = new System.Drawing.Size(28, 77);
            this.kryptonLabel24.StateCommon.ShortText.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.kryptonLabel24.TabIndex = 0;
            this.kryptonLabel24.Values.Text = "项\r\n目\r\n信\r\n息";
            // 
            // kryptonPanel13
            // 
            this.kryptonPanel13.Controls.Add(this.kryptonLabel35);
            this.kryptonPanel13.Controls.Add(this.txtProjectLimitTStart);
            this.kryptonPanel13.Controls.Add(this.txtProjectLimitTEnd);
            this.kryptonPanel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel13.Location = new System.Drawing.Point(181, 121);
            this.kryptonPanel13.Margin = new System.Windows.Forms.Padding(1, 1, 0, 0);
            this.kryptonPanel13.Name = "kryptonPanel13";
            this.kryptonPanel13.Size = new System.Drawing.Size(239, 39);
            this.kryptonPanel13.StateCommon.Color1 = System.Drawing.Color.White;
            this.kryptonPanel13.TabIndex = 13;
            // 
            // kryptonLabel35
            // 
            this.kryptonLabel35.Location = new System.Drawing.Point(87, 6);
            this.kryptonLabel35.Name = "kryptonLabel35";
            this.kryptonLabel35.Size = new System.Drawing.Size(22, 23);
            this.kryptonLabel35.StateCommon.ShortText.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.kryptonLabel35.TabIndex = 2;
            this.kryptonLabel35.Values.Text = "-";
            // 
            // txtProjectLimitTStart
            // 
            this.txtProjectLimitTStart.Location = new System.Drawing.Point(7, 6);
            this.txtProjectLimitTStart.Maximum = new decimal(new int[] {
            6000,
            0,
            0,
            0});
            this.txtProjectLimitTStart.Minimum = new decimal(new int[] {
            2017,
            0,
            0,
            0});
            this.txtProjectLimitTStart.Name = "txtProjectLimitTStart";
            this.txtProjectLimitTStart.Size = new System.Drawing.Size(67, 25);
            this.txtProjectLimitTStart.StateCommon.Content.Font = new System.Drawing.Font("仿宋_GB2312", 12F);
            this.txtProjectLimitTStart.TabIndex = 0;
            this.txtProjectLimitTStart.Value = new decimal(new int[] {
            2017,
            0,
            0,
            0});
            // 
            // txtProjectLimitTEnd
            // 
            this.txtProjectLimitTEnd.Location = new System.Drawing.Point(125, 6);
            this.txtProjectLimitTEnd.Maximum = new decimal(new int[] {
            6000,
            0,
            0,
            0});
            this.txtProjectLimitTEnd.Minimum = new decimal(new int[] {
            2017,
            0,
            0,
            0});
            this.txtProjectLimitTEnd.Name = "txtProjectLimitTEnd";
            this.txtProjectLimitTEnd.Size = new System.Drawing.Size(72, 25);
            this.txtProjectLimitTEnd.StateCommon.Content.Font = new System.Drawing.Font("仿宋_GB2312", 12F);
            this.txtProjectLimitTEnd.TabIndex = 3;
            this.txtProjectLimitTEnd.Value = new decimal(new int[] {
            2017,
            0,
            0,
            0});
            // 
            // kryptonPanel1
            // 
            this.hSkinProHost.SetColumnSpan(this.kryptonPanel1, 3);
            this.kryptonPanel1.Controls.Add(this.txtProjectKeyWord);
            this.kryptonPanel1.Controls.Add(this.kryptonPanel3);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(183, 161);
            this.kryptonPanel1.Margin = new System.Windows.Forms.Padding(3, 1, 3, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(605, 39);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.White;
            this.kryptonPanel1.TabIndex = 37;
            // 
            // txtProjectKeyWord
            // 
            this.txtProjectKeyWord.AlwaysActive = false;
            this.txtProjectKeyWord.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtProjectKeyWord.Location = new System.Drawing.Point(0, 10);
            this.txtProjectKeyWord.Margin = new System.Windows.Forms.Padding(8);
            this.txtProjectKeyWord.Name = "txtProjectKeyWord";
            this.txtProjectKeyWord.Size = new System.Drawing.Size(605, 24);
            this.txtProjectKeyWord.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtProjectKeyWord.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtProjectKeyWord.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.txtProjectKeyWord.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtProjectKeyWord.StateCommon.Content.Font = new System.Drawing.Font("仿宋_GB2312", 12F);
            this.txtProjectKeyWord.TabIndex = 36;
            // 
            // kryptonPanel3
            // 
            this.kryptonPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel3.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel3.Name = "kryptonPanel3";
            this.kryptonPanel3.Size = new System.Drawing.Size(605, 10);
            this.kryptonPanel3.StateCommon.Color1 = System.Drawing.Color.White;
            this.kryptonPanel3.TabIndex = 35;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BorderColor = System.Drawing.Color.Black;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.hSkinProHost.SetColumnSpan(this.tableLayoutPanel1, 4);
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.txtgen6, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtgen5, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.kryptonPanel5, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.kryptonLabel6, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.kryptonLabel7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.kryptonLabel8, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.kryptonLabel9, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtgen3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtgen4, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(80, 200);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(711, 445);
            this.tableLayoutPanel1.TabIndex = 38;
            // 
            // txtgen6
            // 
            this.txtgen6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtgen6.EmptyTextTip = null;
            this.txtgen6.Font = new System.Drawing.Font("仿宋_GB2312", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtgen6.Location = new System.Drawing.Point(103, 283);
            this.txtgen6.Multiline = true;
            this.txtgen6.Name = "txtgen6";
            this.txtgen6.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtgen6.Size = new System.Drawing.Size(605, 159);
            this.txtgen6.TabIndex = 20;
            // 
            // txtgen5
            // 
            this.txtgen5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtgen5.EmptyTextTip = null;
            this.txtgen5.Font = new System.Drawing.Font("仿宋_GB2312", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtgen5.Location = new System.Drawing.Point(103, 203);
            this.txtgen5.Multiline = true;
            this.txtgen5.Name = "txtgen5";
            this.txtgen5.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtgen5.Size = new System.Drawing.Size(605, 74);
            this.txtgen5.TabIndex = 19;
            // 
            // kryptonPanel5
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.kryptonPanel5, 2);
            this.kryptonPanel5.Controls.Add(this.kryptonLabel5);
            this.kryptonPanel5.Location = new System.Drawing.Point(1, 1);
            this.kryptonPanel5.Margin = new System.Windows.Forms.Padding(1, 1, 1, 0);
            this.kryptonPanel5.Name = "kryptonPanel5";
            this.kryptonPanel5.Size = new System.Drawing.Size(602, 39);
            this.kryptonPanel5.TabIndex = 4;
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(5, 9);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(185, 23);
            this.kryptonLabel5.StateCommon.ShortText.Font = new System.Drawing.Font("仿宋_GB2312", 12F);
            this.kryptonLabel5.TabIndex = 3;
            this.kryptonLabel5.Values.Text = "项目摘要（350字以内）";
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonLabel6.Location = new System.Drawing.Point(3, 43);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(94, 23);
            this.kryptonLabel6.StateCommon.ShortText.Font = new System.Drawing.Font("仿宋_GB2312", 12F);
            this.kryptonLabel6.TabIndex = 5;
            this.kryptonLabel6.Values.Text = "研究目标";
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonLabel7.Location = new System.Drawing.Point(3, 123);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(94, 23);
            this.kryptonLabel7.StateCommon.ShortText.Font = new System.Drawing.Font("仿宋_GB2312", 12F);
            this.kryptonLabel7.TabIndex = 6;
            this.kryptonLabel7.Values.Text = "研究内容";
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonLabel8.Location = new System.Drawing.Point(3, 203);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.Size = new System.Drawing.Size(94, 41);
            this.kryptonLabel8.StateCommon.ShortText.Font = new System.Drawing.Font("仿宋_GB2312", 12F);
            this.kryptonLabel8.TabIndex = 7;
            this.kryptonLabel8.Values.Text = "主要\r\n创新点";
            // 
            // kryptonLabel9
            // 
            this.kryptonLabel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonLabel9.Location = new System.Drawing.Point(3, 283);
            this.kryptonLabel9.Name = "kryptonLabel9";
            this.kryptonLabel9.Size = new System.Drawing.Size(94, 41);
            this.kryptonLabel9.StateCommon.ShortText.Font = new System.Drawing.Font("仿宋_GB2312", 12F);
            this.kryptonLabel9.TabIndex = 8;
            this.kryptonLabel9.Values.Text = "预期军事\r\n价值";
            // 
            // txtgen3
            // 
            this.txtgen3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtgen3.EmptyTextTip = null;
            this.txtgen3.Font = new System.Drawing.Font("仿宋_GB2312", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtgen3.Location = new System.Drawing.Point(103, 43);
            this.txtgen3.Multiline = true;
            this.txtgen3.Name = "txtgen3";
            this.txtgen3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtgen3.Size = new System.Drawing.Size(605, 74);
            this.txtgen3.TabIndex = 17;
            // 
            // txtgen4
            // 
            this.txtgen4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtgen4.EmptyTextTip = null;
            this.txtgen4.Font = new System.Drawing.Font("仿宋_GB2312", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtgen4.Location = new System.Drawing.Point(103, 123);
            this.txtgen4.Multiline = true;
            this.txtgen4.Name = "txtgen4";
            this.txtgen4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtgen4.Size = new System.Drawing.Size(605, 74);
            this.txtgen4.TabIndex = 18;
            // 
            // tableLayoutPanel27
            // 
            this.tableLayoutPanel27.ColumnCount = 2;
            this.tableLayoutPanel27.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel27.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel27.Controls.Add(this.btnProjectBasicInfoSave, 1, 0);
            this.tableLayoutPanel27.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel27.Location = new System.Drawing.Point(53, 679);
            this.tableLayoutPanel27.Name = "tableLayoutPanel27";
            this.tableLayoutPanel27.RowCount = 1;
            this.tableLayoutPanel27.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel27.Size = new System.Drawing.Size(791, 35);
            this.tableLayoutPanel27.TabIndex = 1;
            // 
            // btnProjectBasicInfoSave
            // 
            this.btnProjectBasicInfoSave.Location = new System.Drawing.Point(674, 3);
            this.btnProjectBasicInfoSave.Name = "btnProjectBasicInfoSave";
            this.btnProjectBasicInfoSave.Size = new System.Drawing.Size(90, 25);
            this.btnProjectBasicInfoSave.TabIndex = 0;
            this.btnProjectBasicInfoSave.Values.Text = "保存";
            this.btnProjectBasicInfoSave.Click += new System.EventHandler(this.btnProjectBasicInfoSave_Click);
            // 
            // frmProjectBasicInfo
            // 
            this.Controls.Add(this.tableLayoutPanel6);
            this.Name = "frmProjectBasicInfo";
            this.Size = new System.Drawing.Size(847, 767);
            this.Leave += new System.EventHandler(this.frmProjectBasicInfo_Leave);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.hSkinProHost.ResumeLayout(false);
            this.hSkinProHost.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtProjectSecret)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel15)).EndInit();
            this.kryptonPanel15.ResumeLayout(false);
            this.kryptonPanel15.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtApplicationArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel14)).EndInit();
            this.kryptonPanel14.ResumeLayout(false);
            this.kryptonPanel14.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel11)).EndInit();
            this.kryptonPanel11.ResumeLayout(false);
            this.kryptonPanel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel10)).EndInit();
            this.kryptonPanel10.ResumeLayout(false);
            this.kryptonPanel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel13)).EndInit();
            this.kryptonPanel13.ResumeLayout(false);
            this.kryptonPanel13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel5)).EndInit();
            this.kryptonPanel5.ResumeLayout(false);
            this.kryptonPanel5.PerformLayout();
            this.tableLayoutPanel27.ResumeLayout(false);
            this.ResumeLayout(false);

		}
	}
}