using ComponentFactory.Krypton.Navigator;
using ComponentFactory.Krypton.Toolkit;
using NDEY.BLL.Entity;
using NDEY.BLL.Service;
using NDEY.UI.Properties;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Collections.Generic;
using DevExpress.XtraGrid.Views.Grid;

namespace NDEY.UI.NDEYUserControl
{
	public class frmApplyUserInfo : BaseControl
	{
		public delegate void DisableNextPageHandler(object sender, EventArgs e);

		public delegate void EnableNextpageHandler(object sender, EventArgs e);

		private bool issaved;

		private ApplyUserBaseInfoService _applyUserBaseInfoService = new ApplyUserBaseInfoService();

        private UnitInforService _unitInforService = new UnitInforService();

        private IContainer components;

		private TableLayoutPanel tableLayoutPanel7;

		private KryptonPanel kryptonPanel2;

		private KryptonLabel kryptonLabel3;

		private HSkinTableLayoutPanel hSkinInputHost;

		private KryptonPanel kryptonPanel9;

		private KryptonLabel kryptonLabel13;

		private KryptonPanel kryptonPanel3;

		private KryptonLabel kryptonLabel4;

		private KryptonLabel kryptonLabel5;

		private KryptonLabel kryptonLabel6;

		private KryptonLabel kryptonLabel7;

		private KryptonComboBox txtSex;

		private KryptonLabel kryptonLabel8;

		private KryptonLabel kryptonLabel9;

		private KryptonLabel kryptonLabel10;

		private KryptonLabel kryptonLabel11;

		private KryptonLabel kryptonLabel12;

		private KryptonLabel kryptonLabel14;

		private KryptonLabel kryptonLabel15;

		private KryptonLabel kryptonLabel16;

		private KryptonPanel kryptonPanel4;

		private KryptonLabel kryptonLabel18;

		private KryptonLabel kryptonLabel17;

        private KryptonLabel kryptonLabe100;

		private KryptonLabel kryptonLabel19;

		private KryptonTextBox txtApplyUserName;

		private KryptonComboBox txtDegree;

		private KryptonComboBox txtJobTitle;

		private KryptonTextBox txtUnitPosition;

		private KryptonPanel kryptonPanel5;

		private KryptonPanel kryptonPanel6;

		private KryptonPanel kryptonPanel7;

        private KryptonPanel kryptonPanel102;

        private KryptonPanel kryptonPanel104;

        private KryptonTextBox txtYTUnitContacts;

		private KryptonTextBox txtEmail;

		private KryptonTextBox txtMobilePhone;

		private KryptonTextBox txtOfficePhones;

		private KryptonLabel kryptonLabel21;

		private KryptonLabel kryptonLabel22;

		private KryptonLabel kryptonLabel23;

		private KryptonLabel kryptonLabel20;

		private KryptonComboBox txtUnitProperties;

		private KryptonTextBox txtUnitContactsPhone;

		private KryptonComboBox txtUnitForORG;

		private KryptonPanel kryptonPanel8;

		private TableLayoutPanel tableLayoutPanel25;

		private KryptonButton btnApplyUserInfoSave;

		private KryptonTextBox txtMainResearch;

		private KryptonPanel kryptonPanel1;

		private KryptonTextBox txtCardNo;

		private KryptonPanel kryptonPanel10;

		private KryptonPanel kryptonPanel11;

        private KryptonTextBox txtUnitNormal;

		private KryptonPanel kryptonPanel12;

        private KryptonPanel kryptonPanel101;

		private KryptonTextBox txtUnitAddress;

		private KryptonPanel kryptonPanel13;

		private DateTimePicker txtBirthday;
        private BankSelectButton txtWorkUnitList;
        //private DevExpress.XtraGrid.Views.Grid.GridView txtWorkUnitListView;
        private DevExpress.XtraGrid.Columns.GridColumn gcID;
        private DevExpress.XtraGrid.Columns.GridColumn gcUnitName;
        private DevExpress.XtraGrid.Columns.GridColumn gcUnitType;
        private DevExpress.XtraGrid.Columns.GridColumn gcUnitBankUser;
        private DevExpress.XtraGrid.Columns.GridColumn gcUnitBankName;
        private DevExpress.XtraGrid.Columns.GridColumn gcUnitBankNo;
        private BankSelectButton txtUnitList;
        //private DevExpress.XtraGrid.Views.Grid.GridView txtUnitListView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private KryptonLabel kryptonLabel1;
        private KryptonTextBox txtWorkUnit;
        private KryptonPanel kryptonPanel14;
        private KryptonPanel kryptonPanel15;
        private KryptonLabel kryptonLabel2;
        private KryptonTextBox txtYTUnitName;
        private KryptonLabel kryptonLabel24;
        private KryptonTextBox txtYTIDCard;
        private ButtonSpecAny buttonSpecAny2;

		public event frmApplyUserInfo.DisableNextPageHandler OnDisable;

		public event frmApplyUserInfo.EnableNextpageHandler OnEnable;

		public frmApplyUserInfo()
		{
			this.InitializeComponent();
		}

		protected virtual void OnDisableEvent(EventArgs e)
		{
			if (this.OnDisable != null)
			{
				this.OnDisable(this, e);
			}
		}

		protected virtual void OnEnableEvent(EventArgs e)
		{
			if (this.OnEnable != null)
			{
				this.OnEnable(this, e);
			}
		}

		protected override void OnLoad(EventArgs e)
		{
			this.RefreshCall();
			base.OnLoad(e);
		}

