using NDEY.BLL.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Text;

namespace NDEY.BLL.Dao
{
	public class WorkExperienceDao : BaseDBDao
	{
		public IList<WorkExperienceInfo> GetWorkExperience()
		{
			string querystring = "select WorkExperienceNo,WorkExperienceSDate,WorkExperienceEDate,WorkExperienceOrg,WorkExperienceContent,WorkExperienceOrder from WorkExperience  order by WorkExperienceOrder desc";
			string text = "";
			DataTable data = base.GetData(querystring, out text);
			IList<WorkExperienceInfo> list = new List<WorkExperienceInfo>();
			foreach (DataRow dataRow in data.Rows)
			{
				list.Add(new WorkExperienceInfo
				{
					WorkExperienceNo = dataRow["WorkExperienceNo"].ToString(),
					WorkExperienceSDate = dataRow["WorkExperienceSDate"].ToString(),
					WorkExperienceEDate = dataRow["WorkExperienceEDate"].ToString(),
					WorkExperienceOrg = dataRow["WorkExperienceOrg"].ToString(),
					WorkExperienceContent = dataRow["WorkExperienceContent"].ToString(),
					WorkExperienceOrder = (int)((long)dataRow["WorkExperienceOrder"])
				});
			}
			return list;
		}

		public bool Add(WorkExperienceInfo model)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("insert into WorkExperience(");
			stringBuilder.Append("WorkExperienceNo,WorkExperienceSDate,WorkExperienceEDate,WorkExperienceOrg,WorkExperienceContent,WorkExperienceOrder)");
			stringBuilder.Append(" values (");
			stringBuilder.Append("@WorkExperienceNo,@WorkExperienceSDate,@WorkExperienceEDate,@WorkExperienceOrg,@WorkExperienceContent,@WorkExperienceOrder)");
			SQLiteParameter[] array = new SQLiteParameter[]
			{
				new SQLiteParameter("@WorkExperienceNo", DbType.String),
				new SQLiteParameter("@WorkExperienceSDate", DbType.String),
				new SQLiteParameter("@WorkExperienceEDate", DbType.String),
				new SQLiteParameter("@WorkExperienceOrg", DbType.String),
				new SQLiteParameter("@WorkExperienceContent", DbType.String),
				new SQLiteParameter("@WorkExperienceOrder", DbType.Int32, 4)
			};
			array[0].Value = model.WorkExperienceNo;
			array[1].Value = model.WorkExperienceSDate;
			array[2].Value = model.WorkExperienceEDate;
			array[3].Value = model.WorkExperienceOrg;
			array[4].Value = model.WorkExperienceContent;
			array[5].Value = model.WorkExperienceOrder;
			string text = "";
			base.ExecuteNonQuery(stringBuilder.ToString(), array, out text);
			return true;
		}

		public bool Update(WorkExperienceInfo model)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("update WorkExperience set ");
			stringBuilder.Append("WorkExperienceNo=@WorkExperienceNo,");
			stringBuilder.Append("WorkExperienceSDate=@WorkExperienceSDate,");
			stringBuilder.Append("WorkExperienceEDate=@WorkExperienceEDate,");
			stringBuilder.Append("WorkExperienceOrg=@WorkExperienceOrg,");
			stringBuilder.Append("WorkExperienceContent=@WorkExperienceContent,");
			stringBuilder.Append("WorkExperienceOrder=@WorkExperienceOrder");
			stringBuilder.Append(" where WorkExperienceNo=@WorkExperienceNo");
			SQLiteParameter[] array = new SQLiteParameter[]
			{
				new SQLiteParameter("@WorkExperienceNo", DbType.String),
				new SQLiteParameter("@WorkExperienceSDate", DbType.String),
				new SQLiteParameter("@WorkExperienceEDate", DbType.String),
				new SQLiteParameter("@WorkExperienceOrg", DbType.String),
				new SQLiteParameter("@WorkExperienceContent", DbType.String),
				new SQLiteParameter("@WorkExperienceOrder", DbType.Int32, 4)
			};
			array[0].Value = model.WorkExperienceNo;
			array[1].Value = model.WorkExperienceSDate;
			array[2].Value = model.WorkExperienceEDate;
			array[3].Value = model.WorkExperienceOrg;
			array[4].Value = model.WorkExperienceContent;
			array[5].Value = model.WorkExperienceOrder;
			string text = "";
			base.ExecuteNonQuery(stringBuilder.ToString(), array, out text);
			return true;
		}

		public bool DeleteWorkExperience(string item)
		{
			string sql = "DELETE FROM WorkExperience where WorkExperienceNo=@WorkExperienceNo";
			SQLiteParameter[] parameters = new SQLiteParameter[]
			{
				new SQLiteParameter("@WorkExperienceNo", item)
			};
			string text = "";
			base.ExecuteNonQuery(sql, parameters, out text);
			return true;
		}
	}
}
