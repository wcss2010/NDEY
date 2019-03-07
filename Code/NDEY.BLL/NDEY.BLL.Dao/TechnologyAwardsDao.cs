using NDEY.BLL.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Text;

namespace NDEY.BLL.Dao
{
	public class TechnologyAwardsDao : BaseDBDao
	{
		internal IList<TechnologyAwards> GetTechnologyAwards()
		{
			string querystring = "select TechnologyAwardsNo,TechnologyAwardsee,TechnologyAwardsPName,TechnologyAwardsYear,TechnologyAwardsTypeLevel,TechnologyAwardsContent,TechnologyAwardsPDF,TechnologyAwardsPDFOName,TechnologyAwardsOrder from TechnologyAwards  order by TechnologyAwardsOrder desc";
			string text = "";
			DataTable data = base.GetData(querystring, out text);
			IList<TechnologyAwards> list = new List<TechnologyAwards>();
			foreach (DataRow dataRow in data.Rows)
			{
				list.Add(new TechnologyAwards
				{
					TechnologyAwardsNo = dataRow["TechnologyAwardsNo"].ToString(),
					TechnologyAwardsee = dataRow["TechnologyAwardsee"].ToString(),
					TechnologyAwardsPName = dataRow["TechnologyAwardsPName"].ToString(),
					TechnologyAwardsYear = dataRow["TechnologyAwardsYear"].ToString(),
					TechnologyAwardsTypeLevel = dataRow["TechnologyAwardsTypeLevel"].ToString(),
					TechnologyAwardsContent = dataRow["TechnologyAwardsContent"].ToString(),
					TechnologyAwardsPDF = dataRow["TechnologyAwardsPDF"].ToString(),
					TechnologyAwardsPDFOName = dataRow["TechnologyAwardsPDFOName"].ToString(),
					UpLoadFullPath = "",
					TechnologyAwardsOrder = (int)((long)dataRow["TechnologyAwardsOrder"])
				});
			}
			return list;
		}

		internal bool Add(TechnologyAwards model)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("insert into TechnologyAwards(");
			stringBuilder.Append("TechnologyAwardsNo,TechnologyAwardsee,TechnologyAwardsPName,TechnologyAwardsYear,TechnologyAwardsTypeLevel,TechnologyAwardsContent,TechnologyAwardsPDF,TechnologyAwardsPDFOName,TechnologyAwardsOrder)");
			stringBuilder.Append(" values (");
			stringBuilder.Append("@TechnologyAwardsNo,@TechnologyAwardsee,@TechnologyAwardsPName,@TechnologyAwardsYear,@TechnologyAwardsTypeLevel,@TechnologyAwardsContent,@TechnologyAwardsPDF,@TechnologyAwardsPDFOName,@TechnologyAwardsOrder)");
			SQLiteParameter[] array = new SQLiteParameter[]
			{
				new SQLiteParameter("@TechnologyAwardsNo", DbType.String),
				new SQLiteParameter("@TechnologyAwardsee", DbType.String),
				new SQLiteParameter("@TechnologyAwardsPName", DbType.String),
				new SQLiteParameter("@TechnologyAwardsYear", DbType.String),
				new SQLiteParameter("@TechnologyAwardsTypeLevel", DbType.String),
				new SQLiteParameter("@TechnologyAwardsContent", DbType.String),
				new SQLiteParameter("@TechnologyAwardsPDF", DbType.String),
				new SQLiteParameter("@TechnologyAwardsPDFOName", DbType.String),
				new SQLiteParameter("@TechnologyAwardsOrder", DbType.Int32, 4)
			};
			array[0].Value = model.TechnologyAwardsNo;
			array[1].Value = model.TechnologyAwardsee;
			array[2].Value = model.TechnologyAwardsPName;
			array[3].Value = model.TechnologyAwardsYear;
			array[4].Value = model.TechnologyAwardsTypeLevel;
			array[5].Value = model.TechnologyAwardsContent;
			array[6].Value = model.TechnologyAwardsPDF;
			array[7].Value = model.TechnologyAwardsPDFOName;
			array[8].Value = model.TechnologyAwardsOrder;
			string text = "";
			base.ExecuteNonQuery(stringBuilder.ToString(), array, out text);
			return true;
		}

		internal bool Update(TechnologyAwards model)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("update TechnologyAwards set ");
			stringBuilder.Append("TechnologyAwardsNo=@TechnologyAwardsNo,");
			stringBuilder.Append("TechnologyAwardsee=@TechnologyAwardsee,");
			stringBuilder.Append("TechnologyAwardsPName=@TechnologyAwardsPName,");
			stringBuilder.Append("TechnologyAwardsYear=@TechnologyAwardsYear,");
			stringBuilder.Append("TechnologyAwardsTypeLevel=@TechnologyAwardsTypeLevel,");
			stringBuilder.Append("TechnologyAwardsContent=@TechnologyAwardsContent,");
			stringBuilder.Append("TechnologyAwardsPDF=@TechnologyAwardsPDF,");
			stringBuilder.Append("TechnologyAwardsPDFOName=@TechnologyAwardsPDFOName,");
			stringBuilder.Append("TechnologyAwardsOrder=@TechnologyAwardsOrder");
			stringBuilder.Append(" where TechnologyAwardsNo=@TechnologyAwardsNo");
			SQLiteParameter[] array = new SQLiteParameter[]
			{
				new SQLiteParameter("@TechnologyAwardsNo", DbType.String),
				new SQLiteParameter("@TechnologyAwardsee", DbType.String),
				new SQLiteParameter("@TechnologyAwardsPName", DbType.String),
				new SQLiteParameter("@TechnologyAwardsYear", DbType.String),
				new SQLiteParameter("@TechnologyAwardsTypeLevel", DbType.String),
				new SQLiteParameter("@TechnologyAwardsContent", DbType.String),
				new SQLiteParameter("@TechnologyAwardsPDF", DbType.String),
				new SQLiteParameter("@TechnologyAwardsPDFOName", DbType.String),
				new SQLiteParameter("@TechnologyAwardsOrder", DbType.Int32, 4)
			};
			array[0].Value = model.TechnologyAwardsNo;
			array[1].Value = model.TechnologyAwardsee;
			array[2].Value = model.TechnologyAwardsPName;
			array[3].Value = model.TechnologyAwardsYear;
			array[4].Value = model.TechnologyAwardsTypeLevel;
			array[5].Value = model.TechnologyAwardsContent;
			array[6].Value = model.TechnologyAwardsPDF;
			array[7].Value = model.TechnologyAwardsPDFOName;
			array[8].Value = model.TechnologyAwardsOrder;
			string text = "";
			base.ExecuteNonQuery(stringBuilder.ToString(), array, out text);
			return true;
		}

		internal bool DeleteRTreatises(string p)
		{
			string sql = "DELETE FROM TechnologyAwards where TechnologyAwardsNo=@TechnologyAwardsNo";
			SQLiteParameter[] parameters = new SQLiteParameter[]
			{
				new SQLiteParameter("@TechnologyAwardsNo", p)
			};
			string text = "";
			base.ExecuteNonQuery(sql, parameters, out text);
			return true;
		}
	}
}
