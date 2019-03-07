using NDEY.BLL.Dao;
using NDEY.BLL.Entity;
using System;
using System.Collections.Generic;
using System.IO;

namespace NDEY.BLL.Service
{
	public class RTreatisesService
	{
		private RTreatisesDao _rTreatisesDao = new RTreatisesDao();

		public IList<RTreatises> GetRTreatises()
		{
			return this._rTreatisesDao.GetRTreatises();
		}

		public bool UpdateRTreatisess(IList<RTreatises> list)
		{
			string path = Path.Combine(EntityElement.UserPath, "Files");
			foreach (RTreatises current in list)
			{
				if (current.RTreatisesNo == string.Empty)
				{
					current.RTreatisesNo = Guid.NewGuid().ToString();
					if (current.UpLoadFullPath != string.Empty && File.Exists(current.UpLoadFullPath))
					{
						current.RTreatisesPDFOName = Path.GetFileName(current.UpLoadFullPath);
						current.RTreatisesPDF = Path.GetFileNameWithoutExtension(current.UpLoadFullPath) + "_" + DateTime.Now.ToString("yyyy_MM_dd_hh_mm_ss") + Path.GetExtension(current.UpLoadFullPath);
						File.Copy(current.UpLoadFullPath, Path.Combine(path, current.RTreatisesPDF), true);
					}
					this._rTreatisesDao.Add(current);
				}
				else
				{
					if (current.UpLoadFullPath != string.Empty && File.Exists(current.UpLoadFullPath))
					{
						if (current.RTreatisesPDF != string.Empty && File.Exists(Path.Combine(path, current.RTreatisesPDF)))
						{
							File.Delete(Path.Combine(path, current.RTreatisesPDF));
						}
						current.RTreatisesPDFOName = Path.GetFileName(current.UpLoadFullPath);
						current.RTreatisesPDF = Path.GetFileNameWithoutExtension(current.UpLoadFullPath) + "_" + DateTime.Now.ToString("yyyy_MM_dd_hh_mm_ss") + Path.GetExtension(current.UpLoadFullPath);
						File.Copy(current.UpLoadFullPath, Path.Combine(path, current.RTreatisesPDF), true);
					}
					this._rTreatisesDao.Update(current);
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
				this._rTreatisesDao.DeleteRTreatises(array[0]);
			}
			return true;
		}
	}
}
