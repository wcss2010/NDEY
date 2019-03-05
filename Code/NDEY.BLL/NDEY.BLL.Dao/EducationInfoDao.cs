using NDEY.BLL.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Text;

namespace NDEY.BLL.Dao
{
	public class EducationInfoDao : BaseDBDao
	{
		public IList<EducationInfo> GetEducationList()
		{
			string querystring = "select EducationNo,EducationSDate,EducationEDate,EducationOrg,EducationMajor,EducationDegree,EducationOrder  from Education order by EducationOrder desc";
			string text = "";
			DataTable data = base.GetData(querystring, out text);
			IList<EducationInfo> list = new List<EducationInfo>();
			foreach (DataRow dataRow in data.Rows)
			{
				list.Add(new EducationInfo
				{
					EducationNo = dataRow["EducationNo"].ToString(),
					EducationSDate = dataRow["EducationSDate"].ToString(),
					EducationEDate = dataRow["EducationEDate"].ToString(),
					EducationOrg = dataRow["EducationOrg"].ToString(),
					EducationMajor = dataRow["EducationMajor"].ToString(),
					EducationDegree = dataRow["EducationDegree"].ToString(),
					EducationOrder = (int)((long)dataRow["EducationOrder"])
				});
			}
			return list;
		}

		public bool Add(EducationInfo model)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("insert into Education(");
			stringBuilder.Append("EducationNo,EducationSDate,EducationEDate,EducationOrg,EducationMajor,EducationDegree,EducationOrder)");
			stringBuilder.Append(" values (");
			stringBuilder.Append("@EducationNo,@EducationSDate,@EducationEDate,@EducationOrg,@EducationMajor,@EducationDegree,@EducationOrder)");
			SQLiteParameter[] parameters = new SQLiteParameter[]
			{
				new SQLiteParameter("@EducationNo", model.EducationNo),
				new SQLiteParameter("@EducationSDate", model.EducationSDate),
				new SQLiteParameter("@EducationEDate", model.EducationEDate),
				new SQLiteParameter("@EducationOrg", model.EducationOrg),
				new SQLiteParameter("@EducationMajor", model.EducationMajor),
				new SQLiteParameter("@EducationDegree", model.EducationDegree),
				new SQLiteParameter("@EducationOrder", model.EducationOrder)
			};
			string text = "";
			base.ExecuteNonQuery(stringBuilder.ToString(), parameters, out text);
			return true;
		}

		public bool Update(EducationInfo model)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("update Education set ");
			stringBuilder.Append("EducationNo=@EducationNo,");
			stringBuilder.Append("EducationSDate=@EducationSDate,");
			stringBuilder.Append("EducationEDate=@EducationEDate,");
			stringBuilder.Append("EducationOrg=@EducationOrg,");
			stringBuilder.Append("EducationMajor=@EducationMajor,");
			stringBuilder.Append("EducationDegree=@EducationDegree,");
			stringBuilder.Append("EducationOrder=@EducationOrder");
			stringBuilder.Append(" where EducationNo=@EducationNo");
			SQLiteParameter[] array = new SQLiteParameter[]
			{
				new SQLiteParameter("@EducationNo", DbType.String),
				new SQLiteParameter("@EducationSDate", DbType.String),
				new SQLiteParameter("@EducationEDate", DbType.String),
				new SQLiteParameter("@EducationOrg", DbType.String),
				new SQLiteParameter("@EducationMajor", DbType.String),
				new SQLiteParameter("@EducationDegree", DbType.String),
				new SQLiteParameter("@EducationOrder", DbType.Int32, 4)
			};
			array[0].Value = model.EducationNo;
			array[1].Value = model.EducationSDate;
			array[2].Value = model.EducationEDate;
			array[3].Value = model.EducationOrg;
			array[4].Value = model.EducationMajor;
			array[5].Value = model.EducationDegree;
			array[6].Value = model.EducationOrder;
			string text = "";
			base.ExecuteNonQuery(stringBuilder.ToString(), array, out text);
			return true;
		}

		public bool DeleteEducation(string einfoid)
		{
			string sql = "DELETE FROM Education where EducationNo=@EducationNo";
			SQLiteParameter[] parameters = new SQLiteParameter[]
			{
				new SQLiteParameter("@EducationNo", einfoid)
			};
			string text = "";
			base.ExecuteNonQuery(sql, parameters, out text);
			return true;
		}
	}
}
