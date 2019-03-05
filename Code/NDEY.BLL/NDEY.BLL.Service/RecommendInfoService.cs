using NDEY.BLL.Dao;
using NDEY.BLL.Entity;
using System;
using System.IO;

namespace NDEY.BLL.Service
{
	public class RecommendInfoService
	{
		private RecommendInfoDao _recommendInfoDao = new RecommendInfoDao();

		public RecommendInfo GetRecommendInfo()
		{
			return this._recommendInfoDao.GetRecommendInfo();
		}

		public bool UpdateRecommendInfo(RecommendInfo newrinfo, RecommendInfo oldRecommendInfo)
		{
			string path = Path.Combine(EntityElement.UserPath, "Files");
			if (!(newrinfo.RAttachmentInfo.UploadName == oldRecommendInfo.RAttachmentInfo.UploadName) || !(newrinfo.RAttachmentInfo.UploadFullPath == string.Empty))
			{
				if (File.Exists(Path.Combine(path, oldRecommendInfo.RAttachmentInfo.StoreName)))
				{
					File.Delete(Path.Combine(path, oldRecommendInfo.RAttachmentInfo.StoreName));
				}
				if (File.Exists(newrinfo.RAttachmentInfo.UploadFullPath))
				{
					File.Copy(newrinfo.RAttachmentInfo.UploadFullPath, Path.Combine(path, newrinfo.RAttachmentInfo.StoreName), true);
				}
			}
			if (!(newrinfo.ExperInfoList[0].EAttachmentInfo.UploadName == oldRecommendInfo.ExperInfoList[0].EAttachmentInfo.UploadName) || !(newrinfo.ExperInfoList[0].EAttachmentInfo.UploadFullPath == string.Empty))
			{
				if (File.Exists(Path.Combine(path, oldRecommendInfo.ExperInfoList[0].EAttachmentInfo.StoreName)))
				{
					File.Delete(Path.Combine(path, oldRecommendInfo.ExperInfoList[0].EAttachmentInfo.StoreName));
				}
				if (File.Exists(newrinfo.ExperInfoList[0].EAttachmentInfo.UploadFullPath))
				{
					File.Copy(newrinfo.ExperInfoList[0].EAttachmentInfo.UploadFullPath, Path.Combine(path, newrinfo.ExperInfoList[0].EAttachmentInfo.StoreName), true);
				}
			}
			if (!(newrinfo.ExperInfoList[1].EAttachmentInfo.UploadName == oldRecommendInfo.ExperInfoList[1].EAttachmentInfo.UploadName) || !(newrinfo.ExperInfoList[1].EAttachmentInfo.UploadFullPath == string.Empty))
			{
				if (File.Exists(Path.Combine(path, oldRecommendInfo.ExperInfoList[1].EAttachmentInfo.StoreName)))
				{
					File.Delete(Path.Combine(path, oldRecommendInfo.ExperInfoList[1].EAttachmentInfo.StoreName));
				}
				if (File.Exists(newrinfo.ExperInfoList[1].EAttachmentInfo.UploadFullPath))
				{
					File.Copy(newrinfo.ExperInfoList[1].EAttachmentInfo.UploadFullPath, Path.Combine(path, newrinfo.ExperInfoList[1].EAttachmentInfo.StoreName), true);
				}
			}
			if (!(newrinfo.ExperInfoList[2].EAttachmentInfo.UploadName == oldRecommendInfo.ExperInfoList[2].EAttachmentInfo.UploadName) || !(newrinfo.ExperInfoList[2].EAttachmentInfo.UploadFullPath == string.Empty))
			{
				if (File.Exists(Path.Combine(path, oldRecommendInfo.ExperInfoList[2].EAttachmentInfo.StoreName)))
				{
					File.Delete(Path.Combine(path, oldRecommendInfo.ExperInfoList[2].EAttachmentInfo.StoreName));
				}
				if (File.Exists(newrinfo.ExperInfoList[2].EAttachmentInfo.UploadFullPath))
				{
					File.Copy(newrinfo.ExperInfoList[2].EAttachmentInfo.UploadFullPath, Path.Combine(path, newrinfo.ExperInfoList[2].EAttachmentInfo.StoreName), true);
				}
			}
			return this._recommendInfoDao.UpdateRecommendInfo(newrinfo);
		}
	}
}
