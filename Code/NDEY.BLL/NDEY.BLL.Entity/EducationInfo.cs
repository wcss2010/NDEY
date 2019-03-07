using System;

namespace NDEY.BLL.Entity
{
	public class EducationInfo : BaseMessage
	{
		public string EducationNo
		{
			get;
			set;
		}

		public string EducationSDate
		{
			get;
			set;
		}

		public string EducationEDate
		{
			get;
			set;
		}

		public string EducationDate
		{
			get
			{
				string text = "";
				DateTime dateTime;
				if (DateTime.TryParse(this.EducationSDate, out dateTime))
				{
					text = dateTime.ToString("yyyy.M");
				}
				text += "-";
				if (DateTime.TryParse(this.EducationEDate, out dateTime))
				{
					text += dateTime.ToString("yyyy.M");
				}
				else
				{
					text += "至今";
				}
				return text;
			}
		}

		public string EducationOrg
		{
			get;
			set;
		}

		public string EducationMajor
		{
			get;
			set;
		}

		public string EducationDegree
		{
			get;
			set;
		}

		public int EducationOrder
		{
			get;
			set;
		}
	}
}
