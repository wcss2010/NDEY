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

        public override void RefreshCall()
        {
            base.RefreshCall();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            dpContent.initEditor("保密资质.doc", string.Empty, EntityElement.FilesStorePath, Path.Combine(Application.StartupPath, Path.Combine("Helper", "secretPaste.doc")), Path.Combine(Application.StartupPath, Path.Combine("Helper", "documentPasteReadme2.rtf")));
        }
    }
}