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
	public class frmNDPatent : BaseControl
	{
		private IContainer components;

		private TableLayoutPanel tableLayoutPanel15;

		private KryptonPanel kryptonPanel30;

		private KryptonLabel kryptonLabel118;

		private KryptonDataGridView dnp;

		private TableLayoutPanel tableLayoutPanel1;

		private KryptonButton btnsave;

		private KryptonButton btnnext;

		private KryptonLabel kryptonLabel1;

		private NDPatentService _nDPatentService = new NDPatentService();

		private IList<string> _deletedNo = new List<string>();
        private DataGridViewTextBoxColumn patentid;
        private DataGridViewTextBoxColumn patentname;
        private DataGridViewTextBoxColumn patentno;
        private KryptonDataGridViewComboBoxColumn patenttype;
        private CalendarColumnYM patentauthorizedate;
        private DataGridViewTextBoxColumn userpatentorder;
        private DataGridViewImageColumn patentattup;
        private KryptonDataGridViewLinkColumn patentattinfo;
        private DataGridViewTextBoxColumn hiddenStorenName;
        private DataGridViewTextBoxColumn UpLoadPath;
        private DataGridViewTextBoxColumn ndOrder;
        private DataGridViewImageColumn patentup;
        private DataGridViewImageColumn patentdown;
        private DataGridViewImageColumn patentdel;
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel15 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnnext = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnsave = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonPanel30 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel118 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.dnp = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.patentid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patentname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patentno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patenttype = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewComboBoxColumn();
            this.patentauthorizedate = new NDEY.UI.NDEYUserControl.CalendarColumnYM();
            this.userpatentorder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patentattup = new System.Windows.Forms.DataGridViewImageColumn();
            this.patentattinfo = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewLinkColumn();
            this.hiddenStorenName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpLoadPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ndOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patentup = new System.Windows.Forms.DataGridViewImageColumn();
            this.patentdown = new System.Windows.Forms.DataGridViewImageColumn();
            this.patentdel = new System.Windows.Forms.DataGridViewImageColumn();
            this.tableLayoutPanel15.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel30)).BeginInit();
            this.kryptonPanel30.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dnp)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel15
            // 
            this.tableLayoutPanel15.ColumnCount = 3;
            this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel15.Controls.Add(this.tableLayoutPanel1, 1, 3);
            this.tableLayoutPanel15.Controls.Add(this.kryptonPanel30, 1, 1);
            this.tableLayoutPanel15.Controls.Add(this.dnp, 1, 2);
            this.tableLayoutPanel15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel15.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel15.Name = "tableLayoutPanel15";
            this.tableLayoutPanel15.RowCount = 5;
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel15.Size = new System.Drawing.Size(1035, 619);
            this.tableLayoutPanel15.TabIndex = 2;
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(53, 562);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(929, 34);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // btnnext
            // 
            this.btnnext.Location = new System.Drawing.Point(832, 3);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(90, 25);
            this.btnnext.TabIndex = 1;
            this.btnnext.Values.Text = "下一页";
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(729, 3);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(90, 25);
            this.btnsave.TabIndex = 0;
            this.btnsave.Values.Text = "保存";
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // kryptonPanel30
            // 
            this.kryptonPanel30.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel30.Controls.Add(this.kryptonLabel118);
            this.kryptonPanel30.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel30.Location = new System.Drawing.Point(50, 20);
            this.kryptonPanel30.Margin = new System.Windows.Forms.Padding(0);
            this.kryptonPanel30.Name = "kryptonPanel30";
            this.kryptonPanel30.Size = new System.Drawing.Size(935, 80);
            this.kryptonPanel30.TabIndex = 0;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(3, 36);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(308, 41);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("仿宋_GB2312", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.kryptonLabel1.TabIndex = 1;
            this.kryptonLabel1.Values.Text = "1.附件材料需为PDF或者JPG格式。\r\n2.提交纸质材料时，附件需要完整打印。";
            // 
            // kryptonLabel118
            // 
            this.kryptonLabel118.Location = new System.Drawing.Point(3, 10);
            this.kryptonLabel118.Name = "kryptonLabel118";
            this.kryptonLabel118.Size = new System.Drawing.Size(334, 27);
            this.kryptonLabel118.StateCommon.LongText.Font = new System.Drawing.Font("楷体_GB2312", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.kryptonLabel118.StateCommon.ShortText.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.kryptonLabel118.TabIndex = 0;
            this.kryptonLabel118.Values.ExtraText = "（10项以内）";
            this.kryptonLabel118.Values.Text = "八、国家及国防专利情况";
            // 
            // dnp
            // 
            this.dnp.AllowUserToResizeRows = false;
            this.dnp.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dnp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.patentid,
            this.patentname,
            this.patentno,
            this.patenttype,
            this.patentauthorizedate,
            this.userpatentorder,
            this.patentattup,
            this.patentattinfo,
            this.hiddenStorenName,
            this.UpLoadPath,
            this.ndOrder,
            this.patentup,
            this.patentdown,
            this.patentdel});
            this.dnp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dnp.Location = new System.Drawing.Point(53, 103);
            this.dnp.MultiSelect = false;
            this.dnp.Name = "dnp";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("仿宋_GB2312", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dnp.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dnp.RowTemplate.Height = 28;
            this.dnp.Size = new System.Drawing.Size(929, 453);
            this.dnp.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.dnp.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dnp.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dnp.StateCommon.HeaderColumn.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.dnp.TabIndex = 1;
            this.dnp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dnp_CellContentClick);
            this.dnp.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dnp_RowsAdded);
            // 
            // patentid
            // 
            this.patentid.HeaderText = "序号";
            this.patentid.Name = "patentid";
            this.patentid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.patentid.Visible = false;
            this.patentid.Width = 40;
            // 
            // patentname
            // 
            this.patentname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.patentname.HeaderText = "专利名称";
            this.patentname.MinimumWidth = 100;
            this.patentname.Name = "patentname";
            this.patentname.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // patentno
            // 
            this.patentno.HeaderText = "专利号";
            this.patentno.Name = "patentno";
            this.patentno.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.patentno.Width = 160;
            // 
            // patenttype
            // 
            this.patenttype.DropDownWidth = 121;
            this.patenttype.HeaderText = "专利类型";
            this.patenttype.Items.AddRange(new string[] {
            "国防",
            "国家"});
            this.patenttype.Name = "patenttype";
            this.patenttype.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.patenttype.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.patenttype.Width = 100;
            // 
            // patentauthorizedate
            // 
            this.patentauthorizedate.HeaderText = "授权日期";
            this.patentauthorizedate.Name = "patentauthorizedate";
            this.patentauthorizedate.Width = 120;
            // 
            // userpatentorder
            // 
            this.userpatentorder.HeaderText = "排名";
            this.userpatentorder.Name = "userpatentorder";
            this.userpatentorder.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.userpatentorder.Width = 50;
            // 
            // patentattup
            // 
            this.patentattup.HeaderText = "附件";
            this.patentattup.Name = "patentattup";
            this.patentattup.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.patentattup.Width = 45;
            // 
            // patentattinfo
            // 
            this.patentattinfo.HeaderText = "附件信息";
            this.patentattinfo.Name = "patentattinfo";
            this.patentattinfo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.patentattinfo.Width = 150;
            // 
            // hiddenStorenName
            // 
            this.hiddenStorenName.HeaderText = "存储名称";
            this.hiddenStorenName.Name = "hiddenStorenName";
            this.hiddenStorenName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.hiddenStorenName.Visible = false;
            // 
            // UpLoadPath
            // 
            this.UpLoadPath.HeaderText = "UpLoadPath";
            this.UpLoadPath.Name = "UpLoadPath";
            this.UpLoadPath.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.UpLoadPath.Visible = false;
            // 
            // ndOrder
            // 
            this.ndOrder.HeaderText = "排序";
            this.ndOrder.Name = "ndOrder";
            this.ndOrder.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ndOrder.Visible = false;
            // 
            // patentup
            // 
            this.patentup.HeaderText = "上移";
            this.patentup.Name = "patentup";
            this.patentup.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.patentup.Width = 45;
            // 
            // patentdown
            // 
            this.patentdown.HeaderText = "下移";
            this.patentdown.Name = "patentdown";
            this.patentdown.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.patentdown.Width = 45;
            // 
            // patentdel
            // 
            this.patentdel.HeaderText = "删除";
            this.patentdel.Name = "patentdel";
            this.patentdel.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.patentdel.Width = 45;
            // 
            // frmNDPatent
            // 
            this.Controls.Add(this.tableLayoutPanel15);
            this.Name = "frmNDPatent";
            this.Size = new System.Drawing.Size(1035, 619);
            this.Leave += new System.EventHandler(this.frmNDPatent_Leave);
            this.tableLayoutPanel15.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel30)).EndInit();
            this.kryptonPanel30.ResumeLayout(false);
            this.kryptonPanel30.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dnp)).EndInit();
            this.ResumeLayout(false);

		}

		public frmNDPatent()
		{
			this.InitializeComponent();
		}

		protected override void OnLoad(EventArgs e)
		{
			this.RefreshCall();
			base.OnLoad(e);
		}

		private void LoadData(IList<NDPatent> list)
		{
			this.dnp.Rows.Clear();
			foreach (NDPatent current in list)
			{
				DataGridViewRow dataGridViewRow = new DataGridViewRow();
				int rowIndex = this.dnp.Rows.Add(dataGridViewRow);
				this.dnp["patentid", rowIndex].Value = current.NDPatentNo;
				this.dnp["patentname", rowIndex].Value = current.NDPatentName;
                this.dnp["patenttype", rowIndex].Value = current.NDPatentType;
                this.dnp["patentno", rowIndex].Value = current.NDPatentNumber;
				DateTime dateTime;
				if (current.NDPatentApprovalYear != string.Empty && DateTime.TryParse(current.NDPatentApprovalYear, out dateTime))
				{
					this.dnp["patentauthorizedate", rowIndex].Value = dateTime;
				}
				else
				{
					this.dnp["patentauthorizedate", rowIndex].Value = DBNull.Value;
				}
				this.dnp["userpatentorder", rowIndex].Value = current.NDPatentApplicants;
				this.dnp["patentattinfo", rowIndex].Value = current.NDPatentPDFOName;
				this.dnp["hiddenStorenName", rowIndex].Value = current.NDPatentPDF;
				this.dnp["UpLoadPath", rowIndex].Value = "";
				this.dnp["ndOrder", rowIndex].Value = current.NDPatentOrder;
			}
		}

		private void dnp_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
            //if (e.ColumnIndex == 3)
            //{
            //    frmSuperComboboxForm scf = new frmSuperComboboxForm();
            //    scf.Text = "请选择专利类型！";
            //    List<string> list = new List<string>();
            //    list.Add("国防");
            //    list.Add("国家");
            //    scf.InitComboboxList(list.ToArray());
            //    scf.SelectItem(this.dnp.Rows[e.RowIndex].Cells[3].Value != null ? this.dnp.Rows[e.RowIndex].Cells[3].Value.ToString() : string.Empty);
            //    if (scf.ShowDialog() == DialogResult.OK)
            //    {
            //        this.dnp.Rows[e.RowIndex].Cells[3].Value = scf.SelectedItem;
            //    }
            //}

			int columnIndex = e.ColumnIndex;
			int rowIndex = e.RowIndex;
			if (rowIndex == -1)
			{
				return;
			}
			if (this.dnp.Columns[columnIndex].Name == "patentup")
			{
				if (rowIndex == 0 || rowIndex == this.dnp.RowCount - 1)
				{
					return;
				}
				DataGridViewRow dataGridViewRow = this.dnp.Rows[rowIndex];
				this.dnp.Rows.Remove(dataGridViewRow);
				this.dnp.Rows.Insert(rowIndex - 1, dataGridViewRow);
				this.dnp.ClearSelection();
				return;
			}
			else if (this.dnp.Columns[columnIndex].Name == "patentdown")
			{
				if (rowIndex >= this.dnp.RowCount - 2)
				{
					return;
				}
				DataGridViewRow dataGridViewRow2 = this.dnp.Rows[rowIndex];
				this.dnp.Rows.Remove(dataGridViewRow2);
				this.dnp.Rows.Insert(rowIndex + 1, dataGridViewRow2);
				this.dnp.ClearSelection();
				return;
			}
			else
			{
				if (!(this.dnp.Columns[columnIndex].Name == "patentdel"))
				{
					if (this.dnp.Columns[columnIndex].Name == "patentattup")
					{
						OpenFileDialog openFileDialog = new OpenFileDialog();
						openFileDialog.Filter = "Adobe PDF 文件,JPEG图像文件|*.pdf;*.jpg;*.jpeg";
						openFileDialog.Multiselect = false;
						if (openFileDialog.ShowDialog() == DialogResult.OK)
						{
							this.dnp["patentattinfo", rowIndex].Value = openFileDialog.FileName;
							this.dnp["UpLoadPath", rowIndex].Value = openFileDialog.FileName;
							return;
						}
					}
					else if (this.dnp.Columns[columnIndex].Name == "patentattinfo")
					{
						if (this.dnp["hiddenStorenName", rowIndex].Value != null)
						{
							if (File.Exists(Path.Combine(EntityElement.FilesStorePath, this.dnp["hiddenStorenName", rowIndex].Value.ToString())))
							{
								FileOp.OpenFile(Path.Combine(EntityElement.FilesStorePath, this.dnp["hiddenStorenName", rowIndex].Value.ToString()));
								return;
							}
							MessageBox.Show("文件不存在。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
							return;
						}
						else if (this.dnp["UpLoadPath", rowIndex].Value != null)
						{
							if (File.Exists(this.dnp["UpLoadPath", rowIndex].Value.ToString()))
							{
								FileOp.OpenFile(this.dnp["UpLoadPath", rowIndex].Value.ToString());
								return;
							}
							MessageBox.Show("文件不存在。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						}
					}
					return;
				}
				if (rowIndex == this.dnp.RowCount - 1)
				{
					return;
				}
				DataGridViewRow dataGridViewRow3 = this.dnp.Rows[rowIndex];
				if (dataGridViewRow3.Cells["patentid"].Value != null)
				{
					string str = "";
					if (dataGridViewRow3.Cells["hiddenStorenName"].Value != null && dataGridViewRow3.Cells["hiddenStorenName"].Value != DBNull.Value)
					{
						str = dataGridViewRow3.Cells["hiddenStorenName"].Value.ToString();
					}
					this._deletedNo.Add(dataGridViewRow3.Cells["patentid"].Value.ToString() + "|" + str);
					this._nDPatentService.DeleteNDPatents(this._deletedNo);
					this._deletedNo.Clear();
				}
				this.dnp.Rows.Remove(dataGridViewRow3);
				this.dnp.ClearSelection();
				return;
			}
		}

		private void btnrefresh_Click(object sender, EventArgs e)
		{
			this._deletedNo.Clear();
			IList<NDPatent> nDPatent = this._nDPatentService.GetNDPatent();
			this.LoadData(nDPatent);
		}

		private bool SaveProgress()
		{
			this.OnSaveCheckDenyEvent(EventArgs.Empty);
			IList<NDPatent> list = new List<NDPatent>();
			for (int i = 0; i < this.dnp.RowCount - 1; i++)
			{
				DataGridViewRow dataGridViewRow = this.dnp.Rows[i];
				NDPatent nDPatent = new NDPatent();
				nDPatent.NDPatentNo = ((dataGridViewRow.Cells["patentid"].Value == null) ? "" : dataGridViewRow.Cells["patentid"].Value.ToString());
				nDPatent.NDPatentName = ((dataGridViewRow.Cells["patentname"].Value == null || dataGridViewRow.Cells["patentname"].Value == DBNull.Value) ? "" : dataGridViewRow.Cells["patentname"].Value.ToString());
                nDPatent.NDPatentType = ((dataGridViewRow.Cells["patenttype"].Value == null || dataGridViewRow.Cells["patenttype"].Value == DBNull.Value) ? "" : dataGridViewRow.Cells["patenttype"].Value.ToString());
                nDPatent.NDPatentNumber = ((dataGridViewRow.Cells["patentno"].Value == null || dataGridViewRow.Cells["patentno"].Value == DBNull.Value) ? "" : dataGridViewRow.Cells["patentno"].Value.ToString());
				nDPatent.NDPatentApprovalYear = ((dataGridViewRow.Cells["patentauthorizedate"].Value == null || dataGridViewRow.Cells["patentauthorizedate"].Value == DBNull.Value || dataGridViewRow.Cells["patentauthorizedate"].Value.ToString() == "") ? "" : ((DateTime)dataGridViewRow.Cells["patentauthorizedate"].Value).ToString("yyyy-MM-dd"));
				nDPatent.NDPatentApplicants = ((dataGridViewRow.Cells["userpatentorder"].Value == null || dataGridViewRow.Cells["userpatentorder"].Value == DBNull.Value) ? "" : dataGridViewRow.Cells["userpatentorder"].Value.ToString());
				nDPatent.NDPatentPDFOName = ((dataGridViewRow.Cells["patentattinfo"].Value == null || dataGridViewRow.Cells["patentattinfo"].Value == DBNull.Value) ? "" : dataGridViewRow.Cells["patentattinfo"].Value.ToString());
				nDPatent.NDPatentPDF = ((dataGridViewRow.Cells["hiddenStorenName"].Value == null || dataGridViewRow.Cells["hiddenStorenName"].Value == DBNull.Value) ? "" : dataGridViewRow.Cells["hiddenStorenName"].Value.ToString());
				nDPatent.UpLoadFullPath = ((dataGridViewRow.Cells["UpLoadPath"].Value == null || dataGridViewRow.Cells["UpLoadPath"].Value == DBNull.Value) ? "" : dataGridViewRow.Cells["UpLoadPath"].Value.ToString());
				nDPatent.NDPatentOrder = this.dnp.RowCount - i;
				if (nDPatent.NDPatentName == "" || nDPatent.NDPatentNumber == "" || nDPatent.NDPatentApprovalYear == "" || nDPatent.NDPatentApplicants == "" || nDPatent.NDPatentPDFOName == "")
				{
					MessageBox.Show("所有字段均为必填字段，发明专利、国防专利需要上传对应的PDF支撑文件", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return false;
				}
				int num;
				if (!int.TryParse(nDPatent.NDPatentApplicants, out num))
				{
					MessageBox.Show("录入的排名有非整数数据", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return false;
				}
				DateTime.Parse(nDPatent.NDPatentApprovalYear);
				list.Add(nDPatent);
			}
			if (list.Count > 10)
			{
				MessageBox.Show("录入的发明专利、国防专利情况记录条数超过10条", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return false;
			}
			this.OnSaveCheckPassedEvent(EventArgs.Empty);
			this._nDPatentService.UpdateNDPatents(list);
			list = this._nDPatentService.GetNDPatent();
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
			KryptonNavigator kryptonNavigator = (KryptonNavigator)base.Parent.Parent.Parent.Parent.Parent.Parent;
			kryptonNavigator.SelectedIndex++;
			kryptonNavigator.SelectedPage.Enabled = true;
		}

		private void dnp_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
		{
            this.dnp["patentup", e.RowIndex].Value = global::Properties.Resource.UP_16;
            this.dnp["patentdown", e.RowIndex].Value = global::Properties.Resource.DOWN_16;
            this.dnp["patentdel", e.RowIndex].Value = global::Properties.Resource.DELETE_28;
            this.dnp["patentattup", e.RowIndex].Value = global::Properties.Resource.Attachment_16;
		}

		public override void RefreshCall()
		{
			IList<NDPatent> nDPatent = this._nDPatentService.GetNDPatent();
			this.LoadData(nDPatent);
		}

		private void frmNDPatent_Leave(object sender, EventArgs e)
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