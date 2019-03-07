using NDEY.BLL.Entity;
using System;
using System.Data;
using System.Data.SQLite;

namespace NDEY.BLL.Dao
{
	public class ApplyUserBaseInfoDao : BaseDBDao
	{
		public ApplyUserInfo GetUserBaseInfo()
		{
			string querystring = "select UserName,WorkUnitID,WorkUnitName,Sex,Birthdate,Degree,JobTitle,UnitPosition,MainResearch,\r\nCardNo,OfficePhones,MobilePhone,EMail,UnitID,UnitName,UnitIDCard,UnitNormal,UnitContacts,UnitAddress,UnitForORG,UnitProperties,UnitContactsPhone from BaseInfor";
			string text = "";
			DataTable data = base.GetData(querystring, out text);
			ApplyUserInfo applyUserInfo = null;
			if (data != null && data.Rows.Count > 0)
			{
				applyUserInfo = new ApplyUserInfo();
				applyUserInfo.ApplyUserName = ((data.Rows[0]["UserName"] == DBNull.Value) ? "" : data.Rows[0]["UserName"].ToString());
				applyUserInfo.Sex = ((data.Rows[0]["Sex"] == DBNull.Value) ? "" : data.Rows[0]["Sex"].ToString());
				applyUserInfo.Birthday = ((data.Rows[0]["Birthdate"] == DBNull.Value) ? DateTime.Now.ToLongDateString() : data.Rows[0]["Birthdate"].ToString());
				applyUserInfo.BirInDB = ((data.Rows[0]["Birthdate"] == DBNull.Value) ? "" : data.Rows[0]["Birthdate"].ToString());
				applyUserInfo.Degree = ((data.Rows[0]["Degree"] == DBNull.Value) ? "" : data.Rows[0]["Degree"].ToString());
				applyUserInfo.JobTitle = ((data.Rows[0]["JobTitle"] == DBNull.Value) ? "" : data.Rows[0]["JobTitle"].ToString());
				applyUserInfo.UnitPosition = ((data.Rows[0]["UnitPosition"] == DBNull.Value) ? "" : data.Rows[0]["UnitPosition"].ToString());
				applyUserInfo.MainResearch = ((data.Rows[0]["MainResearch"] == DBNull.Value) ? "" : data.Rows[0]["MainResearch"].ToString());
				applyUserInfo.CardNo = ((data.Rows[0]["CardNo"] == DBNull.Value) ? "" : data.Rows[0]["CardNo"].ToString());
				applyUserInfo.OfficePhones = ((data.Rows[0]["OfficePhones"] == DBNull.Value) ? "" : data.Rows[0]["OfficePhones"].ToString());
				applyUserInfo.MobilePhone = ((data.Rows[0]["MobilePhone"] == DBNull.Value) ? "" : data.Rows[0]["MobilePhone"].ToString());
				applyUserInfo.EMail = ((data.Rows[0]["EMail"] == DBNull.Value) ? "" : data.Rows[0]["EMail"].ToString());
				applyUserInfo.WorkUnitID = ((data.Rows[0]["WorkUnitID"] == DBNull.Value) ? "" : data.Rows[0]["WorkUnitID"].ToString());
                applyUserInfo.WorkUnitName = ((data.Rows[0]["WorkUnitName"] == DBNull.Value) ? "" : data.Rows[0]["WorkUnitName"].ToString());
                applyUserInfo.UnitID = ((data.Rows[0]["UnitID"] == DBNull.Value) ? "" : data.Rows[0]["UnitID"].ToString());
                applyUserInfo.UnitName = ((data.Rows[0]["UnitName"] == DBNull.Value) ? "" : data.Rows[0]["UnitName"].ToString());
                applyUserInfo.UnitIDCard = ((data.Rows[0]["UnitIDCard"] == DBNull.Value) ? "" : data.Rows[0]["UnitIDCard"].ToString());
                applyUserInfo.UnitNormal = ((data.Rows[0]["UnitNormal"] == DBNull.Value) ? "" : data.Rows[0]["UnitNormal"].ToString());
                applyUserInfo.UnitContacts = ((data.Rows[0]["UnitContacts"] == DBNull.Value) ? "" : data.Rows[0]["UnitContacts"].ToString());
				applyUserInfo.UnitForORG = ((data.Rows[0]["UnitForORG"] == DBNull.Value) ? "" : data.Rows[0]["UnitForORG"].ToString());
				applyUserInfo.UnitProperties = ((data.Rows[0]["UnitProperties"] == DBNull.Value) ? "" : data.Rows[0]["UnitProperties"].ToString());
				applyUserInfo.UnitContactsPhone = ((data.Rows[0]["UnitContactsPhone"] == DBNull.Value) ? "" : data.Rows[0]["UnitContactsPhone"].ToString());
				applyUserInfo.UnitAddress = ((data.Rows[0]["UnitAddress"] == DBNull.Value) ? "" : data.Rows[0]["UnitAddress"].ToString());
			}
			return applyUserInfo;
		}

		public void DeleteUserBaseInfo()
		{
		}

