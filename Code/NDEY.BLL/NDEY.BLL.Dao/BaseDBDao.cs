using NDEY.BLL.Entity;
using System;
using System.Data;
using System.Data.SQLite;
using System.IO;

namespace NDEY.BLL.Dao
{
	public class BaseDBDao
	{
		private string db = Path.Combine(EntityElement.DBStorePath, "myData.db");

		public DataTable GetData(string querystring, out string msg)
		{
			DataTable dataTable = null;
			msg = "";
			if (string.IsNullOrEmpty(querystring))
			{
				return null;
			}
			try
			{
				using (SQLiteConnection sQLiteConnection = new SQLiteConnection(new SQLiteConnectionStringBuilder
				{
					DataSource = this.db
				}.ConnectionString))
				{
					SQLiteDataAdapter sQLiteDataAdapter = new SQLiteDataAdapter(querystring, sQLiteConnection);
					dataTable = new DataTable();
					sQLiteDataAdapter.Fill(dataTable);
					sQLiteConnection.Close();
					sQLiteConnection.Dispose();
				}
			}
			catch (Exception ex)
			{
				msg = ex.Message;
			}
			return dataTable;
		}

		public int ExecuteNonQuery(string cmdStr, out string msg)
		{
			int result = 0;
			msg = "";
			using (SQLiteConnection sQLiteConnection = new SQLiteConnection(new SQLiteConnectionStringBuilder
			{
				DataSource = this.db
			}.ConnectionString))
			{
				using (SQLiteCommand sQLiteCommand = new SQLiteCommand(cmdStr, sQLiteConnection))
				{
					try
					{
						sQLiteConnection.Open();
						result = sQLiteCommand.ExecuteNonQuery();
						sQLiteConnection.Close();
						sQLiteConnection.Dispose();
					}
					catch (Exception ex)
					{
						msg = ex.Message;
					}
				}
			}
			return result;
		}

		public int ExecuteNonQuery(string sql, SQLiteParameter[] parameters, out string msg)
		{
			int result = 0;
			msg = "";
			using (SQLiteConnection sQLiteConnection = new SQLiteConnection(new SQLiteConnectionStringBuilder
			{
				DataSource = this.db
			}.ConnectionString))
			{
				using (SQLiteCommand sQLiteCommand = new SQLiteCommand(sql, sQLiteConnection))
				{
					sQLiteCommand.Parameters.AddRange(parameters);
					try
					{
						sQLiteConnection.Open();
						result = sQLiteCommand.ExecuteNonQuery();
						sQLiteConnection.Close();
						sQLiteConnection.Dispose();
					}
					catch (Exception ex)
					{
						msg = ex.Message;
					}
				}
			}
			return result;
		}
	}
}
