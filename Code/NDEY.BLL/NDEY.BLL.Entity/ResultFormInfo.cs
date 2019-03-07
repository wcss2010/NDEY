using System;

namespace NDEY.BLL.Entity
{
	public class ResultFormInfo
	{
		public bool IsCBR1Checked
		{
			get;
			set;
		}

		public bool IsCBR2Checked
		{
			get;
			set;
		}

		public bool IsCBR3Checked
		{
			get;
			set;
		}

		public bool IsCBR4Checked
		{
			get;
			set;
		}

		public bool IsCBR5Checked
		{
			get;
			set;
		}

		public bool IsCBR6Checked
		{
			get;
			set;
		}

		public bool IsCBR7Checked
		{
			get;
			set;
		}

		public bool IsCBR8Checked
		{
			get;
			set;
		}

		public bool IsCBR9Checked
		{
			get;
			set;
		}

		public bool IsCBR10Checked
		{
			get;
			set;
		}

		public bool IsCBR11Checked
		{
			get;
			set;
		}

		public bool IsCBR12Checked
		{
			get;
			set;
		}

		public string CBROtherText
		{
			get;
			set;
		}

		public string GetDescription()
		{
			string text = "";
			if (this.IsCBR1Checked)
			{
				text += "样品、";
			}
			if (this.IsCBR2Checked)
			{
				text += "样机、";
			}
			if (this.IsCBR3Checked)
			{
				text += "数据库、";
			}
			if (this.IsCBR4Checked)
			{
				text += "试验（演示）系统、";
			}
			if (this.IsCBR5Checked)
			{
				text += "软件、";
			}
			if (this.IsCBR6Checked)
			{
				text += "仿真模型、";
			}
			if (this.IsCBR7Checked)
			{
				text += "工程工艺、";
			}
			if (this.IsCBR8Checked)
			{
				text += "标准（规范）、";
			}
			if (this.IsCBR9Checked)
			{
				text += "论文、";
			}
			if (this.IsCBR10Checked)
			{
				text += "专利、";
			}
			if (this.IsCBR11Checked)
			{
				text += "研究报告、";
			}
			if (this.IsCBR12Checked)
			{
				text += "试验方案（报告）、";
			}
			if (this.CBROtherText != "")
			{
				text += this.CBROtherText;
			}
			text = text.TrimEnd(new char[]
			{
				'、'
			});
			if (text != string.Empty)
			{
				text += "。";
			}
			return text;
		}
	}
}
