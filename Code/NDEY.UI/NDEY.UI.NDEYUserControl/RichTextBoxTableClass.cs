using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace NDEY.UI.NDEYUserControl
{
	public class RichTextBoxTableClass : RichTextBox
	{
		private static IntPtr moduleHandle;

		protected override CreateParams CreateParams
		{
			get
			{
				if (RichTextBoxTableClass.moduleHandle == IntPtr.Zero)
				{
					RichTextBoxTableClass.moduleHandle = RichTextBoxTableClass.LoadLibrary("msftedit.dll");
					if ((long)RichTextBoxTableClass.moduleHandle < 32L)
					{
						throw new Win32Exception(Marshal.GetLastWin32Error(), "Could not load Msftedit.dll");
					}
				}
				CreateParams createParams = base.CreateParams;
				createParams.ClassName = "RichEdit50W";
				if (this.Multiline)
				{
					if ((base.ScrollBars & RichTextBoxScrollBars.Horizontal) != RichTextBoxScrollBars.None && !base.WordWrap)
					{
						createParams.Style |= 1048576;
						if ((base.ScrollBars & (RichTextBoxScrollBars)16) != RichTextBoxScrollBars.None)
						{
							createParams.Style |= 8192;
						}
					}
					if ((base.ScrollBars & RichTextBoxScrollBars.Vertical) != RichTextBoxScrollBars.None)
					{
						createParams.Style |= 2097152;
						if ((base.ScrollBars & (RichTextBoxScrollBars)16) != RichTextBoxScrollBars.None)
						{
							createParams.Style |= 8192;
						}
					}
				}
				if (BorderStyle.FixedSingle == base.BorderStyle && (createParams.Style & 8388608) != 0)
				{
					createParams.Style &= -8388609;
					createParams.ExStyle |= 512;
				}
				return createParams;
			}
		}

		[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern IntPtr LoadLibrary(string path);
	}
}
