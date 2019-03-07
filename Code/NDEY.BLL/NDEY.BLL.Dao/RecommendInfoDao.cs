using NDEY.BLL.Entity;
using System;
using System.Data;
using System.Data.SQLite;

namespace NDEY.BLL.Dao
{
	public class RecommendInfoDao : BaseDBDao
	{
		public RecommendInfo GetRecommendInfo()
		{
			string querystring = "select ApplicationType,UnitRecommend,UnitRecommendOName,ExpertName1,ExpertArea1,ExpertUnitPosition1,\r\n           ExpertUnit1,ExpertRecommend1, ExpertRecommend1OName,ExpertName2,ExpertArea2,ExpertUnitPosition2,ExpertUnit2,\r\n            ExpertRecommend2,ExpertRecommend2OName,ExpertName3,ExpertArea3,ExpertUnitPosition3,ExpertUnit3,ExpertRecommend3,ExpertRecommend3OName from BaseInfor";
			string text = "";
			DataTable data = base.GetData(querystring, out text);
			RecommendInfo recommendInfo = null;
			if (data != null && data.Rows.Count > 0)
			{
				recommendInfo = new RecommendInfo();
				recommendInfo.ApplicationType = ((data.Rows[0]["ApplicationType"] == DBNull.Value) ? "单位推荐" : data.Rows[0]["ApplicationType"].ToString());
				recommendInfo.RAttachmentInfo.StoreName = ((data.Rows[0]["UnitRecommend"] == DBNull.Value) ? "" : data.Rows[0]["UnitRecommend"].ToString());
				recommendInfo.RAttachmentInfo.UploadName = ((data.Rows[0]["UnitRecommendOName"] == DBNull.Value) ? "" : data.Rows[0]["UnitRecommendOName"].ToString());
				ExpertInfo expertInfo = new ExpertInfo();
				expertInfo.ExpertName = ((data.Rows[0]["ExpertName1"] == DBNull.Value) ? "" : data.Rows[0]["ExpertName1"].ToString());
				expertInfo.ExpertArea = ((data.Rows[0]["ExpertArea1"] == DBNull.Value) ? "" : data.Rows[0]["ExpertArea1"].ToString());
				expertInfo.ExpertUnitPosition = ((data.Rows[0]["ExpertUnitPosition1"] == DBNull.Value) ? "" : data.Rows[0]["ExpertUnitPosition1"].ToString());
				expertInfo.ExpertUnit = ((data.Rows[0]["ExpertUnit1"] == DBNull.Value) ? "" : data.Rows[0]["ExpertUnit1"].ToString());
				expertInfo.EAttachmentInfo.StoreName = ((data.Rows[0]["ExpertRecommend1"] == DBNull.Value) ? "" : data.Rows[0]["ExpertRecommend1"].ToString());
				expertInfo.EAttachmentInfo.UploadName = ((data.Rows[0]["ExpertRecommend1OName"] == DBNull.Value) ? "" : data.Rows[0]["ExpertRecommend1OName"].ToString());
				recommendInfo.ExperInfoList.Add(expertInfo);
				expertInfo = new ExpertInfo();
				expertInfo.ExpertName = ((data.Rows[0]["ExpertName2"] == DBNull.Value) ? "" : data.Rows[0]["ExpertName2"].ToString());
				expertInfo.ExpertArea = ((data.Rows[0]["ExpertArea2"] == DBNull.Value) ? "" : data.Rows[0]["ExpertArea2"].ToString());
				expertInfo.ExpertUnitPosition = ((data.Rows[0]["ExpertUnitPosition2"] == DBNull.Value) ? "" : data.Rows[0]["ExpertUnitPosition2"].ToString());
				expertInfo.ExpertUnit = ((data.Rows[0]["ExpertUnit2"] == DBNull.Value) ? "" : data.Rows[0]["ExpertUnit2"].ToString());
				expertInfo.EAttachmentInfo.StoreName = ((data.Rows[0]["ExpertRecommend2"] == DBNull.Value) ? "" : data.Rows[0]["ExpertRecommend2"].ToString());
				expertInfo.EAttachmentInfo.UploadName = ((data.Rows[0]["ExpertRecommend2OName"] == DBNull.Value) ? "" : data.Rows[0]["ExpertRecommend2OName"].ToString());
				recommendInfo.ExperInfoList.Add(expertInfo);
				expertInfo = new ExpertInfo();
				expertInfo.ExpertName = ((data.Rows[0]["ExpertName2"] == DBNull.Value) ? "" : data.Rows[0]["ExpertName3"].ToString());
				expertInfo.ExpertArea = ((data.Rows[0]["ExpertArea2"] == DBNull.Value) ? "" : data.Rows[0]["ExpertArea3"].ToString());
				expertInfo.ExpertUnitPosition = ((data.Rows[0]["ExpertUnitPosition2"] == DBNull.Value) ? "" : data.Rows[0]["ExpertUnitPosition3"].ToString());
				expertInfo.ExpertUnit = ((data.Rows[0]["ExpertUnit2"] == DBNull.Value) ? "" : data.Rows[0]["ExpertUnit3"].ToString());
				expertInfo.EAttachmentInfo.StoreName = ((data.Rows[0]["ExpertRecommend2"] == DBNull.Value) ? "" : data.Rows[0]["ExpertRecommend3"].ToString());
				expertInfo.EAttachmentInfo.UploadName = ((data.Rows[0]["ExpertRecommend2OName"] == DBNull.Value) ? "" : data.Rows[0]["ExpertRecommend3OName"].ToString());
				recommendInfo.ExperInfoList.Add(expertInfo);
			}
			return recommendInfo;
		}

