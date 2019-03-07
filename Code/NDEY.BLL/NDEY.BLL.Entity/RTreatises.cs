using System;

namespace NDEY.BLL.Entity
{
	public class RTreatises
	{
		public string RTreatisesNo
		{
			get;
			set;
		}

		public string RTreatisesType
		{
			get;
			set;
		}

		public string RTreatisesName
		{
			get;
			set;
		}

		public string RTreatisesTypeExp
		{
			get
			{
				string rTreatisesType;
				if ((rTreatisesType = this.RTreatisesType) != null)
				{
					if (rTreatisesType == "1")
					{
						return "论文";
					}
					if (rTreatisesType == "2")
					{
						return "著作";
					}
					if (rTreatisesType == "3")
					{
						return "研究技术报告";
					}
					if (rTreatisesType == "4")
					{
						return "重要学术会议邀请报告";
					}
				}
				return "";
			}
		}

		public string RTreatisesRell
		{
			get;
			set;
		}

		public string RTreatisesPage
		{
			get;
			set;
		}

		public string RTreatisesJournalTitle
		{
			get;
			set;
		}

		public string RTreatisesCollection
		{
			get;
			set;
		}

		public string RTreatisesPDFOName
		{
			get;
			set;
		}

		public string RTreatisesAuthor
		{
			get;
			set;
		}

		public int RTreatisesOrder
		{
			get;
			set;
		}

		public string RTreatisesWordContent
		{
			get;
			set;
		}

		public string RTreatisesContent
		{
			get;
			set;
		}

		public string RTreatisesPDF
		{
			get;
			set;
		}

		public string UpLoadFullPath
		{
			get;
			set;
		}
	}
}
