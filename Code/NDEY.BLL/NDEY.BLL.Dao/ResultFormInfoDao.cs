using NDEY.BLL.Entity;
using System;
using System.Data;
using System.Data.SQLite;

namespace NDEY.BLL.Dao
{
	public class ResultFormInfoDao : BaseDBDao
	{
		public ResultFormInfo GetResultFormInfo()
		{
			string querystring = "select IDCardName from BaseInfor";
			string text = "";
			DataTable data = base.GetData(querystring, out text);
			ResultFormInfo resultFormInfo = null;
			if (data != null && data.Rows.Count > 0)
			{
				resultFormInfo = new ResultFormInfo();
				resultFormInfo.IsCBR1Checked = false;
				resultFormInfo.IsCBR2Checked = false;
				resultFormInfo.IsCBR3Checked = false;
				resultFormInfo.IsCBR4Checked = false;
				resultFormInfo.IsCBR5Checked = false;
				resultFormInfo.IsCBR6Checked = false;
				resultFormInfo.IsCBR7Checked = false;
				resultFormInfo.IsCBR8Checked = false;
				resultFormInfo.IsCBR9Checked = false;
				resultFormInfo.IsCBR10Checked = false;
				resultFormInfo.IsCBR11Checked = false;
				resultFormInfo.IsCBR12Checked = false;
				resultFormInfo.CBROtherText = string.Empty;
				if (data.Rows[0]["IDCardName"] != DBNull.Value)
				{
					string text2 = data.Rows[0]["IDCardName"].ToString();
					string[] array = text2.Split(new char[]
					{
						'|'
					});
					if (array.Length == 13)
					{
						resultFormInfo.IsCBR1Checked = bool.Parse(array[0]);
						resultFormInfo.IsCBR2Checked = bool.Parse(array[1]);
						resultFormInfo.IsCBR3Checked = bool.Parse(array[2]);
						resultFormInfo.IsCBR4Checked = bool.Parse(array[3]);
						resultFormInfo.IsCBR5Checked = bool.Parse(array[4]);
						resultFormInfo.IsCBR6Checked = bool.Parse(array[5]);
						resultFormInfo.IsCBR7Checked = bool.Parse(array[6]);
						resultFormInfo.IsCBR8Checked = bool.Parse(array[7]);
						resultFormInfo.IsCBR9Checked = bool.Parse(array[8]);
						resultFormInfo.IsCBR10Checked = bool.Parse(array[9]);
						resultFormInfo.IsCBR11Checked = bool.Parse(array[10]);
						resultFormInfo.IsCBR12Checked = bool.Parse(array[11]);
						resultFormInfo.CBROtherText = array[12];
					}
				}
			}
			return resultFormInfo;
		}

		public bool UpdateResultFormInfo(ResultFormInfo info)
		{
			string sql = "update BaseInfor set IDCardName=@IDCardName ";
			string text = "";
			string text2 = text;
			text = string.Concat(new string[]
			{
				text2,
				info.IsCBR1Checked.ToString(),
				"|",
				info.IsCBR2Checked.ToString(),
				"|",
				info.IsCBR3Checked.ToString(),
				"|",
				info.IsCBR4Checked.ToString(),
				"|",
				info.IsCBR5Checked.ToString(),
				"|",
				info.IsCBR6Checked.ToString(),
				"|",
				info.IsCBR7Checked.ToString(),
				"|",
				info.IsCBR8Checked.ToString(),
				"|",
				info.IsCBR9Checked.ToString(),
				"|",
				info.IsCBR10Checked.ToString(),
				"|",
				info.IsCBR11Checked.ToString(),
				"|",
				info.IsCBR12Checked.ToString(),
				"|",
				info.CBROtherText
			});
			SQLiteParameter[] parameters = new SQLiteParameter[]
			{
				new SQLiteParameter("@IDCardName", text)
			};
			string text3 = "";
			base.ExecuteNonQuery(sql, parameters, out text3);
			return true;
		}
	}
}
