using NDEY.BLL.Dao;
using NDEY.BLL.Entity;
using System;
using System.Collections.Generic;
using System.IO;

namespace NDEY.BLL.Service
{
	public class TechnologyAwardsService
	{
		private TechnologyAwardsDao _technologyAwardsDao = new TechnologyAwardsDao();

		public IList<TechnologyAwards> GetTechnologyAwards()
		{
			return this._technologyAwardsDao.GetTechnologyAwards();
		}

		public bool UpdateTechnologyAwards(IList<TechnologyAwards> list)
		{
			string path = Path.Combine(EntityElement.UserPath, "Files");
			foreach (TechnologyAwards current in list)
			{
				if (current.TechnologyAwardsNo == string.Empty)
				{
					current.TechnologyAwardsNo = Guid.NewGuid().ToString();
					if (current.UpLoadFullPath != string.Empty && File.Exists(current.UpLoadFullPath))
					{
						current.TechnologyAwardsPDFOName = Path.GetFileName(current.UpLoadFullPath);
						current.TechnologyAwardsPDF = Path.GetFileNameWithoutExtension(current.UpLoadFullPath) + "_" + DateTime.Now.ToString("yyyy_MM_dd_hh_mm_ss") + Path.GetExtension(current.UpLoadFullPath);
						File.Copy(current.UpLoadFullPath, Path.Combine(path, current.TechnologyAwardsPDF), true);
					}
					this._technologyAwardsDao.Add(current);
				}
				else
				{
					if (current.UpLoadFullPath != string.Empty && File.Exists(current.UpLoadFullPath))
					{
						if (current.TechnologyAwardsPDF != string.Empty && File.Exists(Path.Combine(path, current.TechnologyAwardsPDF)))
						{
							File.Delete(Path.Combine(path, current.TechnologyAwardsPDF));
						}
						current.TechnologyAwardsPDFOName = Path.GetFileName(current.UpLoadFullPath);
						current.TechnologyAwardsPDF = Path.GetFileNameWithoutExtension(current.UpLoadFullPath) + "_" + DateTime.Now.ToString("yyyy_MM_dd_hh_mm_ss") + Path.GetExtension(current.UpLoadFullPath);
						File.Copy(current.UpLoadFullPath, Path.Combine(path, current.TechnologyAwardsPDF), true);
					}
					this._technologyAwardsDao.Update(current);
				}
			}
			return true;
		}

		public bool DeleteRTreatisess(IList<string> list)
		{
			string path = Path.Combine(EntityElement.UserPath, "Files");
			foreach (string current in list)
			{
				string[] array = current.Split(new char[]
				{
					'|'
				});
				if (array[1] != string.Empty && File.Exists(Path.Combine(path, array[1])))
				{
					File.Delete(Path.Combine(path, array[1]));
				}
				this._technologyAwardsDao.DeleteRTreatises(array[0]);
			}
			return true;
		}
	}
}
