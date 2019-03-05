using NDEY.BLL.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Text;

namespace NDEY.BLL.Dao
{
	public class NDPatentDao : BaseDBDao
	{
		internal IList<NDPatent> GetNDPatent()
		{
			string querystring = "select  NDPatentNo,NDPatentApplicants,NDPatentName,NDPatentType,NDPatentApprovalYear,NDPatentNumber,NDPatentContent,NDPatentPDF,NDPatentPDFOName,NDPatentOrder from NDPatent order by NDPatentOrder desc";
			string text = "";
			DataTable data = base.GetData(querystring, out text);
			IList<NDPatent> list = new List<NDPatent>();
			foreach (DataRow dataRow in data.Rows)
			{
				list.Add(new NDPatent
				{
					NDPatentNo = dataRow["NDPatentNo"].ToString(),
					NDPatentApplicants = dataRow["NDPatentApplicants"].ToString(),
					NDPatentName = dataRow["NDPatentName"].ToString(),
                    NDPatentType = dataRow["NDPatentType"].ToString(),
                    NDPatentApprovalYear = dataRow["NDPatentApprovalYear"].ToString(),
					NDPatentNumber = dataRow["NDPatentNumber"].ToString(),
					NDPatentContent = dataRow["NDPatentContent"].ToString(),
					NDPatentPDF = dataRow["NDPatentPDF"].ToString(),
					NDPatentPDFOName = dataRow["NDPatentPDFOName"].ToString(),
					UpLoadFullPath = "",
					NDPatentOrder = (int)((long)dataRow["NDPatentOrder"])
				});
			}
			return list;
		}

		internal bool Add(NDPatent model)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("insert into NDPatent(");
			stringBuilder.Append("NDPatentNo,NDPatentApplicants,NDPatentName,NDPatentType,NDPatentApprovalYear,NDPatentNumber,NDPatentContent,NDPatentPDF,NDPatentPDFOName,NDPatentOrder)");
			stringBuilder.Append(" values (");
			stringBuilder.Append("@NDPatentNo,@NDPatentApplicants,@NDPatentName,@NDPatentType,@NDPatentApprovalYear,@NDPatentNumber,@NDPatentContent,@NDPatentPDF,@NDPatentPDFOName,@NDPatentOrder)");
			SQLiteParameter[] array = new SQLiteParameter[]
			{
				new SQLiteParameter("@NDPatentNo", DbType.String),
				new SQLiteParameter("@NDPatentApplicants", DbType.String),
				new SQLiteParameter("@NDPatentName", DbType.String),
                new SQLiteParameter("@NDPatentType",DbType.String),
				new SQLiteParameter("@NDPatentApprovalYear", DbType.String),
				new SQLiteParameter("@NDPatentNumber", DbType.String),
				new SQLiteParameter("@NDPatentContent", DbType.String),
				new SQLiteParameter("@NDPatentPDF", DbType.String),
				new SQLiteParameter("@NDPatentPDFOName", DbType.String),
				new SQLiteParameter("@NDPatentOrder", DbType.Int32, 4)
			};
			array[0].Value = model.NDPatentNo;
			array[1].Value = model.NDPatentApplicants;
			array[2].Value = model.NDPatentName;
            array[3].Value = model.NDPatentType;
            array[4].Value = model.NDPatentApprovalYear;
			array[5].Value = model.NDPatentNumber;
			array[6].Value = model.NDPatentContent;
			array[7].Value = model.NDPatentPDF;
			array[8].Value = model.NDPatentPDFOName;
			array[9].Value = model.NDPatentOrder;
			string text = "";
			base.ExecuteNonQuery(stringBuilder.ToString(), array, out text);
			return true;
		}

		internal bool Update(NDPatent model)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("update NDPatent set ");
			stringBuilder.Append("NDPatentNo=@NDPatentNo,");
			stringBuilder.Append("NDPatentApplicants=@NDPatentApplicants,");
			stringBuilder.Append("NDPatentName=@NDPatentName,");
            stringBuilder.Append("NDPatentType=@NDPatentType,");
            stringBuilder.Append("NDPatentApprovalYear=@NDPatentApprovalYear,");
			stringBuilder.Append("NDPatentNumber=@NDPatentNumber,");
			stringBuilder.Append("NDPatentContent=@NDPatentContent,");
			stringBuilder.Append("NDPatentPDF=@NDPatentPDF,");
			stringBuilder.Append("NDPatentPDFOName=@NDPatentPDFOName,");
			stringBuilder.Append("NDPatentOrder=@NDPatentOrder");
			stringBuilder.Append(" where NDPatentNo=@NDPatentNo");
			SQLiteParameter[] array = new SQLiteParameter[]
			{
				new SQLiteParameter("@NDPatentNo", DbType.String),
				new SQLiteParameter("@NDPatentApplicants", DbType.String),
				new SQLiteParameter("@NDPatentName", DbType.String),
                new SQLiteParameter("@NDPatentType",DbType.String),
				new SQLiteParameter("@NDPatentApprovalYear", DbType.String),
				new SQLiteParameter("@NDPatentNumber", DbType.String),
				new SQLiteParameter("@NDPatentContent", DbType.String),
				new SQLiteParameter("@NDPatentPDF", DbType.String),
				new SQLiteParameter("@NDPatentPDFOName", DbType.String),
				new SQLiteParameter("@NDPatentOrder", DbType.Int32, 4)
			};
			array[0].Value = model.NDPatentNo;
			array[1].Value = model.NDPatentApplicants;
			array[2].Value = model.NDPatentName;
            array[3].Value = model.NDPatentType;
            array[4].Value = model.NDPatentApprovalYear;
			array[5].Value = model.NDPatentNumber;
			array[6].Value = model.NDPatentContent;
			array[7].Value = model.NDPatentPDF;
			array[8].Value = model.NDPatentPDFOName;
			array[9].Value = model.NDPatentOrder;
			string text = "";
			base.ExecuteNonQuery(stringBuilder.ToString(), array, out text);
			return true;
		}

		internal bool DeleteNDPatent(string p)
		{
			string sql = "DELETE FROM NDPatent where NDPatentNo=@NDPatentNo";
			SQLiteParameter[] parameters = new SQLiteParameter[]
			{
				new SQLiteParameter("@NDPatentNo", p)
			};
			string text = "";
			base.ExecuteNonQuery(sql, parameters, out text);
			return true;
		}
	}
}