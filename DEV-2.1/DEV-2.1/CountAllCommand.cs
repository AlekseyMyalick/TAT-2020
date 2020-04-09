using System;

namespace DEV_2._1
{
    class CountAllCommand : ICommand
    {
        public void Execute()
        {
            CarData.GetInstance().CountAll();
        }
    }
}
