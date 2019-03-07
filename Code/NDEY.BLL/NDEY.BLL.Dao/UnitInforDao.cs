using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Text;
using NDEY.BLL.Entity;

namespace NDEY.BLL.Dao
{
    public class UnitInforDao : BaseDBDao
    {
        internal IList<UnitInfor> GetUnitInforList()
        {
            string querystring = "select * from UnitInfor";
            string text = "";
            DataTable data = base.GetData(querystring, out text);
            IList<UnitInfor> list = new List<UnitInfor>();
            foreach (DataRow dataRow in data.Rows)
            {
                list.Add(new UnitInfor
                {
                    ID = dataRow["ID"].ToString(),
                    UnitName = dataRow["UnitName"].ToString(),
                    UnitType = dataRow["UnitType"].ToString(),
                    UnitBankUser = dataRow["UnitBankUser"].ToString(),
                    UnitBankName = dataRow["UnitBankName"].ToString(),
                    UnitBankNo = dataRow["UnitBankNo"].ToString(),
                    IsUserAdded = Int32.Parse(dataRow["IsUserAdded"].ToString())
                });
            }
            return list;
        }

        internal IList<UnitInfor> GetUnitInforList(string[] idList)
        {
            string querystring = "select * from UnitInfor" + (idList != null && idList.Length >= 1 ? " where ID = '" + idList[0] + "'" : string.Empty);
            string text = "";
            DataTable data = base.GetData(querystring, out text);
            IList<UnitInfor> list = new List<UnitInfor>();
            foreach (DataRow dataRow in data.Rows)
            {
                list.Add(new UnitInfor
                {
                    ID = dataRow["ID"].ToString(),
                    UnitName = dataRow["UnitName"].ToString(),
                    UnitType = dataRow["UnitType"].ToString(),
                    UnitBankUser = dataRow["UnitBankUser"].ToString(),
                    UnitBankName = dataRow["UnitBankName"].ToString(),
                    UnitBankNo = dataRow["UnitBankNo"].ToString(),
                    IsUserAdded = Int32.Parse(dataRow["IsUserAdded"].ToString())
                });
            }
            return list;
        }

        internal bool Add(UnitInfor model)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("insert into UnitInfor(");
            stringBuilder.Append("ID,UnitName,UnitType,UnitBankUser,UnitBankName,UnitBankNo,IsUserAdded)");
            stringBuilder.Append(" values (");
            stringBuilder.Append("@ID,@UnitName,@UnitType,@UnitBankUser,@UnitBankName,@UnitBankNo,@IsUserAdded)");
            SQLiteParameter[] array = new SQLiteParameter[]
            {
                new SQLiteParameter("@ID", DbType.String),
                new SQLiteParameter("@UnitName", DbType.String),
                new SQLiteParameter("@UnitType", DbType.String),
                new SQLiteParameter("@UnitBankUser", DbType.String),
                new SQLiteParameter("@UnitBankName", DbType.String),
                new SQLiteParameter("@UnitBankNo", DbType.String),
                new SQLiteParameter("@IsUserAdded",DbType.Int32)
            };
            array[0].Value = model.ID;
            array[1].Value = model.UnitName;
            array[2].Value = model.UnitType;
            array[3].Value = model.UnitBankUser;
            array[4].Value = model.UnitBankName;
            array[5].Value = model.UnitBankNo;
            array[6].Value = model.IsUserAdded;
            string text = "";
            base.ExecuteNonQuery(stringBuilder.ToString(), array, out text);
            return true;
        }

        internal bool Update(UnitInfor model)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("update UnitInfor set ");
            stringBuilder.Append("ID=@ID,");
            stringBuilder.Append("UnitName=@UnitName,");
            stringBuilder.Append("UnitType=@UnitType,");
            stringBuilder.Append("UnitBankUser=@UnitBankUser,");
            stringBuilder.Append("UnitBankName=@UnitBankName,");
            stringBuilder.Append("UnitBankNo=@UnitBankNo,");
            stringBuilder.Append("IsUserAdded=@IsUserAdded");
            stringBuilder.Append(" where ID=@ID");
            SQLiteParameter[] array = new SQLiteParameter[]
            {
                new SQLiteParameter("@ID", DbType.String),
                new SQLiteParameter("@UnitName", DbType.String),
                new SQLiteParameter("@UnitType", DbType.String),
                new SQLiteParameter("@UnitBankUser", DbType.String),
                new SQLiteParameter("@UnitBankName", DbType.String),
                new SQLiteParameter("@UnitBankNo", DbType.String),
                new SQLiteParameter("@IsUserAdded", DbType.Int32,4)
            };
            array[0].Value = model.ID;
            array[1].Value = model.UnitName;
            array[2].Value = model.UnitType;
            array[3].Value = model.UnitBankUser;
            array[4].Value = model.UnitBankName;
            array[5].Value = model.UnitBankNo;
            array[6].Value = model.IsUserAdded;
            string text = "";
            base.ExecuteNonQuery(stringBuilder.ToString(), array, out text);
            return true;
        }

        internal bool DeleteUnitInfor(string item)
        {
            string sql = "DELETE FROM UnitInfor where ID=@ID";
            SQLiteParameter[] parameters = new SQLiteParameter[]
            {
                new SQLiteParameter("@ID", item)
            };
            string text = "";
            base.ExecuteNonQuery(sql, parameters, out text);
            return true;
        }
    }
}