using Cosmos.System.ExtendedASCII;
using Cosmos.System.FileSystem;
using Cosmos.System.FileSystem.VFS;
using OpenSpace.Shell;
using System;
using System.Collections.Generic;
using Sys = Cosmos.System;

namespace OpenSpace
{
    public class Kernel : Sys.Kernel
    {
        public static ShellManager cmdmgr;
        public static List<Log.LogMessage> loglist;

        public static CosmosVFS fs;

        public static string currentDir = @"0:\";


        protected override void BeforeRun()
        {
            Console.Clear();
            Console.OutputEncoding = CosmosEncodingProvider.Instance.GetEncoding(437);

            fs = new CosmosVFS();
            VFSManager.RegisterVFS(fs);
            cmdmgr = new ShellManager();
        }

        protected override void Run()
        {
            Console.Write("OpenSpace:-$ ");
            cmdmgr.FilterInput(Console.ReadLine());
        }
    }
}
