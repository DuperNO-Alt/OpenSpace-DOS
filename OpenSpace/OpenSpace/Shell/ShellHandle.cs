using System;
using System.Collections.Generic;
namespace OpenSpace.Shell
{
    public class ShellHandle
    {
        public void HandleException(int commandIndex, string[] args)
        {
            try
            {
                Kernel.cmdmgr.registeredShellCommand[commandIndex].Run(args);
            }
            catch(Exception e)
            {
                Log.Log.ShowLog($"{Kernel.cmdmgr.registeredShellCommand[commandIndex].commandInstructionName}: Error occured {e.Message}", Log.LogWarningLevel.Error);
            }
        }
    }
}
