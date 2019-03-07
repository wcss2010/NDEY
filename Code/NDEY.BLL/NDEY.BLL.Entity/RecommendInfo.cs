using System;
using System.Collections.Generic;

namespace NDEY.BLL.Entity
{
	public class RecommendInfo : BaseMessage
	{
		public string ApplicationType
		{
			get;
			set;
		}

		public AttachmentInfo RAttachmentInfo
		{
			get;
			set;
		}

		public IList<ExpertInfo> ExperInfoList
		{
			get;
			private set;
		}

		public RecommendInfo()
		{
			this.RAttachmentInfo = new AttachmentInfo();
			this.ExperInfoList = new List<ExpertInfo>();
		}
	}
}
