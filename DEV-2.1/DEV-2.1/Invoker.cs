using System;

namespace DEV_2._1
{
    class Invoker
    {
        ICommand _command;

        public void SetCommand(ICommand command)
        {
            _command = command;
        }

        public void Run()
        {
            _command.Execute();
        }
    }
}
