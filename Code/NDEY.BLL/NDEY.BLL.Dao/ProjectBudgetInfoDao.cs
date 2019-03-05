using NDEY.BLL.Entity;
using System;
using System.Data;
using System.Data.SQLite;

namespace NDEY.BLL.Dao
{
	public class ProjectBudgetInfoDao : BaseDBDao
	{
		internal ProjectBudgetInfo GetProjectBudgetInfo()
		{
			string querystring = "select ProjectRFA,ProjectRFA1,ProjectRFA1_1,ProjectRFA1_1_1,ProjectRFA1_1_2,\r\n            ProjectRFA1_1_3,ProjectRFA1_2,ProjectRFA1_3,ProjectRFA1_4,ProjectRFA1_5,ProjectRFA1_6,ProjectRFA1_7,\r\nProjectRFA1_8,ProjectRFA1_9,ProjectRFA2,ProjectRFA2_1,ProjectRFA2_2,ProjectOutlay1,ProjectOutlay2,ProjectOutlay3,\r\nProjectOutlay4,ProjectOutlay5,ProjectRFARm,ProjectRFA1Rm,ProjectRFA1_1Rm,ProjectRFA1_1_1Rm,ProjectRFA1_1_2Rm,\r\nProjectRFA1_1_3Rm,ProjectRFA1_2Rm,ProjectRFA1_3Rm,ProjectRFA1_4Rm,ProjectRFA1_5Rm,ProjectRFA1_6Rm,ProjectRFA1_7Rm,\r\nProjectRFA1_8Rm,ProjectRFA1_9Rm,ProjectRFA2Rm,ProjectRFA2_1Rm,ProjectRFA2_2Rm from BaseInfor";
			string text = "";
			DataTable data = base.GetData(querystring, out text);
			ProjectBudgetInfo projectBudgetInfo = null;
			if (data != null && data.Rows.Count > 0)
			{
				projectBudgetInfo = new ProjectBudgetInfo();
				projectBudgetInfo.ProjectRFA = ((data.Rows[0]["ProjectRFA"] == DBNull.Value) ? null : new decimal?((decimal)((double)data.Rows[0]["ProjectRFA"])));
				projectBudgetInfo.ProjectRFA1 = ((data.Rows[0]["ProjectRFA1"] == DBNull.Value) ? null : new decimal?((decimal)((double)data.Rows[0]["ProjectRFA1"])));
				projectBudgetInfo.ProjectRFA1_1 = ((data.Rows[0]["ProjectRFA1_1"] == DBNull.Value) ? null : new decimal?((decimal)((double)data.Rows[0]["ProjectRFA1_1"])));
				projectBudgetInfo.ProjectRFA1_1_1 = ((data.Rows[0]["ProjectRFA1_1_1"] == DBNull.Value) ? null : new decimal?((decimal)((double)data.Rows[0]["ProjectRFA1_1_1"])));
				projectBudgetInfo.ProjectRFA1_1_2 = ((data.Rows[0]["ProjectRFA1_1_2"] == DBNull.Value) ? null : new decimal?((decimal)((double)data.Rows[0]["ProjectRFA1_1_2"])));
				projectBudgetInfo.ProjectRFA1_1_3 = ((data.Rows[0]["ProjectRFA1_1_3"] == DBNull.Value) ? null : new decimal?((decimal)((double)data.Rows[0]["ProjectRFA1_1_3"])));
				projectBudgetInfo.ProjectRFA1_2 = ((data.Rows[0]["ProjectRFA1_2"] == DBNull.Value) ? null : new decimal?((decimal)((double)data.Rows[0]["ProjectRFA1_2"])));
				projectBudgetInfo.ProjectRFA1_3 = ((data.Rows[0]["ProjectRFA1_3"] == DBNull.Value) ? null : new decimal?((decimal)((double)data.Rows[0]["ProjectRFA1_3"])));
				projectBudgetInfo.ProjectRFA1_4 = ((data.Rows[0]["ProjectRFA1_4"] == DBNull.Value) ? null : new decimal?((decimal)((double)data.Rows[0]["ProjectRFA1_4"])));
				projectBudgetInfo.ProjectRFA1_5 = ((data.Rows[0]["ProjectRFA1_5"] == DBNull.Value) ? null : new decimal?((decimal)((double)data.Rows[0]["ProjectRFA1_5"])));
				projectBudgetInfo.ProjectRFA1_6 = ((data.Rows[0]["ProjectRFA1_6"] == DBNull.Value) ? null : new decimal?((decimal)((double)data.Rows[0]["ProjectRFA1_6"])));
				projectBudgetInfo.ProjectRFA1_7 = ((data.Rows[0]["ProjectRFA1_7"] == DBNull.Value) ? null : new decimal?((decimal)((double)data.Rows[0]["ProjectRFA1_7"])));
				projectBudgetInfo.ProjectRFA1_8 = ((data.Rows[0]["ProjectRFA1_8"] == DBNull.Value) ? null : new decimal?((decimal)((double)data.Rows[0]["ProjectRFA1_8"])));
				projectBudgetInfo.ProjectRFA1_9 = ((data.Rows[0]["ProjectRFA1_9"] == DBNull.Value) ? null : new decimal?((decimal)((double)data.Rows[0]["ProjectRFA1_9"])));
				projectBudgetInfo.ProjectRFA2 = ((data.Rows[0]["ProjectRFA2"] == DBNull.Value) ? null : new decimal?((decimal)((double)data.Rows[0]["ProjectRFA2"])));
				projectBudgetInfo.ProjectRFA2_1 = ((data.Rows[0]["ProjectRFA2_1"] == DBNull.Value) ? null : new decimal?((decimal)((double)data.Rows[0]["ProjectRFA2_1"])));
				projectBudgetInfo.Projectoutlay1 = ((data.Rows[0]["ProjectOutlay1"] == DBNull.Value) ? null : new decimal?((decimal)((double)data.Rows[0]["ProjectOutlay1"])));
				projectBudgetInfo.Projectoutlay2 = ((data.Rows[0]["ProjectOutlay2"] == DBNull.Value) ? null : new decimal?((decimal)((double)data.Rows[0]["ProjectOutlay2"])));
				projectBudgetInfo.Projectoutlay3 = ((data.Rows[0]["ProjectOutlay3"] == DBNull.Value) ? null : new decimal?((decimal)((double)data.Rows[0]["ProjectOutlay3"])));
				projectBudgetInfo.Projectoutlay4 = ((data.Rows[0]["ProjectOutlay4"] == DBNull.Value) ? null : new decimal?((decimal)((double)data.Rows[0]["ProjectOutlay4"])));
				projectBudgetInfo.Projectoutlay5 = ((data.Rows[0]["ProjectOutlay5"] == DBNull.Value) ? null : new decimal?((decimal)((double)data.Rows[0]["ProjectOutlay5"])));
				projectBudgetInfo.ProjectRFArm = ((data.Rows[0]["ProjectRFARm"] == DBNull.Value) ? "" : data.Rows[0]["ProjectRFARm"].ToString());
				projectBudgetInfo.ProjectRFA1rm = ((data.Rows[0]["ProjectRFA1Rm"] == DBNull.Value) ? "" : data.Rows[0]["ProjectRFA1Rm"].ToString());
				projectBudgetInfo.ProjectRFA1_1rm = ((data.Rows[0]["ProjectRFA1_1Rm"] == DBNull.Value) ? "" : data.Rows[0]["ProjectRFA1_1Rm"].ToString());
				projectBudgetInfo.ProjectRFA1_1_1rm = ((data.Rows[0]["ProjectRFA1_1_1Rm"] == DBNull.Value) ? "" : data.Rows[0]["ProjectRFA1_1_1Rm"].ToString());
				projectBudgetInfo.ProjectRFA1_1_2rm = ((data.Rows[0]["ProjectRFA1_1_2Rm"] == DBNull.Value) ? "" : data.Rows[0]["ProjectRFA1_1_2Rm"].ToString());
				projectBudgetInfo.ProjectRFA1_1_3rm = ((data.Rows[0]["ProjectRFA1_1_3Rm"] == DBNull.Value) ? "" : data.Rows[0]["ProjectRFA1_1_3Rm"].ToString());
				projectBudgetInfo.ProjectRFA1_2rm = ((data.Rows[0]["ProjectRFA1_2Rm"] == DBNull.Value) ? "" : data.Rows[0]["ProjectRFA1_2Rm"].ToString());
				projectBudgetInfo.ProjectRFA1_3rm = ((data.Rows[0]["ProjectRFA1_3Rm"] == DBNull.Value) ? "" : data.Rows[0]["ProjectRFA1_3Rm"].ToString());
				projectBudgetInfo.ProjectRFA1_4rm = ((data.Rows[0]["ProjectRFA1_4Rm"] == DBNull.Value) ? "" : data.Rows[0]["ProjectRFA1_4Rm"].ToString());
				projectBudgetInfo.ProjectRFA1_5rm = ((data.Rows[0]["ProjectRFA1_5Rm"] == DBNull.Value) ? "" : data.Rows[0]["ProjectRFA1_5Rm"].ToString());
				projectBudgetInfo.ProjectRFA1_6rm = ((data.Rows[0]["ProjectRFA1_6Rm"] == DBNull.Value) ? "" : data.Rows[0]["ProjectRFA1_6Rm"].ToString());
				projectBudgetInfo.ProjectRFA1_7rm = ((data.Rows[0]["ProjectRFA1_7Rm"] == DBNull.Value) ? "" : data.Rows[0]["ProjectRFA1_7Rm"].ToString());
				projectBudgetInfo.ProjectRFA1_8rm = ((data.Rows[0]["ProjectRFA1_8Rm"] == DBNull.Value) ? "" : data.Rows[0]["ProjectRFA1_8Rm"].ToString());
				projectBudgetInfo.ProjectRFA1_9rm = ((data.Rows[0]["ProjectRFA1_9Rm"] == DBNull.Value) ? "" : data.Rows[0]["ProjectRFA1_9Rm"].ToString());
				projectBudgetInfo.ProjectRFA2rm = ((data.Rows[0]["ProjectRFA2Rm"] == DBNull.Value) ? "" : data.Rows[0]["ProjectRFA2Rm"].ToString());
				projectBudgetInfo.ProjectRFA2_1rm = ((data.Rows[0]["ProjectRFA2_1Rm"] == DBNull.Value) ? "" : data.Rows[0]["ProjectRFA2_1Rm"].ToString());
			}
			return projectBudgetInfo;
		}

