using System;

namespace DEV_2._1
{
    class AveragePriceCommand : ICommand
    {
        public void Execute()
        {
            CarData.GetInstance().AveragePrice();
        }
    }
}
