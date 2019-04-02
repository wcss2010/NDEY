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
	public class frmResumeEducation : BaseControl
	{
		private EducationInfoService _educationInfoService = new EducationInfoService();

		private IList<string> _deletedNo = new List<string>();

		private bool issaved;

		private IContainer components;

		private TableLayoutPanel tableLayoutPanel8;

		private TableLayoutPanel tableLayoutPanel1;

		private KryptonButton btnsave;

		private KryptonButton btnnext;

		private KryptonPanel kryptonPanel12;

		private KryptonLabel kryptonLabel63;

		private KryptonDataGridView deducation;

		private ButtonSpecAny buttonSpecAny1;

		private ButtonSpecAny buttonSpecAny2;

		private DataGridViewImageColumn dataGridViewImageColumn1;

		private DataGridViewImageColumn dataGridViewImageColumn2;

		private DataGridViewTextBoxColumn gridEducationNo;

		private CalendarColumnYM startdate;

		private CalendarColumnYM enddate;

		private KryptonDataGridViewTextBoxColumn school;

		private KryptonDataGridViewTextBoxColumn major;

		private KryptonDataGridViewComboBoxColumn degree;

		private KryptonDataGridViewTextBoxColumn cEducationOrder;

		private DataGridViewImageColumn up;

		private DataGridViewImageColumn down;

		private DataGridViewImageColumn delete;

		public frmResumeEducation()
		{
			this.InitializeComponent();
		}

		protected override void OnLoad(EventArgs e)
		{
			this.RefreshCall();
			base.OnLoad(e);
		}

		private void LoadData(IList<EducationInfo> list)
		{
			this.deducation.Rows.Clear();
			foreach (EducationInfo current in list)
			{
				DataGridViewRow dataGridViewRow = new DataGridViewRow();
				int rowIndex = this.deducation.Rows.Add(dataGridViewRow);
				this.deducation["gridEducationNo", rowIndex].Value = current.EducationNo;
				DateTime dateTime;
				if (current.EducationSDate != string.Empty && DateTime.TryParse(current.EducationSDate, out dateTime))
				{
					this.deducation["startdate", rowIndex].Value = dateTime;
				}
				else
				{
					this.deducation["startdate", rowIndex].Value = DBNull.Value;
				}
				if (current.EducationEDate != string.Empty && DateTime.TryParse(current.EducationEDate, out dateTime))
				{
					this.deducation["enddate", rowIndex].Value = dateTime;
				}
				else
				{
					this.deducation["enddate", rowIndex].Value = DBNull.Value;
				}
				this.deducation["school", rowIndex].Value = current.EducationOrg;
				this.deducation["major", rowIndex].Value = current.EducationMajor;
				this.deducation["degree", rowIndex].Value = current.EducationDegree;
				this.deducation["cEducationOrder", rowIndex].Value = current.EducationOrder;
			}
		}

		private void deducation_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			int columnIndex = e.ColumnIndex;
			int rowIndex = e.RowIndex;
			if (rowIndex == -1)
			{
				return;
			}
			if (this.deducation.Columns[columnIndex].Name == "up")
			{
				if (rowIndex == 0 || rowIndex == this.deducation.RowCount - 1)
				{
					return;
				}
				DataGridViewRow dataGridViewRow = this.deducation.Rows[rowIndex];
				this.deducation.Rows.Remove(dataGridViewRow);
				this.deducation.Rows.Insert(rowIndex - 1, dataGridViewRow);
				this.deducation.ClearSelection();
				return;
			}
			else
			{
				if (!(this.deducation.Columns[columnIndex].Name == "down"))
				{
					if (this.deducation.Columns[columnIndex].Name == "delete")
					{
						if (rowIndex == this.deducation.RowCount - 1)
						{
							return;
						}
						DataGridViewRow dataGridViewRow2 = this.deducation.Rows[rowIndex];
						if (dataGridViewRow2.Cells["gridEducationNo"].Value != null)
						{
							this._deletedNo.Add(dataGridViewRow2.Cells["gridEducationNo"].Value.ToString());
							this._educationInfoService.DeleteEducations(this._deletedNo);
							this._deletedNo.Clear();
						}
						this.deducation.Rows.Remove(dataGridViewRow2);
						this.deducation.ClearSelection();
					}
					return;
				}
				if (rowIndex >= this.deducation.RowCount - 2)
				{
					return;
				}
				DataGridViewRow dataGridViewRow3 = this.deducation.Rows[rowIndex];
				this.deducation.Rows.Remove(dataGridViewRow3);
				this.deducation.Rows.Insert(rowIndex + 1, dataGridViewRow3);
				this.deducation.ClearSelection();
				return;
			}
		}

		private bool SaveProgress()
		{
			this.OnSaveCheckDenyEvent(EventArgs.Empty);
			IList<EducationInfo> list = new List<EducationInfo>();
			for (int i = 0; i < this.deducation.RowCount - 1; i++)
			{
				DataGridViewRow dataGridViewRow = this.deducation.Rows[i];
				EducationInfo educationInfo = new EducationInfo();
				educationInfo.EducationNo = ((dataGridViewRow.Cells["gridEducationNo"].Value == null) ? "" : dataGridViewRow.Cells["gridEducationNo"].Value.ToString());
				educationInfo.EducationSDate = ((dataGridViewRow.Cells["startdate"].Value == null || dataGridViewRow.Cells["startdate"].Value == DBNull.Value || dataGridViewRow.Cells["startdate"].Value.ToString() == "") ? "" : ((DateTime)dataGridViewRow.Cells["startdate"].Value).ToString("yyyy-MM-dd"));
				educationInfo.EducationEDate = ((dataGridViewRow.Cells["enddate"].Value == null || dataGridViewRow.Cells["enddate"].Value == DBNull.Value || dataGridViewRow.Cells["enddate"].Value.ToString() == "") ? "" : ((DateTime)dataGridViewRow.Cells["enddate"].Value).ToString("yyyy-MM-dd"));
				educationInfo.EducationOrg = ((dataGridViewRow.Cells["school"].Value == null || dataGridViewRow.Cells["school"].Value == DBNull.Value) ? "" : dataGridViewRow.Cells["school"].Value.ToString());
				educationInfo.EducationMajor = ((dataGridViewRow.Cells["major"].Value == null || dataGridViewRow.Cells["major"].Value == DBNull.Value) ? "" : dataGridViewRow.Cells["major"].Value.ToString());
				educationInfo.EducationDegree = ((dataGridViewRow.Cells["degree"].Value == null || dataGridViewRow.Cells["degree"].Value == DBNull.Value) ? "" : dataGridViewRow.Cells["degree"].Value.ToString());
				educationInfo.EducationOrder = this.deducation.RowCount - i;
				if (educationInfo.EducationSDate == "" || educationInfo.EducationOrg == "" || educationInfo.EducationMajor == "" || educationInfo.EducationDegree == "")
				{
					MessageBox.Show("开始年月、校（院）及系名称、专业、学位为必填字段，检测到部分字段未填写完整", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return false;
				}
				list.Add(educationInfo);
			}
			this.OnSaveCheckPassedEvent(EventArgs.Empty);
			this._educationInfoService.UpdateEducations(list);
			list = this._educationInfoService.GetEducationList();
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

		private void btnrefresh_Click(object sender, EventArgs e)
		{
		}

		private void deducation_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
		{
            this.deducation["up", e.RowIndex].Value = global::Properties.Resource.UP_16;
            this.deducation["down", e.RowIndex].Value = global::Properties.Resource.DOWN_16;
            this.deducation["delete", e.RowIndex].Value = global::Properties.Resource.DELETE_28;
		}

		public override void RefreshCall()
		{
			IList<EducationInfo> educationList = this._educationInfoService.GetEducationList();
			this.LoadData(educationList);
		}

		private void frmresume_education_Leave(object sender, EventArgs e)
		{
			if (this.issaved)
			{
				this.issaved = false;
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
			DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmResumeEducation));
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			this.buttonSpecAny1 = new ButtonSpecAny();
			this.dataGridViewImageColumn1 = new DataGridViewImageColumn();
			this.dataGridViewImageColumn2 = new DataGridViewImageColumn();
			this.buttonSpecAny2 = new ButtonSpecAny();
			this.tableLayoutPanel8 = new TableLayoutPanel();
			this.tableLayoutPanel1 = new TableLayoutPanel();
			this.btnnext = new KryptonButton();
			this.btnsave = new KryptonButton();
			this.kryptonPanel12 = new KryptonPanel();
			this.kryptonLabel63 = new KryptonLabel();
			this.deducation = new KryptonDataGridView();
			this.gridEducationNo = new DataGridViewTextBoxColumn();
			this.startdate = new CalendarColumnYM();
			this.enddate = new CalendarColumnYM();
			this.school = new KryptonDataGridViewTextBoxColumn();
			this.major = new KryptonDataGridViewTextBoxColumn();
			this.degree = new KryptonDataGridViewComboBoxColumn();
			this.cEducationOrder = new KryptonDataGridViewTextBoxColumn();
			this.up = new DataGridViewImageColumn();
			this.down = new DataGridViewImageColumn();
			this.delete = new DataGridViewImageColumn();
			this.tableLayoutPanel8.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			((ISupportInitialize)this.kryptonPanel12).BeginInit();
			this.kryptonPanel12.SuspendLayout();
			((ISupportInitialize)this.deducation).BeginInit();
			base.SuspendLayout();
			this.buttonSpecAny1.Checked = ButtonCheckState.Checked;
			this.buttonSpecAny1.UniqueName = "B0FAED16E99144A6DFA183F6DCF8CE59";
			dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle.NullValue = componentResourceManager.GetObject("dataGridViewCellStyle1.NullValue");
			dataGridViewCellStyle.WrapMode = DataGridViewTriState.True;
			this.dataGridViewImageColumn1.DefaultCellStyle = dataGridViewCellStyle;
			this.dataGridViewImageColumn1.HeaderText = "上移";
			this.dataGridViewImageColumn1.Image = (Image)componentResourceManager.GetObject("dataGridViewImageColumn1.Image");
			this.dataGridViewImageColumn1.ImageLayout = DataGridViewImageCellLayout.Zoom;
			this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
			this.dataGridViewImageColumn1.Resizable = DataGridViewTriState.True;
			this.dataGridViewImageColumn1.Width = 40;
			this.dataGridViewImageColumn2.HeaderText = "下移";
            this.dataGridViewImageColumn2.Image = global::Properties.Resource.DOWN_16;
			this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
			this.dataGridViewImageColumn2.Resizable = DataGridViewTriState.True;
			this.dataGridViewImageColumn2.Width = 40;
			this.buttonSpecAny2.Checked = ButtonCheckState.Checked;
			this.buttonSpecAny2.Image = (Image)componentResourceManager.GetObject("buttonSpecAny2.Image");
			this.buttonSpecAny2.UniqueName = "2B39AF5966CA492620ACC03F8654CCBE";
			this.tableLayoutPanel8.ColumnCount = 3;
			this.tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50f));
			this.tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50f));
			this.tableLayoutPanel8.Controls.Add(this.tableLayoutPanel1, 1, 3);
			this.tableLayoutPanel8.Controls.Add(this.kryptonPanel12, 1, 1);
			this.tableLayoutPanel8.Controls.Add(this.deducation, 1, 2);
			this.tableLayoutPanel8.Dock = DockStyle.Fill;
			this.tableLayoutPanel8.Location = new Point(0, 0);
			this.tableLayoutPanel8.Name = "tableLayoutPanel8";
			this.tableLayoutPanel8.RowCount = 5;
			this.tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Absolute, 20f));
			this.tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Absolute, 40f));
			this.tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Absolute, 40f));
			this.tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Absolute, 20f));
			this.tableLayoutPanel8.Size = new Size(1008, 553);
			this.tableLayoutPanel8.TabIndex = 1;
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 103f));
			this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100f));
			this.tableLayoutPanel1.Controls.Add(this.btnnext, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.btnsave, 1, 0);
			this.tableLayoutPanel1.Dock = DockStyle.Fill;
			this.tableLayoutPanel1.Location = new Point(53, 496);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel1.Size = new Size(902, 34);
			this.tableLayoutPanel1.TabIndex = 3;
			this.btnnext.Location = new Point(805, 3);
			this.btnnext.Name = "btnnext";
			this.btnnext.Size = new Size(90, 25);
			this.btnnext.TabIndex = 1;
			this.btnnext.Values.Text = "下一页";
			this.btnnext.Click += new EventHandler(this.btnnext_Click);
			this.btnsave.Location = new Point(702, 3);
			this.btnsave.Name = "btnsave";
			this.btnsave.Size = new Size(90, 25);
			this.btnsave.TabIndex = 0;
			this.btnsave.Values.Text = "保存";
			this.btnsave.Click += new EventHandler(this.btnsave_Click);
			this.kryptonPanel12.Controls.Add(this.kryptonLabel63);
			this.kryptonPanel12.Dock = DockStyle.Fill;
			this.kryptonPanel12.Location = new Point(50, 20);
			this.kryptonPanel12.Margin = new Padding(0);
			this.kryptonPanel12.Name = "kryptonPanel12";
			this.kryptonPanel12.Size = new Size(908, 40);
			this.kryptonPanel12.TabIndex = 0;
			this.kryptonLabel63.Location = new Point(0, 10);
			this.kryptonLabel63.Name = "kryptonLabel63";
			this.kryptonLabel63.Size = new Size(417, 27);
			this.kryptonLabel63.StateCommon.LongText.Font = new Font("KaiTi_GB2312", 12f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.kryptonLabel63.StateCommon.ShortText.Font = new Font("SimHei", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.kryptonLabel63.TabIndex = 0;
			this.kryptonLabel63.Values.ExtraText = "（从大学教育填起，按时间倒序填写）";
			this.kryptonLabel63.Values.Text = "一、教育经历";
			this.deducation.AllowUserToResizeRows = false;
			this.deducation.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
			this.deducation.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.deducation.Columns.AddRange(new DataGridViewColumn[]
			{
				this.gridEducationNo,
				this.startdate,
				this.enddate,
				this.school,
				this.major,
				this.degree,
				this.cEducationOrder,
				this.up,
				this.down,
				this.delete
			});
			this.deducation.Dock = DockStyle.Fill;
			this.deducation.Location = new Point(53, 63);
			this.deducation.MultiSelect = false;
			this.deducation.Name = "deducation";
			dataGridViewCellStyle2.Font = new Font("FangSong_GB2312", 12f, FontStyle.Regular, GraphicsUnit.Point, 134);
			dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
			this.deducation.RowsDefaultCellStyle = dataGridViewCellStyle2;
			this.deducation.RowTemplate.Height = 28;
			this.deducation.RowTemplate.Resizable = DataGridViewTriState.False;
			this.deducation.Size = new Size(902, 427);
			this.deducation.StateCommon.Background.Color1 = Color.White;
			this.deducation.StateCommon.BackStyle = PaletteBackStyle.GridBackgroundList;
			this.deducation.StateCommon.HeaderColumn.Content.Font = new Font("SimHei", 12f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.deducation.StateCommon.HeaderColumn.Content.TextH = PaletteRelativeAlign.Center;
			this.deducation.TabIndex = 1;
			this.deducation.CellContentClick += new DataGridViewCellEventHandler(this.deducation_CellContentClick);
			this.deducation.RowsAdded += new DataGridViewRowsAddedEventHandler(this.deducation_RowsAdded);
			this.gridEducationNo.HeaderText = "";
			this.gridEducationNo.Name = "gridEducationNo";
			this.gridEducationNo.Visible = false;
			this.startdate.HeaderText = "开始年月";
			this.startdate.Name = "startdate";
			this.startdate.Width = 120;
			this.enddate.HeaderText = "结束年月";
			this.enddate.Name = "enddate";
			this.enddate.Width = 120;
			this.school.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.school.HeaderText = "校（院）及系名称";
			this.school.MinimumWidth = 156;
			this.school.Name = "school";
			this.school.Resizable = DataGridViewTriState.True;
			this.school.SortMode = DataGridViewColumnSortMode.NotSortable;
			this.school.Width = 156;
			this.major.HeaderText = "专业";
			this.major.Name = "major";
			this.major.Resizable = DataGridViewTriState.True;
			this.major.SortMode = DataGridViewColumnSortMode.NotSortable;
			this.major.Width = 180;
			this.degree.DropDownStyle = ComboBoxStyle.DropDownList;
			this.degree.DropDownWidth = 121;
			this.degree.HeaderText = "学位";
			this.degree.Items.AddRange(new string[]
			{
				"博士",
				"硕士",
				"学士",
				"无学位"
			});
			this.degree.Name = "degree";
			this.degree.Resizable = DataGridViewTriState.True;
			this.degree.Width = 150;
			this.cEducationOrder.HeaderText = "排序";
			this.cEducationOrder.Name = "cEducationOrder";
			this.cEducationOrder.SortMode = DataGridViewColumnSortMode.NotSortable;
			this.cEducationOrder.Visible = false;
			this.cEducationOrder.Width = 100;
			dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.NullValue = componentResourceManager.GetObject("dataGridViewCellStyle2.NullValue");
			dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
			this.up.DefaultCellStyle = dataGridViewCellStyle3;
			this.up.HeaderText = "上移";
            this.up.Image = global::Properties.Resource.UP_16;
			this.up.Name = "up";
			this.up.Resizable = DataGridViewTriState.True;
			this.up.Width = 45;
			this.down.HeaderText = "下移";
            this.down.Image = global::Properties.Resource.DOWN_16;
			this.down.Name = "down";
			this.down.Resizable = DataGridViewTriState.True;
			this.down.Width = 45;
			this.delete.HeaderText = "删除";
            this.delete.Image = global::Properties.Resource.DELETE_16;
			this.delete.Name = "delete";
			this.delete.Resizable = DataGridViewTriState.True;
			this.delete.Width = 45;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			//base.AutoScaleMode = AutoScaleMode.Font;
			base.Controls.Add(this.tableLayoutPanel8);
			base.Name = "frmresume_education";
			base.Size = new Size(1008, 553);
			base.Leave += new EventHandler(this.frmresume_education_Leave);
			this.tableLayoutPanel8.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			((ISupportInitialize)this.kryptonPanel12).EndInit();
			this.kryptonPanel12.ResumeLayout(false);
			this.kryptonPanel12.PerformLayout();
			((ISupportInitialize)this.deducation).EndInit();
			base.ResumeLayout(false);
		}
	}
}
