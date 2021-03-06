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

        private KryptonLabel kryptonLabe100;

        private KryptonLabel kryptonLabe108;

        private KryptonLabel kryptonLabel19;

        private KryptonTextBox txtApplyUserName;

        private KryptonComboBox txtDegree;

        private KryptonTextBox txtJobTitle;

        private KryptonTextBox txtUnitPosition;

        private KryptonPanel kryptonPanel5;

        private KryptonPanel kryptonPanel6;

        private KryptonPanel kryptonPanel102;

        private KryptonPanel kryptonPanel104;

        private KryptonTextBox txtYTUnitContacts;

        private KryptonTextBox txtYTUnitSchool;

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

        private KryptonPanel kryptonPanel118;

        private KryptonTextBox txtUnitNormal;

        private KryptonPanel kryptonPanel12;

        private KryptonPanel kryptonPanel101;
        private KryptonPanel kryptonPanel106;
        private KryptonPanel kryptonPanel119;

        private KryptonTextBox txtUnitAddress;

        private KryptonPanel kryptonPanel13;

        private DateTimePicker txtBirthday;

        private KryptonLabel kryptonLabel1;
        private KryptonTextBox txtWorkUnit;
        private KryptonPanel kryptonPanel14;
        private KryptonPanel kryptonPanel15;
        private KryptonLabel kryptonLabel2;
        private KryptonTextBox txtYTUnitName;
        private KryptonLabel kryptonLabel24;
        private KryptonTextBox txtYTIDCard;
        private ButtonSpecAny buttonSpecAny1;
        private ButtonSpecAny buttonSpecAny2;
        private ButtonSpecAny buttonSpecAny3;
        private KryptonPanel kryptonPanel17;

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
            if (this.txtMobilePhone.Text != string.Empty && !Regex.IsMatch(this.txtMobilePhone.Text, "^1[3|4|5|7|8|9][0-9]{9}$", RegexOptions.IgnoreCase))
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
            //if (this.txtWorkUnitList.EditValue != null)
            //{
            //    applyUserInfo.WorkUnitID = this.txtWorkUnitList.EditValue.ToString();
            //}
            //if (this.txtUnitList.EditValue != null)
            //{
            //    applyUserInfo.UnitID = this.txtUnitList.EditValue.ToString();
            //}
            applyUserInfo.UnitName = txtYTUnitName.Text;
            applyUserInfo.UnitIDCard = txtYTIDCard.Text;
            applyUserInfo.UnitNormal = this.txtUnitNormal.Text;
            applyUserInfo.UnitSchool = txtYTUnitSchool.Text;
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
                //if (string.IsNullOrEmpty(userBaseInfo.JobTitle))
                //{
                //	this.txtJobTitle.SelectedIndex = -1;
                //}
                //else
                //{
                this.txtJobTitle.Text = userBaseInfo.JobTitle;
                //}
                this.txtUnitPosition.Text = userBaseInfo.UnitPosition;
                this.txtMainResearch.Text = userBaseInfo.MainResearch;
                this.txtCardNo.Text = userBaseInfo.CardNo;
                this.txtOfficePhones.Text = userBaseInfo.OfficePhones;
                this.txtMobilePhone.Text = userBaseInfo.MobilePhone;
                this.txtEmail.Text = userBaseInfo.EMail;

                //this.txtWorkUnitList.EditValue = userBaseInfo.WorkUnitID;
                this.txtWorkUnit.Text = userBaseInfo.WorkUnitName;

                //this.txtUnitList.EditValue = userBaseInfo.UnitID;
                this.txtYTUnitName.Text = userBaseInfo.UnitName;
                this.txtYTUnitSchool.Text = userBaseInfo.UnitSchool;
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
            this.kryptonPanel118 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.txtYTUnitSchool = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.buttonSpecAny3 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.kryptonPanel119 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
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
            this.txtJobTitle = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
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
            this.kryptonLabe108 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonPanel102 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.txtUnitNormal = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.buttonSpecAny2 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.kryptonPanel106 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
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
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonPanel17 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.txtYTUnitName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.buttonSpecAny1 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.kryptonPanel101 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonPanel14 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.txtWorkUnit = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonPanel15 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel24 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonPanel12 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel104)).BeginInit();
            this.kryptonPanel104.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel118)).BeginInit();
            this.kryptonPanel118.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel119)).BeginInit();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel25.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            this.hSkinInputHost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).BeginInit();
            this.kryptonPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDegree)).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel106)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnitProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnitForORG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel8)).BeginInit();
            this.kryptonPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel17)).BeginInit();
            this.kryptonPanel17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel101)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel14)).BeginInit();
            this.kryptonPanel14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel12)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel104
            // 
            this.hSkinInputHost.SetColumnSpan(this.kryptonPanel104, 3);
            this.kryptonPanel104.Controls.Add(this.txtYTUnitContacts);
            this.kryptonPanel104.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel104.Location = new System.Drawing.Point(193, 323);
            this.kryptonPanel104.Name = "kryptonPanel104";
            this.kryptonPanel104.Size = new System.Drawing.Size(349, 34);
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
            this.txtYTUnitContacts.Size = new System.Drawing.Size(349, 24);
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
            // kryptonPanel118
            // 
            this.hSkinInputHost.SetColumnSpan(this.kryptonPanel118, 5);
            this.kryptonPanel118.Controls.Add(this.txtYTUnitSchool);
            this.kryptonPanel118.Controls.Add(this.kryptonPanel119);
            this.kryptonPanel118.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel118.Location = new System.Drawing.Point(191, 281);
            this.kryptonPanel118.Margin = new System.Windows.Forms.Padding(1, 1, 1, 0);
            this.kryptonPanel118.Name = "kryptonPanel102";
            this.kryptonPanel118.Size = new System.Drawing.Size(686, 39);
            this.kryptonPanel118.StateCommon.Color1 = System.Drawing.Color.White;
            this.kryptonPanel118.TabIndex = 30;
            // 
            // txtYTUnitSchool
            // 
            this.txtYTUnitSchool.AlwaysActive = false;
            this.txtYTUnitSchool.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny3});
            this.txtYTUnitSchool.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtYTUnitSchool.Location = new System.Drawing.Point(0, 10);
            this.txtYTUnitSchool.Margin = new System.Windows.Forms.Padding(8);
            this.txtYTUnitSchool.Name = "txtYTUnitSchool";
            this.txtYTUnitSchool.Size = new System.Drawing.Size(686, 26);
            this.txtYTUnitSchool.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtYTUnitSchool.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtYTUnitSchool.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.txtYTUnitSchool.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtYTUnitSchool.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtYTUnitSchool.TabIndex = 2;
            // 
            // buttonSpecAny3
            // 
            this.buttonSpecAny3.ColorMap = System.Drawing.Color.Transparent;
            this.buttonSpecAny3.Image = ((System.Drawing.Image)(resources.GetObject("buttonSpecAny3.Image")));
            this.buttonSpecAny3.Text = "若单位是大学，填写到所属学院，否则填写无";
            this.buttonSpecAny3.UniqueName = "9CA7A7940F314DC88B99D7C3BD7D4DC9E";
            // 
            // kryptonPanel119
            // 
            this.kryptonPanel119.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel119.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel119.Name = "kryptonPanel119";
            this.kryptonPanel119.Size = new System.Drawing.Size(686, 10);
            this.kryptonPanel119.StateCommon.Color1 = System.Drawing.Color.White;
            this.kryptonPanel119.TabIndex = 1;
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
            this.tableLayoutPanel25.Location = new System.Drawing.Point(53, 520);
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
            this.hSkinInputHost.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.hSkinInputHost.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39F));
            this.hSkinInputHost.Controls.Add(this.kryptonPanel3, 0, 0);
            this.hSkinInputHost.Controls.Add(this.kryptonLabel19, 5, 9);
            this.hSkinInputHost.Controls.Add(this.kryptonLabel5, 1, 0);
            this.hSkinInputHost.Controls.Add(this.txtYTIDCard, 6, 9);
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
            this.hSkinInputHost.Controls.Add(this.kryptonLabe108, 0, 8);
            this.hSkinInputHost.Controls.Add(this.kryptonPanel118, 1, 8);
            this.hSkinInputHost.Controls.Add(this.kryptonPanel102, 1, 7);
            this.hSkinInputHost.Controls.Add(this.kryptonLabel21, 1, 10);
            this.hSkinInputHost.Controls.Add(this.kryptonLabel22, 3, 10);
            this.hSkinInputHost.Controls.Add(this.kryptonLabel23, 5, 10);
            this.hSkinInputHost.Controls.Add(this.txtUnitProperties, 4, 10);
            this.hSkinInputHost.Controls.Add(this.txtUnitContactsPhone, 6, 10);
            this.hSkinInputHost.Controls.Add(this.txtUnitForORG, 2, 10);
            this.hSkinInputHost.Controls.Add(this.kryptonLabel20, 1, 11);
            this.hSkinInputHost.Controls.Add(this.kryptonPanel8, 2, 11);
            this.hSkinInputHost.Controls.Add(this.kryptonLabel2, 1, 6);
            this.hSkinInputHost.Controls.Add(this.kryptonPanel17, 2, 6);
            this.hSkinInputHost.Controls.Add(this.kryptonPanel14, 2, 5);
            this.hSkinInputHost.Controls.Add(this.kryptonLabel1, 1, 5);
            this.hSkinInputHost.Controls.Add(this.kryptonLabel24, 1, 9);
            this.hSkinInputHost.Controls.Add(this.kryptonPanel104, 2, 9);
            this.hSkinInputHost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hSkinInputHost.Location = new System.Drawing.Point(50, 74);
            this.hSkinInputHost.Margin = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.hSkinInputHost.Name = "hSkinInputHost";
            this.hSkinInputHost.RowCount = 12;
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
            this.hSkinInputHost.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.hSkinInputHost.Size = new System.Drawing.Size(878, 441);
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
            this.kryptonLabel19.Location = new System.Drawing.Point(548, 334);
            this.kryptonLabel19.Name = "kryptonLabel19";
            this.kryptonLabel19.Size = new System.Drawing.Size(159, 23);
            this.kryptonLabel19.StateCommon.ShortText.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.kryptonLabel19.StateNormal.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.kryptonLabel19.TabIndex = 18;
            this.kryptonLabel19.Values.Text = "联系人职务";
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
            this.txtYTIDCard.Location = new System.Drawing.Point(712, 328);
            this.txtYTIDCard.Margin = new System.Windows.Forms.Padding(2, 8, 8, 8);
            this.txtYTIDCard.Name = "txtYTIDCard";
            this.txtYTIDCard.Size = new System.Drawing.Size(158, 24);
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
            this.kryptonLabel6.Location = new System.Drawing.Point(321, 14);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(89, 23);
            this.kryptonLabel6.StateNormal.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.kryptonLabel6.TabIndex = 3;
            this.kryptonLabel6.Values.Text = "性    别";
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonLabel7.Location = new System.Drawing.Point(548, 14);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(159, 23);
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
            this.txtSex.Location = new System.Drawing.Point(415, 8);
            this.txtSex.Margin = new System.Windows.Forms.Padding(2, 8, 8, 8);
            this.txtSex.Name = "txtSex";
            this.txtSex.Size = new System.Drawing.Size(122, 25);
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
            this.txtApplyUserName.Size = new System.Drawing.Size(118, 24);
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
            this.txtBirthday.Location = new System.Drawing.Point(712, 8);
            this.txtBirthday.Margin = new System.Windows.Forms.Padding(2, 8, 8, 8);
            this.txtBirthday.Name = "txtBirthday";
            this.txtBirthday.ShowUpDown = true;
            this.txtBirthday.Size = new System.Drawing.Size(158, 26);
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
            this.kryptonLabel9.Location = new System.Drawing.Point(321, 54);
            this.kryptonLabel9.Name = "kryptonLabel9";
            this.kryptonLabel9.Size = new System.Drawing.Size(89, 23);
            this.kryptonLabel9.StateNormal.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.kryptonLabel9.TabIndex = 8;
            this.kryptonLabel9.Values.Text = "职    称";
            // 
            // kryptonLabel10
            // 
            this.kryptonLabel10.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonLabel10.Location = new System.Drawing.Point(548, 54);
            this.kryptonLabel10.Name = "kryptonLabel10";
            this.kryptonLabel10.Size = new System.Drawing.Size(159, 23);
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
            this.txtDegree.Size = new System.Drawing.Size(118, 25);
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
            this.txtJobTitle.Location = new System.Drawing.Point(415, 48);
            this.txtJobTitle.Margin = new System.Windows.Forms.Padding(2, 8, 8, 8);
            this.txtJobTitle.Name = "txtJobTitle";
            this.txtJobTitle.Size = new System.Drawing.Size(122, 24);
            this.txtJobTitle.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtJobTitle.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtJobTitle.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.txtJobTitle.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtJobTitle.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtJobTitle.TabIndex = 22;
            // 
            // txtUnitPosition
            // 
            this.txtUnitPosition.AlwaysActive = false;
            this.txtUnitPosition.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtUnitPosition.Location = new System.Drawing.Point(712, 48);
            this.txtUnitPosition.Margin = new System.Windows.Forms.Padding(2, 8, 8, 8);
            this.txtUnitPosition.Name = "txtUnitPosition";
            this.txtUnitPosition.Size = new System.Drawing.Size(158, 24);
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
            this.kryptonLabel15.Location = new System.Drawing.Point(321, 174);
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
            this.kryptonLabel16.Location = new System.Drawing.Point(548, 174);
            this.kryptonLabel16.Name = "kryptonLabel16";
            this.kryptonLabel16.Size = new System.Drawing.Size(159, 23);
            this.kryptonLabel16.StateCommon.ShortText.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.kryptonLabel16.StateNormal.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.kryptonLabel16.TabIndex = 15;
            this.kryptonLabel16.Values.Text = "电子邮箱";
            // 
            // txtEmail
            // 
            this.txtEmail.AlwaysActive = false;
            this.txtEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEmail.Location = new System.Drawing.Point(712, 168);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2, 8, 8, 8);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(158, 24);
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
            this.txtMobilePhone.Location = new System.Drawing.Point(415, 168);
            this.txtMobilePhone.Margin = new System.Windows.Forms.Padding(2, 8, 8, 8);
            this.txtMobilePhone.Name = "txtMobilePhone";
            this.txtMobilePhone.Size = new System.Drawing.Size(122, 24);
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
            this.txtOfficePhones.Size = new System.Drawing.Size(118, 24);
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
            // kryptonLabe108
            // 
            this.kryptonLabe108.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonLabe108.Location = new System.Drawing.Point(63, 294);
            this.kryptonLabe108.Name = "kryptonLabe108";
            this.kryptonLabe108.Size = new System.Drawing.Size(124, 23);
            this.kryptonLabe108.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.kryptonLabe108.TabIndex = 17;
            this.kryptonLabe108.Values.Text = "所属院系";
            // 
            // kryptonPanel102
            // 
            this.hSkinInputHost.SetColumnSpan(this.kryptonPanel102, 5);
            this.kryptonPanel102.Controls.Add(this.txtUnitNormal);
            this.kryptonPanel102.Controls.Add(this.kryptonPanel106);
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
            // kryptonPanel106
            // 
            this.kryptonPanel106.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel106.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel106.Name = "kryptonPanel106";
            this.kryptonPanel106.Size = new System.Drawing.Size(686, 10);
            this.kryptonPanel106.StateCommon.Color1 = System.Drawing.Color.White;
            this.kryptonPanel106.TabIndex = 1;
            // 
            // kryptonLabel21
            // 
            this.kryptonLabel21.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonLabel21.Location = new System.Drawing.Point(63, 374);
            this.kryptonLabel21.Name = "kryptonLabel21";
            this.kryptonLabel21.Size = new System.Drawing.Size(124, 23);
            this.kryptonLabel21.StateNormal.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.kryptonLabel21.TabIndex = 37;
            this.kryptonLabel21.Values.Text = "隶属部门";
            // 
            // kryptonLabel22
            // 
            this.kryptonLabel22.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonLabel22.Location = new System.Drawing.Point(321, 374);
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
            this.kryptonLabel23.Location = new System.Drawing.Point(548, 374);
            this.kryptonLabel23.Name = "kryptonLabel23";
            this.kryptonLabel23.Size = new System.Drawing.Size(159, 23);
            this.kryptonLabel23.StateCommon.ShortText.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.kryptonLabel23.StateNormal.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.kryptonLabel23.TabIndex = 39;
            this.kryptonLabel23.Values.Text = "联系电话（手机）";
            // 
            // txtUnitProperties
            // 
            this.txtUnitProperties.AlwaysActive = false;
            this.txtUnitProperties.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtUnitProperties.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtUnitProperties.DropDownWidth = 104;
            this.txtUnitProperties.Items.AddRange(new object[] {
            "军队单位",
            "军工集团",
            "民口高校",
            "民口科研院所",
            "其它"});
            this.txtUnitProperties.Location = new System.Drawing.Point(415, 368);
            this.txtUnitProperties.Margin = new System.Windows.Forms.Padding(2, 8, 8, 8);
            this.txtUnitProperties.Name = "txtUnitProperties";
            this.txtUnitProperties.Size = new System.Drawing.Size(122, 25);
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
            this.txtUnitContactsPhone.Location = new System.Drawing.Point(712, 368);
            this.txtUnitContactsPhone.Margin = new System.Windows.Forms.Padding(2, 8, 8, 8);
            this.txtUnitContactsPhone.Name = "txtUnitContactsPhone";
            this.txtUnitContactsPhone.Size = new System.Drawing.Size(158, 24);
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
            "陆军",
            "海军",
            "空军",
            "火箭军",
            "战略支援部队",
            "联勤保障部队",
            "军委机关直属单位",
            "军事科学院",
            "国防大学",
            "国防科技大学",
            "武警部队",
            "教育部",
            "工信部",
            "中国科学院",
            "中国核工业集团有限公司",
            "中国航天科技集团有限公司",
            "中国航天科工集团有限公司",
            "中国航空工业集团有限公司",
            "中国船舶集团有限公司",
            "中国兵器工业集团有限公司",
            "中国兵器装备集团有限公司",
            "中国电子科技集团有限公司",
            "中国航空发动机集团有限公司",
            "中国电子信息产业集团有限公司",
            "中国工程物理研究院",
            "其它"});
            this.txtUnitForORG.Location = new System.Drawing.Point(192, 368);
            this.txtUnitForORG.Margin = new System.Windows.Forms.Padding(2, 8, 8, 8);
            this.txtUnitForORG.Name = "txtUnitForORG";
            this.txtUnitForORG.Size = new System.Drawing.Size(118, 25);
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
            this.kryptonLabel20.Location = new System.Drawing.Point(63, 416);
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
            this.kryptonPanel8.Location = new System.Drawing.Point(191, 401);
            this.kryptonPanel8.Margin = new System.Windows.Forms.Padding(1);
            this.kryptonPanel8.Name = "kryptonPanel8";
            this.kryptonPanel8.Size = new System.Drawing.Size(686, 39);
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
            // kryptonPanel17
            // 
            this.hSkinInputHost.SetColumnSpan(this.kryptonPanel17, 5);
            this.kryptonPanel17.Controls.Add(this.txtYTUnitName);
            this.kryptonPanel17.Controls.Add(this.kryptonPanel101);
            this.kryptonPanel17.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel17.Location = new System.Drawing.Point(191, 201);
            this.kryptonPanel17.Margin = new System.Windows.Forms.Padding(1, 1, 1, 0);
            this.kryptonPanel17.Name = "kryptonPanel17";
            this.kryptonPanel17.Size = new System.Drawing.Size(686, 39);
            this.kryptonPanel17.StateCommon.Color1 = System.Drawing.Color.White;
            this.kryptonPanel17.TabIndex = 30;
            // 
            // txtYTUnitName
            // 
            this.txtYTUnitName.AlwaysActive = false;
            this.txtYTUnitName.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny1});
            this.txtYTUnitName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtYTUnitName.Location = new System.Drawing.Point(0, 10);
            this.txtYTUnitName.Margin = new System.Windows.Forms.Padding(2, 8, 8, 8);
            this.txtYTUnitName.Name = "txtYTUnitName";
            this.txtYTUnitName.Size = new System.Drawing.Size(686, 26);
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
            // buttonSpecAny1
            // 
            this.buttonSpecAny1.ColorMap = System.Drawing.Color.Transparent;
            this.buttonSpecAny1.Image = ((System.Drawing.Image)(resources.GetObject("buttonSpecAny1.Image")));
            this.buttonSpecAny1.Text = "单位名称应为法人单位名称";
            this.buttonSpecAny1.UniqueName = "9CA7A7940F314DC88B99D7C0BD7D4DD9F";
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
            // kryptonPanel14
            // 
            this.hSkinInputHost.SetColumnSpan(this.kryptonPanel14, 3);
            this.kryptonPanel14.Controls.Add(this.txtWorkUnit);
            this.kryptonPanel14.Controls.Add(this.kryptonPanel15);
            this.kryptonPanel14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel14.Location = new System.Drawing.Point(191, 201);
            this.kryptonPanel14.Margin = new System.Windows.Forms.Padding(1, 1, 1, 0);
            this.kryptonPanel14.Name = "kryptonPanel14";
            this.kryptonPanel14.Size = new System.Drawing.Size(353, 1);
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
            this.txtWorkUnit.Size = new System.Drawing.Size(353, 24);
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
            this.kryptonPanel15.Size = new System.Drawing.Size(353, 10);
            this.kryptonPanel15.StateCommon.Color1 = System.Drawing.Color.White;
            this.kryptonPanel15.TabIndex = 1;
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
            this.kryptonLabel24.Location = new System.Drawing.Point(63, 334);
            this.kryptonLabel24.Name = "kryptonLabel24";
            this.kryptonLabel24.Size = new System.Drawing.Size(124, 23);
            this.kryptonLabel24.StateCommon.ShortText.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.kryptonLabel24.StateNormal.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.kryptonLabel24.TabIndex = 18;
            this.kryptonLabel24.Values.Text = "单位联系人";
            // 
            // kryptonPanel12
            // 
            this.kryptonPanel12.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel12.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel12.Name = "kryptonPanel12";
            this.kryptonPanel12.Size = new System.Drawing.Size(463, 10);
            this.kryptonPanel12.StateCommon.Color1 = System.Drawing.Color.White;
            this.kryptonPanel12.TabIndex = 1;
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
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel118)).EndInit();
            this.kryptonPanel118.ResumeLayout(false);
            this.kryptonPanel118.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel119)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel106)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnitProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnitForORG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel8)).EndInit();
            this.kryptonPanel8.ResumeLayout(false);
            this.kryptonPanel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel17)).EndInit();
            this.kryptonPanel17.ResumeLayout(false);
            this.kryptonPanel17.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel101)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel14)).EndInit();
            this.kryptonPanel14.ResumeLayout(false);
            this.kryptonPanel14.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel12)).EndInit();
            this.ResumeLayout(false);

        }

        private void txtUnitList_EditValueChanged(object sender, EventArgs e)
        {
            ////txtWorkUnitList.EditValue = txtUnitList.EditValue;
            //string[] list = new string[] { txtUnitList.EditValue.ToString() };
            //IList<UnitInfor> unitList = _unitInforService.GetUnitInforList(list);
            //foreach (UnitInfor unitInfo in unitList)
            //{
            //    txtUnitNormal.Text = unitInfo.UnitName;
            //}
        }

        private void txtYTUnitName_TextChanged(object sender, EventArgs e)
        {
            txtWorkUnit.Text = txtYTUnitName.Text;
        }
    }

    public class ComboBoxItem
    {
        public ComboBoxItem(object obj, string txt)
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