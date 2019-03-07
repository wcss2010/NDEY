using NDEY.BLL.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Text;

namespace NDEY.BLL.Dao
{
	public class NDProjectDao : BaseDBDao
	{
		internal IList<NDProject> GetNDProject()
		{
			string querystring = "select NDProjectNo,NDProjectSYear,NDProjectEYear,NDProjectName,NDProjectType,NDProjectSource,NDProjectOutlay,NDProjectTaskBySelf,NDProjectUserOrder,NDProjectOrder from NDProject order by NDProjectOrder desc";
			string text = "";
			DataTable data = base.GetData(querystring, out text);
			IList<NDProject> list = new List<NDProject>();
			foreach (DataRow dataRow in data.Rows)
			{
				list.Add(new NDProject
				{
					NDProjectNo = dataRow["NDProjectNo"].ToString(),
					NDProjectSYear = dataRow["NDProjectSYear"].ToString(),
					NDProjectEYear = dataRow["NDProjectEYear"].ToString(),
					NDProjectName = dataRow["NDProjectName"].ToString(),
					NDProjectType = dataRow["NDProjectType"].ToString(),
					NDProjectSource = dataRow["NDProjectSource"].ToString(),
					NDProjectOutlay = dataRow["NDProjectOutlay"].ToString(),
					NDProjectTaskBySelf = dataRow["NDProjectTaskBySelf"].ToString(),
					NDProjectUserOrder = dataRow["NDProjectUserOrder"].ToString(),
					NDProjectOrder = (int)((long)dataRow["NDProjectOrder"])
				});
			}
			return list;
		}

		internal bool Add(NDProject model)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("insert into NDProject(");
			stringBuilder.Append("NDProjectNo,NDProjectSYear,NDProjectEYear,NDProjectName,NDProjectType,NDProjectSource,NDProjectOutlay,NDProjectTaskBySelf,NDProjectUserOrder,NDProjectOrder)");
			stringBuilder.Append(" values (");
			stringBuilder.Append("@NDProjectNo,@NDProjectSYear,@NDProjectEYear,@NDProjectName,@NDProjectType,@NDProjectSource,@NDProjectOutlay,@NDProjectTaskBySelf,@NDProjectUserOrder,@NDProjectOrder)");
			SQLiteParameter[] array = new SQLiteParameter[]
			{
				new SQLiteParameter("@NDProjectNo", DbType.String),
				new SQLiteParameter("@NDProjectSYear", DbType.String),
				new SQLiteParameter("@NDProjectEYear", DbType.String),
				new SQLiteParameter("@NDProjectName", DbType.String),
				new SQLiteParameter("@NDProjectType", DbType.String),
				new SQLiteParameter("@NDProjectSource", DbType.String),
				new SQLiteParameter("@NDProjectOutlay", DbType.String),
				new SQLiteParameter("@NDProjectTaskBySelf", DbType.String),
				new SQLiteParameter("@NDProjectUserOrder", DbType.String),
				new SQLiteParameter("@NDProjectOrder", DbType.Int32, 4)
			};
			array[0].Value = model.NDProjectNo;
			array[1].Value = model.NDProjectSYear;
			array[2].Value = model.NDProjectEYear;
			array[3].Value = model.NDProjectName;
			array[4].Value = model.NDProjectType;
			array[5].Value = model.NDProjectSource;
			array[6].Value = model.NDProjectOutlay;
			array[7].Value = model.NDProjectTaskBySelf;
			array[8].Value = model.NDProjectUserOrder;
			array[9].Value = model.NDProjectOrder;
			string text = "";
			base.ExecuteNonQuery(stringBuilder.ToString(), array, out text);
			return true;
		}

		internal bool Update(NDProject model)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("update NDProject set ");
			stringBuilder.Append("NDProjectNo=@NDProjectNo,");
			stringBuilder.Append("NDProjectSYear=@NDProjectSYear,");
			stringBuilder.Append("NDProjectEYear=@NDProjectEYear,");
			stringBuilder.Append("NDProjectName=@NDProjectName,");
			stringBuilder.Append("NDProjectType=@NDProjectType,");
			stringBuilder.Append("NDProjectSource=@NDProjectSource,");
			stringBuilder.Append("NDProjectOutlay=@NDProjectOutlay,");
			stringBuilder.Append("NDProjectTaskBySelf=@NDProjectTaskBySelf,");
			stringBuilder.Append("NDProjectUserOrder=@NDProjectUserOrder,");
			stringBuilder.Append("NDProjectOrder=@NDProjectOrder");
			stringBuilder.Append(" where NDProjectNo=@NDProjectNo");
			SQLiteParameter[] array = new SQLiteParameter[]
			{
				new SQLiteParameter("@NDProjectNo", DbType.String),
				new SQLiteParameter("@NDProjectSYear", DbType.String),
				new SQLiteParameter("@NDProjectEYear", DbType.String),
				new SQLiteParameter("@NDProjectName", DbType.String),
				new SQLiteParameter("@NDProjectType", DbType.String),
				new SQLiteParameter("@NDProjectSource", DbType.String),
				new SQLiteParameter("@NDProjectOutlay", DbType.String),
				new SQLiteParameter("@NDProjectTaskBySelf", DbType.String),
				new SQLiteParameter("@NDProjectUserOrder", DbType.String),
				new SQLiteParameter("@NDProjectOrder", DbType.Int32, 4)
			};
			array[0].Value = model.NDProjectNo;
			array[1].Value = model.NDProjectSYear;
			array[2].Value = model.NDProjectEYear;
			array[3].Value = model.NDProjectName;
			array[4].Value = model.NDProjectType;
			array[5].Value = model.NDProjectSource;
			array[6].Value = model.NDProjectOutlay;
			array[7].Value = model.NDProjectTaskBySelf;
			array[8].Value = model.NDProjectUserOrder;
			array[9].Value = model.NDProjectOrder;
			string text = "";
			base.ExecuteNonQuery(stringBuilder.ToString(), array, out text);
			return true;
		}

		internal bool DeleteNDProject(string item)
		{
			string sql = "DELETE FROM NDProject where NDProjectNo=@NDProjectNo";
			SQLiteParameter[] parameters = new SQLiteParameter[]
			{
				new SQLiteParameter("@NDProjectNo", item)
			};
			string text = "";
			base.ExecuteNonQuery(sql, parameters, out text);
			return true;
		}
	}
}
