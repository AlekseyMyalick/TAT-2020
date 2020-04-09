using System;

namespace DEV_2._1
{
    class CountTypesCommand : ICommand
    {
        public void Execute()
        {
            CarData.GetInstance().CountTypes();
        }
    }
}
