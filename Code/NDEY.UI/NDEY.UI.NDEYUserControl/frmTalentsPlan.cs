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
	public class frmTalentsPlan : BaseControl
	{
		private TalentsPlanService _talentsPlanService = new TalentsPlanService();

		private IList<string> _deletedNo = new List<string>();

		private bool _hasRegister;

		private bool issaved;

		private IContainer components;

		private TableLayoutPanel tableLayoutPanel11;

		private TableLayoutPanel tableLayoutPanel1;

		private KryptonButton btnsave;

		private KryptonButton btnnext;

		private KryptonDataGridView dtalent;

		private KryptonPanel kryptonPanel26;
        private DataGridViewTextBoxColumn selpersonid;
        private KryptonDataGridViewNumericUpDownColumn selpersonidstartdate;
        private KryptonDataGridViewButtonColumn selpersonname;
        private DataGridViewTextBoxColumn TalentsPlanRA;
        private KryptonDataGridViewTextBoxColumn selpersonfee;
        private DataGridViewTextBoxColumn ctalOrder;
        private DataGridViewImageColumn up;
        private DataGridViewImageColumn down;
        private DataGridViewImageColumn delete;
        private KryptonLabel kryptonLabel114;

		public frmTalentsPlan()
		{
			this.InitializeComponent();
		}

		protected override void OnLoad(EventArgs e)
		{
			this.RefreshCall();
			base.OnLoad(e);
		}

		private void LoadData(IList<TalentsPlan> list)
		{
			this.dtalent.Rows.Clear();
			foreach (TalentsPlan current in list)
			{
				DataGridViewRow dataGridViewRow = new DataGridViewRow();
				int rowIndex = this.dtalent.Rows.Add(dataGridViewRow);
				this.dtalent["selpersonid", rowIndex].Value = current.TalentsPlanNo;
				this.dtalent["selpersonidstartdate", rowIndex].Value = current.TalentsPlanDate;
				this.dtalent["selpersonname", rowIndex].Value = current.TalentsPlanName;
				this.dtalent["TalentsPlanRA", rowIndex].Value = current.TalentsPlanRA;
				this.dtalent["selpersonfee", rowIndex].Value = current.TalentsPlanOutlay;
				this.dtalent["ctalOrder", rowIndex].Value = current.TalentsPlanOrder;
			}
		}

		private bool SaveProgress()
		{
			this.OnSaveCheckDenyEvent(EventArgs.Empty);
			IList<TalentsPlan> list = new List<TalentsPlan>();
			for (int i = 0; i < this.dtalent.RowCount - 1; i++)
			{
				DataGridViewRow dataGridViewRow = this.dtalent.Rows[i];
				TalentsPlan talentsPlan = new TalentsPlan();
				talentsPlan.TalentsPlanNo = ((dataGridViewRow.Cells["selpersonid"].Value == null) ? "" : dataGridViewRow.Cells["selpersonid"].Value.ToString());
				talentsPlan.TalentsPlanDate = ((dataGridViewRow.Cells["selpersonidstartdate"].Value == null || dataGridViewRow.Cells["selpersonidstartdate"].Value == DBNull.Value) ? "" : dataGridViewRow.Cells["selpersonidstartdate"].Value.ToString());
				talentsPlan.TalentsPlanName = ((dataGridViewRow.Cells["selpersonname"].Value == null || dataGridViewRow.Cells["selpersonname"].Value == DBNull.Value) ? "" : dataGridViewRow.Cells["selpersonname"].Value.ToString());
				talentsPlan.TalentsPlanRA = ((dataGridViewRow.Cells["TalentsPlanRA"].Value == null || dataGridViewRow.Cells["TalentsPlanRA"].Value == DBNull.Value) ? "" : dataGridViewRow.Cells["TalentsPlanRA"].Value.ToString());
				talentsPlan.TalentsPlanOutlay = ((dataGridViewRow.Cells["selpersonfee"].Value == null || dataGridViewRow.Cells["selpersonfee"].Value == DBNull.Value) ? "" : dataGridViewRow.Cells["selpersonfee"].Value.ToString());
				talentsPlan.TalentsPlanOrder = this.dtalent.RowCount - i;
				if (talentsPlan.TalentsPlanDate == "")
				{
					MessageBox.Show("入选时间为必填字段，检测到部分字段未填写完整", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return false;
				}
				decimal num;
				if (talentsPlan.TalentsPlanOutlay != string.Empty && !decimal.TryParse(talentsPlan.TalentsPlanOutlay, out num))
				{
					MessageBox.Show("录入的资助经费有非数值数据", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return false;
				}
				list.Add(talentsPlan);
			}
			this.OnSaveCheckPassedEvent(EventArgs.Empty);
			this._talentsPlanService.UpdateTalentsPlans(list);
			list = this._talentsPlanService.GetTalentsPlan();
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
			IList<TalentsPlan> talentsPlan = this._talentsPlanService.GetTalentsPlan();
			this.LoadData(talentsPlan);
		}

		private void dtalent_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
            if (e.ColumnIndex == 2)
            {
                frmSuperComboboxForm scf = new frmSuperComboboxForm();
                scf.Text = "请选择人才计划名称！";
                List<string> itemList = new List<string>();
                itemList.Add("国家“千人计划”创新人才长期项目");
                itemList.Add("国家“千人计划”创新人才短期项目");
                itemList.Add("国家“千人计划”青年项目");
                itemList.Add("国家“万人计划”杰出人才项目");
                itemList.Add("国家“万人计划”领军人才项目");
                itemList.Add("国家“万人计划”青年拔尖人才项目");
                itemList.Add("教育部“长江学者奖励计划”特聘教授");
                itemList.Add("教育部“长江学者奖励计划”讲座教授");
                itemList.Add("教育部“长江学者奖励计划”青年学者");
                itemList.Add("国家自然科学基金委杰出青年基金");
                itemList.Add("国家自然科学基金委优秀青年基金");
                itemList.Add("科技部“创新人才推进计划”中青年科技领军人才");
                itemList.Add("科技部“创新人才推进计划”重点领域创新团队带头人");
                itemList.Add("人社部“百万人才工程”国家级人选");
                itemList.Add("军队科技领军人才");
                itemList.Add("军队科技领军人才培养对象");
                itemList.Add("军队学科拔尖人才");
                itemList.Add("军队学科拔尖人才培养对象");

                scf.InitComboboxList(itemList.ToArray());
                scf.SelectItem(this.dtalent.Rows[e.RowIndex].Cells[2].Value != null ? this.dtalent.Rows[e.RowIndex].Cells[2].Value.ToString() : string.Empty);

                if (scf.ShowDialog() == DialogResult.OK)
                {
                    this.dtalent.Rows[e.RowIndex].Cells[2].Value = scf.SelectedItem;
                }
            }

            int columnIndex = e.ColumnIndex;
			int rowIndex = e.RowIndex;
			if (rowIndex == -1)
			{
				return;
			}
			if (this.dtalent.Columns[columnIndex].Name == "up")
			{
				if (rowIndex == 0 || rowIndex == this.dtalent.RowCount - 1)
				{
					return;
				}
				DataGridViewRow dataGridViewRow = this.dtalent.Rows[rowIndex];
				this.dtalent.Rows.Remove(dataGridViewRow);
				this.dtalent.Rows.Insert(rowIndex - 1, dataGridViewRow);
				this.dtalent.ClearSelection();
				return;
			}
			else if (this.dtalent.Columns[columnIndex].Name == "down")
			{
				if (rowIndex >= this.dtalent.RowCount - 2)
				{
					return;
				}
				DataGridViewRow dataGridViewRow2 = this.dtalent.Rows[rowIndex];
				this.dtalent.Rows.Remove(dataGridViewRow2);
				this.dtalent.Rows.Insert(rowIndex + 1, dataGridViewRow2);
				this.dtalent.ClearSelection();
				return;
			}
			else
			{
				if (!(this.dtalent.Columns[columnIndex].Name == "delete"))
				{
					if (this.dtalent.Columns[columnIndex].Name == "selpersonname" && this.dtalent[columnIndex, rowIndex].Value != null && this.dtalent[columnIndex, rowIndex].Value.ToString() == "其他")
					{
						this.dtalent[columnIndex, rowIndex].Value = "";
					}
					return;
				}
				if (rowIndex == this.dtalent.RowCount - 1)
				{
					return;
				}
				DataGridViewRow dataGridViewRow3 = this.dtalent.Rows[rowIndex];
				if (dataGridViewRow3.Cells["selpersonid"].Value != null)
				{
					this._deletedNo.Add(dataGridViewRow3.Cells["selpersonid"].Value.ToString());
					this._talentsPlanService.DeleteTalentsPlans(this._deletedNo);
					this._deletedNo.Clear();
				}
				this.dtalent.Rows.Remove(dataGridViewRow3);
				this.dtalent.ClearSelection();
				return;
			}
		}

		private void dtalent_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
		{
            this.dtalent["up", e.RowIndex].Value = global::Properties.Resource.UP_16;
            this.dtalent["down", e.RowIndex].Value = global::Properties.Resource.DOWN_16;
            this.dtalent["delete", e.RowIndex].Value = global::Properties.Resource.DELETE_28;
		}

		public override void RefreshCall()
		{
			IList<TalentsPlan> talentsPlan = this._talentsPlanService.GetTalentsPlan();
			this.LoadData(talentsPlan);
		}

		private void dtalent_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
		{
			if (this.dtalent.CurrentCell.OwningColumn.Name == "selpersonname")
			{
				KryptonComboBox kryptonComboBox = (KryptonComboBox)e.Control;
				if (!this._hasRegister)
				{
					kryptonComboBox.SelectedIndexChanged += new EventHandler(this.ComboBox_SelectedIndexChanged);
					this._hasRegister = true;
				}
			}
		}

		private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			KryptonComboBox kryptonComboBox = (KryptonComboBox)sender;
			if (kryptonComboBox.Text == "其他")
			{
				kryptonComboBox.SelectedText = "";
			}
		}

		private void frmTalentsPlan_Leave(object sender, EventArgs e)
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
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnnext = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnsave = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.dtalent = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.kryptonPanel26 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel114 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.selpersonid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selpersonidstartdate = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn();
            this.selpersonname = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewButtonColumn();
            this.TalentsPlanRA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selpersonfee = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.ctalOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.up = new System.Windows.Forms.DataGridViewImageColumn();
            this.down = new System.Windows.Forms.DataGridViewImageColumn();
            this.delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.tableLayoutPanel11.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtalent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel26)).BeginInit();
            this.kryptonPanel26.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.ColumnCount = 3;
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel11.Controls.Add(this.tableLayoutPanel1, 1, 3);
            this.tableLayoutPanel11.Controls.Add(this.dtalent, 1, 2);
            this.tableLayoutPanel11.Controls.Add(this.kryptonPanel26, 1, 1);
            this.tableLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel11.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 5;
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel11.Size = new System.Drawing.Size(1002, 594);
            this.tableLayoutPanel11.TabIndex = 2;
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(53, 537);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(896, 34);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // btnnext
            // 
            this.btnnext.Location = new System.Drawing.Point(799, 3);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(90, 25);
            this.btnnext.TabIndex = 1;
            this.btnnext.Values.Text = "下一页";
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(696, 3);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(90, 25);
            this.btnsave.TabIndex = 0;
            this.btnsave.Values.Text = "保存";
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // dtalent
            // 
            this.dtalent.AllowUserToResizeRows = false;
            this.dtalent.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dtalent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.selpersonid,
            this.selpersonidstartdate,
            this.selpersonname,
            this.TalentsPlanRA,
            this.selpersonfee,
            this.ctalOrder,
            this.up,
            this.down,
            this.delete});
            this.dtalent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtalent.Location = new System.Drawing.Point(53, 63);
            this.dtalent.MultiSelect = false;
            this.dtalent.Name = "dtalent";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("仿宋_GB2312", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtalent.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtalent.RowTemplate.Height = 28;
            this.dtalent.Size = new System.Drawing.Size(896, 468);
            this.dtalent.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.dtalent.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dtalent.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtalent.StateCommon.HeaderColumn.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.dtalent.TabIndex = 2;
            this.dtalent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtalent_CellContentClick);
            this.dtalent.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dtalent_EditingControlShowing);
            this.dtalent.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dtalent_RowsAdded);
            // 
            // kryptonPanel26
            // 
            this.kryptonPanel26.Controls.Add(this.kryptonLabel114);
            this.kryptonPanel26.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel26.Location = new System.Drawing.Point(50, 20);
            this.kryptonPanel26.Margin = new System.Windows.Forms.Padding(0);
            this.kryptonPanel26.Name = "kryptonPanel26";
            this.kryptonPanel26.Size = new System.Drawing.Size(902, 40);
            this.kryptonPanel26.TabIndex = 1;
            // 
            // kryptonLabel114
            // 
            this.kryptonLabel114.Location = new System.Drawing.Point(3, 10);
            this.kryptonLabel114.Name = "kryptonLabel114";
            this.kryptonLabel114.Size = new System.Drawing.Size(577, 27);
            this.kryptonLabel114.StateCommon.LongText.Font = new System.Drawing.Font("楷体_GB2312", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.kryptonLabel114.StateCommon.ShortText.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.kryptonLabel114.TabIndex = 0;
            this.kryptonLabel114.Values.ExtraText = "（按时间倒序填写入选国家和军队人才计划情况）";
            this.kryptonLabel114.Values.Text = "四、入选人才计划情况";
            // 
            // selpersonid
            // 
            this.selpersonid.HeaderText = "id";
            this.selpersonid.Name = "selpersonid";
            this.selpersonid.Visible = false;
            // 
            // selpersonidstartdate
            // 
            this.selpersonidstartdate.HeaderText = "入选时间";
            this.selpersonidstartdate.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.selpersonidstartdate.Minimum = new decimal(new int[] {
            1990,
            0,
            0,
            0});
            this.selpersonidstartdate.Name = "selpersonidstartdate";
            this.selpersonidstartdate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.selpersonidstartdate.Width = 100;
            // 
            // selpersonname
            // 
            this.selpersonname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.selpersonname.HeaderText = "人才计划名称";
            this.selpersonname.Name = "selpersonname";
            this.selpersonname.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // TalentsPlanRA
            // 
            this.TalentsPlanRA.HeaderText = "研究方向";
            this.TalentsPlanRA.Name = "TalentsPlanRA";
            this.TalentsPlanRA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TalentsPlanRA.Width = 200;
            // 
            // selpersonfee
            // 
            this.selpersonfee.HeaderText = "资助经费(万)";
            this.selpersonfee.Name = "selpersonfee";
            this.selpersonfee.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.selpersonfee.Width = 110;
            // 
            // ctalOrder
            // 
            this.ctalOrder.HeaderText = "ctalOrder";
            this.ctalOrder.Name = "ctalOrder";
            this.ctalOrder.Visible = false;
            // 
            // up
            // 
            this.up.HeaderText = "上移";
            this.up.Name = "up";
            this.up.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.up.Width = 45;
            // 
            // down
            // 
            this.down.HeaderText = "下移";
            this.down.Name = "down";
            this.down.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.down.Width = 45;
            // 
            // delete
            // 
            this.delete.HeaderText = "删除";
            this.delete.Name = "delete";
            this.delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.delete.Width = 45;
            // 
            // frmTalentsPlan
            // 
            this.Controls.Add(this.tableLayoutPanel11);
            this.Name = "frmTalentsPlan";
            this.Size = new System.Drawing.Size(1002, 594);
            this.Leave += new System.EventHandler(this.frmTalentsPlan_Leave);
            this.tableLayoutPanel11.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtalent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel26)).EndInit();
            this.kryptonPanel26.ResumeLayout(false);
            this.kryptonPanel26.PerformLayout();
            this.ResumeLayout(false);

		}
	}
}