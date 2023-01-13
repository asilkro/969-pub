using System;
using System.IO;

namespace Silkroski_C969.Models
{
    public class Log
    {
        private static readonly DirectoryInfo currentDirectoryInfo = new DirectoryInfo(".");

        private static readonly string loggingPath = currentDirectoryInfo + "\\AppLog.txt";

        public static void LogMessage(string message)
        {
            if (!File.Exists(loggingPath)) // Create a file to write to if one doesn't exist
            {
                var file = File.Create(loggingPath);
            }

            using (var writer = File.AppendText(loggingPath)) // Write messages to log
            {
                writer.WriteLine(message + "at " + DateTime.Now + ".\n");
            }
        }
    }
}