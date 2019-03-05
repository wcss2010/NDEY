using NDEY.BLL.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Text;

namespace NDEY.BLL.Dao
{
	public class RTreatisesDao : BaseDBDao
	{
		internal IList<RTreatises> GetRTreatises()
		{
			string querystring = "select RTreatisesNo,RTreatisesType,RTreatisesAuthor,RTreatisesName,RTreatisesJournalTitle ,RTreatisesRell ,RTreatisesPage ,RTreatisesCollection ,RTreatisesContent ,RTreatisesPDF ,RTreatisesPDFOName ,RTreatisesOrder from RTreatises order by RTreatisesOrder desc";
			string text = "";
			DataTable data = base.GetData(querystring, out text);
			IList<RTreatises> list = new List<RTreatises>();
			foreach (DataRow dataRow in data.Rows)
			{
				list.Add(new RTreatises
				{
					RTreatisesNo = dataRow["RTreatisesNo"].ToString(),
					RTreatisesType = dataRow["RTreatisesType"].ToString(),
					RTreatisesAuthor = dataRow["RTreatisesAuthor"].ToString(),
					RTreatisesName = dataRow["RTreatisesName"].ToString(),
					RTreatisesJournalTitle = dataRow["RTreatisesJournalTitle"].ToString(),
					RTreatisesRell = dataRow["RTreatisesRell"].ToString(),
					RTreatisesPage = dataRow["RTreatisesPage"].ToString(),
					RTreatisesCollection = dataRow["RTreatisesCollection"].ToString(),
					RTreatisesContent = dataRow["RTreatisesContent"].ToString(),
					RTreatisesPDF = dataRow["RTreatisesPDF"].ToString(),
					RTreatisesPDFOName = dataRow["RTreatisesPDFOName"].ToString(),
					RTreatisesOrder = (int)dataRow["RTreatisesOrder"]
				});
			}
			return list;
		}

		internal bool Add(RTreatises model)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("insert into RTreatises(");
			stringBuilder.Append("RTreatisesNo,RTreatisesType,RTreatisesAuthor,RTreatisesName,RTreatisesJournalTitle,RTreatisesRell,RTreatisesPage,RTreatisesCollection,RTreatisesContent,RTreatisesPDF,RTreatisesPDFOName,RTreatisesOrder)");
			stringBuilder.Append(" values (");
			stringBuilder.Append("@RTreatisesNo,@RTreatisesType,@RTreatisesAuthor,@RTreatisesName,@RTreatisesJournalTitle,@RTreatisesRell,@RTreatisesPage,@RTreatisesCollection,@RTreatisesContent,@RTreatisesPDF,@RTreatisesPDFOName,@RTreatisesOrder)");
			SQLiteParameter[] array = new SQLiteParameter[]
			{
				new SQLiteParameter("@RTreatisesNo", DbType.String),
				new SQLiteParameter("@RTreatisesType", DbType.String),
				new SQLiteParameter("@RTreatisesAuthor", DbType.String),
				new SQLiteParameter("@RTreatisesName", DbType.String),
				new SQLiteParameter("@RTreatisesJournalTitle", DbType.String),
				new SQLiteParameter("@RTreatisesRell", DbType.String),
				new SQLiteParameter("@RTreatisesPage", DbType.String),
				new SQLiteParameter("@RTreatisesCollection", DbType.String),
				new SQLiteParameter("@RTreatisesContent", DbType.String),
				new SQLiteParameter("@RTreatisesPDF", DbType.String),
				new SQLiteParameter("@RTreatisesPDFOName", DbType.String),
				new SQLiteParameter("@RTreatisesOrder", DbType.Int32, 4)
			};
			array[0].Value = model.RTreatisesNo;
			array[1].Value = model.RTreatisesType;
			array[2].Value = model.RTreatisesAuthor;
			array[3].Value = model.RTreatisesName;
			array[4].Value = model.RTreatisesJournalTitle;
			array[5].Value = model.RTreatisesRell;
			array[6].Value = model.RTreatisesPage;
			array[7].Value = model.RTreatisesCollection;
			array[8].Value = model.RTreatisesContent;
			array[9].Value = model.RTreatisesPDF;
			array[10].Value = model.RTreatisesPDFOName;
			array[11].Value = model.RTreatisesOrder;
			string text = "";
			base.ExecuteNonQuery(stringBuilder.ToString(), array, out text);
			return true;
		}

		internal bool Update(RTreatises model)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("update RTreatises set ");
			stringBuilder.Append("RTreatisesNo=@RTreatisesNo,");
			stringBuilder.Append("RTreatisesType=@RTreatisesType,");
			stringBuilder.Append("RTreatisesAuthor=@RTreatisesAuthor,");
			stringBuilder.Append("RTreatisesName=@RTreatisesName,");
			stringBuilder.Append("RTreatisesJournalTitle=@RTreatisesJournalTitle,");
			stringBuilder.Append("RTreatisesRell=@RTreatisesRell,");
			stringBuilder.Append("RTreatisesPage=@RTreatisesPage,");
			stringBuilder.Append("RTreatisesCollection=@RTreatisesCollection,");
			stringBuilder.Append("RTreatisesContent=@RTreatisesContent,");
			stringBuilder.Append("RTreatisesPDF=@RTreatisesPDF,");
			stringBuilder.Append("RTreatisesPDFOName=@RTreatisesPDFOName,");
			stringBuilder.Append("RTreatisesOrder=@RTreatisesOrder");
			stringBuilder.Append(" where RTreatisesNo=@RTreatisesNo");
			SQLiteParameter[] array = new SQLiteParameter[]
			{
				new SQLiteParameter("@RTreatisesNo", DbType.String),
				new SQLiteParameter("@RTreatisesType", DbType.String),
				new SQLiteParameter("@RTreatisesAuthor", DbType.String),
				new SQLiteParameter("@RTreatisesName", DbType.String),
				new SQLiteParameter("@RTreatisesJournalTitle", DbType.String),
				new SQLiteParameter("@RTreatisesRell", DbType.String),
				new SQLiteParameter("@RTreatisesPage", DbType.String),
				new SQLiteParameter("@RTreatisesCollection", DbType.String),
				new SQLiteParameter("@RTreatisesContent", DbType.String),
				new SQLiteParameter("@RTreatisesPDF", DbType.String),
				new SQLiteParameter("@RTreatisesPDFOName", DbType.String),
				new SQLiteParameter("@RTreatisesOrder", DbType.Int32, 4)
			};
			array[0].Value = model.RTreatisesNo;
			array[1].Value = model.RTreatisesType;
			array[2].Value = model.RTreatisesAuthor;
			array[3].Value = model.RTreatisesName;
			array[4].Value = model.RTreatisesJournalTitle;
			array[5].Value = model.RTreatisesRell;
			array[6].Value = model.RTreatisesPage;
			array[7].Value = model.RTreatisesCollection;
			array[8].Value = model.RTreatisesContent;
			array[9].Value = model.RTreatisesPDF;
			array[10].Value = model.RTreatisesPDFOName;
			array[11].Value = model.RTreatisesOrder;
			string text = "";
			base.ExecuteNonQuery(stringBuilder.ToString(), array, out text);
			return true;
		}

		internal bool DeleteRTreatises(string item)
		{
			string sql = "DELETE FROM RTreatises where RTreatisesNo=@RTreatisesNo";
			SQLiteParameter[] parameters = new SQLiteParameter[]
			{
				new SQLiteParameter("@RTreatisesNo", item)
			};
			string text = "";
			base.ExecuteNonQuery(sql, parameters, out text);
			return true;
		}
	}
}
