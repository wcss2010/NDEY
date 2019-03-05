using System;

namespace NDEY.BLL.Entity
{
	public class NDProject
	{
		public string NDProjectNo
		{
			get;
			set;
		}

		public string NDProjectSYear
		{
			get;
			set;
		}

		public string NDProjectEYear
		{
			get;
			set;
		}

		public string NDProjectDate
		{
			get
			{
				string text = "";
				DateTime dateTime;
				if (DateTime.TryParse(this.NDProjectSYear, out dateTime))
				{
					text = dateTime.ToString("yyyy.M");
				}
				text += "-";
				if (DateTime.TryParse(this.NDProjectEYear, out dateTime))
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

		public string NDProjectName
		{
			get;
			set;
		}

		public string NDProjectType
		{
			get;
			set;
		}

		public string NDProjectSource
		{
			get;
			set;
		}

		public string NDProjectOutlay
		{
			get;
			set;
		}

		public string NDProjectTaskBySelf
		{
			get;
			set;
		}

		public string NDProjectUserOrder
		{
			get;
			set;
		}

		public int NDProjectOrder
		{
			get;
			set;
		}
	}
}
