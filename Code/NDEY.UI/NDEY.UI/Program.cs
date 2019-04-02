using NDEY.BLL.Entity;
using System;
using System.IO;
using System.Windows.Forms;

namespace NDEY.UI
{
	internal static class Program
	{
		private static ApplicationContext context;

		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			startForm startform = new startForm();
			startform.Show();
			Program.context = new ApplicationContext();
			Program.context.Tag = startform;
			Application.Idle += new EventHandler(Program.Application_Idle);
			Application.Run(Program.context);
			if (!Directory.Exists(EntityElement.UserPath))
			{
				Directory.CreateDirectory(EntityElement.UserPath);
			}
			if (!Directory.Exists(EntityElement.FilesStorePath))
			{
				Directory.CreateDirectory(EntityElement.FilesStorePath);
			}
			if (!Directory.Exists(EntityElement.DBStorePath))
			{
				Directory.CreateDirectory(EntityElement.DBStorePath);
			}
			if (!Directory.Exists(EntityElement.TemplatePath))
			{
				Directory.CreateDirectory(EntityElement.TemplatePath);
			}
			if (!Directory.Exists(EntityElement.TempPath))
			{
				Directory.CreateDirectory(EntityElement.TempPath);
			}
		}

		private static void Application_Idle(object sender, EventArgs e)
		{
			Application.Idle -= new EventHandler(Program.Application_Idle);
			if (Program.context.MainForm == null)
			{
				logicForm logicform = new logicForm();
				Program.context.MainForm = logicform;
				logicform.initcontent();
				startForm startform = (startForm)Program.context.Tag;
				startform.Close();
				logicform.Show();
			}
		}
	}
}
