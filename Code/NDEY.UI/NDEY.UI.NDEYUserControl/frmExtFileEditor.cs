using System;
using System.Windows.Forms;
using System.IO;
using NDEY.BLL.Entity;

namespace NDEY.UI.NDEYUserControl
{
    public partial class frmExtFileEditor : BaseControl
    {
        public static bool IsUploadedExtFile = false;
        private string lastFile = string.Empty;

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
                if (File.Exists(lastFile))
                {
                    File.Delete(lastFile);
                }

                lastFile = Path.Combine(EntityElement.FilesStorePath, "extFile_" + new FileInfo(imgFile).Name);
                File.Copy(imgFile, lastFile, true);
                IsUploadedExtFile = true;

                MessageBox.Show("保存完成!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        public override void RefreshCall()
        {
            base.RefreshCall();

            lblExtFileLabel.Text = string.Empty;
            string[] filess = Directory.GetFiles(EntityElement.FilesStorePath);
            foreach (string ss in filess)
            {
                if (ss.Contains("extFile_"))
                {
                    lastFile = ss;
                    lblExtFileLabel.Text = new FileInfo(lastFile.Replace("extFile_", string.Empty)).Name;
                    IsUploadedExtFile = true;
                }
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.RefreshCall();
        }

        private void lblExtFileLabel_Click(object sender, EventArgs e)
        {
            if (File.Exists(lastFile))
            {
                try
                {
                    System.Diagnostics.Process.Start(lastFile);
                }
                catch (Exception ex) { }
            }
        }
    }
}