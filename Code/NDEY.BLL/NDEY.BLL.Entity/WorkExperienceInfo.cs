using System;

namespace NDEY.BLL.Entity
{
	public class WorkExperienceInfo
	{
		public string WorkExperienceNo
		{
			get;
			set;
		}

		public string WorkExperienceSDate
		{
			get;
			set;
		}

		public string WorkExperienceEDate
		{
			get;
			set;
		}

		public string WorkExperienceOrg
		{
			get;
			set;
		}

		public string WorkExperienceContent
		{
			get;
			set;
		}

		public int WorkExperienceOrder
		{
			get;
			set;
		}

		public string WorkExperienceDate
		{
			get
			{
				string text = "";
				DateTime dateTime;
				if (DateTime.TryParse(this.WorkExperienceSDate, out dateTime))
				{
					text = dateTime.ToString("yyyy.M");
				}
				text += "-";
				if (DateTime.TryParse(this.WorkExperienceEDate, out dateTime))
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
	}
}
