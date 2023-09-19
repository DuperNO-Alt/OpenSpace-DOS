namespace OpenSpace.Shell
{
    public abstract class ShellCommand
    {
        public ShellCommand(string n, string d)
        {
            commandInstructionName = n;
            commandDescription = d;
        }

        public string commandInstructionName { get; private set; }
        public string commandDescription { get; private set; }

        public abstract void Run(string[] args);
    }
}