		private bool CanSave()
		{
			this.OnSaveCheckDenyEvent(EventArgs.Empty);
			if (this.txtCardNo.Text != string.Empty && !Regex.IsMatch(this.txtCardNo.Text, "^[1-9]\\d{7}((0\\d)|(1[0-2]))(([0|1|2]\\d)|3[0-1])\\d{3}$|^[1-9]\\d{5}[1-9]\\d{3}((0\\d)|(1[0-2]))(([0|1|2]\\d)|3[0-1])\\d{3}([0-9]|X)$", RegexOptions.IgnoreCase))
			{
				MessageBox.Show("请输入正确的身份证号码！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return false;
			}
			if (this.txtMobilePhone.Text != string.Empty && !Regex.IsMatch(this.txtMobilePhone.Text, "^1[3|4|5|7|8][0-9]{9}$", RegexOptions.IgnoreCase))
			{
				MessageBox.Show("请输入正确的手机号码！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return false;
			}
			if (this.txtEmail.Text != string.Empty && !Regex.IsMatch(this.txtEmail.Text, "^\\w+([-+.]\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*$", RegexOptions.IgnoreCase))
			{
				MessageBox.Show("请输入正确的电子邮箱！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return false;
			}
			this.OnSaveCheckPassedEvent(EventArgs.Empty);
			return true;
		}

		private void SaveProgress()
		{
			ApplyUserInfo applyUserInfo = new ApplyUserInfo();
			applyUserInfo.ApplyUserName = this.txtApplyUserName.Text;
			applyUserInfo.Sex = this.txtSex.Text;
			applyUserInfo.Birthday = this.txtBirthday.Value.ToLongDateString();
			applyUserInfo.Degree = this.txtDegree.Text;
			applyUserInfo.JobTitle = this.txtJobTitle.Text;
			applyUserInfo.UnitPosition = this.txtUnitPosition.Text;
			applyUserInfo.MainResearch = this.txtMainResearch.Text;
			applyUserInfo.CardNo = this.txtCardNo.Text;
			applyUserInfo.OfficePhones = this.txtOfficePhones.Text;
			applyUserInfo.MobilePhone = this.txtMobilePhone.Text;
			applyUserInfo.EMail = this.txtEmail.Text;
            applyUserInfo.WorkUnitName = txtWorkUnit.Text;
            if (this.txtWorkUnitList.EditValue != null)
            {
                applyUserInfo.WorkUnitID = this.txtWorkUnitList.EditValue.ToString();
            }
            if (this.txtUnitList.EditValue != null)
            {
                applyUserInfo.UnitID = this.txtUnitList.EditValue.ToString();
            }
            applyUserInfo.UnitName = txtYTUnitName.Text;
            applyUserInfo.UnitIDCard = txtYTIDCard.Text;
            applyUserInfo.UnitNormal = this.txtUnitNormal.Text;
            applyUserInfo.UnitContacts = this.txtYTUnitContacts.Text;
			applyUserInfo.UnitForORG = this.txtUnitForORG.Text;
			applyUserInfo.UnitProperties = this.txtUnitProperties.Text;
			applyUserInfo.UnitContactsPhone = this.txtUnitContactsPhone.Text;
			applyUserInfo.UnitAddress = this.txtUnitAddress.Text;
			this._applyUserBaseInfoService.UpdateUserBaseInfo(applyUserInfo);
		}

		private void btnApplyUserInfoSave_Click(object sender, EventArgs e)
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
            RefreshUnitList();

			ApplyUserInfo userBaseInfo = this._applyUserBaseInfoService.GetUserBaseInfo();
			if (userBaseInfo == null || (userBaseInfo != null && userBaseInfo.BirInDB == string.Empty))
			{
				this.OnDisableEvent(EventArgs.Empty);
			}
			else
			{
				this.OnEnableEvent(EventArgs.Empty);
			}
			if (userBaseInfo != null)
			{
				this.txtApplyUserName.Text = userBaseInfo.ApplyUserName;
				if (string.IsNullOrEmpty(userBaseInfo.Sex))
				{
					this.txtSex.SelectedIndex = -1;
				}
				else
				{
					this.txtSex.Text = userBaseInfo.Sex;
				}
				this.txtBirthday.Value = DateTime.Parse(userBaseInfo.Birthday);
				if (string.IsNullOrEmpty(userBaseInfo.Degree))
				{
					this.txtDegree.SelectedIndex = -1;
				}
				else
				{
					this.txtDegree.Text = userBaseInfo.Degree;
				}
				if (string.IsNullOrEmpty(userBaseInfo.JobTitle))
				{
					this.txtJobTitle.SelectedIndex = -1;
				}
				else
				{
					this.txtJobTitle.Text = userBaseInfo.JobTitle;
				}
				this.txtUnitPosition.Text = userBaseInfo.UnitPosition;
				this.txtMainResearch.Text = userBaseInfo.MainResearch;
				this.txtCardNo.Text = userBaseInfo.CardNo;
				this.txtOfficePhones.Text = userBaseInfo.OfficePhones;
				this.txtMobilePhone.Text = userBaseInfo.MobilePhone;
				this.txtEmail.Text = userBaseInfo.EMail;
                                
                this.txtWorkUnitList.EditValue = userBaseInfo.WorkUnitID;
                this.txtWorkUnit.Text = userBaseInfo.WorkUnitName;

                this.txtUnitList.EditValue = userBaseInfo.UnitID;
                this.txtYTUnitName.Text = userBaseInfo.UnitName;
                this.txtYTIDCard.Text = userBaseInfo.UnitIDCard;
                this.txtUnitNormal.Text = userBaseInfo.UnitNormal;

				this.txtYTUnitContacts.Text = userBaseInfo.UnitContacts;
				this.txtUnitForORG.Text = userBaseInfo.UnitForORG;
				if (string.IsNullOrEmpty(userBaseInfo.UnitProperties))
				{
					this.txtUnitProperties.SelectedIndex = -1;
				}
				else
				{
					this.txtUnitProperties.Text = userBaseInfo.UnitProperties;
				}
				this.txtUnitContactsPhone.Text = userBaseInfo.UnitContactsPhone;
				this.txtUnitAddress.Text = userBaseInfo.UnitAddress;
			}
		}

        public void RefreshUnitList()
        {
            //IList<UnitInfor> unitList = _unitInforService.GetUnitInforList();

            //txtUnitList.Properties.DataSource = unitList;
            //txtUnitList.Properties.DisplayMember = "UnitName";
            //txtUnitList.Properties.ValueMember = "ID";
            //txtWorkUnitList.Properties.DataSource = unitList;
            //txtWorkUnitList.Properties.DisplayMember = "UnitName";
            //txtWorkUnitList.Properties.ValueMember = "ID";
        }

        private void frmApplyUserInfo_Leave(object sender, EventArgs e)
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmApplyUserInfo));
            this.kryptonPanel104 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.txtYTUnitContacts = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel25 = new System.Windows.Forms.TableLayoutPanel();
            this.btnApplyUserInfoSave = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.hSkinInputHost = new NDEY.UI.HSkinTableLayoutPanel();
            this.kryptonPanel3 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel19 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtYTIDCard = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel6 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel7 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtSex = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.txtApplyUserName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtBirthday = new System.Windows.Forms.DateTimePicker();
            this.kryptonLabel8 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel9 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel10 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtDegree = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.txtJobTitle = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.txtUnitPosition = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel11 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonPanel5 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.txtMainResearch = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel12 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonPanel6 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.txtCardNo = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonPanel10 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel14 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel15 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel16 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtEmail = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtMobilePhone = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtOfficePhones = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonPanel4 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel18 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabe100 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonPanel102 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.txtUnitNormal = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.buttonSpecAny2 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.kryptonPanel101 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel21 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel22 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel23 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtUnitProperties = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.txtUnitContactsPhone = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtUnitForORG = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel20 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonPanel8 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.txtUnitAddress = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonPanel13 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel17 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonPanel7 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.txtUnitList = new NDEY.UI.BankSelectButton();
            this.kryptonPanel12 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtYTUnitName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonPanel14 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.txtWorkUnit = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonPanel15 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonPanel9 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.txtWorkUnitList = new NDEY.UI.BankSelectButton();
            this.kryptonPanel11 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel13 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel24 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.gcID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcUnitName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcUnitType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcUnitBankUser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcUnitBankName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcUnitBankNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel104)).BeginInit();
            this.kryptonPanel104.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel25.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            this.hSkinInputHost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).BeginInit();
            this.kryptonPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDegree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJobTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel5)).BeginInit();
            this.kryptonPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel6)).BeginInit();
            this.kryptonPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel4)).BeginInit();
            this.kryptonPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel102)).BeginInit();
            this.kryptonPanel102.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel101)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnitProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnitForORG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel8)).BeginInit();
            this.kryptonPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel7)).BeginInit();
            this.kryptonPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel14)).BeginInit();
            this.kryptonPanel14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel9)).BeginInit();
            this.kryptonPanel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel11)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel104
            // 
            this.hSkinInputHost.SetColumnSpan(this.kryptonPanel104, 3);
            this.kryptonPanel104.Controls.Add(this.txtYTUnitContacts);
            this.kryptonPanel104.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel104.Location = new System.Drawing.Point(193, 283);
            this.kryptonPanel104.Name = "kryptonPanel104";
            this.kryptonPanel104.Size = new System.Drawing.Size(370, 34);
            this.kryptonPanel104.StateCommon.Color1 = System.Drawing.Color.White;
            this.kryptonPanel104.TabIndex = 48;
            // 
            // txtYTUnitContacts
            // 
            this.txtYTUnitContacts.AlwaysActive = false;
            this.txtYTUnitContacts.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtYTUnitContacts.Location = new System.Drawing.Point(0, 10);
            this.txtYTUnitContacts.Margin = new System.Windows.Forms.Padding(2, 8, 8, 8);
            this.txtYTUnitContacts.Name = "txtYTUnitContacts";
            this.txtYTUnitContacts.Size = new System.Drawing.Size(370, 24);
            this.txtYTUnitContacts.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtYTUnitContacts.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtYTUnitContacts.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.txtYTUnitContacts.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtYTUnitContacts.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtYTUnitContacts.TabIndex = 31;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 3;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel25, 1, 3);
            this.tableLayoutPanel7.Controls.Add(this.kryptonPanel2, 1, 1);
            this.tableLayoutPanel7.Controls.Add(this.hSkinInputHost, 1, 2);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 5;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(978, 591);
            this.tableLayoutPanel7.TabIndex = 4;
            // 
            // tableLayoutPanel25
            // 
            this.tableLayoutPanel25.ColumnCount = 2;
            this.tableLayoutPanel25.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel25.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel25.Controls.Add(this.btnApplyUserInfoSave, 1, 0);
            this.tableLayoutPanel25.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel25.Location = new System.Drawing.Point(53, 479);
            this.tableLayoutPanel25.Name = "tableLayoutPanel25";
            this.tableLayoutPanel25.RowCount = 1;
            this.tableLayoutPanel25.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel25.Size = new System.Drawing.Size(872, 36);
            this.tableLayoutPanel25.TabIndex = 48;
            // 
            // btnApplyUserInfoSave
            // 
            this.btnApplyUserInfoSave.Location = new System.Drawing.Point(755, 8);
            this.btnApplyUserInfoSave.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.btnApplyUserInfoSave.Name = "btnApplyUserInfoSave";
            this.btnApplyUserInfoSave.TabIndex = 1;
            this.btnApplyUserInfoSave.Values.Text = "保存";
            this.btnApplyUserInfoSave.Click += new System.EventHandler(this.btnApplyUserInfoSave_Click);
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.kryptonLabel3);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel2.Location = new System.Drawing.Point(51, 21);
            this.kryptonPanel2.Margin = new System.Windows.Forms.Padding(1);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(876, 52);
            this.kryptonPanel2.StateCommon.Color1 = System.Drawing.Color.White;
            this.kryptonPanel2.TabIndex = 0;
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.AllowDrop = true;
            this.kryptonLabel3.AutoSize = false;
            this.kryptonLabel3.Location = new System.Drawing.Point(0, 0);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(755, 50);
            this.kryptonLabel3.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.kryptonLabel3.TabIndex = 0;
            this.kryptonLabel3.Values.Text = "本人保证所填写的信息均真实有效，无任何虚假信息。\r\n本人完全清楚本声明的法律后果，如有不实，愿意承担相应的法律责任。";
            // 
            // hSkinInputHost
            // 
            this.hSkinInputHost.BorderColor = System.Drawing.Color.Black;
            this.hSkinInputHost.ColumnCount = 7;
            this.hSkinInputHost.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.hSkinInputHost.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.hSkinInputHost.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.hSkinInputHost.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.hSkinInputHost.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31F));
            this.hSkinInputHost.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.hSkinInputHost.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39F));
            this.hSkinInputHost.Controls.Add(this.kryptonPanel3, 0, 0);
            this.hSkinInputHost.Controls.Add(this.kryptonLabel19, 5, 8);
            this.hSkinInputHost.Controls.Add(this.kryptonLabel5, 1, 0);
            this.hSkinInputHost.Controls.Add(this.txtYTIDCard, 6, 8);
            this.hSkinInputHost.Controls.Add(this.kryptonLabel6, 3, 0);
            this.hSkinInputHost.Controls.Add(this.kryptonLabel7, 5, 0);
            this.hSkinInputHost.Controls.Add(this.txtSex, 4, 0);
            this.hSkinInputHost.Controls.Add(this.txtApplyUserName, 2, 0);
            this.hSkinInputHost.Controls.Add(this.txtBirthday, 6, 0);
            this.hSkinInputHost.Controls.Add(this.kryptonLabel8, 1, 1);
            this.hSkinInputHost.Controls.Add(this.kryptonLabel9, 3, 1);
            this.hSkinInputHost.Controls.Add(this.kryptonLabel10, 5, 1);
            this.hSkinInputHost.Controls.Add(this.txtDegree, 2, 1);
            this.hSkinInputHost.Controls.Add(this.txtJobTitle, 4, 1);
            this.hSkinInputHost.Controls.Add(this.txtUnitPosition, 6, 1);
            this.hSkinInputHost.Controls.Add(this.kryptonLabel11, 1, 2);
            this.hSkinInputHost.Controls.Add(this.kryptonPanel5, 2, 2);
            this.hSkinInputHost.Controls.Add(this.kryptonLabel12, 1, 3);
            this.hSkinInputHost.Controls.Add(this.kryptonPanel6, 2, 3);
            this.hSkinInputHost.Controls.Add(this.kryptonLabel14, 1, 4);
            this.hSkinInputHost.Controls.Add(this.kryptonLabel15, 3, 4);
            this.hSkinInputHost.Controls.Add(this.kryptonLabel16, 5, 4);
            this.hSkinInputHost.Controls.Add(this.txtEmail, 6, 4);
            this.hSkinInputHost.Controls.Add(this.txtMobilePhone, 4, 4);
            this.hSkinInputHost.Controls.Add(this.txtOfficePhones, 2, 4);
            this.hSkinInputHost.Controls.Add(this.kryptonPanel4, 0, 6);
            this.hSkinInputHost.Controls.Add(this.kryptonLabe100, 0, 7);
            this.hSkinInputHost.Controls.Add(this.kryptonPanel102, 1, 7);
            this.hSkinInputHost.Controls.Add(this.kryptonLabel21, 1, 9);
            this.hSkinInputHost.Controls.Add(this.kryptonLabel22, 3, 9);
            this.hSkinInputHost.Controls.Add(this.kryptonLabel23, 5, 9);
            this.hSkinInputHost.Controls.Add(this.txtUnitProperties, 4, 9);
            this.hSkinInputHost.Controls.Add(this.txtUnitContactsPhone, 6, 9);
            this.hSkinInputHost.Controls.Add(this.txtUnitForORG, 2, 9);
            this.hSkinInputHost.Controls.Add(this.kryptonLabel20, 1, 10);
            this.hSkinInputHost.Controls.Add(this.kryptonPanel8, 2, 10);
            this.hSkinInputHost.Controls.Add(this.kryptonLabel17, 3, 6);
            this.hSkinInputHost.Controls.Add(this.kryptonPanel7, 4, 6);
            this.hSkinInputHost.Controls.Add(this.kryptonLabel2, 1, 6);
            this.hSkinInputHost.Controls.Add(this.txtYTUnitName, 2, 6);
            this.hSkinInputHost.Controls.Add(this.kryptonPanel14, 2, 5);
            this.hSkinInputHost.Controls.Add(this.kryptonPanel9, 6, 5);
            this.hSkinInputHost.Controls.Add(this.kryptonLabel13, 5, 5);
            this.hSkinInputHost.Controls.Add(this.kryptonLabel1, 1, 5);
            this.hSkinInputHost.Controls.Add(this.kryptonLabel24, 1, 8);
            this.hSkinInputHost.Controls.Add(this.kryptonPanel104, 2, 8);
            this.hSkinInputHost.Dock = System.Windows.Forms.DockStyle.Top;
            this.hSkinInputHost.Location = new System.Drawing.Point(50, 74);
            this.hSkinInputHost.Margin = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.hSkinInputHost.Name = "hSkinInputHost";
            this.hSkinInputHost.RowCount = 11;
            this.hSkinInputHost.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.hSkinInputHost.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.hSkinInputHost.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.hSkinInputHost.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.hSkinInputHost.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.hSkinInputHost.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 0F));
            this.hSkinInputHost.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.hSkinInputHost.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.hSkinInputHost.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.hSkinInputHost.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.hSkinInputHost.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.hSkinInputHost.Size = new System.Drawing.Size(878, 400);
            this.hSkinInputHost.TabIndex = 2;
            // 
            // kryptonPanel3
            // 
            this.kryptonPanel3.Controls.Add(this.kryptonLabel4);
            this.kryptonPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel3.Location = new System.Drawing.Point(1, 1);
            this.kryptonPanel3.Margin = new System.Windows.Forms.Padding(1, 1, 0, 0);
            this.kryptonPanel3.Name = "kryptonPanel3";
            this.hSkinInputHost.SetRowSpan(this.kryptonPanel3, 6);
            this.kryptonPanel3.Size = new System.Drawing.Size(59, 199);
            this.kryptonPanel3.StateCommon.Color1 = System.Drawing.Color.White;
            this.kryptonPanel3.TabIndex = 1;
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(16, 60);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(28, 96);
            this.kryptonLabel4.StateNormal.ShortText.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.kryptonLabel4.TabIndex = 0;
            this.kryptonLabel4.Values.Text = "申\r\n请\r\n人\r\n信\r\n息";
            // 
            // kryptonLabel19
            // 
            this.kryptonLabel19.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonLabel19.Location = new System.Drawing.Point(569, 294);
            this.kryptonLabel19.Name = "kryptonLabel19";
            this.kryptonLabel19.Size = new System.Drawing.Size(124, 23);
            this.kryptonLabel19.StateCommon.ShortText.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.kryptonLabel19.StateNormal.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.kryptonLabel19.TabIndex = 18;
            this.kryptonLabel19.Values.Text = "联系人身份证";
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonLabel5.Location = new System.Drawing.Point(63, 14);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(124, 23);
            this.kryptonLabel5.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.kryptonLabel5.TabIndex = 5;
            this.kryptonLabel5.Values.Text = "姓    名";
            // 
            // txtYTIDCard
            // 
            this.txtYTIDCard.AlwaysActive = false;
            this.txtYTIDCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtYTIDCard.Location = new System.Drawing.Point(698, 288);
            this.txtYTIDCard.Margin = new System.Windows.Forms.Padding(2, 8, 8, 8);
            this.txtYTIDCard.Name = "txtYTIDCard";
            this.txtYTIDCard.Size = new System.Drawing.Size(172, 24);
            this.txtYTIDCard.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtYTIDCard.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtYTIDCard.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.txtYTIDCard.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtYTIDCard.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtYTIDCard.TabIndex = 31;
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonLabel6.Location = new System.Drawing.Point(331, 14);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(89, 23);
            this.kryptonLabel6.StateNormal.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.kryptonLabel6.TabIndex = 3;
            this.kryptonLabel6.Values.Text = "性    别";
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonLabel7.Location = new System.Drawing.Point(569, 14);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(124, 23);
            this.kryptonLabel7.StateCommon.ShortText.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.kryptonLabel7.StateNormal.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.kryptonLabel7.TabIndex = 4;
            this.kryptonLabel7.Values.Text = "出生年月";
            // 
            // txtSex
            // 
            this.txtSex.AlwaysActive = false;
            this.txtSex.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtSex.DropDownWidth = 62;
            this.txtSex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.txtSex.Location = new System.Drawing.Point(425, 8);
            this.txtSex.Margin = new System.Windows.Forms.Padding(2, 8, 8, 8);
            this.txtSex.Name = "txtSex";
            this.txtSex.Size = new System.Drawing.Size(133, 25);
            this.txtSex.StateActive.ComboBox.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtSex.StateActive.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtSex.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.Transparent;
            this.txtSex.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtSex.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSex.TabIndex = 5;
            // 
            // txtApplyUserName
            // 
            this.txtApplyUserName.AlwaysActive = false;
            this.txtApplyUserName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtApplyUserName.Location = new System.Drawing.Point(192, 8);
            this.txtApplyUserName.Margin = new System.Windows.Forms.Padding(2, 8, 8, 8);
            this.txtApplyUserName.Name = "txtApplyUserName";
            this.txtApplyUserName.Size = new System.Drawing.Size(128, 24);
            this.txtApplyUserName.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtApplyUserName.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtApplyUserName.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.txtApplyUserName.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtApplyUserName.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtApplyUserName.TabIndex = 2;
            // 
            // txtBirthday
            // 
            this.txtBirthday.CustomFormat = "yyyy年M月";
            this.txtBirthday.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtBirthday.Location = new System.Drawing.Point(698, 8);
            this.txtBirthday.Margin = new System.Windows.Forms.Padding(2, 8, 8, 8);
            this.txtBirthday.Name = "txtBirthday";
            this.txtBirthday.ShowUpDown = true;
            this.txtBirthday.Size = new System.Drawing.Size(172, 26);
            this.txtBirthday.TabIndex = 47;
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonLabel8.Location = new System.Drawing.Point(63, 54);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.Size = new System.Drawing.Size(124, 23);
            this.kryptonLabel8.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.kryptonLabel8.TabIndex = 7;
            this.kryptonLabel8.Values.Text = "学    位";
            // 
            // kryptonLabel9
            // 
            this.kryptonLabel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonLabel9.Location = new System.Drawing.Point(331, 54);
            this.kryptonLabel9.Name = "kryptonLabel9";
            this.kryptonLabel9.Size = new System.Drawing.Size(89, 23);
            this.kryptonLabel9.StateNormal.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.kryptonLabel9.TabIndex = 8;
            this.kryptonLabel9.Values.Text = "职    称";
            // 
            // kryptonLabel10
            // 
            this.kryptonLabel10.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonLabel10.Location = new System.Drawing.Point(569, 54);
            this.kryptonLabel10.Name = "kryptonLabel10";
            this.kryptonLabel10.Size = new System.Drawing.Size(124, 23);
            this.kryptonLabel10.StateCommon.ShortText.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.kryptonLabel10.StateNormal.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.kryptonLabel10.TabIndex = 9;
            this.kryptonLabel10.Values.Text = "职    务";
            // 
            // txtDegree
            // 
            this.txtDegree.AlwaysActive = false;
            this.txtDegree.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtDegree.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtDegree.DropDownWidth = 77;
            this.txtDegree.Items.AddRange(new object[] {
            "博士",
            "硕士",
            "学士",
            "无学位"});
            this.txtDegree.Location = new System.Drawing.Point(192, 48);
            this.txtDegree.Margin = new System.Windows.Forms.Padding(2, 8, 8, 8);
            this.txtDegree.Name = "txtDegree";
            this.txtDegree.Size = new System.Drawing.Size(128, 25);
            this.txtDegree.StateActive.ComboBox.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtDegree.StateActive.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtDegree.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.Transparent;
            this.txtDegree.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtDegree.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtDegree.TabIndex = 21;
            // 
            // txtJobTitle
            // 
            this.txtJobTitle.AlwaysActive = false;
            this.txtJobTitle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtJobTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtJobTitle.DropDownWidth = 77;
            this.txtJobTitle.Items.AddRange(new object[] {
            "教授",
            "副教授",
            "研究员",
            "副研究员",
            "高级讲师",
            "高级工程师",
            "高级实验师",
            "主任医师",
            "副主任医师",
            "主任药师",
            "副主任药师",
            "主任护师",
            "副主任护师",
            "主任技师",
            "副主任技师",
            "其他"});
            this.txtJobTitle.Location = new System.Drawing.Point(425, 48);
            this.txtJobTitle.Margin = new System.Windows.Forms.Padding(2, 8, 8, 8);
            this.txtJobTitle.Name = "txtJobTitle";
            this.txtJobTitle.Size = new System.Drawing.Size(133, 25);
            this.txtJobTitle.StateActive.ComboBox.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtJobTitle.StateActive.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtJobTitle.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.Transparent;
            this.txtJobTitle.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtJobTitle.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtJobTitle.TabIndex = 22;
            // 
            // txtUnitPosition
            // 
            this.txtUnitPosition.AlwaysActive = false;
            this.txtUnitPosition.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtUnitPosition.Location = new System.Drawing.Point(698, 48);
            this.txtUnitPosition.Margin = new System.Windows.Forms.Padding(2, 8, 8, 8);
            this.txtUnitPosition.Name = "txtUnitPosition";
            this.txtUnitPosition.Size = new System.Drawing.Size(172, 24);
            this.txtUnitPosition.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtUnitPosition.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtUnitPosition.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.txtUnitPosition.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtUnitPosition.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtUnitPosition.TabIndex = 23;
            // 
            // kryptonLabel11
            // 
            this.kryptonLabel11.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonLabel11.Location = new System.Drawing.Point(63, 94);
            this.kryptonLabel11.Name = "kryptonLabel11";
            this.kryptonLabel11.Size = new System.Drawing.Size(124, 23);
            this.kryptonLabel11.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.kryptonLabel11.TabIndex = 10;
            this.kryptonLabel11.Values.Text = "主要研究领域";
            // 
            // kryptonPanel5
            // 
            this.hSkinInputHost.SetColumnSpan(this.kryptonPanel5, 5);
            this.kryptonPanel5.Controls.Add(this.txtMainResearch);
            this.kryptonPanel5.Controls.Add(this.kryptonPanel1);
            this.kryptonPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel5.Location = new System.Drawing.Point(191, 81);
            this.kryptonPanel5.Margin = new System.Windows.Forms.Padding(1, 1, 1, 0);
            this.kryptonPanel5.Name = "kryptonPanel5";
            this.kryptonPanel5.Size = new System.Drawing.Size(686, 39);
            this.kryptonPanel5.StateCommon.Color1 = System.Drawing.Color.White;
            this.kryptonPanel5.TabIndex = 24;
            // 
            // txtMainResearch
            // 
            this.txtMainResearch.AlwaysActive = false;
            this.txtMainResearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtMainResearch.Location = new System.Drawing.Point(0, 10);
            this.txtMainResearch.Margin = new System.Windows.Forms.Padding(0);
            this.txtMainResearch.Name = "txtMainResearch";
            this.txtMainResearch.Size = new System.Drawing.Size(686, 24);
            this.txtMainResearch.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtMainResearch.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtMainResearch.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.txtMainResearch.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtMainResearch.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtMainResearch.TabIndex = 6;
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(686, 10);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.White;
            this.kryptonPanel1.TabIndex = 1;
            // 
            // kryptonLabel12
            // 
            this.kryptonLabel12.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonLabel12.Location = new System.Drawing.Point(63, 134);
            this.kryptonLabel12.Name = "kryptonLabel12";
            this.kryptonLabel12.Size = new System.Drawing.Size(124, 23);
            this.kryptonLabel12.StateNormal.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.kryptonLabel12.TabIndex = 11;
            this.kryptonLabel12.Values.Text = "身份证号码";
            // 
            // kryptonPanel6
            // 
            this.hSkinInputHost.SetColumnSpan(this.kryptonPanel6, 5);
            this.kryptonPanel6.Controls.Add(this.txtCardNo);
            this.kryptonPanel6.Controls.Add(this.kryptonPanel10);
            this.kryptonPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel6.Location = new System.Drawing.Point(191, 121);
            this.kryptonPanel6.Margin = new System.Windows.Forms.Padding(1, 1, 1, 0);
            this.kryptonPanel6.Name = "kryptonPanel6";
            this.kryptonPanel6.Size = new System.Drawing.Size(686, 39);
            this.kryptonPanel6.StateCommon.Color1 = System.Drawing.Color.White;
            this.kryptonPanel6.TabIndex = 25;
            // 
            // txtCardNo
            // 
            this.txtCardNo.AlwaysActive = false;
            this.txtCardNo.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtCardNo.Location = new System.Drawing.Point(0, 10);
            this.txtCardNo.Margin = new System.Windows.Forms.Padding(8);
            this.txtCardNo.Name = "txtCardNo";
            this.txtCardNo.Size = new System.Drawing.Size(686, 24);
            this.txtCardNo.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtCardNo.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtCardNo.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.txtCardNo.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtCardNo.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCardNo.TabIndex = 2;
            // 
            // kryptonPanel10
            // 
            this.kryptonPanel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel10.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel10.Name = "kryptonPanel10";
            this.kryptonPanel10.Size = new System.Drawing.Size(686, 10);
            this.kryptonPanel10.StateCommon.Color1 = System.Drawing.Color.White;
            this.kryptonPanel10.TabIndex = 1;
            // 
            // kryptonLabel14
            // 
            this.kryptonLabel14.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonLabel14.Location = new System.Drawing.Point(63, 174);
            this.kryptonLabel14.Name = "kryptonLabel14";
            this.kryptonLabel14.Size = new System.Drawing.Size(124, 23);
            this.kryptonLabel14.StateNormal.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.kryptonLabel14.TabIndex = 13;
            this.kryptonLabel14.Values.Text = "办公电话";
            // 
            // kryptonLabel15
            // 
            this.kryptonLabel15.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonLabel15.Location = new System.Drawing.Point(331, 174);
            this.kryptonLabel15.Name = "kryptonLabel15";
            this.kryptonLabel15.Size = new System.Drawing.Size(89, 23);
            this.kryptonLabel15.StateCommon.ShortText.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.kryptonLabel15.StateNormal.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.kryptonLabel15.TabIndex = 14;
            this.kryptonLabel15.Values.Text = "手   机";
            // 
            // kryptonLabel16
            // 
            this.kryptonLabel16.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonLabel16.Location = new System.Drawing.Point(569, 174);
            this.kryptonLabel16.Name = "kryptonLabel16";
            this.kryptonLabel16.Size = new System.Drawing.Size(124, 23);
            this.kryptonLabel16.StateCommon.ShortText.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.kryptonLabel16.StateNormal.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.kryptonLabel16.TabIndex = 15;
            this.kryptonLabel16.Values.Text = "电子邮箱";
            // 
            // txtEmail
            // 
            this.txtEmail.AlwaysActive = false;
            this.txtEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEmail.Location = new System.Drawing.Point(698, 168);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2, 8, 8, 8);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(172, 24);
            this.txtEmail.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtEmail.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtEmail.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.txtEmail.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtEmail.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtEmail.TabIndex = 34;
            // 
            // txtMobilePhone
            // 
            this.txtMobilePhone.AlwaysActive = false;
            this.txtMobilePhone.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtMobilePhone.Location = new System.Drawing.Point(425, 168);
            this.txtMobilePhone.Margin = new System.Windows.Forms.Padding(2, 8, 8, 8);
            this.txtMobilePhone.Name = "txtMobilePhone";
            this.txtMobilePhone.Size = new System.Drawing.Size(133, 24);
            this.txtMobilePhone.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtMobilePhone.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtMobilePhone.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.txtMobilePhone.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtMobilePhone.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtMobilePhone.TabIndex = 35;
            // 
            // txtOfficePhones
            // 
            this.txtOfficePhones.AlwaysActive = false;
            this.txtOfficePhones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtOfficePhones.Location = new System.Drawing.Point(192, 168);
            this.txtOfficePhones.Margin = new System.Windows.Forms.Padding(2, 8, 8, 8);
            this.txtOfficePhones.Name = "txtOfficePhones";
            this.txtOfficePhones.Size = new System.Drawing.Size(128, 24);
            this.txtOfficePhones.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtOfficePhones.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtOfficePhones.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.txtOfficePhones.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtOfficePhones.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtOfficePhones.TabIndex = 36;
            // 
            // kryptonPanel4
            // 
            this.kryptonPanel4.Controls.Add(this.kryptonLabel18);
            this.kryptonPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel4.Location = new System.Drawing.Point(1, 201);
            this.kryptonPanel4.Margin = new System.Windows.Forms.Padding(1, 1, 0, 1);
            this.kryptonPanel4.Name = "kryptonPanel4";
            this.hSkinInputHost.SetRowSpan(this.kryptonPanel4, 4);
            this.kryptonPanel4.Size = new System.Drawing.Size(59, 158);
            this.kryptonPanel4.StateCommon.Color1 = System.Drawing.Color.White;
            this.kryptonPanel4.TabIndex = 16;
            // 
            // kryptonLabel18
            // 
            this.kryptonLabel18.Location = new System.Drawing.Point(10, 31);
            this.kryptonLabel18.Name = "kryptonLabel18";
            this.kryptonLabel18.Size = new System.Drawing.Size(45, 59);
            this.kryptonLabel18.StateNormal.ShortText.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.kryptonLabel18.TabIndex = 0;
            this.kryptonLabel18.Values.Text = "依托\r\n单位\r\n信息";
            // 
            // kryptonLabe100
            // 
            this.kryptonLabe100.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonLabe100.Location = new System.Drawing.Point(63, 254);
            this.kryptonLabe100.Name = "kryptonLabe100";
            this.kryptonLabe100.Size = new System.Drawing.Size(124, 23);
            this.kryptonLabe100.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.kryptonLabe100.TabIndex = 17;
            this.kryptonLabe100.Values.Text = "单位常用名";
            // 
            // kryptonPanel102
            // 
            this.hSkinInputHost.SetColumnSpan(this.kryptonPanel102, 5);
            this.kryptonPanel102.Controls.Add(this.txtUnitNormal);
            this.kryptonPanel102.Controls.Add(this.kryptonPanel101);
            this.kryptonPanel102.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel102.Location = new System.Drawing.Point(191, 241);
            this.kryptonPanel102.Margin = new System.Windows.Forms.Padding(1, 1, 1, 0);
            this.kryptonPanel102.Name = "kryptonPanel102";
            this.kryptonPanel102.Size = new System.Drawing.Size(686, 39);
            this.kryptonPanel102.StateCommon.Color1 = System.Drawing.Color.White;
            this.kryptonPanel102.TabIndex = 30;
            // 
            // txtUnitNormal
            // 
            this.txtUnitNormal.AlwaysActive = false;
            this.txtUnitNormal.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny2});
            this.txtUnitNormal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUnitNormal.Location = new System.Drawing.Point(0, 10);
            this.txtUnitNormal.Margin = new System.Windows.Forms.Padding(8);
            this.txtUnitNormal.Name = "txtUnitNormal";
            this.txtUnitNormal.Size = new System.Drawing.Size(686, 26);
            this.txtUnitNormal.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtUnitNormal.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtUnitNormal.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.txtUnitNormal.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtUnitNormal.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtUnitNormal.TabIndex = 2;
            // 
            // buttonSpecAny2
            // 
            this.buttonSpecAny2.ColorMap = System.Drawing.Color.Transparent;
            this.buttonSpecAny2.Image = ((System.Drawing.Image)(resources.GetObject("buttonSpecAny2.Image")));
            this.buttonSpecAny2.Text = "若本单位有与公章不一致的常用名时，请在此填写常用名";
            this.buttonSpecAny2.UniqueName = "9CA7A7940F314DC88B99D7C0BD7D4DC9E";
            // 
            // kryptonPanel101
            // 
            this.kryptonPanel101.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel101.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel101.Name = "kryptonPanel101";
            this.kryptonPanel101.Size = new System.Drawing.Size(686, 10);
            this.kryptonPanel101.StateCommon.Color1 = System.Drawing.Color.White;
            this.kryptonPanel101.TabIndex = 1;
            // 
            // kryptonLabel21
            // 
            this.kryptonLabel21.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonLabel21.Location = new System.Drawing.Point(63, 334);
            this.kryptonLabel21.Name = "kryptonLabel21";
            this.kryptonLabel21.Size = new System.Drawing.Size(124, 23);
            this.kryptonLabel21.StateNormal.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.kryptonLabel21.TabIndex = 37;
            this.kryptonLabel21.Values.Text = "隶属部门";
            // 
            // kryptonLabel22
            // 
            this.kryptonLabel22.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonLabel22.Location = new System.Drawing.Point(331, 334);
            this.kryptonLabel22.Name = "kryptonLabel22";
            this.kryptonLabel22.Size = new System.Drawing.Size(89, 23);
            this.kryptonLabel22.StateCommon.ShortText.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.kryptonLabel22.StateNormal.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.kryptonLabel22.TabIndex = 38;
            this.kryptonLabel22.Values.Text = "单位性质";
            // 
            // kryptonLabel23
            // 
            this.kryptonLabel23.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonLabel23.Location = new System.Drawing.Point(569, 334);
            this.kryptonLabel23.Name = "kryptonLabel23";
            this.kryptonLabel23.Size = new System.Drawing.Size(124, 23);
            this.kryptonLabel23.StateCommon.ShortText.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.kryptonLabel23.StateNormal.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.kryptonLabel23.TabIndex = 39;
            this.kryptonLabel23.Values.Text = "联系电话";
            // 
            // txtUnitProperties
            // 
            this.txtUnitProperties.AlwaysActive = false;
            this.txtUnitProperties.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtUnitProperties.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtUnitProperties.DropDownWidth = 104;
            this.txtUnitProperties.Items.AddRange(new object[] {
            "军队单位",
            "教育部",
            "工信部",
            "军工集团",
            "民口高校",
            "民口科研院所",
            "其它"});
            this.txtUnitProperties.Location = new System.Drawing.Point(425, 328);
            this.txtUnitProperties.Margin = new System.Windows.Forms.Padding(2, 8, 8, 8);
            this.txtUnitProperties.Name = "txtUnitProperties";
            this.txtUnitProperties.Size = new System.Drawing.Size(133, 25);
            this.txtUnitProperties.StateActive.ComboBox.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtUnitProperties.StateActive.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtUnitProperties.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.Transparent;
            this.txtUnitProperties.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtUnitProperties.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtUnitProperties.TabIndex = 40;
            // 
            // txtUnitContactsPhone
            // 
            this.txtUnitContactsPhone.AlwaysActive = false;
            this.txtUnitContactsPhone.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtUnitContactsPhone.Location = new System.Drawing.Point(698, 328);
            this.txtUnitContactsPhone.Margin = new System.Windows.Forms.Padding(2, 8, 8, 8);
            this.txtUnitContactsPhone.Name = "txtUnitContactsPhone";
            this.txtUnitContactsPhone.Size = new System.Drawing.Size(172, 24);
            this.txtUnitContactsPhone.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtUnitContactsPhone.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtUnitContactsPhone.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.txtUnitContactsPhone.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtUnitContactsPhone.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtUnitContactsPhone.StateNormal.Border.Color1 = System.Drawing.Color.Transparent;
            this.txtUnitContactsPhone.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtUnitContactsPhone.TabIndex = 41;
            // 
            // txtUnitForORG
            // 
            this.txtUnitForORG.AlwaysActive = false;
            this.txtUnitForORG.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtUnitForORG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtUnitForORG.DropDownWidth = 128;
            this.txtUnitForORG.Items.AddRange(new object[] {
            "中国科学院",
            "中国兵器工业集团公司",
            "中国兵器装备集团公司",
            "中国船舶工业集团公司",
            "中国船舶重工集团公司",
            "中国电子科技集团公司",
            "中国电子信息产业集团有限公司",
            "中国航空发动机集团公司",
            "中国航空工业集团公司",
            "中国航天科工集团公司",
            "中国航天科技集团公司",
            "中国核工业集团公司",
            "中国工程物理研究院",
            "陆军",
            "海军",
            "空军",
            "火箭军",
            "战略支援部队",
            "军事科学院",
            "国防大学",
            "国防科技大学",
            "武警部队",
            "联合勤务保障部队",
            "军委机关直属单位"});
            this.txtUnitForORG.Location = new System.Drawing.Point(192, 328);
            this.txtUnitForORG.Margin = new System.Windows.Forms.Padding(2, 8, 8, 8);
            this.txtUnitForORG.Name = "txtUnitForORG";
            this.txtUnitForORG.Size = new System.Drawing.Size(128, 25);
            this.txtUnitForORG.StateActive.ComboBox.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtUnitForORG.StateActive.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtUnitForORG.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.Transparent;
            this.txtUnitForORG.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtUnitForORG.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtUnitForORG.TabIndex = 42;
            // 
            // kryptonLabel20
            // 
            this.kryptonLabel20.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonLabel20.Location = new System.Drawing.Point(63, 375);
            this.kryptonLabel20.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.kryptonLabel20.Name = "kryptonLabel20";
            this.kryptonLabel20.Size = new System.Drawing.Size(124, 23);
            this.kryptonLabel20.StateNormal.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.kryptonLabel20.TabIndex = 19;
            this.kryptonLabel20.Values.Text = "机要地址";
            // 
            // kryptonPanel8
            // 
            this.hSkinInputHost.SetColumnSpan(this.kryptonPanel8, 5);
            this.kryptonPanel8.Controls.Add(this.txtUnitAddress);
            this.kryptonPanel8.Controls.Add(this.kryptonPanel13);
            this.kryptonPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel8.Location = new System.Drawing.Point(191, 361);
            this.kryptonPanel8.Margin = new System.Windows.Forms.Padding(1);
            this.kryptonPanel8.Name = "kryptonPanel8";
            this.kryptonPanel8.Size = new System.Drawing.Size(686, 38);
            this.kryptonPanel8.StateCommon.Color1 = System.Drawing.Color.White;
            this.kryptonPanel8.TabIndex = 44;
            // 
            // txtUnitAddress
            // 
            this.txtUnitAddress.AlwaysActive = false;
            this.txtUnitAddress.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtUnitAddress.Location = new System.Drawing.Point(0, 10);
            this.txtUnitAddress.Margin = new System.Windows.Forms.Padding(8);
            this.txtUnitAddress.Name = "txtUnitAddress";
            this.txtUnitAddress.Size = new System.Drawing.Size(686, 24);
            this.txtUnitAddress.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtUnitAddress.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtUnitAddress.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.txtUnitAddress.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtUnitAddress.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtUnitAddress.TabIndex = 2;
            // 
            // kryptonPanel13
            // 
            this.kryptonPanel13.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel13.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel13.Name = "kryptonPanel13";
            this.kryptonPanel13.Size = new System.Drawing.Size(686, 10);
            this.kryptonPanel13.StateCommon.Color1 = System.Drawing.Color.White;
            this.kryptonPanel13.TabIndex = 1;
            // 
            // kryptonLabel17
            // 
            this.kryptonLabel17.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonLabel17.Location = new System.Drawing.Point(331, 214);
            this.kryptonLabel17.Name = "kryptonLabel17";
            this.kryptonLabel17.Size = new System.Drawing.Size(89, 23);
            this.kryptonLabel17.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.kryptonLabel17.TabIndex = 17;
            this.kryptonLabel17.Values.Text = "开户帐号";
            // 
            // kryptonPanel7
            // 
            this.hSkinInputHost.SetColumnSpan(this.kryptonPanel7, 3);
            this.kryptonPanel7.Controls.Add(this.txtUnitList);
            this.kryptonPanel7.Controls.Add(this.kryptonPanel12);
            this.kryptonPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel7.Location = new System.Drawing.Point(424, 201);
            this.kryptonPanel7.Margin = new System.Windows.Forms.Padding(1, 1, 1, 0);
            this.kryptonPanel7.Name = "kryptonPanel7";
            this.kryptonPanel7.Size = new System.Drawing.Size(453, 39);
            this.kryptonPanel7.StateCommon.Color1 = System.Drawing.Color.White;
            this.kryptonPanel7.TabIndex = 30;
            // 
            // txtUnitList
            // 
            this.txtUnitList.DefaultEditText = "请选择开户帐号！";
            this.txtUnitList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUnitList.EditText = "请选择开户帐号！";
            this.txtUnitList.EditValue = "";
            this.txtUnitList.Location = new System.Drawing.Point(0, 10);
            this.txtUnitList.Name = "txtUnitList";
            this.txtUnitList.Size = new System.Drawing.Size(453, 29);
            this.txtUnitList.TabIndex = 30;
            this.txtUnitList.Values.Text = "请选择开户帐号！";
            this.txtUnitList.EditValueChanged += new System.EventHandler(this.txtUnitList_EditValueChanged);
            // 
            // kryptonPanel12
            // 
            this.kryptonPanel12.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel12.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel12.Name = "kryptonPanel12";
            this.kryptonPanel12.Size = new System.Drawing.Size(453, 10);
            this.kryptonPanel12.StateCommon.Color1 = System.Drawing.Color.White;
            this.kryptonPanel12.TabIndex = 1;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonLabel2.Location = new System.Drawing.Point(63, 214);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(124, 23);
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.kryptonLabel2.TabIndex = 17;
            this.kryptonLabel2.Values.Text = "单位名称";
            // 
            // txtYTUnitName
            // 
            this.txtYTUnitName.AlwaysActive = false;
            this.txtYTUnitName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtYTUnitName.Location = new System.Drawing.Point(192, 208);
            this.txtYTUnitName.Margin = new System.Windows.Forms.Padding(2, 8, 8, 8);
            this.txtYTUnitName.Name = "txtYTUnitName";
            this.txtYTUnitName.Size = new System.Drawing.Size(128, 24);
            this.txtYTUnitName.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtYTUnitName.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtYTUnitName.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.txtYTUnitName.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtYTUnitName.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtYTUnitName.TabIndex = 34;
            this.txtYTUnitName.TextChanged += new System.EventHandler(this.txtYTUnitName_TextChanged);
            // 
            // kryptonPanel14
            // 
            this.hSkinInputHost.SetColumnSpan(this.kryptonPanel14, 3);
            this.kryptonPanel14.Controls.Add(this.txtWorkUnit);
            this.kryptonPanel14.Controls.Add(this.kryptonPanel15);
            this.kryptonPanel14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel14.Location = new System.Drawing.Point(191, 201);
            this.kryptonPanel14.Margin = new System.Windows.Forms.Padding(1, 1, 1, 0);
            this.kryptonPanel14.Name = "kryptonPanel14";
            this.kryptonPanel14.Size = new System.Drawing.Size(374, 1);
            this.kryptonPanel14.StateCommon.Color1 = System.Drawing.Color.White;
            this.kryptonPanel14.TabIndex = 46;
            // 
            // txtWorkUnit
            // 
            this.txtWorkUnit.AlwaysActive = false;
            this.txtWorkUnit.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtWorkUnit.Location = new System.Drawing.Point(0, 10);
            this.txtWorkUnit.Margin = new System.Windows.Forms.Padding(2, 8, 8, 8);
            this.txtWorkUnit.Name = "txtWorkUnit";
            this.txtWorkUnit.Size = new System.Drawing.Size(374, 24);
            this.txtWorkUnit.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtWorkUnit.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtWorkUnit.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.txtWorkUnit.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtWorkUnit.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtWorkUnit.TabIndex = 34;
            // 
            // kryptonPanel15
            // 
            this.kryptonPanel15.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel15.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel15.Name = "kryptonPanel15";
            this.kryptonPanel15.Size = new System.Drawing.Size(374, 10);
            this.kryptonPanel15.StateCommon.Color1 = System.Drawing.Color.White;
            this.kryptonPanel15.TabIndex = 1;
            // 
            // kryptonPanel9
            // 
            this.kryptonPanel9.Controls.Add(this.txtWorkUnitList);
            this.kryptonPanel9.Controls.Add(this.kryptonPanel11);
            this.kryptonPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel9.Location = new System.Drawing.Point(697, 201);
            this.kryptonPanel9.Margin = new System.Windows.Forms.Padding(1, 1, 1, 0);
            this.kryptonPanel9.Name = "kryptonPanel9";
            this.kryptonPanel9.Size = new System.Drawing.Size(180, 1);
            this.kryptonPanel9.StateCommon.Color1 = System.Drawing.Color.White;
            this.kryptonPanel9.TabIndex = 46;
            // 
            // txtWorkUnitList
            // 
            this.txtWorkUnitList.DefaultEditText = null;
            this.txtWorkUnitList.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtWorkUnitList.EditText = "请选择单位开户帐号！";
            this.txtWorkUnitList.EditValue = "";
            this.txtWorkUnitList.Location = new System.Drawing.Point(0, 10);
            this.txtWorkUnitList.Name = "txtWorkUnitList";
            this.txtWorkUnitList.Size = new System.Drawing.Size(180, 29);
            this.txtWorkUnitList.TabIndex = 30;
            this.txtWorkUnitList.Values.Text = "请选择单位开户帐号！";
            // 
            // kryptonPanel11
            // 
            this.kryptonPanel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel11.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel11.Name = "kryptonPanel11";
            this.kryptonPanel11.Size = new System.Drawing.Size(180, 10);
            this.kryptonPanel11.StateCommon.Color1 = System.Drawing.Color.White;
            this.kryptonPanel11.TabIndex = 1;
            // 
            // kryptonLabel13
            // 
            this.kryptonLabel13.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonLabel13.Location = new System.Drawing.Point(569, 203);
            this.kryptonLabel13.Name = "kryptonLabel13";
            this.kryptonLabel13.Size = new System.Drawing.Size(124, 1);
            this.kryptonLabel13.StateNormal.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.kryptonLabel13.TabIndex = 45;
            this.kryptonLabel13.Values.Text = "单位开户帐号";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonLabel1.Location = new System.Drawing.Point(63, 203);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(124, 1);
            this.kryptonLabel1.StateNormal.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.kryptonLabel1.TabIndex = 45;
            this.kryptonLabel1.Values.Text = "工作单位";
            // 
            // kryptonLabel24
            // 
            this.kryptonLabel24.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonLabel24.Location = new System.Drawing.Point(63, 294);
            this.kryptonLabel24.Name = "kryptonLabel24";
            this.kryptonLabel24.Size = new System.Drawing.Size(124, 23);
            this.kryptonLabel24.StateCommon.ShortText.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.kryptonLabel24.StateNormal.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.kryptonLabel24.TabIndex = 18;
            this.kryptonLabel24.Values.Text = "单位联系人";
            // 
            // gcID
            // 
            this.gcID.FieldName = "ID";
            this.gcID.Name = "gcID";
            // 
            // gcUnitName
            // 
            this.gcUnitName.Caption = "单位名称";
            this.gcUnitName.FieldName = "UnitName";
            this.gcUnitName.Name = "gcUnitName";
            this.gcUnitName.Visible = true;
            this.gcUnitName.VisibleIndex = 0;
            // 
            // gcUnitType
            // 
            this.gcUnitType.Caption = "单位类型";
            this.gcUnitType.FieldName = "UnitType";
            this.gcUnitType.Name = "gcUnitType";
            this.gcUnitType.Visible = true;
            this.gcUnitType.VisibleIndex = 1;
            // 
            // gcUnitBankUser
            // 
            this.gcUnitBankUser.Caption = "开户名称";
            this.gcUnitBankUser.FieldName = "UnitBankUser";
            this.gcUnitBankUser.Name = "gcUnitBankUser";
            this.gcUnitBankUser.Visible = true;
            this.gcUnitBankUser.VisibleIndex = 2;
            // 
            // gcUnitBankName
            // 
            this.gcUnitBankName.Caption = "开户行名称";
            this.gcUnitBankName.FieldName = "UnitBankName";
            this.gcUnitBankName.Name = "gcUnitBankName";
            this.gcUnitBankName.Visible = true;
            this.gcUnitBankName.VisibleIndex = 3;
            // 
            // gcUnitBankNo
            // 
            this.gcUnitBankNo.Caption = "账号";
            this.gcUnitBankNo.FieldName = "UnitBankNo";
            this.gcUnitBankNo.Name = "gcUnitBankNo";
            this.gcUnitBankNo.Visible = true;
            this.gcUnitBankNo.VisibleIndex = 4;
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "ID";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "单位名称";
            this.gridColumn2.FieldName = "UnitName";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "单位类型";
            this.gridColumn3.FieldName = "UnitType";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "开户名称";
            this.gridColumn4.FieldName = "UnitBankUser";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "开户行名称";
            this.gridColumn5.FieldName = "UnitBankName";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 3;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "账号";
            this.gridColumn6.FieldName = "UnitBankNo";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 4;
            // 
            // frmApplyUserInfo
            // 
            this.Controls.Add(this.tableLayoutPanel7);
            this.Name = "frmApplyUserInfo";
            this.Size = new System.Drawing.Size(978, 591);
            this.Leave += new System.EventHandler(this.frmApplyUserInfo_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel104)).EndInit();
            this.kryptonPanel104.ResumeLayout(false);
            this.kryptonPanel104.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel25.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.hSkinInputHost.ResumeLayout(false);
            this.hSkinInputHost.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).EndInit();
            this.kryptonPanel3.ResumeLayout(false);
            this.kryptonPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDegree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJobTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel5)).EndInit();
            this.kryptonPanel5.ResumeLayout(false);
            this.kryptonPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel6)).EndInit();
            this.kryptonPanel6.ResumeLayout(false);
            this.kryptonPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel4)).EndInit();
            this.kryptonPanel4.ResumeLayout(false);
            this.kryptonPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel102)).EndInit();
            this.kryptonPanel102.ResumeLayout(false);
            this.kryptonPanel102.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel101)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnitProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnitForORG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel8)).EndInit();
            this.kryptonPanel8.ResumeLayout(false);
            this.kryptonPanel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel7)).EndInit();
            this.kryptonPanel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel14)).EndInit();
            this.kryptonPanel14.ResumeLayout(false);
            this.kryptonPanel14.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel9)).EndInit();
            this.kryptonPanel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel11)).EndInit();
            this.ResumeLayout(false);

		}

        private void txtUnitList_EditValueChanged(object sender, EventArgs e)
        {
            txtWorkUnitList.EditValue = txtUnitList.EditValue;
            string[] list = new string[] { txtUnitList.EditValue.ToString() };
            IList<UnitInfor> unitList = _unitInforService.GetUnitInforList(list);
            foreach (UnitInfor unitInfo in unitList)
            {
                txtUnitNormal.Text = unitInfo.UnitName;
            }
        }

        private void txtYTUnitName_TextChanged(object sender, EventArgs e)
        {
            txtWorkUnit.Text = txtYTUnitName.Text;
        }
    }

    public class ComboBoxItem
    {
        public ComboBoxItem(object obj,string txt)
        {
            this.Object = obj;
            this.Text = txt;
        }

        public object Object { get; set; }

        public string Text { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}