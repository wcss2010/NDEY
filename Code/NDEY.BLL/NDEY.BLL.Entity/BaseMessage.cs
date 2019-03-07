using System;

namespace NDEY.BLL.Entity
{
	public class BaseMessage
	{
		public bool ErrorHappened
		{
			get;
			set;
		}

		public string Message
		{
			get;
			set;
		}

		public BaseMessage()
		{
			this.ErrorHappened = false;
			this.Message = "";
		}
	}
}
