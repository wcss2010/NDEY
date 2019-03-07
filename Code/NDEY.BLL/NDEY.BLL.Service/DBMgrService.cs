using NDEY.BLL.Dao;
using System;

namespace NDEY.BLL.Service
{
	public class DBMgrService
	{
		private DBMgrDao _dbMgrDao = new DBMgrDao();

		public void InitDB()
		{
			this._dbMgrDao.InitDB();
		}
	}
}
