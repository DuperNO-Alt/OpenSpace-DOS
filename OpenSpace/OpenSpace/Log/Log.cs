using System;
using System.IO;

namespace OpenSpace.Log
{
    public static class Log
    {
        public static void ShowLog(string title, LogWarningLevel warninglevel)
        {
            switch (warninglevel)
            {
                case LogWarningLevel.Information:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[Info] ");
                    Console.ResetColor();
                    Console.WriteLine(title);
                    Kernel.loglist.Add(new LogMessage()
                    {
                        messageString = $"[Info : {DateTime.Now.ToShortTimeString()}] {title}",
                        warningLevel = LogWarningLevel.Information,
                    });
                    break;
                case LogWarningLevel.Warning:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("[Warning] ");
                    Console.ResetColor();
                    Console.WriteLine(title);
                    Kernel.loglist.Add(new LogMessage()
                    {
                        messageString = $"[Warning : {DateTime.Now.ToShortTimeString()}] {title}",
                        warningLevel = LogWarningLevel.Warning,
                    });
                    break;
                case LogWarningLevel.Error:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[Error] ");
                    Console.ResetColor();
                    Console.WriteLine(title);
                    Kernel.loglist.Add(new LogMessage()
                    {
                        messageString = $"[Error : {DateTime.Now.ToShortTimeString()}] {title}",
                        warningLevel = LogWarningLevel.Error,
                    });
                    break;
            }
        }
    }
}
