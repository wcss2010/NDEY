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
	public class frmRTreatises : BaseControl
	{
		private RTreatisesService _rTreatisesService = new RTreatisesService();

		private IList<string> _deletedNo = new List<string>();

		private bool issaved;

		private IContainer components;

		private TableLayoutPanel tableLayoutPanel13;

		private TableLayoutPanel tableLayoutPanel29;

		private KryptonButton btnsave;

		private KryptonButton btnnext;

		private KryptonPanel kryptonPanel28;

		private KryptonLabel kryptonLabel116;

		private KryptonDataGridView dRTreatises;
        private DataGridViewTextBoxColumn paperid;
        private DataGridViewTextBoxColumn papername;
        private KryptonDataGridViewComboBoxColumn papertype;
        private KryptonDataGridViewNumericUpDownColumn paperyear;
        private KryptonDataGridViewTextBoxColumn paperpublish;
        private KryptonDataGridViewButtonColumn paperref;
        private KryptonDataGridViewTextBoxColumn paperorder;
        private DataGridViewImageColumn paperattachmentup;
        private KryptonDataGridViewLinkColumn paperattachmentinfo;
        private DataGridViewTextBoxColumn hiddenRTreatisesPDFOName;
        private DataGridViewTextBoxColumn uploadfullpath;
        private DataGridViewTextBoxColumn reorder;
        private DataGridViewImageColumn paperup;
        private DataGridViewImageColumn paperdown;
        private DataGridViewImageColumn paperdel;
        private KryptonLabel kryptonLabel1;

		public frmRTreatises()
		{
			this.InitializeComponent();
		}

		protected override void OnLoad(EventArgs e)
		{
			this.dRTreatises.Columns["paperpublish"].HeaderText = "著作或机构名称";
			this.RefreshCall();
			base.OnLoad(e);
		}

		private void LoadData(IList<RTreatises> list)
		{
			this.dRTreatises.Rows.Clear();
			foreach (RTreatises current in list)
			{
				DataGridViewRow dataGridViewRow = new DataGridViewRow();
				int rowIndex = this.dRTreatises.Rows.Add(dataGridViewRow);
				this.dRTreatises["paperid", rowIndex].Value = current.RTreatisesNo;
				this.dRTreatises["papername", rowIndex].Value = current.RTreatisesName;
				this.dRTreatises["paperyear", rowIndex].Value = current.RTreatisesRell;
				string rTreatisesType;
				if ((rTreatisesType = current.RTreatisesType) != null)
				{
					if (!(rTreatisesType == "1"))
					{
						if (!(rTreatisesType == "2"))
						{
							if (!(rTreatisesType == "3"))
							{
								if (rTreatisesType == "4")
								{
									this.dRTreatises["papertype", rowIndex].Value = "重要学术会议邀请报告";
								}
							}
							else
							{
								this.dRTreatises["papertype", rowIndex].Value = "研究技术报告";
							}
						}
						else
						{
							this.dRTreatises["papertype", rowIndex].Value = "著作";
						}
					}
					else
					{
						this.dRTreatises["papertype", rowIndex].Value = "论文";
					}
				}
				this.dRTreatises["paperpublish", rowIndex].Value = current.RTreatisesJournalTitle;
				this.dRTreatises["paperref", rowIndex].Value = current.RTreatisesCollection;
				this.dRTreatises["paperorder", rowIndex].Value = current.RTreatisesAuthor;
				this.dRTreatises["paperattachmentinfo", rowIndex].Value = current.RTreatisesPDFOName;
				this.dRTreatises["hiddenRTreatisesPDFOName", rowIndex].Value = current.RTreatisesPDF;
				this.dRTreatises["reorder", rowIndex].Value = current.RTreatisesOrder;
			}
		}

		private void dRTreatises_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
            if (e.ColumnIndex == 5)
            {
                frmSuperComboboxForm scf = new frmSuperComboboxForm();
                scf.Text = "请选择收录及引用情况！";
                List<string> list = new List<string>();
                list.Add("SCI");
                list.Add("EI");
                scf.InitComboboxList(list.ToArray());
                scf.SelectItem(this.dRTreatises.Rows[e.RowIndex].Cells[5].Value != null ? this.dRTreatises.Rows[e.RowIndex].Cells[5].Value.ToString() : string.Empty);
                if (scf.ShowDialog() == DialogResult.OK)
                {
                    this.dRTreatises.Rows[e.RowIndex].Cells[5].Value = scf.SelectedItem;
                }
            }

			int columnIndex = e.ColumnIndex;
			int rowIndex = e.RowIndex;
			if (rowIndex == -1)
			{
				return;
			}
			if (this.dRTreatises.Columns[columnIndex].Name == "paperup")
			{
				if (rowIndex == 0 || rowIndex == this.dRTreatises.RowCount - 1)
				{
					return;
				}
				DataGridViewRow dataGridViewRow = this.dRTreatises.Rows[rowIndex];
				this.dRTreatises.Rows.Remove(dataGridViewRow);
				this.dRTreatises.Rows.Insert(rowIndex - 1, dataGridViewRow);
				this.dRTreatises.ClearSelection();
				return;
			}
			else if (this.dRTreatises.Columns[columnIndex].Name == "paperdown")
			{
				if (rowIndex >= this.dRTreatises.RowCount - 2)
				{
					return;
				}
				DataGridViewRow dataGridViewRow2 = this.dRTreatises.Rows[rowIndex];
				this.dRTreatises.Rows.Remove(dataGridViewRow2);
				this.dRTreatises.Rows.Insert(rowIndex + 1, dataGridViewRow2);
				this.dRTreatises.ClearSelection();
				return;
			}
			else
			{
				if (!(this.dRTreatises.Columns[columnIndex].Name == "paperdel"))
				{
					if (this.dRTreatises.Columns[columnIndex].Name == "paperattachmentup")
					{
						OpenFileDialog openFileDialog = new OpenFileDialog();
						openFileDialog.Filter = "Adobe PDF 文件,JPEG图像文件|*.pdf;*.jpg;*.jpeg";
						openFileDialog.Multiselect = false;
						if (openFileDialog.ShowDialog() == DialogResult.OK)
						{
							this.dRTreatises["paperattachmentinfo", rowIndex].Value = openFileDialog.FileName;
							this.dRTreatises["uploadfullpath", rowIndex].Value = openFileDialog.FileName;
							return;
						}
					}
					else if (this.dRTreatises.Columns[columnIndex].Name == "paperattachmentinfo")
					{
						if (this.dRTreatises["hiddenRTreatisesPDFOName", rowIndex].Value != null)
						{
							if (File.Exists(Path.Combine(EntityElement.FilesStorePath, this.dRTreatises["hiddenRTreatisesPDFOName", rowIndex].Value.ToString())))
							{
								FileOp.OpenFile(Path.Combine(EntityElement.FilesStorePath, this.dRTreatises["hiddenRTreatisesPDFOName", rowIndex].Value.ToString()));
								return;
							}
							MessageBox.Show("文件不存在。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
							return;
						}
						else if (this.dRTreatises["uploadfullpath", rowIndex].Value != null)
						{
							if (File.Exists(this.dRTreatises["uploadfullpath", rowIndex].Value.ToString()))
							{
								FileOp.OpenFile(this.dRTreatises["uploadfullpath", rowIndex].Value.ToString());
								return;
							}
							MessageBox.Show("文件不存在。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						}
					}
					return;
				}
				if (rowIndex == this.dRTreatises.RowCount - 1)
				{
					return;
				}
				DataGridViewRow dataGridViewRow3 = this.dRTreatises.Rows[rowIndex];
				if (dataGridViewRow3.Cells["paperid"].Value != null)
				{
					string str = "";
					if (dataGridViewRow3.Cells["hiddenRTreatisesPDFOName"].Value != null && dataGridViewRow3.Cells["hiddenRTreatisesPDFOName"].Value != DBNull.Value)
					{
						str = dataGridViewRow3.Cells["hiddenRTreatisesPDFOName"].Value.ToString();
					}
					this._deletedNo.Add(dataGridViewRow3.Cells["paperid"].Value.ToString() + "|" + str);
					this._rTreatisesService.DeleteRTreatisess(this._deletedNo);
					this._deletedNo.Clear();
				}
				this.dRTreatises.Rows.Remove(dataGridViewRow3);
				this.dRTreatises.ClearSelection();
				return;
			}
		}

		private void btnrefresh_Click(object sender, EventArgs e)
		{
			this._deletedNo.Clear();
			IList<RTreatises> rTreatises = this._rTreatisesService.GetRTreatises();
			this.LoadData(rTreatises);
		}

		private bool SaveProgress()
		{
			this.OnSaveCheckDenyEvent(EventArgs.Empty);
			IList<RTreatises> list = new List<RTreatises>();
			for (int i = 0; i < this.dRTreatises.RowCount - 1; i++)
			{
				DataGridViewRow dataGridViewRow = this.dRTreatises.Rows[i];
				RTreatises rTreatises = new RTreatises();
				rTreatises.RTreatisesNo = ((dataGridViewRow.Cells["paperid"].Value == null) ? "" : dataGridViewRow.Cells["paperid"].Value.ToString());
				rTreatises.RTreatisesName = ((dataGridViewRow.Cells["papername"].Value == null || dataGridViewRow.Cells["papername"].Value == DBNull.Value) ? "" : dataGridViewRow.Cells["papername"].Value.ToString());
				rTreatises.RTreatisesRell = ((dataGridViewRow.Cells["paperyear"].Value == null || dataGridViewRow.Cells["paperyear"].Value == DBNull.Value) ? "" : dataGridViewRow.Cells["paperyear"].Value.ToString());
				string a;
				if (dataGridViewRow.Cells["papertype"].Value != null && dataGridViewRow.Cells["papertype"].Value != DBNull.Value && (a = dataGridViewRow.Cells["papertype"].Value.ToString()) != null)
				{
					if (!(a == "论文"))
					{
						if (!(a == "著作"))
						{
							if (!(a == "研究技术报告"))
							{
								if (a == "重要学术会议邀请报告")
								{
									rTreatises.RTreatisesType = "4";
								}
							}
							else
							{
								rTreatises.RTreatisesType = "3";
							}
						}
						else
						{
							rTreatises.RTreatisesType = "2";
						}
					}
					else
					{
						rTreatises.RTreatisesType = "1";
					}
				}
				rTreatises.RTreatisesJournalTitle = ((dataGridViewRow.Cells["paperpublish"].Value == null || dataGridViewRow.Cells["paperpublish"].Value == DBNull.Value) ? "" : dataGridViewRow.Cells["paperpublish"].Value.ToString());
				rTreatises.RTreatisesCollection = ((dataGridViewRow.Cells["paperref"].Value == null || dataGridViewRow.Cells["paperref"].Value == DBNull.Value) ? "" : dataGridViewRow.Cells["paperref"].Value.ToString());
				rTreatises.RTreatisesAuthor = ((dataGridViewRow.Cells["paperorder"].Value == null || dataGridViewRow.Cells["paperorder"].Value == DBNull.Value) ? "" : dataGridViewRow.Cells["paperorder"].Value.ToString());
				rTreatises.RTreatisesPDF = ((dataGridViewRow.Cells["hiddenRTreatisesPDFOName"].Value == null || dataGridViewRow.Cells["hiddenRTreatisesPDFOName"].Value == DBNull.Value) ? "" : dataGridViewRow.Cells["hiddenRTreatisesPDFOName"].Value.ToString());
				rTreatises.RTreatisesPDFOName = ((dataGridViewRow.Cells["paperattachmentinfo"].Value == null || dataGridViewRow.Cells["paperattachmentinfo"].Value == DBNull.Value) ? "" : dataGridViewRow.Cells["paperattachmentinfo"].Value.ToString());
				rTreatises.UpLoadFullPath = ((dataGridViewRow.Cells["uploadfullpath"].Value == null || dataGridViewRow.Cells["uploadfullpath"].Value == DBNull.Value) ? "" : dataGridViewRow.Cells["uploadfullpath"].Value.ToString());
				rTreatises.RTreatisesOrder = this.dRTreatises.RowCount - i;
				if (rTreatises.RTreatisesName == "" || rTreatises.RTreatisesType == "" || rTreatises.RTreatisesRell == "" || rTreatises.RTreatisesJournalTitle == "" || rTreatises.RTreatisesPDFOName == "")
				{
					MessageBox.Show("所有字段均为必填字段，代表性著作需要上传对应的PDF支撑文件", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return false;
				}
				int num;
				if (!int.TryParse(rTreatises.RTreatisesAuthor, out num))
				{
					MessageBox.Show("录入的排名有非整数数据", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return false;
				}
				list.Add(rTreatises);
			}
			if (list.Count > 10)
			{
				MessageBox.Show("录入的代表性著作记录条数超过10条", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return false;
			}
			this.OnSaveCheckPassedEvent(EventArgs.Empty);
			this._rTreatisesService.UpdateRTreatisess(list);
			list = this._rTreatisesService.GetRTreatises();
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

		private void dRTreatises_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
		{
            this.dRTreatises["paperup", e.RowIndex].Value = global::Properties.Resource.UP_16;
            this.dRTreatises["paperdown", e.RowIndex].Value = global::Properties.Resource.DOWN_16;
            this.dRTreatises["paperdel", e.RowIndex].Value = global::Properties.Resource.DELETE_28;
            this.dRTreatises["paperattachmentup", e.RowIndex].Value = global::Properties.Resource.Attachment_16;
		}

		public override void RefreshCall()
		{
			IList<RTreatises> rTreatises = this._rTreatisesService.GetRTreatises();
			this.LoadData(rTreatises);
		}

		private void frmRTreatises_Leave(object sender, EventArgs e)
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
            this.tableLayoutPanel13 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel29 = new System.Windows.Forms.TableLayoutPanel();
            this.btnnext = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnsave = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonPanel28 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel116 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.dRTreatises = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.paperid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.papername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.papertype = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewComboBoxColumn();
            this.paperyear = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn();
            this.paperpublish = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.paperref = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewButtonColumn();
            this.paperorder = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.paperattachmentup = new System.Windows.Forms.DataGridViewImageColumn();
            this.paperattachmentinfo = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewLinkColumn();
            this.hiddenRTreatisesPDFOName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uploadfullpath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reorder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paperup = new System.Windows.Forms.DataGridViewImageColumn();
            this.paperdown = new System.Windows.Forms.DataGridViewImageColumn();
            this.paperdel = new System.Windows.Forms.DataGridViewImageColumn();
            this.tableLayoutPanel13.SuspendLayout();
            this.tableLayoutPanel29.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel28)).BeginInit();
            this.kryptonPanel28.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dRTreatises)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel13
            // 
            this.tableLayoutPanel13.ColumnCount = 3;
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel13.Controls.Add(this.tableLayoutPanel29, 1, 3);
            this.tableLayoutPanel13.Controls.Add(this.kryptonPanel28, 1, 1);
            this.tableLayoutPanel13.Controls.Add(this.dRTreatises, 1, 2);
            this.tableLayoutPanel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel13.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel13.Name = "tableLayoutPanel13";
            this.tableLayoutPanel13.RowCount = 5;
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel13.Size = new System.Drawing.Size(1040, 512);
            this.tableLayoutPanel13.TabIndex = 2;
            // 
            // tableLayoutPanel29
            // 
            this.tableLayoutPanel29.ColumnCount = 3;
            this.tableLayoutPanel29.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel29.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 103F));
            this.tableLayoutPanel29.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel29.Controls.Add(this.btnnext, 2, 0);
            this.tableLayoutPanel29.Controls.Add(this.btnsave, 1, 0);
            this.tableLayoutPanel29.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel29.Location = new System.Drawing.Point(53, 455);
            this.tableLayoutPanel29.Name = "tableLayoutPanel29";
            this.tableLayoutPanel29.RowCount = 1;
            this.tableLayoutPanel29.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel29.Size = new System.Drawing.Size(934, 34);
            this.tableLayoutPanel29.TabIndex = 2;
            // 
            // btnnext
            // 
            this.btnnext.Location = new System.Drawing.Point(837, 3);
            this.btnnext.Name = "btnnext";
            this.btnnext.TabIndex = 1;
            this.btnnext.Values.Text = "下一页";
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(734, 3);
            this.btnsave.Name = "btnsave";
            this.btnsave.TabIndex = 0;
            this.btnsave.Values.Text = "保存";
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // kryptonPanel28
            // 
            this.kryptonPanel28.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel28.Controls.Add(this.kryptonLabel116);
            this.kryptonPanel28.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel28.Location = new System.Drawing.Point(50, 20);
            this.kryptonPanel28.Margin = new System.Windows.Forms.Padding(0);
            this.kryptonPanel28.Name = "kryptonPanel28";
            this.kryptonPanel28.Size = new System.Drawing.Size(940, 80);
            this.kryptonPanel28.TabIndex = 0;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(3, 36);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(755, 41);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.kryptonLabel1.TabIndex = 1;
            this.kryptonLabel1.Values.Text = "1.附件材料需为PDF或者JPG格式。\r\n2.提交纸质材料时，论文可打印首页和检索证明,其他类别代表性论著打印封面、目录和首页。";
            // 
            // kryptonLabel116
            // 
            this.kryptonLabel116.Location = new System.Drawing.Point(0, 10);
            this.kryptonLabel116.Name = "kryptonLabel116";
            this.kryptonLabel116.Size = new System.Drawing.Size(927, 27);
            this.kryptonLabel116.StateCommon.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.kryptonLabel116.StateCommon.ShortText.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.kryptonLabel116.TabIndex = 0;
            this.kryptonLabel116.Values.ExtraText = "（主要包括论文、著作、研究报告、重要学术会议邀请报告4类；10篇以内，并按照重要性排序）";
            this.kryptonLabel116.Values.Text = "六、代表性论著\r\n";
            // 
            // dRTreatises
            // 
            this.dRTreatises.AllowUserToResizeColumns = false;
            this.dRTreatises.AllowUserToResizeRows = false;
            this.dRTreatises.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dRTreatises.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.paperid,
            this.papername,
            this.papertype,
            this.paperyear,
            this.paperpublish,
            this.paperref,
            this.paperorder,
            this.paperattachmentup,
            this.paperattachmentinfo,
            this.hiddenRTreatisesPDFOName,
            this.uploadfullpath,
            this.reorder,
            this.paperup,
            this.paperdown,
            this.paperdel});
            this.dRTreatises.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dRTreatises.Location = new System.Drawing.Point(53, 103);
            this.dRTreatises.MultiSelect = false;
            this.dRTreatises.Name = "dRTreatises";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dRTreatises.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dRTreatises.RowTemplate.Height = 28;
            this.dRTreatises.Size = new System.Drawing.Size(934, 346);
            this.dRTreatises.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.dRTreatises.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dRTreatises.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dRTreatises.StateCommon.HeaderColumn.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.dRTreatises.TabIndex = 1;
            this.dRTreatises.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dRTreatises_CellContentClick);
            this.dRTreatises.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dRTreatises_RowsAdded);
            // 
            // paperid
            // 
            this.paperid.HeaderText = "序号";
            this.paperid.Name = "paperid";
            this.paperid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.paperid.Visible = false;
            this.paperid.Width = 40;
            // 
            // papername
            // 
            this.papername.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.papername.HeaderText = "题目";
            this.papername.MinimumWidth = 150;
            this.papername.Name = "papername";
            this.papername.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // papertype
            // 
            this.papertype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.papertype.DropDownWidth = 150;
            this.papertype.HeaderText = "类别";
            this.papertype.Items.AddRange(new string[] {
            "论文",
            "著作",
            "研究技术报告",
            "重要学术会议邀请报告"});
            this.papertype.Name = "papertype";
            this.papertype.Width = 100;
            // 
            // paperyear
            // 
            this.paperyear.HeaderText = "年份";
            this.paperyear.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.paperyear.Minimum = new decimal(new int[] {
            1990,
            0,
            0,
            0});
            this.paperyear.Name = "paperyear";
            this.paperyear.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.paperyear.Width = 80;
            // 
            // paperpublish
            // 
            this.paperpublish.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.paperpublish.HeaderText = "著作或机构名称";
            this.paperpublish.Name = "paperpublish";
            this.paperpublish.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.paperpublish.Width = 130;
            // 
            // paperref
            // 
            this.paperref.HeaderText = "收录情况";
            this.paperref.Name = "paperref";
            this.paperref.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.paperref.Width = 150;
            // 
            // paperorder
            // 
            this.paperorder.HeaderText = "排名";
            this.paperorder.Name = "paperorder";
            this.paperorder.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.paperorder.Width = 50;
            // 
            // paperattachmentup
            // 
            this.paperattachmentup.HeaderText = "附件";
            this.paperattachmentup.Name = "paperattachmentup";
            this.paperattachmentup.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.paperattachmentup.Width = 45;
            // 
            // paperattachmentinfo
            // 
            this.paperattachmentinfo.HeaderText = "附件信息";
            this.paperattachmentinfo.Name = "paperattachmentinfo";
            this.paperattachmentinfo.ReadOnly = true;
            this.paperattachmentinfo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.paperattachmentinfo.Width = 150;
            // 
            // hiddenRTreatisesPDFOName
            // 
            this.hiddenRTreatisesPDFOName.HeaderText = "存储名称";
            this.hiddenRTreatisesPDFOName.Name = "hiddenRTreatisesPDFOName";
            this.hiddenRTreatisesPDFOName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.hiddenRTreatisesPDFOName.Visible = false;
            // 
            // uploadfullpath
            // 
            this.uploadfullpath.HeaderText = "上传路径";
            this.uploadfullpath.Name = "uploadfullpath";
            this.uploadfullpath.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.uploadfullpath.Visible = false;
            // 
            // reorder
            // 
            this.reorder.HeaderText = "排序";
            this.reorder.Name = "reorder";
            this.reorder.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.reorder.Visible = false;
            // 
            // paperup
            // 
            this.paperup.HeaderText = "上移";
            this.paperup.Name = "paperup";
            this.paperup.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.paperup.Width = 45;
            // 
            // paperdown
            // 
            this.paperdown.HeaderText = "下移";
            this.paperdown.Name = "paperdown";
            this.paperdown.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.paperdown.Width = 45;
            // 
            // paperdel
            // 
            this.paperdel.HeaderText = "删除";
            this.paperdel.Name = "paperdel";
            this.paperdel.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.paperdel.Width = 45;
            // 
            // frmRTreatises
            // 
            this.Controls.Add(this.tableLayoutPanel13);
            this.Name = "frmRTreatises";
            this.Size = new System.Drawing.Size(1040, 512);
            this.Leave += new System.EventHandler(this.frmRTreatises_Leave);
            this.tableLayoutPanel13.ResumeLayout(false);
            this.tableLayoutPanel29.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel28)).EndInit();
            this.kryptonPanel28.ResumeLayout(false);
            this.kryptonPanel28.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dRTreatises)).EndInit();
            this.ResumeLayout(false);

		}
	}
}
