using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NDEY.UI
{
    public partial class frmSuperComboboxForm : Form
    {
        public string SelectedItem { get; private set; }

        public frmSuperComboboxForm()
        {
            InitializeComponent();
        }

        public void InitComboboxList(object[] items)
        {
            if (items != null)
            {
                cbxItemList.Items.AddRange(items);
            }
        }

        public void SelectItem(string itemText)
        {
            if (itemText != null)
            {
                if (itemText.StartsWith(lblElseText.Text))
                {
                    cbIsUseElseText.Checked = true;
                    txtElseItem.Text = itemText.Replace(lblElseText.Text, string.Empty).Trim();
                }
                else
                {
                    int objIndex = cbxItemList.Items.IndexOf(itemText);
                    if (objIndex >= 0)
                    {
                        cbxItemList.SelectedIndex = objIndex;
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (cbIsUseList.Checked)
            {
                //列表
                if (string.IsNullOrEmpty(cbxItemList.Text))
                {
                    return;
                }

                SelectedItem = cbxItemList.Text;
            }
            else
            {
                //其它
                if (string.IsNullOrEmpty(txtElseItem.Text))
                {
                    return;
                }

                SelectedItem = lblElseText.Text + txtElseItem.Text;
            }

            DialogResult = DialogResult.OK;
        }

        private void cbIsUseList_CheckedChanged(object sender, EventArgs e)
        {
            if (cbIsUseList.Checked)
            {
                cbIsUseElseText.Checked = false;

                cbxItemList.Enabled = true;
                txtElseItem.Enabled = false;
            }
            else
            {
                cbIsUseElseText.Checked = true;
            }
        }

        private void cbIsUseElseText_CheckedChanged(object sender, EventArgs e)
        {
            if (cbIsUseElseText.Checked)
            {
                cbIsUseList.Checked = false;

                cbxItemList.Enabled = false;
                txtElseItem.Enabled = true;
            }
            else
            {
                cbIsUseList.Checked = true;
            }
        }

        private void lblItemList_Click(object sender, EventArgs e)
        {
            cbIsUseList.Checked = !cbIsUseList.Checked;
        }

        private void lblElseText_Click(object sender, EventArgs e)
        {
            cbIsUseElseText.Checked = !cbIsUseElseText.Checked;
        }

        public override string Text
        {
            get
            {
                return base.Text;
            }

            set
            {
                base.Text = value;

                lblTitle.Text = "先从列表中选，若" + value.Replace("请选择", string.Empty).Replace("!", string.Empty).Replace("！", string.Empty) + "类别不在列表中的，选其它";
            }
        }
    }
}