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
	public class frmNDProject : BaseControl
	{
		private IContainer components;

		private TableLayoutPanel tableLayoutPanel12;

		private TableLayoutPanel tableLayoutPanel1;

		private KryptonButton btnsave;

		private KryptonButton btnnext;

		private KryptonPanel kryptonPanel27;

		private KryptonLabel kryptonLabel115;

		private KryptonDataGridView dproject;

		private DataGridViewTextBoxColumn defenceid;

		private DataGridViewTextBoxColumn defencename;

		private DataGridViewTextBoxColumn defencesource;

		private DataGridViewTextBoxColumn defencefee;

		private CalendarColumnYM defencestartdate;

		private CalendarColumnYM defenceenddate;

		private KryptonDataGridViewTextBoxColumn defencemaintask;

		private KryptonDataGridViewTextBoxColumn defenceorder;

		private KryptonDataGridViewTextBoxColumn proorder;

		private DataGridViewImageColumn defenceup;

		private DataGridViewImageColumn defencedown;

		private DataGridViewImageColumn defencedelete;

		private NDProjectService _nDProjectService = new NDProjectService();

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
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			this.tableLayoutPanel12 = new TableLayoutPanel();
			this.tableLayoutPanel1 = new TableLayoutPanel();
			this.btnnext = new KryptonButton();
			this.btnsave = new KryptonButton();
			this.kryptonPanel27 = new KryptonPanel();
			this.kryptonLabel115 = new KryptonLabel();
			this.dproject = new KryptonDataGridView();
			this.defenceid = new DataGridViewTextBoxColumn();
			this.defencename = new DataGridViewTextBoxColumn();
			this.defencesource = new DataGridViewTextBoxColumn();
			this.defencefee = new DataGridViewTextBoxColumn();
			this.defencestartdate = new CalendarColumnYM();
			this.defenceenddate = new CalendarColumnYM();
			this.defencemaintask = new KryptonDataGridViewTextBoxColumn();
			this.defenceorder = new KryptonDataGridViewTextBoxColumn();
			this.proorder = new KryptonDataGridViewTextBoxColumn();
			this.defenceup = new DataGridViewImageColumn();
			this.defencedown = new DataGridViewImageColumn();
			this.defencedelete = new DataGridViewImageColumn();
			this.tableLayoutPanel12.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			((ISupportInitialize)this.kryptonPanel27).BeginInit();
			this.kryptonPanel27.SuspendLayout();
			((ISupportInitialize)this.dproject).BeginInit();
			base.SuspendLayout();
			this.tableLayoutPanel12.ColumnCount = 3;
			this.tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50f));
			this.tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50f));
			this.tableLayoutPanel12.Controls.Add(this.tableLayoutPanel1, 1, 3);
			this.tableLayoutPanel12.Controls.Add(this.kryptonPanel27, 1, 1);
			this.tableLayoutPanel12.Controls.Add(this.dproject, 1, 2);
			this.tableLayoutPanel12.Dock = DockStyle.Fill;
			this.tableLayoutPanel12.Location = new Point(0, 0);
			this.tableLayoutPanel12.Name = "tableLayoutPanel12";
			this.tableLayoutPanel12.RowCount = 5;
			this.tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Absolute, 20f));
			this.tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Absolute, 40f));
			this.tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Absolute, 40f));
			this.tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Absolute, 20f));
			this.tableLayoutPanel12.Size = new Size(1029, 569);
			this.tableLayoutPanel12.TabIndex = 2;
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 103f));
			this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100f));
			this.tableLayoutPanel1.Controls.Add(this.btnnext, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.btnsave, 1, 0);
			this.tableLayoutPanel1.Dock = DockStyle.Fill;
			this.tableLayoutPanel1.Location = new Point(53, 512);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel1.Size = new Size(923, 34);
			this.tableLayoutPanel1.TabIndex = 5;
			this.btnnext.Location = new Point(826, 3);
			this.btnnext.Name = "btnnext";
			this.btnnext.Size = new Size(90, 25);
			this.btnnext.TabIndex = 1;
			this.btnnext.Values.Text = "下一页";
			this.btnnext.Click += new EventHandler(this.btnnext_Click);
			this.btnsave.Location = new Point(723, 3);
			this.btnsave.Name = "btnsave";
			this.btnsave.Size = new Size(90, 25);
			this.btnsave.TabIndex = 0;
			this.btnsave.Values.Text = "保存";
			this.btnsave.Click += new EventHandler(this.btnsave_Click);
			this.kryptonPanel27.Controls.Add(this.kryptonLabel115);
			this.kryptonPanel27.Dock = DockStyle.Fill;
			this.kryptonPanel27.Location = new Point(50, 20);
			this.kryptonPanel27.Margin = new Padding(0);
			this.kryptonPanel27.Name = "kryptonPanel27";
			this.kryptonPanel27.Size = new Size(929, 40);
			this.kryptonPanel27.TabIndex = 0;
			this.kryptonLabel115.Location = new Point(0, 10);
			this.kryptonLabel115.Name = "kryptonLabel115";
			this.kryptonLabel115.Size = new Size(395, 27);
			this.kryptonLabel115.StateCommon.LongText.Font = new Font("KaiTi_GB2312", 12f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.kryptonLabel115.StateCommon.ShortText.Font = new Font("SimHei", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.kryptonLabel115.TabIndex = 0;
			this.kryptonLabel115.Values.ExtraText = "（限10项）";
			this.kryptonLabel115.Values.Text = "五、承担国防相关代表性项目情况";
			this.dproject.AllowUserToResizeRows = false;
			this.dproject.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
			this.dproject.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dproject.Columns.AddRange(new DataGridViewColumn[]
			{
				this.defenceid,
				this.defencename,
				this.defencesource,
				this.defencefee,
				this.defencestartdate,
				this.defenceenddate,
				this.defencemaintask,
				this.defenceorder,
				this.proorder,
				this.defenceup,
				this.defencedown,
				this.defencedelete
			});
			this.dproject.Dock = DockStyle.Fill;
			this.dproject.Location = new Point(53, 63);
			this.dproject.MultiSelect = false;
			this.dproject.Name = "dproject";
			dataGridViewCellStyle.Font = new Font("FangSong_GB2312", 12f, FontStyle.Regular, GraphicsUnit.Point, 134);
			dataGridViewCellStyle.WrapMode = DataGridViewTriState.True;
			this.dproject.RowsDefaultCellStyle = dataGridViewCellStyle;
			this.dproject.RowTemplate.Height = 28;
			this.dproject.Size = new Size(923, 443);
			this.dproject.StateCommon.Background.Color1 = Color.White;
			this.dproject.StateCommon.BackStyle = PaletteBackStyle.GridBackgroundList;
			this.dproject.StateCommon.HeaderColumn.Content.Font = new Font("SimHei", 12f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.dproject.StateCommon.HeaderColumn.Content.MultiLine = InheritBool.False;
			this.dproject.StateCommon.HeaderColumn.Content.TextH = PaletteRelativeAlign.Center;
			this.dproject.TabIndex = 1;
			this.dproject.CellContentClick += new DataGridViewCellEventHandler(this.dproject_CellContentClick);
			this.dproject.RowsAdded += new DataGridViewRowsAddedEventHandler(this.dproject_RowsAdded);
			this.defenceid.HeaderText = "序号";
			this.defenceid.Name = "defenceid";
			this.defenceid.SortMode = DataGridViewColumnSortMode.NotSortable;
			this.defenceid.Visible = false;
			this.defenceid.Width = 40;
			this.defencename.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
			this.defencename.DefaultCellStyle = dataGridViewCellStyle2;
			this.defencename.HeaderText = "项目名称";
			this.defencename.MinimumWidth = 142;
			this.defencename.Name = "defencename";
			this.defencename.SortMode = DataGridViewColumnSortMode.NotSortable;
			this.defencesource.HeaderText = "项目来源";
			this.defencesource.Name = "defencesource";
			this.defencesource.SortMode = DataGridViewColumnSortMode.NotSortable;
			this.defencefee.HeaderText = "经费(万)";
			this.defencefee.Name = "defencefee";
			this.defencefee.SortMode = DataGridViewColumnSortMode.NotSortable;
			this.defencestartdate.HeaderText = "开始年月";
			this.defencestartdate.Name = "defencestartdate";
			this.defencestartdate.Width = 120;
			this.defenceenddate.HeaderText = "结束年月";
			this.defenceenddate.Name = "defenceenddate";
			this.defenceenddate.Width = 120;
			this.defencemaintask.HeaderText = "主要承担任务";
			this.defencemaintask.Name = "defencemaintask";
			this.defencemaintask.SortMode = DataGridViewColumnSortMode.NotSortable;
			this.defencemaintask.Width = 120;
			this.defenceorder.HeaderText = "排名";
			this.defenceorder.Name = "defenceorder";
			this.defenceorder.SortMode = DataGridViewColumnSortMode.NotSortable;
			this.defenceorder.Width = 45;
			this.proorder.HeaderText = "次序";
			this.proorder.Name = "proorder";
			this.proorder.Resizable = DataGridViewTriState.True;
			this.proorder.SortMode = DataGridViewColumnSortMode.NotSortable;
			this.proorder.Visible = false;
			this.proorder.Width = 100;
			this.defenceup.HeaderText = "上移";
			this.defenceup.Name = "defenceup";
			this.defenceup.Resizable = DataGridViewTriState.True;
			this.defenceup.Width = 45;
			this.defencedown.HeaderText = "下移";
			this.defencedown.Name = "defencedown";
			this.defencedown.Resizable = DataGridViewTriState.True;
			this.defencedown.Width = 45;
			this.defencedelete.HeaderText = "删除";
			this.defencedelete.Name = "defencedelete";
			this.defencedelete.Resizable = DataGridViewTriState.True;
			this.defencedelete.Width = 45;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			//base.AutoScaleMode = AutoScaleMode.Font;
			base.Controls.Add(this.tableLayoutPanel12);
			base.Name = "frmNDProject";
			base.Size = new Size(1029, 569);
			base.Leave += new EventHandler(this.frmNDProject_Leave);
			this.tableLayoutPanel12.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			((ISupportInitialize)this.kryptonPanel27).EndInit();
			this.kryptonPanel27.ResumeLayout(false);
			this.kryptonPanel27.PerformLayout();
			((ISupportInitialize)this.dproject).EndInit();
			base.ResumeLayout(false);
		}

		public frmNDProject()
		{
			this.InitializeComponent();
		}

		protected override void OnLoad(EventArgs e)
		{
			this.RefreshCall();
			base.OnLoad(e);
		}

		private void LoadData(IList<NDProject> list)
		{
			this.dproject.Rows.Clear();
			foreach (NDProject current in list)
			{
				DataGridViewRow dataGridViewRow = new DataGridViewRow();
				int rowIndex = this.dproject.Rows.Add(dataGridViewRow);
				this.dproject["defenceid", rowIndex].Value = current.NDProjectNo;
				DateTime dateTime;
				if (current.NDProjectSYear != string.Empty && DateTime.TryParse(current.NDProjectSYear, out dateTime))
				{
					this.dproject["defencestartdate", rowIndex].Value = dateTime;
				}
				else
				{
					this.dproject["defencestartdate", rowIndex].Value = DBNull.Value;
				}
				if (current.NDProjectEYear != string.Empty && DateTime.TryParse(current.NDProjectEYear, out dateTime))
				{
					this.dproject["defenceenddate", rowIndex].Value = dateTime;
				}
				else
				{
					this.dproject["defenceenddate", rowIndex].Value = DBNull.Value;
				}
				this.dproject["defencename", rowIndex].Value = current.NDProjectName;
				this.dproject["defencesource", rowIndex].Value = current.NDProjectSource;
				this.dproject["defencefee", rowIndex].Value = current.NDProjectOutlay;
				this.dproject["defencemaintask", rowIndex].Value = current.NDProjectTaskBySelf;
				this.dproject["defenceorder", rowIndex].Value = current.NDProjectUserOrder;
				this.dproject["proorder", rowIndex].Value = current.NDProjectOrder;
			}
		}

		private void dproject_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			int columnIndex = e.ColumnIndex;
			int rowIndex = e.RowIndex;
			if (rowIndex == -1)
			{
				return;
			}
			if (this.dproject.Columns[columnIndex].Name == "defenceup")
			{
				if (rowIndex == 0 || rowIndex == this.dproject.RowCount - 1)
				{
					return;
				}
				DataGridViewRow dataGridViewRow = this.dproject.Rows[rowIndex];
				this.dproject.Rows.Remove(dataGridViewRow);
				this.dproject.Rows.Insert(rowIndex - 1, dataGridViewRow);
				this.dproject.ClearSelection();
				return;
			}
			else
			{
				if (!(this.dproject.Columns[columnIndex].Name == "defencedown"))
				{
					if (this.dproject.Columns[columnIndex].Name == "defencedelete")
					{
						if (rowIndex == this.dproject.RowCount - 1)
						{
							return;
						}
						DataGridViewRow dataGridViewRow2 = this.dproject.Rows[rowIndex];
						if (dataGridViewRow2.Cells["defenceid"].Value != null)
						{
							this._deletedNo.Add(dataGridViewRow2.Cells["defenceid"].Value.ToString());
							this._nDProjectService.DeleteNDProjects(this._deletedNo);
							this._deletedNo.Clear();
						}
						this.dproject.Rows.Remove(dataGridViewRow2);
						this.dproject.ClearSelection();
					}
					return;
				}
				if (rowIndex >= this.dproject.RowCount - 2)
				{
					return;
				}
				DataGridViewRow dataGridViewRow3 = this.dproject.Rows[rowIndex];
				this.dproject.Rows.Remove(dataGridViewRow3);
				this.dproject.Rows.Insert(rowIndex + 1, dataGridViewRow3);
				this.dproject.ClearSelection();
				return;
			}
		}

		private void btnrefresh_Click(object sender, EventArgs e)
		{
			this._deletedNo.Clear();
			IList<NDProject> nDProject = this._nDProjectService.GetNDProject();
			this.LoadData(nDProject);
		}

		private bool SaveProgress()
		{
			this.OnSaveCheckDenyEvent(EventArgs.Empty);
			IList<NDProject> list = new List<NDProject>();
			for (int i = 0; i < this.dproject.RowCount - 1; i++)
			{
				DataGridViewRow dataGridViewRow = this.dproject.Rows[i];
				NDProject nDProject = new NDProject();
				nDProject.NDProjectNo = ((dataGridViewRow.Cells["defenceid"].Value == null) ? "" : dataGridViewRow.Cells["defenceid"].Value.ToString());
				nDProject.NDProjectSYear = ((dataGridViewRow.Cells["defencestartdate"].Value == null || dataGridViewRow.Cells["defencestartdate"].Value == DBNull.Value || dataGridViewRow.Cells["defencestartdate"].Value.ToString() == "") ? "" : ((DateTime)dataGridViewRow.Cells["defencestartdate"].Value).ToString("yyyy-MM-dd"));
				nDProject.NDProjectEYear = ((dataGridViewRow.Cells["defenceenddate"].Value == null || dataGridViewRow.Cells["defenceenddate"].Value == DBNull.Value || dataGridViewRow.Cells["defenceenddate"].Value.ToString() == "") ? "" : ((DateTime)dataGridViewRow.Cells["defenceenddate"].Value).ToString("yyyy-MM-dd"));
				nDProject.NDProjectName = ((dataGridViewRow.Cells["defencename"].Value == null || dataGridViewRow.Cells["defencename"].Value == DBNull.Value) ? "" : dataGridViewRow.Cells["defencename"].Value.ToString());
				nDProject.NDProjectSource = ((dataGridViewRow.Cells["defencesource"].Value == null || dataGridViewRow.Cells["defencesource"].Value == DBNull.Value) ? "" : dataGridViewRow.Cells["defencesource"].Value.ToString());
				nDProject.NDProjectOutlay = ((dataGridViewRow.Cells["defencefee"].Value == null || dataGridViewRow.Cells["defencefee"].Value == DBNull.Value) ? "" : dataGridViewRow.Cells["defencefee"].Value.ToString());
				nDProject.NDProjectTaskBySelf = ((dataGridViewRow.Cells["defencemaintask"].Value == null || dataGridViewRow.Cells["defencemaintask"].Value == DBNull.Value) ? "" : dataGridViewRow.Cells["defencemaintask"].Value.ToString());
				nDProject.NDProjectUserOrder = ((dataGridViewRow.Cells["defenceorder"].Value == null || dataGridViewRow.Cells["defenceorder"].Value == DBNull.Value) ? "" : dataGridViewRow.Cells["defenceorder"].Value.ToString());
				nDProject.NDProjectSource = ((dataGridViewRow.Cells["defencesource"].Value == null || dataGridViewRow.Cells["defencesource"].Value == DBNull.Value) ? "" : dataGridViewRow.Cells["defencesource"].Value.ToString());
				nDProject.NDProjectOrder = this.dproject.RowCount - i;
				if (nDProject.NDProjectName == "" || nDProject.NDProjectSYear == "" || nDProject.NDProjectOutlay == "" || nDProject.NDProjectUserOrder == "" || nDProject.NDProjectTaskBySelf == "")
				{
					MessageBox.Show("项目名称、开始年月，经费、主要承担任务、排名为必填字段，检测到部分字段未填写完整", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return false;
				}
				decimal num;
				if (!decimal.TryParse(nDProject.NDProjectOutlay, out num))
				{
					MessageBox.Show("录入的经费有非数值数据", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return false;
				}
				DateTime.Parse(nDProject.NDProjectSYear);
				list.Add(nDProject);
			}
			if (list.Count > 10)
			{
				MessageBox.Show("录入的国防相关代表性项目记录条数超过10条", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return false;
			}
			this.OnSaveCheckPassedEvent(EventArgs.Empty);
			this._nDProjectService.UpdateNDProjects(list);
			list = this._nDProjectService.GetNDProject();
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

		private void dproject_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
		{
            this.dproject["defenceup", e.RowIndex].Value = global::Properties.Resource.UP_16;
            this.dproject["defencedown", e.RowIndex].Value = global::Properties.Resource.DOWN_16;
            this.dproject["defencedelete", e.RowIndex].Value = global::Properties.Resource.DELETE_28;
		}

		public override void RefreshCall()
		{
			IList<NDProject> nDProject = this._nDProjectService.GetNDProject();
			this.LoadData(nDProject);
		}

		private void frmNDProject_Leave(object sender, EventArgs e)
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
