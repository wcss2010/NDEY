using ComponentFactory.Krypton.Docking;
using ComponentFactory.Krypton.Navigator;
using ComponentFactory.Krypton.Toolkit;
using NDEY.BLL.Entity;
using NDEY.BLL.Service;
using NDEY.UI.NDEYUserControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.Text;

namespace NDEY.UI
{
	public class logicForm : Form
	{
		private IContainer components;

		private KryptonPanel kryptonPanel1;

		private KryptonNavigator defaulthost;

		private KryptonPage tpuserinfo;

		private KryptonPage tpproject;

		private KryptonPage tppaper;

		private KryptonLabel lbcurtime;

		private KryptonLabel kryptonLabel2;

		private KryptonNavigator kryptonNavigator2;

		private KryptonPage conapplyuser;

		private KryptonDockableNavigator kryptonDockableNavigator1;

		private KryptonPage tablepageprojectbasicinfo;

		private KryptonNavigator kryptonNavigator3;

		private KryptonPage tabpagecontrbution;

		private KryptonPage tabpageresearchplan;

		private KryptonPage tpresume;

		private KryptonNavigator kryptonNavigator4;

        private KryptonNavigator kryptonNavigator8;

        private KryptonPage tabeducation;

		private KryptonPage tabworkexperience;

		private KryptonPage tabacademic;

		private KryptonPage tabTalentsPlan;

		private KryptonPage tabNDProject;

		private KryptonPage tabRTreatises;

		private KryptonPage tbTechnologyAwards;

		private KryptonPage tabndpatent;

		private KryptonPage tprecomd;

		private KryptonDockableNavigator kryptonDockableNavigator2;

		private KryptonPage tablepagerecommend;

		private ButtonSpecAny buttonSpecAny1;

		private KryptonPage tpfee;

		private KryptonNavigator kryptonNavigator5;

		private KryptonPage tabpagefee;

		private Timer maintimer;

		private KryptonButton btnquit;

		private KryptonButton btnExport;

		private KryptonButton btnhelp;

		private KryptonManager kryptonManager1;

		private KryptonPage kpInputReadme;

		private KryptonNavigator kryptonNavigator1;

		private KryptonPage tablepageintroduction;

		private PictureBox topBanner;

		private KryptonButton btninit;

		private KryptonButton btnImport;

		private KryptonButton btnwordview;

		private KryptonButton btnSave;

		private KryptonPage tabpageresult;

		private KryptonPage tabpagemission;

		private KryptonWrapLabel kryptonWrapLabel1;

		private KryptonPanel kpcontactinner;

		private HSkinTableLayoutPanel kpcontact;

		private DBMgrService _dbMgrService = new DBMgrService();

		private IList<BaseControl> _baseControllist = new List<BaseControl>();

