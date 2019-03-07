using NDEY.BLL.Dao;
using NDEY.BLL.Entity;
using System;
using System.Collections.Generic;

namespace NDEY.BLL.Service
{
	public class EducationInfoService
	{
		private EducationInfoDao _educationInfoDao = new EducationInfoDao();

		public IList<EducationInfo> GetEducationList()
		{
			return this._educationInfoDao.GetEducationList();
		}

		public bool UpdateEducations(IList<EducationInfo> list)
		{
			foreach (EducationInfo current in list)
			{
				if (current.EducationNo == string.Empty)
				{
					current.EducationNo = Guid.NewGuid().ToString();
					this._educationInfoDao.Add(current);
				}
				else
				{
					this._educationInfoDao.Update(current);
				}
			}
			return true;
		}

		public bool DeleteEducations(IList<string> list)
		{
			foreach (string current in list)
			{
				this._educationInfoDao.DeleteEducation(current);
			}
			return true;
		}
	}
}
