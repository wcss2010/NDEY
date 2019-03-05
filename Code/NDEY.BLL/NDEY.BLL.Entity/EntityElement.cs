using System;

namespace NDEY.BLL.Entity
{
	public class EntityElement
	{
		public enum ExportType
		{
			ToWord,
			ToZipFile
		}

		public static string UserPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\NDEY";

		public static string FilesStorePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\NDEY\\Files";

		public static string DBStorePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\NDEY\\DB";

		public static string TemplatePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\NDEY\\Template";

		public static string DBName = "myData.db";

		public static string TempPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\NDEY\\Temp";
	}
}
