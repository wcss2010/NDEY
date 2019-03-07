using NDEY.BLL.Dao;
using NDEY.BLL.Entity;
using System;
using System.Collections.Generic;

namespace NDEY.BLL.Service
{
	public class TalentsPlanService
	{
		private TalentsPlanDao _talentsPlanDao = new TalentsPlanDao();

		public IList<TalentsPlan> GetTalentsPlan()
		{
			return this._talentsPlanDao.GetTalentsPlan();
		}

		public bool UpdateTalentsPlans(IList<TalentsPlan> list)
		{
			foreach (TalentsPlan current in list)
			{
				if (current.TalentsPlanNo == string.Empty)
				{
					current.TalentsPlanNo = Guid.NewGuid().ToString();
					this._talentsPlanDao.Add(current);
				}
				else
				{
					this._talentsPlanDao.Update(current);
				}
			}
			return true;
		}

		public bool DeleteTalentsPlans(IList<string> list)
		{
			foreach (string current in list)
			{
				this._talentsPlanDao.DeleteTalentsPlan(current);
			}
			return true;
		}
	}
}
