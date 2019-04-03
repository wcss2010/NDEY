using System;
using System.Diagnostics;

namespace NDEY.UI.Utility
{
	public class FileOp
	{
		public static Process myProcess;

		public static bool RunWordInstCheck(out string msg)
		{
			msg = "";

            if (FileOp.myProcess != null)
            {
                try
                {
                    if (!FileOp.myProcess.HasExited)
                    {
                        FileOp.myProcess.Kill();
                        FileOp.myProcess.WaitForExit();
                    }
                }
                catch (Exception ex)
                { }
                finally
                {
                    FileOp.myProcess = null;
                }
            }

            try
			{
				Process[] processesByName = Process.GetProcessesByName("winword");
				Process[] array = processesByName;
				for (int i = 0; i < array.Length; i++)
				{
					Process process = array[i];
					IntPtr arg_53_0 = process.MainWindowHandle;
					string mainWindowTitle = process.MainWindowTitle;
					if (string.IsNullOrEmpty(mainWindowTitle))
					{
						process.Kill();
					}
				}
			}
			catch (Exception ex)
			{
				msg = ex.ToString();
				return false;
			}
			return true;
		}

		public static bool OpenFile(string path)
		{
			bool result = false;
			FileOp.myProcess = new Process();
			try
			{
				FileOp.myProcess.StartInfo.FileName = path;
				FileOp.myProcess.StartInfo.Verb = "Open";
				FileOp.myProcess.StartInfo.CreateNoWindow = true;
				FileOp.myProcess.Exited += new EventHandler(FileOp.myProcess_Exited);
				FileOp.myProcess.EnableRaisingEvents = true;
				FileOp.myProcess.Start();
				result = true;
			}
			catch (Exception)
			{
				result = false;
			}
			return result;
		}

		private static void myProcess_Exited(object sender, EventArgs e)
		{
			FileOp.myProcess = null;
		}
	}
}
