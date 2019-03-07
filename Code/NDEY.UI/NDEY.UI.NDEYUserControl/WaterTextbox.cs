using System;
using System.Drawing;
using System.Windows.Forms;

namespace NDEY.UI.NDEYUserControl
{
	public class WaterTextbox : TextBox
	{
		public const int WM_PAINT = 15;

		private Color _emptyTextTipColor = Color.DarkGray;

		public string EmptyTextTip
		{
			get;
			set;
		}

		protected override void WndProc(ref Message m)
		{
			base.WndProc(ref m);
			if (m.Msg == 15)
			{
				this.WmPaint(ref m);
			}
		}

		private void WmPaint(ref Message m)
		{
			Rectangle bounds = new Rectangle(0, 0, base.Width, base.Height);
			using (Graphics graphics = Graphics.FromHwnd(base.Handle))
			{
				if (this.Text.Length == 0 && !string.IsNullOrEmpty(this.EmptyTextTip) && !this.Focused)
				{
					TextFormatFlags textFormatFlags = TextFormatFlags.EndEllipsis | TextFormatFlags.WordBreak;
					if (this.RightToLeft == RightToLeft.Yes)
					{
						textFormatFlags |= (TextFormatFlags.Right | TextFormatFlags.RightToLeft);
					}
					TextRenderer.DrawText(graphics, this.EmptyTextTip, this.Font, bounds, this._emptyTextTipColor, textFormatFlags);
				}
			}
		}
	}
}
