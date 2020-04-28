using System;

namespace DEV_2._1
{
    class ExitCommand : ICommand
    {
        public void Execute()
        {
            Environment.Exit(0);
        }
    }
}
