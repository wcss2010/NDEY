using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using NDEY.BLL.Entity;
using NDEY.BLL.Service;
using Properties;

namespace NDEY.UI
{
    public partial class frmAddUnit : KryptonForm
    {
        private UnitInforService _unitInforService = new UnitInforService();

        private UnitInfor UnitInforObj = null;

        public frmAddUnit(UnitInfor uii)
        {
            InitializeComponent();

            UnitInforObj = uii;
            if (UnitInforObj != null)
            {
                txtUnitName.Text = UnitInforObj.UnitName;
                txtUnitType.Text = UnitInforObj.UnitType;
                txtUnitBankName.Text = UnitInforObj.UnitBankName;
                txtUnitBankUser.Text = UnitInforObj.UnitBankUser;
                txtUnitBankNo.Text = UnitInforObj.UnitBankNo;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == DateTime.Now.Year.ToString())
            {
                if (string.IsNullOrEmpty(txtUnitName.Text))
                {
                    MessageBox.Show("请输入单位名称！");
                    return;
                }
                if (string.IsNullOrEmpty(txtUnitType.Text))
                {
                    MessageBox.Show("请输入单位类型！");
                    return;
                }
                if (string.IsNullOrEmpty(txtUnitBankUser.Text))
                {
                    MessageBox.Show("请输入账号名称！");
                    return;
                }
                if (string.IsNullOrEmpty(txtUnitBankName.Text))
                {
                    MessageBox.Show("请输入开户行名称！");
                    return;
                }
                if (string.IsNullOrEmpty(txtUnitBankNo.Text))
                {
                    MessageBox.Show("请输入账号！");
                    return;
                }

                if (UnitInforObj == null)
                {
                    UnitInforObj = new UnitInfor();
                }
                UnitInforObj.UnitName = txtUnitName.Text;
                UnitInforObj.UnitType = txtUnitType.Text;
                UnitInforObj.UnitBankUser = txtUnitBankUser.Text;
                UnitInforObj.UnitBankName = txtUnitBankName.Text;
                UnitInforObj.UnitBankNo = txtUnitBankNo.Text;
                UnitInforObj.IsUserAdded = 1;

                _unitInforService.UpdateUnitInfors(new List<UnitInfor>(new UnitInfor[] { UnitInforObj }));

                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("对不起，密码错误！");
            }
            
        }
    }
}