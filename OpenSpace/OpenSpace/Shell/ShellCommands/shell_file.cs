using System;
using System.Collections.Generic;
using System.IO;

namespace OpenSpace.Shell.ShellCommands
{
    public class shell_file : ShellCommand
    {
        public shell_file() : base("file", "File command") { }

        public override void Run(string[] args)
        {
            if (args.Length == 0)
            {
                for (int i = 0; i < Directory.GetDirectories(Kernel.currentDir).Length; i++)
                {
                    Console.WriteLine($"<Dir>-: {Directory.GetDirectories(Kernel.currentDir)[i]}");
                }
                for (int i = 0; i < Directory.GetFiles(Kernel.currentDir).Length; i++)
                {
                    Console.WriteLine($"<Files>-: {Directory.GetFiles(Kernel.currentDir)[i]}");
                }
            }
            
            if (args[0] == "-f" || args[0] == "--file")
            {
                File.Create(@$"{Kernel.currentDir}\{args[1]}");
            }
            else if (args[0] == "-d" || args[0] == "--dir")
            {
                Directory.CreateDirectory(@$"{Kernel.currentDir}\{args[1]}");
            }
        }
    }
}
