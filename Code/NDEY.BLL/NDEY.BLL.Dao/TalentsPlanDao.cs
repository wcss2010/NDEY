using NDEY.BLL.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Text;

namespace NDEY.BLL.Dao
{
	public class TalentsPlanDao : BaseDBDao
	{
		internal IList<TalentsPlan> GetTalentsPlan()
		{
			string querystring = "select TalentsPlanNo,TalentsPlanDate,TalentsPlanName,TalentsPlanRA,TalentsPlanOutlay,TalentsPlanOrder from TalentsPlan  order by TalentsPlanOrder desc";
			string text = "";
			DataTable data = base.GetData(querystring, out text);
			IList<TalentsPlan> list = new List<TalentsPlan>();
			foreach (DataRow dataRow in data.Rows)
			{
				list.Add(new TalentsPlan
				{
					TalentsPlanNo = dataRow["TalentsPlanNo"].ToString(),
					TalentsPlanDate = dataRow["TalentsPlanDate"].ToString(),
					TalentsPlanName = dataRow["TalentsPlanName"].ToString(),
					TalentsPlanRA = dataRow["TalentsPlanRA"].ToString(),
					TalentsPlanOutlay = dataRow["TalentsPlanOutlay"].ToString(),
					TalentsPlanOrder = (int)((long)dataRow["TalentsPlanOrder"])
				});
			}
			return list;
		}

		internal bool Add(TalentsPlan model)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("insert into TalentsPlan(");
			stringBuilder.Append("TalentsPlanNo,TalentsPlanDate,TalentsPlanName,TalentsPlanRA,TalentsPlanOutlay,TalentsPlanOrder)");
			stringBuilder.Append(" values (");
			stringBuilder.Append("@TalentsPlanNo,@TalentsPlanDate,@TalentsPlanName,@TalentsPlanRA,@TalentsPlanOutlay,@TalentsPlanOrder)");
			SQLiteParameter[] array = new SQLiteParameter[]
			{
				new SQLiteParameter("@TalentsPlanNo", DbType.String),
				new SQLiteParameter("@TalentsPlanDate", DbType.String),
				new SQLiteParameter("@TalentsPlanName", DbType.String),
				new SQLiteParameter("@TalentsPlanRA", DbType.String),
				new SQLiteParameter("@TalentsPlanOutlay", DbType.String),
				new SQLiteParameter("@TalentsPlanOrder", DbType.Int32, 4)
			};
			array[0].Value = model.TalentsPlanNo;
			array[1].Value = model.TalentsPlanDate;
			array[2].Value = model.TalentsPlanName;
			array[3].Value = model.TalentsPlanRA;
			array[4].Value = model.TalentsPlanOutlay;
			array[5].Value = model.TalentsPlanOrder;
			string text = "";
			base.ExecuteNonQuery(stringBuilder.ToString(), array, out text);
			return true;
		}

		internal bool Update(TalentsPlan model)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("update TalentsPlan set ");
			stringBuilder.Append("TalentsPlanDate=@TalentsPlanDate,");
			stringBuilder.Append("TalentsPlanName=@TalentsPlanName,");
			stringBuilder.Append("TalentsPlanRA=@TalentsPlanRA,");
			stringBuilder.Append("TalentsPlanOutlay=@TalentsPlanOutlay,");
			stringBuilder.Append("TalentsPlanOrder=@TalentsPlanOrder");
			stringBuilder.Append(" where TalentsPlanNo=@TalentsPlanNo");
			SQLiteParameter[] array = new SQLiteParameter[]
			{
				new SQLiteParameter("@TalentsPlanNo", DbType.String),
				new SQLiteParameter("@TalentsPlanDate", DbType.String),
				new SQLiteParameter("@TalentsPlanName", DbType.String),
				new SQLiteParameter("@TalentsPlanRA", DbType.String),
				new SQLiteParameter("@TalentsPlanOutlay", DbType.String),
				new SQLiteParameter("@TalentsPlanOrder", DbType.Int32, 4)
			};
			array[0].Value = model.TalentsPlanNo;
			array[1].Value = model.TalentsPlanDate;
			array[2].Value = model.TalentsPlanName;
			array[3].Value = model.TalentsPlanRA;
			array[4].Value = model.TalentsPlanOutlay;
			array[5].Value = model.TalentsPlanOrder;
			string text = "";
			base.ExecuteNonQuery(stringBuilder.ToString(), array, out text);
			return true;
		}

		internal bool DeleteTalentsPlan(string item)
		{
			string sql = "DELETE FROM TalentsPlan where TalentsPlanNo=@TalentsPlanNo";
			SQLiteParameter[] parameters = new SQLiteParameter[]
			{
				new SQLiteParameter("@TalentsPlanNo", item)
			};
			string text = "";
			base.ExecuteNonQuery(sql, parameters, out text);
			return true;
		}
	}
}
