using System;

namespace OpenSpace.Shell.ShellCommands
{
    public class shell_Help : ShellCommand
    {
        public shell_Help() : base("help", "Shows this text") { }

        public override void Run(string[] args)
        {
            for (int i = 0; i < Kernel.cmdmgr.registeredShellCommand.Count; i++)
            {
                Console.WriteLine($"{Kernel.cmdmgr.registeredShellCommand[i].commandDescription}\t{Kernel.cmdmgr.registeredShellCommand[i].commandInstructionName}");
            }
        }
    }
}
