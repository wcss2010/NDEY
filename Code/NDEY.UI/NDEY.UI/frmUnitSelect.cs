using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using DevExpress.XtraGrid.Columns;
using NDEY.BLL.Entity;
using NDEY.BLL.Service;
using Properties;

namespace NDEY.UI
{
    public partial class frmUnitSelect : KryptonForm
    {
        public UnitInfor SelectedUnitInfor { get; set; }

        UnitInforService _unitInforService = new UnitInforService();

        public frmUnitSelect(string unitID)
        {
            InitializeComponent();

            ((DataGridViewImageColumn)dgvDetail.Columns[dgvDetail.Columns.Count - 1]).Image = Resources.DELETE_28;
            UpdateUnitList();

            leSearchList.EditValue = unitID;
        }

        public frmUnitSelect() : this(string.Empty) { }

        private void UpdateUnitList()
        {
            dgvDetail.Rows.Clear();
            var unitList = _unitInforService.GetUnitInforList();

            leSearchList.Properties.DataSource = unitList;
            leSearchList.Properties.DisplayMember = "UnitBankNo";
            leSearchList.Properties.ValueMember = "ID";

            int rrIndex = 0;
            foreach (UnitInfor unit in unitList)
            {
                rrIndex++;
                List<object> cells = new List<object>();
                cells.Add(rrIndex);
                cells.Add(unit.UnitName);
                cells.Add(unit.UnitType);
                cells.Add(unit.UnitBankUser);
                cells.Add(unit.UnitBankName);
                cells.Add(unit.UnitBankNo);
                cells.Add(unit.IsUserAdded >= 1 ? true : false);

                int rIndex = dgvDetail.Rows.Add(cells.ToArray());
                dgvDetail.Rows[rIndex].Tag = unit;
            }
        }

        private void UpdateUnitList(string[] idList)
        {
            dgvDetail.Rows.Clear();
            var unitList = _unitInforService.GetUnitInforList(idList);
            int rrIndex = 0;
            foreach (UnitInfor unit in unitList)
            {
                rrIndex++;
                List<object> cells = new List<object>();
                cells.Add(rrIndex);
                cells.Add(unit.UnitName);
                cells.Add(unit.UnitType);
                cells.Add(unit.UnitBankUser);
                cells.Add(unit.UnitBankName);
                cells.Add(unit.UnitBankNo);
                cells.Add(unit.IsUserAdded >= 1 ? true : false);

                int rIndex = dgvDetail.Rows.Add(cells.ToArray());
                dgvDetail.Rows[rIndex].Tag = unit;
            }
        }

        private void dgvDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvDetail.Columns.Count - 1)
            {
                if (dgvDetail.Rows[e.RowIndex].Tag != null)
                {
                    UnitInfor uii = (UnitInfor)dgvDetail.Rows[e.RowIndex].Tag;

                    if (uii.IsUserAdded == 0)
                    {
                        MessageBox.Show("对不起，只能删除用户添加的数据！");
                    }
                    else
                    {
                        if (MessageBox.Show("真的要删除吗？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            _unitInforService.DeleteUnitInfors(new List<string>(new string[] { uii.ID }));
                            UpdateUnitList();
                        }
                    }                    
                }
                else
                {
                    if (dgvDetail.Rows.Count > e.RowIndex)
                    {
                        if (MessageBox.Show("真的要删除吗？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            dgvDetail.Rows.RemoveAt(e.RowIndex);
                        }
                    }
                }
            }
        }

        private void dgvDetail_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dgvDetail.SelectedRows.Count >= 1 && dgvDetail.SelectedRows[0].Tag != null)
            {
                UnitInfor unitObj = (UnitInfor)dgvDetail.SelectedRows[0].Tag;
                if (unitObj.IsUserAdded == 1)
                {
                    frmAddUnit addUnit = new frmAddUnit(unitObj);
                    if (addUnit.ShowDialog() == DialogResult.OK)
                    {
                        UpdateUnitList();
                    }
                }
                else
                {
                    MessageBox.Show("对不起，只能编辑用户自定义的单位！");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (dgvDetail.SelectedRows.Count >= 1 && dgvDetail.SelectedRows[0].Tag != null)
            {
                UnitInfor uir = (UnitInfor)dgvDetail.SelectedRows[0].Tag;
                SelectedUnitInfor = uir;
                DialogResult = DialogResult.OK;
            }
        }

        private void dgvDetail_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            ((DataGridViewImageCell)dgvDetail.Rows[e.RowIndex].Cells[dgvDetail.Columns.Count - 1]).Value = Resources.DELETE_28;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddUnit addUnit = new frmAddUnit(null);
            if (addUnit.ShowDialog() == DialogResult.OK)
            {
                UpdateUnitList();
            }
        }

        private void leSearchList_EditValueChanged(object sender, EventArgs e)
        {
            if (leSearchList.EditValue != null)
            {
                List<string> idList = new List<string>();
                idList.Add(leSearchList.EditValue.ToString());

                UpdateUnitList(idList.ToArray());
            }
            else
            {
                UpdateUnitList();
            }
        }

        private void dgvDetail_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDetail.Rows[e.RowIndex].Tag != null)
            {
                UnitInfor uir = (UnitInfor)dgvDetail.Rows[e.RowIndex].Tag;
                SelectedUnitInfor = uir;
                DialogResult = DialogResult.OK;
            }
        }
    }

    public class BankSelectButton : KryptonButton
    {
        UnitInforService _unitInforService = new UnitInforService();

        public BankSelectButton() : base()
        {
            Text = "请选择开户帐号！";
        }

        public event System.EventHandler EditValueChanged;

        private object _editValue = null;

        public string DefaultEditText { get; set; }

        public object EditValue
        {
            get
            {
                return _editValue;
            }

            set
            {
                _editValue = value;
                if (value != null)
                {
                    EditText = DefaultEditText;
                    IList<UnitInfor> list = _unitInforService.GetUnitInforList(new string[] { value.ToString() });
                    foreach (UnitInfor ui in list)
                    {
                        EditText = ui.UnitBankNo;
                        break;
                    }
                }
                else
                {
                    EditText = DefaultEditText;
                }
            }
        }

        public string EditText
        {
            get { return Text; }

            set { Text = value; }
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);

            frmUnitSelect selectForm = new frmUnitSelect(EditValue != null ? EditValue.ToString() : string.Empty);
            if (selectForm.ShowDialog() == DialogResult.OK)
            {
                EditValue = selectForm.SelectedUnitInfor.ID;
                EditText = selectForm.SelectedUnitInfor.UnitBankNo;

                if (EditValueChanged != null)
                {
                    EditValueChanged(this, new EventArgs());
                }
            }
        }
    }
}