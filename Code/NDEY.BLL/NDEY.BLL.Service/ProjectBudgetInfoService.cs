using NDEY.BLL.Dao;
using NDEY.BLL.Entity;
using System;

namespace NDEY.BLL.Service
{
	public class ProjectBudgetInfoService
	{
		private ProjectBudgetInfoDao _projectBudgetInfodao = new ProjectBudgetInfoDao();

		public ProjectBudgetInfo GetProjectBudgetInfo()
		{
			return this._projectBudgetInfodao.GetProjectBudgetInfo();
		}

		public bool UpdateProjectBudgetInfo(ProjectBudgetInfo pbinfo)
		{
			return this._projectBudgetInfodao.UpdateProjectBudgetInfo(pbinfo);
		}
	}
}
