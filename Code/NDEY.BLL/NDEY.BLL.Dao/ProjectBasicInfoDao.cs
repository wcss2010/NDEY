using NDEY.BLL.Entity;
using System;
using System.Data;
using System.Data.SQLite;

namespace NDEY.BLL.Dao
{
	public class ProjectBasicInfoDao : BaseDBDao
	{
		internal ProjectBasicInfo GetProjectBasicInfo()
		{
			string querystring = "select ProjectName,ProjectSecret,ApplicationArea,ProjectTD,ProjectMRD,ProjectBaseT,ProjectKeyWord,\r\n            ProjectBrief,ProjectLimitT from BaseInfor";
			string text = "";
			DataTable data = base.GetData(querystring, out text);
			ProjectBasicInfo projectBasicInfo = null;
			if (data != null && data.Rows.Count > 0)
			{
				projectBasicInfo = new ProjectBasicInfo();
				projectBasicInfo.ProjectName = ((data.Rows[0]["ProjectName"] == DBNull.Value) ? "" : data.Rows[0]["ProjectName"].ToString());
				projectBasicInfo.ProjectSecret = ((data.Rows[0]["ProjectSecret"] == DBNull.Value) ? "" : data.Rows[0]["ProjectSecret"].ToString());
				projectBasicInfo.ApplicationArea = ((data.Rows[0]["ApplicationArea"] == DBNull.Value) ? "" : data.Rows[0]["ApplicationArea"].ToString());
				projectBasicInfo.ProjectTD = ((data.Rows[0]["ProjectTD"] == DBNull.Value) ? "" : data.Rows[0]["ProjectTD"].ToString());
				projectBasicInfo.ProjectMRD = ((data.Rows[0]["ProjectMRD"] == DBNull.Value) ? "" : data.Rows[0]["ProjectMRD"].ToString());
				projectBasicInfo.ProjectBaseT = ((data.Rows[0]["ProjectBaseT"] == DBNull.Value) ? "" : data.Rows[0]["ProjectBaseT"].ToString());
				projectBasicInfo.ProjectKeyWord = ((data.Rows[0]["ProjectKeyWord"] == DBNull.Value) ? "" : data.Rows[0]["ProjectKeyWord"].ToString());
				projectBasicInfo.ProjectBrief = ((data.Rows[0]["ProjectBrief"] == DBNull.Value) ? "" : data.Rows[0]["ProjectBrief"].ToString());
				if (data.Rows[0]["ProjectLimitT"] != DBNull.Value && data.Rows[0]["ProjectLimitT"].ToString() != string.Empty)
				{
					string[] array = data.Rows[0]["ProjectLimitT"].ToString().Split(new char[]
					{
						'~'
					});
					projectBasicInfo.ProjectLimitStart = array[0].TrimEnd(new char[]
					{
						'年'
					});
					projectBasicInfo.ProjectLimitEnd = array[1].TrimEnd(new char[]
					{
						'年'
					});
				}
				else
				{
					projectBasicInfo.ProjectLimitStart = DateTime.Now.Year.ToString();
					projectBasicInfo.ProjectLimitEnd = (DateTime.Now.Year + 4).ToString();
				}
			}
			return projectBasicInfo;
		}

		internal bool UpdateProjectBasicInfo(ProjectBasicInfo pinfo)
		{
			string sql = "update BaseInfor set ProjectName=@ProjectName,ProjectSecret=@ProjectSecret,\r\nApplicationArea=@ApplicationArea,ProjectTD=@ProjectTD,ProjectMRD=@ProjectMRD,ProjectBaseT=@ProjectBaseT,ProjectKeyWord=@ProjectKeyWord,\r\n            ProjectBrief=@ProjectBrief,ProjectLimitT=@ProjectLimitT";
			SQLiteParameter[] parameters = new SQLiteParameter[]
			{
				new SQLiteParameter("@ProjectName", pinfo.ProjectName),
				new SQLiteParameter("@ProjectSecret", pinfo.ProjectSecret),
				new SQLiteParameter("@ApplicationArea", pinfo.ApplicationArea),
				new SQLiteParameter("@ProjectTD", pinfo.ProjectTD),
				new SQLiteParameter("@ProjectMRD", pinfo.ProjectMRD),
				new SQLiteParameter("@ProjectBaseT", pinfo.ProjectBaseT),
				new SQLiteParameter("@ProjectKeyWord", pinfo.ProjectKeyWord),
				new SQLiteParameter("@ProjectBrief", pinfo.ProjectBrief),
				new SQLiteParameter("@ProjectLimitT", pinfo.ProjectLimitStart + "年~" + pinfo.ProjectLimitEnd + "年")
			};
			string text = "";
			base.ExecuteNonQuery(sql, parameters, out text);
			return true;
		}

		internal bool AddProjectBasicInfo(ProjectBasicInfo pinfo)
		{
			string sql = "insert into BaseInfor (ProjectName,ProjectSecret,ApplicationArea,ProjectTD,ProjectMRD,ProjectBaseT,ProjectKeyWord,\r\n            ProjectBrief,ProjectLimitT) values( @ProjectName,@ProjectSecret,@ApplicationArea,@ProjectTD,@ProjectMRD,@ProjectBaseT,@ProjectKeyWord,\r\n            @ProjectBrief,@ProjectLimitT)";
			SQLiteParameter[] parameters = new SQLiteParameter[]
			{
				new SQLiteParameter("@ProjectName", pinfo.ProjectName),
				new SQLiteParameter("@ProjectSecret", pinfo.ProjectSecret),
				new SQLiteParameter("@ApplicationArea", pinfo.ApplicationArea),
				new SQLiteParameter("@ProjectTD", pinfo.ProjectTD),
				new SQLiteParameter("@ProjectMRD", pinfo.ProjectMRD),
				new SQLiteParameter("@ProjectBaseT", pinfo.ProjectBaseT),
				new SQLiteParameter("@ProjectKeyWord", pinfo.ProjectKeyWord),
				new SQLiteParameter("@ProjectBrief", pinfo.ProjectBrief),
				new SQLiteParameter("@ProjectLimitT", pinfo.ProjectLimitStart + "年~" + pinfo.ProjectLimitEnd + "年")
			};
			string text = "";
			base.ExecuteNonQuery(sql, parameters, out text);
			return true;
		}
	}
}
