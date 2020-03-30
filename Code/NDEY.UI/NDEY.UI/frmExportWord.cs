using Aspose.Words;
using Aspose.Words.Tables;
using ComponentFactory.Krypton.Toolkit;
using ICSharpCode.SharpZipLib.Checksums;
using ICSharpCode.SharpZipLib.Zip;
using NDEY.BLL.Entity;
using NDEY.BLL.Service;
using NDEY.UI.Properties;
using NDEY.UI.Utility;
using ProjectContractPlugin.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace NDEY.UI
{
	public class frmExportWord : BaseForm
	{
		private IContainer components;

		private PictureBox picbox;

		private ProgressBar pbar;

		private KryptonLabel lbmsg;

		private KryptonPanel kryptonPanel1;

		private EntityElement.ExportType _expType;

		private bool _submit;

		public string Savefilename = string.Empty;

		private RecommendInfoService recommendInfoService;

		private RecommendInfo rinfo;

		private ApplyUserBaseInfoService applyUserBaseInfoService;

		private ApplyUserInfo userinfo;

		private ProjectBasicInfoService pinfoservice;

		private ProjectBasicInfo projectinfo;

		private ProjectBudgetInfoService pbudgetService;

		private ProjectBudgetInfo pbudgetinfo;

		private RecommendInfoService recommendonfoService;

		private RecommendInfo rmdinfo;

		private EducationInfoService eduService;

		private IList<EducationInfo> eduinfolist;

		private WorkExperienceService workService;

		private IList<WorkExperienceInfo> workinfolist;

		private AcademicPostService acaService;

		private IList<AcademicPost> acainfolist;

		private TalentsPlanService talentService = new TalentsPlanService();

        private UnitInforService unitInforService;

        private IList<TalentsPlan> talentlist;

		private NDProjectService ndprojectService;

		private IList<NDProject> ndprolist;

		private RTreatisesService rTreatisesService;

		private IList<RTreatises> rtlist;

		private TechnologyAwardsService techService;

		private IList<TechnologyAwards> techlist;

		private NDPatentService ndpatentService;

		private IList<NDPatent> ndpatentlist;

		private ResultFormInfoService resultFormInfoService;

		private ResultFormInfo resultFormInfo;
        private IList<UnitInfor> unitList;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExportWord));
            this.picbox = new System.Windows.Forms.PictureBox();
            this.pbar = new System.Windows.Forms.ProgressBar();
            this.lbmsg = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            ((System.ComponentModel.ISupportInitialize)(this.picbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picbox
            // 
            this.picbox.BackColor = System.Drawing.Color.Transparent;
            this.picbox.Dock = System.Windows.Forms.DockStyle.Left;
            this.picbox.Image = ((System.Drawing.Image)(resources.GetObject("picbox.Image")));
            this.picbox.Location = new System.Drawing.Point(0, 0);
            this.picbox.Name = "picbox";
            this.picbox.Size = new System.Drawing.Size(86, 90);
            this.picbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbox.TabIndex = 0;
            this.picbox.TabStop = false;
            // 
            // pbar
            // 
            this.pbar.Location = new System.Drawing.Point(95, 27);
            this.pbar.Name = "pbar";
            this.pbar.Size = new System.Drawing.Size(268, 23);
            this.pbar.TabIndex = 1;
            // 
            // lbmsg
            // 
            this.lbmsg.Location = new System.Drawing.Point(96, 62);
            this.lbmsg.Name = "lbmsg";
            this.lbmsg.Size = new System.Drawing.Size(88, 20);
            this.lbmsg.TabIndex = 2;
            this.lbmsg.Values.Text = "kryptonLabel1";
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.picbox);
            this.kryptonPanel1.Controls.Add(this.lbmsg);
            this.kryptonPanel1.Controls.Add(this.pbar);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(375, 90);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.White;
            this.kryptonPanel1.StateCommon.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.kryptonPanel1.TabIndex = 3;
            // 
            // frmExportWord
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(375, 90);
            this.Controls.Add(this.kryptonPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmExportWord";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmExportWord";
            this.Load += new System.EventHandler(this.frmExportWord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.ResumeLayout(false);

		}

		public frmExportWord()
		{
			this.InitializeComponent();
		}

		public frmExportWord(EntityElement.ExportType exportType, bool submit)
		{
			this.InitializeComponent();
			this._expType = exportType;
			this._submit = submit;
		}

		private void frmExportWord_Load(object sender, EventArgs e)
		{
			if (this._expType == EntityElement.ExportType.ToWord)
			{
                this.picbox.Image = global::Properties.Resource.ToWord;
				this.pbar.Maximum = 80;
			}
			else
			{
                this.picbox.Image = global::Properties.Resource.ToZip;
			}
			BaseForm.AsyncDelegate del = delegate
			{
				this.setprogress(0, "准备数据...");
                this.unitInforService = new UnitInforService();
                this.recommendInfoService = new RecommendInfoService();
				this.rinfo = this.recommendInfoService.GetRecommendInfo();
				this.applyUserBaseInfoService = new ApplyUserBaseInfoService();
				this.userinfo = this.applyUserBaseInfoService.GetUserBaseInfo();
				this.pinfoservice = new ProjectBasicInfoService();
				this.projectinfo = this.pinfoservice.GetProjectBasicInfo();
				this.pbudgetService = new ProjectBudgetInfoService();
				this.pbudgetinfo = this.pbudgetService.GetProjectBudgetInfo();
				this.recommendonfoService = new RecommendInfoService();
				this.rmdinfo = this.recommendonfoService.GetRecommendInfo();
				this.eduService = new EducationInfoService();
				this.eduinfolist = this.eduService.GetEducationList();
				this.workService = new WorkExperienceService();
				this.workinfolist = this.workService.GetWorkExperience();
				this.acaService = new AcademicPostService();
				this.acainfolist = this.acaService.GetAcademicPostList();
				this.talentService = new TalentsPlanService();
				this.talentlist = this.talentService.GetTalentsPlan();
				this.ndprojectService = new NDProjectService();
				this.ndprolist = this.ndprojectService.GetNDProject();
				this.rTreatisesService = new RTreatisesService();
				this.rtlist = this.rTreatisesService.GetRTreatises();
				this.techService = new TechnologyAwardsService();
				this.techlist = this.techService.GetTechnologyAwards();
				this.ndpatentService = new NDPatentService();
				this.ndpatentlist = this.ndpatentService.GetNDPatent();
				this.resultFormInfoService = new ResultFormInfoService();
				this.resultFormInfo = this.resultFormInfoService.GetResultFormInfo();
                this.unitList = unitInforService.GetUnitInforList();
				if (this._expType == EntityElement.ExportType.ToWord)
				{
					this.ExportWord(true);
					return;
				}
				if (this._submit)
				{
					this.setprogress(5, "数据完整性检查...");
					if (!this.isApplyUserInfoCompleted(this.userinfo))
					{
						return;
					}
					if (!this.isProjectBasicInfoCompleted(this.projectinfo))
					{
						return;
					}
					if (!this.isProjectBudgetInfoCompleted(this.pbudgetinfo))
					{
						return;
					}
                    //string text = Path.Combine(EntityElement.FilesStorePath, "军事意义.rtf");
                    //long num = 0L;
                    //if (File.Exists(text))
                    //{
                    //    FileInfo fileInfo = new FileInfo(text);
                    //    num = fileInfo.Length;
                    //}
                    //if (num <= 200L)
                    //{
                    //    BaseForm.MethodInvoker uiDelegate = delegate
                    //    {
                    //        MessageBox.Show("报告正文未填写完成，当前不能上报。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    //        base.Close();
                    //    };
                    //    base.UpdateUI(uiDelegate, this);
                    //    return;
                    //}
                    //text = Path.Combine(EntityElement.FilesStorePath, "主要研究.rtf");
                    //num = 0L;
                    //if (File.Exists(text))
                    //{
                    //    FileInfo fileInfo2 = new FileInfo(text);
                    //    num = fileInfo2.Length;
                    //}
                    //if (num <= 200L)
                    //{
                    //    BaseForm.MethodInvoker uiDelegate2 = delegate
                    //    {
                    //        MessageBox.Show("报告正文未填写完成，当前不能上报。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    //        base.Close();
                    //    };
                    //    base.UpdateUI(uiDelegate2, this);
                    //    return;
                    //}
					if (!this.resultFormInfo.IsCBR1Checked && !this.resultFormInfo.IsCBR2Checked && !this.resultFormInfo.IsCBR3Checked && !this.resultFormInfo.IsCBR4Checked && !this.resultFormInfo.IsCBR5Checked && !this.resultFormInfo.IsCBR6Checked && !this.resultFormInfo.IsCBR7Checked && !this.resultFormInfo.IsCBR8Checked && !this.resultFormInfo.IsCBR9Checked && !this.resultFormInfo.IsCBR10Checked && !this.resultFormInfo.IsCBR11Checked && !this.resultFormInfo.IsCBR12Checked && !(this.resultFormInfo.CBROtherText != ""))
					{
						BaseForm.MethodInvoker uiDelegate3 = delegate
						{
							MessageBox.Show("报告正文未填写完成，当前不能上报。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
							base.Close();
						};
						base.UpdateUI(uiDelegate3, this);
						return;
					}
                    //text = Path.Combine(EntityElement.FilesStorePath, "第一年研究任务.rtf");
                    //num = 0L;
                    //if (File.Exists(text))
                    //{
                    //    FileInfo fileInfo3 = new FileInfo(text);
                    //    num = fileInfo3.Length;
                    //}
                    //if (num <= 200L)
                    //{
                    //    BaseForm.MethodInvoker uiDelegate4 = delegate
                    //    {
                    //        MessageBox.Show("报告正文未填写完成，当前不能上报。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    //        base.Close();
                    //    };
                    //    base.UpdateUI(uiDelegate4, this);
                    //    return;
                    //}
					if (this.eduinfolist.Count == 0)
					{
						BaseForm.MethodInvoker uiDelegate5 = delegate
						{
							MessageBox.Show("学习经历至少填写一条，当前不能上报。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
							base.Close();
						};
						base.UpdateUI(uiDelegate5, this);
						return;
					}
					if (this.workinfolist.Count == 0)
					{
						BaseForm.MethodInvoker uiDelegate6 = delegate
						{
							MessageBox.Show("工作经历至少填写一条，当前不能上报。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
							base.Close();
						};
						base.UpdateUI(uiDelegate6, this);
						return;
					}
                    //if (NDEYUserControl.frmExtFileEditor.IsUploadedExtFile == false)
                    //{
                    //    BaseForm.MethodInvoker uiDelegate6 = delegate
                    //    {
                    //        MessageBox.Show("保密资质没有上传，当前不能上报。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    //        base.Close();
                    //    };
                    //    base.UpdateUI(uiDelegate6, this);
                    //    return;
                    //}
                    if (rinfo.ApplicationType == "专家提名" && (string.IsNullOrEmpty(rinfo.ExperInfoList[0].ExpertWorkType) || string.IsNullOrEmpty(rinfo.ExperInfoList[1].ExpertWorkType) || string.IsNullOrEmpty(rinfo.ExperInfoList[2].ExpertWorkType)))
                    {
                        BaseForm.MethodInvoker uiDelegate6 = delegate
                        {
                            MessageBox.Show("专家类别没有填写，当前不能上报。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            base.Close();
                        };
                        base.UpdateUI(uiDelegate6, this);
                        return;
                    }
                    if (!this.isRecommendInfoCompleted(this.rinfo))
					{
						return;
					}
				}
				if (this._submit)
				{
					if (this.ExportWord(false))
					{
						this.ToZip();
						return;
					}
				}
				else
				{
					this.ToZip();
				}
			};
			base.BeginInvoke(del);
		}

		private bool ExportWord(bool open)
		{
            //string unitA, unitB;
            //unitA = string.Empty;
            //unitB = this.userinfo.UnitNormal;

            this.setprogress(10, "准备Word...");
            if (unitList != null)
            {
                //foreach (UnitInfor unitInfo in unitList)
                //{
                //    if (unitInfo.ID == this.userinfo.WorkUnitID)
                //    {
                //        this.userinfo.WorkUnitID = unitInfo.UnitName;
                //        break;
                //    }
                //}

                //if (this.userinfo.UnitID != null)
                //{
                //    foreach (UnitInfor unitInfo in unitList)
                //    {
                //        if (unitInfo.ID == this.userinfo.UnitID)
                //        {
                //            unitA = unitInfo.UnitName;
                //            break;
                //        }
                //    }
                //}
            }

            string msg = "";
			if (!FileOp.RunWordInstCheck(out msg))
			{
				BaseForm.MethodInvoker uiDelegate = delegate
				{
					MessageBox.Show(msg, "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					this.Close();
				};
				base.UpdateUI(uiDelegate, this);
				return false;
			}
			string path = this.userinfo.UnitID + "_" + this.userinfo.ApplyUserName + "_项目申报书.doc";
			try
			{
				if (this.rinfo.ApplicationType == "专家提名")
				{
					File.Copy(Path.Combine(EntityElement.TemplatePath, "申报书0630-zj.doc"), Path.Combine(EntityElement.FilesStorePath, path), true);
				}
				else
				{
					File.Copy(Path.Combine(EntityElement.TemplatePath, "申报书0630-dw.doc"), Path.Combine(EntityElement.FilesStorePath, path), true);
				}
			}
			catch (Exception ex)
			{
				BaseForm.MethodInvoker uiDelegate2 = delegate
				{
					MessageBox.Show("文件复制错误，请关闭正在读写预览文件的程序。\r\n详细错误：" + ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					this.Close();
				};
				base.UpdateUI(uiDelegate2, this);
				bool result = false;
				return result;
			}

            string destDocFiless = Path.Combine(EntityElement.FilesStorePath, path);
            WordUtility application = new WordUtility();
            application.Document = new Aspose.Words.WordDocument(destDocFiless);

			try
			{
				this.setprogress(20, "读取申报信息...");
				object bookmark = "UserName";
				object obj4 = this.userinfo.ApplyUserName;
				this.InsertText(application, bookmark, obj4, "楷体");
				bookmark = "UserName1";
				this.InsertText(application, bookmark, obj4, null);
				bookmark = "UserName2";
				this.InsertText(application, bookmark, obj4, null);
				bookmark = "ApplicationArea";
				if (this.projectinfo.ApplicationArea == "应用基础类")
				{
					obj4 = "■应用基础类 □工程技术类";
				}
				else
				{
					obj4 = "□应用基础类 ■工程技术类";
				}
				this.InsertText(application, bookmark, obj4, "楷体");
				bookmark = "ProjectName";
				obj4 = this.projectinfo.ProjectName;
				this.InsertText(application, bookmark, obj4, "楷体");
				//bookmark = "InputTime";
				//obj4 = DateTime.Now.ToString("yyyy年M月d日");
				//this.InsertText(application, bookmark, obj4, "楷体");
				bookmark = "ProjectName1";
				obj4 = this.projectinfo.ProjectName;
				this.InsertText(application, bookmark, obj4, null);
				bookmark = "ProjectName2";
				obj4 = this.projectinfo.ProjectName;
				this.InsertText(application, bookmark, obj4, null);
				bookmark = "WorkUnit";
				obj4 = this.userinfo.WorkUnitName;
				this.InsertText(application, bookmark, obj4, null);

				bookmark = "Unit";
                obj4 = this.userinfo.UnitName;
				this.InsertText(application, bookmark, obj4, "楷体");
				bookmark = "Unit1";
				this.InsertText(application, bookmark, obj4, null);
				bookmark = "Unit2";
				this.InsertText(application, bookmark, obj4, null);
                //bookmark = "Unit3";
                //obj4 = this.userinfo.UnitNormal;
                //this.InsertText(application, bookmark, obj4, null);
                bookmark = "UnitNormal";
                obj4 = this.userinfo.UnitNormal;
                this.InsertText(application, bookmark, obj4, "楷体");

                bookmark = "Sex";
				obj4 = this.userinfo.Sex;
				this.InsertText(application, bookmark, obj4, null);
				bookmark = "Birthdate";
				DateTime now = DateTime.Now;
				DateTime.TryParse(this.userinfo.Birthday, out now);
				obj4 = now.ToString("yyyy年M月");
				this.InsertText(application, bookmark, obj4, null);
				bookmark = "Degree";
				obj4 = this.userinfo.Degree;
				this.InsertText(application, bookmark, obj4, null);
				bookmark = "JobTitle";
				obj4 = this.userinfo.JobTitle;
				this.InsertText(application, bookmark, obj4, null);
				bookmark = "UnitPosition";
				obj4 = this.userinfo.UnitPosition;
				this.InsertText(application, bookmark, obj4, null);
				bookmark = "CardNo";
				obj4 = this.userinfo.CardNo;
				this.InsertText(application, bookmark, obj4, null);
				bookmark = "MainResearch";
				obj4 = this.userinfo.MainResearch;
				this.InsertText(application, bookmark, obj4, null);
				bookmark = "OfficePhones";
				obj4 = this.userinfo.OfficePhones;
				this.InsertText(application, bookmark, obj4, null);
				bookmark = "MobilePhone";
				obj4 = this.userinfo.MobilePhone;
				this.InsertText(application, bookmark, obj4, null);
				bookmark = "EMail";
				obj4 = this.userinfo.EMail;
				this.InsertText(application, bookmark, obj4, null);
				bookmark = "UnitContacts";
				obj4 = this.userinfo.UnitContacts;
				this.InsertText(application, bookmark, obj4, null);
                bookmark = "RecvUser";
                this.InsertText(application, bookmark, obj4, "楷体");
                bookmark = "UnitForORG";
				obj4 = this.userinfo.UnitForORG;
				this.InsertText(application, bookmark, obj4, null);
				bookmark = "UnitProperties";
				obj4 = this.userinfo.UnitProperties;
				this.InsertText(application, bookmark, obj4, null);
				bookmark = "UnitAddress";
				obj4 = this.userinfo.UnitAddress;
				this.InsertText(application, bookmark, obj4, null);
				bookmark = "UnitContactsPhone";
				obj4 = this.userinfo.UnitContactsPhone;
				this.InsertText(application, bookmark, obj4, null);
                bookmark = "RecvUserTel";
                this.InsertText(application, bookmark, obj4, "楷体");
                this.setprogress(30, "读取项目信息...");
				bookmark = "ProjectSecret";
				obj4 = this.projectinfo.ProjectSecret;
				this.InsertText(application, bookmark, "密级：" + obj4, null);
				bookmark = "ProjectTD";
				obj4 = this.projectinfo.ProjectTD;
				this.InsertText(application, bookmark, obj4, "楷体");
				bookmark = "ProjectTD1";
				this.InsertText(application, bookmark, obj4, null);
				bookmark = "ProjectMRD";
				obj4 = this.projectinfo.ProjectMRD;
				this.InsertText(application, bookmark, obj4, null);
				bookmark = "ProjectBaseT";
				obj4 = this.projectinfo.ProjectBaseT;
				this.InsertText(application, bookmark, obj4, null);
				bookmark = "ProjectKeyWord";
				obj4 = this.projectinfo.ProjectKeyWord;
				this.InsertText(application, bookmark, obj4, null);
				if (this.projectinfo.ProjectBrief != string.Empty)
				{
					string[] array = this.projectinfo.ProjectBrief.Split(new char[]
					{
						'|'
					});
					if (array.Length == 6)
					{
                        bookmark = "gen1";
                        obj4 = array[0];
                        this.InsertText(application, bookmark, obj4, null);
                        bookmark = "gen2";
                        obj4 = array[1];
                        this.InsertText(application, bookmark, obj4, null);
                        bookmark = "gen3";
                        obj4 = array[2];
                        this.InsertText(application, bookmark, obj4, null);
                        bookmark = "gen4";
                        obj4 = array[3];
                        this.InsertText(application, bookmark, obj4, null);
                        bookmark = "gen5";
                        obj4 = array[4];
                        this.InsertText(application, bookmark, obj4, null);
                        bookmark = "gen6";
                        obj4 = array[5];
                        this.InsertText(application, bookmark, obj4, null);
					}
				}
				bookmark = "ProjectLimitT";
                obj4 = "五年";
                //obj4 = this.projectinfo.ProjectLimitStart + "年-" + this.projectinfo.ProjectLimitEnd + "年";
                this.InsertText(application, bookmark, obj4, null);
				this.setprogress(40, "读取经费预算...");
				bookmark = "ProjectRFAs";
				obj4 = this.pbudgetinfo.ProjectRFA;
                this.InsertText(application, bookmark, obj4 != null ? obj4 : "0", null);
				bookmark = "ProjectRFA";
                this.InsertText(application, bookmark, obj4 != null ? obj4 + "万" : "0" + "万", null);
				bookmark = "ProjectRFA1";
				obj4 = this.pbudgetinfo.ProjectRFA1;
				this.InsertText(application, bookmark, obj4 != null ? obj4 : "0", null);
				bookmark = "ProjectRFA1_1";
				obj4 = this.pbudgetinfo.ProjectRFA1_1;
				this.InsertText(application, bookmark, obj4 != null ? obj4 : "0", null);
				bookmark = "ProjectRFA1_1_1";
				obj4 = this.pbudgetinfo.ProjectRFA1_1_1;
				this.InsertText(application, bookmark, obj4 != null ? obj4 : "0", null);
				bookmark = "ProjectRFA1_1_2";
				obj4 = this.pbudgetinfo.ProjectRFA1_1_2;
				this.InsertText(application, bookmark, obj4 != null ? obj4 : "0", null);
				bookmark = "ProjectRFA1_1_3";
				obj4 = this.pbudgetinfo.ProjectRFA1_1_3;
				this.InsertText(application, bookmark, obj4 != null ? obj4 : "0", null);
				bookmark = "ProjectRFA1_2";
				obj4 = this.pbudgetinfo.ProjectRFA1_2;
				this.InsertText(application, bookmark, obj4 != null ? obj4 : "0", null);
				bookmark = "ProjectRFA1_3";
				obj4 = this.pbudgetinfo.ProjectRFA1_3;
				this.InsertText(application, bookmark, obj4 != null ? obj4 : "0", null);
				bookmark = "ProjectRFA1_4";
				obj4 = this.pbudgetinfo.ProjectRFA1_4;
				this.InsertText(application, bookmark, obj4 != null ? obj4 : "0", null);
				bookmark = "ProjectRFA1_5";
				obj4 = this.pbudgetinfo.ProjectRFA1_5;
				this.InsertText(application, bookmark, obj4 != null ? obj4 : "0", null);
				bookmark = "ProjectRFA1_6";
				obj4 = this.pbudgetinfo.ProjectRFA1_6;
				this.InsertText(application, bookmark, obj4 != null ? obj4 : "0", null);
				bookmark = "ProjectRFA1_7";
				obj4 = this.pbudgetinfo.ProjectRFA1_7;
				this.InsertText(application, bookmark, obj4 != null ? obj4 : "0", null);
				bookmark = "ProjectRFA1_8";
				obj4 = this.pbudgetinfo.ProjectRFA1_8;
				this.InsertText(application, bookmark, obj4 != null ? obj4 : "0", null);
				bookmark = "ProjectRFA1_9";
				obj4 = this.pbudgetinfo.ProjectRFA1_9;
				this.InsertText(application, bookmark, obj4 != null ? obj4 : "0", null);
				bookmark = "ProjectRFA2";
				obj4 = this.pbudgetinfo.ProjectRFA2;
				this.InsertText(application, bookmark, obj4 != null ? obj4 : "0", null);
				bookmark = "ProjectRFA2_1";
				obj4 = this.pbudgetinfo.ProjectRFA2_1;
				this.InsertText(application, bookmark, obj4 != null ? obj4 : "0", null);
				bookmark = "ProjectOutlay1";
				obj4 = this.pbudgetinfo.Projectoutlay1;
				this.InsertText(application, bookmark, obj4 != null ? obj4 : "0", null);
				bookmark = "ProjectOutlay2";
				obj4 = this.pbudgetinfo.Projectoutlay2;
				this.InsertText(application, bookmark, obj4 != null ? obj4 : "0", null);
				bookmark = "ProjectOutlay3";
				obj4 = this.pbudgetinfo.Projectoutlay3;
				this.InsertText(application, bookmark, obj4 != null ? obj4 : "0", null);
				bookmark = "ProjectOutlay4";
				obj4 = this.pbudgetinfo.Projectoutlay4;
				this.InsertText(application, bookmark, obj4 != null ? obj4 : "0", null);
				bookmark = "ProjectOutlay5";
				obj4 = this.pbudgetinfo.Projectoutlay5;
				this.InsertText(application, bookmark, obj4 != null ? obj4 : "0", null);
				bookmark = "ProjectRFARm";
				obj4 = this.pbudgetinfo.ProjectRFArm;
				this.InsertText(application, bookmark, obj4, null, (this.pbudgetinfo.ProjectRFArm.Length > 14) ? 10.5f : 12f);
				bookmark = "ProjectRFA1Rm";
				obj4 = this.pbudgetinfo.ProjectRFA1rm;
				this.InsertText(application, bookmark, obj4, null, (this.pbudgetinfo.ProjectRFA1rm.Length > 14) ? 10.5f : 12f);
				bookmark = "ProjectRFA1_1Rm";
				obj4 = this.pbudgetinfo.ProjectRFA1_1rm;
				this.InsertText(application, bookmark, obj4, null, (this.pbudgetinfo.ProjectRFA1_1rm.Length > 14) ? 10.5f : 12f);
				bookmark = "ProjectRFA1_1_1Rm";
				obj4 = this.pbudgetinfo.ProjectRFA1_1_1rm;
				this.InsertText(application, bookmark, obj4, null, (this.pbudgetinfo.ProjectRFA1_1_1rm.Length > 14) ? 10.5f : 12f);
				bookmark = "ProjectRFA1_1_2Rm";
				obj4 = this.pbudgetinfo.ProjectRFA1_1_2rm;
				this.InsertText(application, bookmark, obj4, null, (this.pbudgetinfo.ProjectRFA1_1_2rm.Length > 14) ? 10.5f : 12f);
				bookmark = "ProjectRFA1_1_3Rm";
				obj4 = this.pbudgetinfo.ProjectRFA1_1_3rm;
				this.InsertText(application, bookmark, obj4, null, (this.pbudgetinfo.ProjectRFA1_1_3rm.Length > 14) ? 10.5f : 12f);
				bookmark = "ProjectRFA1_2Rm";
				obj4 = this.pbudgetinfo.ProjectRFA1_2rm;
				this.InsertText(application, bookmark, obj4, null, (this.pbudgetinfo.ProjectRFA1_2rm.Length > 14) ? 10.5f : 12f);
				bookmark = "ProjectRFA1_3Rm";
				obj4 = this.pbudgetinfo.ProjectRFA1_3rm;
				this.InsertText(application, bookmark, obj4, null, (this.pbudgetinfo.ProjectRFA1_3rm.Length > 14) ? 10.5f : 12f);
				bookmark = "ProjectRFA1_4Rm";
				obj4 = this.pbudgetinfo.ProjectRFA1_4rm;
				this.InsertText(application, bookmark, obj4, null, (this.pbudgetinfo.ProjectRFA1_4rm.Length > 14) ? 10.5f : 12f);
				bookmark = "ProjectRFA1_5Rm";
				obj4 = this.pbudgetinfo.ProjectRFA1_5rm;
				this.InsertText(application, bookmark, obj4, null, (this.pbudgetinfo.ProjectRFA1_5rm.Length > 14) ? 10.5f : 12f);
				bookmark = "ProjectRFA1_6Rm";
				obj4 = this.pbudgetinfo.ProjectRFA1_6rm;
				this.InsertText(application, bookmark, obj4, null, (this.pbudgetinfo.ProjectRFA1_6rm.Length > 14) ? 10.5f : 12f);
				bookmark = "ProjectRFA1_7Rm";
				obj4 = this.pbudgetinfo.ProjectRFA1_7rm;
				this.InsertText(application, bookmark, obj4, null, (this.pbudgetinfo.ProjectRFA1_7rm.Length > 14) ? 10.5f : 12f);
				bookmark = "ProjectRFA1_8Rm";
				obj4 = this.pbudgetinfo.ProjectRFA1_8rm;
				this.InsertText(application, bookmark, obj4, null, (this.pbudgetinfo.ProjectRFA1_8rm.Length > 14) ? 10.5f : 12f);
				bookmark = "ProjectRFA1_9Rm";
				obj4 = this.pbudgetinfo.ProjectRFA1_9rm;
				this.InsertText(application, bookmark, obj4, null, (this.pbudgetinfo.ProjectRFA1_9rm.Length > 14) ? 10.5f : 12f);
				bookmark = "ProjectRFA2Rm";
				obj4 = this.pbudgetinfo.ProjectRFA2rm;
				this.InsertText(application, bookmark, obj4, null, (this.pbudgetinfo.ProjectRFA2rm.Length > 14) ? 10.5f : 12f);
				bookmark = "ProjectRFA2_1Rm";
				obj4 = this.pbudgetinfo.ProjectRFA2_1rm;
				this.InsertText(application, bookmark, obj4, null, (this.pbudgetinfo.ProjectRFA2_1rm.Length > 14) ? 10.5f : 12f);

                int extFileTableRowNum = 1;
				if (this.rinfo.ApplicationType == "专家提名")
				{
					this.setprogress(45, "读取推荐意见...");

                    bookmark = "ExpertName1";
					obj4 = this.rmdinfo.ExperInfoList[0].ExpertName;
					this.InsertText(application, bookmark, obj4, null);
					bookmark = "ExpertArea1";
					obj4 = this.rmdinfo.ExperInfoList[0].ExpertArea;
					this.InsertText(application, bookmark, obj4, null);
					bookmark = "ExpertUnitPosition1";
					obj4 = this.rmdinfo.ExperInfoList[0].ExpertUnitPosition;
					this.InsertText(application, bookmark, obj4, null);
					bookmark = "ExpertUnit1";
					obj4 = this.rmdinfo.ExperInfoList[0].ExpertUnit;
					this.InsertText(application, bookmark, obj4, null);
					bookmark = "ExpertName2";
					obj4 = this.rmdinfo.ExperInfoList[1].ExpertName;
					this.InsertText(application, bookmark, obj4, null);
					bookmark = "ExpertArea2";
					obj4 = this.rmdinfo.ExperInfoList[1].ExpertArea;
					this.InsertText(application, bookmark, obj4, null);
					bookmark = "ExpertUnitPosition2";
					obj4 = this.rmdinfo.ExperInfoList[1].ExpertUnitPosition;
					this.InsertText(application, bookmark, obj4, null);
					bookmark = "ExpertUnit2";
					obj4 = this.rmdinfo.ExperInfoList[1].ExpertUnit;
					this.InsertText(application, bookmark, obj4, null);
					bookmark = "ExpertName3";
					obj4 = this.rmdinfo.ExperInfoList[2].ExpertName;
					this.InsertText(application, bookmark, obj4, null);
					bookmark = "ExpertArea3";
					obj4 = this.rmdinfo.ExperInfoList[2].ExpertArea;
					this.InsertText(application, bookmark, obj4, null);
					bookmark = "ExpertUnitPosition3";
					obj4 = this.rmdinfo.ExperInfoList[2].ExpertUnitPosition;
					this.InsertText(application, bookmark, obj4, null);
					bookmark = "ExpertUnit3";
					obj4 = this.rmdinfo.ExperInfoList[2].ExpertUnit;
					this.InsertText(application, bookmark, obj4, null);
				}

				this.setprogress(50, "读取个人简历...");

                //查找所有表格
                NodeCollection ncc = application.Document.WordDoc.GetChildNodes(NodeType.Table, true);
                
                //附件列表
                int extDocumentCount = 0;
                List<string[]> extDocumentList = new List<string[]>();
                
                foreach (Node node in ncc)
                {
                    Aspose.Words.Tables.Table t = (Aspose.Words.Tables.Table)node;
                    if (t.GetText().Contains("起止年月") && t.GetText().Contains("校（院）及系名称"))
                    {
                        //创建行
                        for (int k = 0; k < this.eduinfolist.Count - 1; k++)
                        {
                            t.Rows.Insert(1, (Aspose.Words.Tables.Row)t.Rows[t.Rows.Count - 2].Clone(true));
                        }

                        for(int kk= 0;kk < this.eduinfolist.Count;kk++)
                        {
                            application.Document.fillCell(true, t.Rows[kk + 1].Cells[0], application.Document.newParagraph(application.Document.WordDoc, this.eduinfolist[kk].EducationDate));
                            application.Document.fillCell(true, t.Rows[kk + 1].Cells[1], application.Document.newParagraph(application.Document.WordDoc,  this.eduinfolist[kk].EducationOrg));
                            application.Document.fillCell(true, t.Rows[kk + 1].Cells[2], application.Document.newParagraph(application.Document.WordDoc, this.eduinfolist[kk].EducationMajor));
                            application.Document.fillCell(true, t.Rows[kk + 1].Cells[3], application.Document.newParagraph(application.Document.WordDoc, this.eduinfolist[kk].EducationDegree));
                        }
                    }
                }
                
                foreach (Node node in ncc)
                {
                    Aspose.Words.Tables.Table t = (Aspose.Words.Tables.Table)node;
                    if (t.GetText().Contains("工作单位") && t.GetText().Contains("职务/职称"))
                    {
                        //创建行
                        for (int k = 0; k < this.workinfolist.Count - 1; k++)
                        {
                            t.Rows.Insert(1, (Aspose.Words.Tables.Row)t.Rows[t.Rows.Count - 2].Clone(true));
                        }

                        for (int kk = 0; kk < this.workinfolist.Count; kk++)
                        {
                            application.Document.fillCell(true, t.Rows[kk + 1].Cells[0], application.Document.newParagraph(application.Document.WordDoc, this.workinfolist[kk].WorkExperienceDate));
                            application.Document.fillCell(true, t.Rows[kk + 1].Cells[1], application.Document.newParagraph(application.Document.WordDoc, this.workinfolist[kk].WorkExperienceOrg));
                            application.Document.fillCell(true, t.Rows[kk + 1].Cells[2], application.Document.newParagraph(application.Document.WordDoc, this.workinfolist[kk].WorkExperienceContent));
                        }
                    }
                }
                
                foreach (Node node in ncc)
                {
                    Aspose.Words.Tables.Table t = (Aspose.Words.Tables.Table)node;
                    if (t.GetText().Contains("组织/机构") && t.GetText().Contains("任职情况"))
                    {
                        //创建行
                        for (int k = 0; k < this.acainfolist.Count - 1; k++)
                        {
                            t.Rows.Insert(1, (Aspose.Words.Tables.Row)t.Rows[t.Rows.Count - 2].Clone(true));
                        }

                        for (int kk = 0; kk < this.acainfolist.Count; kk++)
                        {
                            application.Document.fillCell(true, t.Rows[kk + 1].Cells[0], application.Document.newParagraph(application.Document.WordDoc, this.acainfolist[kk].AcademicPostDate));
                            application.Document.fillCell(true, t.Rows[kk + 1].Cells[1], application.Document.newParagraph(application.Document.WordDoc, this.acainfolist[kk].AcademicPostOrg));
                            application.Document.fillCell(true, t.Rows[kk + 1].Cells[2], application.Document.newParagraph(application.Document.WordDoc, this.acainfolist[kk].AcademicPostContent));
                        }
                    }
                }
                
                foreach (Node node in ncc)
                {
                    Aspose.Words.Tables.Table t = (Aspose.Words.Tables.Table)node;
                    if (t.GetText().Contains("入选时间") && t.GetText().Contains("人才计划名称/研究方向"))
                    {
                        //创建行
                        for (int k = 0; k < this.talentlist.Count - 1; k++)
                        {
                            t.Rows.Insert(1, (Aspose.Words.Tables.Row)t.Rows[t.Rows.Count - 2].Clone(true));
                        }

                        for (int kk = 0; kk < this.talentlist.Count; kk++)
                        {
                            application.Document.fillCell(true, t.Rows[kk + 1].Cells[0], application.Document.newParagraph(application.Document.WordDoc, this.talentlist[kk].TalentsPlanDate + "年"));
                            application.Document.fillCell(true, t.Rows[kk + 1].Cells[1], application.Document.newParagraph(application.Document.WordDoc, ((this.talentlist[kk].TalentsPlanRA == string.Empty) ? this.talentlist[kk].TalentsPlanName : (this.talentlist[kk].TalentsPlanName + "," + this.talentlist[kk].TalentsPlanRA))));
                            application.Document.fillCell(true, t.Rows[kk + 1].Cells[2], application.Document.newParagraph(application.Document.WordDoc, this.talentlist[kk].TalentsPlanOutlay));
                        }
                    }
                }
                
                foreach (Node node in ncc)
                {
                    Aspose.Words.Tables.Table t = (Aspose.Words.Tables.Table)node;
                    if (t.GetText().Contains("项目名称") && t.GetText().Contains("项目来源") && t.GetText().Contains("起止年月") && t.GetText().Contains("主要承担任务"))
                    {
                        //创建行
                        for (int k = 0; k < this.ndprolist.Count - 1; k++)
                        {
                            t.Rows.Insert(1, (Aspose.Words.Tables.Row)t.Rows[t.Rows.Count - 2].Clone(true));
                        }

                        for (int kk = 0; kk < this.ndprolist.Count; kk++)
                        {
                            application.Document.fillCell(true, t.Rows[kk + 1].Cells[0], application.Document.newParagraph(application.Document.WordDoc, (kk + 1).ToString()));
                            application.Document.fillCell(true, t.Rows[kk + 1].Cells[1], application.Document.newParagraph(application.Document.WordDoc, this.ndprolist[kk].NDProjectName));
                            application.Document.fillCell(true, t.Rows[kk + 1].Cells[2], application.Document.newParagraph(application.Document.WordDoc, this.ndprolist[kk].NDProjectSource));
                            application.Document.fillCell(true, t.Rows[kk + 1].Cells[3], application.Document.newParagraph(application.Document.WordDoc, this.ndprolist[kk].NDProjectOutlay));
                            application.Document.fillCell(true, t.Rows[kk + 1].Cells[4], application.Document.newParagraph(application.Document.WordDoc, this.ndprolist[kk].NDProjectDate));
                            application.Document.fillCell(true, t.Rows[kk + 1].Cells[5], application.Document.newParagraph(application.Document.WordDoc, this.ndprolist[kk].NDProjectTaskBySelf));
                            application.Document.fillCell(true, t.Rows[kk + 1].Cells[6], application.Document.newParagraph(application.Document.WordDoc, this.ndprolist[kk].NDProjectUserOrder));
                        }
                    }
                }
                
                foreach (Node node in ncc)
                {
                    Aspose.Words.Tables.Table t = (Aspose.Words.Tables.Table)node;
                    if (t.GetText().Contains("题目") && t.GetText().Contains("类别") && t.GetText().Contains("年份") && t.GetText().Contains("报告采纳"))
                    {
                        //创建行
                        for (int k = 0; k < this.rtlist.Count - 1; k++)
                        {
                            t.Rows.Insert(1, (Aspose.Words.Tables.Row)t.Rows[t.Rows.Count - 2].Clone(true));
                        }

                        for (int kk = 0; kk < this.rtlist.Count; kk++)
                        {
                            application.Document.fillCell(true, t.Rows[kk + 1].Cells[0], application.Document.newParagraph(application.Document.WordDoc, (kk + 1).ToString()));
                            application.Document.fillCell(true, t.Rows[kk + 1].Cells[1], application.Document.newParagraph(application.Document.WordDoc, this.rtlist[kk].RTreatisesName));
                            application.Document.fillCell(true, t.Rows[kk + 1].Cells[2], application.Document.newParagraph(application.Document.WordDoc, this.rtlist[kk].RTreatisesTypeExp));
                            application.Document.fillCell(true, t.Rows[kk + 1].Cells[3], application.Document.newParagraph(application.Document.WordDoc, this.rtlist[kk].RTreatisesRell + "年"));
                            application.Document.fillCell(true, t.Rows[kk + 1].Cells[4], application.Document.newParagraph(application.Document.WordDoc, this.rtlist[kk].RTreatisesJournalTitle));
                            application.Document.fillCell(true, t.Rows[kk + 1].Cells[5], application.Document.newParagraph(application.Document.WordDoc, this.rtlist[kk].RTreatisesCollection));
                            application.Document.fillCell(true, t.Rows[kk + 1].Cells[6], application.Document.newParagraph(application.Document.WordDoc, this.rtlist[kk].RTreatisesAuthor));
                            
                            //作口列表
                            extDocumentList.Add(new string[]{ this.rtlist[kk].RTreatisesName, "代表性论著--" + this.rtlist[kk].RTreatisesTypeExp});                        
                        }
                    }
                }
                
                foreach (Node node in ncc)
                {
                    Aspose.Words.Tables.Table t = (Aspose.Words.Tables.Table)node;
                    if (t.GetText().Contains("项目名称") && t.GetText().Contains("奖励类别及等级"))
                    {
                        //创建行
                        for (int k = 0; k < this.techlist.Count - 1; k++)
                        {
                            t.Rows.Insert(1, (Aspose.Words.Tables.Row)t.Rows[t.Rows.Count - 2].Clone(true));
                        }

                        for (int kk = 0; kk < this.techlist.Count; kk++)
                        {
                            application.Document.fillCell(true, t.Rows[kk + 1].Cells[0], application.Document.newParagraph(application.Document.WordDoc, (kk + 1).ToString()));
                            application.Document.fillCell(true, t.Rows[kk + 1].Cells[1], application.Document.newParagraph(application.Document.WordDoc, this.techlist[kk].TechnologyAwardsPName));
                            application.Document.fillCell(true, t.Rows[kk + 1].Cells[2], application.Document.newParagraph(application.Document.WordDoc, this.techlist[kk].TechnologyAwardsTypeLevel));
                            application.Document.fillCell(true, t.Rows[kk + 1].Cells[3], application.Document.newParagraph(application.Document.WordDoc, this.techlist[kk].TechnologyAwardsYear + "年"));
                            application.Document.fillCell(true, t.Rows[kk + 1].Cells[4], application.Document.newParagraph(application.Document.WordDoc, this.techlist[kk].TechnologyAwardsee));
                            //作口列表
                            extDocumentList.Add(new string[] { this.techlist[kk].TechnologyAwardsPName, "重要科技奖项" });
                        }
                    }
                }
                
                foreach (Node node in ncc)
                {
                    Aspose.Words.Tables.Table t = (Aspose.Words.Tables.Table)node;
                    if (t.GetText().Contains("专利名称") && t.GetText().Contains("专利号"))
                    {
                        //创建行
                        for (int k = 0; k < this.ndpatentlist.Count - 1; k++)
                        {
                            t.Rows.Insert(1, (Aspose.Words.Tables.Row)t.Rows[t.Rows.Count - 2].Clone(true));
                        }

                        for (int kk = 0; kk < this.ndpatentlist.Count; kk++)
                        {
                            application.Document.fillCell(true, t.Rows[kk + 1].Cells[0], application.Document.newParagraph(application.Document.WordDoc, (kk + 1).ToString()));
                            application.Document.fillCell(true, t.Rows[kk + 1].Cells[1], application.Document.newParagraph(application.Document.WordDoc, this.ndpatentlist[kk].NDPatentName));
                            application.Document.fillCell(true, t.Rows[kk + 1].Cells[2], application.Document.newParagraph(application.Document.WordDoc, this.ndpatentlist[kk].NDPatentNumber));

                            DateTime dateTime;
                            						if (this.ndpatentlist[kk].NDPatentApprovalYear != string.Empty && DateTime.TryParse(this.ndpatentlist[kk].NDPatentApprovalYear, out dateTime))
						{
                            application.Document.fillCell(true, t.Rows[kk + 1].Cells[3], application.Document.newParagraph(application.Document.WordDoc, dateTime.ToString("yyyy.M")));
                                                    }

                            application.Document.fillCell(true, t.Rows[kk + 1].Cells[4], application.Document.newParagraph(application.Document.WordDoc, this.ndpatentlist[kk].NDPatentApplicants));
                            //作口列表
                            extDocumentList.Add(new string[] { this.ndpatentlist[kk].NDPatentName, "国家及国防专利" });
                        }
                    }
                }

				bookmark = "jsyy";
				this.setprogress(60, "读取主要成绩和突出贡献...");
                FileInfo fileInfo = new FileInfo(Path.Combine(EntityElement.FilesStorePath, "主要成绩和突出贡献.doc"));
				if (fileInfo.Exists)
				{
                    application.insertFile(bookmark.ToString(), fileInfo.FullName, false);
				}
				bookmark = "zzyj";
				this.setprogress(65, "读取拟开展的研究工作...");
                fileInfo = new FileInfo(Path.Combine(EntityElement.FilesStorePath, "拟开展的研究工作.doc"));
				if (fileInfo.Exists)
                {
                    application.insertFile(bookmark.ToString(), fileInfo.FullName, false);
                }
				bookmark = "bookresult";
				this.setprogress(70, "读取成果形式...");
				obj4 = this.resultFormInfo.GetDescription();
				this.InsertText(application, bookmark, obj4, null);
				bookmark = "bookmission";
                this.setprogress(73, "读取第一年研究任务...");
                fileInfo = new FileInfo(Path.Combine(EntityElement.FilesStorePath, "第一年研究任务.doc"));
				if (fileInfo.Exists)
                {
                    application.insertFile(bookmark.ToString(), fileInfo.FullName, false);
                }

                extDocumentList.Add(new string[] { "保密资质复印件","保密资质" });

                foreach (Node node in ncc)
                {
                    Aspose.Words.Tables.Table t = (Aspose.Words.Tables.Table)node;
                    if (t.GetText().Contains("附件名称") && t.GetText().Contains("附件类型"))
                    {
                        //创建行
                        for (int k = 0; k < extDocumentList.Count - 1; k++)
                        {
                            t.Rows.Insert(1, (Aspose.Words.Tables.Row)t.Rows[t.Rows.Count - 2].Clone(true));
                        }

                        for (int kk = 0; kk < extDocumentList.Count; kk++)
                        {
                            string[] datas = extDocumentList[kk];

                            application.Document.fillCell(true, t.Rows[kk + 1].Cells[0], application.Document.newParagraph(application.Document.WordDoc, (kk + 1).ToString()));
                            application.Document.fillCell(true, t.Rows[kk + 1].Cells[1], application.Document.newParagraph(application.Document.WordDoc, datas[0]));
                            application.Document.fillCell(true, t.Rows[kk + 1].Cells[2], application.Document.newParagraph(application.Document.WordDoc, datas[1]));
                        }
                    }
                }

                //this.setprogress(74, "读取保密资质...");
                //if (File.Exists(Path.Combine(EntityElement.FilesStorePath, "extFile1.png")))
                //{
                //    bookmark = "ExtFile1";
                //    document.Bookmarks[bookmark].Select();

                //    object miss = System.Reflection.Missing.Value;
                //    object oStart = bookmark;
                //    object linkToFile = false; //图片不为外部链接
                //    object saveWithDocment = true; //图片随文档一起保存
                //    object range = application.ActiveDocument.Bookmarks.get_Item(ref oStart).Range; //图片插入位置
                //    application.ActiveDocument.InlineShapes.AddPicture(Path.Combine(EntityElement.FilesStorePath, "extFile1.png"), ref linkToFile, ref saveWithDocment, ref range);
                //}

                this.setprogress(75, "等待Word完成...");
			}
			catch (Exception ex3)
			{
				Exception ex = ex3;
				BaseForm.MethodInvoker uiDelegate4 = delegate
				{
					MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					this.Close();
				};
				
				bool result = false;
				return result;
			}
			try
			{
                application.Document.WordDoc.Save(destDocFiless);
			}
			catch (Exception ex4)
			{
				Exception ex = ex4;
				BaseForm.MethodInvoker uiDelegate5 = delegate
				{
					MessageBox.Show("Word保存失败，操作无法继续，请检查Word能否正常保存文件。\r\n详细错误：" + ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					this.Close();
				};
				bool result = false;
				return result;
			}

            try
            {
                Process.Start(destDocFiless);
            }
            catch (Exception ex) { }
			

			this.setprogress(80, "");
			return true;
		}

        private void InsertText(WordUtility application, object bookmark, object obj4, string fontName)
        {
            string oldFont = application.Document.WordDocBuilder.Font.Name;
            if (!string.IsNullOrEmpty(fontName))
            {
                application.Document.WordDocBuilder.Font.Name = fontName;
            }

            application.insertValue(bookmark != null ? bookmark.ToString() : string.Empty, obj4 != null ? obj4.ToString() : string.Empty);

            application.Document.WordDocBuilder.Font.Name = oldFont;
        }

        private void InsertText(WordUtility application, object bookmark, object obj4, string fontName, double fontSize)
        {
            double oldSize = application.Document.WordDocBuilder.Font.Size;
            string oldFont = application.Document.WordDocBuilder.Font.Name;
            if (!string.IsNullOrEmpty(fontName))
            {
                application.Document.WordDocBuilder.Font.Name = fontName;
            }
            application.Document.WordDocBuilder.Font.Size = fontSize;

            application.insertValue(bookmark != null ? bookmark.ToString() : string.Empty, obj4 != null ? obj4.ToString() : string.Empty);

            application.Document.WordDocBuilder.Font.Name = oldFont;
            application.Document.WordDocBuilder.Font.Size = oldSize;
        }

		private void ToZip()
		{
			this.setprogress(90, "压缩文件...");
			try
			{
				if (File.Exists(Path.Combine(EntityElement.DBStorePath, "myData.db")))
				{
					File.Copy(Path.Combine(EntityElement.DBStorePath, "myData.db"), Path.Combine(EntityElement.FilesStorePath, "myData.db"), true);
				}
				this.ZipDirectory(EntityElement.FilesStorePath, Path.Combine(EntityElement.TempPath, "temp.zip"), "");
			}
			catch (Exception ex)
			{	
				BaseForm.MethodInvoker uiDelegate = delegate
				{
					MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					this.Close();
				};
				base.UpdateUI(uiDelegate, this);
				return;
			}
			this.setprogress(95, "保存...");
			try
			{
				File.Copy(Path.Combine(EntityElement.TempPath, "temp.zip"), this.Savefilename, true);
			}
			catch (Exception ex)
			{
				BaseForm.MethodInvoker uiDelegate2 = delegate
				{
					MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					this.Close();
				};
				base.UpdateUI(uiDelegate2, this);
			}
			File.Delete(Path.Combine(EntityElement.TempPath, "temp.zip"));
			this.setprogress(100, "");
		}

		private void setprogress(int cval, string msg)
		{
			BaseForm.MethodInvoker uiDelegate = delegate
			{
				if (cval == this.pbar.Maximum)
				{
					this.Close();
				}
				this.pbar.Value = cval;
				this.lbmsg.Text = msg;
			};
			base.UpdateUI(uiDelegate, this);
		}

		public bool ZipDirectory(string folderToZip, string zipedFile, string password)
		{
			bool result = false;
			if (!Directory.Exists(folderToZip))
			{
				return result;
			}
			ZipOutputStream zipOutputStream = new ZipOutputStream(File.Create(zipedFile));
			zipOutputStream.SetLevel(6);
			if (!string.IsNullOrEmpty(password))
			{
				zipOutputStream.Password = password;
			}
			result = this.ZipDirectory(folderToZip, zipOutputStream, "");
			zipOutputStream.Finish();
			zipOutputStream.Close();
			return result;
		}

		private bool ZipDirectory(string folderToZip, ZipOutputStream zipStream, string parentFolderName)
		{
			bool result = true;
			ZipEntry zipEntry = null;
			FileStream fileStream = null;
			Crc32 crc = new Crc32();
			try
			{
				zipEntry = new ZipEntry(Path.Combine(parentFolderName, Path.GetFileName(folderToZip) + "/"));
				zipStream.PutNextEntry(zipEntry);
				zipStream.Flush();
				string[] files = Directory.GetFiles(folderToZip);
				string[] array = files;
				for (int i = 0; i < array.Length; i++)
				{
					string path = array[i];
					fileStream = File.OpenRead(path);
					byte[] array2 = new byte[fileStream.Length];
					fileStream.Read(array2, 0, array2.Length);
					zipEntry = new ZipEntry(Path.Combine(parentFolderName, Path.GetFileName(folderToZip) + "/" + Path.GetFileName(path)));
					zipEntry.DateTime = DateTime.Now;
					zipEntry.Size = fileStream.Length;
					fileStream.Close();
					crc.Reset();
					crc.Update(array2);
					zipEntry.Crc = crc.Value;
					zipStream.PutNextEntry(zipEntry);
					zipStream.Write(array2, 0, array2.Length);
				}
			}
			catch
			{
				result = false;
			}
			finally
			{
				if (fileStream != null)
				{
					fileStream.Close();
					fileStream.Dispose();
				}
				if (zipEntry != null)
				{
					zipEntry = null;
				}
				GC.Collect();
				GC.Collect(1);
			}
			string[] directories = Directory.GetDirectories(folderToZip);
			string[] array3 = directories;
			for (int j = 0; j < array3.Length; j++)
			{
				string folderToZip2 = array3[j];
				if (!this.ZipDirectory(folderToZip2, zipStream, folderToZip))
				{
					return false;
				}
			}
			return result;
		}

		private bool isApplyUserInfoCompleted(ApplyUserInfo puserinfo)
		{
			if (puserinfo.ApplyUserName.Trim() == string.Empty || puserinfo.Sex == string.Empty || puserinfo.Degree == string.Empty || puserinfo.JobTitle == string.Empty || puserinfo.MainResearch == string.Empty || puserinfo.CardNo == string.Empty || puserinfo.OfficePhones == string.Empty || puserinfo.MobilePhone == string.Empty || puserinfo.EMail == string.Empty || puserinfo.WorkUnitName == string.Empty || puserinfo.UnitName == string.Empty || puserinfo.UnitContacts == string.Empty || puserinfo.UnitForORG == string.Empty || puserinfo.UnitProperties == string.Empty || puserinfo.UnitContactsPhone == string.Empty || puserinfo.UnitAddress == string.Empty)
			{
				BaseForm.MethodInvoker uiDelegate = delegate
				{
					MessageBox.Show("申报信息未填写完成，当前不能上报。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					base.Close();
				};
				base.UpdateUI(uiDelegate, this);
				return false;
			}
			return true;
		}

		private bool isProjectBasicInfoCompleted(ProjectBasicInfo pprojectinfo)
		{
			bool flag = true;
			if (this.projectinfo.ProjectBrief == "")
			{
				flag = false;
			}
			string[] array = this.projectinfo.ProjectBrief.Split(new char[]
			{
				'|'
			});
			if (array.Length != 6)
			{
				flag = false;
			}
			string[] array2 = array;
			for (int i = 2; i < array2.Length; i++)
			{
				string a = array2[i];
				if (a == string.Empty)
				{
					flag = false;
					break;
				}
			}
			if (pprojectinfo.ProjectName == string.Empty || pprojectinfo.ProjectTD == string.Empty || pprojectinfo.ProjectMRD == string.Empty || pprojectinfo.ApplicationArea == string.Empty || pprojectinfo.ProjectSecret == string.Empty || pprojectinfo.ProjectLimitStart == string.Empty || pprojectinfo.ProjectLimitEnd == string.Empty || pprojectinfo.ProjectKeyWord == string.Empty || !flag)
			{
				BaseForm.MethodInvoker uiDelegate = delegate
				{
					MessageBox.Show("项目信息未填写完成，当前不能上报。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					base.Close();
				};
				base.UpdateUI(uiDelegate, this);
				return false;
			}
			if (pprojectinfo.ProjectSecret == "公开" || pprojectinfo.ProjectSecret == "绝密")
			{
				BaseForm.MethodInvoker uiDelegate2 = delegate
				{
					MessageBox.Show("项目信息中项目密级不能是公开或者绝密，当前不能上报。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					base.Close();
				};
				base.UpdateUI(uiDelegate2, this);
				return false;
			}
			decimal d = 0m;
			decimal d2 = 0m;
			decimal.TryParse(pprojectinfo.ProjectLimitStart, out d);
			decimal.TryParse(pprojectinfo.ProjectLimitEnd, out d2);
			if (d + 4m != d2)
			{
				BaseForm.MethodInvoker uiDelegate3 = delegate
				{
					MessageBox.Show("项目信息中研究周期必须为5年，当前不能上报。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					base.Close();
				};
				base.UpdateUI(uiDelegate3, this);
				return false;
			}
			return true;
		}

		private bool isProjectBudgetInfoCompleted(ProjectBudgetInfo pbinfo)
		{
			if (!pbinfo.ProjectRFA.HasValue || pbinfo.ProjectRFA == 0m)
			{
				BaseForm.MethodInvoker uiDelegate = delegate
				{
					MessageBox.Show("经费预算未填写完成，当前不能上报。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					this.Close();
				};
				base.UpdateUI(uiDelegate, this);
				return false;
			}
			decimal d = (!pbinfo.ProjectRFA.HasValue) ? 0m : pbinfo.ProjectRFA.Value;
			lbmsg.Text = "";
			if (d != 500m)
			{
				lbmsg.Text = "经费总额必须为500万，当前不能上报。\r\n";
			}
			decimal d2 = (!pbinfo.ProjectRFA2.HasValue) ? 0m : pbinfo.ProjectRFA2.Value;
			decimal d3 = (!pbinfo.ProjectRFA1.HasValue) ? 0m : pbinfo.ProjectRFA1.Value;
			decimal d4 = (!pbinfo.ProjectRFA1_1_1.HasValue) ? 0m : pbinfo.ProjectRFA1_1_1.Value;
			decimal d5 = (!pbinfo.ProjectRFA1_3.HasValue) ? 0m : pbinfo.ProjectRFA1_3.Value;
			if (d2 > (d3 - d4 - d5) * 0.2m)
			{
				lbmsg.Text += "请注意，间接经费不超过直接经费减去设备购置费和外协费的20%，当前不能上报。\r\n";
			}
			if (lbmsg.Text != "")
			{
				BaseForm.MethodInvoker uiDelegate2 = delegate
				{
                    MessageBox.Show(lbmsg.Text, "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					this.Close();
				};
				base.UpdateUI(uiDelegate2, this);
				return false;
			}
			return true;
		}

		private bool isRecommendInfoCompleted(RecommendInfo rmdinfo)
		{
			if (rmdinfo.ApplicationType == "单位推荐")
			{
				if (rmdinfo.RAttachmentInfo.StoreName == string.Empty)
				{
					BaseForm.MethodInvoker uiDelegate = delegate
					{
						MessageBox.Show("单位推荐意见未填写完成，当前不能上报。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						base.Close();
					};
					base.UpdateUI(uiDelegate, this);
					return false;
				}
			}
			else
			{
				int num = 0;
				if (rmdinfo.ExperInfoList[0].ExpertName != "" && rmdinfo.ExperInfoList[0].ExpertArea.Trim() != "" && rmdinfo.ExperInfoList[0].ExpertUnitPosition.Trim() != "" && rmdinfo.ExperInfoList[0].ExpertUnit.Trim() != "" && rmdinfo.ExperInfoList[0].EAttachmentInfo.StoreName != "")
				{
					num++;
				}
				if (rmdinfo.ExperInfoList[1].ExpertName != "" && rmdinfo.ExperInfoList[1].ExpertArea.Trim() != "" && rmdinfo.ExperInfoList[1].ExpertUnitPosition.Trim() != "" && rmdinfo.ExperInfoList[1].ExpertUnit.Trim() != "" && rmdinfo.ExperInfoList[1].EAttachmentInfo.StoreName != "")
				{
					num++;
				}
				if (rmdinfo.ExperInfoList[2].ExpertName != "" && rmdinfo.ExperInfoList[2].ExpertArea.Trim() != "" && rmdinfo.ExperInfoList[2].ExpertUnitPosition.Trim() != "" && rmdinfo.ExperInfoList[2].ExpertUnit.Trim() != "" && rmdinfo.ExperInfoList[2].EAttachmentInfo.StoreName != "")
				{
					num++;
				}
				if (num != 3)
				{
					BaseForm.MethodInvoker uiDelegate2 = delegate
					{
						MessageBox.Show("请完成三名推荐专家的全部信息，当前不能上报。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						base.Close();
					};
					base.UpdateUI(uiDelegate2, this);
					return false;
				}
			}
			return true;
		}
	}
}