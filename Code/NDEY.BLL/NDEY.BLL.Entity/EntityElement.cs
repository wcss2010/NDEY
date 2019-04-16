using System;
using System.IO;

namespace NDEY.BLL.Entity
{
	public class EntityElement
	{
		public enum ExportType
		{
			ToWord,
			ToZipFile
		}

        public static string UserPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "NDEY_DATA");

        public static string FilesStorePath = Path.Combine(UserPath, "Files");

		public static string DBStorePath = Path.Combine(UserPath, "DB");

		public static string TemplatePath = Path.Combine(UserPath, "Template");

		public static string DBName = "myData.db";

        public static string TempPath = Path.Combine(UserPath, "Temp");
	}
}
