using NDEY.BLL.Dao;
using NDEY.BLL.Entity;
using System;

namespace NDEY.BLL.Service
{
	public class ResultFormInfoService
	{
		private ResultFormInfoDao _resultFormInfoDao = new ResultFormInfoDao();

		public ResultFormInfo GetResultFormInfo()
		{
			return this._resultFormInfoDao.GetResultFormInfo();
		}

		public bool UpdateResultFormInfo(ResultFormInfo info)
		{
			return this._resultFormInfoDao.UpdateResultFormInfo(info);
		}
	}
}