		internal bool UpdateProjectBudgetInfo(ProjectBudgetInfo pbinfo)
		{
			string sql = "update BaseInfor set ProjectRFA=@ProjectRFA,ProjectRFA1=@ProjectRFA1,ProjectRFA1_1=@ProjectRFA1_1,ProjectRFA1_1_1=@ProjectRFA1_1_1,ProjectRFA1_1_2=@ProjectRFA1_1_2,\r\n            ProjectRFA1_1_3=@ProjectRFA1_1_3,ProjectRFA1_2=@ProjectRFA1_2,ProjectRFA1_3=@ProjectRFA1_3,ProjectRFA1_4=@ProjectRFA1_4,ProjectRFA1_5=@ProjectRFA1_5,ProjectRFA1_6=@ProjectRFA1_6,ProjectRFA1_7=@ProjectRFA1_7,\r\nProjectRFA1_8=@ProjectRFA1_8,ProjectRFA1_9=@ProjectRFA1_9,ProjectRFA2=@ProjectRFA2,ProjectRFA2_1=@ProjectRFA2_1,ProjectRFA2_2=@ProjectRFA2_2,ProjectOutlay1=@ProjectOutlay1,ProjectOutlay2=@ProjectOutlay2,ProjectOutlay3=@ProjectOutlay3,\r\nProjectOutlay4=@ProjectOutlay4,ProjectOutlay5=@ProjectOutlay5,ProjectRFARm=@ProjectRFARm,ProjectRFA1Rm=@ProjectRFA1Rm,\r\nProjectRFA1_1Rm=@ProjectRFA1_1Rm,ProjectRFA1_1_1Rm=@ProjectRFA1_1_1Rm,ProjectRFA1_1_2Rm=@ProjectRFA1_1_2Rm,\r\nProjectRFA1_1_3Rm=@ProjectRFA1_1_3Rm,ProjectRFA1_2Rm=@ProjectRFA1_2Rm,ProjectRFA1_3Rm=@ProjectRFA1_3Rm,\r\nProjectRFA1_4Rm=@ProjectRFA1_4Rm,ProjectRFA1_5Rm=@ProjectRFA1_5Rm,ProjectRFA1_6Rm=@ProjectRFA1_6Rm,ProjectRFA1_7Rm=@ProjectRFA1_7Rm,\r\nProjectRFA1_8Rm=@ProjectRFA1_8Rm,ProjectRFA1_9Rm=@ProjectRFA1_9Rm,ProjectRFA2Rm=@ProjectRFA2Rm,ProjectRFA2_1Rm=@ProjectRFA2_1Rm,ProjectRFA2_2Rm=@ProjectRFA2_2Rm";
			SQLiteParameter[] parameters = new SQLiteParameter[]
			{
				new SQLiteParameter("@ProjectRFA", pbinfo.ProjectRFA),
				new SQLiteParameter("@ProjectRFA1", pbinfo.ProjectRFA1),
				new SQLiteParameter("@ProjectRFA1_1", pbinfo.ProjectRFA1_1),
				new SQLiteParameter("@ProjectRFA1_1_1", pbinfo.ProjectRFA1_1_1),
				new SQLiteParameter("@ProjectRFA1_1_2", pbinfo.ProjectRFA1_1_2),
				new SQLiteParameter("@ProjectRFA1_1_3", pbinfo.ProjectRFA1_1_3),
				new SQLiteParameter("@ProjectRFA1_2", pbinfo.ProjectRFA1_2),
				new SQLiteParameter("@ProjectRFA1_3", pbinfo.ProjectRFA1_3),
				new SQLiteParameter("@ProjectRFA1_4", pbinfo.ProjectRFA1_4),
				new SQLiteParameter("@ProjectRFA1_5", pbinfo.ProjectRFA1_5),
				new SQLiteParameter("@ProjectRFA1_6", pbinfo.ProjectRFA1_6),
				new SQLiteParameter("@ProjectRFA1_7", pbinfo.ProjectRFA1_7),
				new SQLiteParameter("@ProjectRFA1_8", pbinfo.ProjectRFA1_8),
				new SQLiteParameter("@ProjectRFA1_9", pbinfo.ProjectRFA1_9),
				new SQLiteParameter("@ProjectRFA2", pbinfo.ProjectRFA2),
				new SQLiteParameter("@ProjectRFA2_1", pbinfo.ProjectRFA2_1),
				new SQLiteParameter("@ProjectRFA2_2", null),
				new SQLiteParameter("@ProjectOutlay1", pbinfo.Projectoutlay1),
				new SQLiteParameter("@ProjectOutlay2", pbinfo.Projectoutlay2),
				new SQLiteParameter("@ProjectOutlay3", pbinfo.Projectoutlay3),
				new SQLiteParameter("@ProjectOutlay4", pbinfo.Projectoutlay4),
				new SQLiteParameter("@ProjectOutlay5", pbinfo.Projectoutlay5),
				new SQLiteParameter("@ProjectRFARm", pbinfo.ProjectRFArm),
				new SQLiteParameter("@ProjectRFA1Rm", pbinfo.ProjectRFA1rm),
				new SQLiteParameter("@ProjectRFA1_1Rm", pbinfo.ProjectRFA1_1rm),
				new SQLiteParameter("@ProjectRFA1_1_1Rm", pbinfo.ProjectRFA1_1_1rm),
				new SQLiteParameter("@ProjectRFA1_1_2Rm", pbinfo.ProjectRFA1_1_2rm),
				new SQLiteParameter("@ProjectRFA1_1_3Rm", pbinfo.ProjectRFA1_1_3rm),
				new SQLiteParameter("@ProjectRFA1_2Rm", pbinfo.ProjectRFA1_2rm),
				new SQLiteParameter("@ProjectRFA1_3Rm", pbinfo.ProjectRFA1_3rm),
				new SQLiteParameter("@ProjectRFA1_4Rm", pbinfo.ProjectRFA1_4rm),
				new SQLiteParameter("@ProjectRFA1_5Rm", pbinfo.ProjectRFA1_5rm),
				new SQLiteParameter("@ProjectRFA1_6Rm", pbinfo.ProjectRFA1_6rm),
				new SQLiteParameter("@ProjectRFA1_7Rm", pbinfo.ProjectRFA1_7rm),
				new SQLiteParameter("@ProjectRFA1_8Rm", pbinfo.ProjectRFA1_8rm),
				new SQLiteParameter("@ProjectRFA1_9Rm", pbinfo.ProjectRFA1_9rm),
				new SQLiteParameter("@ProjectRFA2Rm", pbinfo.ProjectRFA2rm),
				new SQLiteParameter("@ProjectRFA2_1Rm", pbinfo.ProjectRFA2_1rm),
				new SQLiteParameter("@ProjectRFA2_2Rm", "")
			};
			string text = "";
			base.ExecuteNonQuery(sql, parameters, out text);
			return true;
		}
	}
}