		public bool UpdateRecommendInfo(RecommendInfo rinfo)
		{
			string sql = "update BaseInfor set  ApplicationType=@ApplicationType,UnitRecommend=@UnitRecommend,UnitRecommendOName=@UnitRecommendOName,\r\nExpertName1=@ExpertName1,ExpertArea1=@ExpertArea1,ExpertUnitPosition1=@ExpertUnitPosition1,ExpertUnit1=@ExpertUnit1,ExpertRecommend1=@ExpertRecommend1,\r\nExpertRecommend1OName=@ExpertRecommend1OName,ExpertName2=@ExpertName2,ExpertArea2=@ExpertArea2,ExpertUnitPosition2=@ExpertUnitPosition2,ExpertUnit2=@ExpertUnit2,\r\n            ExpertRecommend2=@ExpertRecommend2,ExpertRecommend2OName=@ExpertRecommend2OName,ExpertName3=@ExpertName3,ExpertArea3=@ExpertArea3,ExpertUnitPosition3=@ExpertUnitPosition3,\r\nExpertUnit3=@ExpertUnit3,ExpertRecommend3=@ExpertRecommend3,ExpertRecommend3OName=@ExpertRecommend3OName";
			SQLiteParameter[] parameters = new SQLiteParameter[]
			{
				new SQLiteParameter("@ApplicationType", rinfo.ApplicationType),
				new SQLiteParameter("@UnitRecommend", rinfo.RAttachmentInfo.StoreName),
				new SQLiteParameter("@UnitRecommendOName", rinfo.RAttachmentInfo.UploadName),
				new SQLiteParameter("@ExpertName1", rinfo.ExperInfoList[0].ExpertName),
				new SQLiteParameter("@ExpertArea1", rinfo.ExperInfoList[0].ExpertArea),
				new SQLiteParameter("@ExpertUnitPosition1", rinfo.ExperInfoList[0].ExpertUnitPosition),
				new SQLiteParameter("@ExpertUnit1", rinfo.ExperInfoList[0].ExpertUnit),
				new SQLiteParameter("@ExpertRecommend1", rinfo.ExperInfoList[0].EAttachmentInfo.StoreName),
				new SQLiteParameter("@ExpertRecommend1OName", rinfo.ExperInfoList[0].EAttachmentInfo.UploadName),
				new SQLiteParameter("@ExpertName2", rinfo.ExperInfoList[1].ExpertName),
				new SQLiteParameter("@ExpertArea2", rinfo.ExperInfoList[1].ExpertArea),
				new SQLiteParameter("@ExpertUnitPosition2", rinfo.ExperInfoList[1].ExpertUnitPosition),
				new SQLiteParameter("@ExpertUnit2", rinfo.ExperInfoList[1].ExpertUnit),
				new SQLiteParameter("@ExpertRecommend2", rinfo.ExperInfoList[1].EAttachmentInfo.StoreName),
				new SQLiteParameter("@ExpertRecommend2OName", rinfo.ExperInfoList[1].EAttachmentInfo.UploadName),
				new SQLiteParameter("@ExpertName3", rinfo.ExperInfoList[2].ExpertName),
				new SQLiteParameter("@ExpertArea3", rinfo.ExperInfoList[2].ExpertArea),
				new SQLiteParameter("@ExpertUnitPosition3", rinfo.ExperInfoList[2].ExpertUnitPosition),
				new SQLiteParameter("@ExpertUnit3", rinfo.ExperInfoList[2].ExpertUnit),
				new SQLiteParameter("@ExpertRecommend3", rinfo.ExperInfoList[2].EAttachmentInfo.StoreName),
				new SQLiteParameter("@ExpertRecommend3OName", rinfo.ExperInfoList[2].EAttachmentInfo.UploadName)
			};
			string text = "";
			base.ExecuteNonQuery(sql, parameters, out text);
			return true;
		}
	}
}