		public bool UpdateUserBaseInfo(ApplyUserInfo userinfo)
		{
			string sql = "update BaseInfor set  UserName=@UserName,WorkUnitID=@WorkUnitID,WorkUnitName=@WorkUnitName,Sex=@Sex,Birthdate=@Birthdate,\r\nDegree=@Degree,JobTitle=@JobTitle,UnitPosition=@UnitPosition,MainResearch=@MainResearch,\r\nCardNo=@CardNo,OfficePhones=@OfficePhones,MobilePhone=@MobilePhone,EMail=@EMail,UnitID=@UnitID,UnitName=@UnitName,UnitIDCard=@UnitIDCard,UnitNormal=@UnitNormal,UnitContacts=@UnitContacts,\r\nUnitAddress=@UnitAddress,UnitForORG=@UnitForORG,UnitProperties=@UnitProperties,UnitContactsPhone=@UnitContactsPhone";
            SQLiteParameter[] parameters = new SQLiteParameter[]
            {
                new SQLiteParameter("@UserName", userinfo.ApplyUserName),
                new SQLiteParameter("@WorkUnitID", userinfo.WorkUnitID),
                new SQLiteParameter("@WorkUnitName", userinfo.WorkUnitName),
                new SQLiteParameter("@Sex", userinfo.Sex),
                new SQLiteParameter("@Birthdate", userinfo.Birthday),
                new SQLiteParameter("@Degree", userinfo.Degree),
                new SQLiteParameter("@JobTitle", userinfo.JobTitle),
                new SQLiteParameter("@UnitPosition", userinfo.UnitPosition),
                new SQLiteParameter("@MainResearch", userinfo.MainResearch),
                new SQLiteParameter("@CardNo", userinfo.CardNo),
                new SQLiteParameter("@OfficePhones", userinfo.OfficePhones),
                new SQLiteParameter("@MobilePhone", userinfo.MobilePhone),
                new SQLiteParameter("@EMail", userinfo.EMail),
                new SQLiteParameter("@UnitID", userinfo.UnitID),
                new SQLiteParameter("@UnitName", userinfo.UnitName),
                new SQLiteParameter("@UnitIDCard", userinfo.UnitIDCard),
                new SQLiteParameter("@UnitNormal",userinfo.UnitNormal),
                new SQLiteParameter("@UnitContacts", userinfo.UnitContacts),
                new SQLiteParameter("@UnitAddress", userinfo.UnitAddress),
                new SQLiteParameter("@UnitForORG", userinfo.UnitForORG),
                new SQLiteParameter("@UnitProperties", userinfo.UnitProperties),
                new SQLiteParameter("@UnitContactsPhone", userinfo.UnitContactsPhone)
            };
			string text = "";
			base.ExecuteNonQuery(sql, parameters, out text);
			return true;
		}

		public bool AddUserBaseInfo(ApplyUserInfo userinfo)
		{
			string sql = "insert into BaseInfor ( UserName,WorkUnitID,WorkUnitName,Sex,Birthdate,Degree,JobTitle,UnitPosition,MainResearch,\r\nCardNo,OfficePhones,MobilePhone,EMail,UnitID,UnitName,UnitIDCard,UnitNormal,UnitContacts,UnitAddress,UnitForORG,UnitProperties,UnitContactsPhone)\r\nvalues ( @UserName,@WorkUnit,@Sex,@Birthdate,@Degree,@JobTitle,@UnitPosition,@MainResearch,@CardNo,@OfficePhones,\r\n@MobilePhone,@EMail,@Unit,@UnitNormal,@UnitContacts,@UnitAddress,@UnitForORG,@UnitProperties,@UnitContactsPhone)";
            SQLiteParameter[] parameters = new SQLiteParameter[]
            {
                new SQLiteParameter("@UserName", userinfo.ApplyUserName),
                new SQLiteParameter("@WorkUnitID", userinfo.WorkUnitID),
                new SQLiteParameter("@WorkUnitName",userinfo.WorkUnitName),
                new SQLiteParameter("@Sex", userinfo.Sex),
                new SQLiteParameter("@Birthdate", userinfo.Birthday),
                new SQLiteParameter("@Degree", userinfo.Degree),
                new SQLiteParameter("@JobTitle", userinfo.JobTitle),
                new SQLiteParameter("@UnitPosition", userinfo.UnitPosition),
                new SQLiteParameter("@MainResearch", userinfo.MainResearch),
                new SQLiteParameter("@CardNo", userinfo.CardNo),
                new SQLiteParameter("@OfficePhones", userinfo.OfficePhones),
                new SQLiteParameter("@MobilePhone", userinfo.MobilePhone),
                new SQLiteParameter("@EMail", userinfo.EMail),
                new SQLiteParameter("@UnitID", userinfo.UnitID),
                new SQLiteParameter("@UnitName",userinfo.UnitName),
                new SQLiteParameter("@UnitIDCard",userinfo.UnitIDCard),
                new SQLiteParameter("@UnitNormal",userinfo.UnitNormal),
                new SQLiteParameter("@UnitContacts", userinfo.UnitContacts),
                new SQLiteParameter("@UnitAddress", userinfo.UnitAddress),
                new SQLiteParameter("@UnitForORG", userinfo.UnitForORG),
                new SQLiteParameter("@UnitProperties", userinfo.UnitProperties),
                new SQLiteParameter("@UnitContactsPhone", userinfo.UnitContactsPhone)
            };
			string text = "";
			base.ExecuteNonQuery(sql, parameters, out text);
			return true;
		}
	}
}