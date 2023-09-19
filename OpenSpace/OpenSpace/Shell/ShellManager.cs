using OpenSpace.Shell.ShellCommands;
using System;
using System.Collections.Generic;


namespace OpenSpace.Shell
{
    public class ShellManager
    {
        public List<ShellCommand> registeredShellCommand;
        private ShellHandle shellHandler;

        public ShellManager()
        {
            registeredShellCommand = new List<ShellCommand>()
            {
                new shell_Help(),
                new shell_file(),
            };
        }

        public void FilterInput(string s)
        {
            string[] seperate = s.Split(' ');
            string fixedCommand = seperate[0];

            List<string> argsAsList = new List<string>();

            for (int i = 0; i < seperate.Length; i++)
            {
                if (seperate[i] != fixedCommand)
                {
                    argsAsList.Add(seperate[i]);
                }
            }

            for (int i = 0; i < registeredShellCommand.Count; i++)
            {
                if (registeredShellCommand[i].commandInstructionName == fixedCommand)
                {
                    shellHandler.HandleException(i, argsAsList.ToArray());
                }
            }
        }
    }
}
