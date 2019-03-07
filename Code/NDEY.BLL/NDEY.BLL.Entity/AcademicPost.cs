using System;

namespace NDEY.BLL.Entity
{
	public class AcademicPost
	{
		public string AcademicPostNo
		{
			get;
			set;
		}

		public string AcademicPostSDate
		{
			get;
			set;
		}

		public string AcademicPostEDate
		{
			get;
			set;
		}

		public string AcademicPostDate
		{
			get
			{
				string text = "";
				DateTime dateTime;
				if (DateTime.TryParse(this.AcademicPostSDate, out dateTime))
				{
					text = dateTime.ToString("yyyy.M");
				}
				text += "-";
				if (DateTime.TryParse(this.AcademicPostEDate, out dateTime))
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

		public string AcademicPostOrg
		{
			get;
			set;
		}

		public string AcademicPostContent
		{
			get;
			set;
		}

		public int AcademicPostOrder
		{
			get;
			set;
		}
	}
}
