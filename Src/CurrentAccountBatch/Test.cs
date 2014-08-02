using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrentAccountBatch
{
    class Test
    {

        public static StreamWriter LogWriter = null;
        static string contractcode = "12";
        static string statuscode = "21";
        static string codes;


        static int Main(string[] args)
        {
            OpenLog();

            //db = DatabaseFactory.CreateDatabase("MyDatabase");
            //DbCommand cmd = db.GetStoredProcCommand("MyStoredProcedure");
            ChangeStatus();
            WriteToLog(codes);
            CloseLog();
            return 0;
        }
        static private void OpenLog()
        {
            // Create log folder if it doesn't exist
            string folderPath = Path.Combine(Environment.CurrentDirectory, "Log Files");
            DirectoryInfo logFolder = new DirectoryInfo(folderPath);

            if (!logFolder.Exists)
                logFolder.Create();

            // Clear out old logs
            //string appSetting = ConfigurationManager.AppSettings["DaysToStoreLogFiles"];
            int days = 5;//int.Parse(appSetting);
            TimeSpan span = new TimeSpan(days, 0, 0, 0);

            foreach (FileInfo logFile in logFolder.GetFiles())
            {
                if (logFile.CreationTime < DateTime.Now - span)
                    logFile.Delete();
            }

            // Create new log file
            string filePath = Path.Combine(folderPath, DateTime.Now.ToString("yyyy-MM-dd-hhmmss"));

            if (File.Exists(filePath + ".txt"))
            {
                bool exitApplication = true;
                for (int x = 1; x <= 10; x++)
                {
                    string newPath = filePath + "(" + x.ToString() + ")";

                    if (!File.Exists(newPath + ".txt"))
                    {
                        filePath = newPath;
                        exitApplication = false;
                        break;
                    }
                }

                // If someone has really launched the batch job more than 10 times in 
                // a single second, something is wrong.
                if (exitApplication)
                    Environment.Exit(1);
            }

            LogWriter = File.CreateText(filePath + ".txt");
            WriteToLog("Begin processing:  " + DateTime.Now.ToString("yyyy-MM-dd-hh:mm:ss"));
            WriteToLog("-----------------------------------------------------------");
            WriteToLog("");
        }

        static private void CloseLog()
        {
            WriteToLog("");
            WriteToLog("------------------------------------------------------------");
            WriteToLog("Finish processing:  " + DateTime.Now.ToString("yyyy-MM-dd-hh:mm:ss"));

            LogWriter.Close();
        }

        static private void WriteToLog(string logEntry)
        {
            LogWriter.WriteLine(logEntry);
        }
        static private void ChangeStatus()
        {
            statuscode = "Tanvee";
            codes = contractcode + "," + statuscode;
        }

    }
}
