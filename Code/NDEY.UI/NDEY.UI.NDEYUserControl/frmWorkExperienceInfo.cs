using ComponentFactory.Krypton.Navigator;
using ComponentFactory.Krypton.Toolkit;
using NDEY.BLL.Entity;
using NDEY.BLL.Service;
using NDEY.UI.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace NDEY.UI.NDEYUserControl
{
	public class frmWorkExperienceInfo : BaseControl
	{
		private IContainer components;

		private TableLayoutPanel tableLayoutPanel9;

		private KryptonPanel kryptonPanel21;

		private KryptonLabel kryptonLabel64;

		private KryptonDataGridView dwork;

		private TableLayoutPanel tableLayoutPanel1;

		private KryptonButton btnsave;

		private KryptonButton btnnext;

		private DataGridViewTextBoxColumn workid;

		private CalendarColumnYM workstartdate;

		private CalendarColumnYM workenddate;

		private DataGridViewTextBoxColumn workcompany;

		private DataGridViewTextBoxColumn workduty;

		private DataGridViewImageColumn workup;

		private DataGridViewImageColumn workdown;

		private DataGridViewImageColumn workdelete;

		private DataGridViewTextBoxColumn cworkOrder;

		private WorkExperienceService _workExperienceService = new WorkExperienceService();

		private IList<string> _deletedNo = new List<string>();

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
			DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
			this.tableLayoutPanel9 = new TableLayoutPanel();
			this.tableLayoutPanel1 = new TableLayoutPanel();
			this.btnnext = new KryptonButton();
			this.btnsave = new KryptonButton();
			this.kryptonPanel21 = new KryptonPanel();
			this.kryptonLabel64 = new KryptonLabel();
			this.dwork = new KryptonDataGridView();
			this.workid = new DataGridViewTextBoxColumn();
			this.workstartdate = new CalendarColumnYM();
			this.workenddate = new CalendarColumnYM();
			this.workcompany = new DataGridViewTextBoxColumn();
			this.workduty = new DataGridViewTextBoxColumn();
			this.workup = new DataGridViewImageColumn();
			this.workdown = new DataGridViewImageColumn();
			this.workdelete = new DataGridViewImageColumn();
			this.cworkOrder = new DataGridViewTextBoxColumn();
			this.tableLayoutPanel9.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			((ISupportInitialize)this.kryptonPanel21).BeginInit();
			this.kryptonPanel21.SuspendLayout();
			((ISupportInitialize)this.dwork).BeginInit();
			base.SuspendLayout();
			this.tableLayoutPanel9.ColumnCount = 3;
			this.tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50f));
			this.tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50f));
			this.tableLayoutPanel9.Controls.Add(this.tableLayoutPanel1, 1, 3);
			this.tableLayoutPanel9.Controls.Add(this.kryptonPanel21, 1, 1);
			this.tableLayoutPanel9.Controls.Add(this.dwork, 1, 2);
			this.tableLayoutPanel9.Dock = DockStyle.Fill;
			this.tableLayoutPanel9.Location = new Point(0, 0);
			this.tableLayoutPanel9.Name = "tableLayoutPanel9";
			this.tableLayoutPanel9.RowCount = 5;
			this.tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Absolute, 20f));
			this.tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Absolute, 40f));
			this.tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Absolute, 40f));
			this.tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Absolute, 20f));
			this.tableLayoutPanel9.Size = new Size(1056, 588);
			this.tableLayoutPanel9.TabIndex = 2;
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 103f));
			this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100f));
			this.tableLayoutPanel1.Controls.Add(this.btnnext, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.btnsave, 1, 0);
			this.tableLayoutPanel1.Dock = DockStyle.Fill;
			this.tableLayoutPanel1.Location = new Point(53, 531);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel1.Size = new Size(950, 34);
			this.tableLayoutPanel1.TabIndex = 4;
			this.btnnext.Location = new Point(853, 3);
			this.btnnext.Name = "btnnext";
			this.btnnext.Size = new Size(90, 25);
			this.btnnext.TabIndex = 1;
			this.btnnext.Values.Text = "下一页";
			this.btnnext.Click += new EventHandler(this.btnnext_Click);
			this.btnsave.Location = new Point(750, 3);
			this.btnsave.Name = "btnsave";
			this.btnsave.Size = new Size(90, 25);
			this.btnsave.TabIndex = 0;
			this.btnsave.Values.Text = "保存";
			this.btnsave.Click += new EventHandler(this.btnsave_Click);
			this.kryptonPanel21.Controls.Add(this.kryptonLabel64);
			this.kryptonPanel21.Dock = DockStyle.Fill;
			this.kryptonPanel21.Location = new Point(50, 20);
			this.kryptonPanel21.Margin = new Padding(0);
			this.kryptonPanel21.Name = "kryptonPanel21";
			this.kryptonPanel21.Size = new Size(956, 40);
			this.kryptonPanel21.TabIndex = 0;
			this.kryptonLabel64.Location = new Point(0, 10);
			this.kryptonLabel64.Name = "kryptonLabel64";
			this.kryptonLabel64.Size = new Size(324, 27);
			this.kryptonLabel64.StateCommon.LongText.Font = new Font("KaiTi_GB2312", 12f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.kryptonLabel64.StateCommon.ShortText.Font = new Font("SimHei", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.kryptonLabel64.TabIndex = 0;
			this.kryptonLabel64.Values.ExtraText = "（按时间倒序填写）";
			this.kryptonLabel64.Values.Text = "二、科研工作经历";
			this.dwork.AllowUserToResizeRows = false;
			this.dwork.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
			this.dwork.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dwork.Columns.AddRange(new DataGridViewColumn[]
			{
				this.workid,
				this.workstartdate,
				this.workenddate,
				this.workcompany,
				this.workduty,
				this.workup,
				this.workdown,
				this.workdelete,
				this.cworkOrder
			});
			this.dwork.Dock = DockStyle.Fill;
			this.dwork.Location = new Point(53, 63);
			this.dwork.MultiSelect = false;
			this.dwork.Name = "dwork";
			dataGridViewCellStyle.Font = new Font("FangSong_GB2312", 12f, FontStyle.Regular, GraphicsUnit.Point, 134);
			dataGridViewCellStyle.WrapMode = DataGridViewTriState.True;
			this.dwork.RowsDefaultCellStyle = dataGridViewCellStyle;
			this.dwork.RowTemplate.Height = 28;
			this.dwork.Size = new Size(950, 462);
			this.dwork.StateCommon.Background.Color1 = Color.White;
			this.dwork.StateCommon.BackStyle = PaletteBackStyle.GridBackgroundList;
			this.dwork.StateCommon.HeaderColumn.Content.Font = new Font("SimHei", 12f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.dwork.StateCommon.HeaderColumn.Content.TextH = PaletteRelativeAlign.Center;
			this.dwork.TabIndex = 1;
			this.dwork.CellContentClick += new DataGridViewCellEventHandler(this.dwork_CellContentClick);
			this.dwork.RowsAdded += new DataGridViewRowsAddedEventHandler(this.dwork_RowsAdded);
			this.workid.HeaderText = "";
			this.workid.Name = "workid";
			this.workid.SortMode = DataGridViewColumnSortMode.NotSortable;
			this.workid.Visible = false;
			this.workstartdate.HeaderText = "开始年月";
			this.workstartdate.Name = "workstartdate";
			this.workstartdate.Width = 120;
			this.workenddate.HeaderText = "结束年月";
			this.workenddate.Name = "workenddate";
			this.workenddate.Width = 120;
			this.workcompany.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.workcompany.HeaderText = "工作单位";
			this.workcompany.Name = "workcompany";
			this.workcompany.SortMode = DataGridViewColumnSortMode.NotSortable;
			this.workduty.HeaderText = "职务/职称";
			this.workduty.Name = "workduty";
			this.workduty.SortMode = DataGridViewColumnSortMode.NotSortable;
			this.workduty.Width = 120;
			this.workup.HeaderText = "上移";
			this.workup.Name = "workup";
			this.workup.Resizable = DataGridViewTriState.True;
			this.workup.Width = 45;
			this.workdown.HeaderText = "下移";
			this.workdown.Name = "workdown";
			this.workdown.Resizable = DataGridViewTriState.True;
			this.workdown.Width = 45;
			this.workdelete.HeaderText = "删除";
			this.workdelete.Name = "workdelete";
			this.workdelete.Resizable = DataGridViewTriState.True;
			this.workdelete.Width = 45;
			this.cworkOrder.HeaderText = "排序";
			this.cworkOrder.Name = "cworkOrder";
			this.cworkOrder.SortMode = DataGridViewColumnSortMode.NotSortable;
			this.cworkOrder.Visible = false;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			//base.AutoScaleMode = AutoScaleMode.Font;
			base.Controls.Add(this.tableLayoutPanel9);
			base.Name = "frmWorkExperienceInfo";
			base.Size = new Size(1056, 588);
			base.Leave += new EventHandler(this.frmWorkExperienceInfo_Leave);
			this.tableLayoutPanel9.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			((ISupportInitialize)this.kryptonPanel21).EndInit();
			this.kryptonPanel21.ResumeLayout(false);
			this.kryptonPanel21.PerformLayout();
			((ISupportInitialize)this.dwork).EndInit();
			base.ResumeLayout(false);
		}

		public frmWorkExperienceInfo()
		{
			this.InitializeComponent();
		}

		protected override void OnLoad(EventArgs e)
		{
			this.RefreshCall();
			base.OnLoad(e);
		}

		private void LoadData(IList<WorkExperienceInfo> list)
		{
			this.dwork.Rows.Clear();
			foreach (WorkExperienceInfo current in list)
			{
				DataGridViewRow dataGridViewRow = new DataGridViewRow();
				int rowIndex = this.dwork.Rows.Add(dataGridViewRow);
				this.dwork["workid", rowIndex].Value = current.WorkExperienceNo;
				DateTime dateTime;
				if (current.WorkExperienceSDate != string.Empty && DateTime.TryParse(current.WorkExperienceSDate, out dateTime))
				{
					this.dwork["workstartdate", rowIndex].Value = dateTime;
				}
				else
				{
					this.dwork["workstartdate", rowIndex].Value = DBNull.Value;
				}
				if (current.WorkExperienceEDate != string.Empty && DateTime.TryParse(current.WorkExperienceEDate, out dateTime))
				{
					this.dwork["workenddate", rowIndex].Value = dateTime;
				}
				else
				{
					this.dwork["workenddate", rowIndex].Value = DBNull.Value;
				}
				this.dwork["workcompany", rowIndex].Value = current.WorkExperienceOrg;
				this.dwork["workduty", rowIndex].Value = current.WorkExperienceContent;
				this.dwork["cworkOrder", rowIndex].Value = current.WorkExperienceOrder;
			}
		}

		private void dwork_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			int columnIndex = e.ColumnIndex;
			int rowIndex = e.RowIndex;
			if (rowIndex == -1)
			{
				return;
			}
			if (this.dwork.Columns[columnIndex].Name == "workup")
			{
				if (rowIndex == 0 || rowIndex == this.dwork.RowCount - 1)
				{
					return;
				}
				DataGridViewRow dataGridViewRow = this.dwork.Rows[rowIndex];
				this.dwork.Rows.Remove(dataGridViewRow);
				this.dwork.Rows.Insert(rowIndex - 1, dataGridViewRow);
				this.dwork.ClearSelection();
				return;
			}
			else
			{
				if (!(this.dwork.Columns[columnIndex].Name == "workdown"))
				{
					if (this.dwork.Columns[columnIndex].Name == "workdelete")
					{
						if (rowIndex == this.dwork.RowCount - 1)
						{
							return;
						}
						DataGridViewRow dataGridViewRow2 = this.dwork.Rows[rowIndex];
						if (dataGridViewRow2.Cells["workid"].Value != null)
						{
							this._deletedNo.Add(dataGridViewRow2.Cells["workid"].Value.ToString());
							this._workExperienceService.DeleteWorkExperiences(this._deletedNo);
							this._deletedNo.Clear();
						}
						this.dwork.Rows.Remove(dataGridViewRow2);
						this.dwork.ClearSelection();
					}
					return;
				}
				if (rowIndex >= this.dwork.RowCount - 2)
				{
					return;
				}
				DataGridViewRow dataGridViewRow3 = this.dwork.Rows[rowIndex];
				this.dwork.Rows.Remove(dataGridViewRow3);
				this.dwork.Rows.Insert(rowIndex + 1, dataGridViewRow3);
				this.dwork.ClearSelection();
				return;
			}
		}

		private void btnrefresh_Click(object sender, EventArgs e)
		{
			this._deletedNo.Clear();
			IList<WorkExperienceInfo> workExperience = this._workExperienceService.GetWorkExperience();
			this.LoadData(workExperience);
		}

		private bool SaveProgress()
		{
			this.OnSaveCheckDenyEvent(EventArgs.Empty);
			IList<WorkExperienceInfo> list = new List<WorkExperienceInfo>();
			for (int i = 0; i < this.dwork.RowCount - 1; i++)
			{
				DataGridViewRow dataGridViewRow = this.dwork.Rows[i];
				WorkExperienceInfo workExperienceInfo = new WorkExperienceInfo();
				workExperienceInfo.WorkExperienceNo = ((dataGridViewRow.Cells["workid"].Value == null) ? "" : dataGridViewRow.Cells["workid"].Value.ToString());
				workExperienceInfo.WorkExperienceSDate = ((dataGridViewRow.Cells["workstartdate"].Value == null || dataGridViewRow.Cells["workstartdate"].Value == DBNull.Value || dataGridViewRow.Cells["workstartdate"].Value.ToString() == "") ? "" : ((DateTime)dataGridViewRow.Cells["workstartdate"].Value).ToString("yyyy-MM-dd"));
				workExperienceInfo.WorkExperienceEDate = ((dataGridViewRow.Cells["workenddate"].Value == null || dataGridViewRow.Cells["workenddate"].Value == DBNull.Value || dataGridViewRow.Cells["workenddate"].Value.ToString() == "") ? "" : ((DateTime)dataGridViewRow.Cells["workenddate"].Value).ToString("yyyy-MM-dd"));
				workExperienceInfo.WorkExperienceOrg = ((dataGridViewRow.Cells["workcompany"].Value == null || dataGridViewRow.Cells["workcompany"].Value == DBNull.Value) ? "" : dataGridViewRow.Cells["workcompany"].Value.ToString());
				workExperienceInfo.WorkExperienceContent = ((dataGridViewRow.Cells["workduty"].Value == null || dataGridViewRow.Cells["workduty"].Value == DBNull.Value) ? "" : dataGridViewRow.Cells["workduty"].Value.ToString());
				workExperienceInfo.WorkExperienceOrder = this.dwork.RowCount - i;
				if (workExperienceInfo.WorkExperienceSDate == "" || workExperienceInfo.WorkExperienceOrg == "" || workExperienceInfo.WorkExperienceContent == "")
				{
					MessageBox.Show("开始年月、工作单位、职务/职称为必填字段，检测到部分字段未填写完整", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return false;
				}
				list.Add(workExperienceInfo);
			}
			this.OnSaveCheckPassedEvent(EventArgs.Empty);
			this._workExperienceService.UpdateWorkExperiences(list);
			list = this._workExperienceService.GetWorkExperience();
			this.LoadData(list);
			return true;
		}

		private void btnsave_Click(object sender, EventArgs e)
		{
			if (!this.SaveProgress())
			{
				return;
			}
			this.issaved = true;
			MessageBox.Show("保存成功。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		private void btnnext_Click(object sender, EventArgs e)
		{
			if (!this.SaveProgress())
			{
				return;
			}
			this.issaved = true;
			KryptonNavigator kryptonNavigator = (KryptonNavigator)base.Parent.Parent.Parent;
			kryptonNavigator.SelectedIndex++;
			kryptonNavigator.SelectedPage.Enabled = true;
		}

		private void dwork_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
		{
            this.dwork["workup", e.RowIndex].Value = global::Properties.Resource.UP_16;
            this.dwork["workdown", e.RowIndex].Value = global::Properties.Resource.DOWN_16;
            this.dwork["workdelete", e.RowIndex].Value = global::Properties.Resource.DELETE_28;
		}

		public override void RefreshCall()
		{
			IList<WorkExperienceInfo> workExperience = this._workExperienceService.GetWorkExperience();
			this.LoadData(workExperience);
		}

		private void frmWorkExperienceInfo_Leave(object sender, EventArgs e)
		{
			if (this.issaved)
			{
				this.issaved = false;
				return;
			}
			this.SaveProgress();
		}
	}
}
