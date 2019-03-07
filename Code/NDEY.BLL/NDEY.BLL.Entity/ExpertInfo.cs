using System;

namespace NDEY.BLL.Entity
{
	public class ExpertInfo
	{
		public string ExpertName
		{
			get;
			set;
		}

		public string ExpertArea
		{
			get;
			set;
		}

		public string ExpertUnitPosition
		{
			get;
			set;
		}

		public string ExpertUnit
		{
			get;
			set;
		}

		public AttachmentInfo EAttachmentInfo
		{
			get;
			set;
		}

		public ExpertInfo()
		{
			this.EAttachmentInfo = new AttachmentInfo();
		}
	}
}
