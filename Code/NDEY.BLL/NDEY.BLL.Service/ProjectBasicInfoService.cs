using NDEY.BLL.Dao;
using NDEY.BLL.Entity;
using System;

namespace NDEY.BLL.Service
{
	public class ProjectBasicInfoService
	{
		private ProjectBasicInfoDao _projectBasicInfoDao = new ProjectBasicInfoDao();

		public ProjectBasicInfo GetProjectBasicInfo()
		{
			return this._projectBasicInfoDao.GetProjectBasicInfo();
		}

		public bool UpdateProjectBasicInfo(ProjectBasicInfo pinfo)
		{
			return this._projectBasicInfoDao.UpdateProjectBasicInfo(pinfo);
		}
	}
}
