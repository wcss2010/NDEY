using NDEY.BLL.Dao;
using NDEY.BLL.Entity;
using System;

namespace NDEY.BLL.Service
{
	public class ApplyUserBaseInfoService
	{
		private ApplyUserBaseInfoDao _applyUserBaseInfoDao = new ApplyUserBaseInfoDao();

		public ApplyUserInfo GetUserBaseInfo()
		{
			return this._applyUserBaseInfoDao.GetUserBaseInfo();
		}

		public void DeleteUserBaseInfo()
		{
		}

		public bool UpdateUserBaseInfo(ApplyUserInfo userinfo)
		{
			return this._applyUserBaseInfoDao.UpdateUserBaseInfo(userinfo);
		}
	}
}
