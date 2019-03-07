using NDEY.BLL.Dao;
using NDEY.BLL.Entity;
using System;
using System.Collections.Generic;
using System.IO;

namespace NDEY.BLL.Service
{
	public class NDPatentService
	{
		private NDPatentDao _nDPatentDao = new NDPatentDao();

		public IList<NDPatent> GetNDPatent()
		{
			return this._nDPatentDao.GetNDPatent();
		}

		public bool UpdateNDPatents(IList<NDPatent> list)
		{
			string path = Path.Combine(EntityElement.UserPath, "Files");
			foreach (NDPatent current in list)
			{
				if (current.NDPatentNo == string.Empty)
				{
					current.NDPatentNo = Guid.NewGuid().ToString();
					if (current.UpLoadFullPath != string.Empty && File.Exists(current.UpLoadFullPath))
					{
						current.NDPatentPDFOName = Path.GetFileName(current.UpLoadFullPath);
						current.NDPatentPDF = Path.GetFileNameWithoutExtension(current.UpLoadFullPath) + "_" + DateTime.Now.ToString("yyyy_MM_dd_hh_mm_ss") + Path.GetExtension(current.UpLoadFullPath);
						File.Copy(current.UpLoadFullPath, Path.Combine(path, current.NDPatentPDF), true);
					}
					this._nDPatentDao.Add(current);
				}
				else
				{
					if (current.UpLoadFullPath != string.Empty && File.Exists(current.UpLoadFullPath))
					{
						if (current.NDPatentPDF != string.Empty && File.Exists(Path.Combine(path, current.NDPatentPDF)))
						{
							File.Delete(Path.Combine(path, current.NDPatentPDF));
						}
						current.NDPatentPDFOName = Path.GetFileName(current.UpLoadFullPath);
						current.NDPatentPDF = Path.GetFileNameWithoutExtension(current.UpLoadFullPath) + "_" + DateTime.Now.ToString("yyyy_MM_dd_hh_mm_ss") + Path.GetExtension(current.UpLoadFullPath);
						File.Copy(current.UpLoadFullPath, Path.Combine(path, current.NDPatentPDF), true);
					}
					this._nDPatentDao.Update(current);
				}
			}
			return true;
		}

		public bool DeleteNDPatents(IList<string> list)
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
				this._nDPatentDao.DeleteNDPatent(array[0]);
			}
			return true;
		}
	}
}
