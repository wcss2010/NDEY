using NDEY.BLL.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Text;

namespace NDEY.BLL.Dao
{
	public class AcademicPostDao : BaseDBDao
	{
		internal IList<AcademicPost> GetAcademicPostList()
		{
			string querystring = "select AcademicPostNo,AcademicPostSDate,AcademicPostEDate,AcademicPostOrg,AcademicPostContent,AcademicPostOrder from AcademicPost  order by AcademicPostOrder desc";
			string text = "";
			DataTable data = base.GetData(querystring, out text);
			IList<AcademicPost> list = new List<AcademicPost>();
			foreach (DataRow dataRow in data.Rows)
			{
				list.Add(new AcademicPost
				{
					AcademicPostNo = dataRow["AcademicPostNo"].ToString(),
					AcademicPostSDate = dataRow["AcademicPostSDate"].ToString(),
					AcademicPostEDate = dataRow["AcademicPostEDate"].ToString(),
					AcademicPostOrg = dataRow["AcademicPostOrg"].ToString(),
					AcademicPostContent = dataRow["AcademicPostContent"].ToString(),
					AcademicPostOrder = (int)((long)dataRow["AcademicPostOrder"])
				});
			}
			return list;
		}

		internal bool Add(AcademicPost model)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("insert into AcademicPost(");
			stringBuilder.Append("AcademicPostNo,AcademicPostSDate,AcademicPostEDate,AcademicPostOrg,AcademicPostContent,AcademicPostOrder)");
			stringBuilder.Append(" values (");
			stringBuilder.Append("@AcademicPostNo,@AcademicPostSDate,@AcademicPostEDate,@AcademicPostOrg,@AcademicPostContent,@AcademicPostOrder)");
			SQLiteParameter[] array = new SQLiteParameter[]
			{
				new SQLiteParameter("@AcademicPostNo", DbType.String),
				new SQLiteParameter("@AcademicPostSDate", DbType.String),
				new SQLiteParameter("@AcademicPostEDate", DbType.String),
				new SQLiteParameter("@AcademicPostOrg", DbType.String),
				new SQLiteParameter("@AcademicPostContent", DbType.String),
				new SQLiteParameter("@AcademicPostOrder", DbType.Int32, 4)
			};
			array[0].Value = model.AcademicPostNo;
			array[1].Value = model.AcademicPostSDate;
			array[2].Value = model.AcademicPostEDate;
			array[3].Value = model.AcademicPostOrg;
			array[4].Value = model.AcademicPostContent;
			array[5].Value = model.AcademicPostOrder;
			string text = "";
			base.ExecuteNonQuery(stringBuilder.ToString(), array, out text);
			return true;
		}

		internal bool Update(AcademicPost model)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("update AcademicPost set ");
			stringBuilder.Append("AcademicPostNo=@AcademicPostNo,");
			stringBuilder.Append("AcademicPostSDate=@AcademicPostSDate,");
			stringBuilder.Append("AcademicPostEDate=@AcademicPostEDate,");
			stringBuilder.Append("AcademicPostOrg=@AcademicPostOrg,");
			stringBuilder.Append("AcademicPostContent=@AcademicPostContent,");
			stringBuilder.Append("AcademicPostOrder=@AcademicPostOrder");
			stringBuilder.Append(" where AcademicPostNo=@AcademicPostNo");
			SQLiteParameter[] array = new SQLiteParameter[]
			{
				new SQLiteParameter("@AcademicPostNo", DbType.String),
				new SQLiteParameter("@AcademicPostSDate", DbType.String),
				new SQLiteParameter("@AcademicPostEDate", DbType.String),
				new SQLiteParameter("@AcademicPostOrg", DbType.String),
				new SQLiteParameter("@AcademicPostContent", DbType.String),
				new SQLiteParameter("@AcademicPostOrder", DbType.Int32, 4)
			};
			array[0].Value = model.AcademicPostNo;
			array[1].Value = model.AcademicPostSDate;
			array[2].Value = model.AcademicPostEDate;
			array[3].Value = model.AcademicPostOrg;
			array[4].Value = model.AcademicPostContent;
			array[5].Value = model.AcademicPostOrder;
			string text = "";
			base.ExecuteNonQuery(stringBuilder.ToString(), array, out text);
			return true;
		}

		internal bool DeleteAcademicPost(string item)
		{
			string sql = "DELETE FROM AcademicPost where AcademicPostNo=@AcademicPostNo";
			SQLiteParameter[] parameters = new SQLiteParameter[]
			{
				new SQLiteParameter("@AcademicPostNo", item)
			};
			string text = "";
			base.ExecuteNonQuery(sql, parameters, out text);
			return true;
		}
	}
}
