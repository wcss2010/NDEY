using NDEY.BLL.Dao;
using NDEY.BLL.Entity;
using System;
using System.Collections.Generic;

namespace NDEY.BLL.Service
{
	public class AcademicPostService
	{
		private AcademicPostDao _academicPostDao = new AcademicPostDao();

		public IList<AcademicPost> GetAcademicPostList()
		{
			return this._academicPostDao.GetAcademicPostList();
		}

		public bool UpdateAcademicPosts(IList<AcademicPost> list)
		{
			foreach (AcademicPost current in list)
			{
				if (current.AcademicPostNo == string.Empty)
				{
					current.AcademicPostNo = Guid.NewGuid().ToString();
					this._academicPostDao.Add(current);
				}
				else
				{
					this._academicPostDao.Update(current);
				}
			}
			return true;
		}

		public bool DeleteAcademicPosts(IList<string> list)
		{
			foreach (string current in list)
			{
				this._academicPostDao.DeleteAcademicPost(current);
			}
			return true;
		}
	}
}
