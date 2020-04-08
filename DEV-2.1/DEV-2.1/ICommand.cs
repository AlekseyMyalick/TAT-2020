using System;

namespace DEV_2._1
{
    interface ICommand
    {
        void Execute();
        void Undo();
    }
}
