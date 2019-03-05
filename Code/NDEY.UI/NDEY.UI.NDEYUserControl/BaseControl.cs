using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace NDEY.UI.NDEYUserControl
{
	public class BaseControl : UserControl
	{
		public delegate void SavePreCheckPassedHandler(object sender, EventArgs e);

		public delegate void SavePreCheckDenyHandler(object sender, EventArgs e);

		public delegate void AsyncDelegate();

		public delegate void MethodInvoker();

		private IContainer components;

		public event BaseControl.SavePreCheckPassedHandler OnSaveCheckPassed;

		public event BaseControl.SavePreCheckDenyHandler OnSaveCheckDeny;

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
			this.components = new Container();
			//base.AutoScaleMode = AutoScaleMode.Font;
		}

		public BaseControl()
		{
			this.InitializeComponent();
		}

		public virtual void RefreshCall()
		{
		}

		protected virtual void OnSaveCheckPassedEvent(EventArgs e)
		{
			if (this.OnSaveCheckPassed != null)
			{
				this.OnSaveCheckPassed(this, e);
			}
		}

		protected virtual void OnSaveCheckDenyEvent(EventArgs e)
		{
			if (this.OnSaveCheckDeny != null)
			{
				this.OnSaveCheckDeny(this, e);
			}
		}

		protected void EndAsync(IAsyncResult ar)
		{
			BaseControl.AsyncDelegate asyncDelegate = (BaseControl.AsyncDelegate)ar.AsyncState;
			try
			{
				asyncDelegate.EndInvoke(ar);
			}
			catch (Exception ex)
			{
				this.OnException(ex);
			}
		}

		protected void BeginInvoke(BaseControl.AsyncDelegate del)
		{
			del.BeginInvoke(new AsyncCallback(this.EndAsync), del);
		}

		protected virtual void OnException(Exception ex)
		{
		}

		protected void UpdateUI(BaseControl.MethodInvoker uiDelegate, Control form)
		{
			if (form.InvokeRequired)
			{
				form.Invoke(uiDelegate);
				return;
			}
			uiDelegate();
		}
	}
}
