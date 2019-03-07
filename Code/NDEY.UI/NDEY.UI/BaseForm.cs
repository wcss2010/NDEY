using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace NDEY.UI
{
	public class BaseForm : Form
	{
		public delegate void AsyncDelegate();

		public delegate void MethodInvoker();

		private IContainer components;

		public BaseForm()
		{
			this.InitializeComponent();
		}

		protected void EndAsync(IAsyncResult ar)
		{
			BaseForm.AsyncDelegate asyncDelegate = (BaseForm.AsyncDelegate)ar.AsyncState;
			try
			{
				asyncDelegate.EndInvoke(ar);
			}
			catch (Exception ex)
			{
				this.OnException(ex);
			}
		}

		protected void BeginInvoke(BaseForm.AsyncDelegate del)
		{
			del.BeginInvoke(new AsyncCallback(this.EndAsync), del);
		}

		protected virtual void OnException(Exception ex)
		{
		}

		protected void UpdateUI(BaseForm.MethodInvoker uiDelegate, Form form)
		{
			if (form.InvokeRequired)
			{
				form.Invoke(uiDelegate);
				return;
			}
			uiDelegate();
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
            this.SuspendLayout();
            // 
            // BaseForm
            // 
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BaseForm";
            this.Text = "BaseForm";
            this.ResumeLayout(false);

		}
	}
}
