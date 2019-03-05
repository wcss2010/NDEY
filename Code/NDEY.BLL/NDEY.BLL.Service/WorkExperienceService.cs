using NDEY.BLL.Dao;
using NDEY.BLL.Entity;
using System;
using System.Collections.Generic;

namespace NDEY.BLL.Service
{
	public class WorkExperienceService
	{
		private WorkExperienceDao _workExperienceDao = new WorkExperienceDao();

		public IList<WorkExperienceInfo> GetWorkExperience()
		{
			return this._workExperienceDao.GetWorkExperience();
		}

		public bool UpdateWorkExperiences(IList<WorkExperienceInfo> list)
		{
			foreach (WorkExperienceInfo current in list)
			{
				if (current.WorkExperienceNo == string.Empty)
				{
					current.WorkExperienceNo = Guid.NewGuid().ToString();
					this._workExperienceDao.Add(current);
				}
				else
				{
					this._workExperienceDao.Update(current);
				}
			}
			return true;
		}

		public bool DeleteWorkExperiences(IList<string> list)
		{
			foreach (string current in list)
			{
				this._workExperienceDao.DeleteWorkExperience(current);
			}
			return true;
		}
	}
}
