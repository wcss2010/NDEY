using ComponentFactory.Krypton.Navigator;
using ComponentFactory.Krypton.Toolkit;
using NDEY.BLL.Entity;
using NDEY.BLL.Service;
using NDEY.UI.Properties;
using NDEY.UI.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace NDEY.UI.NDEYUserControl
{
	public class frmTechnologyAwards : BaseControl
	{
		private TechnologyAwardsService _technologyAwardsService = new TechnologyAwardsService();

		private IList<string> _deletedNo = new List<string>();

		private bool issaved;

		private IContainer components;

		private TableLayoutPanel tableLayoutPanel14;

		private KryptonPanel kryptonPanel29;

		private KryptonLabel kryptonLabel117;

		private KryptonDataGridView dTechnologyAwards;

		private TableLayoutPanel tableLayoutPanel1;

		private KryptonButton btnsave;

		private KryptonButton btnnext;
        private DataGridViewTextBoxColumn scienceid;
        private DataGridViewTextBoxColumn sciencename;
        private KryptonDataGridViewButtonColumn sciencelevel;
        private KryptonDataGridViewNumericUpDownColumn sciencedate;
        private KryptonDataGridViewTextBoxColumn scienceorder;
        private DataGridViewImageColumn scienceattup;
        private KryptonDataGridViewLinkColumn scienceattainfo;
        private DataGridViewTextBoxColumn hiddenStoreName;
        private DataGridViewTextBoxColumn UpLoadFullyName;
        private DataGridViewImageColumn scienceup;
        private DataGridViewImageColumn sciencedown;
        private DataGridViewImageColumn sciencedelete;
        private DataGridViewTextBoxColumn tecOrder;
        private KryptonLabel kryptonLabel1;

		public frmTechnologyAwards()
		{
			this.InitializeComponent();
		}

		protected override void OnLoad(EventArgs e)
		{
			this.RefreshCall();
			base.OnLoad(e);
		}

		private void LoadData(IList<TechnologyAwards> list)
		{
			this.dTechnologyAwards.Rows.Clear();
			foreach (TechnologyAwards current in list)
			{
				DataGridViewRow dataGridViewRow = new DataGridViewRow();
				int rowIndex = this.dTechnologyAwards.Rows.Add(dataGridViewRow);
				this.dTechnologyAwards["scienceid", rowIndex].Value = current.TechnologyAwardsNo;
				this.dTechnologyAwards["sciencename", rowIndex].Value = current.TechnologyAwardsPName;
				this.dTechnologyAwards["sciencelevel", rowIndex].Value = current.TechnologyAwardsTypeLevel;
				this.dTechnologyAwards["sciencedate", rowIndex].Value = current.TechnologyAwardsYear;
				this.dTechnologyAwards["scienceorder", rowIndex].Value = current.TechnologyAwardsee;
				this.dTechnologyAwards["scienceattainfo", rowIndex].Value = current.TechnologyAwardsPDFOName;
				this.dTechnologyAwards["hiddenStoreName", rowIndex].Value = current.TechnologyAwardsPDF;
				this.dTechnologyAwards["UpLoadFullyName", rowIndex].Value = "";
				this.dTechnologyAwards["tecOrder", rowIndex].Value = current.TechnologyAwardsOrder;
			}
		}

		private void dTechnologyAwards_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
            if (e.ColumnIndex == 2)
            {
                frmSuperComboboxForm scf = new frmSuperComboboxForm();
                scf.Text = "请选择奖励类别及等级！";
                List<string> list = new List<string>();
                list.Add("国家最高科技技术奖");
                list.Add("国家科学技术进步奖特等奖");
                list.Add("国家科学技术进步奖一等奖");
                list.Add("国家科学技术进步奖二等奖");
                list.Add("国家自然科学奖一等奖");
                list.Add("国家自然科学奖二等奖");
                list.Add("国家技术发明奖一等奖");
                list.Add("国家技术发明奖二等奖");
                list.Add("国防科学技术进步奖特等奖");
                list.Add("国防科学技术进步奖一等奖");
                list.Add("国防科学技术进步奖二等奖");
                list.Add("国防技术发明特等奖");
                list.Add("国防技术发明一等奖");
                list.Add("国防技术发明二等奖");
                list.Add("军队科学技术进步一等奖");
                list.Add("军队科学技术进步二等奖");
                list.Add("军队技术侦查成果奖一等奖");
                list.Add("军队技术侦查成果奖二等奖");
                list.Add("军队教学成果一等奖");
                list.Add("军队教学成果二等奖");
                list.Add("军队医疗成果一等奖");
                list.Add("军队医疗成果二等奖");
                scf.InitComboboxList(list.ToArray());
                scf.SelectItem(this.dTechnologyAwards.Rows[e.RowIndex].Cells[2].Value != null ? this.dTechnologyAwards.Rows[e.RowIndex].Cells[2].Value.ToString() : string.Empty);
                if (scf.ShowDialog() == DialogResult.OK)
                {
                    this.dTechnologyAwards.Rows[e.RowIndex].Cells[2].Value = scf.SelectedItem;
                }
            }

			int columnIndex = e.ColumnIndex;
			int rowIndex = e.RowIndex;
			if (rowIndex == -1)
			{
				return;
			}
			if (this.dTechnologyAwards.Columns[columnIndex].Name == "scienceup")
			{
				if (rowIndex == 0 || rowIndex == this.dTechnologyAwards.RowCount - 1)
				{
					return;
				}
				DataGridViewRow dataGridViewRow = this.dTechnologyAwards.Rows[rowIndex];
				this.dTechnologyAwards.Rows.Remove(dataGridViewRow);
				this.dTechnologyAwards.Rows.Insert(rowIndex - 1, dataGridViewRow);
				this.dTechnologyAwards.ClearSelection();
				return;
			}
			else if (this.dTechnologyAwards.Columns[columnIndex].Name == "sciencedown")
			{
				if (rowIndex >= this.dTechnologyAwards.RowCount - 2)
				{
					return;
				}
				DataGridViewRow dataGridViewRow2 = this.dTechnologyAwards.Rows[rowIndex];
				this.dTechnologyAwards.Rows.Remove(dataGridViewRow2);
				this.dTechnologyAwards.Rows.Insert(rowIndex + 1, dataGridViewRow2);
				this.dTechnologyAwards.ClearSelection();
				return;
			}
			else
			{
				if (!(this.dTechnologyAwards.Columns[columnIndex].Name == "sciencedelete"))
				{
					if (this.dTechnologyAwards.Columns[columnIndex].Name == "scienceattup")
					{
						OpenFileDialog openFileDialog = new OpenFileDialog();
						openFileDialog.Filter = "Adobe PDF 文件,JPEG图像文件|*.pdf;*.jpg;*.jpeg";
						openFileDialog.Multiselect = false;
						if (openFileDialog.ShowDialog() == DialogResult.OK)
						{
							this.dTechnologyAwards["scienceattainfo", rowIndex].Value = openFileDialog.FileName;
							this.dTechnologyAwards["UpLoadFullyName", rowIndex].Value = openFileDialog.FileName;
							return;
						}
					}
					else if (this.dTechnologyAwards.Columns[columnIndex].Name == "scienceattainfo")
					{
						if (this.dTechnologyAwards["hiddenStoreName", rowIndex].Value != null)
						{
							if (File.Exists(Path.Combine(EntityElement.FilesStorePath, this.dTechnologyAwards["hiddenStoreName", rowIndex].Value.ToString())))
							{
								FileOp.OpenFile(Path.Combine(EntityElement.FilesStorePath, this.dTechnologyAwards["hiddenStoreName", rowIndex].Value.ToString()));
								return;
							}
							MessageBox.Show("文件不存在。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
							return;
						}
						else if (this.dTechnologyAwards["UpLoadFullyName", rowIndex].Value != null)
						{
							if (File.Exists(this.dTechnologyAwards["UpLoadFullyName", rowIndex].Value.ToString()))
							{
								FileOp.OpenFile(this.dTechnologyAwards["UpLoadFullyName", rowIndex].Value.ToString());
								return;
							}
							MessageBox.Show("文件不存在。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						}
					}
					return;
				}
				if (rowIndex == this.dTechnologyAwards.RowCount - 1)
				{
					return;
				}
				DataGridViewRow dataGridViewRow3 = this.dTechnologyAwards.Rows[rowIndex];
				if (dataGridViewRow3.Cells["scienceid"].Value != null)
				{
					string str = "";
					if (dataGridViewRow3.Cells["hiddenStoreName"].Value != null && dataGridViewRow3.Cells["hiddenStoreName"].Value != DBNull.Value)
					{
						str = dataGridViewRow3.Cells["hiddenStoreName"].Value.ToString();
					}
					this._deletedNo.Add(dataGridViewRow3.Cells["scienceid"].Value.ToString() + "|" + str);
					this._technologyAwardsService.DeleteRTreatisess(this._deletedNo);
					this._deletedNo.Clear();
				}
				this.dTechnologyAwards.Rows.Remove(dataGridViewRow3);
				this.dTechnologyAwards.ClearSelection();
				return;
			}
		}

		private bool SaveProgress()
		{
			this.OnSaveCheckDenyEvent(EventArgs.Empty);
			IList<TechnologyAwards> list = new List<TechnologyAwards>();
			for (int i = 0; i < this.dTechnologyAwards.RowCount - 1; i++)
			{
				DataGridViewRow dataGridViewRow = this.dTechnologyAwards.Rows[i];
				TechnologyAwards technologyAwards = new TechnologyAwards();
				technologyAwards.TechnologyAwardsNo = ((dataGridViewRow.Cells["scienceid"].Value == null) ? "" : dataGridViewRow.Cells["scienceid"].Value.ToString());
				technologyAwards.TechnologyAwardsPName = ((dataGridViewRow.Cells["sciencename"].Value == null || dataGridViewRow.Cells["sciencename"].Value == DBNull.Value) ? "" : dataGridViewRow.Cells["sciencename"].Value.ToString());
				technologyAwards.TechnologyAwardsTypeLevel = ((dataGridViewRow.Cells["sciencelevel"].Value == null || dataGridViewRow.Cells["sciencelevel"].Value == DBNull.Value) ? "" : dataGridViewRow.Cells["sciencelevel"].Value.ToString());
				technologyAwards.TechnologyAwardsYear = ((dataGridViewRow.Cells["sciencedate"].Value == null || dataGridViewRow.Cells["sciencedate"].Value == DBNull.Value) ? "" : dataGridViewRow.Cells["sciencedate"].Value.ToString());
				technologyAwards.TechnologyAwardsee = ((dataGridViewRow.Cells["scienceorder"].Value == null || dataGridViewRow.Cells["scienceorder"].Value == DBNull.Value) ? "" : dataGridViewRow.Cells["scienceorder"].Value.ToString());
				technologyAwards.TechnologyAwardsPDFOName = ((dataGridViewRow.Cells["scienceattainfo"].Value == null || dataGridViewRow.Cells["scienceattainfo"].Value == DBNull.Value) ? "" : dataGridViewRow.Cells["scienceattainfo"].Value.ToString());
				technologyAwards.TechnologyAwardsPDF = ((dataGridViewRow.Cells["hiddenStoreName"].Value == null || dataGridViewRow.Cells["hiddenStoreName"].Value == DBNull.Value) ? "" : dataGridViewRow.Cells["hiddenStoreName"].Value.ToString());
				technologyAwards.UpLoadFullPath = ((dataGridViewRow.Cells["UpLoadFullyName"].Value == null || dataGridViewRow.Cells["UpLoadFullyName"].Value == DBNull.Value) ? "" : dataGridViewRow.Cells["UpLoadFullyName"].Value.ToString());
				technologyAwards.TechnologyAwardsOrder = this.dTechnologyAwards.RowCount - i;
				if (technologyAwards.TechnologyAwardsPName == "" || technologyAwards.TechnologyAwardsTypeLevel == "" || technologyAwards.TechnologyAwardsYear == "" || technologyAwards.TechnologyAwardsee == "" || technologyAwards.TechnologyAwardsPDFOName == "")
				{
					MessageBox.Show("所有字段均为必填字段，重要科技奖项需要上传对应的PDF支撑文件", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return false;
				}
				int num;
				if (!int.TryParse(technologyAwards.TechnologyAwardsee, out num))
				{
					MessageBox.Show("录入的排名有非整数数据", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return false;
				}
				list.Add(technologyAwards);
			}
			if (list.Count > 10)
			{
				MessageBox.Show("录入的重要科技奖项记录条数超过10条", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return false;
			}
			this.OnSaveCheckPassedEvent(EventArgs.Empty);
			this._technologyAwardsService.UpdateTechnologyAwards(list);
			list = this._technologyAwardsService.GetTechnologyAwards();
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
			this._deletedNo.Clear();
			IList<TechnologyAwards> technologyAwards = this._technologyAwardsService.GetTechnologyAwards();
			this.LoadData(technologyAwards);
		}

		private void dTechnologyAwards_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
		{
            this.dTechnologyAwards["scienceup", e.RowIndex].Value = global::Properties.Resource.UP_16;
            this.dTechnologyAwards["sciencedown", e.RowIndex].Value = global::Properties.Resource.DOWN_16;
            this.dTechnologyAwards["sciencedelete", e.RowIndex].Value = global::Properties.Resource.DELETE_28;
            this.dTechnologyAwards["scienceattup", e.RowIndex].Value = global::Properties.Resource.Attachment_16;
		}

		public override void RefreshCall()
		{
			IList<TechnologyAwards> technologyAwards = this._technologyAwardsService.GetTechnologyAwards();
			this.LoadData(technologyAwards);
		}

		private void frmTechnologyAwards_Leave(object sender, EventArgs e)
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel14 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnnext = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnsave = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonPanel29 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel117 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.dTechnologyAwards = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.scienceid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sciencename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sciencelevel = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewButtonColumn();
            this.sciencedate = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn();
            this.scienceorder = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.scienceattup = new System.Windows.Forms.DataGridViewImageColumn();
            this.scienceattainfo = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewLinkColumn();
            this.hiddenStoreName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpLoadFullyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scienceup = new System.Windows.Forms.DataGridViewImageColumn();
            this.sciencedown = new System.Windows.Forms.DataGridViewImageColumn();
            this.sciencedelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.tecOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel14.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel29)).BeginInit();
            this.kryptonPanel29.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dTechnologyAwards)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel14
            // 
            this.tableLayoutPanel14.ColumnCount = 3;
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel14.Controls.Add(this.tableLayoutPanel1, 1, 3);
            this.tableLayoutPanel14.Controls.Add(this.kryptonPanel29, 1, 1);
            this.tableLayoutPanel14.Controls.Add(this.dTechnologyAwards, 1, 2);
            this.tableLayoutPanel14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel14.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel14.Name = "tableLayoutPanel14";
            this.tableLayoutPanel14.RowCount = 5;
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel14.Size = new System.Drawing.Size(1020, 603);
            this.tableLayoutPanel14.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 103F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btnnext, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnsave, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(53, 546);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(914, 34);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // btnnext
            // 
            this.btnnext.Location = new System.Drawing.Point(817, 3);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(90, 25);
            this.btnnext.TabIndex = 1;
            this.btnnext.Values.Text = "下一页";
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(714, 3);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(90, 25);
            this.btnsave.TabIndex = 0;
            this.btnsave.Values.Text = "保存";
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // kryptonPanel29
            // 
            this.kryptonPanel29.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel29.Controls.Add(this.kryptonLabel117);
            this.kryptonPanel29.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel29.Location = new System.Drawing.Point(50, 20);
            this.kryptonPanel29.Margin = new System.Windows.Forms.Padding(0);
            this.kryptonPanel29.Name = "kryptonPanel29";
            this.kryptonPanel29.Size = new System.Drawing.Size(920, 80);
            this.kryptonPanel29.TabIndex = 0;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(3, 36);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(308, 41);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("仿宋_GB2312", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.kryptonLabel1.TabIndex = 2;
            this.kryptonLabel1.Values.Text = "1.附件材料需为PDF或者JPG格式。\r\n2.提交纸质材料时，附件需要完整打印。";
            // 
            // kryptonLabel117
            // 
            this.kryptonLabel117.Location = new System.Drawing.Point(0, 10);
            this.kryptonLabel117.Name = "kryptonLabel117";
            this.kryptonLabel117.Size = new System.Drawing.Size(610, 27);
            this.kryptonLabel117.StateCommon.LongText.Font = new System.Drawing.Font("楷体_GB2312", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.kryptonLabel117.StateCommon.ShortText.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.kryptonLabel117.TabIndex = 0;
            this.kryptonLabel117.Values.ExtraText = "（10项以内，主要包括国家、省部级或军队科技奖励）";
            this.kryptonLabel117.Values.Text = "七、重要科技奖项情况\r\n";
            // 
            // dTechnologyAwards
            // 
            this.dTechnologyAwards.AllowUserToResizeRows = false;
            this.dTechnologyAwards.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dTechnologyAwards.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.scienceid,
            this.sciencename,
            this.sciencelevel,
            this.sciencedate,
            this.scienceorder,
            this.scienceattup,
            this.scienceattainfo,
            this.hiddenStoreName,
            this.UpLoadFullyName,
            this.scienceup,
            this.sciencedown,
            this.sciencedelete,
            this.tecOrder});
            this.dTechnologyAwards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dTechnologyAwards.Location = new System.Drawing.Point(53, 103);
            this.dTechnologyAwards.MultiSelect = false;
            this.dTechnologyAwards.Name = "dTechnologyAwards";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("仿宋_GB2312", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dTechnologyAwards.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dTechnologyAwards.RowTemplate.Height = 28;
            this.dTechnologyAwards.Size = new System.Drawing.Size(914, 437);
            this.dTechnologyAwards.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.dTechnologyAwards.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dTechnologyAwards.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dTechnologyAwards.StateCommon.HeaderColumn.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.dTechnologyAwards.TabIndex = 1;
            this.dTechnologyAwards.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dTechnologyAwards_CellContentClick);
            this.dTechnologyAwards.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dTechnologyAwards_RowsAdded);
            // 
            // scienceid
            // 
            this.scienceid.HeaderText = "序号";
            this.scienceid.Name = "scienceid";
            this.scienceid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.scienceid.Visible = false;
            this.scienceid.Width = 40;
            // 
            // sciencename
            // 
            this.sciencename.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sciencename.HeaderText = "项目名称";
            this.sciencename.MinimumWidth = 100;
            this.sciencename.Name = "sciencename";
            this.sciencename.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // sciencelevel
            // 
            this.sciencelevel.HeaderText = "奖励类别及等级";
            this.sciencelevel.Name = "sciencelevel";
            this.sciencelevel.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.sciencelevel.Width = 130;
            // 
            // sciencedate
            // 
            this.sciencedate.HeaderText = "获奖时间";
            this.sciencedate.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.sciencedate.Minimum = new decimal(new int[] {
            1990,
            0,
            0,
            0});
            this.sciencedate.Name = "sciencedate";
            this.sciencedate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.sciencedate.Width = 100;
            // 
            // scienceorder
            // 
            this.scienceorder.HeaderText = "排名";
            this.scienceorder.Name = "scienceorder";
            this.scienceorder.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.scienceorder.Width = 50;
            // 
            // scienceattup
            // 
            this.scienceattup.HeaderText = "附件";
            this.scienceattup.Name = "scienceattup";
            this.scienceattup.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.scienceattup.Width = 45;
            // 
            // scienceattainfo
            // 
            this.scienceattainfo.HeaderText = "附件信息";
            this.scienceattainfo.Name = "scienceattainfo";
            this.scienceattainfo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.scienceattainfo.Width = 150;
            // 
            // hiddenStoreName
            // 
            this.hiddenStoreName.HeaderText = "存储名称";
            this.hiddenStoreName.Name = "hiddenStoreName";
            this.hiddenStoreName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.hiddenStoreName.Visible = false;
            // 
            // UpLoadFullyName
            // 
            this.UpLoadFullyName.HeaderText = "上传路径";
            this.UpLoadFullyName.Name = "UpLoadFullyName";
            this.UpLoadFullyName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.UpLoadFullyName.Visible = false;
            // 
            // scienceup
            // 
            this.scienceup.HeaderText = "上移";
            this.scienceup.Name = "scienceup";
            this.scienceup.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.scienceup.Width = 45;
            // 
            // sciencedown
            // 
            this.sciencedown.HeaderText = "下移";
            this.sciencedown.Name = "sciencedown";
            this.sciencedown.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.sciencedown.Width = 45;
            // 
            // sciencedelete
            // 
            this.sciencedelete.HeaderText = "删除";
            this.sciencedelete.Name = "sciencedelete";
            this.sciencedelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.sciencedelete.Width = 45;
            // 
            // tecOrder
            // 
            this.tecOrder.HeaderText = "排序";
            this.tecOrder.Name = "tecOrder";
            this.tecOrder.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.tecOrder.Visible = false;
            // 
            // frmTechnologyAwards
            // 
            this.Controls.Add(this.tableLayoutPanel14);
            this.Name = "frmTechnologyAwards";
            this.Size = new System.Drawing.Size(1020, 603);
            this.Leave += new System.EventHandler(this.frmTechnologyAwards_Leave);
            this.tableLayoutPanel14.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel29)).EndInit();
            this.kryptonPanel29.ResumeLayout(false);
            this.kryptonPanel29.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dTechnologyAwards)).EndInit();
            this.ResumeLayout(false);

		}
	}
}