		private bool canSwitch = true;
        private KryptonButton btnUnitManage;
        private UserControl preusercontrol;
        private KryptonPage kpExtFile1;
        private KryptonPage kpExtFileSubPage;
        private frmApplyUserInfo frmApplyUserInfo;
        private frmExtFileEditor frmExtFileEditor;

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(logicForm));
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btninit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnImport = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnwordview = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnSave = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnExport = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lbcurtime = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btnUnitManage = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnquit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnhelp = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.defaulthost = new ComponentFactory.Krypton.Navigator.KryptonNavigator();
            this.kpInputReadme = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.kryptonNavigator1 = new ComponentFactory.Krypton.Navigator.KryptonNavigator();
            this.tablepageintroduction = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.tpuserinfo = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.kryptonNavigator2 = new ComponentFactory.Krypton.Navigator.KryptonNavigator();
            this.conapplyuser = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.tpproject = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.kryptonDockableNavigator1 = new ComponentFactory.Krypton.Docking.KryptonDockableNavigator();
            this.tablepageprojectbasicinfo = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.tpfee = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.kryptonNavigator5 = new ComponentFactory.Krypton.Navigator.KryptonNavigator();
            this.tabpagefee = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.tppaper = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.kryptonNavigator3 = new ComponentFactory.Krypton.Navigator.KryptonNavigator();
            this.tabpagecontrbution = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.tabpageresearchplan = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.tabpageresult = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.tabpagemission = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.tpresume = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.kryptonNavigator4 = new ComponentFactory.Krypton.Navigator.KryptonNavigator();
            this.tabeducation = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.tabworkexperience = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.tabacademic = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.tabTalentsPlan = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.tabNDProject = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.tabRTreatises = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.tbTechnologyAwards = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.tabndpatent = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.tprecomd = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.kryptonDockableNavigator2 = new ComponentFactory.Krypton.Docking.KryptonDockableNavigator();
            this.tablepagerecommend = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.kpExtFile1 = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.kryptonNavigator8 = new ComponentFactory.Krypton.Navigator.KryptonNavigator();
            this.kpExtFileSubPage = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.frmExtFileEditor = new NDEY.UI.NDEYUserControl.frmExtFileEditor();
            this.buttonSpecAny1 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.maintimer = new System.Windows.Forms.Timer(this.components);
            this.kryptonManager1 = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.topBanner = new System.Windows.Forms.PictureBox();
            this.kpcontactinner = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonWrapLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonWrapLabel();
            this.kpcontact = new NDEY.UI.HSkinTableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.defaulthost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kpInputReadme)).BeginInit();
            this.kpInputReadme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonNavigator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablepageintroduction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tpuserinfo)).BeginInit();
            this.tpuserinfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonNavigator2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conapplyuser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tpproject)).BeginInit();
            this.tpproject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDockableNavigator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablepageprojectbasicinfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tpfee)).BeginInit();
            this.tpfee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonNavigator5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabpagefee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tppaper)).BeginInit();
            this.tppaper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonNavigator3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabpagecontrbution)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabpageresearchplan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabpageresult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabpagemission)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tpresume)).BeginInit();
            this.tpresume.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonNavigator4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabeducation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabworkexperience)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabacademic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabTalentsPlan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabNDProject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabRTreatises)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTechnologyAwards)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabndpatent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tprecomd)).BeginInit();
            this.tprecomd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDockableNavigator2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablepagerecommend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kpExtFile1)).BeginInit();
            this.kpExtFile1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonNavigator8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kpExtFileSubPage)).BeginInit();
            this.kpExtFileSubPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.topBanner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kpcontactinner)).BeginInit();
            this.kpcontactinner.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.btninit);
            this.kryptonPanel1.Controls.Add(this.btnImport);
            this.kryptonPanel1.Controls.Add(this.btnwordview);
            this.kryptonPanel1.Controls.Add(this.btnSave);
            this.kryptonPanel1.Controls.Add(this.btnExport);
            this.kryptonPanel1.Controls.Add(this.lbcurtime);
            this.kryptonPanel1.Controls.Add(this.btnUnitManage);
            this.kryptonPanel1.Controls.Add(this.btnquit);
            this.kryptonPanel1.Controls.Add(this.btnhelp);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(1127, 40);
            this.kryptonPanel1.TabIndex = 1;
            // 
            // btninit
            // 
            this.btninit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btninit.Location = new System.Drawing.Point(461, 0);
            this.btninit.Name = "btninit";
            this.btninit.Size = new System.Drawing.Size(111, 40);
            this.btninit.StateCommon.Back.Image = ((System.Drawing.Image)(resources.GetObject("btninit.StateCommon.Back.Image")));
            this.btninit.TabIndex = 25;
            this.btninit.Values.Text = "";
            this.btninit.Click += new System.EventHandler(this.btninit_Click);
            // 
            // btnImport
            // 
            this.btnImport.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnImport.Location = new System.Drawing.Point(572, 0);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(111, 40);
            this.btnImport.StateCommon.Back.Image = ((System.Drawing.Image)(resources.GetObject("btnImport.StateCommon.Back.Image")));
            this.btnImport.TabIndex = 24;
            this.btnImport.Values.Text = "";
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnwordview
            // 
            this.btnwordview.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnwordview.Location = new System.Drawing.Point(683, 0);
            this.btnwordview.Name = "btnwordview";
            this.btnwordview.Size = new System.Drawing.Size(111, 40);
            this.btnwordview.StateCommon.Back.Image = ((System.Drawing.Image)(resources.GetObject("btnwordview.StateCommon.Back.Image")));
            this.btnwordview.TabIndex = 23;
            this.btnwordview.Values.Text = "";
            this.btnwordview.Click += new System.EventHandler(this.btnwordview_Click);
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSave.Location = new System.Drawing.Point(614, 0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 40);
            this.btnSave.StateCommon.Back.Image = global::Properties.Resource.TEMPSAVE;
            this.btnSave.TabIndex = 22;
            this.btnSave.Values.Text = "";
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExport
            // 
            this.btnExport.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExport.Location = new System.Drawing.Point(794, 0);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(111, 40);
            this.btnExport.StateCommon.Back.Image = ((System.Drawing.Image)(resources.GetObject("btnExport.StateCommon.Back.Image")));
            this.btnExport.TabIndex = 13;
            this.btnExport.Values.Text = "";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // lbcurtime
            // 
            this.lbcurtime.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbcurtime.Location = new System.Drawing.Point(0, 0);
            this.lbcurtime.Name = "lbcurtime";
            this.lbcurtime.Size = new System.Drawing.Size(78, 40);
            this.lbcurtime.StateCommon.ShortText.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbcurtime.TabIndex = 4;
            this.lbcurtime.Values.Text = "欢迎您！";
            // 
            // btnUnitManage
            // 
            this.btnUnitManage.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnUnitManage.Location = new System.Drawing.Point(815, 0);
            this.btnUnitManage.Name = "btnUnitManage";
            this.btnUnitManage.Size = new System.Drawing.Size(90, 40);
            this.btnUnitManage.StateCommon.Content.LongText.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnUnitManage.StateCommon.Content.ShortText.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnUnitManage.TabIndex = 26;
            this.btnUnitManage.Values.Text = "单位管理";
            this.btnUnitManage.Visible = false;
            this.btnUnitManage.Click += new System.EventHandler(this.btnUnitManage_Click);
            // 
            // btnquit
            // 
            this.btnquit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnquit.Location = new System.Drawing.Point(905, 0);
            this.btnquit.Name = "btnquit";
            this.btnquit.Size = new System.Drawing.Size(111, 40);
            this.btnquit.StateCommon.Back.Image = ((System.Drawing.Image)(resources.GetObject("btnquit.StateCommon.Back.Image")));
            this.btnquit.TabIndex = 5;
            this.btnquit.Values.Text = "";
            this.btnquit.Click += new System.EventHandler(this.btnquit_Click);
            // 
            // btnhelp
            // 
            this.btnhelp.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnhelp.Location = new System.Drawing.Point(1016, 0);
            this.btnhelp.Name = "btnhelp";
            this.btnhelp.Size = new System.Drawing.Size(111, 40);
            this.btnhelp.StateCommon.Back.Image = ((System.Drawing.Image)(resources.GetObject("btnhelp.StateCommon.Back.Image")));
            this.btnhelp.StateCommon.Content.ShortText.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnhelp.TabIndex = 10;
            this.btnhelp.Values.Text = "";
            this.btnhelp.Click += new System.EventHandler(this.btnhelp_Click);
            // 
            // defaulthost
            // 
            this.defaulthost.AllowPageReorder = false;
            this.defaulthost.Bar.BarOrientation = ComponentFactory.Krypton.Toolkit.VisualOrientation.Left;
            this.defaulthost.Bar.ItemMinimumSize = new System.Drawing.Size(20, 30);
            this.defaulthost.Bar.ItemOrientation = ComponentFactory.Krypton.Toolkit.ButtonOrientation.FixedTop;
            this.defaulthost.Button.ButtonDisplayLogic = ComponentFactory.Krypton.Navigator.ButtonDisplayLogic.None;
            this.defaulthost.Button.CloseButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide;
            this.defaulthost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.defaulthost.Location = new System.Drawing.Point(0, 40);
            this.defaulthost.Name = "defaulthost";
            this.defaulthost.NavigatorMode = ComponentFactory.Krypton.Navigator.NavigatorMode.BarRibbonTabGroup;
            this.defaulthost.Pages.AddRange(new ComponentFactory.Krypton.Navigator.KryptonPage[] {
            this.kpInputReadme,
            this.tpuserinfo,
            this.tpproject,
            this.tpfee,
            this.tppaper,
            this.tpresume,
            this.tprecomd,
            this.kpExtFile1});
            this.defaulthost.SelectedIndex = 0;
            this.defaulthost.Size = new System.Drawing.Size(1127, 631);
            this.defaulthost.TabIndex = 2;
            this.defaulthost.Selecting += new System.EventHandler<ComponentFactory.Krypton.Navigator.KryptonPageCancelEventArgs>(this.pagewantChange_Selecting);
            // 
            // kpInputReadme
            // 
            this.kpInputReadme.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kpInputReadme.Controls.Add(this.kryptonNavigator1);
            this.kpInputReadme.Flags = 65534;
            this.kpInputReadme.ImageSmall = global::Properties.Resource.ATTENTION551;
            this.kpInputReadme.LastVisibleSet = true;
            this.kpInputReadme.MinimumSize = new System.Drawing.Size(50, 50);
            this.kpInputReadme.Name = "kryptonPage1";
            this.kpInputReadme.Size = new System.Drawing.Size(925, 629);
            this.kpInputReadme.Text = "        填  写  说  明";
            this.kpInputReadme.ToolTipTitle = "Page ToolTip";
            this.kpInputReadme.UniqueName = "88B1B096A3674DA4FD9BB93F495EED68";
            // 
            // kryptonNavigator1
            // 
            this.kryptonNavigator1.Button.CloseButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide;
            this.kryptonNavigator1.Button.ContextButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide;
            this.kryptonNavigator1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonNavigator1.Location = new System.Drawing.Point(0, 0);
            this.kryptonNavigator1.Name = "kryptonNavigator1";
            this.kryptonNavigator1.Pages.AddRange(new ComponentFactory.Krypton.Navigator.KryptonPage[] {
            this.tablepageintroduction});
            this.kryptonNavigator1.SelectedIndex = 0;
            this.kryptonNavigator1.Size = new System.Drawing.Size(925, 629);
            this.kryptonNavigator1.TabIndex = 0;
            this.kryptonNavigator1.Text = "kryptonNavigator1";
            // 
            // tablepageintroduction
            // 
            this.tablepageintroduction.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.tablepageintroduction.Flags = 65534;
            this.tablepageintroduction.LastVisibleSet = true;
            this.tablepageintroduction.MinimumSize = new System.Drawing.Size(50, 50);
            this.tablepageintroduction.Name = "tablepageintroduction";
            this.tablepageintroduction.Size = new System.Drawing.Size(923, 599);
            this.tablepageintroduction.StateCommon.Tab.Content.ShortText.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tablepageintroduction.Text = "填报说明";
            this.tablepageintroduction.ToolTipTitle = "Page ToolTip";
            this.tablepageintroduction.UniqueName = "601ED654FB3447B6B3944404A612B730";
            // 
            // tpuserinfo
            // 
            this.tpuserinfo.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.tpuserinfo.Controls.Add(this.kryptonNavigator2);
            this.tpuserinfo.Controls.Add(this.kryptonLabel2);
            this.tpuserinfo.Flags = 65534;
            this.tpuserinfo.ImageSmall = global::Properties.Resource.APPLY551;
            this.tpuserinfo.LastVisibleSet = true;
            this.tpuserinfo.MinimumSize = new System.Drawing.Size(50, 50);
            this.tpuserinfo.Name = "tpuserinfo";
            this.tpuserinfo.Size = new System.Drawing.Size(925, 629);
            this.tpuserinfo.Text = "        申  报  信  息   ";
            this.tpuserinfo.TextTitle = "";
            this.tpuserinfo.ToolTipTitle = "Page ToolTip";
            this.tpuserinfo.UniqueName = "5AF53ED7C784450431AEC3A179DBBBE6";
            // 
            // kryptonNavigator2
            // 
            this.kryptonNavigator2.Button.ButtonDisplayLogic = ComponentFactory.Krypton.Navigator.ButtonDisplayLogic.None;
            this.kryptonNavigator2.Button.CloseButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide;
            this.kryptonNavigator2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonNavigator2.Location = new System.Drawing.Point(0, 0);
            this.kryptonNavigator2.Name = "kryptonNavigator2";
            this.kryptonNavigator2.Pages.AddRange(new ComponentFactory.Krypton.Navigator.KryptonPage[] {
            this.conapplyuser});
            this.kryptonNavigator2.SelectedIndex = 0;
            this.kryptonNavigator2.Size = new System.Drawing.Size(925, 629);
            this.kryptonNavigator2.TabIndex = 1;
            this.kryptonNavigator2.Text = "kryptonNavigator2";
            // 
            // conapplyuser
            // 
            this.conapplyuser.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.conapplyuser.Flags = 65534;
            this.conapplyuser.LastVisibleSet = true;
            this.conapplyuser.MinimumSize = new System.Drawing.Size(50, 50);
            this.conapplyuser.Name = "conapplyuser";
            this.conapplyuser.Size = new System.Drawing.Size(923, 599);
            this.conapplyuser.StateCommon.Tab.Content.ShortText.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.conapplyuser.Text = "申请人基本情况";
            this.conapplyuser.ToolTipTitle = "Page ToolTip";
            this.conapplyuser.UniqueName = "0C69D73481194F623DAFAEFF4C182911";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(167, 179);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(98, 20);
            this.kryptonLabel2.TabIndex = 0;
            this.kryptonLabel2.Values.Text = "申请人基本信息";
            // 
            // tpproject
            // 
            this.tpproject.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.tpproject.Controls.Add(this.kryptonDockableNavigator1);
            this.tpproject.Flags = 65534;
            this.tpproject.ImageSmall = global::Properties.Resource.PROJECT551;
            this.tpproject.LastVisibleSet = true;
            this.tpproject.MinimumSize = new System.Drawing.Size(50, 50);
            this.tpproject.Name = "tpproject";
            this.tpproject.Size = new System.Drawing.Size(925, 509);
            this.tpproject.Text = "        项  目  信  息";
            this.tpproject.TextTitle = "";
            this.tpproject.ToolTipTitle = "Page ToolTip";
            this.tpproject.UniqueName = "78F9949B9671498756BBD5E2EBEF8B25";
            // 
            // kryptonDockableNavigator1
            // 
            this.kryptonDockableNavigator1.Button.CloseButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide;
            this.kryptonDockableNavigator1.Button.ContextButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide;
            this.kryptonDockableNavigator1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonDockableNavigator1.Location = new System.Drawing.Point(0, 0);
            this.kryptonDockableNavigator1.Name = "kryptonDockableNavigator1";
            this.kryptonDockableNavigator1.Pages.AddRange(new ComponentFactory.Krypton.Navigator.KryptonPage[] {
            this.tablepageprojectbasicinfo});
            this.kryptonDockableNavigator1.SelectedIndex = 0;
            this.kryptonDockableNavigator1.Size = new System.Drawing.Size(925, 509);
            this.kryptonDockableNavigator1.TabIndex = 0;
            this.kryptonDockableNavigator1.Text = "kryptonDockableNavigator1";
            // 
            // tablepageprojectbasicinfo
            // 
            this.tablepageprojectbasicinfo.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.tablepageprojectbasicinfo.Flags = 65534;
            this.tablepageprojectbasicinfo.LastVisibleSet = true;
            this.tablepageprojectbasicinfo.MinimumSize = new System.Drawing.Size(50, 50);
            this.tablepageprojectbasicinfo.Name = "tablepageprojectbasicinfo";
            this.tablepageprojectbasicinfo.Size = new System.Drawing.Size(923, 479);
            this.tablepageprojectbasicinfo.StateCommon.Tab.Content.ShortText.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tablepageprojectbasicinfo.Text = "项目基本信息";
            this.tablepageprojectbasicinfo.ToolTipTitle = "Page ToolTip";
            this.tablepageprojectbasicinfo.UniqueName = "CCF716851823455CFE9BFDE6AB3D3D4B";
            // 
            // tpfee
            // 
            this.tpfee.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.tpfee.Controls.Add(this.kryptonNavigator5);
            this.tpfee.Flags = 65534;
            this.tpfee.ImageSmall = global::Properties.Resource.BUDEGET551;
            this.tpfee.LastVisibleSet = true;
            this.tpfee.MinimumSize = new System.Drawing.Size(50, 50);
            this.tpfee.Name = "tpfee";
            this.tpfee.Size = new System.Drawing.Size(925, 509);
            this.tpfee.Text = "        经  费  预  算";
            this.tpfee.ToolTipTitle = "Page ToolTip";
            this.tpfee.UniqueName = "D34EF3CAFA614029A6BD9C972FEE188C";
            // 
            // kryptonNavigator5
            // 
            this.kryptonNavigator5.Button.CloseButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide;
            this.kryptonNavigator5.Button.ContextButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide;
            this.kryptonNavigator5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonNavigator5.Location = new System.Drawing.Point(0, 0);
            this.kryptonNavigator5.Name = "kryptonNavigator5";
            this.kryptonNavigator5.Pages.AddRange(new ComponentFactory.Krypton.Navigator.KryptonPage[] {
            this.tabpagefee});
            this.kryptonNavigator5.SelectedIndex = 0;
            this.kryptonNavigator5.Size = new System.Drawing.Size(925, 509);
            this.kryptonNavigator5.TabIndex = 0;
            // 
            // tabpagefee
            // 
            this.tabpagefee.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.tabpagefee.Flags = 65534;
            this.tabpagefee.LastVisibleSet = true;
            this.tabpagefee.MinimumSize = new System.Drawing.Size(50, 50);
            this.tabpagefee.Name = "tabpagefee";
            this.tabpagefee.Size = new System.Drawing.Size(923, 479);
            this.tabpagefee.StateCommon.Tab.Content.ShortText.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabpagefee.Text = "经费预算";
            this.tabpagefee.ToolTipTitle = "Page ToolTip";
            this.tabpagefee.UniqueName = "9DEFD9F990AF4D69BEA8102DEF65A199";
            // 
            // tppaper
            // 
            this.tppaper.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.tppaper.Controls.Add(this.kryptonNavigator3);
            this.tppaper.Flags = 65534;
            this.tppaper.ImageSmall = global::Properties.Resource.PAPAER551;
            this.tppaper.LastVisibleSet = true;
            this.tppaper.MinimumSize = new System.Drawing.Size(50, 50);
            this.tppaper.Name = "tppaper";
            this.tppaper.Size = new System.Drawing.Size(714, 443);
            this.tppaper.Text = "        报  告  正  文";
            this.tppaper.TextTitle = "";
            this.tppaper.ToolTipTitle = "Page ToolTip";
            this.tppaper.UniqueName = "65A6829416834312D5BCD62D694F36F5";
            // 
            // kryptonNavigator3
            // 
            this.kryptonNavigator3.AllowPageReorder = false;
            this.kryptonNavigator3.Button.CloseButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide;
            this.kryptonNavigator3.Button.ContextButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide;
            this.kryptonNavigator3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonNavigator3.Location = new System.Drawing.Point(0, 0);
            this.kryptonNavigator3.Name = "kryptonNavigator3";
            this.kryptonNavigator3.Pages.AddRange(new ComponentFactory.Krypton.Navigator.KryptonPage[] {
            this.tabpagecontrbution,
            this.tabpageresearchplan,
            this.tabpageresult,
            this.tabpagemission});
            this.kryptonNavigator3.SelectedIndex = 0;
            this.kryptonNavigator3.Size = new System.Drawing.Size(714, 443);
            this.kryptonNavigator3.TabIndex = 0;
            this.kryptonNavigator3.Text = "kryptonNavigator3";
            this.kryptonNavigator3.Selecting += new System.EventHandler<ComponentFactory.Krypton.Navigator.KryptonPageCancelEventArgs>(this.pagewantChange_Selecting);
            // 
            // tabpagecontrbution
            // 
            this.tabpagecontrbution.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.tabpagecontrbution.Flags = 65534;
            this.tabpagecontrbution.LastVisibleSet = true;
            this.tabpagecontrbution.MinimumSize = new System.Drawing.Size(50, 50);
            this.tabpagecontrbution.Name = "tabpagecontrbution";
            this.tabpagecontrbution.Size = new System.Drawing.Size(712, 413);
            this.tabpagecontrbution.StateCommon.Tab.Content.ShortText.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabpagecontrbution.Text = "主要成绩和突出贡献";
            this.tabpagecontrbution.ToolTipTitle = "Page ToolTip";
            this.tabpagecontrbution.UniqueName = "F7FEDDF418D64B9695965B27CB7405EA";
            // 
            // tabpageresearchplan
            // 
            this.tabpageresearchplan.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.tabpageresearchplan.Flags = 65534;
            this.tabpageresearchplan.LastVisibleSet = true;
            this.tabpageresearchplan.MinimumSize = new System.Drawing.Size(50, 50);
            this.tabpageresearchplan.Name = "tabpageresearchplan";
            this.tabpageresearchplan.Size = new System.Drawing.Size(923, 479);
            this.tabpageresearchplan.StateCommon.Tab.Content.ShortText.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabpageresearchplan.Text = "拟开展的研究工作";
            this.tabpageresearchplan.ToolTipTitle = "Page ToolTip";
            this.tabpageresearchplan.UniqueName = "4EFD6E7519824767D989B379FE445EB3";
            // 
            // tabpageresult
            // 
            this.tabpageresult.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.tabpageresult.Flags = 65534;
            this.tabpageresult.LastVisibleSet = true;
            this.tabpageresult.MinimumSize = new System.Drawing.Size(50, 50);
            this.tabpageresult.Name = "tabpageresult";
            this.tabpageresult.Size = new System.Drawing.Size(923, 479);
            this.tabpageresult.StateCommon.Tab.Content.ShortText.Font = new System.Drawing.Font("黑体", 12F);
            this.tabpageresult.Text = "成果形式";
            this.tabpageresult.ToolTipTitle = "Page ToolTip";
            this.tabpageresult.UniqueName = "8B594C97920C486E19B8E5503F91E189";
            // 
            // tabpagemission
            // 
            this.tabpagemission.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.tabpagemission.Flags = 65534;
            this.tabpagemission.LastVisibleSet = true;
            this.tabpagemission.MinimumSize = new System.Drawing.Size(50, 50);
            this.tabpagemission.Name = "tabpagemission";
            this.tabpagemission.Size = new System.Drawing.Size(923, 479);
            this.tabpagemission.StateCommon.Tab.Content.ShortText.Font = new System.Drawing.Font("黑体", 12F);
            this.tabpagemission.Text = "第一年研究任务";
            this.tabpagemission.ToolTipTitle = "Page ToolTip";
            this.tabpagemission.UniqueName = "CAABE2079C184A485C8E421245B82AC1";
            // 
            // tpresume
            // 
            this.tpresume.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.tpresume.Controls.Add(this.kryptonNavigator4);
            this.tpresume.Flags = 65534;
            this.tpresume.ImageSmall = global::Properties.Resource.RESUME551;
            this.tpresume.LastVisibleSet = true;
            this.tpresume.MinimumSize = new System.Drawing.Size(50, 50);
            this.tpresume.Name = "tpresume";
            this.tpresume.Size = new System.Drawing.Size(714, 443);
            this.tpresume.Text = "        个  人  简  历";
            this.tpresume.ToolTipTitle = "Page ToolTip";
            this.tpresume.UniqueName = "790FF8B5865147FBAEBC693544071E86";
            // 
            // kryptonNavigator4
            // 
            this.kryptonNavigator4.AllowPageReorder = false;
            this.kryptonNavigator4.Button.CloseButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide;
            this.kryptonNavigator4.Button.ContextButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide;
            this.kryptonNavigator4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonNavigator4.Location = new System.Drawing.Point(0, 0);
            this.kryptonNavigator4.Name = "kryptonNavigator4";
            this.kryptonNavigator4.Pages.AddRange(new ComponentFactory.Krypton.Navigator.KryptonPage[] {
            this.tabeducation,
            this.tabworkexperience,
            this.tabacademic,
            this.tabTalentsPlan,
            this.tabNDProject,
            this.tabRTreatises,
            this.tbTechnologyAwards,
            this.tabndpatent});
            this.kryptonNavigator4.SelectedIndex = 0;
            this.kryptonNavigator4.Size = new System.Drawing.Size(714, 443);
            this.kryptonNavigator4.TabIndex = 0;
            this.kryptonNavigator4.Text = "kryptonNavigator4";
            this.kryptonNavigator4.Selecting += new System.EventHandler<ComponentFactory.Krypton.Navigator.KryptonPageCancelEventArgs>(this.pagewantChange_Selecting);
            // 
            // tabeducation
            // 
            this.tabeducation.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.tabeducation.Flags = 65534;
            this.tabeducation.LastVisibleSet = true;
            this.tabeducation.MinimumSize = new System.Drawing.Size(50, 50);
            this.tabeducation.Name = "tabeducation";
            this.tabeducation.Size = new System.Drawing.Size(712, 413);
            this.tabeducation.StateCommon.Tab.Content.ShortText.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabeducation.Text = "教育经历";
            this.tabeducation.ToolTipTitle = "Page ToolTip";
            this.tabeducation.UniqueName = "A33C82E43B324253CE9CFBDF7D4264FE";
            // 
            // tabworkexperience
            // 
            this.tabworkexperience.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.tabworkexperience.Flags = 65534;
            this.tabworkexperience.LastVisibleSet = true;
            this.tabworkexperience.MinimumSize = new System.Drawing.Size(50, 50);
            this.tabworkexperience.Name = "tabworkexperience";
            this.tabworkexperience.Size = new System.Drawing.Size(923, 479);
            this.tabworkexperience.StateCommon.Tab.Content.ShortText.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabworkexperience.Text = "工作经历";
            this.tabworkexperience.ToolTipTitle = "Page ToolTip";
            this.tabworkexperience.UniqueName = "1200CC9BC96E46A64EA266D31D9F1927";
            // 
            // tabacademic
            // 
            this.tabacademic.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.tabacademic.Flags = 65534;
            this.tabacademic.LastVisibleSet = true;
            this.tabacademic.MinimumSize = new System.Drawing.Size(50, 50);
            this.tabacademic.Name = "tabacademic";
            this.tabacademic.Size = new System.Drawing.Size(923, 479);
            this.tabacademic.StateCommon.Tab.Content.ShortText.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabacademic.Text = "学术任职";
            this.tabacademic.ToolTipTitle = "Page ToolTip";
            this.tabacademic.UniqueName = "D9C226546ECE479E90A4BE08F9BB7C99";
            // 
            // tabTalentsPlan
            // 
            this.tabTalentsPlan.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.tabTalentsPlan.Flags = 65534;
            this.tabTalentsPlan.LastVisibleSet = true;
            this.tabTalentsPlan.MinimumSize = new System.Drawing.Size(50, 50);
            this.tabTalentsPlan.Name = "tabTalentsPlan";
            this.tabTalentsPlan.Size = new System.Drawing.Size(923, 479);
            this.tabTalentsPlan.StateCommon.Tab.Content.ShortText.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabTalentsPlan.Text = "入选人才计划情况";
            this.tabTalentsPlan.ToolTipTitle = "Page ToolTip";
            this.tabTalentsPlan.UniqueName = "016D9E2CD8A0422D3CB924CA2D9D4B31";
            // 
            // tabNDProject
            // 
            this.tabNDProject.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.tabNDProject.Flags = 65534;
            this.tabNDProject.LastVisibleSet = true;
            this.tabNDProject.MinimumSize = new System.Drawing.Size(50, 50);
            this.tabNDProject.Name = "tabNDProject";
            this.tabNDProject.Size = new System.Drawing.Size(923, 479);
            this.tabNDProject.StateCommon.Tab.Content.ShortText.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabNDProject.Text = "承担国防项目";
            this.tabNDProject.ToolTipTitle = "Page ToolTip";
            this.tabNDProject.UniqueName = "19DDF01E97CF4D71209A6456EBF7ABA3";
            // 
            // tabRTreatises
            // 
            this.tabRTreatises.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.tabRTreatises.Flags = 65534;
            this.tabRTreatises.LastVisibleSet = true;
            this.tabRTreatises.MinimumSize = new System.Drawing.Size(50, 50);
            this.tabRTreatises.Name = "tabRTreatises";
            this.tabRTreatises.Size = new System.Drawing.Size(923, 479);
            this.tabRTreatises.StateCommon.Tab.Content.ShortText.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabRTreatises.Text = "代表性论著";
            this.tabRTreatises.ToolTipTitle = "Page ToolTip";
            this.tabRTreatises.UniqueName = "6558AA97248143890CB263CA0639A851";
            // 
            // tbTechnologyAwards
            // 
            this.tbTechnologyAwards.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.tbTechnologyAwards.Flags = 65534;
            this.tbTechnologyAwards.LastVisibleSet = true;
            this.tbTechnologyAwards.MinimumSize = new System.Drawing.Size(50, 50);
            this.tbTechnologyAwards.Name = "tbTechnologyAwards";
            this.tbTechnologyAwards.Size = new System.Drawing.Size(923, 479);
            this.tbTechnologyAwards.StateCommon.Tab.Content.ShortText.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbTechnologyAwards.Text = "科技奖项";
            this.tbTechnologyAwards.ToolTipTitle = "Page ToolTip";
            this.tbTechnologyAwards.UniqueName = "168841E6E42443E692B4D8F1F481D601";
            // 
            // tabndpatent
            // 
            this.tabndpatent.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.tabndpatent.Flags = 65534;
            this.tabndpatent.LastVisibleSet = true;
            this.tabndpatent.MinimumSize = new System.Drawing.Size(50, 50);
            this.tabndpatent.Name = "tabndpatent";
            this.tabndpatent.Size = new System.Drawing.Size(923, 479);
            this.tabndpatent.StateCommon.Tab.Content.ShortText.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabndpatent.Text = "专利情况";
            this.tabndpatent.ToolTipTitle = "Page ToolTip";
            this.tabndpatent.UniqueName = "D1B169570CB44C90B2BCC56EFEE5AAA7";
            // 
            // tprecomd
            // 
            this.tprecomd.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.tprecomd.Controls.Add(this.kryptonDockableNavigator2);
            this.tprecomd.Flags = 65534;
            this.tprecomd.ImageSmall = global::Properties.Resource.RECOMMENS551;
            this.tprecomd.LastVisibleSet = true;
            this.tprecomd.MinimumSize = new System.Drawing.Size(50, 50);
            this.tprecomd.Name = "tprecomd";
            this.tprecomd.Size = new System.Drawing.Size(925, 629);
            this.tprecomd.Text = "        推  荐  意  见";
            this.tprecomd.ToolTipTitle = "Page ToolTip";
            this.tprecomd.UniqueName = "54DEB2F8D8E34900B1A499F8A2804297";
            // 
            // kryptonDockableNavigator2
            // 
            this.kryptonDockableNavigator2.Button.CloseButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide;
            this.kryptonDockableNavigator2.Button.ContextButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide;
            this.kryptonDockableNavigator2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonDockableNavigator2.Location = new System.Drawing.Point(0, 0);
            this.kryptonDockableNavigator2.Name = "kryptonDockableNavigator2";
            this.kryptonDockableNavigator2.Pages.AddRange(new ComponentFactory.Krypton.Navigator.KryptonPage[] {
            this.tablepagerecommend});
            this.kryptonDockableNavigator2.SelectedIndex = 0;
            this.kryptonDockableNavigator2.Size = new System.Drawing.Size(925, 629);
            this.kryptonDockableNavigator2.TabIndex = 1;
            this.kryptonDockableNavigator2.Text = "kryptonDockableNavigator2";
            // 
            // tablepagerecommend
            // 
            this.tablepagerecommend.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.tablepagerecommend.Flags = 65534;
            this.tablepagerecommend.LastVisibleSet = true;
            this.tablepagerecommend.MinimumSize = new System.Drawing.Size(50, 50);
            this.tablepagerecommend.Name = "tablepagerecommend";
            this.tablepagerecommend.Size = new System.Drawing.Size(923, 599);
            this.tablepagerecommend.StateCommon.Tab.Content.ShortText.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tablepagerecommend.Text = "推荐意见";
            this.tablepagerecommend.ToolTipTitle = "Page ToolTip";
            this.tablepagerecommend.UniqueName = "2A9CF08C653B457F7693D064734D304D";
            // 
            // kpExtFile1
            // 
            this.kpExtFile1.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kpExtFile1.Controls.Add(this.kryptonNavigator8);
            this.kpExtFile1.Flags = 65534;
            this.kpExtFile1.ImageSmall = ((System.Drawing.Image)(resources.GetObject("kpExtFile1.ImageSmall")));
            this.kpExtFile1.LastVisibleSet = true;
            this.kpExtFile1.MinimumSize = new System.Drawing.Size(50, 50);
            this.kpExtFile1.Name = "kryptonPage2";
            this.kpExtFile1.Size = new System.Drawing.Size(925, 629);
            this.kpExtFile1.Text = "        保  密  资  质";
            this.kpExtFile1.ToolTipTitle = "Page ToolTip";
            this.kpExtFile1.UniqueName = "AED60046C7DD48024CAB854A778B3EDD";
            // 
            // kryptonNavigator8
            // 
            this.kryptonNavigator8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonNavigator8.Location = new System.Drawing.Point(0, 0);
            this.kryptonNavigator8.Name = "kryptonNavigator8";
            this.kryptonNavigator8.Pages.AddRange(new ComponentFactory.Krypton.Navigator.KryptonPage[] {
            this.kpExtFileSubPage});
            this.kryptonNavigator8.SelectedIndex = 0;
            this.kryptonNavigator8.Size = new System.Drawing.Size(925, 629);
            this.kryptonNavigator8.TabIndex = 0;
            // 
            // kpExtFileSubPage
            // 
            this.kpExtFileSubPage.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kpExtFileSubPage.Controls.Add(this.frmExtFileEditor);
            this.kpExtFileSubPage.Flags = 65534;
            this.kpExtFileSubPage.LastVisibleSet = true;
            this.kpExtFileSubPage.MinimumSize = new System.Drawing.Size(50, 50);
            this.kpExtFileSubPage.Name = "kryptonPage1";
            this.kpExtFileSubPage.Size = new System.Drawing.Size(923, 599);
            this.kpExtFileSubPage.StateCommon.Tab.Content.ShortText.Font = new System.Drawing.Font("黑体", 12F);
            this.kpExtFileSubPage.Text = "保密资质";
            this.kpExtFileSubPage.TextDescription = "";
            this.kpExtFileSubPage.TextTitle = "";
            this.kpExtFileSubPage.ToolTipTitle = "Page ToolTip";
            this.kpExtFileSubPage.UniqueName = "AB65481115594A9A048849F421AF0811";
            // 
            // frmExtFileEditor
            // 
            this.frmExtFileEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frmExtFileEditor.Location = new System.Drawing.Point(0, 0);
            this.frmExtFileEditor.Name = "frmExtFileEditor";
            this.frmExtFileEditor.Size = new System.Drawing.Size(923, 599);
            this.frmExtFileEditor.TabIndex = 0;
            // 
            // buttonSpecAny1
            // 
            this.buttonSpecAny1.UniqueName = "CB556486DAA54590678FC8384AD53700";
            // 
            // maintimer
            // 
            this.maintimer.Enabled = true;
            this.maintimer.Interval = 1000;
            this.maintimer.Tick += new System.EventHandler(this.maintimer_Tick);
            // 
            // kryptonManager1
            // 
            this.kryptonManager1.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Office2010Silver;
            // 
            // topBanner
            // 
            this.topBanner.Dock = System.Windows.Forms.DockStyle.Top;
            this.topBanner.Image = ((System.Drawing.Image)(resources.GetObject("topBanner.Image")));
            this.topBanner.Location = new System.Drawing.Point(0, 0);
            this.topBanner.Name = "topBanner";
            this.topBanner.Size = new System.Drawing.Size(1366, 120);
            this.topBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.topBanner.TabIndex = 0;
            this.topBanner.TabStop = false;
            // 
            // kpcontactinner
            // 
            this.kpcontactinner.Controls.Add(this.kryptonWrapLabel1);
            this.kpcontactinner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kpcontactinner.Location = new System.Drawing.Point(1, 1);
            this.kpcontactinner.Margin = new System.Windows.Forms.Padding(1);
            this.kpcontactinner.Name = "kpcontactinner";
            this.kpcontactinner.Size = new System.Drawing.Size(0, 95);
            this.kpcontactinner.TabIndex = 3;
            // 
            // kryptonWrapLabel1
            // 
            this.kryptonWrapLabel1.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.kryptonWrapLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.kryptonWrapLabel1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.kryptonWrapLabel1.Location = new System.Drawing.Point(5, 22);
            this.kryptonWrapLabel1.Margin = new System.Windows.Forms.Padding(0);
            this.kryptonWrapLabel1.Name = "kryptonWrapLabel1";
            this.kryptonWrapLabel1.Size = new System.Drawing.Size(0, 16);
            this.kryptonWrapLabel1.StateCommon.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // kpcontact
            // 
            this.kpcontact.BorderColor = System.Drawing.Color.Black;
            this.kpcontact.Location = new System.Drawing.Point(0, 0);
            this.kpcontact.Name = "kpcontact";
            this.kpcontact.Size = new System.Drawing.Size(200, 100);
            this.kpcontact.TabIndex = 0;
            // 
            // logicForm
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1127, 671);
            this.Controls.Add(this.defaulthost);
            this.Controls.Add(this.kryptonPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "logicForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "国防科技卓越青年科学基金申报系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.logicform_Load);
            this.Resize += new System.EventHandler(this.logicform_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.defaulthost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kpInputReadme)).EndInit();
            this.kpInputReadme.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonNavigator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablepageintroduction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tpuserinfo)).EndInit();
            this.tpuserinfo.ResumeLayout(false);
            this.tpuserinfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonNavigator2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conapplyuser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tpproject)).EndInit();
            this.tpproject.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDockableNavigator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablepageprojectbasicinfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tpfee)).EndInit();
            this.tpfee.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonNavigator5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabpagefee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tppaper)).EndInit();
            this.tppaper.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonNavigator3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabpagecontrbution)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabpageresearchplan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabpageresult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabpagemission)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tpresume)).EndInit();
            this.tpresume.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonNavigator4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabeducation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabworkexperience)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabacademic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabTalentsPlan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabNDProject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabRTreatises)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTechnologyAwards)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabndpatent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tprecomd)).EndInit();
            this.tprecomd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDockableNavigator2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablepagerecommend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kpExtFile1)).EndInit();
            this.kpExtFile1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonNavigator8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kpExtFileSubPage)).EndInit();
            this.kpExtFileSubPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.topBanner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kpcontactinner)).EndInit();
            this.kpcontactinner.ResumeLayout(false);
            this.kpcontactinner.PerformLayout();
            this.ResumeLayout(false);

		}

		public logicForm()
		{
			this.InitializeComponent();
		}

		private void OnEnable(object Sender, EventArgs e)
		{
			this.tpfee.Enabled = true;
			this.tppaper.Enabled = true;
			this.tpproject.Enabled = true;
			this.tprecomd.Enabled = true;
			this.tpresume.Enabled = true;
			this.tabpageresearchplan.Enabled = true;
			this.tabpageresult.Enabled = true;
			this.tabpagemission.Enabled = true;
			this.tabworkexperience.Enabled = true;
			this.tabacademic.Enabled = true;
			this.tabTalentsPlan.Enabled = true;
			this.tabNDProject.Enabled = true;
			this.tabRTreatises.Enabled = true;
			this.tbTechnologyAwards.Enabled = true;
			this.tabndpatent.Enabled = true;
		}

		private void OnDisable(object Sender, EventArgs e)
		{
			this.defaulthost.SelectedIndex = 1;
			this.tpfee.Enabled = false;
			this.tppaper.Enabled = false;
			this.tpproject.Enabled = false;
			this.tprecomd.Enabled = false;
			this.tpresume.Enabled = false;
			this.kryptonNavigator3.SelectedPage = this.tabpagecontrbution;
			this.tabpageresearchplan.Enabled = false;
			this.tabpageresult.Enabled = false;
			this.tabpagemission.Enabled = false;
			this.kryptonNavigator4.SelectedPage = this.tabeducation;
			this.tabworkexperience.Enabled = false;
			this.tabacademic.Enabled = false;
			this.tabTalentsPlan.Enabled = false;
			this.tabNDProject.Enabled = false;
			this.tabRTreatises.Enabled = false;
			this.tbTechnologyAwards.Enabled = false;
			this.tabndpatent.Enabled = false;
		}

		public void initcontent()
		{
            frmApplyUserInfo = new frmApplyUserInfo();
			frmApplyUserInfo.OnEnable += new frmApplyUserInfo.EnableNextpageHandler(this.OnEnable);
			frmApplyUserInfo.OnDisable += new frmApplyUserInfo.DisableNextPageHandler(this.OnDisable);
			frmApplyUserInfo.OnSaveCheckPassed += new BaseControl.SavePreCheckPassedHandler(this.item_OnSaveCheckPassed);
			frmApplyUserInfo.OnSaveCheckDeny += new BaseControl.SavePreCheckDenyHandler(this.item_OnSaveCheckDeny);
			frmApplyUserInfo.Dock = DockStyle.Fill;
			this.conapplyuser.Controls.Add(frmApplyUserInfo);
			this._baseControllist.Add(frmApplyUserInfo);
			frmBudget frmbudget = new frmBudget();
			frmbudget.Dock = DockStyle.Fill;
			frmbudget.ImeMode = ImeMode.Close;
			frmbudget.OnSaveCheckPassed += new BaseControl.SavePreCheckPassedHandler(this.item_OnSaveCheckPassed);
			frmbudget.OnSaveCheckDeny += new BaseControl.SavePreCheckDenyHandler(this.item_OnSaveCheckDeny);
			this.tabpagefee.Controls.Add(frmbudget);
			this._baseControllist.Add(frmbudget);
			frmProjectBasicInfo frmProjectBasicInfo = new frmProjectBasicInfo();
			frmProjectBasicInfo.Dock = DockStyle.Fill;
			frmProjectBasicInfo.OnSaveCheckPassed += new BaseControl.SavePreCheckPassedHandler(this.item_OnSaveCheckPassed);
			frmProjectBasicInfo.OnSaveCheckDeny += new BaseControl.SavePreCheckDenyHandler(this.item_OnSaveCheckDeny);
			this.tablepageprojectbasicinfo.Controls.Add(frmProjectBasicInfo);
			this._baseControllist.Add(frmProjectBasicInfo);
			frmContributionInfo frmContributionInfo = new frmContributionInfo();
			frmContributionInfo.Dock = DockStyle.Fill;
			frmContributionInfo.OnSaveCheckPassed += new BaseControl.SavePreCheckPassedHandler(this.item_OnSaveCheckPassed);
			frmContributionInfo.OnSaveCheckDeny += new BaseControl.SavePreCheckDenyHandler(this.item_OnSaveCheckDeny);
			this.tabpagecontrbution.Controls.Add(frmContributionInfo);
			this._baseControllist.Add(frmContributionInfo);
			frmResearchPlanInfo frmResearchPlanInfo = new frmResearchPlanInfo();
			frmResearchPlanInfo.Dock = DockStyle.Fill;
			frmResearchPlanInfo.OnSaveCheckPassed += new BaseControl.SavePreCheckPassedHandler(this.item_OnSaveCheckPassed);
			frmResearchPlanInfo.OnSaveCheckDeny += new BaseControl.SavePreCheckDenyHandler(this.item_OnSaveCheckDeny);
			this.tabpageresearchplan.Controls.Add(frmResearchPlanInfo);
			this._baseControllist.Add(frmResearchPlanInfo);
			frmResultInfo frmresultInfo = new frmResultInfo();
			frmresultInfo.Dock = DockStyle.Fill;
			frmresultInfo.OnSaveCheckPassed += new BaseControl.SavePreCheckPassedHandler(this.item_OnSaveCheckPassed);
			frmresultInfo.OnSaveCheckDeny += new BaseControl.SavePreCheckDenyHandler(this.item_OnSaveCheckDeny);
			this.tabpageresult.Controls.Add(frmresultInfo);
			this._baseControllist.Add(frmresultInfo);
			frmMissionInfo frmMissionInfo = new frmMissionInfo();
			frmMissionInfo.Dock = DockStyle.Fill;
			frmMissionInfo.OnSaveCheckPassed += new BaseControl.SavePreCheckPassedHandler(this.item_OnSaveCheckPassed);
			frmMissionInfo.OnSaveCheckDeny += new BaseControl.SavePreCheckDenyHandler(this.item_OnSaveCheckDeny);
			this.tabpagemission.Controls.Add(frmMissionInfo);
			this._baseControllist.Add(frmMissionInfo);
			frmRecommendInfo frmRecommendInfo = new frmRecommendInfo();
			frmRecommendInfo.Dock = DockStyle.Fill;
			frmRecommendInfo.OnSaveCheckPassed += new BaseControl.SavePreCheckPassedHandler(this.item_OnSaveCheckPassed);
			frmRecommendInfo.OnSaveCheckDeny += new BaseControl.SavePreCheckDenyHandler(this.item_OnSaveCheckDeny);
			this.tablepagerecommend.Controls.Add(frmRecommendInfo);
			this._baseControllist.Add(frmRecommendInfo);
			frmResumeEducation frmresume_education = new frmResumeEducation();
			frmresume_education.Dock = DockStyle.Fill;
			frmresume_education.OnSaveCheckPassed += new BaseControl.SavePreCheckPassedHandler(this.item_OnSaveCheckPassed);
			frmresume_education.OnSaveCheckDeny += new BaseControl.SavePreCheckDenyHandler(this.item_OnSaveCheckDeny);
			this.tabeducation.Controls.Add(frmresume_education);
			this._baseControllist.Add(frmresume_education);
			frmWorkExperienceInfo frmWorkExperienceInfo = new frmWorkExperienceInfo();
			frmWorkExperienceInfo.Dock = DockStyle.Fill;
			frmWorkExperienceInfo.OnSaveCheckPassed += new BaseControl.SavePreCheckPassedHandler(this.item_OnSaveCheckPassed);
			frmWorkExperienceInfo.OnSaveCheckDeny += new BaseControl.SavePreCheckDenyHandler(this.item_OnSaveCheckDeny);
			this.tabworkexperience.Controls.Add(frmWorkExperienceInfo);
			this._baseControllist.Add(frmWorkExperienceInfo);
			frmAcademicPost frmAcademicPost = new frmAcademicPost();
			frmAcademicPost.Dock = DockStyle.Fill;
			frmAcademicPost.OnSaveCheckPassed += new BaseControl.SavePreCheckPassedHandler(this.item_OnSaveCheckPassed);
			frmAcademicPost.OnSaveCheckDeny += new BaseControl.SavePreCheckDenyHandler(this.item_OnSaveCheckDeny);
			this.tabacademic.Controls.Add(frmAcademicPost);
			this._baseControllist.Add(frmAcademicPost);
			frmTalentsPlan frmTalentsPlan = new frmTalentsPlan();
			frmTalentsPlan.Dock = DockStyle.Fill;
			frmTalentsPlan.OnSaveCheckPassed += new BaseControl.SavePreCheckPassedHandler(this.item_OnSaveCheckPassed);
			frmTalentsPlan.OnSaveCheckDeny += new BaseControl.SavePreCheckDenyHandler(this.item_OnSaveCheckDeny);
			this.tabTalentsPlan.Controls.Add(frmTalentsPlan);
			this._baseControllist.Add(frmTalentsPlan);
			frmNDProject frmNDProject = new frmNDProject();
			frmNDProject.Dock = DockStyle.Fill;
			frmNDProject.OnSaveCheckPassed += new BaseControl.SavePreCheckPassedHandler(this.item_OnSaveCheckPassed);
			frmNDProject.OnSaveCheckDeny += new BaseControl.SavePreCheckDenyHandler(this.item_OnSaveCheckDeny);
			this.tabNDProject.Controls.Add(frmNDProject);
			this._baseControllist.Add(frmNDProject);
			frmRTreatises frmRTreatises = new frmRTreatises();
			frmRTreatises.Dock = DockStyle.Fill;
			frmRTreatises.OnSaveCheckPassed += new BaseControl.SavePreCheckPassedHandler(this.item_OnSaveCheckPassed);
			frmRTreatises.OnSaveCheckDeny += new BaseControl.SavePreCheckDenyHandler(this.item_OnSaveCheckDeny);
			this.tabRTreatises.Controls.Add(frmRTreatises);
			this._baseControllist.Add(frmRTreatises);
			frmTechnologyAwards frmTechnologyAwards = new frmTechnologyAwards();
			frmTechnologyAwards.Dock = DockStyle.Fill;
			frmTechnologyAwards.OnSaveCheckPassed += new BaseControl.SavePreCheckPassedHandler(this.item_OnSaveCheckPassed);
			frmTechnologyAwards.OnSaveCheckDeny += new BaseControl.SavePreCheckDenyHandler(this.item_OnSaveCheckDeny);
			this.tbTechnologyAwards.Controls.Add(frmTechnologyAwards);
			this._baseControllist.Add(frmTechnologyAwards);
			frmNDPatent frmNDPatent = new frmNDPatent();
			frmNDPatent.Dock = DockStyle.Fill;
			frmNDPatent.OnSaveCheckPassed += new BaseControl.SavePreCheckPassedHandler(this.item_OnSaveCheckPassed);
			frmNDPatent.OnSaveCheckDeny += new BaseControl.SavePreCheckDenyHandler(this.item_OnSaveCheckDeny);
			this.tabndpatent.Controls.Add(frmNDPatent);
			this._baseControllist.Add(frmNDPatent);
			frmIntroduction frmIntroduction = new frmIntroduction();
			frmIntroduction.Dock = DockStyle.Fill;
			frmIntroduction.OnSaveCheckPassed += new BaseControl.SavePreCheckPassedHandler(this.item_OnSaveCheckPassed);
			frmIntroduction.OnSaveCheckDeny += new BaseControl.SavePreCheckDenyHandler(this.item_OnSaveCheckDeny);
			this.tablepageintroduction.Controls.Add(frmIntroduction);
            this._baseControllist.Add(frmExtFileEditor);
        }

		private void btninit_Click(object sender, EventArgs e)
		{
			frmClear frmClear = new frmClear(this._baseControllist);
			frmClear.ClearOK += new frmClear.ClearOKHandler(this.frmclear_ClearOK);
			frmClear.ShowDialog();
		}

		private void frmclear_ClearOK(object sender, EventArgs e)
		{
			this.canSwitch = true;
			this.preusercontrol = null;
		}

		private void btnwordview_Click(object sender, EventArgs e)
		{
			if (!this.canSwitch)
			{
				MessageBox.Show("当前页面还未保存，请保存后再试。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}

            BuildMemoText();
            frmExportWord frmExportWord = new frmExportWord(EntityElement.ExportType.ToWord, false);
			frmExportWord.ShowDialog();
		}

		private void btnExport_Click(object sender, EventArgs e)
		{
			if (!this.canSwitch)
			{
				MessageBox.Show("当前页面还未保存，请保存后再试。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}

            BuildMemoText();
            ApplyUserBaseInfoService applyUserBaseInfoService = new ApplyUserBaseInfoService();
			ApplyUserInfo userBaseInfo = applyUserBaseInfoService.GetUserBaseInfo();
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = " zip files(*.zip)|*.zip";
            saveFileDialog.FileName = userBaseInfo.UnitName + "_" + userBaseInfo.ApplyUserName + ".zip";
			saveFileDialog.FilterIndex = 2;
			saveFileDialog.RestoreDirectory = true;
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				new frmExportWord(EntityElement.ExportType.ToZipFile, true)
				{
					Savefilename = saveFileDialog.FileName
				}.ShowDialog();
			}
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (!this.canSwitch)
			{
				MessageBox.Show("当前页面还未保存，请保存后再试。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			ApplyUserBaseInfoService applyUserBaseInfoService = new ApplyUserBaseInfoService();
			ApplyUserInfo userBaseInfo = applyUserBaseInfoService.GetUserBaseInfo();
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = " zip files(*.zip)|*.zip";
			saveFileDialog.FileName = userBaseInfo.UnitID + "_" + userBaseInfo.ApplyUserName + ".zip";
			saveFileDialog.FilterIndex = 2;
			saveFileDialog.RestoreDirectory = true;
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				new frmExportWord(EntityElement.ExportType.ToZipFile, false)
				{
					Savefilename = saveFileDialog.FileName
				}.ShowDialog();
			}
		}

		private void maintimer_Tick(object sender, EventArgs e)
		{
			this.lbcurtime.Text = "欢迎您！当前时间 " + DateTime.Now.ToString("yyyy年M月d日 H:mm:ss");
		}

		private void btnquit_Click(object sender, EventArgs e)
		{
			DialogResult dialogResult = MessageBox.Show("退出前是否备份打包数据？", "提示", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Asterisk);
			if (dialogResult == DialogResult.Yes)
			{
				this.btnSave_Click(sender, e);
				Application.Exit();
				return;
			}
			if (dialogResult == DialogResult.No)
			{
				Application.Exit();
			}
		}

		private void btnhelp_Click(object sender, EventArgs e)
		{
			frmHelp frmhelp = new frmHelp();
			frmhelp.ShowDialog();
		}

		private void logicform_Load(object sender, EventArgs e)
		{
			int width = Screen.PrimaryScreen.Bounds.Width;
			int num = width;
			if (num <= 1280)
			{
				if (num == 1024)
				{
                    this.topBanner.Image = global::Properties.Resource.BANNER1024;
					goto IL_B3;
				}
				if (num == 1280)
				{
                    this.topBanner.Image = global::Properties.Resource.BANNER1280;
					goto IL_B3;
				}
			}
			else
			{
				if (num == 1366)
				{
                    this.topBanner.Image = global::Properties.Resource.BANNER1366;
					goto IL_B3;
				}
				if (num == 1440)
				{
                    this.topBanner.Image = global::Properties.Resource.BANNER1440;
					goto IL_B3;
				}
				if (num == 1920)
				{
                    this.topBanner.Image = global::Properties.Resource.BANNER1920;
					goto IL_B3;
				}
			}
            this.topBanner.Image = global::Properties.Resource.BANNER1366;
			IL_B3:
			this.defaulthost.SelectedIndex = 0;
		}

		private void btnImport_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Multiselect = false;
			openFileDialog.RestoreDirectory = true;
			openFileDialog.Filter = "Zip压缩文件(*.zip)|*.zip";
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				frmRequestImport frmRequestImport = new frmRequestImport(openFileDialog.FileName, this._baseControllist);
				frmRequestImport.ImportOK += new frmRequestImport.ImportOKHandler(this.ifrmRequestImport_ImportOK);
				frmRequestImport.ShowDialog();
			}
		}

		private void ifrmRequestImport_ImportOK(object sender, EventArgs e)
		{
			this.canSwitch = true;
			this.preusercontrol = null;
		}

		private void pagewantChange_Selecting(object sender, KryptonPageCancelEventArgs e)
		{
			if (!this.canSwitch)
			{
				e.Cancel = true;
				if (this.preusercontrol != null)
				{
					this.preusercontrol = null;
					return;
				}
				MessageBox.Show("检测到当前页面部分必填字段未填写完成，无法切换到其他页面", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}

		private void item_OnSaveCheckDeny(object sender, EventArgs e)
		{
			this.canSwitch = false;
			this.preusercontrol = (UserControl)sender;
		}

		private void item_OnSaveCheckPassed(object sender, EventArgs e)
		{
			this.canSwitch = true;
		}

		private void logicform_Resize(object sender, EventArgs e)
		{
			int num = 540;
			int num2 = base.ClientSize.Height - this.kpcontact.Height;
			this.kpcontact.Top = num + (num2 - num) / 4;
		}

        private void btnUnitManage_Click(object sender, EventArgs e)
        {
            frmUnitSelect unitManage = new frmUnitSelect();
            unitManage.ShowDialog();

            frmApplyUserInfo.RefreshUnitList();
        }

        private void BuildMemoText()
        {
            try
            {
                //生成文本
                ProjectBasicInfoService _projectBasicInfoService = new ProjectBasicInfoService();
                TalentsPlanService _talentsPlanService = new TalentsPlanService();
                RTreatisesService _tTreatisesService = new RTreatisesService();
                TechnologyAwardsService _technologyAwardsService = new TechnologyAwardsService();
                NDPatentService _ndPatentService = new NDPatentService();
                NDProjectService _nDProjectService = new NDProjectService();

                StringBuilder gen1 = new StringBuilder();
                //人才：入选XX
                IList<TalentsPlan> list1 = _talentsPlanService.GetTalentsPlan();
                foreach (TalentsPlan obj in list1)
                {
                    if (obj.TalentsPlanName != null)
                    {
                        if (obj.TalentsPlanName.StartsWith("其它"))
                        {
                            continue;
                        }

                        gen1.Append(obj.TalentsPlanDate).Append("年").Append("入选").Append(obj.TalentsPlanName).Append(",");
                    }
                }
                if (gen1.ToString().EndsWith(","))
                {
                    gen1.Remove(gen1.Length - 1, 1);
                }
                gen1.Append("。");

                StringBuilder gen2 = new StringBuilder();
                //承担X等国防相关代表性项目X项
                //论文：发表SCI论文几篇(1,2,3)，EI论文几篇(1,2,3)
                //获奖：获得XX奖，排名X
                //专利：获得国防专利X项，国家专利X项
                IList<NDProject> list6 = _nDProjectService.GetNDProject();
                IList<RTreatises> list2 = _tTreatisesService.GetRTreatises();
                IList<TechnologyAwards> list3 = _technologyAwardsService.GetTechnologyAwards();
                IList<NDPatent> list4 = _ndPatentService.GetNDPatent();

                Dictionary<string, int> gftongjiDict = new Dictionary<string, int>();
                foreach (NDProject obj in list6)
                {
                    if (gftongjiDict.ContainsKey(obj.NDProjectName))
                    {
                        gftongjiDict[obj.NDProjectName]++;
                    }
                    else
                    {
                        gftongjiDict[obj.NDProjectName] = 1;
                    }
                }
                foreach (KeyValuePair<string, int> kvp in gftongjiDict)
                {
                    gen2.Append("承担").Append(kvp.Key).Append("等国防相关代表性项目").Append(kvp.Value).Append("项").Append(",");
                }
                if (gen2.ToString().EndsWith(","))
                {
                    gen2.Remove(gen2.Length - 1, 1);
                }
                gen2.Append(";");

                int sciCount = 0;
                int eiCount = 0;
                string sciOrder = string.Empty;
                string eiOrder = string.Empty;
                foreach (RTreatises obj in list2)
                {
                    if (obj.RTreatisesCollection != null)
                    {
                        if (obj.RTreatisesCollection.StartsWith("其它"))
                        {
                            continue;
                        }

                        if (obj.RTreatisesCollection.Equals("SCI"))
                        {
                            sciCount++;

                            sciOrder += obj.RTreatisesAuthor + ",";
                        }
                        else if (obj.RTreatisesCollection.Equals("EI"))
                        {
                            eiCount++;

                            eiOrder += obj.RTreatisesAuthor + ",";
                        }
                    }
                }

                if (sciCount >= 1 || eiCount >= 1)
                {
                    gen2.Append("发表");
                    if (sciCount >= 1)
                    {
                        gen2.Append("SCI论文").Append(sciCount).Append("篇").Append("(").Append(sciOrder).Append(")").Append(",");
                    }
                    if (eiCount >= 1)
                    {
                        gen2.Append("EI论文").Append(eiCount).Append("篇").Append("(").Append(eiOrder).Append(")");
                    }
                    if (gen2.ToString().EndsWith(","))
                    {
                        gen2.Remove(gen2.Length - 1, 1);
                    }
                    gen2.Append(";");
                }

                Dictionary<string, string[]> technologyDict = new Dictionary<string, string[]>();
                foreach (TechnologyAwards obj in list3)
                {
                    if (obj.TechnologyAwardsTypeLevel != null)
                    {
                        if (obj.TechnologyAwardsTypeLevel.StartsWith("其它"))
                        {
                            continue;
                        }

                        if (technologyDict.ContainsKey(obj.TechnologyAwardsTypeLevel))
                        {
                            string[] tempList = technologyDict[obj.TechnologyAwardsTypeLevel];
                            tempList[0] = (int.Parse(tempList[0]) + 1) + "";
                            tempList[1] += obj.TechnologyAwardsee + ",";
                        }
                        else
                        {
                            technologyDict.Add(obj.TechnologyAwardsTypeLevel, new string[] { "1", obj.TechnologyAwardsee + "," });
                        }
                    }
                }
                foreach (KeyValuePair<string, string[]> kvp in technologyDict)
                {
                    string[] tempList = kvp.Value;
                    gen2.Append("获得").Append(kvp.Key).Append("").Append(tempList[0]).Append("项").Append("(").Append(tempList[1]).Append("),");
                }
                if (gen2.ToString().EndsWith(","))
                {
                    gen2.Remove(gen2.Length - 1, 1);
                }
                gen2.Append(";");

                int gfCount = 0;
                string gfOrder = string.Empty;
                int gjCount = 0;
                string gjOrder = string.Empty;
                foreach (NDPatent obj in list4)
                {
                    if (obj.NDPatentType != null)
                    {
                        if (obj.NDPatentType.StartsWith("其它"))
                        {
                            continue;
                        }

                        if (obj.NDPatentType.Equals("国防"))
                        {
                            gfCount++;

                            gfOrder += obj.NDPatentApplicants + ",";
                        }
                        else if (obj.NDPatentType.Equals("国家"))
                        {
                            gjCount++;

                            gjOrder += obj.NDPatentApplicants + ",";
                        }
                    }
                }

                if (gfCount >= 1 || gjCount >= 1)
                {
                    gen2.Append("获得");
                    if (gfCount >= 1)
                    {
                        gen2.Append("国防专利").Append(gfCount).Append("项(").Append(gfOrder).Append(")").Append(",");
                    }
                    if (gjCount >= 1)
                    {
                        gen2.Append("国家专利").Append(gjCount).Append("项(").Append(gjOrder).Append(")");
                    }
                    if (gen2.ToString().EndsWith(","))
                    {
                        gen2.Remove(gen2.Length - 1, 1);
                    }
                    gen2.Append("。");
                }
                
                //填充数据
                ProjectBasicInfo pbi = _projectBasicInfoService.GetProjectBasicInfo();
                if (pbi.ProjectBrief != null)
                {
                    string[] ttt = pbi.ProjectBrief.Split(new string[] { "|" }, StringSplitOptions.None);
                    ttt[0] = gen1.ToString().Replace(",)", ")");
                    ttt[1] = gen2.ToString().Replace(",)", ")");

                    StringBuilder sb = new StringBuilder();
                    foreach (string t in ttt)
                    {
                        sb.Append(t).Append("|");
                    }

                    sb.Remove(sb.Length - 1, 1);

                    pbi.ProjectBrief = sb.ToString();
                }

                _projectBasicInfoService.UpdateProjectBasicInfo(pbi);
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.ToString());
            }
        }
    }
}