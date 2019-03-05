using NDEY.BLL.Dao;
using NDEY.BLL.Entity;
using System;
using System.Collections.Generic;

namespace NDEY.BLL.Service
{
	public class NDProjectService
	{
		private NDProjectDao _nDProjectDao = new NDProjectDao();

		public IList<NDProject> GetNDProject()
		{
			return this._nDProjectDao.GetNDProject();
		}

		public bool UpdateNDProjects(IList<NDProject> list)
		{
			foreach (NDProject current in list)
			{
				if (current.NDProjectNo == string.Empty)
				{
					current.NDProjectNo = Guid.NewGuid().ToString();
					this._nDProjectDao.Add(current);
				}
				else
				{
					this._nDProjectDao.Update(current);
				}
			}
			return true;
		}

		public bool DeleteNDProjects(IList<string> list)
		{
			foreach (string current in list)
			{
				this._nDProjectDao.DeleteNDProject(current);
			}
			return true;
		}
	}
}
