using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using NDEY.BLL.Entity;

namespace NDEY.UI.NDEYUserControl
{
    public partial class frmExtFileEditor : BaseControl
    {
        public frmExtFileEditor()
        {
            InitializeComponent();
        }

        public void btnupload_Click(object sender, EventArgs args)
        {
            if (ofdDialogs.ShowDialog() == DialogResult.OK)
            {
                lblExtFileLabel.Text = new FileInfo(ofdDialogs.FileName).Name;
            }
        }

        private void btnsave_Click(object sender, EventArgs args)
        {
            string imgFile = ofdDialogs.FileName;
            if (File.Exists(imgFile))
            {
                File.Copy(ofdDialogs.FileName, Path.Combine(EntityElement.FilesStorePath, "extFile1.png"), true);
            }
        }

        public override void RefreshCall()
        {
            base.RefreshCall();

            lblExtFileLabel.Text = string.Empty;

            if (File.Exists(Path.Combine(EntityElement.FilesStorePath, "extFile1.png")))
            {
                lblExtFileLabel.Text = "extFile1.png";
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.RefreshCall();
        }
    }
}