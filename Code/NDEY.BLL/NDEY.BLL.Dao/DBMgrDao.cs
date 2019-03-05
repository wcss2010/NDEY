using System;
using System.Data.SQLite;

namespace NDEY.BLL.Dao
{
	public class DBMgrDao : BaseDBDao
	{
		internal void InitDB()
		{
			string text = "delete from UnitInfor where IsUserAdded = 1;delete from AcademicPost;delete from BaseInfor;delete from Education;delete from NDPatent;\r\ndelete from NDProject;delete from RTreatises;delete from TalentsPlan;delete from TechnologyAwards;delete from WorkExperience";
			string text2 = "";
			base.ExecuteNonQuery(text, out text2);
			text = "insert into BaseInfor(UserName) values (@UserName)";
			SQLiteParameter[] parameters = new SQLiteParameter[]
			{
				new SQLiteParameter("@UserName", "")
			};
			base.ExecuteNonQuery(text, parameters, out text2);
		}
	}
}
