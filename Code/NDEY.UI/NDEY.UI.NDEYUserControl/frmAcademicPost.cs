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
	public class frmAcademicPost : BaseControl
	{
		private AcademicPostService _academicPostService = new AcademicPostService();

		private IList<string> _deletedNo = new List<string>();

		private bool issaved;

		private IContainer components;

		private TableLayoutPanel tableLayoutPanel10;

		private KryptonPanel kryptonPanel25;

		private KryptonLabel kryptonLabel113;

		private KryptonDataGridView daca;

		private TableLayoutPanel tableLayoutPanel1;

		private KryptonButton btnsave;

		private KryptonButton btnnext;

		private KryptonDataGridViewTextBoxColumn academicjobid;

		private CalendarColumnYM academicjobstartdate;

		private CalendarColumnYM academicjobenddate;

		private KryptonDataGridViewTextBoxColumn academicjoborg;

		private KryptonDataGridViewTextBoxColumn academicjobposition;

		private DataGridViewImageColumn academicjobup;

		private DataGridViewImageColumn academicjobdown;

		private DataGridViewImageColumn academicjobdelete;

		private DataGridViewTextBoxColumn cacaOrder;

		public frmAcademicPost()
		{
			this.InitializeComponent();
		}

		protected override void OnLoad(EventArgs e)
		{
			this.RefreshCall();
			base.OnLoad(e);
		}

		public override void RefreshCall()
		{
			IList<AcademicPost> academicPostList = this._academicPostService.GetAcademicPostList();
			this.LoadData(academicPostList);
		}

		private void LoadData(IList<AcademicPost> list)
		{
			this.daca.Rows.Clear();
			foreach (AcademicPost current in list)
			{
				DataGridViewRow dataGridViewRow = new DataGridViewRow();
				int rowIndex = this.daca.Rows.Add(dataGridViewRow);
				this.daca["academicjobid", rowIndex].Value = current.AcademicPostNo;
				DateTime dateTime;
				if (current.AcademicPostSDate != string.Empty && DateTime.TryParse(current.AcademicPostSDate, out dateTime))
				{
					this.daca["academicjobstartdate", rowIndex].Value = dateTime;
				}
				else
				{
					this.daca["academicjobstartdate", rowIndex].Value = DBNull.Value;
				}
				if (current.AcademicPostEDate != string.Empty && DateTime.TryParse(current.AcademicPostEDate, out dateTime))
				{
					this.daca["academicjobenddate", rowIndex].Value = dateTime;
				}
				else
				{
					this.daca["academicjobenddate", rowIndex].Value = DBNull.Value;
				}
				this.daca["academicjoborg", rowIndex].Value = current.AcademicPostOrg;
				this.daca["academicjobposition", rowIndex].Value = current.AcademicPostContent;
				this.daca["cacaOrder", rowIndex].Value = current.AcademicPostOrder;
			}
		}

		private void daca_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			int columnIndex = e.ColumnIndex;
			int rowIndex = e.RowIndex;
			if (rowIndex == -1)
			{
				return;
			}
			if (this.daca.Columns[columnIndex].Name == "academicjobup")
			{
				if (rowIndex == 0 || rowIndex == this.daca.RowCount - 1)
				{
					return;
				}
				DataGridViewRow dataGridViewRow = this.daca.Rows[rowIndex];
				this.daca.Rows.Remove(dataGridViewRow);
				this.daca.Rows.Insert(rowIndex - 1, dataGridViewRow);
				this.daca.ClearSelection();
				return;
			}
			else
			{
				if (!(this.daca.Columns[columnIndex].Name == "academicjobdown"))
				{
					if (this.daca.Columns[columnIndex].Name == "academicjobdelete")
					{
						if (rowIndex == this.daca.RowCount - 1)
						{
							return;
						}
						DataGridViewRow dataGridViewRow2 = this.daca.Rows[rowIndex];
						if (dataGridViewRow2.Cells["academicjobid"].Value != null)
						{
							this._deletedNo.Add(dataGridViewRow2.Cells["academicjobid"].Value.ToString());
							this._academicPostService.DeleteAcademicPosts(this._deletedNo);
							this._deletedNo.Clear();
						}
						this.daca.Rows.Remove(dataGridViewRow2);
						this.daca.ClearSelection();
					}
					return;
				}
				if (rowIndex >= this.daca.RowCount - 2)
				{
					return;
				}
				DataGridViewRow dataGridViewRow3 = this.daca.Rows[rowIndex];
				this.daca.Rows.Remove(dataGridViewRow3);
				this.daca.Rows.Insert(rowIndex + 1, dataGridViewRow3);
				this.daca.ClearSelection();
				return;
			}
		}

		private void btnrefresh_Click(object sender, EventArgs e)
		{
			this._deletedNo.Clear();
			IList<AcademicPost> academicPostList = this._academicPostService.GetAcademicPostList();
			this.LoadData(academicPostList);
		}

		private bool SaveProgress()
		{
			this.OnSaveCheckDenyEvent(EventArgs.Empty);
			IList<AcademicPost> list = new List<AcademicPost>();
			for (int i = 0; i < this.daca.RowCount - 1; i++)
			{
				DataGridViewRow dataGridViewRow = this.daca.Rows[i];
				AcademicPost academicPost = new AcademicPost();
				academicPost.AcademicPostNo = ((dataGridViewRow.Cells["academicjobid"].Value == null) ? "" : dataGridViewRow.Cells["academicjobid"].Value.ToString());
				academicPost.AcademicPostSDate = ((dataGridViewRow.Cells["academicjobstartdate"].Value == null || dataGridViewRow.Cells["academicjobstartdate"].Value == DBNull.Value || dataGridViewRow.Cells["academicjobstartdate"].Value.ToString() == "") ? "" : ((DateTime)dataGridViewRow.Cells["academicjobstartdate"].Value).ToString("yyyy-MM-dd"));
				academicPost.AcademicPostEDate = ((dataGridViewRow.Cells["academicjobenddate"].Value == null || dataGridViewRow.Cells["academicjobenddate"].Value == DBNull.Value || dataGridViewRow.Cells["academicjobenddate"].Value.ToString() == "") ? "" : ((DateTime)dataGridViewRow.Cells["academicjobenddate"].Value).ToString("yyyy-MM-dd"));
				academicPost.AcademicPostOrg = ((dataGridViewRow.Cells["academicjoborg"].Value == null || dataGridViewRow.Cells["academicjoborg"].Value == DBNull.Value) ? "" : dataGridViewRow.Cells["academicjoborg"].Value.ToString());
				academicPost.AcademicPostContent = ((dataGridViewRow.Cells["academicjobposition"].Value == null || dataGridViewRow.Cells["academicjobposition"].Value == DBNull.Value) ? "" : dataGridViewRow.Cells["academicjobposition"].Value.ToString());
				academicPost.AcademicPostOrder = this.daca.RowCount - i;
				if (academicPost.AcademicPostSDate == "" || academicPost.AcademicPostOrg == "" || academicPost.AcademicPostContent == "")
				{
					MessageBox.Show("开始年月、组织/机构、任职情况为必填字段，检测到部分字段未填写完整", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return false;
				}
				list.Add(academicPost);
			}
			this.OnSaveCheckPassedEvent(EventArgs.Empty);
			this._academicPostService.UpdateAcademicPosts(list);
			list = this._academicPostService.GetAcademicPostList();
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

		private void daca_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
		{
            this.daca["academicjobup", e.RowIndex].Value = global::Properties.Resource.UP_16;
            this.daca["academicjobdown", e.RowIndex].Value = global::Properties.Resource.DOWN_16;
            this.daca["academicjobdelete", e.RowIndex].Value = global::Properties.Resource.DELETE_28;
		}

		private void frmAcademicPost_Leave(object sender, EventArgs e)
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
			this.tableLayoutPanel10 = new TableLayoutPanel();
			this.tableLayoutPanel1 = new TableLayoutPanel();
			this.btnnext = new KryptonButton();
			this.btnsave = new KryptonButton();
			this.kryptonPanel25 = new KryptonPanel();
			this.kryptonLabel113 = new KryptonLabel();
			this.daca = new KryptonDataGridView();
			this.academicjobid = new KryptonDataGridViewTextBoxColumn();
			this.academicjobstartdate = new CalendarColumnYM();
			this.academicjobenddate = new CalendarColumnYM();
			this.academicjoborg = new KryptonDataGridViewTextBoxColumn();
			this.academicjobposition = new KryptonDataGridViewTextBoxColumn();
			this.academicjobup = new DataGridViewImageColumn();
			this.academicjobdown = new DataGridViewImageColumn();
			this.academicjobdelete = new DataGridViewImageColumn();
			this.cacaOrder = new DataGridViewTextBoxColumn();
			this.tableLayoutPanel10.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			((ISupportInitialize)this.kryptonPanel25).BeginInit();
			this.kryptonPanel25.SuspendLayout();
			((ISupportInitialize)this.daca).BeginInit();
			base.SuspendLayout();
			this.tableLayoutPanel10.ColumnCount = 3;
			this.tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50f));
			this.tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50f));
			this.tableLayoutPanel10.Controls.Add(this.tableLayoutPanel1, 1, 3);
			this.tableLayoutPanel10.Controls.Add(this.kryptonPanel25, 1, 1);
			this.tableLayoutPanel10.Controls.Add(this.daca, 1, 2);
			this.tableLayoutPanel10.Dock = DockStyle.Fill;
			this.tableLayoutPanel10.Location = new Point(0, 0);
			this.tableLayoutPanel10.Name = "tableLayoutPanel10";
			this.tableLayoutPanel10.RowCount = 5;
			this.tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Absolute, 20f));
			this.tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Absolute, 40f));
			this.tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Absolute, 40f));
			this.tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Absolute, 20f));
			this.tableLayoutPanel10.Size = new Size(1025, 603);
			this.tableLayoutPanel10.TabIndex = 2;
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 103f));
			this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100f));
			this.tableLayoutPanel1.Controls.Add(this.btnnext, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.btnsave, 1, 0);
			this.tableLayoutPanel1.Dock = DockStyle.Fill;
			this.tableLayoutPanel1.Location = new Point(53, 546);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel1.Size = new Size(919, 34);
			this.tableLayoutPanel1.TabIndex = 5;
			this.btnnext.Location = new Point(822, 3);
			this.btnnext.Name = "btnnext";
			this.btnnext.Size = new Size(90, 25);
			this.btnnext.TabIndex = 1;
			this.btnnext.Values.Text = "下一页";
			this.btnnext.Click += new EventHandler(this.btnnext_Click);
			this.btnsave.Location = new Point(719, 3);
			this.btnsave.Name = "btnsave";
			this.btnsave.Size = new Size(90, 25);
			this.btnsave.TabIndex = 0;
			this.btnsave.Values.Text = "保存";
			this.btnsave.Click += new EventHandler(this.btnsave_Click);
			this.kryptonPanel25.Controls.Add(this.kryptonLabel113);
			this.kryptonPanel25.Dock = DockStyle.Fill;
			this.kryptonPanel25.Location = new Point(50, 20);
			this.kryptonPanel25.Margin = new Padding(0);
			this.kryptonPanel25.Name = "kryptonPanel25";
			this.kryptonPanel25.Size = new Size(925, 40);
			this.kryptonPanel25.TabIndex = 0;
			this.kryptonLabel113.Location = new Point(3, 10);
			this.kryptonLabel113.Name = "kryptonLabel113";
			this.kryptonLabel113.Size = new Size(324, 27);
			this.kryptonLabel113.StateCommon.LongText.Font = new Font("KaiTi_GB2312", 12f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.kryptonLabel113.StateCommon.ShortText.Font = new Font("SimHei", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.kryptonLabel113.TabIndex = 0;
			this.kryptonLabel113.Values.ExtraText = "（按时间倒序填写）";
			this.kryptonLabel113.Values.Text = "三、主要学术任职";
			this.daca.AllowUserToResizeRows = false;
			this.daca.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
			this.daca.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.daca.Columns.AddRange(new DataGridViewColumn[]
			{
				this.academicjobid,
				this.academicjobstartdate,
				this.academicjobenddate,
				this.academicjoborg,
				this.academicjobposition,
				this.academicjobup,
				this.academicjobdown,
				this.academicjobdelete,
				this.cacaOrder
			});
			this.daca.Dock = DockStyle.Fill;
			this.daca.Location = new Point(53, 63);
			this.daca.MultiSelect = false;
			this.daca.Name = "daca";
			dataGridViewCellStyle.Font = new Font("FangSong_GB2312", 12f, FontStyle.Regular, GraphicsUnit.Point, 134);
			dataGridViewCellStyle.WrapMode = DataGridViewTriState.True;
			this.daca.RowsDefaultCellStyle = dataGridViewCellStyle;
			this.daca.RowTemplate.Height = 28;
			this.daca.Size = new Size(919, 477);
			this.daca.StateCommon.Background.Color1 = Color.White;
			this.daca.StateCommon.BackStyle = PaletteBackStyle.GridBackgroundList;
			this.daca.StateCommon.HeaderColumn.Content.Font = new Font("SimHei", 12f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.daca.StateCommon.HeaderColumn.Content.TextH = PaletteRelativeAlign.Center;
			this.daca.TabIndex = 3;
			this.daca.CellContentClick += new DataGridViewCellEventHandler(this.daca_CellContentClick);
			this.daca.RowsAdded += new DataGridViewRowsAddedEventHandler(this.daca_RowsAdded);
			this.academicjobid.HeaderText = "id";
			this.academicjobid.Name = "academicjobid";
			this.academicjobid.SortMode = DataGridViewColumnSortMode.NotSortable;
			this.academicjobid.Visible = false;
			this.academicjobid.Width = 100;
			this.academicjobstartdate.HeaderText = "开始年月";
			this.academicjobstartdate.Name = "academicjobstartdate";
			this.academicjobstartdate.Width = 120;
			this.academicjobenddate.HeaderText = "结束年月";
			this.academicjobenddate.Name = "academicjobenddate";
			this.academicjobenddate.Width = 120;
			this.academicjoborg.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.academicjoborg.HeaderText = "组织/机构";
			this.academicjoborg.Name = "academicjoborg";
			this.academicjoborg.SortMode = DataGridViewColumnSortMode.NotSortable;
			this.academicjoborg.Width = 303;
			this.academicjobposition.HeaderText = "任职情况";
			this.academicjobposition.Name = "academicjobposition";
			this.academicjobposition.SortMode = DataGridViewColumnSortMode.NotSortable;
			this.academicjobposition.Width = 200;
			this.academicjobup.HeaderText = "上移";
			this.academicjobup.Name = "academicjobup";
			this.academicjobup.Resizable = DataGridViewTriState.True;
			this.academicjobup.Width = 45;
			this.academicjobdown.HeaderText = "下移";
			this.academicjobdown.Name = "academicjobdown";
			this.academicjobdown.Resizable = DataGridViewTriState.True;
			this.academicjobdown.Width = 45;
			this.academicjobdelete.HeaderText = "删除";
			this.academicjobdelete.Name = "academicjobdelete";
			this.academicjobdelete.Resizable = DataGridViewTriState.True;
			this.academicjobdelete.Width = 45;
			this.cacaOrder.HeaderText = "排序";
			this.cacaOrder.Name = "cacaOrder";
			this.cacaOrder.SortMode = DataGridViewColumnSortMode.NotSortable;
			this.cacaOrder.Visible = false;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			//base.AutoScaleMode = AutoScaleMode.Font;
			base.Controls.Add(this.tableLayoutPanel10);
			base.Name = "frmAcademicPost";
			base.Size = new Size(1025, 603);
			base.Leave += new EventHandler(this.frmAcademicPost_Leave);
			this.tableLayoutPanel10.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			((ISupportInitialize)this.kryptonPanel25).EndInit();
			this.kryptonPanel25.ResumeLayout(false);
			this.kryptonPanel25.PerformLayout();
			((ISupportInitialize)this.daca).EndInit();
			base.ResumeLayout(false);
		}
	}
}
